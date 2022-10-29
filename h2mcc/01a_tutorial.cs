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
        int tick_seconds;
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
            this.tick_seconds = game_tick_rate();
            this.global_random = 0;
            this.global_random_rumble = 0;
            this.global_random_bridge = 0;
            this.delay_prompt_blink = (short)(2 * this.tick_seconds);
            this.delay_prompt_short = (short)(8 * this.tick_seconds);
            this.delay_prompt_medium = (short)(16 * this.tick_seconds);
            this.delay_prompt_long = (short)(36 * this.tick_seconds);
            this.delay_prompt_drag = (short)(48 * this.tick_seconds);
            this.delay_prompt_final = (short)(60 * this.tick_seconds);
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
        public async Task save_look_start()
        {
            if ((bool)game_safe_to_save())
            {
                data_mine_set_mission_segment("01a_look_start");
            }
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task save_move_start()
        {
            game_save();
            if ((bool)game_safe_to_save())
            {
                data_mine_set_mission_segment("01a_move_start");
            }
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task save_shield_start()
        {
            game_save();
            if ((bool)game_safe_to_save())
            {
                data_mine_set_mission_segment("01a_shield_start");
            }
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task save_tram_start()
        {
            game_save();
            if ((bool)game_safe_to_save())
            {
                data_mine_set_mission_segment("01a_tram_start");
            }
        }

        [ScriptMethod(28, Lifecycle.CommandScript)]
        public async Task cs_lookat_player()
        {
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(29, Lifecycle.CommandScript)]
        public async Task cs_lookat_guns()
        {
            cs_face_object(true, ai_get_object(guns.Squad));
            sleep_forever();
        }

        [ScriptMethod(30, Lifecycle.CommandScript)]
        public async Task cs_johnson_glanceat_guns()
        {
            cs_enable_looking(true);
            cs_look_object(true, ai_get_object(guns.Squad));
            sleep_forever();
        }

        [ScriptMethod(31, Lifecycle.CommandScript)]
        public async Task cs_lookat_johnson()
        {
            cs_face_object(true, ai_get_object(johnson.Squad));
            sleep_forever();
        }

        [ScriptMethod(32, Lifecycle.CommandScript)]
        public async Task cs_lookat_console_zapper()
        {
            cs_look(true, GetReference<ISpatialPoint>("guns_points/console_zapper"));
            await sleep(45);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(33, Lifecycle.CommandScript)]
        public async Task cs_lookat_console_toplight()
        {
            cs_aim_object(true, looker_light_top_red.Entity);
            await sleep(45);
            cs_face(true, GetReference<ISpatialPoint>("guns_points/console_inhibitor"));
            await sleep(30);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(34, Lifecycle.CommandScript)]
        public async Task cs_lookat_console_bottomlight()
        {
            cs_aim_object(true, looker_light_bottom_red.Entity);
            await sleep(45);
            cs_face(true, GetReference<ISpatialPoint>("guns_points/console_inhibitor"));
            await sleep(30);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(35, Lifecycle.CommandScript)]
        public async Task cs_lookat_console_inhibitor()
        {
            cs_face(true, GetReference<ISpatialPoint>("guns_points/console_inhibitor"));
            await sleep(30);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(36, Lifecycle.CommandScript)]
        public async Task cs_guns_start()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("guns_points/start"));
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(37, Lifecycle.CommandScript)]
        public async Task cs_guns_zapper_halfway()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("guns_points/zapper_halfway"));
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(38, Lifecycle.CommandScript)]
        public async Task cs_guns_zapper_wait()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("guns_points/zapper"));
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(39, Lifecycle.CommandScript)]
        public async Task cs_guns_zapper()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_and_face(GetReference<ISpatialPoint>("guns_points/zapper"), GetReference<ISpatialPoint>("guns_points/zapper_face"));
            cs_face(true, GetReference<ISpatialPoint>("guns_points/zapper_face"));
            sleep_forever();
        }

        [ScriptMethod(40, Lifecycle.CommandScript)]
        public async Task cs_guns_zapper_prompt()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_face_player(true);
            await sleep(90);
            cs_face_player(false);
            cs_go_to_and_face(GetReference<ISpatialPoint>("guns_points/zapper"), GetReference<ISpatialPoint>("guns_points/zapper_face"));
            cs_face(true, GetReference<ISpatialPoint>("guns_points/zapper_face"));
            sleep_forever();
        }

        [ScriptMethod(41, Lifecycle.CommandScript)]
        public async Task cs_johnson_start()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("johnson_points/start"));
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(42, Lifecycle.CommandScript)]
        public async Task cs_johnson_elevator()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("johnson_points/elevator"));
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(43, Lifecycle.CommandScript)]
        public async Task cs_johnson_elevator_face_guns()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("johnson_points/elevator"));
            cs_face_object(true, ai_get_object(guns.Squad));
            sleep_forever();
        }

        [ScriptMethod(44, Lifecycle.CommandScript)]
        public async Task cs_guns_elevator()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("guns_points/elevator"));
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(45, Lifecycle.CommandScript)]
        public async Task cs_johnson_tram()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_and_face(GetReference<ISpatialPoint>("johnson_points/tram"), GetReference<ISpatialPoint>("johnson_points/earth"));
            cs_face(true, GetReference<ISpatialPoint>("johnson_points/earth"));
            sleep_forever();
        }

        [ScriptMethod(46, Lifecycle.CommandScript)]
        public async Task cs_lookat_macgun()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_to_and_face(GetReference<ISpatialPoint>("johnson_points/tram_2"), GetReference<ISpatialPoint>("johnson_points/macgun"));
            cs_face(true, GetReference<ISpatialPoint>("johnson_points/macgun"));
            sleep_forever();
        }

        [ScriptMethod(47, Lifecycle.CommandScript)]
        public async Task cs_lookat_malta()
        {
            cs_face(true, GetReference<ISpatialPoint>("johnson_points/malta"));
            sleep_forever();
        }

        [ScriptMethod(48, Lifecycle.CommandScript)]
        public async Task cs_lookat_fleet()
        {
            cs_face_object(true, inamberclad.Entity);
            cs_look_object(true, inamberclad.Entity);
            sleep_forever();
        }

        [ScriptMethod(49, Lifecycle.CommandScript)]
        public async Task cs_johnson_lookat_station()
        {
            cs_face(true, GetReference<ISpatialPoint>("johnson_points/station"));
            sleep_forever();
        }

        [ScriptMethod(50, Lifecycle.CommandScript)]
        public async Task cs_johnson_station()
        {
            cs_force_combat_status(2);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("johnson_points/station"));
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task<bool> prompt_looker_start()
        {
            if (this.counter_prompt_looker_start == 0)
            {
                print("go ahead and look at each of the four lights, chief.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3110_gun", 3873506667U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3110_gun", 3873506667U)));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_short);
            }
            else if (this.counter_prompt_looker_start == 1)
            {
                print("go ahead and target them one more time.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1360_gun", 3873572204U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1360_gun", 3873572204U)));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_medium);
            }
            else if (true)
            {
                this.counter_prompt_looker_start = 0;
            }

            this.counter_prompt_looker_start = (short)(this.counter_prompt_looker_start + 1);
            return false;
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task<bool> prompt_looker()
        {
            if (this.counter_prompt_looker == 0)
            {
                print("you have to look at each light until it turns green.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1310_gun", 3873637741U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1310_gun", 3873637741U)));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_short);
            }
            else if (this.counter_prompt_looker == 1)
            {
                print("you gotta look at all the lights to complete the test.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1370_gun", 3873703278U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1370_gun", 3873703278U)));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_short);
            }
            else if (this.counter_prompt_looker == 2)
            {
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                print("look at the lights, chief, one by one.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1300_gun", 3873768815U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1300_gun", 3873768815U)));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_looker == 3)
            {
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                print("please look at the lights again, son.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1350_gun", 3873834352U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_looker = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1350_gun", 3873834352U)));
                this.timer_prompt_looker = (short)(this.timer_prompt_looker + this.delay_prompt_medium);
            }
            else if (true)
            {
                this.counter_prompt_looker = 0;
            }

            this.counter_prompt_looker = (short)(this.counter_prompt_looker + 1);
            return false;
        }

        [ScriptMethod(53, Lifecycle.Static)]
        public async Task<bool> prompt_start_spot()
        {
            if (this.counter_prompt_start_spot == 0)
            {
                print("go on, walk around, try it out.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0820_gun", 3873899889U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_start_spot = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0820_gun", 3873899889U)));
                this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_short);
            }
            else if (this.counter_prompt_start_spot == 1)
            {
                unit_set_emotional_state(ai_get_unit(guns.Squad), "inquisitive", 0.5F, 1);
                print("something wrong son?  can't you move?");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0830_gun", 3873965426U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_start_spot = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0830_gun", 3873965426U)));
                this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_start_spot == 2)
            {
                unit_set_emotional_state(ai_get_unit(guns.Squad), "inquisitive", 0.5F, 1);
                print("inhibitors are definitely off. you should be able to walk around.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0840_gun", 3874030963U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_start_spot = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0840_gun", 3874030963U)));
                this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_medium);
            }
            else if (true)
            {
                this.counter_prompt_start_spot = 0;
            }

            this.counter_prompt_start_spot = (short)(this.counter_prompt_start_spot + 1);
            return false;
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task<bool> prompt_careful()
        {
            if (this.counter_prompt_careful == 0)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_player));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "scared", 0.5F, 1);
                await sleep(8);
                print("hey! take it easy!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0850_gun", 3874096500U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0850_gun", 3874096500U)));
                await sleep(30);
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_wait));
            }
            else if (this.counter_prompt_careful == 1)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_player));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "scared", 0.5F, 1);
                await sleep(8);
                print("careful! you'll tear a tendon doing that!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0860_gun", 3874162037U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0860_gun", 3874162037U)));
                await sleep(30);
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_wait));
            }
            else if (this.counter_prompt_careful == 2)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_player));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await sleep(8);
                print("fine. but don't come crying to me when your rip your leg out of its socket.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0870_gun", 3874227574U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0870_gun", 3874227574U)));
                await sleep(30);
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_wait));
            }
            else if (true)
            {
                this.counter_prompt_careful = 2;
            }

            this.timer_prompt_careful = this.delay_prompt_blink;
            this.counter_prompt_careful = (short)(this.counter_prompt_careful + 1);
            return false;
        }

        [ScriptMethod(55, Lifecycle.Static)]
        public async Task<bool> prompt_zapper_lookatme()
        {
            hud_show_training_text(false);
            if (this.counter_prompt_zapper_lookatme == 0)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await sleep(30);
                print("are you listening to me?.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3160_gun", 3874293111U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3160_gun", 3874293111U)));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_lookatme == 1)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await sleep(30);
                print("over here, chief.  focus.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3170_gun", 3874358648U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3170_gun", 3874358648U)));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_lookatme == 2)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await sleep(30);
                print("it's considered respectful to look at someone when they are talking.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3180_gun", 3874424185U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3180_gun", 3874424185U)));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_lookatme == 3)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await sleep(30);
                print("this is important, you could at least look at me while i explain it.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3190_gun", 3874489722U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3190_gun", 3874489722U)));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_lookatme == 4)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await sleep(30);
                print("i'm talking to you, chief.  loot at me.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3200_gun", 3874555259U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3200_gun", 3874555259U)));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                hud_set_training_text("tutorial_zapper_lookatme");
                hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_lookatme == 5)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await sleep(30);
                print("i know you spartans think you know everything, but it couldn't hurt you to at least look this way.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3210_gun", 3874620796U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3210_gun", 3874620796U)));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                hud_set_training_text("tutorial_zapper_lookatme");
                hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_lookatme == 6)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await sleep(30);
                print("look, just because the brass kisses your ass, doesn't mean i will.  look at me when i talk to you!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3220_gun", 3874686333U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3220_gun", 3874686333U)));
                this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper + this.delay_prompt_drag);
                hud_set_training_text("tutorial_zapper_lookatme");
                hud_show_training_text(true);
            }
            else if (true)
            {
                this.counter_prompt_zapper_lookatme = 3;
            }

            this.counter_prompt_zapper_lookatme = (short)(this.counter_prompt_zapper_lookatme + 1);
            return false;
        }

        [ScriptMethod(56, Lifecycle.Static)]
        public async Task<bool> prompt_zapper_getin()
        {
            hud_show_training_text(false);
            if (this.counter_prompt_zapper_getin == 0)
            {
                custom_animation(ai_get_unit(guns.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0900_jon", true);
                objectives_finish_up_to(0);
                objectives_show_up_to(1);
                await sleep(10);
                print("step on in. i'll show you.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0900_gun", 3874882944U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0900_gun", 3874882944U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_getin == 1)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                await sleep(30);
                print("step into the red sqaure, chief, and we'll get started.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3230_gun", 3874948481U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3230_gun", 3874948481U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_getin == 2)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                await sleep(30);
                print("chief? stand in the red square.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3240_gun", 3875014018U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3240_gun", 3875014018U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_getin == 3)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                await sleep(30);
                print("you have to stand in the red square before we can start the test.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3250_gun", 3875079555U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3250_gun", 3875079555U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_getin == 4)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await sleep(30);
                print("go ahead and stand in the red sqaure.� it'll just take a minute.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3260_gun", 3875145092U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3260_gun", 3875145092U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
            }
            else if (this.counter_prompt_zapper_getin == 5)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await sleep(30);
                print("come on, son, step into the red square.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3270_gun", 3875210629U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3270_gun", 3875210629U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                hud_set_training_text("tutorial_zapper_getin");
                hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_getin == 6)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                await sleep(30);
                print("will you stop screwing around?� stand in the red square!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3280_gun", 3875276166U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3280_gun", 3875276166U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                hud_set_training_text("tutorial_zapper_getin");
                hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_getin == 7)
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_prompt));
                unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0.5F, 1);
                await sleep(30);
                print("stop bustin' my balls, and step in the damn square!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3290_gun", 3875341703U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3290_gun", 3875341703U)));
                this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper + this.delay_prompt_drag);
                hud_set_training_text("tutorial_zapper_getin");
                hud_show_training_text(true);
            }
            else if (true)
            {
                this.counter_prompt_zapper_getin = 2;
            }

            this.counter_prompt_zapper_getin = (short)(this.counter_prompt_zapper_getin + 1);
            return false;
        }

        [ScriptMethod(57, Lifecycle.Static)]
        public async Task<bool> prompt_zapper_button()
        {
            hud_show_training_text(false);
            if (this.counter_prompt_zapper_button == 0)
            {
                unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0F, 1);
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0F, 1);
                device_set_power(zapper_control.Entity, 1F);
                print("your new armor's shields are extremely resilient - very efficient.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0880_gun", 3875407240U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0880_gun", 3875407240U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + 0);
            }
            else if (this.counter_prompt_zapper_button == 1)
            {
                print("much better than the covenant tech we used for the mark-five.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0890_gun", 3875472777U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0890_gun", 3875472777U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + 0);
            }
            else if (this.counter_prompt_zapper_button == 2)
            {
                custom_animation(ai_get_unit(guns.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0910_jon", true);
                objectives_finish_up_to(1);
                objectives_show_up_to(2);
                await sleep(10);
                print("go ahead and use the switch in front of you to start the shield test.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3300_gun", 3875538314U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3300_gun", 3875538314U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_short);
            }
            else if (this.counter_prompt_zapper_button == 3)
            {
                print("just place your hand on the touchpad to activate the switch.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3310_gun", 3875603851U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3310_gun", 3875603851U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_button == 4)
            {
                print("hit the switch, it won't hurt�.much");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3340_gun", 3875669388U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3340_gun", 3875669388U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_zapper_button == 5)
            {
                print("go ahead and use that switch in front of you.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3330_gun", 3875734925U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3330_gun", 3875734925U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                hud_set_training_text("tutorial_zapper_button");
                hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_button == 6)
            {
                print("the switch right in front of you will start the shield test.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3320_gun", 3875800462U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3320_gun", 3875800462U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_long);
                hud_set_training_text("tutorial_zapper_button");
                hud_show_training_text(true);
            }
            else if (this.counter_prompt_zapper_button == 7)
            {
                unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
                print("it's a switch.  you press it.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3350_gun", 3875865999U), ai_get_object(guns.Squad), 1F);
                this.timer_prompt_zapper = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3350_gun", 3875865999U)));
                this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper + this.delay_prompt_drag);
                hud_set_training_text("tutorial_zapper_button");
                hud_show_training_text(true);
            }
            else if (true)
            {
                this.counter_prompt_zapper_button = 2;
            }

            this.counter_prompt_zapper_button = (short)(this.counter_prompt_zapper_button + 1);
            return false;
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task<bool> prompt_elevator_plr()
        {
            hud_show_training_text(false);
            if (this.counter_prompt_elevator_plr == 0)
            {
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_short);
                objectives_show_up_to(3);
            }
            else if (this.counter_prompt_elevator_plr == 1)
            {
                print("c'mon, chief, they're ready for us on the bridge.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1640_jon", 3875931536U), ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1640_jon", 3875931536U)));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_short);
            }
            else if (this.counter_prompt_elevator_plr == 2)
            {
                print("get on the lift, cheif, we're gonna be late.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1650_jon", 3875997073U), ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1650_jon", 3875997073U)));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_elevator_plr == 3)
            {
                unit_set_emotional_state(ai_get_unit(johnson.Squad), "annoyed", 0.5F, 1);
                print("i don't want to keep the brass waiting, chief.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1660_jon", 3876062610U), ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1660_jon", 3876062610U)));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_medium);
            }
            else if (this.counter_prompt_elevator_plr == 4)
            {
                unit_set_emotional_state(ai_get_unit(johnson.Squad), "annoyed", 0.5F, 1);
                print("fine. you can tell lord hood why we're late!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1670_jon", 3876128147U), ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1670_jon", 3876128147U)));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
            }
            else if (this.counter_prompt_elevator_plr == 5)
            {
                unit_set_emotional_state(ai_get_unit(johnson.Squad), "angry", 0.5F, 1);
                print("get your shiny green posterior on this elevator!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1680_jon", 3876193684U), ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1680_jon", 3876193684U)));
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
                this.timer_prompt_elevator_plr = (short)(this.timer_prompt_elevator_plr + this.delay_prompt_long);
            }
            else if (this.counter_prompt_elevator_plr == 6)
            {
                unit_set_emotional_state(ai_get_unit(johnson.Squad), "angry", 0.5F, 1);
                print("would it help if i said please?");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1690_jon", 3876259221U), ai_get_object(johnson.Squad), 1F);
                this.timer_prompt_elevator_plr = (short)(game_tick_rate_scalar() * (float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1690_jon", 3876259221U)));
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

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task training_setup()
        {
            game_can_use_flashlights(false);
            unit_set_maximum_vitality(await this.player0(), 30F, 1F);
            device_set_power(zapper_control.Entity, 0F);
            device_set_position_immediate(elevator_tram.Entity, 0F);
            ai_place(guns.Squad);
            ai_cannot_die(guns.Squad, true);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_start));
        }

        [ScriptMethod(60, Lifecycle.Startup)]
        public async Task icecream()
        {
            await sleep_until(async () => this.mark_ice_cream && await this.difficulty_legendary(), 1);
            object_create(cookiesncream);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3827172008U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3827172008U)), 1);
            ice_cream_flavor_stock(14);
            print("blam");
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task test_mindread_up()
        {
            object_create(looker_light_top_red);
            player_action_test_reset();
            player_action_test_look_up_begin();
            player_camera_control(true);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_toplight));
            await sleep_until(async () => objects_can_see_object(players(), looker_light_top_red.Entity, 5F) || (bool)player0_looking_up(), 1, 360);
            if (!(objects_can_see_object(players(), looker_light_top_red.Entity, 5F) || (bool)player0_looking_up()))
            {
                print("go ahead and look at the top light, chief.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3070_gun", 3876324758U), ai_get_object(guns.Squad), 1F);
                hud_set_training_text("tutorial_look_up");
                hud_show_training_text(true);
                hud_enable_training(true);
            }

            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
            await sleep_until(async () => objects_can_see_object(players(), looker_light_top_red.Entity, 5F) || (bool)player0_looking_up(), 1);
            player_camera_control(false);
            hud_enable_training(false);
            hud_show_training_text(false);
            object_destroy(looker_light_top_red.Entity);
            if (!((bool)player_action_test_lookstick_backward()))
            {
                this.counter_mindread_normal_success = (short)(this.counter_mindread_normal_success + 1);
                this.counter_mindread_invert_success = 0;
                print("normal success");
            }
            else if (!((bool)player_action_test_lookstick_forward()))
            {
                this.counter_mindread_invert_success = (short)(this.counter_mindread_invert_success + 1);
                this.counter_mindread_normal_success = 0;
                print("invert success");
            }
            else if (true)
            {
                this.counter_mindread_normal_success = 0;
                this.counter_mindread_invert_success = 0;
            }

            player_camera_control(false);
            player_action_test_look_pitch_end();
            player_action_test_reset();
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3070_gun", 3876324758U)));
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task test_mindread_down()
        {
            object_create(looker_light_bottom_red);
            player_action_test_reset();
            player_action_test_look_down_begin();
            player_camera_control(true);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_bottomlight));
            await sleep_until(async () => objects_can_see_object(players(), looker_light_bottom_red.Entity, 3F) || (bool)player0_looking_down(), 1, 360);
            if (!(objects_can_see_object(players(), looker_light_bottom_red.Entity, 3F) || (bool)player0_looking_down()))
            {
                print("look at the bottom light, son.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3060_gun", 3876390295U), ai_get_object(guns.Squad), 1F);
                hud_set_training_text("tutorial_look_down");
                hud_show_training_text(true);
                hud_enable_training(true);
            }

            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
            await sleep_until(async () => objects_can_see_object(players(), looker_light_bottom_red.Entity, 3F) || (bool)player0_looking_down(), 1);
            player_camera_control(false);
            hud_enable_training(false);
            hud_show_training_text(false);
            object_destroy(looker_light_bottom_red.Entity);
            if (!((bool)player_action_test_lookstick_forward()))
            {
                this.counter_mindread_normal_success = (short)(this.counter_mindread_normal_success + 1);
                this.counter_mindread_invert_success = 0;
                print("normal success");
            }
            else if (!((bool)player_action_test_lookstick_backward()))
            {
                this.counter_mindread_invert_success = (short)(this.counter_mindread_invert_success + 1);
                this.counter_mindread_normal_success = 0;
                print("invert success");
            }
            else if (true)
            {
                this.counter_mindread_normal_success = 0;
                this.counter_mindread_invert_success = 0;
            }

            player_camera_control(false);
            player_action_test_look_pitch_end();
            player_action_test_reset();
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3060_gun", 3876390295U)));
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task training_looker_lights_on()
        {
            object_destroy(looker_light_left_green.Entity);
            object_create(looker_light_left_red);
            this.mark_looker_light_left = true;
            object_destroy(looker_light_right_green.Entity);
            object_create(looker_light_right_red);
            this.mark_looker_light_right = true;
            object_destroy(looker_light_top_green.Entity);
            object_create(looker_light_top_red);
            this.mark_looker_light_top = true;
            object_destroy(looker_light_bottom_green.Entity);
            object_create(looker_light_bottom_red);
            this.mark_looker_light_bottom = true;
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task training_looker_lights_off()
        {
            object_destroy(looker_light_left_green.Entity);
            object_destroy(looker_light_left_red.Entity);
            object_destroy(looker_light_right_green.Entity);
            object_destroy(looker_light_right_red.Entity);
            object_destroy(looker_light_top_green.Entity);
            object_destroy(looker_light_top_red.Entity);
            object_destroy(looker_light_bottom_green.Entity);
            object_destroy(looker_light_bottom_red.Entity);
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task<bool> test_all_lights_off()
        {
            return !(this.mark_looker_light_left || this.mark_looker_light_right || this.mark_looker_light_top || this.mark_looker_light_bottom);
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task<bool> training_pitch_choose()
        {
            if (this.counter_training_pitch_choose <= 2)
            {
                await this.training_looker_lights_on();
                await this.prompt_looker_start();
                await sleep_until(async () =>
                {
                    if (await this.test_all_lights_off())
                    {
                        return true;
                    }
                    else if (objects_can_see_object(players(), looker_light_left_red.Entity, 5F))
                    {
                        object_destroy(looker_light_left_red.Entity);
                        object_create_anew(looker_light_left_green);
                        this.mark_looker_light_left = false;
                        return this.mark_looker_light_left;
                    }
                    else if (objects_can_see_object(players(), looker_light_right_red.Entity, 5F))
                    {
                        object_destroy(looker_light_right_red.Entity);
                        object_create_anew(looker_light_right_green);
                        this.mark_looker_light_right = false;
                        return this.mark_looker_light_right;
                    }
                    else if (objects_can_see_object(players(), looker_light_top_red.Entity, 5F))
                    {
                        object_destroy(looker_light_top_red.Entity);
                        object_create_anew(looker_light_top_green);
                        this.mark_looker_light_top = false;
                        return this.mark_looker_light_top;
                    }
                    else if (objects_can_see_object(players(), looker_light_bottom_red.Entity, 5F))
                    {
                        object_destroy(looker_light_bottom_red.Entity);
                        object_create_anew(looker_light_bottom_green);
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
            if ((bool)controller_get_look_invert())
            {
                print("should i leave it inverted, or put it back to normal?");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1450_gun", 3876455832U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1450_gun", 3876455832U)));
                print("press a to leave lookstick inverted, press b to try it normal.");
                hud_set_training_text("tutorial_choose_invert");
            }
            else
            {
                print("should i leave it normal, or put it back to inverted?");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1470_gun", 3876521369U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1470_gun", 3876521369U)));
                print("press a to leave lookstick normal, press b to try it inverted.");
                hud_set_training_text("tutorial_choose_normal");
            }

            hud_show_training_text(true);
            hud_enable_training(true);
            player_action_test_reset();
            await sleep_until(async () => (bool)player_action_test_accept() || (bool)player_action_test_cancel(), 1);
            hud_enable_training(false);
            hud_show_training_text(false);
            if ((bool)player_action_test_accept())
            {
                return true;
            }
            else
            {
                controller_set_look_invert(!((bool)controller_get_look_invert()));
                if ((bool)controller_get_look_invert())
                {
                    cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
                    await sleep(15);
                    print("ok, now it's inverted.");
                    sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1480_gun", 3876586906U), ai_get_object(guns.Squad), 1F);
                    await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1480_gun", 3876586906U)));
                }
                else
                {
                    cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
                    await sleep(15);
                    print("ok, now it's back to normal.");
                    sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1460_gun", 3876652443U), ai_get_object(guns.Squad), 1F);
                    await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1460_gun", 3876652443U)));
                }

                return false;
            }
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task training_pitch()
        {
            if (this.counter_mindread_normal_success >= this.counter_mindread_invert_success)
            {
                controller_set_look_invert(false);
            }
            else
            {
                controller_set_look_invert(true);
            }

            print("tracking looks sketchy, i'm going to run you through the full diagnostic.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3100_gun", 3876717980U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3100_gun", 3876717980U)));
            if ((bool)controller_get_look_invert())
            {
                print("the diagnostic software set your targeting system to be inverted");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3130_gun", 3876783517U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3130_gun", 3876783517U)));
            }
            else
            {
                print("the diagnostic software set your targeting system to be normal");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3120_gun", 3876849054U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3120_gun", 3876849054U)));
            }

            await sleep_until(async () => await this.training_pitch_choose(), 1);
            if ((bool)controller_get_look_invert())
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
                await sleep(15);
                hud_set_training_text("tutorial_set_invert");
                hud_show_training_text(true);
                hud_enable_training(true);
                print("i'll leave your targeting set to inverted.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1570_gun", 3876914591U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1570_gun", 3876914591U)));
            }
            else
            {
                cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
                await sleep(15);
                hud_set_training_text("tutorial_set_normal");
                hud_show_training_text(true);
                hud_enable_training(true);
                print("i'll leave your targeting set to normal.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1560_gun", 3876980128U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1560_gun", 3876980128U)));
            }

            print("if you change your mind, you can switch the setting anytime.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1580_gun", 3877045665U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1580_gun", 3877045665U)));
            hud_enable_training(false);
            hud_show_training_text(false);
        }

        [ScriptMethod(68, Lifecycle.Static)]
        public async Task training_look()
        {
            print("well...  i guess it was all obsolete anyway.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0600_gun", 3877111202U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0600_gun", 3877111202U)));
            custom_animation(ai_get_unit(guns.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0610_jon", true);
            await sleep(15);
            print("your new suit is a mark vi, sent up from songnam this morning.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0610_gun", 3877176739U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0610_gun", 3877176739U)));
            print("try to take it easy until you get used to it.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0620_gun", 3877242276U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0620_gun", 3877242276U)));
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
            await sleep(30);
            print("ok.  let's test your targeting, first thing.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0630_gun", 3877307813U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0630_gun", 3877307813U)));
            objectives_show_up_to(0);
            print("please look at the top light.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3000_gun", 3877373350U), ai_get_object(guns.Squad), 1F);
            await this.test_mindread_up();
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3000_gun", 3877373350U)));
            print("good.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0650_gun", 3877438887U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0650_gun", 3877438887U)));
            print("now look at the bottom light.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3010_gun", 3877504424U), ai_get_object(guns.Squad), 1F);
            await this.test_mindread_down();
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3010_gun", 3877504424U)));
            print("allright");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0670_gun", 3877569961U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0670_gun", 3877569961U)));
            print("look at the top light again.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3020_gun", 3877635498U), ai_get_object(guns.Squad), 1F);
            await this.test_mindread_up();
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3020_gun", 3877635498U)));
            print("that's it�");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0760_gun", 3877701035U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0760_gun", 3877701035U)));
            print("now the bottom one.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3030_gun", 3877766572U), ai_get_object(guns.Squad), 1F);
            await this.test_mindread_down();
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3030_gun", 3877766572U)));
            print("ok.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0740_gun", 3877832109U), ai_get_object(guns.Squad), 1F);
            await sleep(30);
            player_camera_control(true);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0740_gun", 3877832109U)));
            if (this.counter_mindread_normal_success >= 2)
            {
                await sleep(30);
                print("everything checks out.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3877897646U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3877897646U)));
                controller_set_look_invert(false);
            }
            else if (this.counter_mindread_invert_success >= 2)
            {
                await sleep(30);
                print("everything checks out.");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3877897646U), ai_get_object(guns.Squad), 1F);
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0770_gun", 3877897646U)));
                controller_set_look_invert(true);
            }
            else if (true)
            {
                await this.training_pitch();
            }

            await this.training_looker_lights_off();
        }

        [ScriptMethod(69, Lifecycle.Static)]
        public async Task training_move()
        {
            print("stand-by. i'm going to offline the inhibitors�");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0790_gun", 3877963183U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0790_gun", 3877963183U)));
            device_set_position(inhibitor.Entity, 1F);
            player_disable_movement(false);
            hud_enable_training(true);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_inhibitor));
            await sleep(30);
            custom_animation(ai_get_unit(guns.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0800_jon", true);
            await sleep(10);
            print("move around a little, get a feel for it.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0800_gun", 3878028720U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0800_gun", 3878028720U)));
            print("when you're ready, come and meet me by the zapper.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0810_gun", 3878094257U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0810_gun", 3878094257U)));
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_halfway));
            this.timer_prompt_start_spot = (short)(this.timer_prompt_start_spot + this.delay_prompt_short);
            await sleep_until(async () =>
            {
                if (!(volume_test_objects(tv_start_spot, players())))
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
            hud_show_training_text(false);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper_wait));
        }

        [ScriptMethod(70, Lifecycle.Static)]
        public async Task training_shield()
        {
            await sleep_until(async () =>
            {
                if (objects_distance_to_flag(players(), zapper_flag) < 2.5F)
                {
                    return true;
                }
                else if (this.timer_prompt_careful > 0)
                {
                    this.timer_prompt_careful = (short)(this.timer_prompt_careful - 1);
                    return false;
                }
                else if ((bool)game_safe_to_save())
                {
                    return false;
                }
                else if (true)
                {
                    await sleep(30);
                    if (!((bool)game_safe_to_save()))
                    {
                        return await this.prompt_careful();
                    }
                    else
                    {
                        return default(bool);
                    }
                }
            }, 1);
            await sleep_until(async () => objects_distance_to_flag(ai_get_object(guns.Squad), zapper_flag) < 1.5F, 1);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(guns.Squad)) < 2.5F, 1);
            unit_set_emotional_state(ai_get_unit(guns.Squad), "inquisitive", 0F, 1);
            unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0F, 1);
            unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0F, 1);
            print("pay attention because i'm only going to over this once.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3150_gun", 3878159794U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3150_gun", 3878159794U)));
            print("this station will test your recharging energy shields");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3140_gun", 3878225331U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3140_gun", 3878225331U)));
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_zapper));
            await sleep_until(async () =>
            {
                if (device_group_get(zapper_control_group) == 1F)
                {
                    return true;
                }
                else if (objects_distance_to_object(players(), ai_get_object(guns.Squad)) > 2.5F)
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
                    if (objects_can_see_object(await this.player0(), ai_get_object(guns.Squad), 40F))
                    {
                        await sleep(15);
                        this.timer_prompt_zapper_lookatme = 0;
                    }

                    return false;
                }
                else if (this.timer_prompt_zapper_getin > 0)
                {
                    this.timer_prompt_zapper_lookatme = (short)(this.timer_prompt_zapper_lookatme - 1);
                    this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper_getin - 1);
                    this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper_button - 1);
                    if (volume_test_objects(tv_zapper, players()))
                    {
                        await sleep(15);
                        this.timer_prompt_zapper_getin = 0;
                    }

                    return false;
                }
                else if (this.timer_prompt_zapper_button > 0)
                {
                    this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper_button - 1);
                    this.timer_prompt_zapper_getin = (short)(this.timer_prompt_zapper_getin - 1);
                    this.timer_prompt_zapper_button = (short)(this.timer_prompt_zapper_button - 1);
                    if (device_group_get(zapper_control_group) == 1F)
                    {
                        await sleep(15);
                        this.timer_prompt_zapper_button = 0;
                    }

                    return false;
                }
                else if (!(objects_can_see_object(await this.player0(), ai_get_object(guns.Squad), 40F)))
                {
                    return await this.prompt_zapper_lookatme();
                }
                else if (!(volume_test_objects(tv_zapper, players())))
                {
                    return await this.prompt_zapper_getin();
                }
                else if (true)
                {
                    return await this.prompt_zapper_button();
                }
            }, 1);
            objectives_finish_up_to(2);
            device_set_power(zapper.Entity, 1F);
            device_set_power(zapper_cage.Entity, 1F);
            hud_show_training_text(false);
            unit_set_maximum_vitality(await this.player0(), 30F, 70F);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_zapper));
            await sleep(90);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_zapper));
            await sleep(15);
            unit_set_current_vitality(await this.player0(), 30F, 0F);
            await sleep(15);
            print("bingo!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0940_gun", 3878290868U), ai_get_object(guns.Squad), 1F);
            await sleep(30);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_console_zapper));
            print("as you can see, they re-charge a lot faster.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0950_gun", 3878356405U), ai_get_object(guns.Squad), 1F);
            await sleep(45);
            ai_place(johnson.Squad);
            ai_cannot_die(johnson.Squad, true);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_elevator));
            device_set_position(door_elevator_tram_bot.Entity, 1F);
            await sleep_until(async () => device_get_position(door_elevator_tram_bot.Entity) == 1F, 1);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_start));
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0950_gun", 3878356405U)));
            await sleep(60);
            device_set_power(zapper.Entity, 0F);
            device_set_power(zapper_cage.Entity, 0F);
            await sleep(30);
            custom_animation(ai_get_unit(guns.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0960_jon", true);
            print("if your shields go down, find some cover, wait for the meter to read fully-charged.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0960_gun", 3878421942U), ai_get_object(guns.Squad), 1F);
            await sleep(45);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0960_gun", 3878421942U)));
            print("that, or he can just hide behind me.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0970_jon", 3878487479U), ai_get_object(johnson.Squad), 1F);
            await sleep(30);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_johnson));
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0970_jon", 3878487479U)));
            await sleep(15);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_glanceat_guns));
            await sleep_until(async () => objects_can_see_object(await this.player0(), ai_get_object(johnson.Squad), 40F), 1, 90);
            unit_set_emotional_state(ai_get_unit(johnson.Squad), "inquisitive", 0.5F, 1);
            print("you done with my boy here? i don't see any training-wheels�");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1000_jon", 3878553016U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1000_jon", 3878553016U)) - 90));
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_lookat_player));
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1000_jon", 3878553016U)));
            print("his armor's working fine.");
            unit_set_emotional_state(ai_get_unit(guns.Squad), "annoyed", 0.5F, 1);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1010_gun", 3878618553U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1010_gun", 3878618553U)));
            await sleep(15);
            unit_set_emotional_state(ai_get_unit(johnson.Squad), "inquisitive", 0F, 1);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_lookat_player));
            await sleep_until(async () => objects_can_see_object(await this.player0(), ai_get_object(guns.Squad), 40F), 1, 90);
            print("you're free to go, son.  just remember: take things slow.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0980_gun", 3878684090U), ai_get_object(guns.Squad), 1F);
            await sleep((short)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0980_gun", 3878684090U)) - 60));
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_lookat_player));
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0980_gun", 3878684090U)));
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task training_done_tram()
        {
            ai_place(atr1_mar.Squad);
            ai_place(mid_mar.Squad);
            device_set_position_immediate(door_tram_2.Entity, 1F);
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.25F, 1);
            device_set_position(door_tram_2.Entity, 0F);
            await sleep(30);
            ai_erase(atr1_mar.Squad);
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.45F, 1);
            device_set_position(door_tram_3.Entity, 1F);
            ai_place(atr2_mar.Squad);
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.55F, 1);
            device_set_position(door_tram_3.Entity, 0F);
            await sleep(30);
            ai_erase(mid_mar.Squad);
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.75F, 1);
            device_set_position(door_tram_4.Entity, 1F);
            object_create_anew(tram_marine_1);
            object_create_anew(tram_marine_2);
            object_create_anew(tram_marine_3);
            object_create_anew(tram_marine_4);
            object_create_anew(tram_marine_5);
            object_create_anew(tram_marine_6);
            object_create_anew(tram_marine_7);
            custom_animation_loop(tram_marine_1.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3878749627U), "marine_whistle_loop", false);
            custom_animation_loop(tram_marine_2.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3878749627U), "marine_fist_loop", false);
            custom_animation_loop(tram_marine_3.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3878749627U), "marine_clapping_loop", false);
            await sleep(5);
            custom_animation_loop(tram_marine_6.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3878749627U), "marine_whistle_loop", false);
            custom_animation_loop(tram_marine_5.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3878749627U), "marine_fist_loop", false);
            custom_animation_loop(tram_marine_4.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3878749627U), "marine_clapping_loop", false);
            await sleep(5);
            custom_animation_loop(tram_marine_7.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x02\\x02", 3878749627U), "marine_whistle_loop", false);
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.9F, 1);
            device_set_position(door_tram_4.Entity, 0F);
            await sleep(30);
            ai_erase(atr2_mar.Squad);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task training_done()
        {
            device_set_position_immediate(tram.Entity, 0F);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_lookat_guns));
            print("don't worry, i'll hold his hand.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1040_jon", 3878815164U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1040_jon", 3878815164U)) - 30));
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_elevator));
            await sleep(15);
            cs_run_command_script(guns.Squad, new ScriptMethodReference(cs_guns_elevator));
            await sleep(15);
            await sleep_until(async () => volume_test_objects_all(tv_elevator_tram_bot, ai_get_object(johnson.Squad)), 1, 30 * 30);
            if (!(volume_test_objects_all(tv_elevator_tram_bot, ai_get_object(johnson.Squad))))
            {
                object_teleport(ai_get_object(johnson.Squad), tram_flag);
            }

            await sleep_until(async () =>
            {
                if (volume_test_objects_all(tv_elevator_tram_bot, players()))
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
            objectives_finish_up_to(3);
            object_create(wall_elevator_tram_bot);
            this.mark_training_done = true;
            await sleep_until(async () => objects_distance_to_flag(ai_get_object(guns.Squad), tram_flag) < 2.5F, 1, 210);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_elevator_face_guns));
            print("so johnson, when you gonna tell me how you made it back home in one piece?");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3360_gun", 3878880701U), ai_get_object(guns.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3360_gun", 3878880701U)));
            print("sorry, guns.  it's classified.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0990_jon", 3878946238U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0990_jon", 3878946238U)) - 0));
            unit_set_emotional_state(ai_get_unit(guns.Squad), "angry", 0.5F, 1);
            await sleep(5);
            print("(humphs) my ass! well you can forget about those adjustments to your a2's scope! and you're sure as hell not getting one of the new m7s!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3370_gun", 3879011775U), ai_get_object(guns.Squad), 1F);
            await sleep(30);
            await sleep((short)random_range(25, 75));
            device_set_position(elevator_tram.Entity, 1F);
            device_set_position(door_elevator_tram_bot.Entity, 0F);
            await sleep_until(async () => device_get_position(door_elevator_tram_bot.Entity) == 0F, 1);
            sound_impulse_stop(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_3370_gun", 3879011775U));
            await sleep(10);
            print("well he's in a particularly fine mood. maybe lord hood forgot to give him an invitation.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1810_jon", 3879077312U), ai_get_object(johnson.Squad), 1F);
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task training_tram()
        {
            wake(new ScriptMethodReference(training_done_tram));
            await sleep_until(async () => device_get_position(elevator_tram.Entity) == 1F, 1);
            objectives_show_up_to(4);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_tram));
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1810_jon", 3879077312U)));
            await sleep_until(async () => volume_test_objects_all(tv_tram, players()) && volume_test_objects(tv_tram, ai_get_object(johnson.Squad)), 1);
            object_destroy_containing("wall_platform");
            object_create(wall_tram);
            await sleep_until(async () => !(cs_command_script_running(johnson.Squad, new ScriptMethodReference(cs_johnson_tram))), 1, 150);
            objectives_finish_up_to(4);
            custom_animation(ai_get_unit(johnson.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0010_jon", true);
            await sleep(10);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_1810_jon", 3879077312U)));
            print("earth. haven't seen it in years.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0010_jon", 3879142849U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)((float)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0010_jon", 3879142849U)) - 30));
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\01a_tutorial\\01a_music\\01a_01", 3879208386U), default(IGameObject), 1F);
            device_set_position(elevator_tram.Entity, 0F);
            device_set_position(tram.Entity, 1F);
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.08F, 1);
            await sleep(30);
            custom_animation(ai_get_unit(johnson.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0020_jon", true);
            print("when i shipped out for basic, the orbital defense grid was all theory and politics.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0020_jon", 3879470534U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0020_jon", 3879470534U)));
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.175F, 1);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_lookat_macgun));
            print("now look. the cairo is just one of three-hundred geo-sync platforms.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0021_jon", 3879536071U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0021_jon", 3879536071U)));
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.275F, 1);
            custom_animation(ai_get_unit(johnson.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0030_jon", true);
            await sleep(10);
            print("that mac-gun can put a round clean through a covenant capital-ship.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0030_jon", 3879601608U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0030_jon", 3879601608U)));
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.415F, 1);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_lookat_malta));
            await sleep(45);
            await sleep(45);
            custom_animation(ai_get_unit(johnson.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0040_jon", true);
            print("with coordinated fire from the athens and the malta, nothing's getting past this battle-cluster in one piece.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0040_jon", 3879667145U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0040_jon", 3879667145U)));
            await sleep(15);
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.7F, 1);
            custom_animation(ai_get_unit(johnson.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0050_jon", true);
            print("ships have been arriving all morning.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0050_jon", 3879732682U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0050_jon", 3879732682U)));
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\01a_tutorial\\01a_music\\01a_01", 3879208386U));
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.75F, 1);
            await sleep(30);
            custom_animation(ai_get_unit(johnson.Squad), GetTag<AnimationGraphTag>("objects\\characters\\marine\\tutorial\\tutorial", 3874751870U), "l01_0051_jon", true);
            print("nobody's saying much, but i'll bet something big's about to happen.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0051_jon", 3879798219U), ai_get_object(johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\01_spacestation\\mission\\l01_0051_jon", 3879798219U)));
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_lookat_station));
            await sleep_until(async () => device_get_position(tram.Entity) >= 0.975F, 1);
            await sleep(30);
            cs_run_command_script(johnson.Squad, new ScriptMethodReference(cs_johnson_station));
            await sleep_until(async () => !(volume_test_objects_all(tv_station, players())), 1, 150);
        }

        [ScriptMethod(74, Lifecycle.Static)]
        public async Task start_mission()
        {
            await sleep(10);
            print("01a tutorial");
            print("designer - jaime");
            print("env. artists - paul, dave");
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task training_fade()
        {
            player_disable_movement(true);
            player_camera_control(false);
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(76, Lifecycle.Startup)]
        public async Task mission_01a()
        {
            player_disable_movement(true);
            player_camera_control(false);
            if ((bool)game_is_cooperative())
            {
                game_won();
            }

            objectives_clear();
            ai_allegiance(player, human);
            fade_out(1F, 1F, 1F, 0);
            hud_enable_training(false);
            ai_dialogue_enable(false);
            await this.start_mission();
            await this.training_setup();
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            objects_predict_high(ai_get_object(guns.Squad));
            await sleep(2);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(training_fade));
            await this.training_look();
            hud_enable_training(true);
            await this.training_move();
            await this.training_shield();
            await this.save_tram_start();
            await this.training_done();
            await this.training_tram();
            print("you win!");
            sound_class_set_gain("", 0F, 15);
            loading_screen_fade_to_white();
            hud_enable_training(true);
            ai_dialogue_enable(true);
            game_won();
        }
    }
}