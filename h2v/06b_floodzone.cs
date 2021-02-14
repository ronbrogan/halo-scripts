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
        public async Task _06_intra1_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_06_intra1_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _06_intra2_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_06_intra2_01_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _06_intra2_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_06_intra2_02_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _06_intra2_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_06_intra2_03_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x07_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x07_01_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x07_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x07_02_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x07_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x07_03_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x07_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x07_04_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x07_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x07_05_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task x07_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x07_06_predict));
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c06_intra1_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\music\\c06_intra1_01_mus", 3831104228U), default(IGameObject), 1F);
            Engine.print("c06_intra1 score 01 start");
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c06_intra1_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\foley\\c06_intra1_01_fol", 3831169765U), default(IGameObject), 1F);
            Engine.print("c06_intra1 foley 01 start");
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c06_2070_der()
        {
            await Engine.sleep(69);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2070_der", 3831235302U), dervish_intra1.Entity, 1F);
            Engine.cinematic_subtitle("c06_2070_der", 7F);
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c06_2090_soc()
        {
            await Engine.sleep(303);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2090_soc", 3831300839U), commander_intra1.Entity, 1F);
            Engine.cinematic_subtitle("c06_2090_soc", 8F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c06_2101_elc()
        {
            await Engine.sleep(533);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2101_elc", 3831366376U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c06_2101_elc", 3F);
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c06_2110_soc()
        {
            await Engine.sleep(610);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2110_soc", 3831431913U), commander_intra1.Entity, 1F);
            Engine.cinematic_subtitle("c06_2110_soc", 3F);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c06_2120_soc()
        {
            await Engine.sleep(693);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_2120_soc", 3831497450U), commander_intra1.Entity, 1F);
            Engine.cinematic_subtitle("c06_2120_soc", 2F);
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c06_intra1_dof_01()
        {
            await Engine.sleep(0);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(5F, 1F, 1F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(165);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c06_intra1_dof_02()
        {
            Engine.time_code_reset();
            await Engine.sleep(587);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(3F, 0F, 0F, 0F, 0.5F, 0.5F, 0F);
            Engine.print("rack focus");
            Engine.object_destroy_containing("elite");
            await Engine.sleep(190);
            Engine.cinematic_screen_effect_set_depth_of_field(3F, 0F, 0.5F, 1F, 0.5F, 0F, 1F);
            Engine.print("rack focus");
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c06_intra1_cinematic_light()
        {
            Engine.cinematic_lighting_set_primary_light(-20F, 282F, 0.21F, 0.29F, 0.37F);
            Engine.cinematic_lighting_set_secondary_light(-59F, 306F, 0.34F, 0.58F, 0.65F);
            Engine.cinematic_lighting_set_ambient_light(0.07F, 0.05F, 0.08F);
            Engine.object_uses_cinematic_lighting(dervish_intra1.Entity, true);
            Engine.object_uses_cinematic_lighting(commander_intra1.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_01.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_02.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_03.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_04.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_intra1.Entity, true);
            Engine.object_uses_cinematic_lighting(spectre_intra1.Entity, true);
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task c06_intra1_setup()
        {
            Engine.object_create_anew(dervish_intra1);
            Engine.object_create_anew(commander_intra1);
            Engine.object_create_anew(elite_01);
            Engine.object_create_anew(elite_02);
            Engine.object_create_anew(elite_03);
            Engine.object_create_anew(elite_04);
            Engine.object_create_anew(phantom_intra1);
            Engine.object_create_anew(spectre_intra1);
            Engine.cinematic_clone_players_weapon(dervish_intra1.Entity, "left_hand_elite", "");
            Engine.object_cinematic_lod(dervish_intra1.Entity, true);
            Engine.object_cinematic_lod(commander_intra1.Entity, true);
            Engine.object_cinematic_lod(elite_01.Entity, true);
            Engine.object_cinematic_lod(elite_02.Entity, true);
            Engine.object_cinematic_lod(elite_03.Entity, true);
            Engine.object_cinematic_lod(elite_04.Entity, true);
            Engine.object_cinematic_lod(phantom_intra1.Entity, true);
            Engine.object_cinematic_lod(spectre_intra1.Entity, true);
            Engine.wake(new ScriptMethodReference(c06_intra1_score_01));
            Engine.wake(new ScriptMethodReference(c06_intra1_foley_01));
            Engine.wake(new ScriptMethodReference(c06_2070_der));
            Engine.wake(new ScriptMethodReference(c06_2090_soc));
            Engine.wake(new ScriptMethodReference(c06_2101_elc));
            Engine.wake(new ScriptMethodReference(c06_2110_soc));
            Engine.wake(new ScriptMethodReference(c06_2120_soc));
            Engine.wake(new ScriptMethodReference(c06_intra1_dof_01));
            Engine.wake(new ScriptMethodReference(c06_intra1_dof_02));
            Engine.wake(new ScriptMethodReference(c06_intra1_cinematic_light));
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task c06_intra1_cleanup()
        {
            Engine.object_destroy_containing("intra1");
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(46, Lifecycle.Static)]
        public async Task c06_intra1()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("vehicle", 0.25F, 1);
            Engine.sound_class_set_gain("amb", 0.5F, 1);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("sentinelhq_2"));
            await Engine.sleep(1);
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._06_intra1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\music\\c06_intra1_01_mus", 3831104228U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra1\\foley\\c06_intra1_01_fol", 3831169765U));
            await Engine.sleep(this.prediction_offset);
            await this.c06_intra1_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra1\\06_intra1", 3831562987U), "06_intra1_01", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(dervish_intra1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra1\\06_intra1", 3831628524U), "dervish_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(commander_intra1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3831759598U), "soc_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(elite_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3831759598U), "elite01_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(elite_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3831759598U), "elite02_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(elite_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3831759598U), "elite03_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(elite_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra1\\06_intra1", 3831759598U), "elite04_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_intra1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intra1\\06_intra1", 3831890672U), "phantom_01", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(spectre_intra1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\spectre\\06_intra1\\06_intra1", 3831956209U), "spectre_01", false, anchor_intra1.Entity);
            await Engine.sleep(15);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c06_intra1_cleanup();
            await Engine.sleep(30);
            Engine.sound_class_set_gain("vehicle", 1F, 1);
            Engine.sound_class_set_gain("amb", 1F, 1);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c06_intra2_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\music\\c06_intra_2_01_mus", 3832021746U), default(IGameObject), 1F);
            Engine.print("c06_intra2 score 01 start");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task c06_intra2_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_01_fol", 3832087283U), default(IGameObject), 1F);
            Engine.print("c06_intra2 foley 01 start");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task c06_3010_soc()
        {
            await Engine.sleep(550);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_3010_soc", 3832152820U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c06_3010_soc", 3F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task c06_intra2_cinematic_light()
        {
            Engine.cinematic_lighting_set_primary_light(40F, 40F, 0.24F, 0.25F, 0.27F);
            Engine.cinematic_lighting_set_secondary_light(-72F, 134F, 0.23F, 0.27F, 0.29F);
            Engine.cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(commander.Entity, true);
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c06_intra2_01_setup()
        {
            Engine.object_destroy(key.Entity);
            Engine.object_create_anew(dervish);
            Engine.object_create_anew(commander);
            Engine.object_create_anew(energy_blade);
            Engine.object_create_anew(key_intra2_01);
            Engine.object_create_anew(key_intra2_02);
            Engine.objects_attach(commander.Entity, "left_hand_elite", energy_blade.Entity, "");
            Engine.object_set_permutation(energy_blade.Entity, "blade", "noblade");
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(index_container.Entity, true);
            Engine.object_cinematic_lod(key_intra2_01.Entity, true);
            Engine.object_cinematic_lod(key_intra2_02.Entity, true);
            Engine.wake(new ScriptMethodReference(c06_intra2_score_01));
            Engine.wake(new ScriptMethodReference(c06_intra2_foley_01));
            Engine.wake(new ScriptMethodReference(c06_3010_soc));
            Engine.wake(new ScriptMethodReference(c06_intra2_cinematic_light));
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task c06_intra2_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._06_intra2_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\music\\c06_intra_2_01_mus", 3832021746U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_01_fol", 3832087283U));
            await Engine.sleep(this.prediction_offset);
            await this.c06_intra2_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra2\\06_intra2", 3832218357U), "06_intra2_01", default(IUnit), anchor_flag_intra2);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra2\\06_intra2", 3832283894U), "dervish_01", false, anchor_intra2.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra2\\06_intra2", 3832349431U), "commander_01", false, anchor_intra2.Entity);
            Engine.scenery_animation_start_relative(key_intra2_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3832414968U), "intra2_dervishkey_01", anchor_intra2.Entity);
            Engine.scenery_animation_start_relative(key_intra2_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3832414968U), "intra2_humankey_01", anchor_intra2.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._06_intra2_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_02_fol", 3832480505U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c06_intra2_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_02_fol", 3832480505U), default(IGameObject), 1F);
            Engine.print("c06_intra2 foley 02 start");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c06_3030_soc()
        {
            await Engine.sleep(73);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\c06_3030_soc", 3832546042U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c06_3030_soc", 3F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task blade_activate()
        {
            Engine.time_code_reset();
            await Engine.sleep(87);
            Engine.object_set_permutation(energy_blade.Entity, "blade", "default");
            Engine.object_set_function_variable(energy_blade.Entity, "turned_on", 1F, 0F);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\melee\\energy_blade\\blade_activate_replace", 3832611579U), commander.Entity, "left_hand_elite");
            Engine.print("blade activate");
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task kill_switch()
        {
            await Engine.sleep(307);
            Engine.print("delete switch");
            Engine.object_destroy(key_switch.Entity);
        }

        [ScriptMethod(57, Lifecycle.Static)]
        public async Task c06_intra2_02_setup()
        {
            Engine.cinematic_set_far_clip_distance(2048F);
            Engine.print("set far clip");
            Engine.wake(new ScriptMethodReference(c06_intra2_foley_02));
            Engine.wake(new ScriptMethodReference(c06_3030_soc));
            Engine.wake(new ScriptMethodReference(blade_activate));
            Engine.wake(new ScriptMethodReference(kill_switch));
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c06_intra2_02_cleanup()
        {
            Engine.object_destroy(commander.Entity);
            Engine.object_destroy_containing("key_intra2_02");
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c06_intra2_scene_02()
        {
            await this.c06_intra2_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra2\\06_intra2", 3832218357U), "06_intra2_02", default(IUnit), anchor_flag_intra2);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra2\\06_intra2", 3832283894U), "dervish_02", false, anchor_intra2.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\06_intra2\\06_intra2", 3832349431U), "commander_02", false, anchor_intra2.Entity);
            Engine.scenery_animation_start_relative(key_intra2_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3832414968U), "intra2_dervishkey_02", anchor_intra2.Entity);
            Engine.scenery_animation_start_relative(key_intra2_02.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3832414968U), "intra2_humankey_02", anchor_intra2.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._06_intra2_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_03_fol", 3832742653U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c06_intra2_02_cleanup();
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c06_intra2_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\c06_intra2\\foley\\c06_intra2_03_fol", 3832742653U), default(IGameObject), 1F);
            Engine.print("c06_intra2 foley 03 start");
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task l06_0300_tar()
        {
            await Engine.sleep(74);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\mission\\l06_0300_tar", 3832808190U), default(IGameObject), 1F, "radio_covy");
            Engine.cinematic_subtitle("l06_0300_tar", 2F);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task l06_0310_tar()
        {
            await Engine.sleep(164);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\mission\\l06_0310_tar", 3832873727U), default(IGameObject), 1F, "radio_covy");
            Engine.cinematic_subtitle("l06_0310_tar", 2.5F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task key_door_open()
        {
            await Engine.sleep(210);
            Engine.print("key door open");
            Engine.device_set_position(key_ride_door0.Entity, 1F);
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task c06_intra2_03_setup()
        {
            Engine.object_create_anew(phantom_01);
            Engine.object_cinematic_lod(phantom_01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_01.Entity, true);
            Engine.wake(new ScriptMethodReference(c06_intra2_foley_03));
            Engine.wake(new ScriptMethodReference(l06_0300_tar));
            Engine.wake(new ScriptMethodReference(l06_0310_tar));
            Engine.wake(new ScriptMethodReference(key_door_open));
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task c06_intra2_03_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(phantom_01.Entity);
            Engine.object_destroy(key_intra2_01.Entity);
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task c06_intra2_scene_03()
        {
            await this.c06_intra2_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\06_intra2\\06_intra2", 3832218357U), "06_intra2_03", default(IUnit), anchor_flag_intra2);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\06_intra2\\06_intra2", 3832283894U), "dervish_03", false, anchor_intra2.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\06_intra2\\06_intra2", 3832939264U), "phantom_03", false, anchor_intra2.Entity);
            Engine.scenery_animation_start_relative(key_intra2_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\06_intra2\\06_intra2", 3832414968U), "intra2_dervishkey_03", anchor_intra2.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c06_intra2_03_cleanup();
            await Engine.sleep(30);
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task c06_intra2()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("sen_hq_bsp_5"));
            await Engine.sleep(1);
            await this.c06_intra2_scene_01();
            await this.c06_intra2_scene_02();
            await this.c06_intra2_scene_03();
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task x07_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_01_fol", 3833004801U), default(IGameObject), 1F);
            Engine.print("x07 foley 01 start");
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x07_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(-46F, 220F, 0.26F, 0.23F, 0.2F);
            Engine.cinematic_lighting_set_secondary_light(63F, 262F, 0.23F, 0.27F, 0.29F);
            Engine.cinematic_lighting_set_ambient_light(0.02F, 0.02F, 0.02F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(x07_tentacle.Entity, true);
            Engine.print("tentacle cinematic lighting");
            Engine.object_uses_cinematic_lighting(index_container.Entity, true);
        }

        [ScriptMethod(70, Lifecycle.Static)]
        public async Task x07_01_setup()
        {
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(x07_tentacle);
            Engine.object_create_anew(index_container);
            Engine.print("tentacle created");
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(index_container.Entity, true);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 0);
            Engine.print("miranda - pain .25 0");
            Engine.wake(new ScriptMethodReference(x07_foley_01));
            Engine.wake(new ScriptMethodReference(x07_cinematic_light_01));
        }

        [ScriptMethod(71, Lifecycle.Static)]
        public async Task x07_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x07_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_02_mus", 3833070338U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_01_fol", 3833004801U));
            await Engine.sleep(this.prediction_offset);
            await this.x07_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_01", default(IUnit), anchor_flag_x07);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3833201412U), "miranda_01", false, anchor_x07.Entity);
            Engine.scenery_animation_start_relative(x07_tentacle.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x07\\x07", 3835757355U), "tentacle_02", anchor_x07.Entity);
            Engine.print("tentacle 02 animation relative started");
            Engine.scenery_animation_start_relative(x07_tentacle.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x07\\x07", 3835757355U), "tentacle_01", anchor_x07.Entity);
            Engine.print("tentacle 01 animation relative started");
            Engine.scenery_animation_start_relative(index_container.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3835822892U), "x07_01", anchor_x07.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x07_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_02_fol", 3835888429U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task x07_score_02()
        {
            await Engine.sleep(279);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_02_mus", 3833070338U), default(IGameObject), 1F);
            Engine.print("x07 score 02 start");
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task x07_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_02_fol", 3835888429U), default(IGameObject), 1F);
            Engine.print("x07 foley 02 start");
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task x07_0010_mir()
        {
            await Engine.sleep(249);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0010_mir", 3835953966U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x07_0010_mir", 1F);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x07_0020_jon()
        {
            await Engine.sleep(399);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0020_jon", 3836019503U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x07_0020_jon", 4F);
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x07_0030_mir()
        {
            await Engine.sleep(540);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0030_mir", 3836085040U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x07_0030_mir", 1.5F);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 15);
            Engine.print("miranda - pain .25 15");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x07_emotion_miranda_01()
        {
            await Engine.sleep(330);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 0);
            Engine.print("miranda - shocked .5 0");
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x07_emotion_miranda_02()
        {
            await Engine.sleep(520);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            Engine.print("miranda - shocked .25 0");
        }

        [ScriptMethod(79, Lifecycle.Static)]
        public async Task x07_02_setup()
        {
            Engine.object_create_anew(johnson);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.wake(new ScriptMethodReference(x07_score_02));
            Engine.wake(new ScriptMethodReference(x07_foley_02));
            Engine.wake(new ScriptMethodReference(x07_0010_mir));
            Engine.wake(new ScriptMethodReference(x07_0020_jon));
            Engine.wake(new ScriptMethodReference(x07_0030_mir));
            Engine.wake(new ScriptMethodReference(x07_emotion_miranda_01));
            Engine.wake(new ScriptMethodReference(x07_emotion_miranda_02));
        }

        [ScriptMethod(80, Lifecycle.Static)]
        public async Task x07_scene_02()
        {
            await this.x07_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_02", default(IUnit), anchor_flag_x07);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3833201412U), "miranda_02", false, anchor_x07.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3836150577U), "johnson_02", false, anchor_x07.Entity);
            Engine.scenery_animation_start_relative(x07_tentacle.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x07\\x07", 3835757355U), "tentacle_02", anchor_x07.Entity);
            Engine.print("tentacle 02 animation started");
            Engine.scenery_animation_start_relative(index_container.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3835822892U), "x07_02", anchor_x07.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x07_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_03_mus", 3836281651U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_03_fol", 3836347188U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(x07_tentacle.Entity);
            Engine.print("tentacle destroyed");
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x07_score_03()
        {
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\music\\x07_03_mus", 3836281651U), default(IGameObject), 1F);
            Engine.print("x07 score 03 start");
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x07_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_03_fol", 3836347188U), default(IGameObject), 1F);
            Engine.print("x07 foley 03 start");
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x07_0040_jon()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0040_jon", 3836412725U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x07_0040_jon", 2F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x07_0050_jon()
        {
            await Engine.sleep(77);
            Engine.unit_set_emotional_state(johnson.Entity, "pain", 0.25F, 0);
            Engine.print("johnson - pain .25 0");
            await Engine.sleep(10);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0050_jon", 3836478262U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x07_0050_jon", 1.5F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x07_0060_jon()
        {
            await Engine.sleep(150);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0060_jon", 3836543799U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x07_0060_jon", 1F);
            await Engine.sleep(25);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 15);
            Engine.print("miranda - shocked .25 15");
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task x07_0070_jon()
        {
            await Engine.sleep(540);
            Engine.unit_set_emotional_state(johnson.Entity, "shocked", 0.25F, 10);
            Engine.print("johnson - shocked .25 10");
            await Engine.sleep(10);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0070_jon", 3836609336U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x07_0070_jon", 1F);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task x07_0080_jon()
        {
            await Engine.sleep(678);
            Engine.unit_set_emotional_state(johnson.Entity, "annoyed", 0.75F, 60);
            Engine.print("johnson - annoyed .75 60");
            await Engine.sleep(10);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0080_jon", 3836674873U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x07_0080_jon", 1F);
            await Engine.sleep(45);
            Engine.unit_set_emotional_state(johnson.Entity, "shocked", 0.5F, 30);
            Engine.print("johnson - shocked .5 30");
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task x07_0090_mir()
        {
            await Engine.sleep(776);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0090_mir", 3836740410U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x07_0090_mir", 1F);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task x07_0100_mir()
        {
            await Engine.sleep(800);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0100_mir", 3836805947U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x07_0100_mir", 1F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task miranda_smgs_fire_1()
        {
            await Engine.sleep(834);
            Engine.object_create_anew(smg_real_01);
            Engine.object_create_anew(smg_real_02);
            Engine.object_set_scale(smg_real_01.Entity, 1F, 0);
            Engine.object_set_scale(smg_real_02.Entity, 1F, 0);
            Engine.objects_attach(miranda.Entity, "right_hand", smg_real_01.Entity, "");
            Engine.objects_attach(miranda.Entity, "left_hand", smg_real_02.Entity, "");
            await Engine.sleep(5);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("smg_real_01"), 0, true);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("smg_real_02"), 0, true);
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task johnson_rifle_fire()
        {
            await Engine.sleep(563);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(10);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(21);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
            await Engine.sleep(2);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\weapons\\rifle\\battle_rifle\\fire_bullet", 3836871484U), johnson_rifle.Entity, "primary_trigger");
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task dervish_cammo()
        {
            await Engine.sleep(627);
            Engine.print("effect - cammo off");
            Engine.unit_set_active_camo(dervish.Entity, false, 1F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x07_cinematic_light_03()
        {
            Engine.cinematic_lighting_set_primary_light(16F, 82F, 0.25F, 0.32F, 0.32F);
            Engine.cinematic_lighting_set_secondary_light(24F, 272F, 0.22F, 0.26F, 0.28F);
            Engine.cinematic_lighting_set_ambient_light(0.02F, 0.02F, 0.02F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda_smg_01.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda_smg_02.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_rifle.Entity, true);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task johnson_rifle_arm()
        {
            await Engine.sleep(105);
            Engine.objects_attach(johnson.Entity, "right_hand", johnson_rifle.Entity, "");
        }

        [ScriptMethod(95, Lifecycle.Static)]
        public async Task x07_03_setup()
        {
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_07", 3837592391U));
            Engine.object_create_anew(dervish);
            Engine.object_cannot_die(dervish.Entity, true);
            Engine.unit_set_active_camo(dervish.Entity, true, 0F);
            Engine.object_create_anew(miranda_smg_01);
            Engine.object_create_anew(miranda_smg_02);
            Engine.object_create_anew(johnson_rifle);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_cinematic_lod(miranda_smg_01.Entity, true);
            Engine.object_cinematic_lod(miranda_smg_02.Entity, true);
            Engine.object_cinematic_lod(johnson_rifle.Entity, true);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 0);
            Engine.print("miranda - pain .25 0");
            Engine.unit_set_emotional_state(johnson.Entity, "pensive", 0.25F, 0);
            Engine.print("johnson - pensive .25 0");
            Engine.wake(new ScriptMethodReference(x07_score_03));
            Engine.wake(new ScriptMethodReference(x07_foley_03));
            Engine.wake(new ScriptMethodReference(x07_0040_jon));
            Engine.wake(new ScriptMethodReference(x07_0050_jon));
            Engine.wake(new ScriptMethodReference(x07_0060_jon));
            Engine.wake(new ScriptMethodReference(x07_0070_jon));
            Engine.wake(new ScriptMethodReference(x07_0080_jon));
            Engine.wake(new ScriptMethodReference(x07_0090_mir));
            Engine.wake(new ScriptMethodReference(x07_0100_mir));
            Engine.wake(new ScriptMethodReference(miranda_smgs_fire_1));
            Engine.wake(new ScriptMethodReference(johnson_rifle_arm));
            Engine.wake(new ScriptMethodReference(johnson_rifle_fire));
            Engine.wake(new ScriptMethodReference(dervish_cammo));
            Engine.wake(new ScriptMethodReference(x07_cinematic_light_03));
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task x07_scene_03()
        {
            await this.x07_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_03", default(IUnit), anchor_flag_x07);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3833201412U), "miranda_03", false, anchor_x07.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3836150577U), "johnson_03", false, anchor_x07.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3837789002U), "dervish_03", false, anchor_x07.Entity);
            Engine.scenery_animation_start_relative(index_container.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3835822892U), "x07_03", anchor_x07.Entity);
            Engine.scenery_animation_start_relative(miranda_smg_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3837854539U), "smg01_03", anchor_x07.Entity);
            Engine.scenery_animation_start_relative(miranda_smg_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3837854539U), "smg02_03", anchor_x07.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x07_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_04_fol", 3837920076U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x07_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_04_fol", 3837920076U), default(IGameObject), 1F);
            Engine.print("x07 foley 04 start");
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x07_0110_mir()
        {
            await Engine.sleep(117);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0110_mir", 3837985613U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x07_0110_mir", 1.5F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x07_0120_mir()
        {
            await Engine.sleep(169);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0120_mir", 3838051150U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x07_0120_mir", 1F);
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task x07_0130_tar()
        {
            await Engine.sleep(483);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0130_tar", 3838116687U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x07_0130_tar", 4F);
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task x07_0140_der()
        {
            await Engine.sleep(614);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0140_der", 3838182224U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x07_0140_der", 3F);
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task effect_miranda_hit()
        {
            Engine.time_code_reset();
            await Engine.sleep(338);
            Engine.print("effect - miranda hit");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\brute\\hammer_grappling", 3838247761U), miranda.Entity, "body");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x07_cinematic_light_04()
        {
            Engine.cinematic_lighting_set_primary_light(33F, 42F, 0.2F, 0.25F, 0.25F);
            Engine.cinematic_lighting_set_secondary_light(-54F, 0F, 0.23F, 0.27F, 0.29F);
            Engine.cinematic_lighting_set_ambient_light(0.02F, 0.02F, 0.02F);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(104, Lifecycle.Static)]
        public async Task x07_scene_05_problem_actors()
        {
            Engine.print("create problem actors");
            Engine.object_create_anew_containing("brute");
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(brute_03.Entity, true);
            Engine.object_cinematic_lod(brute_04.Entity, true);
            Engine.object_cinematic_lod(brute_shot_01.Entity, true);
            Engine.object_cinematic_lod(brute_shot_02.Entity, true);
            Engine.object_cinematic_lod(brute_rifle_01.Entity, true);
            Engine.object_cinematic_lod(brute_rifle_02.Entity, true);
            Engine.objects_attach(brute_03.Entity, "right_hand", brute_shot_01.Entity, "right_hand_brute");
            Engine.objects_attach(brute_04.Entity, "right_hand", brute_shot_02.Entity, "right_hand_brute");
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_03.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_04.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_shot_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_shot_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_rifle_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_rifle_02.Entity, true);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x07_emotion_miranda_03()
        {
            await Engine.sleep(300);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 0);
            Engine.print("miranda - shocked .5 0");
            await Engine.sleep(38);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.8F, 10);
            Engine.print("miranda - shocked 1 10");
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task tartarus_hide_seek()
        {
            await Engine.sleep(5);
            Engine.object_hide(tartarus.Entity, true);
            Engine.object_hide(hammer.Entity, true);
            await Engine.sleep(400);
            Engine.object_hide(tartarus.Entity, false);
            Engine.object_hide(hammer.Entity, false);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task miranda_smgs_destroy()
        {
            Engine.time_code_reset();
            await Engine.sleep(98);
            Engine.print("stop firing");
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("smg_real_01"), 0, false);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("smg_real_02"), 0, false);
            await Engine.sleep(131);
            Engine.print("destroy smgs");
            Engine.objects_detach(miranda.Entity, smg_real_01.Entity);
            Engine.objects_detach(miranda.Entity, smg_real_02.Entity);
            Engine.object_destroy_containing("smg_real");
        }

        [ScriptMethod(108, Lifecycle.Static)]
        public async Task x07_04_setup()
        {
            Engine.object_create_anew(tartarus);
            Engine.object_create(hammer);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(hammer.Entity, true);
            Engine.wake(new ScriptMethodReference(x07_foley_04));
            Engine.wake(new ScriptMethodReference(x07_0110_mir));
            Engine.wake(new ScriptMethodReference(x07_0120_mir));
            Engine.wake(new ScriptMethodReference(x07_0130_tar));
            Engine.wake(new ScriptMethodReference(x07_0140_der));
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            Engine.print("miranda - shocked .25 0");
            Engine.wake(new ScriptMethodReference(x07_emotion_miranda_03));
            Engine.wake(new ScriptMethodReference(miranda_smgs_destroy));
            Engine.wake(new ScriptMethodReference(tartarus_hide_seek));
            Engine.wake(new ScriptMethodReference(x07_cinematic_light_04));
            Engine.wake(new ScriptMethodReference(effect_miranda_hit));
        }

        [ScriptMethod(109, Lifecycle.Static)]
        public async Task x07_scene_04()
        {
            await this.x07_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_04", default(IUnit), anchor_flag_x07);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3833201412U), "miranda_04", false, anchor_x07.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3836150577U), "johnson_04", false, anchor_x07.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3837789002U), "dervish_04", false, anchor_x07.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3838772057U), "tartarus_04", false, anchor_x07.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x07\\x07", 3838903131U), "hammer_04", anchor_x07.Entity);
            Engine.scenery_animation_start_relative(miranda_smg_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3837854539U), "smg01_04", anchor_x07.Entity);
            Engine.scenery_animation_start_relative(miranda_smg_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\x07\\x07", 3837854539U), "smg02_04", anchor_x07.Entity);
            Engine.scenery_animation_start_relative(index_container.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3835822892U), "x07_04", anchor_x07.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x07_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_05_fol", 3838968668U));
            await this.x07_scene_05_problem_actors();
            await Engine.sleep((short)Engine.camera_time());
            Engine.objects_detach(johnson.Entity, johnson_rifle.Entity);
            Engine.object_destroy(johnson_rifle.Entity);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x07_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_05_fol", 3838968668U), default(IGameObject), 1F);
            Engine.print("x07 foley 05 start");
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x07_0150_tar()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0150_tar", 3839034205U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x07_0150_tar", 1.5F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task x07_0160_tar()
        {
            await Engine.sleep(48);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0160_tar", 3839099742U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x07_0160_tar", 2F);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task x07_0170_tar()
        {
            await Engine.sleep(302);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0170_tar", 3839165279U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x07_0170_tar", 4F);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task x07_0180_tar()
        {
            await Engine.sleep(428);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0180_tar", 3839230816U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x07_0180_tar", 5.5F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task x07_0190_der()
        {
            await Engine.sleep(591);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0190_der", 3839296353U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x07_0190_der", 2.5F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task destroy_miranda()
        {
            await Engine.sleep(428);
            Engine.object_destroy(miranda.Entity);
            Engine.print("destroy miranda");
        }

        [ScriptMethod(117, Lifecycle.Static)]
        public async Task x07_05_setup()
        {
            Engine.wake(new ScriptMethodReference(x07_foley_05));
            Engine.wake(new ScriptMethodReference(x07_0150_tar));
            Engine.wake(new ScriptMethodReference(x07_0160_tar));
            Engine.wake(new ScriptMethodReference(x07_0170_tar));
            Engine.wake(new ScriptMethodReference(x07_0180_tar));
            Engine.wake(new ScriptMethodReference(x07_0190_der));
            Engine.unit_set_emotional_state(miranda.Entity, "asleep", 1F, 0);
            Engine.print("miranda - asleep 1 0");
            Engine.unit_set_emotional_state(johnson.Entity, "asleep", 1F, 0);
            Engine.print("johnson - asleep 1 0");
            Engine.wake(new ScriptMethodReference(destroy_miranda));
        }

        [ScriptMethod(118, Lifecycle.Static)]
        public async Task x07_05_cleanup()
        {
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy_containing("brute");
        }

        [ScriptMethod(119, Lifecycle.Static)]
        public async Task x07_scene_05()
        {
            await this.x07_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_05", default(IUnit), anchor_flag_x07);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x07\\x07", 3833201412U), "miranda_05", false, anchor_x07.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x07\\x07", 3836150577U), "johnson_05", false, anchor_x07.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3837789002U), "dervish_05", false, anchor_x07.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3838772057U), "tartarus_05", false, anchor_x07.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3838772057U), "brute01_05", false, anchor_x07.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3838772057U), "brute02_05", false, anchor_x07.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3838772057U), "brute03_05", false, anchor_x07.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3838772057U), "brute04_05", false, anchor_x07.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x07\\x07", 3838903131U), "hammer_05", anchor_x07.Entity);
            Engine.scenery_animation_start_relative(index_container.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3835822892U), "x07_05", anchor_x07.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x07_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_06_fol", 3839361890U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x07_05_cleanup();
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task x07_foley_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\06_sentinelwalls\\x07\\foley\\x07_06_fol", 3839361890U), default(IGameObject), 1F);
            Engine.print("x07 foley 06 start");
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task x07_0200_tar()
        {
            await Engine.sleep(86);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0200_tar", 3839427427U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("x07_0200_tar", 6.5F);
            await Engine.sleep(128);
            Engine.unit_set_emotional_state(tartarus.Entity, "inquisitive", 1F, 60);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task tartarus_bruteshot_fire()
        {
            await Engine.sleep(373);
            Engine.print("effect - tartarus' hammer");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\brute\\tartarus_hammer_impact_cinematic", 3839492964U), tartarus.Entity, "body");
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task tartarus_bruteshot_hit()
        {
            await Engine.sleep(380);
            Engine.print("effect - hammer hit");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\brute\\hammer_grappling", 3838247761U), dervish.Entity, "body");
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x07_predict_shaft_01()
        {
            await Engine.sleep(385);
            Engine.print("predict: camera");
            Engine.camera_predict_resources_at_frame(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_06", default(IUnit), anchor_flag_x07, 405);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task x07_predict_shaft_02()
        {
            await Engine.sleep(532);
            Engine.print("predict: camera");
            Engine.camera_predict_resources_at_frame(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_06", default(IUnit), anchor_flag_x07, 552);
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task x07_06_setup()
        {
            Engine.wake(new ScriptMethodReference(x07_foley_06));
            Engine.wake(new ScriptMethodReference(x07_0200_tar));
            Engine.wake(new ScriptMethodReference(tartarus_bruteshot_fire));
            Engine.wake(new ScriptMethodReference(tartarus_bruteshot_hit));
            Engine.wake(new ScriptMethodReference(x07_predict_shaft_01));
            Engine.wake(new ScriptMethodReference(x07_predict_shaft_02));
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x07_06_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy(hammer.Entity);
            Engine.object_destroy(index_container.Entity);
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task x07_scene_06()
        {
            await this.x07_06_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x07\\x07", 3833135875U), "x07_06", default(IUnit), anchor_flag_x07);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x07\\x07", 3837789002U), "dervish_06", false, anchor_x07.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\x07\\x07", 3838772057U), "tartarus_06", false, anchor_x07.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\x07\\x07", 3838903131U), "hammer_06", anchor_x07.Entity);
            Engine.scenery_animation_start_relative(index_container.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3835822892U), "x07_06", anchor_x07.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 1));
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            await this.x07_06_cleanup();
            Engine.sound_class_set_gain("amb", 0F, 60);
            await Engine.sleep(90);
        }

        [ScriptMethod(129, Lifecycle.Static)]
        public async Task x07()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("sen_hq_bsp_6"));
            await Engine.sleep(1);
            await this.x07_scene_01();
            await this.x07_scene_02();
            await this.x07_scene_03();
            await this.x07_scene_04();
            await this.x07_scene_05();
            await this.x07_scene_06();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(130, Lifecycle.CommandScript)]
        public async Task cs_invulnerable()
        {
            Engine.cs_enable_moving(true);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_certain);
            await Engine.sleep((short)(30 * 1));
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(131, Lifecycle.CommandScript)]
        public async Task cs_invul_8()
        {
            Engine.cs_enable_moving(true);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep((short)(30 * 8));
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(132, Lifecycle.CommandScript)]
        public async Task cs_kill()
        {
            Engine.ai_kill_silent(this.ai_current_actor);
        }

        [ScriptMethod(133, Lifecycle.Static)]
        public async Task no_death()
        {
            Engine.object_cannot_take_damage(Engine.ai_actors(covenant1));
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task ice_cream_superman()
        {
            Engine.object_create(ice_cream_head);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4168816389U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4168816389U)), 5);
            if (this.debug)
            {
                Engine.print("you're going to get fat!!!!! or dead...");
            }

            if (this.debug)
            {
                Engine.print("because now everyone is superman!!!!");
            }

            Engine.ice_cream_flavor_stock(10);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task music_06b_01()
        {
            await Engine.sleep_until(async () => this.g_music_06b_01);
            if (this.debug)
            {
                Engine.print("start music 06b_01");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_01", 4241300292U), default(IGameObject), 1F);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task music_06b_02()
        {
            await Engine.sleep_until(async () => this.g_music_06b_02);
            if (this.debug)
            {
                Engine.print("start music 06b_02");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_02", 4241431366U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06b_02));
            if (this.debug)
            {
                Engine.print("stop music 06b_02");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_02", 4241431366U));
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task music_06b_03()
        {
            await Engine.sleep_until(async () => this.g_music_06b_03);
            if (this.debug)
            {
                Engine.print("start music 06b_03");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_03", 4241693514U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06b_03));
            if (this.debug)
            {
                Engine.print("stop music 06b_03");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_03", 4241693514U));
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task music_06b_04()
        {
            await Engine.sleep_until(async () => this.g_music_06b_04);
            if (this.debug)
            {
                Engine.print("start music 06b_04");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_04", 4241890125U), default(IGameObject), 1F);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task music_06b_05()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e20_dock_entrance, Engine.players()));
            this.g_music_06b_05 = true;
            if (this.debug)
            {
                Engine.print("start music 06b_05");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_05", 4242021199U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.g_music_06b_05));
            if (this.debug)
            {
                Engine.print("stop music 06b_05");
            }

            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_05", 4242021199U));
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task music_06b_06()
        {
            await Engine.sleep_until(async () => this.g_music_06b_06);
            if (this.debug)
            {
                Engine.print("start music 06b_06");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_06", 4242217810U), default(IGameObject), 1F);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task music_06b_07()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_music_06b_07, Engine.players()));
            if (this.debug)
            {
                Engine.print("start music 06b_07");
            }

            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\06b_floodzone\\06b_music\\06b_07", 3837592391U), default(IGameObject), 1F);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task chapter_mirror()
        {
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task chapter_competition()
        {
            await Engine.sleep(30);
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task chapter_gallery()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_3);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task chapter_familiar()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_4);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task objective_push_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("push through the quarantine-zone toward the library.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task objective_push_clear()
        {
            Engine.print("objective complete:");
            Engine.print("push through the quarantine-zone toward the library.");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task objective_link_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("link-up with the spec-ops leader, and break through the flood barricade.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task objective_link_clear()
        {
            Engine.print("objective complete:");
            Engine.print("link-up with the spec-ops leader, and break through the flood barricade.");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task objective_retrieve_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("retrieve the sacred icon before the humans.");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task objective_retrieve_clear()
        {
            Engine.print("objective complete:");
            Engine.print("retrieve the sacred icon before the humans.");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task sc_cov_charge()
        {
            await Engine.sleep(60);
            if (this.dialogue)
            {
                Engine.print("commander: forward, warriors! and fear not pain or death!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0220"));
            await Engine.sleep((short)(this.dialogue_pause * 2));
            if (this.dialogue)
            {
                Engine.print("commander: go, arbiter! i'll follow when our reinforcements arrive!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0240"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => this.g_qz_cov_def_progress);
            if ((short)Engine.ai_living_count(cov_def_enf) <= 0)
            {
                await Engine.sleep(180);
            }
            else
            {
                await Engine.sleep(30);
            }

            if ((short)Engine.ai_living_count(cov_def_enf) > 0)
            {
                if (this.dialogue)
                {
                    Engine.print("spec-ops: go, enforcers!");
                }

                await Engine.sleep(Engine.ai_play_line(covenant1, "0590"));
                await Engine.sleep(this.dialogue_pause);
            }

            if (this.dialogue)
            {
                Engine.print("spec-ops: to the vehicles! we'll need their heavy-guns!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0600"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: onward! to the sacred icon!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0610"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(153, Lifecycle.CommandScript)]
        public async Task cs_sc_qz_veh_int()
        {
            if (this.dialogue)
            {
                Engine.print("spec-ops: what?! the parasite controls our vehicles?!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0620"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: impossible! it's never done that before!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0640"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: no matter. it will die all the same!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0650"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task sc_qz_veh_int()
        {
            await Engine.sleep(180);
            await Engine.sleep_until(async () => Engine.ai_scene("sc_qz_veh_int", new ScriptMethodReference(cs_sc_qz_veh_int), covenant1));
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task sc_ext_a()
        {
            if (this.dialogue)
            {
                Engine.print("commander: i'm sending you a squad of my most experienced warriors, arbiter.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0650"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("commander: do not squander their talents!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0660"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task sc_factory_approach()
        {
            if (this.dialogue)
            {
                Engine.print("commander: commander! we've found a human vehicle!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0250"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: keep moving. i'm on my way.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0260"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task sc_factory_exit()
        {
            await Engine.sleep(60);
            if (this.dialogue)
            {
                Engine.print("spec-ops: humans and parasites!");
            }

            if (this.dialogue)
            {
                Engine.print("this ring has been befouled, but we will wipe it clean!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0270"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: honoring those who built it!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0280"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task sc_human_fools()
        {
            if (this.dialogue)
            {
                Engine.print("commander: human fools. i almost feel sorry for them.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0290"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task sc_ext_b()
        {
            if (this.dialogue)
            {
                Engine.print("spec-ops: forward to the icon!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0700"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: the parasite's ranks swell as we draw nearer to the library!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0710"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("spec-ops: steel your nerves. we are not turning back!");
            }

            await Engine.sleep(Engine.ai_play_line(covenant1, "0720"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task sc_chasm()
        {
            if (this.dialogue)
            {
                Engine.print("tartarus: i see that coward didn't join you.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0300"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("tartarus: i'll do what i can to keep the flood off your back.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0310"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task sc_outer_wall()
        {
            if (this.dialogue)
            {
                Engine.print("tartarus: we cannot let the humans capture the icon!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0320"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("tartarus: the hierarchs do not look kindly on failure.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0330"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task sc_dock()
        {
            if (this.dialogue)
            {
                Engine.print("tartarus: hurry, arbiter! get the icon!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0340"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task<bool> driver_seat_test()
        {
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.a), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.b), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_ini.a), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_ini.b), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_hog_ab.hog), "warthog_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_ghost_ab.a), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_ghost_ab.b), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_scorpion.scorpion), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_flood_hog_bk.warthog), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_bk.a), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_flood_ghosts_bk.b), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_a_ghosts.a), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_a_ghosts.b), "ghost_d", Engine.players()))
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
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_l", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_r", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_hog_ab.hog), "warthog_p", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_hog_ab.hog), "warthog_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_flood_hog_bk.warthog), "warthog_p", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(veh_int_flood_hog_bk.warthog), "warthog_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_fact_warthog.warthog), "warthog_p", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_fact_warthog.warthog), "warthog_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_warthog.warthog), "warthog_p", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_warthog.warthog), "warthog_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_warthog_gauss.warthog), "warthog_p", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_warthog_gauss.warthog), "warthog_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre), "spectre_p_l", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre), "spectre_p_r", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre), "spectre_g", Engine.players()))
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
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/a"), Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task cov_def_spec_tele_b()
        {
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/b"), Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task cov_def_spec_tele_c()
        {
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/c"), Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(168, Lifecycle.CommandScript)]
        public async Task cov_def_spec_tele_d()
        {
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/d"), Engine.GetReference<ISpatialPoint>("bsp_swap_teleport/face"));
        }

        [ScriptMethod(169, Lifecycle.CommandScript)]
        public async Task cs_fact_ent_exit_veh()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("crashed_fact_ent"));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.ai_set_orders(covenant1, cov_follow_factory1);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(covenant1);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task ext_a_vehicle_orders()
        {
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant1, cov_drive_cov_def);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_cov_def);
                }

                return (short)Engine.structure_bsp_index() == 1;
            });
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    if ((short)Engine.structure_bsp_index() == 0)
                    {
                        Engine.ai_set_orders(covenant_infantry, cov_follow_cov_def);
                        Engine.ai_set_orders(covenant_vehicles, cov_drive_cov_def);
                    }
                    else if ((short)Engine.structure_bsp_index() == 1)
                    {
                        Engine.ai_set_orders(covenant_infantry, cov_follow_veh_int);
                        Engine.ai_set_orders(covenant_vehicles, cov_drive_veh_int_a);
                    }
                }
                else if (true)
                {
                    if ((short)Engine.structure_bsp_index() == 0)
                    {
                        Engine.ai_set_orders(covenant1, cov_follow_cov_def);
                    }
                    else if ((short)Engine.structure_bsp_index() == 1)
                    {
                        Engine.ai_set_orders(covenant1, cov_follow_veh_int);
                    }
                }

                return Engine.volume_test_objects(tv_veh_int_a, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_veh_int_a, Engine.players()) && (short)Engine.ai_living_count(veh_int_sen_a) <= 0 || this.g_veh_int_migrate_b;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    if ((short)Engine.structure_bsp_index() == 0)
                    {
                        Engine.ai_set_orders(covenant_infantry, cov_follow_cov_def);
                        Engine.ai_set_orders(covenant_vehicles, cov_drive_cov_def);
                    }
                    else if ((short)Engine.structure_bsp_index() == 1)
                    {
                        Engine.ai_set_orders(covenant_infantry, cov_follow_veh_int);
                        Engine.ai_set_orders(covenant_vehicles, cov_drive_veh_int_b);
                    }
                }
                else if (true)
                {
                    if ((short)Engine.structure_bsp_index() == 0)
                    {
                        Engine.ai_set_orders(covenant1, cov_follow_cov_def);
                    }
                    else if ((short)Engine.structure_bsp_index() == 1)
                    {
                        Engine.ai_set_orders(covenant1, cov_follow_veh_int);
                    }
                }

                return Engine.volume_test_objects(tv_veh_int_b, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_veh_int_b, Engine.players()) && (short)Engine.ai_living_count(veh_int_sen_b) <= 0 && (short)Engine.ai_living_count(veh_int_flood_b) <= 0 || this.g_veh_int_migrate_c;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_veh_int);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_veh_int_c);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_veh_int);
                }

                return Engine.volume_test_objects(tv_veh_int_c, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_veh_int_c, Engine.players()) && (short)Engine.ai_living_count(veh_int_sen_c) <= 0 && (short)Engine.ai_living_count(veh_int_flood_c) <= 0 || this.g_veh_int_migrate_d;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_veh_int);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_veh_int_d);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_veh_int);
                }

                return Engine.volume_test_objects(tv_veh_int_d, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_veh_int_d, Engine.players()) && (short)Engine.ai_living_count(veh_int_sen_d) <= 0 && (short)Engine.ai_living_count(veh_int_flood_d) <= 0 || this.g_veh_int_migrate_e;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_veh_int);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_veh_int_e);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_veh_int);
                }

                return Engine.volume_test_objects(tv_qz_ext_a, Engine.players()) || this.g_ext_a_dam_migrate_a;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a_dam);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_dam_a);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a_dam);
                }

                return Engine.volume_test_objects(tv_ext_a_dam_a, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_ext_a_dam_a, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_dam_a) <= 0 && (short)Engine.ai_living_count(ext_a_flood_dam_a) <= 0 || this.g_ext_a_dam_migrate_b;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a_dam);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_dam_b);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a_dam);
                }

                return Engine.volume_test_objects(qz_ext_a_dam_b, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(qz_ext_a_dam_b, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_dam_b) <= 0 && (short)Engine.ai_living_count(ext_a_flood_dam_b) <= 0 || this.g_ext_a_migrate_a;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_a);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return Engine.volume_test_objects(tv_ext_a_a, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_ext_a_a, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_a) <= 0 && (short)Engine.ai_living_count(ext_a_flood_a) <= 0 || this.g_ext_a_migrate_b;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_b);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return Engine.volume_test_objects(tv_ext_a_b, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_ext_a_b, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_b) <= 0 && (short)Engine.ai_living_count(ext_a_flood_b) <= 0 || this.g_ext_a_migrate_c;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_c);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return Engine.volume_test_objects(tv_ext_a_c, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_ext_a_c, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_c) <= 0 && (short)Engine.ai_living_count(ext_a_flood_c) <= 0 || this.g_ext_a_migrate_d;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_d);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return Engine.volume_test_objects(tv_ext_a_d, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_ext_a_d, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_d) <= 0 && (short)Engine.ai_living_count(ext_a_flood_d) <= 0 || this.g_ext_a_migrate_e;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_e);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a);
                }

                return Engine.volume_test_objects(tv_ext_a_e, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_ext_a_e, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_e) <= 0 && (short)Engine.ai_living_count(ext_a_flood_e) <= 0 || this.g_ext_a_migrate_f;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a_fact_ent);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_a_f);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a_fact_ent);
                }

                return Engine.volume_test_objects(tv_ext_a_f, Engine.players()) && (bool)Engine.ai_trigger_test("done_fighting", covenant1) || Engine.volume_test_objects(tv_ext_a_f, Engine.players()) && (short)Engine.ai_living_count(ext_a_sen_f) <= 0 && (short)Engine.ai_living_count(ext_a_flood_f) <= 0 || this.g_ext_a_fact_ent_migrate;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_a_fact_ent);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_fact_ent);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_a_fact_ent);
                }

                return (bool)Engine.ai_trigger_test("done_fighting", covenant1) && this.g_fact_ent_sen_spawn || (short)Engine.ai_living_count(fact_ent_sentinels) <= 0 && (short)Engine.ai_living_count(fact_ent_flood) <= 0 && this.g_fact_ent_sen_spawn || Engine.volume_test_objects(tv_fact_ent_follow, Engine.players());
            });
            await Engine.sleep(this.g_order_delay);
            Engine.cs_run_command_script(covenant1, new ScriptMethodReference(cs_fact_ent_exit_veh));
        }

        [ScriptMethod(171, Lifecycle.CommandScript)]
        public async Task cs_ext_b_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("ext_b_exit"));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.ai_set_orders(covenant1, cov_ext_b_exit);
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(covenant1);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task ext_b_vehicle_orders()
        {
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_b_a);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_b);
                }

                Engine.ai_magically_see(covenant1, ext_b_flood);
                return this.g_ext_b_migrate_1;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_b_b);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_b);
                }

                Engine.ai_magically_see(covenant1, ext_b_flood);
                return this.g_ext_b_migrate_2;
            });
            await Engine.sleep((short)(this.g_order_delay * 3));
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_b_b);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_b);
                }

                Engine.ai_magically_see(covenant1, ext_b_flood);
                return (short)Engine.ai_living_count(ext_b_flood_b) <= 0 && (short)Engine.ai_living_count(ext_b_sentinels_b) <= 0 || this.g_ext_b_migrate_3;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_b_c);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_b_bk);
                }

                Engine.ai_magically_see(covenant1, ext_b_flood);
                return (short)Engine.ai_living_count(ext_b_flood_c) <= 0 && (short)Engine.ai_living_count(ext_b_sentinels_c) <= 0 || this.g_ext_b_migrate_4;
            });
            await Engine.sleep(this.g_order_delay);
            await Engine.sleep_until(async () =>
            {
                if (await this.passenger_seat_test())
                {
                    if (this.debug)
                    {
                        Engine.print("player is passenger");
                    }

                    Engine.ai_set_orders(covenant_infantry, cov_follow_ext_b);
                    Engine.ai_set_orders(covenant_vehicles, cov_drive_ext_b_d);
                }
                else if (true)
                {
                    Engine.ai_set_orders(covenant1, cov_follow_ext_b_bk);
                }

                Engine.ai_magically_see(covenant1, ext_b_flood);
                return this.g_ext_b_migrate_5;
            });
            await Engine.sleep((short)(this.g_order_delay * 3));
            Engine.cs_run_command_script(covenant1, new ScriptMethodReference(cs_ext_b_exit));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.ai_migrate(covenant1, key_cov_dump.Squad);
            await Engine.sleep(5);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(key_cov_dump.Squad);
            await Engine.sleep(5);
            Engine.ai_set_orders(covenant1, cov_follow_key_ent);
        }

        [ScriptMethod(173, Lifecycle.CommandScript)]
        public async Task cs_cov_def_phantom()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("qz_cov_def/drop"));
            await Engine.sleep_until(async () => this.g_qz_cov_def_progress);
            Engine.cs_vehicle_speed(0.85F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("qz_cov_def/p4"), Engine.GetReference<ISpatialPoint>("qz_cov_def/p1"), 3F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_cov_def/p1"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_cov_def/p2"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_cov_def/p3"), 10F);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(174, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_a()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => this.g_qz_cov_def_progress, 5);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.a));
        }

        [ScriptMethod(175, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_b()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => this.g_qz_cov_def_progress, 5);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.b));
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_c()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => this.g_qz_cov_def_progress, 5);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre));
        }

        [ScriptMethod(177, Lifecycle.CommandScript)]
        public async Task cs_cov_def_spec_ops_d()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => this.g_qz_cov_def_progress, 5);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre));
        }

        [ScriptMethod(178, Lifecycle.CommandScript)]
        public async Task cs_go_to_scorpion()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(veh_int_scorpion.scorpion));
        }

        [ScriptMethod(179, Lifecycle.CommandScript)]
        public async Task cs_go_to_wraith()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(veh_int_wraith.wraith));
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task ai_veh_int_ghost_spawn()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(veh_int_flood_ghosts_ini.Squad) <= 0);
            if (this.debug)
            {
                Engine.print("waking vehicle interior ghost spawner");
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(veh_int_flood_ghosts_bk.Squad) <= 0);
                await Engine.sleep(90);
                if (this.debug)
                {
                    Engine.print("placing ghosts");
                }

                Engine.ai_place(veh_int_flood_ghosts_bk.Squad, this.g_veh_int_ghost_number);
                return (short)Engine.ai_spawn_count(veh_int_flood_ghosts_bk.Squad) >= this.g_veh_int_ghost_limit || this.g_veh_int_ghost_spawn;
            });
            if ((short)Engine.ai_living_count(veh_int_flood_ghosts_bk.Squad) <= 0)
            {
                Engine.ai_place(veh_int_flood_ghosts_bk.Squad);
            }
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task dam_door_a()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dam_door_a, Engine.players()), 5);
                Engine.device_set_position(dam_door_a1.Entity, 1F);
                return false;
            });
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task dam_door_b()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_dam_door_b, Engine.players()), 5);
                Engine.device_set_position(dam_door_b1.Entity, 1F);
                return false;
            });
        }

        [ScriptMethod(183, Lifecycle.CommandScript)]
        public async Task cs_ext_a_enf_ini()
        {
            Engine.cs_shoot(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_enf/p0"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_enf/p1"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_enf/p2"), 3F);
            Engine.cs_vehicle_boost(false);
        }

        [ScriptMethod(184, Lifecycle.CommandScript)]
        public async Task cs_ext_a_pelican()
        {
            Engine.cs_shoot(false);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(qz_ext_a_dam_human.pelican), "pelican_lc", Engine.ai_vehicle_get_from_starting_location(qz_ext_a_dam_human.scorpion));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_pelican/p0"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_pelican/p2"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_pelican/p3"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_pelican/p5"), 3F);
            await Engine.sleep(30);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(185, Lifecycle.CommandScript)]
        public async Task cs_boost_1_5()
        {
            Engine.cs_vehicle_boost(true);
            await Engine.sleep((short)(30 * 2));
            Engine.cs_vehicle_boost(false);
        }

        [ScriptMethod(186, Lifecycle.CommandScript)]
        public async Task cs_ext_a_phantom()
        {
            Engine.ai_place(qz_ext_a_spec_ops.Squad);
            Engine.ai_place(qz_ext_a_ghosts.Squad);
            Engine.cs_shoot(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep(1);
            Engine.vehicle_load_magic(this.v_ext_a_phantom, "phantom_p", Engine.ai_actors(qz_ext_a_spec_ops.Squad));
            Engine.vehicle_load_magic(this.v_ext_a_phantom, "phantom_sc01", Engine.ai_vehicle_get_from_starting_location(qz_ext_a_ghosts.a));
            Engine.vehicle_load_magic(this.v_ext_a_phantom, "phantom_sc02", Engine.ai_vehicle_get_from_starting_location(qz_ext_a_ghosts.b));
            await Engine.sleep(1);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/p0"), 5F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/p1"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/p2"), 4F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/p3"), Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/unit_face"));
            Engine.cs_vehicle_speed(0.75F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/drop_units"), Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/unit_face"), 2F);
            Engine.object_set_phantom_power(this.v_ext_a_phantom, true);
            await Engine.sleep(45);
            Engine.vehicle_unload(this.v_ext_a_phantom, "phantom_p_a01");
            await Engine.sleep(30);
            Engine.vehicle_unload(this.v_ext_a_phantom, "phantom_p_a02");
            await Engine.sleep(30);
            Engine.vehicle_unload(this.v_ext_a_phantom, "phantom_p_a03");
            await Engine.sleep(45);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/drop_ghosts"), Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/face"), 2F);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_qz_ext_a_ghost_drop, Engine.players())));
            await Engine.sleep(45);
            Engine.vehicle_unload(this.v_ext_a_phantom, "phantom_sc");
            await Engine.sleep(90);
            Engine.object_set_phantom_power(this.v_ext_a_phantom, false);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/p6"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/p4"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_a_phantom/p7"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(187, Lifecycle.CommandScript)]
        public async Task cs_wraiths_shoot()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p0")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p1")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p2")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p3")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p4")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p5")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p6")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("qz_ext_a_wraiths/p7")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 60)));
                return this.g_qz_ext_a_wraith_shoot;
            });
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task ai_ext_a_dam_enforcers()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_a_sen_dam_b) <= 0);
                await Engine.sleep(90);
                Engine.ai_place(qz_ext_a_dam_enf_door.Squad);
                return (short)Engine.ai_spawn_count(qz_ext_a_dam_enf_door.Squad) >= 3 || this.g_ext_a_dam_enf;
            });
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task ai_qz_ext_a_wraiths()
        {
            Engine.ai_place(qz_ext_a_flood_wraith_fr.Squad);
            Engine.ai_place(qz_ext_a_flood_wraith_bk.Squad);
            Engine.ai_place(qz_ext_a_flood_wraith_ledge.Squad);
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task ai_qz_ext_a_ghosts()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(qz_ext_a_flood_ghosts.Squad) <= 0);
                if (this.g_qz_ext_a_flood_ghosts)
                {
                    Engine.sleep_forever();
                }

                await Engine.sleep((short)Engine.random_range(60, 120));
                Engine.ai_place(qz_ext_a_flood_ghosts.Squad);
                return this.g_qz_ext_a_flood_ghosts;
            });
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task ai_fact_ent_sen_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(fact_ent_sen.Squad) <= 1);
                await Engine.sleep((short)Engine.random_range(15, 30));
                Engine.ai_place(fact_ent_sen.Squad);
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
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(fact_ent_enf.Squad) <= 0);
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.ai_place(fact_ent_enf.Squad);
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
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_d, Engine.players()));
            if (this.g_qz_ext_a_d_spawn)
            {
                Engine.ai_place(qz_ext_a_flood_d.Squad);
                Engine.ai_place(qz_ext_a_enf_bk.Squad);
            }
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task factory_1_flood_respawn()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == true || (short)Engine.ai_nonswarm_count(factory1_flood) < 3);
                if (Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_flood_end.Squad, 1);
                }
                else
                {
                    await Engine.sleep(60);
                }

                return Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == true || (short)Engine.ai_spawn_count(factory_1_flood_end.Squad) >= 10;
            });
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task factory_1_sentinel_respawn_01()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_01, Engine.players()) == true || (short)Engine.ai_living_count(factory1_sentinels) < 2);
                if (Engine.volume_test_objects(vol_factory_1_mid_01, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_sentinels_01_low.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                if (Engine.volume_test_objects(vol_factory_1_mid_01, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_sentinels_01_high.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                return Engine.volume_test_objects(vol_factory_1_mid_01, Engine.players()) == true || (float)Engine.ai_spawn_count(factory_1_sentinels_01_low.Squad) + (float)Engine.ai_spawn_count(factory_1_sentinels_01_high.Squad) >= 3F;
            });
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task factory_1_sentinel_respawn_02()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_02, Engine.players()) == true || (short)Engine.ai_living_count(factory1_sentinels) < 2);
                if (Engine.volume_test_objects(vol_factory_1_mid_02, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_sentinels_02_low.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                if (Engine.volume_test_objects(vol_factory_1_mid_02, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_sentinels_02_high.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                return Engine.volume_test_objects(vol_factory_1_mid_02, Engine.players()) == true || (float)Engine.ai_spawn_count(factory_1_sentinels_02_low.Squad) + (float)Engine.ai_spawn_count(factory_1_sentinels_02_high.Squad) >= 6F;
            });
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task factory_1_sentinel_enders()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == true || (short)Engine.ai_living_count(factory1_sentinels) < 2);
                if (Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_sentinels_03_low.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                if (Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_sentinels_03_high.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                return Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == true || (float)Engine.ai_spawn_count(factory_1_sentinels_03_low.Squad) + (float)Engine.ai_spawn_count(factory_1_sentinels_03_high.Squad) >= 6F;
            });
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task factory_1_flood_surge()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(factory_1_major.Squad) == 0);
            Engine.sleep_forever(new ScriptMethodReference(factory_1_flood_respawn));
            Engine.ai_set_orders(factory1_flood, factory_1_flood_tubes_fwd);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == true || (short)Engine.ai_nonswarm_count(factory1_flood) < 3);
                if (Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_flood_end.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                if (Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_flood_tubes_far.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                if (Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_flood_tubes_near.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                if (Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_flood_alcove.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                return Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == true || (float)Engine.ai_spawn_count(factory_1_flood_end.Squad) + (float)Engine.ai_spawn_count(factory_1_flood_tubes_far.Squad) + (float)Engine.ai_spawn_count(factory_1_flood_tubes_near.Squad) + (float)Engine.ai_spawn_count(factory_1_flood_alcove.Squad) >= 10F;
            });
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_exit, Engine.players()) == true || (short)Engine.ai_nonswarm_count(factory1_flood) < 2);
                if (Engine.volume_test_objects(vol_factory_1_exit, Engine.players()) == false)
                {
                    Engine.ai_place(factory_1_flood_end.Squad, 1);
                }
                else
                {
                    await Engine.sleep(120);
                }

                return Engine.volume_test_objects(vol_factory_1_exit, Engine.players()) == true || (short)Engine.ai_spawn_count(factory_1_flood_end.Squad) >= 8;
            });
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task sent_factory_1_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_enter, Engine.players()) == true);
            Engine.game_save();
            Engine.ai_place(factory_1_sentinels_intro.Squad);
            Engine.ai_place(factory_1_flood_intro.Squad);
            Engine.ai_place(factory_1_major.Squad);
            Engine.ai_place(factory_1_sentinels_initial_mid.Squad);
            Engine.ai_place(factory_1_flood_initial_mid.Squad);
            Engine.wake(new ScriptMethodReference(factory_1_flood_surge));
            Engine.wake(new ScriptMethodReference(factory_1_flood_respawn));
            Engine.wake(new ScriptMethodReference(factory_1_sentinel_respawn_01));
            Engine.wake(new ScriptMethodReference(factory_1_sentinel_enders));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_01, Engine.players()) == true || (short)Engine.ai_nonswarm_count(factory1_enemies) < 8);
            Engine.game_save_no_timeout();
            Engine.ai_place(factory_1_sentinels_initial_end.Squad);
            Engine.ai_place(factory_1_flood_initial_end.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_01, Engine.players()) == true);
            Engine.game_save();
            Engine.sleep_forever(new ScriptMethodReference(factory_1_sentinel_respawn_01));
            Engine.wake(new ScriptMethodReference(factory_1_sentinel_respawn_02));
            Engine.ai_renew(covenant1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_02, Engine.players()) == true);
            Engine.game_save();
            Engine.sleep_forever(new ScriptMethodReference(factory_1_sentinel_respawn_02));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_mid_03, Engine.players()) == true);
            Engine.game_save();
            Engine.sleep_forever(new ScriptMethodReference(factory_1_sentinel_enders));
            Engine.sleep_forever(new ScriptMethodReference(factory_1_flood_respawn));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_exit, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(factory_1_major.Squad) == 1)
            {
                Engine.sleep_forever(new ScriptMethodReference(factory_1_flood_surge));
            }
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task ai_sentinel_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(gorge_sen.Squad) <= 0);
                await Engine.sleep(150);
                Engine.ai_place(gorge_sen.Squad);
                return this.g_gorge_sen_spawn;
            });
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task ai_gorge()
        {
            Engine.ai_place(gorge_flood_ini.Squad);
            Engine.ai_place(gorge_enf.Squad);
            Engine.wake(new ScriptMethodReference(ai_sentinel_spawn));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_gorge_mid, Engine.players()));
            Engine.game_save_no_timeout();
            Engine.ai_place(gorge_flood_bk.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_gorge_bk_cave, Engine.players()));
            Engine.ai_place(gorge_flood_bk_cave.Squad);
            this.g_gorge_sen_spawn = true;
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task ai_factory2()
        {
            Engine.ai_place(factory2_flood_ini.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_factory2_mid, Engine.players()));
            Engine.game_save_no_timeout();
            if ((short)Engine.ai_living_count(factory2_flood) <= 4)
            {
                Engine.ai_place(factory2_flood_mid.Squad);
                Engine.ai_place(factory2_flood_bk.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_factory2_bk, Engine.players()));
            Engine.game_save();
            Engine.ai_place(factory2_flood_bk_tunnel.Squad);
            Engine.ai_place(factory2_sen_bk_tunnel.Squad);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task ai_constructor_flock()
        {
            Engine.flock_start("constructor_swarm");
            await Engine.sleep(150);
            Engine.flock_stop("constructor_swarm");
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task cs_ext_b_phantom()
        {
            Engine.cs_shoot(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.ai_place(qz_ext_b_cov_spec_ops.Squad);
            Engine.ai_place(qz_ext_b_cov_spectre.Squad);
            Engine.object_cannot_die(Engine.ai_get_object(qz_ext_b_cov_spec_ops.soc), true);
            await Engine.sleep(1);
            Engine.vehicle_load_magic(this.v_ext_b_phantom, "phantom_p", Engine.ai_actors(qz_ext_b_cov_spec_ops.Squad));
            Engine.vehicle_load_magic(this.v_ext_b_phantom, "phantom_sc01", Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_ghosts.a));
            Engine.vehicle_load_magic(this.v_ext_b_phantom, "phantom_sc02", Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_ghosts.b));
            Engine.vehicle_load_magic(this.v_ext_b_phantom, "phantom_lc", Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre));
            await Engine.sleep(1);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p0"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p1"), 5F);
            Engine.cs_vehicle_boost(false);
            Engine.ai_magically_see(qz_ext_b_wraith_a.Squad, qz_ext_b_cov_phantom.Squad);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p3"), 3F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p4"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"));
            Engine.cs_vehicle_speed(0.65F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/drop"), Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"));
            Engine.object_set_phantom_power(this.v_ext_b_phantom, true);
            await Engine.sleep(45);
            Engine.vehicle_unload(this.v_ext_b_phantom, "phantom_sc");
            Engine.vehicle_unload(this.v_ext_b_phantom, "phantom_lc");
            await Engine.sleep(45);
            Engine.vehicle_unload(this.v_ext_b_phantom, "phantom_p_a01");
            await Engine.sleep(30);
            Engine.vehicle_unload(this.v_ext_b_phantom, "phantom_p_a02");
            await Engine.sleep(30);
            Engine.vehicle_unload(this.v_ext_b_phantom, "phantom_p_a03");
            await Engine.sleep(45);
            Engine.object_set_phantom_power(this.v_ext_b_phantom, false);
            Engine.ai_vehicle_enter(qz_ext_b_cov_spec_ops.Squad, Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_spectre.spectre));
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"));
            Engine.cs_vehicle_speed(1F);
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(sc_ext_b));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p2"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p1"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_phantom/p0"), 3F);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task cs_ext_b_ent_phantom()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p0"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p1"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p2"), 5F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p3"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p5"));
            Engine.cs_vehicle_speed(0.65F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/drop"));
            await Engine.sleep_until(async () => this.g_ext_b_ent_phantom);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p5"));
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p5"), 3F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("qz_ext_b_ent_phantom/p6"), 3F);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task ai_ext_b_exit_tube_a()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_exit_tube_a, Engine.players()));
            Engine.ai_place(qz_ext_b_ent_flood_tube_a.Squad, (short)Engine.pin(8F - (float)Engine.ai_nonswarm_count(ext_b_flood), 0F, 6F));
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task ai_ext_b_exit_tube_b()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_exit_tube_b, Engine.players()));
            Engine.ai_place(qz_ext_b_ent_flood_tube_b.Squad, (short)Engine.pin(8F - (float)Engine.ai_nonswarm_count(ext_b_flood), 0F, 6F));
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task ai_ext_b_enf_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_b_sentinels_b) <= 0);
                if (Engine.volume_test_objects(tv_ext_b_mid, Engine.players()))
                {
                    Engine.ai_place(qz_ext_b_enf_b.Squad);
                }
                else if (true)
                {
                    Engine.ai_place(qz_ext_b_enf_a.Squad);
                }

                return (short)Engine.ai_spawn_count(ext_b_sentinels_b) >= 4 || this.g_ext_b_enforcer;
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(qz_ext_b_ent_ghost_bk.Squad) <= 0);
                await Engine.sleep(90);
                if (this.debug)
                {
                    Engine.print("placing ghosts");
                }

                Engine.ai_place(qz_ext_b_ent_ghost_bk.Squad, this.g_ext_b_bk_ghost_number);
                return (short)Engine.ai_spawn_count(qz_ext_b_ent_ghost_bk.Squad) >= this.g_ext_b_bk_ghost_limit || this.g_ext_b_bk_ghost_spawn;
            });
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task key_ride_door3_main()
        {
            Engine.print("key_ride_door3 begins to open");
            Engine.device_set_position(key_ride_door3.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(key_ride_door3.Entity) >= 0.9F, 10);
            await Engine.sleep(60);
            Engine.print("key_ride_door3 begins to close");
            Engine.device_set_position(key_ride_door3.Entity, 0F);
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task key_ride_human_door2_main()
        {
            Engine.print("human_key_door2 begins to open");
            Engine.device_set_position(human_key_door2.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(human_key_door2.Entity) >= 0.9F, 10);
            Engine.print("human_key_door2 begins to close");
            Engine.device_set_position(human_key_door2.Entity, 0F);
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task key_ride_door2_main()
        {
            Engine.print("key_ride_door2 begins to open");
            Engine.device_set_position(key_ride_door2.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(key_ride_door2.Entity) >= 0.9F, 10);
            Engine.print("key_ride_door2 begins to close");
            Engine.device_set_position(key_ride_door2.Entity, 0F);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task key_ride_door1_main()
        {
            Engine.print("key_ride_door1 begins to open");
            Engine.device_set_position(key_ride_door1.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(key_ride_door1.Entity) >= 0.9F, 10);
            await Engine.sleep(60);
            Engine.print("key_ride_door1 begins to close");
            Engine.device_set_position(key_ride_door1.Entity, 0F);
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task key_ride_door0_main()
        {
            Engine.print("key_ride_door0 begins to open");
            Engine.device_set_position_immediate(key_ride_door0.Entity, 0.32F);
            Engine.device_closes_automatically_set(key_ride_door0.Entity, false);
            Engine.device_set_position(key_ride_door0.Entity, 1F);
            Engine.sleep_forever();
            await Engine.sleep_until(async () => Engine.device_get_position(key_ride_door0.Entity) >= 0.9F, 10);
            await Engine.sleep(540);
            Engine.print("key_ride_door0 begins to close");
            Engine.device_set_position(key_ride_door0.Entity, 0F);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task key_main()
        {
            Engine.wake(new ScriptMethodReference(key_ride_door0_main));
            Engine.pvs_set_object(key.Entity);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 4242479958U), default(IGameObject), 1F);
            Engine.device_set_position_track(key.Entity, "track_horiz0", 0F);
            Engine.device_animate_position(key.Entity, 0.3F, 0F, 0F, 0F, false);
            await Engine.sleep(5);
            Engine.object_teleport(await this.player0(), key_ent0);
            Engine.object_teleport(await this.player1(), key_ent1);
            await Engine.sleep(5);
            Engine.device_animate_position(key.Entity, 0.6F, 75F, 0F, 0F, false);
            this.g_key_started = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.35F, 3);
            Engine.wake(new ScriptMethodReference(key_ride_door0_main));
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.4F, 3);
            this.g_key_lock0_first_loadpoint = true;
            this.g_key_lock0_entered = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.43F, 3);
            this.g_key_lock0_first_loadpoint = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.48F, 3);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("sen_hq_bsp_6"));
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.5F, 3);
            this.g_key_lock0_second_loadpoint = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.5F, 3);
            this.g_key_lock0_begin_human = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.53F, 3);
            this.g_key_lock0_door1 = true;
            Engine.wake(new ScriptMethodReference(key_ride_door1_main));
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.58F, 3);
            this.g_key_cruise_entered = true;
            Engine.device_animate_position(key.Entity, 1F, 45F, 5F, 10F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.67F, 3);
            this.g_key_cruise_first_loadpoint = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.84F, 3);
            this.g_key_cruise_halfway = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 1F, 3);
            this.g_key_shaft_entered = true;
            await Engine.sleep(30);
            Engine.device_set_position_track(key.Entity, "track_rise", 0F);
            Engine.device_set_overlay_track(key.Entity, "overlay_transform");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 4242479958U), true);
            Engine.device_animate_overlay(key.Entity, 1F, 5F, 0F, 0F);
            await Engine.sleep(180);
            Engine.device_animate_position(key.Entity, 1F, 90F, 20F, 10F, false);
            this.g_key_shaft_rising = true;
            this.g_music_06b_06 = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.3F, 3);
            this.g_key_shaft_near_exterior = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.73F, 3);
            Engine.wake(new ScriptMethodReference(key_ride_door2_main));
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 1F, 3);
            this.g_key_lock1_entered = true;
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 4242479958U));
            await Engine.sleep(30);
            Engine.device_set_position_track(key.Entity, "track_horiz1", 0F);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 4242479958U), default(IGameObject), 1F);
            Engine.device_animate_overlay(key.Entity, 0F, 5F, 0F, 0F);
            await Engine.sleep(180);
            Engine.device_animate_position(key.Entity, 1F, 75F, 10F, 10F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.15F, 3);
            this.g_key_lock1_first_arch = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.4F, 3);
            this.g_key_lock1_second_arch = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.49F, 3);
            Engine.wake(new ScriptMethodReference(key_ride_door3_main));
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.65F, 3);
            this.g_key_library_entered = true;
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 0.85F, 3);
            Engine.device_animate_overlay(key.Entity, 1F, 5F, 0F, 0F);
            await Engine.sleep_until(async () => Engine.device_get_position(key.Entity) >= 1F, 3);
            this.g_key_library_arrival = true;
            Engine.wake(new ScriptMethodReference(chapter_familiar));
            Engine.wake(new ScriptMethodReference(sc_dock));
            this.g_music_06b_05 = false;
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\device_machines\\shq__key\\shq__key", 4242479958U));
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task key_ride_human_key_main()
        {
            await Engine.sleep_until(async () => this.g_key_lock0_begin_human, 10);
            Engine.object_create_anew(key_human);
            Engine.pvs_set_object(key_human.Entity);
            Engine.device_set_position_track(key_human.Entity, "track_horiz0", 0F);
            Engine.device_animate_position(key_human.Entity, 0.58F, 0.5F, 0F, 0F, false);
            await Engine.sleep(15);
            Engine.device_animate_position(key_human.Entity, 1F, 55F, 5F, 10F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(key_human.Entity) >= 1F, 3);
            await Engine.sleep(30);
            Engine.device_set_position_track(key_human.Entity, "track_rise", 0F);
            Engine.device_set_overlay_track(key_human.Entity, "overlay_transform");
            Engine.device_animate_overlay(key_human.Entity, 1F, 5F, 0F, 0F);
            await Engine.sleep(180);
            Engine.device_animate_position(key_human.Entity, 1F, 80F, 20F, 10F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(key_human.Entity) >= 0.71F, 3);
            Engine.wake(new ScriptMethodReference(key_ride_human_door2_main));
            await Engine.sleep_until(async () => Engine.device_get_position(key_human.Entity) >= 1F, 3);
            await Engine.sleep(120);
            Engine.device_set_position_track(key_human.Entity, "track_horiz1", 0F);
            Engine.device_animate_overlay(key_human.Entity, 0F, 5F, 0F, 0F);
            await Engine.sleep(180);
            Engine.device_animate_position(key_human.Entity, 1F, 75F, 10F, 10F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(key_human.Entity) >= 0.191F, 3);
            Engine.object_destroy(key_human.Entity);
            Engine.object_create_anew(key_docked);
            await Engine.sleep(1);
            Engine.device_set_overlay_track(key_docked.Entity, "overlay_transform");
            Engine.device_animate_overlay(key_docked.Entity, 1F, 0.1F, 0F, 0F);
        }

        [ScriptMethod(217, Lifecycle.CommandScript)]
        public async Task cs_e21_tartarus()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.print("e21 *tartarus returns from harassing human key*");
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_tartarus/p0"));
            Engine.cs_vehicle_boost(false);
            Engine.print("e21 *tartarus follows the key in through the door*");
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e21_tartarus/p1"));
            Engine.cs_vehicle_speed(0.75F);
            Engine.cs_enable_pathfinding_failsafe(false);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_bsp5/left"));
                return false;
            }, 3, 300);
            Engine.cs_vehicle_speed(0.85F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e22_tartarus_bsp6/forward_facing"));
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_bsp5/center"));
                return false;
            }, 3, 300);
        }

        [ScriptMethod(218, Lifecycle.CommandScript)]
        public async Task cs_e22_tartarus()
        {
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e22_tartarus_bsp6/forward_facing"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e22_tartarus/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e22_tartarus/p1"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e22_tartarus/p2"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e22_tartarus/p3"), 1F);
            await Engine.sleep(50);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e22_tartarus_bsp6/forward_facing"));
            Engine.cs_vehicle_speed(0.9F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_bsp6/center_front"));
            Engine.cs_vehicle_speed(0.9F);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_bsp6/center_front"), 1F);
                return false;
            }, 3);
        }

        [ScriptMethod(219, Lifecycle.CommandScript)]
        public async Task cs_e23_tartarus()
        {
            Engine.cs_vehicle_speed(1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_tartarus/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_tartarus/p1"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e23_tartarus/p2"));
            Engine.cs_vehicle_speed(1F);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_human_bsp6/left_high"), 1F);
                return false;
            }, 3, 360);
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("e23_tartarus/teleport_dest"), Engine.GetReference<ISpatialPoint>("e23_tartarus/teleport_facing"));
            Engine.sleep_forever();
        }

        [ScriptMethod(220, Lifecycle.CommandScript)]
        public async Task cs_e24_tartarus()
        {
            await Engine.sleep(200);
            Engine.cs_vehicle_speed(0.6F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e24_tartarus/p0"));
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e24_tartarus/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e24_tartarus/p2"));
            Engine.sleep_forever();
        }

        [ScriptMethod(221, Lifecycle.CommandScript)]
        public async Task cs_e25_tartarus()
        {
            await Engine.sleep(120);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e25_tartarus/p0"));
            await Engine.sleep(60);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e25_tartarus/p0"));
            Engine.cs_vehicle_speed(0.6F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e25_tartarus/p0"));
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e25_tartarus/p1"), 1F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e25_tartarus/p1_facing"));
            await Engine.sleep(320);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e25_tartarus/p1_facing"));
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_bsp6/center"), 1F);
            Engine.cs_vehicle_speed(0.9F);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_bsp6/center"), 1F);
                return false;
            }, 3);
        }

        [ScriptMethod(222, Lifecycle.CommandScript)]
        public async Task cs_e26_tartarus()
        {
            Engine.cs_vehicle_speed(0.9F);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("key_bsp6/center"), 1F);
                return false;
            }, 3, 210);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e26_tartarus/p0"));
            await Engine.sleep(120);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e26_tartarus/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e26_tartarus/p2"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task key_ride_tartarus_main()
        {
            Engine.ai_place(key_ride_tartarus.Squad);
            Engine.cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e21_tartarus));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 4, 10);
            Engine.cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e22_tartarus));
            await Engine.sleep_until(async () => this.g_key_cruise_entered, 10);
            Engine.cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e23_tartarus));
            await Engine.sleep_until(async () => this.g_key_shaft_near_exterior, 10);
            Engine.cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e24_tartarus));
            await Engine.sleep_until(async () => this.g_key_lock1_entered, 10);
            Engine.cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e25_tartarus));
            await Engine.sleep_until(async () => this.g_key_library_entered, 10);
            Engine.cs_run_command_script(key_ride_tartarus.tartarus, new ScriptMethodReference(cs_e26_tartarus));
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task key_ride_test()
        {
            Engine.wake(new ScriptMethodReference(key_main));
            Engine.wake(new ScriptMethodReference(key_ride_human_key_main));
            Engine.wake(new ScriptMethodReference(key_ride_tartarus_main));
        }

        [ScriptMethod(225, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry3()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep(30);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(226, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry2()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep(30);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p6"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p7"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(227, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry1()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep(30);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p8"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p7"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(228, Lifecycle.CommandScript)]
        public async Task cs_e26_fld_infections_entry0()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep(30);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p1"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e26_fld_infection_forms0/p5"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task e26_smg1()
        {
            Engine.object_create(e26_smg11);
            await Engine.sleep_until(async () =>
            {
                Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e26_smg1"), 0, true);
                await Engine.sleep_until(async () => this.g_e26_ended, 2, (int)Engine.random_range(15, 45));
                Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e26_smg1"), 0, false);
                await Engine.sleep_until(async () => this.g_e26_ended, 2, (int)Engine.random_range(45, 90));
                return this.g_e26_ended;
            }, 1);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e26_smg1"), 0, false);
            Engine.object_destroy(e26_smg11.Entity);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task e26_smg0()
        {
            Engine.object_create(e26_smg01);
            await Engine.sleep_until(async () =>
            {
                Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e26_smg0"), 0, true);
                await Engine.sleep_until(async () => this.g_e26_ended, 2, (int)Engine.random_range(15, 45));
                Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e26_smg0"), 0, false);
                await Engine.sleep_until(async () => this.g_e26_ended, 2, (int)Engine.random_range(45, 90));
                return this.g_e26_ended;
            }, 1);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("e26_smg0"), 0, false);
            Engine.object_destroy(e26_smg01.Entity);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task e26_fld_infections_main()
        {
            Engine.ai_place(e26_fld_infection_forms0.swarm0);
            await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), e26_fld_infs0_1) < 10F, 10, 300);
            Engine.ai_place(e26_fld_infection_forms0.swarm1);
            await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), e26_fld_infs0_2) < 10F, 10, 300);
            Engine.ai_place(e26_fld_infection_forms0.swarm2);
            await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), e26_fld_infs0_3) < 10F, 10, 300);
            Engine.ai_place(e26_fld_infection_forms0.swarm3);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task e26_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e26_main_begin, Engine.players()), 10);
            Engine.data_mine_set_mission_segment("enc_e26");
            this.g_e26_started = true;
            Engine.print("e26_main");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e26_fld_infections_main));
            Engine.wake(new ScriptMethodReference(e26_smg0));
            Engine.wake(new ScriptMethodReference(e26_smg1));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_mission_end0, Engine.players()) || Engine.volume_test_objects(tv_mission_end1, Engine.players()), 10);
            this.g_e26_ended = true;
        }

        [ScriptMethod(233, Lifecycle.CommandScript)]
        public async Task cs_e25_scene3()
        {
            Engine.cs_switch("elite1");
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e25_scenes/p1"));
            Engine.cs_switch("elite0");
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e25_scenes/p0"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 4F);
            Engine.cs_face_player(true);
            Engine.cs_approach(Engine.ai_get_object(this.ai_current_actor), 1F, 1F, 1F);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 4F);
            Engine.print("elite0: we'll guard the key");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0910"));
            await Engine.sleep(20);
            Engine.cs_switch("elite1");
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 4F);
            Engine.cs_face_player(true);
            Engine.cs_approach(Engine.ai_get_object(this.ai_current_actor), 1F, 1F, 1F);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 4F);
            Engine.print("elite1: git to werk");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0920"));
        }

        [ScriptMethod(234, Lifecycle.CommandScript)]
        public async Task cs_e25_scene1()
        {
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e25_scenes/p0"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 4F);
            Engine.cs_face_player(true);
            Engine.cs_approach(Engine.ai_get_object(this.ai_current_actor), 1F, 1F, 1F);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 4F);
            Engine.print("elite0: we'll guard the key");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0910"));
            await Engine.sleep(15);
            Engine.print("elite0: get the icon");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0920"));
        }

        [ScriptMethod(235, Lifecycle.CommandScript)]
        public async Task cs_e25_scene0()
        {
            Engine.print("elite: behold, the library");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0890"));
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task e25_dialogue()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("e25_scene0", new ScriptMethodReference(cs_e25_scene0), e21_cov_inf0), 5, 300);
            await Engine.sleep(120);
            Engine.ai_play_line_on_object(default(IGameObject), "0900") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep_until(async () => this.g_key_library_arrival, 10);
            if ((short)Engine.ai_living_count(e21_cov_inf0) >= 2)
            {
                await Engine.sleep_until(async () => Engine.ai_scene("e25_scene3", new ScriptMethodReference(cs_e25_scene3), e21_cov_inf0), 5);
            }
            else
            {
                await Engine.sleep_until(async () => Engine.ai_scene("e25_scene1", new ScriptMethodReference(cs_e25_scene1), e21_cov_inf0), 5);
            }
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task e25_fld_inf1_main()
        {
            await Engine.sleep_until(async () => this.g_key_lock1_second_arch, 10);
            Engine.ai_place(e25_fld_inf1_0.Squad);
            await Engine.sleep(60);
            Engine.ai_place(e25_fld_inf1_1.Squad);
            await Engine.sleep(60);
            Engine.ai_place(e25_fld_inf1_2.Squad);
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task e25_fld_inf0_main()
        {
            await Engine.sleep_until(async () => this.g_key_lock1_first_arch, 10);
            Engine.ai_place(e25_fld_inf0_0.Squad);
            await Engine.sleep(60);
            Engine.ai_place(e25_fld_inf0_1.Squad);
            await Engine.sleep(60);
            Engine.ai_place(e25_fld_inf0_2.Squad);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task e25_main()
        {
            Engine.data_mine_set_mission_segment("enc_e25");
            await Engine.sleep_until(async () => this.g_key_lock1_entered, 10);
            this.g_e25_started = true;
            Engine.print("e25_main");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e26_main));
            Engine.wake(new ScriptMethodReference(e25_dialogue));
            await Engine.sleep_until(async () => this.g_e26_started);
            Engine.sleep_forever(new ScriptMethodReference(e25_fld_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e25_fld_inf1_main));
        }

        [ScriptMethod(240, Lifecycle.CommandScript)]
        public async Task cs_e24_fld_inf1_load()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_face_object(true, key.Entity);
            await Engine.sleep(210);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_face_object(false, key.Entity);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            if ((short)Engine.random_range(0, 2) == 0)
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e24_fld_inf1_load/p0_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e24_fld_inf1_load/p0_1"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e24_fld_inf1_load/p1_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e24_fld_inf1_load/p1_1"));
            }

            Engine.cs_jump_to_point(3F, 1F);
            Engine.ai_migrate(this.ai_current_actor, e21_fld_inf0_0.Squad);
            await Engine.sleep(150);
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task e24_fld_inf2_main()
        {
            await Engine.sleep_until(async () => this.g_key_shaft_entered, 10);
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task e24_fld_inf1_main()
        {
            await Engine.sleep_until(async () => this.g_key_shaft_rising, 10);
            Engine.ai_place(e24_fld_inf1_1.Squad);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task e24_fld_inf0_main()
        {
            await Engine.sleep_until(async () => this.g_key_shaft_entered, 10);
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task e24_main()
        {
            await Engine.sleep_until(async () => this.g_key_shaft_entered, 10);
            Engine.data_mine_set_mission_segment("enc_e24");
            this.g_e24_started = true;
            Engine.print("e24_main");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e25_main));
            await Engine.sleep_until(async () => this.g_e25_started);
            Engine.sleep_forever(new ScriptMethodReference(e24_fld_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e24_fld_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e24_fld_inf2_main));
        }

        [ScriptMethod(245, Lifecycle.CommandScript)]
        public async Task cs_e23_fld_inf0_0_load()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e23_fld_inf0_load/p0_0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e23_fld_inf0_load/p0_1"));
            Engine.cs_jump(15F, 3F);
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cs_e23_fld_inf0_1_load()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e23_fld_inf0_load/p1_0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e23_fld_inf0_load/p1_1"));
            Engine.cs_jump(15F, 3F);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cs_e23_scene0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_switch("elite0");
            Engine.print("dog: the fool...");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0810"));
            await Engine.sleep(15);
            Engine.cs_switch("elite1");
            Engine.print("scl: on the bright side...");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0820"));
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task e23_dialogue()
        {
            await Engine.sleep(90);
            Engine.print("tartarus: humans! i'll deal with them!");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0800"));
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.ai_scene("e23_scene0", new ScriptMethodReference(cs_e23_scene0), e21_cov_inf0), 10, 90);
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task e23_fld_inf0_main()
        {
            await Engine.sleep_until(async () => this.g_key_cruise_first_loadpoint, 10);
            Engine.ai_place(e23_fld_inf0);
            await Engine.sleep_until(async () => this.g_key_cruise_halfway, 10);
            await Engine.sleep(90);
            Engine.ai_set_orders(e23_fld_inf0_0.Squad, e23_fld_inf0_engage);
            Engine.ai_set_orders(e23_fld_inf0_1.Squad, e23_fld_inf0_engage);
            Engine.cs_run_command_script(e23_fld_inf0_0.Squad, new ScriptMethodReference(cs_e23_fld_inf0_0_load));
            Engine.cs_run_command_script(e23_fld_inf0_1.Squad, new ScriptMethodReference(cs_e23_fld_inf0_1_load));
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task e23_main()
        {
            Engine.data_mine_set_mission_segment("enc_e23");
            await Engine.sleep_until(async () => this.g_key_cruise_entered, 10);
            this.g_e23_started = true;
            Engine.print("e23_main");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e24_main));
            Engine.wake(new ScriptMethodReference(e23_dialogue));
            await Engine.sleep_until(async () => this.g_e24_started);
            Engine.sleep_forever(new ScriptMethodReference(e23_fld_inf0_main));
        }

        [ScriptMethod(251, Lifecycle.Static)]
        public async Task test_key_ride2()
        {
            Engine.device_set_position_immediate(key.Entity, 0.26F);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e23_test);
            Engine.object_set_velocity(await this.player0(), 1F, 0F, 0F);
            Engine.wake(new ScriptMethodReference(key_main));
            Engine.wake(new ScriptMethodReference(e23_main));
            await Engine.sleep(3);
            Engine.device_set_position_immediate(key.Entity, 0.26F);
            Engine.device_set_position(key.Entity, 1F);
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task cs_e22_hack_divide()
        {
            if ((short)Engine.ai_living_count(e22_cov_inf1_0.Squad) < 2)
            {
                Engine.ai_migrate(this.ai_current_actor, e22_cov_inf1_0.Squad);
            }
            else
            {
                Engine.ai_migrate(this.ai_current_actor, e22_cov_inf1_1.Squad);
            }
        }

        [ScriptMethod(253, Lifecycle.CommandScript)]
        public async Task cs_e22_fld_inf0_0_load()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_face_object(true, key.Entity);
            await Engine.sleep_until(async () => this.g_key_lock0_second_loadpoint, 1);
            await Engine.sleep(95);
            Engine.cs_face_object(false, key.Entity);
            Engine.unit_impervious(this.ai_current_actor, true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            if ((short)Engine.random_range(0, 2) == 0)
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_fld_inf0_load/p0_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_fld_inf0_load/p0_1"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_fld_inf0_load/p1_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e22_fld_inf0_load/p1_1"));
            }

            Engine.cs_move_in_direction(0F, 1F, 0F);
            Engine.unit_impervious(this.ai_current_actor, false);
            Engine.ai_migrate(this.ai_current_actor, e21_fld_inf0_0.Squad);
        }

        [ScriptMethod(254, Lifecycle.CommandScript)]
        public async Task cs_e22_scene0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_switch("elite0");
            Engine.print("scl: what courage...");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0780"));
            await Engine.sleep(15);
            Engine.cs_switch("elite1");
            Engine.print("dog: ignore him...");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0790"));
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task e22_dialogue()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 4);
            await Engine.sleep(90);
            Engine.print("tartarus: i will thin their ranks");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0770"));
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.ai_scene("e22_scene0", new ScriptMethodReference(cs_e22_scene0), e21_cov_inf0), 10, 90);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task e22_fld_inf0_main()
        {
            await Engine.sleep_until(async () => this.g_key_lock0_first_loadpoint, 10);
            Engine.ai_place(e22_fld_inf0);
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task e22_main()
        {
            await Engine.sleep_until(async () => this.g_key_lock0_entered, 10);
            Engine.data_mine_set_mission_segment("enc_e22");
            this.g_e22_started = true;
            Engine.print("e22_main");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e23_main));
            Engine.wake(new ScriptMethodReference(e22_fld_inf0_main));
            Engine.wake(new ScriptMethodReference(e22_dialogue));
            await Engine.sleep_until(async () => this.g_e23_started);
            Engine.sleep_forever(new ScriptMethodReference(e22_fld_inf0_main));
        }

        [ScriptMethod(258, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf1_low_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_move_in_direction(6F, 0F, 0F);
            if ((short)Engine.structure_bsp_index() == 3)
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p2"));
                Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p1_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p1_1"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p2"));
                Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p1_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p1_1"));
            }
        }

        [ScriptMethod(259, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf1_high_entry()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_pathfinding_failsafe(true);
            if ((short)Engine.structure_bsp_index() == 3)
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p1_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p1_1"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p1_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p1_1"));
            }
        }

        [ScriptMethod(260, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf0_low_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_move_in_direction(6F, 0F, 0F);
            if ((short)Engine.structure_bsp_index() == 3)
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p2"));
                Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p0_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p0_1"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p2"));
                Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p0_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p0_1"));
            }
        }

        [ScriptMethod(261, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf0_high_entry()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_pathfinding_failsafe(true);
            if ((short)Engine.structure_bsp_index() == 3)
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p0_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp5/p0_1"));
            }
            else
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p0_0"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_bsp6/p0_1"));
            }
        }

        [ScriptMethod(262, Lifecycle.CommandScript)]
        public async Task cs_e21_fld_inf0_0_load()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            await Engine.sleep_until(async () => this.g_key_lock0_first_loadpoint, 1);
            await Engine.sleep(30);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("key_bsp5/p0"));
            await Engine.sleep(148);
            Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("key_bsp5/p0"));
            Engine.ai_set_orders(this.ai_current_squad, e21_fld_inf0_engage0);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_load/left0"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e21_fld_load/left1"));
            Engine.cs_move_in_direction(0F, 1F, 0F);
        }

        [ScriptMethod(263, Lifecycle.CommandScript)]
        public async Task cs_e21_scene0()
        {
            Engine.print("elite: i grow restless without a target");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0730"));
        }

        [ScriptMethod(264, Lifecycle.CommandScript)]
        public async Task cs_e21_scene1()
        {
            Engine.print("elite: look, up ahead! the parasite readies");
            Engine.ai_play_line_at_player(this.ai_current_actor, "0760") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(20);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("e21_scene1_points"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e21_fld_load/p0"));
            Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("e21_fld_load/p0"));
            await Engine.sleep_until(async () => this.g_key_lock0_first_loadpoint, 5);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e21_fld_load/p0"));
            await Engine.sleep(90);
        }

        [ScriptMethod(265, Lifecycle.Static)]
        public async Task<bool> e21_in_bsp4()
        {
            return (short)Engine.structure_bsp_index() == 4;
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task e21_fld_carriers1_main()
        {
            Engine.ai_migrate(e21_fld_carriers0.Squad, e21_fld_carriers1.Squad);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_swarm_count(e21_fld_carriers1.Squad) < 2)
                {
                    Engine.ai_place(e21_fld_carriers1.Squad, 1);
                }

                return this.g_key_lock1_second_arch;
            }, 90);
        }

        [ScriptMethod(267, Lifecycle.Static)]
        public async Task e21_fld_inf1_spawn()
        {
            if (Engine.volume_test_objects(tv_key_near_lower_spawner, Engine.players()))
            {
                if (Engine.volume_test_objects(tv_key_upper_left_side, Engine.players()))
                {
                    Engine.ai_place(e21_fld_inf1_2.Squad, 1);
                    Engine.ai_migrate(e21_fld_inf1_2.Squad, e21_fld_inf1_0.Squad);
                    await Engine.sleep(5);
                    Engine.ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player0());
                    Engine.ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player1());
                }
                else
                {
                    Engine.ai_place(e21_fld_inf0_2.Squad, 1);
                    Engine.cs_run_command_script(e21_fld_inf0_2.Squad, new ScriptMethodReference(cs_e21_fld_inf1_high_entry));
                    Engine.ai_migrate(e21_fld_inf0_2.Squad, e21_fld_inf1_0.Squad);
                    await Engine.sleep(5);
                    Engine.ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player0());
                    Engine.ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player1());
                }
            }
            else
            {
                Engine.ai_place(e21_fld_inf1_1.Squad, 1);
                Engine.ai_migrate(e21_fld_inf1_1.Squad, e21_fld_inf1_0.Squad);
                await Engine.sleep(5);
                Engine.ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player0());
                Engine.ai_magically_see_object(e21_fld_inf1_0.Squad, await this.player1());
            }
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task e21_fld_inf1_main()
        {
            Engine.ai_migrate(e21_fld_inf0, e21_fld_inf1_0.Squad);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_nonswarm_count(e21_fld_inf1_0.Squad) < 8)
                {
                    await Engine.sleep_until(async () =>
                    {
                        await this.e21_fld_inf1_spawn();
                        return (short)Engine.ai_nonswarm_count(e21_fld_inf1_0.Squad) >= 8 || this.g_key_lock1_second_arch;
                    }, 60);
                }

                return this.g_key_lock1_second_arch;
            }, 900);
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task e21_fld_carriers0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 4);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_nonswarm_count(e21_fld_carriers0.Squad) < 2)
                {
                    Engine.ai_place(e21_fld_carriers0.Squad, 1);
                }

                return this.g_key_shaft_rising;
            }, 90);
            Engine.wake(new ScriptMethodReference(e21_fld_carriers1_main));
        }

        [ScriptMethod(270, Lifecycle.Static)]
        public async Task e21_fld_inf0_spawn()
        {
            if (Engine.volume_test_objects(tv_key_near_lower_spawner, Engine.players()))
            {
                if (Engine.volume_test_objects(tv_key_upper_left_side, Engine.players()))
                {
                    Engine.ai_place(e21_fld_inf1_2.Squad, 1);
                    Engine.cs_run_command_script(e21_fld_inf1_2.Squad, new ScriptMethodReference(cs_e21_fld_inf0_high_entry));
                    Engine.ai_migrate(e21_fld_inf1_2.Squad, e21_fld_inf0_0.Squad);
                    await Engine.sleep(5);
                    Engine.ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player0());
                    Engine.ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player1());
                }
                else
                {
                    Engine.ai_place(e21_fld_inf0_2.Squad, 1);
                    Engine.ai_migrate(e21_fld_inf0_2.Squad, e21_fld_inf0_0.Squad);
                    await Engine.sleep(5);
                    Engine.ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player0());
                    Engine.ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player1());
                }
            }
            else
            {
                Engine.ai_place(e21_fld_inf0_1.Squad, 1);
                Engine.ai_migrate(e21_fld_inf0_1.Squad, e21_fld_inf0_0.Squad);
                await Engine.sleep(5);
                Engine.ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player0());
                Engine.ai_magically_see_object(e21_fld_inf0_0.Squad, await this.player1());
            }
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task e21_fld_inf0_main()
        {
            Engine.ai_place(e21_fld_inf0_0.Squad);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 4);
            await Engine.sleep_until(async () =>
            {
                await this.e21_fld_inf0_spawn();
                return (short)Engine.ai_nonswarm_count(e21_fld_inf0_0.Squad) >= 8 || this.g_key_shaft_rising;
            });
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_nonswarm_count(e21_fld_inf0_0.Squad) < 8)
                {
                    await Engine.sleep_until(async () =>
                    {
                        await this.e21_fld_inf0_spawn();
                        return (short)Engine.ai_nonswarm_count(e21_fld_inf0_0.Squad) >= 8 || this.g_key_shaft_rising;
                    }, 60);
                }

                return this.g_key_shaft_rising;
            }, 900);
            Engine.wake(new ScriptMethodReference(e21_fld_inf1_main));
        }

        [ScriptMethod(272, Lifecycle.Dormant)]
        public async Task e21_cov_inf0_main()
        {
            Engine.ai_place(e21_cov_inf0);
            await Engine.sleep(150);
            await Engine.sleep_until(async () => Engine.ai_scene("e21_scene0", new ScriptMethodReference(cs_e21_scene0), e21_cov_inf0_1.Squad), 5, 60);
            await Engine.sleep(300);
            await Engine.sleep_until(async () => Engine.ai_scene("e21_scene1", new ScriptMethodReference(cs_e21_scene1), e21_cov_inf0_0.Squad), 5, 60);
            await Engine.sleep_until(async () => this.g_key_lock0_first_loadpoint, 5);
            Engine.game_save();
            Engine.ai_set_orders(e21_cov_inf0_0.Squad, e21_cov_inf0_0_guard_left);
            Engine.ai_set_orders(e21_cov_inf0_1.Squad, e21_cov_inf0_1_advance_left);
            await Engine.sleep_until(async () => this.g_key_shaft_rising);
            Engine.ai_set_orders(e21_cov_inf0_0.Squad, e21_cov_inf0_0_guard_right);
            Engine.ai_set_orders(e21_cov_inf0_1.Squad, e21_cov_inf0_1_advance_right);
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task e21_main()
        {
            await Engine.sleep_until(async () => this.g_key_started, 5);
            Engine.data_mine_set_mission_segment("enc_e21");
            this.g_e21_started = true;
            Engine.print("e21_main");
            Engine.wake(new ScriptMethodReference(e22_main));
            Engine.wake(new ScriptMethodReference(e21_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e21_fld_inf0_main));
            Engine.wake(new ScriptMethodReference(sc_outer_wall));
        }

        [ScriptMethod(274, Lifecycle.Static)]
        public async Task test_key_ride()
        {
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("sen_hq_bsp_5"));
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), key_ent0);
            Engine.object_set_velocity(await this.player0(), 5F, 0F, 0F);
            Engine.object_teleport(await this.player1(), key_ent1);
            Engine.object_set_velocity(await this.player1(), 5F, 0F, 0F);
            Engine.wake(new ScriptMethodReference(key_main));
            Engine.wake(new ScriptMethodReference(key_ride_human_key_main));
            Engine.wake(new ScriptMethodReference(key_ride_tartarus_main));
            Engine.wake(new ScriptMethodReference(e21_main));
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task begin_key_ride_main()
        {
            Engine.wake(new ScriptMethodReference(e21_main));
            Engine.wake(new ScriptMethodReference(key_main));
            Engine.wake(new ScriptMethodReference(key_ride_human_key_main));
            Engine.wake(new ScriptMethodReference(key_ride_tartarus_main));
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task enc_cov_charge()
        {
            Engine.data_mine_set_mission_segment("enc_cov_charge");
            Engine.print("initialize covenant charge scripts");
            Engine.game_save();
            Engine.object_dynamic_simulation_disable(qz_cov_def_tower_pod_a.Entity, true);
            Engine.object_dynamic_simulation_disable(qz_cov_def_tower_pod_b.Entity, true);
            Engine.ai_place(qz_cov_def_phantom.Squad);
            Engine.ai_place(qz_cov_def_spectre.Squad);
            Engine.ai_place(qz_cov_def_ghosts.Squad);
            Engine.ai_place(qz_cov_def_spec_ops.Squad);
            Engine.wake(new ScriptMethodReference(sc_cov_charge));
            await Engine.sleep_until(async () => Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_l", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_p_r", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_spectre.spectre), "spectre_g", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.a), "ghost_d", Engine.players()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(qz_cov_def_ghosts.b), "ghost_d", Engine.players()), 10, 30 * 20);
            this.g_qz_cov_def_progress = true;
            await Engine.sleep(30);
            Engine.game_save_no_timeout();
            await Engine.sleep(90);
            Engine.ai_place(qz_cov_def_enforcer_a.Squad);
            Engine.ai_place(qz_cov_def_sen_elim.Squad);
            Engine.device_set_position(qz_door_a.Entity, 1F);
            await Engine.sleep((short)(30 * 2));
            Engine.wake(new ScriptMethodReference(ext_a_vehicle_orders));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(sentinels) <= 0);
            await Engine.sleep(30);
            Engine.game_save();
            Engine.ai_renew(covenant1);
        }

        [ScriptMethod(277, Lifecycle.Dormant)]
        public async Task enc_vehicle_int()
        {
            Engine.data_mine_set_mission_segment("enc_vehicle_int");
            Engine.print("initialize vehicle interior scripts");
            Engine.game_save();
            Engine.ai_renew(covenant1);
            Engine.ai_disposable(cov_def_sentinels, true);
            Engine.ai_disposable(cov_def_enf, true);
            this.g_veh_int_migrate_a = true;
            this.g_music_06b_01 = true;
            Engine.wake(new ScriptMethodReference(music_06b_01));
            Engine.wake(new ScriptMethodReference(sc_qz_veh_int));
            Engine.ai_place(veh_int_enf_a.Squad);
            Engine.ai_place(veh_int_enf_b.Squad);
            Engine.ai_place(veh_int_enf_d.Squad);
            Engine.ai_place(veh_int_sen_elim_ini.Squad);
            Engine.ai_place(veh_int_scorpion.Squad);
            Engine.ai_place(veh_int_flood_ghosts_ini.Squad);
            Engine.ai_place(veh_int_wraith.wraith);
            Engine.ai_place(veh_int_hog_ab.Squad);
            Engine.ai_place(veh_int_ghost_ab.Squad);
            await Engine.sleep(15);
            Engine.device_operates_automatically_set(veh_int_door_a.Entity, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_veh_int_b, Engine.players()));
            Engine.game_save();
            Engine.ai_renew(covenant1);
            this.g_veh_int_migrate_b = true;
            Engine.wake(new ScriptMethodReference(ai_veh_int_ghost_spawn));
            Engine.ai_place(veh_int_sen_elim_rt.Squad);
            Engine.ai_place(veh_int_sen_elim_lt.Squad);
            Engine.ai_magically_see(veh_int_wraith.Squad, veh_int_sen);
            Engine.ai_place(veh_int_flood_bk.runner);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_veh_int_c, Engine.players()));
            Engine.data_mine_set_mission_segment("enc_vehicle_int_bk");
            Engine.game_save();
            this.g_veh_int_migrate_c = true;
            Engine.wake(new ScriptMethodReference(sc_factory_approach));
            Engine.ai_renew(covenant1);
            Engine.ai_place(veh_int_wraith.driver);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_veh_int_d, Engine.players()));
            this.g_veh_int_migrate_d = true;
            this.g_veh_int_ghost_spawn = true;
            Engine.ai_place(veh_int_flood_hog_bk.Squad);
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task enc_qz_ext_a()
        {
            Engine.data_mine_set_mission_segment("enc_qz_ext_a_dam");
            Engine.print("initialize quarantine zone exterior a scripts");
            Engine.game_save();
            Engine.ai_renew(covenant1);
            Engine.ai_disposable(veh_int_flood, true);
            Engine.ai_disposable(veh_int_sen, true);
            this.g_veh_int_migrate_e = true;
            this.g_ext_a_dam_migrate_a = true;
            Engine.wake(new ScriptMethodReference(music_06b_02));
            Engine.wake(new ScriptMethodReference(ai_ext_a_dam_enforcers));
            Engine.device_set_position(qz_dam_door_a.Entity, 1F);
            Engine.ai_place(qz_ext_a_dam_enf.a);
            Engine.ai_place(qz_ext_a_dam_human.Squad);
            Engine.ai_place(qz_ext_a_dam_sen.Squad);
            Engine.ai_place(qz_ext_a_dam_sen_elim.Squad);
            Engine.ai_place(qz_ext_a_dam_flood_ini.Squad);
            Engine.wake(new ScriptMethodReference(chapter_competition));
            Engine.game_save();
            Engine.ai_renew(covenant1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(qz_ext_a_dam_b, Engine.players()));
            this.g_ext_a_dam_migrate_b = true;
            Engine.ai_place(qz_ext_a_dam_flood_cliff_a.Squad);
            Engine.ai_place(qz_ext_a_dam_flood_cliff_b.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_a, Engine.players()));
            Engine.data_mine_set_mission_segment("enc_qz_ext_a");
            Engine.game_save();
            Engine.ai_renew(covenant1);
            this.g_ext_a_dam_enf = true;
            this.g_ext_a_migrate_a = true;
            Engine.ai_disposable(ext_a_flood_dam_a, true);
            Engine.ai_disposable(ext_a_flood_dam_b, true);
            Engine.ai_disposable(ext_a_sen_dam_a, true);
            Engine.ai_disposable(ext_a_sen_dam_b, true);
            Engine.wake(new ScriptMethodReference(ai_qz_ext_a_wraiths));
            Engine.ai_place(qz_ext_a_enf_a.Squad);
            Engine.ai_place(qz_ext_a_flood_rocket.Squad);
            if ((short)Engine.ai_living_count(covenant1) <= 1)
            {
                Engine.wake(new ScriptMethodReference(sc_ext_a));
                Engine.ai_place(qz_ext_a_phantom.Squad);
            }

            this.v_ext_a_phantom = Engine.ai_vehicle_get_from_starting_location(qz_ext_a_phantom.phantom);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_b, Engine.players()));
            this.g_ext_a_migrate_b = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_c, Engine.players()));
            Engine.game_save_no_timeout();
            Engine.ai_renew(covenant1);
            this.g_ext_a_migrate_c = true;
            Engine.ai_place(qz_ext_a_flood_c.Squad);
            Engine.ai_place(qz_ext_a_flood_c2.Squad);
            Engine.ai_place(ext_a_flood_ghost_fr.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_d, Engine.players()));
            this.g_ext_a_migrate_d = true;
            Engine.wake(new ScriptMethodReference(ai_qz_ext_a_ghosts));
            Engine.wake(new ScriptMethodReference(ai_qz_ext_a_d_spawn));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_e, Engine.players()));
            Engine.game_save();
            Engine.ai_renew(covenant1);
            this.g_ext_a_migrate_e = true;
            this.g_qz_ext_a_d_spawn = false;
            Engine.ai_place(ext_a_sen_elim_bk.Squad);
            if ((short)Engine.ai_living_count(qz_ext_a_enf_bk.Squad) <= 0)
            {
                Engine.ai_place(qz_ext_a_enf_bk.Squad);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_ghosts_off, Engine.players()));
            this.g_qz_ext_a_flood_ghosts = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_f, Engine.players()));
            Engine.data_mine_set_mission_segment("enc_ext_a_fact_ent");
            Engine.game_save_no_timeout();
            this.g_ext_a_migrate_f = true;
            this.g_music_06b_02 = true;
            Engine.ai_renew(covenant1);
            Engine.ai_place(fact_ent_flood_scorpion.Squad);
            Engine.ai_place(fact_ent_flood_wraith_b.Squad);
            Engine.wake(new ScriptMethodReference(ai_fact_ent_sen_spawn));
            Engine.wake(new ScriptMethodReference(ai_fact_ent_enf_spawn));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_a_fact_ent, Engine.players()));
            this.g_ext_a_fact_ent_migrate = true;
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task enc_crashed_factory()
        {
            Engine.data_mine_set_mission_segment("enc_crashed_factory_a");
            Engine.game_save();
            Engine.ai_renew(covenant1);
            Engine.ai_disposable(ext_a_flood, true);
            Engine.ai_disposable(ext_a_sen, true);
            this.g_music_06b_02 = false;
            this.g_music_06b_03 = true;
            this.g_fact_ent_sen_spawn = true;
            Engine.wake(new ScriptMethodReference(music_06b_03));
            Engine.wake(new ScriptMethodReference(sent_factory_1_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_factory_1_exit, Engine.players()) == true);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_gorge, Engine.players()));
            Engine.data_mine_set_mission_segment("enc_crashed_factory_ext");
            Engine.game_save();
            Engine.ai_disposable(factory1_enemies, true);
            this.g_music_06b_03 = false;
            Engine.ai_set_orders(covenant1, cov_follow_gorge);
            Engine.ai_renew(covenant1);
            Engine.wake(new ScriptMethodReference(ai_gorge));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_factory2_enter, Engine.players()));
            Engine.data_mine_set_mission_segment("enc_crashed_factory_b");
            Engine.game_save();
            Engine.ai_disposable(gorge_enemies, true);
            Engine.ai_set_orders(covenant1, cov_follow_factory2);
            Engine.ai_renew(covenant1);
            Engine.wake(new ScriptMethodReference(ai_factory2));
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task enc_qz_ext_b()
        {
            Engine.data_mine_set_mission_segment("enc_ext_b_fact_exit");
            Engine.print("initialize quarantine zone exterior b scripts");
            Engine.game_save_no_timeout();
            Engine.ai_renew(covenant1);
            Engine.ai_disposable(factory2_enemies, true);
            Engine.wake(new ScriptMethodReference(music_06b_04));
            Engine.wake(new ScriptMethodReference(sc_factory_exit));
            Engine.wake(new ScriptMethodReference(objective_push_clear));
            Engine.wake(new ScriptMethodReference(objective_link_set));
            Engine.wake(new ScriptMethodReference(ext_b_vehicle_orders));
            Engine.ai_place(qz_ext_b_fact_scorpion.Squad);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(qz_ext_b_fact_scorpion.scorpion), true);
            Engine.ai_place(qz_ext_b_fact_wraith.Squad);
            Engine.ai_place(qz_ext_b_fact_ghosts.Squad);
            Engine.ai_place(qz_ext_b_fact_flood.Squad);
            Engine.ai_place(qz_ext_b_fact_ghosts_spare.Squad);
            Engine.ai_place(qz_ext_b_enf_a.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_fact_mid, Engine.players()));
            Engine.game_save();
            if (Engine.random_range(0, 2) == 1 ? true : false)
            {
                Engine.ai_place(qz_ext_b_fact_warthog.Squad);
            }
            else
            {
                Engine.ai_place(qz_ext_b_fact_ghost_bk.Squad);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_b_flood_a) <= 0 && (short)Engine.ai_living_count(ext_b_sentinels_a) <= 0 || Engine.volume_test_objects(tv_ext_b_gate, Engine.players()), 5);
            Engine.data_mine_set_mission_segment("enc_qz_ext_b");
            Engine.game_save();
            Engine.ai_renew(covenant1);
            this.g_ext_b_migrate_1 = true;
            Engine.wake(new ScriptMethodReference(ai_ext_b_enf_spawn));
            this.g_music_06b_04 = true;
            Engine.ai_place(qz_ext_b_cov_phantom.Squad);
            Engine.ai_place(qz_ext_b_wraith_a.Squad);
            Engine.ai_place(qz_ext_b_wraith_b.Squad);
            Engine.ai_place(qz_ext_b_ghosts_a.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(ext_b_flood), 0F, 2F));
            Engine.ai_place(qz_ext_b_warthog.Squad);
            this.v_ext_b_phantom = Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_phantom.phantom);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_b_flood_b) <= 0 && (short)Engine.ai_living_count(ext_b_sentinels_b) <= 0 || Engine.volume_test_objects(tv_ext_b_mid, Engine.players()), 5);
            Engine.game_save_no_timeout();
            Engine.ai_renew(covenant1);
            this.g_ext_b_migrate_2 = true;
            Engine.ai_place(qz_ext_b_ghosts_b.Squad);
            Engine.ai_place(qz_ext_b_warthog_gauss.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_back, Engine.players()), 5);
            Engine.data_mine_set_mission_segment("enc_qz_ext_b_bk");
            Engine.game_save_no_timeout();
            Engine.ai_renew(covenant1);
            Engine.ai_disposable(ext_b_flood, true);
            Engine.ai_disposable(ext_b_sentinels, true);
            this.g_ext_b_migrate_3 = true;
            this.g_ext_b_enforcer = true;
            Engine.wake(new ScriptMethodReference(ai_constructor_flock));
            Engine.wake(new ScriptMethodReference(ai_ext_b_bk_ghost_spawn));
            Engine.ai_place(qz_ext_b_ent_enf.Squad);
            Engine.ai_place(qz_ext_b_ent_scorpion.Squad);
            Engine.ai_place(qz_ext_b_ent_wraith_a.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_ext_b_exit, Engine.players()), 5);
            Engine.data_mine_set_mission_segment("enc_qz_ext_b_exit");
            Engine.game_save();
            Engine.ai_renew(covenant1);
            this.g_ext_b_bk_ghost_spawn = true;
            this.g_ext_b_migrate_4 = true;
            Engine.wake(new ScriptMethodReference(ai_ext_b_exit_tube_a));
            Engine.wake(new ScriptMethodReference(ai_ext_b_exit_tube_b));
            Engine.ai_place(qz_ext_b_ent_turrets.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(ext_b_flood_d) <= 0 && (short)Engine.ai_living_count(ext_b_sentinels_d) <= 0 || Engine.volume_test_objects(tv_ext_b_exit_door, Engine.players()), 5);
            Engine.game_save_no_timeout();
            Engine.ai_renew(covenant1);
            this.g_ext_b_migrate_5 = true;
            Engine.ai_place(qz_ext_b_ent_flood_bk.Squad, (short)Engine.pin(8F - (float)Engine.ai_nonswarm_count(ext_b_flood), 0F, 6F));
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task enc_key_ride()
        {
            Engine.print("initialize key ride scripts");
            Engine.ai_renew(covenant1);
            Engine.wake(new ScriptMethodReference(music_06b_05));
            Engine.wake(new ScriptMethodReference(music_06b_06));
            Engine.wake(new ScriptMethodReference(music_06b_07));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_key_ride_cinematic, Engine.players()));
            await this.cinematic_fade_to_white();
            Engine.ai_erase_all();
            Engine.object_teleport(await this.player0(), key_ride_a);
            Engine.object_teleport(await this.player1(), key_ride_b);
            await Engine.sleep(5);
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    Engine.print("c06_intra2");
                    await this.c06_intra2();
                }

                await this.cinematic_skip_stop();
            }

            Engine.wake(new ScriptMethodReference(begin_key_ride_main));
            await Engine.sleep(25);
            Engine.game_save_immediate();
            Engine.wake(new ScriptMethodReference(chapter_gallery));
            Engine.wake(new ScriptMethodReference(objective_link_clear));
            Engine.wake(new ScriptMethodReference(objective_retrieve_set));
            Engine.ai_renew(covenant1);
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white();
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task enc_library()
        {
            Engine.print("initialize library scripts");
            Engine.game_save();
            Engine.game_save();
            Engine.ai_renew(covenant1);
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task mission_floodzone()
        {
            await this.cinematic_snap_to_white();
            Engine.switch_bsp(0);
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    Engine.print("c06_intra1");
                    await this.c06_intra1();
                }

                await this.cinematic_skip_stop();
            }

            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), player0_start);
            Engine.object_teleport(await this.player1(), player1_start);
            Engine.wake(new ScriptMethodReference(enc_cov_charge));
            if (await this.difficulty_legendary())
            {
                Engine.wake(new ScriptMethodReference(ice_cream_superman));
            }

            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_mirror));
            Engine.wake(new ScriptMethodReference(objective_push_set));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_vehicle_int, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_vehicle_int));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_ext_a, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_qz_ext_a));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_factory, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_crashed_factory));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_ext_b, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_qz_ext_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_key_ride, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_key_ride));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_x07, Engine.players()));
            await this.cinematic_fade_to_white();
            Engine.ai_erase_all();
            Engine.object_teleport(await this.player0(), player0_end);
            Engine.object_teleport(await this.player1(), player1_end);
            if (await this.cinematic_skip_start())
            {
                Engine.print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            await this.playtest_mission();
            Engine.game_won();
        }

        [ScriptMethod(284, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_floodzone));
        }

        [ScriptMethod(285, Lifecycle.Startup)]
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

        [ScriptMethod(286, Lifecycle.Static)]
        public async Task test()
        {
            this.g_play_cinematics = false;
            Engine.device_set_position(qz_door_a.Entity, 1F);
            Engine.device_set_position(veh_int_door_a.Entity, 1F);
            Engine.device_set_position(veh_int_door_b.Entity, 1F);
            Engine.device_set_position(qz_dam_door_a.Entity, 1F);
            Engine.ai_place(qz_cov_def_spectre.Squad);
            Engine.ai_place(qz_cov_def_ghosts.Squad);
            Engine.ai_place(qz_cov_def_spec_ops.Squad);
            Engine.wake(new ScriptMethodReference(ext_a_vehicle_orders));
            Engine.wake(new ScriptMethodReference(dam_door_a));
            Engine.wake(new ScriptMethodReference(dam_door_b));
            await Engine.sleep(90);
            this.g_qz_cov_def_progress = true;
        }

        [ScriptMethod(287, Lifecycle.Static)]
        public async Task test_ext_a_phantom()
        {
            Engine.ai_place(qz_ext_a_phantom.Squad);
            this.v_ext_a_phantom = Engine.ai_vehicle_get_from_starting_location(qz_ext_a_phantom.phantom);
        }

        [ScriptMethod(288, Lifecycle.Static)]
        public async Task test_ext_b_phantom()
        {
            Engine.ai_place(qz_ext_b_cov_phantom.Squad);
            this.v_ext_b_phantom = Engine.ai_vehicle_get_from_starting_location(qz_ext_b_cov_phantom.phantom);
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task _06_intra1_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3786997827U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 35, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3843163036U), 0);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3786997827U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 7);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_base\\cov_watchtower_base", 3848602607U), 2);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 1, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 23, true);
            await Engine.sleep(31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 61);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\turrets\\plasma\\plasma", 3850306569U), 10);
            await Engine.sleep(148);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 25, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3786997827U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_sentinel\\door_sentinel", 3850372106U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_pod\\cov_watchtower_pod", 3851879457U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_base\\cov_watchtower_base", 3848602607U), 2);
            await Engine.sleep(148);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 61);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\turrets\\plasma\\plasma", 3850306569U), 10);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3786997827U), 1);
            await Engine.sleep(67);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 27, true);
            await Engine.sleep(140);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 11, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3786997827U), 2);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 20, false);
            await Engine.sleep(24);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 32, true);
            await Engine.sleep(79);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 5, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 28, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 25, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 17, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 27, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 29, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 16, true);
            await Engine.sleep(27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_watchtower\\cov_watchtower_base\\cov_watchtower_base", 3848602607U), 2);
            await Engine.sleep(45);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 61);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\spectre", 3848995829U), 63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\spectre\\turrets\\plasma\\plasma", 3850306569U), 10);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06a_sentinelwalls\\sentinelhq_2"), 11, true);
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task _06_intra2_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3843163036U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3851944994U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\key_cine\\key_cine", 3853386808U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\mtdoom\\mtdoom", 3786801216U), 7);
            await Engine.sleep(138);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 1);
            await Engine.sleep(89);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 6);
            await Engine.sleep(23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 10);
            await Engine.sleep(27);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            await Engine.sleep(47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3851944994U), 0);
            await Engine.sleep(90);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 5);
            await Engine.sleep(103);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3854500937U), 0);
            await Engine.sleep(99);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3855615066U), 0);
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task _06_intra2_02_predict()
        {
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3851944994U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3856073825U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3843163036U), 0);
            await Engine.sleep(22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 18);
            await Engine.sleep(45);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 3);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3856073825U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 2);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 32);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            await Engine.sleep(82);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 5);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 3);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 23);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3806724464U), 1);
            await Engine.sleep(13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 10);
            await Engine.sleep(13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3851944994U), 0);
            await Engine.sleep(74);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3843490721U), 23);
            await Engine.sleep(123);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3855615066U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3856073825U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3843163036U), 0);
            await Engine.sleep(115);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 0, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3854500937U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3855615066U), 0);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task _06_intra2_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 1);
            await Engine.sleep(34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3842114444U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 1);
            await Engine.sleep(116);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3843097499U), 4);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 4, true);
            await Engine.sleep(82);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_5"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel_rusted\\door_key_tunnel_rusted", 3856073825U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\gas_container\\gas_container", 3856401510U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\door_key_tunnel\\door_key_tunnel", 3855615066U), 0);
            await Engine.sleep(536);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 75, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 59, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 66, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 73, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 76, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\sentinelhq\\firstwall\\firstwall", 3782934533U), 11);
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task x07_01_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 37, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\key\\key", 3857187954U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3859874971U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3860202656U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3860202656U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3843163036U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 16, true);
            await Engine.sleep(151);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(135);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(60);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task x07_02_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 60);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(86);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await Engine.sleep(148);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(37);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(49);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3861251248U), 60);
            await Engine.sleep(21);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            await Engine.sleep(41);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            await Engine.sleep(79);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 11, true);
            await Engine.sleep(55);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task x07_03_predict()
        {
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 2);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await Engine.sleep(99);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3866232060U), 2);
            await Engine.sleep(94);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(86);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(125);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(36);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            await Engine.sleep(49);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            await Engine.sleep(36);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await Engine.sleep(16);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(30);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 1);
            await Engine.sleep(103);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 2);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await Engine.sleep(30);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 1);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task x07_04_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 2);
            await Engine.sleep(38);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await Engine.sleep(44);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(46);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            await Engine.sleep(56);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(18);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(34);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3869705521U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(183);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task x07_05_predict()
        {
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857908861U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3869705521U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\brute_shot\\brute_shot", 3870164280U), 2);
            await Engine.sleep(113);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(94);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 7, false);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            await Engine.sleep(65);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(45);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            await Engine.sleep(54);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            await Engine.sleep(13);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            await Engine.sleep(16);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3810722221U), 3);
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task x07_06_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await Engine.sleep(95);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            await Engine.sleep(89);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            await Engine.sleep(104);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            await Engine.sleep(63);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
            await Engine.sleep(28);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 10, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3839886186U), 10);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            await Engine.sleep(147);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\06b_floodzone\\sen_hq_bsp_6"), 8, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3867477263U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3869705521U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3865642227U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\sentinelhq\\library_blocker\\library_blocker", 3860923563U), 0);
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task tele_vehicle_int()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(1);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), vehicle_int_a);
            Engine.object_teleport(await this.player1(), vehicle_int_b);
            Engine.fade_in(0F, 0F, 0F, 60);
            Engine.print("erasing ai...");
            Engine.ai_erase_all();
            await Engine.sleep(5);
            Engine.print("initializing area scripts...");
            Engine.wake(new ScriptMethodReference(enc_vehicle_int));
            await Engine.sleep(10);
            Engine.player_enable_input(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_ext_a, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_qz_ext_a));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_factory, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_crashed_factory));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_ext_b, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_qz_ext_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_key_ride, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_key_ride));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_x07, Engine.players()));
            if (await this.cinematic_skip_start())
            {
                Engine.print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task tele_ext_a()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(1);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), qz_ext_a_a);
            Engine.object_teleport(await this.player1(), qz_ext_a_b);
            Engine.fade_in(0F, 0F, 0F, 60);
            Engine.print("erasing ai...");
            Engine.ai_erase_all();
            await Engine.sleep(5);
            Engine.print("initializing area scripts...");
            Engine.wake(new ScriptMethodReference(enc_qz_ext_a));
            await Engine.sleep(10);
            Engine.player_enable_input(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_factory, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_crashed_factory));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_ext_b, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_qz_ext_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_key_ride, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_key_ride));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_x07, Engine.players()));
            if (await this.cinematic_skip_start())
            {
                Engine.print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }

        [ScriptMethod(301, Lifecycle.Static)]
        public async Task tele_factory_1()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(2);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), factory1_a);
            Engine.object_teleport(await this.player1(), factory1_b);
            Engine.fade_in(0F, 0F, 0F, 60);
            Engine.print("erasing ai...");
            Engine.ai_erase_all();
            await Engine.sleep(5);
            Engine.print("initializing area scripts...");
            Engine.wake(new ScriptMethodReference(enc_crashed_factory));
            await Engine.sleep(10);
            Engine.player_enable_input(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_qz_ext_b, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_qz_ext_b));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_key_ride, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_key_ride));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_x07, Engine.players()));
            if (await this.cinematic_skip_start())
            {
                Engine.print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task tele_ext_b()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(2);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), qz_ext_b_a);
            Engine.object_teleport(await this.player1(), qz_ext_b_b);
            Engine.fade_in(0F, 0F, 0F, 60);
            Engine.print("erasing ai...");
            Engine.ai_erase_all();
            await Engine.sleep(5);
            Engine.print("initializing area scripts...");
            Engine.wake(new ScriptMethodReference(enc_qz_ext_b));
            await Engine.sleep(10);
            Engine.player_enable_input(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_key_ride, Engine.players()));
            Engine.wake(new ScriptMethodReference(enc_key_ride));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_x07, Engine.players()));
            if (await this.cinematic_skip_start())
            {
                Engine.print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task tele_key()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(3);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), key_ride_a);
            Engine.object_teleport(await this.player1(), key_ride_b);
            Engine.fade_in(0F, 0F, 0F, 60);
            Engine.print("erasing ai...");
            Engine.ai_erase_all();
            await Engine.sleep(5);
            Engine.print("initializing area scripts...");
            Engine.wake(new ScriptMethodReference(enc_key_ride));
            await Engine.sleep(10);
            Engine.player_enable_input(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_x07, Engine.players()));
            if (await this.cinematic_skip_start())
            {
                Engine.print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task tele_library()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(1);
            Engine.player_enable_input(false);
            Engine.print("switching bsp...");
            await Engine.sleep(15);
            Engine.switch_bsp(4);
            Engine.print("teleporting players...");
            Engine.object_teleport(await this.player0(), library_a);
            Engine.object_teleport(await this.player1(), library_b);
            Engine.fade_in(0F, 0F, 0F, 60);
            Engine.print("erasing ai...");
            Engine.ai_erase_all();
            await Engine.sleep(5);
            Engine.print("initializing area scripts...");
            await Engine.sleep(10);
            Engine.player_enable_input(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_x07, Engine.players()));
            if (await this.cinematic_skip_start())
            {
                Engine.print("x07");
                await this.x07();
            }

            await this.cinematic_skip_stop();
            Engine.game_won();
        }
    }
}