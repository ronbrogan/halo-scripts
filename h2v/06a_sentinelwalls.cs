namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\06a_sentinelwalls\\06a_sentinelwalls")]
    public partial class scnr_06a_sentinelwalls : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool debug;
        bool dialogue;
        bool g_play_cinematics;
        int g_sleep_lower_bound;
        int g_sleep_upper_bound;
        int g_emitter_delay;
        bool g_cons_open_ins;
        bool g_enc_insertion;
        bool g_hall_a;
        bool g_conduit_a;
        bool g_hall_b;
        bool g_plug_launch;
        bool g_plug_landing;
        bool g_hall_c;
        bool g_ledge_a;
        bool g_conduit_b;
        bool g_ledge_b;
        bool g_ledge_c;
        bool g_qz_initial;
        bool g_cov_defense;
        bool g_music_06a_03;
        bool g_music_06a_04;
        bool g_music_06a_05;
        bool g_music_06a_06;
        bool g_music_06a_07;
        bool g_music_06a_08;
        bool g_music_06a_09;
        bool g_music_06a_10;
        bool g_plug_ride_enforcer;
        bool g_hall_b_sen_dialogue;
        bool g_enforcer;
        bool g_final_lock;
        bool g_flip_switch;
        int dialogue_pause;
        bool g_qz_cov_camp_progress;
        bool g_sc_cov_camp_done;
        bool g_piston_control;
        int piston_open_time;
        bool g_pussy_grunt;
        bool g_insertion_spawn;
        bool g_insertion_wave;
        int g_insertion_counter;
        int g_insertion_index;
        int g_insertion_limit;
        bool g_hall_a_loops;
        bool g_hall_a_wave;
        int g_hall_a_em_count;
        int g_hall_a_em_index;
        int g_hall_a_sen_limit;
        bool g_cond_a_front;
        bool g_cond_a_back;
        bool g_cond_a_wave;
        int g_cond_a_count;
        int g_cond_a_index;
        int g_cond_a_limit;
        int g_cond_a_bk_count;
        int g_cond_a_bk_limit;
        bool g_cond_a_continue;
        bool g_hall_b_loops;
        bool g_hall_b_wave;
        int g_hall_b_em_count;
        int g_hall_b_em_index;
        int g_hall_b_sen_limit;
        bool g_plug_launch_loops;
        bool g_plug_launch_wave;
        int g_plug_launch_count;
        int g_plug_launch_index;
        int g_plug_launch_limit;
        bool g_plug_launch_em_heroic;
        bool g_plug_move;
        bool g_lower_shield;
        bool g_plugholder_progress;
        int g_plug_holder_wave_count;
        int g_plug_holder_wave_limit;
        bool g_plug_holder_loops;
        bool g_plug_holder_wave;
        int g_plug_holder_count;
        int g_plug_holder_index;
        int g_plug_holder_limit;
        bool g_plug_holder_bk_loops;
        bool g_plug_holder_bk_wave;
        int g_plug_holder_bk_count;
        int g_plug_holder_bk_index;
        int g_plug_holder_bk_limit;
        bool g_plugholder_bk_spawn;
        int g_plugholder_bk_flood_count;
        int g_plugholder_bk_flood_limit;
        bool g_plugholder_bk_a;
        bool g_plugholder_bk_b;
        int g_hall_c_flood_count;
        int g_hall_c_flood_index;
        int g_ledge_a_player_loc;
        bool g_ledge_a_spawn;
        bool g_ledge_a_loops;
        bool g_ledge_a_wave;
        int g_ledge_a_sen_limit;
        int g_ledge_a_count;
        int g_ledge_a_index;
        int cond_b_locator;
        bool cond_b_flood_a_spawn;
        bool cond_b_flood_b_spawn;
        bool cond_b_flood_c_spawn;
        int cond_b_flood_count;
        int cond_b_flood_limit;
        bool ledge_c_spawn;
        int ledge_c_infec_count;
        int ledge_c_infec_limit;
        bool g_ledge_c_phantom_start;
        bool g_ledge_c_phantom_1;
        bool g_mortar_fire;
        bool g_qz_ini_cave;
        bool g_qz_cov_def_spawn;
        int g_qz_cov_def_limit;
        int g_qz_cov_def_count;
        int g_cov_def_flood_advance;
        bool g_qz_phantom;
        public scnr_06a_sentinelwalls(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.debug = true;
            this.dialogue = true;
            this.g_play_cinematics = true;
            this.g_sleep_lower_bound = 60;
            this.g_sleep_upper_bound = 80;
            this.g_emitter_delay = 180;
            this.g_cons_open_ins = false;
            this.g_enc_insertion = false;
            this.g_hall_a = false;
            this.g_conduit_a = false;
            this.g_hall_b = false;
            this.g_plug_launch = false;
            this.g_plug_landing = false;
            this.g_hall_c = false;
            this.g_ledge_a = false;
            this.g_conduit_b = false;
            this.g_ledge_b = false;
            this.g_ledge_c = false;
            this.g_qz_initial = false;
            this.g_cov_defense = false;
            this.g_music_06a_03 = false;
            this.g_music_06a_04 = false;
            this.g_music_06a_05 = false;
            this.g_music_06a_06 = false;
            this.g_music_06a_07 = false;
            this.g_music_06a_08 = true;
            this.g_music_06a_09 = false;
            this.g_music_06a_10 = true;
            this.g_plug_ride_enforcer = false;
            this.g_hall_b_sen_dialogue = false;
            this.g_enforcer = false;
            this.g_final_lock = false;
            this.g_flip_switch = false;
            this.dialogue_pause = 7;
            this.g_qz_cov_camp_progress = false;
            this.g_sc_cov_camp_done = false;
            this.g_piston_control = false;
            this.piston_open_time = 150;
            this.g_pussy_grunt = false;
            this.g_insertion_spawn = false;
            this.g_insertion_wave = false;
            this.g_insertion_counter = 0;
            this.g_insertion_index = 0;
            this.g_insertion_limit = 0;
            this.g_hall_a_loops = false;
            this.g_hall_a_wave = false;
            this.g_hall_a_em_count = 0;
            this.g_hall_a_em_index = 0;
            this.g_hall_a_sen_limit = 0;
            this.g_cond_a_front = false;
            this.g_cond_a_back = false;
            this.g_cond_a_wave = false;
            this.g_cond_a_count = 0;
            this.g_cond_a_index = 0;
            this.g_cond_a_limit = 0;
            this.g_cond_a_bk_count = 0;
            this.g_cond_a_bk_limit = 0;
            this.g_cond_a_continue = false;
            this.g_hall_b_loops = false;
            this.g_hall_b_wave = false;
            this.g_hall_b_em_count = 0;
            this.g_hall_b_em_index = 0;
            this.g_hall_b_sen_limit = 0;
            this.g_plug_launch_loops = false;
            this.g_plug_launch_wave = false;
            this.g_plug_launch_count = 0;
            this.g_plug_launch_index = 0;
            this.g_plug_launch_limit = 0;
            this.g_plug_launch_em_heroic = false;
            this.g_plug_move = false;
            this.g_lower_shield = false;
            this.g_plugholder_progress = false;
            this.g_plug_holder_wave_count = 0;
            this.g_plug_holder_wave_limit = 0;
            this.g_plug_holder_loops = false;
            this.g_plug_holder_wave = false;
            this.g_plug_holder_count = 0;
            this.g_plug_holder_index = 0;
            this.g_plug_holder_limit = 0;
            this.g_plug_holder_bk_loops = false;
            this.g_plug_holder_bk_wave = false;
            this.g_plug_holder_bk_count = 0;
            this.g_plug_holder_bk_index = 0;
            this.g_plug_holder_bk_limit = 0;
            this.g_plugholder_bk_spawn = false;
            this.g_plugholder_bk_flood_count = 0;
            this.g_plugholder_bk_flood_limit = 0;
            this.g_plugholder_bk_a = false;
            this.g_plugholder_bk_b = false;
            this.g_hall_c_flood_count = 0;
            this.g_hall_c_flood_index = 20;
            this.g_ledge_a_player_loc = 0;
            this.g_ledge_a_spawn = false;
            this.g_ledge_a_loops = false;
            this.g_ledge_a_wave = false;
            this.g_ledge_a_sen_limit = 0;
            this.g_ledge_a_count = 0;
            this.g_ledge_a_index = 0;
            this.cond_b_locator = 0;
            this.cond_b_flood_a_spawn = false;
            this.cond_b_flood_b_spawn = false;
            this.cond_b_flood_c_spawn = false;
            this.cond_b_flood_count = 0;
            this.cond_b_flood_limit = 4;
            this.ledge_c_spawn = true;
            this.ledge_c_infec_count = 0;
            this.ledge_c_infec_limit = 3;
            this.g_ledge_c_phantom_start = false;
            this.g_ledge_c_phantom_1 = false;
            this.g_mortar_fire = false;
            this.g_qz_ini_cave = false;
            this.g_qz_cov_def_spawn = true;
            this.g_qz_cov_def_limit = 0;
            this.g_qz_cov_def_count = 0;
            this.g_cov_def_flood_advance = 2;
            this.g_qz_phantom = false;
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
        public async Task x06_01a_predict_stub()
        {
            wake(new ScriptMethodReference(x06_01a_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x06_01b_predict_stub()
        {
            wake(new ScriptMethodReference(x06_01b_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x06_02_predict_stub()
        {
            wake(new ScriptMethodReference(x06_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x06_03_predict_stub()
        {
            wake(new ScriptMethodReference(x06_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x06_04_predict_stub()
        {
            wake(new ScriptMethodReference(x06_04_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x06_05_predict_stub()
        {
            wake(new ScriptMethodReference(x06_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task _06_intro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_06_intro_01_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task _06_intro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_06_intro_02_predict));
        }

        [ScriptMethod(32, Lifecycle.CommandScript)]
        public async Task cs_brute_walk_01()
        {
            cs_movement_mode(this.ai_movement_patrol);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("brute_targets/p0"));
        }

        [ScriptMethod(33, Lifecycle.CommandScript)]
        public async Task cs_brute_walk_02()
        {
            cs_movement_mode(this.ai_movement_patrol);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("brute_targets/p1"));
        }

        [ScriptMethod(34, Lifecycle.CommandScript)]
        public async Task cs_elite_walk_01()
        {
            cs_movement_mode(this.ai_movement_patrol);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("elite_targets/p0"));
        }

        [ScriptMethod(35, Lifecycle.CommandScript)]
        public async Task cs_elite_walk_02()
        {
            cs_movement_mode(this.ai_movement_patrol);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("elite_targets/p1"));
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task exchange_of_hats()
        {
            ai_allegiance(covenant, prophet);
            await sleep(210);
            print("exchange of hats");
            ai_place(brutes_01.Squad);
            ai_place(brutes_02.Squad);
            ai_place(elites_01.Squad);
            ai_place(elites_02.Squad);
            cs_run_command_script(brutes_01.Squad, new ScriptMethodReference(cs_brute_walk_01));
            cs_run_command_script(brutes_02.Squad, new ScriptMethodReference(cs_brute_walk_02));
            cs_run_command_script(elites_01.Squad, new ScriptMethodReference(cs_elite_walk_01));
            cs_run_command_script(elites_02.Squad, new ScriptMethodReference(cs_elite_walk_02));
            time_code_reset();
            await sleep(188);
            ai_erase(brutes_01.Squad);
            ai_erase(brutes_02.Squad);
            ai_erase(elites_01.Squad);
            ai_erase(elites_02.Squad);
            object_destroy_containing("elite_hg_prop");
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task x06_score_01a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_01_mus", 3828810433U), default(IGameObject), 1F);
            print("x06 score 01a start");
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task x06_foley_01a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01a_fol", 3828875970U), default(IGameObject), 1F);
            print("x06 foley 01a start");
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task x06_supratitle_01()
        {
            await sleep(60);
            cinematic_set_title(cinematic_title0);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01a()
        {
            cinematic_lighting_set_primary_light(3F, 234F, 0.28F, 0.28F, 0.39F);
            cinematic_lighting_set_secondary_light(21F, 96F, 0.38F, 0.33F, 0.27F);
            cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(brute_03.Entity, true);
            object_uses_cinematic_lighting(elite_hg_01.Entity, true);
            object_uses_cinematic_lighting(elite_hg_02.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_01.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_02.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_03.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_04.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_05.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_06.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_07.Entity, true);
            object_uses_cinematic_lighting(elite_hg_prop_08.Entity, true);
            object_uses_cinematic_lighting(x06_helmet.Entity, true);
            object_uses_cinematic_lighting(x06_pike_01.Entity, true);
            object_uses_cinematic_lighting(x06_pike_02.Entity, true);
            object_uses_cinematic_lighting(x06_pike_03.Entity, true);
            object_uses_cinematic_lighting(ai_get_object(brutes_01.Squad), true);
            object_uses_cinematic_lighting(ai_get_object(brutes_02.Squad), true);
            object_uses_cinematic_lighting(ai_get_object(elites_01.Squad), true);
            object_uses_cinematic_lighting(ai_get_object(elites_02.Squad), true);
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task x06_01b_problem_actors()
        {
            print("create problem actors");
            object_create_anew(brute_01);
            object_create_anew(brute_hg_01);
            object_create_anew(brute_hg_02);
            object_create_anew(brute_hg_03);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_hg_01.Entity, true);
            object_cinematic_lod(brute_hg_02.Entity, true);
            object_cinematic_lod(brute_hg_03.Entity, true);
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task x06_01a_setup()
        {
            object_create_anew(dervish);
            object_create_anew(brute_02);
            object_create_anew(brute_03);
            object_create_anew(elite_hg_01);
            object_create_anew(elite_hg_02);
            object_create_anew_containing("elite_hg_prop");
            object_create_anew(x06_helmet);
            object_create_anew(x06_pike_01);
            object_create_anew(x06_pike_02);
            object_create_anew(x06_pike_03);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(brute_03.Entity, true);
            object_cinematic_lod(elite_hg_01.Entity, true);
            object_cinematic_lod(elite_hg_02.Entity, true);
            object_cinematic_lod(x06_helmet.Entity, true);
            object_cinematic_lod(x06_pike_01.Entity, true);
            object_cinematic_lod(x06_pike_02.Entity, true);
            object_cinematic_lod(x06_pike_03.Entity, true);
            wake(new ScriptMethodReference(x06_score_01a));
            wake(new ScriptMethodReference(x06_foley_01a));
            wake(new ScriptMethodReference(cinematic_lighting_scene_01a));
            wake(new ScriptMethodReference(x06_supratitle_01));
            wake(new ScriptMethodReference(exchange_of_hats));
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task x06_01a_cleanup()
        {
            object_destroy(elite_hg_01.Entity);
            object_destroy(elite_hg_02.Entity);
            object_destroy(brute_03.Entity);
            object_destroy(brute_04.Entity);
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task x06_scene_01a()
        {
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x06_01a_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_01_mus", 3828810433U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01a_fol", 3828875970U));
            await sleep(this.prediction_offset);
            await this.x06_01a_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3828941507U), "x06_01a", default(IUnit), anchor_flag_x06);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3829007044U), "dervish_01a", false, anchor_x06.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute02_01a", false, anchor_x06.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute03_01a", false, anchor_x06.Entity);
            custom_animation_relative(elite_hg_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "elite_guard1_01a", false, anchor_x06.Entity);
            custom_animation_relative(elite_hg_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "elite_guard2_01a", false, anchor_x06.Entity);
            scenery_animation_start_relative(x06_helmet.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\x06\\x06", 3829400266U), "helmet01_01a", anchor_x06.Entity);
            scenery_animation_start_relative(x06_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3829465803U), "pike01_01a", anchor_x06.Entity);
            print("cache block");
            await sleep(1);
            await cache_block_for_one_frame();
            fade_in(0F, 0F, 0F, 30);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x06_01b_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01b_fol", 3829531340U));
            await this.x06_01b_problem_actors();
            await sleep((short)camera_time());
            await this.x06_01a_cleanup();
        }

        [ScriptMethod(45, Lifecycle.CommandScript)]
        public async Task cs_elite_walk_03()
        {
            cs_movement_mode(this.ai_movement_patrol);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("elite_targets/p2"));
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task final_hg_walk()
        {
            ai_allegiance(covenant, prophet);
            await sleep(120);
            print("final honor-guards");
            ai_place(elites_03.Squad);
            cs_run_command_script(elites_03.Squad, new ScriptMethodReference(cs_elite_walk_03));
            object_uses_cinematic_lighting(ai_get_object(this.ai_current_actor), true);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x06_foley_01b()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01b_fol", 3829531340U), default(IGameObject), 1F);
            print("x06 foley 01b start");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task x06_01b_dof_1()
        {
            time_code_reset();
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(45);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0F, 1F, 0F, 0.5F, 1F);
            print("rack focus");
            time_code_reset();
            await sleep(98);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01b()
        {
            cinematic_lighting_set_primary_light(3F, 234F, 0.28F, 0.28F, 0.39F);
            cinematic_lighting_set_secondary_light(21F, 96F, 0.38F, 0.33F, 0.27F);
            cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_hg_01.Entity, true);
            object_uses_cinematic_lighting(brute_hg_02.Entity, true);
            object_uses_cinematic_lighting(brute_hg_03.Entity, true);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x06_texture_camera_01b_01()
        {
            time_code_reset();
            await sleep(143);
            print("start texture camera");
            object_create_anew(texture_camera);
            object_create_anew(texture_space);
            object_create_anew(texture_halo);
            object_cinematic_lod(texture_halo.Entity, true);
            object_uses_cinematic_lighting(texture_halo.Entity, true);
            texture_camera_set_object_marker(texture_camera.Entity, "primary_trigger", 40F);
            await sleep(156);
            texture_camera_off();
            print("stop texture camera");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task open_sanctum_door()
        {
            await sleep(176);
            print("open sanctum door");
            device_set_position(sanctum_door.Entity, 1F);
            object_destroy_containing("offending_column");
            print("destroy columns");
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task x06_01b_setup()
        {
            wake(new ScriptMethodReference(x06_foley_01b));
            wake(new ScriptMethodReference(final_hg_walk));
            wake(new ScriptMethodReference(x06_texture_camera_01b_01));
            wake(new ScriptMethodReference(open_sanctum_door));
            wake(new ScriptMethodReference(cinematic_lighting_scene_01b));
            wake(new ScriptMethodReference(x06_01b_dof_1));
        }

        [ScriptMethod(53, Lifecycle.Static)]
        public async Task x06_01b_cleanup()
        {
            ai_erase(elites_03.Squad);
            object_destroy(x06_helmet.Entity);
            object_destroy(brute_01.Entity);
            object_destroy(brute_02.Entity);
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task x06_scene_01b()
        {
            await this.x06_01b_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3828941507U), "x06_01b", default(IUnit), anchor_flag_x06);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3829007044U), "dervish_01b", false, anchor_x06.Entity);
            custom_animation_relative(brute_hg_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute01_01b", false, anchor_x06.Entity);
            custom_animation_relative(brute_hg_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute02_01b", false, anchor_x06.Entity);
            custom_animation_relative(brute_hg_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute03_01b", false, anchor_x06.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute04_01b", false, anchor_x06.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute05_01b", false, anchor_x06.Entity);
            scenery_animation_start_relative(x06_helmet.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\x06\\x06", 3829400266U), "helmet01_01b", anchor_x06.Entity);
            scenery_animation_start_relative(x06_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3829465803U), "pike01_01b", anchor_x06.Entity);
            scenery_animation_start_relative(x06_pike_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3829465803U), "pike02_01b", anchor_x06.Entity);
            scenery_animation_start_relative(x06_pike_03.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3829465803U), "pike03_01b", anchor_x06.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x06_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_02_fol", 3829596877U));
            await sleep((short)camera_time());
            await this.x06_01b_cleanup();
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task x06_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_02_fol", 3829596877U), default(IGameObject), 1F);
            print("x06 foley 02 start");
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task x06_0010_soc()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0010_soc", 3829662414U), default(IGameObject), 1F);
            cinematic_subtitle("x06_0010_soc", 3F);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x06_0020_pot()
        {
            await sleep(92);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0020_pot", 3829727951U), default(IGameObject), 1F);
            cinematic_subtitle("x06_0020_pot", 2F);
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x06_0030_soc()
        {
            await sleep(168);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0030_soc", 3829793488U), commander.Entity, 1F);
            cinematic_subtitle("x06_0030_soc", 5F);
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task x06_0040_pot()
        {
            await sleep(306);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0040_pot", 3829859025U), truth.Entity, 1F);
            cinematic_subtitle("x06_0040_pot", 2F);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task x06_0050_soc()
        {
            await sleep(371);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0050_soc", 3829924562U), commander.Entity, 1F);
            cinematic_subtitle("x06_0050_soc", 5F);
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x06_0060_pot()
        {
            await sleep(520);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0060_pot", 3829990099U), truth.Entity, 1F);
            cinematic_subtitle("x06_0060_pot", 8F);
            await sleep(110);
            unit_set_emotional_state(truth.Entity, "arrogant", 0.75F, 60);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x06_0070_soc()
        {
            await sleep(794);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0070_soc", 3830055636U), commander.Entity, 1F);
            cinematic_subtitle("x06_0070_soc", 3F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_02()
        {
            cinematic_lighting_set_primary_light(3F, 234F, 0.28F, 0.28F, 0.39F);
            cinematic_lighting_set_secondary_light(21F, 96F, 0.38F, 0.33F, 0.27F);
            cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            object_uses_cinematic_lighting(truth.Entity, true);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(commander.Entity, true);
            object_uses_cinematic_lighting(so_elite_01.Entity, true);
            object_uses_cinematic_lighting(so_elite_02.Entity, true);
            object_uses_cinematic_lighting(throne_truth.Entity, true);
            object_uses_cinematic_lighting(throne_mercy.Entity, true);
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task x06_texture_camera_02_01()
        {
            print("start texture camera");
            object_create_anew(texture_camera);
            object_create_anew(texture_space);
            object_create_anew(texture_halo);
            object_cinematic_lod(texture_halo.Entity, true);
            object_uses_cinematic_lighting(texture_halo.Entity, true);
            texture_camera_set_object_marker(texture_camera.Entity, "primary_trigger", 40F);
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task x06_02_setup()
        {
            object_create_anew(truth);
            object_create_anew(mercy);
            object_create_anew(commander);
            object_create_anew(so_elite_01);
            object_create_anew(so_elite_02);
            object_create_anew(throne_truth);
            object_create_anew(throne_mercy);
            object_cinematic_lod(truth.Entity, true);
            object_cinematic_lod(mercy.Entity, true);
            object_cinematic_lod(commander.Entity, true);
            object_cinematic_lod(so_elite_01.Entity, true);
            object_cinematic_lod(so_elite_02.Entity, true);
            object_cinematic_lod(throne_truth.Entity, true);
            object_cinematic_lod(throne_mercy.Entity, true);
            objects_attach(truth.Entity, "driver", throne_truth.Entity, "driver_cinematic");
            objects_attach(mercy.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            wake(new ScriptMethodReference(x06_foley_02));
            wake(new ScriptMethodReference(x06_0010_soc));
            wake(new ScriptMethodReference(x06_0020_pot));
            wake(new ScriptMethodReference(x06_0030_soc));
            wake(new ScriptMethodReference(x06_0040_pot));
            wake(new ScriptMethodReference(x06_0050_soc));
            wake(new ScriptMethodReference(x06_0060_pot));
            wake(new ScriptMethodReference(x06_0070_soc));
            wake(new ScriptMethodReference(cinematic_lighting_scene_02));
            wake(new ScriptMethodReference(x06_texture_camera_02_01));
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task x06_scene_02()
        {
            await this.x06_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3828941507U), "x06_02", default(IUnit), anchor_flag_x06);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3829007044U), "dervish_02", false, anchor_x06.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "truth_02", false, anchor_x06.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "mercy_02", false, anchor_x06.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "commander_02", false, anchor_x06.Entity);
            custom_animation_relative(so_elite_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "elite1_02", false, anchor_x06.Entity);
            custom_animation_relative(so_elite_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "elite2_02", false, anchor_x06.Entity);
            custom_animation_relative(brute_hg_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute01_02", false, anchor_x06.Entity);
            custom_animation_relative(brute_hg_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute02_02", false, anchor_x06.Entity);
            scenery_animation_start_relative(x06_pike_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3829465803U), "pike01_02", anchor_x06.Entity);
            scenery_animation_start_relative(x06_pike_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3829465803U), "pike02_02", anchor_x06.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x06_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_03_fol", 3830252247U));
            await sleep((short)camera_time());
            object_destroy_containing("x06_pike");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task x06_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_03_fol", 3830252247U), default(IGameObject), 1F);
            print("x06 foley 03 start");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x06_0080_pot()
        {
            await sleep(148);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0080_pot", 3830317784U), default(IGameObject), 1F);
            cinematic_subtitle("x06_0080_pot", 4F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x06_0090_pot()
        {
            await sleep(265);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0090_pot", 3830383321U), truth.Entity, 1F);
            cinematic_subtitle("x06_0090_pot", 5F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task x06_0100_pot()
        {
            await sleep(418);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0100_pot", 3830448858U), truth.Entity, 1F);
            cinematic_subtitle("x06_0100_pot", 6F);
            await sleep(78);
            unit_set_emotional_state(truth.Entity, "annoyed", 0.75F, 60);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task x06_0110_der()
        {
            await sleep(585);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0110_der", 3830514395U), dervish.Entity, 1F);
            cinematic_subtitle("x06_0110_der", 2F);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task x06_03_setup()
        {
            wake(new ScriptMethodReference(x06_foley_03));
            wake(new ScriptMethodReference(x06_0080_pot));
            wake(new ScriptMethodReference(x06_0090_pot));
            wake(new ScriptMethodReference(x06_0100_pot));
            wake(new ScriptMethodReference(x06_0110_der));
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task x06_03_cleanup()
        {
            object_destroy(commander.Entity);
            object_destroy_containing("brute_hg");
            object_destroy_containing("so_elite");
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task x06_scene_03()
        {
            await this.x06_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3828941507U), "x06_03", default(IUnit), anchor_flag_x06);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3829007044U), "dervish_03", false, anchor_x06.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "truth_03", false, anchor_x06.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "mercy_03", false, anchor_x06.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "commander_03", false, anchor_x06.Entity);
            custom_animation_relative(so_elite_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "elite1_03", false, anchor_x06.Entity);
            custom_animation_relative(so_elite_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3829269192U), "elite2_03", false, anchor_x06.Entity);
            custom_animation_relative(brute_hg_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute01_03", false, anchor_x06.Entity);
            custom_animation_relative(brute_hg_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3829138118U), "brute02_03", false, anchor_x06.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x06_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_04_mus", 3830579932U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_03_fol", 3830252247U));
            await sleep((short)camera_time());
            await this.x06_03_cleanup();
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x06_score_04()
        {
            await sleep(274);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_04_mus", 3830579932U), default(IGameObject), 1F);
            print("x06 score 04 start");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x06_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_04_fol", 3830645469U), default(IGameObject), 1F);
            print("x06 foley 04 start");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x06_0120_pot()
        {
            await sleep(15);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0120_pot", 3830711006U), truth.Entity, 1F);
            cinematic_subtitle("x06_0120_pot", 3F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x06_0130_pom()
        {
            await sleep(109);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0130_pom", 3830776543U), mercy.Entity, 1F);
            cinematic_subtitle("x06_0130_pom", 8F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task x06_0140_pot()
        {
            await sleep(346);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0140_pot", 3830842080U), truth.Entity, 1F);
            cinematic_subtitle("x06_0140_pot", 8F);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task x06_0150_pot()
        {
            await sleep(581);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0150_pot", 3830907617U), truth.Entity, 1F);
            cinematic_subtitle("x06_0150_pot", 5F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x06_0160_pom()
        {
            await sleep(715);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0160_pom", 3830973154U), mercy.Entity, 1F);
            cinematic_subtitle("x06_0160_pom", 9F);
            await sleep(150);
            unit_set_emotional_state(mercy.Entity, "asleep", 0.75F, 60);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x06_fov_01()
        {
            await sleep(576);
            camera_set_field_of_view(60F, 0);
            print("fov");
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x06_04_dof_1()
        {
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("dof");
            await sleep(103);
            cinematic_screen_effect_set_depth_of_field(0.8F, 0.5F, 0F, 1F, 0F, 0.5F, 1F);
            print("dof");
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x06_04_dof_2()
        {
            await sleep(343);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("dof");
            await sleep(82);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0F, 1F, 0F, 0.5F, 1F);
            print("dof");
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task unhide_dervish()
        {
            time_code_reset();
            await sleep(576);
            print("unhide dervish");
            object_hide(dervish.Entity, false);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task x06_04_setup()
        {
            wake(new ScriptMethodReference(x06_score_04));
            wake(new ScriptMethodReference(x06_foley_04));
            wake(new ScriptMethodReference(x06_0120_pot));
            wake(new ScriptMethodReference(x06_0130_pom));
            wake(new ScriptMethodReference(x06_0140_pot));
            wake(new ScriptMethodReference(x06_0150_pot));
            wake(new ScriptMethodReference(x06_0160_pom));
            object_hide(dervish.Entity, true);
            wake(new ScriptMethodReference(unhide_dervish));
            wake(new ScriptMethodReference(x06_fov_01));
            wake(new ScriptMethodReference(x06_04_dof_1));
            wake(new ScriptMethodReference(x06_04_dof_2));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task x06_scene_04()
        {
            await this.x06_04_setup();
            camera_set_field_of_view(30F, 0);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3828941507U), "x06_04", default(IUnit), anchor_flag_x06);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3829007044U), "dervish_04", false, anchor_x06.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "truth_04", false, anchor_x06.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "mercy_04", false, anchor_x06.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x06_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_05_fol", 3831038691U));
            await sleep((short)camera_time());
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x06_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_05_fol", 3831038691U), default(IGameObject), 1F);
            print("x06 foley 05 start");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x06_0170_pot()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0170_pot", 3831104228U), truth.Entity, 1F);
            cinematic_subtitle("x06_0170_pot", 9F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task x06_0180_pot()
        {
            await sleep(276);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0180_pot", 3831169765U), truth.Entity, 1F);
            cinematic_subtitle("x06_0180_pot", 3F);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x06_0190_pom()
        {
            await sleep(366);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0190_pom", 3831235302U), mercy.Entity, 1F);
            cinematic_subtitle("x06_0190_pom", 9F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x06_0200_pot()
        {
            await sleep(635);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0200_pot", 3831300839U), truth.Entity, 1F);
            cinematic_subtitle("x06_0200_pot", 5F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x06_0210_pot()
        {
            await sleep(780);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0210_pot", 3831366376U), truth.Entity, 1F);
            cinematic_subtitle("x06_0210_pot", 4F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task x06_0220_pom()
        {
            await sleep(889);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0220_pom", 3831431913U), mercy.Entity, 1F);
            cinematic_subtitle("x06_0220_pom", 3F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x06_0230_pot()
        {
            await sleep(956);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0230_pot", 3831497450U), truth.Entity, 1F);
            cinematic_subtitle("x06_0230_pot", 3F);
            unit_set_emotional_state(truth.Entity, "happy", 0.5F, 60);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x06_05_dof_1()
        {
            await sleep(488);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0.75F, 0.75F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(160);
            cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 1F, 0F, 0F, 0F);
            print("rack focus");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x06_05_dof_2()
        {
            await sleep(777);
            cinematic_screen_effect_set_depth_of_field(2F, 0F, 0.75F, 1F, 0.75F, 0F, 1F);
            print("rack focus");
            await sleep(173);
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x06_texture_camera_05_01()
        {
            time_code_reset();
            await sleep(279);
            print("stop texture camera");
            texture_camera_off();
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task monitor_sound()
        {
            await sleep(281);
            sound_class_set_gain("device", 1F, 60);
            print("monitor sound up");
        }

        [ScriptMethod(100, Lifecycle.Static)]
        public async Task x06_05_setup()
        {
            sound_class_set_gain("device", 0F, 0);
            object_create_anew(monitor);
            object_cinematic_lod(monitor.Entity, true);
            object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            object_uses_cinematic_lighting(monitor.Entity, true);
            object_create_anew(index_holo);
            wake(new ScriptMethodReference(x06_foley_05));
            wake(new ScriptMethodReference(x06_0170_pot));
            wake(new ScriptMethodReference(x06_0180_pot));
            wake(new ScriptMethodReference(x06_0190_pom));
            wake(new ScriptMethodReference(x06_0200_pot));
            wake(new ScriptMethodReference(x06_0210_pot));
            wake(new ScriptMethodReference(x06_0220_pom));
            wake(new ScriptMethodReference(x06_0230_pot));
            wake(new ScriptMethodReference(monitor_sound));
            wake(new ScriptMethodReference(x06_05_dof_1));
            wake(new ScriptMethodReference(x06_05_dof_2));
            wake(new ScriptMethodReference(x06_texture_camera_05_01));
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x06_05_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy_containing("truth");
            object_destroy_containing("mercy");
            object_destroy(monitor.Entity);
            object_destroy(index_holo.Entity);
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x06_scene_05()
        {
            camera_set_field_of_view(60F, 0);
            await this.x06_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3828941507U), "x06_05", default(IUnit), anchor_flag_x06);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3829007044U), "dervish_05", false, anchor_x06.Entity);
            custom_animation_relative(truth.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "truth_05", false, anchor_x06.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3830121173U), "mercy_05", false, anchor_x06.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\x06\\x06", 3831562987U), "monitor_05", false, anchor_x06.Entity);
            scenery_animation_start_relative(index_holo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_alone\\x06\\x06", 3831628524U), "index_alone_05", anchor_x06.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(0F, 0F, 0F, 15);
            await sleep(15);
            await this.x06_05_cleanup();
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task x06()
        {
            cinematic_enable_ambience_details(false);
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("high_8"));
            await sleep(1);
            await this.x06_scene_01a();
            await this.x06_scene_01b();
            await this.x06_scene_02();
            await this.x06_scene_03();
            await this.x06_scene_04();
            await this.x06_scene_05();
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task c06_intro_sound_scene1_01()
        {
            object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 0F);
            sound_class_set_gain("vehicle", 0F, 0);
            sound_class_set_gain("vehicle", 1F, 90);
            await sleep(90);
            sound_class_set_gain("vehicle", 0F, 90);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task c06_intro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_01_fol", 3831694061U), default(IGameObject), 1F);
            print("c06_intro foley 01 start");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task c06_1010_tar()
        {
            await sleep(144);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1010_tar", 3831759598U), default(IGameObject), 1F);
            cinematic_subtitle("c06_1010_tar", 1F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task c06_1020_tar()
        {
            await sleep(191);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1020_tar", 3831825135U), tartarus.Entity, 1F);
            cinematic_subtitle("c06_1020_tar", 2F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task c06_1030_tar()
        {
            await sleep(264);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1030_tar", 3831890672U), tartarus.Entity, 1F);
            cinematic_subtitle("c06_1030_tar", 3F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task c06_1040_der()
        {
            await sleep(337);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1040_der", 3831956209U), dervish.Entity, 1F);
            cinematic_subtitle("c06_1040_der", 4F);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task c06_1050_tar()
        {
            await sleep(463);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1050_tar", 3832021746U), default(IGameObject), 1F, "radio_covy_loop");
            cinematic_subtitle("c06_1050_tar", 1F);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task c06_1060_der()
        {
            await sleep(507);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1060_der", 3832087283U), dervish.Entity, 1F);
            cinematic_subtitle("c06_1060_der", 1F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task c06_1070_tar()
        {
            await sleep(550);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1070_tar", 3832152820U), tartarus.Entity, 1F);
            cinematic_subtitle("c06_1070_tar", 1F);
            await sleep(35);
            unit_set_emotional_state(tartarus.Entity, "inquisitive", 1F, 30);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task c06_1080_tar()
        {
            await sleep(593);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1080_tar", 3832218357U), tartarus.Entity, 1F);
            cinematic_subtitle("c06_1080_tar", 1F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task c06_1090_tar()
        {
            await sleep(623);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1090_tar", 3832283894U), default(IGameObject), 1F, "radio_covy_loop");
            cinematic_subtitle("c06_1090_tar", 1F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task c06_1100_der()
        {
            await sleep(670);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1100_der", 3832349431U), dervish.Entity, 1F);
            cinematic_subtitle("c06_1100_der", 3F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task c06_1110_tar()
        {
            await sleep(745);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1110_tar", 3832414968U), default(IGameObject), 1F, "radio_covy_out");
            cinematic_subtitle("c06_1110_tar", 3F);
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task camera_shake_01()
        {
            await sleep(188);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task cinematic_light_intro_scene_01()
        {
            cinematic_lighting_set_primary_light(-20F, 282F, 0.21F, 0.29F, 0.37F);
            cinematic_lighting_set_secondary_light(-59F, 306F, 0.34F, 0.58F, 0.65F);
            cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            rasterizer_bloom_override(false);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(brute_03.Entity, true);
            object_uses_cinematic_lighting(brute_04.Entity, true);
            object_uses_cinematic_lighting(phantom_01.Entity, true);
            object_uses_cinematic_lighting(phantom_int.Entity, true);
            object_uses_cinematic_lighting(carbine.Entity, true);
            object_uses_cinematic_lighting(delta_halo.Entity, true);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task cinematic_light_phantom_int()
        {
            await sleep(186);
            print("light phantom");
            cinematic_lighting_set_primary_light(-90F, 0F, 0.23F, 0.29F, 0.53F);
            cinematic_lighting_set_secondary_light(-90F, 192F, 0.16F, 0.1F, 0.19F);
            cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task c06_problem_actors_01()
        {
            print("problem actors");
            object_create_anew(delta_halo);
            object_create_anew(matte_substance);
            object_create_anew(matte_stardust);
            object_cinematic_lod(delta_halo.Entity, true);
            object_cinematic_visibility(delta_halo.Entity, true);
        }

        [ScriptMethod(121, Lifecycle.Static)]
        public async Task c06_intro_01_setup()
        {
            object_create_anew(dervish);
            object_create_anew(tartarus);
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_create_anew(brute_03);
            object_create_anew(brute_04);
            object_create_anew(phantom_01);
            object_create_anew(phantom_int);
            object_create_anew(carbine);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(brute_03.Entity, true);
            object_cinematic_lod(brute_04.Entity, true);
            object_cinematic_lod(phantom_01.Entity, true);
            object_cinematic_lod(phantom_int.Entity, true);
            objects_attach(dervish.Entity, "right_hand_elite", carbine.Entity, "");
            wake(new ScriptMethodReference(c06_intro_sound_scene1_01));
            wake(new ScriptMethodReference(c06_intro_foley_01));
            wake(new ScriptMethodReference(c06_1010_tar));
            wake(new ScriptMethodReference(c06_1020_tar));
            wake(new ScriptMethodReference(c06_1030_tar));
            wake(new ScriptMethodReference(c06_1040_der));
            wake(new ScriptMethodReference(c06_1050_tar));
            wake(new ScriptMethodReference(c06_1060_der));
            wake(new ScriptMethodReference(c06_1070_tar));
            wake(new ScriptMethodReference(c06_1080_tar));
            wake(new ScriptMethodReference(c06_1090_tar));
            wake(new ScriptMethodReference(c06_1100_der));
            wake(new ScriptMethodReference(c06_1110_tar));
            wake(new ScriptMethodReference(camera_shake_01));
            wake(new ScriptMethodReference(cinematic_light_intro_scene_01));
            wake(new ScriptMethodReference(cinematic_light_phantom_int));
        }

        [ScriptMethod(122, Lifecycle.Static)]
        public async Task c06_intro_01_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(tartarus.Entity);
            object_destroy_containing("brute");
            object_destroy(phantom_int.Entity);
            object_destroy(delta_halo.Entity);
            object_destroy(matte_substance.Entity);
            object_destroy(matte_stardust.Entity);
            player_effect_stop(0F);
        }

        [ScriptMethod(123, Lifecycle.Static)]
        public async Task c06_intro_scene_01()
        {
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._06_intro_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_01_fol", 3831694061U));
            wake(new ScriptMethodReference(c06_problem_actors_01));
            await sleep(this.prediction_offset);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3832480505U), "06_intro_01", default(IUnit), anchor_flag_intro);
            await this.c06_intro_01_setup();
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intro\\06_intro", 3832546042U), "dervish_01", false, anchor_intro.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3832611579U), "tartarus_01", false, anchor_intro.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3832611579U), "brute01_01", false, anchor_intro.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3832611579U), "brute02_01", false, anchor_intro.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3832611579U), "brute03_01", false, anchor_intro.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3832611579U), "brute04_01", false, anchor_intro.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intro\\06_intro", 3832677116U), "phantom_01", false, anchor_intro.Entity);
            scenery_animation_start_relative(phantom_int.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\06_intro\\06_intro", 3832742653U), "phantom_int_01", anchor_intro.Entity);
            scenery_animation_start_relative(delta_halo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\06_intro\\06_intro", 3832808190U), "halo_01", anchor_intro.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\06_intro\\06_intro", 3832873727U), "substance_01", anchor_intro.Entity);
            scenery_animation_start_relative(matte_stardust.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\06_intro\\06_intro", 3832939264U), "stardust_01", anchor_intro.Entity);
            await sleep(15);
            fade_in(0F, 0F, 0F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._06_intro_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_02_fol", 3833004801U));
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - 5));
            cinematic_screen_effect_set_crossfade(2F);
            print("crossfade");
            await sleep((short)camera_time());
            await this.c06_intro_01_cleanup();
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task c06_intro_sound_scene2_01()
        {
            sound_class_set_gain("vehicle", 0F, 0);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 0F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 0F);
            sound_class_set_gain("vehicle", 1F, 50);
            await sleep(50);
            sound_class_set_gain("vehicle", 0F, 90);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task c06_intro_sound_scene2_02()
        {
            await sleep(160);
            sound_class_set_gain("vehicle", 1F, 30);
            await sleep(30);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 0F, 120F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 0F, 120F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 0F, 120F);
            await sleep(60);
            object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 90F);
            object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 90F);
            object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 90F);
            sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task c06_intro_sound_scene2_03()
        {
            await sleep(480);
            sound_class_set_gain("vehicle", 1F, 60);
            object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 0F, 0F);
            object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 0F, 0F);
            object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 1F, 60F);
            object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 1F, 60F);
            await sleep(110);
            object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 0F, 60F);
            object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 0F, 60F);
            await sleep(160);
            object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 1F, 60F);
            object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 1F, 60F);
            await sleep(60);
            sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task c06_intro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_02_fol", 3833004801U), default(IGameObject), 1F);
            print("c06_intro foley 02 start");
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task c06_1120_tar()
        {
            await sleep(782);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1120_tar", 3833070338U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c06_1120_tar", 2F);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c06_1130_tar()
        {
            await sleep(842);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1130_tar", 3833135875U), tartarus.Entity, 1F, "radio_default_out");
            cinematic_subtitle("c06_1130_tar", 2F);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task arbiter_fires()
        {
            await sleep(642);
            print("carbine shot");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\covenant_carbine\\firing", 3806790001U), carbine.Entity, "primary_trigger");
            await sleep(22);
            print("carbine shot");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\covenant_carbine\\firing", 3806790001U), carbine.Entity, "primary_trigger");
            await sleep(24);
            print("carbine shot");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\covenant_carbine\\firing", 3806790001U), carbine.Entity, "primary_trigger");
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task phantom_fires()
        {
            time_code_reset();
            await sleep(690);
            object_create_anew(intro_turret_base);
            object_create_anew(intro_turret);
            objects_attach(intro_turret_base.Entity, "primary_trigger", intro_turret.Entity, "");
            print("turret fires");
            weapon_hold_trigger(GetReference<IWeaponReference>("intro_turret"), 0, true);
            await sleep(30);
            weapon_hold_trigger(GetReference<IWeaponReference>("intro_turret"), 0, false);
            objects_detach(intro_turret_base.Entity, intro_turret.Entity);
            object_destroy(intro_turret.Entity);
            object_destroy(intro_turret_base.Entity);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task c06_intro_predict_ledge_01()
        {
            await sleep(145);
            print("predict: camera, dervish");
            object_type_predict_high(GetTag<BaseTag>("objects\\characters\\dervish\\dervish", 3833201412U));
            camera_predict_resources_at_frame(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3832480505U), "06_intro_02", default(IUnit), anchor_flag_intro, 165);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task c06_intro_predict_ledge_02()
        {
            await sleep(224);
            print("predict: camera, dervish, sentinel major");
            object_type_predict_high(GetTag<BaseTag>("objects\\characters\\dervish\\dervish", 3833201412U));
            object_type_predict_high(GetTag<BaseTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851027476U));
            camera_predict_resources_at_frame(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3832480505U), "06_intro_02", default(IUnit), anchor_flag_intro, 244);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task create_dervish_again()
        {
            await sleep(305);
            print("problem actor");
            object_create_anew(dervish);
            object_create_anew(carbine);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(carbine.Entity, true);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(carbine.Entity, true);
            objects_attach(dervish.Entity, "right_hand_elite", carbine.Entity, "");
            object_hide(dervish.Entity, true);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task dervish_unhide()
        {
            await sleep(330);
            object_hide(dervish.Entity, false);
            print("dervish unhide");
        }

        [ScriptMethod(136, Lifecycle.Static)]
        public async Task c06_intro_02_setup()
        {
            object_create_anew(phantom_02);
            object_create_anew(intro_sen_maj);
            object_create_anew(matte_mount_doom);
            object_cinematic_lod(phantom_02.Entity, true);
            object_cinematic_lod(intro_sen_maj.Entity, true);
            object_uses_cinematic_lighting(phantom_02.Entity, true);
            object_uses_cinematic_lighting(intro_sen_maj.Entity, true);
            wake(new ScriptMethodReference(c06_intro_sound_scene2_01));
            wake(new ScriptMethodReference(c06_intro_sound_scene2_02));
            wake(new ScriptMethodReference(c06_intro_sound_scene2_03));
            wake(new ScriptMethodReference(c06_intro_foley_02));
            wake(new ScriptMethodReference(c06_1120_tar));
            wake(new ScriptMethodReference(c06_1130_tar));
            wake(new ScriptMethodReference(dervish_unhide));
            wake(new ScriptMethodReference(create_dervish_again));
            wake(new ScriptMethodReference(arbiter_fires));
            wake(new ScriptMethodReference(phantom_fires));
            wake(new ScriptMethodReference(c06_intro_predict_ledge_01));
            wake(new ScriptMethodReference(c06_intro_predict_ledge_02));
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task c06_intro_02_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(intro_sen_maj.Entity);
            object_destroy_containing("phantom");
            object_destroy(matte_mount_doom.Entity);
        }

        [ScriptMethod(138, Lifecycle.Static)]
        public async Task c06_intro_scene_02()
        {
            await this.c06_intro_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3832480505U), "06_intro_02", default(IUnit), anchor_flag_intro);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intro\\06_intro", 3832546042U), "dervish_02", false, anchor_intro.Entity);
            custom_animation_relative(intro_sen_maj.Entity, GetTag<AnimationGraphTag>("objects\\characters\\sentinel_enforcer\\06_intro\\06_intro", 3867739411U), "sentinel_major_02", false, anchor_intro.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intro\\06_intro", 3832677116U), "phantom01_02", false, anchor_intro.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intro\\06_intro", 3832677116U), "phantom02_02", false, anchor_intro.Entity);
            scenery_animation_start_relative(matte_mount_doom.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\mount_doom\\06_intro\\06_intro", 3867804948U), "mount_doom_02", anchor_intro.Entity);
            time_code_reset();
            await sleep(315);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intro\\06_intro", 3832546042U), "dervish_02", false, anchor_intro.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c06_intro_02_cleanup();
            await sleep(30);
        }

        [ScriptMethod(139, Lifecycle.Static)]
        public async Task c06_intro()
        {
            switch_bsp_by_name(GetReference<IBsp>("sentinelhq_1"));
            await sleep(5);
            await this.c06_intro_scene_01();
            await this.c06_intro_scene_02();
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task difficulty_settings()
        {
            if (await this.difficulty_heroic())
            {
                this.g_sleep_lower_bound = 45;
                this.g_sleep_upper_bound = 65;
                this.g_emitter_delay = 120;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_sleep_lower_bound = 25;
                this.g_sleep_upper_bound = 45;
                this.g_emitter_delay = 60;
            }
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task test_locks()
        {
            device_set_position_immediate(plug.Entity, 1F);
            device_set_position(plug_lock_a.Entity, 1F);
            device_set_position(plug_lock_b.Entity, 1F);
            device_set_position(plug_lock_c.Entity, 1F);
            device_set_position(plug_lock_d.Entity, 1F);
            device_set_position(plug_lock_e.Entity, 1F);
            device_set_position(plug_lock_f.Entity, 1F);
            device_set_position(plug_door_b.Entity, 1F);
        }

        [ScriptMethod(142, Lifecycle.CommandScript)]
        public async Task die()
        {
            ai_kill_silent(this.ai_current_squad);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task ice_cream_mythic()
        {
            object_create(ice_cream_head);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4182841137U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4182841137U)), 5);
            if (this.debug)
            {
                print("you're going to get fat!!!!! or dead...");
            }

            if (this.debug)
            {
                print("because now everyone is mythic!!!!");
            }

            ice_cream_flavor_stock(12);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task chapter_silence()
        {
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task chapter_remorse()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task chapter_war()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_3);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task objective_lower_set()
        {
            await sleep(30);
            print("new objective set:");
            print("lower the containment-shield.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task objective_lower_clear()
        {
            print("objective complete:");
            print("lower the containment-shield.");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task objective_lower_specific_set()
        {
            await sleep(30);
            print("new objective set:");
            print("power-up the four absorbers to lower the containment-shield.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task objective_lower_specific_clear()
        {
            print("objective complete:");
            print("power-up the four absorbers to lower the containment-shield.");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task objective_floodwall_set()
        {
            await sleep(30);
            print("new objective set:");
            print("make your way through the flood-infested wall.");
            objectives_show_up_to(2);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task objective_floodwall_clear()
        {
            print("objective complete:");
            print("make your way through the flood-infested wall.");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task objective_rendezvous_set()
        {
            await sleep(30);
            print("new objective set:");
            print("rendezvous with your allies in the covenant camp.");
            objectives_show_up_to(3);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task objective_rendezvous_clear()
        {
            print("objective complete:");
            print("rendezvous with your allies in the covenant camp.");
            objectives_finish_up_to(3);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task music_06a_01()
        {
            await sleep_until(async () => volume_test_objects(tv_insertion_tube, players()), 1);
            if (this.debug)
            {
                print("start music 06a_01");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_01", 4266859552U), default(IGameObject), 1F);
            await sleep(30);
            if (this.debug)
            {
                print("start music 06a_02");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_02", 4267056163U), default(IGameObject), 1F);
            await sleep_until(async () => volume_test_objects(tv_ins_slide_bottom, players()));
            if (this.debug)
            {
                print("stop music 06a_01");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_01", 4266859552U));
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task music_06a_03()
        {
            await sleep_until(async () => this.g_music_06a_03, 1);
            if (this.debug)
            {
                print("start music 06a_03");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_03", 4267187237U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06a_03));
            if (this.debug)
            {
                print("stop music 06a_03");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_03", 4267187237U));
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task music_06a_04()
        {
            await sleep_until(async () => this.g_music_06a_04);
            if (this.debug)
            {
                print("start music 06a_04");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_04", 4267383848U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06a_04));
            if (this.debug)
            {
                print("stop music 06a_04");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_04", 4267383848U));
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task music_06a_05()
        {
            await sleep_until(async () => this.g_music_06a_05);
            if (this.debug)
            {
                print("start music 06a_05");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_05", 4267580459U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06a_05));
            if (this.debug)
            {
                print("stop music 06a_05");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_05", 4267580459U));
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task music_06a_06()
        {
            await sleep_until(async () => this.g_music_06a_06);
            if (this.debug)
            {
                print("start music 06a_06");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_06", 4267777070U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06a_06));
            if (this.debug)
            {
                print("stop music 06a_06");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_06", 4267777070U));
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task music_06a_07()
        {
            await sleep_until(async () => this.g_music_06a_07);
            if (this.debug)
            {
                print("start music 06a_07");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_07", 4267973681U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06a_07));
            if (this.debug)
            {
                print("stop music 06a_07");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_07", 4267973681U));
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task music_06a_08()
        {
            await sleep_until(async () => volume_test_objects(tv_slide_a, players()));
            if (this.debug)
            {
                print("start music 06a_08");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_08", 4268039218U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06a_08));
            if (this.debug)
            {
                print("stop music 06a_08");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_08", 4268039218U));
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task music_06a_09()
        {
            await sleep_until(async () => volume_test_objects(tv_ledge_c_fr, players()), 5);
            if (this.debug)
            {
                print("start music 06a_09");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_09", 4268235829U), default(IGameObject), 1F);
            this.g_music_06a_08 = false;
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task music_06a_10()
        {
            await sleep_until(async () => volume_test_objects(tv_music_06a_10, players()));
            if (this.debug)
            {
                print("start music 06a_10");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_10", 4268366903U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06a_10));
            if (this.debug)
            {
                print("stop music 06a_10");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_10", 4268366903U));
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task sc_cond_cov()
        {
            await sleep(60);
            cs_switch("grunt");
            if (this.dialogue)
            {
                print("grunt: arbiter our savior!");
            }

            await sleep(ai_play_line_at_player(cond_a_cov.Squad, "0400"));
            await sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                print("grunt: stupid jackal, say thank you!");
            }

            await sleep(ai_play_line_at_player(cond_a_cov.Squad, "0410"));
            await sleep(this.dialogue_pause);
            cs_switch("jackal");
            if (this.dialogue)
            {
                print("jackal: hissss.....");
            }

            await sleep(ai_play_line_at_player(cond_a_cov.Squad, "0420"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task ai_sc_cond_a_cov()
        {
            await sleep_until(async () => ai_scene("sc_cond_a_cov", new ScriptMethodReference(sc_cond_cov), cond_a_cov.Squad));
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task sc_tartarus_reminder()
        {
            game_save_cancel();
            if (this.dialogue)
            {
                print("tartarus: you're getting close to one of the shield-generators�");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0430"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("tartarus: many of my brutes have fallen attempting to take it down.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0440"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("tartarus: let's see if you fare better.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0450"));
            await sleep(this.dialogue_pause);
            game_save_no_timeout();
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task sc_fleeing_grunts()
        {
            if (this.dialogue)
            {
                print("grunt: big, scary thing! run away!");
            }

            await sleep(ai_play_line_at_player(this.ai_current_actor, "0460"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("grunt: please! no make go back!");
            }

            await sleep(ai_play_line_at_player(this.ai_current_actor, "0470"));
            await sleep(this.dialogue_pause);
            await sleep_until(async () => this.g_hall_b_sen_dialogue);
            await sleep(90);
            if (this.dialogue)
            {
                print("grunt: (shriek) more bad things!");
            }

            await sleep(ai_play_line_at_player(this.ai_current_actor, "0480"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("grunt: arbiter! protect! protect!");
            }

            await sleep(ai_play_line_at_player(this.ai_current_actor, "0490"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task ai_sc_hall_b_grunts()
        {
            await sleep_until(async () => (bool)ai_trigger_test("scene_trigger_4", hall_b_cov.Squad));
            cs_run_command_script(hall_b_cov.wimp, new ScriptMethodReference(sc_fleeing_grunts));
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task sc_enforcer()
        {
            await sleep_until(async () => this.g_enforcer);
            game_save_cancel();
            await sleep(60);
            if (this.dialogue)
            {
                print("tartarus: it's useless to attack an enforcer from the front.");
            }

            if (this.dialogue)
            {
                print("tartarus: especially when their shields are up.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0500"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("tartarus: stay in the shadows. wait 'til it loses interest�");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0510"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("tartarus: then strike the beast when it it's back is turned!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0520"));
            await sleep(this.dialogue_pause);
            game_save_no_timeout();
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task sc_plug_launch()
        {
            game_save_cancel();
            this.g_music_06a_03 = false;
            if (this.dialogue)
            {
                print("tartarus: you've reached the shield's power-source, arbiter.");
            }

            if (this.dialogue)
            {
                print("tartarus: overload the locks holding it in place!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0010"));
            await sleep(this.dialogue_pause);
            this.g_enforcer = true;
            await sleep_until(async () => this.g_final_lock);
            if (this.dialogue)
            {
                print("tartarus: one more, arbiter!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0030"));
            await sleep(this.dialogue_pause);
            await sleep_until(async () => this.g_flip_switch);
            await sleep(60);
            if (this.dialogue)
            {
                print("tartarus: you've released the power source!");
            }

            if (this.dialogue)
            {
                print("now find a way to remove it from its cradle.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0040"));
            game_save_no_timeout();
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task sc_plug_ride()
        {
            if (this.dialogue)
            {
                print("tartarus: our path to the library is clear.");
            }

            if (this.dialogue)
            {
                print("tartarus: i'll pick you up on the ledge ahead.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0050"));
            await sleep(this.dialogue_pause);
            await sleep_until(async () => this.g_plug_ride_enforcer);
            if (this.dialogue)
            {
                print("tartarus: (angry growl) blasted machines!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0070"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("tartarus: make your own way through the wall, arbiter!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0080"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task sc_marines_a()
        {
            if (this.dialogue)
            {
                print("marine: negative, ma'am. they aren't covenant!");
            }

            await sleep(ai_play_line_on_object(conduit_b_sound.Entity, "0090"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("sarg: cover that doorway!");
            }

            await sleep(ai_play_line_on_object(conduit_b_sound.Entity, "0100"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task sc_marines_b()
        {
            if (this.dialogue)
            {
                print("marine: proceed to the objective! we'll hold out as long as we can!");
            }

            await sleep(ai_play_line_on_object(hall_c_sound.Entity, "0110"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("marine: aaa! get it off of me!");
            }

            await sleep(ai_play_line_on_object(hall_c_sound.Entity, "0120"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("sarg: suppressive fire! suppressive fi -");
            }

            await sleep(ai_play_line_on_object(hall_c_sound.Entity, "0130"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(174, Lifecycle.CommandScript)]
        public async Task cs_sc_qz_ini()
        {
            if (this.dialogue)
            {
                print("spec-ops: forerunners be praised! the arbiter!");
            }

            await sleep(ai_play_line_at_player(qz_ini_ins_pods.Squad, "0530"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: this quarantine-zone has been compromised!");
            }

            if (this.dialogue)
            {
                print("spec-ops: we must do what we can against the flood!");
            }

            await sleep(ai_play_line_at_player(qz_ini_ins_pods.Squad, "0540"));
            await sleep((short)(this.dialogue_pause * 4));
            if (this.dialogue)
            {
                print("spec-ops: our commander has landed further in.");
            }

            if (this.dialogue)
            {
                print("spec-ops: let us join him!");
            }

            await sleep(ai_play_line_at_player(qz_ini_ins_pods.Squad, "0550"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task sc_qz_initial()
        {
            await sleep_until(async () => ai_scene("sc_qz_ini", new ScriptMethodReference(cs_sc_qz_ini), qz_ini_ins_pods.Squad));
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task cs_cov_camp_elites()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_nearest(GetReference<ISpatialPoint>("qz_cov_def"));
            cs_face_player(true);
            await sleep_until(async () => this.g_sc_cov_camp_done);
        }

        [ScriptMethod(177, Lifecycle.CommandScript)]
        public async Task cs_cov_camp_soc()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("qz_cov_def/soc"));
            cs_face_player(true);
            await sleep_until(async () => this.g_sc_cov_camp_done);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task sc_qz_cov_camp()
        {
            ai_vehicle_exit(qz_cov_def_cov.Squad);
            ai_vehicle_exit(qz_cov_def_soc.Squad);
            await sleep(30);
            cs_run_command_script(qz_cov_def_cov.Squad, new ScriptMethodReference(cs_cov_camp_elites));
            cs_run_command_script(qz_cov_def_soc.Squad, new ScriptMethodReference(cs_cov_camp_soc));
            await sleep_until(async () => volume_test_objects(tv_qz_cov_def_hill, players()), 30, 450);
            await sleep(15);
            if (this.dialogue)
            {
                print("commander: arbiter! what are you doing here?");
            }

            await sleep(ai_play_line(qz_cov_def_soc.Squad, "0170"));
            await sleep(this.dialogue_pause);
            this.g_qz_cov_camp_progress = true;
            await sleep(90);
            if (this.dialogue)
            {
                print("spec-ops: the flood is upon us!");
            }

            await sleep(ai_play_line(qz_cov_def_cov.Squad, "0190"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("commander: we must hold this camp until reinforcements arrive!");
            }

            await sleep(ai_play_line(qz_cov_def_soc.Squad, "0200"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: may our footsteps never fade!");
            }

            await sleep(ai_play_line(qz_cov_def_cov.Squad, "0210"));
            await sleep(this.dialogue_pause);
            await sleep(30);
            this.g_sc_cov_camp_done = true;
            game_save_no_timeout();
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task attach_absorbers_1()
        {
            objects_attach(piston_ins.Entity, "absorber_a", absorber_ins.Entity, "absorber_a");
            objects_attach(piston_a.Entity, "absorber_a", absorber_a.Entity, "absorber_a");
            objects_attach(piston_b.Entity, "absorber_a", absorber_b.Entity, "absorber_a");
            objects_attach(piston_c.Entity, "absorber_a", absorber_c.Entity, "absorber_a");
            objects_attach(piston_d.Entity, "absorber_a", absorber_d.Entity, "absorber_a");
            objects_attach(piston_plug_landing.Entity, "absorber_a", absorber_plug_landing.Entity, "absorber_a");
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task attach_absorbers_1b()
        {
            objects_attach(piston_e.Entity, "absorber_a", absorber_e.Entity, "absorber_a");
            objects_attach(piston_f.Entity, "absorber_a", absorber_f.Entity, "absorber_a");
            objects_attach(piston_g.Entity, "absorber_a", absorber_g.Entity, "absorber_a");
            objects_attach(piston_h.Entity, "absorber_a", absorber_h.Entity, "absorber_a");
            objects_attach(piston_i.Entity, "absorber_a", absorber_i.Entity, "absorber_a");
            objects_attach(piston_ledge_b.Entity, "absorber_a", absorber_ledge_b.Entity, "absorber_a");
            objects_attach(piston_ledge_c.Entity, "absorber_a", absorber_ledge_c.Entity, "absorber_a");
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task attach_controls_1()
        {
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                object_destroy_containing("switch_a");
                object_destroy_containing("switch_b");
                object_destroy_containing("switch_c");
                object_destroy_containing("switch_d");
            }

            objects_attach(piston_ins.Entity, "absorber_a", ins_switch_a.Entity, "switch");
            objects_attach(piston_ins.Entity, "absorber_b", ins_switch_b.Entity, "switch");
            objects_attach(piston_ins.Entity, "absorber_c", ins_switch_c.Entity, "switch");
            objects_attach(piston_ins.Entity, "absorber_d", ins_switch_d.Entity, "switch");
            objects_attach(piston_a.Entity, "absorber_a", a_switch_a.Entity, "switch");
            objects_attach(piston_a.Entity, "absorber_b", a_switch_b.Entity, "switch");
            objects_attach(piston_a.Entity, "absorber_c", a_switch_c.Entity, "switch");
            objects_attach(piston_a.Entity, "absorber_d", a_switch_d.Entity, "switch");
            objects_attach(piston_b.Entity, "absorber_a", b_switch_a.Entity, "switch");
            objects_attach(piston_b.Entity, "absorber_b", b_switch_b.Entity, "switch");
            objects_attach(piston_b.Entity, "absorber_c", b_switch_c.Entity, "switch");
            objects_attach(piston_b.Entity, "absorber_d", b_switch_d.Entity, "switch");
            objects_attach(piston_c.Entity, "absorber_a", c_switch_a.Entity, "switch");
            objects_attach(piston_c.Entity, "absorber_b", c_switch_b.Entity, "switch");
            objects_attach(piston_c.Entity, "absorber_c", c_switch_c.Entity, "switch");
            objects_attach(piston_c.Entity, "absorber_d", c_switch_d.Entity, "switch");
            objects_attach(piston_d.Entity, "absorber_a", d_switch_a.Entity, "switch");
            objects_attach(piston_d.Entity, "absorber_b", d_switch_b.Entity, "switch");
            objects_attach(piston_d.Entity, "absorber_c", d_switch_c.Entity, "switch");
            objects_attach(piston_d.Entity, "absorber_d", d_switch_d.Entity, "switch");
            objects_attach(piston_plug_landing.Entity, "absorber_a", plug_landing_switch_a.Entity, "switch");
            objects_attach(piston_plug_landing.Entity, "absorber_b", plug_landing_switch_b.Entity, "switch");
            objects_attach(piston_plug_landing.Entity, "absorber_c", plug_landing_switch_c.Entity, "switch");
            objects_attach(piston_plug_landing.Entity, "absorber_d", plug_landing_switch_d.Entity, "switch");
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task attach_controls_1b()
        {
            objects_attach(piston_e.Entity, "absorber_a", e_switch_a.Entity, "switch");
            objects_attach(piston_e.Entity, "absorber_b", e_switch_b.Entity, "switch");
            objects_attach(piston_e.Entity, "absorber_c", e_switch_c.Entity, "switch");
            objects_attach(piston_e.Entity, "absorber_d", e_switch_d.Entity, "switch");
            objects_attach(piston_f.Entity, "absorber_a", f_switch_a.Entity, "switch");
            objects_attach(piston_f.Entity, "absorber_b", f_switch_b.Entity, "switch");
            objects_attach(piston_f.Entity, "absorber_c", f_switch_c.Entity, "switch");
            objects_attach(piston_f.Entity, "absorber_d", f_switch_d.Entity, "switch");
            objects_attach(piston_g.Entity, "absorber_a", g_switch_a.Entity, "switch");
            objects_attach(piston_g.Entity, "absorber_b", g_switch_b.Entity, "switch");
            objects_attach(piston_g.Entity, "absorber_c", g_switch_c.Entity, "switch");
            objects_attach(piston_g.Entity, "absorber_d", g_switch_d.Entity, "switch");
            objects_attach(piston_h.Entity, "absorber_a", h_switch_a.Entity, "switch");
            objects_attach(piston_h.Entity, "absorber_b", h_switch_b.Entity, "switch");
            objects_attach(piston_h.Entity, "absorber_c", h_switch_c.Entity, "switch");
            objects_attach(piston_h.Entity, "absorber_d", h_switch_d.Entity, "switch");
            objects_attach(piston_i.Entity, "absorber_a", i_switch_a.Entity, "switch");
            objects_attach(piston_i.Entity, "absorber_b", i_switch_b.Entity, "switch");
            objects_attach(piston_i.Entity, "absorber_c", i_switch_c.Entity, "switch");
            objects_attach(piston_i.Entity, "absorber_d", i_switch_d.Entity, "switch");
            objects_attach(piston_ledge_b.Entity, "absorber_a", ledge_b_switch_a.Entity, "switch");
            objects_attach(piston_ledge_b.Entity, "absorber_b", ledge_b_switch_b.Entity, "switch");
            objects_attach(piston_ledge_b.Entity, "absorber_c", ledge_b_switch_c.Entity, "switch");
            objects_attach(piston_ledge_b.Entity, "absorber_d", ledge_b_switch_d.Entity, "switch");
            objects_attach(piston_ledge_c.Entity, "absorber_a", ledge_c_switch_a.Entity, "switch");
            objects_attach(piston_ledge_c.Entity, "absorber_b", ledge_c_switch_b.Entity, "switch");
            objects_attach(piston_ledge_c.Entity, "absorber_c", ledge_c_switch_c.Entity, "switch");
            objects_attach(piston_ledge_c.Entity, "absorber_d", ledge_c_switch_d.Entity, "switch");
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task open_piston_ins()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_ins) > 0F || object_get_shield(absorber_ins.Entity) <= 0F, 1);
                device_set_position(piston_ins.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_ins.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_ins, players())));
                device_set_position(piston_ins.Entity, 0F);
                device_group_set_immediate(group_ins, 0F);
                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task open_piston_a()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_a) > 0F || object_get_shield(absorber_a.Entity) <= 0F, 1);
                device_set_position(piston_a.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_a.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_a, players())));
                device_set_position(piston_a.Entity, 0F);
                device_group_set_immediate(group_a, 0F);
                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task open_piston_b()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_b) > 0F || object_get_shield(absorber_b.Entity) <= 0F, 1);
                device_set_position(piston_b.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_b.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_b, players())));
                device_set_position(piston_b.Entity, 0F);
                device_group_set_immediate(group_b, 0F);
                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task open_piston_c()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_c) > 0F || object_get_shield(absorber_c.Entity) <= 0F, 1);
                device_set_position(piston_c.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_c.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_c, players())));
                device_set_position(piston_c.Entity, 0F);
                device_group_set_immediate(group_c, 0F);
                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task open_piston_d()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_d) > 0F || object_get_shield(absorber_d.Entity) <= 0F, 1);
                device_set_position(piston_d.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_d.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_d, players())));
                device_set_position(piston_d.Entity, 0F);
                device_group_set_immediate(group_d, 0F);
                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task open_piston_plug_landing()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_plug_landing) > 0F || object_get_shield(absorber_plug_landing.Entity) <= 0F, 1);
                device_set_position(piston_plug_landing.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_plug_landing.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_plug_landing, players())));
                device_set_position(piston_plug_landing.Entity, 0F);
                device_group_set_immediate(group_plug_landing, 0F);
                return (short)structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task open_piston_e()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_e) > 0F || object_get_shield(absorber_e.Entity) <= 0F, 1);
                device_set_position(piston_e.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_e.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_e, players())));
                device_set_position(piston_e.Entity, 0F);
                device_group_set_immediate(group_e, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task open_piston_f()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_f) > 0F || object_get_shield(absorber_f.Entity) <= 0F, 1);
                device_set_position(piston_f.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_f.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_f, players())));
                device_set_position(piston_f.Entity, 0F);
                device_group_set_immediate(group_f, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task open_piston_g()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_g) > 0F || object_get_shield(absorber_g.Entity) <= 0F, 1);
                device_set_position(piston_g.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_g.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_g, players())));
                device_set_position(piston_g.Entity, 0F);
                device_group_set_immediate(group_g, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task open_piston_h()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_h) > 0F || object_get_shield(absorber_h.Entity) <= 0F, 1);
                device_set_position(piston_h.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_h.Entity);
                if (this.g_music_06a_07)
                {
                    this.g_music_06a_07 = false;
                }

                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_h, players())));
                device_set_position(piston_h.Entity, 0F);
                device_group_set_immediate(group_h, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task open_piston_i()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_i) > 0F || object_get_shield(absorber_i.Entity) <= 0F, 1);
                device_set_position(piston_i.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_i.Entity);
                if (this.g_music_06a_06)
                {
                    this.g_music_06a_06 = false;
                }

                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_i, players())));
                device_set_position(piston_i.Entity, 0F);
                device_group_set_immediate(group_i, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task open_piston_ledge_b()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_ledge_b) > 0F || object_get_shield(absorber_ledge_b.Entity) <= 0F, 1);
                device_set_position(piston_ledge_b.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_ledge_b.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_ledge_b, players())));
                device_set_position(piston_ledge_b.Entity, 0F);
                device_group_set_immediate(group_ledge_b, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task open_piston_ledge_c()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => device_group_get(group_ledge_c) > 0F || object_get_shield(absorber_ledge_c.Entity) <= 0F, 1);
                device_set_position(piston_ledge_c.Entity, 1F);
                damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), absorber_ledge_c.Entity);
                await sleep(this.piston_open_time);
                await sleep_until(async () => !(volume_test_objects_all(tv_piston_ledge_c, players())));
                device_set_position(piston_ledge_c.Entity, 0F);
                device_group_set_immediate(group_ledge_c, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task piston_control()
        {
            wake(new ScriptMethodReference(attach_absorbers_1));
            wake(new ScriptMethodReference(attach_controls_1));
            wake(new ScriptMethodReference(open_piston_ins));
            wake(new ScriptMethodReference(open_piston_a));
            wake(new ScriptMethodReference(open_piston_b));
            wake(new ScriptMethodReference(open_piston_c));
            wake(new ScriptMethodReference(open_piston_d));
            wake(new ScriptMethodReference(open_piston_plug_landing));
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            if (this.debug)
            {
                print("creating bsp 1 objects...");
            }

            object_create_anew_containing("bsp1_weapon");
            object_create_anew_containing("bsp1_equip");
            wake(new ScriptMethodReference(attach_absorbers_1b));
            wake(new ScriptMethodReference(attach_controls_1b));
            sleep_forever(new ScriptMethodReference(open_piston_ins));
            sleep_forever(new ScriptMethodReference(open_piston_a));
            sleep_forever(new ScriptMethodReference(open_piston_b));
            sleep_forever(new ScriptMethodReference(open_piston_c));
            sleep_forever(new ScriptMethodReference(open_piston_d));
            sleep_forever(new ScriptMethodReference(open_piston_plug_landing));
            wake(new ScriptMethodReference(open_piston_e));
            wake(new ScriptMethodReference(open_piston_f));
            wake(new ScriptMethodReference(open_piston_g));
            wake(new ScriptMethodReference(open_piston_h));
            wake(new ScriptMethodReference(open_piston_i));
            wake(new ScriptMethodReference(open_piston_ledge_b));
            wake(new ScriptMethodReference(open_piston_ledge_c));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            object_destroy_containing("bsp1_body");
            object_destroy_containing("bsp1_weapon");
            object_destroy_containing("bsp1_equip");
            sleep_forever(new ScriptMethodReference(open_piston_e));
            sleep_forever(new ScriptMethodReference(open_piston_f));
            sleep_forever(new ScriptMethodReference(open_piston_g));
            sleep_forever(new ScriptMethodReference(open_piston_h));
            sleep_forever(new ScriptMethodReference(open_piston_i));
            sleep_forever(new ScriptMethodReference(open_piston_ledge_b));
            sleep_forever(new ScriptMethodReference(open_piston_ledge_c));
        }

        [ScriptMethod(197, Lifecycle.CommandScript)]
        public async Task cs_pussy_grunt_abort()
        {
            await sleep(1);
            object_can_take_damage(ai_actors(pussy_grunt2.Squad));
            ai_set_orders(pussy_grunt2.Squad, hall_a_cov);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task pussy_grunt_abort()
        {
            await sleep_until(async () => volume_test_objects(tv_ins_slide_bottom, ai_actors(pussy_grunt2.Squad)));
            cs_run_command_script(pussy_grunt2.Squad, new ScriptMethodReference(cs_pussy_grunt_abort));
        }

        [ScriptMethod(199, Lifecycle.CommandScript)]
        public async Task pussy_grunt_down()
        {
            wake(new ScriptMethodReference(pussy_grunt_abort));
            cs_enable_dialogue(true);
            cs_enable_pathfinding_failsafe(true);
            cs_movement_mode(2);
            cs_crouch(false);
            object_cannot_take_damage(ai_actors(pussy_grunt2.Squad));
            await sleep_until(async () => device_get_position(piston_ins.Entity) >= 0.5F, 10);
            cs_go_to_and_face(GetReference<ISpatialPoint>("insertion/grunt_stand"), GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            cs_jump(0F, 1F);
            await sleep(15);
            cs_move_in_direction(0F, 5F, 0F);
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task pussy_grunt_shoot()
        {
            cs_movement_mode(2);
            cs_crouch(false);
            cs_go_to_and_face(GetReference<ISpatialPoint>("insertion/grunt_stand"), GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            await sleep(15);
            cs_shoot_point(true, GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            await sleep_until(async () => object_get_shield(absorber_ins.Entity) <= 0F, 5);
            await sleep(15);
            cs_shoot_point(false, GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            cs_run_command_script(pussy_grunt2.Squad, new ScriptMethodReference(pussy_grunt_down));
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task pussy_grunt()
        {
            if ((short)ai_combat_status(insertion_sen.Squad) >= this.ai_combat_status_active)
            {
                await sleep_until(async () => object_get_health(ins_em_a.Entity) <= 0F && object_get_health(ins_em_b.Entity) <= 0F && object_get_health(ins_em_c.Entity) <= 0F);
            }

            await sleep(45);
            if (device_get_position(piston_ins.Entity) == 0F)
            {
                cs_run_command_script(pussy_grunt2.Squad, new ScriptMethodReference(pussy_grunt_shoot));
            }

            await sleep_until(async () => volume_test_objects(tv_insertion_tube, players()), 5);
            cs_run_command_script(pussy_grunt2.Squad, new ScriptMethodReference(pussy_grunt_down));
        }

        [ScriptMethod(202, Lifecycle.CommandScript)]
        public async Task cs_pussy_grunt()
        {
            cs_movement_mode(3);
            cs_crouch(true);
            ai_disregard(ai_actors(constructors), true);
            await sleep_until(async () => volume_test_objects(tv_pussy_grunt, players()) || (float)ai_strength(pussy_grunt2.Squad) < 1F);
            cs_movement_mode(2);
            cs_crouch(false);
            wake(new ScriptMethodReference(pussy_grunt));
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task pussy_grunt_reminder()
        {
            await sleep((short)(30 * 60 * 5));
            if (!(this.g_pussy_grunt))
            {
                await sleep_until(async () => volume_test_objects(tv_ins_bk, players()));
                if ((short)ai_combat_status(insertion_sen.Squad) >= this.ai_combat_status_active)
                {
                    await sleep_until(async () => object_get_health(ins_em_a.Entity) <= 0F && object_get_health(ins_em_b.Entity) <= 0F && object_get_health(ins_em_c.Entity) <= 0F);
                }

                await sleep(45);
                if (device_get_position(piston_ins.Entity) == 1F)
                {
                    cs_run_command_script(pussy_grunt2.Squad, new ScriptMethodReference(pussy_grunt_shoot));
                }
            }
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_miniaturize()
        {
            object_set_scale(ai_get_object(this.ai_current_actor), 0.3F, 0);
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_big()
        {
            cs_enable_moving(true);
            await sleep((short)(30 * 10));
            object_set_scale(ai_get_object(this.ai_current_actor), 2.1F, 0);
        }

        [ScriptMethod(206, Lifecycle.CommandScript)]
        public async Task cs_ins_weld_a()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("insertion/p3"), GetReference<ISpatialPoint>("insertion/p4"));
            cs_shoot_point(true, GetReference<ISpatialPoint>("insertion/p4"));
            await sleep((short)random_range(300, 450));
            cs_shoot_point(false, GetReference<ISpatialPoint>("insertion/p4"));
        }

        [ScriptMethod(207, Lifecycle.CommandScript)]
        public async Task cs_ins_weld_b()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("insertion/p5"), GetReference<ISpatialPoint>("insertion/p6"));
            cs_shoot_point(true, GetReference<ISpatialPoint>("insertion/p6"));
            await sleep((short)random_range(150, 300));
            cs_shoot_point(false, GetReference<ISpatialPoint>("insertion/p6"));
        }

        [ScriptMethod(208, Lifecycle.CommandScript)]
        public async Task cs_ins_weld_c()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("insertion/p7"), GetReference<ISpatialPoint>("insertion/p8"));
            cs_shoot_point(true, GetReference<ISpatialPoint>("insertion/p8"));
            await sleep((short)random_range(45, 60));
            cs_shoot_point(false, GetReference<ISpatialPoint>("insertion/p8"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("insertion/p9"), GetReference<ISpatialPoint>("insertion/p10"));
            cs_shoot_point(true, GetReference<ISpatialPoint>("insertion/p10"));
            await sleep((short)random_range(45, 60));
            cs_shoot_point(false, GetReference<ISpatialPoint>("insertion/p10"));
        }

        [ScriptMethod(209, Lifecycle.CommandScript)]
        public async Task cs_ins_shoot_absorber_slide()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("insertion/shoot_slide"), GetReference<ISpatialPoint>("insertion/target_slide"), 0.25F);
            await sleep(15);
            cs_shoot_point(true, GetReference<ISpatialPoint>("insertion/target_slide"));
            await sleep_until(async () => object_get_shield(absorber_a.Entity) <= 0F, 5);
            await sleep(15);
            cs_shoot_point(false, GetReference<ISpatialPoint>("insertion/target_slide"));
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task ins_open_door_slide()
        {
            ai_place(ins_con_slide.Squad);
            if ((float)ai_strength(ins_cons) == 1F)
            {
                ai_set_orders(ins_con_mid.Squad, ins_sen_slide);
                ai_set_orders(ins_con_bk.Squad, ins_sen_slide);
            }

            await sleep_until(async () => volume_test_objects(tv_ins_slide_bottom, players()) && objects_can_see_object(players(), piston_a.Entity, 180F));
            cs_run_command_script(ins_con_slide.shooter, new ScriptMethodReference(cs_ins_shoot_absorber_slide));
        }

        [ScriptMethod(211, Lifecycle.CommandScript)]
        public async Task cs_ins_runaway()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to(GetReference<ISpatialPoint>("insertion/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("insertion/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("insertion/p2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(212, Lifecycle.CommandScript)]
        public async Task cs_ins_shoot_absorber()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("insertion/shoot_ins"), GetReference<ISpatialPoint>("insertion/target_ins"), 0.25F);
            await sleep(15);
            cs_shoot_point(true, GetReference<ISpatialPoint>("insertion/target_ins"));
            await sleep_until(async () => object_get_shield(absorber_ins.Entity) <= 0F, 5);
            wake(new ScriptMethodReference(ins_open_door_slide));
            await sleep(15);
            cs_shoot_point(false, GetReference<ISpatialPoint>("insertion/target_ins"));
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task ins_open_door()
        {
            await sleep_until(async () => volume_test_objects(tv_ins_bk, players()) && objects_can_see_object(players(), piston_ins.Entity, 180F));
            if ((float)ai_strength(ins_cons) == 1F)
            {
                cs_run_command_script(ins_con_bk.shooter, new ScriptMethodReference(cs_ins_shoot_absorber));
                this.g_cons_open_ins = true;
            }
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task ai_insertion_emitters()
        {
            if (await this.difficulty_normal())
            {
                this.g_insertion_limit = 0;
                this.g_insertion_index = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_insertion_limit = 0;
                this.g_insertion_index = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_insertion_limit = 1;
                this.g_insertion_index = 3;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(insertion_sentinels) <= this.g_insertion_limit);
                if (this.g_insertion_spawn)
                {
                    sleep_forever();
                }

                await sleep(this.g_emitter_delay);
                this.g_insertion_counter = 0;
                this.g_insertion_wave = false;
                await sleep_until(async () =>
                {
                    ai_place(insertion_sen.Squad, 1);
                    this.g_insertion_counter = (short)(this.g_insertion_counter + 1);
                    if (this.g_insertion_counter == this.g_insertion_index)
                    {
                        this.g_insertion_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_insertion_wave;
                });
                return this.g_insertion_spawn;
            });
        }

        [ScriptMethod(215, Lifecycle.Static)]
        public async Task ai_hall_a_em_c()
        {
            if (this.debug)
            {
                print("c");
            }

            ai_place(hall_a_sen.c);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(216, Lifecycle.Static)]
        public async Task ai_hall_a_em_d()
        {
            if (this.debug)
            {
                print("d");
            }

            ai_place(hall_a_sen.d);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task ai_hall_a_em_g()
        {
            if (this.debug)
            {
                print("g");
            }

            ai_place(hall_a_sen.g);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task ai_hall_a_em_h()
        {
            if (this.debug)
            {
                print("h");
            }

            ai_place(hall_a_sen.h);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task ai_hall_a_emitters()
        {
            if (await this.difficulty_normal())
            {
                this.g_hall_a_sen_limit = 0;
                this.g_hall_a_em_index = 2;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_hall_a_sen_limit = 0;
                this.g_hall_a_em_index = 3;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_hall_a_sen_limit = 1;
                this.g_hall_a_em_index = 4;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(hall_a_sentinels) <= this.g_hall_a_sen_limit);
                if (this.g_hall_a_loops)
                {
                    sleep_forever();
                }

                await sleep(this.g_emitter_delay);
                this.g_hall_a_em_count = 0;
                this.g_hall_a_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(hall_a_em_c.Entity)) && object_get_health(hall_a_em_c.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_c.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_c.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_c();
                    }
                    else if (!(unit_is_emitting(hall_a_em_d.Entity)) && object_get_health(hall_a_em_d.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_d.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_d.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_d();
                    }
                    else if (!(unit_is_emitting(hall_a_em_g.Entity)) && object_get_health(hall_a_em_g.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_g.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_g.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_g();
                    }
                    else if (!(unit_is_emitting(hall_a_em_h.Entity)) && object_get_health(hall_a_em_h.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_h.Entity) > 0F && objects_distance_to_object(players(), hall_a_em_h.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_h();
                    }
                    else if (true)
                    {
                        ai_place(hall_a_sen.Squad);
                        this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
                    }

                    if (this.g_hall_a_em_count == this.g_hall_a_em_index)
                    {
                        this.g_hall_a_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_hall_a_wave;
                });
                return this.g_hall_a_loops;
            });
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task ai_hall_a_const()
        {
            ai_place(hall_a_con_ini.Squad);
            ai_place(hall_a_con_bk.Squad);
            await sleep(30);
            await sleep_until(async () => (float)ai_strength(hall_a_cons) < 0.8F);
            await sleep(30);
            if (this.debug)
            {
                print("hall a constructors running away");
            }

            ai_set_orders(constructors, hall_a_runway);
        }

        [ScriptMethod(221, Lifecycle.Static)]
        public async Task ai_cond_a_em_a()
        {
            if (this.debug)
            {
                print("a");
            }

            ai_place(cond_a_sen_a.a);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(222, Lifecycle.Static)]
        public async Task ai_cond_a_em_c()
        {
            if (this.debug)
            {
                print("c");
            }

            ai_place(cond_a_sen_a.c);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(223, Lifecycle.Static)]
        public async Task ai_cond_a_em_e()
        {
            if (this.debug)
            {
                print("e");
            }

            ai_place(cond_a_sen_a.e);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task ai_cond_a_em_f()
        {
            if (this.debug)
            {
                print("f");
            }

            ai_place(cond_a_sen_a.f);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(225, Lifecycle.Static)]
        public async Task ai_cond_a_em_g()
        {
            if (this.debug)
            {
                print("g");
            }

            ai_place(cond_a_sen_a.g);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(226, Lifecycle.Static)]
        public async Task ai_cond_a_em_h()
        {
            if (this.debug)
            {
                print("h");
            }

            ai_place(cond_a_sen_a.h);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task ai_cond_a_em_i()
        {
            if (this.debug)
            {
                print("i");
            }

            ai_place(cond_a_sen_b.i);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(228, Lifecycle.Static)]
        public async Task ai_cond_a_em_j()
        {
            if (this.debug)
            {
                print("j");
            }

            ai_place(cond_a_sen_b.j);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task ai_cond_a_em_k()
        {
            if (this.debug)
            {
                print("k");
            }

            ai_place(cond_a_sen_b.k);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(230, Lifecycle.Static)]
        public async Task ai_cond_a_em_l()
        {
            if (this.debug)
            {
                print("l");
            }

            ai_place(cond_a_sen_b.l);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task ai_cond_a_em_m()
        {
            if (this.debug)
            {
                print("m");
            }

            ai_place(cond_a_sen_b.m);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task ai_cond_a_em_n()
        {
            if (this.debug)
            {
                print("n");
            }

            ai_place(cond_a_sen_b.n);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task ai_cond_a_em_o()
        {
            if (this.debug)
            {
                print("o");
            }

            ai_place(cond_a_sen_b.o);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task ai_cond_a_emitters_fr()
        {
            if (await this.difficulty_normal())
            {
                this.g_cond_a_limit = 0;
                this.g_cond_a_index = 2;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_cond_a_limit = 0;
                this.g_cond_a_index = 3;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_cond_a_limit = 1;
                this.g_cond_a_index = 4;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cond_a_sentinels) <= this.g_cond_a_limit);
                if (await this.difficulty_legendary())
                {
                    await sleep(this.g_emitter_delay);
                }
                else
                {
                    await sleep((short)(this.g_emitter_delay * 2));
                }

                if (this.g_cond_a_front)
                {
                    sleep_forever();
                }

                this.g_cond_a_count = 0;
                this.g_cond_a_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(cond_a_em_c.Entity)) && object_get_health(cond_a_em_c.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_c.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_c();
                    }
                    else if (!(unit_is_emitting(cond_a_em_f.Entity)) && object_get_health(cond_a_em_f.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_f.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_f();
                    }
                    else if (!(unit_is_emitting(cond_a_em_g.Entity)) && object_get_health(cond_a_em_g.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_g.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_g();
                    }
                    else if (!(unit_is_emitting(cond_a_em_e.Entity)) && object_get_health(cond_a_em_e.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_e.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_e();
                    }
                    else if (!(unit_is_emitting(cond_a_em_h.Entity)) && object_get_health(cond_a_em_h.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_h.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_h();
                    }
                    else if (!(unit_is_emitting(cond_a_em_a.Entity)) && object_get_health(cond_a_em_a.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_a.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_a();
                    }
                    else if (true)
                    {
                        ai_place(cond_a_sen_a.Squad);
                        this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
                    }

                    if (this.g_cond_a_count == this.g_cond_a_index)
                    {
                        this.g_cond_a_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_cond_a_wave;
                });
                return this.g_cond_a_front;
            });
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task ai_cond_a_emitters_bk()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cond_a_sentinels) <= this.g_cond_a_limit);
                if (await this.difficulty_legendary())
                {
                    await sleep(this.g_emitter_delay);
                }
                else
                {
                    await sleep((short)(this.g_emitter_delay * 2));
                }

                if (this.g_cond_a_back)
                {
                    sleep_forever();
                }

                this.g_cond_a_count = 0;
                this.g_cond_a_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(cond_a_em_k.Entity)) && object_get_health(cond_a_em_k.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_k.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_k();
                    }
                    else if (!(unit_is_emitting(cond_a_em_o.Entity)) && object_get_health(cond_a_em_o.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_o.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_o();
                    }
                    else if (!(unit_is_emitting(cond_a_em_n.Entity)) && object_get_health(cond_a_em_n.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_n.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_n();
                    }
                    else if (!(unit_is_emitting(cond_a_em_j.Entity)) && object_get_health(cond_a_em_j.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_j.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_j();
                    }
                    else if (!(unit_is_emitting(cond_a_em_l.Entity)) && object_get_health(cond_a_em_l.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_l.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_l();
                    }
                    else if (!(unit_is_emitting(cond_a_em_m.Entity)) && object_get_health(cond_a_em_m.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_m.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_m();
                    }
                    else if (!(unit_is_emitting(cond_a_em_i.Entity)) && object_get_health(cond_a_em_i.Entity) > 0F && objects_distance_to_object(players(), cond_a_em_i.Entity) > 5F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_i();
                    }
                    else if (true)
                    {
                        ai_place(cond_a_sen_b.Squad);
                        this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
                    }

                    if (this.g_cond_a_count == this.g_cond_a_index)
                    {
                        this.g_cond_a_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_cond_a_wave;
                });
                return this.g_cond_a_back;
            });
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task ai_cond_a_back_ini()
        {
            if (await this.difficulty_normal())
            {
                this.g_cond_a_bk_limit = 2;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_cond_a_bk_limit = 3;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_cond_a_bk_limit = 4;
            }

            await sleep(180);
            begin_random(async () => ai_place(cond_a_sen_b.j), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () => await sleep((short)random_range(5, 15)), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    sleep_forever();
                }
            }, 
                async () => ai_place(cond_a_sen_b.k), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () => await sleep((short)random_range(5, 15)), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    sleep_forever();
                }
            }, 
                async () => ai_place(cond_a_sen_b.m), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () => await sleep((short)random_range(5, 15)), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    sleep_forever();
                }
            }, 
                async () => ai_place(cond_a_sen_b.o), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    sleep_forever();
                }
            }, 
                async () => await sleep((short)random_range(5, 15)));
        }

        [ScriptMethod(237, Lifecycle.CommandScript)]
        public async Task cs_cond_a_sen_e()
        {
            cs_fly_to(GetReference<ISpatialPoint>("cond_a/p0"));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task cond_a_delay()
        {
            await sleep(90);
            this.g_cond_a_continue = true;
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task cond_a_initial_delay()
        {
            await sleep_until(async () =>
            {
                if (!(volume_test_objects_all(tv_conduit_a, players())))
                {
                    this.g_cond_a_continue = true;
                }
                else if ((short)ai_living_count(cond_a_sentinels) <= 0)
                {
                    wake(new ScriptMethodReference(cond_a_delay));
                }

                return this.g_cond_a_continue;
            });
        }

        [ScriptMethod(240, Lifecycle.Static)]
        public async Task ai_hall_b_em_b()
        {
            if (this.debug)
            {
                print("b");
            }

            ai_place(hall_b_sen.b);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(241, Lifecycle.Static)]
        public async Task ai_hall_b_em_d()
        {
            if (this.debug)
            {
                print("d");
            }

            ai_place(hall_b_sen.d);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(242, Lifecycle.Static)]
        public async Task ai_hall_b_em_e()
        {
            if (this.debug)
            {
                print("e");
            }

            ai_place(hall_b_sen.e);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(243, Lifecycle.Static)]
        public async Task ai_hall_b_em_f()
        {
            if (this.debug)
            {
                print("f");
            }

            ai_place(hall_b_sen.f);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task ai_hall_b_em_g()
        {
            if (this.debug)
            {
                print("g");
            }

            ai_place(hall_b_sen.g);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task ai_hall_b_emitters()
        {
            if (await this.difficulty_normal())
            {
                this.g_hall_b_sen_limit = 0;
                this.g_hall_b_em_index = 3;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_hall_b_sen_limit = 0;
                this.g_hall_b_em_index = 4;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_hall_b_sen_limit = 1;
                this.g_hall_b_em_index = 5;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(hall_b_sentinels) <= this.g_hall_b_sen_limit);
                if (this.g_hall_b_loops)
                {
                    sleep_forever();
                }

                await sleep(this.g_emitter_delay);
                this.g_hall_b_em_count = 0;
                this.g_hall_b_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(hall_b_em_b.Entity)) && object_get_health(hall_b_em_b.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_b.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_b.Entity) < 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_d();
                    }
                    else if (!(unit_is_emitting(hall_b_em_d.Entity)) && object_get_health(hall_b_em_d.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_d.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_d.Entity) < 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_d();
                    }
                    else if (!(unit_is_emitting(hall_b_em_e.Entity)) && object_get_health(hall_b_em_e.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_e.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_e.Entity) < 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_e();
                    }
                    else if (!(unit_is_emitting(hall_b_em_f.Entity)) && object_get_health(hall_b_em_f.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_f.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_f.Entity) < 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_f();
                    }
                    else if (!(unit_is_emitting(hall_b_em_g.Entity)) && object_get_health(hall_b_em_g.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_g.Entity) > 0F && objects_distance_to_object(players(), hall_b_em_g.Entity) < 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_g();
                    }
                    else if (true)
                    {
                        ai_place(hall_b_sen.Squad);
                        this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
                    }

                    if (this.g_hall_b_em_count == this.g_hall_b_em_index)
                    {
                        this.g_hall_b_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_hall_b_wave;
                });
                return this.g_hall_b_loops;
            });
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cs_plug_launch_enforcer()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to(GetReference<ISpatialPoint>("plug_launch/p0"));
        }

        [ScriptMethod(247, Lifecycle.Static)]
        public async Task ai_plug_launch_em_a()
        {
            if (this.debug)
            {
                print("a");
            }

            ai_place(plug_launch_sen.a);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(248, Lifecycle.Static)]
        public async Task ai_plug_launch_em_b()
        {
            if (this.debug)
            {
                print("b");
            }

            ai_place(plug_launch_sen.b);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(249, Lifecycle.Static)]
        public async Task ai_plug_launch_em_c()
        {
            if (this.debug)
            {
                print("c");
            }

            ai_place(plug_launch_sen.c);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(250, Lifecycle.Static)]
        public async Task ai_plug_launch_em_d()
        {
            if (this.debug)
            {
                print("d");
            }

            ai_place(plug_launch_sen.d);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(251, Lifecycle.Static)]
        public async Task ai_plug_launch_em_e()
        {
            if (this.debug)
            {
                print("e");
            }

            ai_place(plug_launch_sen.e);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(252, Lifecycle.Static)]
        public async Task ai_plug_launch_em_f()
        {
            if (this.debug)
            {
                print("f");
            }

            ai_place(plug_launch_sen.f);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(253, Lifecycle.Static)]
        public async Task ai_plug_launch_em_g()
        {
            if (this.debug)
            {
                print("g");
            }

            ai_place(plug_launch_sen.g);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(254, Lifecycle.Static)]
        public async Task ai_plug_launch_em_h()
        {
            if (this.debug)
            {
                print("h");
            }

            ai_place(plug_launch_sen.h);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task ai_plug_launch_em()
        {
            if (await this.difficulty_normal())
            {
                this.g_plug_launch_limit = 0;
                this.g_plug_launch_index = 2;
                if (this.debug)
                {
                    print("emitters off");
                }

                sleep_forever();
            }
            else if (await this.difficulty_heroic())
            {
                this.g_plug_launch_limit = 0;
                this.g_plug_launch_index = 3;
                await sleep_until(async () => this.g_plug_launch_em_heroic);
                if (this.debug)
                {
                    print("emitters on");
                }
            }
            else if (await this.difficulty_legendary())
            {
                this.g_plug_launch_limit = 0;
                this.g_plug_launch_index = 4;
                if (this.debug)
                {
                    print("emitters on");
                }
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(plug_launch_sentinels) <= this.g_plug_launch_limit);
                if (this.g_plug_launch_loops)
                {
                    sleep_forever();
                }

                await sleep(this.g_emitter_delay);
                this.g_plug_launch_count = 0;
                this.g_plug_launch_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(plug_launch_em_a.Entity)) && object_get_health(plug_launch_em_a.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_a.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_a();
                    }
                    else if (!(unit_is_emitting(plug_launch_em_b.Entity)) && object_get_health(plug_launch_em_b.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_b.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_b();
                    }
                    else if (!(unit_is_emitting(plug_launch_em_c.Entity)) && object_get_health(plug_launch_em_c.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_c.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_c();
                    }
                    else if (!(unit_is_emitting(plug_launch_em_d.Entity)) && object_get_health(plug_launch_em_d.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_d.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_d();
                    }
                    else if (!(unit_is_emitting(plug_launch_em_e.Entity)) && object_get_health(plug_launch_em_e.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_e.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_e();
                    }
                    else if (!(unit_is_emitting(plug_launch_em_f.Entity)) && object_get_health(plug_launch_em_f.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_f.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_f();
                    }
                    else if (!(unit_is_emitting(plug_launch_em_g.Entity)) && object_get_health(plug_launch_em_g.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_g.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_g();
                    }
                    else if (!(unit_is_emitting(plug_launch_em_g.Entity)) && object_get_health(plug_launch_em_g.Entity) > 0F && objects_distance_to_object(players(), plug_launch_em_g.Entity) > 10F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_g();
                    }
                    else if (true)
                    {
                        ai_place(plug_launch_sen.Squad);
                        this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
                    }

                    if (this.g_plug_launch_count == this.g_plug_launch_index)
                    {
                        this.g_plug_launch_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_plug_launch_wave;
                });
                return this.g_plug_launch_loops;
            });
        }

        [ScriptMethod(256, Lifecycle.Static)]
        public async Task<int> absorber05_count()
        {
            if (object_get_shield(plugabsorber05.Entity) <= 0F)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        [ScriptMethod(257, Lifecycle.Static)]
        public async Task<int> absorber06_count()
        {
            if (object_get_shield(plugabsorber06.Entity) <= 0F)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        [ScriptMethod(258, Lifecycle.Static)]
        public async Task<int> absorber07_count()
        {
            if (object_get_shield(plugabsorber07.Entity) <= 0F)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        [ScriptMethod(259, Lifecycle.Static)]
        public async Task<int> absorber08_count()
        {
            if (object_get_shield(plugabsorber08.Entity) <= 0F)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        [ScriptMethod(260, Lifecycle.Static)]
        public async Task<int> absorber_totalcount()
        {
            return (short)(await this.absorber05_count() + await this.absorber06_count() + await this.absorber07_count() + await this.absorber08_count());
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task plug_rods08()
        {
            await sleep_until(async () => device_group_get(group_plug_c) > 0F || object_get_shield(plugabsorber08.Entity) <= 0F, 5);
            device_set_position(plug_thin_fr.Entity, 1F);
            device_set_position(plug_thick_fr.Entity, 1F);
            damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), plugabsorber08.Entity);
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task plug_rods07()
        {
            await sleep_until(async () => device_group_get(group_plug_d) > 0F || object_get_shield(plugabsorber07.Entity) <= 0F, 5);
            device_set_position(plug_thin_br.Entity, 1F);
            device_set_position(plug_thick_br.Entity, 1F);
            damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), plugabsorber07.Entity);
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task plug_rods06()
        {
            await sleep_until(async () => device_group_get(group_plug_a) > 0F || object_get_shield(plugabsorber06.Entity) <= 0F, 5);
            device_set_position(plug_thin_bl.Entity, 1F);
            device_set_position(plug_thick_bl.Entity, 1F);
            damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), plugabsorber06.Entity);
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task plug_rods05()
        {
            await sleep_until(async () => device_group_get(group_plug_b) > 0F || object_get_shield(plugabsorber05.Entity) <= 0F, 5);
            device_set_position(plug_thin_fl.Entity, 1F);
            device_set_position(plug_thick_fl.Entity, 1F);
            damage_object(GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 4268563514U), plugabsorber05.Entity);
        }

        [ScriptMethod(265, Lifecycle.Static)]
        public async Task test_ab()
        {
            object_set_shield(plugabsorber08.Entity, 0F);
            object_set_shield(plugabsorber07.Entity, 0F);
            object_set_shield(plugabsorber06.Entity, 0F);
            object_set_shield(plugabsorber05.Entity, 0F);
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task plug_absorbers()
        {
            objects_attach(plug.Entity, "absorber_a01", plugabsorber06.Entity, "absorber");
            objects_attach(plug.Entity, "absorber_b01", plugabsorber05.Entity, "absorber");
            objects_attach(plug.Entity, "absorber_c01", plugabsorber08.Entity, "absorber");
            objects_attach(plug.Entity, "absorber_d01", plugabsorber07.Entity, "absorber");
            objects_attach(plug.Entity, "switch", plug_switch_housing.Entity, "");
            objects_attach(plug.Entity, "absorber_a01", plug_switch_a.Entity, "switch");
            objects_attach(plug.Entity, "absorber_b01", plug_switch_b.Entity, "switch");
            objects_attach(plug.Entity, "absorber_c01", plug_switch_c.Entity, "switch");
            objects_attach(plug.Entity, "absorber_d01", plug_switch_d.Entity, "switch");
            game_save();
            wake(new ScriptMethodReference(plug_rods08));
            wake(new ScriptMethodReference(plug_rods07));
            wake(new ScriptMethodReference(plug_rods06));
            wake(new ScriptMethodReference(plug_rods05));
            wake(new ScriptMethodReference(sc_plug_launch));
            await sleep(90);
            if (this.debug)
            {
                print("only 4 more to go!!");
            }

            await sleep_until(async () => await this.absorber_totalcount() <= 3);
            if (this.debug)
            {
                print("absorber activated!");
            }

            await sleep_until(async () => await this.absorber_totalcount() <= 2);
            if (this.debug)
            {
                print("absorber activated!");
            }

            this.g_plug_launch_em_heroic = true;
            await sleep_until(async () => await this.absorber_totalcount() <= 1);
            if (this.debug)
            {
                print("absorber activated!");
            }

            this.g_final_lock = true;
            await sleep_until(async () => await this.absorber_totalcount() <= 0);
            if (this.debug)
            {
                print("absorber activated!");
            }

            this.g_flip_switch = true;
            device_set_position(plug_switch_housing.Entity, 1F);
            ai_set_orders(covenant1, plug_cov);
            await sleep_until(async () => device_get_position(plug_switch_housing.Entity) >= 1F, 1, 120);
            await sleep(30);
            object_create(plug_switch);
            objects_attach(plug_switch_housing.Entity, "switch", plug_switch.Entity, "");
            device_set_power(plug_switch.Entity, 1F);
            device_set_position(plug_switch.Entity, 1F);
            await sleep(30);
            await sleep_until(async () => device_get_position(plug_switch.Entity) >= 1F, 1);
            device_group_change_only_once_more_set(plug1, true);
            await sleep_until(async () => device_get_position(plug_switch.Entity) <= 0F, 1);
            await sleep(60);
            device_set_power(plug_switch.Entity, 0F);
            this.g_plug_move = true;
        }

        [ScriptMethod(267, Lifecycle.CommandScript)]
        public async Task cs_gap_phantom()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p1"), 4F);
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p2"), 4F);
            wake(new ScriptMethodReference(sc_plug_ride));
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p3"), 4F);
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p9"), 7F);
            if (this.debug)
            {
                print("placing enforcer...");
            }

            ai_place(plug_holder_enforcer.Squad);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("wall_gap/p10"), GetReference<ISpatialPoint>("wall_gap/p20"), 3F);
            device_group_change_only_once_more_set(plug_door_a1, false);
            await sleep(1);
            if (this.debug)
            {
                print("opening door... (closing the one behind you)");
            }

            device_set_position(plug_door_a.Entity, 0F);
            device_set_position(plug_door_b.Entity, 1F);
            await sleep(1);
            if (this.debug)
            {
                print("placing eliminators...");
            }

            ai_place(plug_holder_sen_elim.Squad, 2);
            await sleep(1);
            await sleep((short)(30 * 5));
            if (this.debug)
            {
                print("placing initial flood...");
            }

            ai_place(plug_holder_flood_a.Squad, 1);
            ai_place(plug_holder_flood_d.Squad);
            ai_place(plug_holder_flood_c.Squad);
            ai_place(plug_holder_flood_d.Squad, 1);
            this.g_plug_ride_enforcer = true;
            cs_vehicle_speed(0.4F);
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p11"), 2F);
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p12"), 2F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("wall_gap/p13"), GetReference<ISpatialPoint>("wall_gap/p15"), 10F);
            cs_vehicle_speed(1F);
            wake(new ScriptMethodReference(objective_floodwall_set));
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p15"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("wall_gap/p16"), 10F);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(268, Lifecycle.Static)]
        public async Task test_phantom()
        {
            ai_place(gap_phantom1.Squad);
            await sleep(1);
            cs_run_command_script(gap_phantom1.Squad, new ScriptMethodReference(cs_gap_phantom));
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task lower_shield()
        {
            if (this.debug)
            {
                print("containment-field created");
            }

            object_create(containment_field);
            await sleep_until(async () => this.g_lower_shield, 5);
            if (this.debug)
            {
                print("lowering the containment-shield");
            }

            device_set_position(containment_field.Entity, 1F);
            await sleep_until(async () => device_get_position(containment_field.Entity) >= 1F);
            object_destroy(containment_field.Entity);
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task bsp0_cleanup()
        {
            if (this.debug)
            {
                print("bsp 0 cleanup...");
            }

            object_destroy_containing("bsp0_body");
            object_destroy_containing("bsp0_weapon");
            object_destroy_containing("bsp0_equip");
            object_destroy_containing("bsp0_crate");
            object_destroy_containing("ins_em");
            object_destroy_containing("hall_a_em");
            object_destroy_containing("cond_a_em");
            object_destroy_containing("hall_b_em");
            object_destroy_containing("plug_launch_em");
            object_destroy(piston_ins.Entity);
            object_destroy(piston_a.Entity);
            object_destroy(piston_b.Entity);
            object_destroy(piston_c.Entity);
            object_destroy(absorber_ins.Entity);
            object_destroy(absorber_a.Entity);
            object_destroy(absorber_a.Entity);
            object_destroy(absorber_b.Entity);
            object_destroy(absorber_c.Entity);
            ai_erase(insertion_sentinels);
            ai_erase(hall_a_sentinels);
            ai_erase(cond_a_sentinels);
            ai_erase(hall_b_sentinels);
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task cs_move_plug()
        {
            wake(new ScriptMethodReference(lower_shield));
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\sentinel_wall_power_down", 4268629051U), default(IGameObject), 1F);
            ai_kill(plug_launch_sen.Squad);
            ai_kill(plug_launch_enforcer.Squad);
            begin_random(async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_a.Entity, "emitter", 2F), 
                async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_b.Entity, "emitter", 2F), 
                async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_c.Entity, "emitter", 2F), 
                async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_d.Entity, "emitter", 2F), 
                async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_e.Entity, "emitter", 2F), 
                async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_f.Entity, "emitter", 2F), 
                async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_g.Entity, "emitter", 2F), 
                async () => await sleep((short)random_range(0, 10)), 
                async () => object_damage_damage_section(plug_launch_em_h.Entity, "emitter", 2F));
            await sleep(30);
            device_set_position(plug_keylock_c.Entity, 1F);
            device_set_position(plug_keylock_d.Entity, 1F);
            if (this.debug)
            {
                print("opening door...");
            }

            device_set_position(plug_door_a.Entity, 1F);
            object_create(plug_doors_open);
            await sleep_until(async () => device_get_position(plug_door_a.Entity) >= 0.5F, 10);
            data_mine_set_mission_segment("enc_plug_across");
            await sleep(15);
            this.g_music_06a_04 = true;
            if (this.debug)
            {
                print("plug down...");
            }

            object_dynamic_simulation_disable(plug.Entity, false);
            await sleep(1);
            device_set_position_track(plug.Entity, "plug_down", 0F);
            device_animate_position(plug.Entity, 1F, 2F, 0.05F, 0.25F, false);
            await sleep_until(async () => device_get_position(plug_door_a.Entity) >= 1F && volume_test_objects_all(tv_plug_down, players()));
            object_destroy(plug_keylock_c.Entity);
            object_destroy(plug_keylock_d.Entity);
            wake(new ScriptMethodReference(chapter_remorse));
            wake(new ScriptMethodReference(objective_lower_specific_clear));
            await sleep(30);
            device_set_power(plug_switch.Entity, 0F);
            device_set_position(plug_switch_housing.Entity, 0F);
            object_destroy(plug_switch.Entity);
            await sleep(30);
            await sleep_until(async () => volume_test_objects_all(tv_plug_down, ai_actors(covenant1)), 30, 30 * 10);
            if (this.debug)
            {
                print("initializing tartersauce...");
            }

            ai_place(gap_phantom1.Squad);
            game_save();
            if (this.debug)
            {
                print("plug across...");
            }

            device_set_position_track(plug.Entity, "plug_across", 0F);
            device_animate_position(plug.Entity, 1F, 60F, 5F, 5F, false);
            await sleep(5);
            await sleep_until(async () => device_get_position(plug.Entity) >= 0.035F, 1);
            if (this.debug)
            {
                print("g_lower_shield set to 1");
            }

            await sleep_until(async () => device_get_position(plug.Entity) >= 0.15F, 5);
            this.g_lower_shield = true;
            await sleep_until(async () => device_get_position(plug.Entity) >= 0.5F, 5);
            game_save_no_timeout();
            wake(new ScriptMethodReference(bsp0_cleanup));
            await sleep_until(async () => device_get_position(plug.Entity) >= 1F);
            await sleep(30);
            if (this.debug)
            {
                print("plug up...");
            }

            device_set_position_track(plug.Entity, "plug_up", 0F);
            device_animate_position(plug.Entity, 1F, 3F, 0.1F, 1F, false);
            ai_set_orders(plug_holder_enforcer.Squad, plugholder_enforcer);
            await sleep_until(async () => device_get_position(plug.Entity) >= 1F, 10);
            await sleep(1);
            object_dynamic_simulation_disable(plug.Entity, true);
            this.g_music_06a_05 = true;
            device_set_position(plug_lock_a.Entity, 1F);
            device_set_position(plug_lock_b.Entity, 1F);
            device_set_position(plug_lock_c.Entity, 1F);
            device_set_position(plug_lock_d.Entity, 1F);
            device_set_position(plug_lock_e.Entity, 1F);
            device_set_position(plug_lock_f.Entity, 1F);
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task cs_gap_flood_jump()
        {
            cs_enable_moving(true);
            await sleep((short)random_range(20, 50));
            cs_jump(30F, 5F);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            await sleep((short)(30 * 3));
            object_can_take_damage(ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(273, Lifecycle.Static)]
        public async Task gap_flood_jump()
        {
            cs_run_command_script(this.ai_current_squad, new ScriptMethodReference(cs_gap_flood_jump));
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task invulnerable()
        {
            cs_enable_moving(true);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_certain);
            await sleep((short)(30 * 1));
            object_can_take_damage(ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(275, Lifecycle.Static)]
        public async Task make_invulnerable()
        {
            cs_run_command_script(this.ai_current_squad, new ScriptMethodReference(invulnerable));
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task close_plugholder_door()
        {
            await sleep(150);
            await sleep_until(async () => !(volume_test_objects(tv_plugholder_a, players())) && !(volume_test_objects(tv_plugholder_b, players())));
            device_set_position(plugholder_door.Entity, 0F);
        }

        [ScriptMethod(277, Lifecycle.Static)]
        public async Task ai_plug_holder_em_a()
        {
            if (this.debug)
            {
                print("a");
            }

            ai_place(plug_holder_sen.a);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(278, Lifecycle.Static)]
        public async Task ai_plug_holder_em_b()
        {
            if (this.debug)
            {
                print("b");
            }

            ai_place(plug_holder_sen.b);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(279, Lifecycle.Static)]
        public async Task ai_plug_holder_em_d()
        {
            if (this.debug)
            {
                print("d");
            }

            ai_place(plug_holder_sen.d);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(280, Lifecycle.Static)]
        public async Task ai_plug_holder_em_f()
        {
            if (this.debug)
            {
                print("f");
            }

            ai_place(plug_holder_sen.f);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(281, Lifecycle.Static)]
        public async Task ai_plug_holder_em_h()
        {
            if (this.debug)
            {
                print("h");
            }

            ai_place(plug_holder_sen.h);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(282, Lifecycle.Static)]
        public async Task ai_plug_holder_em_i()
        {
            if (this.debug)
            {
                print("i");
            }

            ai_place(plug_holder_sen.i);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task ai_plug_holder_em()
        {
            if (await this.difficulty_normal())
            {
                this.g_plug_holder_limit = 0;
                this.g_plug_holder_index = 2;
                this.g_plug_holder_wave_limit = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_plug_holder_limit = 0;
                this.g_plug_holder_index = 3;
                this.g_plug_holder_wave_limit = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_plug_holder_limit = 1;
                this.g_plug_holder_index = 4;
                this.g_plug_holder_wave_limit = 3;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(plug_holder_sentinels) <= this.g_plug_holder_limit);
                if (this.g_plugholder_progress)
                {
                    sleep_forever();
                }

                await sleep(this.g_emitter_delay);
                this.g_plug_holder_count = 0;
                this.g_plug_holder_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(plug_holder_em_a.Entity)) && object_get_health(plug_holder_em_a.Entity) > 0F && objects_distance_to_object(players(), plug_holder_em_a.Entity) > 6F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_a();
                    }
                    else if (!(unit_is_emitting(plug_holder_em_b.Entity)) && object_get_health(plug_holder_em_b.Entity) > 0F && objects_distance_to_object(players(), plug_holder_em_b.Entity) > 6F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_b();
                    }
                    else if (!(unit_is_emitting(plug_holder_em_d.Entity)) && object_get_health(plug_holder_em_d.Entity) > 0F && objects_distance_to_object(players(), plug_holder_em_d.Entity) > 6F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_d();
                    }
                    else if (!(unit_is_emitting(plug_holder_em_f.Entity)) && object_get_health(plug_holder_em_f.Entity) > 0F && objects_distance_to_object(players(), plug_holder_em_f.Entity) > 6F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_f();
                    }
                    else if (!(unit_is_emitting(plug_holder_em_h.Entity)) && object_get_health(plug_holder_em_h.Entity) > 0F && objects_distance_to_object(players(), plug_holder_em_h.Entity) > 6F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_h();
                    }
                    else if (!(unit_is_emitting(plug_holder_em_i.Entity)) && object_get_health(plug_holder_em_i.Entity) > 0F && objects_distance_to_object(players(), plug_holder_em_i.Entity) > 6F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_i();
                    }
                    else if (true)
                    {
                        ai_place(plug_holder_sen.Squad);
                        this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
                        if (this.debug)
                        {
                            print("placing random sentinel (or none at all)...");
                        }
                    }

                    if (this.g_plug_holder_count == this.g_plug_holder_index)
                    {
                        this.g_plug_holder_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_plug_holder_wave;
                });
                this.g_plug_holder_wave_count = (short)(this.g_plug_holder_wave_count + 1);
                if (this.g_plug_holder_wave_count == this.g_plug_holder_wave_limit)
                {
                    this.g_plugholder_progress = true;
                }

                return this.g_plugholder_progress;
            });
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task ai_plug_holder_em_elim()
        {
            await sleep_until(async () => (short)ai_living_count(plug_holder_enforcer.Squad) <= 0);
            if (this.debug)
            {
                print("plug holder enforcer dead. initializing eliminators...");
            }

            await sleep(this.g_emitter_delay);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(plug_holder_sen_elim.Squad) <= 0);
                if (this.g_plugholder_progress)
                {
                    sleep_forever();
                }

                if (this.debug)
                {
                    print("eliminator!");
                }

                ai_place(plug_holder_sen_elim.Squad);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                return this.g_plugholder_progress;
            });
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task ai_plug_holder_flood()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(plug_holder_flood) <= 1);
                if (this.g_plugholder_progress)
                {
                    sleep_forever();
                }

                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (volume_test_objects(tv_plugholder_a, players()))
                {
                    if (this.debug)
                    {
                        print("placing flood a...");
                    }

                    ai_place(plug_holder_flood_c.Squad);
                    ai_place(plug_holder_flood_d.Squad);
                }
                else if (volume_test_objects(tv_plugholder_b, players()))
                {
                    if (this.debug)
                    {
                        print("placing flood b...");
                    }

                    ai_place(plug_holder_flood_a.Squad);
                    ai_place(plug_holder_flood_b.Squad);
                }

                return this.g_plugholder_progress;
            });
        }

        [ScriptMethod(286, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_a()
        {
            if (this.debug)
            {
                print("a back");
            }

            ai_place(plug_holder_bk_sen.a);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(287, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_b()
        {
            if (this.debug)
            {
                print("b back");
            }

            ai_place(plug_holder_bk_sen.b);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(288, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_c()
        {
            if (this.debug)
            {
                print("c back");
            }

            ai_place(plug_holder_bk_sen.c);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(289, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_d()
        {
            if (this.debug)
            {
                print("d back");
            }

            ai_place(plug_holder_bk_sen.d);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(290, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_e()
        {
            if (this.debug)
            {
                print("e back");
            }

            ai_place(plug_holder_bk_sen.e);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(291, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_f()
        {
            if (this.debug)
            {
                print("f back");
            }

            ai_place(plug_holder_bk_sen.f);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task ai_plug_holder_bk_em()
        {
            await sleep_until(async () => (short)ai_living_count(plug_holder_sentinels) <= 2);
            if (await this.difficulty_normal())
            {
                this.g_plug_holder_bk_limit = 0;
                this.g_plug_holder_bk_index = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_plug_holder_bk_limit = 0;
                this.g_plug_holder_bk_index = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_plug_holder_bk_limit = 1;
                this.g_plug_holder_bk_index = 2;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(plug_holder_sentinels_bk) <= this.g_plug_holder_bk_limit);
                if (this.g_plug_holder_bk_loops)
                {
                    sleep_forever();
                }

                await sleep(this.g_emitter_delay);
                this.g_plug_holder_bk_count = 0;
                this.g_plug_holder_bk_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(plug_holder_bk_em_a.Entity)) && object_get_health(plug_holder_bk_em_a.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_a.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_a.Entity) > 8F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_a();
                    }
                    else if (!(unit_is_emitting(plug_holder_bk_em_b.Entity)) && object_get_health(plug_holder_bk_em_b.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_b.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_b.Entity) > 8F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_b();
                    }
                    else if (!(unit_is_emitting(plug_holder_bk_em_c.Entity)) && object_get_health(plug_holder_bk_em_c.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_c.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_c.Entity) > 8F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_c();
                    }
                    else if (!(unit_is_emitting(plug_holder_bk_em_d.Entity)) && object_get_health(plug_holder_bk_em_d.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_d.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_d.Entity) > 8F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_d();
                    }
                    else if (!(unit_is_emitting(plug_holder_bk_em_e.Entity)) && object_get_health(plug_holder_bk_em_e.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_e.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_e.Entity) > 8F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_e();
                    }
                    else if (!(unit_is_emitting(plug_holder_bk_em_f.Entity)) && object_get_health(plug_holder_bk_em_f.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_f.Entity) > 0F && objects_distance_to_object(players(), plug_holder_bk_em_f.Entity) > 8F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_f();
                    }
                    else if (true)
                    {
                        ai_place(plug_holder_bk_sen.Squad);
                        this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
                    }

                    if (this.g_plug_holder_bk_count == this.g_plug_holder_bk_index)
                    {
                        this.g_plug_holder_bk_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_plug_holder_bk_wave;
                });
                return this.g_plug_holder_bk_loops;
            });
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task ai_plugholder_flood_bk()
        {
            if (await this.difficulty_normal())
            {
                this.g_plugholder_bk_flood_limit = 4;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_plugholder_bk_flood_limit = 5;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_plugholder_bk_flood_limit = 6;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(plug_holder_flood_bk) <= 2);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                ai_place(plugholder_bk_flood_a.Squad);
                ai_place(plugholder_bk_infec_a.Squad);
                this.g_plugholder_bk_flood_count = (short)(this.g_plugholder_bk_flood_count + 1);
                if (this.g_plugholder_bk_flood_count == this.g_plugholder_bk_flood_limit)
                {
                    this.g_plugholder_bk_a = true;
                }

                return this.g_plugholder_bk_a;
            });
            this.g_plugholder_bk_flood_count = 0;
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(plug_holder_flood_bk) <= 2);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                ai_place(plugholder_bk_flood_b.Squad);
                ai_place(plugholder_bk_infec_b.Squad);
                this.g_plugholder_bk_flood_count = (short)(this.g_plugholder_bk_flood_count + 1);
                if (this.g_plugholder_bk_flood_count == this.g_plugholder_bk_flood_limit)
                {
                    this.g_plugholder_bk_b = true;
                }

                return this.g_plugholder_bk_b;
            });
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task ai_plugholder_infec_bk_a()
        {
            await sleep_until(async () => this.g_plugholder_bk_flood_count >= 2);
            if (this.debug)
            {
                print("infection forms...");
            }

            ai_place(plugholder_bk_infec_a.Squad);
            await sleep_until(async () => this.g_plugholder_bk_flood_count >= 4);
            if (this.debug)
            {
                print("infection forms...");
            }

            ai_place(plugholder_bk_infec_a.Squad);
            await sleep_until(async () => this.g_plugholder_bk_flood_count >= 6);
            if (this.debug)
            {
                print("infection forms...");
            }

            ai_place(plugholder_bk_infec_a.Squad);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task ai_plugholder_infec_bk_b()
        {
            await sleep_until(async () => this.g_plugholder_bk_flood_count >= 2);
            if (this.debug)
            {
                print("infection forms...");
            }

            ai_place(plugholder_bk_infec_b.Squad);
            await sleep_until(async () => this.g_plugholder_bk_flood_count >= 4);
            if (this.debug)
            {
                print("infection forms...");
            }

            ai_place(plugholder_bk_infec_b.Squad);
            await sleep_until(async () => this.g_plugholder_bk_flood_count >= 6);
            if (this.debug)
            {
                print("infection forms...");
            }

            ai_place(plugholder_bk_infec_b.Squad);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task kill_hall_c_marines()
        {
            begin_random(async () => ai_kill(hall_c_marines1.a), 
                async () => await sleep(5), 
                async () => ai_kill(hall_c_marines1.b), 
                async () => await sleep(5), 
                async () => ai_kill(hall_c_marines1.c), 
                async () => await sleep(5), 
                async () => ai_kill(hall_c_marines1.d), 
                async () => await sleep(5));
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task ai_hall_c_ini()
        {
            ai_place(hall_c_marines1.Squad);
            ai_place(hall_c_flood_far.Squad);
            wake(new ScriptMethodReference(sc_marines_b));
            ai_place(hall_c_infec.Squad);
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task ai_hall_c_flood_d()
        {
            if ((short)ai_living_count(hall_c_flood) < 3)
            {
                ai_place(hall_c_flood_d.Squad);
                this.g_hall_c_flood_count = (short)(this.g_hall_c_flood_count + 1);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
            }
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task ai_hall_c_flood_e()
        {
            if ((short)ai_living_count(hall_c_flood) < 3)
            {
                ai_place(hall_c_flood_e.Squad);
                this.g_hall_c_flood_count = (short)(this.g_hall_c_flood_count + 1);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
            }
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task ai_hall_c_flood_f()
        {
            if ((short)ai_living_count(hall_c_flood) < 3)
            {
                ai_place(hall_c_flood_f.Squad);
                this.g_hall_c_flood_count = (short)(this.g_hall_c_flood_count + 1);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
            }
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task ai_hall_c_flood_spawn()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_hall_c_d, players()))
                {
                    await this.ai_hall_c_flood_e();
                }
                else if (volume_test_objects(tv_hall_c_e, players()))
                {
                    await this.ai_hall_c_flood_f();
                }

                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.g_hall_c_flood_count >= this.g_hall_c_flood_index)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
        }

        [ScriptMethod(302, Lifecycle.Dormant)]
        public async Task ai_ledge_a_initial()
        {
            ai_place(ledge_a_enforcer.Squad);
            ai_place(ledge_a_sen_ini1.Squad);
            ai_place(ledge_a_flood_ini1.Squad);
        }

        [ScriptMethod(303, Lifecycle.Dormant)]
        public async Task ai_ledge_a_location()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_ledge_a, players()))
                {
                    this.g_ledge_a_player_loc = 1;
                }
                else if (volume_test_objects(tv_ledge_a_top_b, players()))
                {
                    this.g_ledge_a_player_loc = 2;
                }
                else if (volume_test_objects(tv_ledge_a_top_c, players()))
                {
                    this.g_ledge_a_player_loc = 3;
                }
                else if (volume_test_objects(tv_ledge_a_top_d1, players()))
                {
                    this.g_ledge_a_player_loc = 4;
                }
                else if (volume_test_objects(tv_ledge_a_top_d2, players()))
                {
                    this.g_ledge_a_player_loc = 5;
                }
                else if (volume_test_objects(tv_ledge_a_top_e, players()))
                {
                    this.g_ledge_a_player_loc = 6;
                }
                else if (volume_test_objects(tv_ledge_a_top_f, players()))
                {
                    this.g_ledge_a_player_loc = 7;
                }
                else if (volume_test_objects(tv_ledge_a_top_g, players()))
                {
                    this.g_ledge_a_player_loc = 8;
                }
                else if (volume_test_objects(tv_ledge_a_bot_a, players()))
                {
                    this.g_ledge_a_player_loc = 9;
                }
                else if (volume_test_objects(tv_ledge_a_bot_b, players()))
                {
                    this.g_ledge_a_player_loc = 10;
                }

                return false;
            });
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task ai_ledge_a_flood_b()
        {
            if (this.debug)
            {
                print("flood b");
            }

            ai_place(ledge_a_flood_b.Squad);
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task ai_ledge_a_flood_c()
        {
            if (this.debug)
            {
                print("flood c");
            }

            ai_place(ledge_a_flood_c.Squad);
        }

        [ScriptMethod(306, Lifecycle.Static)]
        public async Task ai_ledge_a_flood_e()
        {
            if (this.debug)
            {
                print("flood e");
            }

            ai_place(ledge_a_flood_e.Squad);
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task ai_ledge_a_flood_f()
        {
            if (this.debug)
            {
                print("flood f");
            }

            ai_place(ledge_a_flood_f.Squad);
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task ai_ledge_a_flood_spawn()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(ledge_a_flood) <= 2);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.g_ledge_a_player_loc == 2)
                {
                    await this.ai_ledge_a_flood_b();
                }
                else if (this.g_ledge_a_player_loc == 3)
                {
                    await this.ai_ledge_a_flood_c();
                }
                else if (this.g_ledge_a_player_loc == 6)
                {
                    await this.ai_ledge_a_flood_e();
                }
                else if (this.g_ledge_a_player_loc == 7)
                {
                    await this.ai_ledge_a_flood_f();
                }

                return (short)ai_spawn_count(ledge_a_flood) >= 16 || this.g_ledge_a_spawn;
            });
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(ledge_a_flood) <= 2);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.g_ledge_a_player_loc == 6)
                {
                    await this.ai_ledge_a_flood_e();
                }
                else if (this.g_ledge_a_player_loc == 7)
                {
                    await this.ai_ledge_a_flood_f();
                }

                return (short)ai_spawn_count(ledge_a_flood) >= 32 || this.g_ledge_a_spawn;
            });
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task ai_ledge_a_flood_bot_a()
        {
            await sleep_until(async () => volume_test_objects(tv_ledge_a_bot_a, players()));
            ai_place(ledge_a_flood_bot_a1.Squad);
        }

        [ScriptMethod(310, Lifecycle.Dormant)]
        public async Task ai_ledge_a_flood_bot_b()
        {
            await sleep_until(async () => volume_test_objects(tv_ledge_a_bot_b, players()));
            ai_place(ledge_a_flood_bot_b1.Squad);
        }

        [ScriptMethod(311, Lifecycle.Static)]
        public async Task ai_ledge_a_em_a()
        {
            if (this.debug)
            {
                print("a");
            }

            ai_place(ledge_a_sen.a);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task ai_ledge_a_em_b()
        {
            if (this.debug)
            {
                print("b");
            }

            ai_place(ledge_a_sen.b);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(313, Lifecycle.Static)]
        public async Task ai_ledge_a_em_c()
        {
            if (this.debug)
            {
                print("c");
            }

            ai_place(ledge_a_sen.c);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task ai_ledge_a_em_d()
        {
            if (this.debug)
            {
                print("d");
            }

            ai_place(ledge_a_sen.d);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(315, Lifecycle.Static)]
        public async Task ai_ledge_a_em_e()
        {
            if (this.debug)
            {
                print("e");
            }

            ai_place(ledge_a_sen.e);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task ai_ledge_a_em_f()
        {
            if (this.debug)
            {
                print("f");
            }

            ai_place(ledge_a_sen.f);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task ai_ledge_a_em_g()
        {
            if (this.debug)
            {
                print("g");
            }

            ai_place(ledge_a_sen.g);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task ai_ledge_a_em_h()
        {
            if (this.debug)
            {
                print("h");
            }

            ai_place(ledge_a_sen.h);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task ai_ledge_a_em_i()
        {
            if (this.debug)
            {
                print("i");
            }

            ai_place(ledge_a_sen.i);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(320, Lifecycle.Dormant)]
        public async Task ai_ledge_a_emitters()
        {
            if (await this.difficulty_normal())
            {
                this.g_ledge_a_sen_limit = 0;
                this.g_ledge_a_index = 2;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_ledge_a_sen_limit = 0;
                this.g_ledge_a_index = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_ledge_a_sen_limit = 1;
                this.g_ledge_a_index = 3;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(ledge_a_sentinels) <= this.g_ledge_a_sen_limit);
                await sleep(this.g_emitter_delay);
                this.g_ledge_a_count = 0;
                this.g_ledge_a_wave = false;
                await sleep_until(async () =>
                {
                    if (!(unit_is_emitting(ledge_a_em_a.Entity)) && object_get_health(ledge_a_em_a.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_a.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_a.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_a();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_b.Entity)) && object_get_health(ledge_a_em_b.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_b.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_b.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_b();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_c.Entity)) && object_get_health(ledge_a_em_c.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_c.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_c.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_c();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_d.Entity)) && object_get_health(ledge_a_em_d.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_d.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_d.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_d();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_e.Entity)) && object_get_health(ledge_a_em_e.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_e.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_e.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_e();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_f.Entity)) && object_get_health(ledge_a_em_f.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_f.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_f.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_f();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_g.Entity)) && object_get_health(ledge_a_em_g.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_g.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_g.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_g();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_h.Entity)) && object_get_health(ledge_a_em_h.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_h.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_h.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_h();
                    }
                    else if (!(unit_is_emitting(ledge_a_em_i.Entity)) && object_get_health(ledge_a_em_i.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_i.Entity) > 0F && objects_distance_to_object(players(), ledge_a_em_i.Entity) < 9F && (short)random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_i();
                    }

                    if (this.g_ledge_a_count == this.g_ledge_a_index)
                    {
                        this.g_ledge_a_wave = true;
                    }

                    await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_ledge_a_wave;
                });
                return this.g_ledge_a_loops;
            });
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task kill_cond_b_marines()
        {
            begin_random(async () => ai_kill(cond_b_humans1.a), 
                async () => await sleep(5), 
                async () => ai_kill(cond_b_humans1.b), 
                async () => await sleep(5), 
                async () => ai_kill(cond_b_humans1.c), 
                async () => await sleep(5));
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task conduit_b_locator()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_cond_b_a1, players()))
                {
                    this.cond_b_locator = 1;
                }
                else if (volume_test_objects(tv_cond_b_a2, players()))
                {
                    this.cond_b_locator = 2;
                }
                else if (volume_test_objects(tv_cond_b_b1, players()))
                {
                    this.cond_b_locator = 3;
                }
                else if (volume_test_objects(tv_cond_b_b2, players()))
                {
                    this.cond_b_locator = 4;
                }
                else if (volume_test_objects(tv_cond_b_c, players()))
                {
                    this.cond_b_locator = 5;
                }

                return false;
            });
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task ai_cond_b_carrier_a()
        {
            await sleep_until(async () => this.cond_b_flood_count == 2 || volume_test_objects(tv_cond_b_a2, players()));
            ai_place(cond_b_carrier_a.Squad);
            await sleep_until(async () => this.cond_b_flood_count == 4);
            if (this.cond_b_locator > 1)
            {
                sleep_forever();
            }

            ai_place(cond_b_carrier_a.Squad);
            await sleep_until(async () => this.cond_b_flood_count == 6);
            if (this.cond_b_locator > 1)
            {
                sleep_forever();
            }

            ai_place(cond_b_carrier_a.Squad);
        }

        [ScriptMethod(324, Lifecycle.CommandScript)]
        public async Task cs_cond_b_damage_enf()
        {
            await sleep(5);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "l_arm", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "l_rocket", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "l_thruster", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "l_shield_gen", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "r_arm", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "r_rocket", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "r_thruster", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "r_shield_gen", 1F);
            await sleep(1);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "r_shield_gen", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "r_arm", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "r_rocket", 1F);
            object_damage_damage_section(ai_get_object(cond_b_enforcer1.a), "l_thruster", 1F);
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task ai_cond_b_b_em()
        {
            await sleep_until(async () => (short)ai_living_count(cond_b_sen_b.Squad) <= 0);
            await sleep(this.g_emitter_delay);
            if ((short)random_range(0, 2) == 0)
            {
                ai_place(cond_b_sen_b.a);
            }
            else
            {
                ai_place(cond_b_sen_b.b);
            }
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task ai_cond_b_flood_spawn()
        {
            ai_place(cond_b_flood_a_ini_a1.Squad);
            ai_place(cond_b_flood_a_ini_b1.Squad);
            ai_place(cond_b_flood_a_ini_c1.Squad);
            if (await this.difficulty_normal())
            {
                this.cond_b_flood_limit = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.cond_b_flood_limit = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.cond_b_flood_limit = 4;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cond_b_flood) <= 1);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.cond_b_locator == 1)
                {
                    ai_place(cond_b_flood_a.Squad);
                    this.cond_b_flood_count = (short)(this.cond_b_flood_count + 1);
                    if (this.cond_b_flood_count == this.cond_b_flood_limit)
                    {
                        this.cond_b_flood_a_spawn = true;
                    }

                    await sleep(30);
                    ai_magically_see_object(cond_b_flood, await this.player0());
                    ai_magically_see_object(cond_b_flood, await this.player1());
                }

                return this.cond_b_flood_a_spawn;
            });
            this.cond_b_flood_count = 0;
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cond_b_flood) <= 1);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.cond_b_locator == 3)
                {
                    ai_place(cond_b_flood_b.Squad);
                    this.cond_b_flood_count = (short)(this.cond_b_flood_count + 1);
                    if (this.cond_b_flood_count == this.cond_b_flood_limit)
                    {
                        this.cond_b_flood_b_spawn = true;
                    }

                    await sleep(30);
                    ai_magically_see_object(cond_b_flood, await this.player0());
                    ai_magically_see_object(cond_b_flood, await this.player1());
                }

                return this.cond_b_flood_b_spawn;
            });
            this.cond_b_flood_count = 0;
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(cond_b_flood) <= 1);
                await sleep((short)random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.cond_b_locator == 3)
                {
                    ai_place(cond_b_flood_c.Squad);
                    this.cond_b_flood_count = (short)(this.cond_b_flood_count + 1);
                    if (this.cond_b_flood_count == this.cond_b_flood_limit)
                    {
                        this.cond_b_flood_c_spawn = true;
                    }

                    await sleep(30);
                    ai_magically_see_object(cond_b_flood, await this.player0());
                    ai_magically_see_object(cond_b_flood, await this.player1());
                }

                return this.cond_b_flood_c_spawn;
            });
        }

        [ScriptMethod(327, Lifecycle.CommandScript)]
        public async Task cs_cond_b_sen_tube_a()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("cond_b/p0"), GetReference<ISpatialPoint>("cond_b/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("cond_b/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("cond_b/p2"));
            cs_fly_to(GetReference<ISpatialPoint>("cond_b/p3"));
        }

        [ScriptMethod(328, Lifecycle.CommandScript)]
        public async Task cs_cond_b_sen_tube_b()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("cond_b/p1"), GetReference<ISpatialPoint>("cond_b/p2"));
            cs_fly_to(GetReference<ISpatialPoint>("cond_b/p2"));
            cs_fly_to(GetReference<ISpatialPoint>("cond_b/p3"));
        }

        [ScriptMethod(329, Lifecycle.Dormant)]
        public async Task ai_cond_b_sen_tube_b()
        {
            if ((short)random_range(0, 2) == 0)
            {
                ai_place(cond_b_sen_tube_b1.a);
            }
            else
            {
                ai_place(cond_b_sen_tube_b1.b);
            }

            if ((short)random_range(0, 2) == 0)
            {
                ai_place(cond_b_sen_tube_b1.c);
            }
            else
            {
                ai_place(cond_b_sen_tube_b1.d);
            }

            await sleep(5);
            cs_run_command_script(cond_b_sen_tube_b1.a, new ScriptMethodReference(cs_cond_b_sen_tube_a));
            cs_run_command_script(cond_b_sen_tube_b1.b, new ScriptMethodReference(cs_cond_b_sen_tube_a));
            cs_run_command_script(cond_b_sen_tube_b1.c, new ScriptMethodReference(cs_cond_b_sen_tube_b));
            cs_run_command_script(cond_b_sen_tube_b1.d, new ScriptMethodReference(cs_cond_b_sen_tube_b));
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task slide_a_player0()
        {
            await sleep_until(async () => volume_test_object(tv_slide_a, await this.player0()));
            object_cannot_take_damage(await this.player0());
            await sleep_until(async () => !(volume_test_objects(tv_slide_a, await this.player0())));
            object_can_take_damage(await this.player0());
        }

        [ScriptMethod(331, Lifecycle.Dormant)]
        public async Task slide_a_player1()
        {
            await sleep_until(async () => volume_test_object(tv_slide_a, await this.player1()));
            object_cannot_take_damage(await this.player1());
            await sleep_until(async () => !(volume_test_objects(tv_slide_a, await this.player1())));
            object_can_take_damage(await this.player1());
        }

        [ScriptMethod(332, Lifecycle.Dormant)]
        public async Task slide_b_player0()
        {
            await sleep_until(async () => volume_test_object(tv_slide_b, await this.player0()));
            object_cannot_take_damage(await this.player0());
            await sleep_until(async () => !(volume_test_objects(tv_slide_b, await this.player0())));
            object_can_take_damage(await this.player0());
        }

        [ScriptMethod(333, Lifecycle.Dormant)]
        public async Task slide_b_player1()
        {
            await sleep_until(async () => volume_test_object(tv_slide_b, await this.player1()));
            object_cannot_take_damage(await this.player1());
            await sleep_until(async () => !(volume_test_objects(tv_slide_b, await this.player1())));
            object_can_take_damage(await this.player1());
        }

        [ScriptMethod(334, Lifecycle.Dormant)]
        public async Task ai_ledge_c_flood_ini()
        {
            ai_place(ledge_c_flood_fr.Squad);
            ai_place(ledge_c_flood_dead.Squad);
            ai_kill_silent(ledge_c_flood_dead.Squad);
            await sleep(1);
            await sleep_until(async () => (short)ai_living_count(ledge_c_flood) <= 0);
            if (this.ledge_c_spawn && volume_test_objects_all(tv_ledge_c_fr, players()))
            {
                ai_place(ledge_c_flood_bk.Squad);
            }
        }

        [ScriptMethod(335, Lifecycle.Dormant)]
        public async Task ai_ledge_c_infection_spawn()
        {
            if (await this.difficulty_normal())
            {
                this.ledge_c_infec_limit = 3;
            }
            else if (await this.difficulty_heroic())
            {
                this.ledge_c_infec_limit = 6;
            }
            else if (await this.difficulty_legendary())
            {
                this.ledge_c_infec_limit = 9;
            }

            await sleep_until(async () => volume_test_objects_all(tv_ledge_c_fr, players()));
            await sleep((short)random_range(120, 180));
            await sleep_until(async () =>
            {
                ai_place(ledge_c_infec_fr.Squad);
                this.ledge_c_infec_count = (short)(this.ledge_c_infec_count + 1);
                await sleep_until(async () => (short)ai_swarm_count(ledge_c_infec_fr.Squad) <= 5);
                return this.ledge_c_infec_count == this.ledge_c_infec_limit;
            });
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task cs_ledge_c_phantom()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(1F);
            cs_look(true, GetReference<ISpatialPoint>("ledge_c_phantom/p1"));
            await sleep_until(async () => this.g_ledge_c_phantom_start);
            cs_look(false, GetReference<ISpatialPoint>("ledge_c_phantom/p1"));
            cs_turn_sharpness(true, 0.7F);
            await sleep_until(async () => this.g_ledge_c_phantom_1, 5, 150);
            cs_look(true, GetReference<ISpatialPoint>("ledge_c_phantom/p3"));
            await sleep(60);
            cs_look(false, GetReference<ISpatialPoint>("ledge_c_phantom/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("ledge_c_phantom/p2"), 4F);
            cs_fly_by(GetReference<ISpatialPoint>("ledge_c_phantom/p3"), 4F);
            cs_fly_by(GetReference<ISpatialPoint>("ledge_c_phantom/p4"), 6F);
            cs_fly_by(GetReference<ISpatialPoint>("ledge_c_phantom/p5"), 6F);
            cs_fly_by(GetReference<ISpatialPoint>("ledge_c_phantom/p6"), 10F);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(337, Lifecycle.Dormant)]
        public async Task cs_mortar_a()
        {
            await sleep_until(async () =>
            {
                begin_random(async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_a), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_b), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_c), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_d), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_e), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_f), 
                    async () => await sleep((short)random_range(15, 45)));
                return this.g_mortar_fire;
            });
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task cs_mortar_b()
        {
            await sleep_until(async () =>
            {
                begin_random(async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_a), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_b), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_c), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_d), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_e), 
                    async () => await sleep((short)random_range(15, 45)), 
                    async () => effect_new(GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 4268694588U), mortar_f), 
                    async () => await sleep((short)random_range(15, 45)));
                return this.g_mortar_fire;
            });
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task cs_go_to_bridge()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("qz_ini/p0"));
            cs_go_to(GetReference<ISpatialPoint>("qz_ini/p1"));
            cs_go_to(GetReference<ISpatialPoint>("qz_ini/bridge"));
        }

        [ScriptMethod(340, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_a()
        {
            ai_place(qz_ini_ins_pods.a);
            object_create(qz_ent_pod_a);
            objects_attach(qz_ent_pod_a.Entity, "pod_attach", ai_vehicle_get(qz_ini_ins_pods.a), "pod_attach");
            await sleep(1);
            device_set_position(qz_ent_pod_a.Entity, 1F);
            await sleep_until(async () => device_get_position(qz_ent_pod_a.Entity) >= 1F, 1);
            objects_detach(qz_ent_pod_a.Entity, ai_vehicle_get(qz_ini_ins_pods.a));
            object_destroy(qz_ent_pod_a.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(qz_ini_ins_pods.a), "door", 500F);
            await sleep(15);
            ai_vehicle_exit(qz_ini_ins_pods.a);
        }

        [ScriptMethod(341, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_b()
        {
            ai_place(qz_ini_ins_pods.b);
            object_create(qz_ent_pod_b);
            objects_attach(qz_ent_pod_b.Entity, "pod_attach", ai_vehicle_get(qz_ini_ins_pods.b), "pod_attach");
            await sleep(1);
            device_set_position(qz_ent_pod_b.Entity, 1F);
            await sleep_until(async () => device_get_position(qz_ent_pod_b.Entity) >= 1F, 1);
            objects_detach(qz_ent_pod_b.Entity, ai_vehicle_get(qz_ini_ins_pods.b));
            object_destroy(qz_ent_pod_b.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(qz_ini_ins_pods.b), "door", 500F);
            await sleep(15);
            ai_vehicle_exit(qz_ini_ins_pods.b);
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_c()
        {
            ai_place(qz_ini_ins_pods.c);
            object_create(qz_ent_pod_c);
            objects_attach(qz_ent_pod_c.Entity, "pod_attach", ai_vehicle_get(qz_ini_ins_pods.c), "pod_attach");
            await sleep(1);
            device_set_position(qz_ent_pod_c.Entity, 1F);
            await sleep_until(async () => device_get_position(qz_ent_pod_c.Entity) >= 1F, 1);
            objects_detach(qz_ent_pod_c.Entity, ai_vehicle_get(qz_ini_ins_pods.c));
            object_destroy(qz_ent_pod_c.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(qz_ini_ins_pods.c), "door", 500F);
            await sleep(15);
            ai_vehicle_exit(qz_ini_ins_pods.c);
            await sleep(30);
            cs_run_command_script(qz_ini_ins_pods.c, new ScriptMethodReference(cs_go_to_bridge));
        }

        [ScriptMethod(343, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_d()
        {
            ai_place(qz_ini_ins_pods.d);
            object_create(qz_ent_pod_d);
            objects_attach(qz_ent_pod_d.Entity, "pod_attach", ai_vehicle_get(qz_ini_ins_pods.d), "pod_attach");
            await sleep(1);
            device_set_position(qz_ent_pod_d.Entity, 1F);
            await sleep_until(async () => device_get_position(qz_ent_pod_d.Entity) >= 1F, 1);
            objects_detach(qz_ent_pod_d.Entity, ai_vehicle_get(qz_ini_ins_pods.d));
            object_destroy(qz_ent_pod_d.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(qz_ini_ins_pods.d), "door", 500F);
            await sleep(15);
            ai_vehicle_exit(qz_ini_ins_pods.d);
            await sleep(30);
            cs_run_command_script(qz_ini_ins_pods.d, new ScriptMethodReference(cs_go_to_bridge));
            unit_set_maximum_vitality(ai_get_unit(qz_ini_ins_pods.d), 1F, 0F);
        }

        [ScriptMethod(344, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_e()
        {
            ai_place(qz_ini_ins_pods.e);
            object_create(qz_ent_pod_e);
            objects_attach(qz_ent_pod_e.Entity, "pod_attach", ai_vehicle_get(qz_ini_ins_pods.e), "pod_attach");
            await sleep(1);
            device_set_position(qz_ent_pod_e.Entity, 1F);
            await sleep_until(async () => device_get_position(qz_ent_pod_e.Entity) >= 1F, 1);
            objects_detach(qz_ent_pod_e.Entity, ai_vehicle_get(qz_ini_ins_pods.e));
            object_destroy(qz_ent_pod_e.Entity);
            await sleep((short)random_range(20, 45));
            object_damage_damage_section(ai_vehicle_get(qz_ini_ins_pods.e), "door", 500F);
            await sleep(15);
            ai_vehicle_exit(qz_ini_ins_pods.e);
            await sleep(30);
            cs_run_command_script(qz_ini_ins_pods.e, new ScriptMethodReference(cs_go_to_bridge));
            unit_set_maximum_vitality(ai_get_unit(qz_ini_ins_pods.e), 1F, 0F);
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task ai_qz_ini_turrets()
        {
            ai_vehicle_enter(qz_ini_flood, ai_get_unit(qz_ini_turrets.Squad));
        }

        [ScriptMethod(346, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pods()
        {
            begin_random(async () => wake(new ScriptMethodReference(ai_cov_ins_pod_a)), 
                async () => await sleep((short)random_range(0, 15)), 
                async () => wake(new ScriptMethodReference(ai_cov_ins_pod_b)), 
                async () => await sleep((short)random_range(0, 15)), 
                async () => wake(new ScriptMethodReference(ai_cov_ins_pod_c)), 
                async () => await sleep((short)random_range(0, 15)), 
                async () => wake(new ScriptMethodReference(ai_cov_ins_pod_e)), 
                async () => await sleep((short)random_range(0, 15)));
            await sleep(120);
            wake(new ScriptMethodReference(sc_qz_initial));
        }

        [ScriptMethod(347, Lifecycle.Dormant)]
        public async Task ai_qz_ini_exit_turrets()
        {
            await sleep_until(async () => (short)ai_living_count(qz_ini_flood) <= 1 || volume_test_objects(tv_cov_defense, players()));
            ai_vehicle_exit(qz_ini_ins_pods.Squad);
        }

        [ScriptMethod(348, Lifecycle.Dormant)]
        public async Task cs_crash_factory()
        {
            await sleep(90);
            await sleep_until(async () => objects_can_see_object(players(), factory.Entity, 30F) || volume_test_objects(tv_qz_camp, players()), 30, 180);
            await sleep(30);
            device_set_position(factory.Entity, 1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\visual_effects\\shq_factory_explode\\factory_explode", 4201125960U), factory_sound.Entity, 1F);
            this.g_mortar_fire = true;
            await sleep_until(async () => device_get_position(factory.Entity) >= 0.025F, 10);
            wake(new ScriptMethodReference(ai_cov_ins_pods));
            await sleep_until(async () => device_get_position(factory.Entity) >= 0.1F);
            object_destroy(factory.Entity);
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task ai_qz_ini_flood()
        {
            ai_place(qz_initial_flood_camp.Squad);
            ai_play_line_on_object(qz_ini_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_ini_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep_until(async () => (short)ai_living_count(qz_initial_flood_camp.Squad) <= 2);
            if (!(this.g_qz_ini_cave))
            {
                ai_place(qz_initial_flood_camp.Squad);
                ai_play_line_on_object(qz_ini_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
                ;
                ai_play_line_on_object(qz_ini_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(350, Lifecycle.Static)]
        public async Task qz_cov_def_abc()
        {
            if (this.debug)
            {
                print("wave abc");
            }

            ai_place(qz_cov_def_flood_a1.Squad);
            ai_place(qz_cov_def_flood_b1.Squad);
            ai_place(qz_cov_def_flood_c1.Squad);
            await sleep(5);
            ai_play_line_on_object(qz_cov_def_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_c.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_a);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(351, Lifecycle.Static)]
        public async Task qz_cov_def_bcd()
        {
            if (this.debug)
            {
                print("wave bcd");
            }

            ai_place(qz_cov_def_flood_b1.Squad);
            ai_place(qz_cov_def_flood_c1.Squad);
            ai_place(qz_cov_def_flood_d1.Squad);
            await sleep(5);
            ai_play_line_on_object(qz_cov_def_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_c.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_d.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_ab);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(352, Lifecycle.Static)]
        public async Task qz_cov_def_def()
        {
            if (this.debug)
            {
                print("wave def");
            }

            ai_place(qz_cov_def_flood_d1.Squad);
            ai_place(qz_cov_def_flood_e1.Squad);
            ai_place(qz_cov_def_flood_f1.Squad);
            await sleep(5);
            ai_play_line_on_object(qz_cov_def_sound_d.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_e.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_f.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_bc);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(353, Lifecycle.Static)]
        public async Task qz_cov_def_efg()
        {
            if (this.debug)
            {
                print("wave efg");
            }

            ai_place(qz_cov_def_flood_e1.Squad);
            ai_place(qz_cov_def_flood_f1.Squad);
            ai_place(qz_cov_def_flood_g1.Squad);
            await sleep(5);
            ai_play_line_on_object(qz_cov_def_sound_e.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_f.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_g.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_c);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(354, Lifecycle.Static)]
        public async Task qz_cov_def_ag()
        {
            if (this.debug)
            {
                print("wave ag");
            }

            ai_place(qz_cov_def_flood_a1.Squad);
            ai_place(qz_cov_def_flood_g1.Squad);
            await sleep(5);
            ai_play_line_on_object(qz_cov_def_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_play_line_on_object(qz_cov_def_sound_g.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_ac);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task qz_cov_def_d()
        {
            if (this.debug)
            {
                print("wave d");
            }

            ai_place(qz_cov_def_flood_d1.Squad);
            await sleep(5);
            ai_play_line_on_object(qz_cov_def_sound_d.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_b);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await sleep_until(async () => (short)ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(356, Lifecycle.Dormant)]
        public async Task ai_qz_cov_def_flood_spawn()
        {
            if (await this.difficulty_normal())
            {
                this.g_qz_cov_def_limit = 2;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_qz_cov_def_limit = 4;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_qz_cov_def_limit = 6;
            }

            begin_random(async () =>
            {
                if (this.g_qz_cov_def_spawn)
                {
                    this.g_qz_cov_def_count = (short)(this.g_qz_cov_def_count + 1);
                    await this.qz_cov_def_abc();
                    if (this.g_qz_cov_def_count == this.g_qz_cov_def_limit)
                    {
                        this.g_qz_cov_def_spawn = false;
                    }

                    await sleep((short)(30 * 10));
                }
            }, 
                async () =>
            {
                if (this.g_qz_cov_def_spawn)
                {
                    this.g_qz_cov_def_count = (short)(this.g_qz_cov_def_count + 1);
                    await this.qz_cov_def_bcd();
                    if (this.g_qz_cov_def_count == this.g_qz_cov_def_limit)
                    {
                        this.g_qz_cov_def_spawn = false;
                    }

                    await sleep((short)(30 * 10));
                }
            }, 
                async () =>
            {
                if (this.g_qz_cov_def_spawn)
                {
                    this.g_qz_cov_def_count = (short)(this.g_qz_cov_def_count + 1);
                    await this.qz_cov_def_def();
                    if (this.g_qz_cov_def_count == this.g_qz_cov_def_limit)
                    {
                        this.g_qz_cov_def_spawn = false;
                    }

                    await sleep((short)(30 * 10));
                }
            }, 
                async () =>
            {
                if (this.g_qz_cov_def_spawn)
                {
                    this.g_qz_cov_def_count = (short)(this.g_qz_cov_def_count + 1);
                    await this.qz_cov_def_efg();
                    if (this.g_qz_cov_def_count == this.g_qz_cov_def_limit)
                    {
                        this.g_qz_cov_def_spawn = false;
                    }

                    await sleep((short)(30 * 10));
                }
            }, 
                async () =>
            {
                if (this.g_qz_cov_def_spawn)
                {
                    this.g_qz_cov_def_count = (short)(this.g_qz_cov_def_count + 1);
                    await this.qz_cov_def_ag();
                    if (this.g_qz_cov_def_count == this.g_qz_cov_def_limit)
                    {
                        this.g_qz_cov_def_spawn = false;
                    }

                    await sleep((short)(30 * 10));
                }
            }, 
                async () =>
            {
                if (this.g_qz_cov_def_spawn)
                {
                    this.g_qz_cov_def_count = (short)(this.g_qz_cov_def_count + 1);
                    await this.qz_cov_def_d();
                    if (this.g_qz_cov_def_count == this.g_qz_cov_def_limit)
                    {
                        this.g_qz_cov_def_spawn = false;
                    }

                    await sleep((short)(30 * 10));
                }
            });
        }

        [ScriptMethod(357, Lifecycle.Dormant)]
        public async Task ai_qz_cov_def_carrier()
        {
            await sleep_until(async () => this.g_qz_cov_def_count == 2);
            game_save_no_timeout();
            ai_place(qz_cov_def_carrier1.Squad);
            await sleep_until(async () => this.g_qz_cov_def_count == 4);
            game_save_no_timeout();
            ai_place(qz_cov_def_carrier1.Squad);
            await sleep_until(async () => this.g_qz_cov_def_count == 6);
            game_save_no_timeout();
            ai_place(qz_cov_def_carrier1.Squad);
        }

        [ScriptMethod(358, Lifecycle.Dormant)]
        public async Task you_win()
        {
            if (this.debug)
            {
                print("you win script called...");
            }

            await sleep_until(async () => this.g_qz_phantom, 30, 30 * 60 * 2);
            await sleep(120);
            await this.playtest_mission();
            sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            game_won();
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_qz_phantom()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_phantom/p0"), 3F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("qz_phantom/p1"), 3F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("qz_phantom/p3"), 5F);
            ai_magically_see(covenant1, flood);
            cs_vehicle_speed(0.75F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("qz_phantom/p4"), GetReference<ISpatialPoint>("qz_phantom/p5"));
            ai_magically_see(covenant1, flood);
            await sleep_until(async () => !(volume_test_objects(tv_game_won, ai_actors(qz_cov_def_flood))), 30, 30 * 30);
            this.g_qz_phantom = true;
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task enc_insertion()
        {
            if (this.debug)
            {
                print("initialize insertion scripts");
            }

            game_save();
            data_mine_set_mission_segment("enc_insertion");
            if (await this.difficulty_normal())
            {
                object_destroy(ins_em_b.Entity);
            }
            else if (await this.difficulty_heroic())
            {
                object_destroy(ins_em_b.Entity);
            }

            ai_disregard(ai_actors(constructors), true);
            ai_place(ins_con_mid.Squad);
            ai_place(ins_con_bk.Squad);
            ai_place(pussy_grunt2.Squad);
            wake(new ScriptMethodReference(ins_open_door));
            wake(new ScriptMethodReference(pussy_grunt_reminder));
            wake(new ScriptMethodReference(music_06a_01));
            await sleep(1);
            if (!(await this.difficulty_legendary()))
            {
                await sleep_until(async () => (float)ai_strength(ins_cons) < 1F || volume_test_objects(tv_insertion_tube, players()), 5);
            }
            else
            {
                await sleep(150);
                wake(new ScriptMethodReference(ai_insertion_emitters));
            }

            if ((float)ai_strength(ins_cons) < 1F)
            {
                wake(new ScriptMethodReference(ai_insertion_emitters));
                if (device_get_position(piston_ins.Entity) == 0F)
                {
                    ai_set_orders(ins_con_mid.Squad, ins_run_away);
                    ai_set_orders(ins_con_bk.Squad, ins_run_away);
                }
            }

            wake(new ScriptMethodReference(pussy_grunt));
        }

        [ScriptMethod(361, Lifecycle.Dormant)]
        public async Task enc_hall_a()
        {
            if (this.g_hall_a)
            {
                await sleep_until(async () => volume_test_objects(tv_hall_a, players()), 10);
            }

            if (this.debug)
            {
                print("initialize hall a scripts");
            }

            game_save();
            data_mine_set_mission_segment("enc_hall_a");
            this.g_insertion_spawn = true;
            this.g_pussy_grunt = true;
            ai_disposable(insertion_sentinels, true);
            ai_disposable(ins_cons, true);
            ai_disposable(pussy_grunt2.Squad, true);
            ai_set_orders(constructors, hall_a_constructors);
            ai_set_orders(pussy_grunt2.Squad, hall_a_cov);
            wake(new ScriptMethodReference(ai_hall_a_const));
            if (!(await this.difficulty_legendary()))
            {
                await sleep_until(async () => (float)ai_strength(hall_a_cons) < 0.8F || volume_test_objects(tv_hall_a_bk, players()));
            }

            ai_place(hall_a_sen.h);
            await sleep(30);
            wake(new ScriptMethodReference(ai_hall_a_emitters));
        }

        [ScriptMethod(362, Lifecycle.Dormant)]
        public async Task enc_conduit_a()
        {
            if (this.g_conduit_a)
            {
                await sleep_until(async () => volume_test_objects(tv_conduit_a, players()), 10);
            }

            if (this.debug)
            {
                print("initialize conduit a scripts");
            }

            game_save();
            data_mine_set_mission_segment("enc_cond_a_sec_a");
            ai_disposable(hall_a_sentinels, true);
            ai_disposable(hall_a_cons, true);
            ai_place(cond_a_sen_ini1.Squad);
            ai_set_orders(covenant1, cond_a_cov_follow);
            await sleep(1);
            ai_place(cond_a_cov.Squad);
            await sleep(1);
            wake(new ScriptMethodReference(ai_sc_cond_a_cov));
            wake(new ScriptMethodReference(cond_a_initial_delay));
            wake(new ScriptMethodReference(music_06a_03));
            sleep_forever(new ScriptMethodReference(ai_hall_a_emitters));
            await sleep_until(async () => this.g_cond_a_continue);
            ai_renew(covenant1);
            wake(new ScriptMethodReference(ai_cond_a_emitters_fr));
            await sleep_until(async () => volume_test_objects(tv_cond_a_b, players()), 5);
            ai_renew(covenant1);
            wake(new ScriptMethodReference(sc_tartarus_reminder));
            wake(new ScriptMethodReference(ai_cond_a_back_ini));
            this.g_music_06a_03 = true;
            await sleep_until(async () => volume_test_objects(tv_cond_a_c, players()));
            game_save();
            data_mine_set_mission_segment("enc_cond_a_sec_b");
            ai_renew(covenant1);
            wake(new ScriptMethodReference(ai_cond_a_emitters_bk));
            sleep_forever(new ScriptMethodReference(ai_cond_a_emitters_fr));
        }

        [ScriptMethod(363, Lifecycle.Dormant)]
        public async Task enc_hall_b()
        {
            if (this.g_hall_b)
            {
                await sleep_until(async () => volume_test_objects(tv_hall_b, players()), 10);
            }

            if (this.debug)
            {
                print("initialize hall b scripts");
            }

            game_save();
            data_mine_set_mission_segment("enc_hall_b");
            ai_disposable(cond_a_sentinels, true);
            ai_disposable(cond_a_cov.Squad, true);
            sleep_forever(new ScriptMethodReference(ai_cond_a_emitters_bk));
            this.g_cond_a_front = true;
            this.g_cond_a_back = true;
            ai_place(hall_b_cov.Squad, (short)pin(4F - (float)ai_living_count(covenant1), 0F, 4F));
            wake(new ScriptMethodReference(ai_sc_hall_b_grunts));
            ai_set_orders(covenant1, hall_b_cov_follow);
            await sleep(1);
            ai_set_orders(covenant1, hall_b_cov_ini);
            ai_renew(covenant1);
            await sleep_until(async () => volume_test_objects(tv_hall_b_fr, players()));
            wake(new ScriptMethodReference(ai_hall_b_emitters));
            ai_set_orders(covenant1, hall_b_cov_follow);
            this.g_hall_b_sen_dialogue = true;
        }

        [ScriptMethod(364, Lifecycle.Dormant)]
        public async Task enc_plug_launch()
        {
            if (this.g_plug_launch)
            {
                await sleep_until(async () => volume_test_objects(tv_plug_launch, players()), 10);
            }

            if (this.debug)
            {
                print("initialize plug launch scripts");
            }

            wake(new ScriptMethodReference(plug_absorbers));
            game_save();
            data_mine_set_mission_segment("enc_plug_launch");
            ai_disposable(hall_b_cov.Squad, true);
            ai_disposable(hall_b_sentinels, true);
            object_dynamic_simulation_disable(plug.Entity, true);
            wake(new ScriptMethodReference(objective_lower_clear));
            wake(new ScriptMethodReference(objective_lower_specific_set));
            sleep_forever(new ScriptMethodReference(ai_hall_b_emitters));
            ai_renew(covenant1);
            ai_set_orders(covenant1, plug_launch_cov_ini);
            ai_place(plug_launch_enforcer.Squad);
            await sleep_until(async () => (short)ai_combat_status(plug_launch_enforcer.Squad) >= this.ai_combat_status_active, 30, 210);
            wake(new ScriptMethodReference(sc_enforcer));
            wake(new ScriptMethodReference(ai_plug_launch_em));
            await sleep(1);
            ai_set_orders(covenant1, plug_launch_cov_follow);
            await sleep_until(async () => this.g_plug_move);
            this.g_plug_launch_loops = true;
            wake(new ScriptMethodReference(cs_move_plug));
            wake(new ScriptMethodReference(music_06a_04));
        }

        [ScriptMethod(365, Lifecycle.Dormant)]
        public async Task enc_plug_landing()
        {
            if (this.g_plug_landing)
            {
                await sleep_until(async () => volume_test_objects(tv_plug_land, players()));
            }

            await sleep_until(async () => device_get_position(plug.Entity) >= 0.75F, 10);
            if (this.debug)
            {
                print("initialize plug landing scripts");
            }

            game_save_no_timeout();
            data_mine_set_mission_segment("enc_plug_landing");
            ai_disposable(plug_launch_enforcer.Squad, true);
            ai_disposable(plug_launch_sentinels, true);
            wake(new ScriptMethodReference(music_06a_05));
            wake(new ScriptMethodReference(ai_plug_holder_flood));
            wake(new ScriptMethodReference(ai_plug_holder_em));
            wake(new ScriptMethodReference(ai_plug_holder_em_elim));
            await sleep_until(async () => this.g_plugholder_progress || (short)ai_living_count(plug_holder_enforcer.Squad) <= 0, 30, 30 * 60 * 5);
            game_save_no_timeout();
            data_mine_set_mission_segment("enc_plug_landing_bk");
            await sleep((short)(30 * 5));
            this.g_music_06a_04 = false;
            this.g_music_06a_05 = false;
            if (this.debug)
            {
                print("opening the escape hatch...");
            }

            ai_place(plugholder_sen_bk_ini.Squad);
            await sleep(30);
            device_set_position(plugholder_door.Entity, 1F);
            await sleep_until(async () => volume_test_objects(tv_plugholder_d, players()));
            game_save_no_timeout();
            this.g_music_06a_05 = false;
            ai_disposable(plug_holder_flood, true);
            ai_disposable(plug_holder_sentinels, true);
            ai_set_orders(plug_holder_sentinels, plugholder_sen_bk);
            ai_set_orders(plug_holder_enforcer.Squad, plugholder_enforcer_bk);
            this.g_plugholder_progress = true;
            wake(new ScriptMethodReference(close_plugholder_door));
            wake(new ScriptMethodReference(ai_plugholder_flood_bk));
            wake(new ScriptMethodReference(ai_plug_holder_bk_em));
            await sleep_until(async () => volume_test_objects(tv_plugholder_e, players()));
            this.g_plugholder_bk_a = true;
            game_save_no_timeout();
            await sleep_until(async () => volume_test_objects(tv_plugholder_f, players()));
            this.g_plugholder_bk_b = true;
            game_save_no_timeout();
            data_mine_set_mission_segment("enc_plug_landing_lower");
            ai_place(plugholder_lower_hall_flood.Squad);
            ai_place(plugholder_lower_hall_infec.Squad);
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task enc_hall_c()
        {
            if (this.g_hall_c)
            {
                await sleep_until(async () => volume_test_objects(tv_hall_c, players()), 10);
            }

            if (this.debug)
            {
                print("initialize hall c scripts");
            }

            game_save_no_timeout();
            data_mine_set_mission_segment("enc_hall_c_sec_a");
            ai_disposable(plug_holder_flood_bk, true);
            ai_disposable(plugholder_bk_infec_a.Squad, true);
            ai_disposable(plugholder_bk_infec_b.Squad, true);
            sleep_forever(new ScriptMethodReference(ai_plugholder_infec_bk_a));
            sleep_forever(new ScriptMethodReference(ai_plugholder_infec_bk_b));
            await sleep_until(async () => volume_test_objects(tv_hall_c_a, players()), 5);
            game_save_no_timeout();
            wake(new ScriptMethodReference(ai_hall_c_ini));
            await sleep(5);
            ai_magically_see(hall_c_marines1.Squad, hall_c_flood_far.Squad);
            ai_magically_see(hall_c_flood_far.Squad, hall_c_marines1.Squad);
            await sleep_until(async () => volume_test_objects(tv_hall_c_b, players()), 10);
            game_save_no_timeout();
            data_mine_set_mission_segment("enc_hall_c_sec_b");
            wake(new ScriptMethodReference(kill_hall_c_marines));
            ai_place(hall_c_flood_mid.Squad);
            await sleep(1);
            ai_set_orders(hall_c_flood, hall_c_floor_b);
            await sleep_until(async () => volume_test_objects(tv_hall_c_c, players()), 10);
            game_save_no_timeout();
            ai_place(hall_c_flood_c.Squad, (short)pin(8F - (float)ai_nonswarm_count(hall_c_flood), 0F, 6F));
            ai_place(hall_c_carrier_c.Squad);
            ai_place(hall_c_sen_tube1.Squad);
            await sleep(1);
            ai_set_orders(hall_c_flood, hall_c_floor_c);
            await sleep_until(async () => volume_test_objects(tv_hall_c_d, players()), 10);
            game_save_no_timeout();
            data_mine_set_mission_segment("enc_hall_c_sec_c");
            ai_place(hall_c_flood_d.Squad, (short)pin(8F - (float)ai_nonswarm_count(hall_c_flood), 0F, 6F));
            ai_place(hall_c_carrier_d.Squad);
            await sleep(1);
            ai_set_orders(hall_c_flood, hall_c_floor_d);
            await sleep_until(async () => volume_test_objects(tv_hall_c_e, players()), 10);
            game_save_no_timeout();
            ai_place(hall_c_flood_e.Squad, (short)pin(8F - (float)ai_nonswarm_count(hall_c_flood), 0F, 6F));
            ai_place(hall_c_carrier_e.Squad);
            await sleep(1);
            ai_set_orders(hall_c_flood, hall_c_floor_e);
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task enc_ledge_a()
        {
            if (this.g_ledge_a)
            {
                await sleep_until(async () => volume_test_objects(tv_ledge_a, players()), 10);
            }

            if (this.debug)
            {
                print("initialize ledge a scripts");
            }

            game_save_no_timeout();
            data_mine_set_mission_segment("enc_ledge_a_sec_a");
            ai_disposable(hall_c_flood, true);
            wake(new ScriptMethodReference(ai_ledge_a_initial));
            ai_place(ledge_a_flood_dead.Squad);
            await sleep_until(async () => (short)ai_living_count(ledge_a_flood_ini1.Squad) <= 0 || volume_test_objects(tv_ledge_a_top_b, players()));
            await sleep_until(async () => volume_test_objects(tv_ledge_a_top_b, players()));
            game_save_no_timeout();
            wake(new ScriptMethodReference(ai_ledge_a_location));
            wake(new ScriptMethodReference(ai_ledge_a_emitters));
            wake(new ScriptMethodReference(ai_ledge_a_flood_spawn));
            await sleep_until(async () => volume_test_objects(tv_ledge_a_top_d1, players()));
            game_save_no_timeout();
            ai_place(ledge_a_flood_d1.Squad);
            await sleep_until(async () => volume_test_objects(tv_ledge_a_top_d2, players()));
            game_save_no_timeout();
            data_mine_set_mission_segment("enc_ledge_a_sec_b");
            ai_place(ledge_a_flood_d2.Squad);
            await sleep_until(async () => volume_test_objects(tv_ledge_a_top_e, players()));
            game_save_no_timeout();
            ai_set_orders(ledge_a_flood, ledge_a_floor_follow);
        }

        [ScriptMethod(368, Lifecycle.Dormant)]
        public async Task enc_conduit_b()
        {
            if (this.g_conduit_b)
            {
                await sleep_until(async () => volume_test_objects(tv_conduit_b, players()), 10);
            }

            if (this.debug)
            {
                print("initialize conduit b scripts");
            }

            game_save_no_timeout();
            data_mine_set_mission_segment("enc_cond_b_sec_a");
            ai_disposable(ledge_a_sentinels, true);
            ai_disposable(ledge_a_enforcer.Squad, true);
            ai_disposable(ledge_a_flood, true);
            wake(new ScriptMethodReference(music_06a_06));
            wake(new ScriptMethodReference(music_06a_07));
            if (await this.difficulty_legendary())
            {
                wake(new ScriptMethodReference(ice_cream_mythic));
            }

            this.g_music_06a_06 = true;
            this.g_ledge_a_spawn = true;
            wake(new ScriptMethodReference(ai_cond_b_flood_spawn));
            wake(new ScriptMethodReference(conduit_b_locator));
            wake(new ScriptMethodReference(ai_cond_b_carrier_a));
            await sleep_until(async () => volume_test_objects(tv_cond_b_a2, players()), 10);
            game_save_no_timeout();
            ai_place(cond_b_flood_tube_a.Squad);
            this.cond_b_flood_a_spawn = true;
            await sleep(5);
            ai_set_orders(cond_b_flood, cond_b_floor_follow_a);
            await sleep_until(async () => volume_test_objects(tv_cond_b_b1, players()), 10);
            game_save_no_timeout();
            data_mine_set_mission_segment("enc_cond_b_sec_b");
            ai_set_orders(cond_b_flood, cond_b_floor_follow_b);
            ai_place(cond_b_sen_b._1);
            ai_place(cond_b_sen_b._3);
            ai_place(cond_b_flood_b_ini1.Squad);
            wake(new ScriptMethodReference(ai_cond_b_b_em));
            await sleep(5);
            await sleep_until(async () => volume_test_objects(tv_cond_b_b2, players()), 10);
            game_save_no_timeout();
            this.g_music_06a_07 = true;
            sleep_forever(new ScriptMethodReference(ai_cond_b_b_em));
            wake(new ScriptMethodReference(ai_cond_b_sen_tube_b));
            ai_set_orders(cond_b_flood, cond_b_floor_follow_c);
            ai_disposable(ledge_a_flood, true);
            ai_disposable(ledge_a_sentinels, true);
            ai_disposable(ledge_a_enforcer.Squad, true);
            ai_disposable(cond_b_flood, true);
            await sleep_until(async () => volume_test_objects(tv_cond_b_c, players()), 10);
            game_save_no_timeout();
            data_mine_set_mission_segment("enc_cond_b_sec_c");
            wake(new ScriptMethodReference(sc_marines_a));
            this.cond_b_flood_b_spawn = true;
            ai_place(cond_b_humans1.Squad);
            ai_place(cond_b_flood_c_ini_a1.Squad, (short)pin(6F - (float)ai_living_count(cond_b_flood), 0F, 4F));
            await sleep(1);
            ai_place(cond_b_flood_c_ini_b1.Squad, (short)pin(6F - (float)ai_living_count(cond_b_flood), 0F, 4F));
            ai_place(cond_b_infection_c.Squad, 2);
            await sleep(5);
            await sleep_until(async () => volume_test_objects(tv_cond_b_hum_dead, players()), 10);
            game_save_no_timeout();
            wake(new ScriptMethodReference(kill_cond_b_marines));
        }

        [ScriptMethod(369, Lifecycle.Dormant)]
        public async Task enc_ledge_b()
        {
            if (this.g_ledge_b)
            {
                await sleep_until(async () => volume_test_objects(tv_ledge_b, players()), 10);
            }

            if (this.debug)
            {
                print("initialize ledge b scripts");
            }

            game_save();
            data_mine_set_mission_segment("enc_ledge_b");
            ai_disposable(cond_b_flood, true);
            ai_disposable(cond_b_sentinels, true);
            ai_disposable(cond_b_infection_c.Squad, true);
            this.cond_b_flood_c_spawn = true;
            ai_place(ledge_b_flood.Squad);
            ai_place(ledge_c_phantom.Squad);
            wake(new ScriptMethodReference(slide_a_player0));
            wake(new ScriptMethodReference(slide_a_player1));
            wake(new ScriptMethodReference(music_06a_08));
            wake(new ScriptMethodReference(music_06a_09));
            wake(new ScriptMethodReference(music_06a_10));
        }

        [ScriptMethod(370, Lifecycle.Dormant)]
        public async Task enc_ledge_c()
        {
            if (this.g_ledge_c)
            {
                await sleep_until(async () => volume_test_objects(tv_ledge_c, players()), 10);
            }

            if (this.debug)
            {
                print("initialize ledge c scripts");
            }

            game_save_no_timeout();
            data_mine_set_mission_segment("enc_ledge_c");
            ai_disposable(ledge_b_sen1.Squad, true);
            wake(new ScriptMethodReference(ai_ledge_c_flood_ini));
            wake(new ScriptMethodReference(ai_ledge_c_infection_spawn));
            ai_magically_see(ledge_c_flood, ledge_c_phantom.Squad);
            this.g_ledge_c_phantom_start = true;
            await sleep_until(async () => volume_test_objects(tv_ledge_c_bk, players()));
            game_save_no_timeout();
            this.ledge_c_spawn = false;
            this.g_ledge_c_phantom_1 = true;
            ai_place(ledge_c_flood_bk.Squad, (short)pin(6F - (float)ai_living_count(ledge_c_flood), 0F, 6F));
            wake(new ScriptMethodReference(slide_b_player0));
            wake(new ScriptMethodReference(slide_b_player1));
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task enc_qz_initial()
        {
            if (this.g_qz_initial)
            {
                await sleep_until(async () => volume_test_objects(tv_qz_initial, players()), 10);
            }

            if (this.debug)
            {
                print("initialize quarantine zone initial scripts");
            }

            game_save_no_timeout();
            data_mine_set_mission_segment("enc_qz_initial");
            ai_disposable(ledge_c_flood, true);
            wake(new ScriptMethodReference(cs_mortar_a));
            wake(new ScriptMethodReference(cs_mortar_b));
            await sleep_until(async () => device_get_position(qz_door.Entity) > 0F, 1);
            wake(new ScriptMethodReference(chapter_war));
            wake(new ScriptMethodReference(objective_floodwall_clear));
            wake(new ScriptMethodReference(objective_rendezvous_set));
            wake(new ScriptMethodReference(cs_crash_factory));
            this.g_music_06a_10 = false;
            ai_place(qz_initial_flood_ini.Squad);
            ai_place(qz_initial_flood_carrier_ini.Squad);
            ai_place(qz_initial_flood_bridge.Squad);
            ai_place(qz_initial_flood_carrier_camp.Squad);
            if (await this.difficulty_normal())
            {
                ai_place(qz_ini_turrets.a);
            }
            else
            {
                ai_place(qz_ini_turrets.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_qz_camp, players()), 10);
            if (this.debug)
            {
                print("camp");
            }

            game_save_no_timeout();
            data_mine_set_mission_segment("enc_qz_initial_camp");
            wake(new ScriptMethodReference(ai_qz_ini_flood));
            await sleep_until(async () => volume_test_objects(tv_qz_cave, players()), 10);
            if (this.debug)
            {
                print("cave");
            }

            this.g_qz_ini_cave = true;
            ai_place(qz_initial_flood_cave.Squad);
            ai_play_line_on_object(qz_ini_sound_cave.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            wake(new ScriptMethodReference(ai_qz_ini_exit_turrets));
            game_save_no_timeout();
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task enc_cov_defense()
        {
            if (this.g_cov_defense)
            {
                await sleep_until(async () => volume_test_objects(tv_cov_defense, players()), 10);
            }

            if (this.debug)
            {
                print("initialize covenant defense scripts");
            }

            game_save();
            data_mine_set_mission_segment("enc_covenant_defense");
            ai_disposable(qz_ini_flood, true);
            ai_disposable(qz_cov_def_flood, true);
            ai_vehicle_reserve(ai_vehicle_get(qz_ini_turrets.Squad), true);
            ai_vehicle_exit(qz_ini_ins_pods.Squad);
            ai_migrate(qz_ini_ins_pods.Squad, qz_cov_def_cov.Squad);
            ai_set_orders(qz_ini_flood, qz_cov_def_hill);
            ai_place(qz_cov_def_flood_ini.Squad);
            ai_place(qz_cov_def_flood_g1.Squad);
            ai_place(qz_cov_def_cov.Squad, (short)pin(3F - (float)ai_living_count(qz_cov_def_cov.Squad), 0F, 2F));
            ai_place(qz_cov_def_soc.Squad);
            ai_place(qz_camp_turrets.Squad);
            object_cannot_die(ai_get_object(qz_cov_def_soc.soc), true);
            ai_set_orders(covenant1, qz_cov_def_cov_ac);
            await sleep_until(async () => (short)ai_living_count(qz_cov_def_flood) <= 0);
            ai_set_orders(covenant1, qz_cov_def_hill);
            await sleep(1);
            wake(new ScriptMethodReference(sc_qz_cov_camp));
            await sleep_until(async () => this.g_qz_cov_camp_progress);
            wake(new ScriptMethodReference(ai_qz_cov_def_flood_spawn));
            wake(new ScriptMethodReference(ai_qz_cov_def_carrier));
            await sleep(1);
            await sleep_until(async () => this.g_qz_cov_def_spawn == false);
            if (this.debug)
            {
                print("last of the flood waves have spawned");
            }

            await sleep((short)(30 * 5));
            game_save_no_timeout();
            ai_magically_see(covenant1, flood);
            if (this.debug)
            {
                print("phantom placed...");
            }

            ai_place(qz_phantom.Squad);
            wake(new ScriptMethodReference(you_win));
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task mission_sentinelwalls()
        {
            await this.cinematic_snap_to_white();
            switch_bsp(0);
            if (this.g_play_cinematics == true)
            {
                sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        print("x06");
                    }

                    await this.x06();
                }

                await this.cinematic_skip_stop();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        print("intro");
                    }

                    await this.c06_intro();
                }

                await this.cinematic_skip_stop();
            }

            await sleep(2);
            object_teleport(await this.player0(), player0_start);
            object_teleport(await this.player1(), player1_start);
            wake(new ScriptMethodReference(enc_insertion));
            wake(new ScriptMethodReference(piston_control));
            wake(new ScriptMethodReference(difficulty_settings));
            player_training_activate_stealth();
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_silence));
            wake(new ScriptMethodReference(objective_lower_set));
            if (await this.difficulty_normal())
            {
                if (this.debug)
                {
                    print("normal");
                }
            }
            else if (await this.difficulty_heroic())
            {
                if (this.debug)
                {
                    print("heroic");
                }
            }
            else if (await this.difficulty_legendary())
            {
                if (this.debug)
                {
                    print("legendary");
                }
            }

            await sleep_until(async () => this.g_hall_a || volume_test_objects(tv_hall_a, players()), 10);
            wake(new ScriptMethodReference(enc_hall_a));
            await sleep_until(async () => this.g_conduit_a || volume_test_objects(tv_conduit_a, players()), 10);
            wake(new ScriptMethodReference(enc_conduit_a));
            await sleep_until(async () => this.g_hall_b || volume_test_objects(tv_hall_b, players()), 10);
            wake(new ScriptMethodReference(enc_hall_b));
            await sleep_until(async () => this.g_plug_launch || volume_test_objects(tv_plug_launch, players()), 10);
            wake(new ScriptMethodReference(enc_plug_launch));
            await sleep_until(async () => this.g_plug_landing || volume_test_objects(tv_plug_land, players()), 10);
            wake(new ScriptMethodReference(enc_plug_landing));
            await sleep_until(async () => this.g_hall_c || volume_test_objects(tv_hall_c, players()), 10);
            wake(new ScriptMethodReference(enc_hall_c));
            await sleep_until(async () => this.g_ledge_a || volume_test_objects(tv_ledge_a, players()), 10);
            wake(new ScriptMethodReference(enc_ledge_a));
            await sleep_until(async () => this.g_conduit_b || volume_test_objects(tv_conduit_b, players()), 10);
            wake(new ScriptMethodReference(enc_conduit_b));
            await sleep_until(async () => this.g_ledge_b || volume_test_objects(tv_ledge_b, players()), 10);
            wake(new ScriptMethodReference(enc_ledge_b));
            await sleep_until(async () => this.g_ledge_c || volume_test_objects(tv_ledge_c, players()), 10);
            wake(new ScriptMethodReference(enc_ledge_c));
            await sleep_until(async () => this.g_qz_initial || volume_test_objects(tv_qz_initial, players()), 10);
            this.g_piston_control = true;
            wake(new ScriptMethodReference(enc_qz_initial));
            await sleep_until(async () => this.g_cov_defense || volume_test_objects(tv_cov_defense, players()), 10);
            wake(new ScriptMethodReference(enc_cov_defense));
        }

        [ScriptMethod(374, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_sentinelwalls));
        }

        [ScriptMethod(375, Lifecycle.Startup)]
        public async Task mission_main()
        {
            ai_allegiance(covenant, player);
            ai_allegiance(player, covenant);
            ai_allegiance(prophet, player);
            ai_allegiance(player, prophet);
            ai_allegiance(covenant, prophet);
            ai_allegiance(prophet, covenant);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task x06_01a_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3867870485U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3867870485U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\fp_covenant_carbine\\fp_covenant_carbine", 3807379834U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_top\\door_piston_top", 3868198170U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3869967669U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3870491965U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 29, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3870754113U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3871868242U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787194438U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await sleep(166);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 3874227574U), 1);
            await sleep(32);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 2);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3876717980U), 9);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 32, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 15, false);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\brute_honor_helmet_scenery", 3880912348U), 0);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3881305570U), 0);
            await sleep(16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3824026232U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 11);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 25);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 14);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            await sleep(47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 13);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3884975642U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 33);
            await sleep(24);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            await sleep(61);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 29);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            await sleep(52);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\brute_honor_helmet_scenery", 3880912348U), 0);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3881305570U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            await sleep(11);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3871868242U), 0);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            await sleep(33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 41);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, false);
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task x06_01b_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            await sleep(75);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\brute_honor_helmet_scenery", 3880912348U), 0);
            await sleep(68);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3870754113U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3885106716U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_space\\high_charity_space", 3885762086U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3824026232U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 0);
            await sleep(64);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3824026232U), 1);
            await sleep(43);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3824026232U), 2);
            await sleep(35);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3824026232U), 2);
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task x06_02_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3870754113U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3885106716U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_space\\high_charity_space", 3885762086U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 2);
            await sleep(20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 32);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 26);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 10);
            await sleep(239);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3884975642U), 0);
            await sleep(39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 10);
            await sleep(60);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3884975642U), 0);
            await sleep(84);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 41);
            await sleep(334);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881960940U), 26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3884975642U), 0);
            await sleep(43);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 41);
            await sleep(76);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 41);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            await sleep(17);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3871868242U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task x06_03_predict()
        {
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            await sleep(117);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 41);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3871868242U), 0);
            await sleep(141);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 1);
            await sleep(39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            await sleep(183);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 2);
            await sleep(100);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task x06_04_predict()
        {
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3875997073U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 10);
            await sleep(571);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 1);
            await sleep(158);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 0);
            await sleep(120);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3871868242U), 0);
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task x06_05_predict()
        {
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 10);
            await sleep(275);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891988101U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            await sleep(37);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3871868242U), 0);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            await sleep(43);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 0);
            await sleep(229);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_alone\\index_alone", 3892577934U), 0);
            await sleep(162);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3875407240U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3886024234U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3891463805U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3871868242U), 0);
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task _06_intro_01_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 27, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 143, false);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3893823137U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3894150822U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3885106716U), 0);
            await sleep(182);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\cinematics\\cinematics", 3894478507U), 0);
            await sleep(140);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 2);
            await sleep(218);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3883009532U), 34);
            await sleep(74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 2);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task _06_intro_02_predict()
        {
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 16);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\mount_doom\\mount_doom", 3894806192U), 0);
            await sleep(154);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 33, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\antennae_comm\\antennae_comm", 3895068340U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\antennae_comm\\antennae_comm", 3895068340U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\antennae_comm\\antennae_comm", 3895068340U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3896248006U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\fuselage_arm\\fuselage_arm", 3896706765U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\fuselage\\fuselage", 3897034450U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\head\\head", 3897099987U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3897165524U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3808035204U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3897558746U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3897558746U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\arm\\arm", 3898345190U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3898410727U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3870491965U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3898541801U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\senhq_detail_crate\\shq_cover_small\\shq_cover_small", 3899000560U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3824026232U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_top\\door_piston_top", 3868198170U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3899721467U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3899721467U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3899721467U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3899721467U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3899721467U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3901359892U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3901359892U), 12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\door_piston_absorber", 3903194928U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\sentinel_emitter\\sentinel_emitter", 3903653687U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3869967669U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\bullshit_switch\\bullshit_switch", 3904767816U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786276920U), 9);
            await sleep(9);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 7);
            await sleep(62);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 4);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 24, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3897165524U), 3);
            await sleep(40);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 25, false);
            await sleep(53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 2);
            await sleep(13);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3897165524U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3897558746U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3897558746U), 1);
            await sleep(21);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 0);
            await sleep(28);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 39, true);
            await sleep(59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 48);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 49);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 50);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 51);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 52);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 54);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 56);
            await sleep(139);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 40, true);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\fuselage_arm\\fuselage_arm", 3896706765U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 48);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 49);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 50);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 51);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 52);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 54);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 55);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 56);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\arm\\arm", 3898345190U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 6, true);
            await sleep(51);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 25, false);
            await sleep(47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 66);
            await sleep(18);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3905029964U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3824026232U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\garbage\\thruster\\thruster", 3854763085U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3851158550U), 73);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892971156U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 4);
            await sleep(16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 7);
            await sleep(19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 4);
            await sleep(20);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3904964427U), 1);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 212, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 211, false);
            await sleep(47);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 39, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3833332486U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788374104U), 2);
        }

        [ScriptMethod(384, Lifecycle.Static)]
        public async Task tele_insertion()
        {
            map_reset();
        }

        [ScriptMethod(385, Lifecycle.Static)]
        public async Task tele_hall_a()
        {
            switch_bsp(0);
            await sleep(1);
            object_teleport(await this.player0(), hall_a_a);
            object_teleport(await this.player1(), hall_a_b);
            ai_erase_all();
            this.g_hall_a = true;
        }

        [ScriptMethod(386, Lifecycle.Static)]
        public async Task tele_conduit_a()
        {
            switch_bsp(0);
            await sleep(1);
            object_teleport(await this.player0(), conduit_a_a);
            object_teleport(await this.player1(), conduit_a_b);
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
        }

        [ScriptMethod(387, Lifecycle.Static)]
        public async Task tele_hall_b()
        {
            switch_bsp(0);
            await sleep(1);
            object_teleport(await this.player0(), hall_b_a);
            object_teleport(await this.player1(), hall_b_b);
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
        }

        [ScriptMethod(388, Lifecycle.Static)]
        public async Task tele_plug_launch()
        {
            switch_bsp(0);
            await sleep(1);
            object_teleport(await this.player0(), plug_launch_a);
            object_teleport(await this.player1(), plug_launch_b);
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
        }

        [ScriptMethod(389, Lifecycle.Static)]
        public async Task tele_plug_landing()
        {
            switch_bsp(0);
            await sleep(1);
            object_teleport(await this.player0(), plug_landing_a);
            object_teleport(await this.player1(), plug_landing_b);
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            wake(new ScriptMethodReference(cs_move_plug));
        }

        [ScriptMethod(390, Lifecycle.Static)]
        public async Task tele_hall_c()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), hall_c_a);
            object_teleport(await this.player1(), hall_c_b);
            wake(new ScriptMethodReference(bsp0_cleanup));
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            this.g_hall_c = true;
        }

        [ScriptMethod(391, Lifecycle.Static)]
        public async Task tele_ledge_a()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), ledge_a_a);
            object_teleport(await this.player1(), ledge_a_b);
            wake(new ScriptMethodReference(bsp0_cleanup));
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            this.g_hall_c = true;
            this.g_ledge_a = true;
        }

        [ScriptMethod(392, Lifecycle.Static)]
        public async Task tele_conduit_b()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), conduit_b_a);
            object_teleport(await this.player1(), conduit_b_b);
            wake(new ScriptMethodReference(bsp0_cleanup));
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            this.g_hall_c = true;
            this.g_ledge_a = true;
            this.g_conduit_b = true;
        }

        [ScriptMethod(393, Lifecycle.Static)]
        public async Task tele_ledge_b()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), ledge_b_a);
            object_teleport(await this.player1(), ledge_b_b);
            wake(new ScriptMethodReference(bsp0_cleanup));
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            this.g_hall_c = true;
            this.g_ledge_a = true;
            this.g_conduit_b = true;
            this.g_ledge_b = true;
        }

        [ScriptMethod(394, Lifecycle.Static)]
        public async Task tele_ledge_c()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), ledge_c_a);
            object_teleport(await this.player1(), ledge_c_b);
            wake(new ScriptMethodReference(bsp0_cleanup));
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            this.g_hall_c = true;
            this.g_ledge_a = true;
            this.g_conduit_b = true;
            this.g_ledge_b = true;
            this.g_ledge_c = true;
        }

        [ScriptMethod(395, Lifecycle.Static)]
        public async Task tele_qz_initial()
        {
            switch_bsp(2);
            await sleep(1);
            object_teleport(await this.player0(), qz_initial_a);
            object_teleport(await this.player1(), qz_initial_b);
            wake(new ScriptMethodReference(bsp0_cleanup));
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            this.g_hall_c = true;
            this.g_ledge_a = true;
            this.g_conduit_b = true;
            this.g_ledge_b = true;
            this.g_ledge_c = true;
            this.g_qz_initial = true;
        }

        [ScriptMethod(396, Lifecycle.Static)]
        public async Task tele_cov_defense()
        {
            switch_bsp(2);
            await sleep(1);
            object_teleport(await this.player0(), cov_defense_a);
            object_teleport(await this.player1(), cov_defense_b);
            wake(new ScriptMethodReference(bsp0_cleanup));
            ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            this.g_hall_c = true;
            this.g_ledge_a = true;
            this.g_conduit_b = true;
            this.g_ledge_b = true;
            this.g_ledge_c = true;
            this.g_qz_initial = true;
            this.g_cov_defense = true;
        }
    }
}