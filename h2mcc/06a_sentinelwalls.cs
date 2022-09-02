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
        public async Task x06_01a_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x06_01a_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x06_01b_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x06_01b_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x06_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x06_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x06_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x06_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x06_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x06_04_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x06_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x06_05_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task _06_intro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_06_intro_01_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task _06_intro_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_06_intro_02_predict));
        }

        [ScriptMethod(32, Lifecycle.CommandScript)]
        public async Task cs_brute_walk_01()
        {
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("brute_targets/p0"));
        }

        [ScriptMethod(33, Lifecycle.CommandScript)]
        public async Task cs_brute_walk_02()
        {
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("brute_targets/p1"));
        }

        [ScriptMethod(34, Lifecycle.CommandScript)]
        public async Task cs_elite_walk_01()
        {
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("elite_targets/p0"));
        }

        [ScriptMethod(35, Lifecycle.CommandScript)]
        public async Task cs_elite_walk_02()
        {
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("elite_targets/p1"));
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task exchange_of_hats()
        {
            Engine.ai_allegiance(covenant, prophet);
            await Engine.sleep(210);
            Engine.print("exchange of hats");
            Engine.ai_place(brutes_01.Squad);
            Engine.ai_place(brutes_02.Squad);
            Engine.ai_place(elites_01.Squad);
            Engine.ai_place(elites_02.Squad);
            Engine.cs_run_command_script(brutes_01.Squad, new ScriptMethodReference(cs_brute_walk_01));
            Engine.cs_run_command_script(brutes_02.Squad, new ScriptMethodReference(cs_brute_walk_02));
            Engine.cs_run_command_script(elites_01.Squad, new ScriptMethodReference(cs_elite_walk_01));
            Engine.cs_run_command_script(elites_02.Squad, new ScriptMethodReference(cs_elite_walk_02));
            Engine.time_code_reset();
            await Engine.sleep(188);
            Engine.ai_erase(brutes_01.Squad);
            Engine.ai_erase(brutes_02.Squad);
            Engine.ai_erase(elites_01.Squad);
            Engine.ai_erase(elites_02.Squad);
            Engine.object_destroy_containing("elite_hg_prop");
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task x06_score_01a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_01_mus", 3836281651U), default(IGameObject), 1F);
            Engine.print("x06 score 01a start");
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task x06_foley_01a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01a_fol", 3836347188U), default(IGameObject), 1F);
            Engine.print("x06 foley 01a start");
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task x06_supratitle_01()
        {
            await Engine.sleep(60);
            Engine.cinematic_set_title(cinematic_title0);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01a()
        {
            Engine.cinematic_lighting_set_primary_light(3F, 234F, 0.28F, 0.28F, 0.39F);
            Engine.cinematic_lighting_set_secondary_light(21F, 96F, 0.38F, 0.33F, 0.27F);
            Engine.cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_03.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_01.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_02.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_01.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_02.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_03.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_04.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_05.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_06.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_07.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_hg_prop_08.Entity, true);
            Engine.object_uses_cinematic_lighting(x06_helmet.Entity, true);
            Engine.object_uses_cinematic_lighting(x06_pike_01.Entity, true);
            Engine.object_uses_cinematic_lighting(x06_pike_02.Entity, true);
            Engine.object_uses_cinematic_lighting(x06_pike_03.Entity, true);
            Engine.object_uses_cinematic_lighting(Engine.ai_get_object(brutes_01.Squad), true);
            Engine.object_uses_cinematic_lighting(Engine.ai_get_object(brutes_02.Squad), true);
            Engine.object_uses_cinematic_lighting(Engine.ai_get_object(elites_01.Squad), true);
            Engine.object_uses_cinematic_lighting(Engine.ai_get_object(elites_02.Squad), true);
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task x06_01b_problem_actors()
        {
            Engine.print("create problem actors");
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_hg_01);
            Engine.object_create_anew(brute_hg_02);
            Engine.object_create_anew(brute_hg_03);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_hg_01.Entity, true);
            Engine.object_cinematic_lod(brute_hg_02.Entity, true);
            Engine.object_cinematic_lod(brute_hg_03.Entity, true);
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task x06_01a_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(brute_02);
            Engine.object_create_anew(brute_03);
            Engine.object_create_anew(elite_hg_01);
            Engine.object_create_anew(elite_hg_02);
            Engine.object_create_anew_containing("elite_hg_prop");
            Engine.object_create_anew(x06_helmet);
            Engine.object_create_anew(x06_pike_01);
            Engine.object_create_anew(x06_pike_02);
            Engine.object_create_anew(x06_pike_03);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(brute_03.Entity, true);
            Engine.object_cinematic_lod(elite_hg_01.Entity, true);
            Engine.object_cinematic_lod(elite_hg_02.Entity, true);
            Engine.object_cinematic_lod(x06_helmet.Entity, true);
            Engine.object_cinematic_lod(x06_pike_01.Entity, true);
            Engine.object_cinematic_lod(x06_pike_02.Entity, true);
            Engine.object_cinematic_lod(x06_pike_03.Entity, true);
            Engine.wake(new ScriptMethodReference(x06_score_01a));
            Engine.wake(new ScriptMethodReference(x06_foley_01a));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_01a));
            Engine.wake(new ScriptMethodReference(x06_supratitle_01));
            Engine.wake(new ScriptMethodReference(exchange_of_hats));
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task x06_01a_cleanup()
        {
            Engine.object_destroy(elite_hg_01.Entity);
            Engine.object_destroy(elite_hg_02.Entity);
            Engine.object_destroy(brute_03.Entity);
            Engine.object_destroy(brute_04.Entity);
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task x06_scene_01a()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("sentinelwalls_1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x06_01a_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_01_mus", 3836281651U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01a_fol", 3836347188U));
            await Engine.sleep(this.prediction_offset);
            await this.x06_01a_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3836412725U), "x06_01a", default(IUnit), anchor_flag_x06);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3836478262U), "dervish_01a", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute02_01a", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute03_01a", false, anchor_x06.Entity);
            Engine.custom_animation_relative(elite_hg_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "elite_guard1_01a", false, anchor_x06.Entity);
            Engine.custom_animation_relative(elite_hg_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "elite_guard2_01a", false, anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_helmet.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\x06\\x06", 3836871484U), "helmet01_01a", anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3836937021U), "pike01_01a", anchor_x06.Entity);
            Engine.print("cache block");
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x06_01b_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01b_fol", 3837002558U));
            await this.x06_01b_problem_actors();
            await Engine.sleep((short)Engine.camera_time());
            await this.x06_01a_cleanup();
        }

        [ScriptMethod(45, Lifecycle.CommandScript)]
        public async Task cs_elite_walk_03()
        {
            Engine.cs_movement_mode(this.ai_movement_patrol);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("elite_targets/p2"));
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task final_hg_walk()
        {
            Engine.ai_allegiance(covenant, prophet);
            await Engine.sleep(120);
            Engine.print("final honor-guards");
            Engine.ai_place(elites_03.Squad);
            Engine.cs_run_command_script(elites_03.Squad, new ScriptMethodReference(cs_elite_walk_03));
            Engine.object_uses_cinematic_lighting(Engine.ai_get_object(this.ai_current_actor), true);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x06_foley_01b()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_01b_fol", 3837002558U), default(IGameObject), 1F);
            Engine.print("x06 foley 01b start");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task x06_01b_dof_1()
        {
            Engine.time_code_reset();
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(45);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0F, 1F, 0F, 0.5F, 1F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(98);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_01b()
        {
            Engine.cinematic_lighting_set_primary_light(3F, 234F, 0.28F, 0.28F, 0.39F);
            Engine.cinematic_lighting_set_secondary_light(21F, 96F, 0.38F, 0.33F, 0.27F);
            Engine.cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_hg_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_hg_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_hg_03.Entity, true);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x06_texture_camera_01b_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(143);
            Engine.print("start texture camera");
            Engine.object_create_anew(texture_camera);
            Engine.object_create_anew(texture_space);
            Engine.object_create_anew(texture_halo);
            Engine.object_cinematic_lod(texture_halo.Entity, true);
            Engine.object_uses_cinematic_lighting(texture_halo.Entity, true);
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "primary_trigger", 40F);
            await Engine.sleep(156);
            Engine.texture_camera_off();
            Engine.print("stop texture camera");
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task open_sanctum_door()
        {
            await Engine.sleep(176);
            Engine.print("open sanctum door");
            Engine.device_set_position(sanctum_door.Entity, 1F);
            Engine.object_destroy_containing("offending_column");
            Engine.print("destroy columns");
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task x06_01b_setup()
        {
            Engine.wake(new ScriptMethodReference(x06_foley_01b));
            Engine.wake(new ScriptMethodReference(final_hg_walk));
            Engine.wake(new ScriptMethodReference(x06_texture_camera_01b_01));
            Engine.wake(new ScriptMethodReference(open_sanctum_door));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_01b));
            Engine.wake(new ScriptMethodReference(x06_01b_dof_1));
        }

        [ScriptMethod(53, Lifecycle.Static)]
        public async Task x06_01b_cleanup()
        {
            Engine.ai_erase(elites_03.Squad);
            Engine.object_destroy(x06_helmet.Entity);
            Engine.object_destroy(brute_01.Entity);
            Engine.object_destroy(brute_02.Entity);
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task x06_scene_01b()
        {
            await this.x06_01b_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3836412725U), "x06_01b", default(IUnit), anchor_flag_x06);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3836478262U), "dervish_01b", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_hg_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute01_01b", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_hg_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute02_01b", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_hg_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute03_01b", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute04_01b", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute05_01b", false, anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_helmet.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\x06\\x06", 3836871484U), "helmet01_01b", anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3836937021U), "pike01_01b", anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_pike_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3836937021U), "pike02_01b", anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_pike_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3836937021U), "pike03_01b", anchor_x06.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x06_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_02_fol", 3837068095U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x06_01b_cleanup();
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task x06_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_02_fol", 3837068095U), default(IGameObject), 1F);
            Engine.print("x06 foley 02 start");
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task x06_0010_soc()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0010_soc", 3837133632U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x06_0010_soc", 3F);
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x06_0020_pot()
        {
            await Engine.sleep(92);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0020_pot", 3837199169U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x06_0020_pot", 2F);
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x06_0030_soc()
        {
            await Engine.sleep(168);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0030_soc", 3837264706U), commander.Entity, 1F);
            Engine.cinematic_subtitle("x06_0030_soc", 5F);
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task x06_0040_pot()
        {
            await Engine.sleep(306);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0040_pot", 3837330243U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0040_pot", 2F);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task x06_0050_soc()
        {
            await Engine.sleep(371);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0050_soc", 3837395780U), commander.Entity, 1F);
            Engine.cinematic_subtitle("x06_0050_soc", 5F);
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task x06_0060_pot()
        {
            await Engine.sleep(520);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0060_pot", 3837461317U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0060_pot", 8F);
            await Engine.sleep(110);
            Engine.unit_set_emotional_state(truth.Entity, "arrogant", 0.75F, 60);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task x06_0070_soc()
        {
            await Engine.sleep(794);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0070_soc", 3837526854U), commander.Entity, 1F);
            Engine.cinematic_subtitle("x06_0070_soc", 3F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task cinematic_lighting_scene_02()
        {
            Engine.cinematic_lighting_set_primary_light(3F, 234F, 0.28F, 0.28F, 0.39F);
            Engine.cinematic_lighting_set_secondary_light(21F, 96F, 0.38F, 0.33F, 0.27F);
            Engine.cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            Engine.object_uses_cinematic_lighting(truth.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(commander.Entity, true);
            Engine.object_uses_cinematic_lighting(so_elite_01.Entity, true);
            Engine.object_uses_cinematic_lighting(so_elite_02.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_truth.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_mercy.Entity, true);
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task x06_texture_camera_02_01()
        {
            Engine.print("start texture camera");
            Engine.object_create_anew(texture_camera);
            Engine.object_create_anew(texture_space);
            Engine.object_create_anew(texture_halo);
            Engine.object_cinematic_lod(texture_halo.Entity, true);
            Engine.object_uses_cinematic_lighting(texture_halo.Entity, true);
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "primary_trigger", 40F);
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task x06_02_setup()
        {
            Engine.object_create_anew(truth);
            Engine.object_create_anew(mercy);
            Engine.object_create_anew(commander);
            Engine.object_create_anew(so_elite_01);
            Engine.object_create_anew(so_elite_02);
            Engine.object_create_anew(throne_truth);
            Engine.object_create_anew(throne_mercy);
            Engine.object_cinematic_lod(truth.Entity, true);
            Engine.object_cinematic_lod(mercy.Entity, true);
            Engine.object_cinematic_lod(commander.Entity, true);
            Engine.object_cinematic_lod(so_elite_01.Entity, true);
            Engine.object_cinematic_lod(so_elite_02.Entity, true);
            Engine.object_cinematic_lod(throne_truth.Entity, true);
            Engine.object_cinematic_lod(throne_mercy.Entity, true);
            Engine.objects_attach(truth.Entity, "driver", throne_truth.Entity, "driver_cinematic");
            Engine.objects_attach(mercy.Entity, "driver", throne_mercy.Entity, "driver_cinematic");
            Engine.wake(new ScriptMethodReference(x06_foley_02));
            Engine.wake(new ScriptMethodReference(x06_0010_soc));
            Engine.wake(new ScriptMethodReference(x06_0020_pot));
            Engine.wake(new ScriptMethodReference(x06_0030_soc));
            Engine.wake(new ScriptMethodReference(x06_0040_pot));
            Engine.wake(new ScriptMethodReference(x06_0050_soc));
            Engine.wake(new ScriptMethodReference(x06_0060_pot));
            Engine.wake(new ScriptMethodReference(x06_0070_soc));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_scene_02));
            Engine.wake(new ScriptMethodReference(x06_texture_camera_02_01));
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task x06_scene_02()
        {
            await this.x06_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3836412725U), "x06_02", default(IUnit), anchor_flag_x06);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3836478262U), "dervish_02", false, anchor_x06.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "truth_02", false, anchor_x06.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "mercy_02", false, anchor_x06.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "commander_02", false, anchor_x06.Entity);
            Engine.custom_animation_relative(so_elite_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "elite1_02", false, anchor_x06.Entity);
            Engine.custom_animation_relative(so_elite_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "elite2_02", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_hg_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute01_02", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_hg_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute02_02", false, anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_pike_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3836937021U), "pike01_02", anchor_x06.Entity);
            Engine.scenery_animation_start_relative(x06_pike_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\pike\\x06\\x06", 3836937021U), "pike02_02", anchor_x06.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x06_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_03_fol", 3837723465U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy_containing("x06_pike");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task x06_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_03_fol", 3837723465U), default(IGameObject), 1F);
            Engine.print("x06 foley 03 start");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x06_0080_pot()
        {
            await Engine.sleep(148);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0080_pot", 3837789002U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x06_0080_pot", 4F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x06_0090_pot()
        {
            await Engine.sleep(265);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0090_pot", 3837854539U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0090_pot", 5F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task x06_0100_pot()
        {
            await Engine.sleep(418);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0100_pot", 3837920076U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0100_pot", 6F);
            await Engine.sleep(78);
            Engine.unit_set_emotional_state(truth.Entity, "annoyed", 0.75F, 60);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task x06_0110_der()
        {
            await Engine.sleep(585);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0110_der", 3837985613U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x06_0110_der", 2F);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task x06_03_setup()
        {
            Engine.wake(new ScriptMethodReference(x06_foley_03));
            Engine.wake(new ScriptMethodReference(x06_0080_pot));
            Engine.wake(new ScriptMethodReference(x06_0090_pot));
            Engine.wake(new ScriptMethodReference(x06_0100_pot));
            Engine.wake(new ScriptMethodReference(x06_0110_der));
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task x06_03_cleanup()
        {
            Engine.object_destroy(commander.Entity);
            Engine.object_destroy_containing("brute_hg");
            Engine.object_destroy_containing("so_elite");
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task x06_scene_03()
        {
            await this.x06_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3836412725U), "x06_03", default(IUnit), anchor_flag_x06);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3836478262U), "dervish_03", false, anchor_x06.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "truth_03", false, anchor_x06.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "mercy_03", false, anchor_x06.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "commander_03", false, anchor_x06.Entity);
            Engine.custom_animation_relative(so_elite_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "elite1_03", false, anchor_x06.Entity);
            Engine.custom_animation_relative(so_elite_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\x06\\x06", 3836740410U), "elite2_03", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_hg_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute01_03", false, anchor_x06.Entity);
            Engine.custom_animation_relative(brute_hg_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x06\\x06", 3836609336U), "brute02_03", false, anchor_x06.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x06_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_04_mus", 3838051150U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_03_fol", 3837723465U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x06_03_cleanup();
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x06_score_04()
        {
            await Engine.sleep(274);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\music\\x06_04_mus", 3838051150U), default(IGameObject), 1F);
            Engine.print("x06 score 04 start");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x06_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_04_fol", 3838116687U), default(IGameObject), 1F);
            Engine.print("x06 foley 04 start");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x06_0120_pot()
        {
            await Engine.sleep(15);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0120_pot", 3838182224U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0120_pot", 3F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x06_0130_pom()
        {
            await Engine.sleep(109);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0130_pom", 3838247761U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x06_0130_pom", 8F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task x06_0140_pot()
        {
            await Engine.sleep(346);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0140_pot", 3838313298U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0140_pot", 8F);
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task x06_0150_pot()
        {
            await Engine.sleep(581);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0150_pot", 3838378835U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0150_pot", 5F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x06_0160_pom()
        {
            await Engine.sleep(715);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0160_pom", 3838444372U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x06_0160_pom", 9F);
            await Engine.sleep(150);
            Engine.unit_set_emotional_state(mercy.Entity, "asleep", 0.75F, 60);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x06_fov_01()
        {
            await Engine.sleep(576);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov");
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x06_04_dof_1()
        {
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("dof");
            await Engine.sleep(103);
            Engine.cinematic_screen_effect_set_depth_of_field(0.8F, 0.5F, 0F, 1F, 0F, 0.5F, 1F);
            Engine.print("dof");
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x06_04_dof_2()
        {
            await Engine.sleep(343);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("dof");
            await Engine.sleep(82);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0F, 1F, 0F, 0.5F, 1F);
            Engine.print("dof");
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task unhide_dervish()
        {
            Engine.time_code_reset();
            await Engine.sleep(576);
            Engine.print("unhide dervish");
            Engine.object_hide(dervish.Entity, false);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task x06_04_setup()
        {
            Engine.wake(new ScriptMethodReference(x06_score_04));
            Engine.wake(new ScriptMethodReference(x06_foley_04));
            Engine.wake(new ScriptMethodReference(x06_0120_pot));
            Engine.wake(new ScriptMethodReference(x06_0130_pom));
            Engine.wake(new ScriptMethodReference(x06_0140_pot));
            Engine.wake(new ScriptMethodReference(x06_0150_pot));
            Engine.wake(new ScriptMethodReference(x06_0160_pom));
            Engine.object_hide(dervish.Entity, true);
            Engine.wake(new ScriptMethodReference(unhide_dervish));
            Engine.wake(new ScriptMethodReference(x06_fov_01));
            Engine.wake(new ScriptMethodReference(x06_04_dof_1));
            Engine.wake(new ScriptMethodReference(x06_04_dof_2));
        }

        [ScriptMethod(87, Lifecycle.Static)]
        public async Task x06_scene_04()
        {
            await this.x06_04_setup();
            Engine.camera_set_field_of_view(30F, 0);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3836412725U), "x06_04", default(IUnit), anchor_flag_x06);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3836478262U), "dervish_04", false, anchor_x06.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "truth_04", false, anchor_x06.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "mercy_04", false, anchor_x06.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x06_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_05_fol", 3838509909U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x06_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x06\\foley\\x06_05_fol", 3838509909U), default(IGameObject), 1F);
            Engine.print("x06 foley 05 start");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x06_0170_pot()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0170_pot", 3838575446U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0170_pot", 9F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task x06_0180_pot()
        {
            await Engine.sleep(276);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0180_pot", 3838640983U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0180_pot", 3F);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x06_0190_pom()
        {
            await Engine.sleep(366);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0190_pom", 3838706520U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x06_0190_pom", 9F);
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x06_0200_pot()
        {
            await Engine.sleep(635);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0200_pot", 3838772057U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0200_pot", 5F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x06_0210_pot()
        {
            await Engine.sleep(780);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0210_pot", 3838837594U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0210_pot", 4F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task x06_0220_pom()
        {
            await Engine.sleep(889);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0220_pom", 3838903131U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("x06_0220_pom", 3F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x06_0230_pot()
        {
            await Engine.sleep(956);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x06_0230_pot", 3838968668U), truth.Entity, 1F);
            Engine.cinematic_subtitle("x06_0230_pot", 3F);
            Engine.unit_set_emotional_state(truth.Entity, "happy", 0.5F, 60);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x06_05_dof_1()
        {
            await Engine.sleep(488);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.75F, 0.75F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(160);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.75F, 0F, 1F, 0F, 0.75F, 1F);
            Engine.print("rack focus");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x06_05_dof_2()
        {
            await Engine.sleep(777);
            Engine.cinematic_screen_effect_set_depth_of_field(2F, 0F, 0.75F, 1F, 0.75F, 0F, 1F);
            Engine.print("rack focus");
            await Engine.sleep(173);
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x06_texture_camera_05_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(279);
            Engine.print("stop texture camera");
            Engine.texture_camera_off();
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task monitor_sound()
        {
            await Engine.sleep(281);
            Engine.sound_class_set_gain("device", 1F, 60);
            Engine.print("monitor sound up");
        }

        [ScriptMethod(100, Lifecycle.Static)]
        public async Task x06_05_setup()
        {
            Engine.sound_class_set_gain("device", 0F, 0);
            Engine.object_create_anew(monitor);
            Engine.object_cinematic_lod(monitor.Entity, true);
            Engine.object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            Engine.object_uses_cinematic_lighting(monitor.Entity, true);
            Engine.object_create_anew(index_holo);
            Engine.wake(new ScriptMethodReference(x06_foley_05));
            Engine.wake(new ScriptMethodReference(x06_0170_pot));
            Engine.wake(new ScriptMethodReference(x06_0180_pot));
            Engine.wake(new ScriptMethodReference(x06_0190_pom));
            Engine.wake(new ScriptMethodReference(x06_0200_pot));
            Engine.wake(new ScriptMethodReference(x06_0210_pot));
            Engine.wake(new ScriptMethodReference(x06_0220_pom));
            Engine.wake(new ScriptMethodReference(x06_0230_pot));
            Engine.wake(new ScriptMethodReference(monitor_sound));
            Engine.wake(new ScriptMethodReference(x06_05_dof_1));
            Engine.wake(new ScriptMethodReference(x06_05_dof_2));
            Engine.wake(new ScriptMethodReference(x06_texture_camera_05_01));
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x06_05_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy_containing("truth");
            Engine.object_destroy_containing("mercy");
            Engine.object_destroy(monitor.Entity);
            Engine.object_destroy(index_holo.Entity);
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x06_scene_05()
        {
            Engine.camera_set_field_of_view(60F, 0);
            await this.x06_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x06\\x06", 3836412725U), "x06_05", default(IUnit), anchor_flag_x06);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x06\\x06", 3836478262U), "dervish_05", false, anchor_x06.Entity);
            Engine.custom_animation_relative(truth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "truth_05", false, anchor_x06.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\x06\\x06", 3837592391U), "mercy_05", false, anchor_x06.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\x06\\x06", 3839034205U), "monitor_05", false, anchor_x06.Entity);
            Engine.scenery_animation_start_relative(index_holo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_alone\\x06\\x06", 3839099742U), "index_alone_05", anchor_x06.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(0F, 0F, 0F, 15);
            await Engine.sleep(15);
            await this.x06_05_cleanup();
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task x06()
        {
            Engine.cinematic_enable_ambience_details(false);
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_8"));
            await Engine.sleep(1);
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
            Engine.object_set_function_variable(phantom_01.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_01.Entity, "hover_audio", 1F, 0F);
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.sound_class_set_gain("vehicle", 1F, 90);
            await Engine.sleep(90);
            Engine.sound_class_set_gain("vehicle", 0F, 90);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task c06_intro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_01_fol", 3839165279U), default(IGameObject), 1F);
            Engine.print("c06_intro foley 01 start");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task c06_1010_tar()
        {
            await Engine.sleep(144);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1010_tar", 3839230816U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c06_1010_tar", 1F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task c06_1020_tar()
        {
            await Engine.sleep(191);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1020_tar", 3839296353U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c06_1020_tar", 2F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task c06_1030_tar()
        {
            await Engine.sleep(264);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1030_tar", 3839361890U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c06_1030_tar", 3F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task c06_1040_der()
        {
            await Engine.sleep(337);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1040_der", 3839427427U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c06_1040_der", 4F);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task c06_1050_tar()
        {
            await Engine.sleep(463);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1050_tar", 3839492964U), default(IGameObject), 1F, "radio_covy_loop");
            Engine.cinematic_subtitle("c06_1050_tar", 1F);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task c06_1060_der()
        {
            await Engine.sleep(507);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1060_der", 3839558501U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c06_1060_der", 1F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task c06_1070_tar()
        {
            await Engine.sleep(550);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1070_tar", 3839624038U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c06_1070_tar", 1F);
            await Engine.sleep(35);
            Engine.unit_set_emotional_state(tartarus.Entity, "inquisitive", 1F, 30);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task c06_1080_tar()
        {
            await Engine.sleep(593);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1080_tar", 3839689575U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c06_1080_tar", 1F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task c06_1090_tar()
        {
            await Engine.sleep(623);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1090_tar", 3839755112U), default(IGameObject), 1F, "radio_covy_loop");
            Engine.cinematic_subtitle("c06_1090_tar", 1F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task c06_1100_der()
        {
            await Engine.sleep(670);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1100_der", 3839820649U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c06_1100_der", 3F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task c06_1110_tar()
        {
            await Engine.sleep(745);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1110_tar", 3839886186U), default(IGameObject), 1F, "radio_covy_out");
            Engine.cinematic_subtitle("c06_1110_tar", 3F);
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task camera_shake_01()
        {
            await Engine.sleep(188);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task cinematic_light_intro_scene_01()
        {
            Engine.cinematic_lighting_set_primary_light(-20F, 282F, 0.21F, 0.29F, 0.37F);
            Engine.cinematic_lighting_set_secondary_light(-59F, 306F, 0.34F, 0.58F, 0.65F);
            Engine.cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            Engine.rasterizer_bloom_override(false);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_03.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_04.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_int.Entity, true);
            Engine.object_uses_cinematic_lighting(carbine.Entity, true);
            Engine.object_uses_cinematic_lighting(delta_halo.Entity, true);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task cinematic_light_phantom_int()
        {
            await Engine.sleep(186);
            Engine.print("light phantom");
            Engine.cinematic_lighting_set_primary_light(-90F, 0F, 0.23F, 0.29F, 0.53F);
            Engine.cinematic_lighting_set_secondary_light(-90F, 192F, 0.16F, 0.1F, 0.19F);
            Engine.cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task c06_problem_actors_01()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(delta_halo);
            Engine.object_create_anew(matte_substance);
            Engine.object_create_anew(matte_stardust);
            Engine.object_cinematic_lod(delta_halo.Entity, true);
            Engine.object_cinematic_visibility(delta_halo.Entity, true);
        }

        [ScriptMethod(121, Lifecycle.Static)]
        public async Task c06_intro_01_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_create_anew(brute_03);
            Engine.object_create_anew(brute_04);
            Engine.object_create_anew(phantom_01);
            Engine.object_create_anew(phantom_int);
            Engine.object_create_anew(carbine);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(brute_03.Entity, true);
            Engine.object_cinematic_lod(brute_04.Entity, true);
            Engine.object_cinematic_lod(phantom_01.Entity, true);
            Engine.object_cinematic_lod(phantom_int.Entity, true);
            Engine.objects_attach(dervish.Entity, "right_hand_elite", carbine.Entity, "");
            Engine.wake(new ScriptMethodReference(c06_intro_sound_scene1_01));
            Engine.wake(new ScriptMethodReference(c06_intro_foley_01));
            Engine.wake(new ScriptMethodReference(c06_1010_tar));
            Engine.wake(new ScriptMethodReference(c06_1020_tar));
            Engine.wake(new ScriptMethodReference(c06_1030_tar));
            Engine.wake(new ScriptMethodReference(c06_1040_der));
            Engine.wake(new ScriptMethodReference(c06_1050_tar));
            Engine.wake(new ScriptMethodReference(c06_1060_der));
            Engine.wake(new ScriptMethodReference(c06_1070_tar));
            Engine.wake(new ScriptMethodReference(c06_1080_tar));
            Engine.wake(new ScriptMethodReference(c06_1090_tar));
            Engine.wake(new ScriptMethodReference(c06_1100_der));
            Engine.wake(new ScriptMethodReference(c06_1110_tar));
            Engine.wake(new ScriptMethodReference(camera_shake_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_intro_scene_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_phantom_int));
        }

        [ScriptMethod(122, Lifecycle.Static)]
        public async Task c06_intro_01_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy_containing("brute");
            Engine.object_destroy(phantom_int.Entity);
            Engine.object_destroy(delta_halo.Entity);
            Engine.object_destroy(matte_substance.Entity);
            Engine.object_destroy(matte_stardust.Entity);
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(123, Lifecycle.Static)]
        public async Task c06_intro_scene_01()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("sentinelwalls_intro");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._06_intro_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_01_fol", 3839165279U));
            Engine.wake(new ScriptMethodReference(c06_problem_actors_01));
            await Engine.sleep(this.prediction_offset);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3839951723U), "06_intro_01", default(IUnit), anchor_flag_intro);
            await this.c06_intro_01_setup();
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intro\\06_intro", 3840017260U), "dervish_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3840082797U), "tartarus_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3840082797U), "brute01_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3840082797U), "brute02_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3840082797U), "brute03_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\06_intro\\06_intro", 3840082797U), "brute04_01", false, anchor_intro.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intro\\06_intro", 3840148334U), "phantom_01", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(phantom_int.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\cinematics\\06_intro\\06_intro", 3840213871U), "phantom_int_01", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(delta_halo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\06_intro\\06_intro", 3840279408U), "halo_01", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\06_intro\\06_intro", 3840344945U), "substance_01", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(matte_stardust.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\06_intro\\06_intro", 3840410482U), "stardust_01", anchor_intro.Entity);
            await Engine.sleep(15);
            Engine.fade_in(0F, 0F, 0F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._06_intro_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_02_fol", 3840476019U));
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.cinematic_screen_effect_set_crossfade(2F);
            Engine.print("crossfade");
            await Engine.sleep((short)Engine.camera_time());
            await this.c06_intro_01_cleanup();
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task c06_intro_sound_scene2_01()
        {
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 0F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 0F);
            Engine.sound_class_set_gain("vehicle", 1F, 50);
            await Engine.sleep(50);
            Engine.sound_class_set_gain("vehicle", 0F, 90);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task c06_intro_sound_scene2_02()
        {
            await Engine.sleep(160);
            Engine.sound_class_set_gain("vehicle", 1F, 30);
            await Engine.sleep(30);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 0F, 120F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 0F, 120F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 0F, 120F);
            await Engine.sleep(60);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_hack", 1F, 90F);
            Engine.object_set_function_variable(phantom_02.Entity, "engine_audio", 1F, 90F);
            Engine.object_set_function_variable(phantom_02.Entity, "hover_audio", 1F, 90F);
            Engine.sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task c06_intro_sound_scene2_03()
        {
            await Engine.sleep(480);
            Engine.sound_class_set_gain("vehicle", 1F, 60);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 0F, 0F);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 0F, 0F);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 1F, 60F);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 1F, 60F);
            await Engine.sleep(110);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 0F, 60F);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 0F, 60F);
            await Engine.sleep(160);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_hack", 1F, 60F);
            Engine.object_set_function_variable(intro_sen_maj.Entity, "engine_audio", 1F, 60F);
            await Engine.sleep(60);
            Engine.sound_class_set_gain("vehicle", 0F, 150);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task c06_intro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intro\\foley\\c06_intro_02_fol", 3840476019U), default(IGameObject), 1F);
            Engine.print("c06_intro foley 02 start");
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task c06_1120_tar()
        {
            await Engine.sleep(782);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1120_tar", 3840541556U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c06_1120_tar", 2F);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c06_1130_tar()
        {
            await Engine.sleep(842);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_1130_tar", 3840607093U), tartarus.Entity, 1F, "radio_default_out");
            Engine.cinematic_subtitle("c06_1130_tar", 2F);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task arbiter_fires()
        {
            await Engine.sleep(642);
            Engine.print("carbine shot");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\covenant_carbine\\firing", 3807445371U), carbine.Entity, "primary_trigger");
            await Engine.sleep(22);
            Engine.print("carbine shot");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\covenant_carbine\\firing", 3807445371U), carbine.Entity, "primary_trigger");
            await Engine.sleep(24);
            Engine.print("carbine shot");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\covenant_carbine\\firing", 3807445371U), carbine.Entity, "primary_trigger");
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task phantom_fires()
        {
            Engine.time_code_reset();
            await Engine.sleep(690);
            Engine.object_create_anew(intro_turret_base);
            Engine.object_create_anew(intro_turret);
            Engine.objects_attach(intro_turret_base.Entity, "primary_trigger", intro_turret.Entity, "");
            Engine.print("turret fires");
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("intro_turret"), 0, true);
            await Engine.sleep(30);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("intro_turret"), 0, false);
            Engine.objects_detach(intro_turret_base.Entity, intro_turret.Entity);
            Engine.object_destroy(intro_turret.Entity);
            Engine.object_destroy(intro_turret_base.Entity);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task c06_intro_predict_ledge_01()
        {
            await Engine.sleep(145);
            Engine.print("predict: camera, dervish");
            Engine.object_type_predict_high(Engine.GetTag<BaseTag>("objects\\characters\\dervish\\dervish", 3840672630U));
            Engine.camera_predict_resources_at_frame(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3839951723U), "06_intro_02", default(IUnit), anchor_flag_intro, 165);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task c06_intro_predict_ledge_02()
        {
            await Engine.sleep(224);
            Engine.print("predict: camera, dervish, sentinel major");
            Engine.object_type_predict_high(Engine.GetTag<BaseTag>("objects\\characters\\dervish\\dervish", 3840672630U));
            Engine.object_type_predict_high(Engine.GetTag<BaseTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868132633U));
            Engine.camera_predict_resources_at_frame(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3839951723U), "06_intro_02", default(IUnit), anchor_flag_intro, 244);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task create_dervish_again()
        {
            await Engine.sleep(305);
            Engine.print("problem actor");
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(carbine);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(carbine.Entity, true);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(carbine.Entity, true);
            Engine.objects_attach(dervish.Entity, "right_hand_elite", carbine.Entity, "");
            Engine.object_hide(dervish.Entity, true);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task dervish_unhide()
        {
            await Engine.sleep(330);
            Engine.object_hide(dervish.Entity, false);
            Engine.print("dervish unhide");
        }

        [ScriptMethod(136, Lifecycle.Static)]
        public async Task c06_intro_02_setup()
        {
            Engine.object_create_anew(phantom_02);
            Engine.object_create_anew(intro_sen_maj);
            Engine.object_create_anew(matte_mount_doom);
            Engine.object_cinematic_lod(phantom_02.Entity, true);
            Engine.object_cinematic_lod(intro_sen_maj.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_02.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_sen_maj.Entity, true);
            Engine.wake(new ScriptMethodReference(c06_intro_sound_scene2_01));
            Engine.wake(new ScriptMethodReference(c06_intro_sound_scene2_02));
            Engine.wake(new ScriptMethodReference(c06_intro_sound_scene2_03));
            Engine.wake(new ScriptMethodReference(c06_intro_foley_02));
            Engine.wake(new ScriptMethodReference(c06_1120_tar));
            Engine.wake(new ScriptMethodReference(c06_1130_tar));
            Engine.wake(new ScriptMethodReference(dervish_unhide));
            Engine.wake(new ScriptMethodReference(create_dervish_again));
            Engine.wake(new ScriptMethodReference(arbiter_fires));
            Engine.wake(new ScriptMethodReference(phantom_fires));
            Engine.wake(new ScriptMethodReference(c06_intro_predict_ledge_01));
            Engine.wake(new ScriptMethodReference(c06_intro_predict_ledge_02));
        }

        [ScriptMethod(137, Lifecycle.Static)]
        public async Task c06_intro_02_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(intro_sen_maj.Entity);
            Engine.object_destroy_containing("phantom");
            Engine.object_destroy(matte_mount_doom.Entity);
        }

        [ScriptMethod(138, Lifecycle.Static)]
        public async Task c06_intro_scene_02()
        {
            await this.c06_intro_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intro\\06_intro", 3839951723U), "06_intro_02", default(IUnit), anchor_flag_intro);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intro\\06_intro", 3840017260U), "dervish_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(intro_sen_maj.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\sentinel_enforcer\\06_intro\\06_intro", 3888252492U), "sentinel_major_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intro\\06_intro", 3840148334U), "phantom01_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intro\\06_intro", 3840148334U), "phantom02_02", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(matte_mount_doom.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\mount_doom\\06_intro\\06_intro", 3888318029U), "mount_doom_02", anchor_intro.Entity);
            Engine.time_code_reset();
            await Engine.sleep(315);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intro\\06_intro", 3840017260U), "dervish_02", false, anchor_intro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c06_intro_02_cleanup();
            await Engine.sleep(30);
        }

        [ScriptMethod(139, Lifecycle.Static)]
        public async Task c06_intro()
        {
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("sentinelhq_1"));
            await Engine.sleep(5);
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
            Engine.device_set_position_immediate(plug.Entity, 1F);
            Engine.device_set_position(plug_lock_a.Entity, 1F);
            Engine.device_set_position(plug_lock_b.Entity, 1F);
            Engine.device_set_position(plug_lock_c.Entity, 1F);
            Engine.device_set_position(plug_lock_d.Entity, 1F);
            Engine.device_set_position(plug_lock_e.Entity, 1F);
            Engine.device_set_position(plug_lock_f.Entity, 1F);
            Engine.device_set_position(plug_door_b.Entity, 1F);
        }

        [ScriptMethod(142, Lifecycle.CommandScript)]
        public async Task die()
        {
            Engine.ai_kill_silent(this.ai_current_squad);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task ice_cream_mythic()
        {
            Engine.object_create(ice_cream_head);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4266007569U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4266007569U)), 5);
            if (this.debug)
            {
                Engine.print("you're going to get fat!!!!! or dead...");
            }

            if (this.debug)
            {
                Engine.print("because now everyone is mythic!!!!");
            }

            Engine.ice_cream_flavor_stock(12);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task chapter_silence()
        {
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task chapter_remorse()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task chapter_war()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_3);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task objective_lower_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("lower the containment-shield.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task objective_lower_clear()
        {
            Engine.print("objective complete:");
            Engine.print("lower the containment-shield.");
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task objective_lower_specific_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("power-up the four absorbers to lower the containment-shield.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task objective_lower_specific_clear()
        {
            Engine.print("objective complete:");
            Engine.print("power-up the four absorbers to lower the containment-shield.");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task objective_floodwall_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("make your way through the flood-infested wall.");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task objective_floodwall_clear()
        {
            Engine.print("objective complete:");
            Engine.print("make your way through the flood-infested wall.");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task objective_rendezvous_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("rendezvous with your allies in the covenant camp.");
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task objective_rendezvous_clear()
        {
            Engine.print("objective complete:");
            Engine.print("rendezvous with your allies in the covenant camp.");
            Engine.objectives_finish_up_to(3);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task music_06a_01()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_insertion_tube, Engine.players()), 1);
            if (this.debug)
            {
                Engine.print("start music 06a_01");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_01", 2220368393U), default(IGameObject), 1F);
            await Engine.sleep(30);
            if (this.debug)
            {
                Engine.print("start music 06a_02");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_02", 2220761615U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ins_slide_bottom, Engine.players()));
            if (this.debug)
            {
                Engine.print("stop music 06a_01");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_01", 2220368393U));
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task music_06a_03()
        {
            await Engine.sleep_until(async () => this.g_music_06a_03, 1);
            if (this.debug)
            {
                Engine.print("start music 06a_03");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_03", 2221023763U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06a_03));
            if (this.debug)
            {
                Engine.print("stop music 06a_03");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_03", 2221023763U));
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task music_06a_04()
        {
            await Engine.sleep_until(async () => this.g_music_06a_04);
            if (this.debug)
            {
                Engine.print("start music 06a_04");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_04", 2221416985U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06a_04));
            if (this.debug)
            {
                Engine.print("stop music 06a_04");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_04", 2221416985U));
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task music_06a_05()
        {
            await Engine.sleep_until(async () => this.g_music_06a_05);
            if (this.debug)
            {
                Engine.print("start music 06a_05");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_05", 2221810207U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06a_05));
            if (this.debug)
            {
                Engine.print("stop music 06a_05");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_05", 2221810207U));
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task music_06a_06()
        {
            await Engine.sleep_until(async () => this.g_music_06a_06);
            if (this.debug)
            {
                Engine.print("start music 06a_06");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_06", 2222203429U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06a_06));
            if (this.debug)
            {
                Engine.print("stop music 06a_06");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_06", 2222203429U));
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task music_06a_07()
        {
            await Engine.sleep_until(async () => this.g_music_06a_07);
            if (this.debug)
            {
                Engine.print("start music 06a_07");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_07", 2222596651U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06a_07));
            if (this.debug)
            {
                Engine.print("stop music 06a_07");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_07", 2222596651U));
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task music_06a_08()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_slide_a, Engine.players()));
            if (this.debug)
            {
                Engine.print("start music 06a_08");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_08", 2222727725U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06a_08));
            if (this.debug)
            {
                Engine.print("stop music 06a_08");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_08", 2222727725U));
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task music_06a_09()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_c_fr, Engine.players()), 5);
            if (this.debug)
            {
                Engine.print("start music 06a_09");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_09", 2223120947U), default(IGameObject), 1F);
            this.g_music_06a_08 = false;
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task music_06a_10()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_music_06a_10, Engine.players()));
            if (this.debug)
            {
                Engine.print("start music 06a_10");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_10", 2223383095U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06a_10));
            if (this.debug)
            {
                Engine.print("stop music 06a_10");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06a_sentinelwalls\\06a_music\\06a_10", 2223383095U));
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task sc_cond_cov()
        {
            await Engine.sleep(60);
            Engine.cs_switch("grunt");
            if (this.dialogue)
            {
                Engine.print("grunt: arbiter our savior!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cond_a_cov.Squad, "0400"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                Engine.print("grunt: stupid jackal, say thank you!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cond_a_cov.Squad, "0410"));
            await Engine.sleep(this.dialogue_pause);
            Engine.cs_switch("jackal");
            if (this.dialogue)
            {
                Engine.print("jackal: hissss.....");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(cond_a_cov.Squad, "0420"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task ai_sc_cond_a_cov()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("sc_cond_a_cov", new ScriptMethodReference(sc_cond_cov), cond_a_cov.Squad));
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task sc_tartarus_reminder()
        {
            Engine.game_save_cancel();
            if (this.dialogue)
            {
                Engine.print("tartarus: you're getting close to one of the shield-generators�");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0430"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("tartarus: many of my brutes have fallen attempting to take it down.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0440"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("tartarus: let's see if you fare better.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0450"));
            await Engine.sleep(this.dialogue_pause);
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task sc_fleeing_grunts()
        {
            if (this.dialogue)
            {
                Engine.print("grunt: big, scary thing! run away!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0460"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("grunt: please! no make go back!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0470"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => this.g_hall_b_sen_dialogue);
            await Engine.sleep(90);
            if (this.dialogue)
            {
                Engine.print("grunt: (shriek) more bad things!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0480"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("grunt: arbiter! protect! protect!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0490"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task ai_sc_hall_b_grunts()
        {
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("scene_trigger_4", hall_b_cov.Squad));
            Engine.cs_run_command_script(hall_b_cov.wimp, new ScriptMethodReference(sc_fleeing_grunts));
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task sc_enforcer()
        {
            await Engine.sleep_until(async () => this.g_enforcer);
            Engine.game_save_cancel();
            await Engine.sleep(60);
            if (this.dialogue)
            {
                Engine.print("tartarus: it's useless to attack an enforcer from the front.");
            }

            if (this.dialogue)
            {
                Engine.print("tartarus: especially when their shields are up.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0500"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("tartarus: stay in the shadows. wait 'til it loses interest�");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0510"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("tartarus: then strike the beast when it it's back is turned!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0520"));
            await Engine.sleep(this.dialogue_pause);
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task sc_plug_launch()
        {
            Engine.game_save_cancel();
            this.g_music_06a_03 = false;
            if (this.dialogue)
            {
                Engine.print("tartarus: you've reached the shield's power-source, arbiter.");
            }

            if (this.dialogue)
            {
                Engine.print("tartarus: overload the locks holding it in place!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0010"));
            await Engine.sleep(this.dialogue_pause);
            this.g_enforcer = true;
            await Engine.sleep_until(async () => this.g_final_lock);
            if (this.dialogue)
            {
                Engine.print("tartarus: one more, arbiter!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0030"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => this.g_flip_switch);
            Engine.sound_class_set_gain("object_impacts", 0.2F, 2);
            Engine.sound_class_set_gain("vehicle_collision", 0.2F, 2);
            await Engine.sleep(60);
            if (this.dialogue)
            {
                Engine.print("tartarus: you've released the power source!");
            }

            if (this.dialogue)
            {
                Engine.print("now find a way to remove it from its cradle.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0040"));
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task sc_plug_ride()
        {
            if (this.dialogue)
            {
                Engine.print("tartarus: our path to the library is clear.");
            }

            if (this.dialogue)
            {
                Engine.print("tartarus: i'll pick you up on the ledge ahead.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0050"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => this.g_plug_ride_enforcer);
            if (this.dialogue)
            {
                Engine.print("tartarus: (angry growl) blasted machines!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0070"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("tartarus: make your own way through the wall, arbiter!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0080"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task sc_marines_a()
        {
            if (this.dialogue)
            {
                Engine.print("marine: negative, ma'am. they aren't covenant!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(conduit_b_sound.Entity, "0090"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("sarg: cover that doorway!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(conduit_b_sound.Entity, "0100"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task sc_marines_b()
        {
            if (this.dialogue)
            {
                Engine.print("marine: proceed to the objective! we'll hold out as long as we can!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(hall_c_sound.Entity, "0110"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("marine: aaa! get it off of me!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(hall_c_sound.Entity, "0120"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("sarg: suppressive fire! suppressive fi -");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(hall_c_sound.Entity, "0130"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(174, Lifecycle.CommandScript)]
        public async Task cs_sc_qz_ini()
        {
            if (this.dialogue)
            {
                Engine.print("spec-ops: forerunners be praised! the arbiter!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(qz_ini_ins_pods.Squad, "0530"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: this quarantine-zone has been compromised!");
            }

            if (this.dialogue)
            {
                Engine.print("spec-ops: we must do what we can against the flood!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(qz_ini_ins_pods.Squad, "0540"));
            await Engine.sleep((short)(this.dialogue_pause * 4));
            if (this.dialogue)
            {
                Engine.print("spec-ops: our commander has landed further in.");
            }

            if (this.dialogue)
            {
                Engine.print("spec-ops: let us join him!");
            }

            await Engine.sleep(Engine.ai_play_line_at_player(qz_ini_ins_pods.Squad, "0550"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task sc_qz_initial()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("sc_qz_ini", new ScriptMethodReference(cs_sc_qz_ini), qz_ini_ins_pods.Squad));
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task cs_cov_camp_elites()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("qz_cov_def"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => this.g_sc_cov_camp_done);
        }

        [ScriptMethod(177, Lifecycle.CommandScript)]
        public async Task cs_cov_camp_soc()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("qz_cov_def/soc"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => this.g_sc_cov_camp_done);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task sc_qz_cov_camp()
        {
            Engine.ai_vehicle_exit(qz_cov_def_cov.Squad);
            Engine.ai_vehicle_exit(qz_cov_def_soc.Squad);
            await Engine.sleep(30);
            Engine.cs_run_command_script(qz_cov_def_cov.Squad, new ScriptMethodReference(cs_cov_camp_elites));
            Engine.cs_run_command_script(qz_cov_def_soc.Squad, new ScriptMethodReference(cs_cov_camp_soc));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_cov_def_hill, Engine.players()), 30, 450);
            await Engine.sleep(15);
            if (this.dialogue)
            {
                Engine.print("commander: arbiter! what are you doing here?");
            }

            await Engine.sleep(Engine.ai_play_line(qz_cov_def_soc.Squad, "0170"));
            await Engine.sleep(this.dialogue_pause);
            this.g_qz_cov_camp_progress = true;
            await Engine.sleep(90);
            if (this.dialogue)
            {
                Engine.print("spec-ops: the flood is upon us!");
            }

            await Engine.sleep(Engine.ai_play_line(qz_cov_def_cov.Squad, "0190"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("commander: we must hold this camp until reinforcements arrive!");
            }

            await Engine.sleep(Engine.ai_play_line(qz_cov_def_soc.Squad, "0200"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: may our footsteps never fade!");
            }

            await Engine.sleep(Engine.ai_play_line(qz_cov_def_cov.Squad, "0210"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep(30);
            this.g_sc_cov_camp_done = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task attach_absorbers_1()
        {
            Engine.objects_attach(piston_ins.Entity, "absorber_a", absorber_ins.Entity, "absorber_a");
            Engine.objects_attach(piston_a.Entity, "absorber_a", absorber_a.Entity, "absorber_a");
            Engine.objects_attach(piston_b.Entity, "absorber_a", absorber_b.Entity, "absorber_a");
            Engine.objects_attach(piston_c.Entity, "absorber_a", absorber_c.Entity, "absorber_a");
            Engine.objects_attach(piston_d.Entity, "absorber_a", absorber_d.Entity, "absorber_a");
            Engine.objects_attach(piston_plug_landing.Entity, "absorber_a", absorber_plug_landing.Entity, "absorber_a");
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task attach_absorbers_1b()
        {
            Engine.objects_attach(piston_e.Entity, "absorber_a", absorber_e.Entity, "absorber_a");
            Engine.objects_attach(piston_f.Entity, "absorber_a", absorber_f.Entity, "absorber_a");
            Engine.objects_attach(piston_g.Entity, "absorber_a", absorber_g.Entity, "absorber_a");
            Engine.objects_attach(piston_h.Entity, "absorber_a", absorber_h.Entity, "absorber_a");
            Engine.objects_attach(piston_i.Entity, "absorber_a", absorber_i.Entity, "absorber_a");
            Engine.objects_attach(piston_ledge_b.Entity, "absorber_a", absorber_ledge_b.Entity, "absorber_a");
            Engine.objects_attach(piston_ledge_c.Entity, "absorber_a", absorber_ledge_c.Entity, "absorber_a");
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task attach_controls_1()
        {
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                Engine.object_destroy_containing("switch_a");
                Engine.object_destroy_containing("switch_b");
                Engine.object_destroy_containing("switch_c");
                Engine.object_destroy_containing("switch_d");
            }

            Engine.objects_attach(piston_ins.Entity, "absorber_a", ins_switch_a.Entity, "switch");
            Engine.objects_attach(piston_ins.Entity, "absorber_b", ins_switch_b.Entity, "switch");
            Engine.objects_attach(piston_ins.Entity, "absorber_c", ins_switch_c.Entity, "switch");
            Engine.objects_attach(piston_ins.Entity, "absorber_d", ins_switch_d.Entity, "switch");
            Engine.objects_attach(piston_a.Entity, "absorber_a", a_switch_a.Entity, "switch");
            Engine.objects_attach(piston_a.Entity, "absorber_b", a_switch_b.Entity, "switch");
            Engine.objects_attach(piston_a.Entity, "absorber_c", a_switch_c.Entity, "switch");
            Engine.objects_attach(piston_a.Entity, "absorber_d", a_switch_d.Entity, "switch");
            Engine.objects_attach(piston_b.Entity, "absorber_a", b_switch_a.Entity, "switch");
            Engine.objects_attach(piston_b.Entity, "absorber_b", b_switch_b.Entity, "switch");
            Engine.objects_attach(piston_b.Entity, "absorber_c", b_switch_c.Entity, "switch");
            Engine.objects_attach(piston_b.Entity, "absorber_d", b_switch_d.Entity, "switch");
            Engine.objects_attach(piston_c.Entity, "absorber_a", c_switch_a.Entity, "switch");
            Engine.objects_attach(piston_c.Entity, "absorber_b", c_switch_b.Entity, "switch");
            Engine.objects_attach(piston_c.Entity, "absorber_c", c_switch_c.Entity, "switch");
            Engine.objects_attach(piston_c.Entity, "absorber_d", c_switch_d.Entity, "switch");
            Engine.objects_attach(piston_d.Entity, "absorber_a", d_switch_a.Entity, "switch");
            Engine.objects_attach(piston_d.Entity, "absorber_b", d_switch_b.Entity, "switch");
            Engine.objects_attach(piston_d.Entity, "absorber_c", d_switch_c.Entity, "switch");
            Engine.objects_attach(piston_d.Entity, "absorber_d", d_switch_d.Entity, "switch");
            Engine.objects_attach(piston_plug_landing.Entity, "absorber_a", plug_landing_switch_a.Entity, "switch");
            Engine.objects_attach(piston_plug_landing.Entity, "absorber_b", plug_landing_switch_b.Entity, "switch");
            Engine.objects_attach(piston_plug_landing.Entity, "absorber_c", plug_landing_switch_c.Entity, "switch");
            Engine.objects_attach(piston_plug_landing.Entity, "absorber_d", plug_landing_switch_d.Entity, "switch");
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task attach_controls_1b()
        {
            Engine.objects_attach(piston_e.Entity, "absorber_a", e_switch_a.Entity, "switch");
            Engine.objects_attach(piston_e.Entity, "absorber_b", e_switch_b.Entity, "switch");
            Engine.objects_attach(piston_e.Entity, "absorber_c", e_switch_c.Entity, "switch");
            Engine.objects_attach(piston_e.Entity, "absorber_d", e_switch_d.Entity, "switch");
            Engine.objects_attach(piston_f.Entity, "absorber_a", f_switch_a.Entity, "switch");
            Engine.objects_attach(piston_f.Entity, "absorber_b", f_switch_b.Entity, "switch");
            Engine.objects_attach(piston_f.Entity, "absorber_c", f_switch_c.Entity, "switch");
            Engine.objects_attach(piston_f.Entity, "absorber_d", f_switch_d.Entity, "switch");
            Engine.objects_attach(piston_g.Entity, "absorber_a", g_switch_a.Entity, "switch");
            Engine.objects_attach(piston_g.Entity, "absorber_b", g_switch_b.Entity, "switch");
            Engine.objects_attach(piston_g.Entity, "absorber_c", g_switch_c.Entity, "switch");
            Engine.objects_attach(piston_g.Entity, "absorber_d", g_switch_d.Entity, "switch");
            Engine.objects_attach(piston_h.Entity, "absorber_a", h_switch_a.Entity, "switch");
            Engine.objects_attach(piston_h.Entity, "absorber_b", h_switch_b.Entity, "switch");
            Engine.objects_attach(piston_h.Entity, "absorber_c", h_switch_c.Entity, "switch");
            Engine.objects_attach(piston_h.Entity, "absorber_d", h_switch_d.Entity, "switch");
            Engine.objects_attach(piston_i.Entity, "absorber_a", i_switch_a.Entity, "switch");
            Engine.objects_attach(piston_i.Entity, "absorber_b", i_switch_b.Entity, "switch");
            Engine.objects_attach(piston_i.Entity, "absorber_c", i_switch_c.Entity, "switch");
            Engine.objects_attach(piston_i.Entity, "absorber_d", i_switch_d.Entity, "switch");
            Engine.objects_attach(piston_ledge_b.Entity, "absorber_a", ledge_b_switch_a.Entity, "switch");
            Engine.objects_attach(piston_ledge_b.Entity, "absorber_b", ledge_b_switch_b.Entity, "switch");
            Engine.objects_attach(piston_ledge_b.Entity, "absorber_c", ledge_b_switch_c.Entity, "switch");
            Engine.objects_attach(piston_ledge_b.Entity, "absorber_d", ledge_b_switch_d.Entity, "switch");
            Engine.objects_attach(piston_ledge_c.Entity, "absorber_a", ledge_c_switch_a.Entity, "switch");
            Engine.objects_attach(piston_ledge_c.Entity, "absorber_b", ledge_c_switch_b.Entity, "switch");
            Engine.objects_attach(piston_ledge_c.Entity, "absorber_c", ledge_c_switch_c.Entity, "switch");
            Engine.objects_attach(piston_ledge_c.Entity, "absorber_d", ledge_c_switch_d.Entity, "switch");
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task open_piston_ins()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_ins) > 0F || Engine.object_get_shield(absorber_ins.Entity) <= 0F, 1);
                Engine.device_set_position(piston_ins.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_ins.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_ins, Engine.players())));
                Engine.device_set_position(piston_ins.Entity, 0F);
                Engine.device_group_set_immediate(group_ins, 0F);
                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task open_piston_a()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_a) > 0F || Engine.object_get_shield(absorber_a.Entity) <= 0F, 1);
                Engine.device_set_position(piston_a.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_a.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_a, Engine.players())));
                Engine.device_set_position(piston_a.Entity, 0F);
                Engine.device_group_set_immediate(group_a, 0F);
                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task open_piston_b()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_b) > 0F || Engine.object_get_shield(absorber_b.Entity) <= 0F, 1);
                Engine.device_set_position(piston_b.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_b.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_b, Engine.players())));
                Engine.device_set_position(piston_b.Entity, 0F);
                Engine.device_group_set_immediate(group_b, 0F);
                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task open_piston_c()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_c) > 0F || Engine.object_get_shield(absorber_c.Entity) <= 0F, 1);
                Engine.device_set_position(piston_c.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_c.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_c, Engine.players())));
                Engine.device_set_position(piston_c.Entity, 0F);
                Engine.device_group_set_immediate(group_c, 0F);
                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task open_piston_d()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_d) > 0F || Engine.object_get_shield(absorber_d.Entity) <= 0F, 1);
                Engine.device_set_position(piston_d.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_d.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_d, Engine.players())));
                Engine.device_set_position(piston_d.Entity, 0F);
                Engine.device_group_set_immediate(group_d, 0F);
                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task open_piston_plug_landing()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_plug_landing) > 0F || Engine.object_get_shield(absorber_plug_landing.Entity) <= 0F, 1);
                Engine.device_set_position(piston_plug_landing.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_plug_landing.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_plug_landing, Engine.players())));
                Engine.device_set_position(piston_plug_landing.Entity, 0F);
                Engine.device_group_set_immediate(group_plug_landing, 0F);
                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task open_piston_e()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_e) > 0F || Engine.object_get_shield(absorber_e.Entity) <= 0F, 1);
                Engine.device_set_position(piston_e.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_e.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_e, Engine.players())));
                Engine.device_set_position(piston_e.Entity, 0F);
                Engine.device_group_set_immediate(group_e, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task open_piston_f()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_f) > 0F || Engine.object_get_shield(absorber_f.Entity) <= 0F, 1);
                Engine.device_set_position(piston_f.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_f.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_f, Engine.players())));
                Engine.device_set_position(piston_f.Entity, 0F);
                Engine.device_group_set_immediate(group_f, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task open_piston_g()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_g) > 0F || Engine.object_get_shield(absorber_g.Entity) <= 0F, 1);
                Engine.device_set_position(piston_g.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_g.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_g, Engine.players())));
                Engine.device_set_position(piston_g.Entity, 0F);
                Engine.device_group_set_immediate(group_g, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task open_piston_h()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_h) > 0F || Engine.object_get_shield(absorber_h.Entity) <= 0F, 1);
                Engine.device_set_position(piston_h.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_h.Entity);
                if (this.g_music_06a_07)
                {
                    this.g_music_06a_07 = false;
                }

                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_h, Engine.players())));
                Engine.device_set_position(piston_h.Entity, 0F);
                Engine.device_group_set_immediate(group_h, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task open_piston_i()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_i) > 0F || Engine.object_get_shield(absorber_i.Entity) <= 0F, 1);
                Engine.device_set_position(piston_i.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_i.Entity);
                if (this.g_music_06a_06)
                {
                    this.g_music_06a_06 = false;
                }

                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_i, Engine.players())));
                Engine.device_set_position(piston_i.Entity, 0F);
                Engine.device_group_set_immediate(group_i, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task open_piston_ledge_b()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_ledge_b) > 0F || Engine.object_get_shield(absorber_ledge_b.Entity) <= 0F, 1);
                Engine.device_set_position(piston_ledge_b.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_ledge_b.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_ledge_b, Engine.players())));
                Engine.device_set_position(piston_ledge_b.Entity, 0F);
                Engine.device_group_set_immediate(group_ledge_b, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task open_piston_ledge_c()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.device_group_get(group_ledge_c) > 0F || Engine.object_get_shield(absorber_ledge_c.Entity) <= 0F, 1);
                Engine.device_set_position(piston_ledge_c.Entity, 1F);
                Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), absorber_ledge_c.Entity);
                await Engine.sleep(this.piston_open_time);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_piston_ledge_c, Engine.players())));
                Engine.device_set_position(piston_ledge_c.Entity, 0F);
                Engine.device_group_set_immediate(group_ledge_c, 0F);
                return this.g_piston_control;
            });
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task piston_control()
        {
            Engine.wake(new ScriptMethodReference(attach_absorbers_1));
            Engine.wake(new ScriptMethodReference(attach_controls_1));
            Engine.wake(new ScriptMethodReference(open_piston_ins));
            Engine.wake(new ScriptMethodReference(open_piston_a));
            Engine.wake(new ScriptMethodReference(open_piston_b));
            Engine.wake(new ScriptMethodReference(open_piston_c));
            Engine.wake(new ScriptMethodReference(open_piston_d));
            Engine.wake(new ScriptMethodReference(open_piston_plug_landing));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            if (this.debug)
            {
                Engine.print("creating bsp 1 objects...");
            }

            Engine.object_create_anew_containing("bsp1_weapon");
            Engine.object_create_anew_containing("bsp1_equip");
            Engine.wake(new ScriptMethodReference(attach_absorbers_1b));
            Engine.wake(new ScriptMethodReference(attach_controls_1b));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_ins));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_a));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_b));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_c));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_d));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_plug_landing));
            Engine.wake(new ScriptMethodReference(open_piston_e));
            Engine.wake(new ScriptMethodReference(open_piston_f));
            Engine.wake(new ScriptMethodReference(open_piston_g));
            Engine.wake(new ScriptMethodReference(open_piston_h));
            Engine.wake(new ScriptMethodReference(open_piston_i));
            Engine.wake(new ScriptMethodReference(open_piston_ledge_b));
            Engine.wake(new ScriptMethodReference(open_piston_ledge_c));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.object_destroy_containing("bsp1_body");
            Engine.object_destroy_containing("bsp1_weapon");
            Engine.object_destroy_containing("bsp1_equip");
            Engine.sleep_forever(new ScriptMethodReference(open_piston_e));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_f));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_g));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_h));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_i));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_ledge_b));
            Engine.sleep_forever(new ScriptMethodReference(open_piston_ledge_c));
        }

        [ScriptMethod(197, Lifecycle.CommandScript)]
        public async Task cs_pussy_grunt_abort()
        {
            await Engine.sleep(1);
            Engine.object_can_take_damage(Engine.ai_actors(pussy_grunt1.Squad));
            Engine.ai_set_orders(pussy_grunt1.Squad, hall_a_cov);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task pussy_grunt_abort()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ins_slide_bottom, Engine.ai_actors(pussy_grunt1.Squad)));
            Engine.cs_run_command_script(pussy_grunt1.Squad, new ScriptMethodReference(cs_pussy_grunt_abort));
        }

        [ScriptMethod(199, Lifecycle.CommandScript)]
        public async Task pussy_grunt_down()
        {
            Engine.wake(new ScriptMethodReference(pussy_grunt_abort));
            Engine.cs_enable_dialogue(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_movement_mode(2);
            Engine.cs_crouch(false);
            Engine.object_cannot_take_damage(Engine.ai_actors(pussy_grunt1.Squad));
            await Engine.sleep_until(async () => Engine.device_get_position(piston_ins.Entity) >= 0.5F, 10);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/grunt_stand"), Engine.GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            Engine.cs_jump(0F, 1F);
            await Engine.sleep(15);
            Engine.cs_move_in_direction(0F, 5F, 0F);
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task pussy_grunt_shoot()
        {
            Engine.cs_movement_mode(2);
            Engine.cs_crouch(false);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/grunt_stand"), Engine.GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            await Engine.sleep(15);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            await Engine.sleep_until(async () => Engine.object_get_shield(absorber_ins.Entity) <= 0F, 5);
            await Engine.sleep(15);
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("insertion/grunt_shoot"));
            Engine.cs_run_command_script(pussy_grunt1.Squad, new ScriptMethodReference(pussy_grunt_down));
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task pussy_grunt()
        {
            if ((short)Engine.ai_combat_status(insertion_sen.Squad) >= this.ai_combat_status_active)
            {
                await Engine.sleep_until(async () => Engine.object_get_health(ins_em_a.Entity) <= 0F && Engine.object_get_health(ins_em_b.Entity) <= 0F && Engine.object_get_health(ins_em_c.Entity) <= 0F);
            }

            await Engine.sleep(45);
            if (Engine.device_get_position(piston_ins.Entity) == 0F)
            {
                Engine.cs_run_command_script(pussy_grunt1.Squad, new ScriptMethodReference(pussy_grunt_shoot));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_insertion_tube, Engine.players()), 5);
            Engine.cs_run_command_script(pussy_grunt1.Squad, new ScriptMethodReference(pussy_grunt_down));
        }

        [ScriptMethod(202, Lifecycle.CommandScript)]
        public async Task cs_pussy_grunt()
        {
            Engine.cs_movement_mode(3);
            Engine.cs_crouch(true);
            Engine.ai_disregard(Engine.ai_actors(constructors), true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_pussy_grunt, Engine.players()) || (float)Engine.ai_strength(pussy_grunt1.Squad) < 1F);
            Engine.cs_movement_mode(2);
            Engine.cs_crouch(false);
            Engine.wake(new ScriptMethodReference(pussy_grunt));
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task pussy_grunt_reminder()
        {
            await Engine.sleep((short)(30 * 60 * 5));
            if (!(this.g_pussy_grunt))
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ins_bk, Engine.players()));
                if ((short)Engine.ai_combat_status(insertion_sen.Squad) >= this.ai_combat_status_active)
                {
                    await Engine.sleep_until(async () => Engine.object_get_health(ins_em_a.Entity) <= 0F && Engine.object_get_health(ins_em_b.Entity) <= 0F && Engine.object_get_health(ins_em_c.Entity) <= 0F);
                }

                await Engine.sleep(45);
                if (Engine.device_get_position(piston_ins.Entity) == 1F)
                {
                    Engine.cs_run_command_script(pussy_grunt1.Squad, new ScriptMethodReference(pussy_grunt_shoot));
                }
            }
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_miniaturize()
        {
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.3F, 0);
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_big()
        {
            Engine.cs_enable_moving(true);
            await Engine.sleep((short)(30 * 10));
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 2.1F, 0);
        }

        [ScriptMethod(206, Lifecycle.CommandScript)]
        public async Task cs_ins_weld_a()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/p3"), Engine.GetReference<ISpatialPoint>("insertion/p4"));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("insertion/p4"));
            await Engine.sleep((short)Engine.random_range(300, 450));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("insertion/p4"));
        }

        [ScriptMethod(207, Lifecycle.CommandScript)]
        public async Task cs_ins_weld_b()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/p5"), Engine.GetReference<ISpatialPoint>("insertion/p6"));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("insertion/p6"));
            await Engine.sleep((short)Engine.random_range(150, 300));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("insertion/p6"));
        }

        [ScriptMethod(208, Lifecycle.CommandScript)]
        public async Task cs_ins_weld_c()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/p7"), Engine.GetReference<ISpatialPoint>("insertion/p8"));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("insertion/p8"));
            await Engine.sleep((short)Engine.random_range(45, 60));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("insertion/p8"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/p9"), Engine.GetReference<ISpatialPoint>("insertion/p10"));
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("insertion/p10"));
            await Engine.sleep((short)Engine.random_range(45, 60));
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("insertion/p10"));
        }

        [ScriptMethod(209, Lifecycle.CommandScript)]
        public async Task cs_ins_shoot_absorber_slide()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/shoot_slide"), Engine.GetReference<ISpatialPoint>("insertion/target_slide"), 0.25F);
            await Engine.sleep(15);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("insertion/target_slide"));
            await Engine.sleep_until(async () => Engine.object_get_shield(absorber_a.Entity) <= 0F, 5);
            await Engine.sleep(15);
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("insertion/target_slide"));
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task ins_open_door_slide()
        {
            Engine.ai_place(ins_con_slide.Squad);
            if ((float)Engine.ai_strength(ins_cons) == 1F)
            {
                Engine.ai_set_orders(ins_con_mid.Squad, ins_sen_slide);
                Engine.ai_set_orders(ins_con_bk.Squad, ins_sen_slide);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ins_slide_bottom, Engine.players()) && Engine.objects_can_see_object(Engine.players(), piston_a.Entity, 180F));
            Engine.cs_run_command_script(ins_con_slide.shooter, new ScriptMethodReference(cs_ins_shoot_absorber_slide));
        }

        [ScriptMethod(211, Lifecycle.CommandScript)]
        public async Task cs_ins_runaway()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("insertion/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("insertion/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("insertion/p2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(212, Lifecycle.CommandScript)]
        public async Task cs_ins_shoot_absorber()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("insertion/shoot_ins"), Engine.GetReference<ISpatialPoint>("insertion/target_ins"), 0.25F);
            await Engine.sleep(15);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("insertion/target_ins"));
            await Engine.sleep_until(async () => Engine.object_get_shield(absorber_ins.Entity) <= 0F, 5);
            Engine.wake(new ScriptMethodReference(ins_open_door_slide));
            await Engine.sleep(15);
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("insertion/target_ins"));
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task ins_open_door()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ins_bk, Engine.players()) && Engine.objects_can_see_object(Engine.players(), piston_ins.Entity, 180F));
            if ((float)Engine.ai_strength(ins_cons) == 1F)
            {
                Engine.cs_run_command_script(ins_con_bk.shooter, new ScriptMethodReference(cs_ins_shoot_absorber));
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(insertion_sentinels) <= this.g_insertion_limit);
                if (this.g_insertion_spawn)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep(this.g_emitter_delay);
                this.g_insertion_counter = 0;
                this.g_insertion_wave = false;
                await Engine.sleep_until(async () =>
                {
                    Engine.ai_place(insertion_sen.Squad, 1);
                    this.g_insertion_counter = (short)(this.g_insertion_counter + 1);
                    if (this.g_insertion_counter == this.g_insertion_index)
                    {
                        this.g_insertion_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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
                Engine.print("c");
            }

            Engine.ai_place(hall_a_sen.c);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(216, Lifecycle.Static)]
        public async Task ai_hall_a_em_d()
        {
            if (this.debug)
            {
                Engine.print("d");
            }

            Engine.ai_place(hall_a_sen.d);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task ai_hall_a_em_g()
        {
            if (this.debug)
            {
                Engine.print("g");
            }

            Engine.ai_place(hall_a_sen.g);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task ai_hall_a_em_h()
        {
            if (this.debug)
            {
                Engine.print("h");
            }

            Engine.ai_place(hall_a_sen.h);
            this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(hall_a_sentinels) <= this.g_hall_a_sen_limit);
                if (this.g_hall_a_loops)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep(this.g_emitter_delay);
                this.g_hall_a_em_count = 0;
                this.g_hall_a_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(hall_a_em_c.Entity)) && Engine.object_get_health(hall_a_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_c.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_c();
                    }
                    else if (!(Engine.unit_is_emitting(hall_a_em_d.Entity)) && Engine.object_get_health(hall_a_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_d.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_d();
                    }
                    else if (!(Engine.unit_is_emitting(hall_a_em_g.Entity)) && Engine.object_get_health(hall_a_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_g.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_g();
                    }
                    else if (!(Engine.unit_is_emitting(hall_a_em_h.Entity)) && Engine.object_get_health(hall_a_em_h.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_h.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_a_em_h.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_a_em_h();
                    }
                    else if (true)
                    {
                        Engine.ai_place(hall_a_sen.Squad);
                        this.g_hall_a_em_count = (short)(this.g_hall_a_em_count + 1);
                    }

                    if (this.g_hall_a_em_count == this.g_hall_a_em_index)
                    {
                        this.g_hall_a_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_hall_a_wave;
                });
                return this.g_hall_a_loops;
            });
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task ai_hall_a_const()
        {
            Engine.ai_place(hall_a_con_ini.Squad);
            Engine.ai_place(hall_a_con_bk.Squad);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(hall_a_cons) < 0.8F);
            await Engine.sleep(30);
            if (this.debug)
            {
                Engine.print("hall a constructors running away");
            }

            Engine.ai_set_orders(constructors, hall_a_runway);
        }

        [ScriptMethod(221, Lifecycle.Static)]
        public async Task ai_cond_a_em_a()
        {
            if (this.debug)
            {
                Engine.print("a");
            }

            Engine.ai_place(cond_a_sen_a.a);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(222, Lifecycle.Static)]
        public async Task ai_cond_a_em_c()
        {
            if (this.debug)
            {
                Engine.print("c");
            }

            Engine.ai_place(cond_a_sen_a.c);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(223, Lifecycle.Static)]
        public async Task ai_cond_a_em_e()
        {
            if (this.debug)
            {
                Engine.print("e");
            }

            Engine.ai_place(cond_a_sen_a.e);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task ai_cond_a_em_f()
        {
            if (this.debug)
            {
                Engine.print("f");
            }

            Engine.ai_place(cond_a_sen_a.f);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(225, Lifecycle.Static)]
        public async Task ai_cond_a_em_g()
        {
            if (this.debug)
            {
                Engine.print("g");
            }

            Engine.ai_place(cond_a_sen_a.g);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(226, Lifecycle.Static)]
        public async Task ai_cond_a_em_h()
        {
            if (this.debug)
            {
                Engine.print("h");
            }

            Engine.ai_place(cond_a_sen_a.h);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(227, Lifecycle.Static)]
        public async Task ai_cond_a_em_i()
        {
            if (this.debug)
            {
                Engine.print("i");
            }

            Engine.ai_place(cond_a_sen_b.i);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(228, Lifecycle.Static)]
        public async Task ai_cond_a_em_j()
        {
            if (this.debug)
            {
                Engine.print("j");
            }

            Engine.ai_place(cond_a_sen_b.j);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(229, Lifecycle.Static)]
        public async Task ai_cond_a_em_k()
        {
            if (this.debug)
            {
                Engine.print("k");
            }

            Engine.ai_place(cond_a_sen_b.k);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(230, Lifecycle.Static)]
        public async Task ai_cond_a_em_l()
        {
            if (this.debug)
            {
                Engine.print("l");
            }

            Engine.ai_place(cond_a_sen_b.l);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(231, Lifecycle.Static)]
        public async Task ai_cond_a_em_m()
        {
            if (this.debug)
            {
                Engine.print("m");
            }

            Engine.ai_place(cond_a_sen_b.m);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task ai_cond_a_em_n()
        {
            if (this.debug)
            {
                Engine.print("n");
            }

            Engine.ai_place(cond_a_sen_b.n);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(233, Lifecycle.Static)]
        public async Task ai_cond_a_em_o()
        {
            if (this.debug)
            {
                Engine.print("o");
            }

            Engine.ai_place(cond_a_sen_b.o);
            this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cond_a_sentinels) <= this.g_cond_a_limit);
                if (await this.difficulty_legendary())
                {
                    await Engine.sleep(this.g_emitter_delay);
                }
                else
                {
                    await Engine.sleep((short)(this.g_emitter_delay * 2));
                }

                if (this.g_cond_a_front)
                {
                    Engine.sleep_forever();
                }

                this.g_cond_a_count = 0;
                this.g_cond_a_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(cond_a_em_c.Entity)) && Engine.object_get_health(cond_a_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_c.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_c();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_f.Entity)) && Engine.object_get_health(cond_a_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_f.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_f();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_g.Entity)) && Engine.object_get_health(cond_a_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_g.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_g();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_e.Entity)) && Engine.object_get_health(cond_a_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_e.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_e();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_h.Entity)) && Engine.object_get_health(cond_a_em_h.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_h.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_h();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_a.Entity)) && Engine.object_get_health(cond_a_em_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_a.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_a();
                    }
                    else if (true)
                    {
                        Engine.ai_place(cond_a_sen_a.Squad);
                        this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
                    }

                    if (this.g_cond_a_count == this.g_cond_a_index)
                    {
                        this.g_cond_a_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_cond_a_wave;
                });
                return this.g_cond_a_front;
            });
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task ai_cond_a_emitters_bk()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cond_a_sentinels) <= this.g_cond_a_limit);
                if (await this.difficulty_legendary())
                {
                    await Engine.sleep(this.g_emitter_delay);
                }
                else
                {
                    await Engine.sleep((short)(this.g_emitter_delay * 2));
                }

                if (this.g_cond_a_back)
                {
                    Engine.sleep_forever();
                }

                this.g_cond_a_count = 0;
                this.g_cond_a_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(cond_a_em_k.Entity)) && Engine.object_get_health(cond_a_em_k.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_k.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_k();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_o.Entity)) && Engine.object_get_health(cond_a_em_o.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_o.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_o();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_n.Entity)) && Engine.object_get_health(cond_a_em_n.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_n.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_n();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_j.Entity)) && Engine.object_get_health(cond_a_em_j.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_j.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_j();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_l.Entity)) && Engine.object_get_health(cond_a_em_l.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_l.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_l();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_m.Entity)) && Engine.object_get_health(cond_a_em_m.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_m.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_m();
                    }
                    else if (!(Engine.unit_is_emitting(cond_a_em_i.Entity)) && Engine.object_get_health(cond_a_em_i.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), cond_a_em_i.Entity) > 5F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_cond_a_em_i();
                    }
                    else if (true)
                    {
                        Engine.ai_place(cond_a_sen_b.Squad);
                        this.g_cond_a_count = (short)(this.g_cond_a_count + 1);
                    }

                    if (this.g_cond_a_count == this.g_cond_a_index)
                    {
                        this.g_cond_a_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

            await Engine.sleep(180);
            Engine.begin_random(async () => Engine.ai_place(cond_a_sen_b.j), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    Engine.sleep_forever();
                }
            }, 
                async () => Engine.ai_place(cond_a_sen_b.k), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    Engine.sleep_forever();
                }
            }, 
                async () => Engine.ai_place(cond_a_sen_b.m), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    Engine.sleep_forever();
                }
            }, 
                async () => Engine.ai_place(cond_a_sen_b.o), 
                async () => this.g_cond_a_bk_count = (short)(this.g_cond_a_bk_count + 1), 
                async () =>
            {
                if (this.g_cond_a_bk_count == this.g_cond_a_bk_limit)
                {
                    Engine.sleep_forever();
                }
            }, 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)));
        }

        [ScriptMethod(237, Lifecycle.CommandScript)]
        public async Task cs_cond_a_sen_e()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("cond_a/p0"));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task cond_a_delay()
        {
            await Engine.sleep(90);
            this.g_cond_a_continue = true;
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task cond_a_initial_delay()
        {
            await Engine.sleep_until(async () =>
            {
                if (!(Engine.volume_test_objects_all(tv_conduit_a, Engine.players())))
                {
                    this.g_cond_a_continue = true;
                }
                else if ((short)Engine.ai_living_count(cond_a_sentinels) <= 0)
                {
                    Engine.wake(new ScriptMethodReference(cond_a_delay));
                }

                return this.g_cond_a_continue;
            });
        }

        [ScriptMethod(240, Lifecycle.Static)]
        public async Task ai_hall_b_em_b()
        {
            if (this.debug)
            {
                Engine.print("b");
            }

            Engine.ai_place(hall_b_sen.b);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(241, Lifecycle.Static)]
        public async Task ai_hall_b_em_d()
        {
            if (this.debug)
            {
                Engine.print("d");
            }

            Engine.ai_place(hall_b_sen.d);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(242, Lifecycle.Static)]
        public async Task ai_hall_b_em_e()
        {
            if (this.debug)
            {
                Engine.print("e");
            }

            Engine.ai_place(hall_b_sen.e);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(243, Lifecycle.Static)]
        public async Task ai_hall_b_em_f()
        {
            if (this.debug)
            {
                Engine.print("f");
            }

            Engine.ai_place(hall_b_sen.f);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task ai_hall_b_em_g()
        {
            if (this.debug)
            {
                Engine.print("g");
            }

            Engine.ai_place(hall_b_sen.g);
            this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(hall_b_sentinels) <= this.g_hall_b_sen_limit);
                if (this.g_hall_b_loops)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep(this.g_emitter_delay);
                this.g_hall_b_em_count = 0;
                this.g_hall_b_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(hall_b_em_b.Entity)) && Engine.object_get_health(hall_b_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_b.Entity) < 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_d();
                    }
                    else if (!(Engine.unit_is_emitting(hall_b_em_d.Entity)) && Engine.object_get_health(hall_b_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_d.Entity) < 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_d();
                    }
                    else if (!(Engine.unit_is_emitting(hall_b_em_e.Entity)) && Engine.object_get_health(hall_b_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_e.Entity) < 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_e();
                    }
                    else if (!(Engine.unit_is_emitting(hall_b_em_f.Entity)) && Engine.object_get_health(hall_b_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_f.Entity) < 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_f();
                    }
                    else if (!(Engine.unit_is_emitting(hall_b_em_g.Entity)) && Engine.object_get_health(hall_b_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), hall_b_em_g.Entity) < 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_hall_b_em_g();
                    }
                    else if (true)
                    {
                        Engine.ai_place(hall_b_sen.Squad);
                        this.g_hall_b_em_count = (short)(this.g_hall_b_em_count + 1);
                    }

                    if (this.g_hall_b_em_count == this.g_hall_b_em_index)
                    {
                        this.g_hall_b_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_hall_b_wave;
                });
                return this.g_hall_b_loops;
            });
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cs_plug_launch_enforcer()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("plug_launch/p0"));
        }

        [ScriptMethod(247, Lifecycle.Static)]
        public async Task ai_plug_launch_em_a()
        {
            if (this.debug)
            {
                Engine.print("a");
            }

            Engine.ai_place(plug_launch_sen.a);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(248, Lifecycle.Static)]
        public async Task ai_plug_launch_em_b()
        {
            if (this.debug)
            {
                Engine.print("b");
            }

            Engine.ai_place(plug_launch_sen.b);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(249, Lifecycle.Static)]
        public async Task ai_plug_launch_em_c()
        {
            if (this.debug)
            {
                Engine.print("c");
            }

            Engine.ai_place(plug_launch_sen.c);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(250, Lifecycle.Static)]
        public async Task ai_plug_launch_em_d()
        {
            if (this.debug)
            {
                Engine.print("d");
            }

            Engine.ai_place(plug_launch_sen.d);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(251, Lifecycle.Static)]
        public async Task ai_plug_launch_em_e()
        {
            if (this.debug)
            {
                Engine.print("e");
            }

            Engine.ai_place(plug_launch_sen.e);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(252, Lifecycle.Static)]
        public async Task ai_plug_launch_em_f()
        {
            if (this.debug)
            {
                Engine.print("f");
            }

            Engine.ai_place(plug_launch_sen.f);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(253, Lifecycle.Static)]
        public async Task ai_plug_launch_em_g()
        {
            if (this.debug)
            {
                Engine.print("g");
            }

            Engine.ai_place(plug_launch_sen.g);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(254, Lifecycle.Static)]
        public async Task ai_plug_launch_em_h()
        {
            if (this.debug)
            {
                Engine.print("h");
            }

            Engine.ai_place(plug_launch_sen.h);
            this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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
                    Engine.print("emitters off");
                }

                Engine.sleep_forever();
            }
            else if (await this.difficulty_heroic())
            {
                this.g_plug_launch_limit = 0;
                this.g_plug_launch_index = 3;
                await Engine.sleep_until(async () => this.g_plug_launch_em_heroic);
                if (this.debug)
                {
                    Engine.print("emitters on");
                }
            }
            else if (await this.difficulty_legendary())
            {
                this.g_plug_launch_limit = 0;
                this.g_plug_launch_index = 4;
                if (this.debug)
                {
                    Engine.print("emitters on");
                }
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_launch_sentinels) <= this.g_plug_launch_limit);
                if (this.g_plug_launch_loops)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep(this.g_emitter_delay);
                this.g_plug_launch_count = 0;
                this.g_plug_launch_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(plug_launch_em_a.Entity)) && Engine.object_get_health(plug_launch_em_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_a.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_a();
                    }
                    else if (!(Engine.unit_is_emitting(plug_launch_em_b.Entity)) && Engine.object_get_health(plug_launch_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_b.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_b();
                    }
                    else if (!(Engine.unit_is_emitting(plug_launch_em_c.Entity)) && Engine.object_get_health(plug_launch_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_c.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_c();
                    }
                    else if (!(Engine.unit_is_emitting(plug_launch_em_d.Entity)) && Engine.object_get_health(plug_launch_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_d.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_d();
                    }
                    else if (!(Engine.unit_is_emitting(plug_launch_em_e.Entity)) && Engine.object_get_health(plug_launch_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_e.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_e();
                    }
                    else if (!(Engine.unit_is_emitting(plug_launch_em_f.Entity)) && Engine.object_get_health(plug_launch_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_f.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_f();
                    }
                    else if (!(Engine.unit_is_emitting(plug_launch_em_g.Entity)) && Engine.object_get_health(plug_launch_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_g.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_g();
                    }
                    else if (!(Engine.unit_is_emitting(plug_launch_em_g.Entity)) && Engine.object_get_health(plug_launch_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_launch_em_g.Entity) > 10F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_launch_em_g();
                    }
                    else if (true)
                    {
                        Engine.ai_place(plug_launch_sen.Squad);
                        this.g_plug_launch_count = (short)(this.g_plug_launch_count + 1);
                    }

                    if (this.g_plug_launch_count == this.g_plug_launch_index)
                    {
                        this.g_plug_launch_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_plug_launch_wave;
                });
                return this.g_plug_launch_loops;
            });
        }

        [ScriptMethod(256, Lifecycle.Static)]
        public async Task<int> absorber05_count()
        {
            if (Engine.object_get_shield(plugabsorber05.Entity) <= 0F)
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
            if (Engine.object_get_shield(plugabsorber06.Entity) <= 0F)
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
            if (Engine.object_get_shield(plugabsorber07.Entity) <= 0F)
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
            if (Engine.object_get_shield(plugabsorber08.Entity) <= 0F)
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
            await Engine.sleep_until(async () => Engine.device_group_get(group_plug_c) > 0F || Engine.object_get_shield(plugabsorber08.Entity) <= 0F, 5);
            Engine.device_set_position(plug_thin_fr.Entity, 1F);
            Engine.device_set_position(plug_thick_fr.Entity, 1F);
            Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), plugabsorber08.Entity);
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task plug_rods07()
        {
            await Engine.sleep_until(async () => Engine.device_group_get(group_plug_d) > 0F || Engine.object_get_shield(plugabsorber07.Entity) <= 0F, 5);
            Engine.device_set_position(plug_thin_br.Entity, 1F);
            Engine.device_set_position(plug_thick_br.Entity, 1F);
            Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), plugabsorber07.Entity);
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task plug_rods06()
        {
            await Engine.sleep_until(async () => Engine.device_group_get(group_plug_a) > 0F || Engine.object_get_shield(plugabsorber06.Entity) <= 0F, 5);
            Engine.device_set_position(plug_thin_bl.Entity, 1F);
            Engine.device_set_position(plug_thick_bl.Entity, 1F);
            Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), plugabsorber06.Entity);
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task plug_rods05()
        {
            await Engine.sleep_until(async () => Engine.device_group_get(group_plug_b) > 0F || Engine.object_get_shield(plugabsorber05.Entity) <= 0F, 5);
            Engine.device_set_position(plug_thin_fl.Entity, 1F);
            Engine.device_set_position(plug_thick_fl.Entity, 1F);
            Engine.damage_object(Engine.GetTag<DamageEffectTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\damage_effects\\damage_absorber", 2223776317U), plugabsorber05.Entity);
        }

        [ScriptMethod(265, Lifecycle.Static)]
        public async Task test_ab()
        {
            Engine.object_set_shield(plugabsorber08.Entity, 0F);
            Engine.object_set_shield(plugabsorber07.Entity, 0F);
            Engine.object_set_shield(plugabsorber06.Entity, 0F);
            Engine.object_set_shield(plugabsorber05.Entity, 0F);
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task plug_absorbers()
        {
            Engine.objects_attach(plug.Entity, "absorber_a01", plugabsorber06.Entity, "absorber");
            Engine.objects_attach(plug.Entity, "absorber_b01", plugabsorber05.Entity, "absorber");
            Engine.objects_attach(plug.Entity, "absorber_c01", plugabsorber08.Entity, "absorber");
            Engine.objects_attach(plug.Entity, "absorber_d01", plugabsorber07.Entity, "absorber");
            Engine.objects_attach(plug.Entity, "switch", plug_switch_housing.Entity, "");
            Engine.objects_attach(plug.Entity, "absorber_a01", plug_switch_a.Entity, "switch");
            Engine.objects_attach(plug.Entity, "absorber_b01", plug_switch_b.Entity, "switch");
            Engine.objects_attach(plug.Entity, "absorber_c01", plug_switch_c.Entity, "switch");
            Engine.objects_attach(plug.Entity, "absorber_d01", plug_switch_d.Entity, "switch");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(plug_rods08));
            Engine.wake(new ScriptMethodReference(plug_rods07));
            Engine.wake(new ScriptMethodReference(plug_rods06));
            Engine.wake(new ScriptMethodReference(plug_rods05));
            Engine.wake(new ScriptMethodReference(sc_plug_launch));
            await Engine.sleep(90);
            if (this.debug)
            {
                Engine.print("only 4 more to go!!");
            }

            await Engine.sleep_until(async () => await this.absorber_totalcount() <= 3);
            if (this.debug)
            {
                Engine.print("absorber activated!");
            }

            await Engine.sleep_until(async () => await this.absorber_totalcount() <= 2);
            if (this.debug)
            {
                Engine.print("absorber activated!");
            }

            this.g_plug_launch_em_heroic = true;
            await Engine.sleep_until(async () => await this.absorber_totalcount() <= 1);
            if (this.debug)
            {
                Engine.print("absorber activated!");
            }

            this.g_final_lock = true;
            await Engine.sleep_until(async () => await this.absorber_totalcount() <= 0);
            if (this.debug)
            {
                Engine.print("absorber activated!");
            }

            this.g_flip_switch = true;
            Engine.device_set_position(plug_switch_housing.Entity, 1F);
            Engine.ai_set_orders(covenant1, plug_cov);
            await Engine.sleep_until(async () => Engine.device_get_position(plug_switch_housing.Entity) >= 1F, 1, 120);
            await Engine.sleep(30);
            Engine.object_create(plug_switch);
            Engine.objects_attach(plug_switch_housing.Entity, "switch", plug_switch.Entity, "");
            Engine.device_set_power(plug_switch.Entity, 1F);
            Engine.device_set_position(plug_switch.Entity, 1F);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.device_get_position(plug_switch.Entity) >= 1F, 1);
            Engine.device_group_change_only_once_more_set(plug1, true);
            await Engine.sleep_until(async () => Engine.device_get_position(plug_switch.Entity) <= 0F, 1);
            await Engine.sleep(60);
            Engine.device_set_power(plug_switch.Entity, 0F);
            this.g_plug_move = true;
        }

        [ScriptMethod(267, Lifecycle.CommandScript)]
        public async Task cs_gap_phantom()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p1"), 4F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p2"), 4F);
            Engine.wake(new ScriptMethodReference(sc_plug_ride));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p3"), 4F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p9"), 7F);
            if (this.debug)
            {
                Engine.print("placing enforcer...");
            }

            Engine.ai_place(plug_holder_enforcer.Squad);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("wall_gap/p10"), Engine.GetReference<ISpatialPoint>("wall_gap/p20"), 3F);
            Engine.device_group_change_only_once_more_set(plug_door_a1, false);
            await Engine.sleep(1);
            if (this.debug)
            {
                Engine.print("opening door... (closing the one behind you)");
            }

            Engine.device_set_position(plug_door_a.Entity, 0F);
            Engine.device_set_position(plug_door_b.Entity, 1F);
            await Engine.sleep(1);
            if (this.debug)
            {
                Engine.print("placing eliminators...");
            }

            Engine.ai_place(plug_holder_sen_elim.Squad, 2);
            await Engine.sleep(1);
            await Engine.sleep((short)(30 * 5));
            if (this.debug)
            {
                Engine.print("placing initial flood...");
            }

            Engine.ai_place(plug_holder_flood_a.Squad, 1);
            Engine.ai_place(plug_holder_flood_d.Squad);
            Engine.ai_place(plug_holder_flood_c.Squad);
            Engine.ai_place(plug_holder_flood_d.Squad, 1);
            this.g_plug_ride_enforcer = true;
            Engine.sound_class_set_gain("object_impacts", 1F, 2);
            Engine.sound_class_set_gain("vehicle_collision", 1F, 2);
            Engine.cs_vehicle_speed(0.4F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p11"), 2F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p12"), 2F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("wall_gap/p13"), Engine.GetReference<ISpatialPoint>("wall_gap/p15"), 10F);
            Engine.cs_vehicle_speed(1F);
            Engine.wake(new ScriptMethodReference(objective_floodwall_set));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p15"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("wall_gap/p16"), 10F);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(268, Lifecycle.Static)]
        public async Task test_phantom()
        {
            Engine.ai_place(gap_phantom.Squad);
            await Engine.sleep(1);
            Engine.cs_run_command_script(gap_phantom.Squad, new ScriptMethodReference(cs_gap_phantom));
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task lower_shield()
        {
            if (this.debug)
            {
                Engine.print("containment-field created");
            }

            Engine.object_create(containment_field);
            await Engine.sleep_until(async () => this.g_lower_shield, 5);
            if (this.debug)
            {
                Engine.print("lowering the containment-shield");
            }

            Engine.device_set_position(containment_field.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(containment_field.Entity) >= 1F);
            Engine.object_destroy(containment_field.Entity);
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task bsp0_cleanup()
        {
            if (this.debug)
            {
                Engine.print("bsp 0 cleanup...");
            }

            Engine.object_destroy_containing("bsp0_body");
            Engine.object_destroy_containing("bsp0_weapon");
            Engine.object_destroy_containing("bsp0_equip");
            Engine.object_destroy_containing("bsp0_crate");
            Engine.object_destroy_containing("ins_em");
            Engine.object_destroy_containing("hall_a_em");
            Engine.object_destroy_containing("cond_a_em");
            Engine.object_destroy_containing("hall_b_em");
            Engine.object_destroy_containing("plug_launch_em");
            Engine.object_destroy(piston_ins.Entity);
            Engine.object_destroy(piston_a.Entity);
            Engine.object_destroy(piston_b.Entity);
            Engine.object_destroy(piston_c.Entity);
            Engine.object_destroy(absorber_ins.Entity);
            Engine.object_destroy(absorber_a.Entity);
            Engine.object_destroy(absorber_a.Entity);
            Engine.object_destroy(absorber_b.Entity);
            Engine.object_destroy(absorber_c.Entity);
            Engine.ai_erase(insertion_sentinels);
            Engine.ai_erase(hall_a_sentinels);
            Engine.ai_erase(cond_a_sentinels);
            Engine.ai_erase(hall_b_sentinels);
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task cs_move_plug()
        {
            Engine.wake(new ScriptMethodReference(lower_shield));
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\sentinel_wall_power_down", 2223841854U), default(IGameObject), 1F);
            Engine.ai_kill(plug_launch_sen.Squad);
            Engine.ai_kill(plug_launch_enforcer.Squad);
            Engine.begin_random(async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_a.Entity, "emitter", 2F), 
                async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_b.Entity, "emitter", 2F), 
                async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_c.Entity, "emitter", 2F), 
                async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_d.Entity, "emitter", 2F), 
                async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_e.Entity, "emitter", 2F), 
                async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_f.Entity, "emitter", 2F), 
                async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_g.Entity, "emitter", 2F), 
                async () => await Engine.sleep((short)Engine.random_range(0, 10)), 
                async () => Engine.object_damage_damage_section(plug_launch_em_h.Entity, "emitter", 2F));
            await Engine.sleep(30);
            Engine.device_set_position(plug_keylock_c.Entity, 1F);
            Engine.device_set_position(plug_keylock_d.Entity, 1F);
            if (this.debug)
            {
                Engine.print("opening door...");
            }

            Engine.device_set_position(plug_door_a.Entity, 1F);
            Engine.object_create(plug_doors_open);
            await Engine.sleep_until(async () => Engine.device_get_position(plug_door_a.Entity) >= 0.5F, 10);
            Engine.data_mine_set_mission_segment("enc_plug_across");
            await Engine.sleep(15);
            this.g_music_06a_04 = true;
            if (this.debug)
            {
                Engine.print("plug down...");
            }

            Engine.object_dynamic_simulation_disable(plug.Entity, false);
            await Engine.sleep(1);
            Engine.device_set_position_track(plug.Entity, "plug_down", 0F);
            Engine.device_animate_position(plug.Entity, 1F, 2F, 0.05F, 0.25F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(plug_door_a.Entity) >= 1F && Engine.volume_test_objects_all(tv_plug_down, Engine.players()));
            Engine.object_destroy(plug_keylock_c.Entity);
            Engine.object_destroy(plug_keylock_d.Entity);
            Engine.wake(new ScriptMethodReference(chapter_remorse));
            Engine.wake(new ScriptMethodReference(objective_lower_specific_clear));
            await Engine.sleep(30);
            Engine.device_set_power(plug_switch.Entity, 0F);
            Engine.device_set_position(plug_switch_housing.Entity, 0F);
            Engine.object_destroy(plug_switch.Entity);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_plug_down, Engine.ai_actors(covenant1)), 30, 30 * 10);
            if (this.debug)
            {
                Engine.print("initializing tartersauce...");
            }

            Engine.ai_place(gap_phantom.Squad);
            Engine.game_save();
            if (this.debug)
            {
                Engine.print("plug across...");
            }

            Engine.device_set_position_track(plug.Entity, "plug_across", 0F);
            Engine.device_animate_position(plug.Entity, 1F, 60F, 5F, 5F, false);
            await Engine.sleep(5);
            await Engine.sleep_until(async () => Engine.device_get_position(plug.Entity) >= 0.035F, 1);
            if (this.debug)
            {
                Engine.print("g_lower_shield set to 1");
            }

            await Engine.sleep_until(async () => Engine.device_get_position(plug.Entity) >= 0.15F, 5);
            this.g_lower_shield = true;
            await Engine.sleep_until(async () => Engine.device_get_position(plug.Entity) >= 0.5F, 5);
            Engine.game_save_no_timeout();
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            await Engine.sleep_until(async () => Engine.device_get_position(plug.Entity) >= 1F);
            await Engine.sleep(30);
            if (this.debug)
            {
                Engine.print("plug up...");
            }

            Engine.device_set_position_track(plug.Entity, "plug_up", 0F);
            Engine.device_animate_position(plug.Entity, 1F, 3F, 0.1F, 1F, false);
            Engine.ai_set_orders(plug_holder_enforcer.Squad, plugholder_enforcer);
            await Engine.sleep_until(async () => Engine.device_get_position(plug.Entity) >= 1F, 10);
            await Engine.sleep(1);
            Engine.object_dynamic_simulation_disable(plug.Entity, true);
            this.g_music_06a_05 = true;
            Engine.device_set_position(plug_lock_a.Entity, 1F);
            Engine.device_set_position(plug_lock_b.Entity, 1F);
            Engine.device_set_position(plug_lock_c.Entity, 1F);
            Engine.device_set_position(plug_lock_d.Entity, 1F);
            Engine.device_set_position(plug_lock_e.Entity, 1F);
            Engine.device_set_position(plug_lock_f.Entity, 1F);
        }

        [ScriptMethod(272, Lifecycle.CommandScript)]
        public async Task cs_gap_flood_jump()
        {
            Engine.cs_enable_moving(true);
            await Engine.sleep((short)Engine.random_range(20, 50));
            Engine.cs_jump(30F, 5F);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep((short)(30 * 3));
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(273, Lifecycle.Static)]
        public async Task gap_flood_jump()
        {
            Engine.cs_run_command_script(this.ai_current_squad, new ScriptMethodReference(cs_gap_flood_jump));
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task invulnerable()
        {
            Engine.cs_enable_moving(true);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_certain);
            await Engine.sleep((short)(30 * 1));
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(275, Lifecycle.Static)]
        public async Task make_invulnerable()
        {
            Engine.cs_run_command_script(this.ai_current_squad, new ScriptMethodReference(invulnerable));
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task close_plugholder_door()
        {
            await Engine.sleep(150);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_plugholder_a, Engine.players())) && !(Engine.volume_test_objects(tv_plugholder_b, Engine.players())));
            Engine.device_set_position(plugholder_door.Entity, 0F);
        }

        [ScriptMethod(277, Lifecycle.Static)]
        public async Task ai_plug_holder_em_a()
        {
            if (this.debug)
            {
                Engine.print("a");
            }

            Engine.ai_place(plug_holder_sen.a);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(278, Lifecycle.Static)]
        public async Task ai_plug_holder_em_b()
        {
            if (this.debug)
            {
                Engine.print("b");
            }

            Engine.ai_place(plug_holder_sen.b);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(279, Lifecycle.Static)]
        public async Task ai_plug_holder_em_d()
        {
            if (this.debug)
            {
                Engine.print("d");
            }

            Engine.ai_place(plug_holder_sen.d);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(280, Lifecycle.Static)]
        public async Task ai_plug_holder_em_f()
        {
            if (this.debug)
            {
                Engine.print("f");
            }

            Engine.ai_place(plug_holder_sen.f);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(281, Lifecycle.Static)]
        public async Task ai_plug_holder_em_h()
        {
            if (this.debug)
            {
                Engine.print("h");
            }

            Engine.ai_place(plug_holder_sen.h);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(282, Lifecycle.Static)]
        public async Task ai_plug_holder_em_i()
        {
            if (this.debug)
            {
                Engine.print("i");
            }

            Engine.ai_place(plug_holder_sen.i);
            this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_sentinels) <= this.g_plug_holder_limit);
                if (this.g_plugholder_progress)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep(this.g_emitter_delay);
                this.g_plug_holder_count = 0;
                this.g_plug_holder_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(plug_holder_em_a.Entity)) && Engine.object_get_health(plug_holder_em_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_em_a.Entity) > 6F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_a();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_em_b.Entity)) && Engine.object_get_health(plug_holder_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_em_b.Entity) > 6F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_b();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_em_d.Entity)) && Engine.object_get_health(plug_holder_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_em_d.Entity) > 6F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_d();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_em_f.Entity)) && Engine.object_get_health(plug_holder_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_em_f.Entity) > 6F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_f();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_em_h.Entity)) && Engine.object_get_health(plug_holder_em_h.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_em_h.Entity) > 6F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_h();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_em_i.Entity)) && Engine.object_get_health(plug_holder_em_i.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_em_i.Entity) > 6F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_em_i();
                    }
                    else if (true)
                    {
                        Engine.ai_place(plug_holder_sen.Squad);
                        this.g_plug_holder_count = (short)(this.g_plug_holder_count + 1);
                        if (this.debug)
                        {
                            Engine.print("placing random sentinel (or none at all)...");
                        }
                    }

                    if (this.g_plug_holder_count == this.g_plug_holder_index)
                    {
                        this.g_plug_holder_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_enforcer.Squad) <= 0);
            if (this.debug)
            {
                Engine.print("plug holder enforcer dead. initializing eliminators...");
            }

            await Engine.sleep(this.g_emitter_delay);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_sen_elim.Squad) <= 0);
                if (this.g_plugholder_progress)
                {
                    Engine.sleep_forever();
                }

                if (this.debug)
                {
                    Engine.print("eliminator!");
                }

                Engine.ai_place(plug_holder_sen_elim.Squad);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                return this.g_plugholder_progress;
            });
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task ai_plug_holder_flood()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_flood) <= 1);
                if (this.g_plugholder_progress)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (Engine.volume_test_objects(tv_plugholder_a, Engine.players()))
                {
                    if (this.debug)
                    {
                        Engine.print("placing flood a...");
                    }

                    Engine.ai_place(plug_holder_flood_c.Squad);
                    Engine.ai_place(plug_holder_flood_d.Squad);
                }
                else if (Engine.volume_test_objects(tv_plugholder_b, Engine.players()))
                {
                    if (this.debug)
                    {
                        Engine.print("placing flood b...");
                    }

                    Engine.ai_place(plug_holder_flood_a.Squad);
                    Engine.ai_place(plug_holder_flood_b.Squad);
                }

                return this.g_plugholder_progress;
            });
        }

        [ScriptMethod(286, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_a()
        {
            if (this.debug)
            {
                Engine.print("a back");
            }

            Engine.ai_place(plug_holder_bk_sen.a);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(287, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_b()
        {
            if (this.debug)
            {
                Engine.print("b back");
            }

            Engine.ai_place(plug_holder_bk_sen.b);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(288, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_c()
        {
            if (this.debug)
            {
                Engine.print("c back");
            }

            Engine.ai_place(plug_holder_bk_sen.c);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(289, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_d()
        {
            if (this.debug)
            {
                Engine.print("d back");
            }

            Engine.ai_place(plug_holder_bk_sen.d);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(290, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_e()
        {
            if (this.debug)
            {
                Engine.print("e back");
            }

            Engine.ai_place(plug_holder_bk_sen.e);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(291, Lifecycle.Static)]
        public async Task ai_plug_holder_bk_em_f()
        {
            if (this.debug)
            {
                Engine.print("f back");
            }

            Engine.ai_place(plug_holder_bk_sen.f);
            this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task ai_plug_holder_bk_em()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_sentinels) <= 2);
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_sentinels_bk) <= this.g_plug_holder_bk_limit);
                if (this.g_plug_holder_bk_loops)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep(this.g_emitter_delay);
                this.g_plug_holder_bk_count = 0;
                this.g_plug_holder_bk_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(plug_holder_bk_em_a.Entity)) && Engine.object_get_health(plug_holder_bk_em_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_a.Entity) > 8F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_a();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_bk_em_b.Entity)) && Engine.object_get_health(plug_holder_bk_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_b.Entity) > 8F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_b();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_bk_em_c.Entity)) && Engine.object_get_health(plug_holder_bk_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_c.Entity) > 8F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_c();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_bk_em_d.Entity)) && Engine.object_get_health(plug_holder_bk_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_d.Entity) > 8F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_d();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_bk_em_e.Entity)) && Engine.object_get_health(plug_holder_bk_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_e.Entity) > 8F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_e();
                    }
                    else if (!(Engine.unit_is_emitting(plug_holder_bk_em_f.Entity)) && Engine.object_get_health(plug_holder_bk_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), plug_holder_bk_em_f.Entity) > 8F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_plug_holder_bk_em_f();
                    }
                    else if (true)
                    {
                        Engine.ai_place(plug_holder_bk_sen.Squad);
                        this.g_plug_holder_bk_count = (short)(this.g_plug_holder_bk_count + 1);
                    }

                    if (this.g_plug_holder_bk_count == this.g_plug_holder_bk_index)
                    {
                        this.g_plug_holder_bk_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_flood_bk) <= 2);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                Engine.ai_place(plugholder_bk_flood_a.Squad);
                Engine.ai_place(plugholder_bk_infec_a.Squad);
                this.g_plugholder_bk_flood_count = (short)(this.g_plugholder_bk_flood_count + 1);
                if (this.g_plugholder_bk_flood_count == this.g_plugholder_bk_flood_limit)
                {
                    this.g_plugholder_bk_a = true;
                }

                return this.g_plugholder_bk_a;
            });
            this.g_plugholder_bk_flood_count = 0;
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(plug_holder_flood_bk) <= 2);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                Engine.ai_place(plugholder_bk_flood_b.Squad);
                Engine.ai_place(plugholder_bk_infec_b.Squad);
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
            await Engine.sleep_until(async () => this.g_plugholder_bk_flood_count >= 2);
            if (this.debug)
            {
                Engine.print("infection forms...");
            }

            Engine.ai_place(plugholder_bk_infec_a.Squad);
            await Engine.sleep_until(async () => this.g_plugholder_bk_flood_count >= 4);
            if (this.debug)
            {
                Engine.print("infection forms...");
            }

            Engine.ai_place(plugholder_bk_infec_a.Squad);
            await Engine.sleep_until(async () => this.g_plugholder_bk_flood_count >= 6);
            if (this.debug)
            {
                Engine.print("infection forms...");
            }

            Engine.ai_place(plugholder_bk_infec_a.Squad);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task ai_plugholder_infec_bk_b()
        {
            await Engine.sleep_until(async () => this.g_plugholder_bk_flood_count >= 2);
            if (this.debug)
            {
                Engine.print("infection forms...");
            }

            Engine.ai_place(plugholder_bk_infec_b.Squad);
            await Engine.sleep_until(async () => this.g_plugholder_bk_flood_count >= 4);
            if (this.debug)
            {
                Engine.print("infection forms...");
            }

            Engine.ai_place(plugholder_bk_infec_b.Squad);
            await Engine.sleep_until(async () => this.g_plugholder_bk_flood_count >= 6);
            if (this.debug)
            {
                Engine.print("infection forms...");
            }

            Engine.ai_place(plugholder_bk_infec_b.Squad);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task kill_hall_c_marines()
        {
            Engine.begin_random(async () => Engine.ai_kill(hall_c_marines.a), 
                async () => await Engine.sleep(5), 
                async () => Engine.ai_kill(hall_c_marines.b), 
                async () => await Engine.sleep(5), 
                async () => Engine.ai_kill(hall_c_marines.c), 
                async () => await Engine.sleep(5), 
                async () => Engine.ai_kill(hall_c_marines.d), 
                async () => await Engine.sleep(5));
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task ai_hall_c_ini()
        {
            Engine.ai_place(hall_c_marines.Squad);
            Engine.ai_place(hall_c_flood_far.Squad);
            Engine.wake(new ScriptMethodReference(sc_marines_b));
            Engine.ai_place(hall_c_infec.Squad);
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task ai_hall_c_flood_d()
        {
            if ((short)Engine.ai_living_count(hall_c_flood) < 3)
            {
                Engine.ai_place(hall_c_flood_d.Squad);
                this.g_hall_c_flood_count = (short)(this.g_hall_c_flood_count + 1);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
            }
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task ai_hall_c_flood_e()
        {
            if ((short)Engine.ai_living_count(hall_c_flood) < 3)
            {
                Engine.ai_place(hall_c_flood_e.Squad);
                this.g_hall_c_flood_count = (short)(this.g_hall_c_flood_count + 1);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
            }
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task ai_hall_c_flood_f()
        {
            if ((short)Engine.ai_living_count(hall_c_flood) < 3)
            {
                Engine.ai_place(hall_c_flood_f.Squad);
                this.g_hall_c_flood_count = (short)(this.g_hall_c_flood_count + 1);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
            }
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task ai_hall_c_flood_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_hall_c_d, Engine.players()))
                {
                    await this.ai_hall_c_flood_e();
                }
                else if (Engine.volume_test_objects(tv_hall_c_e, Engine.players()))
                {
                    await this.ai_hall_c_flood_f();
                }

                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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
            Engine.ai_place(ledge_a_enforcer.Squad);
            Engine.ai_place(ledge_a_sen_ini.Squad);
            Engine.ai_place(ledge_a_flood_ini.Squad);
        }

        [ScriptMethod(303, Lifecycle.Dormant)]
        public async Task ai_ledge_a_location()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_ledge_a, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 1;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_top_b, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 2;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_top_c, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 3;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_top_d1, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 4;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_top_d2, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 5;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_top_e, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 6;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_top_f, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 7;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_top_g, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 8;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_bot_a, Engine.players()))
                {
                    this.g_ledge_a_player_loc = 9;
                }
                else if (Engine.volume_test_objects(tv_ledge_a_bot_b, Engine.players()))
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
                Engine.print("flood b");
            }

            Engine.ai_place(ledge_a_flood_b.Squad);
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task ai_ledge_a_flood_c()
        {
            if (this.debug)
            {
                Engine.print("flood c");
            }

            Engine.ai_place(ledge_a_flood_c.Squad);
        }

        [ScriptMethod(306, Lifecycle.Static)]
        public async Task ai_ledge_a_flood_e()
        {
            if (this.debug)
            {
                Engine.print("flood e");
            }

            Engine.ai_place(ledge_a_flood_e.Squad);
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task ai_ledge_a_flood_f()
        {
            if (this.debug)
            {
                Engine.print("flood f");
            }

            Engine.ai_place(ledge_a_flood_f.Squad);
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task ai_ledge_a_flood_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(ledge_a_flood) <= 2);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

                return (short)Engine.ai_spawn_count(ledge_a_flood) >= 16 || this.g_ledge_a_spawn;
            });
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(ledge_a_flood) <= 2);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.g_ledge_a_player_loc == 6)
                {
                    await this.ai_ledge_a_flood_e();
                }
                else if (this.g_ledge_a_player_loc == 7)
                {
                    await this.ai_ledge_a_flood_f();
                }

                return (short)Engine.ai_spawn_count(ledge_a_flood) >= 32 || this.g_ledge_a_spawn;
            });
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task ai_ledge_a_flood_bot_a()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_a_bot_a, Engine.players()));
            Engine.ai_place(ledge_a_flood_bot_a.Squad);
        }

        [ScriptMethod(310, Lifecycle.Dormant)]
        public async Task ai_ledge_a_flood_bot_b()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_a_bot_b, Engine.players()));
            Engine.ai_place(ledge_a_flood_bot_b.Squad);
        }

        [ScriptMethod(311, Lifecycle.Static)]
        public async Task ai_ledge_a_em_a()
        {
            if (this.debug)
            {
                Engine.print("a");
            }

            Engine.ai_place(ledge_a_sen.a);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task ai_ledge_a_em_b()
        {
            if (this.debug)
            {
                Engine.print("b");
            }

            Engine.ai_place(ledge_a_sen.b);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(313, Lifecycle.Static)]
        public async Task ai_ledge_a_em_c()
        {
            if (this.debug)
            {
                Engine.print("c");
            }

            Engine.ai_place(ledge_a_sen.c);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task ai_ledge_a_em_d()
        {
            if (this.debug)
            {
                Engine.print("d");
            }

            Engine.ai_place(ledge_a_sen.d);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(315, Lifecycle.Static)]
        public async Task ai_ledge_a_em_e()
        {
            if (this.debug)
            {
                Engine.print("e");
            }

            Engine.ai_place(ledge_a_sen.e);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task ai_ledge_a_em_f()
        {
            if (this.debug)
            {
                Engine.print("f");
            }

            Engine.ai_place(ledge_a_sen.f);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task ai_ledge_a_em_g()
        {
            if (this.debug)
            {
                Engine.print("g");
            }

            Engine.ai_place(ledge_a_sen.g);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task ai_ledge_a_em_h()
        {
            if (this.debug)
            {
                Engine.print("h");
            }

            Engine.ai_place(ledge_a_sen.h);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task ai_ledge_a_em_i()
        {
            if (this.debug)
            {
                Engine.print("i");
            }

            Engine.ai_place(ledge_a_sen.i);
            this.g_ledge_a_count = (short)(this.g_ledge_a_count + 1);
            await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(ledge_a_sentinels) <= this.g_ledge_a_sen_limit);
                await Engine.sleep(this.g_emitter_delay);
                this.g_ledge_a_count = 0;
                this.g_ledge_a_wave = false;
                await Engine.sleep_until(async () =>
                {
                    if (!(Engine.unit_is_emitting(ledge_a_em_a.Entity)) && Engine.object_get_health(ledge_a_em_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_a.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_a.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_a();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_b.Entity)) && Engine.object_get_health(ledge_a_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_b.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_b.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_b();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_c.Entity)) && Engine.object_get_health(ledge_a_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_c.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_c.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_c();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_d.Entity)) && Engine.object_get_health(ledge_a_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_d.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_d.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_d();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_e.Entity)) && Engine.object_get_health(ledge_a_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_e.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_e.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_e();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_f.Entity)) && Engine.object_get_health(ledge_a_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_f.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_f.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_f();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_g.Entity)) && Engine.object_get_health(ledge_a_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_g.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_g.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_g();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_h.Entity)) && Engine.object_get_health(ledge_a_em_h.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_h.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_h.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_h();
                    }
                    else if (!(Engine.unit_is_emitting(ledge_a_em_i.Entity)) && Engine.object_get_health(ledge_a_em_i.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_i.Entity) > 0F && Engine.objects_distance_to_object(Engine.players(), ledge_a_em_i.Entity) < 9F && (short)Engine.random_range(0, 10) <= 3)
                    {
                        await this.ai_ledge_a_em_i();
                    }

                    if (this.g_ledge_a_count == this.g_ledge_a_index)
                    {
                        this.g_ledge_a_wave = true;
                    }

                    await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                    return this.g_ledge_a_wave;
                });
                return this.g_ledge_a_loops;
            });
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task kill_cond_b_marines()
        {
            Engine.begin_random(async () => Engine.ai_kill(cond_b_humans.a), 
                async () => await Engine.sleep(5), 
                async () => Engine.ai_kill(cond_b_humans.b), 
                async () => await Engine.sleep(5), 
                async () => Engine.ai_kill(cond_b_humans.c), 
                async () => await Engine.sleep(5));
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task conduit_b_locator()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_cond_b_a1, Engine.players()))
                {
                    this.cond_b_locator = 1;
                }
                else if (Engine.volume_test_objects(tv_cond_b_a2, Engine.players()))
                {
                    this.cond_b_locator = 2;
                }
                else if (Engine.volume_test_objects(tv_cond_b_b1, Engine.players()))
                {
                    this.cond_b_locator = 3;
                }
                else if (Engine.volume_test_objects(tv_cond_b_b2, Engine.players()))
                {
                    this.cond_b_locator = 4;
                }
                else if (Engine.volume_test_objects(tv_cond_b_c, Engine.players()))
                {
                    this.cond_b_locator = 5;
                }

                return false;
            });
        }

        [ScriptMethod(323, Lifecycle.Dormant)]
        public async Task ai_cond_b_carrier_a()
        {
            await Engine.sleep_until(async () => this.cond_b_flood_count == 2 || Engine.volume_test_objects(tv_cond_b_a2, Engine.players()));
            Engine.ai_place(cond_b_carrier_a.Squad);
            await Engine.sleep_until(async () => this.cond_b_flood_count == 4);
            if (this.cond_b_locator > 1)
            {
                Engine.sleep_forever();
            }

            Engine.ai_place(cond_b_carrier_a.Squad);
            await Engine.sleep_until(async () => this.cond_b_flood_count == 6);
            if (this.cond_b_locator > 1)
            {
                Engine.sleep_forever();
            }

            Engine.ai_place(cond_b_carrier_a.Squad);
        }

        [ScriptMethod(324, Lifecycle.CommandScript)]
        public async Task cs_cond_b_damage_enf()
        {
            await Engine.sleep(5);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "l_arm", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "l_rocket", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "l_thruster", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "l_shield_gen", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "r_arm", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "r_rocket", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "r_thruster", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "r_shield_gen", 1F);
            await Engine.sleep(1);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "r_shield_gen", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "r_arm", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "r_rocket", 1F);
            Engine.object_damage_damage_section(Engine.ai_get_object(cond_b_enforcer.a), "l_thruster", 1F);
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task ai_cond_b_b_em()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(cond_b_sen_b.Squad) <= 0);
            await Engine.sleep(this.g_emitter_delay);
            if ((short)Engine.random_range(0, 2) == 0)
            {
                Engine.ai_place(cond_b_sen_b.a);
            }
            else
            {
                Engine.ai_place(cond_b_sen_b.b);
            }
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task ai_cond_b_flood_spawn()
        {
            Engine.ai_place(cond_b_flood_a_ini_a.Squad);
            Engine.ai_place(cond_b_flood_a_ini_b.Squad);
            Engine.ai_place(cond_b_flood_a_ini_c.Squad);
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cond_b_flood) <= 1);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.cond_b_locator == 1)
                {
                    Engine.ai_place(cond_b_flood_a.Squad);
                    this.cond_b_flood_count = (short)(this.cond_b_flood_count + 1);
                    if (this.cond_b_flood_count == this.cond_b_flood_limit)
                    {
                        this.cond_b_flood_a_spawn = true;
                    }

                    await Engine.sleep(30);
                    Engine.ai_magically_see_object(cond_b_flood, await this.player0());
                    Engine.ai_magically_see_object(cond_b_flood, await this.player1());
                }

                return this.cond_b_flood_a_spawn;
            });
            this.cond_b_flood_count = 0;
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cond_b_flood) <= 1);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.cond_b_locator == 3)
                {
                    Engine.ai_place(cond_b_flood_b.Squad);
                    this.cond_b_flood_count = (short)(this.cond_b_flood_count + 1);
                    if (this.cond_b_flood_count == this.cond_b_flood_limit)
                    {
                        this.cond_b_flood_b_spawn = true;
                    }

                    await Engine.sleep(30);
                    Engine.ai_magically_see_object(cond_b_flood, await this.player0());
                    Engine.ai_magically_see_object(cond_b_flood, await this.player1());
                }

                return this.cond_b_flood_b_spawn;
            });
            this.cond_b_flood_count = 0;
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cond_b_flood) <= 1);
                await Engine.sleep((short)Engine.random_range(this.g_sleep_lower_bound, this.g_sleep_upper_bound));
                if (this.cond_b_locator == 3)
                {
                    Engine.ai_place(cond_b_flood_c.Squad);
                    this.cond_b_flood_count = (short)(this.cond_b_flood_count + 1);
                    if (this.cond_b_flood_count == this.cond_b_flood_limit)
                    {
                        this.cond_b_flood_c_spawn = true;
                    }

                    await Engine.sleep(30);
                    Engine.ai_magically_see_object(cond_b_flood, await this.player0());
                    Engine.ai_magically_see_object(cond_b_flood, await this.player1());
                }

                return this.cond_b_flood_c_spawn;
            });
        }

        [ScriptMethod(327, Lifecycle.CommandScript)]
        public async Task cs_cond_b_sen_tube_a()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("cond_b/p0"), Engine.GetReference<ISpatialPoint>("cond_b/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("cond_b/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("cond_b/p2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("cond_b/p3"));
        }

        [ScriptMethod(328, Lifecycle.CommandScript)]
        public async Task cs_cond_b_sen_tube_b()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("cond_b/p1"), Engine.GetReference<ISpatialPoint>("cond_b/p2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("cond_b/p2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("cond_b/p3"));
        }

        [ScriptMethod(329, Lifecycle.Dormant)]
        public async Task ai_cond_b_sen_tube_b()
        {
            if ((short)Engine.random_range(0, 2) == 0)
            {
                Engine.ai_place(cond_b_sen_tube_b.a);
            }
            else
            {
                Engine.ai_place(cond_b_sen_tube_b.b);
            }

            if ((short)Engine.random_range(0, 2) == 0)
            {
                Engine.ai_place(cond_b_sen_tube_b.c);
            }
            else
            {
                Engine.ai_place(cond_b_sen_tube_b.d);
            }

            await Engine.sleep(5);
            Engine.cs_run_command_script(cond_b_sen_tube_b.a, new ScriptMethodReference(cs_cond_b_sen_tube_a));
            Engine.cs_run_command_script(cond_b_sen_tube_b.b, new ScriptMethodReference(cs_cond_b_sen_tube_a));
            Engine.cs_run_command_script(cond_b_sen_tube_b.c, new ScriptMethodReference(cs_cond_b_sen_tube_b));
            Engine.cs_run_command_script(cond_b_sen_tube_b.d, new ScriptMethodReference(cs_cond_b_sen_tube_b));
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task slide_a_player0()
        {
            await Engine.sleep_until(async () => Engine.volume_test_object(tv_slide_a, await this.player0()));
            Engine.object_cannot_take_damage(await this.player0());
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_slide_a, await this.player0())));
            Engine.object_can_take_damage(await this.player0());
        }

        [ScriptMethod(331, Lifecycle.Dormant)]
        public async Task slide_a_player1()
        {
            await Engine.sleep_until(async () => Engine.volume_test_object(tv_slide_a, await this.player1()));
            Engine.object_cannot_take_damage(await this.player1());
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_slide_a, await this.player1())));
            Engine.object_can_take_damage(await this.player1());
        }

        [ScriptMethod(332, Lifecycle.Dormant)]
        public async Task slide_b_player0()
        {
            await Engine.sleep_until(async () => Engine.volume_test_object(tv_slide_b, await this.player0()));
            Engine.object_cannot_take_damage(await this.player0());
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_slide_b, await this.player0())));
            Engine.object_can_take_damage(await this.player0());
        }

        [ScriptMethod(333, Lifecycle.Dormant)]
        public async Task slide_b_player1()
        {
            await Engine.sleep_until(async () => Engine.volume_test_object(tv_slide_b, await this.player1()));
            Engine.object_cannot_take_damage(await this.player1());
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_slide_b, await this.player1())));
            Engine.object_can_take_damage(await this.player1());
        }

        [ScriptMethod(334, Lifecycle.Dormant)]
        public async Task ai_ledge_c_flood_ini()
        {
            Engine.ai_place(ledge_c_flood_fr.Squad);
            Engine.ai_place(ledge_c_flood_dead.Squad);
            Engine.ai_kill_silent(ledge_c_flood_dead.Squad);
            await Engine.sleep(1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ledge_c_flood) <= 0);
            if (this.ledge_c_spawn && Engine.volume_test_objects_all(tv_ledge_c_fr, Engine.players()))
            {
                Engine.ai_place(ledge_c_flood_bk.Squad);
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

            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_ledge_c_fr, Engine.players()));
            await Engine.sleep((short)Engine.random_range(120, 180));
            await Engine.sleep_until(async () =>
            {
                Engine.ai_place(ledge_c_infec_fr.Squad);
                this.ledge_c_infec_count = (short)(this.ledge_c_infec_count + 1);
                await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(ledge_c_infec_fr.Squad) <= 5);
                return this.ledge_c_infec_count == this.ledge_c_infec_limit;
            });
        }

        [ScriptMethod(336, Lifecycle.CommandScript)]
        public async Task cs_ledge_c_phantom()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p1"));
            await Engine.sleep_until(async () => this.g_ledge_c_phantom_start);
            Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p1"));
            Engine.cs_turn_sharpness(true, 0.7F);
            await Engine.sleep_until(async () => this.g_ledge_c_phantom_1, 5, 150);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p3"));
            await Engine.sleep(60);
            Engine.cs_look(false, Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p2"), 4F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p3"), 4F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p4"), 6F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p5"), 6F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("ledge_c_phantom/p6"), 10F);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(337, Lifecycle.Dormant)]
        public async Task cs_mortar_a()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_a), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_b), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_c), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_d), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_e), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_f), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)));
                return this.g_mortar_fire;
            });
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task cs_mortar_b()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_a), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_b), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_c), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_d), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_e), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)), 
                    async () => Engine.effect_new(Engine.GetTag<EffectTag>("effects\\design\\mortar_emitter\\mortar_emitter", 2223907391U), mortar_f), 
                    async () => await Engine.sleep((short)Engine.random_range(15, 45)));
                return this.g_mortar_fire;
            });
        }

        [ScriptMethod(339, Lifecycle.CommandScript)]
        public async Task cs_go_to_bridge()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("qz_ini/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("qz_ini/p1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("qz_ini/bridge"));
        }

        [ScriptMethod(340, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_a()
        {
            Engine.ai_place(qz_ini_ins_pods.a);
            Engine.object_create(qz_ent_pod_a);
            Engine.objects_attach(qz_ent_pod_a.Entity, "pod_attach", Engine.ai_vehicle_get(qz_ini_ins_pods.a), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(qz_ent_pod_a.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(qz_ent_pod_a.Entity) >= 1F, 1);
            Engine.objects_detach(qz_ent_pod_a.Entity, Engine.ai_vehicle_get(qz_ini_ins_pods.a));
            Engine.object_destroy(qz_ent_pod_a.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(qz_ini_ins_pods.a), "door", 500F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(qz_ini_ins_pods.a);
        }

        [ScriptMethod(341, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_b()
        {
            Engine.ai_place(qz_ini_ins_pods.b);
            Engine.object_create(qz_ent_pod_b);
            Engine.objects_attach(qz_ent_pod_b.Entity, "pod_attach", Engine.ai_vehicle_get(qz_ini_ins_pods.b), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(qz_ent_pod_b.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(qz_ent_pod_b.Entity) >= 1F, 1);
            Engine.objects_detach(qz_ent_pod_b.Entity, Engine.ai_vehicle_get(qz_ini_ins_pods.b));
            Engine.object_destroy(qz_ent_pod_b.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(qz_ini_ins_pods.b), "door", 500F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(qz_ini_ins_pods.b);
        }

        [ScriptMethod(342, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_c()
        {
            Engine.ai_place(qz_ini_ins_pods.c);
            Engine.object_create(qz_ent_pod_c);
            Engine.objects_attach(qz_ent_pod_c.Entity, "pod_attach", Engine.ai_vehicle_get(qz_ini_ins_pods.c), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(qz_ent_pod_c.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(qz_ent_pod_c.Entity) >= 1F, 1);
            Engine.objects_detach(qz_ent_pod_c.Entity, Engine.ai_vehicle_get(qz_ini_ins_pods.c));
            Engine.object_destroy(qz_ent_pod_c.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(qz_ini_ins_pods.c), "door", 500F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(qz_ini_ins_pods.c);
            await Engine.sleep(30);
            Engine.cs_run_command_script(qz_ini_ins_pods.c, new ScriptMethodReference(cs_go_to_bridge));
        }

        [ScriptMethod(343, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_d()
        {
            Engine.ai_place(qz_ini_ins_pods.d);
            Engine.object_create(qz_ent_pod_d);
            Engine.objects_attach(qz_ent_pod_d.Entity, "pod_attach", Engine.ai_vehicle_get(qz_ini_ins_pods.d), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(qz_ent_pod_d.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(qz_ent_pod_d.Entity) >= 1F, 1);
            Engine.objects_detach(qz_ent_pod_d.Entity, Engine.ai_vehicle_get(qz_ini_ins_pods.d));
            Engine.object_destroy(qz_ent_pod_d.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(qz_ini_ins_pods.d), "door", 500F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(qz_ini_ins_pods.d);
            await Engine.sleep(30);
            Engine.cs_run_command_script(qz_ini_ins_pods.d, new ScriptMethodReference(cs_go_to_bridge));
            Engine.unit_set_maximum_vitality(Engine.ai_get_unit(qz_ini_ins_pods.d), 1F, 0F);
        }

        [ScriptMethod(344, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pod_e()
        {
            Engine.ai_place(qz_ini_ins_pods.e);
            Engine.object_create(qz_ent_pod_e);
            Engine.objects_attach(qz_ent_pod_e.Entity, "pod_attach", Engine.ai_vehicle_get(qz_ini_ins_pods.e), "pod_attach");
            await Engine.sleep(1);
            Engine.device_set_position(qz_ent_pod_e.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(qz_ent_pod_e.Entity) >= 1F, 1);
            Engine.objects_detach(qz_ent_pod_e.Entity, Engine.ai_vehicle_get(qz_ini_ins_pods.e));
            Engine.object_destroy(qz_ent_pod_e.Entity);
            await Engine.sleep((short)Engine.random_range(20, 45));
            Engine.object_damage_damage_section(Engine.ai_vehicle_get(qz_ini_ins_pods.e), "door", 500F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(qz_ini_ins_pods.e);
            await Engine.sleep(30);
            Engine.cs_run_command_script(qz_ini_ins_pods.e, new ScriptMethodReference(cs_go_to_bridge));
            Engine.unit_set_maximum_vitality(Engine.ai_get_unit(qz_ini_ins_pods.e), 1F, 0F);
        }

        [ScriptMethod(345, Lifecycle.Dormant)]
        public async Task ai_qz_ini_turrets()
        {
            Engine.ai_vehicle_enter(qz_ini_flood, Engine.ai_get_unit(qz_ini_turrets.Squad));
        }

        [ScriptMethod(346, Lifecycle.Dormant)]
        public async Task ai_cov_ins_pods()
        {
            Engine.begin_random(async () => Engine.wake(new ScriptMethodReference(ai_cov_ins_pod_a)), 
                async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                async () => Engine.wake(new ScriptMethodReference(ai_cov_ins_pod_b)), 
                async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                async () => Engine.wake(new ScriptMethodReference(ai_cov_ins_pod_c)), 
                async () => await Engine.sleep((short)Engine.random_range(0, 15)), 
                async () => Engine.wake(new ScriptMethodReference(ai_cov_ins_pod_e)), 
                async () => await Engine.sleep((short)Engine.random_range(0, 15)));
            await Engine.sleep(120);
            Engine.wake(new ScriptMethodReference(sc_qz_initial));
        }

        [ScriptMethod(347, Lifecycle.Dormant)]
        public async Task ai_qz_ini_exit_turrets()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(qz_ini_flood) <= 1 || Engine.volume_test_objects(tv_cov_defense, Engine.players()));
            Engine.ai_vehicle_exit(qz_ini_ins_pods.Squad);
        }

        [ScriptMethod(348, Lifecycle.Dormant)]
        public async Task cs_crash_factory()
        {
            await Engine.sleep(90);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), factory.Entity, 30F) || Engine.volume_test_objects(tv_qz_camp, Engine.players()), 30, 180);
            await Engine.sleep(30);
            Engine.device_set_position(factory.Entity, 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\visual_effects\\shq_factory_explode\\factory_explode", 4287241557U), factory_sound.Entity, 1F);
            this.g_mortar_fire = true;
            await Engine.sleep_until(async () => Engine.device_get_position(factory.Entity) >= 0.025F, 10);
            Engine.wake(new ScriptMethodReference(ai_cov_ins_pods));
            await Engine.sleep_until(async () => Engine.device_get_position(factory.Entity) >= 0.1F);
            Engine.object_destroy(factory.Entity);
        }

        [ScriptMethod(349, Lifecycle.Dormant)]
        public async Task ai_qz_ini_flood()
        {
            Engine.ai_place(qz_initial_flood_camp.Squad);
            Engine.ai_play_line_on_object(qz_ini_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_ini_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(qz_initial_flood_camp.Squad) <= 2);
            if (!(this.g_qz_ini_cave))
            {
                Engine.ai_place(qz_initial_flood_camp.Squad);
                Engine.ai_play_line_on_object(qz_ini_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
                ;
                Engine.ai_play_line_on_object(qz_ini_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(350, Lifecycle.Static)]
        public async Task qz_cov_def_abc()
        {
            if (this.debug)
            {
                Engine.print("wave abc");
            }

            Engine.ai_place(qz_cov_def_flood_a.Squad);
            Engine.ai_place(qz_cov_def_flood_b.Squad);
            Engine.ai_place(qz_cov_def_flood_c.Squad);
            await Engine.sleep(5);
            Engine.ai_play_line_on_object(qz_cov_def_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_c.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_a);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            Engine.ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(351, Lifecycle.Static)]
        public async Task qz_cov_def_bcd()
        {
            if (this.debug)
            {
                Engine.print("wave bcd");
            }

            Engine.ai_place(qz_cov_def_flood_b.Squad);
            Engine.ai_place(qz_cov_def_flood_c.Squad);
            Engine.ai_place(qz_cov_def_flood_d.Squad);
            await Engine.sleep(5);
            Engine.ai_play_line_on_object(qz_cov_def_sound_b.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_c.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_d.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_ab);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            Engine.ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(352, Lifecycle.Static)]
        public async Task qz_cov_def_def()
        {
            if (this.debug)
            {
                Engine.print("wave def");
            }

            Engine.ai_place(qz_cov_def_flood_d.Squad);
            Engine.ai_place(qz_cov_def_flood_e.Squad);
            Engine.ai_place(qz_cov_def_flood_f.Squad);
            await Engine.sleep(5);
            Engine.ai_play_line_on_object(qz_cov_def_sound_d.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_e.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_f.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_bc);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            Engine.ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(353, Lifecycle.Static)]
        public async Task qz_cov_def_efg()
        {
            if (this.debug)
            {
                Engine.print("wave efg");
            }

            Engine.ai_place(qz_cov_def_flood_e.Squad);
            Engine.ai_place(qz_cov_def_flood_f.Squad);
            Engine.ai_place(qz_cov_def_flood_g.Squad);
            await Engine.sleep(5);
            Engine.ai_play_line_on_object(qz_cov_def_sound_e.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_f.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_g.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_c);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            Engine.ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(354, Lifecycle.Static)]
        public async Task qz_cov_def_ag()
        {
            if (this.debug)
            {
                Engine.print("wave ag");
            }

            Engine.ai_place(qz_cov_def_flood_a.Squad);
            Engine.ai_place(qz_cov_def_flood_g.Squad);
            await Engine.sleep(5);
            Engine.ai_play_line_on_object(qz_cov_def_sound_a.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_play_line_on_object(qz_cov_def_sound_g.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_ac);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            Engine.ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= 1);
        }

        [ScriptMethod(355, Lifecycle.Static)]
        public async Task qz_cov_def_d()
        {
            if (this.debug)
            {
                Engine.print("wave d");
            }

            Engine.ai_place(qz_cov_def_flood_d.Squad);
            await Engine.sleep(5);
            Engine.ai_play_line_on_object(qz_cov_def_sound_d.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.ai_set_orders(qz_cov_def_cov.Squad, qz_cov_def_cov_b);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= this.g_cov_def_flood_advance, 30, 30 * 15);
            Engine.ai_set_orders(qz_cov_def_flood, qz_cov_def_hill);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(qz_cov_def_flood) <= 1);
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

            Engine.begin_random(async () =>
            {
                if (this.g_qz_cov_def_spawn)
                {
                    this.g_qz_cov_def_count = (short)(this.g_qz_cov_def_count + 1);
                    await this.qz_cov_def_abc();
                    if (this.g_qz_cov_def_count == this.g_qz_cov_def_limit)
                    {
                        this.g_qz_cov_def_spawn = false;
                    }

                    await Engine.sleep((short)(30 * 10));
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

                    await Engine.sleep((short)(30 * 10));
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

                    await Engine.sleep((short)(30 * 10));
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

                    await Engine.sleep((short)(30 * 10));
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

                    await Engine.sleep((short)(30 * 10));
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

                    await Engine.sleep((short)(30 * 10));
                }
            });
        }

        [ScriptMethod(357, Lifecycle.Dormant)]
        public async Task ai_qz_cov_def_carrier()
        {
            await Engine.sleep_until(async () => this.g_qz_cov_def_count == 2);
            Engine.game_save_no_timeout();
            Engine.ai_place(qz_cov_def_carrier.Squad);
            await Engine.sleep_until(async () => this.g_qz_cov_def_count == 4);
            Engine.game_save_no_timeout();
            Engine.ai_place(qz_cov_def_carrier.Squad);
            await Engine.sleep_until(async () => this.g_qz_cov_def_count == 6);
            Engine.game_save_no_timeout();
            Engine.ai_place(qz_cov_def_carrier.Squad);
        }

        [ScriptMethod(358, Lifecycle.Dormant)]
        public async Task you_win()
        {
            if (this.debug)
            {
                Engine.print("you win script called...");
            }

            await Engine.sleep_until(async () => this.g_qz_phantom, 30, 30 * 60 * 2);
            await Engine.sleep(120);
            await this.playtest_mission();
            Engine.sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            Engine.game_won();
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_qz_phantom()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_phantom/p0"), 3F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_phantom/p1"), 3F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_phantom/p3"), 5F);
            Engine.ai_magically_see(covenant1, flood);
            Engine.cs_vehicle_speed(0.75F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("qz_phantom/p4"), Engine.GetReference<ISpatialPoint>("qz_phantom/p5"));
            Engine.ai_magically_see(covenant1, flood);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_game_won, Engine.ai_actors(qz_cov_def_flood))), 30, 30 * 30);
            this.g_qz_phantom = true;
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task enc_insertion()
        {
            if (this.debug)
            {
                Engine.print("initialize insertion scripts");
            }

            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_insertion");
            if (await this.difficulty_normal())
            {
                Engine.object_destroy(ins_em_b.Entity);
            }
            else if (await this.difficulty_heroic())
            {
                Engine.object_destroy(ins_em_b.Entity);
            }

            Engine.ai_disregard(Engine.ai_actors(constructors), true);
            Engine.ai_place(ins_con_mid.Squad);
            Engine.ai_place(ins_con_bk.Squad);
            Engine.ai_place(pussy_grunt1.Squad);
            Engine.wake(new ScriptMethodReference(ins_open_door));
            Engine.wake(new ScriptMethodReference(pussy_grunt_reminder));
            Engine.wake(new ScriptMethodReference(music_06a_01));
            await Engine.sleep(1);
            if (!(await this.difficulty_legendary()))
            {
                await Engine.sleep_until(async () => (float)Engine.ai_strength(ins_cons) < 1F || Engine.volume_test_objects(tv_insertion_tube, Engine.players()), 5);
            }
            else
            {
                await Engine.sleep(150);
                Engine.wake(new ScriptMethodReference(ai_insertion_emitters));
            }

            if ((float)Engine.ai_strength(ins_cons) < 1F)
            {
                Engine.wake(new ScriptMethodReference(ai_insertion_emitters));
                if (Engine.device_get_position(piston_ins.Entity) == 0F)
                {
                    Engine.ai_set_orders(ins_con_mid.Squad, ins_run_away);
                    Engine.ai_set_orders(ins_con_bk.Squad, ins_run_away);
                }
            }

            Engine.wake(new ScriptMethodReference(pussy_grunt));
        }

        [ScriptMethod(361, Lifecycle.Dormant)]
        public async Task enc_hall_a()
        {
            if (this.g_hall_a)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_a, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize hall a scripts");
            }

            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_hall_a");
            this.g_insertion_spawn = true;
            this.g_pussy_grunt = true;
            Engine.ai_disposable(insertion_sentinels, true);
            Engine.ai_disposable(ins_cons, true);
            Engine.ai_disposable(pussy_grunt1.Squad, true);
            Engine.ai_set_orders(constructors, hall_a_constructors);
            Engine.ai_set_orders(pussy_grunt1.Squad, hall_a_cov);
            Engine.wake(new ScriptMethodReference(ai_hall_a_const));
            if (!(await this.difficulty_legendary()))
            {
                await Engine.sleep_until(async () => (float)Engine.ai_strength(hall_a_cons) < 0.8F || Engine.volume_test_objects(tv_hall_a_bk, Engine.players()));
            }

            Engine.ai_place(hall_a_sen.h);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(ai_hall_a_emitters));
        }

        [ScriptMethod(362, Lifecycle.Dormant)]
        public async Task enc_conduit_a()
        {
            if (this.g_conduit_a)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_conduit_a, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize conduit a scripts");
            }

            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_cond_a_sec_a");
            Engine.ai_disposable(hall_a_sentinels, true);
            Engine.ai_disposable(hall_a_cons, true);
            Engine.ai_place(cond_a_sen_ini.Squad);
            Engine.ai_set_orders(covenant1, cond_a_cov_follow);
            await Engine.sleep(1);
            Engine.ai_place(cond_a_cov.Squad);
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(ai_sc_cond_a_cov));
            Engine.wake(new ScriptMethodReference(cond_a_initial_delay));
            Engine.wake(new ScriptMethodReference(music_06a_03));
            Engine.sleep_forever(new ScriptMethodReference(ai_hall_a_emitters));
            await Engine.sleep_until(async () => this.g_cond_a_continue);
            Engine.ai_renew(covenant1);
            Engine.wake(new ScriptMethodReference(ai_cond_a_emitters_fr));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cond_a_b, Engine.players()), 5);
            Engine.ai_renew(covenant1);
            Engine.wake(new ScriptMethodReference(sc_tartarus_reminder));
            Engine.wake(new ScriptMethodReference(ai_cond_a_back_ini));
            this.g_music_06a_03 = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cond_a_c, Engine.players()));
            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_cond_a_sec_b");
            Engine.ai_renew(covenant1);
            Engine.wake(new ScriptMethodReference(ai_cond_a_emitters_bk));
            Engine.sleep_forever(new ScriptMethodReference(ai_cond_a_emitters_fr));
        }

        [ScriptMethod(363, Lifecycle.Dormant)]
        public async Task enc_hall_b()
        {
            if (this.g_hall_b)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_b, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize hall b scripts");
            }

            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_hall_b");
            Engine.ai_disposable(cond_a_sentinels, true);
            Engine.ai_disposable(cond_a_cov.Squad, true);
            Engine.sleep_forever(new ScriptMethodReference(ai_cond_a_emitters_bk));
            this.g_cond_a_front = true;
            this.g_cond_a_back = true;
            Engine.ai_place(hall_b_cov.Squad, (short)Engine.pin(4F - (float)Engine.ai_living_count(covenant1), 0F, 4F));
            Engine.wake(new ScriptMethodReference(ai_sc_hall_b_grunts));
            Engine.ai_set_orders(covenant1, hall_b_cov_follow);
            await Engine.sleep(1);
            Engine.ai_set_orders(covenant1, hall_b_cov_ini);
            Engine.ai_renew(covenant1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_b_fr, Engine.players()));
            Engine.wake(new ScriptMethodReference(ai_hall_b_emitters));
            Engine.ai_set_orders(covenant1, hall_b_cov_follow);
            this.g_hall_b_sen_dialogue = true;
        }

        [ScriptMethod(364, Lifecycle.Dormant)]
        public async Task enc_plug_launch()
        {
            if (this.g_plug_launch)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_plug_launch, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize plug launch scripts");
            }

            Engine.wake(new ScriptMethodReference(plug_absorbers));
            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_plug_launch");
            Engine.ai_disposable(hall_b_cov.Squad, true);
            Engine.ai_disposable(hall_b_sentinels, true);
            Engine.object_dynamic_simulation_disable(plug.Entity, true);
            Engine.wake(new ScriptMethodReference(objective_lower_clear));
            Engine.wake(new ScriptMethodReference(objective_lower_specific_set));
            Engine.sleep_forever(new ScriptMethodReference(ai_hall_b_emitters));
            Engine.ai_renew(covenant1);
            Engine.ai_set_orders(covenant1, plug_launch_cov_ini);
            Engine.ai_place(plug_launch_enforcer.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(plug_launch_enforcer.Squad) >= this.ai_combat_status_active, 30, 210);
            Engine.wake(new ScriptMethodReference(sc_enforcer));
            Engine.wake(new ScriptMethodReference(ai_plug_launch_em));
            await Engine.sleep(1);
            Engine.ai_set_orders(covenant1, plug_launch_cov_follow);
            await Engine.sleep_until(async () => this.g_plug_move);
            this.g_plug_launch_loops = true;
            Engine.wake(new ScriptMethodReference(cs_move_plug));
            Engine.wake(new ScriptMethodReference(music_06a_04));
        }

        [ScriptMethod(365, Lifecycle.Dormant)]
        public async Task enc_plug_landing()
        {
            if (this.g_plug_landing)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_plug_land, Engine.players()));
            }

            await Engine.sleep_until(async () => Engine.device_get_position(plug.Entity) >= 0.75F, 10);
            if (this.debug)
            {
                Engine.print("initialize plug landing scripts");
            }

            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_plug_landing");
            Engine.ai_disposable(plug_launch_enforcer.Squad, true);
            Engine.ai_disposable(plug_launch_sentinels, true);
            Engine.wake(new ScriptMethodReference(music_06a_05));
            Engine.wake(new ScriptMethodReference(ai_plug_holder_flood));
            Engine.wake(new ScriptMethodReference(ai_plug_holder_em));
            Engine.wake(new ScriptMethodReference(ai_plug_holder_em_elim));
            await Engine.sleep_until(async () => this.g_plugholder_progress || (short)Engine.ai_living_count(plug_holder_enforcer.Squad) <= 0, 30, 30 * 60 * 5);
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_plug_landing_bk");
            await Engine.sleep((short)(30 * 5));
            this.g_music_06a_04 = false;
            this.g_music_06a_05 = false;
            if (this.debug)
            {
                Engine.print("opening the escape hatch...");
            }

            Engine.ai_place(plugholder_sen_bk_ini.Squad);
            await Engine.sleep(30);
            Engine.device_set_position(plugholder_door.Entity, 1F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_plugholder_d, Engine.players()));
            Engine.game_save_no_timeout();
            this.g_music_06a_05 = false;
            Engine.ai_disposable(plug_holder_flood, true);
            Engine.ai_disposable(plug_holder_sentinels, true);
            Engine.ai_set_orders(plug_holder_sentinels, plugholder_sen_bk);
            Engine.ai_set_orders(plug_holder_enforcer.Squad, plugholder_enforcer_bk);
            this.g_plugholder_progress = true;
            Engine.wake(new ScriptMethodReference(close_plugholder_door));
            Engine.wake(new ScriptMethodReference(ai_plugholder_flood_bk));
            Engine.wake(new ScriptMethodReference(ai_plug_holder_bk_em));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_plugholder_e, Engine.players()));
            this.g_plugholder_bk_a = true;
            Engine.game_save_no_timeout();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_plugholder_f, Engine.players()));
            this.g_plugholder_bk_b = true;
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_plug_landing_lower");
            Engine.ai_place(plugholder_lower_hall_flood.Squad);
            Engine.ai_place(plugholder_lower_hall_infec.Squad);
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task enc_hall_c()
        {
            if (this.g_hall_c)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize hall c scripts");
            }

            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_hall_c_sec_a");
            Engine.ai_disposable(plug_holder_flood_bk, true);
            Engine.ai_disposable(plugholder_bk_infec_a.Squad, true);
            Engine.ai_disposable(plugholder_bk_infec_b.Squad, true);
            Engine.sleep_forever(new ScriptMethodReference(ai_plugholder_infec_bk_a));
            Engine.sleep_forever(new ScriptMethodReference(ai_plugholder_infec_bk_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c_a, Engine.players()), 5);
            Engine.game_save_no_timeout();
            Engine.wake(new ScriptMethodReference(ai_hall_c_ini));
            await Engine.sleep(5);
            Engine.ai_magically_see(hall_c_marines.Squad, hall_c_flood_far.Squad);
            Engine.ai_magically_see(hall_c_flood_far.Squad, hall_c_marines.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c_b, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_hall_c_sec_b");
            Engine.wake(new ScriptMethodReference(kill_hall_c_marines));
            Engine.ai_place(hall_c_flood_mid.Squad);
            await Engine.sleep(1);
            Engine.ai_set_orders(hall_c_flood, hall_c_floor_b);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c_c, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.ai_place(hall_c_flood_c.Squad, (short)Engine.pin(8F - (float)Engine.ai_nonswarm_count(hall_c_flood), 0F, 6F));
            Engine.ai_place(hall_c_carrier_c.Squad);
            Engine.ai_place(hall_c_sen_tube.Squad);
            await Engine.sleep(1);
            Engine.ai_set_orders(hall_c_flood, hall_c_floor_c);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c_d, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_hall_c_sec_c");
            Engine.ai_place(hall_c_flood_d.Squad, (short)Engine.pin(8F - (float)Engine.ai_nonswarm_count(hall_c_flood), 0F, 6F));
            Engine.ai_place(hall_c_carrier_d.Squad);
            await Engine.sleep(1);
            Engine.ai_set_orders(hall_c_flood, hall_c_floor_d);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_hall_c_e, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.ai_place(hall_c_flood_e.Squad, (short)Engine.pin(8F - (float)Engine.ai_nonswarm_count(hall_c_flood), 0F, 6F));
            Engine.ai_place(hall_c_carrier_e.Squad);
            await Engine.sleep(1);
            Engine.ai_set_orders(hall_c_flood, hall_c_floor_e);
        }

        [ScriptMethod(367, Lifecycle.Dormant)]
        public async Task enc_ledge_a()
        {
            if (this.g_ledge_a)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_a, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize ledge a scripts");
            }

            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_ledge_a_sec_a");
            Engine.ai_disposable(hall_c_flood, true);
            Engine.wake(new ScriptMethodReference(ai_ledge_a_initial));
            Engine.ai_place(ledge_a_flood_dead.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ledge_a_flood_ini.Squad) <= 0 || Engine.volume_test_objects(tv_ledge_a_top_b, Engine.players()));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_a_top_b, Engine.players()));
            Engine.game_save_no_timeout();
            Engine.wake(new ScriptMethodReference(ai_ledge_a_location));
            Engine.wake(new ScriptMethodReference(ai_ledge_a_emitters));
            Engine.wake(new ScriptMethodReference(ai_ledge_a_flood_spawn));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_a_top_d1, Engine.players()));
            Engine.game_save_no_timeout();
            Engine.ai_place(ledge_a_flood_d1.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_a_top_d2, Engine.players()));
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_ledge_a_sec_b");
            Engine.ai_place(ledge_a_flood_d2.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_a_top_e, Engine.players()));
            Engine.game_save_no_timeout();
            Engine.ai_set_orders(ledge_a_flood, ledge_a_floor_follow);
        }

        [ScriptMethod(368, Lifecycle.Dormant)]
        public async Task enc_conduit_b()
        {
            if (this.g_conduit_b)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_conduit_b, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize conduit b scripts");
            }

            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_cond_b_sec_a");
            Engine.ai_disposable(ledge_a_sentinels, true);
            Engine.ai_disposable(ledge_a_enforcer.Squad, true);
            Engine.ai_disposable(ledge_a_flood, true);
            Engine.wake(new ScriptMethodReference(music_06a_06));
            Engine.wake(new ScriptMethodReference(music_06a_07));
            if (await this.difficulty_legendary())
            {
                Engine.wake(new ScriptMethodReference(ice_cream_mythic));
            }

            this.g_music_06a_06 = true;
            this.g_ledge_a_spawn = true;
            Engine.wake(new ScriptMethodReference(ai_cond_b_flood_spawn));
            Engine.wake(new ScriptMethodReference(conduit_b_locator));
            Engine.wake(new ScriptMethodReference(ai_cond_b_carrier_a));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cond_b_a2, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.ai_place(cond_b_flood_tube_a.Squad);
            this.cond_b_flood_a_spawn = true;
            await Engine.sleep(5);
            Engine.ai_set_orders(cond_b_flood, cond_b_floor_follow_a);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cond_b_b1, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_cond_b_sec_b");
            Engine.ai_set_orders(cond_b_flood, cond_b_floor_follow_b);
            Engine.ai_place(cond_b_sen_b._1);
            Engine.ai_place(cond_b_sen_b._3);
            Engine.ai_place(cond_b_flood_b_ini.Squad);
            Engine.wake(new ScriptMethodReference(ai_cond_b_b_em));
            await Engine.sleep(5);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cond_b_b2, Engine.players()), 10);
            Engine.game_save_no_timeout();
            this.g_music_06a_07 = true;
            Engine.sleep_forever(new ScriptMethodReference(ai_cond_b_b_em));
            Engine.wake(new ScriptMethodReference(ai_cond_b_sen_tube_b));
            Engine.ai_set_orders(cond_b_flood, cond_b_floor_follow_c);
            Engine.ai_disposable(ledge_a_flood, true);
            Engine.ai_disposable(ledge_a_sentinels, true);
            Engine.ai_disposable(ledge_a_enforcer.Squad, true);
            Engine.ai_disposable(cond_b_flood, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cond_b_c, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_cond_b_sec_c");
            Engine.wake(new ScriptMethodReference(sc_marines_a));
            this.cond_b_flood_b_spawn = true;
            Engine.ai_place(cond_b_humans.Squad);
            Engine.ai_place(cond_b_flood_c_ini_a.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(cond_b_flood), 0F, 4F));
            await Engine.sleep(1);
            Engine.ai_place(cond_b_flood_c_ini_b.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(cond_b_flood), 0F, 4F));
            Engine.ai_place(cond_b_infection_c.Squad, 2);
            await Engine.sleep(5);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cond_b_hum_dead, Engine.players()), 10);
            Engine.game_save_no_timeout();
            Engine.wake(new ScriptMethodReference(kill_cond_b_marines));
        }

        [ScriptMethod(369, Lifecycle.Dormant)]
        public async Task enc_ledge_b()
        {
            if (this.g_ledge_b)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_b, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize ledge b scripts");
            }

            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_ledge_b");
            Engine.ai_disposable(cond_b_flood, true);
            Engine.ai_disposable(cond_b_sentinels, true);
            Engine.ai_disposable(cond_b_infection_c.Squad, true);
            this.cond_b_flood_c_spawn = true;
            Engine.ai_place(ledge_b_flood.Squad);
            Engine.ai_place(ledge_c_phantom.Squad);
            Engine.wake(new ScriptMethodReference(slide_a_player0));
            Engine.wake(new ScriptMethodReference(slide_a_player1));
            Engine.wake(new ScriptMethodReference(music_06a_08));
            Engine.wake(new ScriptMethodReference(music_06a_09));
            Engine.wake(new ScriptMethodReference(music_06a_10));
        }

        [ScriptMethod(370, Lifecycle.Dormant)]
        public async Task enc_ledge_c()
        {
            if (this.g_ledge_c)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_c, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize ledge c scripts");
            }

            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_ledge_c");
            Engine.ai_disposable(ledge_b_sen.Squad, true);
            Engine.wake(new ScriptMethodReference(ai_ledge_c_flood_ini));
            Engine.wake(new ScriptMethodReference(ai_ledge_c_infection_spawn));
            Engine.ai_magically_see(ledge_c_flood, ledge_c_phantom.Squad);
            this.g_ledge_c_phantom_start = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ledge_c_bk, Engine.players()));
            Engine.game_save_no_timeout();
            this.ledge_c_spawn = false;
            this.g_ledge_c_phantom_1 = true;
            Engine.ai_place(ledge_c_flood_bk.Squad, (short)Engine.pin(6F - (float)Engine.ai_living_count(ledge_c_flood), 0F, 6F));
            Engine.wake(new ScriptMethodReference(slide_b_player0));
            Engine.wake(new ScriptMethodReference(slide_b_player1));
        }

        [ScriptMethod(371, Lifecycle.Dormant)]
        public async Task enc_qz_initial()
        {
            if (this.g_qz_initial)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_initial, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize quarantine zone initial scripts");
            }

            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_qz_initial");
            Engine.ai_disposable(ledge_c_flood, true);
            Engine.wake(new ScriptMethodReference(cs_mortar_a));
            Engine.wake(new ScriptMethodReference(cs_mortar_b));
            await Engine.sleep_until(async () => Engine.device_get_position(qz_door.Entity) > 0F, 1);
            Engine.wake(new ScriptMethodReference(chapter_war));
            Engine.wake(new ScriptMethodReference(objective_floodwall_clear));
            Engine.wake(new ScriptMethodReference(objective_rendezvous_set));
            Engine.wake(new ScriptMethodReference(cs_crash_factory));
            this.g_music_06a_10 = false;
            Engine.ai_place(qz_initial_flood_ini.Squad);
            Engine.ai_place(qz_initial_flood_carrier_ini.Squad);
            Engine.ai_place(qz_initial_flood_bridge.Squad);
            Engine.ai_place(qz_initial_flood_carrier_camp.Squad);
            if (await this.difficulty_normal())
            {
                Engine.ai_place(qz_ini_turrets.a);
            }
            else
            {
                Engine.ai_place(qz_ini_turrets.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_camp, Engine.players()), 10);
            if (this.debug)
            {
                Engine.print("camp");
            }

            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("enc_qz_initial_camp");
            Engine.wake(new ScriptMethodReference(ai_qz_ini_flood));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_cave, Engine.players()), 10);
            if (this.debug)
            {
                Engine.print("cave");
            }

            this.g_qz_ini_cave = true;
            Engine.ai_place(qz_initial_flood_cave.Squad);
            Engine.ai_play_line_on_object(qz_ini_sound_cave.Entity, "0180") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.wake(new ScriptMethodReference(ai_qz_ini_exit_turrets));
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(372, Lifecycle.Dormant)]
        public async Task enc_cov_defense()
        {
            if (this.g_cov_defense)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_cov_defense, Engine.players()), 10);
            }

            if (this.debug)
            {
                Engine.print("initialize covenant defense scripts");
            }

            Engine.game_save();
            Engine.data_mine_set_mission_segment("enc_covenant_defense");
            Engine.ai_disposable(qz_ini_flood, true);
            Engine.ai_disposable(qz_cov_def_flood, true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(qz_ini_turrets.Squad), true);
            Engine.ai_vehicle_exit(qz_ini_ins_pods.Squad);
            Engine.ai_migrate(qz_ini_ins_pods.Squad, qz_cov_def_cov.Squad);
            Engine.ai_set_orders(qz_ini_flood, qz_cov_def_hill);
            Engine.ai_place(qz_cov_def_flood_ini.Squad);
            Engine.ai_place(qz_cov_def_flood_g.Squad);
            Engine.ai_place(qz_cov_def_cov.Squad, (short)Engine.pin(3F - (float)Engine.ai_living_count(qz_cov_def_cov.Squad), 0F, 2F));
            Engine.ai_place(qz_cov_def_soc.Squad);
            Engine.ai_place(qz_camp_turrets.Squad);
            Engine.object_cannot_die(Engine.ai_get_object(qz_cov_def_soc.soc), true);
            Engine.ai_set_orders(covenant1, qz_cov_def_cov_ac);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(qz_cov_def_flood) <= 0);
            Engine.ai_set_orders(covenant1, qz_cov_def_hill);
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(sc_qz_cov_camp));
            await Engine.sleep_until(async () => this.g_qz_cov_camp_progress);
            Engine.wake(new ScriptMethodReference(ai_qz_cov_def_flood_spawn));
            Engine.wake(new ScriptMethodReference(ai_qz_cov_def_carrier));
            await Engine.sleep(1);
            await Engine.sleep_until(async () => this.g_qz_cov_def_spawn == false);
            if (this.debug)
            {
                Engine.print("last of the flood waves have spawned");
            }

            await Engine.sleep((short)(30 * 5));
            Engine.game_save_no_timeout();
            Engine.ai_magically_see(covenant1, flood);
            if (this.debug)
            {
                Engine.print("phantom placed...");
            }

            Engine.ai_place(qz_phantom.Squad);
            Engine.wake(new ScriptMethodReference(you_win));
        }

        [ScriptMethod(373, Lifecycle.Dormant)]
        public async Task mission_sentinelwalls()
        {
            await this.cinematic_snap_to_white();
            Engine.switch_bsp(0);
            if (this.g_play_cinematics == true)
            {
                Engine.sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        Engine.print("x06");
                    }

                    await this.x06();
                }

                await this.cinematic_skip_stop();
                if (await this.cinematic_skip_start())
                {
                    if (this.debug)
                    {
                        Engine.print("intro");
                    }

                    await this.c06_intro();
                }

                await this.cinematic_skip_stop();
            }

            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), player0_start);
            Engine.object_teleport(await this.player1(), player1_start);
            Engine.wake(new ScriptMethodReference(enc_insertion));
            Engine.wake(new ScriptMethodReference(piston_control));
            Engine.wake(new ScriptMethodReference(difficulty_settings));
            Engine.player_training_activate_stealth();
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_silence));
            Engine.wake(new ScriptMethodReference(objective_lower_set));
            if (await this.difficulty_normal())
            {
                if (this.debug)
                {
                    Engine.print("normal");
                }
            }
            else if (await this.difficulty_heroic())
            {
                if (this.debug)
                {
                    Engine.print("heroic");
                }
            }
            else if (await this.difficulty_legendary())
            {
                if (this.debug)
                {
                    Engine.print("legendary");
                }
            }

            await Engine.sleep_until(async () => this.g_hall_a || Engine.volume_test_objects(tv_hall_a, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_hall_a));
            await Engine.sleep_until(async () => this.g_conduit_a || Engine.volume_test_objects(tv_conduit_a, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_conduit_a));
            await Engine.sleep_until(async () => this.g_hall_b || Engine.volume_test_objects(tv_hall_b, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_hall_b));
            await Engine.sleep_until(async () => this.g_plug_launch || Engine.volume_test_objects(tv_plug_launch, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_plug_launch));
            await Engine.sleep_until(async () => this.g_plug_landing || Engine.volume_test_objects(tv_plug_land, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_plug_landing));
            await Engine.sleep_until(async () => this.g_hall_c || Engine.volume_test_objects(tv_hall_c, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_hall_c));
            await Engine.sleep_until(async () => this.g_ledge_a || Engine.volume_test_objects(tv_ledge_a, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_ledge_a));
            await Engine.sleep_until(async () => this.g_conduit_b || Engine.volume_test_objects(tv_conduit_b, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_conduit_b));
            await Engine.sleep_until(async () => this.g_ledge_b || Engine.volume_test_objects(tv_ledge_b, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_ledge_b));
            await Engine.sleep_until(async () => this.g_ledge_c || Engine.volume_test_objects(tv_ledge_c, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_ledge_c));
            await Engine.sleep_until(async () => this.g_qz_initial || Engine.volume_test_objects(tv_qz_initial, Engine.players()), 10);
            this.g_piston_control = true;
            Engine.wake(new ScriptMethodReference(enc_qz_initial));
            await Engine.sleep_until(async () => this.g_cov_defense || Engine.volume_test_objects(tv_cov_defense, Engine.players()), 10);
            Engine.wake(new ScriptMethodReference(enc_cov_defense));
        }

        [ScriptMethod(374, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_sentinelwalls));
        }

        [ScriptMethod(375, Lifecycle.Startup)]
        public async Task mission_main()
        {
            Engine.ai_allegiance(covenant, player);
            Engine.ai_allegiance(player, covenant);
            Engine.ai_allegiance(prophet, player);
            Engine.ai_allegiance(player, prophet);
            Engine.ai_allegiance(covenant, prophet);
            Engine.ai_allegiance(prophet, covenant);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task x06_01a_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3888383566U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3888383566U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\fp_covenant_carbine\\fp_covenant_carbine", 3808821648U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_top\\door_piston_top", 3888711251U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3890480750U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3891005046U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 29, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3891267194U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3892381323U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3787259975U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await Engine.sleep(166);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 3894740655U), 1);
            await Engine.sleep(32);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 2);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_honor_guard\\elite_honor_guard", 3897231061U), 9);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 32, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 15, false);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\brute_honor_helmet_scenery", 3901425429U), 0);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3901818651U), 0);
            await Engine.sleep(16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829400266U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 11);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 25);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 14);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            await Engine.sleep(47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 13);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3905554260U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 33);
            await Engine.sleep(24);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            await Engine.sleep(61);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 29);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            await Engine.sleep(52);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\brute_honor_helmet_scenery", 3901425429U), 0);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3901818651U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            await Engine.sleep(11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3892381323U), 0);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            await Engine.sleep(33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 41);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, false);
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task x06_01b_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            await Engine.sleep(75);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute_honor_guard\\brute_honor_helmet_scenery\\brute_honor_helmet_scenery", 3901425429U), 0);
            await Engine.sleep(68);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3891267194U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3905685334U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_space\\high_charity_space", 3906340704U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829400266U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 0);
            await Engine.sleep(64);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829400266U), 1);
            await Engine.sleep(43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829400266U), 2);
            await Engine.sleep(35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829400266U), 2);
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task x06_02_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3891267194U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3905685334U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_space\\high_charity_space", 3906340704U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 2);
            await Engine.sleep(20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 32);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 26);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 10);
            await Engine.sleep(239);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3905554260U), 0);
            await Engine.sleep(39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 10);
            await Engine.sleep(60);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3905554260U), 0);
            await Engine.sleep(84);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 41);
            await Engine.sleep(334);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3902474021U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\pike\\pike", 3905554260U), 0);
            await Engine.sleep(43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 41);
            await Engine.sleep(76);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 41);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            await Engine.sleep(17);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3892381323U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task x06_03_predict()
        {
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            await Engine.sleep(117);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3892381323U), 0);
            await Engine.sleep(141);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 1);
            await Engine.sleep(39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            await Engine.sleep(183);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 2);
            await Engine.sleep(100);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task x06_04_predict()
        {
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3896510154U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 10);
            await Engine.sleep(571);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 1);
            await Engine.sleep(158);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 0);
            await Engine.sleep(120);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3892381323U), 0);
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task x06_05_predict()
        {
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 10);
            await Engine.sleep(275);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3912566719U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            await Engine.sleep(37);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3892381323U), 0);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            await Engine.sleep(43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 0);
            await Engine.sleep(229);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_alone\\index_alone", 3913156552U), 0);
            await Engine.sleep(162);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_8"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_door\\high_sanctum_door", 3895920321U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3906602852U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3912042423U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_sanctum_lift\\high_sanctum_lift", 3892381323U), 0);
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task _06_intro_01_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 27, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 143, false);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_stardust\\high_charity_stardust", 3914401755U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3914729440U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3905685334U), 0);
            await Engine.sleep(182);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\cinematics\\cinematics", 3915057125U), 0);
            await Engine.sleep(140);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 2);
            await Engine.sleep(218);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3903522613U), 34);
            await Engine.sleep(74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 2);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task _06_intro_02_predict()
        {
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 16);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\mount_doom\\mount_doom", 3915384810U), 0);
            await Engine.sleep(154);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 33, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\antennae_comm\\antennae_comm", 3915646958U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\antennae_comm\\antennae_comm", 3915646958U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\antennae_comm\\antennae_comm", 3915646958U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3916826624U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\fuselage_arm\\fuselage_arm", 3917285383U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\fuselage\\fuselage", 3917613068U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\head\\head", 3917678605U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3917744142U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3809870240U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3918137364U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3918137364U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\arm\\arm", 3918923808U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3918989345U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3891005046U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3919120419U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\senhq_detail_crate\\shq_cover_small\\shq_cover_small", 3919579178U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829400266U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_top\\door_piston_top", 3888711251U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3920169011U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3920169011U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3920169011U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3920169011U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3920169011U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3921807436U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3921807436U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_piston_absorber\\door_piston_absorber", 3923642472U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\sentinel_emitter\\sentinel_emitter", 3924101231U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3890480750U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\bullshit_switch\\bullshit_switch", 3925215360U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\jungle\\jungle", 3786342457U), 9);
            await Engine.sleep(9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 7);
            await Engine.sleep(62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 4);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 24, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3917744142U), 3);
            await Engine.sleep(40);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 25, false);
            await Engine.sleep(53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 2);
            await Engine.sleep(13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3917744142U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3918137364U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3918137364U), 1);
            await Engine.sleep(21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 0);
            await Engine.sleep(28);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 39, true);
            await Engine.sleep(59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 48);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 49);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 50);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 51);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 52);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 56);
            await Engine.sleep(139);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 40, true);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\fuselage_arm\\fuselage_arm", 3917285383U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 48);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 49);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 50);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 51);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 52);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 55);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 56);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_aggressor\\garbage\\arm\\arm", 3918923808U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 6, true);
            await Engine.sleep(51);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 25, false);
            await Engine.sleep(47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 66);
            await Engine.sleep(18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3925477508U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829400266U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\garbage\\thruster\\thruster", 3872130390U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\sentinel_enforcer\\sentinel_enforcer", 3868263707U), 73);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3913549774U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 4);
            await Engine.sleep(16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 7);
            await Engine.sleep(19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 4);
            await Engine.sleep(20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3925411971U), 1);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 212, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 211, false);
            await Engine.sleep(47);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_1"), 39, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3840803704U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788439641U), 2);
        }

        [ScriptMethod(384, Lifecycle.Static)]
        public async Task tele_insertion()
        {
            Engine.map_reset();
        }

        [ScriptMethod(385, Lifecycle.Static)]
        public async Task tele_hall_a()
        {
            Engine.switch_bsp(0);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), hall_a_a);
            Engine.object_teleport(await this.player1(), hall_a_b);
            Engine.ai_erase_all();
            this.g_hall_a = true;
        }

        [ScriptMethod(386, Lifecycle.Static)]
        public async Task tele_conduit_a()
        {
            Engine.switch_bsp(0);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), conduit_a_a);
            Engine.object_teleport(await this.player1(), conduit_a_b);
            Engine.ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
        }

        [ScriptMethod(387, Lifecycle.Static)]
        public async Task tele_hall_b()
        {
            Engine.switch_bsp(0);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), hall_b_a);
            Engine.object_teleport(await this.player1(), hall_b_b);
            Engine.ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
        }

        [ScriptMethod(388, Lifecycle.Static)]
        public async Task tele_plug_launch()
        {
            Engine.switch_bsp(0);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), plug_launch_a);
            Engine.object_teleport(await this.player1(), plug_launch_b);
            Engine.ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
        }

        [ScriptMethod(389, Lifecycle.Static)]
        public async Task tele_plug_landing()
        {
            Engine.switch_bsp(0);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), plug_landing_a);
            Engine.object_teleport(await this.player1(), plug_landing_b);
            Engine.ai_erase_all();
            this.g_hall_a = true;
            this.g_conduit_a = true;
            this.g_hall_b = true;
            this.g_plug_launch = true;
            this.g_plug_landing = true;
            Engine.wake(new ScriptMethodReference(cs_move_plug));
        }

        [ScriptMethod(390, Lifecycle.Static)]
        public async Task tele_hall_c()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), hall_c_a);
            Engine.object_teleport(await this.player1(), hall_c_b);
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            Engine.ai_erase_all();
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
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), ledge_a_a);
            Engine.object_teleport(await this.player1(), ledge_a_b);
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            Engine.ai_erase_all();
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
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), conduit_b_a);
            Engine.object_teleport(await this.player1(), conduit_b_b);
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            Engine.ai_erase_all();
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
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), ledge_b_a);
            Engine.object_teleport(await this.player1(), ledge_b_b);
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            Engine.ai_erase_all();
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
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), ledge_c_a);
            Engine.object_teleport(await this.player1(), ledge_c_b);
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            Engine.ai_erase_all();
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
            Engine.switch_bsp(2);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), qz_initial_a);
            Engine.object_teleport(await this.player1(), qz_initial_b);
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            Engine.ai_erase_all();
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
            Engine.switch_bsp(2);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), cov_defense_a);
            Engine.object_teleport(await this.player1(), cov_defense_b);
            Engine.wake(new ScriptMethodReference(bsp0_cleanup));
            Engine.ai_erase_all();
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