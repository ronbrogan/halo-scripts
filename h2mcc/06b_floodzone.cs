namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\06b_floodzone\\06b_floodzone")]
    public partial class scnr_06b_floodzone : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool debug;
        bool dialogue;
        bool g_play_cinematics;
        bool g_fact_ent_sen_spawn;
        int g_fact_ent_sen_count;
        int g_fact_ent_sen_index;
        int g_fact_ent_enf_count;
        int g_fact_ent_enf_index;
        bool g_music_06b_01;
        bool g_music_06b_02;
        bool g_music_06b_03;
        bool g_music_06b_04;
        bool g_music_06b_05;
        bool g_music_06b_06;
        bool g_music_06b_07;
        int dialogue_pause;
        bool g_qz_cov_def_progress;
        int g_order_delay;
        bool g_veh_int_migrate_a;
        bool g_veh_int_migrate_b;
        bool g_veh_int_migrate_c;
        bool g_veh_int_migrate_d;
        bool g_veh_int_migrate_e;
        bool g_ext_a_dam_migrate_a;
        bool g_ext_a_dam_migrate_b;
        bool g_ext_a_migrate_a;
        bool g_ext_a_migrate_b;
        bool g_ext_a_migrate_c;
        bool g_ext_a_migrate_d;
        bool g_ext_a_migrate_e;
        bool g_ext_a_migrate_f;
        bool g_ext_a_fact_ent_migrate;
        bool g_ext_b_migrate_1;
        bool g_ext_b_migrate_2;
        bool g_ext_b_migrate_3;
        bool g_ext_b_migrate_4;
        bool g_ext_b_migrate_5;
        bool g_veh_int_ghost_spawn;
        int g_veh_int_ghost_limit;
        int g_veh_int_ghost_number;
        IVehicle v_ext_a_phantom;
        bool g_qz_ext_a_wraith_shoot;
        bool g_ext_a_dam_enf;
        bool g_qz_ext_a_flood_ghosts;
        bool g_qz_ext_a_d_spawn;
        bool g_gorge_sen_spawn;
        bool g_ext_b_phantom;
        IVehicle v_ext_b_phantom;
        bool g_ext_b_ent_phantom;
        bool g_ext_b_enforcer;
        bool g_ext_b_bk_ghost_spawn;
        int g_ext_b_bk_ghost_limit;
        int g_ext_b_bk_ghost_number;
        bool g_key_started;
        bool g_key_lock0_entered;
        bool g_key_lock0_first_loadpoint;
        bool g_key_lock0_second_loadpoint;
        bool g_key_lock0_begin_human;
        bool g_key_lock0_door1;
        bool g_key_cruise_entered;
        bool g_key_cruise_first_loadpoint;
        bool g_key_cruise_halfway;
        bool g_key_shaft_entered;
        bool g_key_shaft_rising;
        bool g_key_shaft_near_exterior;
        bool g_key_lock1_entered;
        bool g_key_lock1_first_arch;
        bool g_key_lock1_second_arch;
        bool g_key_library_entered;
        bool g_key_library_arrival;
        bool g_e26_started;
        bool g_e26_ended;
        bool g_e25_started;
        bool g_e24_started;
        bool g_e23_started;
        bool g_e22_started;
        bool g_e21_started;
        public scnr_06b_floodzone(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.debug = true;
            this.dialogue = true;
            this.g_play_cinematics = true;
            this.g_fact_ent_sen_spawn = false;
            this.g_fact_ent_sen_count = 0;
            this.g_fact_ent_sen_index = 10;
            this.g_fact_ent_enf_count = 0;
            this.g_fact_ent_enf_index = 3;
            this.g_music_06b_01 = true;
            this.g_music_06b_02 = false;
            this.g_music_06b_03 = false;
            this.g_music_06b_04 = false;
            this.g_music_06b_05 = false;
            this.g_music_06b_06 = false;
            this.g_music_06b_07 = false;
            this.dialogue_pause = 7;
            this.g_qz_cov_def_progress = false;
            this.g_order_delay = 150;
            this.g_veh_int_migrate_a = false;
            this.g_veh_int_migrate_b = false;
            this.g_veh_int_migrate_c = false;
            this.g_veh_int_migrate_d = false;
            this.g_veh_int_migrate_e = false;
            this.g_ext_a_dam_migrate_a = false;
            this.g_ext_a_dam_migrate_b = false;
            this.g_ext_a_migrate_a = false;
            this.g_ext_a_migrate_b = false;
            this.g_ext_a_migrate_c = false;
            this.g_ext_a_migrate_d = false;
            this.g_ext_a_migrate_e = false;
            this.g_ext_a_migrate_f = false;
            this.g_ext_a_fact_ent_migrate = false;
            this.g_ext_b_migrate_1 = false;
            this.g_ext_b_migrate_2 = false;
            this.g_ext_b_migrate_3 = false;
            this.g_ext_b_migrate_4 = false;
            this.g_ext_b_migrate_5 = false;
            this.g_veh_int_ghost_spawn = false;
            this.g_veh_int_ghost_limit = 0;
            this.g_veh_int_ghost_number = 0;
            this.v_ext_a_phantom = default(IVehicle);
            this.g_qz_ext_a_wraith_shoot = false;
            this.g_ext_a_dam_enf = false;
            this.g_qz_ext_a_flood_ghosts = false;
            this.g_qz_ext_a_d_spawn = true;
            this.g_gorge_sen_spawn = false;
            this.g_ext_b_phantom = false;
            this.v_ext_b_phantom = default(IVehicle);
            this.g_ext_b_ent_phantom = false;
            this.g_ext_b_enforcer = false;
            this.g_ext_b_bk_ghost_spawn = false;
            this.g_ext_b_bk_ghost_limit = 0;
            this.g_ext_b_bk_ghost_number = 0;
            this.g_key_started = false;
            this.g_key_lock0_entered = false;
            this.g_key_lock0_first_loadpoint = false;
            this.g_key_lock0_second_loadpoint = false;
            this.g_key_lock0_begin_human = false;
            this.g_key_lock0_door1 = false;
            this.g_key_cruise_entered = false;
            this.g_key_cruise_first_loadpoint = false;
            this.g_key_cruise_halfway = false;
            this.g_key_shaft_entered = false;
            this.g_key_shaft_rising = false;
            this.g_key_shaft_near_exterior = false;
            this.g_key_lock1_entered = false;
            this.g_key_lock1_first_arch = false;
            this.g_key_lock1_second_arch = false;
            this.g_key_library_entered = false;
            this.g_key_library_arrival = false;
            this.g_e26_started = false;
            this.g_e26_ended = false;
            this.g_e25_started = false;
            this.g_e24_started = false;
            this.g_e23_started = false;
            this.g_e22_started = false;
            this.g_e21_started = false;
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
        public async Task _06_intra1_01_predict_stub()
        {
            wake(new ScriptMethodReference(_06_intra1_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _06_intra2_01_predict_stub()
        {
            wake(new ScriptMethodReference(_06_intra2_01_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _06_intra2_02_predict_stub()
        {
            wake(new ScriptMethodReference(_06_intra2_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _06_intra2_03_predict_stub()
        {
            wake(new ScriptMethodReference(_06_intra2_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x07_01_predict_stub()
        {
            wake(new ScriptMethodReference(x07_01_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x07_02_predict_stub()
        {
            wake(new ScriptMethodReference(x07_02_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x07_03_predict_stub()
        {
            wake(new ScriptMethodReference(x07_03_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x07_04_predict_stub()
        {
            wake(new ScriptMethodReference(x07_04_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x07_05_predict_stub()
        {
            wake(new ScriptMethodReference(x07_05_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x07_06_predict_stub()
        {
            wake(new ScriptMethodReference(x07_06_predict));
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c06_intra1_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\music\\c06_intra1_01_mus", 3839492964U), default(IGameObject), 1F);
            print("c06_intra1 score 01 start");
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c06_intra1_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\foley\\c06_intra1_01_fol", 3839558501U), default(IGameObject), 1F);
            print("c06_intra1 foley 01 start");
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c06_2070_der()
        {
            await sleep(69);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2070_der", 3839624038U), dervish_intra1.Entity, 1F);
            cinematic_subtitle("c06_2070_der", 7F);
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c06_2090_soc()
        {
            await sleep(303);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2090_soc", 3839689575U), commander_intra1.Entity, 1F);
            cinematic_subtitle("c06_2090_soc", 8F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c06_2101_elc()
        {
            await sleep(533);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2101_elc", 3839755112U), default(IGameObject), 1F);
            cinematic_subtitle("c06_2101_elc", 3F);
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c06_2110_soc()
        {
            await sleep(610);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2110_soc", 3839820649U), commander_intra1.Entity, 1F);
            cinematic_subtitle("c06_2110_soc", 3F);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c06_2120_soc()
        {
            await sleep(693);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2120_soc", 3839886186U), commander_intra1.Entity, 1F);
            cinematic_subtitle("c06_2120_soc", 2F);
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c06_intra1_dof_01()
        {
            await sleep(0);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(5F, 1F, 1F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(165);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c06_intra1_dof_02()
        {
            time_code_reset();
            await sleep(587);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(3F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            print("rack focus");
            object_destroy_containing("elite");
            await sleep(190);
            cinematic_screen_effect_set_depth_of_field(3F, 0F, 0.5F, 1F, 0.5F, 0F, 1F);
            print("rack focus");
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c06_intra1_cinematic_light()
        {
            cinematic_lighting_set_primary_light(-20F, 282F, 0.21F, 0.29F, 0.37F);
            cinematic_lighting_set_secondary_light(-59F, 306F, 0.34F, 0.58F, 0.65F);
            cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            object_uses_cinematic_lighting(dervish_intra1.Entity, true);
            object_uses_cinematic_lighting(commander_intra1.Entity, true);
            object_uses_cinematic_lighting(elite_01.Entity, true);
            object_uses_cinematic_lighting(elite_02.Entity, true);
            object_uses_cinematic_lighting(elite_03.Entity, true);
            object_uses_cinematic_lighting(elite_04.Entity, true);
            object_uses_cinematic_lighting(phantom_intra1.Entity, true);
            object_uses_cinematic_lighting(spectre_intra1.Entity, true);
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task c06_intra1_setup()
        {
            object_create_anew(dervish_intra1);
            object_create_anew(commander_intra1);
            object_create_anew(elite_01);
            object_create_anew(elite_02);
            object_create_anew(elite_03);
            object_create_anew(elite_04);
            object_create_anew(phantom_intra1);
            object_create_anew(spectre_intra1);
            cinematic_clone_players_weapon(dervish_intra1.Entity, "left_hand_elite", "");
            object_cinematic_lod(dervish_intra1.Entity, true);
            object_cinematic_lod(commander_intra1.Entity, true);
            object_cinematic_lod(elite_01.Entity, true);
            object_cinematic_lod(elite_02.Entity, true);
            object_cinematic_lod(elite_03.Entity, true);
            object_cinematic_lod(elite_04.Entity, true);
            object_cinematic_lod(phantom_intra1.Entity, true);
            object_cinematic_lod(spectre_intra1.Entity, true);
            wake(new ScriptMethodReference(c06_intra1_score_01));
            wake(new ScriptMethodReference(c06_intra1_foley_01));
            wake(new ScriptMethodReference(c06_2070_der));
            wake(new ScriptMethodReference(c06_2090_soc));
            wake(new ScriptMethodReference(c06_2101_elc));
            wake(new ScriptMethodReference(c06_2110_soc));
            wake(new ScriptMethodReference(c06_2120_soc));
            wake(new ScriptMethodReference(c06_intra1_dof_01));
            wake(new ScriptMethodReference(c06_intra1_dof_02));
            wake(new ScriptMethodReference(c06_intra1_cinematic_light));
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task c06_intra1_cleanup()
        {
            object_destroy_containing("intra1");
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(46, Lifecycle.Static)]
        public async Task c06_intra1()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("vehicle", 0.25F, 1);
            sound_class_set_gain("amb", 0.5F, 1);
            switch_bsp_by_name(GetReference<IBsp>("sentinelhq_2"));
            await sleep(1);
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("floodzone_intra1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._06_intra1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\music\\c06_intra1_01_mus", 3839492964U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\foley\\c06_intra1_01_fol", 3839558501U));
            await sleep(this.prediction_offset);
            await this.c06_intra1_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra1\\06_intra1", 3839951723U), "06_intra1_01", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(dervish_intra1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra1\\06_intra1", 3840017260U), "dervish_01", false, anchor_intra1.Entity);
            custom_animation_relative(commander_intra1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3840148334U), "soc_01", false, anchor_intra1.Entity);
            custom_animation_relative(elite_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3840148334U), "elite01_01", false, anchor_intra1.Entity);
            custom_animation_relative(elite_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3840148334U), "elite02_01", false, anchor_intra1.Entity);
            custom_animation_relative(elite_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3840148334U), "elite03_01", false, anchor_intra1.Entity);
            custom_animation_relative(elite_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3840148334U), "elite04_01", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_intra1.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intra1\\06_intra1", 3840279408U), "phantom_01", false, anchor_intra1.Entity);
            custom_animation_relative(spectre_intra1.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\spectre\\06_intra1\\06_intra1", 3840344945U), "spectre_01", false, anchor_intra1.Entity);
            await sleep(15);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c06_intra1_cleanup();
            await sleep(30);
            sound_class_set_gain("vehicle", 1F, 1);
            sound_class_set_gain("amb", 1F, 1);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c06_intra2_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\music\\c06_intra_2_01_mus", 3840410482U), default(IGameObject), 1F);
            print("c06_intra2 score 01 start");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task c06_intra2_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_01_fol", 3840476019U), default(IGameObject), 1F);
            print("c06_intra2 foley 01 start");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task c06_3010_soc()
        {
            await sleep(550);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_3010_soc", 3840541556U), default(IGameObject), 1F);
            cinematic_subtitle("c06_3010_soc", 3F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task c06_intra2_cinematic_light()
        {
            cinematic_lighting_set_primary_light(40F, 40F, 0.24F, 0.25F, 0.27F);
            cinematic_lighting_set_secondary_light(-72F, 134F, 0.23F, 0.27F, 0.29F);
            cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(commander.Entity, true);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c06_intra2_01_setup()
        {
            object_destroy(key.Entity);
            object_create_anew(dervish);
            object_create_anew(commander);
            object_create_anew(energy_blade);
            object_create_anew(key_intra2_01);
            object_create_anew(key_intra2_02);
            objects_attach(commander.Entity, "left_hand_elite", energy_blade.Entity, "");
            object_set_permutation(energy_blade.Entity, "blade", "noblade");
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(index_container.Entity, true);
            object_cinematic_lod(key_intra2_01.Entity, true);
            object_cinematic_lod(key_intra2_02.Entity, true);
            wake(new ScriptMethodReference(c06_intra2_score_01));
            wake(new ScriptMethodReference(c06_intra2_foley_01));
            wake(new ScriptMethodReference(c06_3010_soc));
            wake(new ScriptMethodReference(c06_intra2_cinematic_light));
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task c06_intra2_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("floodzone_intra2");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._06_intra2_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\music\\c06_intra_2_01_mus", 3840410482U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_01_fol", 3840476019U));
            await sleep(this.prediction_offset);
            await this.c06_intra2_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra2\\06_intra2", 3840607093U), "06_intra2_01", default(IUnit), anchor_flag_intra2);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra2\\06_intra2", 3840672630U), "dervish_01", false, anchor_intra2.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra2\\06_intra2", 3840738167U), "commander_01", false, anchor_intra2.Entity);
            scenery_animation_start_relative(key_intra2_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3840803704U), "intra2_dervishkey_01", anchor_intra2.Entity);
            scenery_animation_start_relative(key_intra2_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3840803704U), "intra2_humankey_01", anchor_intra2.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._06_intra2_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_02_fol", 3840869241U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c06_intra2_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_02_fol", 3840869241U), default(IGameObject), 1F);
            print("c06_intra2 foley 02 start");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c06_3030_soc()
        {
            await sleep(73);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_3030_soc", 3840934778U), commander.Entity, 1F);
            cinematic_subtitle("c06_3030_soc", 3F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task blade_activate()
        {
            time_code_reset();
            await sleep(87);
            object_set_permutation(energy_blade.Entity, "blade", "default");
            object_set_function_variable(energy_blade.Entity, "turned_on", 1F, 0F);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\melee\\energy_blade\\blade_activate_replace", 3841000315U), commander.Entity, "left_hand_elite");
            print("blade activate");
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task kill_switch()
        {
            await sleep(307);
            print("delete switch");
            object_destroy(key_switch.Entity);
        }

        [ScriptMethod(57, Lifecycle.Static)]
        public async Task c06_intra2_02_setup()
        {
            cinematic_set_far_clip_distance(2048F);
            print("set far clip");
            wake(new ScriptMethodReference(c06_intra2_foley_02));
            wake(new ScriptMethodReference(c06_3030_soc));
            wake(new ScriptMethodReference(blade_activate));
            wake(new ScriptMethodReference(kill_switch));
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c06_intra2_02_cleanup()
        {
            object_destroy(commander.Entity);
            object_destroy_containing("key_intra2_02");
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c06_intra2_scene_02()
        {
            await this.c06_intra2_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra2\\06_intra2", 3840607093U), "06_intra2_02", default(IUnit), anchor_flag_intra2);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra2\\06_intra2", 3840672630U), "dervish_02", false, anchor_intra2.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra2\\06_intra2", 3840738167U), "commander_02", false, anchor_intra2.Entity);
            scenery_animation_start_relative(key_intra2_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3840803704U), "intra2_dervishkey_02", anchor_intra2.Entity);
            scenery_animation_start_relative(key_intra2_02.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3840803704U), "intra2_humankey_02", anchor_intra2.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._06_intra2_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_03_fol", 3841131389U));
            await sleep((short)camera_time());
            await this.c06_intra2_02_cleanup();
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c06_intra2_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_03_fol", 3841131389U), default(IGameObject), 1F);
            print("c06_intra2 foley 03 start");
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task l06_0300_tar()
        {
            await sleep(74);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\mission\\l06_0300_tar", 3841196926U), default(IGameObject), 1F, "radio_covy");
            cinematic_subtitle("l06_0300_tar", 2F);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task l06_0310_tar()
        {
            await sleep(164);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\mission\\l06_0310_tar", 3841262463U), default(IGameObject), 1F, "radio_covy");
            cinematic_subtitle("l06_0310_tar", 2.5F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task key_door_open()
        {
            await sleep(210);
            print("key door open");
            device_set_position(key_ride_door0.Entity, 1F);
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task c06_intra2_03_setup()
        {
            object_create_anew(phantom_01);
            object_cinematic_lod(phantom_01.Entity, true);
            object_uses_cinematic_lighting(phantom_01.Entity, true);
            wake(new ScriptMethodReference(c06_intra2_foley_03));
            wake(new ScriptMethodReference(l06_0300_tar));
            wake(new ScriptMethodReference(l06_0310_tar));
            wake(new ScriptMethodReference(key_door_open));
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task c06_intra2_03_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(phantom_01.Entity);
            object_destroy(key_intra2_01.Entity);
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task c06_intra2_scene_03()
        {
            await this.c06_intra2_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra2\\06_intra2", 3840607093U), "06_intra2_03", default(IUnit), anchor_flag_intra2);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra2\\06_intra2", 3840672630U), "dervish_03", false, anchor_intra2.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intra2\\06_intra2", 3841328000U), "phantom_03", false, anchor_intra2.Entity);
            scenery_animation_start_relative(key_intra2_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3840803704U), "intra2_dervishkey_03", anchor_intra2.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c06_intra2_03_cleanup();
            await sleep(30);
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task c06_intra2()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("sen_hq_bsp_5"));
            await sleep(1);
            await this.c06_intra2_scene_01();
            await this.c06_intra2_scene_02();
            await this.c06_intra2_scene_03();
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x07_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_01_fol", 3841393537U), default(IGameObject), 1F);
            print("x07 foley 01 start");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x07_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(-46F, 220F, 0.26F, 0.23F, 0.2F);
            cinematic_lighting_set_secondary_light(63F, 262F, 0.23F, 0.27F, 0.29F);
            cinematic_lighting_set_ambient_light(0.02F, 0.02F, 0.02F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(x07_tentacle.Entity, true);
            print("tentacle cinematic lighting");
            object_uses_cinematic_lighting(index_container.Entity, true);
        }

        [ScriptMethod(70, Lifecycle.Static)]
        public async Task x07_01_setup()
        {
            object_create_anew(miranda);
            object_create_anew(x07_tentacle);
            object_create_anew(index_container);
            print("tentacle created");
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(index_container.Entity, true);
            unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 0);
            print("miranda - pain .25 0");
            wake(new ScriptMethodReference(x07_foley_01));
            wake(new ScriptMethodReference(x07_cinematic_light_01));
        }

        [ScriptMethod(71, Lifecycle.Static)]
        public async Task x07_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("floodzone_1");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x07_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_02_mus", 3841459074U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_01_fol", 3841393537U));
            await sleep(this.prediction_offset);
            await this.x07_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_01", default(IUnit), anchor_flag_x07);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3841590148U), "miranda_01", false, anchor_x07.Entity);
            scenery_animation_start_relative(x07_tentacle.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x07\\x07", 3846374349U), "tentacle_02", anchor_x07.Entity);
            print("tentacle 02 animation relative started");
            scenery_animation_start_relative(x07_tentacle.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x07\\x07", 3846374349U), "tentacle_01", anchor_x07.Entity);
            print("tentacle 01 animation relative started");
            scenery_animation_start_relative(index_container.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3846439886U), "x07_01", anchor_x07.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x07_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_02_fol", 3846505423U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task x07_score_02()
        {
            await sleep(279);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_02_mus", 3841459074U), default(IGameObject), 1F);
            print("x07 score 02 start");
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task x07_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_02_fol", 3846505423U), default(IGameObject), 1F);
            print("x07 foley 02 start");
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task x07_0010_mir()
        {
            await sleep(249);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0010_mir", 3846570960U), miranda.Entity, 1F);
            cinematic_subtitle("x07_0010_mir", 1F);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x07_0020_jon()
        {
            await sleep(399);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0020_jon", 3846636497U), johnson.Entity, 1F);
            cinematic_subtitle("x07_0020_jon", 4F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x07_0030_mir()
        {
            await sleep(540);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0030_mir", 3846702034U), miranda.Entity, 1F);
            cinematic_subtitle("x07_0030_mir", 1.5F);
            unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 15);
            print("miranda - pain .25 15");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x07_emotion_miranda_01()
        {
            await sleep(330);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 0);
            print("miranda - shocked .5 0");
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x07_emotion_miranda_02()
        {
            await sleep(520);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            print("miranda - shocked .25 0");
        }

        [ScriptMethod(79, Lifecycle.Static)]
        public async Task x07_02_setup()
        {
            object_create_anew(johnson);
            object_cinematic_lod(johnson.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            wake(new ScriptMethodReference(x07_score_02));
            wake(new ScriptMethodReference(x07_foley_02));
            wake(new ScriptMethodReference(x07_0010_mir));
            wake(new ScriptMethodReference(x07_0020_jon));
            wake(new ScriptMethodReference(x07_0030_mir));
            wake(new ScriptMethodReference(x07_emotion_miranda_01));
            wake(new ScriptMethodReference(x07_emotion_miranda_02));
        }

        [ScriptMethod(80, Lifecycle.Static)]
        public async Task x07_scene_02()
        {
            await this.x07_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_02", default(IUnit), anchor_flag_x07);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3841590148U), "miranda_02", false, anchor_x07.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3846767571U), "johnson_02", false, anchor_x07.Entity);
            scenery_animation_start_relative(x07_tentacle.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x07\\x07", 3846374349U), "tentacle_02", anchor_x07.Entity);
            print("tentacle 02 animation started");
            scenery_animation_start_relative(index_container.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3846439886U), "x07_02", anchor_x07.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x07_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_03_mus", 3846898645U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_03_fol", 3846964182U));
            await sleep((short)camera_time());
            object_destroy(x07_tentacle.Entity);
            print("tentacle destroyed");
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x07_score_03()
        {
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_03_mus", 3846898645U), default(IGameObject), 1F);
            print("x07 score 03 start");
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x07_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_03_fol", 3846964182U), default(IGameObject), 1F);
            print("x07 foley 03 start");
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x07_0040_jon()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0040_jon", 3847029719U), johnson.Entity, 1F);
            cinematic_subtitle("x07_0040_jon", 2F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x07_0050_jon()
        {
            await sleep(77);
            unit_set_emotional_state(johnson.Entity, "pain", 0.25F, 0);
            print("johnson - pain .25 0");
            await sleep(10);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0050_jon", 3847095256U), johnson.Entity, 1F);
            cinematic_subtitle("x07_0050_jon", 1.5F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x07_0060_jon()
        {
            await sleep(150);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0060_jon", 3847160793U), johnson.Entity, 1F);
            cinematic_subtitle("x07_0060_jon", 1F);
            await sleep(25);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 15);
            print("miranda - shocked .25 15");
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task x07_0070_jon()
        {
            await sleep(540);
            unit_set_emotional_state(johnson.Entity, "shocked", 0.25F, 10);
            print("johnson - shocked .25 10");
            await sleep(10);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0070_jon", 3847226330U), johnson.Entity, 1F);
            cinematic_subtitle("x07_0070_jon", 1F);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task x07_0080_jon()
        {
            await sleep(678);
            unit_set_emotional_state(johnson.Entity, "annoyed", 0.75F, 60);
            print("johnson - annoyed .75 60");
            await sleep(10);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0080_jon", 3847291867U), johnson.Entity, 1F);
            cinematic_subtitle("x07_0080_jon", 1F);
            await sleep(45);
            unit_set_emotional_state(johnson.Entity, "shocked", 0.5F, 30);
            print("johnson - shocked .5 30");
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x07_0090_mir()
        {
            await sleep(776);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0090_mir", 3847357404U), default(IGameObject), 1F);
            cinematic_subtitle("x07_0090_mir", 1F);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x07_0100_mir()
        {
            await sleep(800);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0100_mir", 3847422941U), miranda.Entity, 1F);
            cinematic_subtitle("x07_0100_mir", 1F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task miranda_smgs_fire_1()
        {
            await sleep(834);
            object_create_anew(smg_real_01);
            object_create_anew(smg_real_02);
            object_set_scale(smg_real_01.Entity, 1F, 0);
            object_set_scale(smg_real_02.Entity, 1F, 0);
            objects_attach(miranda.Entity, "right_hand", smg_real_01.Entity, "");
            objects_attach(miranda.Entity, "left_hand", smg_real_02.Entity, "");
            await sleep(5);
            weapon_hold_trigger(GetReference<IWeaponReference>("smg_real_01"), 0, true);
            weapon_hold_trigger(GetReference<IWeaponReference>("smg_real_02"), 0, true);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task johnson_rifle_fire()
        {
            await sleep(563);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(10);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(21);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
            await sleep(2);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3847488478U), johnson_rifle.Entity, "primary_trigger");
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task dervish_cammo()
        {
            await sleep(627);
            print("effect - cammo off");
            unit_set_active_camo(dervish.Entity, false, 1F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x07_cinematic_light_03()
        {
            cinematic_lighting_set_primary_light(16F, 82F, 0.25F, 0.32F, 0.32F);
            cinematic_lighting_set_secondary_light(24F, 272F, 0.22F, 0.26F, 0.28F);
            cinematic_lighting_set_ambient_light(0.02F, 0.02F, 0.02F);
            object_uses_cinematic_lighting(dervish.Entity, true);
            object_uses_cinematic_lighting(miranda_smg_01.Entity, true);
            object_uses_cinematic_lighting(miranda_smg_02.Entity, true);
            object_uses_cinematic_lighting(johnson_rifle.Entity, true);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task johnson_rifle_arm()
        {
            await sleep(105);
            objects_attach(johnson.Entity, "right_hand", johnson_rifle.Entity, "");
        }

        [ScriptMethod(95, Lifecycle.Static)]
        public async Task x07_03_setup()
        {
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_07", 3849126903U));
            object_create_anew(dervish);
            object_cannot_die(dervish.Entity, true);
            unit_set_active_camo(dervish.Entity, true, 0F);
            object_create_anew(miranda_smg_01);
            object_create_anew(miranda_smg_02);
            object_create_anew(johnson_rifle);
            object_cinematic_lod(dervish.Entity, true);
            object_cinematic_lod(miranda_smg_01.Entity, true);
            object_cinematic_lod(miranda_smg_02.Entity, true);
            object_cinematic_lod(johnson_rifle.Entity, true);
            unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 0);
            print("miranda - pain .25 0");
            unit_set_emotional_state(johnson.Entity, "pensive", 0.25F, 0);
            print("johnson - pensive .25 0");
            wake(new ScriptMethodReference(x07_score_03));
            wake(new ScriptMethodReference(x07_foley_03));
            wake(new ScriptMethodReference(x07_0040_jon));
            wake(new ScriptMethodReference(x07_0050_jon));
            wake(new ScriptMethodReference(x07_0060_jon));
            wake(new ScriptMethodReference(x07_0070_jon));
            wake(new ScriptMethodReference(x07_0080_jon));
            wake(new ScriptMethodReference(x07_0090_mir));
            wake(new ScriptMethodReference(x07_0100_mir));
            wake(new ScriptMethodReference(miranda_smgs_fire_1));
            wake(new ScriptMethodReference(johnson_rifle_arm));
            wake(new ScriptMethodReference(johnson_rifle_fire));
            wake(new ScriptMethodReference(dervish_cammo));
            wake(new ScriptMethodReference(x07_cinematic_light_03));
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task x07_scene_03()
        {
            await this.x07_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_03", default(IUnit), anchor_flag_x07);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3841590148U), "miranda_03", false, anchor_x07.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3846767571U), "johnson_03", false, anchor_x07.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3849520125U), "dervish_03", false, anchor_x07.Entity);
            scenery_animation_start_relative(index_container.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3846439886U), "x07_03", anchor_x07.Entity);
            scenery_animation_start_relative(miranda_smg_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3849585662U), "smg01_03", anchor_x07.Entity);
            scenery_animation_start_relative(miranda_smg_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3849585662U), "smg02_03", anchor_x07.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x07_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_04_fol", 3849651199U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x07_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_04_fol", 3849651199U), default(IGameObject), 1F);
            print("x07 foley 04 start");
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x07_0110_mir()
        {
            await sleep(117);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0110_mir", 3849716736U), miranda.Entity, 1F);
            cinematic_subtitle("x07_0110_mir", 1.5F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x07_0120_mir()
        {
            await sleep(169);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0120_mir", 3849782273U), miranda.Entity, 1F);
            cinematic_subtitle("x07_0120_mir", 1F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x07_0130_tar()
        {
            await sleep(483);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0130_tar", 3849847810U), tartarus.Entity, 1F);
            cinematic_subtitle("x07_0130_tar", 4F);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task x07_0140_der()
        {
            await sleep(614);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0140_der", 3849913347U), dervish.Entity, 1F);
            cinematic_subtitle("x07_0140_der", 3F);
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task effect_miranda_hit()
        {
            time_code_reset();
            await sleep(338);
            print("effect - miranda hit");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\brute\\hammer_grappling", 3849978884U), miranda.Entity, "body");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x07_cinematic_light_04()
        {
            cinematic_lighting_set_primary_light(33F, 42F, 0.2F, 0.25F, 0.25F);
            cinematic_lighting_set_secondary_light(-54F, 0F, 0.23F, 0.27F, 0.29F);
            cinematic_lighting_set_ambient_light(0.02F, 0.02F, 0.02F);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(104, Lifecycle.Static)]
        public async Task x07_scene_05_problem_actors()
        {
            print("create problem actors");
            object_create_anew_containing("brute");
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(brute_03.Entity, true);
            object_cinematic_lod(brute_04.Entity, true);
            object_cinematic_lod(brute_shot_01.Entity, true);
            object_cinematic_lod(brute_shot_02.Entity, true);
            object_cinematic_lod(brute_rifle_01.Entity, true);
            object_cinematic_lod(brute_rifle_02.Entity, true);
            objects_attach(brute_03.Entity, "right_hand", brute_shot_01.Entity, "right_hand_brute");
            objects_attach(brute_04.Entity, "right_hand", brute_shot_02.Entity, "right_hand_brute");
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(brute_03.Entity, true);
            object_uses_cinematic_lighting(brute_04.Entity, true);
            object_uses_cinematic_lighting(brute_shot_01.Entity, true);
            object_uses_cinematic_lighting(brute_shot_02.Entity, true);
            object_uses_cinematic_lighting(brute_rifle_01.Entity, true);
            object_uses_cinematic_lighting(brute_rifle_02.Entity, true);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x07_emotion_miranda_03()
        {
            await sleep(300);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 0);
            print("miranda - shocked .5 0");
            await sleep(38);
            unit_set_emotional_state(miranda.Entity, "pain", 0.8F, 10);
            print("miranda - shocked 1 10");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task tartarus_hide_seek()
        {
            await sleep(5);
            object_hide(tartarus.Entity, true);
            object_hide(hammer.Entity, true);
            await sleep(400);
            object_hide(tartarus.Entity, false);
            object_hide(hammer.Entity, false);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task miranda_smgs_destroy()
        {
            time_code_reset();
            await sleep(98);
            print("stop firing");
            weapon_hold_trigger(GetReference<IWeaponReference>("smg_real_01"), 0, false);
            weapon_hold_trigger(GetReference<IWeaponReference>("smg_real_02"), 0, false);
            await sleep(131);
            print("destroy smgs");
            objects_detach(miranda.Entity, smg_real_01.Entity);
            objects_detach(miranda.Entity, smg_real_02.Entity);
            object_destroy_containing("smg_real");
        }

        [ScriptMethod(108, Lifecycle.Static)]
        public async Task x07_04_setup()
        {
            object_create_anew(tartarus);
            object_create(hammer);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(hammer.Entity, true);
            wake(new ScriptMethodReference(x07_foley_04));
            wake(new ScriptMethodReference(x07_0110_mir));
            wake(new ScriptMethodReference(x07_0120_mir));
            wake(new ScriptMethodReference(x07_0130_tar));
            wake(new ScriptMethodReference(x07_0140_der));
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            print("miranda - shocked .25 0");
            wake(new ScriptMethodReference(x07_emotion_miranda_03));
            wake(new ScriptMethodReference(miranda_smgs_destroy));
            wake(new ScriptMethodReference(tartarus_hide_seek));
            wake(new ScriptMethodReference(x07_cinematic_light_04));
            wake(new ScriptMethodReference(effect_miranda_hit));
        }

        [ScriptMethod(109, Lifecycle.Static)]
        public async Task x07_scene_04()
        {
            await this.x07_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_04", default(IUnit), anchor_flag_x07);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3841590148U), "miranda_04", false, anchor_x07.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3846767571U), "johnson_04", false, anchor_x07.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3849520125U), "dervish_04", false, anchor_x07.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3850503180U), "tartarus_04", false, anchor_x07.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x07\\x07", 3850634254U), "hammer_04", anchor_x07.Entity);
            scenery_animation_start_relative(miranda_smg_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3849585662U), "smg01_04", anchor_x07.Entity);
            scenery_animation_start_relative(miranda_smg_02.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3849585662U), "smg02_04", anchor_x07.Entity);
            scenery_animation_start_relative(index_container.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3846439886U), "x07_04", anchor_x07.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x07_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_05_fol", 3850699791U));
            await this.x07_scene_05_problem_actors();
            await sleep((short)camera_time());
            objects_detach(johnson.Entity, johnson_rifle.Entity);
            object_destroy(johnson_rifle.Entity);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x07_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_05_fol", 3850699791U), default(IGameObject), 1F);
            print("x07 foley 05 start");
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x07_0150_tar()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0150_tar", 3850765328U), tartarus.Entity, 1F);
            cinematic_subtitle("x07_0150_tar", 1.5F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x07_0160_tar()
        {
            await sleep(48);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0160_tar", 3850830865U), tartarus.Entity, 1F);
            cinematic_subtitle("x07_0160_tar", 2F);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task x07_0170_tar()
        {
            await sleep(302);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0170_tar", 3850896402U), tartarus.Entity, 1F);
            cinematic_subtitle("x07_0170_tar", 4F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x07_0180_tar()
        {
            await sleep(428);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0180_tar", 3850961939U), tartarus.Entity, 1F);
            cinematic_subtitle("x07_0180_tar", 5.5F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task x07_0190_der()
        {
            await sleep(591);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0190_der", 3851027476U), dervish.Entity, 1F);
            cinematic_subtitle("x07_0190_der", 2.5F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task destroy_miranda()
        {
            await sleep(428);
            object_destroy(miranda.Entity);
            print("destroy miranda");
        }

        [ScriptMethod(117, Lifecycle.Static)]
        public async Task x07_05_setup()
        {
            wake(new ScriptMethodReference(x07_foley_05));
            wake(new ScriptMethodReference(x07_0150_tar));
            wake(new ScriptMethodReference(x07_0160_tar));
            wake(new ScriptMethodReference(x07_0170_tar));
            wake(new ScriptMethodReference(x07_0180_tar));
            wake(new ScriptMethodReference(x07_0190_der));
            unit_set_emotional_state(miranda.Entity, "asleep", 1F, 0);
            print("miranda - asleep 1 0");
            unit_set_emotional_state(johnson.Entity, "asleep", 1F, 0);
            print("johnson - asleep 1 0");
            wake(new ScriptMethodReference(destroy_miranda));
        }

        [ScriptMethod(118, Lifecycle.Static)]
        public async Task x07_05_cleanup()
        {
            object_destroy(johnson.Entity);
            object_destroy_containing("brute");
        }

        [ScriptMethod(119, Lifecycle.Static)]
        public async Task x07_scene_05()
        {
            await this.x07_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_05", default(IUnit), anchor_flag_x07);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3841590148U), "miranda_05", false, anchor_x07.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3846767571U), "johnson_05", false, anchor_x07.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3849520125U), "dervish_05", false, anchor_x07.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3850503180U), "tartarus_05", false, anchor_x07.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3850503180U), "brute01_05", false, anchor_x07.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3850503180U), "brute02_05", false, anchor_x07.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3850503180U), "brute03_05", false, anchor_x07.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3850503180U), "brute04_05", false, anchor_x07.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x07\\x07", 3850634254U), "hammer_05", anchor_x07.Entity);
            scenery_animation_start_relative(index_container.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3846439886U), "x07_05", anchor_x07.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x07_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_06_fol", 3851093013U));
            await sleep((short)camera_time());
            await this.x07_05_cleanup();
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task x07_foley_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_06_fol", 3851093013U), default(IGameObject), 1F);
            print("x07 foley 06 start");
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task x07_0200_tar()
        {
            await sleep(86);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0200_tar", 3851158550U), tartarus.Entity, 1F);
            cinematic_subtitle("x07_0200_tar", 6.5F);
            await sleep(128);
            unit_set_emotional_state(tartarus.Entity, "inquisitive", 1F, 60);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task tartarus_bruteshot_fire()
        {
            await sleep(373);
            print("effect - tartarus' hammer");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\brute\\tartarus_hammer_impact_cinematic", 3851224087U), tartarus.Entity, "body");
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task tartarus_bruteshot_hit()
        {
            await sleep(380);
            print("effect - hammer hit");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\brute\\hammer_grappling", 3849978884U), dervish.Entity, "body");
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x07_predict_shaft_01()
        {
            await sleep(385);
            print("predict: camera");
            camera_predict_resources_at_frame(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_06", default(IUnit), anchor_flag_x07, 405);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task x07_predict_shaft_02()
        {
            await sleep(532);
            print("predict: camera");
            camera_predict_resources_at_frame(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_06", default(IUnit), anchor_flag_x07, 552);
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task x07_06_setup()
        {
            wake(new ScriptMethodReference(x07_foley_06));
            wake(new ScriptMethodReference(x07_0200_tar));
            wake(new ScriptMethodReference(tartarus_bruteshot_fire));
            wake(new ScriptMethodReference(tartarus_bruteshot_hit));
            wake(new ScriptMethodReference(x07_predict_shaft_01));
            wake(new ScriptMethodReference(x07_predict_shaft_02));
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x07_06_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(tartarus.Entity);
            object_destroy(hammer.Entity);
            object_destroy(index_container.Entity);
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task x07_scene_06()
        {
            await this.x07_06_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3841524611U), "x07_06", default(IUnit), anchor_flag_x07);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3849520125U), "dervish_06", false, anchor_x07.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3850503180U), "tartarus_06", false, anchor_x07.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x07\\x07", 3850634254U), "hammer_06", anchor_x07.Entity);
            scenery_animation_start_relative(index_container.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3846439886U), "x07_06", anchor_x07.Entity);
            await sleep((short)((float)camera_time() - 1));
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            await this.x07_06_cleanup();
            sound_class_set_gain("amb", 0F, 60);
            await sleep(90);
        }

        [ScriptMethod(129, Lifecycle.Static)]
        public async Task x07()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("sen_hq_bsp_6"));
            await sleep(1);
            await this.x07_scene_01();
            await this.x07_scene_02();
            await this.x07_scene_03();
            await this.x07_scene_04();
            await this.x07_scene_05();
            await this.x07_scene_06();
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(130, Lifecycle.CommandScript)]
        public async Task cs_invulnerable()
        {
            cs_enable_moving(true);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_certain);
            await sleep((short)(30 * 1));
            object_can_take_damage(ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(131, Lifecycle.CommandScript)]
        public async Task cs_invul_8()
        {
            cs_enable_moving(true);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            await sleep((short)(30 * 8));
            object_can_take_damage(ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(132, Lifecycle.CommandScript)]
        public async Task cs_kill()
        {
            ai_kill_silent(this.ai_current_actor);
        }

        [ScriptMethod(133, Lifecycle.Static)]
        public async Task no_death()
        {
            object_cannot_take_damage(ai_actors(covenant1));
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task ice_cream_superman()
        {
            object_create(ice_cream_head);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4250541026U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4250541026U)), 5);
            if (this.debug)
            {
                print("you're going to get fat!!!!! or dead...");
            }

            if (this.debug)
            {
                print("because now everyone is superman!!!!");
            }

            ice_cream_flavor_stock(10);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task music_06b_01()
        {
            await sleep_until(async () => this.g_music_06b_01);
            if (this.debug)
            {
                print("start music 06b_01");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_01", 2191270154U), default(IGameObject), 1F);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task music_06b_02()
        {
            await sleep_until(async () => this.g_music_06b_02);
            if (this.debug)
            {
                print("start music 06b_02");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_02", 2191532302U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06b_02));
            if (this.debug)
            {
                print("stop music 06b_02");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_02", 2191532302U));
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task music_06b_03()
        {
            await sleep_until(async () => this.g_music_06b_03);
            if (this.debug)
            {
                print("start music 06b_03");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_03", 2192056598U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06b_03));
            if (this.debug)
            {
                print("stop music 06b_03");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_03", 2192056598U));
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task music_06b_04()
        {
            await sleep_until(async () => this.g_music_06b_04);
            if (this.debug)
            {
                print("start music 06b_04");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_04", 2192449820U), default(IGameObject), 1F);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task music_06b_05()
        {
            await sleep_until(async () => volume_test_objects(tv_e20_dock_entrance, players()));
            this.g_music_06b_05 = true;
            if (this.debug)
            {
                print("start music 06b_05");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_05", 2192777505U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.g_music_06b_05));
            if (this.debug)
            {
                print("stop music 06b_05");
            }

            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_05", 2192777505U));
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task music_06b_06()
        {
            await sleep_until(async () => this.g_music_06b_06);
            if (this.debug)
            {
                print("start music 06b_06");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_06", 2192974116U), default(IGameObject), 1F);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task music_06b_07()
        {
            await sleep_until(async () => volume_test_objects(tv_music_06b_07, players()));
            if (this.debug)
            {
                print("start music 06b_07");
            }

            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_07", 3849126903U), default(IGameObject), 1F);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task chapter_mirror()
        {
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task chapter_competition()
        {
            await sleep(30);
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task chapter_gallery()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_3);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task chapter_familiar()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_4);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task objective_push_set()
        {
            await sleep(30);
            print("new objective set:");
            print("push through the quarantine-zone toward the library.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task objective_push_clear()
        {
            print("objective complete:");
            print("push through the quarantine-zone toward the library.");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task objective_link_set()
        {
            await sleep(30);
            print("new objective set:");
            print("link-up with the spec-ops leader, and break through the flood barricade.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task objective_link_clear()
        {
            print("objective complete:");
            print("link-up with the spec-ops leader, and break through the flood barricade.");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task objective_retrieve_set()
        {
            await sleep(30);
            print("new objective set:");
            print("retrieve the sacred icon before the humans.");
            objectives_show_up_to(2);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task objective_retrieve_clear()
        {
            print("objective complete:");
            print("retrieve the sacred icon before the humans.");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task sc_cov_charge()
        {
            await sleep(60);
            if (this.dialogue)
            {
                print("commander: forward, warriors! and fear not pain or death!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0220"));
            await sleep((short)(this.dialogue_pause * 2));
            if (this.dialogue)
            {
                print("commander: go, arbiter! i'll follow when our reinforcements arrive!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0240"));
            await sleep(this.dialogue_pause);
            await sleep_until(async () => this.g_qz_cov_def_progress);
            if ((short)ai_living_count(cov_def_enf) <= 0)
            {
                await sleep(180);
            }
            else
            {
                await sleep(30);
            }

            if ((short)ai_living_count(cov_def_enf) > 0)
            {
                if (this.dialogue)
                {
                    print("spec-ops: go, enforcers!");
                }

                await sleep(ai_play_line(covenant1, "0590"));
                await sleep(this.dialogue_pause);
            }

            if (this.dialogue)
            {
                print("spec-ops: to the vehicles! we'll need their heavy-guns!");
            }

            await sleep(ai_play_line(covenant1, "0600"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: onward! to the sacred icon!");
            }

            await sleep(ai_play_line(covenant1, "0610"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(153, Lifecycle.CommandScript)]
        public async Task cs_sc_qz_veh_int()
        {
            if (this.dialogue)
            {
                print("spec-ops: what?! the parasite controls our vehicles?!");
            }

            await sleep(ai_play_line(covenant1, "0620"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: impossible! it's never done that before!");
            }

            await sleep(ai_play_line(covenant1, "0640"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: no matter. it will die all the same!");
            }

            await sleep(ai_play_line(covenant1, "0650"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task sc_qz_veh_int()
        {
            await sleep(180);
            await sleep_until(async () => ai_scene("sc_qz_veh_int", new ScriptMethodReference(cs_sc_qz_veh_int), covenant1));
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task sc_ext_a()
        {
            if (this.dialogue)
            {
                print("commander: i'm sending you a squad of my most experienced warriors, arbiter.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0650"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("commander: do not squander their talents!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0660"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task sc_factory_approach()
        {
            if (this.dialogue)
            {
                print("commander: commander! we've found a human vehicle!");
            }

            await sleep(ai_play_line(covenant1, "0250"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: keep moving. i'm on my way.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0260"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task sc_factory_exit()
        {
            await sleep(60);
            if (this.dialogue)
            {
                print("spec-ops: humans and parasites!");
            }

            if (this.dialogue)
            {
                print("this ring has been befouled, but we will wipe it clean!");
            }

            await sleep(ai_play_line(covenant1, "0270"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: honoring those who built it!");
            }

            await sleep(ai_play_line(covenant1, "0280"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task sc_human_fools()
        {
            if (this.dialogue)
            {
                print("commander: human fools. i almost feel sorry for them.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0290"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task sc_ext_b()
        {
            if (this.dialogue)
            {
                print("spec-ops: forward to the icon!");
            }

            await sleep(ai_play_line(covenant1, "0700"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: the parasite's ranks swell as we draw nearer to the library!");
            }

            await sleep(ai_play_line(covenant1, "0710"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("spec-ops: steel your nerves. we are not turning back!");
            }

            await sleep(ai_play_line(covenant1, "0720"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task sc_chasm()
        {
            if (this.dialogue)
            {
                print("tartarus: i see that coward didn't join you.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0300"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("tartarus: i'll do what i can to keep the flood off your back.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0310"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task sc_outer_wall()
        {
            if (this.dialogue)
            {
                print("tartarus: we cannot let the humans capture the icon!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0320"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("tartarus: the hierarchs do not look kindly on failure.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0330"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task sc_dock()
        {
            if (this.dialogue)
            {
                print("tartarus: hurry, arbiter! get the icon!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0340"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task<bool> driver_seat_test()
        {
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.a), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.b), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_ini.a), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_ini.b), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_hog_ab.hog), "warthog_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_ghost_ab.a), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_ghost_ab.b), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_scorpion1.scorpion), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_flood_hog_bk.warthog), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_bk.a), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_bk.b), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_a_ghosts1.a), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_a_ghosts1.b), "ghost_d", players()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [ScriptMethod(164, Lifecycle.Static)]
        public async Task<bool> passenger_seat_test()
        {
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_l", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_r", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_g", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_hog_ab.hog), "warthog_p", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_hog_ab.hog), "warthog_g", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_flood_hog_bk.warthog), "warthog_p", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(veh_int_flood_hog_bk.warthog), "warthog_g", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_fact_warthog.warthog), "warthog_p", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_fact_warthog.warthog), "warthog_g", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_warthog.warthog), "warthog_p", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_warthog.warthog), "warthog_g", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_warthog_gauss.warthog), "warthog_p", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_warthog_gauss.warthog), "warthog_g", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre), "spectre_p_l", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre), "spectre_p_r", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre), "spectre_g", players()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [ScriptMethod(165, Lifecycle.CommandScript)]
        public async Task cov_def_spec_tele_a()
        {
            cs_teleport(GetReference<ISpatialPoint>("bsp_swap_teleport/a"), GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task cov_def_spec_tele_b()
        {
            cs_teleport(GetReference<ISpatialPoint>("bsp_swap_teleport/b"), GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task cov_def_spec_tele_c()
        {
            cs_teleport(GetReference<ISpatialPoint>("bsp_swap_teleport/c"), GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(168, Lifecycle.CommandScript)]
        public async Task cov_def_spec_tele_d()
        {
            cs_teleport(GetReference<ISpatialPoint>("bsp_swap_teleport/d"), GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(169, Lifecycle.CommandScript)]
        public async Task cs_fact_ent_exit_veh()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_nearest(GetReference<ISpatialPoint>("crashed_fact_ent"));
            cs_enable_targeting(true);
            cs_shoot(true);
            ai_set_orders(covenant1, cov_follow_factory1);
            await sleep(30);
            ai_vehicle_exit(covenant1);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task ext_a_vehicle_orders()
        {
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant1, cov_drive_cov_def);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_cov_def);
                }

                return (short)structure_bsp_index() == 1;
            });
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    if ((short)structure_bsp_index() == 0)
                    {
                        ai_set_orders(covenant_infantry, cov_follow_cov_def);
                        ai_set_orders(covenant_vehicles, cov_drive_cov_def);
                    }
                    else if ((short)structure_bsp_index() == 1)
                    {
                        ai_set_orders(covenant_infantry, cov_follow_veh_int);
                        ai_set_orders(covenant_vehicles, cov_drive_veh_int_a);
                    }
                }
                else if (true)
                {
                    if ((short)structure_bsp_index() == 0)
                    {
                        ai_set_orders(covenant1, cov_follow_cov_def);
                    }
                    else if ((short)structure_bsp_index() == 1)
                    {
                        ai_set_orders(covenant1, cov_follow_veh_int);
                    }
                }

                return volume_test_objects(tv_veh_int_a, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_veh_int_a, players()) && (short)ai_living_count(veh_int_sen_a) <= 0 || this.g_veh_int_migrate_b;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    if ((short)structure_bsp_index() == 0)
                    {
                        ai_set_orders(covenant_infantry, cov_follow_cov_def);
                        ai_set_orders(covenant_vehicles, cov_drive_cov_def);
                    }
                    else if ((short)structure_bsp_index() == 1)
                    {
                        ai_set_orders(covenant_infantry, cov_follow_veh_int);
                        ai_set_orders(covenant_vehicles, cov_drive_veh_int_b);
                    }
                }
                else if (true)
                {
                    if ((short)structure_bsp_index() == 0)
                    {
                        ai_set_orders(covenant1, cov_follow_cov_def);
                    }
                    else if ((short)structure_bsp_index() == 1)
                    {
                        ai_set_orders(covenant1, cov_follow_veh_int);
                    }
                }

                return volume_test_objects(tv_veh_int_b, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_veh_int_b, players()) && (short)ai_living_count(veh_int_sen_b) <= 0 && (short)ai_living_count(veh_int_flood_b) <= 0 || this.g_veh_int_migrate_c;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_veh_int);
                    ai_set_orders(covenant_vehicles, cov_drive_veh_int_c);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_veh_int);
                }

                return volume_test_objects(tv_veh_int_c, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_veh_int_c, players()) && (short)ai_living_count(veh_int_sen_c) <= 0 && (short)ai_living_count(veh_int_flood_c) <= 0 || this.g_veh_int_migrate_d;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_veh_int);
                    ai_set_orders(covenant_vehicles, cov_drive_veh_int_d);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_veh_int);
                }

                return volume_test_objects(tv_veh_int_d, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_veh_int_d, players()) && (short)ai_living_count(veh_int_sen_d) <= 0 && (short)ai_living_count(veh_int_flood_d) <= 0 || this.g_veh_int_migrate_e;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_veh_int);
                    ai_set_orders(covenant_vehicles, cov_drive_veh_int_e);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_veh_int);
                }

                return volume_test_objects(tv_qz_ext_a, players()) || this.g_ext_a_dam_migrate_a;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a_dam);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_dam_a);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a_dam);
                }

                return volume_test_objects(tv_ext_a_dam_a, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_ext_a_dam_a, players()) && (short)ai_living_count(ext_a_sen_dam_a) <= 0 && (short)ai_living_count(ext_a_flood_dam_a) <= 0 || this.g_ext_a_dam_migrate_b;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a_dam);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_dam_b);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a_dam);
                }

                return volume_test_objects(qz_ext_a_dam_b, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(qz_ext_a_dam_b, players()) && (short)ai_living_count(ext_a_sen_dam_b) <= 0 && (short)ai_living_count(ext_a_flood_dam_b) <= 0 || this.g_ext_a_migrate_a;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_a);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return volume_test_objects(tv_ext_a_a, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_ext_a_a, players()) && (short)ai_living_count(ext_a_sen_a) <= 0 && (short)ai_living_count(ext_a_flood_a) <= 0 || this.g_ext_a_migrate_b;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_b);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return volume_test_objects(tv_ext_a_b, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_ext_a_b, players()) && (short)ai_living_count(ext_a_sen_b) <= 0 && (short)ai_living_count(ext_a_flood_b) <= 0 || this.g_ext_a_migrate_c;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_c);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return volume_test_objects(tv_ext_a_c, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_ext_a_c, players()) && (short)ai_living_count(ext_a_sen_c) <= 0 && (short)ai_living_count(ext_a_flood_c) <= 0 || this.g_ext_a_migrate_d;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_d);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return volume_test_objects(tv_ext_a_d, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_ext_a_d, players()) && (short)ai_living_count(ext_a_sen_d) <= 0 && (short)ai_living_count(ext_a_flood_d) <= 0 || this.g_ext_a_migrate_e;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_e);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return volume_test_objects(tv_ext_a_e, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_ext_a_e, players()) && (short)ai_living_count(ext_a_sen_e) <= 0 && (short)ai_living_count(ext_a_flood_e) <= 0 || this.g_ext_a_migrate_f;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a_fact_ent);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_a_f);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a_fact_ent);
                }

                return volume_test_objects(tv_ext_a_f, players()) && (bool)ai_trigger_test("done_fighting", covenant1) || volume_test_objects(tv_ext_a_f, players()) && (short)ai_living_count(ext_a_sen_f) <= 0 && (short)ai_living_count(ext_a_flood_f) <= 0 || this.g_ext_a_fact_ent_migrate;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_a_fact_ent);
                    ai_set_orders(covenant_vehicles, cov_drive_fact_ent);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_a_fact_ent);
                }

                return (bool)ai_trigger_test("done_fighting", covenant1) && this.g_fact_ent_sen_spawn || (short)ai_living_count(fact_ent_sentinels) <= 0 && (short)ai_living_count(fact_ent_flood) <= 0 && this.g_fact_ent_sen_spawn || volume_test_objects(tv_fact_ent_follow, players());
            });
            await sleep(this.g_order_delay);
            cs_run_command_script(covenant1, new ScriptMethodReference(cs_fact_ent_exit_veh));
        }

        [ScriptMethod(171, Lifecycle.CommandScript)]
        public async Task cs_ext_b_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_nearest(GetReference<ISpatialPoint>("ext_b_exit"));
            cs_enable_targeting(true);
            cs_shoot(true);
            ai_set_orders(covenant1, cov_ext_b_exit);
            await sleep(30);
            ai_vehicle_exit(covenant1);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task ext_b_vehicle_orders()
        {
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_b_a);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_b);
                }

                ai_magically_see(covenant1, ext_b_flood);
                return this.g_ext_b_migrate_1;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_b_b);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_b);
                }

                ai_magically_see(covenant1, ext_b_flood);
                return this.g_ext_b_migrate_2;
            });
            await sleep((short)(this.g_order_delay * 3));
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_b_b);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_b);
                }

                ai_magically_see(covenant1, ext_b_flood);
                return (short)ai_living_count(ext_b_flood_b) <= 0 && (short)ai_living_count(ext_b_sentinels_b) <= 0 || this.g_ext_b_migrate_3;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_b_c);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_b_bk);
                }

                ai_magically_see(covenant1, ext_b_flood);
                return (short)ai_living_count(ext_b_flood_c) <= 0 && (short)ai_living_count(ext_b_sentinels_c) <= 0 || this.g_ext_b_migrate_4;
            });
            await sleep(this.g_order_delay);
            await sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        print("player is passenger");
                    }

                    ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    ai_set_orders(covenant_vehicles, cov_drive_ext_b_d);
                }
                else if (true)
                {
                    ai_set_orders(covenant1, cov_follow_ext_b_bk);
                }

                ai_magically_see(covenant1, ext_b_flood);
                return this.g_ext_b_migrate_5;
            });
            await sleep((short)(this.g_order_delay * 3));
            cs_run_command_script(covenant1, new ScriptMethodReference(cs_ext_b_exit));
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            ai_migrate(covenant1, key_cov_dump.Squad);
            await sleep(5);
            ai_teleport_to_starting_location_if_outside_bsp(key_cov_dump.Squad);
            await sleep(5);
            ai_set_orders(covenant1, cov_follow_key_ent);
        }

        [ScriptMethod(173, Lifecycle.CommandScript)]
        public async Task cs_cov_def_phantom()
        {
            cs_fly_to(GetReference<ISpatialPoint>("qz_cov_def/drop"));
            await sleep_until(async () => this.g_qz_cov_def_progress);
            cs_vehicle_speed(0.85F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("qz_cov_def/p4"), GetReference<ISpatialPoint>("qz_cov_def/p1"), 3F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_cov_def/p1"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_cov_def/p2"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_cov_def/p3"), 10F);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(174, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_a()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_look_player(true);
            await sleep_until(async () => this.g_qz_cov_def_progress, 5);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.a));
        }

        [ScriptMethod(175, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_b()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_look_player(true);
            await sleep_until(async () => this.g_qz_cov_def_progress, 5);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.b));
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_c()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_look_player(true);
            await sleep_until(async () => this.g_qz_cov_def_progress, 5);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre));
        }

        [ScriptMethod(177, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_d()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_look_player(true);
            await sleep_until(async () => this.g_qz_cov_def_progress, 5);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre));
        }

        [ScriptMethod(178, Lifecycle.CommandScript)]
        public async Task cs_go_to_scorpion()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(veh_int_scorpion1.scorpion));
        }

        [ScriptMethod(179, Lifecycle.CommandScript)]
        public async Task cs_go_to_wraith()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(veh_int_wraith1.wraith));
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task ai_veh_int_ghost_spawn()
        {
            await sleep_until(async () => (short)ai_living_count(veh_int_flood_ghosts_ini.Squad) <= 0);
            if (this.debug)
            {
                print("waking vehicle interior ghost spawner");
            }

            if (await this.difficulty_normal())
            {
                this.g_veh_int_ghost_limit = 6;
                this.g_veh_int_ghost_number = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_veh_int_ghost_limit = 8;
                this.g_veh_int_ghost_number = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_veh_int_ghost_limit = 10;
                this.g_veh_int_ghost_number = 3;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(veh_int_flood_ghosts_bk.Squad) <= 0);
                await sleep(90);
                if (this.debug)
                {
                    print("placing ghosts");
                }

                ai_place(veh_int_flood_ghosts_bk.Squad, this.g_veh_int_ghost_number);
                return (short)ai_spawn_count(veh_int_flood_ghosts_bk.Squad) >= this.g_veh_int_ghost_limit || this.g_veh_int_ghost_spawn;
            });
            if ((short)ai_living_count(veh_int_flood_ghosts_bk.Squad) <= 0)
            {
                ai_place(veh_int_flood_ghosts_bk.Squad);
            }
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task dam_door_a()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(tv_dam_door_a, players()), 5);
                device_set_position(dam_door_a1.Entity, 1F);
                return false;
            });
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task dam_door_b()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(tv_dam_door_b, players()), 5);
                device_set_position(dam_door_b1.Entity, 1F);
                return false;
            });
        }

        [ScriptMethod(183, Lifecycle.CommandScript)]
        public async Task cs_ext_a_enf_ini()
        {
            cs_shoot(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_enf/p0"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_enf/p1"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_enf/p2"), 3F);
            cs_vehicle_boost(false);
        }

        [ScriptMethod(184, Lifecycle.CommandScript)]
        public async Task cs_ext_a_pelican()
        {
            cs_shoot(false);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(qz_ext_a_dam_human.pelican), "pelican_lc", ai_vehicle_get_from_starting_location(qz_ext_a_dam_human.scorpion));
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_pelican/p0"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_pelican/p2"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_pelican/p3"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_pelican/p5"), 3F);
            await sleep(30);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(185, Lifecycle.CommandScript)]
        public async Task cs_boost_1_5()
        {
            cs_vehicle_boost(true);
            await sleep((short)(30 * 2));
            cs_vehicle_boost(false);
        }

        [ScriptMethod(186, Lifecycle.CommandScript)]
        public async Task cs_ext_a_phantom()
        {
            ai_place(qz_ext_a_spec_ops1.Squad);
            ai_place(qz_ext_a_ghosts1.Squad);
            cs_shoot(true);
            cs_enable_pathfinding_failsafe(true);
            await sleep(1);
            vehicle_load_magic(this.v_ext_a_phantom, "phantom_p", ai_actors(qz_ext_a_spec_ops1.Squad));
            vehicle_load_magic(this.v_ext_a_phantom, "phantom_sc01", ai_vehicle_get_from_starting_location(qz_ext_a_ghosts1.a));
            vehicle_load_magic(this.v_ext_a_phantom, "phantom_sc02", ai_vehicle_get_from_starting_location(qz_ext_a_ghosts1.b));
            await sleep(1);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_phantom/p0"), 5F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_phantom/p1"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_phantom/p2"), 4F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("qz_ext_a_phantom/p3"), GetReference<ISpatialPoint>("qz_ext_a_phantom/unit_face"));
            cs_vehicle_speed(0.75F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("qz_ext_a_phantom/drop_units"), GetReference<ISpatialPoint>("qz_ext_a_phantom/unit_face"), 2F);
            object_set_phantom_power(this.v_ext_a_phantom, true);
            await sleep(45);
            vehicle_unload(this.v_ext_a_phantom, "phantom_p_a01");
            await sleep(30);
            vehicle_unload(this.v_ext_a_phantom, "phantom_p_a02");
            await sleep(30);
            vehicle_unload(this.v_ext_a_phantom, "phantom_p_a03");
            await sleep(45);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("qz_ext_a_phantom/drop_ghosts"), GetReference<ISpatialPoint>("qz_ext_a_phantom/face"), 2F);
            await sleep_until(async () => !(volume_test_objects_all(tv_qz_ext_a_ghost_drop, players())));
            await sleep(45);
            vehicle_unload(this.v_ext_a_phantom, "phantom_sc");
            await sleep(90);
            object_set_phantom_power(this.v_ext_a_phantom, false);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_phantom/p6"));
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_phantom/p4"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_a_phantom/p7"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(187, Lifecycle.CommandScript)]
        public async Task cs_wraiths_shoot()
        {
            cs_abort_on_damage(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p0")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p1")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p2")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p3")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p4")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p5")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p6")), 
                    async () => await sleep((short)random_range(30, 60)), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("qz_ext_a_wraiths/p7")), 
                    async () => await sleep((short)random_range(30, 60)));
                return this.g_qz_ext_a_wraith_shoot;
            });
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task ai_ext_a_dam_enforcers()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(ext_a_sen_dam_b) <= 0);
                await sleep(90);
                ai_place(qz_ext_a_dam_enf_door.Squad);
                return (short)ai_spawn_count(qz_ext_a_dam_enf_door.Squad) >= 3 || this.g_ext_a_dam_enf;
            });
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task ai_qz_ext_a_wraiths()
        {
            ai_place(qz_ext_a_flood_wraith_fr1.Squad);
            ai_place(qz_ext_a_flood_wraith_bk.Squad);
            ai_place(qz_ext_a_flood_wraith_ledge.Squad);
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task ai_qz_ext_a_ghosts()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(qz_ext_a_flood_ghosts.Squad) <= 0);
                if (this.g_qz_ext_a_flood_ghosts)
                {
                    sleep_forever();
                }

                await sleep((short)random_range(60, 120));
                ai_place(qz_ext_a_flood_ghosts.Squad);
                return this.g_qz_ext_a_flood_ghosts;
            });
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task ai_fact_ent_sen_spawn()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(fact_ent_sen1.Squad) <= 1);
                await sleep((short)random_range(15, 30));
                ai_place(fact_ent_sen1.Squad);
                this.g_fact_ent_sen_count = (short)(this.g_fact_ent_sen_count + 1);
                if (this.g_fact_ent_sen_count == this.g_fact_ent_sen_index)
                {
                    this.g_fact_ent_sen_spawn = true;
                }

                return this.g_fact_ent_sen_spawn;
            });
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task ai_fact_ent_enf_spawn()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(fact_ent_enf1.Squad) <= 0);
                await sleep((short)random_range(30, 60));
                ai_place(fact_ent_enf1.Squad);
                this.g_fact_ent_enf_count = (short)(this.g_fact_ent_enf_count + 1);
                if (this.g_fact_ent_enf_count == this.g_fact_ent_enf_index)
                {
                    this.g_fact_ent_sen_spawn = true;
                }

                return this.g_fact_ent_sen_spawn;
            });
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task ai_qz_ext_a_d_spawn()
        {
            await sleep_until(async () => volume_test_objects(tv_ext_a_d, players()));
            if (this.g_qz_ext_a_d_spawn)
            {
                ai_place(qz_ext_a_flood_d1.Squad);
                ai_place(qz_ext_a_enf_bk1.Squad);
            }
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task factory_1_flood_respawn()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_factory_1_mid_03, players()) == true || (short)ai_nonswarm_count(factory1_flood) < 3);
                if (volume_test_objects(vol_factory_1_mid_03, players()) == false)
                {
                    ai_place(factory_1_flood_end.Squad, 1);
                }
                else
                {
                    await sleep(60);
                }

                return volume_test_objects(vol_factory_1_mid_03, players()) == true || (short)ai_spawn_count(factory_1_flood_end.Squad) >= 10;
            });
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task factory_1_sentinel_respawn_01()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_factory_1_mid_01, players()) == true || (short)ai_living_count(factory1_sentinels) < 2);
                if (volume_test_objects(vol_factory_1_mid_01, players()) == false)
                {
                    ai_place(factory_1_sentinels_01_low.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                if (volume_test_objects(vol_factory_1_mid_01, players()) == false)
                {
                    ai_place(factory_1_sentinels_01_high.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                return volume_test_objects(vol_factory_1_mid_01, players()) == true || (float)ai_spawn_count(factory_1_sentinels_01_low.Squad) + (float)ai_spawn_count(factory_1_sentinels_01_high.Squad) >= 3F;
            });
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task factory_1_sentinel_respawn_02()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_factory_1_mid_02, players()) == true || (short)ai_living_count(factory1_sentinels) < 2);
                if (volume_test_objects(vol_factory_1_mid_02, players()) == false)
                {
                    ai_place(factory_1_sentinels_02_low.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                if (volume_test_objects(vol_factory_1_mid_02, players()) == false)
                {
                    ai_place(factory_1_sentinels_02_high.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                return volume_test_objects(vol_factory_1_mid_02, players()) == true || (float)ai_spawn_count(factory_1_sentinels_02_low.Squad) + (float)ai_spawn_count(factory_1_sentinels_02_high.Squad) >= 6F;
            });
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task factory_1_sentinel_enders()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_factory_1_mid_03, players()) == true || (short)ai_living_count(factory1_sentinels) < 2);
                if (volume_test_objects(vol_factory_1_mid_03, players()) == false)
                {
                    ai_place(factory_1_sentinels_03_low.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                if (volume_test_objects(vol_factory_1_mid_03, players()) == false)
                {
                    ai_place(factory_1_sentinels_03_high.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                return volume_test_objects(vol_factory_1_mid_03, players()) == true || (float)ai_spawn_count(factory_1_sentinels_03_low.Squad) + (float)ai_spawn_count(factory_1_sentinels_03_high.Squad) >= 6F;
            });
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task factory_1_flood_surge()
        {
            await sleep_until(async () => (short)ai_living_count(factory_1_major.Squad) == 0);
            sleep_forever(new ScriptMethodReference(factory_1_flood_respawn));
            ai_set_orders(factory1_flood, factory_1_flood_tubes_fwd);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_factory_1_mid_03, players()) == true || (short)ai_nonswarm_count(factory1_flood) < 3);
                if (volume_test_objects(vol_factory_1_mid_03, players()) == false)
                {
                    ai_place(factory_1_flood_end.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                if (volume_test_objects(vol_factory_1_mid_03, players()) == false)
                {
                    ai_place(factory_1_flood_tubes_far.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                if (volume_test_objects(vol_factory_1_mid_03, players()) == false)
                {
                    ai_place(factory_1_flood_tubes_near.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                if (volume_test_objects(vol_factory_1_mid_03, players()) == false)
                {
                    ai_place(factory_1_flood_alcove.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                return volume_test_objects(vol_factory_1_mid_03, players()) == true || (float)ai_spawn_count(factory_1_flood_end.Squad) + (float)ai_spawn_count(factory_1_flood_tubes_far.Squad) + (float)ai_spawn_count(factory_1_flood_tubes_near.Squad) + (float)ai_spawn_count(factory_1_flood_alcove.Squad) >= 10F;
            });
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_factory_1_exit, players()) == true || (short)ai_nonswarm_count(factory1_flood) < 2);
                if (volume_test_objects(vol_factory_1_exit, players()) == false)
                {
                    ai_place(factory_1_flood_end.Squad, 1);
                }
                else
                {
                    await sleep(120);
                }

                return volume_test_objects(vol_factory_1_exit, players()) == true || (short)ai_spawn_count(factory_1_flood_end.Squad) >= 8;
            });
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task sent_factory_1_start()
        {
            await sleep_until(async () => volume_test_objects(vol_factory_1_enter, players()) == true);
            game_save();
            ai_place(factory_1_sentinels_intro.Squad);
            ai_place(factory_1_flood_intro.Squad);
            ai_place(factory_1_major.Squad);
            ai_place(factory_1_sentinels_initial_mid.Squad);
            ai_place(factory_1_flood_initial_mid.Squad);
            wake(new ScriptMethodReference(factory_1_flood_surge));
            wake(new ScriptMethodReference(factory_1_flood_respawn));
            wake(new ScriptMethodReference(factory_1_sentinel_respawn_01));
            wake(new ScriptMethodReference(factory_1_sentinel_enders));
            await sleep_until(async () => volume_test_objects(vol_factory_1_mid_01, players()) == true || (short)ai_nonswarm_count(factory1_enemies) < 8);
            game_save_no_timeout();
            ai_place(factory_1_sentinels_initial_end.Squad);
            ai_place(factory_1_flood_initial_end.Squad);
            await sleep_until(async () => volume_test_objects(vol_factory_1_mid_01, players()) == true);
            game_save();
            sleep_forever(new ScriptMethodReference(factory_1_sentinel_respawn_01));
            wake(new ScriptMethodReference(factory_1_sentinel_respawn_02));
            ai_renew(covenant1);
            await sleep_until(async () => volume_test_objects(vol_factory_1_mid_02, players()) == true);
            game_save();
            sleep_forever(new ScriptMethodReference(factory_1_sentinel_respawn_02));
            await sleep_until(async () => volume_test_objects(vol_factory_1_mid_03, players()) == true);
            game_save();
            sleep_forever(new ScriptMethodReference(factory_1_sentinel_enders));
            sleep_forever(new ScriptMethodReference(factory_1_flood_respawn));
            await sleep_until(async () => volume_test_objects(vol_factory_1_exit, players()) == true);
            game_save();
            if ((short)ai_living_count(factory_1_major.Squad) == 1)
            {
                sleep_forever(new ScriptMethodReference(factory_1_flood_surge));
            }
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task ai_sentinel_spawn()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(gorge_sen1.Squad) <= 0);
                await sleep(150);
                ai_place(gorge_sen1.Squad);
                return this.g_gorge_sen_spawn;
            });
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task ai_gorge()
        {
            ai_place(gorge_flood_ini1.Squad);
            ai_place(gorge_enf1.Squad);
            wake(new ScriptMethodReference(ai_sentinel_spawn));
            await sleep_until(async () => volume_test_objects(tv_gorge_mid, players()));
            game_save_no_timeout();
            ai_place(gorge_flood_bk1.Squad);
            await sleep_until(async () => volume_test_objects(tv_gorge_bk_cave, players()));
            ai_place(gorge_flood_bk_cave.Squad);
            this.g_gorge_sen_spawn = true;
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task ai_factory2()
        {
            ai_place(factory2_flood_ini1.Squad);
            await sleep_until(async () => volume_test_objects(tv_factory2_mid, players()));
            game_save_no_timeout();
            if ((short)ai_living_count(factory2_flood) <= 4)
            {
                ai_place(factory2_flood_mid1.Squad);
                ai_place(factory2_flood_bk1.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_factory2_bk, players()));
            game_save();
            ai_place(factory2_flood_bk_tunnel.Squad);
            ai_place(factory2_sen_bk_tunnel.Squad);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task ai_constructor_flock()
        {
            flock_start("constructor_swarm");
            await sleep(150);
            flock_stop("constructor_swarm");
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_ext_b_phantom()
        {
            cs_shoot(true);
            cs_enable_pathfinding_failsafe(true);
            ai_place(qz_ext_b_cov_spec_ops.Squad);
            ai_place(qz_ext_b_cov_spectre.Squad);
            object_cannot_die(ai_get_object(qz_ext_b_cov_spec_ops.soc), true);
            await sleep(1);
            vehicle_load_magic(this.v_ext_b_phantom, "phantom_p", ai_actors(qz_ext_b_cov_spec_ops.Squad));
            vehicle_load_magic(this.v_ext_b_phantom, "phantom_sc01", ai_vehicle_get_from_starting_location(qz_ext_b_cov_ghosts.a));
            vehicle_load_magic(this.v_ext_b_phantom, "phantom_sc02", ai_vehicle_get_from_starting_location(qz_ext_b_cov_ghosts.b));
            vehicle_load_magic(this.v_ext_b_phantom, "phantom_lc", ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre));
            await sleep(1);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_phantom/p0"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_phantom/p1"), 5F);
            cs_vehicle_boost(false);
            ai_magically_see(qz_ext_b_wraith_a1.Squad, qz_ext_b_cov_phantom.Squad);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_phantom/p3"), 3F);
            cs_fly_to(GetReference<ISpatialPoint>("qz_ext_b_phantom/p4"));
            cs_face(true, GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"));
            cs_vehicle_speed(0.65F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("qz_ext_b_phantom/drop"), GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"));
            object_set_phantom_power(this.v_ext_b_phantom, true);
            await sleep(45);
            vehicle_unload(this.v_ext_b_phantom, "phantom_sc");
            vehicle_unload(this.v_ext_b_phantom, "phantom_lc");
            await sleep(45);
            vehicle_unload(this.v_ext_b_phantom, "phantom_p_a01");
            await sleep(30);
            vehicle_unload(this.v_ext_b_phantom, "phantom_p_a02");
            await sleep(30);
            vehicle_unload(this.v_ext_b_phantom, "phantom_p_a03");
            await sleep(45);
            object_set_phantom_power(this.v_ext_b_phantom, false);
            ai_vehicle_enter(qz_ext_b_cov_spec_ops.Squad, ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre));
            cs_face(false, GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"));
            cs_vehicle_speed(1F);
            await sleep(60);
            wake(new ScriptMethodReference(sc_ext_b));
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_phantom/p1"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_phantom/p0"), 3F);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_ext_b_ent_phantom()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p0"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p1"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p2"), 5F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p3"));
            cs_face(true, GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p5"));
            cs_vehicle_speed(0.65F);
            cs_fly_to(GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/drop"));
            await sleep_until(async () => this.g_ext_b_ent_phantom);
            cs_face(false, GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p5"));
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p5"), 3F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p6"), 3F);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task ai_ext_b_exit_tube_a()
        {
            await sleep_until(async () => volume_test_objects(tv_ext_b_exit_tube_a, players()));
            ai_place(qz_ext_b_ent_flood_tube_a.Squad, (short)pin(8F - (float)ai_nonswarm_count(ext_b_flood), 0F, 6F));
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task ai_ext_b_exit_tube_b()
        {
            await sleep_until(async () => volume_test_objects(tv_ext_b_exit_tube_b, players()));
            ai_place(qz_ext_b_ent_flood_tube_b.Squad, (short)pin(8F - (float)ai_nonswarm_count(ext_b_flood), 0F, 6F));
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task ai_ext_b_enf_spawn()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(ext_b_sentinels_b) <= 0);
                if (volume_test_objects(tv_ext_b_mid, players()))
                {
                    ai_place(qz_ext_b_enf_b1.Squad);
                }
                else if (true)
                {
                    ai_place(qz_ext_b_enf_a1.Squad);
                }

                return (short)ai_spawn_count(ext_b_sentinels_b) >= 4 || this.g_ext_b_enforcer;
            });
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task ai_ext_b_bk_ghost_spawn()
        {
            if (await this.difficulty_normal())
            {
                this.g_ext_b_bk_ghost_limit = 6;
                this.g_ext_b_bk_ghost_number = 1;
            }
            else if (await this.difficulty_heroic())
            {
                this.g_ext_b_bk_ghost_limit = 8;
                this.g_ext_b_bk_ghost_number = 2;
            }
            else if (await this.difficulty_legendary())
            {
                this.g_ext_b_bk_ghost_limit = 10;
                this.g_ext_b_bk_ghost_number = 3;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(qz_ext_b_ent_ghost_bk.Squad) <= 0);
                await sleep(90);
                if (this.debug)
                {
                    print("placing ghosts");
                }

                ai_place(qz_ext_b_ent_ghost_bk.Squad, this.g_ext_b_bk_ghost_number);
                return (short)ai_spawn_count(qz_ext_b_ent_ghost_bk.Squad) >= this.g_ext_b_bk_ghost_limit || this.g_ext_b_bk_ghost_spawn;
            });
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task key_ride_door3_main()
        {
            print("key_ride_door3 begins to open");
            device_set_position(key_ride_door3.Entity, 1F);
            await sleep_until(async () => device_get_position(key_ride_door3.Entity) >= 0.9F, 10);
            await sleep(60);
            print("key_ride_door3 begins to close");
            device_set_position(key_ride_door3.Entity, 0F);
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task key_ride_human_door2_main()
        {
            print("human_key_door2 begins to open");
            device_set_position(human_key_door2.Entity, 1F);
            await sleep_until(async () => device_get_position(human_key_door2.Entity) >= 0.9F, 10);
            print("human_key_door2 begins to close");
            device_set_position(human_key_door2.Entity, 0F);
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task key_ride_door2_main()
        {
            print("key_ride_door2 begins to open");
            device_set_position(key_ride_door2.Entity, 1F);
            await sleep_until(async () => device_get_position(key_ride_door2.Entity) >= 0.9F, 10);
            print("key_ride_door2 begins to close");
            device_set_position(key_ride_door2.Entity, 0F);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task key_ride_door1_main()
        {
            print("key_ride_door1 begins to open");
            device_set_position(key_ride_door1.Entity, 1F);
            await sleep_until(async () => device_get_position(key_ride_door1.Entity) >= 0.9F, 10);
            await sleep(60);
            print("key_ride_door1 begins to close");
            device_set_position(key_ride_door1.Entity, 0F);
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task key_ride_door0_main()
        {
            print("key_ride_door0 begins to open");
            device_set_position_immediate(key_ride_door0.Entity, 0.32F);
            device_closes_automatically_set(key_ride_door0.Entity, false);
            device_set_position(key_ride_door0.Entity, 1F);
            sleep_forever();
            await sleep_until(async () => device_get_position(key_ride_door0.Entity) >= 0.9F, 10);
            await sleep(540);
            print("key_ride_door0 begins to close");
            device_set_position(key_ride_door0.Entity, 0F);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task key_main()
        {
            wake(new ScriptMethodReference(key_ride_door0_main));
            pvs_set_object(key.Entity);
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 2193498412U), default(IGameObject), 1F);
            device_set_position_track(key.Entity, "track_horiz0", 0F);
            device_animate_position(key.Entity, 0.3F, 0F, 0F, 0F, false);
            await sleep(5);
            object_teleport(await this.player0(), key_ent0);
            object_teleport(await this.player1(), key_ent1);
            await sleep(5);
            device_animate_position(key.Entity, 0.6F, 75F, 0F, 0F, false);
            this.g_key_started = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.35F, 3);
            wake(new ScriptMethodReference(key_ride_door0_main));
            await sleep_until(async () => device_get_position(key.Entity) >= 0.4F, 3);
            this.g_key_lock0_first_loadpoint = true;
            this.g_key_lock0_entered = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.43F, 3);
            this.g_key_lock0_first_loadpoint = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.48F, 3);
            switch_bsp_by_name(GetReference<IBsp>("sen_hq_bsp_6"));
            await sleep_until(async () => device_get_position(key.Entity) >= 0.5F, 3);
            this.g_key_lock0_second_loadpoint = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.5F, 3);
            this.g_key_lock0_begin_human = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.53F, 3);
            this.g_key_lock0_door1 = true;
            wake(new ScriptMethodReference(key_ride_door1_main));
            await sleep_until(async () => device_get_position(key.Entity) >= 0.58F, 3);
            this.g_key_cruise_entered = true;
            device_animate_position(key.Entity, 1F, 45F, 5F, 10F, true);
            await sleep_until(async () => device_get_position(key.Entity) >= 0.67F, 3);
            this.g_key_cruise_first_loadpoint = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.84F, 3);
            this.g_key_cruise_halfway = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 1F, 3);
            this.g_key_shaft_entered = true;
            await sleep(30);
            device_set_position_track(key.Entity, "track_rise", 0F);
            device_set_overlay_track(key.Entity, "overlay_transform");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 2193498412U), true);
            device_animate_overlay(key.Entity, 1F, 5F, 0F, 0F);
            await sleep(180);
            device_animate_position(key.Entity, 1F, 90F, 20F, 10F, false);
            this.g_key_shaft_rising = true;
            this.g_music_06b_06 = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.3F, 3);
            this.g_key_shaft_near_exterior = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.73F, 3);
            wake(new ScriptMethodReference(key_ride_door2_main));
            await sleep_until(async () => device_get_position(key.Entity) >= 1F, 3);
            this.g_key_lock1_entered = true;
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 2193498412U));
            await sleep(30);
            device_set_position_track(key.Entity, "track_horiz1", 0F);
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 2193498412U), default(IGameObject), 1F);
            device_animate_overlay(key.Entity, 0F, 5F, 0F, 0F);
            await sleep(180);
            device_animate_position(key.Entity, 1F, 75F, 10F, 10F, false);
            await sleep_until(async () => device_get_position(key.Entity) >= 0.15F, 3);
            this.g_key_lock1_first_arch = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.4F, 3);
            this.g_key_lock1_second_arch = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.49F, 3);
            wake(new ScriptMethodReference(key_ride_door3_main));
            await sleep_until(async () => device_get_position(key.Entity) >= 0.65F, 3);
            this.g_key_library_entered = true;
            await sleep_until(async () => device_get_position(key.Entity) >= 0.85F, 3);
            device_animate_overlay(key.Entity, 1F, 5F, 0F, 0F);
            await sleep_until(async () => device_get_position(key.Entity) >= 1F, 3);
            this.g_key_library_arrival = true;
            wake(new ScriptMethodReference(chapter_familiar));
            wake(new ScriptMethodReference(sc_dock));
            this.g_music_06b_05 = false;
            sound_looping_stop(GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 2193498412U));
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task key_ride_human_key_main()
        {
            await sleep_until(async () => this.g_key_lock0_begin_human, 10);
            object_create_anew(key_human);
            pvs_set_object(key_human.Entity);
            device_set_position_track(key_human.Entity, "track_horiz0", 0F);
            device_animate_position(key_human.Entity, 0.58F, 0.5F, 0F, 0F, false);
            await sleep(15);
            device_animate_position(key_human.Entity, 1F, 55F, 5F, 10F, false);
            await sleep_until(async () => device_get_position(key_human.Entity) >= 1F, 3);
            await sleep(30);
            device_set_position_track(key_human.Entity, "track_rise", 0F);
            device_set_overlay_track(key_human.Entity, "overlay_transform");
            device_animate_overlay(key_human.Entity, 1F, 5F, 0F, 0F);
            await sleep(180);
            device_animate_position(key_human.Entity, 1F, 80F, 20F, 10F, false);
            await sleep_until(async () => device_get_position(key_human.Entity) >= 0.71F, 3);
            wake(new ScriptMethodReference(key_ride_human_door2_main));
            await sleep_until(async () => device_get_position(key_human.Entity) >= 1F, 3);
            await sleep(120);
            device_set_position_track(key_human.Entity, "track_horiz1", 0F);
            device_animate_overlay(key_human.Entity, 0F, 5F, 0F, 0F);
            await sleep(180);
            device_animate_position(key_human.Entity, 1F, 75F, 10F, 10F, false);
            await sleep_until(async () => device_get_position(key_human.Entity) >= 0.191F, 3);
            object_destroy(key_human.Entity);
            object_create_anew(key_docked);
            await sleep(1);
            device_set_overlay_track(key_docked.Entity, "overlay_transform");
            device_animate_overlay(key_docked.Entity, 1F, 0.1F, 0F, 0F);
        }

        [ScriptMethod(217, Lifecycle.CommandScript)]
        public async Task cs_e21_tartarus()
        {
            cs_enable_pathfinding_failsafe(true);
            print("e21 *tartarus returns from harassing human key*");
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e21_tartarus/p0"));
            cs_vehicle_boost(false);
            print("e21 *tartarus follows the key in through the door*");
            cs_fly_by(GetReference<ISpatialPoint>("e21_tartarus/p1"));
            cs_vehicle_speed(0.75F);
            cs_enable_pathfinding_failsafe(false);
            await sleep_until(async () =>
            {
                cs_fly_by(GetReference<ISpatialPoint>("key_bsp5/left"));
                return false;
            }, 3, 300);
            cs_vehicle_speed(0.85F);
            cs_face(true, GetReference<ISpatialPoint>("e22_tartarus_bsp6/forward_facing"));
            await sleep_until(async () =>
            {
                cs_fly_by(GetReference<ISpatialPoint>("key_bsp5/center"));
                return false;
            }, 3, 300);
        }

        [ScriptMethod(218, Lifecycle.CommandScript)]
        public async Task cs_e22_tartarus()
        {
            cs_face(false, GetReference<ISpatialPoint>("e22_tartarus_bsp6/forward_facing"));
            cs_fly_by(GetReference<ISpatialPoint>("e22_tartarus/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e22_tartarus/p1"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e22_tartarus/p2"));
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e22_tartarus/p3"), 1F);
            await sleep(50);
            cs_face(true, GetReference<ISpatialPoint>("e22_tartarus_bsp6/forward_facing"));
            cs_vehicle_speed(0.9F);
            cs_fly_by(GetReference<ISpatialPoint>("key_bsp6/center_front"));
            cs_vehicle_speed(0.9F);
            await sleep_until(async () =>
            {
                cs_fly_by(GetReference<ISpatialPoint>("key_bsp6/center_front"), 1F);
                return false;
            }, 3);
        }

        [ScriptMethod(219, Lifecycle.CommandScript)]
        public async Task cs_e23_tartarus()
        {
            cs_vehicle_speed(1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e23_tartarus/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e23_tartarus/p1"));
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("e23_tartarus/p2"));
            cs_vehicle_speed(1F);
            await sleep_until(async () =>
            {
                cs_fly_by(GetReference<ISpatialPoint>("key_human_bsp6/left_high"), 1F);
                return false;
            }, 3, 360);
            cs_teleport(GetReference<ISpatialPoint>("e23_tartarus/teleport_dest"), GetReference<ISpatialPoint>("e23_tartarus/teleport_facing"));
            sleep_forever();
        }

        [ScriptMethod(220, Lifecycle.CommandScript)]
        public async Task cs_e24_tartarus()
        {
            await sleep(200);
            cs_vehicle_speed(0.6F);
            cs_fly_by(GetReference<ISpatialPoint>("e24_tartarus/p0"));
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("e24_tartarus/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e24_tartarus/p2"));
            sleep_forever();
        }

        [ScriptMethod(221, Lifecycle.CommandScript)]
        public async Task cs_e25_tartarus()
        {
            await sleep(120);
            cs_face(true, GetReference<ISpatialPoint>("e25_tartarus/p0"));
            await sleep(60);
            cs_face(false, GetReference<ISpatialPoint>("e25_tartarus/p0"));
            cs_vehicle_speed(0.6F);
            cs_fly_by(GetReference<ISpatialPoint>("e25_tartarus/p0"));
            cs_vehicle_speed(1F);
            cs_fly_to(GetReference<ISpatialPoint>("e25_tartarus/p1"), 1F);
            cs_face(true, GetReference<ISpatialPoint>("e25_tartarus/p1_facing"));
            await sleep(320);
            cs_face(false, GetReference<ISpatialPoint>("e25_tartarus/p1_facing"));
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("key_bsp6/center"), 1F);
            cs_vehicle_speed(0.9F);
            await sleep_until(async () =>
            {
                cs_fly_by(GetReference<ISpatialPoint>("key_bsp6/center"), 1F);
                return false;
            }, 3);
        }

        [ScriptMethod(222, Lifecycle.CommandScript)]
        public async Task cs_e26_tartarus()
        {
            cs_vehicle_speed(0.9F);
            await sleep_until(async () =>
            {
                cs_fly_by(GetReference<ISpatialPoint>("key_bsp6/center"), 1F);
                return false;
            }, 3, 210);
            cs_fly_to(GetReference<ISpatialPoint>("e26_tartarus/p0"));
            await sleep(120);
            cs_fly_by(GetReference<ISpatialPoint>("e26_tartarus/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e26_tartarus/p2"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task key_ride_tartarus_main()
        {
            ai_place(key_ride_tartarus.Squad);
            cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e21_tartarus));
            await sleep_until(async () => (short)structure_bsp_index() == 4, 10);
            cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e22_tartarus));
            await sleep_until(async () => this.g_key_cruise_entered, 10);
            cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e23_tartarus));
            await sleep_until(async () => this.g_key_shaft_near_exterior, 10);
            cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e24_tartarus));
            await sleep_until(async () => this.g_key_lock1_entered, 10);
            cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e25_tartarus));
            await sleep_until(async () => this.g_key_library_entered, 10);
            cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e26_tartarus));
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task key_ride_test()
        {
            wake(new ScriptMethodReference(key_main));
            wake(new ScriptMethodReference(key_ride_human_key_main));
            wake(new ScriptMethodReference(key_ride_tartarus_main));
        }

        [ScriptMethod(225, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry3()
        {
            cs_abort_on_damage(true);
            await sleep(30);
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(226, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry2()
        {
            cs_abort_on_damage(true);
            await sleep(30);
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p6"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p7"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(227, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry1()
        {
            cs_abort_on_damage(true);
            await sleep(30);
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p8"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p7"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(228, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry0()
        {
            cs_abort_on_damage(true);
            await sleep(30);
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p0"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p1"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            cs_go_to(GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task e26_smg1()
        {
            object_create(e26_smg11);
            await sleep_until(async () =>
            {
                weapon_hold_trigger(GetReference<IWeaponReference>("e26_smg1"), 0, true);
                await sleep_until(async () => this.g_e26_ended, 2, (int)random_range(15, 45));
                weapon_hold_trigger(GetReference<IWeaponReference>("e26_smg1"), 0, false);
                await sleep_until(async () => this.g_e26_ended, 2, (int)random_range(45, 90));
                return this.g_e26_ended;
            }, 1);
            weapon_hold_trigger(GetReference<IWeaponReference>("e26_smg1"), 0, false);
            object_destroy(e26_smg11.Entity);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task e26_smg0()
        {
            object_create(e26_smg01);
            await sleep_until(async () =>
            {
                weapon_hold_trigger(GetReference<IWeaponReference>("e26_smg0"), 0, true);
                await sleep_until(async () => this.g_e26_ended, 2, (int)random_range(15, 45));
                weapon_hold_trigger(GetReference<IWeaponReference>("e26_smg0"), 0, false);
                await sleep_until(async () => this.g_e26_ended, 2, (int)random_range(45, 90));
                return this.g_e26_ended;
            }, 1);
            weapon_hold_trigger(GetReference<IWeaponReference>("e26_smg0"), 0, false);
            object_destroy(e26_smg01.Entity);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task e26_fld_infections_main()
        {
            ai_place(e26_fld_infection_forms0.swarm0);
            await sleep_until(async () => objects_distance_to_flag(players(), e26_fld_infs0_1) < 10F, 10, 300);
            ai_place(e26_fld_infection_forms0.swarm1);
            await sleep_until(async () => objects_distance_to_flag(players(), e26_fld_infs0_2) < 10F, 10, 300);
            ai_place(e26_fld_infection_forms0.swarm2);
            await sleep_until(async () => objects_distance_to_flag(players(), e26_fld_infs0_3) < 10F, 10, 300);
            ai_place(e26_fld_infection_forms0.swarm3);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task e26_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e26_main_begin, players()), 10);
            data_mine_set_mission_segment("enc_e26");
            this.g_e26_started = true;
            print("e26_main");
            game_save();
            wake(new ScriptMethodReference(e26_fld_infections_main));
            wake(new ScriptMethodReference(e26_smg0));
            wake(new ScriptMethodReference(e26_smg1));
            await sleep_until(async () => volume_test_objects(tv_mission_end0, players()) || volume_test_objects(tv_mission_end1, players()), 10);
            this.g_e26_ended = true;
        }

        [ScriptMethod(233, Lifecycle.CommandScript)]
        public async Task cs_e25_scene3()
        {
            cs_switch("elite1");
            cs_start_to(GetReference<ISpatialPoint>("e25_scenes/p1"));
            cs_switch("elite0");
            cs_start_to(GetReference<ISpatialPoint>("e25_scenes/p0"));
            await sleep_until(async () => !((bool)cs_moving()) || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 4F);
            cs_face_player(true);
            cs_approach(ai_get_object(this.ai_current_actor), 1F, 1F, 1F);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 4F);
            print("elite0: we'll guard the key");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0910"));
            await sleep(20);
            cs_switch("elite1");
            await sleep_until(async () => !((bool)cs_moving()) || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 4F);
            cs_face_player(true);
            cs_approach(ai_get_object(this.ai_current_actor), 1F, 1F, 1F);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 4F);
            print("elite1: git to werk");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0920"));
        }

        [ScriptMethod(234, Lifecycle.CommandScript)]
        public async Task cs_e25_scene1()
        {
            cs_start_to(GetReference<ISpatialPoint>("e25_scenes/p0"));
            await sleep_until(async () => !((bool)cs_moving()) || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 4F);
            cs_face_player(true);
            cs_approach(ai_get_object(this.ai_current_actor), 1F, 1F, 1F);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 4F);
            print("elite0: we'll guard the key");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0910"));
            await sleep(15);
            print("elite0: get the icon");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0920"));
        }

        [ScriptMethod(235, Lifecycle.CommandScript)]
        public async Task cs_e25_scene0()
        {
            print("elite: behold, the library");
            await sleep(ai_play_line(this.ai_current_actor, "0890"));
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task e25_dialogue()
        {
            await sleep_until(async () => ai_scene("e25_scene0", new ScriptMethodReference(cs_e25_scene0), e21_cov_inf0), 5, 300);
            await sleep(120);
            ai_play_line_on_object(default(IGameObject), "0900") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep_until(async () => this.g_key_library_arrival, 10);
            if ((short)ai_living_count(e21_cov_inf0) >= 2)
            {
                await sleep_until(async () => ai_scene("e25_scene3", new ScriptMethodReference(cs_e25_scene3), e21_cov_inf0), 5);
            }
            else
            {
                await sleep_until(async () => ai_scene("e25_scene1", new ScriptMethodReference(cs_e25_scene1), e21_cov_inf0), 5);
            }
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task e25_fld_inf1_main()
        {
            await sleep_until(async () => this.g_key_lock1_second_arch, 10);
            ai_place(e25_fld_inf1_0.Squad);
            await sleep(60);
            ai_place(e25_fld_inf1_1.Squad);
            await sleep(60);
            ai_place(e25_fld_inf1_2.Squad);
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task e25_fld_inf0_main()
        {
            await sleep_until(async () => this.g_key_lock1_first_arch, 10);
            ai_place(e25_fld_inf0_0.Squad);
            await sleep(60);
            ai_place(e25_fld_inf0_1.Squad);
            await sleep(60);
            ai_place(e25_fld_inf0_2.Squad);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task e25_main()
        {
            data_mine_set_mission_segment("enc_e25");
            await sleep_until(async () => this.g_key_lock1_entered, 10);
            this.g_e25_started = true;
            print("e25_main");
            game_save();
            wake(new ScriptMethodReference(e26_main));
            wake(new ScriptMethodReference(e25_dialogue));
            await sleep_until(async () => this.g_e26_started);
            sleep_forever(new ScriptMethodReference(e25_fld_inf0_main));
            sleep_forever(new ScriptMethodReference(e25_fld_inf1_main));
        }

        [ScriptMethod(240, Lifecycle.CommandScript)]
        public async Task cs_e24_fld_inf1_load()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_face_object(true, key.Entity);
            await sleep(210);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            cs_face_object(false, key.Entity);
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            if ((short)random_range(0, 2) == 0)
            {
                cs_go_to(GetReference<ISpatialPoint>("e24_fld_inf1_load/p0_0"));
                cs_go_to(GetReference<ISpatialPoint>("e24_fld_inf1_load/p0_1"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e24_fld_inf1_load/p1_0"));
                cs_go_to(GetReference<ISpatialPoint>("e24_fld_inf1_load/p1_1"));
            }

            cs_jump_to_point(3F, 1F);
            ai_migrate(this.ai_current_actor, e21_fld_inf0_0.Squad);
            await sleep(150);
            object_can_take_damage(ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task e24_fld_inf2_main()
        {
            await sleep_until(async () => this.g_key_shaft_entered, 10);
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task e24_fld_inf1_main()
        {
            await sleep_until(async () => this.g_key_shaft_rising, 10);
            ai_place(e24_fld_inf1_1.Squad);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task e24_fld_inf0_main()
        {
            await sleep_until(async () => this.g_key_shaft_entered, 10);
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task e24_main()
        {
            await sleep_until(async () => this.g_key_shaft_entered, 10);
            data_mine_set_mission_segment("enc_e24");
            this.g_e24_started = true;
            print("e24_main");
            game_save();
            wake(new ScriptMethodReference(e25_main));
            await sleep_until(async () => this.g_e25_started);
            sleep_forever(new ScriptMethodReference(e24_fld_inf0_main));
            sleep_forever(new ScriptMethodReference(e24_fld_inf1_main));
            sleep_forever(new ScriptMethodReference(e24_fld_inf2_main));
        }

        [ScriptMethod(245, Lifecycle.CommandScript)]
        public async Task cs_e23_fld_inf0_0_load()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("e23_fld_inf0_load/p0_0"));
            cs_go_to(GetReference<ISpatialPoint>("e23_fld_inf0_load/p0_1"));
            cs_jump(15F, 3F);
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cs_e23_fld_inf0_1_load()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("e23_fld_inf0_load/p1_0"));
            cs_go_to(GetReference<ISpatialPoint>("e23_fld_inf0_load/p1_1"));
            cs_jump(15F, 3F);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cs_e23_scene0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_switch("elite0");
            print("dog: the fool...");
            await sleep(ai_play_line(this.ai_current_actor, "0810"));
            await sleep(15);
            cs_switch("elite1");
            print("scl: on the bright side...");
            await sleep(ai_play_line(this.ai_current_actor, "0820"));
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task e23_dialogue()
        {
            await sleep(90);
            print("tartarus: humans! i'll deal with them!");
            await sleep(ai_play_line_on_object(default(IGameObject), "0800"));
            await sleep(30);
            await sleep_until(async () => ai_scene("e23_scene0", new ScriptMethodReference(cs_e23_scene0), e21_cov_inf0), 10, 90);
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task e23_fld_inf0_main()
        {
            await sleep_until(async () => this.g_key_cruise_first_loadpoint, 10);
            ai_place(e23_fld_inf0);
            await sleep_until(async () => this.g_key_cruise_halfway, 10);
            await sleep(90);
            ai_set_orders(e23_fld_inf0_0.Squad, e23_fld_inf0_engage);
            ai_set_orders(e23_fld_inf0_1.Squad, e23_fld_inf0_engage);
            cs_run_command_script(e23_fld_inf0_0.Squad, new ScriptMethodReference(cs_e23_fld_inf0_0_load));
            cs_run_command_script(e23_fld_inf0_1.Squad, new ScriptMethodReference(cs_e23_fld_inf0_1_load));
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task e23_main()
        {
            data_mine_set_mission_segment("enc_e23");
            await sleep_until(async () => this.g_key_cruise_entered, 10);
            this.g_e23_started = true;
            print("e23_main");
            game_save();
            wake(new ScriptMethodReference(e24_main));
            wake(new ScriptMethodReference(e23_dialogue));
            await sleep_until(async () => this.g_e24_started);
            sleep_forever(new ScriptMethodReference(e23_fld_inf0_main));
        }

        [ScriptMethod(251, Lifecycle.Static)]
        public async Task test_key_ride2()
        {
            device_set_position_immediate(key.Entity, 0.26F);
            await sleep(1);
            object_teleport(await this.player0(), e23_test);
            object_set_velocity(await this.player0(), 1F, 0F, 0F);
            wake(new ScriptMethodReference(key_main));
            wake(new ScriptMethodReference(e23_main));
            await sleep(3);
            device_set_position_immediate(key.Entity, 0.26F);
            device_set_position(key.Entity, 1F);
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task cs_e22_hack_divide()
        {
            if ((short)ai_living_count(e22_cov_inf1_0.Squad) < 2)
            {
                ai_migrate(this.ai_current_actor, e22_cov_inf1_0.Squad);
            }
            else
            {
                ai_migrate(this.ai_current_actor, e22_cov_inf1_1.Squad);
            }
        }

        [ScriptMethod(253, Lifecycle.CommandScript)]
        public async Task cs_e22_fld_inf0_0_load()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_face_object(true, key.Entity);
            await sleep_until(async () => this.g_key_lock0_second_loadpoint, 1);
            await sleep(95);
            cs_face_object(false, key.Entity);
            unit_impervious(this.ai_current_actor, true);
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            if ((short)random_range(0, 2) == 0)
            {
                cs_go_to(GetReference<ISpatialPoint>("e22_fld_inf0_load/p0_0"));
                cs_go_to(GetReference<ISpatialPoint>("e22_fld_inf0_load/p0_1"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e22_fld_inf0_load/p1_0"));
                cs_go_to(GetReference<ISpatialPoint>("e22_fld_inf0_load/p1_1"));
            }

            cs_move_in_direction(0F, 1F, 0F);
            unit_impervious(this.ai_current_actor, false);
            ai_migrate(this.ai_current_actor, e21_fld_inf0_0.Squad);
        }

        [ScriptMethod(254, Lifecycle.CommandScript)]
        public async Task cs_e22_scene0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_switch("elite0");
            print("scl: what courage...");
            await sleep(ai_play_line(this.ai_current_actor, "0780"));
            await sleep(15);
            cs_switch("elite1");
            print("dog: ignore him...");
            await sleep(ai_play_line(this.ai_current_actor, "0790"));
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task e22_dialogue()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 4);
            await sleep(90);
            print("tartarus: i will thin their ranks");
            await sleep(ai_play_line_on_object(default(IGameObject), "0770"));
            await sleep(30);
            await sleep_until(async () => ai_scene("e22_scene0", new ScriptMethodReference(cs_e22_scene0), e21_cov_inf0), 10, 90);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task e22_fld_inf0_main()
        {
            await sleep_until(async () => this.g_key_lock0_first_loadpoint, 10);
            ai_place(e22_fld_inf0);
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task e22_main()
        {
            await sleep_until(async () => this.g_key_lock0_entered, 10);
            data_mine_set_mission_segment("enc_e22");
            this.g_e22_started = true;
            print("e22_main");
            game_save();
            wake(new ScriptMethodReference(e23_main));
            wake(new ScriptMethodReference(e22_fld_inf0_main));
            wake(new ScriptMethodReference(e22_dialogue));
            await sleep_until(async () => this.g_e23_started);
            sleep_forever(new ScriptMethodReference(e22_fld_inf0_main));
        }

        [ScriptMethod(258, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf1_low_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_move_in_direction(6F, 0F, 0F);
            if ((short)structure_bsp_index() == 3)
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p2"));
                cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p1_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p1_1"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p2"));
                cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p1_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p1_1"));
            }
        }

        [ScriptMethod(259, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf1_high_entry()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_pathfinding_failsafe(true);
            if ((short)structure_bsp_index() == 3)
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p1_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p1_1"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p1_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p1_1"));
            }
        }

        [ScriptMethod(260, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf0_low_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_move_in_direction(6F, 0F, 0F);
            if ((short)structure_bsp_index() == 3)
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p2"));
                cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p0_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p0_1"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p2"));
                cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p0_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p0_1"));
            }
        }

        [ScriptMethod(261, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf0_high_entry()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_pathfinding_failsafe(true);
            if ((short)structure_bsp_index() == 3)
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p0_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp5/p0_1"));
            }
            else
            {
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p0_0"));
                cs_go_to(GetReference<ISpatialPoint>("e21_fld_bsp6/p0_1"));
            }
        }

        [ScriptMethod(262, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf0_0_load()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            await sleep_until(async () => this.g_key_lock0_first_loadpoint, 1);
            await sleep(30);
            cs_shoot_point(true, GetReference<ISpatialPoint>("key_bsp5/p0"));
            await sleep(148);
            cs_shoot_point(false, GetReference<ISpatialPoint>("key_bsp5/p0"));
            ai_set_orders(this.ai_current_squad, e21_fld_inf0_engage0);
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e21_fld_load/left0"));
            cs_go_to(GetReference<ISpatialPoint>("e21_fld_load/left1"));
            cs_move_in_direction(0F, 1F, 0F);
        }

        [ScriptMethod(263, Lifecycle.CommandScript)]
        public async Task cs_e21_scene0()
        {
            print("elite: i grow restless without a target");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0730"));
        }

        [ScriptMethod(264, Lifecycle.CommandScript)]
        public async Task cs_e21_scene1()
        {
            print("elite: look, up ahead! the parasite readies");
            ai_play_line_at_player(this.ai_current_actor, "0760") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(20);
            cs_go_to_nearest(GetReference<ISpatialPoint>("e21_scene1_points"));
            cs_face(true, GetReference<ISpatialPoint>("e21_fld_load/p0"));
            cs_aim(true, GetReference<ISpatialPoint>("e21_fld_load/p0"));
            await sleep_until(async () => this.g_key_lock0_first_loadpoint, 5);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e21_fld_load/p0"));
            await sleep(90);
        }

        [ScriptMethod(265, Lifecycle.Static)]
        public async Task<bool> e21_in_bsp4()
        {
            return (short)structure_bsp_index() == 4;
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task e21_fld_carriers1_main()
        {
            ai_migrate(e21_fld_carriers0.Squad, e21_fld_carriers1.Squad);
            await sleep_until(async () =>
            {
                if ((short)ai_swarm_count(e21_fld_carriers1.Squad) < 2)
                {
                    ai_place(e21_fld_carriers1.Squad, 1);
                }

                return this.g_key_lock1_second_arch;
            }, 90);
        }

        [ScriptMethod(267, Lifecycle.Static)]
        public async Task e21_fld_inf1_spawn()
        {
            if (volume_test_objects(tv_key_near_lower_spawner, players()))
            {
                if (volume_test_objects(tv_key_upper_left_side, players()))
                {
                    ai_place(e21_fld_inf1_2.Squad, 1);
                    ai_migrate(e21_fld_inf1_2.Squad, e21_fld_inf1_0.Squad);
                    await sleep(5);
                    ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player0());
                    ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player1());
                }
                else
                {
                    ai_place(e21_fld_inf0_2.Squad, 1);
                    cs_run_command_script(e21_fld_inf0_2.Squad, new ScriptMethodReference(cs_e21_fld_inf1_high_entry));
                    ai_migrate(e21_fld_inf0_2.Squad, e21_fld_inf1_0.Squad);
                    await sleep(5);
                    ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player0());
                    ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player1());
                }
            }
            else
            {
                ai_place(e21_fld_inf1_1.Squad, 1);
                ai_migrate(e21_fld_inf1_1.Squad, e21_fld_inf1_0.Squad);
                await sleep(5);
                ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player0());
                ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player1());
            }
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task e21_fld_inf1_main()
        {
            ai_migrate(e21_fld_inf0, e21_fld_inf1_0.Squad);
            await sleep_until(async () =>
            {
                if ((short)ai_nonswarm_count(e21_fld_inf1_0.Squad) < 8)
                {
                    await sleep_until(async () =>
                    {
                        await this.e21_fld_inf1_spawn();
                        return (short)ai_nonswarm_count(e21_fld_inf1_0.Squad) >= 8 || this.g_key_lock1_second_arch;
                    }, 60);
                }

                return this.g_key_lock1_second_arch;
            }, 900);
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task e21_fld_carriers0_main()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 4);
            await sleep_until(async () =>
            {
                if ((short)ai_nonswarm_count(e21_fld_carriers0.Squad) < 2)
                {
                    ai_place(e21_fld_carriers0.Squad, 1);
                }

                return this.g_key_shaft_rising;
            }, 90);
            wake(new ScriptMethodReference(e21_fld_carriers1_main));
        }

        [ScriptMethod(270, Lifecycle.Static)]
        public async Task e21_fld_inf0_spawn()
        {
            if (volume_test_objects(tv_key_near_lower_spawner, players()))
            {
                if (volume_test_objects(tv_key_upper_left_side, players()))
                {
                    ai_place(e21_fld_inf1_2.Squad, 1);
                    cs_run_command_script(e21_fld_inf1_2.Squad, new ScriptMethodReference(cs_e21_fld_inf0_high_entry));
                    ai_migrate(e21_fld_inf1_2.Squad, e21_fld_inf0_0.Squad);
                    await sleep(5);
                    ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player0());
                    ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player1());
                }
                else
                {
                    ai_place(e21_fld_inf0_2.Squad, 1);
                    ai_migrate(e21_fld_inf0_2.Squad, e21_fld_inf0_0.Squad);
                    await sleep(5);
                    ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player0());
                    ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player1());
                }
            }
            else
            {
                ai_place(e21_fld_inf0_1.Squad, 1);
                ai_migrate(e21_fld_inf0_1.Squad, e21_fld_inf0_0.Squad);
                await sleep(5);
                ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player0());
                ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player1());
            }
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task e21_fld_inf0_main()
        {
            ai_place(e21_fld_inf0_0.Squad);
            await sleep_until(async () => (short)structure_bsp_index() == 4);
            await sleep_until(async () =>
            {
                await this.e21_fld_inf0_spawn();
                return (short)ai_nonswarm_count(e21_fld_inf0_0.Squad) >= 8 || this.g_key_shaft_rising;
            });
            await sleep_until(async () =>
            {
                if ((short)ai_nonswarm_count(e21_fld_inf0_0.Squad) < 8)
                {
                    await sleep_until(async () =>
                    {
                        await this.e21_fld_inf0_spawn();
                        return (short)ai_nonswarm_count(e21_fld_inf0_0.Squad) >= 8 || this.g_key_shaft_rising;
                    }, 60);
                }

                return this.g_key_shaft_rising;
            }, 900);
            wake(new ScriptMethodReference(e21_fld_inf1_main));
        }

        [ScriptMethod(272, Lifecycle.Dormant)]
        public async Task e21_cov_inf0_main()
        {
            ai_place(e21_cov_inf0);
            await sleep(150);
            await sleep_until(async () => ai_scene("e21_scene0", new ScriptMethodReference(cs_e21_scene0), e21_cov_inf0_1.Squad), 5, 60);
            await sleep(300);
            await sleep_until(async () => ai_scene("e21_scene1", new ScriptMethodReference(cs_e21_scene1), e21_cov_inf0_0.Squad), 5, 60);
            await sleep_until(async () => this.g_key_lock0_first_loadpoint, 5);
            game_save();
            ai_set_orders(e21_cov_inf0_0.Squad, e21_cov_inf0_0_guard_left);
            ai_set_orders(e21_cov_inf0_1.Squad, e21_cov_inf0_1_advance_left);
            await sleep_until(async () => this.g_key_shaft_rising);
            ai_set_orders(e21_cov_inf0_0.Squad, e21_cov_inf0_0_guard_right);
            ai_set_orders(e21_cov_inf0_1.Squad, e21_cov_inf0_1_advance_right);
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task e21_main()
        {
            await sleep_until(async () => this.g_key_started, 5);
            data_mine_set_mission_segment("enc_e21");
            this.g_e21_started = true;
            print("e21_main");
            wake(new ScriptMethodReference(e22_main));
            wake(new ScriptMethodReference(e21_cov_inf0_main));
            wake(new ScriptMethodReference(e21_fld_inf0_main));
            wake(new ScriptMethodReference(sc_outer_wall));
        }

        [ScriptMethod(274, Lifecycle.Static)]
        public async Task test_key_ride()
        {
            switch_bsp_by_name(GetReference<IBsp>("sen_hq_bsp_5"));
            await sleep(1);
            object_teleport(await this.player0(), key_ent0);
            object_set_velocity(await this.player0(), 5F, 0F, 0F);
            object_teleport(await this.player1(), key_ent1);
            object_set_velocity(await this.player1(), 5F, 0F, 0F);
            wake(new ScriptMethodReference(key_main));
            wake(new ScriptMethodReference(key_ride_human_key_main));
            wake(new ScriptMethodReference(key_ride_tartarus_main));
            wake(new ScriptMethodReference(e21_main));
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task begin_key_ride_main()
        {
            wake(new ScriptMethodReference(e21_main));
            wake(new ScriptMethodReference(key_main));
            wake(new ScriptMethodReference(key_ride_human_key_main));
            wake(new ScriptMethodReference(key_ride_tartarus_main));
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task enc_cov_charge()
        {
            data_mine_set_mission_segment("enc_cov_charge");
            print("initialize covenant charge scripts");
            game_save();
            object_dynamic_simulation_disable(qz_cov_def_tower_pod_a.Entity, true);
            object_dynamic_simulation_disable(qz_cov_def_tower_pod_b.Entity, true);
            ai_place(qz_cov_def_phantom.Squad);
            ai_place(qz_cov_def_spectre.Squad);
            ai_place(qz_cov_def_ghosts.Squad);
            ai_place(qz_cov_def_spec_ops1.Squad);
            wake(new ScriptMethodReference(sc_cov_charge));
            await sleep_until(async () => vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_l", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_r", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_g", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.a), "ghost_d", players()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.b), "ghost_d", players()), 10, 30 * 20);
            this.g_qz_cov_def_progress = true;
            await sleep(30);
            game_save_no_timeout();
            await sleep(90);
            ai_place(qz_cov_def_enforcer_a.Squad);
            ai_place(qz_cov_def_sen_elim.Squad);
            device_set_position(qz_door_a.Entity, 1F);
            await sleep((short)(30 * 2));
            wake(new ScriptMethodReference(ext_a_vehicle_orders));
            await sleep_until(async () => (short)ai_living_count(sentinels) <= 0);
            await sleep(30);
            game_save();
            ai_renew(covenant1);
        }

        [ScriptMethod(277, Lifecycle.Dormant)]
        public async Task enc_vehicle_int()
        {
            data_mine_set_mission_segment("enc_vehicle_int");
            print("initialize vehicle interior scripts");
            game_save();
            ai_renew(covenant1);
            ai_disposable(cov_def_sentinels, true);
            ai_disposable(cov_def_enf, true);
            this.g_veh_int_migrate_a = true;
            this.g_music_06b_01 = true;
            wake(new ScriptMethodReference(music_06b_01));
            wake(new ScriptMethodReference(sc_qz_veh_int));
            ai_place(veh_int_enf_a1.Squad);
            ai_place(veh_int_enf_b1.Squad);
            ai_place(veh_int_enf_d.Squad);
            ai_place(veh_int_sen_elim_ini.Squad);
            ai_place(veh_int_scorpion1.Squad);
            ai_place(veh_int_flood_ghosts_ini.Squad);
            ai_place(veh_int_wraith1.wraith);
            ai_place(veh_int_hog_ab.Squad);
            ai_place(veh_int_ghost_ab.Squad);
            await sleep(15);
            device_operates_automatically_set(veh_int_door_a.Entity, true);
            await sleep_until(async () => volume_test_objects(tv_veh_int_b, players()));
            game_save();
            ai_renew(covenant1);
            this.g_veh_int_migrate_b = true;
            wake(new ScriptMethodReference(ai_veh_int_ghost_spawn));
            ai_place(veh_int_sen_elim_rt.Squad);
            ai_place(veh_int_sen_elim_lt.Squad);
            ai_magically_see(veh_int_wraith1.Squad, veh_int_sen);
            ai_place(veh_int_flood_bk.runner);
            await sleep_until(async () => volume_test_objects(tv_veh_int_c, players()));
            data_mine_set_mission_segment("enc_vehicle_int_bk");
            game_save();
            this.g_veh_int_migrate_c = true;
            wake(new ScriptMethodReference(sc_factory_approach));
            ai_renew(covenant1);
            ai_place(veh_int_wraith1.driver);
            await sleep_until(async () => volume_test_objects(tv_veh_int_d, players()));
            this.g_veh_int_migrate_d = true;
            this.g_veh_int_ghost_spawn = true;
            ai_place(veh_int_flood_hog_bk.Squad);
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task enc_qz_ext_a()
        {
            data_mine_set_mission_segment("enc_qz_ext_a_dam");
            print("initialize quarantine zone exterior a scripts");
            game_save();
            ai_renew(covenant1);
            ai_disposable(veh_int_flood, true);
            ai_disposable(veh_int_sen, true);
            this.g_veh_int_migrate_e = true;
            this.g_ext_a_dam_migrate_a = true;
            wake(new ScriptMethodReference(music_06b_02));
            wake(new ScriptMethodReference(ai_ext_a_dam_enforcers));
            device_set_position(qz_dam_door_a.Entity, 1F);
            ai_place(qz_ext_a_dam_enf.a);
            ai_place(qz_ext_a_dam_human.Squad);
            ai_place(qz_ext_a_dam_sen1.Squad);
            ai_place(qz_ext_a_dam_sen_elim.Squad);
            ai_place(qz_ext_a_dam_flood_ini1.Squad);
            wake(new ScriptMethodReference(chapter_competition));
            game_save();
            ai_renew(covenant1);
            await sleep_until(async () => volume_test_objects(qz_ext_a_dam_b, players()));
            this.g_ext_a_dam_migrate_b = true;
            ai_place(qz_ext_a_dam_flood_cliff_a.Squad);
            ai_place(qz_ext_a_dam_flood_cliff_b.Squad);
            await sleep_until(async () => volume_test_objects(tv_ext_a_a, players()));
            data_mine_set_mission_segment("enc_qz_ext_a");
            game_save();
            ai_renew(covenant1);
            this.g_ext_a_dam_enf = true;
            this.g_ext_a_migrate_a = true;
            ai_disposable(ext_a_flood_dam_a, true);
            ai_disposable(ext_a_flood_dam_b, true);
            ai_disposable(ext_a_sen_dam_a, true);
            ai_disposable(ext_a_sen_dam_b, true);
            wake(new ScriptMethodReference(ai_qz_ext_a_wraiths));
            ai_place(qz_ext_a_enf_a1.Squad);
            ai_place(qz_ext_a_flood_rocket.Squad);
            if ((short)ai_living_count(covenant1) <= 1)
            {
                wake(new ScriptMethodReference(sc_ext_a));
                ai_place(qz_ext_a_phantom.Squad);
            }

            this.v_ext_a_phantom = ai_vehicle_get_from_starting_location(qz_ext_a_phantom.phantom);
            await sleep_until(async () => volume_test_objects(tv_ext_a_b, players()));
            this.g_ext_a_migrate_b = true;
            await sleep_until(async () => volume_test_objects(tv_ext_a_c, players()));
            game_save_no_timeout();
            ai_renew(covenant1);
            this.g_ext_a_migrate_c = true;
            ai_place(qz_ext_a_flood_c1.Squad);
            ai_place(qz_ext_a_flood_c21.Squad);
            ai_place(ext_a_flood_ghost_fr.Squad);
            await sleep_until(async () => volume_test_objects(tv_ext_a_d, players()));
            this.g_ext_a_migrate_d = true;
            wake(new ScriptMethodReference(ai_qz_ext_a_ghosts));
            wake(new ScriptMethodReference(ai_qz_ext_a_d_spawn));
            await sleep_until(async () => volume_test_objects(tv_ext_a_e, players()));
            game_save();
            ai_renew(covenant1);
            this.g_ext_a_migrate_e = true;
            this.g_qz_ext_a_d_spawn = false;
            ai_place(ext_a_sen_elim_bk1.Squad);
            if ((short)ai_living_count(qz_ext_a_enf_bk1.Squad) <= 0)
            {
                ai_place(qz_ext_a_enf_bk1.Squad);
            }

            await sleep_until(async () => volume_test_objects(tv_ext_a_ghosts_off, players()));
            this.g_qz_ext_a_flood_ghosts = true;
            await sleep_until(async () => volume_test_objects(tv_ext_a_f, players()));
            data_mine_set_mission_segment("enc_ext_a_fact_ent");
            game_save_no_timeout();
            this.g_ext_a_migrate_f = true;
            this.g_music_06b_02 = true;
            ai_renew(covenant1);
            ai_place(fact_ent_flood_scorpion.Squad);
            ai_place(fact_ent_flood_wraith_b1.Squad);
            wake(new ScriptMethodReference(ai_fact_ent_sen_spawn));
            wake(new ScriptMethodReference(ai_fact_ent_enf_spawn));
            await sleep_until(async () => volume_test_objects(tv_ext_a_fact_ent, players()));
            this.g_ext_a_fact_ent_migrate = true;
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task enc_crashed_factory()
        {
            data_mine_set_mission_segment("enc_crashed_factory_a");
            game_save();
            ai_renew(covenant1);
            ai_disposable(ext_a_flood, true);
            ai_disposable(ext_a_sen, true);
            this.g_music_06b_02 = false;
            this.g_music_06b_03 = true;
            this.g_fact_ent_sen_spawn = true;
            wake(new ScriptMethodReference(music_06b_03));
            wake(new ScriptMethodReference(sent_factory_1_start));
            await sleep_until(async () => volume_test_objects(vol_factory_1_exit, players()) == true);
            game_save();
            await sleep_until(async () => volume_test_objects(tv_gorge, players()));
            data_mine_set_mission_segment("enc_crashed_factory_ext");
            game_save();
            ai_disposable(factory1_enemies, true);
            this.g_music_06b_03 = false;
            ai_set_orders(covenant1, cov_follow_gorge);
            ai_renew(covenant1);
            wake(new ScriptMethodReference(ai_gorge));
            await sleep_until(async () => volume_test_objects(tv_factory2_enter, players()));
            data_mine_set_mission_segment("enc_crashed_factory_b");
            game_save();
            ai_disposable(gorge_enemies, true);
            ai_set_orders(covenant1, cov_follow_factory2);
            ai_renew(covenant1);
            wake(new ScriptMethodReference(ai_factory2));
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task enc_qz_ext_b()
        {
            data_mine_set_mission_segment("enc_ext_b_fact_exit");
            print("initialize quarantine zone exterior b scripts");
            game_save_no_timeout();
            ai_renew(covenant1);
            ai_disposable(factory2_enemies, true);
            wake(new ScriptMethodReference(music_06b_04));
            wake(new ScriptMethodReference(sc_factory_exit));
            wake(new ScriptMethodReference(objective_push_clear));
            wake(new ScriptMethodReference(objective_link_set));
            wake(new ScriptMethodReference(ext_b_vehicle_orders));
            ai_place(qz_ext_b_fact_scorpion.Squad);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(qz_ext_b_fact_scorpion.scorpion), true);
            ai_place(qz_ext_b_fact_wraith1.Squad);
            ai_place(qz_ext_b_fact_ghosts1.Squad);
            ai_place(qz_ext_b_fact_flood1.Squad);
            ai_place(qz_ext_b_fact_ghosts_spare1.Squad);
            ai_place(qz_ext_b_enf_a1.Squad);
            await sleep_until(async () => volume_test_objects(tv_ext_b_fact_mid, players()));
            game_save();
            if (random_range(0, 2) == 1 ? true : false)
            {
                ai_place(qz_ext_b_fact_warthog.Squad);
            }
            else
            {
                ai_place(qz_ext_b_fact_ghost_bk.Squad);
            }

            await sleep_until(async () => (short)ai_living_count(ext_b_flood_a) <= 0 && (short)ai_living_count(ext_b_sentinels_a) <= 0 || volume_test_objects(tv_ext_b_gate, players()), 5);
            data_mine_set_mission_segment("enc_qz_ext_b");
            game_save();
            ai_renew(covenant1);
            this.g_ext_b_migrate_1 = true;
            wake(new ScriptMethodReference(ai_ext_b_enf_spawn));
            this.g_music_06b_04 = true;
            ai_place(qz_ext_b_cov_phantom.Squad);
            ai_place(qz_ext_b_wraith_a1.Squad);
            ai_place(qz_ext_b_wraith_b1.Squad);
            ai_place(qz_ext_b_ghosts_a.Squad, (short)pin(7F - (float)ai_living_count(ext_b_flood), 0F, 2F));
            ai_place(qz_ext_b_warthog.Squad);
            this.v_ext_b_phantom = ai_vehicle_get_from_starting_location(qz_ext_b_cov_phantom.phantom);
            await sleep_until(async () => (short)ai_living_count(ext_b_flood_b) <= 0 && (short)ai_living_count(ext_b_sentinels_b) <= 0 || volume_test_objects(tv_ext_b_mid, players()), 5);
            game_save_no_timeout();
            ai_renew(covenant1);
            this.g_ext_b_migrate_2 = true;
            ai_place(qz_ext_b_ghosts_b.Squad);
            ai_place(qz_ext_b_warthog_gauss.Squad);
            await sleep_until(async () => volume_test_objects(tv_ext_b_back, players()), 5);
            data_mine_set_mission_segment("enc_qz_ext_b_bk");
            game_save_no_timeout();
            ai_renew(covenant1);
            ai_disposable(ext_b_flood, true);
            ai_disposable(ext_b_sentinels, true);
            this.g_ext_b_migrate_3 = true;
            this.g_ext_b_enforcer = true;
            wake(new ScriptMethodReference(ai_constructor_flock));
            wake(new ScriptMethodReference(ai_ext_b_bk_ghost_spawn));
            ai_place(qz_ext_b_ent_enf1.Squad);
            ai_place(qz_ext_b_ent_scorpion1.Squad);
            ai_place(qz_ext_b_ent_wraith_a.Squad);
            await sleep_until(async () => volume_test_objects(tv_ext_b_exit, players()), 5);
            data_mine_set_mission_segment("enc_qz_ext_b_exit");
            game_save();
            ai_renew(covenant1);
            this.g_ext_b_bk_ghost_spawn = true;
            this.g_ext_b_migrate_4 = true;
            wake(new ScriptMethodReference(ai_ext_b_exit_tube_a));
            wake(new ScriptMethodReference(ai_ext_b_exit_tube_b));
            ai_place(qz_ext_b_ent_turrets1.Squad);
            await sleep_until(async () => (short)ai_living_count(ext_b_flood_d) <= 0 && (short)ai_living_count(ext_b_sentinels_d) <= 0 || volume_test_objects(tv_ext_b_exit_door, players()), 5);
            game_save_no_timeout();
            ai_renew(covenant1);
            this.g_ext_b_migrate_5 = true;
            ai_place(qz_ext_b_ent_flood_bk.Squad, (short)pin(8F - (float)ai_nonswarm_count(ext_b_flood), 0F, 6F));
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task enc_key_ride()
        {
            print("initialize key ride scripts");
            ai_renew(covenant1);
            wake(new ScriptMethodReference(music_06b_05));
            wake(new ScriptMethodReference(music_06b_06));
            wake(new ScriptMethodReference(music_06b_07));
            await sleep_until(async () => volume_test_objects(tv_key_ride_cinematic, players()));
            await this.cinematic_fade_to_white();
            ai_erase_all();
            object_teleport(await this.player0(), key_ride_a);
            object_teleport(await this.player1(), key_ride_b);
            await sleep(5);
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    print("c06_intra2");
                    await this.c06_intra2();
                }

                await this.cinematic_skip_stop();
            }

            wake(new ScriptMethodReference(begin_key_ride_main));
            await sleep(25);
            game_save_immediate();
            wake(new ScriptMethodReference(chapter_gallery));
            wake(new ScriptMethodReference(objective_link_clear));
            wake(new ScriptMethodReference(objective_retrieve_set));
            ai_renew(covenant1);
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white();
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task enc_library()
        {
            print("initialize library scripts");
            game_save();
            game_save();
            ai_renew(covenant1);
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task mission_floodzone()
        {
            await this.cinematic_snap_to_white();
            switch_bsp(0);
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    print("c06_intra1");
                    await this.c06_intra1();
                }

                await this.cinematic_skip_stop();
            }

            await sleep(2);
            object_teleport(await this.player0(), player0_start);
            object_teleport(await this.player1(), player1_start);
            wake(new ScriptMethodReference(enc_cov_charge));
            if (await this.difficulty_legendary())
            {
                wake(new ScriptMethodReference(ice_cream_superman));
            }

            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_mirror));
            wake(new ScriptMethodReference(objective_push_set));
            await sleep_until(async () => volume_test_objects(tv_vehicle_int, players()));
            wake(new ScriptMethodReference(enc_vehicle_int));
            await sleep_until(async () => volume_test_objects(tv_qz_ext_a, players()));
            wake(new ScriptMethodReference(enc_qz_ext_a));
            await sleep_until(async () => volume_test_objects(tv_factory, players()));
            wake(new ScriptMethodReference(enc_crashed_factory));
            await sleep_until(async () => volume_test_objects(tv_qz_ext_b, players()));
            wake(new ScriptMethodReference(enc_qz_ext_b));
            await sleep_until(async () => volume_test_objects(tv_key_ride, players()));
            wake(new ScriptMethodReference(enc_key_ride));
            await sleep_until(async () => volume_test_objects(tv_x07, players()));
            await this.cinematic_fade_to_white();
            ai_erase_all();
            object_teleport(await this.player0(), player0_end);
            object_teleport(await this.player1(), player1_end);
            if (await this.cinematic_skip_start())
            {
                print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            await this.playtest_mission();
            game_won();
        }

        [ScriptMethod(284, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_floodzone));
        }

        [ScriptMethod(285, Lifecycle.Startup)]
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

        [ScriptMethod(286, Lifecycle.Static)]
        public async Task test()
        {
            this.g_play_cinematics = false;
            device_set_position(qz_door_a.Entity, 1F);
            device_set_position(veh_int_door_a.Entity, 1F);
            device_set_position(veh_int_door_b.Entity, 1F);
            device_set_position(qz_dam_door_a.Entity, 1F);
            ai_place(qz_cov_def_spectre.Squad);
            ai_place(qz_cov_def_ghosts.Squad);
            ai_place(qz_cov_def_spec_ops1.Squad);
            wake(new ScriptMethodReference(ext_a_vehicle_orders));
            wake(new ScriptMethodReference(dam_door_a));
            wake(new ScriptMethodReference(dam_door_b));
            await sleep(90);
            this.g_qz_cov_def_progress = true;
        }

        [ScriptMethod(287, Lifecycle.Static)]
        public async Task test_ext_a_phantom()
        {
            ai_place(qz_ext_a_phantom.Squad);
            this.v_ext_a_phantom = ai_vehicle_get_from_starting_location(qz_ext_a_phantom.phantom);
        }

        [ScriptMethod(288, Lifecycle.Static)]
        public async Task test_ext_b_phantom()
        {
            ai_place(qz_ext_b_cov_phantom.Squad);
            this.v_ext_b_phantom = ai_vehicle_get_from_starting_location(qz_ext_b_cov_phantom.phantom);
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task _06_intra1_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3787063364U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 35, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855090770U), 0);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3787063364U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 7);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_base\\cov_watchtower_base", 3860595878U), 2);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 1, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 23, true);
            await sleep(31);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 61);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\turrets\\plasma\\plasma", 3862299840U), 10);
            await sleep(148);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 25, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3787063364U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_sentinel\\door_sentinel", 3862365377U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_pod\\cov_watchtower_pod", 3863872728U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_base\\cov_watchtower_base", 3860595878U), 2);
            await sleep(148);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 61);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\turrets\\plasma\\plasma", 3862299840U), 10);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3787063364U), 1);
            await sleep(67);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 27, true);
            await sleep(140);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 11, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3787063364U), 2);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, false);
            await sleep(24);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 32, true);
            await sleep(79);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 5, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 28, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 25, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 17, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 27, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 29, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 16, true);
            await sleep(27);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_base\\cov_watchtower_base", 3860595878U), 2);
            await sleep(45);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 61);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3860989100U), 63);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\spectre\\turrets\\plasma\\plasma", 3862299840U), 10);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 11, true);
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task _06_intra2_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855090770U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3863938265U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\key_cine", 3865380079U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786866753U), 7);
            await sleep(138);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 1);
            await sleep(89);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 6);
            await sleep(23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 10);
            await sleep(27);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            await sleep(47);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3863938265U), 0);
            await sleep(90);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 5);
            await sleep(103);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3866494208U), 0);
            await sleep(99);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3867608337U), 0);
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task _06_intra2_02_predict()
        {
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3863938265U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3868067096U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855090770U), 0);
            await sleep(22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 18);
            await sleep(45);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 3);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3868067096U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 2);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 32);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            await sleep(82);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 5);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 3);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 23);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3808559500U), 1);
            await sleep(13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 10);
            await sleep(13);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3863938265U), 0);
            await sleep(74);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3855483992U), 23);
            await sleep(123);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3867608337U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3868067096U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855090770U), 0);
            await sleep(115);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3866494208U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3867608337U), 0);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task _06_intra2_03_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 1);
            await sleep(34);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3854042178U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 1);
            await sleep(116);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3855025233U), 4);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 4, true);
            await sleep(82);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3868067096U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\gas_container\\gas_container", 3868394781U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3867608337U), 0);
            await sleep(536);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 75, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 59, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 66, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 73, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 76, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 35, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 29, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3783000070U), 11);
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task x07_01_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 37, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\key\\key", 3869181225U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3871868242U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3872195927U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3872195927U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855090770U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await sleep(151);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(135);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(60);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task x07_02_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 60);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(86);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await sleep(148);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 60);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(37);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(49);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3873244519U), 60);
            await sleep(21);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            await sleep(41);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            await sleep(79);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 11, true);
            await sleep(55);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task x07_03_predict()
        {
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 2);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await sleep(99);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3878290868U), 2);
            await sleep(94);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(86);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(125);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(36);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            await sleep(49);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            await sleep(36);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await sleep(16);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(30);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 1);
            await sleep(103);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 2);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await sleep(30);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 1);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task x07_04_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 2);
            await sleep(38);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await sleep(44);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(46);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            await sleep(56);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(18);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(34);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3881764329U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(183);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task x07_05_predict()
        {
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3869902132U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3881764329U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_low\\brute_shot\\brute_shot", 3882223088U), 2);
            await sleep(113);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(94);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 7, false);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await sleep(65);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(45);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await sleep(54);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            await sleep(13);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await sleep(16);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3813999071U), 3);
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task x07_06_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await sleep(95);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await sleep(89);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            await sleep(104);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            await sleep(63);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
            await sleep(28);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3851617309U), 10);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await sleep(147);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 38, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 39, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3879470534U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3881764329U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3877635498U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3872916834U), 0);
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task tele_vehicle_int()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(1);
            print("teleporting players...");
            object_teleport(await this.player0(), vehicle_int_a);
            object_teleport(await this.player1(), vehicle_int_b);
            fade_in(0F, 0F, 0F, 60);
            print("erasing ai...");
            ai_erase_all();
            await sleep(5);
            print("initializing area scripts...");
            wake(new ScriptMethodReference(enc_vehicle_int));
            await sleep(10);
            player_enable_input(true);
            await sleep_until(async () => volume_test_objects(tv_qz_ext_a, players()));
            wake(new ScriptMethodReference(enc_qz_ext_a));
            await sleep_until(async () => volume_test_objects(tv_factory, players()));
            wake(new ScriptMethodReference(enc_crashed_factory));
            await sleep_until(async () => volume_test_objects(tv_qz_ext_b, players()));
            wake(new ScriptMethodReference(enc_qz_ext_b));
            await sleep_until(async () => volume_test_objects(tv_key_ride, players()));
            wake(new ScriptMethodReference(enc_key_ride));
            await sleep_until(async () => volume_test_objects(tv_x07, players()));
            if (await this.cinematic_skip_start())
            {
                print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            game_won();
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task tele_ext_a()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(1);
            print("teleporting players...");
            object_teleport(await this.player0(), qz_ext_a_a);
            object_teleport(await this.player1(), qz_ext_a_b);
            fade_in(0F, 0F, 0F, 60);
            print("erasing ai...");
            ai_erase_all();
            await sleep(5);
            print("initializing area scripts...");
            wake(new ScriptMethodReference(enc_qz_ext_a));
            await sleep(10);
            player_enable_input(true);
            await sleep_until(async () => volume_test_objects(tv_factory, players()));
            wake(new ScriptMethodReference(enc_crashed_factory));
            await sleep_until(async () => volume_test_objects(tv_qz_ext_b, players()));
            wake(new ScriptMethodReference(enc_qz_ext_b));
            await sleep_until(async () => volume_test_objects(tv_key_ride, players()));
            wake(new ScriptMethodReference(enc_key_ride));
            await sleep_until(async () => volume_test_objects(tv_x07, players()));
            if (await this.cinematic_skip_start())
            {
                print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            game_won();
        }

        [ScriptMethod(301, Lifecycle.Static)]
        public async Task tele_factory_1()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(2);
            print("teleporting players...");
            object_teleport(await this.player0(), factory1_a);
            object_teleport(await this.player1(), factory1_b);
            fade_in(0F, 0F, 0F, 60);
            print("erasing ai...");
            ai_erase_all();
            await sleep(5);
            print("initializing area scripts...");
            wake(new ScriptMethodReference(enc_crashed_factory));
            await sleep(10);
            player_enable_input(true);
            await sleep_until(async () => volume_test_objects(tv_qz_ext_b, players()));
            wake(new ScriptMethodReference(enc_qz_ext_b));
            await sleep_until(async () => volume_test_objects(tv_key_ride, players()));
            wake(new ScriptMethodReference(enc_key_ride));
            await sleep_until(async () => volume_test_objects(tv_x07, players()));
            if (await this.cinematic_skip_start())
            {
                print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            game_won();
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task tele_ext_b()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(2);
            print("teleporting players...");
            object_teleport(await this.player0(), qz_ext_b_a);
            object_teleport(await this.player1(), qz_ext_b_b);
            fade_in(0F, 0F, 0F, 60);
            print("erasing ai...");
            ai_erase_all();
            await sleep(5);
            print("initializing area scripts...");
            wake(new ScriptMethodReference(enc_qz_ext_b));
            await sleep(10);
            player_enable_input(true);
            await sleep_until(async () => volume_test_objects(tv_key_ride, players()));
            wake(new ScriptMethodReference(enc_key_ride));
            await sleep_until(async () => volume_test_objects(tv_x07, players()));
            if (await this.cinematic_skip_start())
            {
                print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            game_won();
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task tele_key()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(3);
            print("teleporting players...");
            object_teleport(await this.player0(), key_ride_a);
            object_teleport(await this.player1(), key_ride_b);
            fade_in(0F, 0F, 0F, 60);
            print("erasing ai...");
            ai_erase_all();
            await sleep(5);
            print("initializing area scripts...");
            wake(new ScriptMethodReference(enc_key_ride));
            await sleep(10);
            player_enable_input(true);
            await sleep_until(async () => volume_test_objects(tv_x07, players()));
            if (await this.cinematic_skip_start())
            {
                print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            game_won();
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task tele_library()
        {
            fade_out(0F, 0F, 0F, 0);
            await sleep(1);
            player_enable_input(false);
            print("switching bsp...");
            await sleep(15);
            switch_bsp(4);
            print("teleporting players...");
            object_teleport(await this.player0(), library_a);
            object_teleport(await this.player1(), library_b);
            fade_in(0F, 0F, 0F, 60);
            print("erasing ai...");
            ai_erase_all();
            await sleep(5);
            print("initializing area scripts...");
            await sleep(10);
            player_enable_input(true);
            await sleep_until(async () => volume_test_objects(tv_x07, players()));
            if (await this.cinematic_skip_start())
            {
                print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            game_won();
        }
    }
}