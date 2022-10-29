namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\08b_deltacontrol\\08b_deltacontrol")]
    public partial class scnr_08b_deltacontrol : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        bool blam;
        int tick_seconds;
        int timer_boss_tartarus_recharge;
        int timer_boss_johnson_fire;
        bool boss_tartarus_invincible;
        int count_boss_cycle;
        int counter_boss_johnson_prompt;
        int skip_boss_johnson_prompt;
        bool boss_tartarus_berserk;
        int timer_boss_tartarus_berserk;
        int counter_boss_tartarus_taunt;
        bool mark_boss_first_cycle;
        int timer_boss_reenforcements;
        int boss_random_reenforcements;
        bool boss_respawn_brutes;
        bool boss_respawn_elites;
        bool boss_flavor_done;
        int sound_offset;
        int prediction_offset;
        bool g_mission_over;
        int _15_seconds;
        int _30_seconds;
        int _45_seconds;
        int one_minute;
        int two_minutes;
        IUnit g_cov_commander;
        float g_scarab_interpolation;
        bool g_e13_started;
        bool g_e12_started;
        bool g_e12_pro_inf0_1_berserk;
        bool g_e11_started;
        bool g_e11_door_open;
        bool g_e11_door_should_open;
        bool g_e11_player_warned;
        bool g_e11_player_saw_door;
        int g_e11_shot_counter;
        bool g_e9_started;
        bool g_e9_pro_phantom0_unloaded;
        bool g_e9_pro_phantom0_retreating;
        bool g_e9_pro_phantom1_retreating;
        bool g_e9_scarab_started;
        bool g_e9_scarab_near_first_bend;
        bool g_e9_scarab_near_second_bend;
        bool g_e9_scarab_at_second_bend;
        bool g_e9_scarab_stepping_down;
        bool g_e8_started;
        bool g_e8_cov_banshees0_greeted;
        int g_e8_mars_inf0_living_count;
        int g_e8_target_wraith;
        bool g_e7_started;
        bool g_e7_mars_johnson_go;
        bool g_e7_mars_johnson_aboard;
        bool g_e7_pro_captain_done;
        bool g_e7_pro_sentry_alerted;
        int g_e7_mars_living_count;
        bool g_e6_started;
        bool g_e5_started;
        int g_e5_pro_inf2_limit;
        bool g_e4_started;
        bool g_e3_started;
        bool g_e3_hunters_rise;
        bool g_e3_hunter0_go;
        bool g_e3_hunter1_go;
        bool g_e3_hunter0_arrived;
        bool g_e3_hunter1_arrived;
        bool g_e2_started;
        bool g_e1_started;
        int g_e1_ghosts_weak;
        int g_e1_ghosts_strong;
        int g_e1_ghosts_per_leg;
        public scnr_08b_deltacontrol(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.blam = false;
            this.tick_seconds = game_tick_rate();
            this.timer_boss_tartarus_recharge = 0;
            this.timer_boss_johnson_fire = 0;
            this.boss_tartarus_invincible = false;
            this.count_boss_cycle = 1;
            this.counter_boss_johnson_prompt = 0;
            this.skip_boss_johnson_prompt = 1;
            this.boss_tartarus_berserk = false;
            this.timer_boss_tartarus_berserk = 0;
            this.counter_boss_tartarus_taunt = 0;
            this.mark_boss_first_cycle = true;
            this.timer_boss_reenforcements = 0;
            this.boss_random_reenforcements = 0;
            this.boss_respawn_brutes = false;
            this.boss_respawn_elites = false;
            this.boss_flavor_done = false;
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.g_mission_over = false;
            this._15_seconds = 450;
            this._30_seconds = 900;
            this._45_seconds = 900;
            this.one_minute = 1800;
            this.two_minutes = 3600;
            this.g_cov_commander = default(IUnit);
            this.g_scarab_interpolation = 0.25F;
            this.g_e13_started = false;
            this.g_e12_started = false;
            this.g_e12_pro_inf0_1_berserk = false;
            this.g_e11_started = false;
            this.g_e11_door_open = false;
            this.g_e11_door_should_open = false;
            this.g_e11_player_warned = false;
            this.g_e11_player_saw_door = false;
            this.g_e11_shot_counter = 0;
            this.g_e9_started = false;
            this.g_e9_pro_phantom0_unloaded = false;
            this.g_e9_pro_phantom0_retreating = false;
            this.g_e9_pro_phantom1_retreating = false;
            this.g_e9_scarab_started = false;
            this.g_e9_scarab_near_first_bend = false;
            this.g_e9_scarab_near_second_bend = false;
            this.g_e9_scarab_at_second_bend = false;
            this.g_e9_scarab_stepping_down = false;
            this.g_e8_started = false;
            this.g_e8_cov_banshees0_greeted = false;
            this.g_e8_mars_inf0_living_count = 3;
            this.g_e8_target_wraith = -1;
            this.g_e7_started = false;
            this.g_e7_mars_johnson_go = false;
            this.g_e7_mars_johnson_aboard = false;
            this.g_e7_pro_captain_done = false;
            this.g_e7_pro_sentry_alerted = false;
            this.g_e7_mars_living_count = 0;
            this.g_e6_started = false;
            this.g_e5_started = false;
            this.g_e5_pro_inf2_limit = 7;
            this.g_e4_started = false;
            this.g_e3_started = false;
            this.g_e3_hunters_rise = false;
            this.g_e3_hunter0_go = false;
            this.g_e3_hunter1_go = false;
            this.g_e3_hunter0_arrived = false;
            this.g_e3_hunter1_arrived = false;
            this.g_e2_started = false;
            this.g_e1_started = false;
            this.g_e1_ghosts_weak = 1;
            this.g_e1_ghosts_strong = 3;
            this.g_e1_ghosts_per_leg = 10;
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
        public async Task cs_boss_brutes_stunned()
        {
            cs_force_combat_status(4);
            cs_enable_moving(false);
            cs_pause(1F);
            cs_abort_on_damage(true);
            cs_pause(1F);
        }

        [ScriptMethod(25, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_stunned()
        {
            cs_force_combat_status(4);
            cs_enable_moving(false);
            sleep_forever();
        }

        [ScriptMethod(26, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_jump()
        {
            cs_force_combat_status(4);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("boss/mid_land"));
            cs_face_player(true);
        }

        [ScriptMethod(27, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_cheer()
        {
            cs_enable_moving(false);
            cs_enable_targeting(false);
            cs_face_player(true);
            await sleep(60);
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 3826188953U), "combat:rifle:cheer", true);
            await sleep(60);
        }

        [ScriptMethod(28, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_taunt()
        {
            cs_enable_moving(false);
            cs_enable_targeting(false);
            cs_face_player(true);
            await sleep(60);
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 3826188953U), "combat:rifle:taunt", true);
            await sleep(60);
        }

        [ScriptMethod(29, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_shakefist()
        {
            cs_enable_moving(false);
            cs_enable_targeting(false);
            cs_face_player(true);
            await sleep(60);
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 3826188953U), "combat:rifle:shakefist", true);
            await sleep(60);
        }

        [ScriptMethod(30, Lifecycle.CommandScript)]
        public async Task cs_boss_johnson_idle()
        {
            cs_force_combat_status(4);
            cs_enable_moving(false);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("boss/ledge_perch"));
            cs_crouch(true);
            cs_face_object(true, ai_get_object(boss_tartarus.Squad));
            cs_aim_object(true, ai_get_object(boss_tartarus.Squad));
            print("johnson idle");
            sleep_forever();
        }

        [ScriptMethod(31, Lifecycle.CommandScript)]
        public async Task cs_boss_johnson_idle2()
        {
            cs_force_combat_status(4);
            cs_enable_moving(false);
            cs_crouch(true);
            cs_face_object(true, ai_get_object(boss_tartarus.Squad));
            cs_aim_object(true, ai_get_object(boss_tartarus.Squad));
            print("johnson idle2");
            sleep_forever();
        }

        [ScriptMethod(32, Lifecycle.CommandScript)]
        public async Task cs_boss_johnson_shoot()
        {
            cs_force_combat_status(4);
            cs_enable_moving(false);
            cs_crouch(true);
            cs_face_object(true, ai_get_object(boss_tartarus.Squad));
            cs_aim_object(true, ai_get_object(boss_tartarus.Squad));
            cs_shoot(true, ai_get_object(boss_tartarus.Squad));
            print("shot 1");
            await sleep(5);
            cs_shoot(false, ai_get_object(boss_tartarus.Squad));
            await sleep(11);
            cs_shoot(true, ai_get_object(boss_tartarus.Squad));
            print("shot 2");
            await sleep(5);
            cs_shoot(false, ai_get_object(boss_tartarus.Squad));
            await sleep(11);
            cs_shoot(true, ai_get_object(boss_tartarus.Squad));
            print("shot 3");
            await sleep(15);
        }

        [ScriptMethod(33, Lifecycle.CommandScript)]
        public async Task cs_boss_miranda_nocrouch()
        {
            cs_crouch(false);
            sleep_forever();
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task boss_tartarus_taunt()
        {
            if (this.counter_boss_tartarus_taunt == 0)
            {
                print("what? is the mighty arbiter afraid?!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_0980_tar", 3828286137U), ai_get_object(boss_tartarus.Squad), 1F);
            }
            else if (this.counter_boss_tartarus_taunt == 1)
            {
                print("you want revenge?! well here i am! come and take it!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_0990_tar", 3828351674U), ai_get_object(boss_tartarus.Squad), 1F);
            }
            else if (this.counter_boss_tartarus_taunt == 2)
            {
                print("just like the rest of your kind - you are cowardly and weak!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1000_tar", 3828417211U), ai_get_object(boss_tartarus.Squad), 1F);
            }
            else if (true)
            {
                this.counter_boss_tartarus_taunt = 0;
            }

            this.counter_boss_tartarus_taunt = (short)(this.counter_boss_tartarus_taunt + 1);
        }

        [ScriptMethod(35, Lifecycle.Static)]
        public async Task boss_johnson_prompt()
        {
            await sleep(45);
            if (this.counter_boss_johnson_prompt == (short)(1 * this.skip_boss_johnson_prompt))
            {
                print("hey, mohawk! how'd that feel?!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2010_jon", 3828482748U), ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(2 * this.skip_boss_johnson_prompt))
            {
                print("his shield is down! let him have it!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2020_jon", 3828548285U), ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(3 * this.skip_boss_johnson_prompt))
            {
                print("there goes his shield!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2030_jon", 3828613822U), ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(4 * this.skip_boss_johnson_prompt))
            {
                print("got his shield! hit him now!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2040_jon", 3828679359U), ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(5 * this.skip_boss_johnson_prompt))
            {
                print("quick! while his shield is down!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2050_jon", 3828744896U), ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(6 * this.skip_boss_johnson_prompt))
            {
                print("i can keep his shield down, but you're gonna have to finish the job!");
                sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2060_jon", 3828810433U), ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt > (short)(8 * this.skip_boss_johnson_prompt))
            {
                this.counter_boss_johnson_prompt = 0;
                this.skip_boss_johnson_prompt = (short)(this.skip_boss_johnson_prompt + 1);
            }

            this.counter_boss_johnson_prompt = (short)(this.counter_boss_johnson_prompt + 1);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task boss_flavor()
        {
            await sleep((short)(5 * 30));
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\ambience\\deltacontolroom\\boss\\stage1", 3828875970U), default(IGameObject), 1F);
            await sleep((short)(5 * 30));
            print("charging sequence initiated! primary generators coming on-line!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1040_gsp", 3828941507U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1040_gsp", 3828941507U)));
            print("well, shut them down!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1050_mir", 3829007044U), ai_get_object(boss_miranda1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1050_mir", 3829007044U)));
            print("apology. protocol does allow me to interfere with any aspect of the sequence.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1060_gsp", 3829072581U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1060_gsp", 3829072581U)));
            print("then how do i stop it?!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1120_mir", 3829138118U), ai_get_object(boss_miranda1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1120_mir", 3829138118U)));
            print("well�it will take some time to go over the proper procedures�");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1130_gsp", 3829203655U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1130_gsp", 3829203655U)));
            print("quit stalling!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1140_mir", 3829269192U), ai_get_object(boss_miranda1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1140_mir", 3829269192U)));
            print("under more controlled circumstances, i would suggest the reclaimer simply remove the index.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1150_gsp", 3829334729U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1150_gsp", 3829334729U)));
            print("that's it?! johnson, i'm on it!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1160_mir", 3829400266U), ai_get_object(boss_miranda1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1160_mir", 3829400266U)));
            print("hang-tight, ma'am! not until that brute is dead!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1170_jon", 3829465803U), ai_get_object(boss_johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1170_jon", 3829465803U)));
            this.boss_flavor_done = true;
            await sleep((short)(30 * 30));
            this.boss_flavor_done = false;
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\ambience\\deltacontolroom\\boss\\stage2", 3829531340U), default(IGameObject), 1F);
            await sleep((short)(5 * 30));
            print("secondary generators charging! all systems are performing well within operational parameters!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1070_gsp", 3829596877U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1070_gsp", 3829596877U)));
            print("you're telling me you can't stop the sequence?");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1080_mir", 3829662414U), ai_get_object(boss_miranda1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1080_mir", 3829662414U)));
            print("reclaimer, please understand: interrupting the wave-generation process will severely damage this installation.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1090_gsp", 3829727951U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1090_gsp", 3829727951U)));
            print("give me a direct answer!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1100_mir", 3829793488U), ai_get_object(boss_miranda1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1100_mir", 3829793488U)));
            print("i am but a monitor. the reclaimer can do what it likes.");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1110_gsp", 3829859025U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1110_gsp", 3829859025U)));
            this.boss_flavor_done = true;
            await sleep((short)(30 * 30));
            this.boss_flavor_done = false;
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\ambience\\deltacontolroom\\boss\\stage3", 3829924562U), default(IGameObject), 1F);
            await sleep((short)(5 * 30));
            print("power-generation phase complete! the installation is ready to fire! starting final countdown�");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1180_gsp", 3829990099U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1180_gsp", 3829990099U)));
            print("c'mon, arbiter! kick that guy's ass!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1190_jon", 3830055636U), ai_get_object(boss_johnson.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1190_jon", 3830055636U)));
            print("and may i say, reclaimers, it has been a pleasure to serve you both! goodbye!");
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1200_gsp", 3830121173U), ai_get_object(boss_monitor1.Squad), 1F);
            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1200_gsp", 3830121173U)));
            this.boss_flavor_done = true;
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task boss_music()
        {
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_11", 3830186710U), default(IGameObject), 1F);
            await sleep_until(async () => volume_test_objects(tv_boss_platform, players()));
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_12", 3830579932U), default(IGameObject), 1F);
            await sleep_until(async () => !(this.mark_boss_first_cycle));
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_13", 3830973154U), default(IGameObject), 1F);
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task<int> boss_tartarus_rateofrecharge()
        {
            if (await this.difficulty_legendary())
            {
                return (short)random_range((short)(1 * this.tick_seconds), (short)(2 * this.tick_seconds));
            }
            else if (await this.difficulty_heroic())
            {
                return (short)random_range((short)(1 * this.tick_seconds), (short)(3 * this.tick_seconds));
            }
            else if (true)
            {
                return (short)random_range((short)(2 * this.tick_seconds), (short)(3 * this.tick_seconds));
            }
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task<int> boss_johnson_rateoffire()
        {
            if (await this.difficulty_legendary())
            {
                return (short)random_range((short)(7 * this.tick_seconds), (short)(15 * this.tick_seconds));
            }
            else if (await this.difficulty_heroic())
            {
                return (short)random_range((short)(5 * this.tick_seconds), (short)(12 * this.tick_seconds));
            }
            else if (true)
            {
                return (short)random_range((short)(4 * this.tick_seconds), (short)(10 * this.tick_seconds));
            }
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task<int> boss_rateofreenforcement()
        {
            if (await this.difficulty_legendary())
            {
                return (short)random_range((short)(30 * this.tick_seconds), (short)(60 * this.tick_seconds));
            }
            else if (await this.difficulty_heroic())
            {
                return (short)random_range((short)(30 * this.tick_seconds), (short)(60 * this.tick_seconds));
            }
            else if (true)
            {
                return (short)random_range((short)(30 * this.tick_seconds), (short)(60 * this.tick_seconds));
            }
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task boss_tartarus_invincible_on()
        {
            object_set_function_variable(ai_get_object(boss_tartarus.Squad), "invincibility", 1F, 2F);
            object_set_shield(ai_get_object(boss_tartarus.Squad), 1F / 1000F);
            this.boss_tartarus_invincible = true;
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task boss_tartarus_invincible_off()
        {
            object_set_function_variable(ai_get_object(boss_tartarus.Squad), "invincibility", 0F, 0.1F);
            object_set_shield(ai_get_object(boss_tartarus.Squad), 0F / 1000F);
            this.boss_tartarus_invincible = false;
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task boss_tartarus_berserk_on()
        {
            ai_berserk(boss_tartarus.Squad, true);
            this.boss_tartarus_berserk = true;
            print("berserk");
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task boss_tartarus_berserk_off()
        {
            ai_berserk(boss_tartarus.Squad, false);
            this.boss_tartarus_berserk = false;
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task boss_setup()
        {
            switch_bsp(3);
            ai_allegiance(player, human);
            ai_allegiance(player, covenant);
            ai_allegiance(player, sentinel);
            ai_allegiance(human, covenant);
            ai_allegiance(human, sentinel);
            ai_allegiance(covenant, human);
            ai_allegiance(covenant, sentinel);
            ai_allegiance(prophet, sentinel);
            await sleep(1);
            object_teleport(await this.player0(), boss_player0_flag);
            object_teleport(await this.player1(), boss_player1_flag);
            kill_volume_enable(kill_e13_0);
            device_set_position_immediate(e13_rotors.Entity, 0.625F);
            device_operates_automatically_set(e12_door1.Entity, false);
            if (await this.difficulty_legendary())
            {
                this.count_boss_cycle = 4;
            }
            else if (await this.difficulty_heroic())
            {
                this.count_boss_cycle = 3;
            }
            else if (true)
            {
                this.count_boss_cycle = 2;
            }

            if (await this.difficulty_legendary())
            {
                this.skip_boss_johnson_prompt = 6;
            }
            else if (await this.difficulty_heroic())
            {
                this.skip_boss_johnson_prompt = 3;
            }
            else if (true)
            {
                this.skip_boss_johnson_prompt = 1;
            }

            ai_place(boss_tartarus.Squad);
            unit_impervious(ai_get_object(boss_tartarus.Squad), true);
            ai_cannot_die(boss_tartarus.Squad, true);
            unit_only_takes_damage_from_players_team(ai_get_unit(boss_tartarus.Squad), true);
            object_set_scale(ai_get_object(boss_tartarus.Squad), 1.15F, 0);
            await this.boss_tartarus_invincible_on();
            if (await this.difficulty_legendary())
            {
                unit_set_maximum_vitality(ai_get_unit(boss_tartarus.Squad), 400F, 1000F);
            }
            else if (await this.difficulty_heroic())
            {
                unit_set_maximum_vitality(ai_get_unit(boss_tartarus.Squad), 350F, 1000F);
            }
            else if (true)
            {
                unit_set_maximum_vitality(ai_get_unit(boss_tartarus.Squad), 300F, 1000F);
            }

            unit_set_current_vitality(ai_get_unit(boss_tartarus.Squad), 50F, 1000F);
            cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_stunned));
            ai_place(boss_miranda1.Squad);
            unit_impervious(ai_actors(boss_miranda1.Squad), true);
            object_cannot_die(ai_get_object(boss_miranda1.Squad), true);
            cs_run_command_script(boss_miranda1.Squad, new ScriptMethodReference(cs_boss_miranda_nocrouch));
            ai_disregard(ai_get_object(boss_miranda1.Squad), true);
            ai_place(boss_monitor1.Squad);
            ai_cannot_die(boss_monitor1.Squad, true);
            ai_disregard(ai_get_object(boss_monitor1.Squad), true);
            ai_place(boss_johnson.Squad);
            unit_impervious(ai_actors(boss_johnson.Squad), true);
            object_cannot_die(ai_get_object(boss_johnson.Squad), true);
            ai_disregard(ai_get_object(boss_johnson.Squad), true);
            cinematic_lighting_set_primary_light(27F, 0F, 0.34902F, 0.333333F, 0.541176F);
            cinematic_lighting_set_secondary_light(-26F, 154F, 0.639216F, 0.54902F, 0.505882F);
            cinematic_lighting_set_ambient_light(0.0823529F, 0.0784314F, 0.0588235F);
            object_uses_cinematic_lighting(ai_get_object(boss_johnson.Squad), true);
            ai_place(boss_brute_start.Squad);
            cs_run_command_script(boss_brute_start.Squad, new ScriptMethodReference(cs_boss_brutes_stunned));
            ai_place(boss_elite_start.Squad);
            game_save_immediate();
        }

        [ScriptMethod(46, Lifecycle.Static)]
        public async Task tartarus_boss_fight()
        {
            await this.cinematic_snap_to_white();
            object_create_containing("boss_object");
            print("war!");
            await this.boss_setup();
            wake(new ScriptMethodReference(boss_music));
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white();
            await sleep(90);
            units_set_current_vitality(ai_actors(boss_brute_start.Squad), 30F, 0F);
            await sleep(120);
            await sleep_until(async () => !(device_get_position(e13_rotors.Entity) > 0.05F && device_get_position(e13_rotors.Entity) < 0.125F || device_get_position(e13_rotors.Entity) > 0.3F && device_get_position(e13_rotors.Entity) < 0.375F || device_get_position(e13_rotors.Entity) > 0.55F && device_get_position(e13_rotors.Entity) < 0.625F || device_get_position(e13_rotors.Entity) > 0.8F && device_get_position(e13_rotors.Entity) < 0.875F), 1);
            cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_jump));
            await sleep_until(async () => (short)ai_living_count(boss_brute_start.Squad) == 0, 1, 15 * 30);
            ai_place(boss_elite_reenforcements1.Squad);
            await sleep_until(async () => volume_test_objects(tv_boss_platform, players()), 1, 30 * 30);
            await sleep((short)(10 * 30));
            unit_impervious(ai_get_object(boss_tartarus.Squad), false);
            this.timer_boss_johnson_fire = await this.boss_johnson_rateoffire();
            cs_run_command_script(boss_johnson.Squad, new ScriptMethodReference(cs_boss_johnson_idle));
            wake(new ScriptMethodReference(boss_flavor));
            unit_set_current_vitality(ai_get_unit(boss_tartarus.Squad), 50F, 1000F);
            await sleep_until(async () =>
            {
                if (volume_test_objects(kill_e13_0, ai_get_object(boss_miranda1.Squad)))
                {
                    ai_erase(boss_miranda1.Squad);
                    ai_place(boss_miranda1.Squad);
                    unit_impervious(ai_actors(boss_miranda1.Squad), true);
                    object_cannot_die(ai_get_object(boss_miranda1.Squad), true);
                    return false;
                }
                else if (!(volume_test_objects(tv_boss_ledge, ai_get_object(boss_johnson.Squad))))
                {
                    ai_erase(boss_johnson.Squad);
                    ai_place(boss_johnson.Squad);
                    unit_impervious(ai_actors(boss_johnson.Squad), true);
                    object_cannot_die(ai_get_object(boss_johnson.Squad), true);
                    return false;
                }
                else if (!(volume_test_objects(tv_boss_platform, ai_get_object(boss_tartarus.Squad))) && !(volume_test_objects(tv_boss_ledge, ai_get_object(boss_tartarus.Squad))) && await this.player_count() > 0)
                {
                    object_teleport(ai_get_object(boss_tartarus.Squad), boss_tartarus_respawn_flag);
                    await sleep(90);
                    return false;
                }
                else if ((bool)ai_vitality_pinned(boss_tartarus.Squad))
                {
                    this.count_boss_cycle = (short)(this.count_boss_cycle - 1);
                    print("cycle complete");
                    if (!(await this.player_count() > 0))
                    {
                        return false;
                    }
                    else if (this.count_boss_cycle <= 0)
                    {
                        ai_cannot_die(boss_tartarus.Squad, false);
                        ai_kill(boss_tartarus.Squad);
                        return true;
                    }
                    else if (true)
                    {
                        if (this.mark_boss_first_cycle)
                        {
                            print("(growls in pain) a lucky hit! you will not land another!");
                            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1020_tar", 3831366376U), ai_get_object(boss_tartarus.Squad), 1F);
                            this.mark_boss_first_cycle = false;
                        }

                        if (await this.difficulty_legendary())
                        {
                            unit_set_maximum_vitality(ai_get_unit(boss_tartarus.Squad), 400F, 1000F);
                        }
                        else if (await this.difficulty_heroic())
                        {
                            unit_set_maximum_vitality(ai_get_unit(boss_tartarus.Squad), 350F, 1000F);
                        }
                        else if (true)
                        {
                            unit_set_maximum_vitality(ai_get_unit(boss_tartarus.Squad), 300F, 1000F);
                        }

                        this.boss_respawn_brutes = true;
                        await this.boss_tartarus_invincible_on();
                        begin_random(async () => cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_taunt)), 
                            async () => cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_cheer)), 
                            async () => cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_shakefist)));
                        await sleep_until(async () => !(cs_command_script_running(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_taunt))) && !(cs_command_script_running(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_cheer))) && !(cs_command_script_running(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_shakefist))), 1);
                        if (!(await this.difficulty_normal()))
                        {
                            await this.boss_tartarus_berserk_on();
                        }

                        return false;
                    }
                }
                else if (!(volume_test_objects(tv_boss_platform, players())) && !((bool)ai_vitality_pinned(boss_tartarus.Squad)) && await this.player_count() > 0)
                {
                    if (this.boss_flavor_done)
                    {
                        await this.boss_tartarus_taunt();
                    }

                    ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    await sleep_until(async () => volume_test_objects(tv_boss_platform, players()), 1, 15 * 30);
                    return false;
                }
                else if (this.timer_boss_tartarus_recharge > 0)
                {
                    this.timer_boss_tartarus_recharge = (short)(this.timer_boss_tartarus_recharge - 1);
                    return false;
                }
                else if (!(this.boss_tartarus_invincible))
                {
                    ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    await this.boss_tartarus_invincible_on();
                    return false;
                }
                else if (await this.difficulty_legendary() && unit_get_shield(ai_get_unit(boss_tartarus.Squad)) < 0.9F || await this.difficulty_heroic() && unit_get_shield(ai_get_unit(boss_tartarus.Squad)) < 0.95F || await this.difficulty_normal() && unit_get_shield(ai_get_unit(boss_tartarus.Squad)) < 0.975F)
                {
                    ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    await this.boss_tartarus_invincible_off();
                    if (this.boss_flavor_done)
                    {
                        await this.boss_johnson_prompt();
                    }

                    this.timer_boss_tartarus_recharge = await this.boss_tartarus_rateofrecharge();
                    return false;
                }
                else if (this.timer_boss_tartarus_berserk > 0)
                {
                    this.timer_boss_tartarus_berserk = (short)(this.timer_boss_tartarus_berserk - 1);
                    return false;
                }
                else if (this.boss_tartarus_berserk)
                {
                    ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    await this.boss_tartarus_berserk_off();
                    return false;
                }
                else if (this.boss_respawn_brutes && (float)ai_living_count(boss_elite_reenforcements1.Squad) + (float)ai_living_count(boss_brute_reenforcements1.Squad) <= 3F)
                {
                    if (await this.difficulty_legendary())
                    {
                        this.boss_random_reenforcements = (short)random_range(3, 10);
                    }
                    else if (await this.difficulty_heroic())
                    {
                        this.boss_random_reenforcements = (short)random_range(3, 7);
                    }
                    else if (true)
                    {
                        this.boss_random_reenforcements = (short)random_range(0, 6);
                    }

                    if (this.boss_random_reenforcements > 7)
                    {
                        ai_place(boss_brute_reenforcements_many.Squad);
                    }
                    else if (this.boss_random_reenforcements > 3)
                    {
                        ai_place(boss_brute_reenforcements1.Squad);
                    }

                    this.boss_respawn_brutes = false;
                    return this.boss_respawn_brutes;
                }
                else if (this.boss_respawn_elites && (float)ai_living_count(boss_elite_reenforcements1.Squad) + (float)ai_living_count(boss_brute_reenforcements1.Squad) <= 3F)
                {
                    if (await this.difficulty_legendary())
                    {
                        this.boss_random_reenforcements = (short)random_range(3, 10);
                    }
                    else if (await this.difficulty_heroic())
                    {
                        this.boss_random_reenforcements = (short)random_range(3, 7);
                    }
                    else if (true)
                    {
                        this.boss_random_reenforcements = (short)random_range(0, 6);
                    }

                    if (this.boss_random_reenforcements < 3)
                    {
                        ai_place(boss_elite_reenforcements_many.Squad);
                    }
                    else if (this.boss_random_reenforcements < 7)
                    {
                        ai_place(boss_elite_reenforcements1.Squad);
                    }

                    this.boss_respawn_elites = false;
                    return this.boss_respawn_elites;
                }
                else if (this.timer_boss_johnson_fire > 0)
                {
                    this.timer_boss_johnson_fire = (short)(this.timer_boss_johnson_fire - 1);
                    if ((float)ai_living_count(boss_elite_reenforcements1.Squad) + (float)ai_living_count(boss_brute_reenforcements1.Squad) <= 3F)
                    {
                        this.timer_boss_reenforcements = (short)(this.timer_boss_reenforcements - 1);
                    }

                    if (this.timer_boss_reenforcements <= 0)
                    {
                        this.boss_respawn_elites = true;
                        this.timer_boss_reenforcements = await this.boss_rateofreenforcement();
                        print("respawn!");
                    }

                    return false;
                }
                else if (objects_can_see_object(ai_get_object(boss_johnson.Squad), ai_get_object(boss_tartarus.Squad), 0.25F))
                {
                    ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    print("fire");
                    object_set_shield(ai_get_object(boss_tartarus.Squad), 1F / 1000F);
                    cs_run_command_script(boss_johnson.Squad, new ScriptMethodReference(cs_boss_johnson_shoot));
                    cs_queue_command_script(boss_johnson.Squad, new ScriptMethodReference(cs_boss_johnson_idle));
                    this.timer_boss_johnson_fire = await this.boss_johnson_rateoffire();
                    return false;
                }
                else if (true)
                {
                    ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    return false;
                }
            }, 1);
            ai_kill(boss_tartarus.Squad);
            print("nice job!");
            sleep_forever(new ScriptMethodReference(boss_flavor));
            await sleep((short)(10 * 30));
            if (await this.player_count() == 0)
            {
                sleep_forever();
            }

            await this.cinematic_fade_to_white();
            await sleep(15);
            ai_erase(boss_elite_reenforcements1.Squad);
            ai_erase(boss_tartarus.Squad);
            ai_erase(boss_brute_reenforcements1.Squad);
            ai_erase(boss_miranda1.Squad);
            ai_erase(boss_johnson.Squad);
            ai_erase(boss_monitor1.Squad);
            object_destroy_containing("boss_object");
            garbage_collect_now();
        }

        [ScriptMethod(47, Lifecycle.Static)]
        public async Task _08_intra1_04_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra1_04_predict));
        }

        [ScriptMethod(48, Lifecycle.Static)]
        public async Task _08_intra2_01_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra2_01_predict));
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task _08_intra2_02_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra2_02_predict));
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task _08_intra3_01_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra3_01_predict));
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task _08_intra3_02_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra3_02_predict));
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task _08_intra3_03_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra3_03_predict));
        }

        [ScriptMethod(53, Lifecycle.Static)]
        public async Task _08_intra3_04_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra3_04_predict));
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task _08_intra3_05_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra3_05_predict));
        }

        [ScriptMethod(55, Lifecycle.Static)]
        public async Task _08_intra3_06_predict_stub()
        {
            wake(new ScriptMethodReference(_08_intra3_05_predict));
        }

        [ScriptMethod(56, Lifecycle.Static)]
        public async Task x09_01_predict_stub()
        {
            wake(new ScriptMethodReference(x09_01_predict));
        }

        [ScriptMethod(57, Lifecycle.Static)]
        public async Task x09_02_predict_stub()
        {
            wake(new ScriptMethodReference(x09_02_predict));
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task x09_03_predict_stub()
        {
            wake(new ScriptMethodReference(x09_03_predict));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x09_04_predict_stub()
        {
            wake(new ScriptMethodReference(x09_04_predict));
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x09_05_predict_stub()
        {
            wake(new ScriptMethodReference(x09_05_predict));
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task x09_06_predict_stub()
        {
            wake(new ScriptMethodReference(x09_06_predict));
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task x09_07_predict_stub()
        {
            wake(new ScriptMethodReference(x09_07_predict));
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task x09_08_predict_stub()
        {
            wake(new ScriptMethodReference(x09_08_predict));
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task x10_01_predict_stub()
        {
            wake(new ScriptMethodReference(x10_01_predict));
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task x10_02_predict_stub()
        {
            wake(new ScriptMethodReference(x10_02_predict));
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task c08_intra1_score_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_04_mus", 3831431913U), default(IGameObject), 1F);
            print("c08_intra1 score 04 start");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_04_fol", 3831497450U), default(IGameObject), 1F);
            print("c08_intra1 foley 04 start");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c08_2050_der()
        {
            await sleep(60);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2050_der", 3831562987U), dervish_02.Entity, 1F);
            cinematic_subtitle("c08_2050_der", 1F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c08_2060_soc()
        {
            await sleep(92);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2060_soc", 3831628524U), commander.Entity, 1F);
            cinematic_subtitle("c08_2060_soc", 6F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c08_2070_grv()
        {
            await sleep(273);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2070_grv", 3831694061U), default(IGameObject), 1F);
            cinematic_subtitle("c08_2070_grv", 5F);
            cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task c08_2080_der()
        {
            await sleep(425);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2080_der", 3831759598U), dervish_02.Entity, 1F);
            cinematic_subtitle("c08_2080_der", 2F);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task c08_2090_soc()
        {
            await sleep(473);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2090_soc", 3831825135U), commander.Entity, 1F);
            cinematic_subtitle("c08_2090_soc", 1F);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task c08_2100_soc()
        {
            await sleep(512);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2100_soc", 3831890672U), commander.Entity, 1F);
            cinematic_subtitle("c08_2100_soc", 2F);
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c04_intra1_fov_04()
        {
            await sleep(511);
            print("fov change: 80 -> 60 over 0 ticks");
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task c04_intra1_dof_04()
        {
            await sleep(427);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1.17F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(84);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(100);
            cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0F, 0F, 0F, 0.5F, 0.5F);
            print("rack focus");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_04()
        {
            cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            object_uses_cinematic_lighting(dervish_02.Entity, true);
            object_uses_cinematic_lighting(commander.Entity, true);
            object_uses_cinematic_lighting(wraith_01.Entity, true);
        }

        [ScriptMethod(77, Lifecycle.Static)]
        public async Task c08_intra1_04_problem_actors()
        {
            print("problem actors");
            object_create_anew(dervish_02);
            object_create_anew(commander);
            object_create_anew(wraith_01);
            cinematic_clone_players_weapon(dervish_02.Entity, "right_hand_elite", "");
            object_cinematic_lod(dervish_02.Entity, true);
            object_cinematic_lod(commander.Entity, true);
            object_cinematic_lod(wraith_01.Entity, true);
        }

        [ScriptMethod(78, Lifecycle.Static)]
        public async Task c08_intra1_04_setup()
        {
            wake(new ScriptMethodReference(c08_intra1_score_04));
            wake(new ScriptMethodReference(c08_intra1_foley_04));
            wake(new ScriptMethodReference(c08_2050_der));
            wake(new ScriptMethodReference(c08_2060_soc));
            wake(new ScriptMethodReference(c08_2070_grv));
            wake(new ScriptMethodReference(c08_2080_der));
            wake(new ScriptMethodReference(c08_2090_soc));
            wake(new ScriptMethodReference(c08_2100_soc));
            wake(new ScriptMethodReference(c04_intra1_fov_04));
            wake(new ScriptMethodReference(c04_intra1_dof_04));
            wake(new ScriptMethodReference(cinematic_lighting_intra1_04));
        }

        [ScriptMethod(79, Lifecycle.Static)]
        public async Task c08_intra1_04_cleanup()
        {
            object_destroy(dervish_02.Entity);
            object_destroy(commander.Entity);
            object_destroy(wraith_01.Entity);
        }

        [ScriptMethod(80, Lifecycle.Static)]
        public async Task c08_intra1()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("vehicle", 0F, 0);
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start_movie("deltacontrol_intra1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this.c08_intra1_04_problem_actors();
            await this._08_intra1_04_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_04_mus", 3831431913U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_04_fol", 3831497450U));
            await sleep(this.prediction_offset);
            await this.c08_intra1_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3831956209U), "08_intra1_04", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(dervish_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra1\\08_intra1", 3832021746U), "dervish_04", false, anchor_intra1.Entity);
            custom_animation_relative(commander.Entity, GetTag<AnimationGraphTag>("objects\\characters\\elite\\08_intra1\\08_intra1", 3832152820U), "commander_04", false, anchor_intra1.Entity);
            custom_animation_relative(wraith_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\wraith\\08_intra1\\08_intra1", 3832283894U), "wraith_04", false, anchor_intra1.Entity);
            print("cache block");
            await sleep(1);
            await cache_block_for_one_frame();
            fade_in(0F, 0F, 0F, 30);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c08_intra1_04_cleanup();
            cinematic_screen_effect_stop();
            await sleep(30);
            sound_class_set_gain("vehicle", 1F, 1);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c08_intra2_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_01_fol", 3832349431U), default(IGameObject), 1F);
            print("c08_intra2 foley 01 start");
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c08_3010_jon()
        {
            await sleep(100);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3010_jon", 3832414968U), johnson_02.Entity, 1F, "radio_covy_in");
            cinematic_subtitle("c08_3010_jon", 3F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c08_3020_jon()
        {
            await sleep(203);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3020_jon", 3832480505U), johnson_02.Entity, 1F);
            cinematic_subtitle("c08_3020_jon", 3F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task c08_3030_jon()
        {
            await sleep(316);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3030_jon", 3832546042U), johnson_02.Entity, 1F);
            cinematic_subtitle("c08_3030_jon", 2F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task c08_3040_der()
        {
            await sleep(359);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3040_der", 3832611579U), dervish_02.Entity, 1F);
            cinematic_subtitle("c08_3040_der", 3F);
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task intra2_texture_cam_01()
        {
            object_create_anew(texture_camera);
            texture_camera_set_object_marker(texture_camera.Entity, "marker", 35F);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\08_intra2\\08_intra2", 3832677116U), "texture_camera_01", anchor_intra2.Entity);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra2()
        {
            cinematic_lighting_set_primary_light(33F, 0F, 0.258824F, 0.278431F, 0.34902F);
            cinematic_lighting_set_secondary_light(-37F, 228F, 0.109804F, 0.419608F, 0.611765F);
            cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            object_uses_cinematic_lighting(dervish_02.Entity, true);
            object_uses_cinematic_lighting(johnson_02.Entity, true);
            object_uses_cinematic_lighting(scarab_01.Entity, true);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task c08_intra2_problem_actors()
        {
            print("problem actors");
            object_create_anew(dervish_02);
            object_cinematic_lod(dervish_02.Entity, true);
            cinematic_clone_players_weapon(dervish_02.Entity, "right_hand_elite", "");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task scarab_shake()
        {
            await sleep(45);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 2F);
            await sleep(240);
            player_effect_stop(2F);
        }

        [ScriptMethod(90, Lifecycle.Static)]
        public async Task c08_intra2_01_setup()
        {
            object_destroy(scarab.Entity);
            object_create_anew(johnson_02);
            object_create_anew(scarab_01);
            object_create_anew(scarab_screen);
            objects_attach(scarab_01.Entity, "holo_scarab_full", scarab_screen.Entity, "");
            object_cinematic_lod(johnson_02.Entity, true);
            object_cinematic_lod(scarab_01.Entity, true);
            unit_set_emotional_state(johnson_02.Entity, "angry", 0.25F, 0);
            wake(new ScriptMethodReference(c08_intra2_foley_01));
            wake(new ScriptMethodReference(c08_3010_jon));
            wake(new ScriptMethodReference(c08_3020_jon));
            wake(new ScriptMethodReference(c08_3030_jon));
            wake(new ScriptMethodReference(c08_3040_der));
            wake(new ScriptMethodReference(scarab_shake));
            wake(new ScriptMethodReference(intra2_texture_cam_01));
            wake(new ScriptMethodReference(cinematic_lighting_intra2));
        }

        [ScriptMethod(91, Lifecycle.Static)]
        public async Task c08_intra2_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("deltacontrol_intra2");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this.c08_intra2_problem_actors();
            await this._08_intra2_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_01_fol", 3832349431U));
            await sleep(this.prediction_offset);
            await sleep(45);
            await this.c08_intra2_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra2\\08_intra2", 3832742653U), "08_intra2_01", default(IUnit), anchor_flag_intra2);
            custom_animation_relative(dervish_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra2\\08_intra2", 3832808190U), "dervish_01", false, anchor_intra2.Entity);
            custom_animation_relative(johnson_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra2\\08_intra2", 3832873727U), "johnson_01", false, anchor_intra2.Entity);
            scenery_animation_start_relative(scarab_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\08_intra2\\08_intra2", 3833004801U), "scarab_01", anchor_intra2.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra2_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_02_fol", 3833070338U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task c08_intra2_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_02_fol", 3833070338U), default(IGameObject), 1F);
            print("c08_intra1 foley 04 start");
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task c08_3050_jon()
        {
            await sleep(70);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3050_jon", 3833135875U), johnson_02.Entity, 1F, "radio_covy_loop");
            cinematic_subtitle("c08_3050_jon", 2F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task c08_3061_jon()
        {
            await sleep(156);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3061_jon", 3833201412U), johnson_02.Entity, 1F, "radio_covy_loop");
            cinematic_subtitle("c08_3061_jon", 2F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task c08_3070_jon()
        {
            await sleep(231);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3070_jon", 3833266949U), johnson_02.Entity, 1F);
            cinematic_subtitle("c08_3070_jon", 1F);
            unit_set_emotional_state(johnson_02.Entity, "angry", 0.75F, 45);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task intra2_dof()
        {
            await sleep(68);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0.001F, 0F, 0F, 0.001F);
            print("rack focus");
            await sleep(151);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task scarab_shake2()
        {
            await sleep(137);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.75F, 0.15F);
            await sleep(5);
            player_effect_stop(0.5F);
        }

        [ScriptMethod(98, Lifecycle.Static)]
        public async Task c08_intra2_02_setup()
        {
            wake(new ScriptMethodReference(c08_intra2_foley_02));
            wake(new ScriptMethodReference(c08_3050_jon));
            wake(new ScriptMethodReference(c08_3061_jon));
            wake(new ScriptMethodReference(c08_3070_jon));
            wake(new ScriptMethodReference(intra2_dof));
            wake(new ScriptMethodReference(scarab_shake2));
        }

        [ScriptMethod(99, Lifecycle.Static)]
        public async Task c08_intra2_02_cleanup()
        {
            object_destroy(dervish_02.Entity);
            object_destroy(johnson_02.Entity);
            object_destroy(scarab_01.Entity);
            object_destroy(scarab_screen.Entity);
            object_create_anew(scarab);
        }

        [ScriptMethod(100, Lifecycle.Static)]
        public async Task c08_intra2_scene_02()
        {
            await this.c08_intra2_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra2\\08_intra2", 3832742653U), "08_intra2_02", default(IUnit), anchor_flag_intra2);
            custom_animation_relative(dervish_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra2\\08_intra2", 3832808190U), "dervish_02", false, anchor_intra2.Entity);
            custom_animation_relative(johnson_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra2\\08_intra2", 3832873727U), "johnson_02", false, anchor_intra2.Entity);
            scenery_animation_start_relative(scarab_01.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\08_intra2\\08_intra2", 3833004801U), "scarab_02", anchor_intra2.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c08_intra2_02_cleanup();
            sound_class_set_gain("amb", 0F, 15);
            await sleep(15);
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task c08_intra2()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp0"));
            await sleep(1);
            await this.c08_intra2_scene_01();
            await this.c08_intra2_scene_02();
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_01_fol", 3833332486U), default(IGameObject), 1F);
            print("c08_intra3 foley 01 start");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task c08_4010_tar()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4010_tar", 3833398023U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4010_tar", 4F);
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task c08_4020_tar()
        {
            await sleep(167);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4020_tar", 3833463560U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4020_tar", 3F);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task c08_4030_gsp()
        {
            await sleep(251);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4030_gsp", 3833529097U), monitor.Entity, 1F);
            cinematic_subtitle("c08_4030_gsp", 3F);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task c08_4040_tar()
        {
            await sleep(344);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4040_tar", 3833594634U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4040_tar", 4F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task c08_4050_mir()
        {
            await sleep(486);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4050_mir", 3833660171U), miranda.Entity, 1F);
            cinematic_subtitle("c08_4050_mir", 1F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task c08_4060_tar()
        {
            await sleep(510);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4060_tar", 3833725708U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4060_tar", 3F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task c08_intra3_fov_01()
        {
            await sleep(246);
            camera_set_field_of_view(30F, 0);
            print("fov change: 60 -> 30 over 0 ticks");
            await sleep(105);
            camera_set_field_of_view(60F, 13);
            print("fov change: 30 -> 60 over 13 ticks");
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra3_01()
        {
            cinematic_lighting_set_primary_light(63F, 80F, 0.180392F, 0.168627F, 0.129412F);
            cinematic_lighting_set_secondary_light(-51F, 188F, 0.101961F, 0.2F, 0.301961F);
            cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(tartarus.Entity, true);
            object_uses_cinematic_lighting(brute_01.Entity, true);
            object_uses_cinematic_lighting(brute_02.Entity, true);
            object_uses_cinematic_lighting(brute_03.Entity, true);
            object_uses_cinematic_lighting(brute_04.Entity, true);
            object_uses_cinematic_lighting(monitor.Entity, true);
            object_uses_cinematic_lighting(index.Entity, true);
        }

        [ScriptMethod(111, Lifecycle.Static)]
        public async Task c08_intra3_problem_actors_01()
        {
            print("problem actors");
            object_create_anew(miranda);
            object_create_anew(tartarus);
            object_create_anew(brute_01);
            object_create_anew(brute_02);
            object_create_anew(brute_03);
            object_create_anew(brute_04);
            object_create_anew(monitor);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(tartarus.Entity, true);
            object_cinematic_lod(brute_01.Entity, true);
            object_cinematic_lod(brute_02.Entity, true);
            object_cinematic_lod(brute_03.Entity, true);
            object_cinematic_lod(brute_04.Entity, true);
            object_cinematic_lod(monitor.Entity, true);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task c08_intra2_miranda_emotion_01()
        {
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            await sleep(180);
            unit_set_emotional_state(miranda.Entity, "angry", 0.75F, 30);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task c08_intra2_miranda_emotion_02()
        {
            await sleep(488);
            unit_set_emotional_state(miranda.Entity, "pain", 0.75F, 30);
            await sleep(81);
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 60);
        }

        [ScriptMethod(114, Lifecycle.Static)]
        public async Task c08_intra3_01_setup()
        {
            object_create_anew(index);
            object_create_anew(repository);
            object_cinematic_lod(index.Entity, true);
            object_cinematic_lod(repository.Entity, true);
            wake(new ScriptMethodReference(c08_intra3_foley_01));
            wake(new ScriptMethodReference(c08_4010_tar));
            wake(new ScriptMethodReference(c08_4020_tar));
            wake(new ScriptMethodReference(c08_4030_gsp));
            wake(new ScriptMethodReference(c08_4040_tar));
            wake(new ScriptMethodReference(c08_4050_mir));
            wake(new ScriptMethodReference(c08_4060_tar));
            wake(new ScriptMethodReference(c08_intra2_miranda_emotion_01));
            wake(new ScriptMethodReference(c08_intra2_miranda_emotion_02));
            wake(new ScriptMethodReference(c08_intra3_fov_01));
            wake(new ScriptMethodReference(cinematic_lighting_intra3_01));
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task c08_intra3_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("deltacontrol_intra3");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.c08_intra3_problem_actors_01();
            await this._08_intra3_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_01_fol", 3833332486U));
            await sleep(this.prediction_offset);
            await this.c08_intra3_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_01", default(IUnit), anchor_flag_intra3);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_01", false, anchor_intra3.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_01", false, anchor_intra3.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_01", false, anchor_intra3.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_01", false, anchor_intra3.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_01", false, anchor_intra3.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_01", false, anchor_intra3.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_01", false, anchor_intra3.Entity);
            scenery_animation_start_relative(index.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_01", anchor_intra3.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra3_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_02_mus", 3838772057U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_02_fol", 3838837594U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task c08_intra3_score_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_02_mus", 3838772057U), default(IGameObject), 1F);
            print("c08_intra3 score 02 start");
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_02_fol", 3838837594U), default(IGameObject), 1F);
            print("c08_intra3 foley 02 start");
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task c08_4070_der()
        {
            await sleep(36);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4070_der", 3838903131U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4070_der", 1F);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task c08_4080_tar()
        {
            await sleep(77);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4080_tar", 3838968668U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4080_tar", 3F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task c08_4100_der()
        {
            await sleep(157);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4100_der", 3839034205U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4100_der", 2F);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task c08_4110_tar()
        {
            await sleep(212);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4110_tar", 3839099742U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4110_tar", 3F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task c08_4120_der()
        {
            await sleep(312);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4120_der", 3839165279U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4120_der", 5F);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task c08_4140_tar()
        {
            await sleep(516);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4140_tar", 3839230816U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4140_tar", 4F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task c08_4150_der()
        {
            await sleep(628);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4150_der", 3839296353U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4150_der", 1F);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task c08_4160_der()
        {
            await sleep(681);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4160_der", 3839361890U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4160_der", 3F);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task unhide_dervish()
        {
            time_code_reset();
            await sleep(10);
            print("unhide dervish");
            object_hide(dervish.Entity, false);
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task c08_intra3_02_setup()
        {
            object_create_anew(dervish);
            object_cinematic_lod(dervish.Entity, true);
            object_hide(dervish.Entity, true);
            cinematic_clone_players_weapon(dervish.Entity, "right_hand_elite", "");
            wake(new ScriptMethodReference(c08_intra3_score_02));
            wake(new ScriptMethodReference(c08_intra3_foley_02));
            wake(new ScriptMethodReference(c08_4070_der));
            wake(new ScriptMethodReference(c08_4080_tar));
            wake(new ScriptMethodReference(c08_4100_der));
            wake(new ScriptMethodReference(c08_4110_tar));
            wake(new ScriptMethodReference(c08_4120_der));
            wake(new ScriptMethodReference(c08_4140_tar));
            wake(new ScriptMethodReference(c08_4150_der));
            wake(new ScriptMethodReference(c08_4160_der));
            wake(new ScriptMethodReference(unhide_dervish));
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task c08_intra3_scene_02()
        {
            await this.c08_intra3_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_02", default(IUnit), anchor_flag_intra3);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_02", false, anchor_intra3.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_02", false, anchor_intra3.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_02", false, anchor_intra3.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_02", false, anchor_intra3.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_02", false, anchor_intra3.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_02", false, anchor_intra3.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_02", false, anchor_intra3.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_02", false, anchor_intra3.Entity);
            scenery_animation_start_relative(index.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_02", anchor_intra3.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra3_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_03_fol", 3839492964U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_03_fol", 3839492964U), default(IGameObject), 1F);
            print("c08_intra3 foley 03 start");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task c08_4170_gsp()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4170_gsp", 3839558501U), monitor.Entity, 1F);
            cinematic_subtitle("c08_4170_gsp", 2F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task c08_4180_tar()
        {
            await sleep(41);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4180_tar", 3839624038U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4180_tar", 2F);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task c08_4190_tar()
        {
            await sleep(84);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4190_tar", 3839689575U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4190_tar", 2F);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task c08_4200_jon()
        {
            await sleep(137);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4200_jon", 3839755112U), johnson.Entity, 1F);
            cinematic_subtitle("c08_4200_jon", 1F);
            unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 0);
            print("johnson - angry .5 0");
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task c08_4201_jon()
        {
            await sleep(202);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4201_jon", 3839820649U), johnson.Entity, 1F);
            cinematic_subtitle("c08_4201_jon", 2F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task c08_4220_jon()
        {
            await sleep(308);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4220_jon", 3839886186U), johnson.Entity, 1F);
            cinematic_subtitle("c08_4220_jon", 3F);
            unit_set_emotional_state(johnson.Entity, "angry", 1F, 15);
            print("johnson - angry 1 15");
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task c08_4230_tar()
        {
            await sleep(430);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4230_tar", 3839951723U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4230_tar", 1F);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task c08_4240_jon()
        {
            await sleep(474);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4240_jon", 3840017260U), johnson.Entity, 1F);
            cinematic_subtitle("c08_4240_jon", 2F);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task c08_4250_der()
        {
            await sleep(548);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4250_der", 3840082797U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4250_der", 2F);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task c08_intra3_fov_03()
        {
            await sleep(184);
            camera_set_field_of_view(5F, 21);
            print("fov change: 60 -> 5 over 21 ticks");
            await sleep(69);
            camera_set_field_of_view(60F, 0);
            print("fov change: 5 -> 60 over 0 ticks");
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra3_03()
        {
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(cov_sniper.Entity, true);
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task c08_intra3_03_setup()
        {
            object_create_anew(johnson);
            object_create_anew(cov_sniper);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(cov_sniper.Entity, true);
            objects_attach(johnson.Entity, "right_hand", cov_sniper.Entity, "");
            wake(new ScriptMethodReference(c08_intra3_foley_03));
            wake(new ScriptMethodReference(c08_4170_gsp));
            wake(new ScriptMethodReference(c08_4180_tar));
            wake(new ScriptMethodReference(c08_4190_tar));
            wake(new ScriptMethodReference(c08_4200_jon));
            wake(new ScriptMethodReference(c08_4201_jon));
            wake(new ScriptMethodReference(c08_4220_jon));
            wake(new ScriptMethodReference(c08_4230_tar));
            wake(new ScriptMethodReference(c08_4240_jon));
            wake(new ScriptMethodReference(c08_4250_der));
            wake(new ScriptMethodReference(c08_intra3_fov_03));
            wake(new ScriptMethodReference(cinematic_lighting_intra3_03));
        }

        [ScriptMethod(142, Lifecycle.Static)]
        public async Task c08_intra3_scene_03()
        {
            await this.c08_intra3_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_03", default(IUnit), anchor_flag_intra3);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_03", false, anchor_intra3.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra3\\08_intra3", 3840148334U), "johnson_03", false, anchor_intra3.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_03", false, anchor_intra3.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_03", false, anchor_intra3.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_03", false, anchor_intra3.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_03", false, anchor_intra3.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_03", false, anchor_intra3.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_03", false, anchor_intra3.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_03", false, anchor_intra3.Entity);
            scenery_animation_start_relative(index.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_03", anchor_intra3.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra3_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_04_fol", 3840213871U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_04_fol", 3840213871U), default(IGameObject), 1F);
            print("c08_intra3 foley 04 start");
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task c08_4260_gsp()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4260_gsp", 3840279408U), monitor.Entity, 1F);
            cinematic_subtitle("c08_4260_gsp", 6F);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            print("miranda - shocked .25 0");
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task c08_4270_der()
        {
            await sleep(189);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4270_der", 3840344945U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4270_der", 4F);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task c08_4280_gsp()
        {
            await sleep(297);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4280_gsp", 3840410482U), monitor.Entity, 1F);
            cinematic_subtitle("c08_4280_gsp", 11F);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c08_4290_gsp()
        {
            await sleep(640);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4290_gsp", 3840476019U), monitor.Entity, 1F);
            cinematic_subtitle("c08_4290_gsp", 2F);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task c08_4300_der()
        {
            await sleep(746);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4300_der", 3840541556U), dervish.Entity, 1F);
            cinematic_subtitle("c08_4300_der", 4F);
        }

        [ScriptMethod(149, Lifecycle.Static)]
        public async Task c08_intra3_04_setup()
        {
            wake(new ScriptMethodReference(c08_intra3_foley_04));
            wake(new ScriptMethodReference(c08_4260_gsp));
            wake(new ScriptMethodReference(c08_4270_der));
            wake(new ScriptMethodReference(c08_4280_gsp));
            wake(new ScriptMethodReference(c08_4290_gsp));
            wake(new ScriptMethodReference(c08_4300_der));
        }

        [ScriptMethod(150, Lifecycle.Static)]
        public async Task c08_intra3_scene_04()
        {
            await this.c08_intra3_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_04", default(IUnit), anchor_flag_intra3);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_04", false, anchor_intra3.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra3\\08_intra3", 3840148334U), "johnson_04", false, anchor_intra3.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_04", false, anchor_intra3.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_04", false, anchor_intra3.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_04", false, anchor_intra3.Entity);
            scenery_animation_start_relative(index.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_04", anchor_intra3.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra3_05_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_05_fol", 3840607093U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_05_fol", 3840607093U), default(IGameObject), 1F);
            print("c08_intra3 foley 05 start");
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task c08_4310_jon()
        {
            await sleep(74);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4310_jon", 3840672630U), johnson.Entity, 1F);
            cinematic_subtitle("c08_4310_jon", 1F);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task c08_4320_tar()
        {
            await sleep(106);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4320_tar", 3840738167U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4320_tar", 1F);
            unit_set_emotional_state(miranda.Entity, "pain", 0.5F, 0);
            print("miranda - pain .5 0");
            await sleep(45);
            unit_set_emotional_state(miranda.Entity, "scared", 0.5F, 15);
            print("miranda - scared .5 15");
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task c08_4330_tar()
        {
            await sleep(144);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4330_tar", 3840803704U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4330_tar", 2F);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task c08_4340_tar()
        {
            await sleep(220);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4340_tar", 3840869241U), tartarus.Entity, 1F);
            cinematic_subtitle("c08_4340_tar", 4F);
            object_set_function_variable(tartarus.Entity, "invincibility", 1F, 60F);
            print("tartarus activates shield");
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra3_05()
        {
            object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task index_insertion()
        {
            await sleep(165);
            print("slot the icon");
            device_set_position(repository.Entity, 1F);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\cinematics\\index\\index_insertion", 3840934778U), index.Entity, "");
            await sleep(15);
            object_destroy(index.Entity);
        }

        [ScriptMethod(158, Lifecycle.Static)]
        public async Task c08_intra3_05_setup()
        {
            object_create_anew(hammer);
            object_cinematic_lod(hammer.Entity, true);
            wake(new ScriptMethodReference(c08_intra3_foley_05));
            wake(new ScriptMethodReference(c08_4310_jon));
            wake(new ScriptMethodReference(c08_4320_tar));
            wake(new ScriptMethodReference(c08_4330_tar));
            wake(new ScriptMethodReference(c08_4340_tar));
            wake(new ScriptMethodReference(index_insertion));
            wake(new ScriptMethodReference(cinematic_lighting_intra3_05));
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task c08_intra3_05_cleanup()
        {
            object_destroy(miranda.Entity);
            object_destroy(johnson.Entity);
            object_destroy(monitor.Entity);
            object_destroy(dervish.Entity);
            object_destroy(tartarus.Entity);
            object_destroy(brute_01.Entity);
            object_destroy(brute_02.Entity);
            object_destroy(brute_03.Entity);
            object_destroy(brute_04.Entity);
            object_destroy(repository.Entity);
            object_destroy(index.Entity);
            object_destroy(hammer.Entity);
            object_destroy(cov_sniper.Entity);
        }

        [ScriptMethod(160, Lifecycle.Static)]
        public async Task c08_intra3_scene_05()
        {
            await this.c08_intra3_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_05", default(IUnit), anchor_flag_intra3);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_05", false, anchor_intra3.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra3\\08_intra3", 3840148334U), "johnson_05", false, anchor_intra3.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_05", false, anchor_intra3.Entity);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_05", false, anchor_intra3.Entity);
            custom_animation_relative(tartarus.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_05", false, anchor_intra3.Entity);
            custom_animation_relative(brute_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_05", false, anchor_intra3.Entity);
            custom_animation_relative(brute_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_05", false, anchor_intra3.Entity);
            custom_animation_relative(brute_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_05", false, anchor_intra3.Entity);
            custom_animation_relative(brute_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_05", false, anchor_intra3.Entity);
            scenery_animation_start_relative(hammer.Entity, GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\08_intra3\\08_intra3", 3841524611U), "hammer_05", anchor_intra3.Entity);
            scenery_animation_start_relative(index.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_05", anchor_intra3.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._08_intra3_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_06_mus", 3841590148U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_06_fol", 3841655685U));
            await sleep((short)camera_time());
            wake(new ScriptMethodReference(c08_intra3_05_cleanup));
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task create_lift()
        {
            print("create lift");
            object_create_anew(c08_intra3_lift);
            object_set_function_variable(c08_intra3_lift.Entity, "effect", 0F, 0F);
            await sleep(10);
            object_set_function_variable(c08_intra3_lift.Entity, "effect", 1F, 60F);
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task c08_intra3_scene_06()
        {
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_06_mus", 3841590148U), default(IGameObject), 1F);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_06_fol", 3841655685U), default(IGameObject), 1F);
            device_set_position(e13_boss_platform.Entity, 1F);
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 3F);
            camera_set(platform_01a, 0);
            camera_set(platform_01b, 420);
            await sleep(300);
            wake(new ScriptMethodReference(create_lift));
            await sleep(30);
            camera_set(platform_02, 0);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(5F, 0F, 0F, 0F, 2F, 2F, 0F);
            await sleep(30);
            cinematic_screen_effect_set_depth_of_field(5F, 0F, 2F, 0.5F, 2F, 0F, 0.5F);
            await sleep(45);
            player_effect_stop(1.5F);
            await sleep(15);
            print("fade to white");
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            cinematic_screen_effect_stop();
            object_destroy(c08_intra3_lift.Entity);
            sound_class_set_gain("amb", 0F, 15);
            await sleep(30);
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task c08_intra3()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp3"));
            await sleep(1);
            await this.c08_intra3_scene_01();
            await this.c08_intra3_scene_02();
            await this.c08_intra3_scene_03();
            await this.c08_intra3_scene_04();
            await this.c08_intra3_scene_05();
            await this.c08_intra3_scene_06();
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task x09_foley_1()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_01_fol", 3841721222U), default(IGameObject), 1F);
            print("x09 foley 01 start");
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task x09_01_stop_sounds()
        {
            await sleep(383);
            print("sound looping stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_11", 3830186710U));
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_12", 3830579932U));
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_13", 3830973154U));
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_01()
        {
            cinematic_lighting_set_primary_light(-4F, 206F, 0.454902F, 0.435294F, 0.352941F);
            cinematic_lighting_set_secondary_light(-69F, 234F, 0.152941F, 0.152941F, 0.227451F);
            cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.4F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(rotors_x09.Entity, true);
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task x09_fov_01()
        {
            time_code_reset();
            await sleep(289);
            camera_set_field_of_view(35F, 0);
            print("fov change: 60 -> 35 over 0 ticks");
        }

        [ScriptMethod(168, Lifecycle.Static)]
        public async Task x09_problem_actors_01()
        {
            print("problem actors");
            object_create_anew(miranda);
            object_create_anew(rotors_x09);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(rotors_x09.Entity, true);
        }

        [ScriptMethod(169, Lifecycle.Static)]
        public async Task x09_problem_actors_02()
        {
            print("problem actors");
            object_create_anew(index_x09);
            object_cinematic_lod(index_x09.Entity, true);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_01()
        {
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            await sleep(186);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 30);
            await sleep(71);
            unit_set_emotional_state(miranda.Entity, "pain", 0.5F, 30);
        }

        [ScriptMethod(171, Lifecycle.Static)]
        public async Task x09_01_setup()
        {
            object_destroy(e13_rotors.Entity);
            wake(new ScriptMethodReference(x09_miranda_emotion_01));
            wake(new ScriptMethodReference(x09_01_stop_sounds));
            wake(new ScriptMethodReference(x09_foley_1));
            wake(new ScriptMethodReference(x09_fov_01));
            wake(new ScriptMethodReference(cinematic_lighting_x09_01));
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task x09_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("deltacontrol_1");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this.x09_problem_actors_01();
            await this.x09_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_01_fol", 3841721222U));
            await sleep(this.prediction_offset);
            await sleep(30);
            await this.x09_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_01", default(IUnit), anchor_flag_x09_01);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_01", false, anchor_x09_01.Entity);
            scenery_animation_start_relative(rotors_x09.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_rotors\\x09\\x09", 3841917833U), "control_rotors_01", anchor_x09_01.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x09_02_predict_stub();
            await this.x09_problem_actors_02();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_02_mus", 3841983370U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_02_fol", 3842048907U));
            await sleep((short)camera_time());
            object_destroy(rotors_x09.Entity);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task x09_score_2()
        {
            await sleep(92);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_02_mus", 3841983370U), default(IGameObject), 1F);
            print("x09 score 01 start");
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task x09_foley_2()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_02_fol", 3842048907U), default(IGameObject), 1F);
            print("x09 foley 02 start");
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_02()
        {
            cinematic_lighting_set_primary_light(-18F, 166F, 0.454902F, 0.435294F, 0.352941F);
            cinematic_lighting_set_secondary_light(-10F, 78F, 0.152941F, 0.152941F, 0.227451F);
            cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            object_uses_cinematic_lighting(index_x09.Entity, true);
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task x09_dof_01()
        {
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(0.5F, 1F, 1F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(45);
            cinematic_screen_effect_set_depth_of_field(0.5F, 1F, 0F, 0.25F, 0F, 1F, 0.25F);
            print("rack focus");
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task lift_deactivate()
        {
            await sleep(93);
            print("lift deactivate");
            object_set_function_variable(x09_lift.Entity, "effect", 0F, 90F);
            sound_class_set_gain("device", 0F, 30);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_02()
        {
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            await sleep(137);
            unit_set_emotional_state(miranda.Entity, "scared", 0.5F, 90);
        }

        [ScriptMethod(179, Lifecycle.Static)]
        public async Task x09_02_setup()
        {
            wake(new ScriptMethodReference(x09_score_2));
            wake(new ScriptMethodReference(x09_foley_2));
            wake(new ScriptMethodReference(lift_deactivate));
            wake(new ScriptMethodReference(x09_miranda_emotion_02));
            wake(new ScriptMethodReference(cinematic_lighting_x09_02));
        }

        [ScriptMethod(180, Lifecycle.Static)]
        public async Task x09_scene_02()
        {
            camera_set_field_of_view(60F, 0);
            await this.x09_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_02", default(IUnit), anchor_flag_x09_01);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_02", false, anchor_x09_01.Entity);
            scenery_animation_start_relative(index_x09.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\x09\\x09", 3842114444U), "index_02", anchor_x09_01.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x09_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_03_fol", 3842179981U));
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            cinematic_screen_effect_stop();
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task x09_foley_3()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_03_fol", 3842179981U), default(IGameObject), 1F);
            print("x09 foley 03 start");
        }

        [ScriptMethod(182, Lifecycle.Static)]
        public async Task x09_problem_actors_04()
        {
            print("predict: problem actors");
            object_create_anew(halo);
            object_create_anew(matte_halo);
            object_cinematic_lod(halo.Entity, true);
            object_cinematic_lod(matte_halo.Entity, true);
        }

        [ScriptMethod(183, Lifecycle.Static)]
        public async Task x09_03_setup()
        {
            object_create_anew(x09_halo_bang);
            wake(new ScriptMethodReference(x09_foley_3));
        }

        [ScriptMethod(184, Lifecycle.Static)]
        public async Task x09_scene_03()
        {
            await sleep(15);
            await this.x09_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_03", default(IUnit), anchor_flag_x09_03);
            await sleep(10);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x09_04_predict_stub();
            await this.x09_problem_actors_04();
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_04_fol", 3842245518U));
            await sleep((short)((float)camera_time() - 5));
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task x09_foley_4()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_04_fol", 3842245518U), default(IGameObject), 1F);
            print("x09 foley 04 start");
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_04()
        {
            cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(halo.Entity, true);
        }

        [ScriptMethod(187, Lifecycle.Static)]
        public async Task x09_04_setup()
        {
            object_create_anew(matte_substance);
            object_create_anew(matte_high_charity);
            object_cinematic_lod(matte_substance.Entity, true);
            object_cinematic_lod(matte_high_charity.Entity, true);
            object_create_anew(x09_halo_whimper);
            wake(new ScriptMethodReference(x09_foley_4));
            wake(new ScriptMethodReference(cinematic_lighting_x09_04));
        }

        [ScriptMethod(188, Lifecycle.Static)]
        public async Task x09_scene_04_cleanup()
        {
            object_destroy(halo.Entity);
            object_destroy_containing("matte");
        }

        [ScriptMethod(189, Lifecycle.Static)]
        public async Task x09_scene_04()
        {
            await this.x09_04_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_04", default(IUnit), anchor_flag_x09_02);
            scenery_animation_start_relative(halo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x09\\x09", 3842311055U), "halo_04", anchor_x09_02.Entity);
            scenery_animation_start_relative(matte_halo.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_halo_quarter\\x09\\x09", 3842376592U), "delta_halo_quarter_04", anchor_x09_02.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x09\\x09", 3842442129U), "substance_space_04", anchor_x09_02.Entity);
            scenery_animation_start_relative(matte_high_charity.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\x09\\x09", 3842507666U), "high_charity_exterior_04", anchor_x09_02.Entity);
            await sleep(10);
            fade_in(1F, 1F, 1F, 5);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x09_05_predict_stub();
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_05_fol", 3842573203U));
            await sleep((short)((float)camera_time() - 90));
            fade_out(0F, 0F, 0F, 90);
            await sleep(90);
            await this.x09_scene_04_cleanup();
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task x09_foley_5()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_05_fol", 3842573203U), default(IGameObject), 1F);
            print("x09 foley 05 start");
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task x09_0010_mir()
        {
            await sleep(188);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0010_mir", 3842638740U), miranda.Entity, 1F);
            cinematic_subtitle("x09_0010_mir", 1F);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task x09_0020_gsp()
        {
            await sleep(214);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0020_gsp", 3842704277U), monitor.Entity, 1F);
            cinematic_subtitle("x09_0020_gsp", 1F);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task x09_0030_mir()
        {
            await sleep(251);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0030_mir", 3842769814U), miranda.Entity, 1F);
            cinematic_subtitle("x09_0030_mir", 1F);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task x09_0040_gsp()
        {
            await sleep(280);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0040_gsp", 3842835351U), monitor.Entity, 1F);
            cinematic_subtitle("x09_0040_gsp", 3F);
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task x09_0050_mir()
        {
            await sleep(370);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0050_mir", 3842900888U), miranda.Entity, 1F);
            cinematic_subtitle("x09_0050_mir", 2F);
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task x09_0060_gsp()
        {
            await sleep(419);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0060_gsp", 3842966425U), monitor.Entity, 1F);
            cinematic_subtitle("x09_0060_gsp", 2F);
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task x09_0070_mir()
        {
            await sleep(469);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0070_mir", 3843031962U), miranda.Entity, 1F);
            cinematic_subtitle("x09_0070_mir", 1F);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_05()
        {
            cinematic_lighting_set_primary_light(-18F, 220F, 0.286275F, 0.270588F, 0.219608F);
            cinematic_lighting_set_secondary_light(13F, 176F, 0.152941F, 0.152941F, 0.227451F);
            cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            rasterizer_bloom_override_threshold(0.4F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(monitor.Entity, true);
            object_uses_cinematic_lighting(index_x09.Entity, true);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task beacon_shuffle()
        {
            await sleep(140);
            print("beacon 01 -> beacon 02");
            object_destroy(beacon_01.Entity);
            object_create_anew(beacon_02);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_05()
        {
            await sleep(467);
            unit_set_emotional_state(miranda.Entity, "angry", 0.5F, 30);
        }

        [ScriptMethod(201, Lifecycle.Static)]
        public async Task x09_05_setup()
        {
            object_destroy(e13_rotors.Entity);
            object_destroy(x09_lift.Entity);
            object_create_anew(johnson);
            object_create_anew(monitor);
            object_create_anew(beacon_01);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(monitor.Entity, true);
            unit_set_emotional_state(miranda.Entity, "inquisitive", 1F, 0);
            wake(new ScriptMethodReference(x09_miranda_emotion_05));
            wake(new ScriptMethodReference(x09_foley_5));
            wake(new ScriptMethodReference(x09_0010_mir));
            wake(new ScriptMethodReference(x09_0020_gsp));
            wake(new ScriptMethodReference(x09_0030_mir));
            wake(new ScriptMethodReference(x09_0040_gsp));
            wake(new ScriptMethodReference(x09_0050_mir));
            wake(new ScriptMethodReference(x09_0060_gsp));
            wake(new ScriptMethodReference(x09_0070_mir));
            wake(new ScriptMethodReference(beacon_shuffle));
            wake(new ScriptMethodReference(cinematic_lighting_x09_05));
            interpolator_start("x09_fog", 1F, 1F);
        }

        [ScriptMethod(202, Lifecycle.Static)]
        public async Task x09_scene_05()
        {
            await this.x09_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_05", default(IUnit), anchor_flag_x09_01);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_05", false, anchor_x09_01.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x09\\x09", 3843097499U), "johnson_05", false, anchor_x09_01.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\x09\\x09", 3843163036U), "monitor_05", false, anchor_x09_01.Entity);
            scenery_animation_start_relative(index_x09.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\x09\\x09", 3842114444U), "index_05", anchor_x09_01.Entity);
            await sleep(15);
            fade_in(0F, 0F, 0F, 90);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x09_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_06_fol", 3843228573U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task x09_foley_6()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_06_fol", 3843228573U), default(IGameObject), 1F);
            print("x09 foley 06 start");
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task x09_0080_gsp()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0080_gsp", 3843294110U), monitor.Entity, 1F);
            cinematic_subtitle("x09_0080_gsp", 10F);
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task x09_0090_mir()
        {
            await sleep(310);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0090_mir", 3843359647U), miranda.Entity, 1F);
            cinematic_subtitle("x09_0090_mir", 2F);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task x09_0100_gsp()
        {
            await sleep(386);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0100_gsp", 3843425184U), monitor.Entity, 1F);
            cinematic_subtitle("x09_0100_gsp", 1F);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task x09_0110_jon()
        {
            await sleep(430);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0110_jon", 3843490721U), johnson.Entity, 1F);
            cinematic_subtitle("x09_0110_jon", 2F);
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task x09_0120_mir()
        {
            await sleep(494);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0120_mir", 3843556258U), miranda.Entity, 1F);
            cinematic_subtitle("x09_0120_mir", 4F);
            await sleep(30);
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task x09_0130_gsp()
        {
            await sleep(675);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0130_gsp", 3843621795U), monitor.Entity, 1F);
            cinematic_subtitle("x09_0130_gsp", 2F);
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task x09_0140_der()
        {
            await sleep(742);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0140_der", 3843687332U), dervish.Entity, 1F);
            cinematic_subtitle("x09_0140_der", 3F);
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_06()
        {
            cinematic_lighting_set_primary_light(-18F, 220F, 0.286275F, 0.270588F, 0.219608F);
            cinematic_lighting_set_secondary_light(13F, 176F, 0.152941F, 0.152941F, 0.227451F);
            cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            object_uses_cinematic_lighting(dervish.Entity, true);
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_06a()
        {
            await sleep(310);
            unit_set_emotional_state(miranda.Entity, "scared", 0.5F, 60);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_06b()
        {
            await sleep(525);
            unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 90);
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_06c()
        {
            await sleep(776);
            unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 30);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task x09_johnson_emotion_06a()
        {
            await sleep(440);
            unit_set_emotional_state(johnson.Entity, "angry", 0.75F, 60);
            await sleep(54);
            unit_set_emotional_state(johnson.Entity, "shocked", 0.25F, 30);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task x09_johnson_emotion_06b()
        {
            await sleep(784);
            unit_set_emotional_state(johnson.Entity, "shocked", 0.25F, 30);
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task x09_06_setup()
        {
            object_destroy(beacon_02.Entity);
            object_create_anew(beacon_03);
            device_set_position(beacon_03.Entity, 1F);
            object_create_anew(dervish);
            object_cinematic_lod(dervish.Entity, true);
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            unit_set_emotional_state(johnson.Entity, "angry", 0.25F, 0);
            wake(new ScriptMethodReference(x09_miranda_emotion_06a));
            wake(new ScriptMethodReference(x09_miranda_emotion_06b));
            wake(new ScriptMethodReference(x09_miranda_emotion_06c));
            wake(new ScriptMethodReference(x09_johnson_emotion_06a));
            wake(new ScriptMethodReference(x09_johnson_emotion_06b));
            wake(new ScriptMethodReference(x09_foley_6));
            wake(new ScriptMethodReference(x09_0080_gsp));
            wake(new ScriptMethodReference(x09_0090_mir));
            wake(new ScriptMethodReference(x09_0100_gsp));
            wake(new ScriptMethodReference(x09_0110_jon));
            wake(new ScriptMethodReference(x09_0120_mir));
            wake(new ScriptMethodReference(x09_0130_gsp));
            wake(new ScriptMethodReference(x09_0140_der));
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task x09_scene_06_cleanup()
        {
            object_destroy(dervish.Entity);
            object_destroy(miranda.Entity);
            object_destroy(johnson.Entity);
            object_destroy(monitor.Entity);
            object_destroy(index_x09.Entity);
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task x09_scene_06()
        {
            await this.x09_06_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_06", default(IUnit), anchor_flag_x09_01);
            custom_animation_relative(dervish.Entity, GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x09\\x09", 3843752869U), "dervish_06", false, anchor_x09_01.Entity);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_06", false, anchor_x09_01.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\x09\\x09", 3843097499U), "johnson_06", false, anchor_x09_01.Entity);
            custom_animation_relative(monitor.Entity, GetTag<AnimationGraphTag>("objects\\characters\\monitor\\x09\\x09", 3843163036U), "monitor_06", false, anchor_x09_01.Entity);
            scenery_animation_start_relative(index_x09.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\x09\\x09", 3842114444U), "index_06", anchor_x09_01.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x09_07_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_07_fol", 3843818406U));
            await sleep((short)((float)camera_time() - 5));
            fade_out(0F, 0F, 0F, 5);
            await sleep(5);
            await this.x09_scene_06_cleanup();
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task x09_foley_7()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_07_fol", 3843818406U), default(IGameObject), 1F);
            print("x09 foley 07 start");
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task x09_0150_to1()
        {
            await sleep(100);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0150_to1", 3843883943U), default(IGameObject), 1F, "radio_default_in");
            cinematic_subtitle("x09_0150_to1", 3F);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_07()
        {
            cinematic_lighting_set_primary_light(16F, -32F, 0.8F, 0.6F, 0.4F);
            cinematic_lighting_set_secondary_light(20F, 180F, 0.3F, 0.3F, 0.5F);
            cinematic_lighting_set_ambient_light(0.2F, 0.2F, 0.2F);
            object_uses_cinematic_lighting(forerunner_ship.Entity, true);
        }

        [ScriptMethod(223, Lifecycle.Static)]
        public async Task x09_problem_actors_08()
        {
            print("problem actors");
            object_create_anew(chief);
            object_create_anew(x09_alcove);
            object_create_anew(bloom_quad);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(x09_alcove.Entity, true);
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task x09_07_setup()
        {
            object_create_anew(slipspace);
            object_create_anew_containing("earth_battle");
            object_create_anew(forerunner_ship);
            object_create_anew(matte_earth);
            object_create_anew(matte_moon);
            object_cinematic_lod(forerunner_ship.Entity, true);
            object_cinematic_lod(matte_earth.Entity, true);
            object_cinematic_lod(matte_moon.Entity, true);
            wake(new ScriptMethodReference(x09_foley_7));
            wake(new ScriptMethodReference(x09_0150_to1));
            wake(new ScriptMethodReference(cinematic_lighting_x09_07));
        }

        [ScriptMethod(225, Lifecycle.Static)]
        public async Task x09_scene_07_cleanup()
        {
            object_destroy(slipspace.Entity);
            object_destroy_containing("earth_battle");
            object_destroy(forerunner_ship.Entity);
            object_destroy_containing("matte");
        }

        [ScriptMethod(226, Lifecycle.Static)]
        public async Task x09_scene_07()
        {
            await sleep(60);
            await this.x09_07_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_07", default(IUnit), anchor_flag_x09_02);
            scenery_animation_start_relative(forerunner_ship.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\x09\\x09", 3843949480U), "forerunner_ship_07", anchor_x09_02.Entity);
            scenery_animation_start_relative(cairo.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\x09\\x09", 3844015017U), "ss_prop_07", anchor_x09_02.Entity);
            scenery_animation_start_relative(matte_earth.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\x09\\x09", 3844080554U), "earth_space_07", anchor_x09_02.Entity);
            scenery_animation_start_relative(matte_moon.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\moon\\x09\\x09", 3844146091U), "moon_07", anchor_x09_02.Entity);
            fade_in(0F, 0F, 0F, 5);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x09_08_predict_stub();
            await this.x09_problem_actors_08();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_08_mus", 3844211628U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_03_fol", 3842179981U));
            await sleep((short)((float)camera_time() - 5));
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
            await this.x09_scene_07_cleanup();
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task x09_score_8()
        {
            await sleep(338);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_08_mus", 3844211628U), default(IGameObject), 1F);
            print("x09 score 08 start");
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task x09_foley_8()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_08_fol", 3844277165U), default(IGameObject), 1F);
            print("x09 foley 08 start");
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task x09_0160_lhd()
        {
            await sleep(0);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0160_lhd", 3844342702U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("x09_0160_lhd", 2F);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task x09_0180_mas()
        {
            await sleep(69);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0180_mas", 3844408239U), chief.Entity, 1F);
            cinematic_subtitle("x09_0180_mas", 2F);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task x09_0190_mas()
        {
            await sleep(132);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0190_mas", 3844473776U), default(IGameObject), 1F, "radio_default_out");
            cinematic_subtitle("x09_0190_mas", 2F);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task x09_0200_lhd()
        {
            await sleep(183);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0200_lhd", 3844539313U), hood.Entity, 1F);
            cinematic_subtitle("x09_0200_lhd", 1F);
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task x09_0210_lhd()
        {
            await sleep(232);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0210_lhd", 3844604850U), hood.Entity, 1F);
            cinematic_subtitle("x09_0210_lhd", 3F);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task x09_0220_mas()
        {
            await sleep(342);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0220_mas", 3844670387U), chief.Entity, 1F);
            cinematic_subtitle("x09_0220_mas", 3F);
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task cinematic_light_x09_chief_01()
        {
            print("light chief 01");
            cinematic_lighting_set_primary_light(-20F, 278F, 0.388235F, 0.427451F, 0.494118F);
            cinematic_lighting_set_secondary_light(42F, 224F, 0.0431373F, 0.0431373F, 0.0666667F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(hood.Entity, true);
            object_uses_cinematic_lighting(cairo_bridge.Entity, true);
            object_uses_cinematic_lighting(x09_alcove.Entity, true);
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task cinematic_light_x09_hood_01()
        {
            await sleep(124);
            print("light hood 01");
            cinematic_lighting_set_primary_light(0F, 94F, 0.47451F, 0.443137F, 0.333333F);
            cinematic_lighting_set_secondary_light(0F, 320F, 0.184314F, 0.176471F, 0.266667F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            rasterizer_bloom_override_threshold(0.75F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task final_explosion()
        {
            time_code_reset();
            await sleep(135);
            object_create_anew_containing("blast_base");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 3844735924U), blast_base.Entity, "marker");
            await sleep(110);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 3844735924U), blast_base2.Entity, "marker");
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task cinematic_light_x09_chief_02()
        {
            await sleep(277);
            print("light chief 02");
            cinematic_lighting_set_primary_light(-20F, 278F, 0.388235F, 0.427451F, 0.494118F);
            cinematic_lighting_set_secondary_light(42F, 224F, 0.0431373F, 0.0431373F, 0.0666667F);
            cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task x09_hood_emotion_08()
        {
            await sleep(43);
            unit_set_emotional_state(hood.Entity, "shocked", 0.5F, 30);
            await sleep(45);
            unit_set_emotional_state(hood.Entity, "happy", 0.25F, 90);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task shake_chief()
        {
            print("shake");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.75F, 0F);
            await sleep(15);
            player_effect_stop(3F);
        }

        [ScriptMethod(241, Lifecycle.Static)]
        public async Task x09_08_setup()
        {
            object_create_anew(hood);
            object_create_anew(cairo_bridge);
            object_cinematic_lod(hood.Entity, true);
            object_cinematic_lod(cairo_bridge.Entity, true);
            object_create_anew_containing("cairo_effect");
            unit_set_emotional_state(hood.Entity, "angry", 0.5F, 0);
            wake(new ScriptMethodReference(x09_hood_emotion_08));
            wake(new ScriptMethodReference(x09_score_8));
            wake(new ScriptMethodReference(x09_foley_8));
            wake(new ScriptMethodReference(x09_0160_lhd));
            wake(new ScriptMethodReference(x09_0180_mas));
            wake(new ScriptMethodReference(x09_0190_mas));
            wake(new ScriptMethodReference(x09_0200_lhd));
            wake(new ScriptMethodReference(x09_0210_lhd));
            wake(new ScriptMethodReference(x09_0220_mas));
            wake(new ScriptMethodReference(shake_chief));
            wake(new ScriptMethodReference(final_explosion));
            wake(new ScriptMethodReference(cinematic_light_x09_chief_01));
            wake(new ScriptMethodReference(cinematic_light_x09_hood_01));
            wake(new ScriptMethodReference(cinematic_light_x09_chief_02));
        }

        [ScriptMethod(242, Lifecycle.Static)]
        public async Task x09_scene_08_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(hood.Entity);
            object_destroy(cairo_bridge.Entity);
            object_destroy(x09_alcove.Entity);
            object_destroy(bloom_quad.Entity);
            object_destroy_containing("blast_base");
        }

        [ScriptMethod(243, Lifecycle.Static)]
        public async Task x09_scene_08()
        {
            await this.x09_08_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_08", default(IUnit), anchor_flag_x09_02);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x09\\x09", 3845194683U), "chief_08", false, anchor_x09_02.Entity);
            custom_animation_relative(hood.Entity, GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x09\\x09", 3845260220U), "hood_08", false, anchor_x09_02.Entity);
            scenery_animation_start_relative(cairo_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge\\x09\\x09", 3845391294U), "cairo_bridge_08", anchor_x09_02.Entity);
            scenery_animation_start_relative(x09_alcove.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\x09\\x09", 3845456831U), "alcove_08", anchor_x09_02.Entity);
            scenery_animation_start_relative(bloom_quad.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\special\\bloom_quad\\x09\\x09", 3845522368U), "bloom_quad_08", anchor_x09_02.Entity);
            await sleep(10);
            fade_in(1F, 1F, 1F, 5);
            await sleep((short)((float)camera_time() - 5));
            fade_out(0F, 0F, 0F, 5);
            await sleep(5);
            await sleep(401);
            await this.x09_scene_08_cleanup();
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task x10_score_1()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\music\\x10_01_mus", 3845587905U), default(IGameObject), 1F);
            print("x10 score 01 start");
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task x10_foley_1()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\foley\\x10_01_fol", 3845653442U), default(IGameObject), 1F);
            print("x10 foley 01 start");
        }

        [ScriptMethod(246, Lifecycle.Dormant)]
        public async Task x10_0010_grv()
        {
            await sleep(496);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0010_grv", 3845718979U), default(IGameObject), 1F);
            cinematic_subtitle("x10_0010_grv", 6F);
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x10_01()
        {
            cinematic_lighting_set_primary_light(51F, 28F, 0.380392F, 0.384314F, 0.341176F);
            cinematic_lighting_set_secondary_light(-53F, 202F, 0.0588235F, 0.356863F, 0.356863F);
            cinematic_lighting_set_ambient_light(0.0901961F, 0.117647F, 0.0823529F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(tentacle_01.Entity, true);
            object_uses_cinematic_lighting(tentacle_02.Entity, true);
            object_uses_cinematic_lighting(tentacle_03.Entity, true);
            object_uses_cinematic_lighting(tentacle_04.Entity, true);
        }

        [ScriptMethod(248, Lifecycle.Static)]
        public async Task x10_problem_actors_01()
        {
            print("problem actors");
            object_create_anew(spore_01);
            object_create_anew(spore_02);
            object_create_anew(spore_03);
            object_cinematic_lod(spore_01.Entity, true);
            object_cinematic_lod(spore_02.Entity, true);
            object_cinematic_lod(spore_03.Entity, true);
        }

        [ScriptMethod(249, Lifecycle.Static)]
        public async Task x10_scene_01_setup()
        {
            object_create_anew(x09_chamber_door);
            object_create_anew(tentacle_01);
            object_create_anew(tentacle_02);
            object_create_anew(tentacle_03);
            object_create_anew(tentacle_04);
            object_cinematic_lod(x09_chamber_door.Entity, true);
            object_cinematic_lod(tentacle_01.Entity, true);
            object_cinematic_lod(tentacle_02.Entity, true);
            object_cinematic_lod(tentacle_03.Entity, true);
            object_cinematic_lod(tentacle_04.Entity, true);
            object_cinematic_visibility(tentacle_01.Entity, true);
            object_cinematic_visibility(tentacle_02.Entity, true);
            object_cinematic_visibility(tentacle_03.Entity, true);
            object_cinematic_visibility(tentacle_04.Entity, true);
            wake(new ScriptMethodReference(x10_score_1));
            wake(new ScriptMethodReference(x10_foley_1));
            wake(new ScriptMethodReference(x10_0010_grv));
            wake(new ScriptMethodReference(cinematic_lighting_x10_01));
        }

        [ScriptMethod(250, Lifecycle.Static)]
        public async Task x10_scene_01_cleanup()
        {
            object_destroy(x09_chamber_door.Entity);
            object_destroy_containing("spore");
        }

        [ScriptMethod(251, Lifecycle.Static)]
        public async Task x10_scene_01()
        {
            fade_out(0F, 0F, 0F, 0);
            camera_control(true);
            cinematic_start_movie("deltacontrol_2");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            weather_start(0F);
            weather_change_intensity(0F, 1F);
            await this.x10_problem_actors_01();
            await this.x10_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\music\\x10_01_mus", 3845587905U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\foley\\x10_01_fol", 3845653442U));
            await sleep(this.prediction_offset);
            await this.x10_scene_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x10\\x10", 3845784516U), "x10_01", default(IUnit), anchor_flag_x10);
            scenery_animation_start_relative(x09_chamber_door.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\x10\\x10", 3845850053U), "high_door_grand_01", anchor_x10.Entity);
            scenery_animation_start_relative(spore_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\flood\\flood_spore\\x10\\x10", 3845915590U), "spore01_01", anchor_x10.Entity);
            scenery_animation_start_relative(spore_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\flood\\flood_spore\\x10\\x10", 3845915590U), "spore02_01", anchor_x10.Entity);
            scenery_animation_start_relative(spore_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\flood\\flood_spore\\x10\\x10", 3845915590U), "spore03_01", anchor_x10.Entity);
            scenery_animation_start_relative(tentacle_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle01_01", anchor_x10.Entity);
            scenery_animation_start_relative(tentacle_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle02_01", anchor_x10.Entity);
            scenery_animation_start_relative(tentacle_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle03_01", anchor_x10.Entity);
            fade_in(0F, 0F, 0F, 60);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this.x10_02_predict_stub();
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - 1));
            cinematic_screen_effect_set_crossfade(2F);
            await sleep(1);
            await this.x10_scene_01_cleanup();
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task x10_score_2()
        {
            await sleep(553);
            sound_looping_start(GetTag<LoopingSoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\music\\x10_02_mus", 3846046664U), default(IGameObject), 1F);
            print("x10 score 02 start");
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task x10_0020_grv()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0020_grv", 3846243275U), default(IGameObject), 1F);
            cinematic_subtitle("x10_0020_grv", 8F);
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task x10_0030_grv()
        {
            await sleep(260);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0030_grv", 3846308812U), default(IGameObject), 1F);
            cinematic_subtitle("x10_0030_grv", 5F);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task x10_0040_cor()
        {
            await sleep(496);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0040_cor", 3846374349U), cortana.Entity, 1F);
            cinematic_subtitle("x10_0040_cor", 1F);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task x10_0041_cor()
        {
            await sleep(520);
            unit_set_emotional_state(cortana.Entity, "pain", 0.25F, 60);
            print("cortana - pain .25 60");
            await sleep(30);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0041_cor", 3846439886U), cortana.Entity, 1F);
            cinematic_subtitle("x10_0041_cor", 1F);
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x10_02()
        {
            cinematic_lighting_set_primary_light(51F, 28F, 0.380392F, 0.384314F, 0.341176F);
            cinematic_lighting_set_secondary_light(-53F, 202F, 0.0588235F, 0.356863F, 0.356863F);
            cinematic_lighting_set_ambient_light(0.0901961F, 0.117647F, 0.0823529F);
            object_uses_cinematic_lighting(cortana.Entity, true);
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task effect_cortana_appear()
        {
            await sleep(410);
            print("cortana appears");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 3846505423U), cortana_stand.Entity, "marker");
        }

        [ScriptMethod(259, Lifecycle.Static)]
        public async Task x10_scene_02_setup()
        {
            object_create_anew(cortana);
            object_cinematic_lod(cortana.Entity, true);
            object_create_anew(cortana_stand);
            unit_set_emotional_state(cortana.Entity, "repulsed", 0.5F, 0);
            print("cortana - repulsed .5 0");
            wake(new ScriptMethodReference(x10_score_2));
            wake(new ScriptMethodReference(x10_0020_grv));
            wake(new ScriptMethodReference(x10_0030_grv));
            wake(new ScriptMethodReference(x10_0040_cor));
            wake(new ScriptMethodReference(x10_0041_cor));
            wake(new ScriptMethodReference(effect_cortana_appear));
            wake(new ScriptMethodReference(cinematic_lighting_x10_02));
            cinematic_set_near_clip_distance(0.05F);
            print("setting near clip distance to .05");
        }

        [ScriptMethod(260, Lifecycle.Static)]
        public async Task x10_scene_02_cleanup()
        {
            object_destroy_containing("cortana");
            object_destroy_containing("tentacle");
        }

        [ScriptMethod(261, Lifecycle.Static)]
        public async Task x10_scene_02()
        {
            time_code_reset();
            await this.x10_scene_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x10\\x10", 3845784516U), "x10_02", default(IUnit), anchor_flag_x10);
            custom_animation_relative(cortana.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x10\\x10", 3847357404U), "cortana_02", false, anchor_x10.Entity);
            scenery_animation_start_relative(tentacle_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle01_02", anchor_x10.Entity);
            scenery_animation_start_relative(tentacle_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle02_02", anchor_x10.Entity);
            scenery_animation_start_relative(tentacle_03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle03_02", anchor_x10.Entity);
            scenery_animation_start_relative(tentacle_04.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle04_02", anchor_x10.Entity);
            await sleep((short)((float)camera_time() - 5));
            fade_out(0F, 0F, 0F, 5);
            await sleep(5);
            cinematic_set_near_clip_distance(0.06F);
            print("setting near clip distance to .06");
            await sleep(328);
        }

        [ScriptMethod(262, Lifecycle.Static)]
        public async Task x10()
        {
            switch_bsp_by_name(GetReference<IBsp>("high_0"));
            await sleep(1);
            await this.x10_scene_01();
            await this.x10_scene_02();
        }

        [ScriptMethod(263, Lifecycle.Static)]
        public async Task x09()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp4"));
            await sleep(1);
            sound_class_set_gain("amb", 0F, 15);
            await this.x09_scene_01();
            await this.x09_scene_02();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp0"));
            await sleep(1);
            await this.x09_scene_03();
            await this.x09_scene_04();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp4"));
            await sleep(1);
            await this.x09_scene_05();
            await this.x09_scene_06();
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp0"));
            await sleep(1);
            await this.x09_scene_07();
            await this.x09_scene_08();
            await sleep(90);
            print("90 ticks of black instead of credits");
            await this.x10();
            await sleep(30);
            print("30 ticks of black for marty2");
            game_won();
        }

        [ScriptMethod(264, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) || (bool)game_is_cooperative() && unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(265, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return unit_in_vehicle(unit(await this.player0())) && !((bool)game_is_cooperative()) || unit_in_vehicle(unit(await this.player1()));
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task chapter_title0()
        {
            await sleep(30);
            cinematic_set_title(title0);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task chapter_title1()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task chapter_title2()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(269, Lifecycle.Static)]
        public async Task cinematic_intro()
        {
            if (await this.cinematic_skip_start())
            {
                await this.c08_intra1();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(270, Lifecycle.Static)]
        public async Task cinematic_johnson_ledge()
        {
            if (await this.cinematic_skip_start())
            {
                await this.c08_intra2();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(271, Lifecycle.Static)]
        public async Task cinematic_tartarus_fight()
        {
            if (await this.cinematic_skip_start())
            {
                await this.c08_intra3();
            }

            await this.cinematic_skip_stop();
        }

        [ScriptMethod(272, Lifecycle.Static)]
        public async Task cinematic_epilogue()
        {
            await this.x09();
        }

        [ScriptMethod(273, Lifecycle.Dormant)]
        public async Task objective0_set()
        {
            await sleep(30);
            objectives_show_up_to(0);
        }

        [ScriptMethod(274, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            objectives_finish_up_to(0);
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await sleep(30);
            objectives_show_up_to(1);
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            objectives_finish_up_to(1);
        }

        [ScriptMethod(277, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await sleep(30);
            objectives_show_up_to(2);
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            objectives_finish_up_to(2);
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await sleep(30);
            objectives_show_up_to(3);
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task objective3_clear()
        {
            objectives_finish_up_to(3);
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task objective4_set()
        {
            await sleep(180);
            objectives_show_up_to(4);
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task objective4_clear()
        {
            objectives_finish_up_to(4);
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task music_08b_01_stop()
        {
            print("music 08b_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_01", 3847488478U));
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task music_08b_01_start_alt()
        {
            print("music 08b_01 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_01", 3847488478U), true);
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task music_08b_01_start()
        {
            print("music 08b_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_01", 3847488478U), default(IGameObject), 1F);
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task music_08b_02_stop()
        {
            print("music 08b_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_02", 3848537070U));
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task music_08b_02_start()
        {
            print("music 08b_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_02", 3848537070U), default(IGameObject), 1F);
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task music_08b_03_stop()
        {
            print("music 08b_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_03", 3848930292U));
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task music_08b_03_start()
        {
            print("music 08b_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_03", 3848930292U), default(IGameObject), 1F);
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task music_08b_04_stop()
        {
            print("music 08b_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_04", 3849323514U));
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task music_08b_04_start()
        {
            print("music 08b_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_04", 3849323514U), default(IGameObject), 1F);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task music_08b_05_stop()
        {
            print("music 08b_05 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_05", 3849847810U));
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task music_08b_05_start_alt()
        {
            print("music 08b_05 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_05", 3849847810U), true);
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task music_08b_05_start()
        {
            print("music 08b_05 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_05", 3849847810U), default(IGameObject), 1F);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task music_08b_06_start()
        {
            print("music 08b_06 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_06", 3850634254U), default(IGameObject), 1F);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task music_08b_07_start()
        {
            print("music 08b_07 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_07", 3850896402U), default(IGameObject), 1F);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task music_08b_08_start()
        {
            print("music 08b_08 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_08", 3851158550U), default(IGameObject), 1F);
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task music_08b_09_stop()
        {
            print("music 08b_09 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_09", 3851420698U));
        }

        [ScriptMethod(299, Lifecycle.Dormant)]
        public async Task music_08b_09_start_alt()
        {
            print("music 08b_09 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_09", 3851420698U), true);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task music_08b_09_start()
        {
            print("music 08b_09 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_09", 3851420698U), default(IGameObject), 1F);
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task music_08b_10_stop()
        {
            print("music 08b_10 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_10", 3851813920U));
        }

        [ScriptMethod(302, Lifecycle.Dormant)]
        public async Task music_08b_10_start()
        {
            print("music 08b_10 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_10", 3851813920U), default(IGameObject), 1F);
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task scarab_idle_var0()
        {
            print("scarab_idle_var0");
            device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task scarab_idle_firing()
        {
            print("scarab_idle_var0");
            device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task scarab_idle_var0_no_block()
        {
            print("scarab_idle_var0");
            device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
        }

        [ScriptMethod(306, Lifecycle.Static)]
        public async Task scarab_idle_to_walk_front()
        {
            print("scarab_idle_to_walk_front");
            device_set_position_track(scarab.Entity, "combat:idle:2:walk_front", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task scarab_walk_front_var0()
        {
            print("scarab_walk_front_var0");
            device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(308, Lifecycle.Static)]
        public async Task scarab_walk_front_to_idle()
        {
            print("scarab_walk_front_to_idle");
            device_set_position_track(scarab.Entity, "combat:walk_front:2:idle", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(309, Lifecycle.Static)]
        public async Task scarab_idle_turn_15_left()
        {
            print("scarab_idle_turn_15_left");
            device_set_position_track(scarab.Entity, "combat:turn_15_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(310, Lifecycle.Static)]
        public async Task scarab_idle_turn_15_right()
        {
            print("scarab_idle_turn_15_right");
            device_set_position_track(scarab.Entity, "combat:turn_15_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(311, Lifecycle.Static)]
        public async Task scarab_idle_turn_15_right_slow()
        {
            print("scarab_idle_turn_15_right_slow");
            device_set_position_track(scarab.Entity, "combat:turn_15_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_left()
        {
            print("scarab_idle_turn_22_left");
            device_set_position_track(scarab.Entity, "combat:turn_22_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(313, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_right()
        {
            print("scarab_idle_turn_22_right");
            device_set_position_track(scarab.Entity, "combat:turn_22_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_right_slow()
        {
            print("scarab_idle_turn_22_right_slow");
            device_set_position_track(scarab.Entity, "combat:turn_22_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(315, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_left()
        {
            print("scarab_idle_turn_45_left");
            device_set_position_track(scarab.Entity, "combat:turn_45_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_right()
        {
            print("scarab_idle_turn_45_right");
            device_set_position_track(scarab.Entity, "combat:turn_45_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_right_slow()
        {
            print("scarab_idle_turn_45_right_slow");
            device_set_position_track(scarab.Entity, "combat:turn_45_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_left()
        {
            print("scarab_walk_front_turn_15_left");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_right()
        {
            print("scarab_walk_front_turn_15_right");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_22_left()
        {
            print("scarab_walk_front_turn_22_left");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_22_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(321, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_22_right()
        {
            print("scarab_walk_front_turn_22_right");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_22_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(322, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_left()
        {
            print("scarab_walk_front_turn_45_left");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(323, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_right()
        {
            print("scarab_walk_front_turn_45_right");
            device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(324, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_left()
        {
            print("scarab_idle_to_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_right()
        {
            print("scarab_idle_to_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task scarab_twist_5_left()
        {
            print("scarab_twist_5_left");
            device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(327, Lifecycle.Static)]
        public async Task scarab_twist_5_left_firing()
        {
            print("scarab_twist_5_left");
            device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(328, Lifecycle.Static)]
        public async Task scarab_twist_5_right()
        {
            print("scarab_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(329, Lifecycle.Static)]
        public async Task scarab_twist_5_right_firing()
        {
            print("scarab_twist_5_right");
            device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(330, Lifecycle.Static)]
        public async Task scarab_twist_5_left_to_idle()
        {
            print("scarab_twist_5_left_to_idle");
            device_set_position_track(scarab.Entity, "combat:twist_5_left_to_idle", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(331, Lifecycle.Static)]
        public async Task scarab_twist_5_right_to_idle()
        {
            print("scarab_twist_5_left_to_idle");
            device_set_position_track(scarab.Entity, "combat:twist_5_right_to_idle", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(332, Lifecycle.Static)]
        public async Task scarab_gun_open_up()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_open");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(333, Lifecycle.Static)]
        public async Task scarab_gun_fire_up()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire");
            device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(334, Lifecycle.Static)]
        public async Task scarab_gun_close_up()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_close");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(335, Lifecycle.Static)]
        public async Task scarab_gun_open_down()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_down_open");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(336, Lifecycle.Static)]
        public async Task scarab_gun_fire_down()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_down");
            device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(337, Lifecycle.Static)]
        public async Task scarab_gun_fire_down_abort()
        {
            device_animate_overlay(scarab.Entity, 0F, 3F, 0F, 0F);
        }

        [ScriptMethod(338, Lifecycle.Static)]
        public async Task scarab_gun_close_down()
        {
            device_set_overlay_track(scarab.Entity, "combat:fire_down_close");
            device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(339, Lifecycle.Dormant)]
        public async Task e13_main()
        {
            this.g_e13_started = true;
            game_save();
            print("e13_main");
            data_mine_set_mission_segment("e13_control_room");
            device_operates_automatically_set(e12_door0.Entity, false);
            await this.tartarus_boss_fight();
            wake(new ScriptMethodReference(objective3_clear));
            this.g_mission_over = true;
        }

        [ScriptMethod(340, Lifecycle.Dormant)]
        public async Task e13_cinematic_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e13_cutscene_trigger1, players()) || volume_test_objects(tv_e13_cutscene_trigger0, players()) && objects_can_see_flag(players(), e13_cutscene_trigger, 15F), 15);
            await this.cinematic_fade_to_white();
            object_teleport(await this.player0(), player0_stash);
            object_teleport(await this.player1(), player1_stash);
            await this.cinematic_tartarus_fight();
            sound_suppress_ambience_update_on_revert();
            sound_class_set_gain("amb", 0F, 0);
            await sleep(1);
            sound_class_set_gain("amb", 1F, 15);
            switch_bsp_by_name(GetReference<IBsp>("deltacontrolroom_bsp4"));
            wake(new ScriptMethodReference(e13_main));
            await this.cinematic_fade_from_white();
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_phantom0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p1"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p1_1"));
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p1_2"));
            cs_fly_to(GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p2"));
            cs_face(true, GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p2_facing"));
            cs_fly_to(GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p3"), 1F);
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), true);
            await sleep(30);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_a01");
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_a02");
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_a03");
            await sleep(45);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_b01");
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_b02");
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_b03");
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get(this.ai_current_actor), false);
            cs_face(false, GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p2_facing"));
            cs_fly_to(GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p4"));
            cs_face(true, GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p4_facing"));
            cs_enable_targeting(true);
            cs_enable_moving(true);
            await sleep_until(async () => (short)structure_bsp_index() == 2, 15);
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_1_wait()
        {
            cs_crouch(true);
            await sleep_until(async () => (bool)ai_trigger_test("e12_pro_inf0_sighted_player", e12_pro_inf0), 15);
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_wait0()
        {
            cs_crouch(true);
            cs_face(true, GetReference<ISpatialPoint>("e12_patrol/s0"));
            await sleep_until(async () => device_get_position(e12_door0.Entity) > 0F, 15);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e12_patrol/s0"));
            await sleep(30);
            cs_go_to(GetReference<ISpatialPoint>("e12_patrol/p0"));
            await sleep(30);
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_wait1()
        {
            cs_crouch(true);
            cs_face(true, GetReference<ISpatialPoint>("e12_patrol/s1"));
            await sleep_until(async () => device_get_position(e12_door0.Entity) > 0F, 15);
            cs_shoot_point(true, GetReference<ISpatialPoint>("e12_patrol/s1"));
            await sleep(30);
            cs_go_to(GetReference<ISpatialPoint>("e12_patrol/p1"));
            await sleep(30);
        }

        [ScriptMethod(345, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_look()
        {
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_follow()
        {
            await sleep(1);
        }

        [ScriptMethod(347, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_captain()
        {
            cs_enable_targeting(true);
            cs_enable_moving(true);
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) > this.ai_combat_status_active);
            cs_enable_moving(false);
            cs_look_player(true);
            await sleep((short)random_range(15, 30));
            print("cpn: do not let them enter!");
            await sleep(ai_play_line(this.ai_current_actor, "0940"));
            await sleep(20);
            cs_enable_moving(true);
            print("cpn: tartar sauce must complete his tasty condiments");
            await sleep(ai_play_line(this.ai_current_actor, "0950"));
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_berserker()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) > this.ai_combat_status_active);
            await sleep((short)random_range(0, 30));
            ai_berserk(this.ai_current_actor, true);
        }

        [ScriptMethod(349, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_banshee0_entry()
        {
            object_cannot_die(ai_vehicle_get(this.ai_current_actor), true);
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_to(GetReference<ISpatialPoint>("e12_cov_banshees0/p2"), 5F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e12_cov_banshees0/p2"), 0.5F);
            ai_vehicle_reserve(ai_vehicle_get(this.ai_current_actor), true);
            ai_vehicle_exit(this.ai_current_actor);
            await sleep(30);
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task e12_pro_inf0_main()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 2, 15);
            await sleep_until(async () => volume_test_objects(tv_e12_chamber_entered, players()), 15);
            ai_place(e12_pro_inf0_1.Squad);
            wake(new ScriptMethodReference(music_08b_09_start));
            await sleep_until(async () => (short)ai_living_count(e12_pro_inf0) <= 1 && device_get_position(e12_door1.Entity) <= 0F);
            game_save_no_timeout();
            ai_place(e12_pro_inf0_2.Squad);
            wake(new ScriptMethodReference(music_08b_09_start_alt));
            wake(new ScriptMethodReference(music_08b_10_start));
            await sleep_until(async () => (short)ai_living_count(e12_pro_inf0) <= 0 || volume_test_objects(tv_e13_cutscene_trigger0, players()), 15);
            device_one_sided_set(e12_door1.Entity, false);
            device_closes_automatically_set(e12_door1.Entity, false);
            device_set_position(e12_door1.Entity, 1F);
            wake(new ScriptMethodReference(music_08b_09_stop));
            wake(new ScriptMethodReference(music_08b_10_stop));
        }

        [ScriptMethod(351, Lifecycle.Dormant)]
        public async Task e12_pro_inf0_ender()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_pro_inf0_end, players()), 15);
            sleep_forever(new ScriptMethodReference(e12_pro_inf0_main));
            device_one_sided_set(e12_door1.Entity, false);
            device_closes_automatically_set(e12_door1.Entity, false);
            device_set_position(e12_door1.Entity, 1F);
            wake(new ScriptMethodReference(music_08b_09_stop));
            wake(new ScriptMethodReference(music_08b_10_stop));
        }

        [ScriptMethod(352, Lifecycle.Dormant)]
        public async Task e12_cov_phantom0_main()
        {
            ai_place(e12_cov_phantom0.Squad);
        }

        [ScriptMethod(353, Lifecycle.Dormant)]
        public async Task e12_cov_banshees0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_ledge, players()) || volume_test_objects(tv_e12_cov_banshee0_begin, players()) || !(await this.player_in_vehicle()), 15);
            if (volume_test_objects(tv_e12_ledge, players()))
            {
                sleep_forever();
            }

            await sleep_until(async () => !(objects_can_see_flag(players(), e12_cov_banshees0_spawn, 80F)), 15);
            ai_place(e12_cov_banshees0.Squad);
            await sleep_until(async () => await this.player_in_vehicle(), 30, 450);
            if (await this.player_in_vehicle())
            {
                sleep_forever();
            }

            activate_team_nav_point_object(_default, player, ai_vehicle_get_from_starting_location(e12_cov_banshees0.banshee0), 1F);
            await sleep_until(async () => await this.player_in_vehicle());
            deactivate_team_nav_point_object(player, ai_vehicle_get_from_starting_location(e12_cov_banshees0.banshee0));
        }

        [ScriptMethod(354, Lifecycle.Dormant)]
        public async Task e12_cov_inf0_main()
        {
            await sleep_until(async () => (short)ai_spawn_count(e12_cov_phantom0.Squad) > 0, 5);
            ai_place(e12_cov_inf0_0.Squad);
            ai_place(e12_cov_inf0_1.elite0);
            ai_place(e12_cov_inf0_1.elite1);
            if (!((bool)game_is_cooperative()))
            {
                ai_place(e12_cov_inf0_1.elite2);
            }

            await sleep(2);
            ai_vehicle_enter_immediate(e12_cov_inf0_0.Squad, ai_vehicle_get(e12_cov_phantom0.phantom0), "phantom_p_a");
            ai_vehicle_enter_immediate(e12_cov_inf0_1.Squad, ai_vehicle_get(e12_cov_phantom0.phantom0), "phantom_p_b");
            await sleep_until(async () => volume_test_objects(tv_e12_ledge, players()), 15);
            cs_run_command_script(e12_cov_inf0, new ScriptMethodReference(cs_e12_cov_inf0_look));
            await sleep_until(async () => volume_test_objects(tv_e12_ledge_entrance, players()), 15);
            cs_run_command_script(e12_cov_inf0, new ScriptMethodReference(cs_e12_cov_inf0_follow));
            ai_set_orders(e12_cov_inf0, e12_cov_inf0_advance0);
            await sleep_until(async () => volume_test_objects(tv_e12_swap_room_halfway, players()), 15);
            ai_set_orders(e12_cov_inf0, e12_cov_inf0_advance1);
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            ai_teleport_to_starting_location_if_outside_bsp(e12_cov_inf0_0.Squad);
            ai_teleport_to_starting_location_if_outside_bsp(e12_cov_inf0_1.Squad);
            await sleep_until(async () => device_get_position(e12_door0.Entity) > 0F, 15);
            ai_set_orders(e12_cov_inf0_0.Squad, e12_cov_inf0_engage0_right);
            ai_set_orders(e12_cov_inf0_1.Squad, e12_cov_inf0_engage0_left);
        }

        [ScriptMethod(355, Lifecycle.Dormant)]
        public async Task e12_main()
        {
            this.g_e12_started = true;
            game_save();
            print("e12_main");
            data_mine_set_mission_segment("e12_control_antechamber");
            wake(new ScriptMethodReference(chapter_title2));
            wake(new ScriptMethodReference(objective2_clear));
            wake(new ScriptMethodReference(objective3_set));
            wake(new ScriptMethodReference(e13_cinematic_main));
            wake(new ScriptMethodReference(e12_cov_banshees0_main));
            wake(new ScriptMethodReference(e12_pro_inf0_main));
            wake(new ScriptMethodReference(e12_pro_inf0_ender));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            game_save();
            sleep_forever(new ScriptMethodReference(e12_cov_banshees0_main));
            deactivate_team_nav_point_object(player, ai_vehicle_get_from_starting_location(e12_cov_banshees0.banshee0));
            await sleep_until(async () => this.g_e13_started);
            sleep_forever(new ScriptMethodReference(e12_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e12_cov_phantom0_main));
            sleep_forever(new ScriptMethodReference(e12_pro_inf0_main));
            ai_erase(e12_cov);
            ai_erase(e12_pro);
        }

        [ScriptMethod(356, Lifecycle.Static)]
        public async Task test_antechamber()
        {
            switch_bsp(2);
            object_teleport(await this.player0(), e12_test);
            if (!(this.g_e12_started))
            {
                wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(357, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_phantom0_0_main()
        {
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p00"));
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p1"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p2"), GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1_facing"), 0.5F);
            await sleep(30);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_lc");
            ai_braindead(e11_pro_wraith0_0.Squad, false);
            await sleep(30);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p1"), GetReference<ISpatialPoint>("e11_pro_phantom0_0/p3"), 0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p4"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_0/p5"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_phantom0_1_main()
        {
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p00"));
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p0"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1"), GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1_facing"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p2"), GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1_facing"), 0.5F);
            await sleep(30);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_lc");
            ai_braindead(e11_pro_wraith0_1.Squad, false);
            await sleep(30);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1"), GetReference<ISpatialPoint>("e11_pro_phantom0_1/p3"), 0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p4"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_phantom0_1/p5"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_e11_attack_scarab()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_moving(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint3")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint3")));
                return false;
            });
        }

        [ScriptMethod(360, Lifecycle.CommandScript)]
        public async Task cs_e11_attack_scarab_behavior()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) <= this.ai_combat_status_active);
                cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_attack_scarab));
                return false;
            });
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_wraiths1_shoot()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_enable_moving(true);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => cs_shoot_point(true, GetReference<ISpatialPoint>("scarab_air/joint3")), 
                    async () => await sleep((short)random_range(90, 180)), 
                    async () => cs_shoot_point(false, GetReference<ISpatialPoint>("scarab_air/joint3")));
                return false;
            });
        }

        [ScriptMethod(362, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_wraiths1_bombard()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            await sleep_until(async () =>
            {
                await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) <= this.ai_combat_status_active);
                cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_pro_wraiths1_shoot));
                return false;
            });
        }

        [ScriptMethod(363, Lifecycle.CommandScript)]
        public async Task cs_e11_ghost_door0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_and_face(GetReference<ISpatialPoint>("e11_door_entry/p0"), GetReference<ISpatialPoint>("e11_door_entry/p1"));
            await sleep_until(async () =>
            {
                device_set_position(e11_door0.Entity, 1F);
                return device_get_position(e11_door0.Entity) >= 1F;
            }, 10);
            cs_go_by(GetReference<ISpatialPoint>("e11_door_entry/p1"), GetReference<ISpatialPoint>("e11_door_entry/p2"));
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e11_door_entry/p2"));
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            await sleep(120);
            object_can_take_damage(ai_get_object(this.ai_current_actor));
            cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_attack_scarab_behavior));
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task cs_e11_spectre_door0_entry()
        {
            cs_enable_pathfinding_failsafe(true);
            ai_vehicle_reserve_seat(ai_vehicle_get(this.ai_current_actor), "spectre_p_l", true);
            cs_go_to_and_face(GetReference<ISpatialPoint>("e11_door_entry/p0"), GetReference<ISpatialPoint>("e11_door_entry/p1"));
            await sleep_until(async () =>
            {
                device_set_position(e11_door0.Entity, 1F);
                return device_get_position(e11_door0.Entity) >= 1F;
            }, 10);
            cs_go_by(GetReference<ISpatialPoint>("e11_door_entry/p1"), GetReference<ISpatialPoint>("e11_door_entry/p2"));
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e11_door_entry/p2"));
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            await sleep(120);
            object_can_take_damage(ai_get_object(this.ai_current_actor));
            cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_attack_scarab_behavior));
        }

        [ScriptMethod(365, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_banshees0_0_entry()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_vehicle_boost(true);
            await sleep(90);
            cs_enable_moving(true);
            await sleep(150);
        }

        [ScriptMethod(366, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_banshees0_1_entry()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e11_pro_banshees0_1_entry/p0"));
            cs_enable_moving(true);
            await sleep(150);
        }

        [ScriptMethod(367, Lifecycle.CommandScript)]
        public async Task cs_e11_scarab_main_gun_shoot()
        {
            cs_shoot_point(true, GetReference<ISpatialPoint>("e11_scarab_gunners/p0"));
            await sleep(165);
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_banshees0_die()
        {
            ai_kill(this.ai_current_actor);
        }

        [ScriptMethod(369, Lifecycle.Static)]
        public async Task<bool> e11_pro_phantom0_0_retreat()
        {
            return object_get_health(ai_vehicle_get(e11_pro_phantom0_0.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e11_pro_phantom0_0.phantom0), "target_front") >= 3;
        }

        [ScriptMethod(370, Lifecycle.Static)]
        public async Task<bool> e11_pro_phantom0_1_retreat()
        {
            return object_get_health(ai_vehicle_get(e11_pro_phantom0_1.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e11_pro_phantom0_1.phantom0), "target_front") >= 3;
        }

        [ScriptMethod(371, Lifecycle.Static)]
        public async Task<int> e11_pro_wraiths1_living_count()
        {
            float ifResult_44491455 = default(float);
            if (unit_get_health(ai_vehicle_get_from_starting_location(e11_pro_wraith1_0.wraith)) > 0F)
            {
                ifResult_44491455 = 1F;
            }
            else
            {
                ifResult_44491455 = 0F;
            }

            float ifResult_48101661 = default(float);
            if (unit_get_health(ai_vehicle_get_from_starting_location(e11_pro_wraith1_1.wraith)) > 0F)
            {
                ifResult_48101661 = 1F;
            }
            else
            {
                ifResult_48101661 = 0F;
            }

            float ifResult_21056532 = default(float);
            if (unit_get_health(ai_vehicle_get_from_starting_location(e11_pro_wraith1_2.wraith)) > 0F)
            {
                ifResult_21056532 = 1F;
            }
            else
            {
                ifResult_21056532 = 0F;
            }

            float ifResult_41431065 = default(float);
            if (unit_get_health(ai_vehicle_get_from_starting_location(e11_pro_wraith1_3.wraith)) > 0F)
            {
                ifResult_41431065 = 1F;
            }
            else
            {
                ifResult_41431065 = 0F;
            }

            return (short)(ifResult_44491455 + ifResult_48101661 + ifResult_21056532 + ifResult_41431065);
        }

        [ScriptMethod(372, Lifecycle.Static)]
        public async Task<bool> e11_pro_wraiths1_weakened()
        {
            return await this.e11_pro_wraiths1_living_count() <= 2;
        }

        [ScriptMethod(373, Lifecycle.Static)]
        public async Task<bool> e11_door_blocked()
        {
            return cs_command_script_queued(e11_pro_ghosts0.Squad, new ScriptMethodReference(cs_e11_ghost_door0_entry)) || cs_command_script_queued(e11_pro_spectres0.Squad, new ScriptMethodReference(cs_e11_spectre_door0_entry));
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task e11_pro_phantom1_main()
        {
            await sleep_until(async () => !(objects_can_see_flag(players(), e11_pro_phantom1_spawn, 80F)) && (short)ai_living_count(e11_pro_phantom0_0.Squad) <= 0 && (short)ai_living_count(e11_pro_wraith0_0.Squad) <= 0, 30);
            ai_place_in_vehicle(e11_pro_wraith0_1.Squad, e11_pro_phantom0_1.Squad);
            ai_braindead(e11_pro_wraith0_1.Squad, true);
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task e11_pro_phantom0_main()
        {
            await sleep_until(async () => this.g_e11_door_open);
            await sleep_until(async () => !(volume_test_objects(tv_e11_outer_cove, players())), 30);
            ai_place(e11_pro_phantom0_0.Squad);
            ai_place_in_vehicle(e11_pro_wraith0_0.Squad, e11_pro_phantom0_0.Squad);
            ai_braindead(e11_pro_wraith0_0.Squad, true);
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task e11_pro_banshees0_main()
        {
            await sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 2);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e11_pro_banshees0) <= 0)
                {
                    await sleep_until(async () =>
                    {
                        if (volume_test_objects(tv_e11_outer_cove, players()))
                        {
                            ai_place(e11_pro_banshees0_1.Squad, 1);
                        }
                        else
                        {
                            ai_place(e11_pro_banshees0_0.Squad, 1);
                        }

                        return (short)ai_living_count(e11_pro_banshees0) >= 2;
                    }, 60);
                }

                return (short)ai_spawn_count(e11_pro_banshees0) >= 10;
            }, 450);
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task e11_pro_spectres0_main()
        {
            await sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 1 && (short)ai_spawn_count(e11_pro_banshees0) > 6);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e11_pro_spectres0.Squad) < 2 && objects_distance_to_object(players(), e11_door0.Entity) > 50F)
                {
                    await sleep_until(async () => !(await this.e11_door_blocked()), 5);
                    if ((short)structure_bsp_index() == 0)
                    {
                        ai_place(e11_pro_spectres0.Squad);
                    }
                }

                return (short)ai_spawn_count(e11_pro_spectres0.Squad) >= 6;
            }, 150);
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task e11_pro_ghosts0_main()
        {
            await sleep_until(async () => this.g_e11_door_open);
            await sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 0);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e11_pro_ghosts0.Squad) < 3 && objects_distance_to_object(players(), e11_door0.Entity) > 50F)
                {
                    await sleep_until(async () => !(await this.e11_door_blocked()), 5);
                    if ((short)structure_bsp_index() == 0)
                    {
                        ai_place(e11_pro_ghosts0.Squad, 1);
                    }
                }

                return (short)ai_spawn_count(e11_pro_ghosts0.Squad) >= 16;
            }, 150);
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task e11_pro_wraith_checkpoints()
        {
            await sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 3, 61);
            game_save();
            await sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 2, 61);
            game_save();
            await sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 1, 61);
            game_save();
            await sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 0, 61);
            game_save();
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task e11_pro_wraith1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e11_pro_wraiths1_begin, players()), 15);
            wake(new ScriptMethodReference(e11_pro_wraith_checkpoints));
            ai_place(e11_pro_wraith1_0.Squad);
            ai_place(e11_pro_wraith1_1.Squad);
            await sleep_until(async () => (short)ai_living_count(e11_pro_wraith1) <= 0);
            wake(new ScriptMethodReference(e11_pro_phantom0_main));
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task e11_cov_banshees0_main()
        {
            if (!(await this.players_in_vehicle()))
            {
                ai_place(e11_cov_banshees0.Squad);
            }
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task e11_navpoint()
        {
            await sleep_until(async () => objects_distance_to_flag(players(), e11_exit_door1) > 185F, 60, this.one_minute);
            activate_team_nav_point_flag(_default, player, e11_exit_door1, 0F);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task e11_navpoint_kill()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_ledge, players()));
            sleep_forever(new ScriptMethodReference(e11_navpoint));
            deactivate_team_nav_point_flag(player, e11_exit_door1);
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task e11_door_opening()
        {
            await sleep_until(async () => this.g_e11_door_should_open, 10);
            await sleep(120);
            sound_impulse_start(GetTag<SoundTag>("sound_remastered\\visual_effects\\deltacontrol_bigdoorexplosion", 3852338216U), default(IGameObject), 1F);
            effect_new(GetTag<EffectTag>("effects\\scenarios\\solo\\deltacontrolroom\\scarab_attack_deltacontrol", 3852403753U), e11_door_explosion);
            object_destroy(e11_exit_door.Entity);
            this.g_e11_door_open = true;
            await sleep(30);
            wake(new ScriptMethodReference(e11_navpoint));
            wake(new ScriptMethodReference(e11_navpoint_kill));
        }

        [ScriptMethod(385, Lifecycle.Dormant)]
        public async Task e11_scarab_main()
        {
            pvs_set_object(scarab.Entity);
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_turn_22_left();
            await this.scarab_walk_front_turn_15_right();
            await this.scarab_walk_front_to_idle();
            await this.scarab_gun_open_up();
            await sleep_until(async () =>
            {
                await this.scarab_idle_var0();
                return volume_test_objects(tv_e11_outer_cove, players());
            }, 1);
            print("johnson: stay clear of the door");
            await sleep(ai_play_line_on_object(default(IGameObject), "0840"));
            await sleep_until(async () => !(volume_test_objects(tv_e11_exit_vicinity, players())), 10, 45);
            if (volume_test_objects(tv_e11_exit_vicinity, players()))
            {
                print("johnson: you trying to get killed?");
                await sleep(ai_play_line_on_object(default(IGameObject), "0860"));
                await sleep_until(async () => !(volume_test_objects(tv_e11_exit_vicinity, players())), 10, 60);
            }

            if (volume_test_objects(tv_e11_exit_vicinity, players()))
            {
                print("johnson: what? do i have to spell it out for you? move!");
                await sleep(ai_play_line_on_object(default(IGameObject), "0870"));
                await sleep_until(async () => !(volume_test_objects(tv_e11_exit_vicinity, players())), 10, 60);
                if (volume_test_objects(tv_e11_exit_vicinity, players()))
                {
                    print("johnson: listen, i'm gonna count to three.");
                    await sleep(ai_play_line_on_object(default(IGameObject), "0880"));
                    await sleep_until(async () => !(volume_test_objects(tv_e11_exit_vicinity, players())), 10, 30);
                    if (volume_test_objects(tv_e11_exit_vicinity, players()))
                    {
                        print("johnson: one...");
                        await sleep(ai_play_line_on_object(default(IGameObject), "0890"));
                        await sleep_until(async () => !(volume_test_objects(tv_e11_exit_vicinity, players())), 10, 45);
                        if (volume_test_objects(tv_e11_exit_vicinity, players()))
                        {
                            print("johnson: two...");
                            await sleep(ai_play_line_on_object(default(IGameObject), "0900"));
                            await sleep_until(async () => !(volume_test_objects(tv_e11_exit_vicinity, players())), 10, 60);
                            if (volume_test_objects(tv_e11_exit_vicinity, players()))
                            {
                                print("johnson: don't say i didn't warn you!");
                                await sleep(ai_play_line_on_object(default(IGameObject), "0910"));
                            }
                            else
                            {
                                await sleep(20);
                                print("johnson: good! now stay put!");
                                await sleep(ai_play_line_on_object(default(IGameObject), "0920"));
                                this.g_e11_player_warned = true;
                            }
                        }
                        else
                        {
                            await sleep(20);
                            print("johnson: good! now stay put!");
                            await sleep(ai_play_line_on_object(default(IGameObject), "0920"));
                            this.g_e11_player_warned = true;
                        }
                    }
                    else
                    {
                        await sleep(20);
                        print("johnson: good! now stay put!");
                        await sleep(ai_play_line_on_object(default(IGameObject), "0920"));
                        this.g_e11_player_warned = true;
                    }
                }
                else
                {
                    await sleep(25);
                    print("johnson: good! now stay put!");
                    await sleep(ai_play_line_on_object(default(IGameObject), "0920"));
                    this.g_e11_player_warned = true;
                }
            }

            await sleep(30);
            if (this.g_e11_player_warned && volume_test_objects(tv_e11_exit_vicinity, players()))
            {
                print("johnson: yeah, that's real funny. i'm still shooting.");
                await sleep(ai_play_line_on_object(default(IGameObject), "0930"));
            }
            else
            {
                print("johnson: hey bastards, knock knock!");
                await sleep(ai_play_line_on_object(default(IGameObject), "0850"));
            }

            wake(new ScriptMethodReference(music_08b_07_start));
            wake(new ScriptMethodReference(music_08b_08_start));
            wake(new ScriptMethodReference(e11_door_opening));
            await sleep_until(async () =>
            {
                await this.scarab_gun_fire_up();
                cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e11_scarab_main_gun_shoot));
                this.g_e11_shot_counter = (short)(this.g_e11_shot_counter + 1);
                if (objects_can_see_flag(players(), e11_exit_door1, 25F))
                {
                    this.g_e11_player_saw_door = true;
                }

                if (this.g_e11_shot_counter >= 4 || this.g_e11_player_saw_door && this.g_e11_shot_counter >= 2)
                {
                    this.g_e11_door_should_open = true;
                }

                await this.scarab_idle_firing();
                return this.g_e11_door_should_open;
            }, 1);
            await this.scarab_gun_close_up();
            wake(new ScriptMethodReference(e12_main));
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_to_idle();
            await this.scarab_idle_turn_22_left();
            await this.scarab_idle_turn_22_left();
            pvs_clear();
            await sleep_until(async () =>
            {
                await this.scarab_idle_var0();
                return false;
            }, 1);
        }

        [ScriptMethod(386, Lifecycle.Dormant)]
        public async Task e11_key()
        {
            if (!(await this.difficulty_legendary()))
            {
                sleep_forever();
            }

            object_create(key);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3853124660U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3853124660U)));
            ice_cream_flavor_stock(8);
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task e11_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e11_main_begin, players()), 15);
            this.g_e11_started = true;
            game_save();
            print("e11_main");
            data_mine_set_mission_segment("e11_scarab_boardings");
            kill_volume_disable(kill_e8_0);
            wake(new ScriptMethodReference(e11_pro_banshees0_main));
            wake(new ScriptMethodReference(e11_pro_wraith1_main));
            wake(new ScriptMethodReference(e11_cov_banshees0_main));
            wake(new ScriptMethodReference(e11_key));
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            sleep_forever(new ScriptMethodReference(e11_pro_wraith1_main));
            sleep_forever(new ScriptMethodReference(e11_pro_banshees0_main));
            sleep_forever(new ScriptMethodReference(e11_pro_phantom0_main));
            sleep_forever(new ScriptMethodReference(e11_pro_phantom1_main));
            sleep_forever(new ScriptMethodReference(e11_pro_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e11_pro_spectres0_main));
            sleep_forever(new ScriptMethodReference(e11_pro_wraith_checkpoints));
            ai_erase(e11_pro);
            ai_erase(e11_cov);
        }

        [ScriptMethod(388, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_phantom0_exit()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p0"), GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p1"), 1F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p0_1"), GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p1"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p2"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(389, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_phantom0_entry()
        {
            cs_fly_to(GetReference<ISpatialPoint>("e9_pro_phantom0_entry/p0"));
            cs_fly_to(GetReference<ISpatialPoint>("e9_pro_phantom0_entry/p1"));
            cs_fly_to(GetReference<ISpatialPoint>("e9_pro_phantom0_entry/p2"), 1F);
            await sleep_until(async () => this.g_e9_scarab_at_second_bend, 15);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("scarab_air/dropship_p1"), GetReference<ISpatialPoint>("scarab_air/dropship_p1_facing"));
            cs_vehicle_speed(0.25F);
            await sleep_until(async () =>
            {
                cs_fly_to_and_face(GetReference<ISpatialPoint>("scarab_air/dropship_p1"), GetReference<ISpatialPoint>("scarab_air/dropship_p1_facing"), 3F);
                return false;
            }, 3, 60);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await sleep_until(async () =>
            {
                cs_fly_to_and_face(GetReference<ISpatialPoint>("scarab_air/dropship_p1"), GetReference<ISpatialPoint>("scarab_air/dropship_p1_facing"), 3F);
                return false;
            }, 3, 300);
            this.g_e9_pro_phantom0_unloaded = true;
        }

        [ScriptMethod(390, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_banshees0_entry()
        {
            cs_vehicle_boost(true);
            await sleep(120);
        }

        [ScriptMethod(391, Lifecycle.Dormant)]
        public async Task e9_pro_spectres0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_second_bend, players()) || this.g_e9_scarab_started, 15);
            ai_place(e9_pro_spectres0_0.Squad);
            await sleep(1);
            ai_vehicle_reserve_seat(ai_vehicle_get(e9_pro_spectres0_0.spectre0), "spectre_p_l", true);
            await sleep_until(async () => volume_test_objects(tv_e9_second_bend, players()) || (short)ai_living_count(e9_pro_spectres0) <= 1, 15);
            ai_place(e9_pro_spectres0_1.Squad);
            await sleep(1);
            ai_vehicle_reserve_seat(ai_vehicle_get(e9_pro_spectres0_1.starting_locations_0), "spectre_p_l", true);
        }

        [ScriptMethod(392, Lifecycle.Dormant)]
        public async Task e9_pro_phantom0_main()
        {
            await sleep_until(async () => this.g_e9_scarab_near_second_bend, 15);
            ai_place(e9_pro_phantom0.Squad);
            await sleep_until(async () => this.g_e9_pro_phantom0_unloaded);
            await sleep_until(async () => object_model_targets_destroyed(ai_vehicle_get(e9_pro_phantom0.phantom0), "target_front") >= 3 || object_get_health(ai_vehicle_get(e9_pro_phantom0.phantom0)) <= 0.05F, 15, 450);
            this.g_e9_pro_phantom0_retreating = true;
            cs_run_command_script(e9_pro_phantom0.phantom0, new ScriptMethodReference(cs_e9_pro_phantom0_exit));
            await sleep(150);
            if (object_model_targets_destroyed(ai_vehicle_get(e9_pro_phantom0.phantom0), "target_front") >= 3 || object_get_health(ai_vehicle_get(e9_pro_phantom0.phantom0)) <= 0.05F)
            {
                print("johnson: now i know why you have the fancy armor");
                ai_play_line_on_object(default(IGameObject), "0690") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(393, Lifecycle.Dormant)]
        public async Task e9_pro_banshees0_main()
        {
            await sleep_until(async () => this.g_e9_scarab_near_first_bend);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e9_pro_banshees0.Squad) <= 0 || (short)ai_living_count(e9_pro_banshees0.Squad) <= 1 && (short)ai_living_count(e9_pro_inf0.Squad) <= 2 && (short)ai_living_count(e9_pro_spectres0) <= 0)
                {
                    ai_place(e9_pro_banshees0.Squad, 1);
                }

                return (short)ai_spawn_count(e9_pro_banshees0.Squad) >= 6 || volume_test_objects(tv_e9_pro_banshees0_stop, players()) || this.g_e9_scarab_stepping_down;
            }, 60);
            ai_migrate(e9_pro_banshees0.Squad, e11_pro_banshees0_1.Squad);
        }

        [ScriptMethod(394, Lifecycle.Dormant)]
        public async Task e9_pro_inf3_main()
        {
            await sleep_until(async () => (short)ai_living_count(e9_pro_phantom0.Squad) > 0);
            ai_place_in_vehicle(e9_pro_inf3_0.Squad, e9_pro_phantom0.Squad);
        }

        [ScriptMethod(395, Lifecycle.Dormant)]
        public async Task e9_pro_inf0_main()
        {
            ai_place(e9_pro_inf0.Squad);
        }

        [ScriptMethod(396, Lifecycle.Dormant)]
        public async Task e9_scarab_navpoint()
        {
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), scarab.Entity) < 40F)
                {
                    deactivate_team_nav_point_object(player, scarab.Entity);
                }

                if (objects_distance_to_object(players(), scarab.Entity) > 60F)
                {
                    activate_team_nav_point_object(_default, player, scarab.Entity, 10F);
                }

                return this.g_e11_door_open;
            }, 140);
            deactivate_team_nav_point_object(player, scarab.Entity);
        }

        [ScriptMethod(397, Lifecycle.Dormant)]
        public async Task e9_scarab_main()
        {
            pvs_set_object(scarab.Entity);
            if (await this.difficulty_normal())
            {
                wake(new ScriptMethodReference(e9_scarab_navpoint));
            }

            this.g_e9_scarab_started = true;
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_turn_22_right();
            await this.scarab_walk_front_turn_15_right();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_to_idle();
            await this.scarab_idle_turn_22_left();
            await this.scarab_idle_turn_45_left();
            await this.scarab_idle_turn_22_left();
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_var0();
            this.g_e9_scarab_near_first_bend = true;
            await this.scarab_walk_front_turn_15_right();
            await this.scarab_walk_front_turn_15_right();
            await this.scarab_walk_front_turn_45_right();
            await this.scarab_walk_front_turn_45_right();
            this.g_e9_scarab_near_second_bend = true;
            await this.scarab_walk_front_turn_15_right();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_turn_22_left();
            await this.scarab_walk_front_turn_22_left();
            await this.scarab_walk_front_turn_45_left();
            this.g_e9_scarab_at_second_bend = true;
            await this.scarab_walk_front_to_idle();
            await this.scarab_idle_turn_22_left();
            await this.scarab_idle_turn_22_left();
            await sleep_until(async () =>
            {
                await this.scarab_idle_var0();
                return true && !(volume_test_objects(tv_scarab, ai_actors(e9_pro_inf3)));
            }, 1);
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_turn_22_right();
            this.g_e9_scarab_stepping_down = true;
            device_set_position_track(scarab.Entity, "delta_canyon_step_down", this.g_scarab_interpolation);
            device_animate_position(scarab.Entity, 1F, 350F / 30F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
            await this.scarab_walk_front_turn_22_right();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_var0();
            wake(new ScriptMethodReference(e11_scarab_main));
        }

        [ScriptMethod(398, Lifecycle.Static)]
        public async Task e9_scarab_test()
        {
            object_teleport(scarab.Entity, e9_scarab);
            wake(new ScriptMethodReference(e9_scarab_main));
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_main_begin, players()) || this.g_e9_scarab_started, 15);
            this.g_e9_started = true;
            game_save();
            print("e9_main");
            data_mine_set_mission_segment("e9_scarab_canyon");
            wake(new ScriptMethodReference(e9_pro_inf0_main));
            wake(new ScriptMethodReference(e9_pro_inf3_main));
            wake(new ScriptMethodReference(e9_pro_spectres0_main));
            wake(new ScriptMethodReference(e9_pro_banshees0_main));
            await sleep_until(async () => this.g_e11_started);
            ai_disposable(e9_pro, true);
            await sleep_until(async () => this.g_e12_started);
            sleep_forever(new ScriptMethodReference(e9_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e9_pro_inf3_main));
            sleep_forever(new ScriptMethodReference(e9_pro_spectres0_main));
            sleep_forever(new ScriptMethodReference(e9_pro_banshees0_main));
        }

        [ScriptMethod(400, Lifecycle.Static)]
        public async Task test_scarab_canyon()
        {
            object_teleport(scarab.Entity, e9_scarab);
            wake(new ScriptMethodReference(e9_main));
            await sleep(1);
            wake(new ScriptMethodReference(e9_main));
            wake(new ScriptMethodReference(e11_main));
        }

        [ScriptMethod(401, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_phantom0_exit()
        {
            cs_fly_by(GetReference<ISpatialPoint>("e8_pro_phantom0_exit/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_pro_phantom0_exit/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_pro_phantom0_exit/p2"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(402, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_entry0()
        {
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            cs_vehicle_boost(true);
            await sleep(80);
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p0_0"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p0_1"), 15F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p0_1"), 2F);
            await sleep(15);
            ai_vehicle_exit(this.ai_current_actor);
            object_can_take_damage(ai_get_object(this.ai_current_actor));
            cs_ignore_obstacles(false);
            cs_face_player(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 3F || this.g_e8_cov_banshees0_greeted);
            if (!(this.g_e8_cov_banshees0_greeted))
            {
                print("elite: take my banshee");
                this.g_e8_cov_banshees0_greeted = true;
                await sleep(ai_play_line_at_player(this.ai_current_actor, "0800"));
            }

            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 10F || await this.players_in_vehicle());
            cs_go_to(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/exit0"));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 40F);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(403, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_entry1()
        {
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            cs_vehicle_boost(true);
            await sleep(70);
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p1_0"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p1_1"), 15F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p1_1"), 2F);
            await sleep(15);
            ai_vehicle_exit(this.ai_current_actor);
            object_can_take_damage(ai_get_object(this.ai_current_actor));
            cs_ignore_obstacles(false);
            cs_face_player(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 3F || this.g_e8_cov_banshees0_greeted);
            if (!(this.g_e8_cov_banshees0_greeted))
            {
                print("elite: take my banshee");
                this.g_e8_cov_banshees0_greeted = true;
                await sleep(ai_play_line_at_player(this.ai_current_actor, "0800"));
            }

            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 10F || await this.players_in_vehicle());
            cs_go_to(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/exit0"));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 40F);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(404, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_entry2()
        {
            cs_ignore_obstacles(true);
            cs_enable_pathfinding_failsafe(true);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            cs_vehicle_boost(true);
            await sleep(70);
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p2_0"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p2_1"), 15F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p2_1"), 2F);
            await sleep(15);
            ai_vehicle_exit(this.ai_current_actor);
            object_can_take_damage(ai_get_object(this.ai_current_actor));
            cs_ignore_obstacles(false);
            cs_face_player(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 0F && objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 3F || this.g_e8_cov_banshees0_greeted);
            if (!(this.g_e8_cov_banshees0_greeted))
            {
                print("elite: take my banshee");
                this.g_e8_cov_banshees0_greeted = true;
                await sleep(ai_play_line_at_player(this.ai_current_actor, "0800"));
            }

            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 10F || await this.players_in_vehicle());
            cs_go_to(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/exit1"));
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) > 40F);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(405, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_flyby()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_vehicle_boost(true);
            await sleep(100);
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p4"));
            object_destroy(ai_vehicle_get(this.ai_current_actor));
            await sleep(1);
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(406, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_wraith0_0_bombard()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_face_object(true, scarab.Entity);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p0_0"));
                cs_shoot_point(true, GetReference<ISpatialPoint>("scarab/target_right"));
                await sleep_until(async () => this.g_e8_target_wraith == 0, 10);
                cs_shoot_point(false, GetReference<ISpatialPoint>("scarab/target_right"));
                cs_go_to(GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p0_1"));
                await sleep((short)random_range(180, 210));
                return false;
            }, 1);
        }

        [ScriptMethod(407, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_wraith0_1_bombard()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_face_object(true, scarab.Entity);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p1_0"));
                cs_shoot_point(true, GetReference<ISpatialPoint>("scarab/target_left"));
                await sleep_until(async () => this.g_e8_target_wraith == 1, 10);
                cs_shoot_point(false, GetReference<ISpatialPoint>("scarab/target_left"));
                cs_go_to(GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p1_1"));
                await sleep((short)random_range(180, 210));
                return false;
            }, 1);
        }

        [ScriptMethod(408, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_wraith0_2_bombard()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_face_object(true, scarab.Entity);
            await sleep_until(async () =>
            {
                cs_go_to(GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p2_0"));
                cs_shoot_point(true, GetReference<ISpatialPoint>("scarab/target_left"));
                await sleep_until(async () => this.g_e8_target_wraith == 2, 10);
                cs_shoot_point(false, GetReference<ISpatialPoint>("scarab/target_left"));
                cs_go_to(GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p2_1"));
                await sleep((short)random_range(180, 210));
                return false;
            }, 1);
        }

        [ScriptMethod(409, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_idle()
        {
            sleep_forever();
        }

        [ScriptMethod(410, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_shoot0()
        {
            cs_shoot_point(true, GetReference<ISpatialPoint>("e8_scarab_gunners/p0"));
            await sleep(75);
            if (volume_test_objects(tv_e8_scarab_fire_unsafe, players()))
            {
                await this.scarab_gun_fire_down_abort();
                cs_shoot_point(false, GetReference<ISpatialPoint>("e8_scarab_gunners/p0"));
            }

            await sleep(90);
        }

        [ScriptMethod(411, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_shoot1()
        {
            cs_shoot_point(true, GetReference<ISpatialPoint>("e8_scarab_gunners/p1"));
            await sleep(75);
            if (volume_test_objects(tv_e8_scarab_fire_unsafe, players()))
            {
                await this.scarab_gun_fire_down_abort();
                cs_shoot_point(false, GetReference<ISpatialPoint>("e8_scarab_gunners/p1"));
            }

            await sleep(90);
        }

        [ScriptMethod(412, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_shoot2()
        {
            cs_shoot_point(true, GetReference<ISpatialPoint>("e8_scarab_gunners/p2"));
            await sleep(75);
            if (volume_test_objects(tv_e8_scarab_fire_unsafe, players()))
            {
                await this.scarab_gun_fire_down_abort();
                cs_shoot_point(false, GetReference<ISpatialPoint>("e8_scarab_gunners/p2"));
            }

            await sleep(90);
        }

        [ScriptMethod(413, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_johnson_init()
        {
            cs_enable_dialogue(true);
            object_cannot_die(ai_get_object(this.ai_current_actor), true);
            object_cinematic_lod(ai_get_object(this.ai_current_actor), true);
            ai_vehicle_enter_immediate(this.ai_current_actor, unit(object_at_marker(scarab.Entity, "scarab_d_l")), "scarab_d_r");
            cs_look_player(true);
            sleep_forever();
        }

        [ScriptMethod(414, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_inf0_emerge()
        {
            cs_abort_on_combat_status(this.ai_combat_status_visible);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("scarab/p2"));
        }

        [ScriptMethod(415, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_inf0_retreat()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("scarab/p0"));
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task e8_scarab_main()
        {
            pvs_set_object(scarab.Entity);
            print("hide main gunner");
            object_hide(object_at_marker(scarab.Entity, "primary_trigger"), true);
            device_set_position_track(scarab.Entity, "delta_ledge_exit", 0F);
            device_animate_position(scarab.Entity, 1F, 1F / 30F, 0F, 0F, true);
            await sleep(3);
            object_create(scarab_door);
            objects_attach(scarab.Entity, "plasma_door", scarab_door.Entity, "");
            ai_place(scarab_gunners.main_gunner);
            vehicle_load_magic(unit(object_at_marker(scarab.Entity, "primary_trigger")), "scarab_turret_d", ai_get_object(scarab_gunners.main_gunner));
            cs_run_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_idle));
            await this.scarab_idle_var0();
            await this.scarab_idle_turn_22_right_slow();
            await this.scarab_idle_turn_45_right_slow();
            await this.scarab_idle_turn_22_right_slow();
            await this.scarab_gun_open_down();
            await this.scarab_idle_turn_15_right_slow();
            this.g_e8_target_wraith = 1;
            await this.scarab_idle_to_twist_5_left();
            await this.scarab_gun_fire_down();
            cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot1));
            await this.scarab_twist_5_left_firing();
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(e8_pro_wraiths0_0.Squad) > 0)
                    {
                        if (!(this.g_e8_target_wraith == 0))
                        {
                            await this.scarab_twist_5_left_to_idle();
                            await this.scarab_idle_to_twist_5_right();
                        }
                        else
                        {
                            await this.scarab_twist_5_right();
                        }

                        this.g_e8_target_wraith = 0;
                        if (!(volume_test_objects(tv_e8_scarab_fire_unsafe, players())))
                        {
                            await this.scarab_gun_fire_down();
                            cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot0));
                            await this.scarab_twist_5_right_firing();
                        }
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_pro_wraiths0_1.Squad) > 0)
                    {
                        if (this.g_e8_target_wraith == 0)
                        {
                            await this.scarab_twist_5_right_to_idle();
                            await this.scarab_idle_to_twist_5_left();
                        }
                        else
                        {
                            await this.scarab_twist_5_left();
                        }

                        this.g_e8_target_wraith = 1;
                        if (!(volume_test_objects(tv_e8_scarab_fire_unsafe, players())))
                        {
                            await this.scarab_gun_fire_down();
                            cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot1));
                            await this.scarab_twist_5_left_firing();
                        }
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_pro_wraiths0_2.Squad) > 0)
                    {
                        if (this.g_e8_target_wraith == 0)
                        {
                            await this.scarab_twist_5_right_to_idle();
                            await this.scarab_idle_to_twist_5_left();
                        }
                        else
                        {
                            await this.scarab_twist_5_left();
                        }

                        this.g_e8_target_wraith = 2;
                        if (!(volume_test_objects(tv_e8_scarab_fire_unsafe, players())))
                        {
                            await this.scarab_gun_fire_down();
                            cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot2));
                            await this.scarab_twist_5_left_firing();
                        }
                    }
                });
                return (short)ai_living_count(e8_pro_wraiths0) <= 0;
            }, 1);
            await this.scarab_gun_close_down();
            if (this.g_e8_target_wraith == 0)
            {
                await this.scarab_twist_5_right_to_idle();
            }
            else
            {
                await this.scarab_twist_5_left_to_idle();
            }

            await this.scarab_idle_turn_15_left();
            wake(new ScriptMethodReference(e9_scarab_main));
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task e8_wraith_dialogue()
        {
            await sleep_until(async () => (short)ai_living_count(e8_pro_wraiths0) <= 2);
            await sleep(30);
            print("johnson: hah, how do you like it?");
            ai_play_line_on_object(default(IGameObject), "0660") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task e8_pro_wraiths0_main()
        {
            await sleep_until(async () => await this.players_in_vehicle() || volume_test_objects(tv_e8_exit, players()), 30, 450);
            ai_place(e8_pro_wraiths0);
            wake(new ScriptMethodReference(e8_wraith_dialogue));
            await sleep_until(async () =>
            {
                if ((short)ai_combat_status(e8_pro_wraiths0_0.Squad) <= this.ai_combat_status_active && !(cs_command_script_queued(e8_pro_wraiths0_0.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_0_bombard))))
                {
                    print("wraith0 bombard");
                    cs_run_command_script(e8_pro_wraiths0_0.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_0_bombard));
                }

                if ((short)ai_combat_status(e8_pro_wraiths0_1.Squad) <= this.ai_combat_status_active && !(cs_command_script_queued(e8_pro_wraiths0_1.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_1_bombard))))
                {
                    print("wraith1 bombard");
                    cs_run_command_script(e8_pro_wraiths0_1.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_1_bombard));
                }

                if ((short)ai_combat_status(e8_pro_wraiths0_2.Squad) <= this.ai_combat_status_active && !(cs_command_script_queued(e8_pro_wraiths0_2.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_2_bombard))))
                {
                    print("wraith2 bombard");
                    cs_run_command_script(e8_pro_wraiths0_2.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_2_bombard));
                }

                return (short)ai_living_count(e8_pro_wraiths0) <= 0;
            });
            await sleep(60);
            game_save();
        }

        [ScriptMethod(419, Lifecycle.Dormant)]
        public async Task e8_cov_banshees0_main()
        {
            ai_place(e8_cov_banshees0.banshee1);
            await sleep(60);
            ai_place(e8_cov_banshees0.banshee0);
            await sleep(90);
            ai_place(e8_cov_banshees0.banshee2);
            await sleep_until(async () => await this.players_in_vehicle() || volume_test_objects(tv_e8_exit, players()));
            wake(new ScriptMethodReference(music_08b_06_start));
            game_save();
        }

        [ScriptMethod(420, Lifecycle.Static)]
        public async Task<bool> e8_mars_inf0_should_activate()
        {
            return volume_test_objects(tv_scarab, players()) || volume_test_objects(tv_scarab, ai_actors(e9_pro_inf3));
        }

        [ScriptMethod(421, Lifecycle.Dormant)]
        public async Task e8_mars_inf0_main()
        {
            await sleep(30);
            ai_place(e8_mars_inf0.Squad);
            await sleep_until(async () =>
            {
                if (await this.e8_mars_inf0_should_activate())
                {
                    if ((short)ai_living_count(e8_mars_inf0.Squad) <= 0)
                    {
                        ai_place(e8_mars_inf0.Squad, this.g_e8_mars_inf0_living_count);
                    }
                    else
                    {
                        cs_run_command_script(e8_mars_inf0.Squad, new ScriptMethodReference(cs_e8_mars_inf0_emerge));
                        cs_run_command_script(e8_mars_inf0.johnson, new ScriptMethodReference(cs_e8_mars_johnson_init));
                    }

                    await sleep_until(async () => !(await this.e8_mars_inf0_should_activate()));
                }
                else if ((short)ai_living_count(e8_mars_inf0.Squad) > 0)
                {
                    this.g_e8_mars_inf0_living_count = (short)ai_living_count(e8_mars_inf0.Squad);
                    cs_run_command_script(e8_mars_inf0.Squad, new ScriptMethodReference(cs_e8_mars_inf0_retreat));
                    await sleep_until(async () => await this.e8_mars_inf0_should_activate() || volume_test_objects_all(tv_scarab_interior, ai_actors(e8_mars_inf0.Squad)));
                    if (!(await this.e8_mars_inf0_should_activate()))
                    {
                        ai_erase(e8_mars_inf0.Squad);
                    }
                }

                return false;
            });
        }

        [ScriptMethod(422, Lifecycle.Dormant)]
        public async Task e8_cov_inf0_main()
        {
            await sleep(1);
        }

        [ScriptMethod(423, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            this.g_e8_started = true;
            game_save();
            print("e8_main");
            data_mine_set_mission_segment("e8_scarab_cove");
            kill_volume_disable(kill_e8_0);
            wake(new ScriptMethodReference(objective1_clear));
            wake(new ScriptMethodReference(objective2_set));
            wake(new ScriptMethodReference(e9_main));
            wake(new ScriptMethodReference(e11_main));
            object_create(e8_banshee0);
            object_create(e8_banshee1);
            wake(new ScriptMethodReference(e8_cov_inf0_main));
            wake(new ScriptMethodReference(e8_cov_banshees0_main));
            wake(new ScriptMethodReference(e8_pro_wraiths0_main));
            wake(new ScriptMethodReference(e8_scarab_main));
            await sleep_until(async () => this.g_e9_started);
            ai_disposable(e8_cov, true);
        }

        [ScriptMethod(424, Lifecycle.Static)]
        public async Task test_scarab_ride()
        {
            object_teleport(scarab.Entity, e8_scarab);
            if (!(this.g_e8_started))
            {
                wake(new ScriptMethodReference(e8_main));
            }
        }

        [ScriptMethod(425, Lifecycle.Dormant)]
        public async Task scarab_test_loop()
        {
            await sleep_until(async () =>
            {
                object_create_anew(scarab);
                pvs_set_object(scarab.Entity);
                device_set_position_track(scarab.Entity, "delta_ledge_exit", 0F);
                device_animate_position(scarab.Entity, 1F, 90F / 30F, 0F, 0F, true);
                await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
                await this.scarab_idle_var0();
                await this.scarab_idle_turn_22_right();
                await this.scarab_idle_turn_45_right();
                await this.scarab_idle_turn_22_right();
                await this.scarab_idle_var0();
                await this.scarab_idle_to_walk_front();
                await this.scarab_walk_front_turn_22_right();
                await this.scarab_walk_front_turn_15_right();
                await this.scarab_walk_front_turn_15_left();
                await this.scarab_walk_front_turn_15_left();
                await this.scarab_walk_front_var0();
                await this.scarab_walk_front_var0();
                await this.scarab_walk_front_to_idle();
                await this.scarab_idle_turn_22_left();
                await this.scarab_idle_turn_45_left();
                await this.scarab_idle_turn_22_left();
                await this.scarab_idle_to_walk_front();
                await this.scarab_walk_front_var0();
                await this.scarab_walk_front_turn_15_right();
                await this.scarab_walk_front_turn_15_right();
                await this.scarab_walk_front_turn_45_right();
                await this.scarab_walk_front_turn_45_right();
                await this.scarab_walk_front_turn_15_right();
                await this.scarab_walk_front_turn_15_left();
                await this.scarab_walk_front_turn_22_left();
                await this.scarab_walk_front_turn_22_left();
                await this.scarab_walk_front_turn_45_left();
                await this.scarab_walk_front_to_idle();
                await this.scarab_idle_turn_22_left();
                await this.scarab_idle_turn_22_left();
                await this.scarab_idle_var0();
                await this.scarab_idle_to_walk_front();
                await this.scarab_walk_front_turn_15_left();
                await this.scarab_walk_front_turn_15_left();
                await this.scarab_walk_front_turn_22_right();
                device_set_position_track(scarab.Entity, "delta_canyon_step_down", 0F);
                device_animate_position(scarab.Entity, 1F, 350F / 30F, 0F, 0F, true);
                await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
                await this.scarab_walk_front_var0();
                return false;
            }, 1);
        }

        [ScriptMethod(426, Lifecycle.CommandScript)]
        public async Task cs_e7_mars_inf0_wait()
        {
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            custom_animation_loop(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_unarmed", false);
            await sleep_until(async () => this.g_e7_mars_johnson_go, 3);
            await sleep(15);
            custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_to_idle_pistol", false);
            cs_enable_moving(true);
            await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
            ai_disregard(ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(427, Lifecycle.CommandScript)]
        public async Task cs_e7_mars_inf0_johnson()
        {
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            unit_impervious(ai_get_unit(this.ai_current_actor), true);
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            cs_enable_pathfinding_failsafe(true);
            custom_animation_relative_loop(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_unarmed_johnson", false, anchor_intra2.Entity);
            await sleep_until(async () => this.g_e7_mars_johnson_go, 3);
            print("johnson: go go go!");
            ai_play_line(this.ai_current_actor, "3000") // Couldn't generate cast from 'Short' to 'Void'
            ;
            custom_animation_relative(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_2_scarab", false, anchor_intra2.Entity);
            await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
            this.g_e7_mars_johnson_aboard = true;
            cs_go_to(GetReference<ISpatialPoint>("scarab/p0"));
        }

        [ScriptMethod(428, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_wait()
        {
            await sleep_until(async () => device_get_position(e7_door0.Entity) > 0F, 5);
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_abort_on_damage(true);
            cs_look_object(true, ai_get_object(e7_mars_inf0.johnson0));
            await sleep_until(async () => this.g_e7_pro_sentry_alerted, 10);
            ai_magically_see_object(this.ai_current_squad, await this.player0());
            cs_force_combat_status(4);
        }

        [ScriptMethod(429, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_captain_alert()
        {
            cs_aim_player(true);
            await sleep(20);
            print("cpn: elites!");
            await sleep(ai_play_line(this.ai_current_actor, "0400"));
            this.g_e7_mars_johnson_go = true;
            object_cannot_die(ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(430, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_captain()
        {
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e7_pro_inf0_captain_alert));
            await sleep_until(async () => device_get_position(e7_door0.Entity) > 0F, 5);
            cs_abort_on_combat_status(this.ai_combat_status_active);
            cs_abort_on_damage(true);
            object_cannot_die(ai_get_object(this.ai_current_actor), true);
            print("tar: mine will do. kill the others.");
            await sleep(ai_play_line_on_object(default(IGameObject), "0050"));
            await sleep(20);
            print("cpn: yes chieftan.");
            await sleep(ai_play_line(this.ai_current_actor, "0060"));
            cs_look_object(true, ai_get_object(e7_mars_inf0.johnson0));
            await sleep(20);
            print("cpn: a day's rations says i do this in one cut.");
            await sleep(ai_play_line(this.ai_current_actor, "0070"));
            cs_start_to(GetReference<ISpatialPoint>("e7_pro_inf0_sentry/p1"));
            await sleep(20);
            this.g_e7_pro_captain_done = true;
            print("guard: two cuts, at least");
            await sleep(ai_play_line(e7_pro_inf0.guard0, "0090"));
            await sleep(20);
            print("cpn: done!");
            await sleep(ai_play_line(this.ai_current_actor, "0100"));
            await sleep_until(async () => this.g_e7_pro_sentry_alerted, 10);
            ai_magically_see_object(this.ai_current_squad, await this.player0());
            cs_force_combat_status(4);
        }

        [ScriptMethod(431, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_sentry0_alerted()
        {
            print("sentry: wait, movement!");
            await sleep(ai_play_line(this.ai_current_actor, "0110"));
            this.g_e7_pro_sentry_alerted = true;
            ai_magically_see_object(this.ai_current_squad, await this.player0());
            cs_force_combat_status(4);
        }

        [ScriptMethod(432, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_sentry0()
        {
            cs_abort_on_damage(true);
            await sleep_until(async () => this.g_e7_pro_captain_done || objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) <= 5F, 10);
            cs_look(true, GetReference<ISpatialPoint>("e7_pro_inf0_sentry/look0"));
            await sleep(45);
            cs_face(true, GetReference<ISpatialPoint>("e7_pro_inf0_sentry/look1"));
            await sleep(60);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e7_pro_inf0_sentry0_alerted));
        }

        [ScriptMethod(433, Lifecycle.Dormant)]
        public async Task e7_mars_inf0_main()
        {
            ai_place(e7_mars_inf0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e7_on_ledge, players()), 3);
            this.g_e7_pro_sentry_alerted = true;
            this.g_e7_mars_johnson_go = true;
        }

        [ScriptMethod(434, Lifecycle.Dormant)]
        public async Task e7_pro_inf0_main()
        {
            ai_place(e7_pro_inf0.Squad);
            ai_prefer_target(ai_actors(e7_cov), true);
        }

        [ScriptMethod(435, Lifecycle.Dormant)]
        public async Task e7_cov_hunters0_main()
        {
            await sleep(1);
        }

        [ScriptMethod(436, Lifecycle.Dormant)]
        public async Task e7_cov_inf0_main()
        {
            ai_migrate(e6_cov_hunters0.Squad, e7_cov_hunters0.Squad);
            await sleep_until(async () =>
            {
                if ((short)ai_living_count(e6_cov) <= 0)
                {
                    return 1F == 1F;
                }
                else
                {
                    if ((short)ai_living_count(e7_cov_inf0.Squad) < 2)
                    {
                        print("migrated an actor");
                        ai_migrate(object_get_ai(list_get(ai_actors(e6_cov), 0)), e7_cov_inf0.Squad);
                    }

                    return 1F == 0F;
                }
            });
        }

        [ScriptMethod(437, Lifecycle.Startup)]
        public async Task e7_scarab_main()
        {
            pvs_set_object(scarab.Entity);
            device_set_position_track(scarab.Entity, "delta_ledge_idle", 0F);
            device_animate_position(scarab.Entity, 1F, 2F, 0F, 0F, true);
            pvs_clear();
            await sleep_until(async () => this.g_e7_mars_johnson_aboard, 2);
            pvs_set_object(scarab.Entity);
            device_set_position_track(scarab.Entity, "delta_ledge_rear_back", 0F);
            device_animate_position(scarab.Entity, 1F, 70F / 30F, 0F, 0F, true);
            await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
            await sleep_until(async () =>
            {
                device_set_position_track(scarab.Entity, "delta_ledge_rear_idle", 0F);
                device_animate_position(scarab.Entity, 1F, 120F / 30F, 0F, 0F, true);
                await sleep_until(async () => device_get_position(scarab.Entity) >= 1F, 1);
                return (short)structure_bsp_index() == 0 && !(volume_test_objects(tv_e7_brute_area, ai_actors(e7_pro_inf0.Squad))) && (bool)game_safe_to_save();
            }, 5);
            await this.cinematic_fade_to_white();
            ai_erase(e7_mars);
            object_destroy(scarab.Entity);
            object_teleport(await this.player0(), player0_e8_stash);
            object_teleport(await this.player1(), player1_e8_stash);
            object_cannot_take_damage(players());
            object_hide(await this.player0(), true);
            object_hide(await this.player1(), true);
            await this.cinematic_johnson_ledge();
            sound_suppress_ambience_update_on_revert();
            sound_class_set_gain("amb", 0F, 0);
            await sleep(1);
            sound_class_set_gain("amb", 1F, 15);
            object_teleport(await this.player0(), player0_e8_start);
            object_teleport(await this.player1(), player1_e8_start);
            object_can_take_damage(players());
            object_hide(await this.player0(), false);
            object_hide(await this.player1(), false);
            object_create(scarab);
            pvs_set_object(scarab.Entity);
            device_set_position_track(scarab.Entity, "delta_ledge_idle", 0F);
            wake(new ScriptMethodReference(e8_main));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_title1));
        }

        [ScriptMethod(438, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 0 && volume_test_objects(tv_e7_main_begin, players()), 15);
            this.g_e7_started = true;
            game_save();
            print("e7_main");
            data_mine_set_mission_segment("e7_scarab_ledge");
            weather_stop(0F);
            device_operates_automatically_set(e7_door0.Entity, true);
            wake(new ScriptMethodReference(music_08b_05_stop));
            wake(new ScriptMethodReference(e7_cov_inf0_main));
            wake(new ScriptMethodReference(e7_cov_hunters0_main));
            wake(new ScriptMethodReference(e7_pro_inf0_main));
            wake(new ScriptMethodReference(e7_mars_inf0_main));
            await sleep_until(async () => this.g_e8_started);
            ai_disposable(e7_cov, true);
            ai_disposable(e7_pro, true);
            await sleep_until(async () => this.g_e9_started);
            sleep_forever(new ScriptMethodReference(e7_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e7_cov_hunters0_main));
            sleep_forever(new ScriptMethodReference(e7_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e7_mars_inf0_main));
        }

        [ScriptMethod(439, Lifecycle.Static)]
        public async Task test_scarab_boarding()
        {
            object_teleport(await this.player0(), e7_test);
            ai_place(e7_cov_inf0.Squad);
            ai_place(e7_cov_hunters0.Squad);
            if (!(this.g_e7_started))
            {
                wake(new ScriptMethodReference(e7_main));
            }
        }

        [ScriptMethod(440, Lifecycle.Static)]
        public async Task<bool> e6_room_cleared()
        {
            return (short)ai_living_count(e6_pro) <= 0 && object_get_health(e6_jail_shield1.Entity) < 0F && object_get_health(e6_jail_shield2.Entity) < 0F && object_get_health(e6_jail_shield4.Entity) < 0F;
        }

        [ScriptMethod(441, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (object_get_health(e6_jail_shield0.Entity) >= 0F)
            {
                cs_start_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield0"));
                await sleep_until(async () => !((bool)cs_moving()) || object_get_health(e6_jail_shield0.Entity) < 0F, 15);
                if (object_get_health(e6_jail_shield0.Entity) >= 0F)
                {
                    cs_shoot_point(true, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield0"));
                }

                await sleep_until(async () => object_get_health(e6_jail_shield0.Entity) < 0F, 15, 150);
                cs_shoot_point(false, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield0"));
            }
        }

        [ScriptMethod(442, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door1()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (object_get_health(e6_jail_shield1.Entity) >= 0F)
            {
                cs_start_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield1"));
                await sleep_until(async () => !((bool)cs_moving()) || object_get_health(e6_jail_shield1.Entity) < 0F, 15);
                if (object_get_health(e6_jail_shield1.Entity) >= 0F)
                {
                    cs_shoot_point(true, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield1"));
                }

                await sleep_until(async () => object_get_health(e6_jail_shield1.Entity) < 0F, 15, 150);
                cs_shoot_point(false, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield1"));
            }
        }

        [ScriptMethod(443, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door2()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (object_get_health(e6_jail_shield2.Entity) >= 0F)
            {
                cs_start_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield2"));
                await sleep_until(async () => !((bool)cs_moving()) || object_get_health(e6_jail_shield2.Entity) < 0F, 15);
                if (object_get_health(e6_jail_shield2.Entity) >= 0F)
                {
                    cs_shoot_point(true, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield2"));
                }

                await sleep_until(async () => object_get_health(e6_jail_shield2.Entity) < 0F, 15, 150);
                cs_shoot_point(false, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield2"));
            }
        }

        [ScriptMethod(444, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door3()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (object_get_health(e6_jail_shield3.Entity) >= 0F)
            {
                cs_start_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield3"));
                await sleep_until(async () => !((bool)cs_moving()) || object_get_health(e6_jail_shield3.Entity) < 0F, 15);
                if (object_get_health(e6_jail_shield3.Entity) >= 0F)
                {
                    cs_shoot_point(true, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield3"));
                }

                await sleep_until(async () => object_get_health(e6_jail_shield3.Entity) < 0F, 15, 150);
                cs_shoot_point(false, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield3"));
            }
        }

        [ScriptMethod(445, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door4()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (object_get_health(e6_jail_shield4.Entity) >= 0F)
            {
                cs_start_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield4"));
                await sleep_until(async () => !((bool)cs_moving()) || object_get_health(e6_jail_shield4.Entity) < 0F, 15);
                if (object_get_health(e6_jail_shield4.Entity) >= 0F)
                {
                    cs_shoot_point(true, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield4"));
                }

                await sleep_until(async () => object_get_health(e6_jail_shield4.Entity) < 0F, 15, 150);
                cs_shoot_point(false, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield4"));
            }
        }

        [ScriptMethod(446, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door5()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (object_get_health(e6_jail_shield5.Entity) >= 0F)
            {
                cs_start_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield5"));
                await sleep_until(async () => !((bool)cs_moving()) || object_get_health(e6_jail_shield5.Entity) < 0F, 15);
                if (object_get_health(e6_jail_shield5.Entity) >= 0F)
                {
                    cs_shoot_point(true, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield5"));
                }

                await sleep_until(async () => object_get_health(e6_jail_shield5.Entity) < 0F, 15, 150);
                cs_shoot_point(false, GetReference<ISpatialPoint>("cs_e6_hunter_room/shield5"));
            }
        }

        [ScriptMethod(447, Lifecycle.CommandScript)]
        public async Task cs_e6_release_captives()
        {
            cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (object_get_health(e6_jail_shield4.Entity) >= 0F && !(cs_command_script_queued(this.ai_current_squad, new ScriptMethodReference(cs_e6_destroy_door4))))
            {
                cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_destroy_door4));
                await sleep(30);
            }

            if (object_get_health(e6_jail_shield1.Entity) >= 0F && !(cs_command_script_queued(this.ai_current_squad, new ScriptMethodReference(cs_e6_destroy_door1))))
            {
                cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_destroy_door1));
                await sleep(30);
            }

            if (object_get_health(e6_jail_shield2.Entity) >= 0F && !(cs_command_script_queued(this.ai_current_squad, new ScriptMethodReference(cs_e6_destroy_door2))))
            {
                cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_destroy_door2));
                await sleep(30);
            }
        }

        [ScriptMethod(448, Lifecycle.CommandScript)]
        public async Task cs_e6_jailbreak_behavior()
        {
            cs_enable_moving(true);
            cs_enable_targeting(true);
            cs_enable_dialogue(true);
            await sleep_until(async () =>
            {
                if (!(unit_has_weapon(ai_get_unit(this.ai_current_actor), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3854369863U))) && (short)ai_combat_status(this.ai_current_actor) < this.ai_combat_status_certain)
                {
                    cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_release_captives));
                }

                return await this.e6_room_cleared() || unit_has_weapon(ai_get_unit(this.ai_current_actor), GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3854369863U));
            }, 60);
        }

        [ScriptMethod(449, Lifecycle.CommandScript)]
        public async Task cs_e6_cov_inf1_1_init()
        {
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            await sleep_until(async () => (short)ai_combat_status(e6_pro) >= this.ai_combat_status_active || object_get_health(e6_jail_shield1.Entity) < 0F, 15);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/elite1_approach"));
            cs_look_player(true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:cheer", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:shakefist", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:warn", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:wave", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                });
                return object_get_health(e6_jail_shield1.Entity) < 0F || (short)ai_living_count(e6_pro) <= 0;
            }, 15);
            await sleep_until(async () => object_get_health(e6_jail_shield1.Entity) < 0F, 15);
            ai_disregard(ai_get_object(this.ai_current_actor), false);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_jailbreak_behavior));
        }

        [ScriptMethod(450, Lifecycle.CommandScript)]
        public async Task cs_e6_cov_inf1_2_init()
        {
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            await sleep_until(async () => (short)ai_combat_status(e6_pro) >= this.ai_combat_status_active || object_get_health(e6_jail_shield2.Entity) < 0F, 15);
            cs_ignore_obstacles(true);
            cs_go_to(GetReference<ISpatialPoint>("cs_e6_hunter_room/elite2_approach"));
            cs_look_player(true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:cheer", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:shakefist", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:warn", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        custom_animation(ai_get_unit(this.ai_current_actor), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:wave", true);
                        await sleep(unit_get_custom_animation_time(ai_get_unit(this.ai_current_actor)));
                        await sleep_until(async () => object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)random_range(90, 150));
                    }
                });
                return object_get_health(e6_jail_shield2.Entity) < 0F || (short)ai_living_count(e6_pro) <= 0;
            }, 15);
            await sleep_until(async () => object_get_health(e6_jail_shield2.Entity) < 0F, 15);
            ai_disregard(ai_get_object(this.ai_current_actor), false);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_jailbreak_behavior));
        }

        [ScriptMethod(451, Lifecycle.CommandScript)]
        public async Task cs_e6_cov_hunters0_0_init()
        {
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            await sleep_until(async () => (bool)ai_trigger_test("generic_player_sighted", this.ai_current_squad) || object_get_health(e6_jail_shield4.Entity) < 0F, 15);
            cs_look_player(true);
            await sleep_until(async () => object_get_health(e6_jail_shield4.Entity) < 0F, 15);
            ai_disregard(ai_get_object(this.ai_current_actor), false);
            cs_force_combat_status(4);
            cs_look_player(false);
            cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_jailbreak_behavior));
        }

        [ScriptMethod(452, Lifecycle.CommandScript)]
        public async Task cs_e6_jailbreak_scene()
        {
            ai_play_line(this.ai_current_actor, "0610") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(453, Lifecycle.Dormant)]
        public async Task e6_pro_inf0_main()
        {
            ai_place(e6_pro_inf0_0.Squad);
            ai_place(e6_pro_inf0_1.Squad);
            await sleep_until(async () => (short)ai_combat_status(e6_pro_inf0) > this.ai_combat_status_clear_los || (short)ai_living_count(e6_pro_inf0_0.Squad) <= 2, 15);
            wake(new ScriptMethodReference(music_08b_05_start_alt));
            await sleep_until(async () => (short)ai_living_count(e6_pro_inf0_0.Squad) <= 2);
            ai_place(e6_pro_inf0_2.Squad);
            await sleep(15);
            device_operates_automatically_set(e6_door0.Entity, true);
        }

        [ScriptMethod(454, Lifecycle.Dormant)]
        public async Task e6_cov_hunters0_main()
        {
            ai_migrate(e5_cov_hunters0.Squad, e6_cov_hunters0.Squad);
            if ((short)ai_living_count(e6_cov_hunters0.Squad) >= 2)
            {
                sleep_forever();
            }

            ai_place(e6_cov_hunters0.Squad);
            ai_set_orders(e6_cov_hunters0.Squad, e6_cov_hunters0_engage1);
        }

        [ScriptMethod(455, Lifecycle.Dormant)]
        public async Task e6_cov_inf1_main()
        {
            ai_place(e6_cov_inf1_1.Squad);
            ai_place(e6_cov_inf1_2.Squad);
        }

        [ScriptMethod(456, Lifecycle.Dormant)]
        public async Task e6_cov_inf0_main()
        {
            ai_migrate(e5_cov_inf0.Squad, e6_cov_inf0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e6_main_room, ai_actors(e6_cov_inf0.Squad)));
            await sleep_until(async () => ai_scene("e6_jailbreak_scene", new ScriptMethodReference(cs_e6_jailbreak_scene), e6_cov_inf0.Squad), 30, 300);
            await sleep_until(async () => (short)ai_spawn_count(e6_pro_inf0_2.Squad) > 0 && (short)ai_living_count(e6_pro_inf0_2.Squad) <= 0);
            cs_run_command_script(e6_cov_inf0.Squad, new ScriptMethodReference(cs_e6_jailbreak_behavior));
            await sleep_until(async () => await this.e6_room_cleared());
            game_save();
            ai_migrate(e6_cov_inf1, e6_cov_inf0.Squad);
            ai_set_orders(e6_cov_inf0.Squad, e6_cov_inf0_continue);
        }

        [ScriptMethod(457, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_main_begin, players()), 15);
            this.g_e6_started = true;
            game_save();
            print("e6_main");
            data_mine_set_mission_segment("e6_jail");
            wake(new ScriptMethodReference(music_08b_05_start));
            wake(new ScriptMethodReference(e7_main));
            wake(new ScriptMethodReference(e6_cov_inf0_main));
            wake(new ScriptMethodReference(e6_cov_inf1_main));
            wake(new ScriptMethodReference(e6_cov_hunters0_main));
            wake(new ScriptMethodReference(e6_pro_inf0_main));
            await sleep_until(async () => this.g_e7_started);
            sleep_forever(new ScriptMethodReference(e6_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e6_cov_inf1_main));
            sleep_forever(new ScriptMethodReference(e6_cov_hunters0_main));
            sleep_forever(new ScriptMethodReference(e6_pro_inf0_main));
            ai_disposable(e6_pro, true);
        }

        [ScriptMethod(458, Lifecycle.Static)]
        public async Task test_hunter_room()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e6_test);
            ai_place(e6_cov_inf0.Squad);
            if (!(this.g_e6_started))
            {
                wake(new ScriptMethodReference(e6_main));
            }
        }

        [ScriptMethod(459, Lifecycle.CommandScript)]
        public async Task cs_e5_pro_phantom0_entry()
        {
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e5_pro_phantom0/p0"), GetReference<ISpatialPoint>("e5_pro_phantom0/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e5_pro_phantom0/p1"));
        }

        [ScriptMethod(460, Lifecycle.CommandScript)]
        public async Task cs_e5_pro_phantom0_exit()
        {
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e5_pro_phantom0/p2"), GetReference<ISpatialPoint>("e5_pro_phantom0/p2_facing"));
            cs_fly_by(GetReference<ISpatialPoint>("e5_pro_phantom0/p3"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e5_pro_phantom0/p4"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(461, Lifecycle.Dormant)]
        public async Task e5_pro_phantom0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_pro_phantom0_begin, players()), 15);
            ai_place(e5_pro_phantom0.Squad);
            await sleep_until(async () => object_get_health(ai_vehicle_get(e5_pro_phantom0.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e5_pro_phantom0.phantom0), "target_front") >= 3 || volume_test_objects(tv_e7_main_begin, players()), 30, this.one_minute);
            cs_run_command_script(e5_pro_phantom0.phantom0, new ScriptMethodReference(cs_e5_pro_phantom0_exit));
        }

        [ScriptMethod(462, Lifecycle.Dormant)]
        public async Task e5_pro_inf3_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_pro_inf3_init, players()), 15);
            ai_place(e5_pro_inf3.Squad);
        }

        [ScriptMethod(463, Lifecycle.Dormant)]
        public async Task e5_pro_inf2_main()
        {
            await sleep_until(async () =>
            {
                if ((float)ai_living_count(e5_pro_inf0.Squad) + (float)ai_living_count(e5_pro_inf1.Squad) + (float)ai_living_count(e5_pro_inf2.Squad) < this.g_e5_pro_inf2_limit)
                {
                    ai_place(e5_pro_inf2.Squad, 1);
                }

                return volume_test_objects(tv_e5_bridge_exit, players()) || (short)ai_spawn_count(e5_pro_inf2.Squad) >= this.g_e5_pro_inf2_limit;
            }, 30);
        }

        [ScriptMethod(464, Lifecycle.Dormant)]
        public async Task e5_pro_inf1_main()
        {
            ai_place(e5_pro_inf1.Squad);
        }

        [ScriptMethod(465, Lifecycle.Dormant)]
        public async Task e5_pro_inf0_main()
        {
            ai_place(e5_pro_inf0.Squad);
        }

        [ScriptMethod(466, Lifecycle.Dormant)]
        public async Task e5_cov_hunters0_main()
        {
            await sleep_until(async () => (short)ai_living_count(e4_pro_inf0.Squad) <= 0 && (short)ai_living_count(e4_pro_inf1.Squad) <= 0 && (short)ai_living_count(e4_pro_inf3.Squad) <= 0);
            await sleep_until(async () => (short)structure_bsp_index() == 1, 15);
            await sleep_until(async () => (short)structure_bsp_index() == 0, 15);
            ai_migrate(e4_cov_hunters0.Squad, e5_cov_hunters0.Squad);
            ai_teleport_to_starting_location_if_outside_bsp(e5_cov_hunters0.Squad);
        }

        [ScriptMethod(467, Lifecycle.Dormant)]
        public async Task e5_cov_inf0_main()
        {
            await sleep_until(async () => (short)ai_living_count(e4_pro_inf0.Squad) <= 0 && (short)ai_living_count(e4_pro_inf1.Squad) <= 0 && (short)ai_living_count(e4_pro_inf3.Squad) <= 0);
            await sleep_until(async () => (short)structure_bsp_index() == 1, 15);
            await sleep_until(async () => (short)structure_bsp_index() == 0, 15);
            ai_migrate(e4_cov_inf0.Squad, e5_cov_inf0.Squad);
            ai_teleport_to_starting_location_if_outside_bsp(e5_cov_inf0.Squad);
        }

        [ScriptMethod(468, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_main_begin, players()) && (short)structure_bsp_index() == 0, 15);
            this.g_e5_started = true;
            game_save();
            print("e5_main");
            data_mine_set_mission_segment("e5_bridge");
            weather_change_intensity(0F, 0.5F);
            wake(new ScriptMethodReference(e6_main));
            wake(new ScriptMethodReference(e5_cov_inf0_main));
            wake(new ScriptMethodReference(e5_cov_hunters0_main));
            wake(new ScriptMethodReference(e5_pro_inf0_main));
            wake(new ScriptMethodReference(e5_pro_inf1_main));
            wake(new ScriptMethodReference(e5_pro_inf2_main));
            wake(new ScriptMethodReference(e5_pro_phantom0_main));
            await sleep_until(async () => this.g_e6_started);
            sleep_forever(new ScriptMethodReference(e5_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e5_cov_hunters0_main));
            sleep_forever(new ScriptMethodReference(e5_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e5_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e5_pro_inf2_main));
            sleep_forever(new ScriptMethodReference(e5_pro_phantom0_main));
            ai_disposable(e5_pro, true);
            ai_disposable(e5_pro_phantom0.Squad, false);
        }

        [ScriptMethod(469, Lifecycle.Static)]
        public async Task test_bridge()
        {
            object_teleport(await this.player0(), e5_test);
            ai_place(e5_cov_inf0.Squad);
            ai_place(e5_cov_hunters0.Squad);
            if (!(this.g_e5_started))
            {
                wake(new ScriptMethodReference(e5_main));
            }
        }

        [ScriptMethod(470, Lifecycle.Dormant)]
        public async Task e4_music()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_halfway, players()), 15);
            wake(new ScriptMethodReference(music_08b_04_start));
            await sleep(2);
            game_save();
            await sleep_until(async () => volume_test_objects(tv_e4_main_shutdown, players()), 15);
            wake(new ScriptMethodReference(music_08b_03_stop));
            wake(new ScriptMethodReference(music_08b_04_stop));
        }

        [ScriptMethod(471, Lifecycle.Dormant)]
        public async Task e4_pro_inf3_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_corner, players()) || (short)ai_living_count(e4_pro_inf0.Squad) <= 0 || (short)ai_living_count(e4_pro_inf1.Squad) <= 0, 15);
            ai_place(e4_pro_inf3.Squad, (short)(6 - (float)ai_living_count(e4_pro_inf0.Squad)));
        }

        [ScriptMethod(472, Lifecycle.Dormant)]
        public async Task e4_pro_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_corner, players()) || (short)ai_living_count(e4_pro_inf0.Squad) <= 0 || (short)ai_living_count(e4_pro_inf1.Squad) <= 0, 15);
            ai_place(e4_pro_inf2.Squad);
        }

        [ScriptMethod(473, Lifecycle.Dormant)]
        public async Task e4_pro_inf1_main()
        {
            ai_place(e4_pro_inf1.Squad);
        }

        [ScriptMethod(474, Lifecycle.Dormant)]
        public async Task e4_pro_inf0_main()
        {
            ai_place(e4_pro_inf0.Squad);
        }

        [ScriptMethod(475, Lifecycle.Dormant)]
        public async Task e4_cov_hunters0_main()
        {
            ai_migrate(e3_cov_hunters0.Squad, e4_cov_hunters0.Squad);
        }

        [ScriptMethod(476, Lifecycle.Dormant)]
        public async Task e4_cov_inf0_main()
        {
            ai_migrate(e3_cov_inf0.Squad, e4_cov_inf0.Squad);
        }

        [ScriptMethod(477, Lifecycle.Dormant)]
        public async Task e4_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e4_main_begin, players()), 15);
            this.g_e4_started = true;
            game_save();
            print("e4_main");
            data_mine_set_mission_segment("e4_generator_room");
            wake(new ScriptMethodReference(music_08b_03_start));
            wake(new ScriptMethodReference(e5_main));
            wake(new ScriptMethodReference(e4_cov_inf0_main));
            wake(new ScriptMethodReference(e4_cov_hunters0_main));
            wake(new ScriptMethodReference(e4_pro_inf0_main));
            wake(new ScriptMethodReference(e4_pro_inf1_main));
            wake(new ScriptMethodReference(e4_pro_inf3_main));
            wake(new ScriptMethodReference(e4_music));
            await sleep_until(async () => volume_test_objects(tv_e4_main_shutdown, players()), 15);
            sleep_forever(new ScriptMethodReference(e4_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e4_cov_hunters0_main));
            sleep_forever(new ScriptMethodReference(e4_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e4_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e4_pro_inf2_main));
            sleep_forever(new ScriptMethodReference(e4_pro_inf3_main));
            await sleep_until(async () => this.g_e5_started);
            ai_disposable(e4_pro, true);
        }

        [ScriptMethod(478, Lifecycle.Static)]
        public async Task test_generator_cave()
        {
            switch_bsp(1);
            await sleep(1);
            object_teleport(await this.player0(), e4_test);
            ai_place(e4_cov_inf0.Squad);
            ai_place(e4_cov_hunters0.Squad);
            if (!(this.g_e4_started))
            {
                wake(new ScriptMethodReference(e4_main));
            }
        }

        [ScriptMethod(479, Lifecycle.Static)]
        public async Task<bool> e3_cov_hunters0_break()
        {
            return (short)ai_spawn_count(e3_pro_inf0) > 0 && (short)ai_living_count(e3_pro_inf0_0.Squad) <= 1 || volume_test_objects(tv_e3_player_advance2, players());
        }

        [ScriptMethod(480, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_hunters0_0()
        {
            cs_crouch(true);
            cs_look_player(true);
            unit_impervious(ai_get_unit(this.ai_current_actor), true);
            object_cannot_die(ai_get_object(this.ai_current_actor), true);
            await sleep_until(async () => this.g_e3_hunters_rise || volume_test_objects(tv_e3_player_advance0, players()), 5);
            await sleep(20);
            cs_crouch(false);
            await sleep_until(async () => this.g_e3_hunter0_go || volume_test_objects(tv_e3_player_advance0, players()), 5);
            cs_ignore_obstacles(true);
            cs_look_player(false);
            cs_enable_looking(true);
            cs_start_to(GetReference<ISpatialPoint>("e3_intro_bsp0/p0"));
            await sleep_until(async () => !((bool)cs_moving()) && (short)structure_bsp_index() == 1, 5);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e3_intro_bsp1/p0"));
            cs_crouch(true);
            cs_enable_targeting(true);
            cs_go_to(GetReference<ISpatialPoint>("e3_intro_bsp1/p1_0"));
            await sleep_until(async () => await this.e3_cov_hunters0_break(), 15, this._30_seconds);
            this.g_e3_hunter0_arrived = true;
            ai_renew(this.ai_current_actor);
            unit_impervious(ai_get_unit(this.ai_current_actor), false);
            object_cannot_die(ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(481, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_hunters0_1()
        {
            cs_crouch(true);
            cs_look_player(true);
            unit_impervious(ai_get_unit(this.ai_current_actor), true);
            object_cannot_die(ai_get_object(this.ai_current_actor), true);
            await sleep_until(async () => this.g_e3_hunters_rise || volume_test_objects(tv_e3_player_advance0, players()), 5);
            await sleep(30);
            cs_crouch(false);
            await sleep_until(async () => this.g_e3_hunter1_go || volume_test_objects(tv_e3_player_advance0, players()), 5);
            cs_ignore_obstacles(true);
            cs_look_player(false);
            cs_enable_looking(true);
            cs_start_to(GetReference<ISpatialPoint>("e3_intro_bsp0/p1"));
            await sleep_until(async () => !((bool)cs_moving()) && (short)structure_bsp_index() == 1, 5);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e3_intro_bsp1/p0"));
            cs_crouch(true);
            cs_enable_targeting(true);
            cs_go_to(GetReference<ISpatialPoint>("e3_intro_bsp1/p1_1"));
            await sleep_until(async () => await this.e3_cov_hunters0_break(), 15, this._30_seconds);
            this.g_e3_hunter1_arrived = true;
            ai_renew(this.ai_current_actor);
            unit_impervious(ai_get_unit(this.ai_current_actor), false);
            object_cannot_die(ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(482, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_0()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_crouch(true);
            cs_look_player(true);
            await sleep_until(async () => device_get_position(e2_exit_door.Entity) > 0.1F, 5);
            cs_crouch(false);
            this.g_e3_hunters_rise = true;
            print("elite: hold your fire!");
            await sleep(ai_play_line_at_player(this.ai_current_actor, "0560"));
            cs_jump_to_point(1F, 2.25F);
            await sleep(25);
            print("elite: the hunters rawk");
            ai_play_line_at_player(this.ai_current_actor, "0570") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await sleep(20);
            cs_look_object(true, ai_get_object(e3_cov_hunters0.hunter0));
            await sleep(40);
            this.g_e3_hunter0_go = true;
            cs_look_object(true, ai_get_object(e3_cov_hunters0.hunter1));
            await sleep(30);
            this.g_e3_hunter1_go = true;
            cs_look_object(false, ai_get_object(e3_cov_hunters0.hunter1));
            cs_enable_looking(true);
            cs_move_in_direction(-20F, 0.5F, 0F);
            cs_start_to(GetReference<ISpatialPoint>("e3_intro_bsp0/p2"));
            await sleep_until(async () => !((bool)cs_moving()) && (short)structure_bsp_index() == 1, 5);
            cs_go_to(GetReference<ISpatialPoint>("e3_intro_bsp1/p0"));
            await sleep_until(async () => this.g_e3_hunter0_arrived && this.g_e3_hunter1_arrived);
            cs_go_to(GetReference<ISpatialPoint>("e3_intro_bsp1/p2"));
        }

        [ScriptMethod(483, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_init()
        {
            cs_crouch(true);
            cs_look_player(true);
            await sleep_until(async () => device_get_position(e2_exit_door.Entity) > 0F, 5);
            await sleep(30);
            cs_crouch(false);
            await sleep_until(async () => volume_test_objects(tv_e3_player_advance0, players()), 15, 200);
        }

        [ScriptMethod(484, Lifecycle.CommandScript)]
        public async Task cs_e3_pro_inf2_idle()
        {
            cs_crouch(true);
            await sleep_until(async () => (short)ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_active, 3);
            cs_crouch(false);
            cs_go_to(GetReference<ISpatialPoint>("e3_intro_bsp1/p3"));
        }

        [ScriptMethod(485, Lifecycle.CommandScript)]
        public async Task cs_e3_weapon_scene()
        {
            cs_play_line("0580");
        }

        [ScriptMethod(486, Lifecycle.Dormant)]
        public async Task e3_weapon_scene()
        {
            await sleep_until(async () => ai_scene("e3_weapons_scene", new ScriptMethodReference(cs_e3_weapon_scene), e3_cov));
        }

        [ScriptMethod(487, Lifecycle.Dormant)]
        public async Task e3_objective_failsafe()
        {
            await sleep_until(async () => device_get_position(e2_exit_door.Entity) > 0F, 5, 30);
            wake(new ScriptMethodReference(objective1_set));
        }

        [ScriptMethod(488, Lifecycle.Dormant)]
        public async Task e3_pro_inf2_main()
        {
            await sleep_until(async () => (short)structure_bsp_index() == 1, 5);
            ai_place(e3_pro_inf2.Squad);
        }

        [ScriptMethod(489, Lifecycle.Dormant)]
        public async Task e3_pro_inf1_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e3_pro_inf1_begin, players()), 15);
            ai_place(e3_pro_inf1.Squad);
        }

        [ScriptMethod(490, Lifecycle.Dormant)]
        public async Task e3_pro_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e3_pro_inf0_begin, players()), 15);
            ai_place(e3_pro_inf0_0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e3_player_advance2, players()) || (short)ai_living_count(e3_pro_inf0) <= 2, 15);
            ai_place(e3_pro_inf0_1.Squad, (short)pin(7F - (float)ai_living_count(e3_pro_inf0), 2F, 4F));
        }

        [ScriptMethod(491, Lifecycle.Dormant)]
        public async Task e3_cov_hunters0_main()
        {
            ai_place(e3_cov_hunters0.Squad);
            cs_run_command_script(e3_cov_hunters0.hunter0, new ScriptMethodReference(cs_e3_cov_hunters0_0));
            cs_run_command_script(e3_cov_hunters0.hunter1, new ScriptMethodReference(cs_e3_cov_hunters0_1));
        }

        [ScriptMethod(492, Lifecycle.Dormant)]
        public async Task e3_cov_inf0_main()
        {
            ai_place(e3_cov_inf0.Squad);
            await sleep_until(async () => device_get_position(e2_exit_door.Entity) > 0F, 5, 30);
            wake(new ScriptMethodReference(music_08b_02_stop));
        }

        [ScriptMethod(493, Lifecycle.Dormant)]
        public async Task e3_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e3_main_begin, players()), 15);
            this.g_e3_started = true;
            game_save();
            print("e3_main");
            data_mine_set_mission_segment("e3_ramp_room");
            wake(new ScriptMethodReference(e4_main));
            wake(new ScriptMethodReference(e3_cov_inf0_main));
            wake(new ScriptMethodReference(e3_cov_hunters0_main));
            wake(new ScriptMethodReference(e3_pro_inf0_main));
            wake(new ScriptMethodReference(e3_objective_failsafe));
            await sleep_until(async () => this.g_e4_started);
            sleep_forever(new ScriptMethodReference(e3_cov_inf0_main));
            sleep_forever(new ScriptMethodReference(e3_cov_hunters0_main));
            sleep_forever(new ScriptMethodReference(e3_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e3_pro_inf1_main));
            sleep_forever(new ScriptMethodReference(e3_pro_inf2_main));
            ai_disposable(e3_pro, true);
            await sleep_until(async () => this.g_e5_started);
            ai_erase(e3_cov);
            ai_erase(e3_pro);
        }

        [ScriptMethod(494, Lifecycle.Static)]
        public async Task test_ramp_room()
        {
            object_teleport(await this.player0(), e3_test);
            if (!(this.g_e3_started))
            {
                wake(new ScriptMethodReference(e3_main));
            }

            device_operates_automatically_set(e2_exit_door.Entity, true);
        }

        [ScriptMethod(495, Lifecycle.Dormant)]
        public async Task e2_dialogue()
        {
            await sleep_until(async () => objects_can_see_object(players(), scarab.Entity, 15F) && (bool)game_safe_to_save(), 15, 300);
            await sleep_until(async () => objects_can_see_object(players(), scarab.Entity, 15F), 15, this._30_seconds);
            await sleep(ai_play_line_at_player(object_get_ai(this.g_cov_commander), "0520"));
            await sleep_until(async () => objects_can_see_object(players(), e2_exit_door.Entity, 15F) && (bool)game_safe_to_save(), 15, 300);
            await sleep_until(async () => objects_can_see_object(players(), e2_exit_door.Entity, 15F), 15, this._30_seconds);
            await sleep(ai_play_line_at_player(object_get_ai(this.g_cov_commander), "0530"));
            game_save();
            wake(new ScriptMethodReference(objective0_clear));
            wake(new ScriptMethodReference(objective1_set));
            await sleep_until(async () => (short)ai_spawn_count(e2_pro_wraith0) > 0 && (short)ai_living_count(e2_pro_wraith0) <= 0 && volume_test_objects(tv_e2_near_perimeter, players()) && (bool)game_safe_to_save());
            await sleep(ai_play_line_at_player(object_get_ai(this.g_cov_commander), "0540"));
        }

        [ScriptMethod(496, Lifecycle.Dormant)]
        public async Task e2_door_unlocker()
        {
            await sleep_until(async () => (short)ai_spawn_count(e2_pro_wraith0) > 0 && (short)ai_living_count(e2_pro_wraith0) <= 0);
            await sleep_until(async () => volume_test_objects(tv_e3_main_begin, players()), 15);
            device_operates_automatically_set(e2_exit_door.Entity, true);
        }

        [ScriptMethod(497, Lifecycle.CommandScript)]
        public async Task cs_e2_pro_phantom0_0_entry()
        {
            cs_fly_to(GetReference<ISpatialPoint>("e2_pro_phantom0_0/p0"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1"), GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1_facing"));
        }

        [ScriptMethod(498, Lifecycle.CommandScript)]
        public async Task cs_e2_pro_phantom0_0_exit()
        {
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1"), GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1_facing"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1"), GetReference<ISpatialPoint>("e2_pro_phantom0_0/p2"), 0.5F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e2_pro_phantom0_0/p2"), GetReference<ISpatialPoint>("e2_pro_phantom0_0/p3"), 1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e2_pro_phantom0_0/p3"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(499, Lifecycle.Static)]
        public async Task e2_pro_ghosts0_enter()
        {
            ai_enter_squad_vehicles(this.ai_current_squad);
        }

        [ScriptMethod(500, Lifecycle.Dormant)]
        public async Task e2_pro_phantoms0_main()
        {
            ai_place(e2_pro_phantom0_0.Squad);
            await sleep_until(async () => object_get_health(ai_vehicle_get(e2_pro_phantom0_0.phantom0)) <= 0.05F || object_model_targets_destroyed(ai_vehicle_get(e2_pro_phantom0_0.phantom0), "target_front") >= 3, 30, this.one_minute);
            cs_run_command_script(e2_pro_phantom0_0.phantom0, new ScriptMethodReference(cs_e2_pro_phantom0_0_exit));
            wake(new ScriptMethodReference(music_08b_01_stop));
            wake(new ScriptMethodReference(music_08b_02_start));
        }

        [ScriptMethod(501, Lifecycle.Dormant)]
        public async Task e2_pro_wraiths0_main()
        {
            await sleep(150);
            await sleep_until(async () => volume_test_objects(tv_e2_pro_wraiths0_begin, players()) || (short)ai_living_count(e2_pro_phantom0) <= 0, 15);
            ai_place(e2_pro_wraith0);
            await sleep_until(async () => (short)ai_living_count(e2_pro_wraith0) <= 0);
            game_save();
        }

        [ScriptMethod(502, Lifecycle.Dormant)]
        public async Task e2_pro_ghosts0_main()
        {
            ai_place(e2_pro_ghosts0);
        }

        [ScriptMethod(503, Lifecycle.Dormant)]
        public async Task e2_pro_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e2_near_perimeter, players()), 15);
            ai_place(e2_pro_inf0.Squad);
            await sleep_until(async () => (short)ai_living_count(e2_pro_inf0.Squad) <= 0);
            game_save();
        }

        [ScriptMethod(504, Lifecycle.Dormant)]
        public async Task e2_cov_wraith0_main()
        {
            ai_migrate(e1_cov_wraiths0, e2_cov_wraith0.Squad);
        }

        [ScriptMethod(505, Lifecycle.Dormant)]
        public async Task e2_cov_spectre0_main()
        {
            ai_migrate(e1_cov_spectre0.Squad, e2_cov_spectre0.Squad);
        }

        [ScriptMethod(506, Lifecycle.Dormant)]
        public async Task e2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e2_main_begin, players()), 15);
            this.g_e2_started = true;
            game_save();
            print("e2_main");
            data_mine_set_mission_segment("e2_scarab_cove");
            wake(new ScriptMethodReference(e3_main));
            wake(new ScriptMethodReference(e2_cov_spectre0_main));
            wake(new ScriptMethodReference(e2_cov_wraith0_main));
            wake(new ScriptMethodReference(e2_pro_inf0_main));
            wake(new ScriptMethodReference(e2_pro_wraiths0_main));
            wake(new ScriptMethodReference(e2_pro_phantoms0_main));
            wake(new ScriptMethodReference(e2_dialogue));
            wake(new ScriptMethodReference(e2_door_unlocker));
            await sleep_until(async () => this.g_e3_started);
            ai_disposable(e2_pro, true);
            ai_disposable(e2_pro_phantom0, false);
            await sleep_until(async () => this.g_e4_started);
            sleep_forever(new ScriptMethodReference(e2_cov_spectre0_main));
            sleep_forever(new ScriptMethodReference(e2_cov_wraith0_main));
            sleep_forever(new ScriptMethodReference(e2_pro_inf0_main));
            sleep_forever(new ScriptMethodReference(e2_pro_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e2_pro_wraiths0_main));
            sleep_forever(new ScriptMethodReference(e2_pro_phantoms0_main));
            ai_disposable(e2_cov, true);
        }

        [ScriptMethod(507, Lifecycle.Static)]
        public async Task test_scarab_cove()
        {
            object_teleport(await this.player0(), e2_test);
            if (!(this.g_e2_started))
            {
                wake(new ScriptMethodReference(e2_main));
            }

            ai_place(e2_cov_wraith0.Squad);
            ai_place(e2_cov_spectre0.Squad);
        }

        [ScriptMethod(508, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_phantom0_exit()
        {
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p0"), GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"), 1F);
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p2"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p3"), GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(509, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_phantom0_entry()
        {
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p0"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p1"), GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p1_facing"), 0.5F);
            cs_fly_to(GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p2"), 0.5F);
            await sleep(30);
            vehicle_unload(ai_vehicle_get(this.ai_current_actor), "phantom_lc");
            ai_braindead(e1_pro_wraith0.Squad, false);
            await sleep(30);
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p1"), 0.5F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p0"), GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"), 1F);
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p2"));
            cs_fly_to_and_face(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p3"), GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(510, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_spectre0_init()
        {
            cs_go_to(GetReference<ISpatialPoint>("e1_cov_spectre0_entry/p0"));
            ai_overcomes_oversteer(this.ai_current_actor, true);
            cs_face(true, GetReference<ISpatialPoint>("e1_cov_spectre0_entry/p1"));
            await sleep_until(async () => await this.players_in_vehicle() && unit_in_vehicle(this.g_cov_commander) || volume_test_objects(tv_e1_canyon_entry, players()), 10);
            ai_overcomes_oversteer(this.ai_current_actor, false);
            cs_face(false, GetReference<ISpatialPoint>("e1_cov_spectre0_entry/p1"));
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(e1_cov_spectre0.spectre0));
        }

        [ScriptMethod(511, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_spectre0_passenger()
        {
            cs_look_player(true);
            cs_face_player(true);
            await sleep_until(async () => await this.players_in_vehicle() && unit_in_vehicle(this.g_cov_commander), 10);
            cs_look_player(false);
            cs_face_player(false);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(e1_cov_spectre0.spectre0));
        }

        [ScriptMethod(512, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_commander0_legendary()
        {
            cs_face_player(true);
            await sleep_until(async () => await this.players_in_vehicle() || volume_test_objects(tv_e1_canyon_entry, players()), 15);
            cs_look_player(false);
            cs_face_player(false);
        }

        [ScriptMethod(513, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_commander0_init()
        {
            ai_vehicle_exit(this.ai_current_actor);
            await sleep_until(async () => !(unit_in_vehicle(ai_get_unit(this.ai_current_actor))), 5);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_cov_spectre0_entry/soc_p0"));
            cs_face_player(true);
            await sleep_until(async () => vehicle_test_seat_list(ai_vehicle_get_from_starting_location(e1_cov_wraiths0_0.wraith0), "wraith_d", players()) || await this.players_in_vehicle() || volume_test_objects(tv_e1_canyon_entry, players()), 15);
            cs_look_player(false);
            cs_face_player(false);
            if (vehicle_test_seat_list(ai_vehicle_get_from_starting_location(e1_cov_wraiths0_0.wraith0), "wraith_d", players()))
            {
                cs_go_to_vehicle(ai_vehicle_get_from_starting_location(e1_cov_spectre0.spectre0));
            }
            else
            {
                cs_go_to_vehicle(ai_vehicle_get_from_starting_location(e1_cov_wraiths0_0.wraith0));
            }
        }

        [ScriptMethod(514, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_2_entry0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p8"));
        }

        [ScriptMethod(515, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_2_entry1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p9"));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p10"));
        }

        [ScriptMethod(516, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_1_entry0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p5"));
        }

        [ScriptMethod(517, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_1_entry1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p6"));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p7"));
        }

        [ScriptMethod(518, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_0_entry0()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p0"));
        }

        [ScriptMethod(519, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_0_entry1()
        {
            cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            cs_vehicle_boost(true);
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p2"));
            cs_go_to(GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p3"));
        }

        [ScriptMethod(520, Lifecycle.Static)]
        public async Task<bool> e1_pro_ghosts0_weak()
        {
            return (float)ai_living_count(e1_pro_ghosts0) + (float)ai_living_count(e1_pro_wraith0.Squad) <= this.g_e1_ghosts_weak;
        }

        [ScriptMethod(521, Lifecycle.Static)]
        public async Task<bool> e1_pro_ghosts0_strong()
        {
            return (float)ai_living_count(e1_pro_ghosts0) + (float)ai_living_count(e1_pro_wraith0.Squad) >= this.g_e1_ghosts_strong;
        }

        [ScriptMethod(522, Lifecycle.Dormant)]
        public async Task e1_weather()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_advance0, players()), 16);
            weather_change_intensity(60F, 0.4F);
            await sleep_until(async () => volume_test_objects(tv_e1_advance1, players()), 16);
            weather_change_intensity(60F, 0.7F);
            await sleep_until(async () => volume_test_objects(tv_e1_advance2, players()), 16);
            weather_change_intensity(60F, 1F);
        }

        [ScriptMethod(523, Lifecycle.Dormant)]
        public async Task e1_pro_phantom0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_advance1, players()), 15);
            ai_place(e1_pro_wraith0.Squad);
            await sleep_until(async () => volume_test_objects(tv_e1_advance3, players()), 15);
            wake(new ScriptMethodReference(music_08b_01_start_alt));
        }

        [ScriptMethod(524, Lifecycle.Dormant)]
        public async Task e1_pro_ghosts0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_canyon_entry, players()), 15);
            ai_place(e1_pro_ghosts0_0.Squad);
            await sleep_until(async () =>
            {
                if (await this.e1_pro_ghosts0_weak())
                {
                    await sleep_until(async () =>
                    {
                        ai_place(e1_pro_ghosts0_0.Squad, 1);
                        return await this.e1_pro_ghosts0_strong() || (short)ai_spawn_count(e1_pro_ghosts0_0.Squad) >= this.g_e1_ghosts_per_leg || volume_test_objects(tv_e1_advance0, players());
                    });
                }

                return volume_test_objects(tv_e1_advance0, players());
            });
            game_save_no_timeout();
            await sleep_until(async () =>
            {
                if (await this.e1_pro_ghosts0_weak())
                {
                    await sleep_until(async () =>
                    {
                        ai_place(e1_pro_ghosts0_1.Squad, 1);
                        return await this.e1_pro_ghosts0_strong() || (short)ai_spawn_count(e1_pro_ghosts0_1.Squad) >= this.g_e1_ghosts_per_leg || volume_test_objects(tv_e1_advance2, players());
                    });
                }

                return volume_test_objects(tv_e1_advance2, players());
            });
            game_save_no_timeout();
            await sleep_until(async () =>
            {
                if (await this.e1_pro_ghosts0_weak())
                {
                    await sleep_until(async () =>
                    {
                        ai_place(e1_pro_ghosts0_2.Squad, 1);
                        return await this.e1_pro_ghosts0_strong() || (short)ai_spawn_count(e1_pro_ghosts0_2.Squad) >= this.g_e1_ghosts_per_leg || volume_test_objects(tv_e1_advance4, players());
                    });
                }

                return volume_test_objects(tv_e1_advance4, players());
            });
            game_save();
        }

        [ScriptMethod(525, Lifecycle.Dormant)]
        public async Task e1_pro_inf0_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_advance1, players()));
            ai_place(e1_pro_inf0_0.Squad);
        }

        [ScriptMethod(526, Lifecycle.Dormant)]
        public async Task e1_cov_spectre0_main()
        {
            ai_place(e1_cov_spectre0.Squad);
            await sleep(10);
            object_type_predict(GetTag<BaseTag>("objects\\vehicles\\spectre\\spectre", 3869771058U));
        }

        [ScriptMethod(527, Lifecycle.Dormant)]
        public async Task e1_cov_wraiths0_main()
        {
            ai_place(e1_cov_wraiths0_0.Squad);
            object_cannot_die(ai_get_object(e1_cov_wraiths0_0.wraith0), true);
            this.g_cov_commander = ai_get_unit(e1_cov_wraiths0_0.wraith0);
            if (await this.difficulty_legendary())
            {
                unit_set_enterable_by_player(ai_vehicle_get(e1_cov_wraiths0_0.wraith0), false);
                cs_run_command_script(e1_cov_wraiths0_0.wraith0, new ScriptMethodReference(cs_e1_cov_commander0_legendary));
            }
            else
            {
                cs_run_command_script(e1_cov_wraiths0_0.wraith0, new ScriptMethodReference(cs_e1_cov_commander0_init));
            }

            await sleep_until(async () => await this.players_in_vehicle() || volume_test_objects(tv_e1_canyon_entry, players()), 15);
            wake(new ScriptMethodReference(music_08b_01_start));
        }

        [ScriptMethod(528, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            this.g_e1_started = true;
            print("e1_main");
            data_mine_set_mission_segment("e1_wraith_canyon");
            wake(new ScriptMethodReference(objective0_set));
            wake(new ScriptMethodReference(e2_main));
            wake(new ScriptMethodReference(e1_cov_wraiths0_main));
            wake(new ScriptMethodReference(e1_cov_spectre0_main));
            wake(new ScriptMethodReference(e1_pro_ghosts0_main));
            wake(new ScriptMethodReference(e1_pro_phantom0_main));
            wake(new ScriptMethodReference(e1_pro_inf0_main));
            wake(new ScriptMethodReference(e1_weather));
            await sleep_until(async () => this.g_e2_started);
            ai_disposable(e1_pro, true);
            ai_disposable(e1_pro_phantom0.Squad, false);
            await sleep_until(async () => this.g_e3_started);
            sleep_forever(new ScriptMethodReference(e1_cov_wraiths0_main));
            sleep_forever(new ScriptMethodReference(e1_pro_ghosts0_main));
            sleep_forever(new ScriptMethodReference(e1_pro_phantom0_main));
            sleep_forever(new ScriptMethodReference(e1_pro_inf0_main));
        }

        [ScriptMethod(529, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            object_cannot_take_damage(players());
            object_hide(await this.player0(), true);
            object_hide(await this.player1(), true);
            await this.cinematic_snap_to_white();
            await this.cinematic_intro();
            object_teleport(await this.player0(), player0_start);
            object_teleport(await this.player1(), player1_start);
            object_hide(await this.player0(), false);
            object_hide(await this.player1(), false);
            object_can_take_damage(players());
            wake(new ScriptMethodReference(e1_main));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(15);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_title0));
            await sleep_until(async () => this.g_mission_over, 5);
            await this.playtest_mission();
            await sleep(15);
            object_cannot_take_damage(players());
            object_teleport(await this.player0(), player0_stash);
            object_teleport(await this.player1(), player1_stash);
            await this.cinematic_epilogue();
            game_won();
        }

        [ScriptMethod(530, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(531, Lifecycle.Startup)]
        public async Task mission_main()
        {
            ai_allegiance(player, covenant);
            ai_allegiance(player, human);
            ai_allegiance(covenant, human);
            weather_start(0F);
            weather_change_intensity(0F, 0.1F);
            kill_volume_disable(kill_e13_0);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(532, Lifecycle.Dormant)]
        public async Task _08_intra1_04_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3880125904U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3881633255U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3883664902U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 68);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 70);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 9);
            await sleep(6);
            await sleep(24);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await sleep(129);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 17);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 70, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 79, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 69, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 67, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 35, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            await sleep(66);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3880125904U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 3);
            await sleep(155);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 32);
            await sleep(72);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 2);
            await sleep(12);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 80, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 70, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 79, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 69, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 67, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 35, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
        }

        [ScriptMethod(533, Lifecycle.Dormant)]
        public async Task _08_intra2_01_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 44, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 38, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 89, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3881633255U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 46, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3891398268U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 66);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 67);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 68);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 70);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 71);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 24, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 16);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 17);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 18);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 20);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 21);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 22);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 23);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 24);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 25);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 27);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 28);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 29);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 30);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 31);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_cam\\scarab_cam", 3893167767U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3893495452U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3894216359U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3894544044U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3895002803U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 41, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 40, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 16, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3900114689U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_small\\door_small", 3901359892U), 1);
            await sleep(115);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3901622040U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            await sleep(71);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 13, false);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_small\\door_small", 3901359892U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            await sleep(86);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 40, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
        }

        [ScriptMethod(534, Lifecycle.Dormant)]
        public async Task _08_intra2_02_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            await sleep(69);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 7, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 42, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3881633255U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            await sleep(151);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 68, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            await sleep(244);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
        }

        [ScriptMethod(535, Lifecycle.Dormant)]
        public async Task _08_intra3_01_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_walkway\\control_walkway", 3906340704U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3908437888U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_boss_platform\\control_boss_platform", 3909355406U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
            await sleep(355);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(83);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
        }

        [ScriptMethod(536, Lifecycle.Dormant)]
        public async Task _08_intra3_02_predict()
        {
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            await sleep(36);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 2);
            await sleep(33);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            await sleep(72);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            await sleep(200);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(21);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            await sleep(72);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await sleep(174);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
        }

        [ScriptMethod(537, Lifecycle.Dormant)]
        public async Task _08_intra3_03_predict()
        {
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await sleep(157);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(28);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 2);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            await sleep(47);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await sleep(54);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            await sleep(90);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            await sleep(60);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
        }

        [ScriptMethod(538, Lifecycle.Dormant)]
        public async Task _08_intra3_04_predict()
        {
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await sleep(186);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(185);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await sleep(250);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
        }

        [ScriptMethod(539, Lifecycle.Dormant)]
        public async Task _08_intra3_05_predict()
        {
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3913549774U), 0);
            await sleep(51);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3913549774U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await sleep(18);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            await sleep(107);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
        }

        [ScriptMethod(540, Lifecycle.Dormant)]
        public async Task _08_intra3_06_predict()
        {
            print("next scene has no prediction...yet");
        }

        [ScriptMethod(541, Lifecycle.Dormant)]
        public async Task x09_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3891398268U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 17);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_rotors\\control_rotors", 3913942996U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_room\\grav_lift\\grav_lift", 3914401755U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await sleep(64);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            await sleep(57);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            await sleep(75);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_room\\grav_lift\\grav_lift", 3914401755U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await sleep(35);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await sleep(33);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_room\\grav_lift\\grav_lift", 3914401755U), 0);
            await sleep(53);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3908437888U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 6, true);
            await sleep(29);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
        }

        [ScriptMethod(542, Lifecycle.Dormant)]
        public async Task x09_02_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 8, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(58);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            await sleep(15);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 6, true);
            await sleep(129);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 62, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 77, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 22, false);
        }

        [ScriptMethod(543, Lifecycle.Dormant)]
        public async Task x09_03_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 88, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 44, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 89, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 52, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\control_room_beam\\control_room_beam", 3915122662U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 5);
            await sleep(166);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 41, false);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 46, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3891398268U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 46, false);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 60, false);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 49, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 63, false);
        }

        [ScriptMethod(544, Lifecycle.Dormant)]
        public async Task x09_04_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 75, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3915188199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3915515884U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_halo_quarter\\delta_halo_quarter", 3915712495U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3915909106U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785097254U), 0);
            await sleep(131);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\halo_disarm\\halo_disarm", 3916564476U), 0);
        }

        [ScriptMethod(545, Lifecycle.Dormant)]
        public async Task x09_05_predict()
        {
            await sleep(10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3908437888U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\beacon_halo_holo\\beacon_halo_holo", 3916630013U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            await sleep(113);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            await sleep(15);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            await sleep(31);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            await sleep(210);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
        }

        [ScriptMethod(546, Lifecycle.Dormant)]
        public async Task x09_06_predict()
        {
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(303);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            await sleep(77);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 6, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\beacon_halo_holo\\beacon_halo_holo", 3916630013U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 8, true);
            await sleep(126);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            await sleep(39);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await sleep(46);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            await sleep(140);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await sleep(114);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 62, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 77, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 22, false);
        }

        [ScriptMethod(547, Lifecycle.Dormant)]
        public async Task x09_07_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 75, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\moon\\moon", 3917809679U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 3918006290U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship\\forerunner_ship", 3918202901U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3919317030U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785097254U), 0);
            await sleep(123);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3919317030U), 0);
            await sleep(36);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\forerunner_ship_alcove", 3919448104U), 0);
        }

        [ScriptMethod(548, Lifecycle.Dormant)]
        public async Task x09_08_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3920758844U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 19);
            await sleep(5);
            await sleep(119);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3921610825U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3921610825U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 3922397269U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3919317030U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 3926198415U), 0);
            await sleep(153);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3920758844U), 0);
            await sleep(678);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
        }

        [ScriptMethod(549, Lifecycle.Dormant)]
        public async Task x10_01_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\flood\\flood_spore\\flood_spore", 3926329489U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 7);
            await sleep(19);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            await sleep(11);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            await sleep(17);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 20, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 9);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 11);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 13);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 15);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3893495452U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3894216359U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3894544044U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3895002803U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3900114689U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3926526100U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3927050396U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3927115933U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\multi\\lockout\\power_module\\power_module", 3927443618U), 0);
            await sleep(18);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 1);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, true);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 28, true);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3927902377U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3927902377U), 1);
            await sleep(28);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            await sleep(15);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\garbage\\cov_gravcolumn_top\\cov_gravcolumn_top", 3928688821U), 0);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 3929606339U), 1);
            await sleep(18);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3930720468U), 0);
            await sleep(5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_clump\\flood_clump", 3931506912U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_sack\\flood_sack", 3931769060U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_pod\\flood_pod", 3931965671U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_floor_clump_small\\flood_floor_clump_small", 3932031208U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3932096745U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3933145337U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3933210874U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_generator\\flood_generator", 3933276411U), 0);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\garbage\\cov_gravcolumn_bottom_garbage_1\\cov_gravcolumn_bottom_garbage_1", 3933341948U), 0);
        }

        [ScriptMethod(550, Lifecycle.Dormant)]
        public async Task x10_02_predict()
        {
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3930720468U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3933473022U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3933800707U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3933800707U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3933800707U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3901622040U), 0);
            await sleep(236);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            await sleep(130);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            await sleep(61);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3933210874U), 0);
        }
    }
}