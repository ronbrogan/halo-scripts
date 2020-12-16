namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\01a_tutorial\\01a_tutorial")]
    public partial class scnr_01a_tutorial : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int seconds;
        int global_random;
        int global_random_rumble;
        int global_random_bridge;
        int delay_prompt_blink;
        int delay_prompt_short;
        int delay_prompt_medium;
        int delay_prompt_long;
        int delay_prompt_drag;
        int delay_prompt_final;
        bool mark_bsp0;
        bool mark_bsp1;
        bool mark_bsp2;
        bool mark_bsp3;
        bool mark_bsp4;
        bool mark_bsp5;
        int counter_mindread_normal_success;
        int counter_mindread_invert_success;
        int counter_training_pitch_choose;
        int counter_prompt_looker_start;
        int counter_prompt_looker;
        int counter_prompt_start_spot;
        int counter_prompt_careful;
        int counter_prompt_zapper_lookatme;
        int counter_prompt_zapper_getin;
        int counter_prompt_zapper_button;
        int counter_prompt_elevator_plr;
        bool mark_looker_light_left;
        bool mark_looker_light_right;
        bool mark_looker_light_top;
        bool mark_looker_light_bottom;
        bool mark_training_free;
        bool mark_training_done;
        int timer_training_pitch_choose;
        int timer_prompt_looker_start;
        int timer_prompt_looker;
        int timer_prompt_start_spot;
        int timer_prompt_careful;
        int timer_prompt_zapper;
        int timer_prompt_zapper_lookatme;
        int timer_prompt_zapper_getin;
        int timer_prompt_zapper_button;
        int timer_prompt_elevator_plr;
        bool mark_ice_cream;
        public scnr_01a_tutorial(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.seconds = 30;
            this.global_random = 0;
            this.global_random_rumble = 0;
            this.global_random_bridge = 0;
            this.delay_prompt_blink = (short)(2 * this.seconds);
            this.delay_prompt_short = (short)(8 * this.seconds);
            this.delay_prompt_medium = (short)(16 * this.seconds);
            this.delay_prompt_long = (short)(36 * this.seconds);
            this.delay_prompt_drag = (short)(48 * this.seconds);
            this.delay_prompt_final = (short)(60 * this.seconds);
            this.mark_bsp0 = false;
            this.mark_bsp1 = false;
            this.mark_bsp2 = false;
            this.mark_bsp3 = false;
            this.mark_bsp4 = false;
            this.mark_bsp5 = false;
            this.counter_mindread_normal_success = 0;
            this.counter_mindread_invert_success = 0;
            this.counter_training_pitch_choose = 0;
            this.counter_prompt_looker_start = 0;
            this.counter_prompt_looker = 0;
            this.counter_prompt_start_spot = 0;
            this.counter_prompt_careful = 0;
            this.counter_prompt_zapper_lookatme = 0;
            this.counter_prompt_zapper_getin = 0;
            this.counter_prompt_zapper_button = 0;
            this.counter_prompt_elevator_plr = 0;
            this.mark_looker_light_left = false;
            this.mark_looker_light_right = false;
            this.mark_looker_light_top = false;
            this.mark_looker_light_bottom = false;
            this.mark_training_free = false;
            this.mark_training_done = false;
            this.timer_training_pitch_choose = 0;
            this.timer_prompt_looker_start = 0;
            this.timer_prompt_looker = 0;
            this.timer_prompt_start_spot = 0;
            this.timer_prompt_careful = 0;
            this.timer_prompt_zapper = 0;
            this.timer_prompt_zapper_lookatme = 0;
            this.timer_prompt_zapper_getin = 0;
            this.timer_prompt_zapper_button = 0;
            this.timer_prompt_elevator_plr = 0;
            this.mark_ice_cream = false;
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
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_start();
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
            Engine.fade_out(0F, 0F, 0F, 15);
            await Engine.sleep(15);
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_start();
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
        public async Task save_look_start()
        {
            if ((bool)Engine.game_safe_to_save())
            {
                Engine.data_mine_set_mission_segment("01a_look_start");
            }
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task save_move_start()
        {
            Engine.game_save();
            if ((bool)Engine.game_safe_to_save())
            {
                Engine.data_mine_set_mission_segment("01a_move_start");
            }
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task save_shield_start()
        {
            Engine.game_save();
            if ((bool)Engine.game_safe_to_save())
            {
                Engine.data_mine_set_mission_segment("01a_shield_start");
            }
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task save_tram_start()
        {
            Engine.game_save();
            if ((bool)Engine.game_safe_to_save())
            {
                Engine.data_mine_set_mission_segment("01a_tram_start");
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_player()
        {
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_guns()
        {
            Engine.cs_face_object(true, Engine.ai_get_object(guns.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_johnson_glanceat_guns()
        {
            Engine.cs_enable_looking(true);
            Engine.cs_look_object(true, Engine.ai_get_object(guns.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_johnson()
        {
            Engine.cs_face_object(true, Engine.ai_get_object(johnson.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_console_zapper()
        {
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("guns_points/console_zapper"));
            await Engine.sleep(45);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_console_toplight()
        {
            Engine.cs_aim_object(true, looker_light_top_red.Entity);
            await Engine.sleep(45);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("guns_points/console_inhibitor"));
            await Engine.sleep(30);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_console_bottomlight()
        {
            Engine.cs_aim_object(true, looker_light_bottom_red.Entity);
            await Engine.sleep(45);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("guns_points/console_inhibitor"));
            await Engine.sleep(30);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_console_inhibitor()
        {
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("guns_points/console_inhibitor"));
            await Engine.sleep(30);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_guns_start()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("guns_points/start"));
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_guns_zapper_halfway()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("guns_points/zapper_halfway"));
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_guns_zapper_wait()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("guns_points/zapper"));
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_guns_zapper()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("guns_points/zapper"), Engine.GetReference<ISpatialPoint>("guns_points/zapper_face"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("guns_points/zapper_face"));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_guns_zapper_prompt()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_face_player(true);
            await Engine.sleep(90);
            Engine.cs_face_player(false);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("guns_points/zapper"), Engine.GetReference<ISpatialPoint>("guns_points/zapper_face"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("guns_points/zapper_face"));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_johnson_start()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("johnson_points/start"));
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_johnson_elevator()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("johnson_points/elevator"));
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_johnson_elevator_face_guns()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("johnson_points/elevator"));
            Engine.cs_face_object(true, Engine.ai_get_object(guns.Squad));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_guns_elevator()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("guns_points/elevator"));
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_johnson_tram()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("johnson_points/tram"), Engine.GetReference<ISpatialPoint>("johnson_points/earth"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("johnson_points/earth"));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_macgun()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("johnson_points/tram_2"), Engine.GetReference<ISpatialPoint>("johnson_points/macgun"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("johnson_points/macgun"));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_malta()
        {
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("johnson_points/malta"));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_lookat_fleet()
        {
            Engine.cs_face_object(true, inamberclad.Entity);
            Engine.cs_look_object(true, inamberclad.Entity);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_johnson_lookat_station()
        {
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("johnson_points/station"));
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cs_johnson_station()
        {
            Engine.cs_force_combat_status(2);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("johnson_points/station"));
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_looker_start()
        {
            if (this.counter_prompt_looker_start == 0)
            {
                Engine.print("go ahead and look at each of the four lights, chief.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3110_gun", 3861316785U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3110_gun", 3861316785U));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_short);
            }
            else if (this.counter_prompt_looker_start == 1)
            {
                Engine.print("go ahead and target them one more time.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1360_gun", 3861382322U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1360_gun", 3861382322U));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_medium);
            }
            else if (true)
            {
                this.counter_prompt_looker_start = 0;
            }

            this.counter_prompt_looker_start = (short)(this.counter_prompt_looker_start + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_looker()
        {
            if (this.counter_prompt_looker == 0)
            {
                Engine.print("you have to look at each light until it turns green.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1310_gun", 3861447859U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1310_gun", 3861447859U));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_short);
            }
            else if (this.counter_prompt_looker == 1)
            {
                Engine.print("you gotta look at all the lights to complete the test.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1370_gun", 3861513396U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1370_gun", 3861513396U));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_short);
            }
            else if (this.counter_prompt_looker == 2)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                Engine.print("look at the lights, chief, one by one.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1300_gun", 3861578933U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1300_gun", 3861578933U));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_looker == 3)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                Engine.print("please look at the lights again, son.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1350_gun", 3861644470U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1350_gun", 3861644470U));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_medium);
            }
            else if (true)
            {
                this.counter_prompt_looker = 0;
            }

            this.counter_prompt_looker = (short)(this.counter_prompt_looker + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_start_spot()
        {
            if (this.counter_prompt_start_spot == 0)
            {
                Engine.print("go on, walk around, try it out.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0820_gun", 3861710007U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_start_spot = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0820_gun", 3861710007U));
                this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_short);
            }
            else if (this.counter_prompt_start_spot == 1)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "inquisitive", 0.5F, 1);
                Engine.print("something wrong son?  can't you move?");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0830_gun", 3861775544U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_start_spot = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0830_gun", 3861775544U));
                this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_start_spot == 2)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "inquisitive", 0.5F, 1);
                Engine.print("inhibitors are definitely off. you should be able to walk around.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0840_gun", 3861841081U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_start_spot = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0840_gun", 3861841081U));
                this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_medium);
            }
            else if (true)
            {
                this.counter_prompt_start_spot = 0;
            }

            this.counter_prompt_start_spot = (short)(this.counter_prompt_start_spot + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_careful()
        {
            if (this.counter_prompt_careful == 0)
            {
                Engine.cs_run_command_script(guns.Squad, cs_lookat_player);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "scared", 0.5F, 1);
                await Engine.sleep(8);
                Engine.print("hey! take it easy!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0850_gun", 3861906618U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0850_gun", 3861906618U)));
                await Engine.sleep(30);
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_wait);
            }
            else if (this.counter_prompt_careful == 1)
            {
                Engine.cs_run_command_script(guns.Squad, cs_lookat_player);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "scared", 0.5F, 1);
                await Engine.sleep(8);
                Engine.print("careful! you'll tear a tendon doing that!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0860_gun", 3861972155U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0860_gun", 3861972155U)));
                await Engine.sleep(30);
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_wait);
            }
            else if (this.counter_prompt_careful == 2)
            {
                Engine.cs_run_command_script(guns.Squad, cs_lookat_player);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await Engine.sleep(8);
                Engine.print("fine. but don't come crying to me when your rip your leg out of its socket.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0870_gun", 3862037692U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0870_gun", 3862037692U)));
                await Engine.sleep(30);
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_wait);
            }
            else if (true)
            {
                this.counter_prompt_careful = 2;
            }

            this.timer_prompt_careful = this.delay_prompt_blink;
            this.counter_prompt_careful = (short)(this.counter_prompt_careful + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_zapper_lookatme()
        {
            Engine.hud_show_training_text(false);
            if (this.counter_prompt_zapper_lookatme == 0)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("are you listening to me?.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3160_gun", 3862103229U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3160_gun", 3862103229U));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_lookatme == 1)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("over here, chief.  focus.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3170_gun", 3862168766U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3170_gun", 3862168766U));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_lookatme == 2)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("it's considered respectful to look at someone when they are talking.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3180_gun", 3862234303U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3180_gun", 3862234303U));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_lookatme == 3)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("this is important, you could at least look at me while i explain it.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3190_gun", 3862299840U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3190_gun", 3862299840U));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_lookatme == 4)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("i'm talking to you, chief.  loot at me.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3200_gun", 3862365377U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3200_gun", 3862365377U));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                Engine.hud_set_training_text("tutorial_zapper_lookatme");
                Engine.hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_lookatme == 5)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("i know you spartans think you know everything, but it couldn't hurt you to at least look this way.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3210_gun", 3862430914U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3210_gun", 3862430914U));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                Engine.hud_set_training_text("tutorial_zapper_lookatme");
                Engine.hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_lookatme == 6)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("look, just because the brass kisses your ass, doesn't mean i will.  look at me when i talk to you!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3220_gun", 3862496451U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3220_gun", 3862496451U));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_drag);
                Engine.hud_set_training_text("tutorial_zapper_lookatme");
                Engine.hud_show_training_text(true);
            }
            else if (true)
            {
                this.counter_prompt_zapper_lookatme = 3;
            }

            this.counter_prompt_zapper_lookatme = (short)(this.counter_prompt_zapper_lookatme + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_zapper_getin()
        {
            Engine.hud_show_training_text(false);
            if (this.counter_prompt_zapper_getin == 0)
            {
                Engine.custom_animation(Engine.ai_get_unit(guns.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0900_jon", true);
                Engine.objectives_finish_up_to(0);
                Engine.objectives_show_up_to(1);
                await Engine.sleep(10);
                Engine.print("step on in. i'll show you.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0900_gun", 3862693062U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0900_gun", 3862693062U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_getin == 1)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                await Engine.sleep(30);
                Engine.print("step into the red sqaure, chief, and we'll get started.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3230_gun", 3862758599U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3230_gun", 3862758599U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_getin == 2)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                await Engine.sleep(30);
                Engine.print("chief? stand in the red square.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3240_gun", 3862824136U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3240_gun", 3862824136U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_getin == 3)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                await Engine.sleep(30);
                Engine.print("you have to stand in the red square before we can start the test.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3250_gun", 3862889673U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3250_gun", 3862889673U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_getin == 4)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("go ahead and stand in the red sqaure.� it'll just take a minute.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3260_gun", 3862955210U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3260_gun", 3862955210U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
            }
            else if (this.counter_prompt_zapper_getin == 5)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("come on, son, step into the red square.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3270_gun", 3863020747U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3270_gun", 3863020747U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                Engine.hud_set_training_text("tutorial_zapper_getin");
                Engine.hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_getin == 5)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("will you stop screwing around?� stand in the red square!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3280_gun", 3863086284U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3280_gun", 3863086284U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                Engine.hud_set_training_text("tutorial_zapper_getin");
                Engine.hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_getin == 5)
            {
                Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_prompt);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await Engine.sleep(30);
                Engine.print("stop bustin' my balls, and step in the damn square!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3290_gun", 3863151821U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3290_gun", 3863151821U));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_drag);
                Engine.hud_set_training_text("tutorial_zapper_getin");
                Engine.hud_show_training_text(true);
            }
            else if (true)
            {
                this.counter_prompt_zapper_getin = 2;
            }

            this.counter_prompt_zapper_getin = (short)(this.counter_prompt_zapper_getin + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_zapper_button()
        {
            Engine.hud_show_training_text(false);
            if (this.counter_prompt_zapper_button == 0)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0F, 1);
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0F, 1);
                Engine.device_set_power(zapper_control.Entity, 1F);
                Engine.print("your new armor's shields are extremely resilient - very efficient.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0880_gun", 3863217358U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(2 * (float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0880_gun", 3863217358U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + 0);
            }
            else if (this.counter_prompt_zapper_button == 1)
            {
                Engine.print("much better than the covenant tech we used for the mark-five.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0890_gun", 3863282895U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(2 * (float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0890_gun", 3863282895U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + 0);
            }
            else if (this.counter_prompt_zapper_button == 2)
            {
                Engine.custom_animation(Engine.ai_get_unit(guns.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0910_jon", true);
                Engine.objectives_finish_up_to(1);
                Engine.objectives_show_up_to(2);
                await Engine.sleep(10);
                Engine.print("go ahead and use the switch in front of you to start the shield test.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3300_gun", 3863348432U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3300_gun", 3863348432U));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_button == 3)
            {
                Engine.print("just place your hand on the touchpad to activate the switch.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3310_gun", 3863413969U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3310_gun", 3863413969U));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_button == 4)
            {
                Engine.print("hit the switch, it won't hurt�.much");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3340_gun", 3863479506U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3340_gun", 3863479506U));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_button == 5)
            {
                Engine.print("go ahead and use that switch in front of you.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3330_gun", 3863545043U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3330_gun", 3863545043U));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                Engine.hud_set_training_text("tutorial_zapper_button");
                Engine.hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_button == 6)
            {
                Engine.print("the switch right in front of you will start the shield test.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3320_gun", 3863610580U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3320_gun", 3863610580U));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                Engine.hud_set_training_text("tutorial_zapper_button");
                Engine.hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_button == 7)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                Engine.print("it's a switch.  you press it.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3350_gun", 3863676117U), Engine.ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3350_gun", 3863676117U));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_drag);
                Engine.hud_set_training_text("tutorial_zapper_button");
                Engine.hud_show_training_text(true);
            }
            else if (true)
            {
                this.counter_prompt_zapper_button = 2;
            }

            this.counter_prompt_zapper_button = (short)(this.counter_prompt_zapper_button + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> prompt_elevator_plr()
        {
            Engine.hud_show_training_text(false);
            if (this.counter_prompt_elevator_plr == 0)
            {
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_short);
                Engine.objectives_show_up_to(3);
            }
            else if (this.counter_prompt_elevator_plr == 1)
            {
                Engine.print("c'mon, chief, they're ready for us on the bridge.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1640_jon", 3863741654U), Engine.ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1640_jon", 3863741654U));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_short);
            }
            else if (this.counter_prompt_elevator_plr == 2)
            {
                Engine.print("get on the lift, cheif, we're gonna be late.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1650_jon", 3863807191U), Engine.ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1650_jon", 3863807191U));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_elevator_plr == 3)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(johnson.Squad), "annoyed", 0.5F, 1);
                Engine.print("i don't want to keep the brass waiting, chief.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1660_jon", 3863872728U), Engine.ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1660_jon", 3863872728U));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_elevator_plr == 4)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(johnson.Squad), "annoyed", 0.5F, 1);
                Engine.print("fine. you can tell lord hood why we're late!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1670_jon", 3863938265U), Engine.ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1670_jon", 3863938265U));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
            }
            else if (this.counter_prompt_elevator_plr == 5)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(johnson.Squad), "angry", 0.5F, 1);
                Engine.print("get your shiny green posterior on this elevator!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1680_jon", 3864003802U), Engine.ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1680_jon", 3864003802U));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
            }
            else if (this.counter_prompt_elevator_plr == 6)
            {
                Engine.unit_set_emotional_state(Engine.ai_get_unit(johnson.Squad), "angry", 0.5F, 1);
                Engine.print("would it help if i said please?");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1690_jon", 3864069339U), Engine.ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1690_jon", 3864069339U));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_drag);
                this.mark_ice_cream = true;
            }
            else if (true)
            {
                this.counter_prompt_elevator_plr = 0;
            }

            this.counter_prompt_elevator_plr = (short)(this.counter_prompt_elevator_plr + 1);
            return false;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_setup()
        {
            Engine.game_can_use_flashlights(false);
            Engine.unit_set_maximum_vitality(await this.player0(), 30F, 1F);
            Engine.device_set_power(zapper_control.Entity, 0F);
            Engine.device_set_position_immediate(elevator_tram.Entity, 0F);
            Engine.ai_place(guns.Squad);
            Engine.ai_cannot_die(guns.Squad, true);
            Engine.cs_run_command_script(guns.Squad, cs_guns_start);
        }

        [ScriptMethod(Lifecycle.Startup)]
        public async Task icecream()
        {
            await Engine.sleep_until(async () => this.mark_ice_cream && await this.difficulty_legendary(), 1);
            Engine.object_create(cookiesncream);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3826516638U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3826516638U)), 1);
            Engine.ice_cream_flavor_stock(14);
            Engine.print("blam");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task test_mindread_up()
        {
            Engine.object_create(looker_light_top_red);
            Engine.player_action_test_reset();
            Engine.player_action_test_look_up_begin();
            Engine.player_camera_control(true);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_toplight);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), looker_light_top_red.Entity, 5F) || (bool)Engine.player0_looking_up(), 1, 360);
            if (!(Engine.objects_can_see_object(Engine.players(), looker_light_top_red.Entity, 5F) || (bool)Engine.player0_looking_up()))
            {
                Engine.print("go ahead and look at the top light, chief.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3070_gun", 3864134876U), Engine.ai_get_object(guns.Squad), 1F);
                Engine.hud_set_training_text("tutorial_look_up");
                Engine.hud_show_training_text(true);
                Engine.hud_enable_training(true);
            }

            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), looker_light_top_red.Entity, 5F) || (bool)Engine.player0_looking_up(), 1);
            Engine.player_camera_control(false);
            Engine.hud_enable_training(false);
            Engine.hud_show_training_text(false);
            Engine.object_destroy(looker_light_top_red.Entity);
            if (!((bool)Engine.player_action_test_lookstick_backward()))
            {
                this.counter_mindread_normal_success = (short)(this.counter_mindread_normal_success + 1);
                this.counter_mindread_invert_success = 0;
                Engine.print("normal success");
            }
            else if (!((bool)Engine.player_action_test_lookstick_forward()))
            {
                this.counter_mindread_invert_success = (short)(this.counter_mindread_invert_success + 1);
                this.counter_mindread_normal_success = 0;
                Engine.print("invert success");
            }
            else if (true)
            {
                this.counter_mindread_normal_success = 0;
                this.counter_mindread_invert_success = 0;
            }

            Engine.player_camera_control(false);
            Engine.player_action_test_look_pitch_end();
            Engine.player_action_test_reset();
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3070_gun", 3864134876U)));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task test_mindread_down()
        {
            Engine.object_create(looker_light_bottom_red);
            Engine.player_action_test_reset();
            Engine.player_action_test_look_down_begin();
            Engine.player_camera_control(true);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_bottomlight);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), looker_light_bottom_red.Entity, 3F) || (bool)Engine.player0_looking_down(), 1, 360);
            if (!(Engine.objects_can_see_object(Engine.players(), looker_light_bottom_red.Entity, 3F) || (bool)Engine.player0_looking_down()))
            {
                Engine.print("look at the bottom light, son.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3060_gun", 3864200413U), Engine.ai_get_object(guns.Squad), 1F);
                Engine.hud_set_training_text("tutorial_look_down");
                Engine.hud_show_training_text(true);
                Engine.hud_enable_training(true);
            }

            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), looker_light_bottom_red.Entity, 3F) || (bool)Engine.player0_looking_down(), 1);
            Engine.player_camera_control(false);
            Engine.hud_enable_training(false);
            Engine.hud_show_training_text(false);
            Engine.object_destroy(looker_light_bottom_red.Entity);
            if (!((bool)Engine.player_action_test_lookstick_forward()))
            {
                this.counter_mindread_normal_success = (short)(this.counter_mindread_normal_success + 1);
                this.counter_mindread_invert_success = 0;
                Engine.print("normal success");
            }
            else if (!((bool)Engine.player_action_test_lookstick_backward()))
            {
                this.counter_mindread_invert_success = (short)(this.counter_mindread_invert_success + 1);
                this.counter_mindread_normal_success = 0;
                Engine.print("invert success");
            }
            else if (true)
            {
                this.counter_mindread_normal_success = 0;
                this.counter_mindread_invert_success = 0;
            }

            Engine.player_camera_control(false);
            Engine.player_action_test_look_pitch_end();
            Engine.player_action_test_reset();
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3060_gun", 3864200413U)));
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_looker_lights_on()
        {
            Engine.object_destroy(looker_light_left_green.Entity);
            Engine.object_create(looker_light_left_red);
            this.mark_looker_light_left = true;
            Engine.object_destroy(looker_light_right_green.Entity);
            Engine.object_create(looker_light_right_red);
            this.mark_looker_light_right = true;
            Engine.object_destroy(looker_light_top_green.Entity);
            Engine.object_create(looker_light_top_red);
            this.mark_looker_light_top = true;
            Engine.object_destroy(looker_light_bottom_green.Entity);
            Engine.object_create(looker_light_bottom_red);
            this.mark_looker_light_bottom = true;
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_looker_lights_off()
        {
            Engine.object_destroy(looker_light_left_green.Entity);
            Engine.object_destroy(looker_light_left_red.Entity);
            Engine.object_destroy(looker_light_right_green.Entity);
            Engine.object_destroy(looker_light_right_red.Entity);
            Engine.object_destroy(looker_light_top_green.Entity);
            Engine.object_destroy(looker_light_top_red.Entity);
            Engine.object_destroy(looker_light_bottom_green.Entity);
            Engine.object_destroy(looker_light_bottom_red.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> test_all_lights_off()
        {
            return !(this.mark_looker_light_left || this.mark_looker_light_right || this.mark_looker_light_top || this.mark_looker_light_bottom);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task<bool> training_pitch_choose()
        {
            if (this.counter_training_pitch_choose <= 2)
            {
                await this.training_looker_lights_on();
                await this.prompt_looker_start();
                await Engine.sleep_until(async () =>
                {
                    if (await this.test_all_lights_off())
                    {
                        return true;
                    }
                    else if (Engine.objects_can_see_object(Engine.players(), looker_light_left_red.Entity, 5F))
                    {
                        Engine.object_destroy(looker_light_left_red.Entity);
                        Engine.object_create_anew(looker_light_left_green);
                        this.mark_looker_light_left = false;
                        return this.mark_looker_light_left;
                    }
                    else if (Engine.objects_can_see_object(Engine.players(), looker_light_right_red.Entity, 5F))
                    {
                        Engine.object_destroy(looker_light_right_red.Entity);
                        Engine.object_create_anew(looker_light_right_green);
                        this.mark_looker_light_right = false;
                        return this.mark_looker_light_right;
                    }
                    else if (Engine.objects_can_see_object(Engine.players(), looker_light_top_red.Entity, 5F))
                    {
                        Engine.object_destroy(looker_light_top_red.Entity);
                        Engine.object_create_anew(looker_light_top_green);
                        this.mark_looker_light_top = false;
                        return this.mark_looker_light_top;
                    }
                    else if (Engine.objects_can_see_object(Engine.players(), looker_light_bottom_red.Entity, 5F))
                    {
                        Engine.object_destroy(looker_light_bottom_red.Entity);
                        Engine.object_create_anew(looker_light_bottom_green);
                        this.mark_looker_light_bottom = false;
                        return this.mark_looker_light_bottom;
                    }
                    else if (this.timer_prompt_looker > 0)
                    {
                        this.timer_prompt_looker = (short)(this.timer_prompt_looker - 1);
                        return false;
                    }
                    else if (true)
                    {
                        return await this.prompt_looker();
                    }
                }, 1);
            }

            this.counter_training_pitch_choose = (short)(this.counter_training_pitch_choose + 1);
            if ((bool)Engine.controller_get_look_invert())
            {
                Engine.print("should i leave it inverted, or put it back to normal?");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1450_gun", 3864265950U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1450_gun", 3864265950U)));
                Engine.print("press a to leave lookstick inverted, press b to try it normal.");
                Engine.hud_set_training_text("tutorial_choose_invert");
            }
            else
            {
                Engine.print("should i leave it normal, or put it back to inverted?");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1470_gun", 3864331487U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1470_gun", 3864331487U)));
                Engine.print("press a to leave lookstick normal, press b to try it inverted.");
                Engine.hud_set_training_text("tutorial_choose_normal");
            }

            Engine.hud_show_training_text(true);
            Engine.hud_enable_training(true);
            Engine.player_action_test_reset();
            await Engine.sleep_until(async () => (bool)Engine.player_action_test_accept() || (bool)Engine.player_action_test_cancel(), 1);
            Engine.hud_enable_training(false);
            Engine.hud_show_training_text(false);
            if ((bool)Engine.player_action_test_accept())
            {
                return true;
            }
            else
            {
                Engine.controller_set_look_invert(!((bool)Engine.controller_get_look_invert()));
                if ((bool)Engine.controller_get_look_invert())
                {
                    Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
                    await Engine.sleep(15);
                    Engine.print("ok, now it's inverted.");
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1480_gun", 3864397024U), Engine.ai_get_object(guns.Squad), 1F);
                    await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1480_gun", 3864397024U)));
                }
                else
                {
                    Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
                    await Engine.sleep(15);
                    Engine.print("ok, now it's back to normal.");
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1460_gun", 3864462561U), Engine.ai_get_object(guns.Squad), 1F);
                    await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1460_gun", 3864462561U)));
                }

                return false;
            }
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_pitch()
        {
            if (this.counter_mindread_normal_success >= this.counter_mindread_invert_success)
            {
                Engine.controller_set_look_invert(false);
            }
            else
            {
                Engine.controller_set_look_invert(true);
            }

            Engine.print("tracking looks sketchy, i'm going to run you through the full diagnostic.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3100_gun", 3864528098U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3100_gun", 3864528098U)));
            if ((bool)Engine.controller_get_look_invert())
            {
                Engine.print("the diagnostic software set your targeting system to be inverted");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3130_gun", 3864593635U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3130_gun", 3864593635U)));
            }
            else
            {
                Engine.print("the diagnostic software set your targeting system to be normal");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3120_gun", 3864659172U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3120_gun", 3864659172U)));
            }

            await Engine.sleep_until(async () => await this.training_pitch_choose(), 1);
            if ((bool)Engine.controller_get_look_invert())
            {
                Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
                await Engine.sleep(15);
                Engine.hud_set_training_text("tutorial_set_invert");
                Engine.hud_show_training_text(true);
                Engine.hud_enable_training(true);
                Engine.print("i'll leave your targeting set to inverted.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1570_gun", 3864724709U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1570_gun", 3864724709U)));
            }
            else
            {
                Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
                await Engine.sleep(15);
                Engine.hud_set_training_text("tutorial_set_normal");
                Engine.hud_show_training_text(true);
                Engine.hud_enable_training(true);
                Engine.print("i'll leave your targeting set to normal.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1560_gun", 3864790246U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1560_gun", 3864790246U)));
            }

            Engine.print("if you change your mind, you can switch the setting anytime.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1580_gun", 3864855783U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1580_gun", 3864855783U)));
            Engine.hud_enable_training(false);
            Engine.hud_show_training_text(false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_look()
        {
            Engine.print("well...  i guess it was all obsolete anyway.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0600_gun", 3864921320U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0600_gun", 3864921320U)));
            Engine.custom_animation(Engine.ai_get_unit(guns.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0610_jon", true);
            await Engine.sleep(15);
            Engine.print("your new suit is a mark vi, sent up from songnam this morning.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0610_gun", 3864986857U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0610_gun", 3864986857U)));
            Engine.print("try to take it easy until you get used to it.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0620_gun", 3865052394U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0620_gun", 3865052394U)));
            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
            await Engine.sleep(30);
            Engine.print("ok.  let's test your targeting, first thing.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0630_gun", 3865117931U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0630_gun", 3865117931U)));
            Engine.objectives_show_up_to(0);
            Engine.print("please look at the top light.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3000_gun", 3865183468U), Engine.ai_get_object(guns.Squad), 1F);
            await this.test_mindread_up();
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3000_gun", 3865183468U)));
            Engine.print("good.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0650_gun", 3865249005U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0650_gun", 3865249005U)));
            Engine.print("now look at the bottom light.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3010_gun", 3865314542U), Engine.ai_get_object(guns.Squad), 1F);
            await this.test_mindread_down();
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3010_gun", 3865314542U)));
            Engine.print("allright");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0670_gun", 3865380079U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0670_gun", 3865380079U)));
            Engine.print("look at the top light again.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3020_gun", 3865445616U), Engine.ai_get_object(guns.Squad), 1F);
            await this.test_mindread_up();
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3020_gun", 3865445616U)));
            Engine.print("that's it�");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0760_gun", 3865511153U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0760_gun", 3865511153U)));
            Engine.print("now the bottom one.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3030_gun", 3865576690U), Engine.ai_get_object(guns.Squad), 1F);
            await this.test_mindread_down();
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3030_gun", 3865576690U)));
            Engine.print("ok.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0740_gun", 3865642227U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep(30);
            Engine.player_camera_control(true);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0740_gun", 3865642227U)));
            if (this.counter_mindread_normal_success >= 2)
            {
                await Engine.sleep(30);
                Engine.print("everything checks out.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3865707764U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3865707764U)));
                Engine.controller_set_look_invert(false);
            }
            else if (this.counter_mindread_invert_success >= 2)
            {
                await Engine.sleep(30);
                Engine.print("everything checks out.");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3865707764U), Engine.ai_get_object(guns.Squad), 1F);
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3865707764U)));
                Engine.controller_set_look_invert(true);
            }
            else if (true)
            {
                await this.training_pitch();
            }

            await this.training_looker_lights_off();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_move()
        {
            Engine.print("stand-by. i'm going to offline the inhibitors�");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0790_gun", 3865773301U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0790_gun", 3865773301U)));
            Engine.device_set_position(inhibitor.Entity, 1F);
            Engine.player_disable_movement(false);
            Engine.hud_enable_training(true);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_inhibitor);
            await Engine.sleep(30);
            Engine.custom_animation(Engine.ai_get_unit(guns.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0800_jon", true);
            await Engine.sleep(10);
            Engine.print("move around a little, get a feel for it.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0800_gun", 3865838838U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0800_gun", 3865838838U)));
            Engine.print("when you're ready, come and meet me by the zapper.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0810_gun", 3865904375U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0810_gun", 3865904375U)));
            Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_halfway);
            this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_short);
            await Engine.sleep_until(async () =>
            {
                if (!(Engine.volume_test_objects(tv_start_spot, Engine.players())))
                {
                    return true;
                }
                else if (this.timer_prompt_start_spot > 0)
                {
                    this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot - 1);
                    return false;
                }
                else if (true)
                {
                    return await this.prompt_start_spot();
                }
            }, 1);
            Engine.hud_show_training_text(false);
            Engine.cs_run_command_script(guns.Squad, cs_guns_zapper_wait);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_shield()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_flag(Engine.players(), zapper_flag) < 2.5F)
                {
                    return true;
                }
                else if (this.timer_prompt_careful > 0)
                {
                    this.timer_prompt_careful = (short)(this.timer_prompt_careful - 1);
                    return false;
                }
                else if ((bool)Engine.game_safe_to_save())
                {
                    return false;
                }
                else if (true)
                {
                    await Engine.sleep(30);
                    if (!((bool)Engine.game_safe_to_save()))
                    {
                        return await this.prompt_careful();
                    }
                    else
                    {
                        return default(bool);
                    }
                }
            }, 1);
            await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.ai_get_object(guns.Squad), zapper_flag) < 1.5F, 1);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(guns.Squad)) < 2.5F, 1);
            Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "inquisitive", 0F, 1);
            Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0F, 1);
            Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0F, 1);
            Engine.print("pay attention because i'm only going to over this once.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3150_gun", 3865969912U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3150_gun", 3865969912U)));
            Engine.print("this station will test your recharging energy shields");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3140_gun", 3866035449U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3140_gun", 3866035449U)));
            Engine.cs_run_command_script(guns.Squad, cs_guns_zapper);
            await Engine.sleep_until(async () =>
            {
                if (Engine.device_group_get(zapper_control_group) == 1F)
                {
                    return true;
                }
                else if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(guns.Squad)) > 2.5F)
                {
                    return false;
                }
                else if (this.timer_prompt_zapper > 0)
                {
                    this.timer_prompt_zapper = (short)(this.timer_prompt_zapper - 1);
                    return false;
                }
                else if (this.timer_prompt_zapper_lookatme > 0)
                {
                    this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper_lookatme - 1);
                    this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper_getin - 1);
                    this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper_button - 1);
                    if (Engine.objects_can_see_object(await this.player0(), Engine.ai_get_object(guns.Squad), 40F))
                    {
                        await Engine.sleep(15);
                        this.timer_prompt_zapper_lookatme = 0;
                    }

                    return false;
                }
                else if (this.timer_prompt_zapper_getin > 0)
                {
                    this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper_lookatme - 1);
                    this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper_getin - 1);
                    this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper_button - 1);
                    if (Engine.volume_test_objects(tv_zapper, Engine.players()))
                    {
                        await Engine.sleep(15);
                        this.timer_prompt_zapper_getin = 0;
                    }

                    return false;
                }
                else if (this.timer_prompt_zapper_button > 0)
                {
                    this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper_button - 1);
                    this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper_getin - 1);
                    this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper_button - 1);
                    if (Engine.device_group_get(zapper_control_group) == 1F)
                    {
                        await Engine.sleep(15);
                        this.timer_prompt_zapper_button = 0;
                    }

                    return false;
                }
                else if (!(Engine.objects_can_see_object(await this.player0(), Engine.ai_get_object(guns.Squad), 40F)))
                {
                    return await this.prompt_zapper_lookatme();
                }
                else if (!(Engine.volume_test_objects(tv_zapper, Engine.players())))
                {
                    return await this.prompt_zapper_getin();
                }
                else if (true)
                {
                    return await this.prompt_zapper_button();
                }
            }, 1);
            Engine.objectives_finish_up_to(2);
            Engine.device_set_power(zapper.Entity, 1F);
            Engine.device_set_power(zapper_cage.Entity, 1F);
            Engine.hud_show_training_text(false);
            Engine.unit_set_maximum_vitality(await this.player0(), 30F, 70F);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_zapper);
            await Engine.sleep(90);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_zapper);
            await Engine.sleep(15);
            Engine.unit_set_current_vitality(await this.player0(), 30F, 0F);
            await Engine.sleep(15);
            Engine.print("bingo!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0940_gun", 3866100986U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep(30);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_console_zapper);
            Engine.print("as you can see, they re-charge a lot faster.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0950_gun", 3866166523U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep(45);
            Engine.ai_place(johnson.Squad);
            Engine.ai_cannot_die(johnson.Squad, true);
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_elevator);
            Engine.device_set_position(door_elevator_tram_bot.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(door_elevator_tram_bot.Entity) == 1F, 1);
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_start);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0950_gun", 3866166523U)));
            await Engine.sleep(60);
            Engine.device_set_power(zapper.Entity, 0F);
            Engine.device_set_power(zapper_cage.Entity, 0F);
            await Engine.sleep(30);
            Engine.custom_animation(Engine.ai_get_unit(guns.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0960_jon", true);
            Engine.print("if your shields go down, find some cover, wait for the meter to read fully-charged.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0960_gun", 3866232060U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep(45);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0960_gun", 3866232060U)));
            Engine.print("that, or he can just hide behind me.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0970_jon", 3866297597U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep(30);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_johnson);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0970_jon", 3866297597U)));
            await Engine.sleep(15);
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_glanceat_guns);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(await this.player0(), Engine.ai_get_object(johnson.Squad), 40F), 1, 90);
            Engine.unit_set_emotional_state(Engine.ai_get_unit(johnson.Squad), "inquisitive", 0.5F, 1);
            Engine.print("you done with my boy here? i don't see any training-wheels�");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1000_jon", 3866363134U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1000_jon", 3866363134U)) - 90));
            Engine.cs_run_command_script(johnson.Squad, cs_lookat_player);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1000_jon", 3866363134U)));
            Engine.print("his armor's working fine.");
            Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1010_gun", 3866428671U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1010_gun", 3866428671U)));
            await Engine.sleep(15);
            Engine.unit_set_emotional_state(Engine.ai_get_unit(johnson.Squad), "inquisitive", 0F, 1);
            Engine.cs_run_command_script(guns.Squad, cs_lookat_player);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(await this.player0(), Engine.ai_get_object(guns.Squad), 40F), 1, 90);
            Engine.print("you're free to go, son.  just remember: take things slow.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0980_gun", 3866494208U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0980_gun", 3866494208U)) - 60));
            Engine.cs_run_command_script(johnson.Squad, cs_lookat_player);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0980_gun", 3866494208U)));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task training_done_tram()
        {
            Engine.ai_place(atr1_mar.Squad);
            Engine.ai_place(mid_mar.Squad);
            Engine.device_set_position_immediate(door_tram_2.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.25F, 1);
            Engine.device_set_position(door_tram_2.Entity, 0F);
            await Engine.sleep(30);
            Engine.ai_erase(atr1_mar.Squad);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.45F, 1);
            Engine.device_set_position(door_tram_3.Entity, 1F);
            Engine.ai_place(atr2_mar.Squad);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.55F, 1);
            Engine.device_set_position(door_tram_3.Entity, 0F);
            await Engine.sleep(30);
            Engine.ai_erase(mid_mar.Squad);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.75F, 1);
            Engine.device_set_position(door_tram_4.Entity, 1F);
            Engine.object_create_anew(tram_marine_1);
            Engine.object_create_anew(tram_marine_2);
            Engine.object_create_anew(tram_marine_3);
            Engine.object_create_anew(tram_marine_4);
            Engine.object_create_anew(tram_marine_5);
            Engine.object_create_anew(tram_marine_6);
            Engine.object_create_anew(tram_marine_7);
            Engine.custom_animation_loop(tram_marine_1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3866559745U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(tram_marine_2.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3866559745U), "marine_fist_loop", false);
            Engine.custom_animation_loop(tram_marine_3.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3866559745U), "marine_clapping_loop", false);
            await Engine.sleep(5);
            Engine.custom_animation_loop(tram_marine_6.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3866559745U), "marine_whistle_loop", false);
            Engine.custom_animation_loop(tram_marine_5.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3866559745U), "marine_fist_loop", false);
            Engine.custom_animation_loop(tram_marine_4.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3866559745U), "marine_clapping_loop", false);
            await Engine.sleep(5);
            Engine.custom_animation_loop(tram_marine_7.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3866559745U), "marine_whistle_loop", false);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.9F, 1);
            Engine.device_set_position(door_tram_4.Entity, 0F);
            await Engine.sleep(30);
            Engine.ai_erase(atr2_mar.Squad);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_done()
        {
            Engine.device_set_position_immediate(tram.Entity, 0F);
            Engine.cs_run_command_script(johnson.Squad, cs_lookat_guns);
            Engine.print("don't worry, i'll hold his hand.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1040_jon", 3866625282U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1040_jon", 3866625282U)) - 30));
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_elevator);
            await Engine.sleep(15);
            Engine.cs_run_command_script(guns.Squad, cs_guns_elevator);
            await Engine.sleep(15);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_elevator_tram_bot, Engine.ai_get_object(johnson.Squad)), 1, (int)(30 * this.seconds));
            if (!(Engine.volume_test_objects_all(tv_elevator_tram_bot, Engine.ai_get_object(johnson.Squad))))
            {
                Engine.object_teleport(Engine.ai_get_object(johnson.Squad), tram_flag);
            }

            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects_all(tv_elevator_tram_bot, Engine.players()))
                {
                    return true;
                }
                else if (this.timer_prompt_elevator_plr > 0)
                {
                    this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr - 1);
                    return false;
                }
                else if (true)
                {
                    return await this.prompt_elevator_plr();
                }
            }, 1);
            Engine.objectives_finish_up_to(3);
            Engine.object_create(wall_elevator_tram_bot);
            this.mark_training_done = true;
            await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.ai_get_object(guns.Squad), tram_flag) < 2.5F, 1, 210);
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_elevator_face_guns);
            Engine.print("so johnson, when you gonna tell me how you made it back home in one piece?");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3360_gun", 3866690819U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3360_gun", 3866690819U)));
            Engine.print("sorry, guns.  it's classified.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0990_jon", 3866756356U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0990_jon", 3866756356U)) - 0));
            Engine.unit_set_emotional_state(Engine.ai_get_unit(guns.Squad), "angry", 0.5F, 1);
            await Engine.sleep(5);
            Engine.print("(humphs) my ass! well you can forget about those adjustments to your a2's scope! and you're sure as hell not getting one of the new m7s!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3370_gun", 3866821893U), Engine.ai_get_object(guns.Squad), 1F);
            await Engine.sleep(30);
            await Engine.sleep((short)Engine.random_range(25, 75));
            Engine.device_set_position(elevator_tram.Entity, 1F);
            Engine.device_set_position(door_elevator_tram_bot.Entity, 0F);
            await Engine.sleep_until(async () => Engine.device_get_position(door_elevator_tram_bot.Entity) == 0F, 1);
            Engine.sound_impulse_stop(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3370_gun", 3866821893U));
            await Engine.sleep(10);
            Engine.print("well he's in a particularly fine mood. maybe lord hood forgot to give him an invitation.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1810_jon", 3866887430U), Engine.ai_get_object(johnson.Squad), 1F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task training_tram()
        {
            Engine.wake(training_done_tram);
            await Engine.sleep_until(async () => Engine.device_get_position(elevator_tram.Entity) == 1F, 1);
            Engine.objectives_show_up_to(4);
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_tram);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1810_jon", 3866887430U)));
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_tram, Engine.players()) && Engine.volume_test_objects(tv_tram, Engine.ai_get_object(johnson.Squad)), 1);
            Engine.object_destroy_containing("wall_platform");
            Engine.object_create(wall_tram);
            await Engine.sleep_until(async () => !(Engine.cs_command_script_running(johnson.Squad, cs_johnson_tram)), 1, 150);
            Engine.objectives_finish_up_to(4);
            Engine.custom_animation(Engine.ai_get_unit(johnson.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0010_jon", true);
            await Engine.sleep(10);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1810_jon", 3866887430U)));
            Engine.print("earth. haven't seen it in years.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0010_jon", 3866952967U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)((float)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0010_jon", 3866952967U)) - 30));
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01a_tutorial\\01a_music\\01a_01", 3867018504U), default(IGameObject), 1F);
            Engine.device_set_position(elevator_tram.Entity, 0F);
            Engine.device_set_position(tram.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.08F, 1);
            await Engine.sleep(30);
            Engine.custom_animation(Engine.ai_get_unit(johnson.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0020_jon", true);
            Engine.print("when i shipped out for basic, the orbital defense grid was all theory and politics.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0020_jon", 3867280652U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0020_jon", 3867280652U)));
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.175F, 1);
            Engine.cs_run_command_script(johnson.Squad, cs_lookat_macgun);
            Engine.print("now look. the cairo is just one of three-hundred geo-sync platforms.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0021_jon", 3867346189U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0021_jon", 3867346189U)));
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.275F, 1);
            Engine.custom_animation(Engine.ai_get_unit(johnson.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0030_jon", true);
            await Engine.sleep(10);
            Engine.print("that mac-gun can put a round clean through a covenant capital-ship.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0030_jon", 3867411726U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0030_jon", 3867411726U)));
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.415F, 1);
            Engine.cs_run_command_script(johnson.Squad, cs_lookat_malta);
            await Engine.sleep(45);
            await Engine.sleep(45);
            Engine.custom_animation(Engine.ai_get_unit(johnson.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0040_jon", true);
            Engine.print("with coordinated fire from the athens and the malta, nothing's getting past this battle-cluster in one piece.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0040_jon", 3867477263U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0040_jon", 3867477263U)));
            await Engine.sleep(15);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.7F, 1);
            Engine.custom_animation(Engine.ai_get_unit(johnson.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0050_jon", true);
            Engine.print("ships have been arriving all morning.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0050_jon", 3867542800U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0050_jon", 3867542800U)));
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\01a_tutorial\\01a_music\\01a_01", 3867018504U));
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.75F, 1);
            await Engine.sleep(30);
            Engine.custom_animation(Engine.ai_get_unit(johnson.Squad), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3862561988U), "l01_0051_jon", true);
            Engine.print("nobody's saying much, but i'll bet something big's about to happen.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0051_jon", 3867608337U), Engine.ai_get_object(johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0051_jon", 3867608337U)));
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_lookat_station);
            await Engine.sleep_until(async () => Engine.device_get_position(tram.Entity) >= 0.975F, 1);
            await Engine.sleep(30);
            Engine.cs_run_command_script(johnson.Squad, cs_johnson_station);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_station, Engine.players())), 1, 150);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task start_mission()
        {
            await Engine.sleep(10);
            Engine.print("01a tutorial");
            Engine.print("designer - jaime");
            Engine.print("env. artists - paul, dave");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task training_fade()
        {
            Engine.player_disable_movement(true);
            Engine.player_camera_control(false);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(Lifecycle.Startup)]
        public async Task mission_01a()
        {
            Engine.player_disable_movement(true);
            Engine.player_camera_control(false);
            if ((bool)Engine.game_is_cooperative())
            {
                Engine.game_won();
            }

            Engine.objectives_clear();
            Engine.ai_allegiance(player, human);
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.hud_enable_training(false);
            Engine.ai_dialogue_enable(false);
            await this.start_mission();
            await this.training_setup();
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            Engine.objects_predict_high(Engine.ai_get_object(guns.Squad));
            await Engine.sleep(2);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(training_fade);
            await this.training_look();
            Engine.hud_enable_training(true);
            await this.training_move();
            await this.training_shield();
            await this.save_tram_start();
            await this.training_done();
            await this.training_tram();
            Engine.print("you win!");
            Engine.sound_class_set_gain("", 0F, 15);
            Engine.loading_screen_fade_to_white();
            Engine.hud_enable_training(true);
            Engine.ai_dialogue_enable(true);
            Engine.game_won();
        }
    }
}