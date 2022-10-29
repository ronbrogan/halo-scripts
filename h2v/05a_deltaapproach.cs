namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\05a_deltaapproach\\05a_deltaapproach")]
    public partial class scnr_05a_deltaapproach : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        int straggler_no;
        EffectTag phantom_boom;
        int lz_turret_count;
        bool lz_mounted_up;
        bool ride_ally_comment_go;
        bool lz_pelican_in_sight;
        bool lz_pelican_arrived;
        bool turrets_down;
        bool lz_phantom_01_leaving;
        bool lz_phantom_02_leaving;
        bool lz_phantom_03_leaving;
        bool wraith_warning_go;
        int bridge_vehicles_total;
        bool regret_ally_comment_go;
        bool bunker_holo_trans;
        bool bunker_holo_chant;
        bool bridge_ally_comment_go;
        bool bridge_pelican_in_sight;
        bool bridge_pelican_arrived;
        float bridge_state;
        int w_path_turret_count;
        int w_path_spawn_count;
        int temple_ent_near_turret;
        int temple_ent_far_turret;
        int temple_ent_spawn_count;
        bool temple_ent_phase_01;
        bool temple_ent_phase_02;
        bool structure_comment_go;
        bool old_temple_pel_comment_go;
        bool old_temple_bombs_away;
        int old_temple_veh_total;
        bool old_temple_ghosts_over;
        bool old_temple_chatter;
        bool old_temp_middle_go;
        bool court_holo_chant;
        bool court_holo_trans;
        int grotto_final_snipers;
        bool tower1_holo_trans;
        bool tower1_holo_chant;
        bool who_points;
        public scnr_05a_deltaapproach(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.straggler_no = 0;
            this.phantom_boom = GetTag<EffectTag>("effects\\scenarios\\solo\\deltatemple\\phantom_explosion", 2155945547U);
            this.lz_turret_count = 2;
            this.lz_mounted_up = false;
            this.ride_ally_comment_go = false;
            this.lz_pelican_in_sight = false;
            this.lz_pelican_arrived = false;
            this.turrets_down = false;
            this.lz_phantom_01_leaving = false;
            this.lz_phantom_02_leaving = false;
            this.lz_phantom_03_leaving = false;
            this.wraith_warning_go = false;
            this.bridge_vehicles_total = 1;
            this.regret_ally_comment_go = false;
            this.bunker_holo_trans = false;
            this.bunker_holo_chant = true;
            this.bridge_ally_comment_go = false;
            this.bridge_pelican_in_sight = false;
            this.bridge_pelican_arrived = false;
            this.bridge_state = 0F;
            this.w_path_turret_count = 1;
            this.w_path_spawn_count = 5;
            this.temple_ent_near_turret = 1;
            this.temple_ent_far_turret = 1;
            this.temple_ent_spawn_count = 5;
            this.temple_ent_phase_01 = false;
            this.temple_ent_phase_02 = false;
            this.structure_comment_go = false;
            this.old_temple_pel_comment_go = false;
            this.old_temple_bombs_away = false;
            this.old_temple_veh_total = 2;
            this.old_temple_ghosts_over = false;
            this.old_temple_chatter = false;
            this.old_temp_middle_go = false;
            this.court_holo_chant = true;
            this.court_holo_trans = false;
            this.grotto_final_snipers = 1;
            this.tower1_holo_trans = false;
            this.tower1_holo_chant = true;
            this.who_points = true;
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
        public async Task x05_01_predict_stub()
        {
            wake(new ScriptMethodReference(x05_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task x05_02_predict_stub()
        {
            wake(new ScriptMethodReference(x05_02_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task x05_03_predict_stub()
        {
            wake(new ScriptMethodReference(x05_03_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task x05_04_predict_stub()
        {
            wake(new ScriptMethodReference(x05_04_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task x05_05_predict_stub()
        {
            wake(new ScriptMethodReference(x05_05_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task x05_06a_predict_stub()
        {
            wake(new ScriptMethodReference(x05_06a_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task x05_06b_predict_stub()
        {
            wake(new ScriptMethodReference(x05_06b_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task x05_07_predict_stub()
        {
            wake(new ScriptMethodReference(x05_07_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task x05_08_predict_stub()
        {
            wake(new ScriptMethodReference(x05_08_predict));
        }

        [ScriptMethod(33, Lifecycle.Static)]
        public async Task _05_intro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_05_intro_01_predict));
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task _05_intro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_05_intro_02_predict));
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task _05_intro_03_predict_stub()
        {
            wake(new ScriptMethodReference(_05_intro_03_predict));
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task x05_score_01()
        {
            await sleep(40);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_01_mus", 3830842080U), default(IGameObject), 1F);
            print("x05 score 01 start");
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task x05_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_01_fol", 3830907617U), default(IGameObject), 1F);
            print("x05 foley 01 start");
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task x05_slipspace_open()
        {
            await sleep(10);
            print("effect - slipspace open");
            object_create_anew(x05_slipspace);
            await sleep(300);
            object_destroy(x05_slipspace.Entity);
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_01()
        {
            cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            object_uses_cinematic_lighting(carrier.Entity, true);
            object_uses_cinematic_lighting(iac.Entity, true);
            object_uses_cinematic_lighting(x05_debris.Entity, true);
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task x05_02_problem_actors()
        {
            print("problem actors");
            object_create_anew(miranda);
            object_create_anew(iac_bridge);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(iac_bridge.Entity, true);
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task x05_01_setup()
        {
            object_create_anew(carrier);
            object_create_anew(iac);
            object_create_anew(x05_debris);
            object_cinematic_lod(carrier.Entity, true);
            object_cinematic_lod(iac.Entity, true);
            object_cinematic_lod(x05_debris.Entity, true);
            wake(new ScriptMethodReference(x05_score_01));
            wake(new ScriptMethodReference(x05_foley_01));
            wake(new ScriptMethodReference(x05_slipspace_open));
            wake(new ScriptMethodReference(x05_cinematic_lighting_scene_01));
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task x05_01_cleanup()
        {
            object_destroy(carrier.Entity);
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task x05_scene_01()
        {
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.x05_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_01_mus", 3830842080U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_01_fol", 3830907617U));
            await sleep(this.prediction_offset);
            await this.x05_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_01", default(IUnit), anchor_flag_x05);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3831038691U), "iac_01", anchor_x05.Entity);
            scenery_animation_start_relative(carrier.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x05\\x05", 3831104228U), "capital_ship_01", anchor_x05.Entity);
            scenery_animation_start_relative(x05_debris.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\effects\\x05_building_debris\\x05\\x05", 3831169765U), "debris_01", anchor_x05.Entity);
            fade_in(0F, 0F, 0F, 30);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_02_predict_stub();
            await this.x05_02_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_02_fol", 3831235302U));
            await sleep((short)camera_time());
            await this.x05_01_cleanup();
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task x05_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_02_fol", 3831235302U), default(IGameObject), 1F);
            print("x05 foley 02 start");
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task x05_0010_mir()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0010_mir", 3831300839U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0010_mir", 1F);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 15);
            print("miranda - shocked .5 15");
            unit_set_emotional_state(nav_officer.Entity, "annoyed", 0.25F, 0);
            print("nav_officer - pain .5 0");
            unit_set_emotional_state(weap_officer.Entity, "annoyed", 0.5F, 0);
            print("nav_officer - annoyed .5 0");
            await sleep(153);
            unit_set_emotional_state(miranda.Entity, "pensive", 0.5F, 30);
            print("miranda - pensive .25 30");
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task x05_0020_mir()
        {
            await sleep(25);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0020_mir", 3831366376U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0020_mir", 1F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task x05_0030_no1()
        {
            await sleep(51);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0030_no1", 3831431913U), nav_officer.Entity, 1F);
            cinematic_subtitle("x05_0030_no1", 2F);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task x05_0040_wo1()
        {
            await sleep(127);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0040_wo1", 3831497450U), weap_officer.Entity, 1F);
            cinematic_subtitle("x05_0040_wo1", 2F);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task x05_0050_mir()
        {
            await sleep(204);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0050_mir", 3831562987U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0050_mir", 2F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task x05_0060_mir()
        {
            await sleep(272);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0060_mir", 3831628524U), default(IGameObject), 1F, "radio_default_in");
            cinematic_subtitle("x05_0060_mir", 2F);
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task x05_0070_mir()
        {
            await sleep(327);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0070_mir", 3831694061U), default(IGameObject), 1F, "radio_default_out");
            cinematic_subtitle("x05_0070_mir", 1F);
            await sleep(27);
            unit_set_emotional_state(johnson.Entity, "inquisitive", 0.5F, 10);
            print("johnson - inquisitive .5 10");
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task x05_0080_jon()
        {
            await sleep(367);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0080_jon", 3831759598U), johnson.Entity, 1F);
            cinematic_subtitle("x05_0080_jon", 2F);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task x05_0090_cor()
        {
            await sleep(437);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0090_cor", 3831825135U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0090_cor", 1F);
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task x05_0100_no1()
        {
            await sleep(481);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0100_no1", 3831890672U), nav_officer.Entity, 1F);
            cinematic_subtitle("x05_0100_no1", 3F);
            unit_set_emotional_state(miranda.Entity, "pensive", 0.5F, 0);
            print("miranda - pensive .5 0");
            unit_set_emotional_state(nav_officer.Entity, "shocked", 0.5F, 30);
            print("nav_officer - shocked .5 30");
            await sleep(90);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 120);
            print("miranda - shocked .5 120");
            await sleep(60);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 90);
            print("miranda - shocked .25 90");
            await sleep(75);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.05F, 60);
            print("miranda - shocked .05 60");
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task x05_0110_mir()
        {
            await sleep(594);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0110_mir", 3831956209U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0110_mir", 3F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task x05_fov_02()
        {
            await sleep(49);
            camera_set_field_of_view(36F, 0);
            print("fov change: 60 -> 36 over 0 ticks");
            await sleep(154);
            camera_set_field_of_view(60F, 0);
            print("fov change: 36 -> 60 over 0 ticks");
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task x05_05_dof_scene_02()
        {
            await sleep(49);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 1F, 1F, 0F);
            print("rack focus");
            await sleep(76);
            cinematic_screen_effect_set_depth_of_field(1F, 0F, 1F, 0.5F, 1F, 0F, 0.5F);
            print("rack focus");
            await sleep(78);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task x05_light_scene_02_bridge_1()
        {
            print("light bridge");
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(nav_officer.Entity, true);
            object_uses_cinematic_lighting(weap_officer.Entity, true);
            object_uses_cinematic_lighting(cigar.Entity, true);
            object_uses_cinematic_lighting(iac_bridge.Entity, true);
            object_uses_cinematic_lighting(hev_bay.Entity, true);
            object_uses_cinematic_lighting(hev_01.Entity, true);
            object_uses_cinematic_lighting(hev_02.Entity, true);
            object_uses_cinematic_lighting(hev_03.Entity, true);
            object_uses_cinematic_lighting(hev_04.Entity, true);
            object_uses_cinematic_lighting(hev_05.Entity, true);
            object_uses_cinematic_lighting(hev_06.Entity, true);
            object_uses_cinematic_lighting(hev_07.Entity, true);
            object_uses_cinematic_lighting(hev_08.Entity, true);
            object_uses_cinematic_lighting(hev_09.Entity, true);
            object_uses_cinematic_lighting(hev_10.Entity, true);
            object_uses_cinematic_lighting(hev_11.Entity, true);
            object_uses_cinematic_lighting(hev_12.Entity, true);
            object_uses_cinematic_lighting(hev_13.Entity, true);
            object_uses_cinematic_lighting(hev_14.Entity, true);
            object_uses_cinematic_lighting(hev_15.Entity, true);
            object_uses_cinematic_lighting(hev_16.Entity, true);
            object_uses_cinematic_lighting(hev_17.Entity, true);
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task x05_light_scene_02_hev_1()
        {
            await sleep(264);
            print("light hev");
            cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task x05_light_scene_02_bridge_2()
        {
            await sleep(479);
            print("light bridge");
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task x05_02_setup()
        {
            object_create_anew(chief);
            object_create_anew(johnson);
            object_create_anew(nav_officer);
            object_create_anew(weap_officer);
            object_create_anew(cigar);
            object_create_anew_containing("hev");
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(nav_officer.Entity, true);
            object_cinematic_lod(weap_officer.Entity, true);
            object_cinematic_lod(cigar.Entity, true);
            object_cinematic_lod(hev_bay.Entity, true);
            object_cinematic_lod(hev_01.Entity, true);
            object_cinematic_lod(hev_02.Entity, true);
            object_cinematic_lod(hev_03.Entity, true);
            object_cinematic_lod(hev_04.Entity, true);
            object_cinematic_lod(hev_05.Entity, true);
            object_cinematic_lod(hev_06.Entity, true);
            object_cinematic_lod(hev_07.Entity, true);
            object_cinematic_lod(hev_08.Entity, true);
            object_cinematic_lod(hev_09.Entity, true);
            object_cinematic_lod(hev_10.Entity, true);
            object_cinematic_lod(hev_11.Entity, true);
            object_cinematic_lod(hev_12.Entity, true);
            object_cinematic_lod(hev_13.Entity, true);
            object_cinematic_lod(hev_14.Entity, true);
            object_cinematic_lod(hev_15.Entity, true);
            object_cinematic_lod(hev_16.Entity, true);
            object_cinematic_lod(hev_17.Entity, true);
            wake(new ScriptMethodReference(x05_0010_mir));
            wake(new ScriptMethodReference(x05_0020_mir));
            wake(new ScriptMethodReference(x05_0030_no1));
            wake(new ScriptMethodReference(x05_0040_wo1));
            wake(new ScriptMethodReference(x05_0050_mir));
            wake(new ScriptMethodReference(x05_0060_mir));
            wake(new ScriptMethodReference(x05_0070_mir));
            wake(new ScriptMethodReference(x05_0080_jon));
            wake(new ScriptMethodReference(x05_0090_cor));
            wake(new ScriptMethodReference(x05_0100_no1));
            wake(new ScriptMethodReference(x05_0110_mir));
            wake(new ScriptMethodReference(x05_foley_02));
            wake(new ScriptMethodReference(x05_fov_02));
            wake(new ScriptMethodReference(x05_05_dof_scene_02));
            wake(new ScriptMethodReference(x05_light_scene_02_bridge_1));
            wake(new ScriptMethodReference(x05_light_scene_02_hev_1));
            wake(new ScriptMethodReference(x05_light_scene_02_bridge_2));
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task x05_scene_02()
        {
            await this.x05_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_02", default(IUnit), anchor_flag_x05);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x05\\x05", 3832021746U), "miranda_02", false, anchor_x05.Entity);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3834446615U), "chief_02", false, anchor_x05.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "johnson_02", false, anchor_x05.Entity);
            custom_animation_relative(nav_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "nav_02", false, anchor_x05.Entity);
            custom_animation_relative(weap_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "weap_02", false, anchor_x05.Entity);
            scenery_animation_start_relative(cigar.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\x05\\x05", 3834643226U), "cigar_bent_02", anchor_x05.Entity);
            scenery_animation_start_relative(hev_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev01_02", anchor_x05.Entity);
            scenery_animation_start_relative(hev_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev02_02", anchor_x05.Entity);
            scenery_animation_start_relative(hev_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev03_02", anchor_x05.Entity);
            scenery_animation_start_relative(hev_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev04_02", anchor_x05.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x05\\x05", 3834774300U), "bridge_02", anchor_x05.Entity);
            scenery_animation_start_relative(hev_bay.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3834839837U), "hevbay_02", anchor_x05.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_03_mus", 3834905374U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_03_fol", 3834970911U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task x05_score_03()
        {
            await sleep(113);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_03_mus", 3834905374U), default(IGameObject), 1F);
            print("x05 score 03 start");
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task x05_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_03_fol", 3834970911U), default(IGameObject), 1F);
            print("x05 foley 03 start");
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task x05_0120_cor()
        {
            await sleep(60);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0120_cor", 3835036448U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0120_cor", 2F);
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_03()
        {
            cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task x05_03_setup()
        {
            object_create_anew(delta_halo);
            object_create_anew(matte_substance);
            object_uses_cinematic_lighting(delta_halo.Entity, true);
            wake(new ScriptMethodReference(x05_score_03));
            wake(new ScriptMethodReference(x05_foley_03));
            wake(new ScriptMethodReference(x05_0120_cor));
        }

        [ScriptMethod(68, Lifecycle.Static)]
        public async Task x05_scene_03()
        {
            await this.x05_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_03", default(IUnit), anchor_flag_x05);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3831038691U), "iac_03", anchor_x05.Entity);
            scenery_animation_start_relative(x05_debris.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\effects\\x05_building_debris\\x05\\x05", 3831169765U), "debris_03", anchor_x05.Entity);
            scenery_animation_start_relative(delta_halo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3835101985U), "halo_03", anchor_x05.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3835167522U), "substance_space_03", anchor_x05.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_04_fol", 3835233059U));
            await sleep((short)camera_time());
            object_destroy(x05_debris.Entity);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task x05_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_04_fol", 3835233059U), default(IGameObject), 1F);
            print("x05 foley 04 start");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task x05_0130_jon()
        {
            await sleep(12);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0130_jon", 3835298596U), johnson.Entity, 1F);
            cinematic_subtitle("x05_0130_jon", 1F);
            unit_set_emotional_state(johnson.Entity, "shocked", 0.75F, 10);
            print("johnson - shocked .75 10");
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task x05_0140_mir()
        {
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            print("miranda - shocked .25 0");
            await sleep(63);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0140_mir", 3835364133U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0140_mir", 2F);
            unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 60);
            print("miranda - pain .25 60");
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task x05_0150_mir()
        {
            await sleep(132);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0150_mir", 3835429670U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0150_mir", 2F);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task x05_0160_cor()
        {
            await sleep(202);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0160_cor", 3835495207U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0160_cor", 4F);
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task x05_0170_mir()
        {
            await sleep(340);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0170_mir", 3835560744U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0170_mir", 3F);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task x05_0180_mir()
        {
            await sleep(418);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0180_mir", 3835626281U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0180_mir", 2F);
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            print("miranda - angry .25 0");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task x05_0181_mir()
        {
            await sleep(483);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0181_mir", 3835691818U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0181_mir", 2F);
            texture_camera_off();
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task x05_0190_cor()
        {
            await sleep(550);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0190_cor", 3835757355U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0190_cor", 1F);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task x05_0200_mir()
        {
            await sleep(573);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0200_mir", 3835822892U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0200_mir", 1F);
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task x05_0210_wo1()
        {
            await sleep(602);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0210_wo1", 3835888429U), weap_officer.Entity, 1F);
            cinematic_subtitle("x05_0210_wo1", 3F);
            unit_set_emotional_state(weap_officer.Entity, "pensive", 0.5F, 60);
            print("weap_officer - pensive .5 60");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task x05_0220_mir()
        {
            await sleep(704);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0220_mir", 3835953966U), miranda.Entity, 1F);
            cinematic_subtitle("x05_0220_mir", 1F);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task x05_texture_camera_scene_04()
        {
            object_create_anew(texture_camera);
            texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x05\\x05", 3836019503U), "texture_camera_04", anchor_x05.Entity);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task x05_fov_04()
        {
            time_code_reset();
            await sleep(588);
            camera_set_field_of_view(34F, 0);
            print("fov change: 60 -> 34 over 0 ticks");
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task x05_05_dof_scene_04()
        {
            await sleep(589);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0F, 0F, 0F, 1F, 1F, 0F);
            print("rack focus");
            await sleep(112);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0F, 1F, 0.25F, 1F, 0F, 0.25F);
            print("rack focus");
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_04()
        {
            cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task x05_light_scene_04_bridge_1()
        {
            await sleep(49);
            print("light bridge");
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task x05_light_scene_04_hev_1()
        {
            await sleep(326);
            print("light hev");
            cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task x05_light_scene_04_bridge_2()
        {
            await sleep(467);
            print("light bridge");
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task x05_04_setup()
        {
            wake(new ScriptMethodReference(x05_0130_jon));
            wake(new ScriptMethodReference(x05_0140_mir));
            wake(new ScriptMethodReference(x05_0150_mir));
            wake(new ScriptMethodReference(x05_0160_cor));
            wake(new ScriptMethodReference(x05_0170_mir));
            wake(new ScriptMethodReference(x05_0180_mir));
            wake(new ScriptMethodReference(x05_0181_mir));
            wake(new ScriptMethodReference(x05_0190_cor));
            wake(new ScriptMethodReference(x05_0200_mir));
            wake(new ScriptMethodReference(x05_0210_wo1));
            wake(new ScriptMethodReference(x05_0220_mir));
            wake(new ScriptMethodReference(x05_texture_camera_scene_04));
            wake(new ScriptMethodReference(x05_fov_04));
            wake(new ScriptMethodReference(x05_05_dof_scene_04));
            wake(new ScriptMethodReference(x05_cinematic_lighting_scene_04));
            wake(new ScriptMethodReference(x05_light_scene_04_bridge_1));
            wake(new ScriptMethodReference(x05_light_scene_04_hev_1));
            wake(new ScriptMethodReference(x05_light_scene_04_bridge_2));
            wake(new ScriptMethodReference(x05_foley_04));
        }

        [ScriptMethod(89, Lifecycle.Static)]
        public async Task x05_04_cleanup()
        {
            object_destroy(cigar.Entity);
            object_destroy(texture_camera.Entity);
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(90, Lifecycle.Static)]
        public async Task x05_scene_04()
        {
            await this.x05_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_04", default(IUnit), anchor_flag_x05);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x05\\x05", 3832021746U), "miranda_04", false, anchor_x05.Entity);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3834446615U), "chief_04", false, anchor_x05.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "johnson_04", false, anchor_x05.Entity);
            custom_animation_relative(nav_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "nav_04", false, anchor_x05.Entity);
            custom_animation_relative(weap_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "weap_04", false, anchor_x05.Entity);
            scenery_animation_start_relative(cigar.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\x05\\x05", 3834643226U), "cigar_bent_04", anchor_x05.Entity);
            scenery_animation_start_relative(hev_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev01_04", anchor_x05.Entity);
            scenery_animation_start_relative(hev_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev02_04", anchor_x05.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x05\\x05", 3834774300U), "bridge_04", anchor_x05.Entity);
            scenery_animation_start_relative(hev_bay.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3834839837U), "hevbay_04", anchor_x05.Entity);
            scenery_animation_start_relative(delta_halo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3835101985U), "halo_04", anchor_x05.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3835167522U), "substance_space_04", anchor_x05.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_05_fol", 3836085040U));
            await sleep((short)camera_time());
            await this.x05_04_cleanup();
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task x05_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_05_fol", 3836085040U), default(IGameObject), 1F);
            print("x05 foley 05 start");
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task x05_0230_mir()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0230_mir", 3836150577U), default(IGameObject), 1F);
            cinematic_subtitle("x05_0230_mir", 6F);
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_05()
        {
            cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(94, Lifecycle.Static)]
        public async Task x05_05_setup()
        {
            wake(new ScriptMethodReference(x05_0230_mir));
            wake(new ScriptMethodReference(x05_foley_05));
            wake(new ScriptMethodReference(x05_cinematic_lighting_scene_05));
        }

        [ScriptMethod(95, Lifecycle.Static)]
        public async Task x05_scene_05()
        {
            await this.x05_05_setup();
            camera_set_field_of_view(60F, 0);
            print("fov change: 34 -> 60 over 0 ticks");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_05", default(IUnit), anchor_flag_x05);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3831038691U), "iac_05", anchor_x05.Entity);
            scenery_animation_start_relative(delta_halo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3835101985U), "halo_05", anchor_x05.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3835167522U), "substance_space_05", anchor_x05.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_06a_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_06a_mus", 3836216114U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06a_fol", 3836281651U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x05_score_06a()
        {
            await sleep(113);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_06a_mus", 3836216114U), default(IGameObject), 1F);
            print("x05 score 06a start");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task x05_foley_06a()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06a_fol", 3836281651U), default(IGameObject), 1F);
            print("x05 foley 06a start");
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task x05_0240_mir()
        {
            await sleep(0);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0240_mir", 3836347188U), default(IGameObject), 1F, "radio_default_in");
            cinematic_subtitle("x05_0240_mir", 4F);
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task x05_cinematic_light_scene_06a()
        {
            cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(100, Lifecycle.Static)]
        public async Task x05_06b_problem_actors()
        {
            object_create_anew(johnson);
            object_cinematic_lod(johnson.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task x05_06a_setup()
        {
            object_destroy(johnson.Entity);
            wake(new ScriptMethodReference(x05_score_06a));
            wake(new ScriptMethodReference(x05_foley_06a));
            wake(new ScriptMethodReference(x05_0240_mir));
            wake(new ScriptMethodReference(x05_cinematic_light_scene_06a));
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task x05_scene_06a()
        {
            await this.x05_06a_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_06a", default(IUnit), anchor_flag_x05);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3834446615U), "chief_06a", false, anchor_x05.Entity);
            scenery_animation_start_relative(hev_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev01_06a", anchor_x05.Entity);
            scenery_animation_start_relative(hev_bay.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3834839837U), "hevbay_06a", anchor_x05.Entity);
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_06b_predict_stub();
            await this.x05_06b_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06b_fol", 3836412725U));
            await sleep((short)((float)camera_time() - 5));
            cinematic_screen_effect_set_crossfade(1F);
            await sleep(5);
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task x05_foley_06b()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06b_fol", 3836412725U), default(IGameObject), 1F);
            print("x05 foley 06b start");
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task x05_0250_mir()
        {
            await sleep(9);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0250_mir", 3836478262U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0250_mir", 3F);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task x05_0260_jon()
        {
            await sleep(89);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0260_jon", 3836543799U), johnson.Entity, 1F);
            cinematic_subtitle("x05_0260_jon", 1F);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task x05_0270_mir()
        {
            await sleep(125);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0270_mir", 3836609336U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x05_0270_mir", 3F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task x05_0280_mir()
        {
            await sleep(225);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0280_mir", 3836674873U), default(IGameObject), 1F, "radio_default_out");
            cinematic_subtitle("x05_0280_mir", 2F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task x05_0290_mas()
        {
            await sleep(320);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0290_mas", 3836740410U), chief.Entity, 1F);
            cinematic_subtitle("x05_0290_mas", 1F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task x05_0300_wo1()
        {
            await sleep(356);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0300_wo1", 3836805947U), weap_officer.Entity, 1F);
            cinematic_subtitle("x05_0300_wo1", 2F);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task x05_fov_06b()
        {
            await sleep(358);
            camera_set_field_of_view(35F, 0);
            print("fov change: 60 -> 35 over 0 ticks");
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task x05_light_scene_06b_bridge_1()
        {
            time_code_reset();
            await sleep(358);
            print("light bridge");
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(112, Lifecycle.Static)]
        public async Task x05_07_problem_actors()
        {
            print("problem actors");
            object_create_anew(matte_delta_halo_close);
        }

        [ScriptMethod(113, Lifecycle.Static)]
        public async Task x05_06b_setup()
        {
            wake(new ScriptMethodReference(x05_0250_mir));
            wake(new ScriptMethodReference(x05_0260_jon));
            wake(new ScriptMethodReference(x05_0270_mir));
            wake(new ScriptMethodReference(x05_0280_mir));
            wake(new ScriptMethodReference(x05_0290_mas));
            wake(new ScriptMethodReference(x05_0300_wo1));
            wake(new ScriptMethodReference(x05_foley_06b));
            wake(new ScriptMethodReference(x05_fov_06b));
            wake(new ScriptMethodReference(x05_light_scene_06b_bridge_1));
        }

        [ScriptMethod(114, Lifecycle.Static)]
        public async Task x05_06b_cleanup()
        {
            object_destroy(miranda.Entity);
            object_destroy(johnson.Entity);
            object_destroy(nav_officer.Entity);
            object_destroy(weap_officer.Entity);
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task x05_scene_06b()
        {
            await this.x05_06b_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_06b", default(IUnit), anchor_flag_x05);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x05\\x05", 3832021746U), "miranda_06b", false, anchor_x05.Entity);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3834446615U), "chief_06b", false, anchor_x05.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "johnson_06b", false, anchor_x05.Entity);
            custom_animation_relative(nav_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "nav_06b", false, anchor_x05.Entity);
            custom_animation_relative(weap_officer.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3834512152U), "weap_06b", false, anchor_x05.Entity);
            scenery_animation_start_relative(hev_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev01_06b", anchor_x05.Entity);
            scenery_animation_start_relative(hev_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev02_06b", anchor_x05.Entity);
            scenery_animation_start_relative(hev_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev03_06b", anchor_x05.Entity);
            scenery_animation_start_relative(hev_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev04_06b", anchor_x05.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x05\\x05", 3834774300U), "bridge_06b", anchor_x05.Entity);
            scenery_animation_start_relative(hev_bay.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3834839837U), "hevbay_06b", anchor_x05.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_07_predict_stub();
            await sleep((short)((float)camera_time() - 15));
            await this.x05_07_problem_actors();
            await sleep((short)camera_time());
            await this.x05_06b_cleanup();
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_07()
        {
            cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(117, Lifecycle.Static)]
        public async Task x05_scene_07()
        {
            wake(new ScriptMethodReference(x05_cinematic_lighting_scene_07));
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_07", default(IUnit), anchor_flag_x05);
            camera_set_field_of_view(60F, 0);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3831038691U), "iac_07", anchor_x05.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3835167522U), "substance_space_07", anchor_x05.Entity);
            scenery_animation_start_relative(matte_delta_halo_close.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\x05\\x05", 3836871484U), "delta_halo_close_07", anchor_x05.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x05_08_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_08_fol", 3836937021U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task x05_foley_08()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_08_fol", 3836937021U), default(IGameObject), 1F);
            print("x05 foley 08 start");
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task x05_0310_cor()
        {
            await sleep(9);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0310_cor", 3837002558U), default(IGameObject), 1F);
            cinematic_subtitle("x05_0310_cor", 1F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task effect_hev_release()
        {
            await sleep(40);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3837068095U), hev_bay.Entity, "explosive_bolt06");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3837133632U), hev_bay.Entity, "steam_vent06");
            print("effects - first hev");
            await sleep(56);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3837068095U), hev_bay.Entity, "explosive_bolt05");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3837133632U), hev_bay.Entity, "steam_vent05");
            print("effects - second hev");
            await sleep(37);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3837068095U), hev_bay.Entity, "explosive_bolt04");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3837133632U), hev_bay.Entity, "steam_vent04");
            print("effects - second hev");
            await sleep(29);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3837068095U), hev_bay.Entity, "explosive_bolt03");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3837133632U), hev_bay.Entity, "steam_vent03");
            print("effects - second hev");
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task effect_corona()
        {
            await sleep(320);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_start", 3837264706U), hev_10.Entity, "");
            print("effect - re-entry corona");
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task x05_effect_shake_01()
        {
            await sleep(300);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.5F, 3F);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_08()
        {
            cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task x05_light_scene_08_space()
        {
            await sleep(172);
            print("light space");
            cinematic_lighting_set_primary_light(-21F, 32F, 0.48F, 0.53F, 0.69F);
            cinematic_lighting_set_secondary_light(-17F, 214F, 0.18F, 0.22F, 0.41F);
            cinematic_lighting_set_ambient_light(0.11F, 0.11F, 0.14F);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task destroy_chief()
        {
            await sleep(52);
            object_destroy(chief.Entity);
            print("destroy chief");
        }

        [ScriptMethod(126, Lifecycle.Static)]
        public async Task x05_08_setup()
        {
            wake(new ScriptMethodReference(x05_0310_cor));
            wake(new ScriptMethodReference(x05_foley_08));
            wake(new ScriptMethodReference(destroy_chief));
            wake(new ScriptMethodReference(effect_hev_release));
            wake(new ScriptMethodReference(effect_corona));
            wake(new ScriptMethodReference(x05_effect_shake_01));
            wake(new ScriptMethodReference(x05_cinematic_lighting_scene_08));
            wake(new ScriptMethodReference(x05_light_scene_08_space));
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task x05_08_cleanup()
        {
            object_destroy(delta_halo.Entity);
            object_destroy_containing("iac");
            object_destroy_containing("hev");
            object_destroy_containing("matte");
            player_effect_stop(0F);
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task x05_scene_08()
        {
            await this.x05_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3830973154U), "x05_08", default(IUnit), anchor_flag_x05);
            scenery_animation_start_relative(iac.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3831038691U), "iac_08", anchor_x05.Entity);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3834446615U), "chief_08", false, anchor_x05.Entity);
            scenery_animation_start_relative(hev_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev01_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev02_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev03_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev04_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_05.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev05_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_06.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev06_08", anchor_x05.Entity);
            scenery_animation_start_relative(delta_halo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3835101985U), "halo_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_bay.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3834839837U), "hevbay_08", anchor_x05.Entity);
            scenery_animation_start_relative(matte_delta_halo_close.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\x05\\x05", 3836871484U), "delta_halo_close_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_07.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev07_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_08.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev08_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_09.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev09_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_10.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev10_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_11.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev11_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_12.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev12_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_13.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev13_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_14.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev14_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_15.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev15_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_16.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev16_08", anchor_x05.Entity);
            scenery_animation_start_relative(hev_17.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3834708763U), "hev17_08", anchor_x05.Entity);
            await sleep((short)((float)camera_time() - 5));
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
            await this.x05_08_cleanup();
        }

        [ScriptMethod(129, Lifecycle.Static)]
        public async Task x05()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("bsp_x05"));
            await sleep(1);
            await this.x05_scene_01();
            await this.x05_scene_02();
            await this.x05_scene_03();
            await this.x05_scene_04();
            await this.x05_scene_05();
            await this.x05_scene_06a();
            await this.x05_scene_06b();
            await this.x05_scene_07();
            await this.x05_scene_08();
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task c05_intro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_01_fol", 3837330243U), default(IGameObject), 1F);
            print("c05_intro foley 01 start");
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task c05_1010_cor()
        {
            await sleep(192);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_1010_cor", 3837395780U), default(IGameObject), 1F);
            cinematic_subtitle("c05_1010_cor", 1F);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task effect_burn_contrails()
        {
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3837461317U), corona_02.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3837526854U), corona_02.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3837461317U), corona_03.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3837526854U), corona_03.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3837461317U), corona_04.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3837526854U), corona_04.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3837461317U), corona_05.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3837526854U), corona_05.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3837461317U), corona_06.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3837526854U), corona_06.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3837461317U), corona_07.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3837526854U), corona_07.Entity, "");
            print("effect - burn, contrail");
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task effect_chute_pins()
        {
            await sleep(259);
            print("effect - chute pins");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3837068095U), hev_02.Entity, "cable_release");
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task effect_retros_01()
        {
            await sleep(264);
            print("effect - retro rockets");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_02.Entity, "retro_rocket");
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task c05_intro_dof_01()
        {
            time_code_reset();
            await sleep(79);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(20F, 0F, 0F, 0F, 5F, 5F, 0F);
            print("rack focus");
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task c05_intro_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(-21F, 32F, 0.48F, 0.53F, 0.69F);
            cinematic_lighting_set_secondary_light(-17F, 214F, 0.18F, 0.22F, 0.41F);
            cinematic_lighting_set_ambient_light(0.11F, 0.11F, 0.14F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(hev_01.Entity, true);
            object_uses_cinematic_lighting(hev_02.Entity, true);
            object_uses_cinematic_lighting(hev_03.Entity, true);
            object_uses_cinematic_lighting(hev_04.Entity, true);
            object_uses_cinematic_lighting(hev_05.Entity, true);
            object_uses_cinematic_lighting(hev_06.Entity, true);
            object_uses_cinematic_lighting(hev_07.Entity, true);
            object_uses_cinematic_lighting(hev_chute.Entity, true);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task hev_unhide()
        {
            await sleep(126);
            print("hev unhide");
            object_hide(hev_06.Entity, false);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task destroy_corona_02()
        {
            await sleep(210);
            print("destroy corona 02");
            object_destroy(corona_02.Entity);
        }

        [ScriptMethod(139, Lifecycle.Static)]
        public async Task c05_intro_01_setup()
        {
            object_create_anew(chief);
            object_create_anew(hev_01);
            object_create_anew(hev_02);
            object_create_anew(hev_03);
            object_create_anew(hev_04);
            object_create_anew(hev_05);
            object_create_anew(hev_06);
            object_create_anew(hev_07);
            object_create_anew(hev_chute);
            object_create_anew(corona_01);
            object_create_anew(corona_02);
            object_create_anew(corona_03);
            object_create_anew(corona_04);
            object_create_anew(corona_05);
            object_create_anew(corona_06);
            object_create_anew(corona_07);
            object_create_anew(matte_horizon);
            object_create_anew(matte_islands);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(hev_01.Entity, true);
            object_cinematic_lod(hev_02.Entity, true);
            object_cinematic_lod(hev_03.Entity, true);
            object_cinematic_lod(hev_04.Entity, true);
            object_cinematic_lod(hev_05.Entity, true);
            object_cinematic_lod(hev_06.Entity, true);
            object_cinematic_lod(hev_07.Entity, true);
            object_cinematic_lod(hev_chute.Entity, true);
            object_hide(hev_06.Entity, true);
            wake(new ScriptMethodReference(c05_1010_cor));
            wake(new ScriptMethodReference(c05_intro_foley_01));
            wake(new ScriptMethodReference(destroy_corona_02));
            wake(new ScriptMethodReference(effect_burn_contrails));
            wake(new ScriptMethodReference(hev_unhide));
            wake(new ScriptMethodReference(effect_chute_pins));
            wake(new ScriptMethodReference(effect_retros_01));
            wake(new ScriptMethodReference(c05_intro_dof_01));
            wake(new ScriptMethodReference(c05_intro_cinematic_light_01));
        }

        [ScriptMethod(140, Lifecycle.Static)]
        public async Task c05_intro_01_cleanup()
        {
            object_destroy(chief_intro.Entity);
            object_destroy_containing("matte");
            object_destroy(hev_01.Entity);
            object_destroy(hev_02.Entity);
            object_destroy(hev_03.Entity);
            object_destroy(hev_04.Entity);
            object_destroy(hev_05.Entity);
            object_destroy(hev_06.Entity);
            object_destroy(hev_07.Entity);
            object_destroy_containing("corona");
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task c05_intro_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._05_intro_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_01_fol", 3837330243U));
            await sleep(this.prediction_offset);
            await this.c05_intro_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intro\\05_intro", 3837920076U), "05_intro_01", default(IUnit), anchor_flag_x05);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intro\\05_intro", 3837985613U), "chief_01", false, anchor_x05.Entity);
            scenery_animation_start_relative(hev_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev01_01", anchor_x05.Entity);
            scenery_animation_start_relative(hev_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev02_01", anchor_x05.Entity);
            scenery_animation_start_relative(hev_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev03_01", anchor_x05.Entity);
            scenery_animation_start_relative(hev_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev04_01", anchor_x05.Entity);
            scenery_animation_start_relative(hev_05.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev05_01", anchor_x05.Entity);
            scenery_animation_start_relative(hev_06.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev06_01", anchor_x05.Entity);
            scenery_animation_start_relative(hev_07.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev07_01", anchor_x05.Entity);
            scenery_animation_start_relative(hev_chute.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\hev_chute\\05_intro\\05_intro", 3838116687U), "hev_chute_01", anchor_x05.Entity);
            scenery_animation_start_relative(corona_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3838182224U), "hev_reentry02_01", anchor_x05.Entity);
            scenery_animation_start_relative(corona_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3838182224U), "hev_reentry03_01", anchor_x05.Entity);
            scenery_animation_start_relative(corona_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3838182224U), "hev_reentry04_01", anchor_x05.Entity);
            scenery_animation_start_relative(corona_05.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3838182224U), "hev_reentry05_01", anchor_x05.Entity);
            scenery_animation_start_relative(corona_06.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3838182224U), "hev_reentry06_01", anchor_x05.Entity);
            scenery_animation_start_relative(corona_07.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3838182224U), "hev_reentry07_01", anchor_x05.Entity);
            scenery_animation_start_relative(matte_horizon.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\05_intro\\05_intro", 3838247761U), "delta_horizon_01", anchor_x05.Entity);
            scenery_animation_start_relative(matte_islands.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_islands\\05_intro\\05_intro", 3838313298U), "delta_islands_01", anchor_x05.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_02_fol", 3838378835U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c05_intro_01_cleanup();
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task little_alien()
        {
            if (GameDifficulty.Easy() == game_difficulty_get_real())
            {
                object_create_anew(tree_toy);
                objects_attach(grunt_01.Entity, "right_hand", tree_toy.Entity, "");
                await sleep(150);
                object_destroy(tree_toy.Entity);
            }

            if (GameDifficulty.Normal() == game_difficulty_get_real())
            {
                object_create_anew(grenade_toy_01);
                object_create_anew(grenade_toy_02);
                objects_attach(grunt_01.Entity, "right_hand", grenade_toy_01.Entity, "");
                objects_attach(grunt_01.Entity, "left_hand", grenade_toy_02.Entity, "");
                await sleep(150);
                object_destroy(grenade_toy_01.Entity);
                object_destroy(grenade_toy_02.Entity);
            }

            if (GameDifficulty.Heroic() == game_difficulty_get_real())
            {
                object_create_anew(intro_fire);
                await sleep(150);
                object_destroy(intro_fire.Entity);
            }

            if (GameDifficulty.Legendary() == game_difficulty_get_real())
            {
                object_create_anew(chief_toy);
                object_create_anew(grunt_toy);
                objects_attach(grunt_01.Entity, "right_hand", grunt_toy.Entity, "");
                objects_attach(grunt_01.Entity, "left_hand", chief_toy.Entity, "");
                await sleep(150);
                object_destroy(chief_toy.Entity);
                object_destroy(grunt_toy.Entity);
            }
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task c05_intro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_02_fol", 3838378835U), default(IGameObject), 1F);
            print("c05_intro foley 02 start");
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task effect_retros_02()
        {
            await sleep(1);
            print("effect - retro-rockets");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_01.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_02.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_03.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_04.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_05.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_06.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_07.Entity, "retro_rocket");
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task effect_retros_03()
        {
            await sleep(310);
            print("effect - retro-rockets");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_01.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_02.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_03.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_04.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_05.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_06.Entity, "retro_rocket");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3837723465U), hev_close_07.Entity, "retro_rocket");
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task c05_intro_dof_02()
        {
            time_code_reset();
            await sleep(218);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 1F, 1F, 0F, 0F, 0F, 0F);
            print("rack focus");
            time_code_reset();
            await sleep(88);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c05_intro_cinematic_light_02()
        {
            cinematic_lighting_set_primary_light(43F, 284F, 0.45F, 0.39F, 0.27F);
            cinematic_lighting_set_secondary_light(1F, 112F, 0.25F, 0.26F, 0.73F);
            cinematic_lighting_set_ambient_light(0.11F, 0.12F, 0.07F);
            object_uses_cinematic_lighting(hev_close_01.Entity, true);
            object_uses_cinematic_lighting(hev_close_02.Entity, true);
            object_uses_cinematic_lighting(hev_close_03.Entity, true);
            object_uses_cinematic_lighting(hev_close_04.Entity, true);
            object_uses_cinematic_lighting(hev_close_05.Entity, true);
            object_uses_cinematic_lighting(hev_close_06.Entity, true);
            object_uses_cinematic_lighting(hev_close_07.Entity, true);
            object_uses_cinematic_lighting(hev_close_08.Entity, true);
            object_uses_cinematic_lighting(grunt_01.Entity, true);
            object_uses_cinematic_lighting(jackal_01.Entity, true);
            object_uses_cinematic_lighting(intro_turret.Entity, true);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task jackal_shield_activate()
        {
            await sleep(278);
            print("jackal shield activate");
            object_create_anew(jackal_shield);
            objects_attach(jackal_01.Entity, "shield_light", jackal_shield.Entity, "");
            object_set_function_variable(jackal_01.Entity, "shield", 1F, 1F);
        }

        [ScriptMethod(149, Lifecycle.Static)]
        public async Task c05_intro_02_setup()
        {
            object_create_anew(hev_close_01);
            object_create_anew(hev_close_02);
            object_create_anew(hev_close_03);
            object_create_anew(hev_close_04);
            object_create_anew(hev_close_05);
            object_create_anew(hev_close_06);
            object_create_anew(hev_close_07);
            object_create_anew(hev_close_08);
            object_create_anew(grunt_01);
            object_create_anew(jackal_01);
            object_create_anew(intro_turret);
            object_cinematic_lod(hev_close_01.Entity, true);
            object_cinematic_lod(hev_close_02.Entity, true);
            object_cinematic_lod(hev_close_03.Entity, true);
            object_cinematic_lod(hev_close_04.Entity, true);
            object_cinematic_lod(hev_close_05.Entity, true);
            object_cinematic_lod(hev_close_06.Entity, true);
            object_cinematic_lod(hev_close_07.Entity, true);
            object_cinematic_lod(hev_close_08.Entity, true);
            object_cinematic_lod(grunt_01.Entity, true);
            object_cinematic_lod(jackal_01.Entity, true);
            object_cinematic_lod(intro_turret.Entity, true);
            object_set_function_variable(jackal_01.Entity, "shield", 0F, 0F);
            wake(new ScriptMethodReference(c05_intro_foley_02));
            wake(new ScriptMethodReference(effect_retros_02));
            wake(new ScriptMethodReference(effect_retros_03));
            wake(new ScriptMethodReference(c05_intro_dof_02));
            wake(new ScriptMethodReference(c05_intro_cinematic_light_02));
            wake(new ScriptMethodReference(little_alien));
            wake(new ScriptMethodReference(jackal_shield_activate));
        }

        [ScriptMethod(150, Lifecycle.Static)]
        public async Task c05_intro_scene_02()
        {
            cinematic_lightmap_shadow_enable();
            await this._05_intro_02_predict_stub();
            await sleep(this.prediction_offset);
            await this.c05_intro_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intro\\05_intro", 3837920076U), "05_intro_02", default(IUnit), anchor_flag_intro);
            custom_animation_relative(grunt_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\05_intro\\05_intro", 3838444372U), "grunt_02", false, anchor_intro.Entity);
            custom_animation_relative(jackal_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\05_intro\\05_intro", 3838509909U), "jackal_02", false, anchor_intro.Entity);
            custom_animation_relative(intro_turret.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\c_turret_ap\\05_intro\\05_intro", 3838575446U), "turret_02", false, anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev01_02", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev02_02", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev03_02", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev04_02", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_05.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev05_02", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_06.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev06_02", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_07.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev07_02", anchor_intro.Entity);
            await sleep(5);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._05_intro_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_03_fol", 3838640983U));
            await sleep((short)camera_time());
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task c05_intro_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_03_fol", 3838640983U), default(IGameObject), 1F);
            print("c05_intro foley 03 start");
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task c05_1020_cor()
        {
            await sleep(439);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_1020_cor", 3838706520U), default(IGameObject), 1F);
            cinematic_subtitle("c05_1020_cor", 2.5F);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task c05_1030_cor()
        {
            await sleep(552);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_1030_cor", 3838772057U), default(IGameObject), 1F);
            cinematic_subtitle("c05_1030_cor", 1F);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task effect_dust()
        {
            time_code_reset();
            await sleep(286);
            effect_new(GetTag<EffectTag>("effects\\cinematics\\05\\hev_land", 3838837594U), c05_intro_pod_01);
            print("first pod");
            await sleep(42);
            effect_new(GetTag<EffectTag>("effects\\cinematics\\05\\hev_land", 3838837594U), c05_intro_pod_03);
            print("second pod");
            await sleep(29);
            effect_new(GetTag<EffectTag>("effects\\cinematics\\05\\hev_land", 3838837594U), c05_intro_pod_02);
            print("third pod");
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task effect_hev_door_release()
        {
            await sleep(390);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\hev_door_release", 3838968668U), hev_close_06.Entity, "door_release");
            print("effect - blow pins");
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task intro_turret_fire()
        {
            object_create(turret_handheld);
            objects_attach(intro_turret.Entity, "primary_trigger", turret_handheld.Entity, "");
            object_hide(turret_handheld.Entity, true);
            await sleep(131);
            print("turret fire");
            weapon_hold_trigger(GetReference<IWeaponReference>("turret_handheld"), 0, true);
            await sleep(150);
            weapon_hold_trigger(GetReference<IWeaponReference>("turret_handheld"), 0, false);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task intro_turret_fire_02()
        {
            object_create(turret_handheld_02);
            objects_attach(intro_turret_02.Entity, "primary_trigger", turret_handheld_02.Entity, "");
            object_hide(turret_handheld_02.Entity, true);
            await sleep(193);
            print("turret_02 fire");
            weapon_hold_trigger(GetReference<IWeaponReference>("turret_handheld_02"), 0, true);
            await sleep(160);
            weapon_hold_trigger(GetReference<IWeaponReference>("turret_handheld_02"), 0, false);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task _05_intro_fov_03_1()
        {
            await sleep(161);
            print("fov switch");
            camera_set_field_of_view(70F, 0);
            print("fov change: 60 -> 70 over 0 ticks");
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task _05_intro_fov_03_2()
        {
            await sleep(280);
            print("fov switch");
            camera_set_field_of_view(60F, 0);
            print("fov change: 70 -> 60 over 0 ticks");
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task c05_intro_cinematic_light_03()
        {
            object_uses_cinematic_lighting(chief_intro.Entity, true);
            object_uses_cinematic_lighting(smg_01.Entity, true);
            object_uses_cinematic_lighting(rocket_01.Entity, true);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task late_pods()
        {
            await sleep(280);
            scenery_animation_start_relative(hev_close_06.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev06_03", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_07.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev07_03", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_08.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev08_03", anchor_intro.Entity);
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task c05_intro_03_setup()
        {
            object_create_anew(chief_intro);
            object_create_anew(rocket_01);
            object_create_anew(smg_01);
            object_create_anew(intro_turret_02);
            object_cinematic_lod(chief_intro.Entity, true);
            object_cinematic_lod(rocket_01.Entity, true);
            object_cinematic_lod(smg_01.Entity, true);
            object_cinematic_lod(intro_turret_02.Entity, true);
            object_destroy(intro_crate_01.Entity);
            object_destroy(intro_crate_02.Entity);
            wake(new ScriptMethodReference(c05_1020_cor));
            wake(new ScriptMethodReference(c05_1030_cor));
            wake(new ScriptMethodReference(c05_intro_foley_03));
            wake(new ScriptMethodReference(late_pods));
            wake(new ScriptMethodReference(effect_dust));
            wake(new ScriptMethodReference(effect_hev_door_release));
            wake(new ScriptMethodReference(intro_turret_fire));
            wake(new ScriptMethodReference(intro_turret_fire_02));
            wake(new ScriptMethodReference(_05_intro_fov_03_1));
            wake(new ScriptMethodReference(_05_intro_fov_03_2));
            wake(new ScriptMethodReference(c05_intro_cinematic_light_03));
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task c05_intro_03_cleanup()
        {
            object_destroy(chief_intro.Entity);
            object_destroy(grunt_01.Entity);
            object_destroy(jackal_01.Entity);
            object_destroy_containing("turret");
            object_destroy(rocket_01.Entity);
            object_destroy(smg_01.Entity);
            object_destroy_containing("hev_close");
            object_create_anew(intro_crate_01);
            object_create_anew(intro_crate_02);
        }

        [ScriptMethod(164, Lifecycle.Static)]
        public async Task c05_intro_scene_03()
        {
            await this.c05_intro_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intro\\05_intro", 3837920076U), "05_intro_03", default(IUnit), anchor_flag_intro);
            custom_animation_relative(grunt_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\grunt\\05_intro\\05_intro", 3838444372U), "grunt_03", false, anchor_intro.Entity);
            custom_animation_relative(jackal_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\jackal\\05_intro\\05_intro", 3838509909U), "jackal_03", false, anchor_intro.Entity);
            custom_animation_relative(intro_turret.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\c_turret_ap\\05_intro\\05_intro", 3838575446U), "turret_03", false, anchor_intro.Entity);
            custom_animation_relative(intro_turret_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\c_turret_ap\\05_intro\\05_intro", 3838575446U), "turret02_03", false, anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev01_03", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev02_03", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev03_03", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev04_03", anchor_intro.Entity);
            scenery_animation_start_relative(hev_close_05.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3838051150U), "hev05_03", anchor_intro.Entity);
            scenery_animation_start_relative(smg_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\05_intro\\05_intro", 3839034205U), "smg_03", anchor_intro.Entity);
            await sleep(400);
            custom_animation_relative(chief_intro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intro\\05_intro", 3837985613U), "chief_03", false, anchor_intro.Entity);
            scenery_animation_start_relative(rocket_01.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\support_high\\rocket_launcher\\05_intro\\05_intro", 3839099742U), "rocket_03", anchor_intro.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c05_intro_03_cleanup();
            await sleep(30);
            cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(165, Lifecycle.Static)]
        public async Task c05_intro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("bsp_x05"));
            await sleep(1);
            await this.c05_intro_scene_01();
            switch_bsp_by_name(GetReference<IBsp>("bsp_00"));
            await sleep(1);
            await this.c05_intro_scene_02();
            await this.c05_intro_scene_03();
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task long_pause()
        {
            cs_abort_on_alert(true);
            sleep_forever();
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task forever_pause()
        {
            cs_pause(-1F);
        }

        [ScriptMethod(168, Lifecycle.CommandScript)]
        public async Task abort()
        {
            cs_pause(0.1F);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task _05a_title0()
        {
            await this.cinematic_fade_from_white_bars();
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
            game_save();
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task _05a_title1()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task _05a_title2()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_3);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task objective_lz_set()
        {
            await sleep(30);
            print("new objective set:");
            print("clear the landing zone for the pelicans.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task objective_lz_clear()
        {
            print("objective complete:");
            print("clear the landing zone for the pelicans.");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task objective_bridge_set()
        {
            await sleep(30);
            print("new objective set:");
            print("extend the bridge, and cross the chasm.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task objective_bridge_clear()
        {
            print("objective complete:");
            print("extend the bridge, and cross the chasm.");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task objective_ruins_set()
        {
            await sleep(30);
            print("new objective set:");
            print("push through the covenant-held ruins.");
            objectives_show_up_to(2);
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task objective_ruins_clear()
        {
            print("objective complete:");
            print("push through the covenant-held ruins.");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task objective_tower1_set()
        {
            await sleep(30);
            print("new objective set:");
            print("reach the towers in the lake.");
            objectives_show_up_to(3);
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task objective_tower1_clear()
        {
            print("objective complete:");
            print("reach the towers in the lake.");
            objectives_finish_up_to(3);
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task music_05a_01_start()
        {
            print("music 05a_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_01", 2154569270U), default(IGameObject), 1F);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task music_05a_02_start()
        {
            print("music 05a_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_02", 2154700344U), default(IGameObject), 1F);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task music_05a_02_stop()
        {
            print("music 05a_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_02", 2154700344U));
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task music_05a_03_start()
        {
            print("music 05a_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_03", 2154896955U), default(IGameObject), 1F);
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task music_05a_03_stop()
        {
            print("music 05a_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_03", 2154896955U));
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task music_05a_04_start()
        {
            print("music 05a_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_04", 2155093566U), default(IGameObject), 1F);
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task music_05a_04_start_alt()
        {
            print("music 05a_04 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_04", 2155093566U), true);
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task music_05a_04_stop()
        {
            print("music 05a_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_04", 2155093566U));
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task music_05a_05_start()
        {
            print("music 05a_05 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_05", 2155617862U), default(IGameObject), 1F);
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task music_05a_05_stop()
        {
            print("music 05a_05 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_05", 2155617862U));
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task music_05a_06_start()
        {
            print("music 05a_06 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_06", 2155814473U), default(IGameObject), 1F);
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)structure_bsp_index() == 0);
                kill_volume_enable(kill_bsp00_lz);
                kill_volume_enable(kill_bsp00_all);
                kill_volume_disable(kill_bsp01_all);
                kill_volume_disable(kill_approach_ramp);
                await sleep_until(async () => (short)structure_bsp_index() == 1);
                kill_volume_enable(kill_bsp01_all);
                kill_volume_enable(kill_approach_ramp);
                kill_volume_disable(kill_bsp00_lz);
                kill_volume_disable(kill_bsp00_all);
                return false;
            });
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task kill_stragglers()
        {
            await sleep_until(async () =>
            {
                if (objects_can_see_object(players(), list_get(ai_actors(all_ai), this.straggler_no), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(all_ai), this.straggler_no)) > 100F)
                {
                    object_destroy(list_get(ai_actors(all_ai), this.straggler_no));
                }

                this.straggler_no = (short)(this.straggler_no + 1);
                if (this.straggler_no > 19)
                {
                    this.straggler_no = 0;
                }

                return false;
            });
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task lights()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_lights_on_01, players()) == true || volume_test_objects(vol_lights_on_02, players()) == true || volume_test_objects(vol_lights_on_03, players()) == true || volume_test_objects(vol_lights_on_04, players()) == true || volume_test_objects(vol_lights_on_05, players()) == true || volume_test_objects(vol_lights_on_06, players()) == true);
                game_can_use_flashlights(true);
                await sleep_until(async () => volume_test_objects(vol_lights_on_01, players()) == false && volume_test_objects(vol_lights_on_02, players()) == false && volume_test_objects(vol_lights_on_03, players()) == false && volume_test_objects(vol_lights_on_04, players()) == false && volume_test_objects(vol_lights_on_05, players()) == false && volume_test_objects(vol_lights_on_06, players()) == false);
                game_can_use_flashlights(false);
                return false;
            });
        }

        [ScriptMethod(194, Lifecycle.CommandScript)]
        public async Task lz_phantom_01_crash()
        {
            cs_pause(-1F);
        }

        [ScriptMethod(195, Lifecycle.Static)]
        public async Task lz_phantom_01_blows()
        {
            cs_run_command_script(LZ_phantom_01.pilot, new ScriptMethodReference(lz_phantom_01_crash));
            begin_random(async () => effect_new_on_object_marker(this.phantom_boom, ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p"), 
                async () => await sleep((short)random_range(10, 60)), 
                async () => print("."), 
                async () => effect_new_on_object_marker(this.phantom_boom, ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "right_gun"), 
                async () => await sleep((short)random_range(10, 60)), 
                async () => print("."), 
                async () => effect_new_on_object_marker(this.phantom_boom, ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "left_gun"), 
                async () => await sleep((short)random_range(10, 60)), 
                async () => print("."), 
                async () => effect_new_on_object_marker(this.phantom_boom, ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "chin_gun"), 
                async () => await sleep((short)random_range(10, 60)), 
                async () => print("."), 
                async () => effect_new_on_object_marker(this.phantom_boom, ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "target_engine_left"), 
                async () => await sleep((short)random_range(10, 60)), 
                async () => print("."), 
                async () => effect_new_on_object_marker(this.phantom_boom, ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "target_engine_right"), 
                async () => await sleep((short)random_range(10, 60)), 
                async () => print("."));
        }

        [ScriptMethod(196, Lifecycle.CommandScript)]
        public async Task stay_shooting()
        {
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(197, Lifecycle.Static)]
        public async Task prep_return_from_intro()
        {
            if (await this.difficulty_legendary())
            {
                this.lz_turret_count = 4;
            }

            if (await this.difficulty_heroic())
            {
                this.lz_turret_count = 3;
            }

            if (await this.difficulty_normal())
            {
                this.lz_turret_count = 2;
            }

            ai_place(LZ_turrets_01.Squad);
            ai_set_blind(LZ_turrets_01.Squad, true);
            cs_run_command_script(LZ_turrets_01.Squad, new ScriptMethodReference(stay_shooting));
            this.lz_turret_count = (short)(this.lz_turret_count - 1);
            begin_random(async () =>
            {
                if (this.lz_turret_count > 0)
                {
                    ai_place(LZ_turrets_02.Squad);
                    ai_set_blind(LZ_turrets_02.Squad, true);
                    cs_run_command_script(LZ_turrets_02.Squad, new ScriptMethodReference(stay_shooting));
                    this.lz_turret_count = (short)(this.lz_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.lz_turret_count > 0)
                {
                    ai_place(LZ_turrets_03.Squad);
                    ai_set_blind(LZ_turrets_03.Squad, true);
                    cs_run_command_script(LZ_turrets_03.Squad, new ScriptMethodReference(stay_shooting));
                    this.lz_turret_count = (short)(this.lz_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.lz_turret_count > 0)
                {
                    ai_place(LZ_turrets_04.Squad);
                    ai_set_blind(LZ_turrets_04.Squad, true);
                    cs_run_command_script(LZ_turrets_04.Squad, new ScriptMethodReference(stay_shooting));
                    this.lz_turret_count = (short)(this.lz_turret_count - 1);
                }
            });
            if (await this.difficulty_legendary())
            {
                ai_place(allies_lz_ledge.Squad, 2);
                ai_place(LZ_jackals_ridge.Squad, 1);
            }

            if (await this.difficulty_heroic())
            {
                ai_place(allies_lz_ledge.Squad, 2);
                ai_place(allies_lz_ridge.Squad, 1);
                ai_place(LZ_jackals_ridge.Squad, 1);
            }

            if (await this.difficulty_normal())
            {
                ai_place(allies_lz_ledge.Squad, 2);
                ai_place(allies_lz_ridge.Squad, 1);
                ai_place(LZ_jackals_ridge.Squad, 1);
            }

            object_teleport(await this.player0(), lz_start_player0);
            object_teleport(await this.player1(), lz_start_player1);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task lz_pelican_wait()
        {
            await sleep_until(async () => volume_test_objects(vol_lz_all, players()) == false && await this.player_count() > 0);
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == false)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'let's wait for our warthog. unless you really want to walk...'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0370"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(199, Lifecycle.CommandScript)]
        public async Task drive_to_overlook_01()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("overlook/p2"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p3"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p6"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p7"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p4"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p5"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p1"));
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task drive_to_overlook_02()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("overlook/p2"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p3"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p6"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p7"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p4"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p5"));
            cs_go_to(GetReference<ISpatialPoint>("overlook/p0"));
        }

        [ScriptMethod(201, Lifecycle.CommandScript)]
        public async Task lz_pelican_sighted()
        {
            this.ride_ally_comment_go = true;
            cs_switch("lz_odst");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("odst: 'here comes our ride!'");
            cs_play_line("0380");
        }

        [ScriptMethod(202, Lifecycle.CommandScript)]
        public async Task lz_saddle_up()
        {
            cs_switch("lz_ally");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("ally: 'saddle-up!  we're moving out!'");
            cs_play_line("0050");
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task lz_pelican_timer()
        {
            await sleep(8000);
            object_destroy(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot));
            object_destroy(ai_vehicle_get_from_starting_location(LZ_pelican_02.pilot));
        }

        [ScriptMethod(204, Lifecycle.CommandScript)]
        public async Task lz_pelican_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_a_09"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_a_08"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_a_07"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_a_06"), 20F);
            this.lz_pelican_in_sight = true;
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("lz_pelicans/pel_a_04"), 5F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("lz_pelicans/pel_a_04"), GetReference<ISpatialPoint>("lz_pelicans/p0"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("lz_pelicans/pel_a_05"), 1F);
            ai_set_orders(LZ_allies, allies_lz_hogs);
            await sleep_until(async () => volume_test_objects(vol_lz_warthog, players()) == false && volume_test_objects(vol_lz_warthog, ai_actors(all_allies)) == false && await this.player_count() > 0);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_lc");
            await sleep(45);
            wake(new ScriptMethodReference(music_05a_02_start));
            wake(new ScriptMethodReference(lz_pelican_timer));
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_p");
            await sleep_until(async () => (short)ai_living_count(LZ_pelican_01.Squad) < 4);
            this.lz_pelican_arrived = true;
            cs_fly_to(GetReference<ISpatialPoint>("lz_pelicans/pel_a_04"), 1F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_a_06"), 3F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_a_07"), 20F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_a_09"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("lz_pelicans/pel_a_10"), 20F);
            ai_erase(LZ_pelican_01.Squad);
        }

        [ScriptMethod(205, Lifecycle.CommandScript)]
        public async Task other_lz_pelican()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_07"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_06"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_05"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_04"), 10F);
            cs_vehicle_speed(0.5F);
            cs_face(true, GetReference<ISpatialPoint>("lz_pelicans/pel_a_05"));
            await sleep_until(async () =>
            {
                if (this.lz_pelican_arrived == false)
                {
                    cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_02"), 3F);
                }

                if (this.lz_pelican_arrived == false)
                {
                    cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_03"), 3F);
                }

                return this.lz_pelican_arrived == true;
            });
            cs_face(false, GetReference<ISpatialPoint>("lz_pelicans/pel_a_05"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_05"), 20F);
            cs_vehicle_speed(1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("lz_pelicans/pel_b_07"), 40F);
            cs_fly_to(GetReference<ISpatialPoint>("lz_pelicans/pel_b_08"), 30F);
            ai_erase(LZ_pelican_02.Squad);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task lz_pelican()
        {
            ai_place(LZ_pelican_02.Squad);
            cs_run_command_script(LZ_pelican_02.pilot, new ScriptMethodReference(other_lz_pelican));
            await sleep(120);
            ai_place(allies_lz_pelican.Squad, (short)(2 - (float)ai_living_count(all_allies)));
            ai_place(LZ_pelican_01.Squad);
            ai_place(LZ_warthog_01.Squad);
            object_cannot_take_damage(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_p", ai_actors(allies_lz_pelican.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_lc", ai_vehicle_get_from_starting_location(LZ_warthog_01.driver));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), true);
            cs_run_command_script(LZ_pelican_01.pilot, new ScriptMethodReference(lz_pelican_arrives));
            ai_set_orders(LZ_allies, allies_lz_all);
            await sleep_until(async () => this.lz_pelican_in_sight == true);
            if (this.lz_pelican_arrived == false)
            {
                await sleep_until(async () => ai_scene("lz_pelican_sighted_scene", new ScriptMethodReference(lz_pelican_sighted), LZ_allies) || (short)ai_living_count(allies_lz_ledge.Squad) < 1 && (short)ai_living_count(allies_lz_ridge.Squad) < 1, 30, 150);
                await sleep(150);
                if (this.ride_ally_comment_go == false)
                {
                    ai_dialogue_enable(false);
                    await sleep(60);
                    print("cortana: 'here comes our ride!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "2020"));
                    await sleep(30);
                    ai_dialogue_enable(true);
                }
            }

            await sleep(240);
            ai_dialogue_enable(false);
            await sleep(60);
            print("johnson: 'i got a good view coming in.'");
            print("'there's a big building in the middle of this island's lake.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0020"));
            await sleep(30);
            print("cortana: 'i saw it too.  it looked like a temple.");
            await sleep(ai_play_line_on_object(default(IGameObject), "0030"));
            await sleep(15);
            print("if i were a megalomaniac - and i'm not - that's where i'd be.");
            await sleep(ai_play_line_on_object(default(IGameObject), "0040"));
            await sleep(30);
            ai_dialogue_enable(true);
            await sleep_until(async () => this.lz_pelican_arrived == true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            ai_set_orders(LZ_allies, allies_lz_hogs);
            ai_scene("lz_saddle_up_scene", new ScriptMethodReference(lz_saddle_up), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await sleep_until(async () => volume_test_objects(vol_lz_all, players()) == false && await this.player_count() > 0 || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) || (bool)game_is_cooperative() == false);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), false);
            game_save();
            ai_enter_squad_vehicles(all_allies);
            this.lz_mounted_up = true;
        }

        [ScriptMethod(207, Lifecycle.Static)]
        public async Task short_lz_pel()
        {
            ai_place(LZ_pelican_02.Squad);
            cs_run_command_script(LZ_pelican_02.pilot, new ScriptMethodReference(other_lz_pelican));
            await sleep(120);
            ai_place(allies_lz_pelican.Squad, (short)(4 - (float)ai_living_count(all_allies)));
            ai_place(LZ_pelican_01.Squad);
            ai_place(LZ_warthog_01.Squad);
            object_cannot_take_damage(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_p", ai_actors(allies_lz_pelican.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_lc", ai_vehicle_get_from_starting_location(LZ_warthog_01.driver));
            cs_run_command_script(LZ_pelican_01.pilot, new ScriptMethodReference(lz_pelican_arrives));
            await sleep_until(async () => (short)ai_living_count(LZ_enemies_all) > 1);
            ai_set_orders(LZ_allies, allies_lz_all);
            await sleep_until(async () => this.lz_pelican_in_sight == true);
            if (this.lz_pelican_arrived == false)
            {
                await sleep_until(async () => ai_scene("lz_pelican_sighted_scene", new ScriptMethodReference(lz_pelican_sighted), LZ_allies) || (short)ai_living_count(allies_lz_ledge.Squad) < 1 && (short)ai_living_count(allies_lz_ridge.Squad) < 1, 30, 150);
                await sleep(150);
                if (this.ride_ally_comment_go == false)
                {
                    ai_dialogue_enable(false);
                    await sleep(60);
                    print("cortana: 'here comes our ride!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "2020"));
                    await sleep(30);
                    ai_dialogue_enable(true);
                }
            }

            await sleep(240);
            ai_dialogue_enable(false);
            await sleep(60);
            print("johnson: 'i got a good view coming in.'");
            print("'there's a big building in the middle of this island's lake.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0020"));
            await sleep(30);
            print("cortana: 'i saw it too.  it looked like a temple.");
            await sleep(ai_play_line_on_object(default(IGameObject), "0030"));
            await sleep(15);
            print("if i were a megalomaniac - and i'm not - that's where i'd be.");
            await sleep(ai_play_line_on_object(default(IGameObject), "0040"));
            await sleep(30);
            ai_dialogue_enable(true);
            await sleep_until(async () => this.lz_pelican_arrived == true);
            ai_set_orders(LZ_allies, allies_lz_hogs);
            ai_scene("lz_saddle_up_scene", new ScriptMethodReference(lz_saddle_up), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            ai_enter_squad_vehicles(all_allies);
            await sleep_until(async () => (short)ai_living_count(LZ_warthog_01.Squad) > 1);
            ai_set_orders(LZ_warthog_01.Squad, allies_overlook_pause);
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task lz_turret_reminder()
        {
            await sleep_until(async () => (short)ai_living_count(LZ_enemies_turrets) < 1, 30, 8000);
            if ((short)ai_living_count(LZ_enemies_turrets) > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'those turrets will tear the pelicans to shreds! take them out!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0310"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => (short)ai_living_count(LZ_enemies_turrets) < 1, 30, 8000);
            if ((short)ai_living_count(LZ_enemies_turrets) > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'take out those turrets, chief!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2010"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(209, Lifecycle.CommandScript)]
        public async Task odst_warning()
        {
            cs_switch("lz_odst");
            cs_start_approach_player(2F, 10F, 10F);
            cs_abort_on_damage(true);
            print("odst: 'sir! we gotta neutralize those turrets!'");
            cs_play_line("0300");
        }

        [ScriptMethod(210, Lifecycle.CommandScript)]
        public async Task odst_turrets_down()
        {
            cs_switch("lz_odst");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("odst: 'clear this lz! the pelicans are right behind us!'");
            cs_play_line("0010");
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task lz_turret_track()
        {
            await sleep_until(async () => (short)ai_living_count(LZ_enemies_turrets) < 1);
            print("all turrets down");
            this.turrets_down = true;
            await sleep_until(async () => ai_scene("lz_turrets_down_scene", new ScriptMethodReference(odst_turrets_down), all_allies) || (short)ai_living_count(all_allies) < 1, 30, 600);
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task lz_phantom_01_drop()
        {
            object_set_phantom_power(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a03");
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_b01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_b02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_b03");
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c03");
            ai_set_orders(LZ_elites_phantom_01.Squad, lz_enemies_phantom_01);
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), false);
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task lz_phantom_arrives_01()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            cs_vehicle_speed(0.3F);
            cs_fly_to(GetReference<ISpatialPoint>("lz_airspace/pel6"), 2F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("lz_airspace/pel6"), GetReference<ISpatialPoint>("lz_airspace/p0"), 1F);
            wake(new ScriptMethodReference(lz_phantom_01_drop));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("lz_airspace/ph3a"), GetReference<ISpatialPoint>("lz_airspace/p0"), 1F);
            await sleep_until(async () => (short)ai_living_count(LZ_phantom_01.Squad) < 2, 30, 900);
            this.lz_phantom_01_leaving = true;
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            cs_fly_to(GetReference<ISpatialPoint>("lz_airspace/phxa"));
            ai_erase(LZ_phantom_01.Squad);
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task lz_phantom_02_drop()
        {
            object_set_phantom_power(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), true);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_a01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_a02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_a03");
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_b01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_b02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_b03");
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c03");
            ai_set_orders(LZ_elites_phantom_02.Squad, lz_enemies_phantom_02);
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), false);
        }

        [ScriptMethod(215, Lifecycle.CommandScript)]
        public async Task lz_phantom_arrives_02()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph0b"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph1b"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph2b"));
            cs_vehicle_speed(0.3F);
            cs_fly_to(GetReference<ISpatialPoint>("lz_airspace/pel6"), 2F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("lz_airspace/pel6"), GetReference<ISpatialPoint>("lz_airspace/p1"), 1F);
            wake(new ScriptMethodReference(lz_phantom_02_drop));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("lz_airspace/ph3b"), GetReference<ISpatialPoint>("lz_airspace/p1"), 2F);
            await sleep_until(async () => (short)ai_living_count(LZ_phantom_02.Squad) < 2, 30, 900);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph2b"));
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph1b"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph0b"));
            cs_fly_to(GetReference<ISpatialPoint>("lz_airspace/phxb"));
            ai_erase(LZ_phantom_02.Squad);
            this.lz_phantom_02_leaving = true;
        }

        [ScriptMethod(216, Lifecycle.CommandScript)]
        public async Task lz_phantom_arrives_03()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            cs_vehicle_speed(0.3F);
            cs_fly_to(GetReference<ISpatialPoint>("lz_airspace/ph3a"), 2F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("lz_airspace/ph3a"), GetReference<ISpatialPoint>("lz_airspace/p0"), 1F);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a03");
            await sleep_until(async () => (short)ai_living_count(LZ_phantom_01.Squad) < 2, 30, 900);
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), false);
            ai_set_active_camo(LZ_stealth_phantom_03.Squad, true);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            cs_fly_by(GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            cs_fly_to(GetReference<ISpatialPoint>("lz_airspace/phxa"));
            ai_erase(LZ_phantom_01.Squad);
            this.lz_phantom_03_leaving = true;
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task lz_phantom_01_start()
        {
            ai_place(LZ_phantom_01.Squad);
            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_elites_phantom_01.Squad, 2);
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_jackals_phantom_01.Squad, (short)random_range(2, 4));
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_grunts_phantom_01.Squad, (short)(6 - (float)ai_living_count(LZ_jackals_phantom_01.Squad)));
            }

            await sleep(15);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c", ai_actors(LZ_elites_phantom_01.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p", ai_actors(LZ_grunts_phantom_01.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p", ai_actors(LZ_jackals_phantom_01.Squad));
            await sleep(15);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            cs_run_command_script(LZ_phantom_01.pilot, new ScriptMethodReference(lz_phantom_arrives_01));
            await sleep(210);
            print("saving");
            game_save();
            await sleep_until(async () => (short)ai_living_count(LZ_phantom_01.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot));
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task lz_phantom_02_start()
        {
            ai_place(LZ_phantom_02.Squad);
            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_elites_phantom_02.Squad, 2);
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_jackals_phantom_02.Squad, (short)random_range(2, 4));
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_grunts_phantom_02.Squad, (short)(6 - (float)ai_living_count(LZ_jackals_phantom_02.Squad)));
            }

            await sleep(15);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c", ai_actors(LZ_elites_phantom_02.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", ai_actors(LZ_jackals_phantom_02.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", ai_actors(LZ_grunts_phantom_02.Squad));
            await sleep(15);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), true);
            cs_run_command_script(LZ_phantom_02.pilot, new ScriptMethodReference(lz_phantom_arrives_02));
            await sleep(150);
            print("saving");
            game_save();
            await sleep_until(async () => (short)ai_living_count(LZ_phantom_02.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot));
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task lz_phantom_03_start()
        {
            ai_place(LZ_phantom_01.Squad);
            ai_place(LZ_stealth_phantom_03.Squad, 3);
            await sleep(15);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a01", ai_actors(LZ_stealth_phantom_03._1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a02", ai_actors(LZ_stealth_phantom_03._2));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a03", ai_actors(LZ_stealth_phantom_03._3));
            await sleep(15);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            cs_run_command_script(LZ_phantom_01.pilot, new ScriptMethodReference(lz_phantom_arrives_03));
            await sleep(210);
            print("saving");
            game_save();
            await sleep_until(async () => (short)ai_living_count(LZ_phantom_01.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot));
        }

        [ScriptMethod(220, Lifecycle.Static)]
        public async Task short_lz_ph_02()
        {
            ai_allegiance(prophet, covenant);
            ai_place(LZ_phantom_02.Squad);
            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_elites_phantom_02.Squad, 2);
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_jackals_phantom_02.Squad, (short)random_range(2, 4));
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_grunts_phantom_02.Squad, (short)(7 - (float)ai_living_count(LZ_jackals_phantom_02.Squad)));
            }

            await sleep(15);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c", ai_actors(LZ_elites_phantom_02.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", ai_actors(LZ_jackals_phantom_02.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", ai_actors(LZ_grunts_phantom_02.Squad));
            await sleep(15);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), true);
            cs_run_command_script(LZ_phantom_02.pilot, new ScriptMethodReference(lz_phantom_arrives_02));
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task lz_start()
        {
            data_mine_set_mission_segment("05a_1_landing_zone");
            game_save();
            wake(new ScriptMethodReference(lz_turret_track));
            wake(new ScriptMethodReference(lz_turret_reminder));
            await sleep(5);
            ai_scene("lz_intro_inform_scene", new ScriptMethodReference(odst_warning), allies_lz_ledge.Squad) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await sleep(120);
            ai_place(LZ_grunts_ledge.Squad, 3);
            ai_set_blind(LZ_turrets_01.Squad, false);
            ai_set_blind(LZ_turrets_02.Squad, false);
            ai_set_blind(LZ_turrets_03.Squad, false);
            ai_set_blind(LZ_turrets_04.Squad, false);
            await sleep_until(async () => volume_test_objects(vol_entry_ledge, players()) == false && await this.player_count() > 0 || (short)ai_living_count(LZ_enemies_all) < 3);
            game_save();
            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_jackals_ridge.Squad, (short)(2 - (float)ai_living_count(LZ_jackals_ridge.Squad)));
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_grunts_ridge.Squad, (short)(3 - (float)ai_living_count(LZ_grunts_ledge.Squad)));
            }

            await sleep_until(async () => volume_test_objects(vol_lz_leaving_ridge, players()) == true || (short)ai_living_count(LZ_enemies_all) < 1);
            ai_place(LZ_jackals_structure.Squad, 1);
            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_elites_yard.Squad, 2);
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_jackals_yard.Squad, (short)(2 - (float)ai_living_count(LZ_jackals_ridge.Squad)));
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_grunts_yard.Squad, (short)(3 - (float)ai_living_count(LZ_grunts_ledge.Squad) + (float)ai_living_count(LZ_grunts_ridge.Squad)));
            }

            game_save();
            await sleep(30);
            wake(new ScriptMethodReference(music_05a_01_start));
            await sleep_until(async () => volume_test_objects(vol_lz_in_yard_01, players()) == true || (short)ai_living_count(LZ_enemies_all) < 3);
            game_save();
            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_elites_structure.Squad, (short)(2 - (float)ai_living_count(LZ_elites_yard.Squad)));
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_grunts_structure.Squad, (short)(5 - (float)ai_living_count(LZ_enemies_yard)));
            }

            await sleep_until(async () => volume_test_objects(vol_lz_in_yard_02, players()) == true || (short)ai_living_count(LZ_enemies_all) < 3);
            game_save();
            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_elites_bunkered.Squad, (short)(2 - (float)ai_living_count(LZ_elites_yard.Squad) + (float)ai_living_count(LZ_elites_structure.Squad)));
            }

            if ((short)ai_living_count(LZ_enemies_all) < 11)
            {
                ai_place(LZ_grunts_bunkered.Squad, (short)(5 - (float)ai_living_count(LZ_enemies_structure)));
            }

            await sleep_until(async () => this.turrets_down == true && (short)ai_living_count(LZ_enemies_all) < 1, 30, 1800);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", LZ_enemies_all) == true);
            await sleep(90);
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'artillery disabled, sergeant! landing zone secure�for the moment.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0320"));
            await sleep(30);
            print("johnson: 'i hear ya. starting our approach. hang tight.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0330"));
            await sleep(60);
            print("cortana: 'easier said than done�inbound phantoms, chief!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0340"));
            await sleep(30);
            ai_dialogue_enable(true);
            await this.lz_phantom_01_start();
            await sleep_until(async () => (short)ai_living_count(LZ_enemies_all) < 1, 30, 8000);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", LZ_enemies_all) == true);
            if (await this.difficulty_legendary())
            {
                await sleep(60);
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'another phantom! on approach!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0350"));
                await sleep(30);
                ai_dialogue_enable(true);
                await this.lz_phantom_02_start();
                await sleep_until(async () => (short)ai_living_count(LZ_enemies_all) < 1, 30, 8000);
                await sleep_until(async () => (bool)ai_trigger_test("done_fighting", LZ_enemies_all) == true);
                await this.lz_phantom_03_start();
                await sleep_until(async () => (short)ai_living_count(LZ_enemies_all) < 1, 30, 4000);
                await sleep_until(async () => (bool)ai_trigger_test("done_fighting", LZ_enemies_all) == true);
                wake(new ScriptMethodReference(lz_pelican));
                wake(new ScriptMethodReference(objective_lz_clear));
            }
            else
            {
                await sleep(60);
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'another phantom! on approach!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0350"));
                await sleep(30);
                ai_dialogue_enable(true);
                await this.lz_phantom_02_start();
                await sleep_until(async () => (short)ai_living_count(LZ_enemies_all) < 1, 30, 8000);
                await sleep_until(async () => (bool)ai_trigger_test("done_fighting", LZ_enemies_all) == true);
                wake(new ScriptMethodReference(lz_pelican));
                wake(new ScriptMethodReference(objective_lz_clear));
            }

            await sleep(90);
            if (this.lz_pelican_in_sight == false)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'hold here until the pelican arrives, chief.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0360"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            game_save();
            wake(new ScriptMethodReference(lz_pelican_wait));
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task overlook_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_bridge_all, players()) == true, 30, 5400);
            if (volume_test_objects(vol_bridge_all, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'let's get moving before we're spotted, alright?'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0430"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(223, Lifecycle.CommandScript)]
        public async Task overlook_remark()
        {
            cs_switch("overlook_ally");
            cs_abort_on_damage(true);
            print("ally: 'whoa�'");
            cs_play_line("0390");
            await sleep(30);
            print("ally: 'it's like a postcard.'");
            cs_play_line("0400");
            await sleep(30);
            print("ally: 'dear, sarge: kicking ass in outer space. wish you were here.'");
            cs_play_line("0410");
            await sleep(30);
            print("johnson: 'i heard that, jackass.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0420"));
        }

        [ScriptMethod(224, Lifecycle.CommandScript)]
        public async Task overlook_wander1()
        {
            cs_abort_on_alert(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("overlook/jack01")), 
                    async () => cs_face(true, GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_face(false, GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("overlook/jack02")), 
                    async () => cs_face(true, GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_face(false, GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("overlook/jack06")), 
                    async () => cs_face(true, GetReference<ISpatialPoint>("overlook/jack05")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_face(false, GetReference<ISpatialPoint>("overlook/jack05")));
                return false;
            });
        }

        [ScriptMethod(225, Lifecycle.CommandScript)]
        public async Task overlook_wander2()
        {
            cs_abort_on_alert(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("overlook/jack03")), 
                    async () => cs_face(true, GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_face(false, GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("overlook/jack04")), 
                    async () => cs_face(true, GetReference<ISpatialPoint>("overlook/jack_look2")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_face(false, GetReference<ISpatialPoint>("overlook/jack_look2")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("overlook/jack05")), 
                    async () => cs_face(true, GetReference<ISpatialPoint>("overlook/jack06")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_face(false, GetReference<ISpatialPoint>("overlook/jack06")));
                return false;
            });
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task overlook_start()
        {
            ai_disposable(LZ_enemies_all, true);
            data_mine_set_mission_segment("05a_2_overlook");
            wake(new ScriptMethodReference(overlook_reminder));
            game_save();
            ai_place(overlook_jackals_011.Squad, 2);
            if (await this.difficulty_legendary())
            {
                ai_place(overlook_jackals_021.Squad, 2);
            }

            if (await this.difficulty_heroic())
            {
                ai_place(overlook_jackals_021.Squad, 1);
            }

            await sleep_until(async () => volume_test_objects(vol_overlook_pause, players()) == true);
            await sleep_until(async () => (short)ai_living_count(overlook_jackals) < 1 || volume_test_objects(vol_bridge_all, players()) == true);
            await sleep_until(async () => volume_test_objects(vol_bridge_all, players()) == true || ai_scene("overlook_remark_scene", new ScriptMethodReference(overlook_remark), all_allies) || (short)ai_living_count(all_allies) < 1, 30, 300);
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task bridge_cortana_comment()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'the covenant has control of the bridge ahead.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0440"));
            await sleep(15);
            print("'they're going to try and bottle us up on this side of the gorge!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0450"));
            await sleep(30);
            game_save();
            await sleep_until(async () => volume_test_objects(vol_bridge_near_bunker, players()) == true);
            print("cortana: 'the controls to extend the bridge should be in this structure!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0460"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(228, Lifecycle.CommandScript)]
        public async Task bridge_wraith_warn()
        {
            this.wraith_warning_go = true;
            cs_switch("bridge_ally");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("ally: 'watch out, chief!  wraiths on the far side!'");
            cs_play_line("0480");
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task bridge_wraith_warning()
        {
            await sleep(300);
            await sleep_until(async () => ai_scene("bridge_wraith_warn_scene", new ScriptMethodReference(bridge_wraith_warn), all_allies) || (short)ai_living_count(all_allies) < 1, 30, 150);
            await sleep(30);
            if (this.wraith_warning_go == false)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'watch out, chief!  wraiths on the far side!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2030"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(230, Lifecycle.CommandScript)]
        public async Task bridge_phantom_01a()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph1"), 10F);
            cs_vehicle_boost(false);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/ph2"), 1F);
            vehicle_unload(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc");
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_01.Squad) < 2);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bridge_airspace/pel5"), GetReference<ISpatialPoint>("bridge_airspace/ph1"), 2F);
            cs_vehicle_speed(1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph1"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/phx"), 20F);
            ai_erase(bridge_phantom_01.Squad);
        }

        [ScriptMethod(231, Lifecycle.CommandScript)]
        public async Task bridge_phantom_01b()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph1too"), 10F);
            cs_vehicle_boost(false);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/ph3"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/ph4"), 1F);
            vehicle_unload(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc");
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_01.Squad) < 2);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bridge_airspace/ph3"), GetReference<ISpatialPoint>("bridge_airspace/ph1"), 2F);
            cs_vehicle_speed(1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph1too"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/phx"), 20F);
            ai_erase(bridge_phantom_01.Squad);
        }

        [ScriptMethod(232, Lifecycle.CommandScript)]
        public async Task bridge_phantom_02a()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel0"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel1"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel2"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel4"), 5F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/ph2"), 1F);
            vehicle_unload(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc");
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_02.Squad) < 2);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bridge_airspace/pel5"), GetReference<ISpatialPoint>("bridge_airspace/pel4"), 2F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel4"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel3"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel1"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel0"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pelx"), 5F);
            ai_erase(bridge_phantom_02.Squad);
        }

        [ScriptMethod(233, Lifecycle.CommandScript)]
        public async Task bridge_phantom_02b()
        {
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel0"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel1"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel2"), 20F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/ph3"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/ph4"), 1F);
            vehicle_unload(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc");
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_02.Squad) < 2);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bridge_airspace/ph3"), GetReference<ISpatialPoint>("bridge_airspace/pel2"), 2F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel3"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel1"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel0"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pelx"), 5F);
            ai_erase(bridge_phantom_02.Squad);
        }

        [ScriptMethod(234, Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_01a()
        {
            ai_place(bridge_phantom_01.Squad);
            ai_place(bridge_phantom_ghosts_02.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2));
            await sleep(60);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), true);
            cs_run_command_script(bridge_phantom_01.pilot, new ScriptMethodReference(bridge_phantom_01a));
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(235, Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_01b()
        {
            ai_place(bridge_phantom_01.Squad);
            ai_place(bridge_phantom_ghosts_01.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._2));
            await sleep(60);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), true);
            cs_run_command_script(bridge_phantom_01.pilot, new ScriptMethodReference(bridge_phantom_01b));
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(236, Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_02a()
        {
            ai_place(bridge_phantom_02.Squad);
            ai_place(bridge_phantom_ghosts_02.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2));
            await sleep(60);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), true);
            cs_run_command_script(bridge_phantom_02.pilot, new ScriptMethodReference(bridge_phantom_02a));
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(237, Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_02b()
        {
            ai_place(bridge_phantom_02.Squad);
            ai_place(bridge_phantom_ghosts_02.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2));
            await sleep(60);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), true);
            cs_run_command_script(bridge_phantom_02.pilot, new ScriptMethodReference(bridge_phantom_02b));
            await sleep_until(async () => (short)ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(238, Lifecycle.CommandScript)]
        public async Task bridge_ghostman_r()
        {
            cs_abort_on_alert(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("bridge/b1")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("bridge/b2")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("bridge/b3")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("bridge/b4")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("bridge/b5")), 
                    async () => await sleep((short)random_range(30, 90)));
                return (short)ai_combat_status(this.ai_current_actor) > this.ai_combat_status_idle;
            });
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/r"));
            await sleep(5);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), false);
            await sleep(5);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r));
        }

        [ScriptMethod(239, Lifecycle.CommandScript)]
        public async Task bridge_ghostman_l()
        {
            cs_abort_on_alert(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("bridge/a1")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("bridge/a2")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("bridge/a3")), 
                    async () => await sleep((short)random_range(30, 90)), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("bridge/a4")), 
                    async () => await sleep((short)random_range(30, 90)));
                return (short)ai_combat_status(this.ai_current_actor) > this.ai_combat_status_idle;
            });
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/l"));
            await sleep(5);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), false);
            await sleep(5);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l));
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task bridge_ghosts_by_phantom()
        {
            if (await this.difficulty_heroic())
            {
                this.bridge_vehicles_total = 2;
            }

            if (await this.difficulty_legendary())
            {
                this.bridge_vehicles_total = 3;
            }

            await sleep_until(async () => (short)ai_combat_status(bridge_enemies_bunker) > this.ai_combat_status_idle);
            await sleep_until(async () => (short)ai_living_count(bridge_ghost_elites.Squad) < 1, 30, 300);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), false);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), false);
            await sleep_until(async () => (short)ai_living_count(bridge_vehicles_all) > 0, 30, 450);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(bridge_vehicles_all) < 1 || volume_test_objects(vol_bridge_ghost_spawn, players()) == true || volume_test_objects(vol_bridge_inside_bunker, players()) == true);
                if (volume_test_objects(vol_bridge_ghost_spawn, players()) == true || volume_test_objects(vol_bridge_inside_bunker, players()) == true)
                {
                    sleep_forever();
                }

                if (this.bridge_vehicles_total > 0)
                {
                    game_save();
                    ai_place(bridge_phantom_ghosts_01.Squad, 1);
                }

                await sleep((short)random_range(60, 120));
                if (volume_test_objects(vol_bridge_ghost_spawn, players()) == true || volume_test_objects(vol_bridge_inside_bunker, players()) == true)
                {
                    sleep_forever();
                }

                if (this.bridge_vehicles_total > 0)
                {
                    game_save();
                    ai_place(bridge_phantom_ghosts_01.Squad, 1);
                }

                this.bridge_vehicles_total = (short)(this.bridge_vehicles_total - 1);
                return this.bridge_vehicles_total <= 0 || volume_test_objects(vol_bridge_ghost_spawn, players()) == true || volume_test_objects(vol_bridge_inside_bunker, players()) == true;
            });
            await sleep_until(async () => (short)ai_living_count(bridge_vehicles_all) < 1 && (short)ai_living_count(bridge_bunker_turrets1.Squad) < 1);
            game_save_no_timeout();
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task bridge_activate_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_bridge_inside_bunker, players()) == true, 30, 16000);
            if (volume_test_objects(vol_bridge_inside_bunker, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'get into that structure and find the controls to extend the bridge!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0470"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task bridge_cortana_response()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'a sermon, actually.  i've been listening to him since we landed.'");
            print("cortana: 'so far it's the standard covenant liturgy,'");
            print("cortana: 'but i'll translate if he says anything interesting.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0080"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(243, Lifecycle.CommandScript)]
        public async Task bridge_holo_comment()
        {
            this.regret_ally_comment_go = true;
            cs_switch("bridge_marine");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("marine: 'isn't that our target?'");
            cs_play_line("0060");
            await sleep(30);
            print("marine: 'what's he doing?  giving a speech?'");
            cs_play_line("0070");
            wake(new ScriptMethodReference(bridge_cortana_response));
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task bunker_holo_looper()
        {
            object_create(regret01);
            objects_attach(bunker_throne.Entity, "driver", regret01.Entity, "");
            ai_disregard(regret01.Entity, true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant1a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3000"));
                        await sleep((short)random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2b", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3001"));
                        await sleep((short)random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2c", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3002"));
                        await sleep((short)random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3003"));
                        await sleep((short)random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3c", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3004"));
                        await sleep((short)random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant5a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3005"));
                        await sleep((short)random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant6a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3006"));
                        await sleep((short)random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task bridge_holo_translate()
        {
            await sleep_until(async () => (short)ai_living_count(bridge_enemies_bunker) < 1 && volume_test_objects(vol_bunker_upper_level, players()) == true);
            await sleep_until(async () => (short)ai_living_count(all_allies) < 1 || ai_scene("bridge_holo_scene", new ScriptMethodReference(bridge_holo_comment), all_allies), 30, 300);
            await sleep(30);
            if (this.regret_ally_comment_go == false && volume_test_objects(vol_bunker_upper_level, players()) == true)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'regret's giving a speech - a sermon to be exact.'");
                print("'so far it's the standard covenant liturgy, but i'll translate if he says anything interesting.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2110"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => volume_test_objects(vol_bunker_upper_level, players()) == true && (short)ai_living_count(bridge_enemies_bunker) < 1);
            await sleep(60);
            this.bunker_holo_trans = true;
            await sleep_until(async () => objects_can_see_object(players(), regret01.Entity, 30F) == true && volume_test_objects(vol_bunker_upper_level, players()) == true && this.bunker_holo_chant == false);
            ai_dialogue_enable(false);
            await sleep(60);
            custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_l05_0090_por", true);
            print("regret: 'the forerunners, our most exalted lords, used the seven sacred rings...'");
            print("'...to flee a doomed existence - to escape their endless struggle against the flood!'");
            await sleep(ai_play_line_on_object(regret01.Entity, "0090"));
            await sleep(30);
            custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_l05_0100_por", true);
            print("'long ago, the prophets and elites fought an equally fruitless war.'");
            print("'indeed, i suspect we would still be at each other's throats had the prophets...'");
            print("'...not found evidence of the forerunners and their great journey!'");
            await sleep(ai_play_line_on_object(regret01.Entity, "0100"));
            await sleep(30);
            ai_dialogue_enable(true);
            await sleep((short)random_range(240, 480));
            this.bunker_holo_trans = false;
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task bridge_ally_comment()
        {
            cs_switch("bridge_ally");
            cs_enable_pathfinding_failsafe(true);
            this.bridge_ally_comment_go = true;
            cs_abort_on_damage(true);
            print("ally: 'good. the bridge is down. now about those wraiths�'");
            cs_play_line("0490");
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task crack_spawn()
        {
            await sleep_until(async () => (short)ai_combat_status(bridge_enemies_bunker) > this.ai_combat_status_idle);
            if (await this.difficulty_heroic())
            {
                ai_place(bridge_crack_jackals.Squad, 1);
            }

            if (await this.difficulty_normal())
            {
                ai_place(bridge_crack_jackals.Squad, 2);
            }
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task bunker_turret_remanning()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects(vol_bridge_inside_bunker, players()) == false && await this.player_count() > 0 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_01), "c_turret_ap_d", ai_actors(all_enemies)) == false && object_get_health(ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_01)) > 0F && (short)ai_living_count(bunker_turret_remen.Squad) < 1)
                {
                    ai_place(bunker_turret_remen._1);
                    await sleep(5);
                    ai_vehicle_enter(bunker_turret_remen.Squad, ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_01));
                }

                if (volume_test_objects(vol_bridge_inside_bunker, players()) == false && await this.player_count() > 0 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_02), "c_turret_ap_d", ai_actors(all_enemies)) == false && object_get_health(ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_02)) > 0F && (short)ai_living_count(bunker_turret_remen.Squad) < 1)
                {
                    ai_place(bunker_turret_remen._2);
                    await sleep(5);
                    ai_vehicle_enter(bunker_turret_remen.Squad, ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_02));
                }

                if (volume_test_objects(vol_bridge_inside_bunker, players()) == false && await this.player_count() > 0 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_03), "c_turret_ap_d", ai_actors(all_enemies)) == false && object_get_health(ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_03)) > 0F && (short)ai_living_count(bunker_turret_remen.Squad) < 1)
                {
                    ai_place(bunker_turret_remen._3);
                    await sleep(5);
                    ai_vehicle_enter(bunker_turret_remen.Squad, ai_vehicle_get_from_starting_location(bridge_bunker_turrets1.bunker_03));
                }

                return volume_test_objects(vol_bridge_inside_bunker, players()) == true || (short)ai_spawn_count(bunker_turret_remen.Squad) > 5;
            });
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task bunker_upper_spawn_01()
        {
            await sleep_until(async () => volume_test_objects(vol_bunker_front, players()) == true || (short)ai_living_count(bridge_enemies_bunker) < 1);
            game_save();
            if ((short)ai_living_count(bridge_bunker_elites) < 2)
            {
                ai_place(bridge_bunker_elites_01.Squad, 1);
            }

            ai_place(bridge_bunker_grunts_01.Squad, (short)((float)random_range(1, 3) - (float)ai_living_count(bridge_bunker_grunts)));
            await sleep_until(async () => volume_test_objects(vol_bunker_front, players()) == true || (short)ai_living_count(bridge_enemies_bunker) < 1);
            game_save();
            if ((short)ai_living_count(bridge_enemies_bunker) < 1 && volume_test_objects(vol_bridge_inside_bunker, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(bridge_bunker_elites) < 2)
                {
                    ai_place(bridge_bunker_elites_01.Squad, 1);
                }

                ai_place(bridge_bunker_jackals_01.Squad, (short)(2 - (float)ai_living_count(bridge_bunker_jackals)));
            }

            await sleep_until(async () => volume_test_objects(vol_bunker_front, players()) == true || (short)ai_living_count(bridge_enemies_bunker) < 1);
            game_save();
            if ((short)ai_living_count(bridge_enemies_bunker) < 1 && volume_test_objects(vol_bridge_inside_bunker, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(bridge_bunker_elites) < 2)
                {
                    ai_place(bridge_bunker_elites_01.Squad, (short)(1 - (float)ai_living_count(bridge_bunker_elites)));
                }

                ai_place(bridge_bunker_jackals_01.Squad, (short)(1 - (float)ai_living_count(bridge_bunker_jackals)));
                ai_set_orders(bridge_bunker_elites_01.Squad, bridge_bunker_in_upper_01);
                ai_set_orders(bridge_bunker_jackals_01.Squad, bridge_bunker_in_upper_01);
            }
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task bunker_upper_spawn_03()
        {
            await sleep_until(async () => volume_test_objects(vol_bunker_upper_level, players()) == true || volume_test_objects(vol_bunker_roof, players()) == true || volume_test_objects(vol_bunker_spawnstop_01, players()) == true || volume_test_objects(vol_bunker_spawnstop_02, players()) == true || volume_test_objects(vol_bunker_spawnstop_03, players()) == true);
            game_save();
            wake(new ScriptMethodReference(music_05a_03_start));
            ai_place(bridge_control_elites_01.Squad, 1);
            ai_place(bridge_control_jackals_01.Squad, (short)random_range(0, 3));
            ai_place(bridge_control_grunts_01.Squad, (short)(3 - (float)ai_living_count(bridge_control_jackals_01.Squad)));
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task bunker_lower_spawn_01()
        {
            await sleep_until(async () => volume_test_objects(vol_bunker_backdoor, players()) == true);
            game_save();
            if ((short)ai_living_count(bridge_bunker_elites) < 2)
            {
                ai_place(bridge_backdoor_elites_01.Squad, 1);
            }

            ai_place(bridge_backdoor_grunts_01.Squad, (short)((float)random_range(1, 3) - (float)ai_living_count(bridge_bunker_grunts)));
            await sleep_until(async () => volume_test_objects(vol_bunker_backdoor, players()) == true || (short)ai_living_count(bridge_enemies_bunker) < 1);
            game_save();
            if ((short)ai_living_count(bridge_enemies_bunker) < 1 && volume_test_objects(vol_bunker_lower_level, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(bridge_bunker_elites) < 2)
                {
                    ai_place(bridge_backdoor_elites_01.Squad, 1);
                }

                ai_place(bridge_backdoor_jackals_01.Squad, (short)(2 - (float)ai_living_count(bridge_bunker_jackals)));
            }

            await sleep_until(async () => volume_test_objects(vol_bunker_backdoor, players()) == true || (short)ai_living_count(bridge_enemies_bunker) < 1);
            game_save();
            if ((short)ai_living_count(bridge_enemies_bunker) < 1 && volume_test_objects(vol_bunker_lower_level, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(bridge_bunker_elites) < 2)
                {
                    ai_place(bridge_backdoor_elites_01.Squad, (short)(1 - (float)ai_living_count(bridge_bunker_elites)));
                }

                ai_place(bridge_backdoor_jackals_01.Squad, (short)(2 - (float)ai_living_count(bridge_bunker_jackals)));
                ai_set_orders(bridge_backdoor_elites_01.Squad, bridge_bunker_in_lower_02);
                ai_set_orders(bridge_backdoor_jackals_01.Squad, bridge_bunker_in_lower_02);
            }
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task bunker_spawn_checker()
        {
            await sleep_until(async () => volume_test_objects(vol_bunker_upper_level, players()) == true || volume_test_objects(vol_bunker_spawnstop_01, players()) == true || volume_test_objects(vol_bunker_spawnstop_02, players()) == true || volume_test_objects(vol_bunker_spawnstop_03, players()) == true);
            sleep_forever(new ScriptMethodReference(bunker_upper_spawn_01));
            sleep_forever(new ScriptMethodReference(bunker_lower_spawn_01));
            sleep_forever(new ScriptMethodReference(bunker_turret_remanning));
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task bridge_pelican_wait()
        {
            await sleep_until(async () => volume_test_objects(vol_bridge_middle, players()) == true || volume_test_objects(vol_bridge_farside_all, players()) == true);
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player0()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player1()) == false)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'you don't want the tank?  o-kay�i guess we'll leave it for the others.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0510"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            wake(new ScriptMethodReference(music_05a_04_start));
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task bridge_cross_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_bridge_farside_all, players()) == true, 30, 8000);
            if (volume_test_objects(vol_bridge_farside_all, players()) == false && (short)ai_living_count(bridge_farside_wraiths.Squad) > 0 && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'let's head across the bridge and deal with those wraiths.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0520"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(255, Lifecycle.CommandScript)]
        public async Task banshee_boost()
        {
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_enable_moving(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 50F);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task bridge_pelican_timer()
        {
            await sleep(8000);
            object_destroy(ai_vehicle_get_from_starting_location(bridge_pelican.pilot));
        }

        [ScriptMethod(257, Lifecycle.CommandScript)]
        public async Task gimme_tank()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel0"), 50F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel1"), 50F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel2"), 50F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel3"), 50F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel4"), 20F);
            this.bridge_pelican_in_sight = true;
            cs_vehicle_boost(false);
            ai_set_orders(bridge_pelican_chasers.Squad, bridge_air);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/pel4too"), 3F);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/pel6"), 3F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bridge_airspace/pel6"), GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bridge_airspace/pel7"), GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            await sleep_until(async () => volume_test_objects(vol_bridge_tank, players()) == false && volume_test_objects(vol_bridge_tank, ai_actors(all_allies)) == false && await this.player_count() > 0);
            vehicle_unload(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_lc");
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_p");
            this.bridge_pelican_arrived = true;
            wake(new ScriptMethodReference(bridge_pelican_timer));
            await sleep_until(async () => (short)ai_living_count(bridge_pelican.Squad) < 4);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("bridge_airspace/pel6"), 2F);
            cs_vehicle_boost(true);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel4"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel1"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pel0"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("bridge_airspace/pelx"), 20F);
            ai_erase(bridge_pelican.Squad);
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task bridge_pelican_run()
        {
            ai_place(allies_bridge_pelican.Squad, (short)(2 - (float)ai_living_count(all_allies)));
            ai_place(bridge_pelican.Squad);
            ai_place(bridge_tank1.Squad);
            object_cannot_take_damage(ai_vehicle_get_from_starting_location(bridge_pelican.pilot));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_p", ai_actors(allies_bridge_pelican.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_lc", ai_vehicle_get_from_starting_location(bridge_tank1.driver));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), true);
            ai_vehicle_reserve_seat(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", true);
            cs_run_command_script(bridge_pelican.pilot, new ScriptMethodReference(gimme_tank));
        }

        [ScriptMethod(259, Lifecycle.Static)]
        public async Task short_bridge_pel()
        {
            ai_place(allies_bridge_pelican.Squad, (short)(2 - (float)ai_living_count(all_allies)));
            ai_place(bridge_pelican.Squad);
            ai_place(bridge_tank1.Squad);
            object_cannot_take_damage(ai_vehicle_get_from_starting_location(bridge_pelican.pilot));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_p", ai_actors(allies_bridge_pelican.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_lc", ai_vehicle_get_from_starting_location(bridge_tank1.driver));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_pelican.pilot), true);
            cs_run_command_script(bridge_pelican.pilot, new ScriptMethodReference(gimme_tank));
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task bridge_banshee_spawn()
        {
            await sleep_until(async () => (short)ai_living_count(bridge_farside_wraiths.Squad) < 1 || volume_test_objects(vol_winding_path, players()) == true);
            if (volume_test_objects(vol_winding_path, players()) == true)
            {
                sleep_forever();
            }

            if (volume_test_objects(vol_winding_path, players()) == false && await this.difficulty_normal() || await this.difficulty_heroic())
            {
                ai_place(bridge_banshees.Squad, 1);
                cs_run_command_script(bridge_banshees.Squad, new ScriptMethodReference(banshee_boost));
            }

            if (await this.difficulty_legendary() && volume_test_objects(vol_winding_path, players()) == false)
            {
                ai_place(bridge_banshees.Squad, 2);
                cs_run_command_script(bridge_banshees.Squad, new ScriptMethodReference(banshee_boost));
            }

            await sleep_until(async () => (short)ai_living_count(bridge_banshees.Squad) < 1 || volume_test_objects(vol_winding_path, players()) == true);
            if (volume_test_objects(vol_winding_path, players()) == true)
            {
                sleep_forever();
            }

            if (volume_test_objects(vol_winding_path, players()) == false && await this.difficulty_normal() || await this.difficulty_heroic())
            {
                ai_place(bridge_banshees.Squad, 1);
                cs_run_command_script(bridge_banshees.Squad, new ScriptMethodReference(banshee_boost));
            }

            if (await this.difficulty_legendary() && volume_test_objects(vol_winding_path, players()) == false)
            {
                ai_place(bridge_banshees.Squad, 2);
                cs_run_command_script(bridge_banshees.Squad, new ScriptMethodReference(banshee_boost));
            }
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task farside_ghosts_spawn()
        {
            await sleep_until(async () => volume_test_objects(vol_bridge_middle, players()) == true && device_get_position(da_bridge.Entity) == 0F);
            ai_place(bridge_farside_ghosts.Squad, 2);
            await sleep_until(async () => volume_test_objects(vol_winding_path, players()) == true || (short)ai_living_count(bridge_farside_ghosts.Squad) < 1);
            if (volume_test_objects(vol_winding_path, players()) == false && await this.player_count() > 0 && (short)ai_living_count(bridge_farside_ghosts.Squad) < 1)
            {
                ai_place(bridge_farside_ghosts.Squad, 2);
            }
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task bridge_spare_ghost_spawn()
        {
            await sleep_until(async () =>
            {
                if (list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && objects_can_see_flag(players(), extra_ghost_01, 45F) == false && objects_distance_to_flag(players(), extra_ghost_01) > 5F)
                {
                    ai_place(bridge_free_ghost._1);
                }

                if (list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && objects_can_see_flag(players(), extra_ghost_02, 45F) == false && objects_distance_to_flag(players(), extra_ghost_02) > 5F)
                {
                    ai_place(bridge_free_ghost._2);
                }

                if (list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && objects_can_see_flag(players(), extra_ghost_03, 45F) == false && objects_distance_to_flag(players(), extra_ghost_03) > 5F)
                {
                    ai_place(bridge_free_ghost._3);
                }

                if (list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && objects_can_see_flag(players(), extra_ghost_04, 45F) == false && objects_distance_to_flag(players(), extra_ghost_04) > 5F)
                {
                    ai_place(bridge_free_ghost._4);
                }

                return list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) > 0 || list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) > 0 || list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) > 0 || list_count(ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) > 0;
            });
        }

        [ScriptMethod(263, Lifecycle.CommandScript)]
        public async Task bridge_wraith_engage()
        {
            cs_abort_on_damage(true);
            cs_go_to(GetReference<ISpatialPoint>("bridge/p0"));
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_shoot(true, ai_vehicle_get_from_starting_location(LZ_warthog_01.driver));
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_visible);
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task bridges_start()
        {
            device_set_position_immediate(da_bridge.Entity, 0.5F);
            device_set_position(real_bridge.Entity, 1F);
            object_create(waterfall_far);
            object_create(waterfall_close);
            wake(new ScriptMethodReference(bunker_holo_looper));
            ai_place(bridge_bunker_ghosts.Squad);
            ai_place(bridge_ghost_elites.Squad, 2);
            cs_run_command_script(bridge_ghost_elites.r, new ScriptMethodReference(bridge_ghostman_r));
            cs_run_command_script(bridge_ghost_elites.l, new ScriptMethodReference(bridge_ghostman_l));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), true);
            await sleep(15);
            if (await this.difficulty_legendary())
            {
                ai_place(bridge_bunker_turrets1.Squad, 4);
            }

            if (await this.difficulty_heroic())
            {
                ai_place(bridge_bunker_turrets1.Squad, 3);
            }

            if (await this.difficulty_normal())
            {
                ai_place(bridge_bunker_turrets1.Squad, 2);
            }

            cs_run_command_script(bridge_bunker_turrets1.Squad, new ScriptMethodReference(stay_shooting));
            await sleep(15);
            wake(new ScriptMethodReference(crack_spawn));
            wake(new ScriptMethodReference(bunker_upper_spawn_03));
            wake(new ScriptMethodReference(bunker_spawn_checker));
            wake(new ScriptMethodReference(bridge_ghosts_by_phantom));
            wake(new ScriptMethodReference(bunker_turret_remanning));
            await sleep_until(async () => volume_test_objects(vol_bridge_pause, players()) == true);
            data_mine_set_mission_segment("05a_3_bridge");
            wake(new ScriptMethodReference(music_05a_02_stop));
            device_set_position(da_bridge.Entity, 1F);
            await sleep(60);
            wake(new ScriptMethodReference(bridge_cortana_comment));
            wake(new ScriptMethodReference(bridge_activate_reminder));
            device_group_change_only_once_more_set(da_bridge1, true);
            await sleep_until(async () => volume_test_objects(vol_bridge_engage, players()) == true);
            ai_place(bridge_farside_wraiths.Squad, 1);
            cs_run_command_script(bridge_farside_wraiths.Squad, new ScriptMethodReference(bridge_wraith_engage));
            wake(new ScriptMethodReference(bridge_wraith_warning));
            await sleep_until(async () => volume_test_objects(vol_bridge_inside_bunker, players()) == true);
            sleep_forever(new ScriptMethodReference(bridge_ghosts_by_phantom));
            await sleep_until(async () =>
            {
                this.bridge_state = device_get_position(da_bridge.Entity);
                await sleep(15);
                return device_get_position(da_bridge.Entity) < this.bridge_state;
            });
            wake(new ScriptMethodReference(music_05a_03_stop));
            wake(new ScriptMethodReference(bridge_pelican_run));
            wake(new ScriptMethodReference(lights));
            ai_set_orders(all_allies, bridge_tank_wait);
            game_save();
            wake(new ScriptMethodReference(farside_ghosts_spawn));
            if (await this.difficulty_legendary() || await this.difficulty_heroic())
            {
                ai_place(bridge_farside_wraiths.Squad, (short)(2 - (float)ai_living_count(bridge_farside_wraiths.Squad)));
            }
            else
            {
                ai_place(bridge_farside_wraiths.Squad, (short)(1 - (float)ai_living_count(bridge_farside_wraiths.Squad)));
            }

            wake(new ScriptMethodReference(bridge_cross_reminder));
            await sleep_until(async () => ai_scene("bridge_ally_scene", new ScriptMethodReference(bridge_ally_comment), all_allies) || (short)ai_living_count(bridge_allies) < 1, 30, 150);
            await sleep(150);
            if (this.bridge_ally_comment_go == false)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'good. the bridge is down. now about those wraiths�'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2040"));
            }

            ai_dialogue_enable(false);
            await sleep(60);
            print("johnson: 'roger that, marine. armor's on the way!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0500"));
            await sleep(30);
            ai_dialogue_enable(true);
            game_save();
            wake(new ScriptMethodReference(bridge_holo_translate));
            wake(new ScriptMethodReference(bridge_pelican_wait));
            await sleep_until(async () => device_get_position(da_bridge.Entity) == 0F);
            device_set_position(real_bridge.Entity, 0F);
            await sleep_until(async () => this.bridge_pelican_arrived == true);
            wake(new ScriptMethodReference(bridge_banshee_spawn));
            wake(new ScriptMethodReference(bridge_spare_ghost_spawn));
            await sleep_until(async () => volume_test_objects(vol_bridge_all, players()) == false && await this.player_count() > 0 || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), "ghost_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), "ghost_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._1), "ghost_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._2), "ghost_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1), "ghost_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2), "ghost_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_farside_ghosts._1), "ghost_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_farside_ghosts._2), "ghost_d", await this.player0()) && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), "ghost_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), "ghost_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._1), "ghost_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._2), "ghost_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1), "ghost_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2), "ghost_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_farside_ghosts._1), "ghost_d", await this.player1()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_farside_ghosts._2), "ghost_d", await this.player1()) || (bool)game_is_cooperative() == false);
            await sleep(120);
            game_save();
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_tank1.driver), false);
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()))
            {
                wake(new ScriptMethodReference(music_05a_04_start));
            }
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task waterfall_toggle()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(vol_waterfall_off, players()) == true);
                object_destroy(waterfall_far.Entity);
                object_destroy(waterfall_close.Entity);
                await sleep_until(async () => volume_test_objects(vol_waterfall_on, players()) == true);
                object_create(waterfall_far);
                object_create(waterfall_close);
                return false;
            });
        }

        [ScriptMethod(266, Lifecycle.CommandScript)]
        public async Task w_path_turret_0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("w_path_turrets/go_p0"));
            cs_deploy_turret(GetReference<ISpatialPoint>("w_path_turrets/p0"));
        }

        [ScriptMethod(267, Lifecycle.CommandScript)]
        public async Task w_path_turret_1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("w_path_turrets/go_p1"));
            cs_deploy_turret(GetReference<ISpatialPoint>("w_path_turrets/p1"));
        }

        [ScriptMethod(268, Lifecycle.CommandScript)]
        public async Task w_path_turret_2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("w_path_turrets/go_p2"));
            cs_deploy_turret(GetReference<ISpatialPoint>("w_path_turrets/p2"));
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task w_path_turret_deploy()
        {
            if (await this.difficulty_legendary())
            {
                this.w_path_turret_count = 3;
            }

            if (await this.difficulty_heroic())
            {
                this.w_path_turret_count = 2;
            }

            begin_random(async () =>
            {
                if (this.w_path_turret_count > 0)
                {
                    ai_place(w_path_heavies._0);
                    cs_run_command_script(w_path_heavies._0, new ScriptMethodReference(w_path_turret_0));
                    this.w_path_turret_count = (short)(this.w_path_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.w_path_turret_count > 0)
                {
                    ai_place(w_path_heavies._1);
                    cs_run_command_script(w_path_heavies._1, new ScriptMethodReference(w_path_turret_1));
                    this.w_path_turret_count = (short)(this.w_path_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.w_path_turret_count > 2)
                {
                    ai_place(w_path_heavies._2);
                    cs_run_command_script(w_path_heavies._0, new ScriptMethodReference(w_path_turret_2));
                    this.w_path_turret_count = (short)(this.w_path_turret_count - 1);
                }
            });
        }

        [ScriptMethod(270, Lifecycle.CommandScript)]
        public async Task throw_grenade()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_clear_los);
            cs_grenade(GetReference<ISpatialPoint>("w_path_turrets/p3"), 1);
        }

        [ScriptMethod(271, Lifecycle.Dormant)]
        public async Task winding_path_start()
        {
            ai_disposable(overlook_jackals, true);
            ai_disposable(bridge_enemies_all, true);
            data_mine_set_mission_segment("05a_4_winding_path");
            game_save();
            wake(new ScriptMethodReference(waterfall_toggle));
            ai_place(w_path_free_ghost.Squad, 1);
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "", players()) == false)
            {
                this.w_path_spawn_count = 3;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(winding_path_ghosts) < 1 || volume_test_objects(vol_winding_path_mid_01, players()) == true);
                if (volume_test_objects(vol_winding_path_mid_01, players()) == false && await this.player_count() > 0)
                {
                    ai_place(winding_path_ghosts_01.Squad, 1);
                }

                await sleep_until(async () => volume_test_objects(vol_winding_path_mid_01, players()) == true, 30, (int)random_range(30, 90));
                if (volume_test_objects(vol_winding_path_mid_01, players()) == false && await this.player_count() > 0)
                {
                    ai_place(winding_path_ghosts_01.Squad, 1);
                }

                return volume_test_objects(vol_winding_path_mid_01, players()) == true || (short)ai_spawn_count(winding_path_ghosts_01.Squad) > this.w_path_spawn_count;
            });
            await sleep_until(async () => volume_test_objects(vol_winding_path_mid_02, players()) == true);
            game_save();
            if ((short)ai_living_count(winding_path_enemies) < 6)
            {
                ai_place(winding_path_grunts.Squad, 4);
            }

            wake(new ScriptMethodReference(w_path_turret_deploy));
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(winding_path_ghosts) < 1 || volume_test_objects(vol_waterfall_on, players()) == true);
                if (volume_test_objects(vol_waterfall_on, players()) == false && await this.player_count() > 0)
                {
                    ai_place(winding_path_ghosts_02.Squad, 1);
                }

                await sleep_until(async () => volume_test_objects(vol_waterfall_on, players()) == true, 30, (int)random_range(30, 90));
                if (volume_test_objects(vol_waterfall_on, players()) == false && await this.player_count() > 0)
                {
                    ai_place(winding_path_ghosts_02.Squad, 1);
                }

                return volume_test_objects(vol_waterfall_on, players()) == true || (short)ai_spawn_count(winding_path_ghosts_02.Squad) > this.w_path_spawn_count;
            });
            game_save();
            if ((short)ai_living_count(winding_path_enemies) < 6)
            {
                ai_place(winding_path_jackals.Squad, 3);
            }

            if ((short)ai_living_count(winding_path_enemies) < 6)
            {
                ai_place(winding_path_ledge_grunts.Squad, 3);
            }

            cs_run_command_script(winding_path_ledge_grunts.Squad, new ScriptMethodReference(throw_grenade));
            await sleep_until(async () => (short)ai_living_count(winding_path_ghosts) < 1 && (short)ai_living_count(winding_path_grunts.Squad) < 1 && (short)ai_living_count(winding_path_jackals.Squad) < 1);
            game_save();
        }

        [ScriptMethod(272, Lifecycle.Dormant)]
        public async Task temple_ent_turret_spawn()
        {
            if (await this.difficulty_legendary())
            {
                this.temple_ent_near_turret = 3;
                this.temple_ent_far_turret = 3;
            }

            if (await this.difficulty_heroic())
            {
                this.temple_ent_near_turret = 2;
                this.temple_ent_far_turret = 2;
            }

            begin_random(async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    ai_place(temple_ent_turrets_01._1);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    ai_place(temple_ent_turrets_01._2);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    ai_place(temple_ent_turrets_02._1);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    ai_place(temple_ent_turrets_02._2);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            });
            begin_random(async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    ai_place(temple_ent_turrets_03._1);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    ai_place(temple_ent_turrets_03._2);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    ai_place(temple_ent_turrets_04._1);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    ai_place(temple_ent_turrets_04._2);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            });
        }

        [ScriptMethod(273, Lifecycle.CommandScript)]
        public async Task temple_ent_ghostman_r()
        {
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.r));
        }

        [ScriptMethod(274, Lifecycle.CommandScript)]
        public async Task temple_ent_ghostman_l()
        {
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.l));
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task temple_ent_ghost_alert()
        {
            await sleep_until(async () => (short)ai_combat_status(temple_ent_elites_01r.Squad) > this.ai_combat_status_idle || (short)ai_combat_status(temple_ent_elites_01l.Squad) > this.ai_combat_status_idle);
            cs_run_command_script(temple_ent_elites_01r.Squad, new ScriptMethodReference(temple_ent_ghostman_r));
            cs_run_command_script(temple_ent_elites_01l.Squad, new ScriptMethodReference(temple_ent_ghostman_l));
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task temple_ent_veh_spawn()
        {
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "", players()) == false)
            {
                this.temple_ent_spawn_count = 3;
            }

            await sleep_until(async () => (short)ai_living_count(temple_ent_elites_02r.Squad) < 1 && (short)ai_living_count(temple_ent_elites_02l.Squad) < 1 && (short)ai_living_count(temple_ent_ghosts_01.Squad) < 1 || object_get_health(ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.r)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.l)) <= 0F || volume_test_objects(vol_temple_ent_02, players()) == true || volume_test_objects(vol_temple_ent_03, players()) == true, 30, 900);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(temple_ent_ghosts) < 1 || volume_test_objects(vol_temple_ent_02, players()) == true);
                game_save();
                if (volume_test_objects(vol_temple_ent_02, players()) == false)
                {
                    ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)ai_living_count(temple_ent_ghosts)));
                }

                await sleep_until(async () => volume_test_objects(vol_temple_ent_02, players()) == true, 30, (int)random_range(30, 90));
                if (volume_test_objects(vol_temple_ent_02, players()) == false)
                {
                    ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)ai_living_count(temple_ent_ghosts)));
                }

                return (short)ai_spawn_count(temple_ent_ghosts_02.Squad) > this.temple_ent_spawn_count || volume_test_objects(vol_temple_ent_02, players()) == true || volume_test_objects(vol_temple_ent_03, players()) == true;
            });
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(temple_ent_ghosts) < 1 || volume_test_objects(vol_temple_ent_03, players()) == true);
                game_save();
                if (volume_test_objects(vol_temple_ent_03, players()) == false)
                {
                    ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)ai_living_count(temple_ent_ghosts)));
                }

                await sleep_until(async () => volume_test_objects(vol_temple_ent_03, players()) == true, 30, (int)random_range(30, 90));
                if (volume_test_objects(vol_temple_ent_03, players()) == false)
                {
                    ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)ai_living_count(temple_ent_ghosts)));
                }

                return (short)ai_spawn_count(temple_ent_ghosts_02.Squad) > (short)(this.temple_ent_spawn_count * 2F - 1) || volume_test_objects(vol_temple_ent_03, players()) == true;
            });
        }

        [ScriptMethod(277, Lifecycle.CommandScript)]
        public async Task back_home_comment()
        {
            cs_switch("ally01");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("ally: 'kinda reminds me of back home�'");
            cs_play_line("0530");
            cs_switch("ally02");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("ally: 'yeah. too bad we're blowing it the hell up!'");
            cs_play_line("0540");
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task temple_ent_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_tunnel_01, players()) == true, 30, 8000);
            if (volume_test_objects(vol_tunnel_01, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'let's push on. we need to find a an access point to those structures in the lake.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0580"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task old_temple_entrance_start()
        {
            await sleep_until(async () => volume_test_objects(vol_temple_entrance, players()) == true);
            ai_disposable(winding_path_enemies, true);
            data_mine_set_mission_segment("05a_5_temple_entrance");
            game_save();
            wake(new ScriptMethodReference(_05a_title1));
            wake(new ScriptMethodReference(music_05a_04_start_alt));
            wake(new ScriptMethodReference(temple_ent_turret_spawn));
            ai_place(temple_ent_elites_01l.Squad, 1);
            ai_place(temple_ent_elites_01r.Squad, 1);
            if (await this.difficulty_heroic())
            {
                ai_place(temple_ent_jackals_01l.Squad, 1);
                ai_place(temple_ent_jackals_01r.Squad, 1);
            }

            if (await this.difficulty_normal())
            {
                ai_place(temple_ent_jackals_01l.Squad, 2);
                ai_place(temple_ent_jackals_01r.Squad, 2);
            }

            ai_place(temple_ent_ghosts_01.Squad, 2);
            wake(new ScriptMethodReference(temple_ent_ghost_alert));
            await sleep_until(async () => (short)ai_living_count(temple_ent_turrets_near) < 1 || (short)ai_living_count(temple_ent_enemies_all) < 4 || volume_test_objects(vol_temple_ent_01, players()) == true);
            game_save();
            if ((short)ai_living_count(temple_ent_enemies_all) < 8)
            {
                ai_place(temple_ent_elites_02r.Squad, (short)(1 - (float)ai_living_count(temple_ent_elites_01r.Squad)));
            }

            if ((short)ai_living_count(temple_ent_enemies_all) < 8)
            {
                ai_place(temple_ent_elites_02l.Squad, (short)(1 - (float)ai_living_count(temple_ent_elites_01l.Squad)));
            }

            wake(new ScriptMethodReference(temple_ent_veh_spawn));
            this.temple_ent_phase_01 = true;
            await sleep_until(async () => (short)ai_living_count(temple_ent_enemies_all) < 4 || volume_test_objects(vol_temple_ent_02, players()) == true);
            game_save();
            if ((short)ai_living_count(temple_ent_enemies_all) < 8)
            {
                ai_place(temple_ent_jackals_02c.Squad, 2);
            }

            if (object_get_health(ai_vehicle_get_from_starting_location(temple_ent_turrets_03._1)) > 0F && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(temple_ent_turrets_03._1), "", ai_actors(all_enemies)) == false && (short)ai_living_count(temple_ent_enemies_all) < 8)
            {
                ai_place(temple_ent_grunts_01l.Squad, 1);
            }

            if (object_get_health(ai_vehicle_get_from_starting_location(temple_ent_turrets_03._2)) > 0F && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(temple_ent_turrets_03._2), "", ai_actors(all_enemies)) == false && (short)ai_living_count(temple_ent_enemies_all) < 8)
            {
                ai_place(temple_ent_grunts_01l.Squad, 1);
            }

            if (object_get_health(ai_vehicle_get_from_starting_location(temple_ent_turrets_04._1)) > 0F && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(temple_ent_turrets_04._1), "", ai_actors(all_enemies)) == false && (short)ai_living_count(temple_ent_enemies_all) < 8)
            {
                ai_place(temple_ent_grunts_01r.Squad, 1);
            }

            if (object_get_health(ai_vehicle_get_from_starting_location(temple_ent_turrets_04._2)) > 0F && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(temple_ent_turrets_04._2), "", ai_actors(all_enemies)) == false && (short)ai_living_count(temple_ent_enemies_all) < 8)
            {
                ai_place(temple_ent_grunts_01r.Squad, 1);
            }

            this.temple_ent_phase_02 = true;
            await sleep_until(async () => (short)ai_living_count(temple_ent_enemies_all) < 1 || volume_test_objects(vol_temple_ent_03, players()) == true);
            game_save();
            ai_set_orders(temple_ent_ghosts, temple_ent_back_02);
            wake(new ScriptMethodReference(temple_ent_reminder));
            await sleep_until(async () => (short)ai_living_count(temple_ent_enemies_all) < 1 || volume_test_objects(vol_tunnel_01, players()) == true);
            game_save();
            await sleep_until(async () => (short)ai_living_count(all_allies) < 1 || ai_scene("temple_ent_scene", new ScriptMethodReference(back_home_comment), all_allies), 30, 300);
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task temple_ent_arch()
        {
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", tunnel_enemies_all) == true || volume_test_objects(vol_old_temple_near_left, players()) == true);
            await sleep_until(async () => volume_test_objects(vol_old_temple_near_left, players()) == true, 30, 450);
            if (volume_test_objects(vol_old_temple_near_left, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'these structures seem forerunner,'");
                print("'but they're much older than anything we ever found on the first halo.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0570"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(281, Lifecycle.CommandScript)]
        public async Task old_temple_structure_comment()
        {
            this.structure_comment_go = true;
            cs_switch("ally");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("ally: 'careful, we're coming-up on another structure!'");
            cs_play_line("0600");
        }

        [ScriptMethod(282, Lifecycle.CommandScript)]
        public async Task tunnel_turret_0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("tunnel_turrets/go_p0"));
            cs_deploy_turret(GetReference<ISpatialPoint>("tunnel_turrets/p0"));
        }

        [ScriptMethod(283, Lifecycle.CommandScript)]
        public async Task tunnel_turret_1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("tunnel_turrets/go_p1"));
            cs_deploy_turret(GetReference<ISpatialPoint>("tunnel_turrets/p1"));
        }

        [ScriptMethod(284, Lifecycle.CommandScript)]
        public async Task tunnel_turret_2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("tunnel_turrets/go_p2"));
            cs_deploy_turret(GetReference<ISpatialPoint>("tunnel_turrets/p2"));
        }

        [ScriptMethod(285, Lifecycle.CommandScript)]
        public async Task tunnel_turret_3()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("tunnel_turrets/go_p3"));
            cs_deploy_turret(GetReference<ISpatialPoint>("tunnel_turrets/p3"));
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task tunnel_start()
        {
            ai_disposable(temple_ent_enemies_all, true);
            data_mine_set_mission_segment("05a_6_tunnel");
            game_save();
            if ((short)ai_living_count(tunnel_enemies_all) < 6)
            {
                ai_place(tunnel_grunts.Squad, 2);
            }

            if ((short)ai_living_count(tunnel_enemies_all) < 6)
            {
                ai_place(tunnel_heavies_01.Squad, 2);
            }

            cs_run_command_script(tunnel_heavies_01._0, new ScriptMethodReference(tunnel_turret_0));
            cs_run_command_script(tunnel_heavies_01._1, new ScriptMethodReference(tunnel_turret_1));
            ai_place(tunnel_ghosts_011.Squad, (short)(2 - (float)ai_living_count(temple_ent_ghosts)));
            await sleep_until(async () => volume_test_objects(vol_tunnel_02, players()) == true, 30, (int)random_range(30, 90));
            if (volume_test_objects(vol_tunnel_02, players()) == false)
            {
                ai_place(tunnel_ghosts_011.Squad, (short)(2 - (float)ai_living_count(temple_ent_ghosts)));
            }

            await sleep_until(async () => volume_test_objects(vol_tunnel_02, players()) == true);
            game_save();
            if ((short)ai_living_count(tunnel_enemies_all) < 6)
            {
                ai_place(tunnel_jackals.Squad, 2);
            }

            if ((short)ai_living_count(tunnel_enemies_all) < 6)
            {
                ai_place(tunnel_heavies_02.Squad, 2);
            }

            cs_run_command_script(tunnel_heavies_02._2, new ScriptMethodReference(tunnel_turret_2));
            cs_run_command_script(tunnel_heavies_02._3, new ScriptMethodReference(tunnel_turret_3));
            ai_migrate(temple_ent_ghosts, tunnel_ghosts_021.Squad);
            ai_migrate(tunnel_ghosts_011.Squad, tunnel_ghosts_021.Squad);
            ai_place(tunnel_ghosts_021.Squad, (short)(2 - (float)ai_living_count(tunnel_ghosts)));
            await sleep_until(async () => volume_test_objects(vol_tunnel_03, players()) == true, 30, (int)random_range(30, 90));
            if (volume_test_objects(vol_tunnel_02, players()) == false)
            {
                ai_place(tunnel_ghosts_021.Squad, (short)(2 - (float)ai_living_count(tunnel_ghosts)));
            }

            await sleep_until(async () => volume_test_objects(vol_tunnel_03, players()) == true || (short)ai_living_count(tunnel_ghosts) < 1 && (short)ai_living_count(tunnel_infantry) < 1);
            game_save();
            await sleep_until(async () => ai_scene("old_temple_scene", new ScriptMethodReference(old_temple_structure_comment), all_allies) || (short)ai_living_count(all_allies) < 1, 30, 150);
            await sleep(30);
            if (this.structure_comment_go == false)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'careful, we're coming-up on another structure!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2060"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task arbiter_envy()
        {
            await sleep_until(async () => volume_test_objects(vol_arbiter_envy, players()) == true);
            object_create(envy);
            ai_place(envy_elites.Squad);
            ai_set_active_camo(envy_elites.Squad, true);
            cs_run_command_script(envy_elites.Squad, new ScriptMethodReference(forever_pause));
            custom_animation_loop(unit(list_get(ai_actors(envy_elites.Squad), 0)), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4194441168U), "combat:rifle:berserk", true);
            custom_animation_loop(unit(list_get(ai_actors(envy_elites.Squad), 1)), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4194441168U), "combat:rifle:berserk", true);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4162655741U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4162655741U)));
            ice_cream_flavor_stock(0);
        }

        [ScriptMethod(288, Lifecycle.CommandScript)]
        public async Task old_temple_pelican_comment()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'got a pelican coming in!'");
            cs_play_line("0620");
            await sleep(30);
            print("ally: 'let's clear an lz!'");
            cs_play_line("0630");
            this.old_temple_pel_comment_go = true;
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task old_temple_pelican_timer()
        {
            await sleep(8000);
            object_destroy(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot));
        }

        [ScriptMethod(290, Lifecycle.CommandScript)]
        public async Task old_temple_pelican_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/pel0"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/pel1"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/pel2"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/pel3"), 10F);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/pel4"), 5F);
            this.old_temple_bombs_away = true;
            cs_fly_to_and_face(GetReference<ISpatialPoint>("old_temple_airspace/pel4"), GetReference<ISpatialPoint>("old_temple_airspace/p0"), 1F);
            ai_place(allies_old_temple_pelican.Squad, (short)(4 - (float)ai_living_count(all_allies)));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_p", ai_actors(allies_old_temple_pelican.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), true);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/pel5"), 1F);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_p");
            await sleep_until(async () => volume_test_objects(vol_old_temple_center_01, players()) == true || volume_test_objects(vol_old_temple_center_03, players()) == true || volume_test_objects(vol_old_temple_center_05, players()) == true);
            await sleep(90);
            wake(new ScriptMethodReference(old_temple_pelican_timer));
            cs_vehicle_speed(1F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/pel4"), 2F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/pel3"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/pel2"), 5F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/pel1"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/pel0"), 20F);
            ai_erase(old_temple_pelican1.Squad);
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task old_temple_pelican()
        {
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 5)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 5), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 5));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 4)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 4), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 4));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 3)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 3), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 3));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 2), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 2));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 1), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 1));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 0), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 0));
            }

            await sleep(5);
            await sleep_until(async () => (short)ai_living_count(old_temple_phantom1.Squad) < 1);
            ai_place(old_temple_pelican1.Squad);
            object_cannot_take_damage(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot));
            object_create_anew(rack);
            objects_attach(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_sc_01", rack.Entity, "pin");
            object_create_anew(bomb01);
            objects_attach(rack.Entity, "rack01", bomb01.Entity, "pin");
            object_create_anew(bomb02);
            objects_attach(rack.Entity, "rack02", bomb02.Entity, "pin");
            object_create_anew(bomb03);
            objects_attach(rack.Entity, "rack03", bomb03.Entity, "pin");
            object_create_anew(bomb04);
            objects_attach(rack.Entity, "rack04", bomb04.Entity, "pin");
            object_create_anew(bomb05);
            objects_attach(rack.Entity, "rack05", bomb05.Entity, "pin");
            object_create_anew(bomb06);
            objects_attach(rack.Entity, "rack06", bomb06.Entity, "pin");
            cs_run_command_script(old_temple_pelican1.pilot, new ScriptMethodReference(old_temple_pelican_arrives));
            await sleep_until(async () => this.old_temple_bombs_away == true);
            begin_random(async () => objects_detach(rack.Entity, bomb01.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb02.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb03.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb04.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb05.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb06.Entity), 
                async () => await sleep((short)random_range(10, 30)));
        }

        [ScriptMethod(292, Lifecycle.Static)]
        public async Task short_old_temple_pel()
        {
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 5)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 5), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 5));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 4)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 4), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 4));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 3)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 3), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 3));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 2), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 2));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 1), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 1));
            }

            await sleep(5);
            if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 50F && objects_can_see_object(players(), list_get(ai_actors(all_allies), 0), 45F) == false)
            {
                object_destroy(list_get(ai_actors(all_allies), 0));
            }

            await sleep(5);
            ai_place(allies_old_temple_pelican.Squad, 4);
            ai_place(old_temple_pelican1.Squad);
            object_cannot_take_damage(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_p", ai_actors(allies_old_temple_pelican.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), true);
            object_create_anew(rack);
            objects_attach(ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_sc_01", rack.Entity, "pin");
            object_create_anew(bomb01);
            objects_attach(rack.Entity, "rack01", bomb01.Entity, "pin");
            object_create_anew(bomb02);
            objects_attach(rack.Entity, "rack02", bomb02.Entity, "pin");
            object_create_anew(bomb03);
            objects_attach(rack.Entity, "rack03", bomb03.Entity, "pin");
            object_create_anew(bomb04);
            objects_attach(rack.Entity, "rack04", bomb04.Entity, "pin");
            object_create_anew(bomb05);
            objects_attach(rack.Entity, "rack05", bomb05.Entity, "pin");
            object_create_anew(bomb06);
            objects_attach(rack.Entity, "rack06", bomb06.Entity, "pin");
            cs_run_command_script(old_temple_pelican1.pilot, new ScriptMethodReference(old_temple_pelican_arrives));
            await sleep_until(async () => this.old_temple_bombs_away == true);
            begin_random(async () => objects_detach(rack.Entity, bomb01.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb02.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb03.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb04.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb05.Entity), 
                async () => await sleep((short)random_range(10, 30)), 
                async () => objects_detach(rack.Entity, bomb06.Entity), 
                async () => await sleep((short)random_range(10, 30)));
        }

        [ScriptMethod(293, Lifecycle.CommandScript)]
        public async Task old_temple_ph_01_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph3a"), 3F);
            cs_vehicle_speed(0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph3a"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph4a"), 1F);
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), "phantom_lc");
            await sleep_until(async () => (short)ai_living_count(old_temple_phantom1.Squad) < 2, 30, 900);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("old_temple_airspace/ph3a"), GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 1F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            ai_erase(old_temple_phantom1.Squad);
        }

        [ScriptMethod(294, Lifecycle.CommandScript)]
        public async Task old_temple_ph_02_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph3b"), 3F);
            cs_vehicle_speed(0.5F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("old_temple_airspace/ph3b"), GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 1F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph4b"), 1F);
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), "phantom_lc");
            await sleep_until(async () => (short)ai_living_count(old_temple_phantom1.Squad) < 2, 30, 900);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph3b"), 1F);
            cs_vehicle_speed(1F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 1F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            ai_erase(old_temple_phantom1.Squad);
        }

        [ScriptMethod(295, Lifecycle.CommandScript)]
        public async Task old_temple_ph_04_arrives()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph3c"), 5F);
            cs_vehicle_speed(0.5F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("old_temple_airspace/ph3c"), GetReference<ISpatialPoint>("old_temple_airspace/p2"), 1F);
            cs_vehicle_speed(1F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph4c"), 1F);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), true);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a03");
            ai_set_orders(old_temple_court_grunts_03.Squad, old_temple_courtyard_03);
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b03");
            ai_set_orders(old_temple_court_jackals_03.Squad, old_temple_courtyard_03);
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c01");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c02");
            await sleep(15);
            vehicle_unload(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c03");
            ai_set_orders(old_temple_court_jackals_04.Squad, old_temple_courtyard_04);
            await sleep_until(async () => (short)ai_living_count(old_temp_court_phantom.Squad) < 2, 30, 900);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), false);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/ph3c"), 1F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            ai_erase(old_temple_phantom1.Squad);
        }

        [ScriptMethod(296, Lifecycle.CommandScript)]
        public async Task old_temple_abort()
        {
            cs_enable_pathfinding_failsafe(true);
            if (volume_test_objects(vol_old_temple_airspace_low, ai_actors(old_temple_phantom1.Squad)) == true)
            {
                cs_enable_moving(true);
                cs_enable_looking(true);
                await sleep_until(async () => volume_test_objects(vol_old_temple_airspace_high, ai_actors(old_temple_phantom1.Squad)) == true);
            }

            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            cs_fly_to(GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            ai_erase(old_temple_phantom1.Squad);
        }

        [ScriptMethod(297, Lifecycle.Static)]
        public async Task old_temple_phantom_01()
        {
            await sleep_until(async () => (short)ai_living_count(old_temple_pelican1.Squad) < 1);
            ai_place(old_temple_phantom1.Squad);
            ai_place(old_temple_ghosts_air.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(old_temple_ghosts_air._1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(old_temple_ghosts_air._2));
            await sleep(60);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), true);
            cs_run_command_script(old_temple_phantom1.pilot, new ScriptMethodReference(old_temple_ph_01_arrives));
            await sleep_until(async () => (short)ai_living_count(old_temple_phantom1.Squad) < 1 || (short)ai_living_count(old_temple_ghosts_air.Squad) < 1);
            if ((short)ai_living_count(old_temple_ghosts_air.Squad) < 1)
            {
                cs_run_command_script(old_temple_phantom1.Squad, new ScriptMethodReference(old_temple_abort));
            }

            await sleep_until(async () => (short)ai_living_count(old_temple_phantom1.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot));
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task old_temple_phantom_02()
        {
            await sleep_until(async () => (short)ai_living_count(old_temple_pelican1.Squad) < 1);
            ai_place(old_temple_phantom1.Squad);
            ai_place(old_temple_ghosts_air.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(old_temple_ghosts_air._1));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), "phantom_lc", ai_vehicle_get_from_starting_location(old_temple_ghosts_air._2));
            await sleep(60);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot), true);
            cs_run_command_script(old_temple_phantom1.pilot, new ScriptMethodReference(old_temple_ph_02_arrives));
            await sleep_until(async () => (short)ai_living_count(old_temple_phantom1.Squad) < 1 || (short)ai_living_count(old_temple_ghosts_air.Squad) < 1);
            if ((short)ai_living_count(old_temple_ghosts_air.Squad) < 1)
            {
                cs_run_command_script(old_temple_phantom1.Squad, new ScriptMethodReference(old_temple_abort));
            }

            await sleep_until(async () => (short)ai_living_count(old_temple_phantom1.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(old_temple_phantom1.pilot));
        }

        [ScriptMethod(299, Lifecycle.Dormant)]
        public async Task old_temple_phantom_04()
        {
            await sleep_until(async () => (short)ai_living_count(old_temple_pelican1.Squad) < 1);
            ai_place(old_temple_court_jackals_03.Squad, 2);
            ai_place(old_temple_court_grunts_03.Squad, 3);
            ai_place(old_temple_court_jackals_04.Squad, 3);
            ai_place(old_temp_court_phantom.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c", ai_actors(old_temple_court_jackals_04.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a", ai_actors(old_temple_court_grunts_03.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b", ai_actors(old_temple_court_jackals_03.Squad));
            await sleep(60);
            cs_run_command_script(old_temp_court_phantom.pilot, new ScriptMethodReference(old_temple_ph_04_arrives));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), true);
            await sleep_until(async () => (short)ai_living_count(old_temp_court_phantom.Squad) < 1, 30, 8000);
            object_destroy(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot));
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task short_old_temple_phantom()
        {
            ai_allegiance(covenant, prophet);
            ai_place(old_temple_court_jackals_03.Squad, 2);
            ai_place(old_temple_court_grunts_03.Squad, 3);
            ai_place(old_temple_court_jackals_04.Squad, 3);
            ai_place(old_temp_court_phantom.Squad);
            await sleep(60);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c", ai_actors(old_temple_court_jackals_04.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a", ai_actors(old_temple_court_grunts_03.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b", ai_actors(old_temple_court_jackals_03.Squad));
            await sleep(60);
            cs_run_command_script(old_temp_court_phantom.pilot, new ScriptMethodReference(old_temple_ph_04_arrives));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), true);
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task old_temple_vehicle_spawn()
        {
            ai_place(old_temple_ghosts_far.Squad);
            if (await this.difficulty_heroic())
            {
                this.old_temple_veh_total = 3;
            }

            if (await this.difficulty_legendary())
            {
                this.old_temple_veh_total = 4;
            }

            await sleep_until(async () => (short)ai_living_count(old_temple_ghosts_far.Squad) > 0, 30, 600);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(old_temple_vehicles) < 1 || volume_test_objects(vol_old_temple_debris, players()) == true);
                game_save();
                if (volume_test_objects(vol_old_temple_debris, players()) == true)
                {
                    sleep_forever();
                }

                if (volume_test_objects(vol_old_temple_debris, players()) == false)
                {
                    ai_place(old_temple_ghosts_far.Squad, 1);
                }

                await sleep_until(async () => volume_test_objects(vol_old_temple_debris, players()) == true, 30, (int)random_range(30, 120));
                if (volume_test_objects(vol_old_temple_debris, players()) == true)
                {
                    sleep_forever();
                }

                if (volume_test_objects(vol_old_temple_debris, players()) == false)
                {
                    ai_place(old_temple_ghosts_far.Squad, 1);
                }

                this.old_temple_veh_total = (short)(this.old_temple_veh_total - 1);
                return await this.difficulty_normal() && this.old_temple_veh_total < 2 || await this.difficulty_heroic() && this.old_temple_veh_total < 2 || await this.difficulty_legendary() && this.old_temple_veh_total < 3 || volume_test_objects(vol_old_temple_debris, players()) == true;
            });
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_living_count(old_temple_vehicles) < 1 || volume_test_objects(vol_old_temple_debris, players()) == true);
                game_save();
                if (volume_test_objects(vol_old_temple_debris, players()) == true)
                {
                    sleep_forever();
                }

                if (volume_test_objects(vol_old_temple_debris, players()) == false)
                {
                    ai_place(old_temple_ghosts_far.Squad, 1);
                    ai_set_orders(old_temple_ghosts_far.Squad, old_temple_vehicles_ltd);
                }

                await sleep_until(async () => volume_test_objects(vol_old_temple_debris, players()) == true, 30, (int)random_range(30, 120));
                if (volume_test_objects(vol_old_temple_debris, players()) == true)
                {
                    sleep_forever();
                }

                if (volume_test_objects(vol_old_temple_debris, players()) == false)
                {
                    ai_place(old_temple_ghosts_far.Squad, 1);
                    ai_set_orders(old_temple_ghosts_far.Squad, old_temple_vehicles_ltd);
                }

                this.old_temple_veh_total = (short)(this.old_temple_veh_total - 1);
                return this.old_temple_veh_total <= 0 || volume_test_objects(vol_old_temple_debris, players()) == true;
            });
            await sleep_until(async () => (short)ai_living_count(old_temple_vehicles) < 1);
            this.old_temple_ghosts_over = true;
        }

        [ScriptMethod(302, Lifecycle.Dormant)]
        public async Task old_temple_near_right()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_near_right, players()) == true && volume_test_objects(vol_old_temple_int_01, players()) == false && volume_test_objects(vol_old_temple_int_02, players()) == false && await this.player_count() > 0);
            game_save();
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_elites_near_right.Squad, 1);
            }

            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_jackals_near_right.Squad, (short)(2 - (float)ai_living_count(old_temple_peri_jackals)));
            }
        }

        [ScriptMethod(303, Lifecycle.Dormant)]
        public async Task old_temple_far_left()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_far_left, players()) == true && volume_test_objects(vol_old_temple_int_01, players()) == false && volume_test_objects(vol_old_temple_int_02, players()) == false && await this.player_count() > 0);
            game_save();
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_grunts_far_left.Squad, (short)(3 - (float)ai_living_count(old_temple_peri_grunts)));
            }
        }

        [ScriptMethod(304, Lifecycle.Dormant)]
        public async Task old_temple_far_right()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_far_right, players()) == true && volume_test_objects(vol_old_temple_int_01, players()) == false && volume_test_objects(vol_old_temple_int_02, players()) == false && await this.player_count() > 0);
            game_save();
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_grunts_far_right.Squad, (short)(3 - (float)ai_living_count(old_temple_peri_grunts)));
            }
        }

        [ScriptMethod(305, Lifecycle.Dormant)]
        public async Task old_temple_below()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_below, players()) == true && volume_test_objects(vol_old_temple_int_01, players()) == false && volume_test_objects(vol_old_temple_int_02, players()) == false && await this.player_count() > 0);
            game_save();
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_jackals_below_far.Squad, (short)((float)random_range(2, 5) - (float)ai_living_count(old_temple_peri_jackals)));
            }

            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_jackals_below_near.Squad, (short)((float)random_range(2, 5) - (float)ai_living_count(old_temple_peri_jackals)));
            }
        }

        [ScriptMethod(306, Lifecycle.CommandScript)]
        public async Task old_temp_reman_fr()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_go_to(GetReference<ISpatialPoint>("old_temple/far_r"));
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(old_temple_turrets.far_r));
            cs_enable_targeting(true);
            cs_shoot(true);
            sleep_forever();
        }

        [ScriptMethod(307, Lifecycle.CommandScript)]
        public async Task old_temp_reman_fl()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_go_to(GetReference<ISpatialPoint>("old_temple/far_l"));
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(old_temple_turrets.far_l));
            cs_enable_targeting(true);
            cs_shoot(true);
            sleep_forever();
        }

        [ScriptMethod(308, Lifecycle.CommandScript)]
        public async Task old_temp_reman_nl()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_go_to(GetReference<ISpatialPoint>("old_temple/near_l"));
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(old_temple_turrets.near_l));
            cs_enable_targeting(true);
            cs_shoot(true);
            sleep_forever();
        }

        [ScriptMethod(309, Lifecycle.CommandScript)]
        public async Task old_temp_reman_cen()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_go_to(GetReference<ISpatialPoint>("old_temple/center"));
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(old_temple_turrets.center));
            cs_enable_targeting(true);
            cs_shoot(true);
            sleep_forever();
        }

        [ScriptMethod(310, Lifecycle.Dormant)]
        public async Task old_temple_turret_reman()
        {
            await sleep_until(async () =>
            {
                if (object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) > 0F && volume_test_objects(vol_old_temple_farwall_all, players()) == false && await this.player_count() > 0 && (short)ai_spawn_count(old_temple_grunts_far_right.Squad) < 5 && (short)ai_living_count(old_temple_grunts_far_right.Squad) < 1 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(old_temple_turrets.far_r), "", ai_actors(old_temple_turrets.Squad)) == false && objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) < 20F)
                {
                    ai_place(old_temple_grunts_far_right._1);
                    cs_run_command_script(old_temple_grunts_far_right._1, new ScriptMethodReference(old_temp_reman_fr));
                }

                if (object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) > 0F && volume_test_objects(vol_old_temple_seawall_all, players()) == false && await this.player_count() > 0 && (short)ai_spawn_count(old_temple_grunts_far_left.Squad) < 5 && (short)ai_living_count(old_temple_grunts_far_left.Squad) < 1 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(old_temple_turrets.far_l), "", ai_actors(old_temple_turrets.Squad)) == false && objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) < 20F)
                {
                    ai_place(old_temple_grunts_far_left._1);
                    cs_run_command_script(old_temple_grunts_far_left._1, new ScriptMethodReference(old_temp_reman_fl));
                }

                if (object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) > 0F && volume_test_objects(vol_old_temple_seawall_all, players()) == false && await this.player_count() > 0 && (short)ai_spawn_count(old_temple_grunts_near_left.Squad) < 5 && (short)ai_living_count(old_temple_grunts_near_left.Squad) < 1 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(old_temple_turrets.near_l), "", ai_actors(old_temple_turrets.Squad)) == false && objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) < 20F)
                {
                    ai_place(old_temple_grunts_near_left._1);
                    cs_run_command_script(old_temple_grunts_near_left._1, new ScriptMethodReference(old_temp_reman_nl));
                }

                if (object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.center)) > 0F && volume_test_objects(vol_old_temple_see_nook, players()) == false && await this.player_count() > 0 && (short)ai_spawn_count(old_temple_grunts_center.Squad) < 5 && (short)ai_living_count(old_temple_grunts_center.Squad) < 1 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(old_temple_turrets.center), "", ai_actors(old_temple_turrets.Squad)) == false && objects_distance_to_object(players(), ai_vehicle_get_from_starting_location(old_temple_turrets.center)) < 20F)
                {
                    ai_place(old_temple_grunts_center._1);
                    cs_run_command_script(old_temple_grunts_center._1, new ScriptMethodReference(old_temp_reman_cen));
                }

                return volume_test_objects(vol_old_temple_center_01, await this.player0()) == true || volume_test_objects(vol_old_temple_center_03, await this.player0()) == true || volume_test_objects(vol_old_temple_center_05, await this.player0()) == true || object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.center)) <= 0F;
            });
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task old_temple_perimeter_nuke()
        {
            await sleep_until(async () =>
            {
                if (objects_can_see_object(players(), list_get(ai_actors(old_temple_peri_grunts), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(old_temple_peri_grunts), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(old_temple_peri_grunts), 0));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(old_temple_peri_jackals), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(old_temple_peri_jackals), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(old_temple_peri_jackals), 0));
                }

                await sleep(5);
                return (short)ai_living_count(old_temple_peri_grunts) < 1 && (short)ai_living_count(old_temple_peri_jackals) < 1;
            });
            print("all gone");
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task nuke()
        {
            await sleep_until(async () =>
            {
                if (objects_can_see_object(players(), list_get(ai_actors(old_temple_peri_grunts), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(old_temple_peri_grunts), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(old_temple_peri_grunts), 0));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(old_temple_peri_jackals), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(old_temple_peri_jackals), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(old_temple_peri_jackals), 0));
                }

                await sleep(5);
                return (short)ai_living_count(old_temple_peri_grunts) < 1 && (short)ai_living_count(old_temple_peri_jackals) < 1;
            });
            print("all gone");
        }

        [ScriptMethod(313, Lifecycle.CommandScript)]
        public async Task old_temple_middle_comment()
        {
            this.old_temp_middle_go = true;
            cs_switch("ally");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("ally: 'they're all pouring-out of the middle! let's get in there!'");
            cs_play_line("0610");
        }

        [ScriptMethod(314, Lifecycle.Dormant)]
        public async Task old_temple_middle_ally()
        {
            await sleep_until(async () => (short)ai_living_count(all_allies) < 1 || ai_scene("old_temple_mid_scene", new ScriptMethodReference(old_temple_middle_comment), all_allies), 30, 300);
            await sleep(30);
            if (this.old_temp_middle_go == false && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'they're all pouring-out of the middle! let's get in there!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2070"));
                await sleep(30);
                ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }
        }

        [ScriptMethod(315, Lifecycle.Dormant)]
        public async Task old_temple_center()
        {
            await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && volume_test_objects(vol_old_temple_center_01, await this.player0()) == true || volume_test_objects(vol_old_temple_center_03, await this.player0()) == true || volume_test_objects(vol_old_temple_center_05, await this.player0()) == true || unit_in_vehicle(await this.player1()) == false && volume_test_objects(vol_old_temple_center_01, await this.player1()) == true || volume_test_objects(vol_old_temple_center_03, await this.player1()) == true || volume_test_objects(vol_old_temple_center_05, await this.player1()) == true);
            ai_disposable(old_temple_peri_grunts, true);
            ai_disposable(old_temple_peri_jackals, true);
            game_save();
            sleep_forever(new ScriptMethodReference(old_temple_near_right));
            sleep_forever(new ScriptMethodReference(old_temple_far_left));
            sleep_forever(new ScriptMethodReference(old_temple_far_right));
            sleep_forever(new ScriptMethodReference(old_temple_vehicle_spawn));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_tank1.driver), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            cs_run_command_script(old_temple_phantom1.Squad, new ScriptMethodReference(old_temple_abort));
            wake(new ScriptMethodReference(old_temple_perimeter_nuke));
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_center_elites_01.Squad, (short)(2 - (float)ai_living_count(old_temp_center_tough)));
            }

            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_center_grunts_01.Squad, (short)(3 - (float)ai_living_count(old_temp_center_fodder)));
            }

            wake(new ScriptMethodReference(old_temple_middle_ally));
            await sleep_until(async () => volume_test_objects(vol_old_temple_center_03, players()) == true || volume_test_objects(vol_old_temple_center_05, players()) == true || (short)ai_living_count(old_temple_center_all) < 3);
            game_save();
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_center_grunts_03.Squad, (short)(3 - (float)ai_living_count(old_temp_center_fodder)));
            }

            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_center_jackals_04.Squad, (short)(2 - (float)ai_living_count(old_temp_center_tough)));
            }

            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_center_grunts_04.Squad, (short)(6 - (float)ai_living_count(old_temp_center_fodder)));
            }

            await sleep_until(async () => volume_test_objects(vol_old_temple_center_05, players()) == true || (short)ai_living_count(old_temple_center_all) < 3);
            game_save();
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_center_elites_05.Squad, (short)(2 - (float)ai_living_count(old_temp_center_tough)));
            }

            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_center_jackals_05.Squad, (short)(4 - (float)ai_living_count(old_temp_center_tough)));
            }

            await sleep_until(async () =>
            {
                if ((short)ai_living_count(old_temple_center_all) < 2 && volume_test_objects(vol_old_temple_court_01, players()) == false && await this.player_count() > 0)
                {
                    ai_place(old_temple_courtyard_lure.Squad, 1);
                }

                await sleep_until(async () => volume_test_objects(vol_old_temple_close_nuff, players()) == true || (short)ai_living_count(old_temple_center_all) < 2 || (short)ai_spawn_count(old_temple_courtyard_lure.Squad) > 3, 30, 210);
                return volume_test_objects(vol_old_temple_close_nuff, players()) == true || (short)ai_spawn_count(old_temple_courtyard_lure.Squad) > 3;
            });
            game_save();
            await sleep_until(async () => (short)ai_living_count(old_temple_center_all) < 1, 30, 3600);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", old_temple_center_all) == true, 30, 3600);
            game_save();
        }

        [ScriptMethod(316, Lifecycle.Dormant)]
        public async Task old_temple_playfight()
        {
            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_playfight_e.Squad, 2);
            }

            if ((short)ai_living_count(old_temple_enemies) < 8)
            {
                ai_place(old_temple_playfight_g.Squad, 3);
            }

            await sleep_until(async () =>
            {
                if ((short)ai_living_count(old_temple_playfight_g.Squad) < 3)
                {
                    ai_place(old_temple_playfight_g.Squad, 1);
                }

                return volume_test_objects(vol_old_temple_center_01, players()) == true || volume_test_objects(vol_old_temple_center_03, players()) == true;
            });
            ai_set_orders(allies_old_temple_pelican.Squad, old_temple_center_allies_01);
        }

        [ScriptMethod(317, Lifecycle.Dormant)]
        public async Task old_temple_debris_comment()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_debris, players()) == true && this.old_temple_chatter == false);
            this.old_temple_chatter = true;
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'looks like a landslide has blocked the main passage.'");
            print("'we'll have to find an alternate route.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0670"));
            await sleep(30);
            ai_dialogue_enable(true);
            this.old_temple_chatter = false;
        }

        [ScriptMethod(318, Lifecycle.Dormant)]
        public async Task old_temple_middle_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_in_court, players()) == true, 30, 8000);
            if (volume_test_objects(vol_old_temple_in_court, players()) == false && await this.player_count() > 0 && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'the covenant holed-up in the middle of this structure.'");
                print("'we need to clear them out.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0650"));
                await sleep(30);
                ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }

            await sleep_until(async () => volume_test_objects(vol_old_temple_in_court, players()) == true, 30, 8000);
            if (volume_test_objects(vol_old_temple_in_court, players()) == false && await this.player_count() > 0)
            {
                activate_team_nav_point_flag(_default, player, old_temple_exit, 0F);
                await sleep_until(async () => volume_test_objects(vol_old_temple_in_court, players()) == true);
                deactivate_team_nav_point_flag(player, old_temple_exit);
            }
        }

        [ScriptMethod(319, Lifecycle.Dormant)]
        public async Task old_temple_start()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_start, players()) == true);
            ai_disposable(tunnel_enemies_all, true);
            data_mine_set_mission_segment("05a_7_old_temple");
            wake(new ScriptMethodReference(music_05a_04_stop));
            game_save();
            ai_place(old_temple_init_jackals_nl.Squad, 2);
            await sleep(2);
            ai_place(old_temple_turrets.center);
            cs_run_command_script(old_temple_turrets.Squad, new ScriptMethodReference(stay_shooting));
            await sleep(2);
            ai_place(old_temple_turrets.near_l);
            cs_run_command_script(old_temple_turrets.Squad, new ScriptMethodReference(stay_shooting));
            await sleep(2);
            ai_place(old_temple_turrets.far_l);
            cs_run_command_script(old_temple_turrets.Squad, new ScriptMethodReference(stay_shooting));
            await sleep(2);
            ai_place(old_temple_turrets.far_r);
            cs_run_command_script(old_temple_turrets.Squad, new ScriptMethodReference(stay_shooting));
            wake(new ScriptMethodReference(old_temple_near_right));
            wake(new ScriptMethodReference(old_temple_far_left));
            wake(new ScriptMethodReference(old_temple_far_right));
            wake(new ScriptMethodReference(old_temple_below));
            wake(new ScriptMethodReference(old_temple_center));
            wake(new ScriptMethodReference(old_temple_vehicle_spawn));
            wake(new ScriptMethodReference(old_temple_middle_reminder));
            wake(new ScriptMethodReference(old_temple_turret_reman));
            if (await this.difficulty_legendary())
            {
                wake(new ScriptMethodReference(arbiter_envy));
            }

            await sleep_until(async () => volume_test_objects(vol_old_temple_center_01, players()) == true || volume_test_objects(vol_old_temple_center_03, players()) == true || object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(old_temple_turrets.center)) <= 0F && this.old_temple_ghosts_over == true);
            game_save();
            wake(new ScriptMethodReference(old_temple_pelican));
            wake(new ScriptMethodReference(old_temple_playfight));
            await sleep_until(async () => ai_scene("old_temple_pel_scene", new ScriptMethodReference(old_temple_pelican_comment), all_allies) || (short)ai_living_count(all_allies) < 1, 30, 60);
            await sleep(300);
            if (this.old_temple_pel_comment_go == false && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'pelican inbound!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2080"));
                await sleep(15);
                print("cortana: 'let's clear a landing-zone!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "2090"));
                await sleep(30);
                ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }

            await sleep_until(async () => volume_test_objects(vol_old_temple_center_01, players()) == true || volume_test_objects(vol_old_temple_center_03, players()) == true || volume_test_objects(vol_old_temple_in_court, players()) == true, 30, 300);
            if (volume_test_objects(vol_old_temple_center_01, players()) == false && volume_test_objects(vol_old_temple_center_03, players()) == false && volume_test_objects(vol_old_temple_in_court, players()) == false && await this.player_count() > 0 && this.old_temple_bombs_away == false)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("johnson: 'clear out the riff-raff so i can set her down!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0640"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            game_save();
            await sleep_until(async () => (short)ai_living_count(old_temple_enemies) < 1, 30, 3600);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", old_temple_enemies) == true, 30, 3600);
            game_save();
        }

        [ScriptMethod(320, Lifecycle.Dormant)]
        public async Task old_temple_debris_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_through_debris, players()) == true, 30, 8000);
            if (volume_test_objects(vol_through_debris, players()) == false && await this.player_count() > 0 && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'there should be a way through this debris�'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0680"));
                await sleep(30);
                ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }

            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true, 30, 4000);
            if (volume_test_objects(vol_grotto, players()) == false && await this.player_count() > 0)
            {
                activate_team_nav_point_flag(_default, player, courtyard_exit, 0F);
                await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
                deactivate_team_nav_point_flag(player, courtyard_exit);
            }
        }

        [ScriptMethod(321, Lifecycle.Dormant)]
        public async Task old_temple_holo_translate()
        {
            await sleep_until(async () => (short)ai_living_count(old_temple_court_all) < 1);
            await sleep(300);
            this.court_holo_trans = true;
            await sleep_until(async () => volume_test_objects(vol_old_temple_court_04, players()) == true && objects_can_see_object(players(), regret02.Entity, 30F) == true && this.court_holo_chant == false);
            ai_dialogue_enable(false);
            await sleep(60);
            custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_l05_0110_por", true);
            print("'in a gesture of peace and reconciliation, the prophets promised to find the means...'");
            print("'...of the forerunners' transcendence, and to share this knowledge with the elites.'");
            await sleep(ai_play_line_on_object(regret02.Entity, "0110"));
            await sleep(30);
            custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_l05_0120_por", true);
            print("'the elites promised to defend the prophets as they searched - '");
            print("'a simple arrangement that has become our binding covenant!'");
            await sleep(ai_play_line_on_object(regret02.Entity, "0120"));
            await sleep(60);
            if (this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                print("cortana: 'transcendence, huh? more like mass-suicide.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0660"));
                this.old_temple_chatter = false;
            }

            await sleep(30);
            ai_dialogue_enable(true);
            await sleep((short)random_range(240, 480));
            this.court_holo_trans = false;
        }

        [ScriptMethod(322, Lifecycle.Dormant)]
        public async Task courtyard_holo_looper()
        {
            object_create(regret02);
            objects_attach(court_throne_attach.Entity, "", court_throne.Entity, "driver");
            objects_attach(court_throne.Entity, "driver", regret02.Entity, "");
            ai_disregard(regret02.Entity, true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant1a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3000"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2b", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3001"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2c", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3002"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3003"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3c", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3004"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant5a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3005"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant6a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3006"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(323, Lifecycle.Static)]
        public async Task court_holo_looper()
        {
            object_create(regret02);
            objects_attach(court_throne_attach.Entity, "", court_throne.Entity, "driver");
            objects_attach(court_throne.Entity, "driver", regret02.Entity, "");
            ai_disregard(regret02.Entity, true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant1a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3000"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2b", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3001"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2c", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3002"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3003"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3c", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3004"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant5a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3005"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant6a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3006"));
                        await sleep((short)random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(324, Lifecycle.Dormant)]
        public async Task old_temple_archaeologist()
        {
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", all_enemies) == true);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", all_enemies) == true || volume_test_objects(vol_through_debris, players()) == true);
            await sleep_until(async () => volume_test_objects(vol_through_debris, players()) == true, 30, 300);
            if (volume_test_objects(vol_through_debris, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'what happened to this place? the stones�'");
                print("'this isn't normal wear and tear. it almost looks like battle-scarring�'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0590"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(325, Lifecycle.Dormant)]
        public async Task old_temple_courtyard()
        {
            await sleep_until(async () => volume_test_objects(vol_old_temple_court_01, players()) == true || volume_test_objects(vol_old_temple_in_court, players()) == true);
            ai_disposable(old_temple_center_all, true);
            data_mine_set_mission_segment("05a_8_old_temple_courtyard");
            wake(new ScriptMethodReference(courtyard_holo_looper));
            game_save();
            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_elites_01.Squad, 2);
            }

            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_grunts_01.Squad, 3);
            }

            await sleep_until(async () => (short)ai_living_count(old_temple_court_all) < 3 || volume_test_objects(vol_old_temple_court_02, players()) == true);
            game_save();
            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_grunts_02.Squad, (short)(4 - (float)ai_living_count(old_temple_court_grunts_01.Squad)));
            }

            await sleep_until(async () => (short)ai_living_count(old_temple_court_all) < 3 || volume_test_objects(vol_old_temple_court_04, players()) == true);
            game_save();
            wake(new ScriptMethodReference(old_temple_holo_translate));
            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_jackals_03.Squad, (short)(2 - (float)ai_living_count(old_temple_court_elites_01.Squad)));
            }

            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_grunts_03.Squad, (short)(3 - (float)ai_living_count(old_temple_court_grunts_01.Squad) + (float)ai_living_count(old_temple_court_grunts_02.Squad)));
            }

            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_jackals_04.Squad, 2);
            }

            await sleep_until(async () => (short)ai_living_count(old_temple_court_all) < 3 || volume_test_objects(vol_old_temple_court_05, players()) == true);
            game_save();
            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_elites_05.Squad, 2);
            }

            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_jackals_05.Squad, 2);
            }

            wake(new ScriptMethodReference(old_temple_debris_reminder));
            await sleep_until(async () => volume_test_objects(vol_old_temple_court_06, players()) == true);
            game_save();
            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_jackals_06.Squad, 2);
            }

            if ((short)ai_living_count(old_temple_court_all) < 8)
            {
                ai_place(old_temple_court_grunts_06.Squad, 3);
            }

            await sleep_until(async () => (short)ai_living_count(old_temple_court_all) < 1, 30, 4000);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", old_temple_court_all) == true, 30, 3600);
            game_save();
        }

        [ScriptMethod(326, Lifecycle.Dormant)]
        public async Task grotto_cortana_comment()
        {
            await sleep_until(async () => volume_test_objects(vol_grotto_follow_01, players()) == true && objects_can_see_flag(players(), grotto_center, 30F) == true);
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'you always bring me to such nice places.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0690"));
            await sleep(30);
            wake(new ScriptMethodReference(music_05a_05_start));
            ai_dialogue_enable(true);
            await sleep_until(async () => (bool)game_safe_to_save());
            game_save();
        }

        [ScriptMethod(327, Lifecycle.CommandScript)]
        public async Task grotto_ally_cheese()
        {
            cs_switch("ally01");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("odst: 'my girl would dig this place. so beautiful�'");
            cs_play_line("0700");
            await sleep(30);
            cs_switch("ally02");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("odst: 'beautiful and dangerous, man.'");
            cs_play_line("0710");
            await sleep(30);
            cs_switch("ally01");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("odst: 'hey. that's why i love her.'");
            cs_play_line("0720");
        }

        [ScriptMethod(328, Lifecycle.Dormant)]
        public async Task grotto_ally_comments()
        {
            await sleep_until(async () => ai_scene("grotto_ally_cheese_scene", new ScriptMethodReference(grotto_ally_cheese), all_allies), 30, 450);
        }

        [ScriptMethod(329, Lifecycle.Dormant)]
        public async Task grotto_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_grotto_exit, players()) == true, 30, 8000);
            if (volume_test_objects(vol_grotto_exit, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'we're approaching another structure. it should be the...'");
                print("'...lake access-point we've been looking for�'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0750"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => volume_test_objects(vol_grotto_exit, players()) == true, 30, 4000);
            if (volume_test_objects(vol_grotto_exit, players()) == false && await this.player_count() > 0)
            {
                activate_team_nav_point_flag(_default, player, grotto_exit, 0F);
                await sleep_until(async () => volume_test_objects(vol_grotto_exit, players()) == true);
                deactivate_team_nav_point_flag(player, grotto_exit);
            }
        }

        [ScriptMethod(330, Lifecycle.Dormant)]
        public async Task grotto_pool()
        {
            await sleep_until(async () => (short)ai_living_count(grotto_init_01.Squad) < 1 || volume_test_objects(vol_grotto_first_pool_01, players()) == true || volume_test_objects(vol_grotto_mid_02, players()) == true || volume_test_objects(vol_grotto_mid_03, players()) == true);
            if (volume_test_objects(vol_grotto_mid_02, players()) == true || volume_test_objects(vol_grotto_mid_03, players()) == true)
            {
                sleep_forever();
            }

            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_crack_grunts.Squad, 2);
            }

            await sleep_until(async () => (short)ai_living_count(grotto_crack_grunts.Squad) < 2 || volume_test_objects(vol_grotto_first_pool_02, players()) == true || volume_test_objects(vol_grotto_mid_02, players()) == true || volume_test_objects(vol_grotto_mid_03, players()) == true);
            if (volume_test_objects(vol_grotto_mid_02, players()) == true || volume_test_objects(vol_grotto_mid_03, players()) == true)
            {
                sleep_forever();
            }

            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_buggers_new_01.Squad, (short)(4 - (float)ai_living_count(grotto_buggers)));
            }

            await sleep_until(async () => (short)ai_living_count(grotto_buggers_new_01.Squad) < 2 || volume_test_objects(vol_grotto_mid_02, players()) == true || volume_test_objects(vol_grotto_mid_03, players()) == true);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(grotto_pool_grunts.Squad) < 1)
                {
                    ai_place(grotto_pool_grunts.Squad, 1);
                }

                return volume_test_objects(vol_grotto_mid_02, players()) == true || volume_test_objects(vol_grotto_mid_03, players()) == true || (short)ai_spawn_count(grotto_pool_grunts.Squad) > 3;
            });
        }

        [ScriptMethod(331, Lifecycle.Dormant)]
        public async Task grotto_buggers_reinforce()
        {
            if ((short)ai_living_count(grotto_enemies) < 8 && await this.difficulty_legendary())
            {
                ai_place(grotto_buggers_01.Squad, (short)(4 - (float)ai_living_count(grotto_buggers)));
            }

            await sleep_until(async () => volume_test_objects(vol_grotto_mid_03, players()) == true);
            ai_migrate(grotto_buggers_01.Squad, grotto_buggers_02.Squad);
            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_buggers_02.Squad, (short)(4 - (float)ai_living_count(grotto_buggers)));
            }
        }

        [ScriptMethod(332, Lifecycle.Dormant)]
        public async Task grotto_extra_checkpoint()
        {
            await sleep(60);
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == false && await this.player_count() > 0);
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            game_save();
        }

        [ScriptMethod(333, Lifecycle.CommandScript)]
        public async Task grotto_entry_patrol()
        {
            cs_abort_on_alert(true);
            await sleep_until(async () =>
            {
                cs_go_to_and_face(GetReference<ISpatialPoint>("grotto/p0"), GetReference<ISpatialPoint>("grotto/p2"));
                cs_aim(true, GetReference<ISpatialPoint>("grotto/p2"));
                await sleep((short)random_range(30, 90));
                cs_aim(false, GetReference<ISpatialPoint>("grotto/p2"));
                cs_go_to_and_face(GetReference<ISpatialPoint>("grotto/p1"), GetReference<ISpatialPoint>("grotto/p2"));
                cs_aim(true, GetReference<ISpatialPoint>("grotto/p2"));
                await sleep((short)random_range(30, 90));
                cs_aim(false, GetReference<ISpatialPoint>("grotto/p2"));
                return false;
            });
        }

        [ScriptMethod(334, Lifecycle.Dormant)]
        public async Task grotto_start()
        {
            ai_disposable(old_temple_enemies, true);
            data_mine_set_mission_segment("05a_9_grotto");
            game_save();
            wake(new ScriptMethodReference(_05a_title2));
            ai_place(grotto_init_01.Squad, 1);
            ai_place(grotto_init_04.Squad, 1);
            ai_place(grotto_init_05.Squad, 1);
            ai_place(grotto_init_07.Squad, 1);
            ai_place(grotto_init_09.Squad, 1);
            cs_run_command_script(grotto_init_09.Squad, new ScriptMethodReference(grotto_entry_patrol));
            ai_place(grotto_init_11.Squad, 2);
            wake(new ScriptMethodReference(grotto_cortana_comment));
            wake(new ScriptMethodReference(grotto_pool));
            wake(new ScriptMethodReference(grotto_extra_checkpoint));
            await sleep_until(async () => volume_test_objects(vol_grotto_mid_02, players()) == true);
            game_save();
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                this.grotto_final_snipers = 2;
            }

            begin_random(async () =>
            {
                if (this.grotto_final_snipers > 0 && (short)ai_living_count(grotto_enemies) < 8)
                {
                    ai_place(grotto_cave_jackals_02.Squad, 1);
                    this.grotto_final_snipers = (short)(this.grotto_final_snipers - 1);
                }
            }, 
                async () =>
            {
                if (this.grotto_final_snipers > 0 && (short)ai_living_count(grotto_enemies) < 8)
                {
                    ai_place(grotto_cave_jackals_03.Squad, 1);
                    this.grotto_final_snipers = (short)(this.grotto_final_snipers - 1);
                }
            });
            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_cave_jackals_01.Squad, 1);
            }

            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_cave_elites.Squad, 1);
            }

            wake(new ScriptMethodReference(grotto_buggers_reinforce));
            await sleep_until(async () => volume_test_objects(vol_grotto_far_top, players()) == true);
            game_save();
            wake(new ScriptMethodReference(grotto_reminder));
            ai_migrate(grotto_buggers_02.Squad, grotto_buggers_03.Squad);
            if ((short)ai_living_count(grotto_enemies) < 8 && await this.difficulty_legendary())
            {
                ai_place(grotto_buggers_03.Squad, (short)(4 - (float)ai_living_count(grotto_buggers)));
            }

            ai_set_orders(grotto_buggers, grotto_follow_03);
            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_end_elites_01.Squad, 1);
            }

            await sleep(30);
            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_end_jackals_02.Squad, 2);
            }

            await sleep(30);
            if ((short)ai_living_count(grotto_enemies) < 8)
            {
                ai_place(grotto_end_elites_02.Squad, 1);
            }

            await sleep_until(async () => volume_test_objects(vol_grotto_end, players()) == true);
            wake(new ScriptMethodReference(music_05a_05_stop));
            game_save();
            ai_set_orders(grotto_initial, grotto_follow_03);
            await sleep_until(async () => (short)ai_living_count(grotto_enemies) < 1);
            game_save();
        }

        [ScriptMethod(335, Lifecycle.Dormant)]
        public async Task approach_cortana_comment()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'good. still no word about in amber clad on the covenant battle-net.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0760"));
            await sleep(60);
            print("cortana: 'it's odd - the covenant know we made land-fall,'");
            print("'but they don't seem to consider us a very serious threat.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0770"));
            await sleep(30);
            print("cortana: 'boy are they in for a big surprise!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0780"));
            await sleep(30);
            ai_dialogue_enable(true);
            game_save();
        }

        [ScriptMethod(336, Lifecycle.Dormant)]
        public async Task approach_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_tower1, players()) == true, 30, 3600);
            if (volume_test_objects(vol_tower1, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'this tower cluster should connect to the structures further...'");
                print("'...out in the lake. let's get inside.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0790"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(337, Lifecycle.Dormant)]
        public async Task temple_approach_start()
        {
            ai_disposable(grotto_enemies, true);
            data_mine_set_mission_segment("05a_10_tower_approach");
            ai_place(approach_jackal_01.Squad);
            ai_place(approach_jackal_02.Squad);
            ai_place(approach_jackal_03.Squad);
            ai_place(approach_elite_01.Squad);
            ai_place(approach_elite_02.Squad);
            ai_place(approach_elite_03.Squad);
            ai_place(approach_grunts_01.Squad);
            wake(new ScriptMethodReference(approach_cortana_comment));
            wake(new ScriptMethodReference(approach_reminder));
            await sleep_until(async () => volume_test_objects(vol_approach_ramp, players()) == true || volume_test_objects(vol_approach_music, players()) == true && objects_can_see_flag(players(), see_tower1, 30F) == true);
            wake(new ScriptMethodReference(music_05a_06_start));
            await sleep_until(async () => (short)ai_combat_status(approach_enemies) > this.ai_combat_status_idle || volume_test_objects(vol_approach_ramp, players()) == true);
            if (volume_test_objects(vol_approach_ramp, players()) == false && await this.player_count() > 0 && (short)ai_living_count(approach_enemies) < 8)
            {
                ai_place(approach_buggers1.Squad, 5);
            }

            await sleep(2);
            await sleep_until(async () => (short)ai_living_count(approach_buggers1.Squad) < 1);
            await sleep_until(async () => volume_test_object(vol_no_see_ramp, await this.player0()) == true || volume_test_object(vol_no_see_approach, await this.player0()) == true && volume_test_object(vol_no_see_ramp, await this.player1()) == true || volume_test_object(vol_no_see_approach, await this.player1()) == true || (bool)game_is_cooperative() == false);
            if ((short)ai_living_count(approach_enemies) < 8)
            {
                ai_place(approach_buggers_too1.Squad, 4);
            }
        }

        [ScriptMethod(338, Lifecycle.Dormant)]
        public async Task tower1_holo_looper()
        {
            object_create(regret03);
            objects_attach(tower1_throne.Entity, "driver", regret03.Entity, "");
            ai_disregard(regret03.Entity, true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant1a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3000"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2b", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3001"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant2c", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3002"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3003"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant3c", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3004"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant5a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3005"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3886548530U), "regret_chant6a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3006"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(339, Lifecycle.Dormant)]
        public async Task tower1_hg_warn()
        {
            await sleep_until(async () => volume_test_objects(vol_tower1_see_hg, players()) == true && objects_can_see_object(players(), list_get(ai_actors(tower1_hg_01a.Squad), 0), 30F) || objects_can_see_object(players(), list_get(ai_actors(tower1_hg_01b.Squad), 0), 30F));
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'watch yourself! honor-guards!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0800"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(340, Lifecycle.CommandScript)]
        public async Task long_pause_point()
        {
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) > this.ai_combat_status_idle);
            cs_aim_player(true);
            cs_custom_animation(GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4194441168U), "combat:rifle:warn", 1F, true);
            cs_aim_player(false);
        }

        [ScriptMethod(341, Lifecycle.Dormant)]
        public async Task tower1_start()
        {
            await sleep_until(async () => volume_test_objects(vol_tower1, players()) == true);
            ai_disposable(approach_enemies, true);
            data_mine_set_mission_segment("05a_11_tower1_interior");
            wake(new ScriptMethodReference(tower1_holo_looper));
            game_save();
            ai_place(tower1_hg_01a.Squad, 1);
            ai_place(tower1_hg_01b.Squad, 1);
            begin_random(async () =>
            {
                if (this.who_points == true)
                {
                    cs_run_command_script(tower1_hg_01a.Squad, new ScriptMethodReference(long_pause_point));
                    ai_set_orders(tower1_hg_01a.Squad, tower1_hg1a);
                    cs_run_command_script(tower1_hg_01b.Squad, new ScriptMethodReference(long_pause));
                    ai_set_orders(tower1_hg_01b.Squad, tower1_hg1b_back);
                    this.who_points = false;
                }
            }, 
                async () =>
            {
                if (this.who_points == true)
                {
                    cs_run_command_script(tower1_hg_01a.Squad, new ScriptMethodReference(long_pause));
                    ai_set_orders(tower1_hg_01a.Squad, tower1_hg1a_back);
                    cs_run_command_script(tower1_hg_01b.Squad, new ScriptMethodReference(long_pause_point));
                    ai_set_orders(tower1_hg_01b.Squad, tower1_hg1b);
                    this.who_points = false;
                }
            });
            wake(new ScriptMethodReference(tower1_hg_warn));
            await sleep_until(async () => (short)ai_living_count(tower1_hg_01a.Squad) < 1 && (short)ai_living_count(tower1_hg_01b.Squad) < 1 || volume_test_objects(vol_tower1_upper, players()) == true);
            ai_place(tower1_hg_02a.Squad, (short)(1 - (float)ai_living_count(tower1_hg_01a.Squad)));
            ai_place(tower1_hg_02b.Squad, (short)(1 - (float)ai_living_count(tower1_hg_01b.Squad)));
            await sleep_until(async () => (short)ai_living_count(tower1_enemies) < 1, 30, 8000);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", tower1_enemies) == true);
            await sleep_until(async () => volume_test_objects(vol_tower1_all, players()) == true);
            await this.playtest_mission();
            await sleep(30);
            sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            await sleep(30);
            game_won();
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task temple_ent_go()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(0.5F);
            cs_go_to_and_face(GetReference<ISpatialPoint>("temple_ent/p2"), GetReference<ISpatialPoint>("temple_ent/p1"));
            cs_vehicle_speed(0.25F);
            cs_go_to_and_face(GetReference<ISpatialPoint>("temple_ent/p0"), GetReference<ISpatialPoint>("temple_ent/p1"));
            cs_move_in_direction(0F, 10F, 0F);
        }

        [ScriptMethod(343, Lifecycle.Dormant)]
        public async Task bridge_bunker_backup()
        {
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", ai_actors(LZ_warthog_01.Squad)) == true)
            {
                await sleep_until(async () => volume_test_objects(vol_bunker_parking, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", LZ_warthog_01.Squad) == true);
            }

            ai_vehicle_exit(all_allies);
            ai_set_orders(all_allies, allies_bridge_bunker);
        }

        [ScriptMethod(344, Lifecycle.Dormant)]
        public async Task ally_order_monitor()
        {
            await sleep_until(async () => this.lz_mounted_up == true || volume_test_objects(vol_lz_all, players()) == false);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_overlook_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_overlook_pause);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_overlook_follow);
                }

                return volume_test_objects(vol_overlook_pause, players()) == true;
            });
            await sleep_until(async () => volume_test_objects(vol_bridge_pause, players()) == true || volume_test_objects(vol_overlook_pause, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", overlook_jackals) == true);
            await sleep_until(async () => volume_test_objects(vol_bridge_pause, players()) == true, 30, 300);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_bridge_follow_01);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_pause);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_01);
                }

                return volume_test_objects(vol_bridge_pause, players()) == true;
            });
            await sleep_until(async () => volume_test_objects(vol_bridge_pause, players()) == false && await this.player_count() > 0, 30, 300);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_bridge_follow_01);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_advance);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_01);
                }

                return volume_test_objects(vol_bridge_inside_bunker, players()) == true;
            });
            ai_set_orders(ally_infantry, allies_bridge_bunker);
            ai_set_orders(LZ_warthog_01.Squad, allies_bridge_bunker);
            wake(new ScriptMethodReference(bridge_bunker_backup));
            await sleep_until(async () => this.bridge_pelican_arrived == true || volume_test_objects(vol_bridge_middle, players()) == true);
            await sleep_until(async () => vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true || volume_test_objects(vol_bridge_middle, players()) == true);
            ai_enter_squad_vehicles(all_allies);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_bridge_follow_02);
                ai_set_orders(bridge_tank1.Squad, allies_bridge_follow_02);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_cross);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_02);
                }

                return volume_test_objects(vol_winding_path, players()) == true || volume_test_objects(vol_bridge_farside_all, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", bridge_farside_enemies) == true;
            });
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_w_path_follow);
                ai_set_orders(bridge_tank1.Squad, allies_w_path_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_w_path_advance);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_w_path_follow);
                }

                return volume_test_objects(vol_temple_ent_start, players()) == true || volume_test_objects(vol_temple_entrance, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", winding_path_enemies) == true;
            });
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_temple_ent_follow);
                ai_set_orders(bridge_tank1.Squad, allies_temple_ent_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_01);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return volume_test_objects(vol_tunnel_01, players()) == true || this.temple_ent_phase_01 == true || volume_test_objects(vol_temple_ent_03, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", temple_ent_enemies_all) == true;
            });
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_temple_ent_follow);
                ai_set_orders(bridge_tank1.Squad, allies_temple_ent_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_02);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return volume_test_objects(vol_tunnel_01, players()) == true || this.temple_ent_phase_02 == true || volume_test_objects(vol_temple_ent_03, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", temple_ent_enemies_all) == true;
            });
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_temple_ent_follow);
                ai_set_orders(bridge_tank1.Squad, allies_temple_ent_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_03);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return volume_test_objects(vol_tunnel_01, players()) == true || volume_test_objects(vol_temple_ent_03, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", temple_ent_enemies_all) == true;
            });
            cs_run_command_script(bridge_tank1.driver, new ScriptMethodReference(temple_ent_go));
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_tunnel_follow);
                ai_set_orders(bridge_tank1.Squad, allies_tunnel_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_advance);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_follow);
                }

                return volume_test_objects(vol_old_temple_near_left, players()) == true || volume_test_objects(vol_tunnel_03, ai_actors(LZ_warthog_01.Squad)) == true && (bool)ai_trigger_test("done_fighting", tunnel_enemies_all) == true;
            });
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_old_temple_follow);
                ai_set_orders(bridge_tank1.Squad, allies_old_temple_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_advance);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_follow);
                }

                return volume_test_objects(vol_old_temple_center_01, players()) == true || volume_test_objects(vol_old_temple_center_01, ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await sleep_until(async () => vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) == false && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) == false);
            ai_vehicle_exit(all_allies);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_tank1.driver), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            ai_migrate(allies_old_temple_pelican.Squad, allies_old_temple_real.Squad);
            ai_set_orders(all_allies, allies_old_temp_center);
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            ai_set_orders(all_allies, allies_grotto_suppress);
            await sleep_until(async () => (short)ai_combat_status(grotto_enemies) > this.ai_combat_status_idle);
            ai_set_orders(all_allies, grotto_follow_01);
            await sleep_until(async () => volume_test_objects(vol_grotto_exit, players()) == true);
            ai_set_orders(all_allies, allies_grotto_exit);
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            ai_set_orders(all_allies, allies_approach);
            await sleep_until(async () => volume_test_objects(vol_tower1, players()) == true);
            ai_set_orders(all_allies, allies_tower1);
        }

        [ScriptMethod(345, Lifecycle.Static)]
        public async Task sleep_intro()
        {
            sleep_forever(new ScriptMethodReference(lz_start));
            sleep_forever(new ScriptMethodReference(lz_turret_track));
            sleep_forever(new ScriptMethodReference(lz_turret_reminder));
            sleep_forever(new ScriptMethodReference(lz_pelican));
            sleep_forever(new ScriptMethodReference(lz_pelican_wait));
            sleep_forever(new ScriptMethodReference(lz_phantom_03_start));
        }

        [ScriptMethod(346, Lifecycle.Static)]
        public async Task sleep_bridge()
        {
            sleep_forever(new ScriptMethodReference(overlook_start));
            sleep_forever(new ScriptMethodReference(overlook_reminder));
            sleep_forever(new ScriptMethodReference(bridges_start));
            sleep_forever(new ScriptMethodReference(crack_spawn));
            sleep_forever(new ScriptMethodReference(bunker_upper_spawn_01));
            sleep_forever(new ScriptMethodReference(bunker_upper_spawn_03));
            sleep_forever(new ScriptMethodReference(bunker_lower_spawn_01));
            sleep_forever(new ScriptMethodReference(bunker_turret_remanning));
            sleep_forever(new ScriptMethodReference(bunker_spawn_checker));
            sleep_forever(new ScriptMethodReference(bridge_ghosts_by_phantom));
            sleep_forever(new ScriptMethodReference(farside_ghosts_spawn));
            sleep_forever(new ScriptMethodReference(bridge_phantom_reinforce_01a));
            sleep_forever(new ScriptMethodReference(bridge_phantom_reinforce_01b));
            sleep_forever(new ScriptMethodReference(bridge_phantom_reinforce_02a));
            sleep_forever(new ScriptMethodReference(bridge_phantom_reinforce_02b));
            sleep_forever(new ScriptMethodReference(bridge_cortana_comment));
            sleep_forever(new ScriptMethodReference(bridge_wraith_warning));
            sleep_forever(new ScriptMethodReference(bridge_activate_reminder));
            sleep_forever(new ScriptMethodReference(bunker_holo_looper));
            sleep_forever(new ScriptMethodReference(bridge_holo_translate));
            sleep_forever(new ScriptMethodReference(bridge_pelican_wait));
            sleep_forever(new ScriptMethodReference(bridge_cross_reminder));
            sleep_forever(new ScriptMethodReference(bridge_banshee_spawn));
            sleep_forever(new ScriptMethodReference(bridge_spare_ghost_spawn));
        }

        [ScriptMethod(347, Lifecycle.Static)]
        public async Task sleep_winding_path()
        {
            sleep_forever(new ScriptMethodReference(winding_path_start));
        }

        [ScriptMethod(348, Lifecycle.Static)]
        public async Task sleep_temple_ent()
        {
            sleep_forever(new ScriptMethodReference(old_temple_entrance_start));
            sleep_forever(new ScriptMethodReference(temple_ent_ghost_alert));
            sleep_forever(new ScriptMethodReference(temple_ent_veh_spawn));
            sleep_forever(new ScriptMethodReference(temple_ent_reminder));
            sleep_forever(new ScriptMethodReference(temple_ent_arch));
        }

        [ScriptMethod(349, Lifecycle.Static)]
        public async Task sleep_tunnel()
        {
            sleep_forever(new ScriptMethodReference(tunnel_start));
        }

        [ScriptMethod(350, Lifecycle.Static)]
        public async Task sleep_old_temple()
        {
            sleep_forever(new ScriptMethodReference(old_temple_start));
            sleep_forever(new ScriptMethodReference(old_temple_near_right));
            sleep_forever(new ScriptMethodReference(old_temple_far_left));
            sleep_forever(new ScriptMethodReference(old_temple_far_right));
            sleep_forever(new ScriptMethodReference(old_temple_below));
            sleep_forever(new ScriptMethodReference(old_temple_center));
            sleep_forever(new ScriptMethodReference(old_temple_courtyard));
            sleep_forever(new ScriptMethodReference(old_temple_vehicle_spawn));
            sleep_forever(new ScriptMethodReference(old_temple_pelican));
            sleep_forever(new ScriptMethodReference(old_temple_phantom_01));
            sleep_forever(new ScriptMethodReference(old_temple_phantom_02));
            sleep_forever(new ScriptMethodReference(old_temple_turret_reman));
            sleep_forever(new ScriptMethodReference(old_temple_perimeter_nuke));
            sleep_forever(new ScriptMethodReference(old_temple_middle_ally));
            sleep_forever(new ScriptMethodReference(old_temple_playfight));
            sleep_forever(new ScriptMethodReference(old_temple_debris_comment));
            sleep_forever(new ScriptMethodReference(old_temple_middle_comment));
            sleep_forever(new ScriptMethodReference(old_temple_debris_reminder));
            sleep_forever(new ScriptMethodReference(old_temple_holo_translate));
            sleep_forever(new ScriptMethodReference(courtyard_holo_looper));
            sleep_forever(new ScriptMethodReference(old_temple_archaeologist));
        }

        [ScriptMethod(351, Lifecycle.Static)]
        public async Task sleep_grotto()
        {
            sleep_forever(new ScriptMethodReference(grotto_start));
            sleep_forever(new ScriptMethodReference(grotto_buggers_reinforce));
            sleep_forever(new ScriptMethodReference(grotto_cortana_comment));
            sleep_forever(new ScriptMethodReference(grotto_ally_comments));
            sleep_forever(new ScriptMethodReference(grotto_reminder));
            sleep_forever(new ScriptMethodReference(grotto_pool));
            sleep_forever(new ScriptMethodReference(grotto_extra_checkpoint));
        }

        [ScriptMethod(352, Lifecycle.Static)]
        public async Task sleep_approach()
        {
            sleep_forever(new ScriptMethodReference(temple_approach_start));
            sleep_forever(new ScriptMethodReference(approach_reminder));
        }

        [ScriptMethod(353, Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_black();
            if (volume_test_objects(vol_starting_locations, players()) == true)
            {
                sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    await this.x05();
                }

                await this.cinematic_skip_stop();
                await this.cinematic_snap_to_white();
                if (await this.cinematic_skip_start())
                {
                    await this.c05_intro();
                }

                await this.cinematic_skip_stop();
            }

            await sleep(2);
            switch_bsp(0);
            await sleep(2);
            ai_allegiance(covenant, prophet);
            ai_allegiance(player, human);
            objectives_clear();
            await this.prep_return_from_intro();
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            wake(new ScriptMethodReference(_05a_title0));
            wake(new ScriptMethodReference(objective_lz_set));
            wake(new ScriptMethodReference(kill_volumes));
            wake(new ScriptMethodReference(lz_start));
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep_until(async () => volume_test_objects(vol_overlook, players()) == true);
            wake(new ScriptMethodReference(overlook_start));
            wake(new ScriptMethodReference(bridges_start));
            wake(new ScriptMethodReference(objective_bridge_set));
            await sleep_until(async () => volume_test_objects(vol_winding_path, players()) == true);
            wake(new ScriptMethodReference(winding_path_start));
            wake(new ScriptMethodReference(old_temple_entrance_start));
            wake(new ScriptMethodReference(objective_bridge_clear));
            wake(new ScriptMethodReference(objective_ruins_set));
            await this.sleep_intro();
            await sleep_until(async () => volume_test_objects(vol_tunnel_01, players()) == true);
            wake(new ScriptMethodReference(tunnel_start));
            wake(new ScriptMethodReference(old_temple_start));
            wake(new ScriptMethodReference(old_temple_courtyard));
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            wake(new ScriptMethodReference(grotto_start));
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await sleep_until(async () => volume_test_objects(vol_approach, players()) == true);
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
            wake(new ScriptMethodReference(objective_ruins_clear));
            wake(new ScriptMethodReference(objective_tower1_set));
            await this.sleep_old_temple();
            await sleep_until(async () => volume_test_objects(vol_tower1, players()) == true);
            await this.sleep_grotto();
        }

        [ScriptMethod(354, Lifecycle.Static)]
        public async Task short_allies()
        {
            ai_allegiance(player, human);
            ai_place(LZ_warthog_01.Squad);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0());
            ai_place_in_vehicle(allies_lz_ridge.Squad, LZ_warthog_01.Squad);
            object_teleport(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), ally_start);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_overlook_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_overlook_pause);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_overlook_follow);
                }

                return volume_test_objects(vol_overlook_pause, players()) == true;
            });
            await sleep(30);
            print("arrived");
            await sleep(30);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_bridge_follow_01);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_pause);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_01);
                }

                return volume_test_objects(vol_bridge_pause, players()) == true;
            });
            await sleep(30);
            print("arrived");
            await sleep(30);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_bridge_follow_02);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_cross);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_02);
                }

                return volume_test_objects(vol_winding_path, players()) == true || volume_test_objects(vol_bridge_farside_all, ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await sleep(30);
            print("arrived");
            await sleep(30);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_w_path_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_w_path_advance);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_w_path_follow);
                }

                return volume_test_objects(vol_temple_ent_start, players()) == true || volume_test_objects(vol_temple_entrance, ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await sleep(30);
            print("arrived");
            await sleep(30);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_temple_ent_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_03);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return volume_test_objects(vol_tunnel_01, players()) == true || volume_test_objects(vol_temple_ent_03, ai_actors(LZ_warthog_01.Squad)) == true;
            });
            cs_run_command_script(bridge_tank1.driver, new ScriptMethodReference(temple_ent_go));
            await sleep(30);
            print("arrived");
            await sleep(30);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_tunnel_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_advance);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_follow);
                }

                return volume_test_objects(vol_old_temple_near_left, players()) == true || volume_test_objects(vol_tunnel_03, ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await sleep(30);
            print("arrived");
            await sleep(30);
            await sleep_until(async () =>
            {
                ai_set_orders(ally_infantry, allies_old_temple_follow);
                if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || vehicle_test_seat_list(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_advance);
                }
                else
                {
                    ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_follow);
                }

                return volume_test_objects(vol_old_temple_center_01, players()) == true || volume_test_objects(vol_old_temple_center_01, ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await sleep(30);
            print("arrived");
            await sleep(30);
            ai_vehicle_exit(all_allies);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(bridge_tank1.driver), true);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            ai_migrate(allies_old_temple_pelican.Squad, allies_old_temple_real.Squad);
            ai_set_orders(all_allies, allies_old_temp_center);
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            ai_set_orders(all_allies, grotto_follow_01);
            await sleep_until(async () => volume_test_objects(vol_grotto_exit, players()) == true);
            ai_set_orders(all_allies, allies_grotto_exit);
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            ai_set_orders(all_allies, allies_approach);
            await sleep_until(async () => volume_test_objects(vol_tower1, players()) == true);
            ai_set_orders(all_allies, allies_tower1);
        }

        [ScriptMethod(355, Lifecycle.Dormant)]
        public async Task x05_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 4);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_x05"), 0, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3839165279U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785490476U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\x05_building_debris\\x05_building_debris", 3840344945U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3846177738U), 2);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3847357404U), 0);
        }

        [ScriptMethod(356, Lifecycle.Dormant)]
        public async Task x05_02_predict()
        {
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3850306569U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3850830865U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3850896402U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3854107715U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
            await sleep(15);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3850306569U), 0);
            await sleep(25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 2);
            await sleep(215);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3862103229U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\x05_building_debris\\x05_building_debris", 3840344945U), 0);
            await sleep(215);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3850896402U), 0);
        }

        [ScriptMethod(357, Lifecycle.Dormant)]
        public async Task x05_03_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3862430914U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\x05_building_debris\\x05_building_debris", 3840344945U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3862824136U), 0);
            await sleep(27);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3863348432U), 0);
        }

        [ScriptMethod(358, Lifecycle.Dormant)]
        public async Task x05_04_predict()
        {
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3854107715U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3862103229U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
            await sleep(48);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3863413969U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3850896402U), 0);
            await sleep(63);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 2);
            await sleep(214);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3862103229U), 0);
            await sleep(13);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3863348432U), 0);
            await sleep(128);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3850306569U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3850896402U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3862103229U), 0);
            await sleep(91);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3850830865U), 0);
        }

        [ScriptMethod(359, Lifecycle.Dormant)]
        public async Task x05_05_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
        }

        [ScriptMethod(360, Lifecycle.Dormant)]
        public async Task x05_06a_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3854107715U), 0);
        }

        [ScriptMethod(361, Lifecycle.Dormant)]
        public async Task x05_06b_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 60);
            await sleep(121);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3850896402U), 0);
            await sleep(238);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3847488478U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3855483992U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3850896402U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3862430914U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3862824136U), 0);
            await sleep(31);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\delta_halo_close", 3863741654U), 0);
        }

        [ScriptMethod(362, Lifecycle.Dormant)]
        public async Task x05_07_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(363, Lifecycle.Dormant)]
        public async Task x05_08_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3854107715U), 0);
            await sleep(101);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3850896402U), 0);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\delta_halo_close", 3863741654U), 0);
            await sleep(66);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3862824136U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3862430914U), 0);
            await sleep(40);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
        }

        [ScriptMethod(364, Lifecycle.Dormant)]
        public async Task _05_intro_01_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_islands\\delta_islands", 3863938265U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\delta_horizon", 3864134876U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev_reentry\\hev_reentry", 3864331487U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3863348432U), 0);
            await sleep(75);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3863348432U), 0);
            await sleep(97);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            await sleep(54);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3863348432U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_islands\\delta_islands", 3863938265U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
            await sleep(106);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 0, false);
        }

        [ScriptMethod(365, Lifecycle.Dormant)]
        public async Task _05_intro_02_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 69, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 70, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 74, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 83, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 90, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 71, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 76, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 82, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3850830865U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3864593635U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3865052394U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3855221844U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 59, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3782934533U), 4);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3865117931U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3865117931U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3866428671U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3870295354U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 14);
            await sleep(138);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 59, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 65, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 52, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 53, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 54, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 55, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 56, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 119, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_bush\\tree_bush", 3870819650U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_branch\\tree_branch", 3870885187U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3865052394U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3870295354U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3850306569U), 1);
            await sleep(76);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            await sleep(60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3870950724U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3870950724U), 1);
        }

        [ScriptMethod(366, Lifecycle.Dormant)]
        public async Task _05_intro_03_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 76, true);
            await sleep(7);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 10, true);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3868656929U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3850830865U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3857319028U), 6);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 16, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3865117931U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3865117931U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786604605U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_bush\\tree_bush", 3870819650U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 59, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3871147335U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3871475020U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 88, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3865052394U), 1);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 87, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 93, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 84, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 85, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 86, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 95, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 96, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3864593635U), 1);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 101, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 97, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 89, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 99, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_branch\\tree_branch", 3870885187U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3807576445U), 2);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 90, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3872654686U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 73, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 94, true);
            await sleep(89);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\invisible_box1x2x2\\invisible_box1x2x2", 3873637741U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 98, true);
            await sleep(15);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3807576445U), 0);
            await sleep(22);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 69, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 70, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 74, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 76, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 79, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 83, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 71, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 82, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3866428671U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3870950724U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3870950724U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3864593635U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786604605U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            await sleep(22);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 88, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3807576445U), 2);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 29, false);
            await sleep(17);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 17, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 86, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 95, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 96, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 97, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 99, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 94, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 101, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 98, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3872654686U), 0);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 73, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 96, true);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 95, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 28, false);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 71, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 78, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 79, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 81, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 101, true);
            await sleep(40);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 84, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3865052394U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3849454588U), 1);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 14, false);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786604605U), 2);
            await sleep(29);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786604605U), 2);
            await sleep(62);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3860989100U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3807576445U), 2);
            await sleep(65);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
            await sleep(47);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
        }

        [ScriptMethod(367, Lifecycle.Static)]
        public async Task teleport_bridge()
        {
            ai_erase_all();
            ai_place(LZ_warthog_01.Squad);
            device_set_position(da_bridge.Entity, 0.5F);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0());
            vehicle_load_magic(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1());
            ai_place_in_vehicle(allies_lz_ledge.Squad, LZ_warthog_01.Squad);
            object_teleport(ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), bridge_player0);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            garbage_collect_now();
            game_save();
            ai_set_orders(LZ_warthog_01.Squad, allies_bridge_pause);
            wake(new ScriptMethodReference(bridges_start));
            await sleep_until(async () => volume_test_objects(vol_winding_path, players()) == true);
            wake(new ScriptMethodReference(winding_path_start));
            wake(new ScriptMethodReference(old_temple_entrance_start));
            await sleep_until(async () => volume_test_objects(vol_tunnel_01, players()) == true);
            wake(new ScriptMethodReference(tunnel_start));
            wake(new ScriptMethodReference(old_temple_start));
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            wake(new ScriptMethodReference(grotto_start));
            await sleep_until(async () => volume_test_objects(vol_approach, players()) == true);
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
        }

        [ScriptMethod(368, Lifecycle.Static)]
        public async Task teleport_winding_path()
        {
            ai_erase_all();
            ai_place(bridge_tank1.Squad);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            object_teleport(ai_vehicle_get_from_starting_location(bridge_tank1.driver), winding_path_player0);
            ai_set_orders(all_allies, allies_w_path_follow);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_bridge();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(winding_path_start));
            wake(new ScriptMethodReference(old_temple_entrance_start));
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep_until(async () => volume_test_objects(vol_tunnel_01, players()) == true);
            wake(new ScriptMethodReference(tunnel_start));
            wake(new ScriptMethodReference(old_temple_start));
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            wake(new ScriptMethodReference(grotto_start));
            await sleep_until(async () => volume_test_objects(vol_approach, players()) == true);
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
        }

        [ScriptMethod(369, Lifecycle.Static)]
        public async Task teleport_temple_ent()
        {
            ai_erase_all();
            ai_place(bridge_tank1.Squad);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            object_teleport(ai_vehicle_get_from_starting_location(bridge_tank1.driver), temple_ent_player0);
            ai_set_orders(all_allies, temple_ent_all);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(old_temple_entrance_start));
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep_until(async () => volume_test_objects(vol_tunnel_01, players()) == true);
            wake(new ScriptMethodReference(tunnel_start));
            wake(new ScriptMethodReference(old_temple_start));
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            wake(new ScriptMethodReference(grotto_start));
            await sleep_until(async () => volume_test_objects(vol_approach, players()) == true);
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
        }

        [ScriptMethod(370, Lifecycle.Static)]
        public async Task teleport_tunnel()
        {
            ai_erase_all();
            ai_place(bridge_tank1.Squad);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            object_teleport(ai_vehicle_get_from_starting_location(bridge_tank1.driver), tunnel_player0);
            ai_set_orders(all_allies, allies_tunnel_follow);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(tunnel_start));
            wake(new ScriptMethodReference(old_temple_start));
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            wake(new ScriptMethodReference(grotto_start));
            await sleep_until(async () => volume_test_objects(vol_approach, players()) == true);
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
        }

        [ScriptMethod(371, Lifecycle.Static)]
        public async Task teleport_old_temple()
        {
            ai_erase_all();
            ai_place(bridge_tank1.Squad);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            object_teleport(ai_vehicle_get_from_starting_location(bridge_tank1.driver), old_temple_player0);
            ai_set_orders(all_allies, allies_old_temple_follow);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(old_temple_start));
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep(1);
            wake(new ScriptMethodReference(ally_order_monitor));
            await sleep_until(async () => volume_test_objects(vol_grotto, players()) == true);
            wake(new ScriptMethodReference(grotto_start));
            await sleep_until(async () => volume_test_objects(vol_approach, players()) == true);
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
        }

        [ScriptMethod(372, Lifecycle.Static)]
        public async Task teleport_grotto()
        {
            ai_erase_all();
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), grotto_player0);
            object_teleport(await this.player1(), grotto_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await this.sleep_old_temple();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(grotto_start));
            await sleep_until(async () => volume_test_objects(vol_approach, players()) == true);
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
        }

        [ScriptMethod(373, Lifecycle.Static)]
        public async Task teleport_approach()
        {
            ai_erase_all();
            switch_bsp(1);
            await sleep(1);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), approach_player0);
            object_teleport(await this.player1(), approach_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await this.sleep_old_temple();
            await this.sleep_grotto();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(temple_approach_start));
            wake(new ScriptMethodReference(tower1_start));
        }

        [ScriptMethod(374, Lifecycle.Static)]
        public async Task teleport_tower1()
        {
            ai_erase_all();
            switch_bsp(1);
            await sleep(1);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), tower1_player0);
            object_teleport(await this.player1(), tower1_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await this.sleep_old_temple();
            await this.sleep_grotto();
            await this.sleep_approach();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(tower1_start));
        }
    }
}