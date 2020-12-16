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
            this.phantom_boom = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\deltatemple\\phantom_explosion", 2230395574U);
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
        [ScriptMethod(Lifecycle.Static)]
        public async Task<IUnit> player0()
        {
            return Engine.unit(Engine.list_get(Engine.players(), 0));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<IUnit> player1()
        {
            return Engine.unit(Engine.list_get(Engine.players(), 1));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<int> player_count()
        {
            return Engine.list_count(Engine.players());
        }

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> difficulty_legendary()
        {
            return Engine.game_difficulty_get() // Couldn't generate cast from 'String' to 'GameDifficulty'
 == "legendary";
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> difficulty_heroic()
        {
            return Engine.game_difficulty_get() // Couldn't generate cast from 'String' to 'GameDifficulty'
 == "heroic";
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> difficulty_normal()
        {
            return Engine.game_difficulty_get() // Couldn't generate cast from 'String' to 'GameDifficulty'
 == "normal";
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> cinematic_skip_start()
        {
            Engine.cinematic_skip_start_internal();
            Engine.game_save_cinematic_skip();
            await Engine.sleep_until(async () => !((bool)Engine.game_saving()), 1);
            return !((bool)Engine.game_reverted());
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_skip_stop()
        {
            Engine.cinematic_skip_stop_internal();
            if (!((bool)Engine.game_reverted()))
            {
                Engine.game_revert();
            }
        }

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_stash_players()
        {
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            Engine.object_cannot_take_damage(Engine.players());
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cinematic_unstash_players()
        {
            Engine.object_hide(await this.player0(), false);
            Engine.object_hide(await this.player1(), false);
            Engine.object_can_take_damage(Engine.players());
        }

        [ScriptMethod(Lifecycle.Dormant)]
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

        [ScriptMethod(Lifecycle.Dormant)]
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

        [ScriptMethod(Lifecycle.Static)]
        public async Task activate_stealth_toggle_monitor()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task activate_stealth_timer_monitor()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(Lifecycle.Static)]
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

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_01_predict_stub()
        {
            Engine.wake(x05_01_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_02_predict_stub()
        {
            Engine.wake(x05_02_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_03_predict_stub()
        {
            Engine.wake(x05_03_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_04_predict_stub()
        {
            Engine.wake(x05_04_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_05_predict_stub()
        {
            Engine.wake(x05_05_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_06a_predict_stub()
        {
            Engine.wake(x05_06a_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_06b_predict_stub()
        {
            Engine.wake(x05_06b_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_07_predict_stub()
        {
            Engine.wake(x05_07_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_08_predict_stub()
        {
            Engine.wake(x05_08_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _05_intro_01_predict_stub()
        {
            Engine.wake(_05_intro_01_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _05_intro_02_predict_stub()
        {
            Engine.wake(_05_intro_02_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _05_intro_03_predict_stub()
        {
            Engine.wake(_05_intro_03_predict);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_score_01()
        {
            await Engine.sleep(40);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_01_mus", 3838444372U), default(IGameObject), 1F);
            Engine.print("x05 score 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_01_fol", 3838509909U), default(IGameObject), 1F);
            Engine.print("x05 foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_slipspace_open()
        {
            await Engine.sleep(10);
            Engine.print("effect - slipspace open");
            Engine.object_create_anew(x05_slipspace);
            await Engine.sleep(300);
            Engine.object_destroy(x05_slipspace.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_01()
        {
            Engine.cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            Engine.cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.object_uses_cinematic_lighting(carrier.Entity, true);
            Engine.object_uses_cinematic_lighting(iac.Entity, true);
            Engine.object_uses_cinematic_lighting(x05_debris.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_02_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(iac_bridge);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(iac_bridge.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_01_setup()
        {
            Engine.object_create_anew(carrier);
            Engine.object_create_anew(iac);
            Engine.object_create_anew(x05_debris);
            Engine.object_cinematic_lod(carrier.Entity, true);
            Engine.object_cinematic_lod(iac.Entity, true);
            Engine.object_cinematic_lod(x05_debris.Entity, true);
            Engine.wake(x05_score_01);
            Engine.wake(x05_foley_01);
            Engine.wake(x05_slipspace_open);
            Engine.wake(x05_cinematic_lighting_scene_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_01_cleanup()
        {
            Engine.object_destroy(carrier.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_01()
        {
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltaapproach_1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.x05_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_01_mus", 3838444372U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_01_fol", 3838509909U));
            await Engine.sleep(this.prediction_offset);
            await this.x05_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_01", default(IUnit), anchor_flag_x05);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3838640983U), "iac_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(carrier.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\x05\\x05", 3838706520U), "capital_ship_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(x05_debris.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\effects\\x05_building_debris\\x05\\x05", 3838772057U), "debris_01", anchor_x05.Entity);
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_02_predict_stub();
            await this.x05_02_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_02_fol", 3838837594U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x05_01_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_02_fol", 3838837594U), default(IGameObject), 1F);
            Engine.print("x05 foley 02 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0010_mir()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0010_mir", 3838903131U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0010_mir", 1F);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 15);
            Engine.print("miranda - shocked .5 15");
            Engine.unit_set_emotional_state(nav_officer.Entity, "annoyed", 0.25F, 0);
            Engine.print("nav_officer - pain .5 0");
            Engine.unit_set_emotional_state(weap_officer.Entity, "annoyed", 0.5F, 0);
            Engine.print("nav_officer - annoyed .5 0");
            await Engine.sleep(153);
            Engine.unit_set_emotional_state(miranda.Entity, "pensive", 0.5F, 30);
            Engine.print("miranda - pensive .25 30");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0020_mir()
        {
            await Engine.sleep(25);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0020_mir", 3838968668U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0020_mir", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0030_no1()
        {
            await Engine.sleep(51);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0030_no1", 3839034205U), nav_officer.Entity, 1F);
            Engine.cinematic_subtitle("x05_0030_no1", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0040_wo1()
        {
            await Engine.sleep(127);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0040_wo1", 3839099742U), weap_officer.Entity, 1F);
            Engine.cinematic_subtitle("x05_0040_wo1", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0050_mir()
        {
            await Engine.sleep(204);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0050_mir", 3839165279U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0050_mir", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0060_mir()
        {
            await Engine.sleep(272);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0060_mir", 3839230816U), default(IGameObject), 1F, "radio_default_in");
            Engine.cinematic_subtitle("x05_0060_mir", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0070_mir()
        {
            await Engine.sleep(327);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0070_mir", 3839296353U), default(IGameObject), 1F, "radio_default_out");
            Engine.cinematic_subtitle("x05_0070_mir", 1F);
            await Engine.sleep(27);
            Engine.unit_set_emotional_state(johnson.Entity, "inquisitive", 0.5F, 10);
            Engine.print("johnson - inquisitive .5 10");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0080_jon()
        {
            await Engine.sleep(367);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0080_jon", 3839361890U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x05_0080_jon", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0090_cor()
        {
            await Engine.sleep(437);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0090_cor", 3839427427U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0090_cor", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0100_no1()
        {
            await Engine.sleep(481);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0100_no1", 3839492964U), nav_officer.Entity, 1F);
            Engine.cinematic_subtitle("x05_0100_no1", 3F);
            Engine.unit_set_emotional_state(miranda.Entity, "pensive", 0.5F, 0);
            Engine.print("miranda - pensive .5 0");
            Engine.unit_set_emotional_state(nav_officer.Entity, "shocked", 0.5F, 30);
            Engine.print("nav_officer - shocked .5 30");
            await Engine.sleep(90);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 120);
            Engine.print("miranda - shocked .5 120");
            await Engine.sleep(60);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 90);
            Engine.print("miranda - shocked .25 90");
            await Engine.sleep(75);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.05F, 60);
            Engine.print("miranda - shocked .05 60");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0110_mir()
        {
            await Engine.sleep(594);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0110_mir", 3839558501U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0110_mir", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_fov_02()
        {
            await Engine.sleep(49);
            Engine.camera_set_field_of_view(36F, 0);
            Engine.print("fov change: 60 -> 36 over 0 ticks");
            await Engine.sleep(154);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 36 -> 60 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_05_dof_scene_02()
        {
            await Engine.sleep(49);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 1F, 1F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(76);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0F, 1F, 0.5F, 1F, 0F, 0.5F);
            Engine.print("rack focus");
            await Engine.sleep(78);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_02_bridge_1()
        {
            Engine.print("light bridge");
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(nav_officer.Entity, true);
            Engine.object_uses_cinematic_lighting(weap_officer.Entity, true);
            Engine.object_uses_cinematic_lighting(cigar.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_bridge.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_bay.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_01.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_02.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_03.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_04.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_05.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_06.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_07.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_08.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_09.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_10.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_11.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_12.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_13.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_14.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_15.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_16.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_17.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_02_hev_1()
        {
            await Engine.sleep(264);
            Engine.print("light hev");
            Engine.cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            Engine.cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_02_bridge_2()
        {
            await Engine.sleep(479);
            Engine.print("light bridge");
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_02_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(nav_officer);
            Engine.object_create_anew(weap_officer);
            Engine.object_create_anew(cigar);
            Engine.object_create_anew_containing("hev");
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(nav_officer.Entity, true);
            Engine.object_cinematic_lod(weap_officer.Entity, true);
            Engine.object_cinematic_lod(cigar.Entity, true);
            Engine.object_cinematic_lod(hev_bay.Entity, true);
            Engine.object_cinematic_lod(hev_01.Entity, true);
            Engine.object_cinematic_lod(hev_02.Entity, true);
            Engine.object_cinematic_lod(hev_03.Entity, true);
            Engine.object_cinematic_lod(hev_04.Entity, true);
            Engine.object_cinematic_lod(hev_05.Entity, true);
            Engine.object_cinematic_lod(hev_06.Entity, true);
            Engine.object_cinematic_lod(hev_07.Entity, true);
            Engine.object_cinematic_lod(hev_08.Entity, true);
            Engine.object_cinematic_lod(hev_09.Entity, true);
            Engine.object_cinematic_lod(hev_10.Entity, true);
            Engine.object_cinematic_lod(hev_11.Entity, true);
            Engine.object_cinematic_lod(hev_12.Entity, true);
            Engine.object_cinematic_lod(hev_13.Entity, true);
            Engine.object_cinematic_lod(hev_14.Entity, true);
            Engine.object_cinematic_lod(hev_15.Entity, true);
            Engine.object_cinematic_lod(hev_16.Entity, true);
            Engine.object_cinematic_lod(hev_17.Entity, true);
            Engine.wake(x05_0010_mir);
            Engine.wake(x05_0020_mir);
            Engine.wake(x05_0030_no1);
            Engine.wake(x05_0040_wo1);
            Engine.wake(x05_0050_mir);
            Engine.wake(x05_0060_mir);
            Engine.wake(x05_0070_mir);
            Engine.wake(x05_0080_jon);
            Engine.wake(x05_0090_cor);
            Engine.wake(x05_0100_no1);
            Engine.wake(x05_0110_mir);
            Engine.wake(x05_foley_02);
            Engine.wake(x05_fov_02);
            Engine.wake(x05_05_dof_scene_02);
            Engine.wake(x05_light_scene_02_bridge_1);
            Engine.wake(x05_light_scene_02_hev_1);
            Engine.wake(x05_light_scene_02_bridge_2);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_02()
        {
            await this.x05_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_02", default(IUnit), anchor_flag_x05);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x05\\x05", 3839624038U), "miranda_02", false, anchor_x05.Entity);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3844146091U), "chief_02", false, anchor_x05.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "johnson_02", false, anchor_x05.Entity);
            Engine.custom_animation_relative(nav_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "nav_02", false, anchor_x05.Entity);
            Engine.custom_animation_relative(weap_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "weap_02", false, anchor_x05.Entity);
            Engine.scenery_animation_start_relative(cigar.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\x05\\x05", 3844342702U), "cigar_bent_02", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev01_02", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev02_02", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev03_02", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev04_02", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x05\\x05", 3844473776U), "bridge_02", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_bay.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3844539313U), "hevbay_02", anchor_x05.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_03_mus", 3844604850U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_03_fol", 3844670387U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_score_03()
        {
            await Engine.sleep(113);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_03_mus", 3844604850U), default(IGameObject), 1F);
            Engine.print("x05 score 03 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_03_fol", 3844670387U), default(IGameObject), 1F);
            Engine.print("x05 foley 03 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0120_cor()
        {
            await Engine.sleep(60);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0120_cor", 3844735924U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0120_cor", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_03()
        {
            Engine.cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            Engine.cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_03_setup()
        {
            Engine.object_create_anew(delta_halo);
            Engine.object_create_anew(matte_substance);
            Engine.object_uses_cinematic_lighting(delta_halo.Entity, true);
            Engine.wake(x05_score_03);
            Engine.wake(x05_foley_03);
            Engine.wake(x05_0120_cor);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_03()
        {
            await this.x05_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_03", default(IUnit), anchor_flag_x05);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3838640983U), "iac_03", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(x05_debris.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\effects\\x05_building_debris\\x05\\x05", 3838772057U), "debris_03", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(delta_halo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3844801461U), "halo_03", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3844866998U), "substance_space_03", anchor_x05.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_04_fol", 3844932535U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(x05_debris.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_04_fol", 3844932535U), default(IGameObject), 1F);
            Engine.print("x05 foley 04 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0130_jon()
        {
            await Engine.sleep(12);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0130_jon", 3844998072U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x05_0130_jon", 1F);
            Engine.unit_set_emotional_state(johnson.Entity, "shocked", 0.75F, 10);
            Engine.print("johnson - shocked .75 10");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0140_mir()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            Engine.print("miranda - shocked .25 0");
            await Engine.sleep(63);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0140_mir", 3845063609U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0140_mir", 2F);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 60);
            Engine.print("miranda - pain .25 60");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0150_mir()
        {
            await Engine.sleep(132);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0150_mir", 3845129146U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0150_mir", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0160_cor()
        {
            await Engine.sleep(202);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0160_cor", 3845194683U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0160_cor", 4F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0170_mir()
        {
            await Engine.sleep(340);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0170_mir", 3845260220U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0170_mir", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0180_mir()
        {
            await Engine.sleep(418);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0180_mir", 3845325757U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0180_mir", 2F);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            Engine.print("miranda - angry .25 0");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0181_mir()
        {
            await Engine.sleep(483);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0181_mir", 3845391294U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0181_mir", 2F);
            Engine.texture_camera_off();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0190_cor()
        {
            await Engine.sleep(550);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0190_cor", 3845456831U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0190_cor", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0200_mir()
        {
            await Engine.sleep(573);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0200_mir", 3845522368U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0200_mir", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0210_wo1()
        {
            await Engine.sleep(602);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0210_wo1", 3845587905U), weap_officer.Entity, 1F);
            Engine.cinematic_subtitle("x05_0210_wo1", 3F);
            Engine.unit_set_emotional_state(weap_officer.Entity, "pensive", 0.5F, 60);
            Engine.print("weap_officer - pensive .5 60");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0220_mir()
        {
            await Engine.sleep(704);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0220_mir", 3845653442U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x05_0220_mir", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_texture_camera_scene_04()
        {
            Engine.object_create_anew(texture_camera);
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\x05\\x05", 3845718979U), "texture_camera_04", anchor_x05.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_fov_04()
        {
            Engine.time_code_reset();
            await Engine.sleep(588);
            Engine.camera_set_field_of_view(34F, 0);
            Engine.print("fov change: 60 -> 34 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_05_dof_scene_04()
        {
            await Engine.sleep(589);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0F, 0F, 0F, 1F, 1F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(112);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0F, 1F, 0.25F, 1F, 0F, 0.25F);
            Engine.print("rack focus");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_04()
        {
            Engine.cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            Engine.cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_04_bridge_1()
        {
            await Engine.sleep(49);
            Engine.print("light bridge");
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_04_hev_1()
        {
            await Engine.sleep(326);
            Engine.print("light hev");
            Engine.cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            Engine.cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_04_bridge_2()
        {
            await Engine.sleep(467);
            Engine.print("light bridge");
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_04_setup()
        {
            Engine.wake(x05_0130_jon);
            Engine.wake(x05_0140_mir);
            Engine.wake(x05_0150_mir);
            Engine.wake(x05_0160_cor);
            Engine.wake(x05_0170_mir);
            Engine.wake(x05_0180_mir);
            Engine.wake(x05_0181_mir);
            Engine.wake(x05_0190_cor);
            Engine.wake(x05_0200_mir);
            Engine.wake(x05_0210_wo1);
            Engine.wake(x05_0220_mir);
            Engine.wake(x05_texture_camera_scene_04);
            Engine.wake(x05_fov_04);
            Engine.wake(x05_05_dof_scene_04);
            Engine.wake(x05_cinematic_lighting_scene_04);
            Engine.wake(x05_light_scene_04_bridge_1);
            Engine.wake(x05_light_scene_04_hev_1);
            Engine.wake(x05_light_scene_04_bridge_2);
            Engine.wake(x05_foley_04);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_04_cleanup()
        {
            Engine.object_destroy(cigar.Entity);
            Engine.object_destroy(texture_camera.Entity);
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_04()
        {
            await this.x05_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_04", default(IUnit), anchor_flag_x05);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x05\\x05", 3839624038U), "miranda_04", false, anchor_x05.Entity);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3844146091U), "chief_04", false, anchor_x05.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "johnson_04", false, anchor_x05.Entity);
            Engine.custom_animation_relative(nav_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "nav_04", false, anchor_x05.Entity);
            Engine.custom_animation_relative(weap_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "weap_04", false, anchor_x05.Entity);
            Engine.scenery_animation_start_relative(cigar.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\x05\\x05", 3844342702U), "cigar_bent_04", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev01_04", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev02_04", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x05\\x05", 3844473776U), "bridge_04", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_bay.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3844539313U), "hevbay_04", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(delta_halo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3844801461U), "halo_04", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3844866998U), "substance_space_04", anchor_x05.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_05_fol", 3845784516U));
            await Engine.sleep((short)Engine.camera_time());
            await this.x05_04_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_05_fol", 3845784516U), default(IGameObject), 1F);
            Engine.print("x05 foley 05 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0230_mir()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0230_mir", 3845850053U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x05_0230_mir", 6F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_05()
        {
            Engine.cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            Engine.cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_05_setup()
        {
            Engine.wake(x05_0230_mir);
            Engine.wake(x05_foley_05);
            Engine.wake(x05_cinematic_lighting_scene_05);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_05()
        {
            await this.x05_05_setup();
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 34 -> 60 over 0 ticks");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_05", default(IUnit), anchor_flag_x05);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3838640983U), "iac_05", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(delta_halo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3844801461U), "halo_05", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3844866998U), "substance_space_05", anchor_x05.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_06a_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_06a_mus", 3845915590U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06a_fol", 3845981127U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_score_06a()
        {
            await Engine.sleep(113);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\music\\x05_06a_mus", 3845915590U), default(IGameObject), 1F);
            Engine.print("x05 score 06a start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_06a()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06a_fol", 3845981127U), default(IGameObject), 1F);
            Engine.print("x05 foley 06a start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0240_mir()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0240_mir", 3846046664U), default(IGameObject), 1F, "radio_default_in");
            Engine.cinematic_subtitle("x05_0240_mir", 4F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_cinematic_light_scene_06a()
        {
            Engine.cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            Engine.cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_06b_problem_actors()
        {
            Engine.object_create_anew(johnson);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_06a_setup()
        {
            Engine.object_destroy(johnson.Entity);
            Engine.wake(x05_score_06a);
            Engine.wake(x05_foley_06a);
            Engine.wake(x05_0240_mir);
            Engine.wake(x05_cinematic_light_scene_06a);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_06a()
        {
            await this.x05_06a_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_06a", default(IUnit), anchor_flag_x05);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3844146091U), "chief_06a", false, anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev01_06a", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_bay.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3844539313U), "hevbay_06a", anchor_x05.Entity);
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_06b_predict_stub();
            await this.x05_06b_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06b_fol", 3846112201U));
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.cinematic_screen_effect_set_crossfade(1F);
            await Engine.sleep(5);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_06b()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_06b_fol", 3846112201U), default(IGameObject), 1F);
            Engine.print("x05 foley 06b start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0250_mir()
        {
            await Engine.sleep(9);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0250_mir", 3846177738U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0250_mir", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0260_jon()
        {
            await Engine.sleep(89);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0260_jon", 3846243275U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x05_0260_jon", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0270_mir()
        {
            await Engine.sleep(125);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0270_mir", 3846308812U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x05_0270_mir", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0280_mir()
        {
            await Engine.sleep(225);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0280_mir", 3846374349U), default(IGameObject), 1F, "radio_default_out");
            Engine.cinematic_subtitle("x05_0280_mir", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0290_mas()
        {
            await Engine.sleep(320);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0290_mas", 3846439886U), chief.Entity, 1F);
            Engine.cinematic_subtitle("x05_0290_mas", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0300_wo1()
        {
            await Engine.sleep(356);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0300_wo1", 3846505423U), weap_officer.Entity, 1F);
            Engine.cinematic_subtitle("x05_0300_wo1", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_fov_06b()
        {
            await Engine.sleep(358);
            Engine.camera_set_field_of_view(35F, 0);
            Engine.print("fov change: 60 -> 35 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_06b_bridge_1()
        {
            Engine.time_code_reset();
            await Engine.sleep(358);
            Engine.print("light bridge");
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-73F, 160F, 0.117647F, 0.117647F, 0.176471F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_07_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(matte_delta_halo_close);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_06b_setup()
        {
            Engine.wake(x05_0250_mir);
            Engine.wake(x05_0260_jon);
            Engine.wake(x05_0270_mir);
            Engine.wake(x05_0280_mir);
            Engine.wake(x05_0290_mas);
            Engine.wake(x05_0300_wo1);
            Engine.wake(x05_foley_06b);
            Engine.wake(x05_fov_06b);
            Engine.wake(x05_light_scene_06b_bridge_1);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_06b_cleanup()
        {
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(nav_officer.Entity);
            Engine.object_destroy(weap_officer.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_06b()
        {
            await this.x05_06b_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_06b", default(IUnit), anchor_flag_x05);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x05\\x05", 3839624038U), "miranda_06b", false, anchor_x05.Entity);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3844146091U), "chief_06b", false, anchor_x05.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "johnson_06b", false, anchor_x05.Entity);
            Engine.custom_animation_relative(nav_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "nav_06b", false, anchor_x05.Entity);
            Engine.custom_animation_relative(weap_officer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x05\\x05", 3844211628U), "weap_06b", false, anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev01_06b", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev02_06b", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev03_06b", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev04_06b", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\x05\\x05", 3844473776U), "bridge_06b", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_bay.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3844539313U), "hevbay_06b", anchor_x05.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_07_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            await this.x05_07_problem_actors();
            await Engine.sleep((short)Engine.camera_time());
            await this.x05_06b_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_07()
        {
            Engine.cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            Engine.cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_07()
        {
            Engine.wake(x05_cinematic_lighting_scene_07);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_07", default(IUnit), anchor_flag_x05);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3838640983U), "iac_07", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x05\\x05", 3844866998U), "substance_space_07", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_delta_halo_close.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\x05\\x05", 3846570960U), "delta_halo_close_07", anchor_x05.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x05_08_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_08_fol", 3846636497U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_foley_08()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\x05\\foley\\x05_08_fol", 3846636497U), default(IGameObject), 1F);
            Engine.print("x05 foley 08 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_0310_cor()
        {
            await Engine.sleep(9);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\x05_0310_cor", 3846702034U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x05_0310_cor", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_hev_release()
        {
            await Engine.sleep(40);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3846767571U), hev_bay.Entity, "explosive_bolt06");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3846833108U), hev_bay.Entity, "steam_vent06");
            Engine.print("effects - first hev");
            await Engine.sleep(56);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3846767571U), hev_bay.Entity, "explosive_bolt05");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3846833108U), hev_bay.Entity, "steam_vent05");
            Engine.print("effects - second hev");
            await Engine.sleep(37);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3846767571U), hev_bay.Entity, "explosive_bolt04");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3846833108U), hev_bay.Entity, "steam_vent04");
            Engine.print("effects - second hev");
            await Engine.sleep(29);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3846767571U), hev_bay.Entity, "explosive_bolt03");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_launch_steam", 3846833108U), hev_bay.Entity, "steam_vent03");
            Engine.print("effects - second hev");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_corona()
        {
            await Engine.sleep(320);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_start", 3846964182U), hev_10.Entity, "");
            Engine.print("effect - re-entry corona");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_effect_shake_01()
        {
            await Engine.sleep(300);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.5F, 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_cinematic_lighting_scene_08()
        {
            Engine.cinematic_lighting_set_primary_light(8F, 172F, 0.55F, 0.39F, 0.26F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 246F, 0.19F, 0.18F, 0.26F);
            Engine.cinematic_lighting_set_ambient_light(0.04F, 0.04F, 0.05F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_light_scene_08_space()
        {
            await Engine.sleep(172);
            Engine.print("light space");
            Engine.cinematic_lighting_set_primary_light(-21F, 32F, 0.48F, 0.53F, 0.69F);
            Engine.cinematic_lighting_set_secondary_light(-17F, 214F, 0.18F, 0.22F, 0.41F);
            Engine.cinematic_lighting_set_ambient_light(0.11F, 0.11F, 0.14F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task destroy_chief()
        {
            await Engine.sleep(52);
            Engine.object_destroy(chief.Entity);
            Engine.print("destroy chief");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_08_setup()
        {
            Engine.wake(x05_0310_cor);
            Engine.wake(x05_foley_08);
            Engine.wake(destroy_chief);
            Engine.wake(effect_hev_release);
            Engine.wake(effect_corona);
            Engine.wake(x05_effect_shake_01);
            Engine.wake(x05_cinematic_lighting_scene_08);
            Engine.wake(x05_light_scene_08_space);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_08_cleanup()
        {
            Engine.object_destroy(delta_halo.Entity);
            Engine.object_destroy_containing("iac");
            Engine.object_destroy_containing("hev");
            Engine.object_destroy_containing("matte");
            Engine.player_effect_stop(0F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05_scene_08()
        {
            await this.x05_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x05\\x05", 3838575446U), "x05_08", default(IUnit), anchor_flag_x05);
            Engine.scenery_animation_start_relative(iac.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad\\x05\\x05", 3838640983U), "iac_08", anchor_x05.Entity);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x05\\x05", 3844146091U), "chief_08", false, anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev01_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev02_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev03_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev04_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev05_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev06_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(delta_halo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x05\\x05", 3844801461U), "halo_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_bay.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_hevbay\\x05\\x05", 3844539313U), "hevbay_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_delta_halo_close.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\x05\\x05", 3846570960U), "delta_halo_close_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev07_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_08.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev08_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_09.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev09_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_10.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev10_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_11.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev11_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_12.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev12_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_13.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev13_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_14.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev14_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_15.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev15_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_16.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev16_08", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_17.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\x05\\x05", 3844408239U), "hev17_08", anchor_x05.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
            await this.x05_08_cleanup();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task x05()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("bsp_x05"));
            await Engine.sleep(1);
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

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_01_fol", 3847029719U), default(IGameObject), 1F);
            Engine.print("c05_intro foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_1010_cor()
        {
            await Engine.sleep(192);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_1010_cor", 3847095256U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c05_1010_cor", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_burn_contrails()
        {
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3847160793U), corona_02.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3847226330U), corona_02.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3847160793U), corona_03.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3847226330U), corona_03.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3847160793U), corona_04.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3847226330U), corona_04.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3847160793U), corona_05.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3847226330U), corona_05.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3847160793U), corona_06.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3847226330U), corona_06.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_burn", 3847160793U), corona_07.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_reentry_contrail", 3847226330U), corona_07.Entity, "");
            Engine.print("effect - burn, contrail");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_chute_pins()
        {
            await Engine.sleep(259);
            Engine.print("effect - chute pins");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_explosive_bolt", 3846767571U), hev_02.Entity, "cable_release");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_retros_01()
        {
            await Engine.sleep(264);
            Engine.print("effect - retro rockets");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_02.Entity, "retro_rocket");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_dof_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(79);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(20F, 0F, 0F, 0F, 5F, 5F, 0F);
            Engine.print("rack focus");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(-21F, 32F, 0.48F, 0.53F, 0.69F);
            Engine.cinematic_lighting_set_secondary_light(-17F, 214F, 0.18F, 0.22F, 0.41F);
            Engine.cinematic_lighting_set_ambient_light(0.11F, 0.11F, 0.14F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_01.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_02.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_03.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_04.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_05.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_06.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_07.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_chute.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task hev_unhide()
        {
            await Engine.sleep(126);
            Engine.print("hev unhide");
            Engine.object_hide(hev_06.Entity, false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task destroy_corona_02()
        {
            await Engine.sleep(210);
            Engine.print("destroy corona 02");
            Engine.object_destroy(corona_02.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_01_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(hev_01);
            Engine.object_create_anew(hev_02);
            Engine.object_create_anew(hev_03);
            Engine.object_create_anew(hev_04);
            Engine.object_create_anew(hev_05);
            Engine.object_create_anew(hev_06);
            Engine.object_create_anew(hev_07);
            Engine.object_create_anew(hev_chute);
            Engine.object_create_anew(corona_01);
            Engine.object_create_anew(corona_02);
            Engine.object_create_anew(corona_03);
            Engine.object_create_anew(corona_04);
            Engine.object_create_anew(corona_05);
            Engine.object_create_anew(corona_06);
            Engine.object_create_anew(corona_07);
            Engine.object_create_anew(matte_horizon);
            Engine.object_create_anew(matte_islands);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(hev_01.Entity, true);
            Engine.object_cinematic_lod(hev_02.Entity, true);
            Engine.object_cinematic_lod(hev_03.Entity, true);
            Engine.object_cinematic_lod(hev_04.Entity, true);
            Engine.object_cinematic_lod(hev_05.Entity, true);
            Engine.object_cinematic_lod(hev_06.Entity, true);
            Engine.object_cinematic_lod(hev_07.Entity, true);
            Engine.object_cinematic_lod(hev_chute.Entity, true);
            Engine.object_hide(hev_06.Entity, true);
            Engine.wake(c05_1010_cor);
            Engine.wake(c05_intro_foley_01);
            Engine.wake(destroy_corona_02);
            Engine.wake(effect_burn_contrails);
            Engine.wake(hev_unhide);
            Engine.wake(effect_chute_pins);
            Engine.wake(effect_retros_01);
            Engine.wake(c05_intro_dof_01);
            Engine.wake(c05_intro_cinematic_light_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_01_cleanup()
        {
            Engine.object_destroy(chief_intro.Entity);
            Engine.object_destroy_containing("matte");
            Engine.object_destroy(hev_01.Entity);
            Engine.object_destroy(hev_02.Entity);
            Engine.object_destroy(hev_03.Entity);
            Engine.object_destroy(hev_04.Entity);
            Engine.object_destroy(hev_05.Entity);
            Engine.object_destroy(hev_06.Entity);
            Engine.object_destroy(hev_07.Entity);
            Engine.object_destroy_containing("corona");
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltaapproach_intro");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._05_intro_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_01_fol", 3847029719U));
            await Engine.sleep(this.prediction_offset);
            await this.c05_intro_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intro\\05_intro", 3847619552U), "05_intro_01", default(IUnit), anchor_flag_x05);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intro\\05_intro", 3847685089U), "chief_01", false, anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev01_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev02_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev03_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev04_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev05_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev06_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev07_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(hev_chute.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\hev_chute\\05_intro\\05_intro", 3847816163U), "hev_chute_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(corona_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3847881700U), "hev_reentry02_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(corona_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3847881700U), "hev_reentry03_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(corona_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3847881700U), "hev_reentry04_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(corona_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3847881700U), "hev_reentry05_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(corona_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3847881700U), "hev_reentry06_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(corona_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev_reentry\\05_intro\\05_intro", 3847881700U), "hev_reentry07_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_horizon.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\05_intro\\05_intro", 3847947237U), "delta_horizon_01", anchor_x05.Entity);
            Engine.scenery_animation_start_relative(matte_islands.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_islands\\05_intro\\05_intro", 3848012774U), "delta_islands_01", anchor_x05.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_02_fol", 3848078311U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c05_intro_01_cleanup();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task little_alien()
        {
            if ("easy" == Engine.game_difficulty_get_real() // Couldn't generate cast from 'String' to 'GameDifficulty'
            )
            {
                Engine.object_create_anew(tree_toy);
                Engine.objects_attach(grunt_01.Entity, "right_hand", tree_toy.Entity, "");
                await Engine.sleep(150);
                Engine.object_destroy(tree_toy.Entity);
            }

            if ("normal" == Engine.game_difficulty_get_real() // Couldn't generate cast from 'String' to 'GameDifficulty'
            )
            {
                Engine.object_create_anew(grenade_toy_01);
                Engine.object_create_anew(grenade_toy_02);
                Engine.objects_attach(grunt_01.Entity, "right_hand", grenade_toy_01.Entity, "");
                Engine.objects_attach(grunt_01.Entity, "left_hand", grenade_toy_02.Entity, "");
                await Engine.sleep(150);
                Engine.object_destroy(grenade_toy_01.Entity);
                Engine.object_destroy(grenade_toy_02.Entity);
            }

            if ("heroic" == Engine.game_difficulty_get_real() // Couldn't generate cast from 'String' to 'GameDifficulty'
            )
            {
                Engine.object_create_anew(intro_fire);
                await Engine.sleep(150);
                Engine.object_destroy(intro_fire.Entity);
            }

            if ("legendary" == Engine.game_difficulty_get_real() // Couldn't generate cast from 'String' to 'GameDifficulty'
            )
            {
                Engine.object_create_anew(chief_toy);
                Engine.object_create_anew(grunt_toy);
                Engine.objects_attach(grunt_01.Entity, "right_hand", grunt_toy.Entity, "");
                Engine.objects_attach(grunt_01.Entity, "left_hand", chief_toy.Entity, "");
                await Engine.sleep(150);
                Engine.object_destroy(chief_toy.Entity);
                Engine.object_destroy(grunt_toy.Entity);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_02_fol", 3848078311U), default(IGameObject), 1F);
            Engine.print("c05_intro foley 02 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_retros_02()
        {
            await Engine.sleep(1);
            Engine.print("effect - retro-rockets");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_01.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_02.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_03.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_04.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_05.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_06.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_07.Entity, "retro_rocket");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_retros_03()
        {
            await Engine.sleep(310);
            Engine.print("effect - retro-rockets");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_01.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_02.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_03.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_04.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_05.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_06.Entity, "retro_rocket");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_retro_rocket", 3847422941U), hev_close_07.Entity, "retro_rocket");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_dof_02()
        {
            Engine.time_code_reset();
            await Engine.sleep(218);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 1F, 1F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(88);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_cinematic_light_02()
        {
            Engine.cinematic_lighting_set_primary_light(43F, 284F, 0.45F, 0.39F, 0.27F);
            Engine.cinematic_lighting_set_secondary_light(1F, 112F, 0.25F, 0.26F, 0.73F);
            Engine.cinematic_lighting_set_ambient_light(0.11F, 0.12F, 0.07F);
            Engine.object_uses_cinematic_lighting(hev_close_01.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_close_02.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_close_03.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_close_04.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_close_05.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_close_06.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_close_07.Entity, true);
            Engine.object_uses_cinematic_lighting(hev_close_08.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_01.Entity, true);
            Engine.object_uses_cinematic_lighting(jackal_01.Entity, true);
            Engine.object_uses_cinematic_lighting(intro_turret.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task jackal_shield_activate()
        {
            await Engine.sleep(278);
            Engine.print("jackal shield activate");
            Engine.object_create_anew(jackal_shield);
            Engine.objects_attach(jackal_01.Entity, "shield_light", jackal_shield.Entity, "");
            Engine.object_set_function_variable(jackal_01.Entity, "shield", 1F, 1F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_02_setup()
        {
            Engine.object_create_anew(hev_close_01);
            Engine.object_create_anew(hev_close_02);
            Engine.object_create_anew(hev_close_03);
            Engine.object_create_anew(hev_close_04);
            Engine.object_create_anew(hev_close_05);
            Engine.object_create_anew(hev_close_06);
            Engine.object_create_anew(hev_close_07);
            Engine.object_create_anew(hev_close_08);
            Engine.object_create_anew(grunt_01);
            Engine.object_create_anew(jackal_01);
            Engine.object_create_anew(intro_turret);
            Engine.object_cinematic_lod(hev_close_01.Entity, true);
            Engine.object_cinematic_lod(hev_close_02.Entity, true);
            Engine.object_cinematic_lod(hev_close_03.Entity, true);
            Engine.object_cinematic_lod(hev_close_04.Entity, true);
            Engine.object_cinematic_lod(hev_close_05.Entity, true);
            Engine.object_cinematic_lod(hev_close_06.Entity, true);
            Engine.object_cinematic_lod(hev_close_07.Entity, true);
            Engine.object_cinematic_lod(hev_close_08.Entity, true);
            Engine.object_cinematic_lod(grunt_01.Entity, true);
            Engine.object_cinematic_lod(jackal_01.Entity, true);
            Engine.object_cinematic_lod(intro_turret.Entity, true);
            Engine.object_set_function_variable(jackal_01.Entity, "shield", 0F, 0F);
            Engine.wake(c05_intro_foley_02);
            Engine.wake(effect_retros_02);
            Engine.wake(effect_retros_03);
            Engine.wake(c05_intro_dof_02);
            Engine.wake(c05_intro_cinematic_light_02);
            Engine.wake(little_alien);
            Engine.wake(jackal_shield_activate);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_scene_02()
        {
            Engine.cinematic_lightmap_shadow_enable();
            await this._05_intro_02_predict_stub();
            await Engine.sleep(this.prediction_offset);
            await this.c05_intro_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intro\\05_intro", 3847619552U), "05_intro_02", default(IUnit), anchor_flag_intro);
            Engine.custom_animation_relative(grunt_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\05_intro\\05_intro", 3848143848U), "grunt_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(jackal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\05_intro\\05_intro", 3848209385U), "jackal_02", false, anchor_intro.Entity);
            Engine.custom_animation_relative(intro_turret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\c_turret_ap\\05_intro\\05_intro", 3848274922U), "turret_02", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev01_02", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev02_02", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev03_02", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev04_02", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev05_02", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev06_02", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev07_02", anchor_intro.Entity);
            await Engine.sleep(5);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._05_intro_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_03_fol", 3848340459U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intro\\foley\\c05_intro_03_fol", 3848340459U), default(IGameObject), 1F);
            Engine.print("c05_intro foley 03 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_1020_cor()
        {
            await Engine.sleep(439);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_1020_cor", 3848405996U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c05_1020_cor", 2.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_1030_cor()
        {
            await Engine.sleep(552);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_1030_cor", 3848471533U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c05_1030_cor", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_dust()
        {
            Engine.time_code_reset();
            await Engine.sleep(286);
            Engine.effect_new(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_land", 3848537070U), c05_intro_pod_01);
            Engine.print("first pod");
            await Engine.sleep(42);
            Engine.effect_new(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_land", 3848537070U), c05_intro_pod_03);
            Engine.print("second pod");
            await Engine.sleep(29);
            Engine.effect_new(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_land", 3848537070U), c05_intro_pod_02);
            Engine.print("third pod");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_hev_door_release()
        {
            await Engine.sleep(390);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\hev_door_release", 3848668144U), hev_close_06.Entity, "door_release");
            Engine.print("effect - blow pins");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task intro_turret_fire()
        {
            Engine.object_create(turret_handheld);
            Engine.objects_attach(intro_turret.Entity, "primary_trigger", turret_handheld.Entity, "");
            Engine.object_hide(turret_handheld.Entity, true);
            await Engine.sleep(131);
            Engine.print("turret fire");
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("turret_handheld"), 0, true);
            await Engine.sleep(150);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("turret_handheld"), 0, false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task intro_turret_fire_02()
        {
            Engine.object_create(turret_handheld_02);
            Engine.objects_attach(intro_turret_02.Entity, "primary_trigger", turret_handheld_02.Entity, "");
            Engine.object_hide(turret_handheld_02.Entity, true);
            await Engine.sleep(193);
            Engine.print("turret_02 fire");
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("turret_handheld_02"), 0, true);
            await Engine.sleep(160);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("turret_handheld_02"), 0, false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05_intro_fov_03_1()
        {
            await Engine.sleep(161);
            Engine.print("fov switch");
            Engine.camera_set_field_of_view(70F, 0);
            Engine.print("fov change: 60 -> 70 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05_intro_fov_03_2()
        {
            await Engine.sleep(280);
            Engine.print("fov switch");
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 70 -> 60 over 0 ticks");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c05_intro_cinematic_light_03()
        {
            Engine.object_uses_cinematic_lighting(chief_intro.Entity, true);
            Engine.object_uses_cinematic_lighting(smg_01.Entity, true);
            Engine.object_uses_cinematic_lighting(rocket_01.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task late_pods()
        {
            await Engine.sleep(280);
            Engine.scenery_animation_start_relative(hev_close_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev06_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev07_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_08.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev08_03", anchor_intro.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_03_setup()
        {
            Engine.object_create_anew(chief_intro);
            Engine.object_create_anew(rocket_01);
            Engine.object_create_anew(smg_01);
            Engine.object_create_anew(intro_turret_02);
            Engine.object_cinematic_lod(chief_intro.Entity, true);
            Engine.object_cinematic_lod(rocket_01.Entity, true);
            Engine.object_cinematic_lod(smg_01.Entity, true);
            Engine.object_cinematic_lod(intro_turret_02.Entity, true);
            Engine.object_destroy(intro_crate_01.Entity);
            Engine.object_destroy(intro_crate_02.Entity);
            Engine.wake(c05_1020_cor);
            Engine.wake(c05_1030_cor);
            Engine.wake(c05_intro_foley_03);
            Engine.wake(late_pods);
            Engine.wake(effect_dust);
            Engine.wake(effect_hev_door_release);
            Engine.wake(intro_turret_fire);
            Engine.wake(intro_turret_fire_02);
            Engine.wake(_05_intro_fov_03_1);
            Engine.wake(_05_intro_fov_03_2);
            Engine.wake(c05_intro_cinematic_light_03);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_03_cleanup()
        {
            Engine.object_destroy(chief_intro.Entity);
            Engine.object_destroy(grunt_01.Entity);
            Engine.object_destroy(jackal_01.Entity);
            Engine.object_destroy_containing("turret");
            Engine.object_destroy(rocket_01.Entity);
            Engine.object_destroy(smg_01.Entity);
            Engine.object_destroy_containing("hev_close");
            Engine.object_create_anew(intro_crate_01);
            Engine.object_create_anew(intro_crate_02);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro_scene_03()
        {
            await this.c05_intro_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intro\\05_intro", 3847619552U), "05_intro_03", default(IUnit), anchor_flag_intro);
            Engine.custom_animation_relative(grunt_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\05_intro\\05_intro", 3848143848U), "grunt_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(jackal_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\jackal\\05_intro\\05_intro", 3848209385U), "jackal_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(intro_turret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\c_turret_ap\\05_intro\\05_intro", 3848274922U), "turret_03", false, anchor_intro.Entity);
            Engine.custom_animation_relative(intro_turret_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\c_turret_ap\\05_intro\\05_intro", 3848274922U), "turret02_03", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev01_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev02_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev03_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev04_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(hev_close_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\hev\\05_intro\\05_intro", 3847750626U), "hev05_03", anchor_intro.Entity);
            Engine.scenery_animation_start_relative(smg_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\rifle\\smg\\05_intro\\05_intro", 3848733681U), "smg_03", anchor_intro.Entity);
            await Engine.sleep(400);
            Engine.custom_animation_relative(chief_intro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intro\\05_intro", 3847685089U), "chief_03", false, anchor_intro.Entity);
            Engine.scenery_animation_start_relative(rocket_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\support_high\\rocket_launcher\\05_intro\\05_intro", 3848799218U), "rocket_03", anchor_intro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c05_intro_03_cleanup();
            await Engine.sleep(30);
            Engine.cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c05_intro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("bsp_x05"));
            await Engine.sleep(1);
            await this.c05_intro_scene_01();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("bsp_00"));
            await Engine.sleep(1);
            await this.c05_intro_scene_02();
            await this.c05_intro_scene_03();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task long_pause()
        {
            Engine.cs_abort_on_alert(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task forever_pause()
        {
            Engine.cs_pause(-1F);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task abort()
        {
            Engine.cs_pause(0.1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05a_title0()
        {
            await this.cinematic_fade_from_white_bars();
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05a_title1()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05a_title2()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_3);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_lz_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("clear the landing zone for the pelicans.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_lz_clear()
        {
            Engine.print("objective complete:");
            Engine.print("clear the landing zone for the pelicans.");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_bridge_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("extend the bridge, and cross the chasm.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_bridge_clear()
        {
            Engine.print("objective complete:");
            Engine.print("extend the bridge, and cross the chasm.");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_ruins_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("push through the covenant-held ruins.");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_ruins_clear()
        {
            Engine.print("objective complete:");
            Engine.print("push through the covenant-held ruins.");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_tower1_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("reach the towers in the lake.");
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_tower1_clear()
        {
            Engine.print("objective complete:");
            Engine.print("reach the towers in the lake.");
            Engine.objectives_finish_up_to(3);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_01_start()
        {
            Engine.print("music 05a_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_01", 2227643020U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_02_start()
        {
            Engine.print("music 05a_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_02", 2227905168U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_02_stop()
        {
            Engine.print("music 05a_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_02", 2227905168U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_03_start()
        {
            Engine.print("music 05a_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_03", 2228298390U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_03_stop()
        {
            Engine.print("music 05a_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_03", 2228298390U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_04_start()
        {
            Engine.print("music 05a_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_04", 2228691612U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_04_start_alt()
        {
            Engine.print("music 05a_04 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_04", 2228691612U), true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_04_stop()
        {
            Engine.print("music 05a_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_04", 2228691612U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_05_start()
        {
            Engine.print("music 05a_05 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_05", 2229740204U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_05_stop()
        {
            Engine.print("music 05a_05 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_05", 2229740204U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_05a_06_start()
        {
            Engine.print("music 05a_06 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05a_deltaapproach\\05a_music\\05a_06", 2230133426U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
                Engine.kill_volume_enable(kill_bsp00_lz);
                Engine.kill_volume_enable(kill_bsp00_all);
                Engine.kill_volume_disable(kill_bsp01_all);
                Engine.kill_volume_disable(kill_approach_ramp);
                await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
                Engine.kill_volume_enable(kill_bsp01_all);
                Engine.kill_volume_enable(kill_approach_ramp);
                Engine.kill_volume_disable(kill_bsp00_lz);
                Engine.kill_volume_disable(kill_bsp00_all);
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task kill_stragglers()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_ai), this.straggler_no), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_ai), this.straggler_no)) > 100F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_ai), this.straggler_no));
                }

                this.straggler_no = (short)(this.straggler_no + 1);
                if (this.straggler_no > 19)
                {
                    this.straggler_no = 0;
                }

                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lights()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lights_on_01, Engine.players()) == true || Engine.volume_test_objects(vol_lights_on_02, Engine.players()) == true || Engine.volume_test_objects(vol_lights_on_03, Engine.players()) == true || Engine.volume_test_objects(vol_lights_on_04, Engine.players()) == true || Engine.volume_test_objects(vol_lights_on_05, Engine.players()) == true || Engine.volume_test_objects(vol_lights_on_06, Engine.players()) == true);
                Engine.game_can_use_flashlights(true);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lights_on_01, Engine.players()) == false && Engine.volume_test_objects(vol_lights_on_02, Engine.players()) == false && Engine.volume_test_objects(vol_lights_on_03, Engine.players()) == false && Engine.volume_test_objects(vol_lights_on_04, Engine.players()) == false && Engine.volume_test_objects(vol_lights_on_05, Engine.players()) == false && Engine.volume_test_objects(vol_lights_on_06, Engine.players()) == false);
                Engine.game_can_use_flashlights(false);
                return false;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lz_phantom_01_crash()
        {
            Engine.cs_pause(-1F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task lz_phantom_01_blows()
        {
            Engine.cs_run_command_script(LZ_phantom_01.pilot, lz_phantom_01_crash);
            Engine.begin_random(async () => Engine.effect_new_on_object_marker(this.phantom_boom, Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p"), 
                async () => await Engine.sleep((short)Engine.random_range(10, 60)), 
                async () => Engine.print("."), 
                async () => Engine.effect_new_on_object_marker(this.phantom_boom, Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "right_gun"), 
                async () => await Engine.sleep((short)Engine.random_range(10, 60)), 
                async () => Engine.print("."), 
                async () => Engine.effect_new_on_object_marker(this.phantom_boom, Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "left_gun"), 
                async () => await Engine.sleep((short)Engine.random_range(10, 60)), 
                async () => Engine.print("."), 
                async () => Engine.effect_new_on_object_marker(this.phantom_boom, Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "chin_gun"), 
                async () => await Engine.sleep((short)Engine.random_range(10, 60)), 
                async () => Engine.print("."), 
                async () => Engine.effect_new_on_object_marker(this.phantom_boom, Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "target_engine_left"), 
                async () => await Engine.sleep((short)Engine.random_range(10, 60)), 
                async () => Engine.print("."), 
                async () => Engine.effect_new_on_object_marker(this.phantom_boom, Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "target_engine_right"), 
                async () => await Engine.sleep((short)Engine.random_range(10, 60)), 
                async () => Engine.print("."));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task stay_shooting()
        {
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.Static)]
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

            Engine.ai_place(LZ_turrets_01.Squad);
            Engine.ai_set_blind(LZ_turrets_01.Squad, true);
            Engine.cs_run_command_script(LZ_turrets_01.Squad, stay_shooting);
            this.lz_turret_count = (short)(this.lz_turret_count - 1);
            Engine.begin_random(async () =>
            {
                if (this.lz_turret_count > 0)
                {
                    Engine.ai_place(LZ_turrets_02.Squad);
                    Engine.ai_set_blind(LZ_turrets_02.Squad, true);
                    Engine.cs_run_command_script(LZ_turrets_02.Squad, stay_shooting);
                    this.lz_turret_count = (short)(this.lz_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.lz_turret_count > 0)
                {
                    Engine.ai_place(LZ_turrets_03.Squad);
                    Engine.ai_set_blind(LZ_turrets_03.Squad, true);
                    Engine.cs_run_command_script(LZ_turrets_03.Squad, stay_shooting);
                    this.lz_turret_count = (short)(this.lz_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.lz_turret_count > 0)
                {
                    Engine.ai_place(LZ_turrets_04.Squad);
                    Engine.ai_set_blind(LZ_turrets_04.Squad, true);
                    Engine.cs_run_command_script(LZ_turrets_04.Squad, stay_shooting);
                    this.lz_turret_count = (short)(this.lz_turret_count - 1);
                }
            });
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(allies_lz_ledge.Squad, 2);
                Engine.ai_place(LZ_jackals_ridge.Squad, 1);
            }

            if (await this.difficulty_heroic())
            {
                Engine.ai_place(allies_lz_ledge.Squad, 2);
                Engine.ai_place(allies_lz_ridge.Squad, 1);
                Engine.ai_place(LZ_jackals_ridge.Squad, 1);
            }

            if (await this.difficulty_normal())
            {
                Engine.ai_place(allies_lz_ledge.Squad, 2);
                Engine.ai_place(allies_lz_ridge.Squad, 1);
                Engine.ai_place(LZ_jackals_ridge.Squad, 1);
            }

            Engine.object_teleport(await this.player0(), lz_start_player0);
            Engine.object_teleport(await this.player1(), lz_start_player1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_pelican_wait()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lz_all, Engine.players()) == false && await this.player_count() > 0);
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'let's wait for our warthog. unless you really want to walk...'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0370"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task drive_to_overlook_01()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p6"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p7"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p5"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p1"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task drive_to_overlook_02()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p3"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p6"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p7"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p4"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p5"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/p0"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lz_pelican_sighted()
        {
            this.ride_ally_comment_go = true;
            Engine.cs_switch("lz_odst");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("odst: 'here comes our ride!'");
            Engine.cs_play_line("0380");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lz_saddle_up()
        {
            Engine.cs_switch("lz_ally");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'saddle-up!  we're moving out!'");
            Engine.cs_play_line("0050");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_pelican_timer()
        {
            await Engine.sleep(8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot));
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_02.pilot));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lz_pelican_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_09"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_08"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_07"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_06"), 20F);
            this.lz_pelican_in_sight = true;
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_04"), 5F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_04"), Engine.GetReference<ISpatialPoint>("lz_pelicans/p0"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_05"), 1F);
            Engine.ai_set_orders(LZ_allies, allies_lz_hogs);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lz_warthog, Engine.players()) == false && Engine.volume_test_objects(vol_lz_warthog, Engine.ai_actors(all_allies)) == false && await this.player_count() > 0);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_lc");
            await Engine.sleep(45);
            Engine.wake(music_05a_02_start);
            Engine.wake(lz_pelican_timer);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_p");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_pelican_01.Squad) < 4);
            this.lz_pelican_arrived = true;
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_04"), 1F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_06"), 3F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_07"), 20F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_09"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_10"), 20F);
            Engine.ai_erase(LZ_pelican_01.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task other_lz_pelican()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_07"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_06"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_05"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_04"), 10F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_05"));
            await Engine.sleep_until(async () =>
            {
                if (this.lz_pelican_arrived == false)
                {
                    Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_02"), 3F);
                }

                if (this.lz_pelican_arrived == false)
                {
                    Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_03"), 3F);
                }

                return this.lz_pelican_arrived == true;
            });
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_a_05"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_05"), 20F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_07"), 40F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_pelicans/pel_b_08"), 30F);
            Engine.ai_erase(LZ_pelican_02.Squad);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_pelican()
        {
            Engine.ai_place(LZ_pelican_02.Squad);
            Engine.cs_run_command_script(LZ_pelican_02.pilot, other_lz_pelican);
            await Engine.sleep(120);
            Engine.ai_place(allies_lz_pelican.Squad, (short)(2 - (float)Engine.ai_living_count(all_allies)));
            Engine.ai_place(LZ_pelican_01.Squad);
            Engine.ai_place(LZ_warthog_01.Squad);
            Engine.object_cannot_take_damage(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_p", Engine.ai_actors(allies_lz_pelican.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_lc", Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), true);
            Engine.cs_run_command_script(LZ_pelican_01.pilot, lz_pelican_arrives);
            Engine.ai_set_orders(LZ_allies, allies_lz_all);
            await Engine.sleep_until(async () => this.lz_pelican_in_sight == true);
            if (this.lz_pelican_arrived == false)
            {
                await Engine.sleep_until(async () => Engine.ai_scene("lz_pelican_sighted_scene", lz_pelican_sighted, LZ_allies) || (short)Engine.ai_living_count(allies_lz_ledge.Squad) < 1 && (short)Engine.ai_living_count(allies_lz_ridge.Squad) < 1, 30, 150);
                await Engine.sleep(150);
                if (this.ride_ally_comment_go == false)
                {
                    Engine.ai_dialogue_enable(false);
                    await Engine.sleep(60);
                    Engine.print("cortana: 'here comes our ride!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2020"));
                    await Engine.sleep(30);
                    Engine.ai_dialogue_enable(true);
                }
            }

            await Engine.sleep(240);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("johnson: 'i got a good view coming in.'");
            Engine.print("'there's a big building in the middle of this island's lake.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0020"));
            await Engine.sleep(30);
            Engine.print("cortana: 'i saw it too.  it looked like a temple.");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0030"));
            await Engine.sleep(15);
            Engine.print("if i were a megalomaniac - and i'm not - that's where i'd be.");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0040"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep_until(async () => this.lz_pelican_arrived == true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            Engine.ai_set_orders(LZ_allies, allies_lz_hogs);
            Engine.ai_scene("lz_saddle_up_scene", lz_saddle_up, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lz_all, Engine.players()) == false && await this.player_count() > 0 || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) || (bool)Engine.game_is_cooperative() == false);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), false);
            Engine.game_save();
            Engine.ai_enter_squad_vehicles(all_allies);
            this.lz_mounted_up = true;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task short_lz_pel()
        {
            Engine.ai_place(LZ_pelican_02.Squad);
            Engine.cs_run_command_script(LZ_pelican_02.pilot, other_lz_pelican);
            await Engine.sleep(120);
            Engine.ai_place(allies_lz_pelican.Squad, (short)(4 - (float)Engine.ai_living_count(all_allies)));
            Engine.ai_place(LZ_pelican_01.Squad);
            Engine.ai_place(LZ_warthog_01.Squad);
            Engine.object_cannot_take_damage(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_p", Engine.ai_actors(allies_lz_pelican.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_pelican_01.pilot), "pelican_lc", Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver));
            Engine.cs_run_command_script(LZ_pelican_01.pilot, lz_pelican_arrives);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_all) > 1);
            Engine.ai_set_orders(LZ_allies, allies_lz_all);
            await Engine.sleep_until(async () => this.lz_pelican_in_sight == true);
            if (this.lz_pelican_arrived == false)
            {
                await Engine.sleep_until(async () => Engine.ai_scene("lz_pelican_sighted_scene", lz_pelican_sighted, LZ_allies) || (short)Engine.ai_living_count(allies_lz_ledge.Squad) < 1 && (short)Engine.ai_living_count(allies_lz_ridge.Squad) < 1, 30, 150);
                await Engine.sleep(150);
                if (this.ride_ally_comment_go == false)
                {
                    Engine.ai_dialogue_enable(false);
                    await Engine.sleep(60);
                    Engine.print("cortana: 'here comes our ride!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2020"));
                    await Engine.sleep(30);
                    Engine.ai_dialogue_enable(true);
                }
            }

            await Engine.sleep(240);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("johnson: 'i got a good view coming in.'");
            Engine.print("'there's a big building in the middle of this island's lake.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0020"));
            await Engine.sleep(30);
            Engine.print("cortana: 'i saw it too.  it looked like a temple.");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0030"));
            await Engine.sleep(15);
            Engine.print("if i were a megalomaniac - and i'm not - that's where i'd be.");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0040"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep_until(async () => this.lz_pelican_arrived == true);
            Engine.ai_set_orders(LZ_allies, allies_lz_hogs);
            Engine.ai_scene("lz_saddle_up_scene", lz_saddle_up, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            Engine.ai_enter_squad_vehicles(all_allies);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_warthog_01.Squad) > 1);
            Engine.ai_set_orders(LZ_warthog_01.Squad, allies_overlook_pause);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_turret_reminder()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_turrets) < 1, 30, 8000);
            if ((short)Engine.ai_living_count(LZ_enemies_turrets) > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'those turrets will tear the pelicans to shreds! take them out!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0310"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_turrets) < 1, 30, 8000);
            if ((short)Engine.ai_living_count(LZ_enemies_turrets) > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'take out those turrets, chief!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2010"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task odst_warning()
        {
            Engine.cs_switch("lz_odst");
            Engine.cs_start_approach_player(2F, 10F, 10F);
            Engine.cs_abort_on_damage(true);
            Engine.print("odst: 'sir! we gotta neutralize those turrets!'");
            Engine.cs_play_line("0300");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task odst_turrets_down()
        {
            Engine.cs_switch("lz_odst");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("odst: 'clear this lz! the pelicans are right behind us!'");
            Engine.cs_play_line("0010");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_turret_track()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_turrets) < 1);
            Engine.print("all turrets down");
            this.turrets_down = true;
            await Engine.sleep_until(async () => Engine.ai_scene("lz_turrets_down_scene", odst_turrets_down, all_allies) || (short)Engine.ai_living_count(all_allies) < 1, 30, 600);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_phantom_01_drop()
        {
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a03");
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_b01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_b02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_b03");
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c03");
            Engine.ai_set_orders(LZ_elites_phantom_01.Squad, lz_enemies_phantom_01);
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), false);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lz_phantom_arrives_01()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            Engine.cs_vehicle_speed(0.3F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_airspace/pel6"), 2F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("lz_airspace/pel6"), Engine.GetReference<ISpatialPoint>("lz_airspace/p0"), 1F);
            Engine.wake(lz_phantom_01_drop);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("lz_airspace/ph3a"), Engine.GetReference<ISpatialPoint>("lz_airspace/p0"), 1F);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_phantom_01.Squad) < 2, 30, 900);
            this.lz_phantom_01_leaving = true;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_airspace/phxa"));
            Engine.ai_erase(LZ_phantom_01.Squad);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_phantom_02_drop()
        {
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), true);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_a01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_a02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_a03");
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_b01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_b02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_b03");
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c03");
            Engine.ai_set_orders(LZ_elites_phantom_02.Squad, lz_enemies_phantom_02);
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), false);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lz_phantom_arrives_02()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph0b"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph1b"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph2b"));
            Engine.cs_vehicle_speed(0.3F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_airspace/pel6"), 2F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("lz_airspace/pel6"), Engine.GetReference<ISpatialPoint>("lz_airspace/p1"), 1F);
            Engine.wake(lz_phantom_02_drop);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("lz_airspace/ph3b"), Engine.GetReference<ISpatialPoint>("lz_airspace/p1"), 2F);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_phantom_02.Squad) < 2, 30, 900);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph2b"));
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph1b"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph0b"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_airspace/phxb"));
            Engine.ai_erase(LZ_phantom_02.Squad);
            this.lz_phantom_02_leaving = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lz_phantom_arrives_03()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            Engine.cs_vehicle_speed(0.3F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_airspace/ph3a"), 2F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("lz_airspace/ph3a"), Engine.GetReference<ISpatialPoint>("lz_airspace/p0"), 1F);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a03");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_phantom_01.Squad) < 2, 30, 900);
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), false);
            Engine.ai_set_active_camo(LZ_stealth_phantom_03.Squad, true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph2a"));
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph1a"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("lz_airspace/ph0a"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("lz_airspace/phxa"));
            Engine.ai_erase(LZ_phantom_01.Squad);
            this.lz_phantom_03_leaving = true;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task lz_phantom_01_start()
        {
            Engine.ai_place(LZ_phantom_01.Squad);
            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_elites_phantom_01.Squad, 2);
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_jackals_phantom_01.Squad, (short)Engine.random_range(2, 4));
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_grunts_phantom_01.Squad, (short)(6 - (float)Engine.ai_living_count(LZ_jackals_phantom_01.Squad)));
            }

            await Engine.sleep(15);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_c", Engine.ai_actors(LZ_elites_phantom_01.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p", Engine.ai_actors(LZ_grunts_phantom_01.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p", Engine.ai_actors(LZ_jackals_phantom_01.Squad));
            await Engine.sleep(15);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            Engine.cs_run_command_script(LZ_phantom_01.pilot, lz_phantom_arrives_01);
            await Engine.sleep(210);
            Engine.print("saving");
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_phantom_01.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task lz_phantom_02_start()
        {
            Engine.ai_place(LZ_phantom_02.Squad);
            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_elites_phantom_02.Squad, 2);
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_jackals_phantom_02.Squad, (short)Engine.random_range(2, 4));
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_grunts_phantom_02.Squad, (short)(6 - (float)Engine.ai_living_count(LZ_jackals_phantom_02.Squad)));
            }

            await Engine.sleep(15);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c", Engine.ai_actors(LZ_elites_phantom_02.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", Engine.ai_actors(LZ_jackals_phantom_02.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", Engine.ai_actors(LZ_grunts_phantom_02.Squad));
            await Engine.sleep(15);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), true);
            Engine.cs_run_command_script(LZ_phantom_02.pilot, lz_phantom_arrives_02);
            await Engine.sleep(150);
            Engine.print("saving");
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_phantom_02.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task lz_phantom_03_start()
        {
            Engine.ai_place(LZ_phantom_01.Squad);
            Engine.ai_place(LZ_stealth_phantom_03.Squad, 3);
            await Engine.sleep(15);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a01", Engine.ai_actors(LZ_stealth_phantom_03._1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a02", Engine.ai_actors(LZ_stealth_phantom_03._2));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), "phantom_p_a03", Engine.ai_actors(LZ_stealth_phantom_03._3));
            await Engine.sleep(15);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot), true);
            Engine.cs_run_command_script(LZ_phantom_01.pilot, lz_phantom_arrives_03);
            await Engine.sleep(210);
            Engine.print("saving");
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_phantom_01.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_01.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task short_lz_ph_02()
        {
            Engine.ai_allegiance(prophet, covenant);
            Engine.ai_place(LZ_phantom_02.Squad);
            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_elites_phantom_02.Squad, 2);
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_jackals_phantom_02.Squad, (short)Engine.random_range(2, 4));
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_grunts_phantom_02.Squad, (short)(7 - (float)Engine.ai_living_count(LZ_jackals_phantom_02.Squad)));
            }

            await Engine.sleep(15);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p_c", Engine.ai_actors(LZ_elites_phantom_02.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", Engine.ai_actors(LZ_jackals_phantom_02.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), "phantom_p", Engine.ai_actors(LZ_grunts_phantom_02.Squad));
            await Engine.sleep(15);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_phantom_02.pilot), true);
            Engine.cs_run_command_script(LZ_phantom_02.pilot, lz_phantom_arrives_02);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lz_start()
        {
            Engine.data_mine_set_mission_segment("05a_1_landing_zone");
            Engine.game_save();
            Engine.wake(lz_turret_track);
            Engine.wake(lz_turret_reminder);
            await Engine.sleep(5);
            Engine.ai_scene("lz_intro_inform_scene", odst_warning, allies_lz_ledge.Squad) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await Engine.sleep(120);
            Engine.ai_place(LZ_grunts_ledge.Squad, 3);
            Engine.ai_set_blind(LZ_turrets_01.Squad, false);
            Engine.ai_set_blind(LZ_turrets_02.Squad, false);
            Engine.ai_set_blind(LZ_turrets_03.Squad, false);
            Engine.ai_set_blind(LZ_turrets_04.Squad, false);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_entry_ledge, Engine.players()) == false && await this.player_count() > 0 || (short)Engine.ai_living_count(LZ_enemies_all) < 3);
            Engine.game_save();
            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_jackals_ridge.Squad, (short)(2 - (float)Engine.ai_living_count(LZ_jackals_ridge.Squad)));
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_grunts_ridge.Squad, (short)(3 - (float)Engine.ai_living_count(LZ_grunts_ledge.Squad)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lz_leaving_ridge, Engine.players()) == true || (short)Engine.ai_living_count(LZ_enemies_all) < 1);
            Engine.ai_place(LZ_jackals_structure.Squad, 1);
            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_elites_yard.Squad, 2);
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_jackals_yard.Squad, (short)(2 - (float)Engine.ai_living_count(LZ_jackals_ridge.Squad)));
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_grunts_yard.Squad, (short)(3 - (float)Engine.ai_living_count(LZ_grunts_ledge.Squad) + (float)Engine.ai_living_count(LZ_grunts_ridge.Squad)));
            }

            Engine.game_save();
            await Engine.sleep(30);
            Engine.wake(music_05a_01_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lz_in_yard_01, Engine.players()) == true || (short)Engine.ai_living_count(LZ_enemies_all) < 3);
            Engine.game_save();
            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_elites_structure.Squad, (short)(2 - (float)Engine.ai_living_count(LZ_elites_yard.Squad)));
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_grunts_structure.Squad, (short)(5 - (float)Engine.ai_living_count(LZ_enemies_yard)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lz_in_yard_02, Engine.players()) == true || (short)Engine.ai_living_count(LZ_enemies_all) < 3);
            Engine.game_save();
            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_elites_bunkered.Squad, (short)(2 - (float)Engine.ai_living_count(LZ_elites_yard.Squad) + (float)Engine.ai_living_count(LZ_elites_structure.Squad)));
            }

            if ((short)Engine.ai_living_count(LZ_enemies_all) < 11)
            {
                Engine.ai_place(LZ_grunts_bunkered.Squad, (short)(5 - (float)Engine.ai_living_count(LZ_enemies_structure)));
            }

            await Engine.sleep_until(async () => this.turrets_down == true && (short)Engine.ai_living_count(LZ_enemies_all) < 1, 30, 1800);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", LZ_enemies_all) == true);
            await Engine.sleep(90);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'artillery disabled, sergeant! landing zone secure�for the moment.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0320"));
            await Engine.sleep(30);
            Engine.print("johnson: 'i hear ya. starting our approach. hang tight.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0330"));
            await Engine.sleep(60);
            Engine.print("cortana: 'easier said than done�inbound phantoms, chief!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0340"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await this.lz_phantom_01_start();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_all) < 1, 30, 8000);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", LZ_enemies_all) == true);
            if (await this.difficulty_legendary())
            {
                await Engine.sleep(60);
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'another phantom! on approach!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0350"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                await this.lz_phantom_02_start();
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_all) < 1, 30, 8000);
                await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", LZ_enemies_all) == true);
                await this.lz_phantom_03_start();
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_all) < 1, 30, 4000);
                await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", LZ_enemies_all) == true);
                Engine.wake(lz_pelican);
                Engine.wake(objective_lz_clear);
            }
            else
            {
                await Engine.sleep(60);
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'another phantom! on approach!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0350"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                await this.lz_phantom_02_start();
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(LZ_enemies_all) < 1, 30, 8000);
                await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", LZ_enemies_all) == true);
                Engine.wake(lz_pelican);
                Engine.wake(objective_lz_clear);
            }

            await Engine.sleep(90);
            if (this.lz_pelican_in_sight == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'hold here until the pelican arrives, chief.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0360"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            Engine.game_save();
            Engine.wake(lz_pelican_wait);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task overlook_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_all, Engine.players()) == true, 30, 5400);
            if (Engine.volume_test_objects(vol_bridge_all, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'let's get moving before we're spotted, alright?'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0430"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task overlook_remark()
        {
            Engine.cs_switch("overlook_ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'whoa�'");
            Engine.cs_play_line("0390");
            await Engine.sleep(30);
            Engine.print("ally: 'it's like a postcard.'");
            Engine.cs_play_line("0400");
            await Engine.sleep(30);
            Engine.print("ally: 'dear, sarge: kicking ass in outer space. wish you were here.'");
            Engine.cs_play_line("0410");
            await Engine.sleep(30);
            Engine.print("johnson: 'i heard that, jackass.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0420"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task overlook_wander1()
        {
            Engine.cs_abort_on_alert(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/jack01")), 
                    async () => Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/jack02")), 
                    async () => Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/jack06")), 
                    async () => Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("overlook/jack05")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("overlook/jack05")));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task overlook_wander2()
        {
            Engine.cs_abort_on_alert(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/jack03")), 
                    async () => Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("overlook/jack_look")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/jack04")), 
                    async () => Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("overlook/jack_look2")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("overlook/jack_look2")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("overlook/jack05")), 
                    async () => Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("overlook/jack06")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("overlook/jack06")));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task overlook_start()
        {
            Engine.ai_disposable(LZ_enemies_all, true);
            Engine.data_mine_set_mission_segment("05a_2_overlook");
            Engine.wake(overlook_reminder);
            Engine.game_save();
            Engine.ai_place(overlook_jackals_01.Squad, 2);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(overlook_jackals_02.Squad, 2);
            }

            if (await this.difficulty_heroic())
            {
                Engine.ai_place(overlook_jackals_02.Squad, 1);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_overlook_pause, Engine.players()) == true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(overlook_jackals) < 1 || Engine.volume_test_objects(vol_bridge_all, Engine.players()) == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_all, Engine.players()) == true || Engine.ai_scene("overlook_remark_scene", overlook_remark, all_allies) || (short)Engine.ai_living_count(all_allies) < 1, 30, 300);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_cortana_comment()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'the covenant has control of the bridge ahead.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0440"));
            await Engine.sleep(15);
            Engine.print("'they're going to try and bottle us up on this side of the gorge!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0450"));
            await Engine.sleep(30);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_near_bunker, Engine.players()) == true);
            Engine.print("cortana: 'the controls to extend the bridge should be in this structure!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0460"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_wraith_warn()
        {
            this.wraith_warning_go = true;
            Engine.cs_switch("bridge_ally");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'watch out, chief!  wraiths on the far side!'");
            Engine.cs_play_line("0480");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_wraith_warning()
        {
            await Engine.sleep(300);
            await Engine.sleep_until(async () => Engine.ai_scene("bridge_wraith_warn_scene", bridge_wraith_warn, all_allies) || (short)Engine.ai_living_count(all_allies) < 1, 30, 150);
            await Engine.sleep(30);
            if (this.wraith_warning_go == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'watch out, chief!  wraiths on the far side!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2030"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_phantom_01a()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph1"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph2"), 1F);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_01.Squad) < 2);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel5"), Engine.GetReference<ISpatialPoint>("bridge_airspace/ph1"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph1"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/phx"), 20F);
            Engine.ai_erase(bridge_phantom_01.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_phantom_01b()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph1too"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph3"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph4"), 1F);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_01.Squad) < 2);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph3"), Engine.GetReference<ISpatialPoint>("bridge_airspace/ph1"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph1too"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph0"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/phx"), 20F);
            Engine.ai_erase(bridge_phantom_01.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_phantom_02a()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel0"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel1"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel2"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel4"), 5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph2"), 1F);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_02.Squad) < 2);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel5"), Engine.GetReference<ISpatialPoint>("bridge_airspace/pel4"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel4"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel3"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel1"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel0"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pelx"), 5F);
            Engine.ai_erase(bridge_phantom_02.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_phantom_02b()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel0"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel1"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel2"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph3"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph4"), 1F);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_02.Squad) < 2);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bridge_airspace/ph3"), Engine.GetReference<ISpatialPoint>("bridge_airspace/pel2"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel3"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel1"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel0"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pelx"), 5F);
            Engine.ai_erase(bridge_phantom_02.Squad);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_01a()
        {
            Engine.ai_place(bridge_phantom_01.Squad);
            Engine.ai_place(bridge_phantom_ghosts_02.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2));
            await Engine.sleep(60);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), true);
            Engine.cs_run_command_script(bridge_phantom_01.pilot, bridge_phantom_01a);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_01b()
        {
            Engine.ai_place(bridge_phantom_01.Squad);
            Engine.ai_place(bridge_phantom_ghosts_01.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._2));
            await Engine.sleep(60);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot), true);
            Engine.cs_run_command_script(bridge_phantom_01.pilot, bridge_phantom_01b);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_02a()
        {
            Engine.ai_place(bridge_phantom_02.Squad);
            Engine.ai_place(bridge_phantom_ghosts_02.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2));
            await Engine.sleep(60);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), true);
            Engine.cs_run_command_script(bridge_phantom_02.pilot, bridge_phantom_02a);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task bridge_phantom_reinforce_02b()
        {
            Engine.ai_place(bridge_phantom_02.Squad);
            Engine.ai_place(bridge_phantom_ghosts_02.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2));
            await Engine.sleep(60);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_02.pilot), true);
            Engine.cs_run_command_script(bridge_phantom_02.pilot, bridge_phantom_02b);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_phantom_01.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_01.pilot));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_ghostman_r()
        {
            Engine.cs_abort_on_alert(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/b1")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/b2")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/b3")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/b4")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/b5")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)));
                return (short)Engine.ai_combat_status(this.ai_current_actor) > this.ai_combat_status_idle;
            });
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/r"));
            await Engine.sleep(5);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), false);
            await Engine.sleep(5);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_ghostman_l()
        {
            Engine.cs_abort_on_alert(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/a1")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/a2")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/a3")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/a4")), 
                    async () => await Engine.sleep((short)Engine.random_range(30, 90)));
                return (short)Engine.ai_combat_status(this.ai_current_actor) > this.ai_combat_status_idle;
            });
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/l"));
            await Engine.sleep(5);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), false);
            await Engine.sleep(5);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l));
        }

        [ScriptMethod(Lifecycle.Dormant)]
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

            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(bridge_enemies_bunker) > this.ai_combat_status_idle);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_ghost_elites.Squad) < 1, 30, 300);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), false);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), false);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_vehicles_all) > 0, 30, 450);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_vehicles_all) < 1 || Engine.volume_test_objects(vol_bridge_ghost_spawn, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true);
                if (Engine.volume_test_objects(vol_bridge_ghost_spawn, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true)
                {
                    Engine.sleep_forever();
                }

                if (this.bridge_vehicles_total > 0)
                {
                    Engine.game_save();
                    Engine.ai_place(bridge_phantom_ghosts_01.Squad, 1);
                }

                await Engine.sleep((short)Engine.random_range(60, 120));
                if (Engine.volume_test_objects(vol_bridge_ghost_spawn, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true)
                {
                    Engine.sleep_forever();
                }

                if (this.bridge_vehicles_total > 0)
                {
                    Engine.game_save();
                    Engine.ai_place(bridge_phantom_ghosts_01.Squad, 1);
                }

                this.bridge_vehicles_total = (short)(this.bridge_vehicles_total - 1);
                return this.bridge_vehicles_total <= 0 || Engine.volume_test_objects(vol_bridge_ghost_spawn, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true;
            });
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_vehicles_all) < 1 && (short)Engine.ai_living_count(bridge_bunker_turrets.Squad) < 1);
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_activate_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true, 30, 16000);
            if (Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'get into that structure and find the controls to extend the bridge!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0470"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_cortana_response()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'a sermon, actually.  i've been listening to him since we landed.'");
            Engine.print("cortana: 'so far it's the standard covenant liturgy,'");
            Engine.print("cortana: 'but i'll translate if he says anything interesting.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0080"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_holo_comment()
        {
            this.regret_ally_comment_go = true;
            Engine.cs_switch("bridge_marine");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("marine: 'isn't that our target?'");
            Engine.cs_play_line("0060");
            await Engine.sleep(30);
            Engine.print("marine: 'what's he doing?  giving a speech?'");
            Engine.cs_play_line("0070");
            Engine.wake(bridge_cortana_response);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bunker_holo_looper()
        {
            Engine.object_create(regret01);
            Engine.objects_attach(bunker_throne.Entity, "driver", regret01.Entity, "");
            Engine.ai_disregard(regret01.Entity, true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant1a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3000"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2b", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3001"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3002"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3003"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3004"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant5a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3005"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.bunker_holo_trans == false)
                    {
                        this.bunker_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant6a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3006"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.bunker_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_holo_translate()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_enemies_bunker) < 1 && Engine.volume_test_objects(vol_bunker_upper_level, Engine.players()) == true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(all_allies) < 1 || Engine.ai_scene("bridge_holo_scene", bridge_holo_comment, all_allies), 30, 300);
            await Engine.sleep(30);
            if (this.regret_ally_comment_go == false && Engine.volume_test_objects(vol_bunker_upper_level, Engine.players()) == true)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'regret's giving a speech - a sermon to be exact.'");
                Engine.print("'so far it's the standard covenant liturgy, but i'll translate if he says anything interesting.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2110"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_upper_level, Engine.players()) == true && (short)Engine.ai_living_count(bridge_enemies_bunker) < 1);
            await Engine.sleep(60);
            this.bunker_holo_trans = true;
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), regret01.Entity, 30F) == true && Engine.volume_test_objects(vol_bunker_upper_level, Engine.players()) == true && this.bunker_holo_chant == false);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_l05_0090_por", true);
            Engine.print("regret: 'the forerunners, our most exalted lords, used the seven sacred rings...'");
            Engine.print("'...to flee a doomed existence - to escape their endless struggle against the flood!'");
            await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "0090"));
            await Engine.sleep(30);
            Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_l05_0100_por", true);
            Engine.print("'long ago, the prophets and elites fought an equally fruitless war.'");
            Engine.print("'indeed, i suspect we would still be at each other's throats had the prophets...'");
            Engine.print("'...not found evidence of the forerunners and their great journey!'");
            await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "0100"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep((short)Engine.random_range(240, 480));
            this.bunker_holo_trans = false;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_ally_comment()
        {
            Engine.cs_switch("bridge_ally");
            Engine.cs_enable_pathfinding_failsafe(true);
            this.bridge_ally_comment_go = true;
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'good. the bridge is down. now about those wraiths�'");
            Engine.cs_play_line("0490");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task crack_spawn()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(bridge_enemies_bunker) > this.ai_combat_status_idle);
            if (await this.difficulty_heroic())
            {
                Engine.ai_place(bridge_crack_jackals.Squad, 1);
            }

            if (await this.difficulty_normal())
            {
                Engine.ai_place(bridge_crack_jackals.Squad, 2);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bunker_turret_remanning()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == false && await this.player_count() > 0 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_01), "c_turret_ap_d", Engine.ai_actors(all_enemies)) == false && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_01)) > 0F && (short)Engine.ai_living_count(bunker_turret_remen.Squad) < 1)
                {
                    Engine.ai_place(bunker_turret_remen._1);
                    await Engine.sleep(5);
                    Engine.ai_vehicle_enter(bunker_turret_remen.Squad, Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_01));
                }

                if (Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == false && await this.player_count() > 0 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_02), "c_turret_ap_d", Engine.ai_actors(all_enemies)) == false && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_02)) > 0F && (short)Engine.ai_living_count(bunker_turret_remen.Squad) < 1)
                {
                    Engine.ai_place(bunker_turret_remen._2);
                    await Engine.sleep(5);
                    Engine.ai_vehicle_enter(bunker_turret_remen.Squad, Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_02));
                }

                if (Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == false && await this.player_count() > 0 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_03), "c_turret_ap_d", Engine.ai_actors(all_enemies)) == false && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_03)) > 0F && (short)Engine.ai_living_count(bunker_turret_remen.Squad) < 1)
                {
                    Engine.ai_place(bunker_turret_remen._3);
                    await Engine.sleep(5);
                    Engine.ai_vehicle_enter(bunker_turret_remen.Squad, Engine.ai_vehicle_get_from_starting_location(bridge_bunker_turrets.bunker_03));
                }

                return Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true || (short)Engine.ai_spawn_count(bunker_turret_remen.Squad) > 5;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bunker_upper_spawn_01()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_front, Engine.players()) == true || (short)Engine.ai_living_count(bridge_enemies_bunker) < 1);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_bunker_elites) < 2)
            {
                Engine.ai_place(bridge_bunker_elites_01.Squad, 1);
            }

            Engine.ai_place(bridge_bunker_grunts_01.Squad, (short)((float)Engine.random_range(1, 3) - (float)Engine.ai_living_count(bridge_bunker_grunts)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_front, Engine.players()) == true || (short)Engine.ai_living_count(bridge_enemies_bunker) < 1);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_enemies_bunker) < 1 && Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(bridge_bunker_elites) < 2)
                {
                    Engine.ai_place(bridge_bunker_elites_01.Squad, 1);
                }

                Engine.ai_place(bridge_bunker_jackals_01.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_bunker_jackals)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_front, Engine.players()) == true || (short)Engine.ai_living_count(bridge_enemies_bunker) < 1);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_enemies_bunker) < 1 && Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(bridge_bunker_elites) < 2)
                {
                    Engine.ai_place(bridge_bunker_elites_01.Squad, (short)(1 - (float)Engine.ai_living_count(bridge_bunker_elites)));
                }

                Engine.ai_place(bridge_bunker_jackals_01.Squad, (short)(1 - (float)Engine.ai_living_count(bridge_bunker_jackals)));
                Engine.ai_set_orders(bridge_bunker_elites_01.Squad, bridge_bunker_in_upper_01);
                Engine.ai_set_orders(bridge_bunker_jackals_01.Squad, bridge_bunker_in_upper_01);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bunker_upper_spawn_03()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_upper_level, Engine.players()) == true || Engine.volume_test_objects(vol_bunker_roof, Engine.players()) == true || Engine.volume_test_objects(vol_bunker_spawnstop_01, Engine.players()) == true || Engine.volume_test_objects(vol_bunker_spawnstop_02, Engine.players()) == true || Engine.volume_test_objects(vol_bunker_spawnstop_03, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(music_05a_03_start);
            Engine.ai_place(bridge_control_elites_01.Squad, 1);
            Engine.ai_place(bridge_control_jackals_01.Squad, (short)Engine.random_range(0, 3));
            Engine.ai_place(bridge_control_grunts_01.Squad, (short)(3 - (float)Engine.ai_living_count(bridge_control_jackals_01.Squad)));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bunker_lower_spawn_01()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_backdoor, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_bunker_elites) < 2)
            {
                Engine.ai_place(bridge_backdoor_elites_01.Squad, 1);
            }

            Engine.ai_place(bridge_backdoor_grunts_01.Squad, (short)((float)Engine.random_range(1, 3) - (float)Engine.ai_living_count(bridge_bunker_grunts)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_backdoor, Engine.players()) == true || (short)Engine.ai_living_count(bridge_enemies_bunker) < 1);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_enemies_bunker) < 1 && Engine.volume_test_objects(vol_bunker_lower_level, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(bridge_bunker_elites) < 2)
                {
                    Engine.ai_place(bridge_backdoor_elites_01.Squad, 1);
                }

                Engine.ai_place(bridge_backdoor_jackals_01.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_bunker_jackals)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_backdoor, Engine.players()) == true || (short)Engine.ai_living_count(bridge_enemies_bunker) < 1);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_enemies_bunker) < 1 && Engine.volume_test_objects(vol_bunker_lower_level, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(bridge_bunker_elites) < 2)
                {
                    Engine.ai_place(bridge_backdoor_elites_01.Squad, (short)(1 - (float)Engine.ai_living_count(bridge_bunker_elites)));
                }

                Engine.ai_place(bridge_backdoor_jackals_01.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_bunker_jackals)));
                Engine.ai_set_orders(bridge_backdoor_elites_01.Squad, bridge_bunker_in_lower_02);
                Engine.ai_set_orders(bridge_backdoor_jackals_01.Squad, bridge_bunker_in_lower_02);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bunker_spawn_checker()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_upper_level, Engine.players()) == true || Engine.volume_test_objects(vol_bunker_spawnstop_01, Engine.players()) == true || Engine.volume_test_objects(vol_bunker_spawnstop_02, Engine.players()) == true || Engine.volume_test_objects(vol_bunker_spawnstop_03, Engine.players()) == true);
            Engine.sleep_forever(bunker_upper_spawn_01);
            Engine.sleep_forever(bunker_lower_spawn_01);
            Engine.sleep_forever(bunker_turret_remanning);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_pelican_wait()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_middle, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_farside_all, Engine.players()) == true);
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player0()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player1()) == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'you don't want the tank?  o-kay�i guess we'll leave it for the others.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0510"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            Engine.wake(music_05a_04_start);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_cross_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_farside_all, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_bridge_farside_all, Engine.players()) == false && (short)Engine.ai_living_count(bridge_farside_wraiths.Squad) > 0 && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'let's head across the bridge and deal with those wraiths.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0520"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task banshee_boost()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 50F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_pelican_timer()
        {
            await Engine.sleep(8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task gimme_tank()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel0"), 50F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel1"), 50F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel2"), 50F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel3"), 50F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel4"), 20F);
            this.bridge_pelican_in_sight = true;
            Engine.cs_vehicle_boost(false);
            Engine.ai_set_orders(bridge_pelican_chasers.Squad, bridge_air);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel4too"), 3F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel6"), 3F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel6"), Engine.GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel7"), Engine.GetReference<ISpatialPoint>("bridge_airspace/pel5"), 1F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_tank, Engine.players()) == false && Engine.volume_test_objects(vol_bridge_tank, Engine.ai_actors(all_allies)) == false && await this.player_count() > 0);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_lc");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound_remastered\\vehicles\\scorpion\\scorpion_drop\\mono", 2230461111U), bridge_tank.Entity, 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound_remastered\\vehicles\\scorpion\\scorpion_drop\\reflections", 2230526648U), bridge_tank.Entity, 1F);
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_p");
            this.bridge_pelican_arrived = true;
            Engine.wake(bridge_pelican_timer);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_pelican.Squad) < 4);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel6"), 2F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel4"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel1"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pel0"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bridge_airspace/pelx"), 20F);
            Engine.ai_erase(bridge_pelican.Squad);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_pelican_run()
        {
            Engine.ai_place(allies_bridge_pelican.Squad, (short)(2 - (float)Engine.ai_living_count(all_allies)));
            Engine.ai_place(bridge_pelican.Squad);
            Engine.ai_place(bridge_tank1.Squad);
            Engine.object_cannot_take_damage(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_p", Engine.ai_actors(allies_bridge_pelican.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_lc", Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), true);
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", true);
            Engine.cs_run_command_script(bridge_pelican.pilot, gimme_tank);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task short_bridge_pel()
        {
            Engine.ai_place(allies_bridge_pelican.Squad, (short)(2 - (float)Engine.ai_living_count(all_allies)));
            Engine.ai_place(bridge_pelican.Squad);
            Engine.ai_place(bridge_tank1.Squad);
            Engine.object_cannot_take_damage(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_p", Engine.ai_actors(allies_bridge_pelican.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), "pelican_lc", Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_pelican.pilot), true);
            Engine.cs_run_command_script(bridge_pelican.pilot, gimme_tank);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_banshee_spawn()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_farside_wraiths.Squad) < 1 || Engine.volume_test_objects(vol_winding_path, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_winding_path, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }

            if (Engine.volume_test_objects(vol_winding_path, Engine.players()) == false && await this.difficulty_normal() || await this.difficulty_heroic())
            {
                Engine.ai_place(bridge_banshees.Squad, 1);
                Engine.cs_run_command_script(bridge_banshees.Squad, banshee_boost);
            }

            if (await this.difficulty_legendary() && Engine.volume_test_objects(vol_winding_path, Engine.players()) == false)
            {
                Engine.ai_place(bridge_banshees.Squad, 2);
                Engine.cs_run_command_script(bridge_banshees.Squad, banshee_boost);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_banshees.Squad) < 1 || Engine.volume_test_objects(vol_winding_path, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_winding_path, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }

            if (Engine.volume_test_objects(vol_winding_path, Engine.players()) == false && await this.difficulty_normal() || await this.difficulty_heroic())
            {
                Engine.ai_place(bridge_banshees.Squad, 1);
                Engine.cs_run_command_script(bridge_banshees.Squad, banshee_boost);
            }

            if (await this.difficulty_legendary() && Engine.volume_test_objects(vol_winding_path, Engine.players()) == false)
            {
                Engine.ai_place(bridge_banshees.Squad, 2);
                Engine.cs_run_command_script(bridge_banshees.Squad, banshee_boost);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task farside_ghosts_spawn()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_middle, Engine.players()) == true && Engine.device_get_position(da_bridge.Entity) == 0F);
            Engine.ai_place(bridge_farside_ghosts.Squad, 2);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_winding_path, Engine.players()) == true || (short)Engine.ai_living_count(bridge_farside_ghosts.Squad) < 1);
            if (Engine.volume_test_objects(vol_winding_path, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_living_count(bridge_farside_ghosts.Squad) < 1)
            {
                Engine.ai_place(bridge_farside_ghosts.Squad, 2);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_spare_ghost_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && Engine.objects_can_see_flag(Engine.players(), extra_ghost_01, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), extra_ghost_01) > 5F)
                {
                    Engine.ai_place(bridge_free_ghost._1);
                }

                if (Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && Engine.objects_can_see_flag(Engine.players(), extra_ghost_02, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), extra_ghost_02) > 5F)
                {
                    Engine.ai_place(bridge_free_ghost._2);
                }

                if (Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && Engine.objects_can_see_flag(Engine.players(), extra_ghost_03, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), extra_ghost_03) > 5F)
                {
                    Engine.ai_place(bridge_free_ghost._3);
                }

                if (Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) < 1 && Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) < 1 && Engine.objects_can_see_flag(Engine.players(), extra_ghost_04, 45F) == false && Engine.objects_distance_to_flag(Engine.players(), extra_ghost_04) > 5F)
                {
                    Engine.ai_place(bridge_free_ghost._4);
                }

                return Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._1)) > 0 || Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._2)) > 0 || Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._3)) > 0 || Engine.list_count(Engine.ai_vehicle_get_from_starting_location(bridge_free_ghost._4)) > 0;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_wraith_engage()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/p0"));
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true, Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver));
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_visible);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridges_start()
        {
            Engine.device_set_position_immediate(da_bridge.Entity, 0.5F);
            Engine.device_set_position(real_bridge.Entity, 1F);
            Engine.object_create(waterfall_far);
            Engine.object_create(waterfall_close);
            Engine.wake(bunker_holo_looper);
            Engine.ai_place(bridge_bunker_ghosts.Squad);
            Engine.ai_place(bridge_ghost_elites.Squad, 2);
            Engine.cs_run_command_script(bridge_ghost_elites.r, bridge_ghostman_r);
            Engine.cs_run_command_script(bridge_ghost_elites.l, bridge_ghostman_l);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), true);
            await Engine.sleep(15);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(bridge_bunker_turrets.Squad, 4);
            }

            if (await this.difficulty_heroic())
            {
                Engine.ai_place(bridge_bunker_turrets.Squad, 3);
            }

            if (await this.difficulty_normal())
            {
                Engine.ai_place(bridge_bunker_turrets.Squad, 2);
            }

            Engine.cs_run_command_script(bridge_bunker_turrets.Squad, stay_shooting);
            await Engine.sleep(15);
            Engine.wake(crack_spawn);
            Engine.wake(bunker_upper_spawn_03);
            Engine.wake(bunker_spawn_checker);
            Engine.wake(bridge_ghosts_by_phantom);
            Engine.wake(bunker_turret_remanning);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_pause, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("05a_3_bridge");
            Engine.wake(music_05a_02_stop);
            Engine.device_set_position(da_bridge.Entity, 1F);
            await Engine.sleep(60);
            Engine.wake(bridge_cortana_comment);
            Engine.wake(bridge_activate_reminder);
            Engine.device_group_change_only_once_more_set(da_bridge1, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_engage, Engine.players()) == true);
            Engine.ai_place(bridge_farside_wraiths.Squad, 1);
            Engine.cs_run_command_script(bridge_farside_wraiths.Squad, bridge_wraith_engage);
            Engine.wake(bridge_wraith_warning);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true);
            Engine.sleep_forever(bridge_ghosts_by_phantom);
            await Engine.sleep_until(async () =>
            {
                this.bridge_state = Engine.device_get_position(da_bridge.Entity);
                await Engine.sleep(15);
                return Engine.device_get_position(da_bridge.Entity) < this.bridge_state;
            });
            Engine.wake(music_05a_03_stop);
            Engine.wake(bridge_pelican_run);
            Engine.wake(lights);
            Engine.ai_set_orders(all_allies, bridge_tank_wait);
            Engine.game_save();
            Engine.wake(farside_ghosts_spawn);
            if (await this.difficulty_legendary() || await this.difficulty_heroic())
            {
                Engine.ai_place(bridge_farside_wraiths.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_farside_wraiths.Squad)));
            }
            else
            {
                Engine.ai_place(bridge_farside_wraiths.Squad, (short)(1 - (float)Engine.ai_living_count(bridge_farside_wraiths.Squad)));
            }

            Engine.wake(bridge_cross_reminder);
            await Engine.sleep_until(async () => Engine.ai_scene("bridge_ally_scene", bridge_ally_comment, all_allies) || (short)Engine.ai_living_count(bridge_allies) < 1, 30, 150);
            await Engine.sleep(150);
            if (this.bridge_ally_comment_go == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'good. the bridge is down. now about those wraiths�'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2040"));
            }

            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("johnson: 'roger that, marine. armor's on the way!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0500"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.game_save();
            Engine.wake(bridge_holo_translate);
            Engine.wake(bridge_pelican_wait);
            await Engine.sleep_until(async () => Engine.device_get_position(da_bridge.Entity) == 0F);
            Engine.device_set_position(real_bridge.Entity, 0F);
            await Engine.sleep_until(async () => this.bridge_pelican_arrived == true);
            Engine.wake(bridge_banshee_spawn);
            Engine.wake(bridge_spare_ghost_spawn);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_all, Engine.players()) == false && await this.player_count() > 0 || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), "ghost_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), "ghost_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._1), "ghost_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._2), "ghost_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1), "ghost_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2), "ghost_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_farside_ghosts._1), "ghost_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_farside_ghosts._2), "ghost_d", await this.player0()) && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_p", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.l), "ghost_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_bunker_ghosts.r), "ghost_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._1), "ghost_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_01._2), "ghost_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._1), "ghost_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_phantom_ghosts_02._2), "ghost_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_farside_ghosts._1), "ghost_d", await this.player1()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_farside_ghosts._2), "ghost_d", await this.player1()) || (bool)Engine.game_is_cooperative() == false);
            await Engine.sleep(120);
            Engine.game_save();
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), false);
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()))
            {
                Engine.wake(music_05a_04_start);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task waterfall_toggle()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_waterfall_off, Engine.players()) == true);
                Engine.object_destroy(waterfall_far.Entity);
                Engine.object_destroy(waterfall_close.Entity);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_waterfall_on, Engine.players()) == true);
                Engine.object_create(waterfall_far);
                Engine.object_create(waterfall_close);
                return false;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task w_path_turret_0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("w_path_turrets/go_p0"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("w_path_turrets/p0"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task w_path_turret_1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("w_path_turrets/go_p1"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("w_path_turrets/p1"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task w_path_turret_2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("w_path_turrets/go_p2"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("w_path_turrets/p2"));
        }

        [ScriptMethod(Lifecycle.Dormant)]
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

            Engine.begin_random(async () =>
            {
                if (this.w_path_turret_count > 0)
                {
                    Engine.ai_place(w_path_heavies._0);
                    Engine.cs_run_command_script(w_path_heavies._0, w_path_turret_0);
                    this.w_path_turret_count = (short)(this.w_path_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.w_path_turret_count > 0)
                {
                    Engine.ai_place(w_path_heavies._1);
                    Engine.cs_run_command_script(w_path_heavies._1, w_path_turret_1);
                    this.w_path_turret_count = (short)(this.w_path_turret_count - 1);
                }
            }, 
                async () =>
            {
                if (this.w_path_turret_count > 2)
                {
                    Engine.ai_place(w_path_heavies._2);
                    Engine.cs_run_command_script(w_path_heavies._0, w_path_turret_2);
                    this.w_path_turret_count = (short)(this.w_path_turret_count - 1);
                }
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task throw_grenade()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_clear_los);
            Engine.cs_grenade(Engine.GetReference<ISpatialPoint>("w_path_turrets/p3"), 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task winding_path_start()
        {
            Engine.ai_disposable(overlook_jackals, true);
            Engine.ai_disposable(bridge_enemies_all, true);
            Engine.data_mine_set_mission_segment("05a_4_winding_path");
            Engine.game_save();
            Engine.wake(waterfall_toggle);
            Engine.ai_place(w_path_free_ghost.Squad, 1);
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "", Engine.players()) == false)
            {
                this.w_path_spawn_count = 3;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(winding_path_ghosts) < 1 || Engine.volume_test_objects(vol_winding_path_mid_01, Engine.players()) == true);
                if (Engine.volume_test_objects(vol_winding_path_mid_01, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(winding_path_ghosts_01.Squad, 1);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_winding_path_mid_01, Engine.players()) == true, 30, (int)Engine.random_range(30, 90));
                if (Engine.volume_test_objects(vol_winding_path_mid_01, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(winding_path_ghosts_01.Squad, 1);
                }

                return Engine.volume_test_objects(vol_winding_path_mid_01, Engine.players()) == true || (short)Engine.ai_spawn_count(winding_path_ghosts_01.Squad) > this.w_path_spawn_count;
            });
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_winding_path_mid_02, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(winding_path_enemies) < 6)
            {
                Engine.ai_place(winding_path_grunts.Squad, 4);
            }

            Engine.wake(w_path_turret_deploy);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(winding_path_ghosts) < 1 || Engine.volume_test_objects(vol_waterfall_on, Engine.players()) == true);
                if (Engine.volume_test_objects(vol_waterfall_on, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(winding_path_ghosts_02.Squad, 1);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_waterfall_on, Engine.players()) == true, 30, (int)Engine.random_range(30, 90));
                if (Engine.volume_test_objects(vol_waterfall_on, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(winding_path_ghosts_02.Squad, 1);
                }

                return Engine.volume_test_objects(vol_waterfall_on, Engine.players()) == true || (short)Engine.ai_spawn_count(winding_path_ghosts_02.Squad) > this.w_path_spawn_count;
            });
            Engine.game_save();
            if ((short)Engine.ai_living_count(winding_path_enemies) < 6)
            {
                Engine.ai_place(winding_path_jackals.Squad, 3);
            }

            if ((short)Engine.ai_living_count(winding_path_enemies) < 6)
            {
                Engine.ai_place(winding_path_ledge_grunts.Squad, 3);
            }

            Engine.cs_run_command_script(winding_path_ledge_grunts.Squad, throw_grenade);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(winding_path_ghosts) < 1 && (short)Engine.ai_living_count(winding_path_grunts.Squad) < 1 && (short)Engine.ai_living_count(winding_path_jackals.Squad) < 1);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.Dormant)]
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

            Engine.begin_random(async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_01._1);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_01._2);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_02._1);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_near_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_02._2);
                    this.temple_ent_near_turret = (short)(this.temple_ent_near_turret - 1);
                }
            });
            Engine.begin_random(async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_03._1);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_03._2);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_04._1);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            }, 
                async () =>
            {
                if (this.temple_ent_far_turret > 0)
                {
                    Engine.ai_place(temple_ent_turrets_04._2);
                    this.temple_ent_far_turret = (short)(this.temple_ent_far_turret - 1);
                }
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task temple_ent_ghostman_r()
        {
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.r));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task temple_ent_ghostman_l()
        {
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.l));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task temple_ent_ghost_alert()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(temple_ent_elites_01r.Squad) > this.ai_combat_status_idle || (short)Engine.ai_combat_status(temple_ent_elites_01l.Squad) > this.ai_combat_status_idle);
            Engine.cs_run_command_script(temple_ent_elites_01r.Squad, temple_ent_ghostman_r);
            Engine.cs_run_command_script(temple_ent_elites_01l.Squad, temple_ent_ghostman_l);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task temple_ent_veh_spawn()
        {
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "", Engine.players()) == false)
            {
                this.temple_ent_spawn_count = 3;
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_ent_elites_02r.Squad) < 1 && (short)Engine.ai_living_count(temple_ent_elites_02l.Squad) < 1 && (short)Engine.ai_living_count(temple_ent_ghosts_01.Squad) < 1 || Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.r)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(temple_ent_ghosts_01.l)) <= 0F || Engine.volume_test_objects(vol_temple_ent_02, Engine.players()) == true || Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == true, 30, 900);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_ent_ghosts) < 1 || Engine.volume_test_objects(vol_temple_ent_02, Engine.players()) == true);
                Engine.game_save();
                if (Engine.volume_test_objects(vol_temple_ent_02, Engine.players()) == false)
                {
                    Engine.ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)Engine.ai_living_count(temple_ent_ghosts)));
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ent_02, Engine.players()) == true, 30, (int)Engine.random_range(30, 90));
                if (Engine.volume_test_objects(vol_temple_ent_02, Engine.players()) == false)
                {
                    Engine.ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)Engine.ai_living_count(temple_ent_ghosts)));
                }

                return (short)Engine.ai_spawn_count(temple_ent_ghosts_02.Squad) > this.temple_ent_spawn_count || Engine.volume_test_objects(vol_temple_ent_02, Engine.players()) == true || Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == true;
            });
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_ent_ghosts) < 1 || Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == true);
                Engine.game_save();
                if (Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == false)
                {
                    Engine.ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)Engine.ai_living_count(temple_ent_ghosts)));
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == true, 30, (int)Engine.random_range(30, 90));
                if (Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == false)
                {
                    Engine.ai_place(temple_ent_ghosts_02.Squad, (short)(2 - (float)Engine.ai_living_count(temple_ent_ghosts)));
                }

                return (short)Engine.ai_spawn_count(temple_ent_ghosts_02.Squad) > (short)(this.temple_ent_spawn_count * 2F - 1) || Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task back_home_comment()
        {
            Engine.cs_switch("ally01");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'kinda reminds me of back home�'");
            Engine.cs_play_line("0530");
            Engine.cs_switch("ally02");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'yeah. too bad we're blowing it the hell up!'");
            Engine.cs_play_line("0540");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task temple_ent_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'let's push on. we need to find a an access point to those structures in the lake.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0580"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_entrance_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_entrance, Engine.players()) == true);
            Engine.ai_disposable(winding_path_enemies, true);
            Engine.data_mine_set_mission_segment("05a_5_temple_entrance");
            Engine.game_save();
            Engine.wake(_05a_title1);
            Engine.wake(music_05a_04_start_alt);
            Engine.wake(temple_ent_turret_spawn);
            Engine.ai_place(temple_ent_elites_01l.Squad, 1);
            Engine.ai_place(temple_ent_elites_01r.Squad, 1);
            if (await this.difficulty_heroic())
            {
                Engine.ai_place(temple_ent_jackals_01l.Squad, 1);
                Engine.ai_place(temple_ent_jackals_01r.Squad, 1);
            }

            if (await this.difficulty_normal())
            {
                Engine.ai_place(temple_ent_jackals_01l.Squad, 2);
                Engine.ai_place(temple_ent_jackals_01r.Squad, 2);
            }

            Engine.ai_place(temple_ent_ghosts_01.Squad, 2);
            Engine.wake(temple_ent_ghost_alert);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_ent_turrets_near) < 1 || (short)Engine.ai_living_count(temple_ent_enemies_all) < 4 || Engine.volume_test_objects(vol_temple_ent_01, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(temple_ent_enemies_all) < 8)
            {
                Engine.ai_place(temple_ent_elites_02r.Squad, (short)(1 - (float)Engine.ai_living_count(temple_ent_elites_01r.Squad)));
            }

            if ((short)Engine.ai_living_count(temple_ent_enemies_all) < 8)
            {
                Engine.ai_place(temple_ent_elites_02l.Squad, (short)(1 - (float)Engine.ai_living_count(temple_ent_elites_01l.Squad)));
            }

            Engine.wake(temple_ent_veh_spawn);
            this.temple_ent_phase_01 = true;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_ent_enemies_all) < 4 || Engine.volume_test_objects(vol_temple_ent_02, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(temple_ent_enemies_all) < 8)
            {
                Engine.ai_place(temple_ent_jackals_02c.Squad, 2);
            }

            if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_03._1)) > 0F && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_03._1), "", Engine.ai_actors(all_enemies)) == false && (short)Engine.ai_living_count(temple_ent_enemies_all) < 8)
            {
                Engine.ai_place(temple_ent_grunts_01l.Squad, 1);
            }

            if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_03._2)) > 0F && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_03._2), "", Engine.ai_actors(all_enemies)) == false && (short)Engine.ai_living_count(temple_ent_enemies_all) < 8)
            {
                Engine.ai_place(temple_ent_grunts_01l.Squad, 1);
            }

            if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_04._1)) > 0F && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_04._1), "", Engine.ai_actors(all_enemies)) == false && (short)Engine.ai_living_count(temple_ent_enemies_all) < 8)
            {
                Engine.ai_place(temple_ent_grunts_01r.Squad, 1);
            }

            if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_04._2)) > 0F && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets_04._2), "", Engine.ai_actors(all_enemies)) == false && (short)Engine.ai_living_count(temple_ent_enemies_all) < 8)
            {
                Engine.ai_place(temple_ent_grunts_01r.Squad, 1);
            }

            this.temple_ent_phase_02 = true;
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_ent_enemies_all) < 1 || Engine.volume_test_objects(vol_temple_ent_03, Engine.players()) == true);
            Engine.game_save();
            Engine.ai_set_orders(temple_ent_ghosts, temple_ent_back_02);
            Engine.wake(temple_ent_reminder);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_ent_enemies_all) < 1 || Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true);
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(all_allies) < 1 || Engine.ai_scene("temple_ent_scene", back_home_comment, all_allies), 30, 300);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task temple_ent_arch()
        {
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", tunnel_enemies_all) == true || Engine.volume_test_objects(vol_old_temple_near_left, Engine.players()) == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_near_left, Engine.players()) == true, 30, 450);
            if (Engine.volume_test_objects(vol_old_temple_near_left, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'these structures seem forerunner,'");
                Engine.print("'but they're much older than anything we ever found on the first halo.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0570"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_structure_comment()
        {
            this.structure_comment_go = true;
            Engine.cs_switch("ally");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'careful, we're coming-up on another structure!'");
            Engine.cs_play_line("0600");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task tunnel_turret_0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("tunnel_turrets/go_p0"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("tunnel_turrets/p0"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task tunnel_turret_1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("tunnel_turrets/go_p1"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("tunnel_turrets/p1"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task tunnel_turret_2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("tunnel_turrets/go_p2"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("tunnel_turrets/p2"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task tunnel_turret_3()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("tunnel_turrets/go_p3"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("tunnel_turrets/p3"));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task tunnel_start()
        {
            Engine.ai_disposable(temple_ent_enemies_all, true);
            Engine.data_mine_set_mission_segment("05a_6_tunnel");
            Engine.game_save();
            if ((short)Engine.ai_living_count(tunnel_enemies_all) < 6)
            {
                Engine.ai_place(tunnel_grunts.Squad, 2);
            }

            if ((short)Engine.ai_living_count(tunnel_enemies_all) < 6)
            {
                Engine.ai_place(tunnel_heavies_01.Squad, 2);
            }

            Engine.cs_run_command_script(tunnel_heavies_01._0, tunnel_turret_0);
            Engine.cs_run_command_script(tunnel_heavies_01._1, tunnel_turret_1);
            Engine.ai_place(tunnel_ghosts_01.Squad, (short)(2 - (float)Engine.ai_living_count(temple_ent_ghosts)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_02, Engine.players()) == true, 30, (int)Engine.random_range(30, 90));
            if (Engine.volume_test_objects(vol_tunnel_02, Engine.players()) == false)
            {
                Engine.ai_place(tunnel_ghosts_01.Squad, (short)(2 - (float)Engine.ai_living_count(temple_ent_ghosts)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_02, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(tunnel_enemies_all) < 6)
            {
                Engine.ai_place(tunnel_jackals.Squad, 2);
            }

            if ((short)Engine.ai_living_count(tunnel_enemies_all) < 6)
            {
                Engine.ai_place(tunnel_heavies_02.Squad, 2);
            }

            Engine.cs_run_command_script(tunnel_heavies_02._2, tunnel_turret_2);
            Engine.cs_run_command_script(tunnel_heavies_02._3, tunnel_turret_3);
            Engine.ai_migrate(temple_ent_ghosts, tunnel_ghosts_02.Squad);
            Engine.ai_migrate(tunnel_ghosts_01.Squad, tunnel_ghosts_02.Squad);
            Engine.ai_place(tunnel_ghosts_02.Squad, (short)(2 - (float)Engine.ai_living_count(tunnel_ghosts)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_03, Engine.players()) == true, 30, (int)Engine.random_range(30, 90));
            if (Engine.volume_test_objects(vol_tunnel_02, Engine.players()) == false)
            {
                Engine.ai_place(tunnel_ghosts_02.Squad, (short)(2 - (float)Engine.ai_living_count(tunnel_ghosts)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_03, Engine.players()) == true || (short)Engine.ai_living_count(tunnel_ghosts) < 1 && (short)Engine.ai_living_count(tunnel_infantry) < 1);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.ai_scene("old_temple_scene", old_temple_structure_comment, all_allies) || (short)Engine.ai_living_count(all_allies) < 1, 30, 150);
            await Engine.sleep(30);
            if (this.structure_comment_go == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'careful, we're coming-up on another structure!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2060"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task arbiter_envy()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arbiter_envy, Engine.players()) == true);
            Engine.object_create(envy);
            Engine.ai_place(envy_elites.Squad);
            Engine.ai_set_active_camo(envy_elites.Squad, true);
            Engine.cs_run_command_script(envy_elites.Squad, forever_pause);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(envy_elites.Squad), 0)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4252703556U), "combat:rifle:berserk", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(envy_elites.Squad), 1)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4252703556U), "combat:rifle:berserk", true);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4218624339U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4218624339U)));
            Engine.ice_cream_flavor_stock(0);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_pelican_comment()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'got a pelican coming in!'");
            Engine.cs_play_line("0620");
            await Engine.sleep(30);
            Engine.print("ally: 'let's clear an lz!'");
            Engine.cs_play_line("0630");
            this.old_temple_pel_comment_go = true;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_pelican_timer()
        {
            await Engine.sleep(8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_pelican_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel0"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel1"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel2"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel3"), 10F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel4"), 5F);
            this.old_temple_bombs_away = true;
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel4"), Engine.GetReference<ISpatialPoint>("old_temple_airspace/p0"), 1F);
            Engine.ai_place(allies_old_temple_pelican.Squad, (short)(4 - (float)Engine.ai_living_count(all_allies)));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_p", Engine.ai_actors(allies_old_temple_pelican.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel5"), 1F);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_p");
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_center_01, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_03, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_05, Engine.players()) == true);
            await Engine.sleep(90);
            Engine.wake(old_temple_pelican_timer);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel4"), 2F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel3"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel2"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel1"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/pel0"), 20F);
            Engine.ai_erase(old_temple_pelican1.Squad);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_pelican()
        {
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 5)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 5), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 5));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 4));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
            }

            await Engine.sleep(5);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_phantom.Squad) < 1);
            Engine.ai_place(old_temple_pelican1.Squad);
            Engine.object_cannot_take_damage(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot));
            Engine.object_create_anew(rack);
            Engine.objects_attach(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_sc_01", rack.Entity, "pin");
            Engine.object_create_anew(bomb01);
            Engine.objects_attach(rack.Entity, "rack01", bomb01.Entity, "pin");
            Engine.object_create_anew(bomb02);
            Engine.objects_attach(rack.Entity, "rack02", bomb02.Entity, "pin");
            Engine.object_create_anew(bomb03);
            Engine.objects_attach(rack.Entity, "rack03", bomb03.Entity, "pin");
            Engine.object_create_anew(bomb04);
            Engine.objects_attach(rack.Entity, "rack04", bomb04.Entity, "pin");
            Engine.object_create_anew(bomb05);
            Engine.objects_attach(rack.Entity, "rack05", bomb05.Entity, "pin");
            Engine.object_create_anew(bomb06);
            Engine.objects_attach(rack.Entity, "rack06", bomb06.Entity, "pin");
            Engine.cs_run_command_script(old_temple_pelican1.pilot, old_temple_pelican_arrives);
            await Engine.sleep_until(async () => this.old_temple_bombs_away == true);
            Engine.begin_random(async () => Engine.objects_detach(rack.Entity, bomb01.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb02.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb03.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb04.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb05.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb06.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task short_old_temple_pel()
        {
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 5)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 5), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 5));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 4));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
            }

            await Engine.sleep(5);
            if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 50F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0), 45F) == false)
            {
                Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
            }

            await Engine.sleep(5);
            Engine.ai_place(allies_old_temple_pelican.Squad, 4);
            Engine.ai_place(old_temple_pelican1.Squad);
            Engine.object_cannot_take_damage(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_p", Engine.ai_actors(allies_old_temple_pelican.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), true);
            Engine.object_create_anew(rack);
            Engine.objects_attach(Engine.ai_vehicle_get_from_starting_location(old_temple_pelican1.pilot), "pelican_sc_01", rack.Entity, "pin");
            Engine.object_create_anew(bomb01);
            Engine.objects_attach(rack.Entity, "rack01", bomb01.Entity, "pin");
            Engine.object_create_anew(bomb02);
            Engine.objects_attach(rack.Entity, "rack02", bomb02.Entity, "pin");
            Engine.object_create_anew(bomb03);
            Engine.objects_attach(rack.Entity, "rack03", bomb03.Entity, "pin");
            Engine.object_create_anew(bomb04);
            Engine.objects_attach(rack.Entity, "rack04", bomb04.Entity, "pin");
            Engine.object_create_anew(bomb05);
            Engine.objects_attach(rack.Entity, "rack05", bomb05.Entity, "pin");
            Engine.object_create_anew(bomb06);
            Engine.objects_attach(rack.Entity, "rack06", bomb06.Entity, "pin");
            Engine.cs_run_command_script(old_temple_pelican1.pilot, old_temple_pelican_arrives);
            await Engine.sleep_until(async () => this.old_temple_bombs_away == true);
            Engine.begin_random(async () => Engine.objects_detach(rack.Entity, bomb01.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb02.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb03.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb04.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb05.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)), 
                async () => Engine.objects_detach(rack.Entity, bomb06.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(10, 30)));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_ph_01_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3a"), 3F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3a"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph4a"), 1F);
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), "phantom_lc");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_phantom.Squad) < 2, 30, 900);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3a"), Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 1F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            Engine.ai_erase(old_temple_phantom.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_ph_02_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3b"), 3F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3b"), Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph4b"), 1F);
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), "phantom_lc");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_phantom.Squad) < 2, 30, 900);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3b"), 1F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            Engine.ai_erase(old_temple_phantom.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_ph_04_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3c"), 5F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3c"), Engine.GetReference<ISpatialPoint>("old_temple_airspace/p2"), 1F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph4c"), 1F);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), true);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a03");
            Engine.ai_set_orders(old_temple_court_grunts_03.Squad, old_temple_courtyard_03);
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b03");
            Engine.ai_set_orders(old_temple_court_jackals_03.Squad, old_temple_courtyard_03);
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c01");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c02");
            await Engine.sleep(15);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c03");
            Engine.ai_set_orders(old_temple_court_jackals_04.Squad, old_temple_courtyard_04);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temp_court_phantom.Squad) < 2, 30, 900);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph3c"), 1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            Engine.ai_erase(old_temple_phantom.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_abort()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            if (Engine.volume_test_objects(vol_old_temple_airspace_low, Engine.ai_actors(old_temple_phantom.Squad)) == true)
            {
                Engine.cs_enable_moving(true);
                Engine.cs_enable_looking(true);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_airspace_high, Engine.ai_actors(old_temple_phantom.Squad)) == true);
            }

            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph1"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("old_temple_airspace/ph0"), 20F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("old_temple_airspace/phx"), 20F);
            Engine.ai_erase(old_temple_phantom.Squad);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task old_temple_phantom_01()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_pelican1.Squad) < 1);
            Engine.ai_place(old_temple_phantom.Squad);
            Engine.ai_place(old_temple_ghosts_air.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(old_temple_ghosts_air._1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(old_temple_ghosts_air._2));
            await Engine.sleep(60);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), true);
            Engine.cs_run_command_script(old_temple_phantom.pilot, old_temple_ph_01_arrives);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_phantom.Squad) < 1 || (short)Engine.ai_living_count(old_temple_ghosts_air.Squad) < 1);
            if ((short)Engine.ai_living_count(old_temple_ghosts_air.Squad) < 1)
            {
                Engine.cs_run_command_script(old_temple_phantom.Squad, old_temple_abort);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_phantom.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task old_temple_phantom_02()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_pelican1.Squad) < 1);
            Engine.ai_place(old_temple_phantom.Squad);
            Engine.ai_place(old_temple_ghosts_air.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(old_temple_ghosts_air._1));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), "phantom_lc", Engine.ai_vehicle_get_from_starting_location(old_temple_ghosts_air._2));
            await Engine.sleep(60);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot), true);
            Engine.cs_run_command_script(old_temple_phantom.pilot, old_temple_ph_02_arrives);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_phantom.Squad) < 1 || (short)Engine.ai_living_count(old_temple_ghosts_air.Squad) < 1);
            if ((short)Engine.ai_living_count(old_temple_ghosts_air.Squad) < 1)
            {
                Engine.cs_run_command_script(old_temple_phantom.Squad, old_temple_abort);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_phantom.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(old_temple_phantom.pilot));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_phantom_04()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_pelican1.Squad) < 1);
            Engine.ai_place(old_temple_court_jackals_03.Squad, 2);
            Engine.ai_place(old_temple_court_grunts_03.Squad, 3);
            Engine.ai_place(old_temple_court_jackals_04.Squad, 3);
            Engine.ai_place(old_temp_court_phantom.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c", Engine.ai_actors(old_temple_court_jackals_04.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a", Engine.ai_actors(old_temple_court_grunts_03.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b", Engine.ai_actors(old_temple_court_jackals_03.Squad));
            await Engine.sleep(60);
            Engine.cs_run_command_script(old_temp_court_phantom.pilot, old_temple_ph_04_arrives);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temp_court_phantom.Squad) < 1, 30, 8000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task short_old_temple_phantom()
        {
            Engine.ai_allegiance(covenant, prophet);
            Engine.ai_place(old_temple_court_jackals_03.Squad, 2);
            Engine.ai_place(old_temple_court_grunts_03.Squad, 3);
            Engine.ai_place(old_temple_court_jackals_04.Squad, 3);
            Engine.ai_place(old_temp_court_phantom.Squad);
            await Engine.sleep(60);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_c", Engine.ai_actors(old_temple_court_jackals_04.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_a", Engine.ai_actors(old_temple_court_grunts_03.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), "phantom_p_b", Engine.ai_actors(old_temple_court_jackals_03.Squad));
            await Engine.sleep(60);
            Engine.cs_run_command_script(old_temp_court_phantom.pilot, old_temple_ph_04_arrives);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(old_temp_court_phantom.pilot), true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_vehicle_spawn()
        {
            Engine.ai_place(old_temple_ghosts_far.Squad);
            if (await this.difficulty_heroic())
            {
                this.old_temple_veh_total = 3;
            }

            if (await this.difficulty_legendary())
            {
                this.old_temple_veh_total = 4;
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_ghosts_far.Squad) > 0, 30, 600);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_vehicles) < 1 || Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true);
                Engine.game_save();
                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true)
                {
                    Engine.sleep_forever();
                }

                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == false)
                {
                    Engine.ai_place(old_temple_ghosts_far.Squad, 1);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true, 30, (int)Engine.random_range(30, 120));
                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true)
                {
                    Engine.sleep_forever();
                }

                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == false)
                {
                    Engine.ai_place(old_temple_ghosts_far.Squad, 1);
                }

                this.old_temple_veh_total = (short)(this.old_temple_veh_total - 1);
                return await this.difficulty_normal() && this.old_temple_veh_total < 2 || await this.difficulty_heroic() && this.old_temple_veh_total < 2 || await this.difficulty_legendary() && this.old_temple_veh_total < 3 || Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true;
            });
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_vehicles) < 1 || Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true);
                Engine.game_save();
                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true)
                {
                    Engine.sleep_forever();
                }

                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == false)
                {
                    Engine.ai_place(old_temple_ghosts_far.Squad, 1);
                    Engine.ai_set_orders(old_temple_ghosts_far.Squad, old_temple_vehicles_ltd);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true, 30, (int)Engine.random_range(30, 120));
                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true)
                {
                    Engine.sleep_forever();
                }

                if (Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == false)
                {
                    Engine.ai_place(old_temple_ghosts_far.Squad, 1);
                    Engine.ai_set_orders(old_temple_ghosts_far.Squad, old_temple_vehicles_ltd);
                }

                this.old_temple_veh_total = (short)(this.old_temple_veh_total - 1);
                return this.old_temple_veh_total <= 0 || Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true;
            });
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_vehicles) < 1);
            this.old_temple_ghosts_over = true;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_near_right()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_near_right, Engine.players()) == true && Engine.volume_test_objects(vol_old_temple_int_01, Engine.players()) == false && Engine.volume_test_objects(vol_old_temple_int_02, Engine.players()) == false && await this.player_count() > 0);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_elites_near_right.Squad, 1);
            }

            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_jackals_near_right.Squad, (short)(2 - (float)Engine.ai_living_count(old_temple_peri_jackals)));
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_far_left()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_far_left, Engine.players()) == true && Engine.volume_test_objects(vol_old_temple_int_01, Engine.players()) == false && Engine.volume_test_objects(vol_old_temple_int_02, Engine.players()) == false && await this.player_count() > 0);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_grunts_far_left.Squad, (short)(3 - (float)Engine.ai_living_count(old_temple_peri_grunts)));
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_far_right()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_far_right, Engine.players()) == true && Engine.volume_test_objects(vol_old_temple_int_01, Engine.players()) == false && Engine.volume_test_objects(vol_old_temple_int_02, Engine.players()) == false && await this.player_count() > 0);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_grunts_far_right.Squad, (short)(3 - (float)Engine.ai_living_count(old_temple_peri_grunts)));
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_below()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_below, Engine.players()) == true && Engine.volume_test_objects(vol_old_temple_int_01, Engine.players()) == false && Engine.volume_test_objects(vol_old_temple_int_02, Engine.players()) == false && await this.player_count() > 0);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_jackals_below_far.Squad, (short)((float)Engine.random_range(2, 5) - (float)Engine.ai_living_count(old_temple_peri_jackals)));
            }

            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_jackals_below_near.Squad, (short)((float)Engine.random_range(2, 5) - (float)Engine.ai_living_count(old_temple_peri_jackals)));
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temp_reman_fr()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("old_temple/far_r"));
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_r));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temp_reman_fl()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("old_temple/far_l"));
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_l));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temp_reman_nl()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("old_temple/near_l"));
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.near_l));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temp_reman_cen()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("old_temple/center"));
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.center));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_turret_reman()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) > 0F && Engine.volume_test_objects(vol_old_temple_farwall_all, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_spawn_count(old_temple_grunts_far_right.Squad) < 5 && (short)Engine.ai_living_count(old_temple_grunts_far_right.Squad) < 1 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_r), "", Engine.ai_actors(old_temple_turrets.Squad)) == false && Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) < 20F)
                {
                    Engine.ai_place(old_temple_grunts_far_right._1);
                    Engine.cs_run_command_script(old_temple_grunts_far_right._1, old_temp_reman_fr);
                }

                if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) > 0F && Engine.volume_test_objects(vol_old_temple_seawall_all, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_spawn_count(old_temple_grunts_far_left.Squad) < 5 && (short)Engine.ai_living_count(old_temple_grunts_far_left.Squad) < 1 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_l), "", Engine.ai_actors(old_temple_turrets.Squad)) == false && Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) < 20F)
                {
                    Engine.ai_place(old_temple_grunts_far_left._1);
                    Engine.cs_run_command_script(old_temple_grunts_far_left._1, old_temp_reman_fl);
                }

                if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) > 0F && Engine.volume_test_objects(vol_old_temple_seawall_all, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_spawn_count(old_temple_grunts_near_left.Squad) < 5 && (short)Engine.ai_living_count(old_temple_grunts_near_left.Squad) < 1 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.near_l), "", Engine.ai_actors(old_temple_turrets.Squad)) == false && Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) < 20F)
                {
                    Engine.ai_place(old_temple_grunts_near_left._1);
                    Engine.cs_run_command_script(old_temple_grunts_near_left._1, old_temp_reman_nl);
                }

                if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.center)) > 0F && Engine.volume_test_objects(vol_old_temple_see_nook, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_spawn_count(old_temple_grunts_center.Squad) < 5 && (short)Engine.ai_living_count(old_temple_grunts_center.Squad) < 1 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.center), "", Engine.ai_actors(old_temple_turrets.Squad)) == false && Engine.objects_distance_to_object(Engine.players(), Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.center)) < 20F)
                {
                    Engine.ai_place(old_temple_grunts_center._1);
                    Engine.cs_run_command_script(old_temple_grunts_center._1, old_temp_reman_cen);
                }

                return Engine.volume_test_objects(vol_old_temple_center_01, await this.player0()) == true || Engine.volume_test_objects(vol_old_temple_center_03, await this.player0()) == true || Engine.volume_test_objects(vol_old_temple_center_05, await this.player0()) == true || Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.center)) <= 0F;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_perimeter_nuke()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_grunts), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_grunts), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(old_temple_peri_grunts), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_jackals), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_jackals), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(old_temple_peri_jackals), 0));
                }

                await Engine.sleep(5);
                return (short)Engine.ai_living_count(old_temple_peri_grunts) < 1 && (short)Engine.ai_living_count(old_temple_peri_jackals) < 1;
            });
            Engine.print("all gone");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task nuke()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_grunts), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_grunts), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(old_temple_peri_grunts), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_jackals), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(old_temple_peri_jackals), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(old_temple_peri_jackals), 0));
                }

                await Engine.sleep(5);
                return (short)Engine.ai_living_count(old_temple_peri_grunts) < 1 && (short)Engine.ai_living_count(old_temple_peri_jackals) < 1;
            });
            Engine.print("all gone");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task old_temple_middle_comment()
        {
            this.old_temp_middle_go = true;
            Engine.cs_switch("ally");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'they're all pouring-out of the middle! let's get in there!'");
            Engine.cs_play_line("0610");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_middle_ally()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(all_allies) < 1 || Engine.ai_scene("old_temple_mid_scene", old_temple_middle_comment, all_allies), 30, 300);
            await Engine.sleep(30);
            if (this.old_temp_middle_go == false && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'they're all pouring-out of the middle! let's get in there!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2070"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_center()
        {
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.volume_test_objects(vol_old_temple_center_01, await this.player0()) == true || Engine.volume_test_objects(vol_old_temple_center_03, await this.player0()) == true || Engine.volume_test_objects(vol_old_temple_center_05, await this.player0()) == true || Engine.unit_in_vehicle(await this.player1()) == false && Engine.volume_test_objects(vol_old_temple_center_01, await this.player1()) == true || Engine.volume_test_objects(vol_old_temple_center_03, await this.player1()) == true || Engine.volume_test_objects(vol_old_temple_center_05, await this.player1()) == true);
            Engine.ai_disposable(old_temple_peri_grunts, true);
            Engine.ai_disposable(old_temple_peri_jackals, true);
            Engine.game_save();
            Engine.sleep_forever(old_temple_near_right);
            Engine.sleep_forever(old_temple_far_left);
            Engine.sleep_forever(old_temple_far_right);
            Engine.sleep_forever(old_temple_vehicle_spawn);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            Engine.cs_run_command_script(old_temple_phantom.Squad, old_temple_abort);
            Engine.wake(old_temple_perimeter_nuke);
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_center_elites_01.Squad, (short)(2 - (float)Engine.ai_living_count(old_temp_center_tough)));
            }

            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_center_grunts_01.Squad, (short)(3 - (float)Engine.ai_living_count(old_temp_center_fodder)));
            }

            Engine.wake(old_temple_middle_ally);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_center_03, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_05, Engine.players()) == true || (short)Engine.ai_living_count(old_temple_center_all) < 3);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_center_grunts_03.Squad, (short)(3 - (float)Engine.ai_living_count(old_temp_center_fodder)));
            }

            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_center_jackals_04.Squad, (short)(2 - (float)Engine.ai_living_count(old_temp_center_tough)));
            }

            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_center_grunts_04.Squad, (short)(6 - (float)Engine.ai_living_count(old_temp_center_fodder)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_center_05, Engine.players()) == true || (short)Engine.ai_living_count(old_temple_center_all) < 3);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_center_elites_05.Squad, (short)(2 - (float)Engine.ai_living_count(old_temp_center_tough)));
            }

            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_center_jackals_05.Squad, (short)(4 - (float)Engine.ai_living_count(old_temp_center_tough)));
            }

            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(old_temple_center_all) < 2 && Engine.volume_test_objects(vol_old_temple_court_01, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(old_temple_courtyard_lure.Squad, 1);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_close_nuff, Engine.players()) == true || (short)Engine.ai_living_count(old_temple_center_all) < 2 || (short)Engine.ai_spawn_count(old_temple_courtyard_lure.Squad) > 3, 30, 210);
                return Engine.volume_test_objects(vol_old_temple_close_nuff, Engine.players()) == true || (short)Engine.ai_spawn_count(old_temple_courtyard_lure.Squad) > 3;
            });
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_center_all) < 1, 30, 3600);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", old_temple_center_all) == true, 30, 3600);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_playfight()
        {
            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_playfight_e.Squad, 2);
            }

            if ((short)Engine.ai_living_count(old_temple_enemies) < 8)
            {
                Engine.ai_place(old_temple_playfight_g.Squad, 3);
            }

            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(old_temple_playfight_g.Squad) < 3)
                {
                    Engine.ai_place(old_temple_playfight_g.Squad, 1);
                }

                return Engine.volume_test_objects(vol_old_temple_center_01, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_03, Engine.players()) == true;
            });
            Engine.ai_set_orders(allies_old_temple_pelican.Squad, old_temple_center_allies_01);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_debris_comment()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_debris, Engine.players()) == true && this.old_temple_chatter == false);
            this.old_temple_chatter = true;
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'looks like a landslide has blocked the main passage.'");
            Engine.print("'we'll have to find an alternate route.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0670"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            this.old_temple_chatter = false;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_middle_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == false && await this.player_count() > 0 && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'the covenant holed-up in the middle of this structure.'");
                Engine.print("'we need to clear them out.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0650"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.activate_team_nav_point_flag(_default, player, old_temple_exit, 0F);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == true);
                Engine.deactivate_team_nav_point_flag(player, old_temple_exit);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_start, Engine.players()) == true);
            Engine.ai_disposable(tunnel_enemies_all, true);
            Engine.data_mine_set_mission_segment("05a_7_old_temple");
            Engine.wake(music_05a_04_stop);
            Engine.game_save();
            Engine.ai_place(old_temple_init_jackals_nl.Squad, 2);
            await Engine.sleep(2);
            Engine.ai_place(old_temple_turrets.center);
            Engine.cs_run_command_script(old_temple_turrets.Squad, stay_shooting);
            await Engine.sleep(2);
            Engine.ai_place(old_temple_turrets.near_l);
            Engine.cs_run_command_script(old_temple_turrets.Squad, stay_shooting);
            await Engine.sleep(2);
            Engine.ai_place(old_temple_turrets.far_l);
            Engine.cs_run_command_script(old_temple_turrets.Squad, stay_shooting);
            await Engine.sleep(2);
            Engine.ai_place(old_temple_turrets.far_r);
            Engine.cs_run_command_script(old_temple_turrets.Squad, stay_shooting);
            Engine.wake(old_temple_near_right);
            Engine.wake(old_temple_far_left);
            Engine.wake(old_temple_far_right);
            Engine.wake(old_temple_below);
            Engine.wake(old_temple_center);
            Engine.wake(old_temple_vehicle_spawn);
            Engine.wake(old_temple_middle_reminder);
            Engine.wake(old_temple_turret_reman);
            if (await this.difficulty_legendary())
            {
                Engine.wake(arbiter_envy);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_center_01, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_03, Engine.players()) == true || Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_r)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.far_l)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.near_l)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(old_temple_turrets.center)) <= 0F && this.old_temple_ghosts_over == true);
            Engine.game_save();
            Engine.wake(old_temple_pelican);
            Engine.wake(old_temple_playfight);
            await Engine.sleep_until(async () => Engine.ai_scene("old_temple_pel_scene", old_temple_pelican_comment, all_allies) || (short)Engine.ai_living_count(all_allies) < 1, 30, 60);
            await Engine.sleep(300);
            if (this.old_temple_pel_comment_go == false && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'pelican inbound!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2080"));
                await Engine.sleep(15);
                Engine.print("cortana: 'let's clear a landing-zone!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2090"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_center_01, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_03, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == true, 30, 300);
            if (Engine.volume_test_objects(vol_old_temple_center_01, Engine.players()) == false && Engine.volume_test_objects(vol_old_temple_center_03, Engine.players()) == false && Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == false && await this.player_count() > 0 && this.old_temple_bombs_away == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("johnson: 'clear out the riff-raff so i can set her down!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0640"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_enemies) < 1, 30, 3600);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", old_temple_enemies) == true, 30, 3600);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_debris_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_through_debris, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_through_debris, Engine.players()) == false && await this.player_count() > 0 && this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'there should be a way through this debris�'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0680"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.old_temple_chatter = false;
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true, 30, 4000);
            if (Engine.volume_test_objects(vol_grotto, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.activate_team_nav_point_flag(_default, player, courtyard_exit, 0F);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
                Engine.deactivate_team_nav_point_flag(player, courtyard_exit);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_holo_translate()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_court_all) < 1);
            await Engine.sleep(300);
            this.court_holo_trans = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_court_04, Engine.players()) == true && Engine.objects_can_see_object(Engine.players(), regret02.Entity, 30F) == true && this.court_holo_chant == false);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_l05_0110_por", true);
            Engine.print("'in a gesture of peace and reconciliation, the prophets promised to find the means...'");
            Engine.print("'...of the forerunners' transcendence, and to share this knowledge with the elites.'");
            await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "0110"));
            await Engine.sleep(30);
            Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_l05_0120_por", true);
            Engine.print("'the elites promised to defend the prophets as they searched - '");
            Engine.print("'a simple arrangement that has become our binding covenant!'");
            await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "0120"));
            await Engine.sleep(60);
            if (this.old_temple_chatter == false)
            {
                this.old_temple_chatter = true;
                Engine.print("cortana: 'transcendence, huh? more like mass-suicide.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0660"));
                this.old_temple_chatter = false;
            }

            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep((short)Engine.random_range(240, 480));
            this.court_holo_trans = false;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task courtyard_holo_looper()
        {
            Engine.object_create(regret02);
            Engine.objects_attach(court_throne_attach.Entity, "", court_throne.Entity, "driver");
            Engine.objects_attach(court_throne.Entity, "driver", regret02.Entity, "");
            Engine.ai_disregard(regret02.Entity, true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant1a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3000"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2b", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3001"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3002"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3003"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3004"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant5a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3005"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant6a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3006"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task court_holo_looper()
        {
            Engine.object_create(regret02);
            Engine.objects_attach(court_throne_attach.Entity, "", court_throne.Entity, "driver");
            Engine.objects_attach(court_throne.Entity, "driver", regret02.Entity, "");
            Engine.ai_disregard(regret02.Entity, true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant1a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3000"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2b", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3001"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3002"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3003"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3004"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant5a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3005"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.court_holo_trans == false)
                    {
                        this.court_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant6a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3006"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.court_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_archaeologist()
        {
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", all_enemies) == true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", all_enemies) == true || Engine.volume_test_objects(vol_through_debris, Engine.players()) == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_through_debris, Engine.players()) == true, 30, 300);
            if (Engine.volume_test_objects(vol_through_debris, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'what happened to this place? the stones�'");
                Engine.print("'this isn't normal wear and tear. it almost looks like battle-scarring�'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0590"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task old_temple_courtyard()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_court_01, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_in_court, Engine.players()) == true);
            Engine.ai_disposable(old_temple_center_all, true);
            Engine.data_mine_set_mission_segment("05a_8_old_temple_courtyard");
            Engine.wake(courtyard_holo_looper);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_elites_01.Squad, 2);
            }

            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_grunts_01.Squad, 3);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_court_all) < 3 || Engine.volume_test_objects(vol_old_temple_court_02, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_grunts_02.Squad, (short)(4 - (float)Engine.ai_living_count(old_temple_court_grunts_01.Squad)));
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_court_all) < 3 || Engine.volume_test_objects(vol_old_temple_court_04, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(old_temple_holo_translate);
            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_jackals_03.Squad, (short)(2 - (float)Engine.ai_living_count(old_temple_court_elites_01.Squad)));
            }

            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_grunts_03.Squad, (short)(3 - (float)Engine.ai_living_count(old_temple_court_grunts_01.Squad) + (float)Engine.ai_living_count(old_temple_court_grunts_02.Squad)));
            }

            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_jackals_04.Squad, 2);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_court_all) < 3 || Engine.volume_test_objects(vol_old_temple_court_05, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_elites_05.Squad, 2);
            }

            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_jackals_05.Squad, 2);
            }

            Engine.wake(old_temple_debris_reminder);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_old_temple_court_06, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_jackals_06.Squad, 2);
            }

            if ((short)Engine.ai_living_count(old_temple_court_all) < 8)
            {
                Engine.ai_place(old_temple_court_grunts_06.Squad, 3);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(old_temple_court_all) < 1, 30, 4000);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", old_temple_court_all) == true, 30, 3600);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grotto_cortana_comment()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_follow_01, Engine.players()) == true && Engine.objects_can_see_flag(Engine.players(), grotto_center, 30F) == true);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'you always bring me to such nice places.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0690"));
            await Engine.sleep(30);
            Engine.wake(music_05a_05_start);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save());
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task grotto_ally_cheese()
        {
            Engine.cs_switch("ally01");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("odst: 'my girl would dig this place. so beautiful�'");
            Engine.cs_play_line("0700");
            await Engine.sleep(30);
            Engine.cs_switch("ally02");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("odst: 'beautiful and dangerous, man.'");
            Engine.cs_play_line("0710");
            await Engine.sleep(30);
            Engine.cs_switch("ally01");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("odst: 'hey. that's why i love her.'");
            Engine.cs_play_line("0720");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grotto_ally_comments()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("grotto_ally_cheese_scene", grotto_ally_cheese, all_allies), 30, 450);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grotto_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_exit, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_grotto_exit, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'we're approaching another structure. it should be the...'");
                Engine.print("'...lake access-point we've been looking for�'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0750"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_exit, Engine.players()) == true, 30, 4000);
            if (Engine.volume_test_objects(vol_grotto_exit, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.activate_team_nav_point_flag(_default, player, grotto_exit, 0F);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_exit, Engine.players()) == true);
                Engine.deactivate_team_nav_point_flag(player, grotto_exit);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grotto_pool()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(grotto_init_01.Squad) < 1 || Engine.volume_test_objects(vol_grotto_first_pool_01, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_02, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_03, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_grotto_mid_02, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_03, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }

            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_crack_grunts.Squad, 2);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(grotto_crack_grunts.Squad) < 2 || Engine.volume_test_objects(vol_grotto_first_pool_02, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_02, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_03, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_grotto_mid_02, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_03, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }

            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_buggers_new_01.Squad, (short)(4 - (float)Engine.ai_living_count(grotto_buggers)));
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(grotto_buggers_new_01.Squad) < 2 || Engine.volume_test_objects(vol_grotto_mid_02, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_03, Engine.players()) == true);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(grotto_pool_grunts.Squad) < 1)
                {
                    Engine.ai_place(grotto_pool_grunts.Squad, 1);
                }

                return Engine.volume_test_objects(vol_grotto_mid_02, Engine.players()) == true || Engine.volume_test_objects(vol_grotto_mid_03, Engine.players()) == true || (short)Engine.ai_spawn_count(grotto_pool_grunts.Squad) > 3;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grotto_buggers_reinforce()
        {
            if ((short)Engine.ai_living_count(grotto_enemies) < 8 && await this.difficulty_legendary())
            {
                Engine.ai_place(grotto_buggers_01.Squad, (short)(4 - (float)Engine.ai_living_count(grotto_buggers)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_mid_03, Engine.players()) == true);
            Engine.ai_migrate(grotto_buggers_01.Squad, grotto_buggers_02.Squad);
            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_buggers_02.Squad, (short)(4 - (float)Engine.ai_living_count(grotto_buggers)));
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grotto_extra_checkpoint()
        {
            await Engine.sleep(60);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == false && await this.player_count() > 0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task grotto_entry_patrol()
        {
            Engine.cs_abort_on_alert(true);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("grotto/p0"), Engine.GetReference<ISpatialPoint>("grotto/p2"));
                Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("grotto/p2"));
                await Engine.sleep((short)Engine.random_range(30, 90));
                Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("grotto/p2"));
                Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("grotto/p1"), Engine.GetReference<ISpatialPoint>("grotto/p2"));
                Engine.cs_aim(true, Engine.GetReference<ISpatialPoint>("grotto/p2"));
                await Engine.sleep((short)Engine.random_range(30, 90));
                Engine.cs_aim(false, Engine.GetReference<ISpatialPoint>("grotto/p2"));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grotto_start()
        {
            Engine.ai_disposable(old_temple_enemies, true);
            Engine.data_mine_set_mission_segment("05a_9_grotto");
            Engine.game_save();
            Engine.wake(_05a_title2);
            Engine.ai_place(grotto_init_01.Squad, 1);
            Engine.ai_place(grotto_init_04.Squad, 1);
            Engine.ai_place(grotto_init_05.Squad, 1);
            Engine.ai_place(grotto_init_07.Squad, 1);
            Engine.ai_place(grotto_init_09.Squad, 1);
            Engine.cs_run_command_script(grotto_init_09.Squad, grotto_entry_patrol);
            Engine.ai_place(grotto_init_11.Squad, 2);
            Engine.wake(grotto_cortana_comment);
            Engine.wake(grotto_pool);
            Engine.wake(grotto_extra_checkpoint);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_mid_02, Engine.players()) == true);
            Engine.game_save();
            if (await this.difficulty_heroic() || await this.difficulty_legendary())
            {
                this.grotto_final_snipers = 2;
            }

            Engine.begin_random(async () =>
            {
                if (this.grotto_final_snipers > 0 && (short)Engine.ai_living_count(grotto_enemies) < 8)
                {
                    Engine.ai_place(grotto_cave_jackals_02.Squad, 1);
                    this.grotto_final_snipers = (short)(this.grotto_final_snipers - 1);
                }
            }, 
                async () =>
            {
                if (this.grotto_final_snipers > 0 && (short)Engine.ai_living_count(grotto_enemies) < 8)
                {
                    Engine.ai_place(grotto_cave_jackals_03.Squad, 1);
                    this.grotto_final_snipers = (short)(this.grotto_final_snipers - 1);
                }
            });
            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_cave_jackals_01.Squad, 1);
            }

            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_cave_elites.Squad, 1);
            }

            Engine.wake(grotto_buggers_reinforce);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_far_top, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(grotto_reminder);
            Engine.ai_migrate(grotto_buggers_02.Squad, grotto_buggers_03.Squad);
            if ((short)Engine.ai_living_count(grotto_enemies) < 8 && await this.difficulty_legendary())
            {
                Engine.ai_place(grotto_buggers_03.Squad, (short)(4 - (float)Engine.ai_living_count(grotto_buggers)));
            }

            Engine.ai_set_orders(grotto_buggers, grotto_follow_03);
            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_end_elites_01.Squad, 1);
            }

            await Engine.sleep(30);
            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_end_jackals_02.Squad, 2);
            }

            await Engine.sleep(30);
            if ((short)Engine.ai_living_count(grotto_enemies) < 8)
            {
                Engine.ai_place(grotto_end_elites_02.Squad, 1);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_end, Engine.players()) == true);
            Engine.wake(music_05a_05_stop);
            Engine.game_save();
            Engine.ai_set_orders(grotto_initial, grotto_follow_03);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(grotto_enemies) < 1);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task approach_cortana_comment()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'good. still no word about in amber clad on the covenant battle-net.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0760"));
            await Engine.sleep(60);
            Engine.print("cortana: 'it's odd - the covenant know we made land-fall,'");
            Engine.print("'but they don't seem to consider us a very serious threat.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0770"));
            await Engine.sleep(30);
            Engine.print("cortana: 'boy are they in for a big surprise!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0780"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task approach_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1, Engine.players()) == true, 30, 3600);
            if (Engine.volume_test_objects(vol_tower1, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'this tower cluster should connect to the structures further...'");
                Engine.print("'...out in the lake. let's get inside.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0790"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task temple_approach_start()
        {
            Engine.ai_disposable(grotto_enemies, true);
            Engine.data_mine_set_mission_segment("05a_10_tower_approach");
            Engine.ai_place(approach_jackal_01.Squad);
            Engine.ai_place(approach_jackal_02.Squad);
            Engine.ai_place(approach_jackal_03.Squad);
            Engine.ai_place(approach_elite_01.Squad);
            Engine.ai_place(approach_elite_02.Squad);
            Engine.ai_place(approach_elite_03.Squad);
            Engine.ai_place(approach_grunts_01.Squad);
            Engine.wake(approach_cortana_comment);
            Engine.wake(approach_reminder);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach_ramp, Engine.players()) == true || Engine.volume_test_objects(vol_approach_music, Engine.players()) == true && Engine.objects_can_see_flag(Engine.players(), see_tower1, 30F) == true);
            Engine.wake(music_05a_06_start);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(approach_enemies) > this.ai_combat_status_idle || Engine.volume_test_objects(vol_approach_ramp, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_approach_ramp, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_living_count(approach_enemies) < 8)
            {
                Engine.ai_place(approach_buggers.Squad, 5);
            }

            await Engine.sleep(2);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(approach_buggers.Squad) < 1);
            await Engine.sleep_until(async () => Engine.volume_test_object(vol_no_see_ramp, await this.player0()) == true || Engine.volume_test_object(vol_no_see_approach, await this.player0()) == true && Engine.volume_test_object(vol_no_see_ramp, await this.player1()) == true || Engine.volume_test_object(vol_no_see_approach, await this.player1()) == true || (bool)Engine.game_is_cooperative() == false);
            if ((short)Engine.ai_living_count(approach_enemies) < 8)
            {
                Engine.ai_place(approach_buggers_too.Squad, 4);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task tower1_holo_looper()
        {
            Engine.object_create(regret03);
            Engine.objects_attach(tower1_throne.Entity, "driver", regret03.Entity, "");
            Engine.ai_disregard(regret03.Entity, true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant1a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3000"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2b", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3001"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant2c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3002"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3003"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant3c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3004"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant5a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3005"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896379080U), "regret_chant6a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3006"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task tower1_hg_warn()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1_see_hg, Engine.players()) == true && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower1_hg_01a.Squad), 0), 30F) || Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower1_hg_01b.Squad), 0), 30F));
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'watch yourself! honor-guards!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0800"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task long_pause_point()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) > this.ai_combat_status_idle);
            Engine.cs_aim_player(true);
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 4252703556U), "combat:rifle:warn", 1F, true);
            Engine.cs_aim_player(false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task tower1_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1, Engine.players()) == true);
            Engine.ai_disposable(approach_enemies, true);
            Engine.data_mine_set_mission_segment("05a_11_tower1_interior");
            Engine.wake(tower1_holo_looper);
            Engine.game_save();
            Engine.ai_place(tower1_hg_01a.Squad, 1);
            Engine.ai_place(tower1_hg_01b.Squad, 1);
            Engine.begin_random(async () =>
            {
                if (this.who_points == true)
                {
                    Engine.cs_run_command_script(tower1_hg_01a.Squad, long_pause_point);
                    Engine.ai_set_orders(tower1_hg_01a.Squad, tower1_hg1a);
                    Engine.cs_run_command_script(tower1_hg_01b.Squad, long_pause);
                    Engine.ai_set_orders(tower1_hg_01b.Squad, tower1_hg1b_back);
                    this.who_points = false;
                }
            }, 
                async () =>
            {
                if (this.who_points == true)
                {
                    Engine.cs_run_command_script(tower1_hg_01a.Squad, long_pause);
                    Engine.ai_set_orders(tower1_hg_01a.Squad, tower1_hg1a_back);
                    Engine.cs_run_command_script(tower1_hg_01b.Squad, long_pause_point);
                    Engine.ai_set_orders(tower1_hg_01b.Squad, tower1_hg1b);
                    this.who_points = false;
                }
            });
            Engine.wake(tower1_hg_warn);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower1_hg_01a.Squad) < 1 && (short)Engine.ai_living_count(tower1_hg_01b.Squad) < 1 || Engine.volume_test_objects(vol_tower1_upper, Engine.players()) == true);
            Engine.ai_place(tower1_hg_02a.Squad, (short)(1 - (float)Engine.ai_living_count(tower1_hg_01a.Squad)));
            Engine.ai_place(tower1_hg_02b.Squad, (short)(1 - (float)Engine.ai_living_count(tower1_hg_01b.Squad)));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower1_enemies) < 1, 30, 8000);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", tower1_enemies) == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1_all, Engine.players()) == true);
            await this.playtest_mission();
            await Engine.sleep(30);
            Engine.sound_class_set_gain("", 0F, 15);
            await this.cinematic_fade_to_white();
            await Engine.sleep(30);
            Engine.game_won();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task temple_ent_go()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("temple_ent/p2"), Engine.GetReference<ISpatialPoint>("temple_ent/p1"));
            Engine.cs_vehicle_speed(0.25F);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("temple_ent/p0"), Engine.GetReference<ISpatialPoint>("temple_ent/p1"));
            Engine.cs_move_in_direction(0F, 10F, 0F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_bunker_backup()
        {
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", Engine.ai_actors(LZ_warthog_01.Squad)) == true)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bunker_parking, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", LZ_warthog_01.Squad) == true);
            }

            Engine.ai_vehicle_exit(all_allies);
            Engine.ai_set_orders(all_allies, allies_bridge_bunker1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task ally_order_monitor()
        {
            await Engine.sleep_until(async () => this.lz_mounted_up == true || Engine.volume_test_objects(vol_lz_all, Engine.players()) == false);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_overlook_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_overlook_pause);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_overlook_follow);
                }

                return Engine.volume_test_objects(vol_overlook_pause, Engine.players()) == true;
            });
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_pause, Engine.players()) == true || Engine.volume_test_objects(vol_overlook_pause, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", overlook_jackals) == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_pause, Engine.players()) == true, 30, 300);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_bridge_follow_01);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_pause);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_01);
                }

                return Engine.volume_test_objects(vol_bridge_pause, Engine.players()) == true;
            });
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge_pause, Engine.players()) == false && await this.player_count() > 0, 30, 300);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_bridge_follow_01);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_advance);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_01);
                }

                return Engine.volume_test_objects(vol_bridge_inside_bunker, Engine.players()) == true;
            });
            Engine.ai_set_orders(ally_infantry, allies_bridge_bunker1);
            Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_bunker1);
            Engine.wake(bridge_bunker_backup);
            await Engine.sleep_until(async () => this.bridge_pelican_arrived == true || Engine.volume_test_objects(vol_bridge_middle, Engine.players()) == true);
            await Engine.sleep_until(async () => Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true || Engine.volume_test_objects(vol_bridge_middle, Engine.players()) == true);
            Engine.ai_enter_squad_vehicles(all_allies);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_bridge_follow_02);
                Engine.ai_set_orders(bridge_tank1.Squad, allies_bridge_follow_02);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_cross);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_02);
                }

                return Engine.volume_test_objects(vol_winding_path, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_farside_all, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", bridge_farside_enemies) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_w_path_follow);
                Engine.ai_set_orders(bridge_tank1.Squad, allies_w_path_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_w_path_advance);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_w_path_follow);
                }

                return Engine.volume_test_objects(vol_temple_ent_start, Engine.players()) == true || Engine.volume_test_objects(vol_temple_entrance, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", winding_path_enemies) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_temple_ent_follow);
                Engine.ai_set_orders(bridge_tank1.Squad, allies_temple_ent_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_01);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true || this.temple_ent_phase_01 == true || Engine.volume_test_objects(vol_temple_ent_03, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", temple_ent_enemies_all) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_temple_ent_follow);
                Engine.ai_set_orders(bridge_tank1.Squad, allies_temple_ent_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_02);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true || this.temple_ent_phase_02 == true || Engine.volume_test_objects(vol_temple_ent_03, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", temple_ent_enemies_all) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_temple_ent_follow);
                Engine.ai_set_orders(bridge_tank1.Squad, allies_temple_ent_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_03);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true || Engine.volume_test_objects(vol_temple_ent_03, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", temple_ent_enemies_all) == true;
            });
            Engine.cs_run_command_script(bridge_tank1.driver, temple_ent_go);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_tunnel_follow);
                Engine.ai_set_orders(bridge_tank1.Squad, allies_tunnel_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_advance);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_follow);
                }

                return Engine.volume_test_objects(vol_old_temple_near_left, Engine.players()) == true || Engine.volume_test_objects(vol_tunnel_03, Engine.ai_actors(LZ_warthog_01.Squad)) == true && (bool)Engine.ai_trigger_test("done_fighting", tunnel_enemies_all) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_old_temple_follow);
                Engine.ai_set_orders(bridge_tank1.Squad, allies_old_temple_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_advance);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_follow);
                }

                return Engine.volume_test_objects(vol_old_temple_center_01, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_01, Engine.ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await Engine.sleep_until(async () => Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0()) == false && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player1()) == false);
            Engine.ai_vehicle_exit(all_allies);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            Engine.ai_migrate(allies_old_temple_pelican.Squad, allies_old_temple_real.Squad);
            Engine.ai_set_orders(all_allies, allies_old_temp_center);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, allies_grotto_suppress);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(grotto_enemies) > this.ai_combat_status_idle);
            Engine.ai_set_orders(all_allies, grotto_follow_01);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_exit, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, allies_grotto_exit);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.ai_set_orders(all_allies, allies_approach);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, allies_tower1);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_intro()
        {
            Engine.sleep_forever(lz_start);
            Engine.sleep_forever(lz_turret_track);
            Engine.sleep_forever(lz_turret_reminder);
            Engine.sleep_forever(lz_pelican);
            Engine.sleep_forever(lz_pelican_wait);
            Engine.sleep_forever(lz_phantom_03_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_bridge()
        {
            Engine.sleep_forever(overlook_start);
            Engine.sleep_forever(overlook_reminder);
            Engine.sleep_forever(bridges_start);
            Engine.sleep_forever(crack_spawn);
            Engine.sleep_forever(bunker_upper_spawn_01);
            Engine.sleep_forever(bunker_upper_spawn_03);
            Engine.sleep_forever(bunker_lower_spawn_01);
            Engine.sleep_forever(bunker_turret_remanning);
            Engine.sleep_forever(bunker_spawn_checker);
            Engine.sleep_forever(bridge_ghosts_by_phantom);
            Engine.sleep_forever(farside_ghosts_spawn);
            Engine.sleep_forever(bridge_phantom_reinforce_01a);
            Engine.sleep_forever(bridge_phantom_reinforce_01b);
            Engine.sleep_forever(bridge_phantom_reinforce_02a);
            Engine.sleep_forever(bridge_phantom_reinforce_02b);
            Engine.sleep_forever(bridge_cortana_comment);
            Engine.sleep_forever(bridge_wraith_warning);
            Engine.sleep_forever(bridge_activate_reminder);
            Engine.sleep_forever(bunker_holo_looper);
            Engine.sleep_forever(bridge_holo_translate);
            Engine.sleep_forever(bridge_pelican_wait);
            Engine.sleep_forever(bridge_cross_reminder);
            Engine.sleep_forever(bridge_banshee_spawn);
            Engine.sleep_forever(bridge_spare_ghost_spawn);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_winding_path()
        {
            Engine.sleep_forever(winding_path_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_temple_ent()
        {
            Engine.sleep_forever(old_temple_entrance_start);
            Engine.sleep_forever(temple_ent_ghost_alert);
            Engine.sleep_forever(temple_ent_veh_spawn);
            Engine.sleep_forever(temple_ent_reminder);
            Engine.sleep_forever(temple_ent_arch);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_tunnel()
        {
            Engine.sleep_forever(tunnel_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_old_temple()
        {
            Engine.sleep_forever(old_temple_start);
            Engine.sleep_forever(old_temple_near_right);
            Engine.sleep_forever(old_temple_far_left);
            Engine.sleep_forever(old_temple_far_right);
            Engine.sleep_forever(old_temple_below);
            Engine.sleep_forever(old_temple_center);
            Engine.sleep_forever(old_temple_courtyard);
            Engine.sleep_forever(old_temple_vehicle_spawn);
            Engine.sleep_forever(old_temple_pelican);
            Engine.sleep_forever(old_temple_phantom_01);
            Engine.sleep_forever(old_temple_phantom_02);
            Engine.sleep_forever(old_temple_turret_reman);
            Engine.sleep_forever(old_temple_perimeter_nuke);
            Engine.sleep_forever(old_temple_middle_ally);
            Engine.sleep_forever(old_temple_playfight);
            Engine.sleep_forever(old_temple_debris_comment);
            Engine.sleep_forever(old_temple_middle_comment);
            Engine.sleep_forever(old_temple_debris_reminder);
            Engine.sleep_forever(old_temple_holo_translate);
            Engine.sleep_forever(courtyard_holo_looper);
            Engine.sleep_forever(old_temple_archaeologist);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_grotto()
        {
            Engine.sleep_forever(grotto_start);
            Engine.sleep_forever(grotto_buggers_reinforce);
            Engine.sleep_forever(grotto_cortana_comment);
            Engine.sleep_forever(grotto_ally_comments);
            Engine.sleep_forever(grotto_reminder);
            Engine.sleep_forever(grotto_pool);
            Engine.sleep_forever(grotto_extra_checkpoint);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_approach()
        {
            Engine.sleep_forever(temple_approach_start);
            Engine.sleep_forever(approach_reminder);
        }

        [ScriptMethod(Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_black();
            if (Engine.volume_test_objects(vol_starting_locations, Engine.players()) == true)
            {
                Engine.sound_suppress_ambience_update_on_revert();
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

            await Engine.sleep(2);
            Engine.switch_bsp(0);
            await Engine.sleep(2);
            Engine.ai_allegiance(covenant, prophet);
            Engine.ai_allegiance(player, human);
            Engine.objectives_clear();
            await this.prep_return_from_intro();
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            Engine.wake(_05a_title0);
            Engine.wake(objective_lz_set);
            Engine.wake(kill_volumes);
            Engine.wake(lz_start);
            Engine.wake(ally_order_monitor);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_overlook, Engine.players()) == true);
            Engine.wake(overlook_start);
            Engine.wake(bridges_start);
            Engine.wake(objective_bridge_set);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_winding_path, Engine.players()) == true);
            Engine.wake(winding_path_start);
            Engine.wake(old_temple_entrance_start);
            Engine.wake(objective_bridge_clear);
            Engine.wake(objective_ruins_set);
            await this.sleep_intro();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true);
            Engine.wake(tunnel_start);
            Engine.wake(old_temple_start);
            Engine.wake(old_temple_courtyard);
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.wake(grotto_start);
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach, Engine.players()) == true);
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
            Engine.wake(objective_ruins_clear);
            Engine.wake(objective_tower1_set);
            await this.sleep_old_temple();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1, Engine.players()) == true);
            await this.sleep_grotto();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task short_allies()
        {
            Engine.ai_allegiance(player, human);
            Engine.ai_place(LZ_warthog_01.Squad);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0());
            Engine.ai_place_in_vehicle(allies_lz_ridge.Squad, LZ_warthog_01.Squad);
            Engine.object_teleport(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), ally_start);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_overlook_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_overlook_pause);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_overlook_follow);
                }

                return Engine.volume_test_objects(vol_overlook_pause, Engine.players()) == true;
            });
            await Engine.sleep(30);
            Engine.print("arrived");
            await Engine.sleep(30);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_bridge_follow_01);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_pause);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_01);
                }

                return Engine.volume_test_objects(vol_bridge_pause, Engine.players()) == true;
            });
            await Engine.sleep(30);
            Engine.print("arrived");
            await Engine.sleep(30);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_bridge_follow_02);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_cross);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_follow_02);
                }

                return Engine.volume_test_objects(vol_winding_path, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_farside_all, Engine.ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await Engine.sleep(30);
            Engine.print("arrived");
            await Engine.sleep(30);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_w_path_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_w_path_advance);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_w_path_follow);
                }

                return Engine.volume_test_objects(vol_temple_ent_start, Engine.players()) == true || Engine.volume_test_objects(vol_temple_entrance, Engine.ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await Engine.sleep(30);
            Engine.print("arrived");
            await Engine.sleep(30);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_temple_ent_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_advance_03);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_temple_ent_follow);
                }

                return Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true || Engine.volume_test_objects(vol_temple_ent_03, Engine.ai_actors(LZ_warthog_01.Squad)) == true;
            });
            Engine.cs_run_command_script(bridge_tank1.driver, temple_ent_go);
            await Engine.sleep(30);
            Engine.print("arrived");
            await Engine.sleep(30);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_tunnel_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_advance);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_tunnel_follow);
                }

                return Engine.volume_test_objects(vol_old_temple_near_left, Engine.players()) == true || Engine.volume_test_objects(vol_tunnel_03, Engine.ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await Engine.sleep(30);
            Engine.print("arrived");
            await Engine.sleep(30);
            await Engine.sleep_until(async () =>
            {
                Engine.ai_set_orders(ally_infantry, allies_old_temple_follow);
                if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player0()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1()) == true || Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_g", await this.player1()) == true)
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_advance);
                }
                else
                {
                    Engine.ai_set_orders(LZ_warthog_01.Squad, allies_old_temple_follow);
                }

                return Engine.volume_test_objects(vol_old_temple_center_01, Engine.players()) == true || Engine.volume_test_objects(vol_old_temple_center_01, Engine.ai_actors(LZ_warthog_01.Squad)) == true;
            });
            await Engine.sleep(30);
            Engine.print("arrived");
            await Engine.sleep(30);
            Engine.ai_vehicle_exit(all_allies);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), true);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), true);
            Engine.ai_migrate(allies_old_temple_pelican.Squad, allies_old_temple_real.Squad);
            Engine.ai_set_orders(all_allies, allies_old_temp_center);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, grotto_follow_01);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto_exit, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, allies_grotto_exit);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.ai_set_orders(all_allies, allies_approach);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, allies_tower1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 4);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_x05"), 0, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad\\inamberclad", 3848864755U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785556013U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\x05_building_debris\\x05_building_debris", 3850044421U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3855877214U), 2);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3857056880U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_02_predict()
        {
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3860006045U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3860530341U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3860595878U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3863807191U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
            await Engine.sleep(15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3860006045U), 0);
            await Engine.sleep(25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 2);
            await Engine.sleep(215);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3871802705U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\x05_building_debris\\x05_building_debris", 3850044421U), 0);
            await Engine.sleep(215);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3860595878U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3872130390U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\x05_building_debris\\x05_building_debris", 3850044421U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3872523612U), 0);
            await Engine.sleep(27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3873047908U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_04_predict()
        {
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3863807191U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3871802705U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
            await Engine.sleep(48);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3873113445U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3860595878U), 0);
            await Engine.sleep(63);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 2);
            await Engine.sleep(214);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3871802705U), 0);
            await Engine.sleep(13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3873047908U), 0);
            await Engine.sleep(128);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3860006045U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3860595878U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cigar\\cigar_bent\\cigar_bent", 3871802705U), 0);
            await Engine.sleep(91);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3860530341U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_05_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3873047908U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_06a_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3863807191U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_06b_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 60);
            await Engine.sleep(121);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3860595878U), 0);
            await Engine.sleep(238);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3857187954U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\crewman\\crewman", 3865183468U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3860595878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3872130390U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3872523612U), 0);
            await Engine.sleep(31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\delta_halo_close", 3873441130U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_07_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task x05_08_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_hevbay\\inamberclad_hevbay", 3863807191U), 0);
            await Engine.sleep(101);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3860595878U), 0);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_halo_close\\delta_halo_close", 3873441130U), 0);
            await Engine.sleep(66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3872523612U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3872130390U), 0);
            await Engine.sleep(40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05_intro_01_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_islands\\delta_islands", 3873637741U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\delta_horizon", 3873834352U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev_reentry\\hev_reentry", 3874030963U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3873047908U), 0);
            await Engine.sleep(75);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3873047908U), 0);
            await Engine.sleep(97);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            await Engine.sleep(54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_chute\\hev_chute", 3873047908U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_islands\\delta_islands", 3873637741U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
            await Engine.sleep(106);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 0, false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05_intro_02_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 69, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 70, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 74, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 83, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 90, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 71, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 76, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 82, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3860530341U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3874293111U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3874882944U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3864921320U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 59, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 4);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3874948481U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3874948481U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3876259221U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3880125904U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 14);
            await Engine.sleep(138);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 59, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 65, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 52, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 53, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 55, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 119, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_bush\\tree_bush", 3880650200U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_branch\\tree_branch", 3880715737U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3874882944U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3880125904U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_leafy\\tree_leafy_small\\tree_leafy_small", 3860006045U), 1);
            await Engine.sleep(76);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            await Engine.sleep(60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3880781274U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3880781274U), 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _05_intro_03_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 76, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 10, true);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3878487479U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev_door\\hev_door", 3860530341U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3867018504U), 6);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 16, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3874948481U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\c_turret_ap\\c_turret_ap", 3874948481U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786670142U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_bush\\tree_bush", 3880650200U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 59, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3880977885U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\battle_rifle\\battle_rifle", 3881305570U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 88, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3874882944U), 1);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 87, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 93, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 84, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 85, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 86, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 95, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 96, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3874293111U), 1);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 101, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 97, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 89, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 99, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_branch\\tree_branch", 3880715737U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3810132388U), 2);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 90, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3882485236U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 73, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 94, true);
            await Engine.sleep(89);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\invisible_box1x2x2\\invisible_box1x2x2", 3883468291U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 98, true);
            await Engine.sleep(15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3810132388U), 0);
            await Engine.sleep(22);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 69, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 70, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 74, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 76, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 79, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 83, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 71, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 82, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\jackal\\jackal", 3876259221U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3880781274U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\jackal_shield\\jackal_shield", 3880781274U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3874293111U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786670142U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            await Engine.sleep(22);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 88, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3810132388U), 2);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 29, false);
            await Engine.sleep(17);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 17, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 86, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 95, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 96, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 97, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 99, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 94, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 101, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 98, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3882485236U), 0);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 73, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 96, true);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 95, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 28, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 71, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 78, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 79, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 81, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 101, true);
            await Engine.sleep(40);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 84, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3874882944U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\hev\\hev", 3859154064U), 1);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 80, true);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 14, false);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786670142U), 2);
            await Engine.sleep(29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3786670142U), 2);
            await Engine.sleep(62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3870688576U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3810132388U), 2);
            await Engine.sleep(65);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
            await Engine.sleep(47);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_00"), 3, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_bridge()
        {
            Engine.ai_erase_all();
            Engine.ai_place(LZ_warthog_01.Squad);
            Engine.device_set_position(da_bridge.Entity, 0.5F);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_d", await this.player0());
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), "warthog_p", await this.player1());
            Engine.ai_place_in_vehicle(allies_lz_ledge.Squad, LZ_warthog_01.Squad);
            Engine.object_teleport(Engine.ai_vehicle_get_from_starting_location(LZ_warthog_01.driver), bridge_player0);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.ai_set_orders(LZ_warthog_01.Squad, allies_bridge_pause);
            Engine.wake(bridges_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_winding_path, Engine.players()) == true);
            Engine.wake(winding_path_start);
            Engine.wake(old_temple_entrance_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true);
            Engine.wake(tunnel_start);
            Engine.wake(old_temple_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.wake(grotto_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach, Engine.players()) == true);
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_winding_path()
        {
            Engine.ai_erase_all();
            Engine.ai_place(bridge_tank1.Squad);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            Engine.object_teleport(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), winding_path_player0);
            Engine.ai_set_orders(all_allies, allies_w_path_follow);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_bridge();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(winding_path_start);
            Engine.wake(old_temple_entrance_start);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true);
            Engine.wake(tunnel_start);
            Engine.wake(old_temple_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.wake(grotto_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach, Engine.players()) == true);
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_temple_ent()
        {
            Engine.ai_erase_all();
            Engine.ai_place(bridge_tank1.Squad);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            Engine.object_teleport(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), temple_ent_player0);
            Engine.ai_set_orders(all_allies, temple_ent_all);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(old_temple_entrance_start);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01, Engine.players()) == true);
            Engine.wake(tunnel_start);
            Engine.wake(old_temple_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.wake(grotto_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach, Engine.players()) == true);
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_tunnel()
        {
            Engine.ai_erase_all();
            Engine.ai_place(bridge_tank1.Squad);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            Engine.object_teleport(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), tunnel_player0);
            Engine.ai_set_orders(all_allies, allies_tunnel_follow);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(tunnel_start);
            Engine.wake(old_temple_start);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.wake(grotto_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach, Engine.players()) == true);
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_old_temple()
        {
            Engine.ai_erase_all();
            Engine.ai_place(bridge_tank1.Squad);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), "scorpion_d", await this.player0());
            Engine.object_teleport(Engine.ai_vehicle_get_from_starting_location(bridge_tank1.driver), old_temple_player0);
            Engine.ai_set_orders(all_allies, allies_old_temple_follow);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(old_temple_start);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep(1);
            Engine.wake(ally_order_monitor);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_grotto, Engine.players()) == true);
            Engine.wake(grotto_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach, Engine.players()) == true);
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_grotto()
        {
            Engine.ai_erase_all();
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), grotto_player0);
            Engine.object_teleport(await this.player1(), grotto_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await this.sleep_old_temple();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(grotto_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_approach, Engine.players()) == true);
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_approach()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), approach_player0);
            Engine.object_teleport(await this.player1(), approach_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await this.sleep_old_temple();
            await this.sleep_grotto();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(temple_approach_start);
            Engine.wake(tower1_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_tower1()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), tower1_player0);
            Engine.object_teleport(await this.player1(), tower1_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_bridge();
            await this.sleep_winding_path();
            await this.sleep_temple_ent();
            await this.sleep_tunnel();
            await this.sleep_old_temple();
            await this.sleep_grotto();
            await this.sleep_approach();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(tower1_start);
        }
    }
}