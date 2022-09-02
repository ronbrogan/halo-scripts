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
            this.tick_seconds = Engine.game_tick_rate();
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

        [ScriptMethod(24, Lifecycle.CommandScript)]
        public async Task cs_boss_brutes_stunned()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_moving(false);
            Engine.cs_pause(1F);
            Engine.cs_abort_on_damage(true);
            Engine.cs_pause(1F);
        }

        [ScriptMethod(25, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_stunned()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_moving(false);
            Engine.sleep_forever();
        }

        [ScriptMethod(26, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_jump()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("boss/mid_land"));
            Engine.cs_face_player(true);
        }

        [ScriptMethod(27, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_cheer()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_enable_targeting(false);
            Engine.cs_face_player(true);
            await Engine.sleep(60);
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 3826188953U), "combat:rifle:cheer", true);
            await Engine.sleep(60);
        }

        [ScriptMethod(28, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_taunt()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_enable_targeting(false);
            Engine.cs_face_player(true);
            await Engine.sleep(60);
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 3826188953U), "combat:rifle:taunt", true);
            await Engine.sleep(60);
        }

        [ScriptMethod(29, Lifecycle.CommandScript)]
        public async Task cs_boss_tartarus_shakefist()
        {
            Engine.cs_enable_moving(false);
            Engine.cs_enable_targeting(false);
            Engine.cs_face_player(true);
            await Engine.sleep(60);
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\brute", 3826188953U), "combat:rifle:shakefist", true);
            await Engine.sleep(60);
        }

        [ScriptMethod(30, Lifecycle.CommandScript)]
        public async Task cs_boss_johnson_idle()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_moving(false);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("boss/ledge_perch"));
            Engine.cs_crouch(true);
            Engine.cs_face_object(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.cs_aim_object(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.print("johnson idle");
            Engine.sleep_forever();
        }

        [ScriptMethod(31, Lifecycle.CommandScript)]
        public async Task cs_boss_johnson_idle2()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_moving(false);
            Engine.cs_crouch(true);
            Engine.cs_face_object(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.cs_aim_object(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.print("johnson idle2");
            Engine.sleep_forever();
        }

        [ScriptMethod(32, Lifecycle.CommandScript)]
        public async Task cs_boss_johnson_shoot()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_moving(false);
            Engine.cs_crouch(true);
            Engine.cs_face_object(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.cs_aim_object(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.cs_shoot(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.print("shot 1");
            await Engine.sleep(5);
            Engine.cs_shoot(false, Engine.ai_get_object(boss_tartarus.Squad));
            await Engine.sleep(11);
            Engine.cs_shoot(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.print("shot 2");
            await Engine.sleep(5);
            Engine.cs_shoot(false, Engine.ai_get_object(boss_tartarus.Squad));
            await Engine.sleep(11);
            Engine.cs_shoot(true, Engine.ai_get_object(boss_tartarus.Squad));
            Engine.print("shot 3");
            await Engine.sleep(15);
        }

        [ScriptMethod(33, Lifecycle.CommandScript)]
        public async Task cs_boss_miranda_nocrouch()
        {
            Engine.cs_crouch(false);
            Engine.sleep_forever();
        }

        [ScriptMethod(34, Lifecycle.Static)]
        public async Task boss_tartarus_taunt()
        {
            if (this.counter_boss_tartarus_taunt == 0)
            {
                Engine.print("what? is the mighty arbiter afraid?!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_0980_tar", 3828286137U), Engine.ai_get_object(boss_tartarus.Squad), 1F);
            }
            else if (this.counter_boss_tartarus_taunt == 1)
            {
                Engine.print("you want revenge?! well here i am! come and take it!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_0990_tar", 3828351674U), Engine.ai_get_object(boss_tartarus.Squad), 1F);
            }
            else if (this.counter_boss_tartarus_taunt == 2)
            {
                Engine.print("just like the rest of your kind - you are cowardly and weak!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1000_tar", 3828417211U), Engine.ai_get_object(boss_tartarus.Squad), 1F);
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
            await Engine.sleep(45);
            if (this.counter_boss_johnson_prompt == (short)(1 * this.skip_boss_johnson_prompt))
            {
                Engine.print("hey, mohawk! how'd that feel?!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2010_jon", 3828482748U), Engine.ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(2 * this.skip_boss_johnson_prompt))
            {
                Engine.print("his shield is down! let him have it!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2020_jon", 3828548285U), Engine.ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(3 * this.skip_boss_johnson_prompt))
            {
                Engine.print("there goes his shield!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2030_jon", 3828613822U), Engine.ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(4 * this.skip_boss_johnson_prompt))
            {
                Engine.print("got his shield! hit him now!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2040_jon", 3828679359U), Engine.ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(5 * this.skip_boss_johnson_prompt))
            {
                Engine.print("quick! while his shield is down!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2050_jon", 3828744896U), Engine.ai_get_object(boss_johnson.Squad), 1F);
            }
            else if (this.counter_boss_johnson_prompt == (short)(6 * this.skip_boss_johnson_prompt))
            {
                Engine.print("i can keep his shield down, but you're gonna have to finish the job!");
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_2060_jon", 3828810433U), Engine.ai_get_object(boss_johnson.Squad), 1F);
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
            await Engine.sleep((short)(5 * 30));
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\deltacontolroom\\boss\\stage1", 3828875970U), default(IGameObject), 1F);
            await Engine.sleep((short)(5 * 30));
            Engine.print("charging sequence initiated! primary generators coming on-line!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1040_gsp", 3828941507U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1040_gsp", 3828941507U)));
            Engine.print("well, shut them down!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1050_mir", 3829007044U), Engine.ai_get_object(boss_miranda.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1050_mir", 3829007044U)));
            Engine.print("apology. protocol does allow me to interfere with any aspect of the sequence.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1060_gsp", 3829072581U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1060_gsp", 3829072581U)));
            Engine.print("then how do i stop it?!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1120_mir", 3829138118U), Engine.ai_get_object(boss_miranda.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1120_mir", 3829138118U)));
            Engine.print("well�it will take some time to go over the proper procedures�");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1130_gsp", 3829203655U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1130_gsp", 3829203655U)));
            Engine.print("quit stalling!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1140_mir", 3829269192U), Engine.ai_get_object(boss_miranda.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1140_mir", 3829269192U)));
            Engine.print("under more controlled circumstances, i would suggest the reclaimer simply remove the index.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1150_gsp", 3829334729U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1150_gsp", 3829334729U)));
            Engine.print("that's it?! johnson, i'm on it!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1160_mir", 3829400266U), Engine.ai_get_object(boss_miranda.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1160_mir", 3829400266U)));
            Engine.print("hang-tight, ma'am! not until that brute is dead!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1170_jon", 3829465803U), Engine.ai_get_object(boss_johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1170_jon", 3829465803U)));
            this.boss_flavor_done = true;
            await Engine.sleep((short)(30 * 30));
            this.boss_flavor_done = false;
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\deltacontolroom\\boss\\stage2", 3829531340U), default(IGameObject), 1F);
            await Engine.sleep((short)(5 * 30));
            Engine.print("secondary generators charging! all systems are performing well within operational parameters!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1070_gsp", 3829596877U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1070_gsp", 3829596877U)));
            Engine.print("you're telling me you can't stop the sequence?");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1080_mir", 3829662414U), Engine.ai_get_object(boss_miranda.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1080_mir", 3829662414U)));
            Engine.print("reclaimer, please understand: interrupting the wave-generation process will severely damage this installation.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1090_gsp", 3829727951U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1090_gsp", 3829727951U)));
            Engine.print("give me a direct answer!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1100_mir", 3829793488U), Engine.ai_get_object(boss_miranda.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1100_mir", 3829793488U)));
            Engine.print("i am but a monitor. the reclaimer can do what it likes.");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1110_gsp", 3829859025U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1110_gsp", 3829859025U)));
            this.boss_flavor_done = true;
            await Engine.sleep((short)(30 * 30));
            this.boss_flavor_done = false;
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\ambience\\deltacontolroom\\boss\\stage3", 3829924562U), default(IGameObject), 1F);
            await Engine.sleep((short)(5 * 30));
            Engine.print("power-generation phase complete! the installation is ready to fire! starting final countdown�");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1180_gsp", 3829990099U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1180_gsp", 3829990099U)));
            Engine.print("c'mon, arbiter! kick that guy's ass!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1190_jon", 3830055636U), Engine.ai_get_object(boss_johnson.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1190_jon", 3830055636U)));
            Engine.print("and may i say, reclaimers, it has been a pleasure to serve you both! goodbye!");
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1200_gsp", 3830121173U), Engine.ai_get_object(boss_monitor.Squad), 1F);
            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1200_gsp", 3830121173U)));
            this.boss_flavor_done = true;
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task boss_music()
        {
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_11", 3830186710U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_boss_platform, Engine.players()));
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_12", 3830579932U), default(IGameObject), 1F);
            await Engine.sleep_until(async () => !(this.mark_boss_first_cycle));
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_13", 3830973154U), default(IGameObject), 1F);
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task<int> boss_tartarus_rateofrecharge()
        {
            if (await this.difficulty_legendary())
            {
                return (short)Engine.random_range((short)(1 * this.tick_seconds), (short)(2 * this.tick_seconds));
            }
            else if (await this.difficulty_heroic())
            {
                return (short)Engine.random_range((short)(1 * this.tick_seconds), (short)(3 * this.tick_seconds));
            }
            else if (true)
            {
                return (short)Engine.random_range((short)(2 * this.tick_seconds), (short)(3 * this.tick_seconds));
            }
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task<int> boss_johnson_rateoffire()
        {
            if (await this.difficulty_legendary())
            {
                return (short)Engine.random_range((short)(7 * this.tick_seconds), (short)(15 * this.tick_seconds));
            }
            else if (await this.difficulty_heroic())
            {
                return (short)Engine.random_range((short)(5 * this.tick_seconds), (short)(12 * this.tick_seconds));
            }
            else if (true)
            {
                return (short)Engine.random_range((short)(4 * this.tick_seconds), (short)(10 * this.tick_seconds));
            }
        }

        [ScriptMethod(40, Lifecycle.Static)]
        public async Task<int> boss_rateofreenforcement()
        {
            if (await this.difficulty_legendary())
            {
                return (short)Engine.random_range((short)(30 * this.tick_seconds), (short)(60 * this.tick_seconds));
            }
            else if (await this.difficulty_heroic())
            {
                return (short)Engine.random_range((short)(30 * this.tick_seconds), (short)(60 * this.tick_seconds));
            }
            else if (true)
            {
                return (short)Engine.random_range((short)(30 * this.tick_seconds), (short)(60 * this.tick_seconds));
            }
        }

        [ScriptMethod(41, Lifecycle.Static)]
        public async Task boss_tartarus_invincible_on()
        {
            Engine.object_set_function_variable(Engine.ai_get_object(boss_tartarus.Squad), "invincibility", 1F, 2F);
            Engine.object_set_shield(Engine.ai_get_object(boss_tartarus.Squad), 1F / 1000F);
            this.boss_tartarus_invincible = true;
        }

        [ScriptMethod(42, Lifecycle.Static)]
        public async Task boss_tartarus_invincible_off()
        {
            Engine.object_set_function_variable(Engine.ai_get_object(boss_tartarus.Squad), "invincibility", 0F, 0.1F);
            Engine.object_set_shield(Engine.ai_get_object(boss_tartarus.Squad), 0F / 1000F);
            this.boss_tartarus_invincible = false;
        }

        [ScriptMethod(43, Lifecycle.Static)]
        public async Task boss_tartarus_berserk_on()
        {
            Engine.ai_berserk(boss_tartarus.Squad, true);
            this.boss_tartarus_berserk = true;
            Engine.print("berserk");
        }

        [ScriptMethod(44, Lifecycle.Static)]
        public async Task boss_tartarus_berserk_off()
        {
            Engine.ai_berserk(boss_tartarus.Squad, false);
            this.boss_tartarus_berserk = false;
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task boss_setup()
        {
            Engine.switch_bsp(3);
            Engine.ai_allegiance(player, human);
            Engine.ai_allegiance(player, covenant);
            Engine.ai_allegiance(player, sentinel);
            Engine.ai_allegiance(human, covenant);
            Engine.ai_allegiance(human, sentinel);
            Engine.ai_allegiance(covenant, human);
            Engine.ai_allegiance(covenant, sentinel);
            Engine.ai_allegiance(prophet, sentinel);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), boss_player0_flag);
            Engine.object_teleport(await this.player1(), boss_player1_flag);
            Engine.kill_volume_enable(kill_e13_0);
            Engine.device_set_position_immediate(e13_rotors.Entity, 0.625F);
            Engine.device_operates_automatically_set(e12_door1.Entity, false);
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

            Engine.ai_place(boss_tartarus.Squad);
            Engine.unit_impervious(Engine.ai_get_object(boss_tartarus.Squad), true);
            Engine.ai_cannot_die(boss_tartarus.Squad, true);
            Engine.unit_only_takes_damage_from_players_team(Engine.ai_get_unit(boss_tartarus.Squad), true);
            Engine.object_set_scale(Engine.ai_get_object(boss_tartarus.Squad), 1.15F, 0);
            await this.boss_tartarus_invincible_on();
            if (await this.difficulty_legendary())
            {
                Engine.unit_set_maximum_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 400F, 1000F);
            }
            else if (await this.difficulty_heroic())
            {
                Engine.unit_set_maximum_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 350F, 1000F);
            }
            else if (true)
            {
                Engine.unit_set_maximum_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 300F, 1000F);
            }

            Engine.unit_set_current_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 50F, 1000F);
            Engine.cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_stunned));
            Engine.ai_place(boss_miranda.Squad);
            Engine.unit_impervious(Engine.ai_actors(boss_miranda.Squad), true);
            Engine.object_cannot_die(Engine.ai_get_object(boss_miranda.Squad), true);
            Engine.cs_run_command_script(boss_miranda.Squad, new ScriptMethodReference(cs_boss_miranda_nocrouch));
            Engine.ai_disregard(Engine.ai_get_object(boss_miranda.Squad), true);
            Engine.ai_place(boss_monitor.Squad);
            Engine.ai_cannot_die(boss_monitor.Squad, true);
            Engine.ai_disregard(Engine.ai_get_object(boss_monitor.Squad), true);
            Engine.ai_place(boss_johnson.Squad);
            Engine.unit_impervious(Engine.ai_actors(boss_johnson.Squad), true);
            Engine.object_cannot_die(Engine.ai_get_object(boss_johnson.Squad), true);
            Engine.ai_disregard(Engine.ai_get_object(boss_johnson.Squad), true);
            Engine.cinematic_lighting_set_primary_light(27F, 0F, 0.34902F, 0.333333F, 0.541176F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 154F, 0.639216F, 0.54902F, 0.505882F);
            Engine.cinematic_lighting_set_ambient_light(0.0823529F, 0.0784314F, 0.0588235F);
            Engine.object_uses_cinematic_lighting(Engine.ai_get_object(boss_johnson.Squad), true);
            Engine.ai_place(boss_brute_start.Squad);
            Engine.cs_run_command_script(boss_brute_start.Squad, new ScriptMethodReference(cs_boss_brutes_stunned));
            Engine.ai_place(boss_elite_start.Squad);
            Engine.game_save_immediate();
        }

        [ScriptMethod(46, Lifecycle.Static)]
        public async Task tartarus_boss_fight()
        {
            await this.cinematic_snap_to_white();
            Engine.object_create_containing("boss_object");
            Engine.print("war!");
            await this.boss_setup();
            Engine.wake(new ScriptMethodReference(boss_music));
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white();
            await Engine.sleep(90);
            Engine.units_set_current_vitality(Engine.ai_actors(boss_brute_start.Squad), 30F, 0F);
            await Engine.sleep(120);
            await Engine.sleep_until(async () => !(Engine.device_get_position(e13_rotors.Entity) > 0.05F && Engine.device_get_position(e13_rotors.Entity) < 0.125F || Engine.device_get_position(e13_rotors.Entity) > 0.3F && Engine.device_get_position(e13_rotors.Entity) < 0.375F || Engine.device_get_position(e13_rotors.Entity) > 0.55F && Engine.device_get_position(e13_rotors.Entity) < 0.625F || Engine.device_get_position(e13_rotors.Entity) > 0.8F && Engine.device_get_position(e13_rotors.Entity) < 0.875F), 1);
            Engine.cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_jump));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(boss_brute_start.Squad) == 0, 1, 15 * 30);
            Engine.ai_place(boss_elite_reenforcements.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_boss_platform, Engine.players()), 1, 30 * 30);
            await Engine.sleep((short)(10 * 30));
            Engine.unit_impervious(Engine.ai_get_object(boss_tartarus.Squad), false);
            this.timer_boss_johnson_fire = await this.boss_johnson_rateoffire();
            Engine.cs_run_command_script(boss_johnson.Squad, new ScriptMethodReference(cs_boss_johnson_idle));
            Engine.wake(new ScriptMethodReference(boss_flavor));
            Engine.unit_set_current_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 50F, 1000F);
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(kill_e13_0, Engine.ai_get_object(boss_miranda.Squad)))
                {
                    Engine.ai_erase(boss_miranda.Squad);
                    Engine.ai_place(boss_miranda.Squad);
                    Engine.unit_impervious(Engine.ai_actors(boss_miranda.Squad), true);
                    Engine.object_cannot_die(Engine.ai_get_object(boss_miranda.Squad), true);
                    return false;
                }
                else if (!(Engine.volume_test_objects(tv_boss_ledge, Engine.ai_get_object(boss_johnson.Squad))))
                {
                    Engine.ai_erase(boss_johnson.Squad);
                    Engine.ai_place(boss_johnson.Squad);
                    Engine.unit_impervious(Engine.ai_actors(boss_johnson.Squad), true);
                    Engine.object_cannot_die(Engine.ai_get_object(boss_johnson.Squad), true);
                    return false;
                }
                else if (!(Engine.volume_test_objects(tv_boss_platform, Engine.ai_get_object(boss_tartarus.Squad))) && !(Engine.volume_test_objects(tv_boss_ledge, Engine.ai_get_object(boss_tartarus.Squad))) && await this.player_count() > 0)
                {
                    Engine.object_teleport(Engine.ai_get_object(boss_tartarus.Squad), boss_tartarus_respawn_flag);
                    await Engine.sleep(90);
                    return false;
                }
                else if ((bool)Engine.ai_vitality_pinned(boss_tartarus.Squad))
                {
                    this.count_boss_cycle = (short)(this.count_boss_cycle - 1);
                    Engine.print("cycle complete");
                    if (!(await this.player_count() > 0))
                    {
                        return false;
                    }
                    else if (this.count_boss_cycle <= 0)
                    {
                        Engine.ai_cannot_die(boss_tartarus.Squad, false);
                        Engine.ai_kill(boss_tartarus.Squad);
                        return true;
                    }
                    else if (true)
                    {
                        if (this.mark_boss_first_cycle)
                        {
                            Engine.print("(growls in pain) a lucky hit! you will not land another!");
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\mission\\l08_1020_tar", 3831366376U), Engine.ai_get_object(boss_tartarus.Squad), 1F);
                            this.mark_boss_first_cycle = false;
                        }

                        if (await this.difficulty_legendary())
                        {
                            Engine.unit_set_maximum_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 400F, 1000F);
                        }
                        else if (await this.difficulty_heroic())
                        {
                            Engine.unit_set_maximum_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 350F, 1000F);
                        }
                        else if (true)
                        {
                            Engine.unit_set_maximum_vitality(Engine.ai_get_unit(boss_tartarus.Squad), 300F, 1000F);
                        }

                        this.boss_respawn_brutes = true;
                        await this.boss_tartarus_invincible_on();
                        Engine.begin_random(async () => Engine.cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_taunt)), 
                            async () => Engine.cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_cheer)), 
                            async () => Engine.cs_run_command_script(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_shakefist)));
                        await Engine.sleep_until(async () => !(Engine.cs_command_script_running(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_taunt))) && !(Engine.cs_command_script_running(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_cheer))) && !(Engine.cs_command_script_running(boss_tartarus.Squad, new ScriptMethodReference(cs_boss_tartarus_shakefist))), 1);
                        if (!(await this.difficulty_normal()))
                        {
                            await this.boss_tartarus_berserk_on();
                        }

                        return false;
                    }
                }
                else if (!(Engine.volume_test_objects(tv_boss_platform, Engine.players())) && !((bool)Engine.ai_vitality_pinned(boss_tartarus.Squad)) && await this.player_count() > 0)
                {
                    if (this.boss_flavor_done)
                    {
                        await this.boss_tartarus_taunt();
                    }

                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    await Engine.sleep_until(async () => Engine.volume_test_objects(tv_boss_platform, Engine.players()), 1, 15 * 30);
                    return false;
                }
                else if (this.timer_boss_tartarus_recharge > 0)
                {
                    this.timer_boss_tartarus_recharge = (short)(this.timer_boss_tartarus_recharge - 1);
                    return false;
                }
                else if (!(this.boss_tartarus_invincible))
                {
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    await this.boss_tartarus_invincible_on();
                    return false;
                }
                else if (await this.difficulty_legendary() && Engine.unit_get_shield(Engine.ai_get_unit(boss_tartarus.Squad)) < 0.9F || await this.difficulty_heroic() && Engine.unit_get_shield(Engine.ai_get_unit(boss_tartarus.Squad)) < 0.95F || await this.difficulty_normal() && Engine.unit_get_shield(Engine.ai_get_unit(boss_tartarus.Squad)) < 0.975F)
                {
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player1());
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
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    await this.boss_tartarus_berserk_off();
                    return false;
                }
                else if (this.boss_respawn_brutes && (float)Engine.ai_living_count(boss_elite_reenforcements.Squad) + (float)Engine.ai_living_count(boss_brute_reenforcements.Squad) <= 3F)
                {
                    if (await this.difficulty_legendary())
                    {
                        this.boss_random_reenforcements = (short)Engine.random_range(3, 10);
                    }
                    else if (await this.difficulty_heroic())
                    {
                        this.boss_random_reenforcements = (short)Engine.random_range(3, 7);
                    }
                    else if (true)
                    {
                        this.boss_random_reenforcements = (short)Engine.random_range(0, 6);
                    }

                    if (this.boss_random_reenforcements > 7)
                    {
                        Engine.ai_place(boss_brute_reenforcements_many.Squad);
                    }
                    else if (this.boss_random_reenforcements > 3)
                    {
                        Engine.ai_place(boss_brute_reenforcements.Squad);
                    }

                    this.boss_respawn_brutes = false;
                    return this.boss_respawn_brutes;
                }
                else if (this.boss_respawn_elites && (float)Engine.ai_living_count(boss_elite_reenforcements.Squad) + (float)Engine.ai_living_count(boss_brute_reenforcements.Squad) <= 3F)
                {
                    if (await this.difficulty_legendary())
                    {
                        this.boss_random_reenforcements = (short)Engine.random_range(3, 10);
                    }
                    else if (await this.difficulty_heroic())
                    {
                        this.boss_random_reenforcements = (short)Engine.random_range(3, 7);
                    }
                    else if (true)
                    {
                        this.boss_random_reenforcements = (short)Engine.random_range(0, 6);
                    }

                    if (this.boss_random_reenforcements < 3)
                    {
                        Engine.ai_place(boss_elite_reenforcements_many.Squad);
                    }
                    else if (this.boss_random_reenforcements < 7)
                    {
                        Engine.ai_place(boss_elite_reenforcements.Squad);
                    }

                    this.boss_respawn_elites = false;
                    return this.boss_respawn_elites;
                }
                else if (this.timer_boss_johnson_fire > 0)
                {
                    this.timer_boss_johnson_fire = (short)(this.timer_boss_johnson_fire - 1);
                    if ((float)Engine.ai_living_count(boss_elite_reenforcements.Squad) + (float)Engine.ai_living_count(boss_brute_reenforcements.Squad) <= 3F)
                    {
                        this.timer_boss_reenforcements = (short)(this.timer_boss_reenforcements - 1);
                    }

                    if (this.timer_boss_reenforcements <= 0)
                    {
                        this.boss_respawn_elites = true;
                        this.timer_boss_reenforcements = await this.boss_rateofreenforcement();
                        Engine.print("respawn!");
                    }

                    return false;
                }
                else if (Engine.objects_can_see_object(Engine.ai_get_object(boss_johnson.Squad), Engine.ai_get_object(boss_tartarus.Squad), 0.25F))
                {
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    Engine.print("fire");
                    Engine.object_set_shield(Engine.ai_get_object(boss_tartarus.Squad), 1F / 1000F);
                    Engine.cs_run_command_script(boss_johnson.Squad, new ScriptMethodReference(cs_boss_johnson_shoot));
                    Engine.cs_queue_command_script(boss_johnson.Squad, new ScriptMethodReference(cs_boss_johnson_idle));
                    this.timer_boss_johnson_fire = await this.boss_johnson_rateoffire();
                    return false;
                }
                else if (true)
                {
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player0());
                    Engine.ai_magically_see_object(boss_tartarus.Squad, await this.player1());
                    return false;
                }
            }, 1);
            Engine.ai_kill(boss_tartarus.Squad);
            Engine.print("nice job!");
            Engine.sleep_forever(new ScriptMethodReference(boss_flavor));
            await Engine.sleep((short)(10 * 30));
            if (await this.player_count() == 0)
            {
                Engine.sleep_forever();
            }

            await this.cinematic_fade_to_white();
            await Engine.sleep(15);
            Engine.ai_erase(boss_elite_reenforcements.Squad);
            Engine.ai_erase(boss_tartarus.Squad);
            Engine.ai_erase(boss_brute_reenforcements.Squad);
            Engine.ai_erase(boss_miranda.Squad);
            Engine.ai_erase(boss_johnson.Squad);
            Engine.ai_erase(boss_monitor.Squad);
            Engine.object_destroy_containing("boss_object");
            Engine.garbage_collect_now();
        }

        [ScriptMethod(47, Lifecycle.Static)]
        public async Task _08_intra1_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra1_04_predict));
        }

        [ScriptMethod(48, Lifecycle.Static)]
        public async Task _08_intra2_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra2_01_predict));
        }

        [ScriptMethod(49, Lifecycle.Static)]
        public async Task _08_intra2_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra2_02_predict));
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task _08_intra3_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra3_01_predict));
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task _08_intra3_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra3_02_predict));
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task _08_intra3_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra3_03_predict));
        }

        [ScriptMethod(53, Lifecycle.Static)]
        public async Task _08_intra3_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra3_04_predict));
        }

        [ScriptMethod(54, Lifecycle.Static)]
        public async Task _08_intra3_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra3_05_predict));
        }

        [ScriptMethod(55, Lifecycle.Static)]
        public async Task _08_intra3_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_08_intra3_05_predict));
        }

        [ScriptMethod(56, Lifecycle.Static)]
        public async Task x09_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_01_predict));
        }

        [ScriptMethod(57, Lifecycle.Static)]
        public async Task x09_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_02_predict));
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task x09_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_03_predict));
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task x09_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_04_predict));
        }

        [ScriptMethod(60, Lifecycle.Static)]
        public async Task x09_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_05_predict));
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task x09_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_06_predict));
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task x09_07_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_07_predict));
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task x09_08_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x09_08_predict));
        }

        [ScriptMethod(64, Lifecycle.Static)]
        public async Task x10_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x10_01_predict));
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task x10_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(x10_02_predict));
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task c08_intra1_score_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_04_mus", 3831431913U), default(IGameObject), 1F);
            Engine.print("c08_intra1 score 04 start");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task c08_intra1_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_04_fol", 3831497450U), default(IGameObject), 1F);
            Engine.print("c08_intra1 foley 04 start");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c08_2050_der()
        {
            await Engine.sleep(60);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2050_der", 3831562987U), dervish_02.Entity, 1F);
            Engine.cinematic_subtitle("c08_2050_der", 1F);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c08_2060_soc()
        {
            await Engine.sleep(92);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2060_soc", 3831628524U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c08_2060_soc", 6F);
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c08_2070_grv()
        {
            await Engine.sleep(273);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2070_grv", 3831694061U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c08_2070_grv", 5F);
            Engine.cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task c08_2080_der()
        {
            await Engine.sleep(425);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2080_der", 3831759598U), dervish_02.Entity, 1F);
            Engine.cinematic_subtitle("c08_2080_der", 2F);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task c08_2090_soc()
        {
            await Engine.sleep(473);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2090_soc", 3831825135U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c08_2090_soc", 1F);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task c08_2100_soc()
        {
            await Engine.sleep(512);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_2100_soc", 3831890672U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c08_2100_soc", 2F);
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c04_intra1_fov_04()
        {
            await Engine.sleep(511);
            Engine.print("fov change: 80 -> 60 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task c04_intra1_dof_04()
        {
            await Engine.sleep(427);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1.17F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(84);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(100);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 0.5F, 0F, 0F, 0F, 0.5F, 0.5F);
            Engine.print("rack focus");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra1_04()
        {
            Engine.cinematic_lighting_set_primary_light(40F, 134F, 0.321569F, 0.321569F, 0.290196F);
            Engine.cinematic_lighting_set_secondary_light(8F, 274F, 0.301961F, 0.290196F, 0.45098F);
            Engine.cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            Engine.object_uses_cinematic_lighting(dervish_02.Entity, true);
            Engine.object_uses_cinematic_lighting(commander.Entity, true);
            Engine.object_uses_cinematic_lighting(wraith_01.Entity, true);
        }

        [ScriptMethod(77, Lifecycle.Static)]
        public async Task c08_intra1_04_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(dervish_02);
            Engine.object_create_anew(commander);
            Engine.object_create_anew(wraith_01);
            Engine.cinematic_clone_players_weapon(dervish_02.Entity, "right_hand_elite", "");
            Engine.object_cinematic_lod(dervish_02.Entity, true);
            Engine.object_cinematic_lod(commander.Entity, true);
            Engine.object_cinematic_lod(wraith_01.Entity, true);
        }

        [ScriptMethod(78, Lifecycle.Static)]
        public async Task c08_intra1_04_setup()
        {
            Engine.wake(new ScriptMethodReference(c08_intra1_score_04));
            Engine.wake(new ScriptMethodReference(c08_intra1_foley_04));
            Engine.wake(new ScriptMethodReference(c08_2050_der));
            Engine.wake(new ScriptMethodReference(c08_2060_soc));
            Engine.wake(new ScriptMethodReference(c08_2070_grv));
            Engine.wake(new ScriptMethodReference(c08_2080_der));
            Engine.wake(new ScriptMethodReference(c08_2090_soc));
            Engine.wake(new ScriptMethodReference(c08_2100_soc));
            Engine.wake(new ScriptMethodReference(c04_intra1_fov_04));
            Engine.wake(new ScriptMethodReference(c04_intra1_dof_04));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra1_04));
        }

        [ScriptMethod(79, Lifecycle.Static)]
        public async Task c08_intra1_04_cleanup()
        {
            Engine.object_destroy(dervish_02.Entity);
            Engine.object_destroy(commander.Entity);
            Engine.object_destroy(wraith_01.Entity);
        }

        [ScriptMethod(80, Lifecycle.Static)]
        public async Task c08_intra1()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltacontrol_intra1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this.c08_intra1_04_problem_actors();
            await this._08_intra1_04_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\music\\c08_intra1_04_mus", 3831431913U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra1\\foley\\c08_intra1_04_fol", 3831497450U));
            await Engine.sleep(this.prediction_offset);
            await this.c08_intra1_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra1\\08_intra1", 3831956209U), "08_intra1_04", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(dervish_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra1\\08_intra1", 3832021746U), "dervish_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\08_intra1\\08_intra1", 3832152820U), "commander_04", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(wraith_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\wraith\\08_intra1\\08_intra1", 3832283894U), "wraith_04", false, anchor_intra1.Entity);
            Engine.print("cache block");
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            Engine.fade_in(0F, 0F, 0F, 30);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c08_intra1_04_cleanup();
            Engine.cinematic_screen_effect_stop();
            await Engine.sleep(30);
            Engine.sound_class_set_gain("vehicle", 1F, 1);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c08_intra2_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_01_fol", 3832349431U), default(IGameObject), 1F);
            Engine.print("c08_intra2 foley 01 start");
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c08_3010_jon()
        {
            await Engine.sleep(100);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3010_jon", 3832414968U), johnson_02.Entity, 1F, "radio_covy_in");
            Engine.cinematic_subtitle("c08_3010_jon", 3F);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c08_3020_jon()
        {
            await Engine.sleep(203);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3020_jon", 3832480505U), johnson_02.Entity, 1F);
            Engine.cinematic_subtitle("c08_3020_jon", 3F);
        }

        [ScriptMethod(84, Lifecycle.Dormant)]
        public async Task c08_3030_jon()
        {
            await Engine.sleep(316);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3030_jon", 3832546042U), johnson_02.Entity, 1F);
            Engine.cinematic_subtitle("c08_3030_jon", 2F);
        }

        [ScriptMethod(85, Lifecycle.Dormant)]
        public async Task c08_3040_der()
        {
            await Engine.sleep(359);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3040_der", 3832611579U), dervish_02.Entity, 1F);
            Engine.cinematic_subtitle("c08_3040_der", 3F);
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task intra2_texture_cam_01()
        {
            Engine.object_create_anew(texture_camera);
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "marker", 35F);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\08_intra2\\08_intra2", 3832677116U), "texture_camera_01", anchor_intra2.Entity);
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra2()
        {
            Engine.cinematic_lighting_set_primary_light(33F, 0F, 0.258824F, 0.278431F, 0.34902F);
            Engine.cinematic_lighting_set_secondary_light(-37F, 228F, 0.109804F, 0.419608F, 0.611765F);
            Engine.cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            Engine.object_uses_cinematic_lighting(dervish_02.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson_02.Entity, true);
            Engine.object_uses_cinematic_lighting(scarab_01.Entity, true);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task c08_intra2_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(dervish_02);
            Engine.object_cinematic_lod(dervish_02.Entity, true);
            Engine.cinematic_clone_players_weapon(dervish_02.Entity, "right_hand_elite", "");
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task scarab_shake()
        {
            await Engine.sleep(45);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 2F);
            await Engine.sleep(240);
            Engine.player_effect_stop(2F);
        }

        [ScriptMethod(90, Lifecycle.Static)]
        public async Task c08_intra2_01_setup()
        {
            Engine.object_destroy(scarab.Entity);
            Engine.object_create_anew(johnson_02);
            Engine.object_create_anew(scarab_01);
            Engine.object_create_anew(scarab_screen);
            Engine.objects_attach(scarab_01.Entity, "holo_scarab_full", scarab_screen.Entity, "");
            Engine.object_cinematic_lod(johnson_02.Entity, true);
            Engine.object_cinematic_lod(scarab_01.Entity, true);
            Engine.unit_set_emotional_state(johnson_02.Entity, "angry", 0.25F, 0);
            Engine.wake(new ScriptMethodReference(c08_intra2_foley_01));
            Engine.wake(new ScriptMethodReference(c08_3010_jon));
            Engine.wake(new ScriptMethodReference(c08_3020_jon));
            Engine.wake(new ScriptMethodReference(c08_3030_jon));
            Engine.wake(new ScriptMethodReference(c08_3040_der));
            Engine.wake(new ScriptMethodReference(scarab_shake));
            Engine.wake(new ScriptMethodReference(intra2_texture_cam_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra2));
        }

        [ScriptMethod(91, Lifecycle.Static)]
        public async Task c08_intra2_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltacontrol_intra2");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this.c08_intra2_problem_actors();
            await this._08_intra2_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_01_fol", 3832349431U));
            await Engine.sleep(this.prediction_offset);
            await Engine.sleep(45);
            await this.c08_intra2_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra2\\08_intra2", 3832742653U), "08_intra2_01", default(IUnit), anchor_flag_intra2);
            Engine.custom_animation_relative(dervish_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra2\\08_intra2", 3832808190U), "dervish_01", false, anchor_intra2.Entity);
            Engine.custom_animation_relative(johnson_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra2\\08_intra2", 3832873727U), "johnson_01", false, anchor_intra2.Entity);
            Engine.scenery_animation_start_relative(scarab_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\08_intra2\\08_intra2", 3833004801U), "scarab_01", anchor_intra2.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra2_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_02_fol", 3833070338U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task c08_intra2_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra2\\foley\\c08_intra2_02_fol", 3833070338U), default(IGameObject), 1F);
            Engine.print("c08_intra1 foley 04 start");
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task c08_3050_jon()
        {
            await Engine.sleep(70);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3050_jon", 3833135875U), johnson_02.Entity, 1F, "radio_covy_loop");
            Engine.cinematic_subtitle("c08_3050_jon", 2F);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task c08_3061_jon()
        {
            await Engine.sleep(156);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3061_jon", 3833201412U), johnson_02.Entity, 1F, "radio_covy_loop");
            Engine.cinematic_subtitle("c08_3061_jon", 2F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task c08_3070_jon()
        {
            await Engine.sleep(231);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_3070_jon", 3833266949U), johnson_02.Entity, 1F);
            Engine.cinematic_subtitle("c08_3070_jon", 1F);
            Engine.unit_set_emotional_state(johnson_02.Entity, "angry", 0.75F, 45);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task intra2_dof()
        {
            await Engine.sleep(68);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0.001F, 0F, 0F, 0.001F);
            Engine.print("rack focus");
            await Engine.sleep(151);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task scarab_shake2()
        {
            await Engine.sleep(137);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.75F, 0.15F);
            await Engine.sleep(5);
            Engine.player_effect_stop(0.5F);
        }

        [ScriptMethod(98, Lifecycle.Static)]
        public async Task c08_intra2_02_setup()
        {
            Engine.wake(new ScriptMethodReference(c08_intra2_foley_02));
            Engine.wake(new ScriptMethodReference(c08_3050_jon));
            Engine.wake(new ScriptMethodReference(c08_3061_jon));
            Engine.wake(new ScriptMethodReference(c08_3070_jon));
            Engine.wake(new ScriptMethodReference(intra2_dof));
            Engine.wake(new ScriptMethodReference(scarab_shake2));
        }

        [ScriptMethod(99, Lifecycle.Static)]
        public async Task c08_intra2_02_cleanup()
        {
            Engine.object_destroy(dervish_02.Entity);
            Engine.object_destroy(johnson_02.Entity);
            Engine.object_destroy(scarab_01.Entity);
            Engine.object_destroy(scarab_screen.Entity);
            Engine.object_create_anew(scarab);
        }

        [ScriptMethod(100, Lifecycle.Static)]
        public async Task c08_intra2_scene_02()
        {
            await this.c08_intra2_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra2\\08_intra2", 3832742653U), "08_intra2_02", default(IUnit), anchor_flag_intra2);
            Engine.custom_animation_relative(dervish_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra2\\08_intra2", 3832808190U), "dervish_02", false, anchor_intra2.Entity);
            Engine.custom_animation_relative(johnson_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra2\\08_intra2", 3832873727U), "johnson_02", false, anchor_intra2.Entity);
            Engine.scenery_animation_start_relative(scarab_01.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\scarab\\08_intra2\\08_intra2", 3833004801U), "scarab_02", anchor_intra2.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c08_intra2_02_cleanup();
            Engine.sound_class_set_gain("amb", 0F, 15);
            await Engine.sleep(15);
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task c08_intra2()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp0"));
            await Engine.sleep(1);
            await this.c08_intra2_scene_01();
            await this.c08_intra2_scene_02();
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_01_fol", 3833332486U), default(IGameObject), 1F);
            Engine.print("c08_intra3 foley 01 start");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task c08_4010_tar()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4010_tar", 3833398023U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4010_tar", 4F);
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task c08_4020_tar()
        {
            await Engine.sleep(167);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4020_tar", 3833463560U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4020_tar", 3F);
        }

        [ScriptMethod(105, Lifecycle.Dormant)]
        public async Task c08_4030_gsp()
        {
            await Engine.sleep(251);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4030_gsp", 3833529097U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c08_4030_gsp", 3F);
        }

        [ScriptMethod(106, Lifecycle.Dormant)]
        public async Task c08_4040_tar()
        {
            await Engine.sleep(344);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4040_tar", 3833594634U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4040_tar", 4F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task c08_4050_mir()
        {
            await Engine.sleep(486);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4050_mir", 3833660171U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c08_4050_mir", 1F);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task c08_4060_tar()
        {
            await Engine.sleep(510);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4060_tar", 3833725708U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4060_tar", 3F);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task c08_intra3_fov_01()
        {
            await Engine.sleep(246);
            Engine.camera_set_field_of_view(30F, 0);
            Engine.print("fov change: 60 -> 30 over 0 ticks");
            await Engine.sleep(105);
            Engine.camera_set_field_of_view(60F, 13);
            Engine.print("fov change: 30 -> 60 over 13 ticks");
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra3_01()
        {
            Engine.cinematic_lighting_set_primary_light(63F, 80F, 0.180392F, 0.168627F, 0.129412F);
            Engine.cinematic_lighting_set_secondary_light(-51F, 188F, 0.101961F, 0.2F, 0.301961F);
            Engine.cinematic_lighting_set_ambient_light(0.121569F, 0.121569F, 0.0705882F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_01.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_02.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_03.Entity, true);
            Engine.object_uses_cinematic_lighting(brute_04.Entity, true);
            Engine.object_uses_cinematic_lighting(monitor.Entity, true);
            Engine.object_uses_cinematic_lighting(index.Entity, true);
        }

        [ScriptMethod(111, Lifecycle.Static)]
        public async Task c08_intra3_problem_actors_01()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(brute_01);
            Engine.object_create_anew(brute_02);
            Engine.object_create_anew(brute_03);
            Engine.object_create_anew(brute_04);
            Engine.object_create_anew(monitor);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(brute_01.Entity, true);
            Engine.object_cinematic_lod(brute_02.Entity, true);
            Engine.object_cinematic_lod(brute_03.Entity, true);
            Engine.object_cinematic_lod(brute_04.Entity, true);
            Engine.object_cinematic_lod(monitor.Entity, true);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task c08_intra2_miranda_emotion_01()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            await Engine.sleep(180);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.75F, 30);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task c08_intra2_miranda_emotion_02()
        {
            await Engine.sleep(488);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.75F, 30);
            await Engine.sleep(81);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 60);
        }

        [ScriptMethod(114, Lifecycle.Static)]
        public async Task c08_intra3_01_setup()
        {
            Engine.object_create_anew(index);
            Engine.object_create_anew(repository);
            Engine.object_cinematic_lod(index.Entity, true);
            Engine.object_cinematic_lod(repository.Entity, true);
            Engine.wake(new ScriptMethodReference(c08_intra3_foley_01));
            Engine.wake(new ScriptMethodReference(c08_4010_tar));
            Engine.wake(new ScriptMethodReference(c08_4020_tar));
            Engine.wake(new ScriptMethodReference(c08_4030_gsp));
            Engine.wake(new ScriptMethodReference(c08_4040_tar));
            Engine.wake(new ScriptMethodReference(c08_4050_mir));
            Engine.wake(new ScriptMethodReference(c08_4060_tar));
            Engine.wake(new ScriptMethodReference(c08_intra2_miranda_emotion_01));
            Engine.wake(new ScriptMethodReference(c08_intra2_miranda_emotion_02));
            Engine.wake(new ScriptMethodReference(c08_intra3_fov_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra3_01));
        }

        [ScriptMethod(115, Lifecycle.Static)]
        public async Task c08_intra3_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltacontrol_intra3");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.c08_intra3_problem_actors_01();
            await this._08_intra3_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_01_fol", 3833332486U));
            await Engine.sleep(this.prediction_offset);
            await this.c08_intra3_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_01", default(IUnit), anchor_flag_intra3);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_01", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_01", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_01", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_01", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_01", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_01", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_01", false, anchor_intra3.Entity);
            Engine.scenery_animation_start_relative(index.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_01", anchor_intra3.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra3_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_02_mus", 3838772057U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_02_fol", 3838837594U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task c08_intra3_score_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_02_mus", 3838772057U), default(IGameObject), 1F);
            Engine.print("c08_intra3 score 02 start");
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_02_fol", 3838837594U), default(IGameObject), 1F);
            Engine.print("c08_intra3 foley 02 start");
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task c08_4070_der()
        {
            await Engine.sleep(36);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4070_der", 3838903131U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4070_der", 1F);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task c08_4080_tar()
        {
            await Engine.sleep(77);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4080_tar", 3838968668U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4080_tar", 3F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task c08_4100_der()
        {
            await Engine.sleep(157);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4100_der", 3839034205U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4100_der", 2F);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task c08_4110_tar()
        {
            await Engine.sleep(212);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4110_tar", 3839099742U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4110_tar", 3F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task c08_4120_der()
        {
            await Engine.sleep(312);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4120_der", 3839165279U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4120_der", 5F);
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task c08_4140_tar()
        {
            await Engine.sleep(516);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4140_tar", 3839230816U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4140_tar", 4F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task c08_4150_der()
        {
            await Engine.sleep(628);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4150_der", 3839296353U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4150_der", 1F);
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task c08_4160_der()
        {
            await Engine.sleep(681);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4160_der", 3839361890U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4160_der", 3F);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task unhide_dervish()
        {
            Engine.time_code_reset();
            await Engine.sleep(10);
            Engine.print("unhide dervish");
            Engine.object_hide(dervish.Entity, false);
        }

        [ScriptMethod(127, Lifecycle.Static)]
        public async Task c08_intra3_02_setup()
        {
            Engine.object_create_anew(dervish);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.object_hide(dervish.Entity, true);
            Engine.cinematic_clone_players_weapon(dervish.Entity, "right_hand_elite", "");
            Engine.wake(new ScriptMethodReference(c08_intra3_score_02));
            Engine.wake(new ScriptMethodReference(c08_intra3_foley_02));
            Engine.wake(new ScriptMethodReference(c08_4070_der));
            Engine.wake(new ScriptMethodReference(c08_4080_tar));
            Engine.wake(new ScriptMethodReference(c08_4100_der));
            Engine.wake(new ScriptMethodReference(c08_4110_tar));
            Engine.wake(new ScriptMethodReference(c08_4120_der));
            Engine.wake(new ScriptMethodReference(c08_4140_tar));
            Engine.wake(new ScriptMethodReference(c08_4150_der));
            Engine.wake(new ScriptMethodReference(c08_4160_der));
            Engine.wake(new ScriptMethodReference(unhide_dervish));
        }

        [ScriptMethod(128, Lifecycle.Static)]
        public async Task c08_intra3_scene_02()
        {
            await this.c08_intra3_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_02", default(IUnit), anchor_flag_intra3);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_02", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_02", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_02", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_02", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_02", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_02", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_02", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_02", false, anchor_intra3.Entity);
            Engine.scenery_animation_start_relative(index.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_02", anchor_intra3.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra3_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_03_fol", 3839492964U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_03_fol", 3839492964U), default(IGameObject), 1F);
            Engine.print("c08_intra3 foley 03 start");
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task c08_4170_gsp()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4170_gsp", 3839558501U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c08_4170_gsp", 2F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task c08_4180_tar()
        {
            await Engine.sleep(41);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4180_tar", 3839624038U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4180_tar", 2F);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task c08_4190_tar()
        {
            await Engine.sleep(84);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4190_tar", 3839689575U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4190_tar", 2F);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task c08_4200_jon()
        {
            await Engine.sleep(137);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4200_jon", 3839755112U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c08_4200_jon", 1F);
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 0.5F, 0);
            Engine.print("johnson - angry .5 0");
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task c08_4201_jon()
        {
            await Engine.sleep(202);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4201_jon", 3839820649U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c08_4201_jon", 2F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task c08_4220_jon()
        {
            await Engine.sleep(308);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4220_jon", 3839886186U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c08_4220_jon", 3F);
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 1F, 15);
            Engine.print("johnson - angry 1 15");
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task c08_4230_tar()
        {
            await Engine.sleep(430);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4230_tar", 3839951723U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4230_tar", 1F);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task c08_4240_jon()
        {
            await Engine.sleep(474);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4240_jon", 3840017260U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c08_4240_jon", 2F);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task c08_4250_der()
        {
            await Engine.sleep(548);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4250_der", 3840082797U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4250_der", 2F);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task c08_intra3_fov_03()
        {
            await Engine.sleep(184);
            Engine.camera_set_field_of_view(5F, 21);
            Engine.print("fov change: 60 -> 5 over 21 ticks");
            await Engine.sleep(69);
            Engine.camera_set_field_of_view(60F, 0);
            Engine.print("fov change: 5 -> 60 over 0 ticks");
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra3_03()
        {
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(cov_sniper.Entity, true);
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task c08_intra3_03_setup()
        {
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(cov_sniper);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(cov_sniper.Entity, true);
            Engine.objects_attach(johnson.Entity, "right_hand", cov_sniper.Entity, "");
            Engine.wake(new ScriptMethodReference(c08_intra3_foley_03));
            Engine.wake(new ScriptMethodReference(c08_4170_gsp));
            Engine.wake(new ScriptMethodReference(c08_4180_tar));
            Engine.wake(new ScriptMethodReference(c08_4190_tar));
            Engine.wake(new ScriptMethodReference(c08_4200_jon));
            Engine.wake(new ScriptMethodReference(c08_4201_jon));
            Engine.wake(new ScriptMethodReference(c08_4220_jon));
            Engine.wake(new ScriptMethodReference(c08_4230_tar));
            Engine.wake(new ScriptMethodReference(c08_4240_jon));
            Engine.wake(new ScriptMethodReference(c08_4250_der));
            Engine.wake(new ScriptMethodReference(c08_intra3_fov_03));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra3_03));
        }

        [ScriptMethod(142, Lifecycle.Static)]
        public async Task c08_intra3_scene_03()
        {
            await this.c08_intra3_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_03", default(IUnit), anchor_flag_intra3);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra3\\08_intra3", 3840148334U), "johnson_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_03", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_03", false, anchor_intra3.Entity);
            Engine.scenery_animation_start_relative(index.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_03", anchor_intra3.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra3_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_04_fol", 3840213871U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_04_fol", 3840213871U), default(IGameObject), 1F);
            Engine.print("c08_intra3 foley 04 start");
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task c08_4260_gsp()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4260_gsp", 3840279408U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c08_4260_gsp", 6F);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 0);
            Engine.print("miranda - shocked .25 0");
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task c08_4270_der()
        {
            await Engine.sleep(189);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4270_der", 3840344945U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4270_der", 4F);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task c08_4280_gsp()
        {
            await Engine.sleep(297);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4280_gsp", 3840410482U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c08_4280_gsp", 11F);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task c08_4290_gsp()
        {
            await Engine.sleep(640);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4290_gsp", 3840476019U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c08_4290_gsp", 2F);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task c08_4300_der()
        {
            await Engine.sleep(746);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4300_der", 3840541556U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("c08_4300_der", 4F);
        }

        [ScriptMethod(149, Lifecycle.Static)]
        public async Task c08_intra3_04_setup()
        {
            Engine.wake(new ScriptMethodReference(c08_intra3_foley_04));
            Engine.wake(new ScriptMethodReference(c08_4260_gsp));
            Engine.wake(new ScriptMethodReference(c08_4270_der));
            Engine.wake(new ScriptMethodReference(c08_4280_gsp));
            Engine.wake(new ScriptMethodReference(c08_4290_gsp));
            Engine.wake(new ScriptMethodReference(c08_4300_der));
        }

        [ScriptMethod(150, Lifecycle.Static)]
        public async Task c08_intra3_scene_04()
        {
            await this.c08_intra3_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_04", default(IUnit), anchor_flag_intra3);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_04", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra3\\08_intra3", 3840148334U), "johnson_04", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_04", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_04", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_04", false, anchor_intra3.Entity);
            Engine.scenery_animation_start_relative(index.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_04", anchor_intra3.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra3_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_05_fol", 3840607093U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task c08_intra3_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_05_fol", 3840607093U), default(IGameObject), 1F);
            Engine.print("c08_intra3 foley 05 start");
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task c08_4310_jon()
        {
            await Engine.sleep(74);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4310_jon", 3840672630U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("c08_4310_jon", 1F);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task c08_4320_tar()
        {
            await Engine.sleep(106);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4320_tar", 3840738167U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4320_tar", 1F);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.5F, 0);
            Engine.print("miranda - pain .5 0");
            await Engine.sleep(45);
            Engine.unit_set_emotional_state(miranda.Entity, "scared", 0.5F, 15);
            Engine.print("miranda - scared .5 15");
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task c08_4330_tar()
        {
            await Engine.sleep(144);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4330_tar", 3840803704U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4330_tar", 2F);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task c08_4340_tar()
        {
            await Engine.sleep(220);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\c08_4340_tar", 3840869241U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c08_4340_tar", 4F);
            Engine.object_set_function_variable(tartarus.Entity, "invincibility", 1F, 60F);
            Engine.print("tartarus activates shield");
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task cinematic_lighting_intra3_05()
        {
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task index_insertion()
        {
            await Engine.sleep(165);
            Engine.print("slot the icon");
            Engine.device_set_position(repository.Entity, 1F);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\cinematics\\index\\index_insertion", 3840934778U), index.Entity, "");
            await Engine.sleep(15);
            Engine.object_destroy(index.Entity);
        }

        [ScriptMethod(158, Lifecycle.Static)]
        public async Task c08_intra3_05_setup()
        {
            Engine.object_create_anew(hammer);
            Engine.object_cinematic_lod(hammer.Entity, true);
            Engine.wake(new ScriptMethodReference(c08_intra3_foley_05));
            Engine.wake(new ScriptMethodReference(c08_4310_jon));
            Engine.wake(new ScriptMethodReference(c08_4320_tar));
            Engine.wake(new ScriptMethodReference(c08_4330_tar));
            Engine.wake(new ScriptMethodReference(c08_4340_tar));
            Engine.wake(new ScriptMethodReference(index_insertion));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_intra3_05));
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task c08_intra3_05_cleanup()
        {
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(monitor.Entity);
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy(brute_01.Entity);
            Engine.object_destroy(brute_02.Entity);
            Engine.object_destroy(brute_03.Entity);
            Engine.object_destroy(brute_04.Entity);
            Engine.object_destroy(repository.Entity);
            Engine.object_destroy(index.Entity);
            Engine.object_destroy(hammer.Entity);
            Engine.object_destroy(cov_sniper.Entity);
        }

        [ScriptMethod(160, Lifecycle.Static)]
        public async Task c08_intra3_scene_05()
        {
            await this.c08_intra3_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\08_intra3\\08_intra3", 3833791245U), "08_intra3_05", default(IUnit), anchor_flag_intra3);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\08_intra3\\08_intra3", 3833856782U), "miranda_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\08_intra3\\08_intra3", 3840148334U), "johnson_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\08_intra3\\08_intra3", 3838575446U), "monitor_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\08_intra3\\08_intra3", 3839427427U), "dervish_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "tartarus_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute01_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute02_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute03_05", false, anchor_intra3.Entity);
            Engine.custom_animation_relative(brute_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\08_intra3\\08_intra3", 3838640983U), "brute04_05", false, anchor_intra3.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\08_intra3\\08_intra3", 3841524611U), "hammer_05", anchor_intra3.Entity);
            Engine.scenery_animation_start_relative(index.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\08_intra3\\08_intra3", 3838706520U), "index_05", anchor_intra3.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._08_intra3_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_06_mus", 3841590148U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_06_fol", 3841655685U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.wake(new ScriptMethodReference(c08_intra3_05_cleanup));
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task create_lift()
        {
            Engine.print("create lift");
            Engine.object_create_anew(c08_intra3_lift);
            Engine.object_set_function_variable(c08_intra3_lift.Entity, "effect", 0F, 0F);
            await Engine.sleep(10);
            Engine.object_set_function_variable(c08_intra3_lift.Entity, "effect", 1F, 60F);
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task c08_intra3_scene_06()
        {
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\music\\c08_intra3_06_mus", 3841590148U), default(IGameObject), 1F);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\c08_intra3\\foley\\c08_intra3_06_fol", 3841655685U), default(IGameObject), 1F);
            Engine.device_set_position(e13_boss_platform.Entity, 1F);
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 3F);
            Engine.camera_set(platform_01a, 0);
            Engine.camera_set(platform_01b, 420);
            await Engine.sleep(300);
            Engine.wake(new ScriptMethodReference(create_lift));
            await Engine.sleep(30);
            Engine.camera_set(platform_02, 0);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(5F, 0F, 0F, 0F, 2F, 2F, 0F);
            await Engine.sleep(30);
            Engine.cinematic_screen_effect_set_depth_of_field(5F, 0F, 2F, 0.5F, 2F, 0F, 0.5F);
            await Engine.sleep(45);
            Engine.player_effect_stop(1.5F);
            await Engine.sleep(15);
            Engine.print("fade to white");
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.cinematic_screen_effect_stop();
            Engine.object_destroy(c08_intra3_lift.Entity);
            Engine.sound_class_set_gain("amb", 0F, 15);
            await Engine.sleep(30);
        }

        [ScriptMethod(163, Lifecycle.Static)]
        public async Task c08_intra3()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp3"));
            await Engine.sleep(1);
            await this.c08_intra3_scene_01();
            await this.c08_intra3_scene_02();
            await this.c08_intra3_scene_03();
            await this.c08_intra3_scene_04();
            await this.c08_intra3_scene_05();
            await this.c08_intra3_scene_06();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task x09_foley_1()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_01_fol", 3841721222U), default(IGameObject), 1F);
            Engine.print("x09 foley 01 start");
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task x09_01_stop_sounds()
        {
            await Engine.sleep(383);
            Engine.print("sound looping stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_11", 3830186710U));
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_12", 3830579932U));
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_13", 3830973154U));
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_01()
        {
            Engine.cinematic_lighting_set_primary_light(-4F, 206F, 0.454902F, 0.435294F, 0.352941F);
            Engine.cinematic_lighting_set_secondary_light(-69F, 234F, 0.152941F, 0.152941F, 0.227451F);
            Engine.cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.4F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(rotors_x09.Entity, true);
        }

        [ScriptMethod(167, Lifecycle.Dormant)]
        public async Task x09_fov_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(289);
            Engine.camera_set_field_of_view(35F, 0);
            Engine.print("fov change: 60 -> 35 over 0 ticks");
        }

        [ScriptMethod(168, Lifecycle.Static)]
        public async Task x09_problem_actors_01()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(rotors_x09);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(rotors_x09.Entity, true);
        }

        [ScriptMethod(169, Lifecycle.Static)]
        public async Task x09_problem_actors_02()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(index_x09);
            Engine.object_cinematic_lod(index_x09.Entity, true);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_01()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            await Engine.sleep(186);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.5F, 30);
            await Engine.sleep(71);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.5F, 30);
        }

        [ScriptMethod(171, Lifecycle.Static)]
        public async Task x09_01_setup()
        {
            Engine.object_destroy(e13_rotors.Entity);
            Engine.wake(new ScriptMethodReference(x09_miranda_emotion_01));
            Engine.wake(new ScriptMethodReference(x09_01_stop_sounds));
            Engine.wake(new ScriptMethodReference(x09_foley_1));
            Engine.wake(new ScriptMethodReference(x09_fov_01));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x09_01));
        }

        [ScriptMethod(172, Lifecycle.Static)]
        public async Task x09_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltacontrol_1");
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this.x09_problem_actors_01();
            await this.x09_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_01_fol", 3841721222U));
            await Engine.sleep(this.prediction_offset);
            await Engine.sleep(30);
            await this.x09_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_01", default(IUnit), anchor_flag_x09_01);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_01", false, anchor_x09_01.Entity);
            Engine.scenery_animation_start_relative(rotors_x09.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_rotors\\x09\\x09", 3841917833U), "control_rotors_01", anchor_x09_01.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x09_02_predict_stub();
            await this.x09_problem_actors_02();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_02_mus", 3841983370U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_02_fol", 3842048907U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(rotors_x09.Entity);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task x09_score_2()
        {
            await Engine.sleep(92);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_02_mus", 3841983370U), default(IGameObject), 1F);
            Engine.print("x09 score 01 start");
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task x09_foley_2()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_02_fol", 3842048907U), default(IGameObject), 1F);
            Engine.print("x09 foley 02 start");
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_02()
        {
            Engine.cinematic_lighting_set_primary_light(-18F, 166F, 0.454902F, 0.435294F, 0.352941F);
            Engine.cinematic_lighting_set_secondary_light(-10F, 78F, 0.152941F, 0.152941F, 0.227451F);
            Engine.cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            Engine.object_uses_cinematic_lighting(index_x09.Entity, true);
        }

        [ScriptMethod(176, Lifecycle.Dormant)]
        public async Task x09_dof_01()
        {
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 1F, 1F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(45);
            Engine.cinematic_screen_effect_set_depth_of_field(0.5F, 1F, 0F, 0.25F, 0F, 1F, 0.25F);
            Engine.print("rack focus");
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task lift_deactivate()
        {
            await Engine.sleep(93);
            Engine.print("lift deactivate");
            Engine.object_set_function_variable(x09_lift.Entity, "effect", 0F, 90F);
            Engine.sound_class_set_gain("device", 0F, 30);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_02()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            await Engine.sleep(137);
            Engine.unit_set_emotional_state(miranda.Entity, "scared", 0.5F, 90);
        }

        [ScriptMethod(179, Lifecycle.Static)]
        public async Task x09_02_setup()
        {
            Engine.wake(new ScriptMethodReference(x09_score_2));
            Engine.wake(new ScriptMethodReference(x09_foley_2));
            Engine.wake(new ScriptMethodReference(lift_deactivate));
            Engine.wake(new ScriptMethodReference(x09_miranda_emotion_02));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x09_02));
        }

        [ScriptMethod(180, Lifecycle.Static)]
        public async Task x09_scene_02()
        {
            Engine.camera_set_field_of_view(60F, 0);
            await this.x09_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_02", default(IUnit), anchor_flag_x09_01);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_02", false, anchor_x09_01.Entity);
            Engine.scenery_animation_start_relative(index_x09.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\x09\\x09", 3842114444U), "index_02", anchor_x09_01.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x09_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_03_fol", 3842179981U));
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.cinematic_screen_effect_stop();
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task x09_foley_3()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_03_fol", 3842179981U), default(IGameObject), 1F);
            Engine.print("x09 foley 03 start");
        }

        [ScriptMethod(182, Lifecycle.Static)]
        public async Task x09_problem_actors_04()
        {
            Engine.print("predict: problem actors");
            Engine.object_create_anew(halo);
            Engine.object_create_anew(matte_halo);
            Engine.object_cinematic_lod(halo.Entity, true);
            Engine.object_cinematic_lod(matte_halo.Entity, true);
        }

        [ScriptMethod(183, Lifecycle.Static)]
        public async Task x09_03_setup()
        {
            Engine.object_create_anew(x09_halo_bang);
            Engine.wake(new ScriptMethodReference(x09_foley_3));
        }

        [ScriptMethod(184, Lifecycle.Static)]
        public async Task x09_scene_03()
        {
            await Engine.sleep(15);
            await this.x09_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_03", default(IUnit), anchor_flag_x09_03);
            await Engine.sleep(10);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x09_04_predict_stub();
            await this.x09_problem_actors_04();
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_04_fol", 3842245518U));
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task x09_foley_4()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_04_fol", 3842245518U), default(IGameObject), 1F);
            Engine.print("x09 foley 04 start");
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_04()
        {
            Engine.cinematic_lighting_set_primary_light(34F, 146F, 0.51F, 0.79F, 0.99F);
            Engine.cinematic_lighting_set_secondary_light(6F, 118F, 0.18F, 0.22F, 0.41F);
            Engine.cinematic_lighting_set_ambient_light(0.05F, 0.05F, 0.05F);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(halo.Entity, true);
        }

        [ScriptMethod(187, Lifecycle.Static)]
        public async Task x09_04_setup()
        {
            Engine.object_create_anew(matte_substance);
            Engine.object_create_anew(matte_high_charity);
            Engine.object_cinematic_lod(matte_substance.Entity, true);
            Engine.object_cinematic_lod(matte_high_charity.Entity, true);
            Engine.object_create_anew(x09_halo_whimper);
            Engine.wake(new ScriptMethodReference(x09_foley_4));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x09_04));
        }

        [ScriptMethod(188, Lifecycle.Static)]
        public async Task x09_scene_04_cleanup()
        {
            Engine.object_destroy(halo.Entity);
            Engine.object_destroy_containing("matte");
        }

        [ScriptMethod(189, Lifecycle.Static)]
        public async Task x09_scene_04()
        {
            await this.x09_04_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_04", default(IUnit), anchor_flag_x09_02);
            Engine.scenery_animation_start_relative(halo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\halo\\x09\\x09", 3842311055U), "halo_04", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(matte_halo.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_halo_quarter\\x09\\x09", 3842376592U), "delta_halo_quarter_04", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\x09\\x09", 3842442129U), "substance_space_04", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(matte_high_charity.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\x09\\x09", 3842507666U), "high_charity_exterior_04", anchor_x09_02.Entity);
            await Engine.sleep(10);
            Engine.fade_in(1F, 1F, 1F, 5);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x09_05_predict_stub();
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_05_fol", 3842573203U));
            await Engine.sleep((short)((float)Engine.camera_time() - 90));
            Engine.fade_out(0F, 0F, 0F, 90);
            await Engine.sleep(90);
            await this.x09_scene_04_cleanup();
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task x09_foley_5()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_05_fol", 3842573203U), default(IGameObject), 1F);
            Engine.print("x09 foley 05 start");
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task x09_0010_mir()
        {
            await Engine.sleep(188);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0010_mir", 3842638740U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x09_0010_mir", 1F);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task x09_0020_gsp()
        {
            await Engine.sleep(214);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0020_gsp", 3842704277U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("x09_0020_gsp", 1F);
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task x09_0030_mir()
        {
            await Engine.sleep(251);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0030_mir", 3842769814U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x09_0030_mir", 1F);
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task x09_0040_gsp()
        {
            await Engine.sleep(280);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0040_gsp", 3842835351U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("x09_0040_gsp", 3F);
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task x09_0050_mir()
        {
            await Engine.sleep(370);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0050_mir", 3842900888U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x09_0050_mir", 2F);
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task x09_0060_gsp()
        {
            await Engine.sleep(419);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0060_gsp", 3842966425U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("x09_0060_gsp", 2F);
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task x09_0070_mir()
        {
            await Engine.sleep(469);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0070_mir", 3843031962U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x09_0070_mir", 1F);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_05()
        {
            Engine.cinematic_lighting_set_primary_light(-18F, 220F, 0.286275F, 0.270588F, 0.219608F);
            Engine.cinematic_lighting_set_secondary_light(13F, 176F, 0.152941F, 0.152941F, 0.227451F);
            Engine.cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            Engine.rasterizer_bloom_override_threshold(0.4F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(monitor.Entity, true);
            Engine.object_uses_cinematic_lighting(index_x09.Entity, true);
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task beacon_shuffle()
        {
            await Engine.sleep(140);
            Engine.print("beacon 01 -> beacon 02");
            Engine.object_destroy(beacon_01.Entity);
            Engine.object_create_anew(beacon_02);
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_05()
        {
            await Engine.sleep(467);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.5F, 30);
        }

        [ScriptMethod(201, Lifecycle.Static)]
        public async Task x09_05_setup()
        {
            Engine.object_destroy(e13_rotors.Entity);
            Engine.object_destroy(x09_lift.Entity);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(monitor);
            Engine.object_create_anew(beacon_01);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(monitor.Entity, true);
            Engine.unit_set_emotional_state(miranda.Entity, "inquisitive", 1F, 0);
            Engine.wake(new ScriptMethodReference(x09_miranda_emotion_05));
            Engine.wake(new ScriptMethodReference(x09_foley_5));
            Engine.wake(new ScriptMethodReference(x09_0010_mir));
            Engine.wake(new ScriptMethodReference(x09_0020_gsp));
            Engine.wake(new ScriptMethodReference(x09_0030_mir));
            Engine.wake(new ScriptMethodReference(x09_0040_gsp));
            Engine.wake(new ScriptMethodReference(x09_0050_mir));
            Engine.wake(new ScriptMethodReference(x09_0060_gsp));
            Engine.wake(new ScriptMethodReference(x09_0070_mir));
            Engine.wake(new ScriptMethodReference(beacon_shuffle));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x09_05));
            Engine.interpolator_start("x09_fog", 1F, 1F);
        }

        [ScriptMethod(202, Lifecycle.Static)]
        public async Task x09_scene_05()
        {
            await this.x09_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_05", default(IUnit), anchor_flag_x09_01);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_05", false, anchor_x09_01.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x09\\x09", 3843097499U), "johnson_05", false, anchor_x09_01.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\x09\\x09", 3843163036U), "monitor_05", false, anchor_x09_01.Entity);
            Engine.scenery_animation_start_relative(index_x09.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\x09\\x09", 3842114444U), "index_05", anchor_x09_01.Entity);
            await Engine.sleep(15);
            Engine.fade_in(0F, 0F, 0F, 90);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x09_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_06_fol", 3843228573U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task x09_foley_6()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_06_fol", 3843228573U), default(IGameObject), 1F);
            Engine.print("x09 foley 06 start");
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task x09_0080_gsp()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0080_gsp", 3843294110U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("x09_0080_gsp", 10F);
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task x09_0090_mir()
        {
            await Engine.sleep(310);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0090_mir", 3843359647U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x09_0090_mir", 2F);
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task x09_0100_gsp()
        {
            await Engine.sleep(386);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0100_gsp", 3843425184U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("x09_0100_gsp", 1F);
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task x09_0110_jon()
        {
            await Engine.sleep(430);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0110_jon", 3843490721U), johnson.Entity, 1F);
            Engine.cinematic_subtitle("x09_0110_jon", 2F);
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task x09_0120_mir()
        {
            await Engine.sleep(494);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0120_mir", 3843556258U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("x09_0120_mir", 4F);
            await Engine.sleep(30);
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task x09_0130_gsp()
        {
            await Engine.sleep(675);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0130_gsp", 3843621795U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("x09_0130_gsp", 2F);
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task x09_0140_der()
        {
            await Engine.sleep(742);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0140_der", 3843687332U), dervish.Entity, 1F);
            Engine.cinematic_subtitle("x09_0140_der", 3F);
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_06()
        {
            Engine.cinematic_lighting_set_primary_light(-18F, 220F, 0.286275F, 0.270588F, 0.219608F);
            Engine.cinematic_lighting_set_secondary_light(13F, 176F, 0.152941F, 0.152941F, 0.227451F);
            Engine.cinematic_lighting_set_ambient_light(0.0862745F, 0.0862745F, 0.0862745F);
            Engine.object_uses_cinematic_lighting(dervish.Entity, true);
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_06a()
        {
            await Engine.sleep(310);
            Engine.unit_set_emotional_state(miranda.Entity, "scared", 0.5F, 60);
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_06b()
        {
            await Engine.sleep(525);
            Engine.unit_set_emotional_state(miranda.Entity, "pain", 0.25F, 90);
        }

        [ScriptMethod(214, Lifecycle.Dormant)]
        public async Task x09_miranda_emotion_06c()
        {
            await Engine.sleep(776);
            Engine.unit_set_emotional_state(miranda.Entity, "shocked", 0.25F, 30);
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task x09_johnson_emotion_06a()
        {
            await Engine.sleep(440);
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 0.75F, 60);
            await Engine.sleep(54);
            Engine.unit_set_emotional_state(johnson.Entity, "shocked", 0.25F, 30);
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task x09_johnson_emotion_06b()
        {
            await Engine.sleep(784);
            Engine.unit_set_emotional_state(johnson.Entity, "shocked", 0.25F, 30);
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task x09_06_setup()
        {
            Engine.object_destroy(beacon_02.Entity);
            Engine.object_create_anew(beacon_03);
            Engine.device_set_position(beacon_03.Entity, 1F);
            Engine.object_create_anew(dervish);
            Engine.object_cinematic_lod(dervish.Entity, true);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 0);
            Engine.unit_set_emotional_state(johnson.Entity, "angry", 0.25F, 0);
            Engine.wake(new ScriptMethodReference(x09_miranda_emotion_06a));
            Engine.wake(new ScriptMethodReference(x09_miranda_emotion_06b));
            Engine.wake(new ScriptMethodReference(x09_miranda_emotion_06c));
            Engine.wake(new ScriptMethodReference(x09_johnson_emotion_06a));
            Engine.wake(new ScriptMethodReference(x09_johnson_emotion_06b));
            Engine.wake(new ScriptMethodReference(x09_foley_6));
            Engine.wake(new ScriptMethodReference(x09_0080_gsp));
            Engine.wake(new ScriptMethodReference(x09_0090_mir));
            Engine.wake(new ScriptMethodReference(x09_0100_gsp));
            Engine.wake(new ScriptMethodReference(x09_0110_jon));
            Engine.wake(new ScriptMethodReference(x09_0120_mir));
            Engine.wake(new ScriptMethodReference(x09_0130_gsp));
            Engine.wake(new ScriptMethodReference(x09_0140_der));
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task x09_scene_06_cleanup()
        {
            Engine.object_destroy(dervish.Entity);
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(monitor.Entity);
            Engine.object_destroy(index_x09.Entity);
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task x09_scene_06()
        {
            await this.x09_06_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_06", default(IUnit), anchor_flag_x09_01);
            Engine.custom_animation_relative(dervish.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\x09\\x09", 3843752869U), "dervish_06", false, anchor_x09_01.Entity);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\x09\\x09", 3841852296U), "miranda_06", false, anchor_x09_01.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\x09\\x09", 3843097499U), "johnson_06", false, anchor_x09_01.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\x09\\x09", 3843163036U), "monitor_06", false, anchor_x09_01.Entity);
            Engine.scenery_animation_start_relative(index_x09.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\x09\\x09", 3842114444U), "index_06", anchor_x09_01.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x09_07_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_07_fol", 3843818406U));
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(0F, 0F, 0F, 5);
            await Engine.sleep(5);
            await this.x09_scene_06_cleanup();
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task x09_foley_7()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_07_fol", 3843818406U), default(IGameObject), 1F);
            Engine.print("x09 foley 07 start");
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task x09_0150_to1()
        {
            await Engine.sleep(100);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0150_to1", 3843883943U), default(IGameObject), 1F, "radio_default_in");
            Engine.cinematic_subtitle("x09_0150_to1", 3F);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x09_07()
        {
            Engine.cinematic_lighting_set_primary_light(16F, -32F, 0.8F, 0.6F, 0.4F);
            Engine.cinematic_lighting_set_secondary_light(20F, 180F, 0.3F, 0.3F, 0.5F);
            Engine.cinematic_lighting_set_ambient_light(0.2F, 0.2F, 0.2F);
            Engine.object_uses_cinematic_lighting(forerunner_ship.Entity, true);
        }

        [ScriptMethod(223, Lifecycle.Static)]
        public async Task x09_problem_actors_08()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(chief);
            Engine.object_create_anew(x09_alcove);
            Engine.object_create_anew(bloom_quad);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(x09_alcove.Entity, true);
        }

        [ScriptMethod(224, Lifecycle.Static)]
        public async Task x09_07_setup()
        {
            Engine.object_create_anew(slipspace);
            Engine.object_create_anew_containing("earth_battle");
            Engine.object_create_anew(forerunner_ship);
            Engine.object_create_anew(matte_earth);
            Engine.object_create_anew(matte_moon);
            Engine.object_cinematic_lod(forerunner_ship.Entity, true);
            Engine.object_cinematic_lod(matte_earth.Entity, true);
            Engine.object_cinematic_lod(matte_moon.Entity, true);
            Engine.wake(new ScriptMethodReference(x09_foley_7));
            Engine.wake(new ScriptMethodReference(x09_0150_to1));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x09_07));
        }

        [ScriptMethod(225, Lifecycle.Static)]
        public async Task x09_scene_07_cleanup()
        {
            Engine.object_destroy(slipspace.Entity);
            Engine.object_destroy_containing("earth_battle");
            Engine.object_destroy(forerunner_ship.Entity);
            Engine.object_destroy_containing("matte");
        }

        [ScriptMethod(226, Lifecycle.Static)]
        public async Task x09_scene_07()
        {
            await Engine.sleep(60);
            await this.x09_07_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_07", default(IUnit), anchor_flag_x09_02);
            Engine.scenery_animation_start_relative(forerunner_ship.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\x09\\x09", 3843949480U), "forerunner_ship_07", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(cairo.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\spacestation\\ss_prop\\x09\\x09", 3844015017U), "ss_prop_07", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(matte_earth.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\earth_space\\x09\\x09", 3844080554U), "earth_space_07", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(matte_moon.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\moon\\x09\\x09", 3844146091U), "moon_07", anchor_x09_02.Entity);
            Engine.fade_in(0F, 0F, 0F, 5);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x09_08_predict_stub();
            await this.x09_problem_actors_08();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_08_mus", 3844211628U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_03_fol", 3842179981U));
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
            await this.x09_scene_07_cleanup();
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task x09_score_8()
        {
            await Engine.sleep(338);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\music\\x09_08_mus", 3844211628U), default(IGameObject), 1F);
            Engine.print("x09 score 08 start");
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task x09_foley_8()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x09\\foley\\x09_08_fol", 3844277165U), default(IGameObject), 1F);
            Engine.print("x09 foley 08 start");
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task x09_0160_lhd()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0160_lhd", 3844342702U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("x09_0160_lhd", 2F);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task x09_0180_mas()
        {
            await Engine.sleep(69);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0180_mas", 3844408239U), chief.Entity, 1F);
            Engine.cinematic_subtitle("x09_0180_mas", 2F);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task x09_0190_mas()
        {
            await Engine.sleep(132);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0190_mas", 3844473776U), default(IGameObject), 1F, "radio_default_out");
            Engine.cinematic_subtitle("x09_0190_mas", 2F);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task x09_0200_lhd()
        {
            await Engine.sleep(183);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0200_lhd", 3844539313U), hood.Entity, 1F);
            Engine.cinematic_subtitle("x09_0200_lhd", 1F);
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task x09_0210_lhd()
        {
            await Engine.sleep(232);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0210_lhd", 3844604850U), hood.Entity, 1F);
            Engine.cinematic_subtitle("x09_0210_lhd", 3F);
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task x09_0220_mas()
        {
            await Engine.sleep(342);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x09_0220_mas", 3844670387U), chief.Entity, 1F);
            Engine.cinematic_subtitle("x09_0220_mas", 3F);
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task cinematic_light_x09_chief_01()
        {
            Engine.print("light chief 01");
            Engine.cinematic_lighting_set_primary_light(-20F, 278F, 0.388235F, 0.427451F, 0.494118F);
            Engine.cinematic_lighting_set_secondary_light(42F, 224F, 0.0431373F, 0.0431373F, 0.0666667F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(hood.Entity, true);
            Engine.object_uses_cinematic_lighting(cairo_bridge.Entity, true);
            Engine.object_uses_cinematic_lighting(x09_alcove.Entity, true);
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task cinematic_light_x09_hood_01()
        {
            await Engine.sleep(124);
            Engine.print("light hood 01");
            Engine.cinematic_lighting_set_primary_light(0F, 94F, 0.47451F, 0.443137F, 0.333333F);
            Engine.cinematic_lighting_set_secondary_light(0F, 320F, 0.184314F, 0.176471F, 0.266667F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.rasterizer_bloom_override_threshold(0.75F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task final_explosion()
        {
            Engine.time_code_reset();
            await Engine.sleep(135);
            Engine.object_create_anew_containing("blast_base");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 3844735924U), blast_base.Entity, "marker");
            await Engine.sleep(110);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\01_outro\\covenant_tiny_explosion", 3844735924U), blast_base2.Entity, "marker");
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task cinematic_light_x09_chief_02()
        {
            await Engine.sleep(277);
            Engine.print("light chief 02");
            Engine.cinematic_lighting_set_primary_light(-20F, 278F, 0.388235F, 0.427451F, 0.494118F);
            Engine.cinematic_lighting_set_secondary_light(42F, 224F, 0.0431373F, 0.0431373F, 0.0666667F);
            Engine.cinematic_lighting_set_ambient_light(0F, 0F, 0F);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task x09_hood_emotion_08()
        {
            await Engine.sleep(43);
            Engine.unit_set_emotional_state(hood.Entity, "shocked", 0.5F, 30);
            await Engine.sleep(45);
            Engine.unit_set_emotional_state(hood.Entity, "happy", 0.25F, 90);
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task shake_chief()
        {
            Engine.print("shake");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.75F, 0F);
            await Engine.sleep(15);
            Engine.player_effect_stop(3F);
        }

        [ScriptMethod(241, Lifecycle.Static)]
        public async Task x09_08_setup()
        {
            Engine.object_create_anew(hood);
            Engine.object_create_anew(cairo_bridge);
            Engine.object_cinematic_lod(hood.Entity, true);
            Engine.object_cinematic_lod(cairo_bridge.Entity, true);
            Engine.object_create_anew_containing("cairo_effect");
            Engine.unit_set_emotional_state(hood.Entity, "angry", 0.5F, 0);
            Engine.wake(new ScriptMethodReference(x09_hood_emotion_08));
            Engine.wake(new ScriptMethodReference(x09_score_8));
            Engine.wake(new ScriptMethodReference(x09_foley_8));
            Engine.wake(new ScriptMethodReference(x09_0160_lhd));
            Engine.wake(new ScriptMethodReference(x09_0180_mas));
            Engine.wake(new ScriptMethodReference(x09_0190_mas));
            Engine.wake(new ScriptMethodReference(x09_0200_lhd));
            Engine.wake(new ScriptMethodReference(x09_0210_lhd));
            Engine.wake(new ScriptMethodReference(x09_0220_mas));
            Engine.wake(new ScriptMethodReference(shake_chief));
            Engine.wake(new ScriptMethodReference(final_explosion));
            Engine.wake(new ScriptMethodReference(cinematic_light_x09_chief_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_x09_hood_01));
            Engine.wake(new ScriptMethodReference(cinematic_light_x09_chief_02));
        }

        [ScriptMethod(242, Lifecycle.Static)]
        public async Task x09_scene_08_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(hood.Entity);
            Engine.object_destroy(cairo_bridge.Entity);
            Engine.object_destroy(x09_alcove.Entity);
            Engine.object_destroy(bloom_quad.Entity);
            Engine.object_destroy_containing("blast_base");
        }

        [ScriptMethod(243, Lifecycle.Static)]
        public async Task x09_scene_08()
        {
            await this.x09_08_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x09\\x09", 3841786759U), "x09_08", default(IUnit), anchor_flag_x09_02);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\x09\\x09", 3845194683U), "chief_08", false, anchor_x09_02.Entity);
            Engine.custom_animation_relative(hood.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\lord_hood\\x09\\x09", 3845260220U), "hood_08", false, anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(cairo_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\cairo_bridge\\x09\\x09", 3845391294U), "cairo_bridge_08", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(x09_alcove.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\x09\\x09", 3845456831U), "alcove_08", anchor_x09_02.Entity);
            Engine.scenery_animation_start_relative(bloom_quad.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\special\\bloom_quad\\x09\\x09", 3845522368U), "bloom_quad_08", anchor_x09_02.Entity);
            await Engine.sleep(10);
            Engine.fade_in(1F, 1F, 1F, 5);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(0F, 0F, 0F, 5);
            await Engine.sleep(5);
            await Engine.sleep(401);
            await this.x09_scene_08_cleanup();
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(244, Lifecycle.Dormant)]
        public async Task x10_score_1()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\music\\x10_01_mus", 3845587905U), default(IGameObject), 1F);
            Engine.print("x10 score 01 start");
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task x10_foley_1()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\foley\\x10_01_fol", 3845653442U), default(IGameObject), 1F);
            Engine.print("x10 foley 01 start");
        }

        [ScriptMethod(246, Lifecycle.Dormant)]
        public async Task x10_0010_grv()
        {
            await Engine.sleep(496);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0010_grv", 3845718979U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x10_0010_grv", 6F);
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x10_01()
        {
            Engine.cinematic_lighting_set_primary_light(51F, 28F, 0.380392F, 0.384314F, 0.341176F);
            Engine.cinematic_lighting_set_secondary_light(-53F, 202F, 0.0588235F, 0.356863F, 0.356863F);
            Engine.cinematic_lighting_set_ambient_light(0.0901961F, 0.117647F, 0.0823529F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(tentacle_01.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_02.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_03.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_04.Entity, true);
        }

        [ScriptMethod(248, Lifecycle.Static)]
        public async Task x10_problem_actors_01()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(spore_01);
            Engine.object_create_anew(spore_02);
            Engine.object_create_anew(spore_03);
            Engine.object_cinematic_lod(spore_01.Entity, true);
            Engine.object_cinematic_lod(spore_02.Entity, true);
            Engine.object_cinematic_lod(spore_03.Entity, true);
        }

        [ScriptMethod(249, Lifecycle.Static)]
        public async Task x10_scene_01_setup()
        {
            Engine.object_create_anew(x09_chamber_door);
            Engine.object_create_anew(tentacle_01);
            Engine.object_create_anew(tentacle_02);
            Engine.object_create_anew(tentacle_03);
            Engine.object_create_anew(tentacle_04);
            Engine.object_cinematic_lod(x09_chamber_door.Entity, true);
            Engine.object_cinematic_lod(tentacle_01.Entity, true);
            Engine.object_cinematic_lod(tentacle_02.Entity, true);
            Engine.object_cinematic_lod(tentacle_03.Entity, true);
            Engine.object_cinematic_lod(tentacle_04.Entity, true);
            Engine.object_cinematic_visibility(tentacle_01.Entity, true);
            Engine.object_cinematic_visibility(tentacle_02.Entity, true);
            Engine.object_cinematic_visibility(tentacle_03.Entity, true);
            Engine.object_cinematic_visibility(tentacle_04.Entity, true);
            Engine.wake(new ScriptMethodReference(x10_score_1));
            Engine.wake(new ScriptMethodReference(x10_foley_1));
            Engine.wake(new ScriptMethodReference(x10_0010_grv));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x10_01));
        }

        [ScriptMethod(250, Lifecycle.Static)]
        public async Task x10_scene_01_cleanup()
        {
            Engine.object_destroy(x09_chamber_door.Entity);
            Engine.object_destroy_containing("spore");
        }

        [ScriptMethod(251, Lifecycle.Static)]
        public async Task x10_scene_01()
        {
            Engine.fade_out(0F, 0F, 0F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltacontrol_2");
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.weather_start(0F);
            Engine.weather_change_intensity(0F, 1F);
            await this.x10_problem_actors_01();
            await this.x10_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\music\\x10_01_mus", 3845587905U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\foley\\x10_01_fol", 3845653442U));
            await Engine.sleep(this.prediction_offset);
            await this.x10_scene_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x10\\x10", 3845784516U), "x10_01", default(IUnit), anchor_flag_x10);
            Engine.scenery_animation_start_relative(x09_chamber_door.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\x10\\x10", 3845850053U), "high_door_grand_01", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(spore_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\flood\\flood_spore\\x10\\x10", 3845915590U), "spore01_01", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(spore_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\flood\\flood_spore\\x10\\x10", 3845915590U), "spore02_01", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(spore_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\flood\\flood_spore\\x10\\x10", 3845915590U), "spore03_01", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(tentacle_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle01_01", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(tentacle_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle02_01", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(tentacle_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle03_01", anchor_x10.Entity);
            Engine.fade_in(0F, 0F, 0F, 60);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this.x10_02_predict_stub();
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - 1));
            Engine.cinematic_screen_effect_set_crossfade(2F);
            await Engine.sleep(1);
            await this.x10_scene_01_cleanup();
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task x10_score_2()
        {
            await Engine.sleep(553);
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound\\cinematics\\08_deltacliffs\\x10\\music\\x10_02_mus", 3846046664U), default(IGameObject), 1F);
            Engine.print("x10 score 02 start");
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task x10_0020_grv()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0020_grv", 3846243275U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x10_0020_grv", 8F);
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task x10_0030_grv()
        {
            await Engine.sleep(260);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0030_grv", 3846308812U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x10_0030_grv", 5F);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task x10_0040_cor()
        {
            await Engine.sleep(496);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0040_cor", 3846374349U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("x10_0040_cor", 1F);
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task x10_0041_cor()
        {
            await Engine.sleep(520);
            Engine.unit_set_emotional_state(cortana.Entity, "pain", 0.25F, 60);
            Engine.print("cortana - pain .25 60");
            await Engine.sleep(30);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\08_controlroom\\cinematic\\x10_0041_cor", 3846439886U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("x10_0041_cor", 1F);
        }

        [ScriptMethod(257, Lifecycle.Dormant)]
        public async Task cinematic_lighting_x10_02()
        {
            Engine.cinematic_lighting_set_primary_light(51F, 28F, 0.380392F, 0.384314F, 0.341176F);
            Engine.cinematic_lighting_set_secondary_light(-53F, 202F, 0.0588235F, 0.356863F, 0.356863F);
            Engine.cinematic_lighting_set_ambient_light(0.0901961F, 0.117647F, 0.0823529F);
            Engine.object_uses_cinematic_lighting(cortana.Entity, true);
        }

        [ScriptMethod(258, Lifecycle.Dormant)]
        public async Task effect_cortana_appear()
        {
            await Engine.sleep(410);
            Engine.print("cortana appears");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 3846505423U), cortana_stand.Entity, "marker");
        }

        [ScriptMethod(259, Lifecycle.Static)]
        public async Task x10_scene_02_setup()
        {
            Engine.object_create_anew(cortana);
            Engine.object_cinematic_lod(cortana.Entity, true);
            Engine.object_create_anew(cortana_stand);
            Engine.unit_set_emotional_state(cortana.Entity, "repulsed", 0.5F, 0);
            Engine.print("cortana - repulsed .5 0");
            Engine.wake(new ScriptMethodReference(x10_score_2));
            Engine.wake(new ScriptMethodReference(x10_0020_grv));
            Engine.wake(new ScriptMethodReference(x10_0030_grv));
            Engine.wake(new ScriptMethodReference(x10_0040_cor));
            Engine.wake(new ScriptMethodReference(x10_0041_cor));
            Engine.wake(new ScriptMethodReference(effect_cortana_appear));
            Engine.wake(new ScriptMethodReference(cinematic_lighting_x10_02));
            Engine.cinematic_set_near_clip_distance(0.05F);
            Engine.print("setting near clip distance to .05");
        }

        [ScriptMethod(260, Lifecycle.Static)]
        public async Task x10_scene_02_cleanup()
        {
            Engine.object_destroy_containing("cortana");
            Engine.object_destroy_containing("tentacle");
        }

        [ScriptMethod(261, Lifecycle.Static)]
        public async Task x10_scene_02()
        {
            Engine.time_code_reset();
            await this.x10_scene_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\x10\\x10", 3845784516U), "x10_02", default(IUnit), anchor_flag_x10);
            Engine.custom_animation_relative(cortana.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\x10\\x10", 3847357404U), "cortana_02", false, anchor_x10.Entity);
            Engine.scenery_animation_start_relative(tentacle_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle01_02", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(tentacle_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle02_02", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(tentacle_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle03_02", anchor_x10.Entity);
            Engine.scenery_animation_start_relative(tentacle_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\x10\\x10", 3845981127U), "tentacle04_02", anchor_x10.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(0F, 0F, 0F, 5);
            await Engine.sleep(5);
            Engine.cinematic_set_near_clip_distance(0.06F);
            Engine.print("setting near clip distance to .06");
            await Engine.sleep(328);
        }

        [ScriptMethod(262, Lifecycle.Static)]
        public async Task x10()
        {
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_0"));
            await Engine.sleep(1);
            await this.x10_scene_01();
            await this.x10_scene_02();
        }

        [ScriptMethod(263, Lifecycle.Static)]
        public async Task x09()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp4"));
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 0F, 15);
            await this.x09_scene_01();
            await this.x09_scene_02();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp0"));
            await Engine.sleep(1);
            await this.x09_scene_03();
            await this.x09_scene_04();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp4"));
            await Engine.sleep(1);
            await this.x09_scene_05();
            await this.x09_scene_06();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp0"));
            await Engine.sleep(1);
            await this.x09_scene_07();
            await this.x09_scene_08();
            await Engine.sleep(90);
            Engine.print("90 ticks of black instead of credits");
            await this.x10();
            await Engine.sleep(30);
            Engine.print("30 ticks of black for marty2");
            Engine.game_won();
        }

        [ScriptMethod(264, Lifecycle.Static)]
        public async Task<bool> player_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) || (bool)Engine.game_is_cooperative() && Engine.unit_in_vehicle(Engine.unit(await this.player1()));
        }

        [ScriptMethod(265, Lifecycle.Static)]
        public async Task<bool> players_in_vehicle()
        {
            return Engine.unit_in_vehicle(Engine.unit(await this.player0())) && !((bool)Engine.game_is_cooperative()) || Engine.unit_in_vehicle(Engine.unit(await this.player1()));
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task chapter_title0()
        {
            await Engine.sleep(30);
            Engine.cinematic_set_title(title0);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task chapter_title1()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task chapter_title2()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
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
            await Engine.sleep(30);
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(274, Lifecycle.Dormant)]
        public async Task objective0_clear()
        {
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(275, Lifecycle.Dormant)]
        public async Task objective1_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(276, Lifecycle.Dormant)]
        public async Task objective1_clear()
        {
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(277, Lifecycle.Dormant)]
        public async Task objective2_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task objective2_clear()
        {
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task objective3_set()
        {
            await Engine.sleep(30);
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task objective3_clear()
        {
            Engine.objectives_finish_up_to(3);
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task objective4_set()
        {
            await Engine.sleep(180);
            Engine.objectives_show_up_to(4);
        }

        [ScriptMethod(282, Lifecycle.Dormant)]
        public async Task objective4_clear()
        {
            Engine.objectives_finish_up_to(4);
        }

        [ScriptMethod(283, Lifecycle.Dormant)]
        public async Task music_08b_01_stop()
        {
            Engine.print("music 08b_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_01", 3847488478U));
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task music_08b_01_start_alt()
        {
            Engine.print("music 08b_01 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_01", 3847488478U), true);
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task music_08b_01_start()
        {
            Engine.print("music 08b_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_01", 3847488478U), default(IGameObject), 1F);
        }

        [ScriptMethod(286, Lifecycle.Dormant)]
        public async Task music_08b_02_stop()
        {
            Engine.print("music 08b_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_02", 3848537070U));
        }

        [ScriptMethod(287, Lifecycle.Dormant)]
        public async Task music_08b_02_start()
        {
            Engine.print("music 08b_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_02", 3848537070U), default(IGameObject), 1F);
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task music_08b_03_stop()
        {
            Engine.print("music 08b_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_03", 3848930292U));
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task music_08b_03_start()
        {
            Engine.print("music 08b_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_03", 3848930292U), default(IGameObject), 1F);
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task music_08b_04_stop()
        {
            Engine.print("music 08b_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_04", 3849323514U));
        }

        [ScriptMethod(291, Lifecycle.Dormant)]
        public async Task music_08b_04_start()
        {
            Engine.print("music 08b_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_04", 3849323514U), default(IGameObject), 1F);
        }

        [ScriptMethod(292, Lifecycle.Dormant)]
        public async Task music_08b_05_stop()
        {
            Engine.print("music 08b_05 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_05", 3849847810U));
        }

        [ScriptMethod(293, Lifecycle.Dormant)]
        public async Task music_08b_05_start_alt()
        {
            Engine.print("music 08b_05 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_05", 3849847810U), true);
        }

        [ScriptMethod(294, Lifecycle.Dormant)]
        public async Task music_08b_05_start()
        {
            Engine.print("music 08b_05 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_05", 3849847810U), default(IGameObject), 1F);
        }

        [ScriptMethod(295, Lifecycle.Dormant)]
        public async Task music_08b_06_start()
        {
            Engine.print("music 08b_06 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_06", 3850634254U), default(IGameObject), 1F);
        }

        [ScriptMethod(296, Lifecycle.Dormant)]
        public async Task music_08b_07_start()
        {
            Engine.print("music 08b_07 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_07", 3850896402U), default(IGameObject), 1F);
        }

        [ScriptMethod(297, Lifecycle.Dormant)]
        public async Task music_08b_08_start()
        {
            Engine.print("music 08b_08 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_08", 3851158550U), default(IGameObject), 1F);
        }

        [ScriptMethod(298, Lifecycle.Dormant)]
        public async Task music_08b_09_stop()
        {
            Engine.print("music 08b_09 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_09", 3851420698U));
        }

        [ScriptMethod(299, Lifecycle.Dormant)]
        public async Task music_08b_09_start_alt()
        {
            Engine.print("music 08b_09 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_09", 3851420698U), true);
        }

        [ScriptMethod(300, Lifecycle.Dormant)]
        public async Task music_08b_09_start()
        {
            Engine.print("music 08b_09 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_09", 3851420698U), default(IGameObject), 1F);
        }

        [ScriptMethod(301, Lifecycle.Dormant)]
        public async Task music_08b_10_stop()
        {
            Engine.print("music 08b_10 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_10", 3851813920U));
        }

        [ScriptMethod(302, Lifecycle.Dormant)]
        public async Task music_08b_10_start()
        {
            Engine.print("music 08b_10 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\08b_deltacontrol\\08b_music\\08b_10", 3851813920U), default(IGameObject), 1F);
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task scarab_idle_var0()
        {
            Engine.print("scarab_idle_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(304, Lifecycle.Static)]
        public async Task scarab_idle_firing()
        {
            Engine.print("scarab_idle_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(305, Lifecycle.Static)]
        public async Task scarab_idle_var0_no_block()
        {
            Engine.print("scarab_idle_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
        }

        [ScriptMethod(306, Lifecycle.Static)]
        public async Task scarab_idle_to_walk_front()
        {
            Engine.print("scarab_idle_to_walk_front");
            Engine.device_set_position_track(scarab.Entity, "combat:idle:2:walk_front", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(307, Lifecycle.Static)]
        public async Task scarab_walk_front_var0()
        {
            Engine.print("scarab_walk_front_var0");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:var0", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(308, Lifecycle.Static)]
        public async Task scarab_walk_front_to_idle()
        {
            Engine.print("scarab_walk_front_to_idle");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front:2:idle", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 3F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(309, Lifecycle.Static)]
        public async Task scarab_idle_turn_15_left()
        {
            Engine.print("scarab_idle_turn_15_left");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_15_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(310, Lifecycle.Static)]
        public async Task scarab_idle_turn_15_right()
        {
            Engine.print("scarab_idle_turn_15_right");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_15_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(311, Lifecycle.Static)]
        public async Task scarab_idle_turn_15_right_slow()
        {
            Engine.print("scarab_idle_turn_15_right_slow");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_15_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(312, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_left()
        {
            Engine.print("scarab_idle_turn_22_left");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_22_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(313, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_right()
        {
            Engine.print("scarab_idle_turn_22_right");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_22_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task scarab_idle_turn_22_right_slow()
        {
            Engine.print("scarab_idle_turn_22_right_slow");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_22_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(315, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_left()
        {
            Engine.print("scarab_idle_turn_45_left");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_45_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_right()
        {
            Engine.print("scarab_idle_turn_45_right");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_45_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task scarab_idle_turn_45_right_slow()
        {
            Engine.print("scarab_idle_turn_45_right_slow");
            Engine.device_set_position_track(scarab.Entity, "combat:turn_45_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_left()
        {
            Engine.print("scarab_walk_front_turn_15_left");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_15_right()
        {
            Engine.print("scarab_walk_front_turn_15_right");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_15_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_22_left()
        {
            Engine.print("scarab_walk_front_turn_22_left");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_22_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(321, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_22_right()
        {
            Engine.print("scarab_walk_front_turn_22_right");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_22_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(322, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_left()
        {
            Engine.print("scarab_walk_front_turn_45_left");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(323, Lifecycle.Static)]
        public async Task scarab_walk_front_turn_45_right()
        {
            Engine.print("scarab_walk_front_turn_45_right");
            Engine.device_set_position_track(scarab.Entity, "combat:walk_front_turn_45_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(324, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_left()
        {
            Engine.print("scarab_idle_to_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task scarab_idle_to_twist_5_right()
        {
            Engine.print("scarab_idle_to_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:idle_to_twist_5_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task scarab_twist_5_left()
        {
            Engine.print("scarab_twist_5_left");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(327, Lifecycle.Static)]
        public async Task scarab_twist_5_left_firing()
        {
            Engine.print("scarab_twist_5_left");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_left", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(328, Lifecycle.Static)]
        public async Task scarab_twist_5_right()
        {
            Engine.print("scarab_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 4F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(329, Lifecycle.Static)]
        public async Task scarab_twist_5_right_firing()
        {
            Engine.print("scarab_twist_5_right");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_right", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 6F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(330, Lifecycle.Static)]
        public async Task scarab_twist_5_left_to_idle()
        {
            Engine.print("scarab_twist_5_left_to_idle");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_left_to_idle", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(331, Lifecycle.Static)]
        public async Task scarab_twist_5_right_to_idle()
        {
            Engine.print("scarab_twist_5_left_to_idle");
            Engine.device_set_position_track(scarab.Entity, "combat:twist_5_right_to_idle", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 1.5F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
        }

        [ScriptMethod(332, Lifecycle.Static)]
        public async Task scarab_gun_open_up()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_open");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(333, Lifecycle.Static)]
        public async Task scarab_gun_fire_up()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire");
            Engine.device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(334, Lifecycle.Static)]
        public async Task scarab_gun_close_up()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_close");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(335, Lifecycle.Static)]
        public async Task scarab_gun_open_down()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_down_open");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(336, Lifecycle.Static)]
        public async Task scarab_gun_fire_down()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_down");
            Engine.device_animate_overlay(scarab.Entity, 1F, 6F, 0F, 0F);
        }

        [ScriptMethod(337, Lifecycle.Static)]
        public async Task scarab_gun_fire_down_abort()
        {
            Engine.device_animate_overlay(scarab.Entity, 0F, 3F, 0F, 0F);
        }

        [ScriptMethod(338, Lifecycle.Static)]
        public async Task scarab_gun_close_down()
        {
            Engine.device_set_overlay_track(scarab.Entity, "combat:fire_down_close");
            Engine.device_animate_overlay(scarab.Entity, 1F, 3.5F, 0F, 0F);
        }

        [ScriptMethod(339, Lifecycle.Dormant)]
        public async Task e13_main()
        {
            this.g_e13_started = true;
            Engine.game_save();
            Engine.print("e13_main");
            Engine.data_mine_set_mission_segment("e13_control_room");
            Engine.device_operates_automatically_set(e12_door0.Entity, false);
            await this.tartarus_boss_fight();
            Engine.wake(new ScriptMethodReference(objective3_clear));
            this.g_mission_over = true;
        }

        [ScriptMethod(340, Lifecycle.Dormant)]
        public async Task e13_cinematic_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e13_cutscene_trigger1, Engine.players()) || Engine.volume_test_objects(tv_e13_cutscene_trigger0, Engine.players()) && Engine.objects_can_see_flag(Engine.players(), e13_cutscene_trigger, 15F), 15);
            await this.cinematic_fade_to_white();
            Engine.object_teleport(await this.player0(), player0_stash);
            Engine.object_teleport(await this.player1(), player1_stash);
            await this.cinematic_tartarus_fight();
            Engine.sound_suppress_ambience_update_on_revert();
            Engine.sound_class_set_gain("amb", 0F, 0);
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 1F, 15);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("deltacontrolroom_bsp4"));
            Engine.wake(new ScriptMethodReference(e13_main));
            await this.cinematic_fade_from_white();
        }

        [ScriptMethod(341, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_phantom0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p1"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p1_1"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p1_2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p2"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p2_facing"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p3"), 1F);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), true);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_a01");
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_a02");
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_a03");
            await Engine.sleep(45);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_b01");
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_b02");
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_b03");
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get(this.ai_current_actor), false);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p2_facing"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p4"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e12_cov_phantom0_entry/p4_facing"));
            Engine.cs_enable_targeting(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2, 15);
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(342, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_1_wait()
        {
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("e12_pro_inf0_sighted_player", e12_pro_inf0), 15);
        }

        [ScriptMethod(343, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_wait0()
        {
            Engine.cs_crouch(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e12_patrol/s0"));
            await Engine.sleep_until(async () => Engine.device_get_position(e12_door0.Entity) > 0F, 15);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e12_patrol/s0"));
            await Engine.sleep(30);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e12_patrol/p0"));
            await Engine.sleep(30);
        }

        [ScriptMethod(344, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_wait1()
        {
            Engine.cs_crouch(true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e12_patrol/s1"));
            await Engine.sleep_until(async () => Engine.device_get_position(e12_door0.Entity) > 0F, 15);
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e12_patrol/s1"));
            await Engine.sleep(30);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e12_patrol/p1"));
            await Engine.sleep(30);
        }

        [ScriptMethod(345, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_look()
        {
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(346, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_inf0_follow()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(347, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_captain()
        {
            Engine.cs_enable_targeting(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) > this.ai_combat_status_active);
            Engine.cs_enable_moving(false);
            Engine.cs_look_player(true);
            await Engine.sleep((short)Engine.random_range(15, 30));
            Engine.print("cpn: do not let them enter!");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0940"));
            await Engine.sleep(20);
            Engine.cs_enable_moving(true);
            Engine.print("cpn: tartar sauce must complete his tasty condiments");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0950"));
        }

        [ScriptMethod(348, Lifecycle.CommandScript)]
        public async Task cs_e12_pro_inf0_berserker()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) > this.ai_combat_status_active);
            await Engine.sleep((short)Engine.random_range(0, 30));
            Engine.ai_berserk(this.ai_current_actor, true);
        }

        [ScriptMethod(349, Lifecycle.CommandScript)]
        public async Task cs_e12_cov_banshee0_entry()
        {
            Engine.object_cannot_die(Engine.ai_vehicle_get(this.ai_current_actor), true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e12_cov_banshees0/p2"), 5F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e12_cov_banshees0/p2"), 0.5F);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(this.ai_current_actor), true);
            Engine.ai_vehicle_exit(this.ai_current_actor);
            await Engine.sleep(30);
        }

        [ScriptMethod(350, Lifecycle.Dormant)]
        public async Task e12_pro_inf0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2, 15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_chamber_entered, Engine.players()), 15);
            Engine.ai_place(e12_pro_inf0_1.Squad);
            Engine.wake(new ScriptMethodReference(music_08b_09_start));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e12_pro_inf0) <= 1 && Engine.device_get_position(e12_door1.Entity) <= 0F);
            Engine.game_save_no_timeout();
            Engine.ai_place(e12_pro_inf0_2.Squad);
            Engine.wake(new ScriptMethodReference(music_08b_09_start_alt));
            Engine.wake(new ScriptMethodReference(music_08b_10_start));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e12_pro_inf0) <= 0 || Engine.volume_test_objects(tv_e13_cutscene_trigger0, Engine.players()), 15);
            Engine.device_one_sided_set(e12_door1.Entity, false);
            Engine.device_closes_automatically_set(e12_door1.Entity, false);
            Engine.device_set_position(e12_door1.Entity, 1F);
            Engine.wake(new ScriptMethodReference(music_08b_09_stop));
            Engine.wake(new ScriptMethodReference(music_08b_10_stop));
        }

        [ScriptMethod(351, Lifecycle.Dormant)]
        public async Task e12_pro_inf0_ender()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_pro_inf0_end, Engine.players()), 15);
            Engine.sleep_forever(new ScriptMethodReference(e12_pro_inf0_main));
            Engine.device_one_sided_set(e12_door1.Entity, false);
            Engine.device_closes_automatically_set(e12_door1.Entity, false);
            Engine.device_set_position(e12_door1.Entity, 1F);
            Engine.wake(new ScriptMethodReference(music_08b_09_stop));
            Engine.wake(new ScriptMethodReference(music_08b_10_stop));
        }

        [ScriptMethod(352, Lifecycle.Dormant)]
        public async Task e12_cov_phantom0_main()
        {
            Engine.ai_place(e12_cov_phantom0.Squad);
        }

        [ScriptMethod(353, Lifecycle.Dormant)]
        public async Task e12_cov_banshees0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_ledge, Engine.players()) || Engine.volume_test_objects(tv_e12_cov_banshee0_begin, Engine.players()) || !(await this.player_in_vehicle()), 15);
            if (Engine.volume_test_objects(tv_e12_ledge, Engine.players()))
            {
                Engine.sleep_forever();
            }

            await Engine.sleep_until(async () => !(Engine.objects_can_see_flag(Engine.players(), e12_cov_banshees0_spawn, 80F)), 15);
            Engine.ai_place(e12_cov_banshees0.Squad);
            await Engine.sleep_until(async () => await this.player_in_vehicle(), 30, 450);
            if (await this.player_in_vehicle())
            {
                Engine.sleep_forever();
            }

            Engine.activate_team_nav_point_object(_default, player, Engine.ai_vehicle_get_from_starting_location(e12_cov_banshees0.banshee0), 1F);
            await Engine.sleep_until(async () => await this.player_in_vehicle());
            Engine.deactivate_team_nav_point_object(player, Engine.ai_vehicle_get_from_starting_location(e12_cov_banshees0.banshee0));
        }

        [ScriptMethod(354, Lifecycle.Dormant)]
        public async Task e12_cov_inf0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e12_cov_phantom0.Squad) > 0, 5);
            Engine.ai_place(e12_cov_inf0_0.Squad);
            Engine.ai_place(e12_cov_inf0_1.elite0);
            Engine.ai_place(e12_cov_inf0_1.elite1);
            if (!((bool)Engine.game_is_cooperative()))
            {
                Engine.ai_place(e12_cov_inf0_1.elite2);
            }

            await Engine.sleep(2);
            Engine.ai_vehicle_enter_immediate(e12_cov_inf0_0.Squad, Engine.ai_vehicle_get(e12_cov_phantom0.phantom0), "phantom_p_a");
            Engine.ai_vehicle_enter_immediate(e12_cov_inf0_1.Squad, Engine.ai_vehicle_get(e12_cov_phantom0.phantom0), "phantom_p_b");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_ledge, Engine.players()), 15);
            Engine.cs_run_command_script(e12_cov_inf0, new ScriptMethodReference(cs_e12_cov_inf0_look));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_ledge_entrance, Engine.players()), 15);
            Engine.cs_run_command_script(e12_cov_inf0, new ScriptMethodReference(cs_e12_cov_inf0_follow));
            Engine.ai_set_orders(e12_cov_inf0, e12_cov_inf0_advance0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_swap_room_halfway, Engine.players()), 15);
            Engine.ai_set_orders(e12_cov_inf0, e12_cov_inf0_advance1);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e12_cov_inf0_0.Squad);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e12_cov_inf0_1.Squad);
            await Engine.sleep_until(async () => Engine.device_get_position(e12_door0.Entity) > 0F, 15);
            Engine.ai_set_orders(e12_cov_inf0_0.Squad, e12_cov_inf0_engage0_right);
            Engine.ai_set_orders(e12_cov_inf0_1.Squad, e12_cov_inf0_engage0_left);
        }

        [ScriptMethod(355, Lifecycle.Dormant)]
        public async Task e12_main()
        {
            this.g_e12_started = true;
            Engine.game_save();
            Engine.print("e12_main");
            Engine.data_mine_set_mission_segment("e12_control_antechamber");
            Engine.wake(new ScriptMethodReference(chapter_title2));
            Engine.wake(new ScriptMethodReference(objective2_clear));
            Engine.wake(new ScriptMethodReference(objective3_set));
            Engine.wake(new ScriptMethodReference(e13_cinematic_main));
            Engine.wake(new ScriptMethodReference(e12_cov_banshees0_main));
            Engine.wake(new ScriptMethodReference(e12_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e12_pro_inf0_ender));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.game_save();
            Engine.sleep_forever(new ScriptMethodReference(e12_cov_banshees0_main));
            Engine.deactivate_team_nav_point_object(player, Engine.ai_vehicle_get_from_starting_location(e12_cov_banshees0.banshee0));
            await Engine.sleep_until(async () => this.g_e13_started);
            Engine.sleep_forever(new ScriptMethodReference(e12_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_cov_phantom0_main));
            Engine.sleep_forever(new ScriptMethodReference(e12_pro_inf0_main));
            Engine.ai_erase(e12_cov);
            Engine.ai_erase(e12_pro);
        }

        [ScriptMethod(356, Lifecycle.Static)]
        public async Task test_antechamber()
        {
            Engine.switch_bsp(2);
            Engine.object_teleport(await this.player0(), e12_test);
            if (!(this.g_e12_started))
            {
                Engine.wake(new ScriptMethodReference(e12_main));
            }
        }

        [ScriptMethod(357, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_phantom0_0_main()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p00"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p1"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p2"), Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1_facing"), 0.5F);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_lc");
            Engine.ai_braindead(e11_pro_wraith0_0.Squad, false);
            await Engine.sleep(30);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p1"), Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p3"), 0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p4"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_0/p5"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(358, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_phantom0_1_main()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p00"));
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p0"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1"), Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1_facing"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p2"), Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1_facing"), 0.5F);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_lc");
            Engine.ai_braindead(e11_pro_wraith0_1.Squad, false);
            await Engine.sleep(30);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p1"), Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p3"), 0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p4"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_phantom0_1/p5"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(359, Lifecycle.CommandScript)]
        public async Task cs_e11_attack_scarab()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint3")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint3")));
                return false;
            });
        }

        [ScriptMethod(360, Lifecycle.CommandScript)]
        public async Task cs_e11_attack_scarab_behavior()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) <= this.ai_combat_status_active);
                Engine.cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_attack_scarab));
                return false;
            });
        }

        [ScriptMethod(361, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_wraiths1_shoot()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint0")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint1")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint2")), 
                    async () => Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab_air/joint3")), 
                    async () => await Engine.sleep((short)Engine.random_range(90, 180)), 
                    async () => Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab_air/joint3")));
                return false;
            });
        }

        [ScriptMethod(362, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_wraiths1_bombard()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) <= this.ai_combat_status_active);
                Engine.cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_pro_wraiths1_shoot));
                return false;
            });
        }

        [ScriptMethod(363, Lifecycle.CommandScript)]
        public async Task cs_e11_ghost_door0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("e11_door_entry/p0"), Engine.GetReference<ISpatialPoint>("e11_door_entry/p1"));
            await Engine.sleep_until(async () =>
            {
                Engine.device_set_position(e11_door0.Entity, 1F);
                return Engine.device_get_position(e11_door0.Entity) >= 1F;
            }, 10);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e11_door_entry/p1"), Engine.GetReference<ISpatialPoint>("e11_door_entry/p2"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e11_door_entry/p2"));
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep(120);
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_attack_scarab_behavior));
        }

        [ScriptMethod(364, Lifecycle.CommandScript)]
        public async Task cs_e11_spectre_door0_entry()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get(this.ai_current_actor), "spectre_p_l", true);
            Engine.cs_go_to_and_face(Engine.GetReference<ISpatialPoint>("e11_door_entry/p0"), Engine.GetReference<ISpatialPoint>("e11_door_entry/p1"));
            await Engine.sleep_until(async () =>
            {
                Engine.device_set_position(e11_door0.Entity, 1F);
                return Engine.device_get_position(e11_door0.Entity) >= 1F;
            }, 10);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e11_door_entry/p1"), Engine.GetReference<ISpatialPoint>("e11_door_entry/p2"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e11_door_entry/p2"));
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            await Engine.sleep(120);
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_run_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e11_attack_scarab_behavior));
        }

        [ScriptMethod(365, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_banshees0_0_entry()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(90);
            Engine.cs_enable_moving(true);
            await Engine.sleep(150);
        }

        [ScriptMethod(366, Lifecycle.CommandScript)]
        public async Task cs_e11_pro_banshees0_1_entry()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e11_pro_banshees0_1_entry/p0"));
            Engine.cs_enable_moving(true);
            await Engine.sleep(150);
        }

        [ScriptMethod(367, Lifecycle.CommandScript)]
        public async Task cs_e11_scarab_main_gun_shoot()
        {
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e11_scarab_gunners/p0"));
            await Engine.sleep(165);
        }

        [ScriptMethod(368, Lifecycle.CommandScript)]
        public async Task cs_e11_cov_banshees0_die()
        {
            Engine.ai_kill(this.ai_current_actor);
        }

        [ScriptMethod(369, Lifecycle.Static)]
        public async Task<bool> e11_pro_phantom0_0_retreat()
        {
            return Engine.object_get_health(Engine.ai_vehicle_get(e11_pro_phantom0_0.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e11_pro_phantom0_0.phantom0), "target_front") >= 3;
        }

        [ScriptMethod(370, Lifecycle.Static)]
        public async Task<bool> e11_pro_phantom0_1_retreat()
        {
            return Engine.object_get_health(Engine.ai_vehicle_get(e11_pro_phantom0_1.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e11_pro_phantom0_1.phantom0), "target_front") >= 3;
        }

        [ScriptMethod(371, Lifecycle.Static)]
        public async Task<int> e11_pro_wraiths1_living_count()
        {
            float ifResult_40574674 = default(float);
            if (Engine.unit_get_health(Engine.ai_vehicle_get_from_starting_location(e11_pro_wraith1_0.wraith)) > 0F)
            {
                ifResult_40574674 = 1F;
            }
            else
            {
                ifResult_40574674 = 0F;
            }

            float ifResult_63601460 = default(float);
            if (Engine.unit_get_health(Engine.ai_vehicle_get_from_starting_location(e11_pro_wraith1_1.wraith)) > 0F)
            {
                ifResult_63601460 = 1F;
            }
            else
            {
                ifResult_63601460 = 0F;
            }

            float ifResult_55432838 = default(float);
            if (Engine.unit_get_health(Engine.ai_vehicle_get_from_starting_location(e11_pro_wraith1_2.wraith)) > 0F)
            {
                ifResult_55432838 = 1F;
            }
            else
            {
                ifResult_55432838 = 0F;
            }

            float ifResult_63913605 = default(float);
            if (Engine.unit_get_health(Engine.ai_vehicle_get_from_starting_location(e11_pro_wraith1_3.wraith)) > 0F)
            {
                ifResult_63913605 = 1F;
            }
            else
            {
                ifResult_63913605 = 0F;
            }

            return (short)(ifResult_40574674 + ifResult_63601460 + ifResult_55432838 + ifResult_63913605);
        }

        [ScriptMethod(372, Lifecycle.Static)]
        public async Task<bool> e11_pro_wraiths1_weakened()
        {
            return await this.e11_pro_wraiths1_living_count() <= 2;
        }

        [ScriptMethod(373, Lifecycle.Static)]
        public async Task<bool> e11_door_blocked()
        {
            return Engine.cs_command_script_queued(e11_pro_ghosts0.Squad, new ScriptMethodReference(cs_e11_ghost_door0_entry)) || Engine.cs_command_script_queued(e11_pro_spectres0.Squad, new ScriptMethodReference(cs_e11_spectre_door0_entry));
        }

        [ScriptMethod(374, Lifecycle.Dormant)]
        public async Task e11_pro_phantom1_main()
        {
            await Engine.sleep_until(async () => !(Engine.objects_can_see_flag(Engine.players(), e11_pro_phantom1_spawn, 80F)) && (short)Engine.ai_living_count(e11_pro_phantom0_0.Squad) <= 0 && (short)Engine.ai_living_count(e11_pro_wraith0_0.Squad) <= 0, 30);
            Engine.ai_place_in_vehicle(e11_pro_wraith0_1.Squad, e11_pro_phantom0_1.Squad);
            Engine.ai_braindead(e11_pro_wraith0_1.Squad, true);
        }

        [ScriptMethod(375, Lifecycle.Dormant)]
        public async Task e11_pro_phantom0_main()
        {
            await Engine.sleep_until(async () => this.g_e11_door_open);
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_outer_cove, Engine.players())), 30);
            Engine.ai_place(e11_pro_phantom0_0.Squad);
            Engine.ai_place_in_vehicle(e11_pro_wraith0_0.Squad, e11_pro_phantom0_0.Squad);
            Engine.ai_braindead(e11_pro_wraith0_0.Squad, true);
        }

        [ScriptMethod(376, Lifecycle.Dormant)]
        public async Task e11_pro_banshees0_main()
        {
            await Engine.sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 2);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e11_pro_banshees0) <= 0)
                {
                    await Engine.sleep_until(async () =>
                    {
                        if (Engine.volume_test_objects(tv_e11_outer_cove, Engine.players()))
                        {
                            Engine.ai_place(e11_pro_banshees0_1.Squad, 1);
                        }
                        else
                        {
                            Engine.ai_place(e11_pro_banshees0_0.Squad, 1);
                        }

                        return (short)Engine.ai_living_count(e11_pro_banshees0) >= 2;
                    }, 60);
                }

                return (short)Engine.ai_spawn_count(e11_pro_banshees0) >= 10;
            }, 450);
        }

        [ScriptMethod(377, Lifecycle.Dormant)]
        public async Task e11_pro_spectres0_main()
        {
            await Engine.sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 1 && (short)Engine.ai_spawn_count(e11_pro_banshees0) > 6);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e11_pro_spectres0.Squad) < 2 && Engine.objects_distance_to_object(Engine.players(), e11_door0.Entity) > 50F)
                {
                    await Engine.sleep_until(async () => !(await this.e11_door_blocked()), 5);
                    if ((short)Engine.structure_bsp_index() == 0)
                    {
                        Engine.ai_place(e11_pro_spectres0.Squad);
                    }
                }

                return (short)Engine.ai_spawn_count(e11_pro_spectres0.Squad) >= 6;
            }, 150);
        }

        [ScriptMethod(378, Lifecycle.Dormant)]
        public async Task e11_pro_ghosts0_main()
        {
            await Engine.sleep_until(async () => this.g_e11_door_open);
            await Engine.sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 0);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e11_pro_ghosts0.Squad) < 3 && Engine.objects_distance_to_object(Engine.players(), e11_door0.Entity) > 50F)
                {
                    await Engine.sleep_until(async () => !(await this.e11_door_blocked()), 5);
                    if ((short)Engine.structure_bsp_index() == 0)
                    {
                        Engine.ai_place(e11_pro_ghosts0.Squad, 1);
                    }
                }

                return (short)Engine.ai_spawn_count(e11_pro_ghosts0.Squad) >= 16;
            }, 150);
        }

        [ScriptMethod(379, Lifecycle.Dormant)]
        public async Task e11_pro_wraith_checkpoints()
        {
            await Engine.sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 3, 61);
            Engine.game_save();
            await Engine.sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 2, 61);
            Engine.game_save();
            await Engine.sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 1, 61);
            Engine.game_save();
            await Engine.sleep_until(async () => await this.e11_pro_wraiths1_living_count() <= 0, 61);
            Engine.game_save();
        }

        [ScriptMethod(380, Lifecycle.Dormant)]
        public async Task e11_pro_wraith1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_pro_wraiths1_begin, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e11_pro_wraith_checkpoints));
            Engine.ai_place(e11_pro_wraith1_0.Squad);
            Engine.ai_place(e11_pro_wraith1_1.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e11_pro_wraith1) <= 0);
            Engine.wake(new ScriptMethodReference(e11_pro_phantom0_main));
        }

        [ScriptMethod(381, Lifecycle.Dormant)]
        public async Task e11_cov_banshees0_main()
        {
            if (!(await this.players_in_vehicle()))
            {
                Engine.ai_place(e11_cov_banshees0.Squad);
            }
        }

        [ScriptMethod(382, Lifecycle.Dormant)]
        public async Task e11_navpoint()
        {
            await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), e11_exit_door1) > 185F, 60, this.one_minute);
            Engine.activate_team_nav_point_flag(_default, player, e11_exit_door1, 0F);
        }

        [ScriptMethod(383, Lifecycle.Dormant)]
        public async Task e11_navpoint_kill()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_ledge, Engine.players()));
            Engine.sleep_forever(new ScriptMethodReference(e11_navpoint));
            Engine.deactivate_team_nav_point_flag(player, e11_exit_door1);
        }

        [ScriptMethod(384, Lifecycle.Dormant)]
        public async Task e11_door_opening()
        {
            await Engine.sleep_until(async () => this.g_e11_door_should_open, 10);
            await Engine.sleep(120);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound_remastered\\visual_effects\\deltacontrol_bigdoorexplosion", 3852338216U), default(IGameObject), 1F);
            Engine.effect_new(Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\deltacontrolroom\\scarab_attack_deltacontrol", 3852403753U), e11_door_explosion);
            Engine.object_destroy(e11_exit_door.Entity);
            this.g_e11_door_open = true;
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(e11_navpoint));
            Engine.wake(new ScriptMethodReference(e11_navpoint_kill));
        }

        [ScriptMethod(385, Lifecycle.Dormant)]
        public async Task e11_scarab_main()
        {
            Engine.pvs_set_object(scarab.Entity);
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_turn_22_left();
            await this.scarab_walk_front_turn_15_right();
            await this.scarab_walk_front_to_idle();
            await this.scarab_gun_open_up();
            await Engine.sleep_until(async () =>
            {
                await this.scarab_idle_var0();
                return Engine.volume_test_objects(tv_e11_outer_cove, Engine.players());
            }, 1);
            Engine.print("johnson: stay clear of the door");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0840"));
            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players())), 10, 45);
            if (Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players()))
            {
                Engine.print("johnson: you trying to get killed?");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0860"));
                await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players())), 10, 60);
            }

            if (Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players()))
            {
                Engine.print("johnson: what? do i have to spell it out for you? move!");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0870"));
                await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players())), 10, 60);
                if (Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players()))
                {
                    Engine.print("johnson: listen, i'm gonna count to three.");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0880"));
                    await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players())), 10, 30);
                    if (Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players()))
                    {
                        Engine.print("johnson: one...");
                        await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0890"));
                        await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players())), 10, 45);
                        if (Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players()))
                        {
                            Engine.print("johnson: two...");
                            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0900"));
                            await Engine.sleep_until(async () => !(Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players())), 10, 60);
                            if (Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players()))
                            {
                                Engine.print("johnson: don't say i didn't warn you!");
                                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0910"));
                            }
                            else
                            {
                                await Engine.sleep(20);
                                Engine.print("johnson: good! now stay put!");
                                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0920"));
                                this.g_e11_player_warned = true;
                            }
                        }
                        else
                        {
                            await Engine.sleep(20);
                            Engine.print("johnson: good! now stay put!");
                            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0920"));
                            this.g_e11_player_warned = true;
                        }
                    }
                    else
                    {
                        await Engine.sleep(20);
                        Engine.print("johnson: good! now stay put!");
                        await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0920"));
                        this.g_e11_player_warned = true;
                    }
                }
                else
                {
                    await Engine.sleep(25);
                    Engine.print("johnson: good! now stay put!");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0920"));
                    this.g_e11_player_warned = true;
                }
            }

            await Engine.sleep(30);
            if (this.g_e11_player_warned && Engine.volume_test_objects(tv_e11_exit_vicinity, Engine.players()))
            {
                Engine.print("johnson: yeah, that's real funny. i'm still shooting.");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0930"));
            }
            else
            {
                Engine.print("johnson: hey bastards, knock knock!");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0850"));
            }

            Engine.wake(new ScriptMethodReference(music_08b_07_start));
            Engine.wake(new ScriptMethodReference(music_08b_08_start));
            Engine.wake(new ScriptMethodReference(e11_door_opening));
            await Engine.sleep_until(async () =>
            {
                await this.scarab_gun_fire_up();
                Engine.cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e11_scarab_main_gun_shoot));
                this.g_e11_shot_counter = (short)(this.g_e11_shot_counter + 1);
                if (Engine.objects_can_see_flag(Engine.players(), e11_exit_door1, 25F))
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
            Engine.wake(new ScriptMethodReference(e12_main));
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_var0();
            await this.scarab_walk_front_to_idle();
            await this.scarab_idle_turn_22_left();
            await this.scarab_idle_turn_22_left();
            Engine.pvs_clear();
            await Engine.sleep_until(async () =>
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
                Engine.sleep_forever();
            }

            Engine.object_create(key);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3853124660U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 3853124660U)));
            Engine.ice_cream_flavor_stock(8);
        }

        [ScriptMethod(387, Lifecycle.Dormant)]
        public async Task e11_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e11_main_begin, Engine.players()), 15);
            this.g_e11_started = true;
            Engine.game_save();
            Engine.print("e11_main");
            Engine.data_mine_set_mission_segment("e11_scarab_boardings");
            Engine.kill_volume_disable(kill_e8_0);
            Engine.wake(new ScriptMethodReference(e11_pro_banshees0_main));
            Engine.wake(new ScriptMethodReference(e11_pro_wraith1_main));
            Engine.wake(new ScriptMethodReference(e11_cov_banshees0_main));
            Engine.wake(new ScriptMethodReference(e11_key));
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.sleep_forever(new ScriptMethodReference(e11_pro_wraith1_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_pro_banshees0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_pro_phantom0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_pro_phantom1_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_pro_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_pro_spectres0_main));
            Engine.sleep_forever(new ScriptMethodReference(e11_pro_wraith_checkpoints));
            Engine.ai_erase(e11_pro);
            Engine.ai_erase(e11_cov);
        }

        [ScriptMethod(388, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_phantom0_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p0"), Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p1"), 1F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p0_1"), Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p1"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_exit/p2"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(389, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_phantom0_entry()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_entry/p0"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_entry/p1"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e9_pro_phantom0_entry/p2"), 1F);
            await Engine.sleep_until(async () => this.g_e9_scarab_at_second_bend, 15);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("scarab_air/dropship_p1"), Engine.GetReference<ISpatialPoint>("scarab_air/dropship_p1_facing"));
            Engine.cs_vehicle_speed(0.25F);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("scarab_air/dropship_p1"), Engine.GetReference<ISpatialPoint>("scarab_air/dropship_p1_facing"), 3F);
                return false;
            }, 3, 60);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_p_a");
            await Engine.sleep_until(async () =>
            {
                Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("scarab_air/dropship_p1"), Engine.GetReference<ISpatialPoint>("scarab_air/dropship_p1_facing"), 3F);
                return false;
            }, 3, 300);
            this.g_e9_pro_phantom0_unloaded = true;
        }

        [ScriptMethod(390, Lifecycle.CommandScript)]
        public async Task cs_e9_pro_banshees0_entry()
        {
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(120);
        }

        [ScriptMethod(391, Lifecycle.Dormant)]
        public async Task e9_pro_spectres0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_second_bend, Engine.players()) || this.g_e9_scarab_started, 15);
            Engine.ai_place(e9_pro_spectres0_0.Squad);
            await Engine.sleep(1);
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get(e9_pro_spectres0_0.spectre0), "spectre_p_l", true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_second_bend, Engine.players()) || (short)Engine.ai_living_count(e9_pro_spectres0) <= 1, 15);
            Engine.ai_place(e9_pro_spectres0_1.Squad);
            await Engine.sleep(1);
            Engine.ai_vehicle_reserve_seat(Engine.ai_vehicle_get(e9_pro_spectres0_1.starting_locations_0), "spectre_p_l", true);
        }

        [ScriptMethod(392, Lifecycle.Dormant)]
        public async Task e9_pro_phantom0_main()
        {
            await Engine.sleep_until(async () => this.g_e9_scarab_near_second_bend, 15);
            Engine.ai_place(e9_pro_phantom0.Squad);
            await Engine.sleep_until(async () => this.g_e9_pro_phantom0_unloaded);
            await Engine.sleep_until(async () => Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e9_pro_phantom0.phantom0), "target_front") >= 3 || Engine.object_get_health(Engine.ai_vehicle_get(e9_pro_phantom0.phantom0)) <= 0.05F, 15, 450);
            this.g_e9_pro_phantom0_retreating = true;
            Engine.cs_run_command_script(e9_pro_phantom0.phantom0, new ScriptMethodReference(cs_e9_pro_phantom0_exit));
            await Engine.sleep(150);
            if (Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e9_pro_phantom0.phantom0), "target_front") >= 3 || Engine.object_get_health(Engine.ai_vehicle_get(e9_pro_phantom0.phantom0)) <= 0.05F)
            {
                Engine.print("johnson: now i know why you have the fancy armor");
                Engine.ai_play_line_on_object(default(IGameObject), "0690") // Couldn't generate cast from 'Short' to 'Void'
                ;
            }
        }

        [ScriptMethod(393, Lifecycle.Dormant)]
        public async Task e9_pro_banshees0_main()
        {
            await Engine.sleep_until(async () => this.g_e9_scarab_near_first_bend);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e9_pro_banshees0.Squad) <= 0 || (short)Engine.ai_living_count(e9_pro_banshees0.Squad) <= 1 && (short)Engine.ai_living_count(e9_pro_inf0.Squad) <= 2 && (short)Engine.ai_living_count(e9_pro_spectres0) <= 0)
                {
                    Engine.ai_place(e9_pro_banshees0.Squad, 1);
                }

                return (short)Engine.ai_spawn_count(e9_pro_banshees0.Squad) >= 6 || Engine.volume_test_objects(tv_e9_pro_banshees0_stop, Engine.players()) || this.g_e9_scarab_stepping_down;
            }, 60);
            Engine.ai_migrate(e9_pro_banshees0.Squad, e11_pro_banshees0_1.Squad);
        }

        [ScriptMethod(394, Lifecycle.Dormant)]
        public async Task e9_pro_inf3_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e9_pro_phantom0.Squad) > 0);
            Engine.ai_place_in_vehicle(e9_pro_inf3_0.Squad, e9_pro_phantom0.Squad);
        }

        [ScriptMethod(395, Lifecycle.Dormant)]
        public async Task e9_pro_inf0_main()
        {
            Engine.ai_place(e9_pro_inf0.Squad);
        }

        [ScriptMethod(396, Lifecycle.Dormant)]
        public async Task e9_scarab_navpoint()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), scarab.Entity) < 40F)
                {
                    Engine.deactivate_team_nav_point_object(player, scarab.Entity);
                }

                if (Engine.objects_distance_to_object(Engine.players(), scarab.Entity) > 60F)
                {
                    Engine.activate_team_nav_point_object(_default, player, scarab.Entity, 10F);
                }

                return this.g_e11_door_open;
            }, 140);
            Engine.deactivate_team_nav_point_object(player, scarab.Entity);
        }

        [ScriptMethod(397, Lifecycle.Dormant)]
        public async Task e9_scarab_main()
        {
            Engine.pvs_set_object(scarab.Entity);
            if (await this.difficulty_normal())
            {
                Engine.wake(new ScriptMethodReference(e9_scarab_navpoint));
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
            await Engine.sleep_until(async () =>
            {
                await this.scarab_idle_var0();
                return true && !(Engine.volume_test_objects(tv_scarab, Engine.ai_actors(e9_pro_inf3)));
            }, 1);
            await this.scarab_idle_to_walk_front();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_turn_22_right();
            this.g_e9_scarab_stepping_down = true;
            Engine.device_set_position_track(scarab.Entity, "delta_canyon_step_down", this.g_scarab_interpolation);
            Engine.device_animate_position(scarab.Entity, 1F, 350F / 30F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
            await this.scarab_walk_front_turn_22_right();
            await this.scarab_walk_front_turn_15_left();
            await this.scarab_walk_front_var0();
            Engine.wake(new ScriptMethodReference(e11_scarab_main));
        }

        [ScriptMethod(398, Lifecycle.Static)]
        public async Task e9_scarab_test()
        {
            Engine.object_teleport(scarab.Entity, e9_scarab);
            Engine.wake(new ScriptMethodReference(e9_scarab_main));
        }

        [ScriptMethod(399, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_main_begin, Engine.players()) || this.g_e9_scarab_started, 15);
            this.g_e9_started = true;
            Engine.game_save();
            Engine.print("e9_main");
            Engine.data_mine_set_mission_segment("e9_scarab_canyon");
            Engine.wake(new ScriptMethodReference(e9_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e9_pro_inf3_main));
            Engine.wake(new ScriptMethodReference(e9_pro_spectres0_main));
            Engine.wake(new ScriptMethodReference(e9_pro_banshees0_main));
            await Engine.sleep_until(async () => this.g_e11_started);
            Engine.ai_disposable(e9_pro, true);
            await Engine.sleep_until(async () => this.g_e12_started);
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_inf3_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_spectres0_main));
            Engine.sleep_forever(new ScriptMethodReference(e9_pro_banshees0_main));
        }

        [ScriptMethod(400, Lifecycle.Static)]
        public async Task test_scarab_canyon()
        {
            Engine.object_teleport(scarab.Entity, e9_scarab);
            Engine.wake(new ScriptMethodReference(e9_main));
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(e9_main));
            Engine.wake(new ScriptMethodReference(e11_main));
        }

        [ScriptMethod(401, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_phantom0_exit()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_pro_phantom0_exit/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_pro_phantom0_exit/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_pro_phantom0_exit/p2"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(402, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_entry0()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(80);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p0_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p0_1"), 15F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p0_1"), 2F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(this.ai_current_actor);
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_ignore_obstacles(false);
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 3F || this.g_e8_cov_banshees0_greeted);
            if (!(this.g_e8_cov_banshees0_greeted))
            {
                Engine.print("elite: take my banshee");
                this.g_e8_cov_banshees0_greeted = true;
                await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0800"));
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 10F || await this.players_in_vehicle());
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/exit0"));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 40F);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(403, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_entry1()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(70);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p1_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p1_1"), 15F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p1_1"), 2F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(this.ai_current_actor);
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_ignore_obstacles(false);
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 3F || this.g_e8_cov_banshees0_greeted);
            if (!(this.g_e8_cov_banshees0_greeted))
            {
                Engine.print("elite: take my banshee");
                this.g_e8_cov_banshees0_greeted = true;
                await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0800"));
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 10F || await this.players_in_vehicle());
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/exit0"));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 40F);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(404, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_entry2()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(70);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p2_0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p2_1"), 15F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p2_1"), 2F);
            await Engine.sleep(15);
            Engine.ai_vehicle_exit(this.ai_current_actor);
            Engine.object_can_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.cs_ignore_obstacles(false);
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 0F && Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 3F || this.g_e8_cov_banshees0_greeted);
            if (!(this.g_e8_cov_banshees0_greeted))
            {
                Engine.print("elite: take my banshee");
                this.g_e8_cov_banshees0_greeted = true;
                await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0800"));
            }

            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 10F || await this.players_in_vehicle());
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/exit1"));
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) > 40F);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(405, Lifecycle.CommandScript)]
        public async Task cs_e8_cov_banshee0_flyby()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_vehicle_boost(true);
            await Engine.sleep(100);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e8_cov_banshees0_entry/p4"));
            Engine.object_destroy(Engine.ai_vehicle_get(this.ai_current_actor));
            await Engine.sleep(1);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(406, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_wraith0_0_bombard()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_face_object(true, scarab.Entity);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p0_0"));
                Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab/target_right"));
                await Engine.sleep_until(async () => this.g_e8_target_wraith == 0, 10);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab/target_right"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p0_1"));
                await Engine.sleep((short)Engine.random_range(180, 210));
                return false;
            }, 1);
        }

        [ScriptMethod(407, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_wraith0_1_bombard()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_face_object(true, scarab.Entity);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p1_0"));
                Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab/target_left"));
                await Engine.sleep_until(async () => this.g_e8_target_wraith == 1, 10);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab/target_left"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p1_1"));
                await Engine.sleep((short)Engine.random_range(180, 210));
                return false;
            }, 1);
        }

        [ScriptMethod(408, Lifecycle.CommandScript)]
        public async Task cs_e8_pro_wraith0_2_bombard()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_face_object(true, scarab.Entity);
            await Engine.sleep_until(async () =>
            {
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p2_0"));
                Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("scarab/target_left"));
                await Engine.sleep_until(async () => this.g_e8_target_wraith == 2, 10);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("scarab/target_left"));
                Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e8_pro_wraiths0_bombard/p2_1"));
                await Engine.sleep((short)Engine.random_range(180, 210));
                return false;
            }, 1);
        }

        [ScriptMethod(409, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_idle()
        {
            Engine.sleep_forever();
        }

        [ScriptMethod(410, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_shoot0()
        {
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e8_scarab_gunners/p0"));
            await Engine.sleep(75);
            if (Engine.volume_test_objects(tv_e8_scarab_fire_unsafe, Engine.players()))
            {
                await this.scarab_gun_fire_down_abort();
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e8_scarab_gunners/p0"));
            }

            await Engine.sleep(90);
        }

        [ScriptMethod(411, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_shoot1()
        {
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e8_scarab_gunners/p1"));
            await Engine.sleep(75);
            if (Engine.volume_test_objects(tv_e8_scarab_fire_unsafe, Engine.players()))
            {
                await this.scarab_gun_fire_down_abort();
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e8_scarab_gunners/p1"));
            }

            await Engine.sleep(90);
        }

        [ScriptMethod(412, Lifecycle.CommandScript)]
        public async Task cs_e8_scarab_main_gun_shoot2()
        {
            Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("e8_scarab_gunners/p2"));
            await Engine.sleep(75);
            if (Engine.volume_test_objects(tv_e8_scarab_fire_unsafe, Engine.players()))
            {
                await this.scarab_gun_fire_down_abort();
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("e8_scarab_gunners/p2"));
            }

            await Engine.sleep(90);
        }

        [ScriptMethod(413, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_johnson_init()
        {
            Engine.cs_enable_dialogue(true);
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.object_cinematic_lod(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.ai_vehicle_enter_immediate(this.ai_current_actor, Engine.unit(Engine.object_at_marker(scarab.Entity, "scarab_d_l")), "scarab_d_r");
            Engine.cs_look_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(414, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_inf0_emerge()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_visible);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("scarab/p2"));
        }

        [ScriptMethod(415, Lifecycle.CommandScript)]
        public async Task cs_e8_mars_inf0_retreat()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("scarab/p0"));
        }

        [ScriptMethod(416, Lifecycle.Dormant)]
        public async Task e8_scarab_main()
        {
            Engine.pvs_set_object(scarab.Entity);
            Engine.print("hide main gunner");
            Engine.object_hide(Engine.object_at_marker(scarab.Entity, "primary_trigger"), true);
            Engine.device_set_position_track(scarab.Entity, "delta_ledge_exit", 0F);
            Engine.device_animate_position(scarab.Entity, 1F, 1F / 30F, 0F, 0F, true);
            await Engine.sleep(3);
            Engine.object_create(scarab_door);
            Engine.objects_attach(scarab.Entity, "plasma_door", scarab_door.Entity, "");
            Engine.ai_place(scarab_gunners.main_gunner);
            Engine.vehicle_load_magic(Engine.unit(Engine.object_at_marker(scarab.Entity, "primary_trigger")), "scarab_turret_d", Engine.ai_get_object(scarab_gunners.main_gunner));
            Engine.cs_run_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_idle));
            await this.scarab_idle_var0();
            await this.scarab_idle_turn_22_right_slow();
            await this.scarab_idle_turn_45_right_slow();
            await this.scarab_idle_turn_22_right_slow();
            await this.scarab_gun_open_down();
            await this.scarab_idle_turn_15_right_slow();
            this.g_e8_target_wraith = 1;
            await this.scarab_idle_to_twist_5_left();
            await this.scarab_gun_fire_down();
            Engine.cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot1));
            await this.scarab_twist_5_left_firing();
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(e8_pro_wraiths0_0.Squad) > 0)
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
                        if (!(Engine.volume_test_objects(tv_e8_scarab_fire_unsafe, Engine.players())))
                        {
                            await this.scarab_gun_fire_down();
                            Engine.cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot0));
                            await this.scarab_twist_5_right_firing();
                        }
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_pro_wraiths0_1.Squad) > 0)
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
                        if (!(Engine.volume_test_objects(tv_e8_scarab_fire_unsafe, Engine.players())))
                        {
                            await this.scarab_gun_fire_down();
                            Engine.cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot1));
                            await this.scarab_twist_5_left_firing();
                        }
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_pro_wraiths0_2.Squad) > 0)
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
                        if (!(Engine.volume_test_objects(tv_e8_scarab_fire_unsafe, Engine.players())))
                        {
                            await this.scarab_gun_fire_down();
                            Engine.cs_stack_command_script(scarab_gunners.main_gunner, new ScriptMethodReference(cs_e8_scarab_main_gun_shoot2));
                            await this.scarab_twist_5_left_firing();
                        }
                    }
                });
                return (short)Engine.ai_living_count(e8_pro_wraiths0) <= 0;
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
            Engine.wake(new ScriptMethodReference(e9_scarab_main));
        }

        [ScriptMethod(417, Lifecycle.Dormant)]
        public async Task e8_wraith_dialogue()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e8_pro_wraiths0) <= 2);
            await Engine.sleep(30);
            Engine.print("johnson: hah, how do you like it?");
            Engine.ai_play_line_on_object(default(IGameObject), "0660") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(418, Lifecycle.Dormant)]
        public async Task e8_pro_wraiths0_main()
        {
            await Engine.sleep_until(async () => await this.players_in_vehicle() || Engine.volume_test_objects(tv_e8_exit, Engine.players()), 30, 450);
            Engine.ai_place(e8_pro_wraiths0);
            Engine.wake(new ScriptMethodReference(e8_wraith_dialogue));
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_combat_status(e8_pro_wraiths0_0.Squad) <= this.ai_combat_status_active && !(Engine.cs_command_script_queued(e8_pro_wraiths0_0.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_0_bombard))))
                {
                    Engine.print("wraith0 bombard");
                    Engine.cs_run_command_script(e8_pro_wraiths0_0.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_0_bombard));
                }

                if ((short)Engine.ai_combat_status(e8_pro_wraiths0_1.Squad) <= this.ai_combat_status_active && !(Engine.cs_command_script_queued(e8_pro_wraiths0_1.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_1_bombard))))
                {
                    Engine.print("wraith1 bombard");
                    Engine.cs_run_command_script(e8_pro_wraiths0_1.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_1_bombard));
                }

                if ((short)Engine.ai_combat_status(e8_pro_wraiths0_2.Squad) <= this.ai_combat_status_active && !(Engine.cs_command_script_queued(e8_pro_wraiths0_2.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_2_bombard))))
                {
                    Engine.print("wraith2 bombard");
                    Engine.cs_run_command_script(e8_pro_wraiths0_2.Squad, new ScriptMethodReference(cs_e8_pro_wraith0_2_bombard));
                }

                return (short)Engine.ai_living_count(e8_pro_wraiths0) <= 0;
            });
            await Engine.sleep(60);
            Engine.game_save();
        }

        [ScriptMethod(419, Lifecycle.Dormant)]
        public async Task e8_cov_banshees0_main()
        {
            Engine.ai_place(e8_cov_banshees0.banshee1);
            await Engine.sleep(60);
            Engine.ai_place(e8_cov_banshees0.banshee0);
            await Engine.sleep(90);
            Engine.ai_place(e8_cov_banshees0.banshee2);
            await Engine.sleep_until(async () => await this.players_in_vehicle() || Engine.volume_test_objects(tv_e8_exit, Engine.players()));
            Engine.wake(new ScriptMethodReference(music_08b_06_start));
            Engine.game_save();
        }

        [ScriptMethod(420, Lifecycle.Static)]
        public async Task<bool> e8_mars_inf0_should_activate()
        {
            return Engine.volume_test_objects(tv_scarab, Engine.players()) || Engine.volume_test_objects(tv_scarab, Engine.ai_actors(e9_pro_inf3));
        }

        [ScriptMethod(421, Lifecycle.Dormant)]
        public async Task e8_mars_inf0_main()
        {
            await Engine.sleep(30);
            Engine.ai_place(e8_mars_inf0.Squad);
            await Engine.sleep_until(async () =>
            {
                if (await this.e8_mars_inf0_should_activate())
                {
                    if ((short)Engine.ai_living_count(e8_mars_inf0.Squad) <= 0)
                    {
                        Engine.ai_place(e8_mars_inf0.Squad, this.g_e8_mars_inf0_living_count);
                    }
                    else
                    {
                        Engine.cs_run_command_script(e8_mars_inf0.Squad, new ScriptMethodReference(cs_e8_mars_inf0_emerge));
                        Engine.cs_run_command_script(e8_mars_inf0.johnson, new ScriptMethodReference(cs_e8_mars_johnson_init));
                    }

                    await Engine.sleep_until(async () => !(await this.e8_mars_inf0_should_activate()));
                }
                else if ((short)Engine.ai_living_count(e8_mars_inf0.Squad) > 0)
                {
                    this.g_e8_mars_inf0_living_count = (short)Engine.ai_living_count(e8_mars_inf0.Squad);
                    Engine.cs_run_command_script(e8_mars_inf0.Squad, new ScriptMethodReference(cs_e8_mars_inf0_retreat));
                    await Engine.sleep_until(async () => await this.e8_mars_inf0_should_activate() || Engine.volume_test_objects_all(tv_scarab_interior, Engine.ai_actors(e8_mars_inf0.Squad)));
                    if (!(await this.e8_mars_inf0_should_activate()))
                    {
                        Engine.ai_erase(e8_mars_inf0.Squad);
                    }
                }

                return false;
            });
        }

        [ScriptMethod(422, Lifecycle.Dormant)]
        public async Task e8_cov_inf0_main()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(423, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            this.g_e8_started = true;
            Engine.game_save();
            Engine.print("e8_main");
            Engine.data_mine_set_mission_segment("e8_scarab_cove");
            Engine.kill_volume_disable(kill_e8_0);
            Engine.wake(new ScriptMethodReference(objective1_clear));
            Engine.wake(new ScriptMethodReference(objective2_set));
            Engine.wake(new ScriptMethodReference(e9_main));
            Engine.wake(new ScriptMethodReference(e11_main));
            Engine.object_create(e8_banshee0);
            Engine.object_create(e8_banshee1);
            Engine.wake(new ScriptMethodReference(e8_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e8_cov_banshees0_main));
            Engine.wake(new ScriptMethodReference(e8_pro_wraiths0_main));
            Engine.wake(new ScriptMethodReference(e8_scarab_main));
            await Engine.sleep_until(async () => this.g_e9_started);
            Engine.ai_disposable(e8_cov, true);
        }

        [ScriptMethod(424, Lifecycle.Static)]
        public async Task test_scarab_ride()
        {
            Engine.object_teleport(scarab.Entity, e8_scarab);
            if (!(this.g_e8_started))
            {
                Engine.wake(new ScriptMethodReference(e8_main));
            }
        }

        [ScriptMethod(425, Lifecycle.Dormant)]
        public async Task scarab_test_loop()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.object_create_anew(scarab);
                Engine.pvs_set_object(scarab.Entity);
                Engine.device_set_position_track(scarab.Entity, "delta_ledge_exit", 0F);
                Engine.device_animate_position(scarab.Entity, 1F, 90F / 30F, 0F, 0F, true);
                await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
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
                Engine.device_set_position_track(scarab.Entity, "delta_canyon_step_down", 0F);
                Engine.device_animate_position(scarab.Entity, 1F, 350F / 30F, 0F, 0F, true);
                await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
                await this.scarab_walk_front_var0();
                return false;
            }, 1);
        }

        [ScriptMethod(426, Lifecycle.CommandScript)]
        public async Task cs_e7_mars_inf0_wait()
        {
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.custom_animation_loop(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_unarmed", false);
            await Engine.sleep_until(async () => this.g_e7_mars_johnson_go, 3);
            await Engine.sleep(15);
            Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_to_idle_pistol", false);
            Engine.cs_enable_moving(true);
            await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(427, Lifecycle.CommandScript)]
        public async Task cs_e7_mars_inf0_johnson()
        {
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.unit_impervious(Engine.ai_get_unit(this.ai_current_actor), true);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.custom_animation_relative_loop(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_unarmed_johnson", false, anchor_intra2.Entity);
            await Engine.sleep_until(async () => this.g_e7_mars_johnson_go, 3);
            Engine.print("johnson: go go go!");
            Engine.ai_play_line(this.ai_current_actor, "3000") // Couldn't generate cast from 'Short' to 'Void'
            ;
            Engine.custom_animation_relative(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\deltacontrol\\deltacontrol", 3854304326U), "kneel_2_scarab", false, anchor_intra2.Entity);
            await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
            this.g_e7_mars_johnson_aboard = true;
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("scarab/p0"));
        }

        [ScriptMethod(428, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_wait()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(e7_door0.Entity) > 0F, 5);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_abort_on_damage(true);
            Engine.cs_look_object(true, Engine.ai_get_object(e7_mars_inf0.johnson0));
            await Engine.sleep_until(async () => this.g_e7_pro_sentry_alerted, 10);
            Engine.ai_magically_see_object(this.ai_current_squad, await this.player0());
            Engine.cs_force_combat_status(4);
        }

        [ScriptMethod(429, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_captain_alert()
        {
            Engine.cs_aim_player(true);
            await Engine.sleep(20);
            Engine.print("cpn: elites!");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0400"));
            this.g_e7_mars_johnson_go = true;
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(430, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_captain()
        {
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e7_pro_inf0_captain_alert));
            await Engine.sleep_until(async () => Engine.device_get_position(e7_door0.Entity) > 0F, 5);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_active);
            Engine.cs_abort_on_damage(true);
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.print("tar: mine will do. kill the others.");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0050"));
            await Engine.sleep(20);
            Engine.print("cpn: yes chieftan.");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0060"));
            Engine.cs_look_object(true, Engine.ai_get_object(e7_mars_inf0.johnson0));
            await Engine.sleep(20);
            Engine.print("cpn: a day's rations says i do this in one cut.");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0070"));
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e7_pro_inf0_sentry/p1"));
            await Engine.sleep(20);
            this.g_e7_pro_captain_done = true;
            Engine.print("guard: two cuts, at least");
            await Engine.sleep(Engine.ai_play_line(e7_pro_inf0.guard0, "0090"));
            await Engine.sleep(20);
            Engine.print("cpn: done!");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0100"));
            await Engine.sleep_until(async () => this.g_e7_pro_sentry_alerted, 10);
            Engine.ai_magically_see_object(this.ai_current_squad, await this.player0());
            Engine.cs_force_combat_status(4);
        }

        [ScriptMethod(431, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_sentry0_alerted()
        {
            Engine.print("sentry: wait, movement!");
            await Engine.sleep(Engine.ai_play_line(this.ai_current_actor, "0110"));
            this.g_e7_pro_sentry_alerted = true;
            Engine.ai_magically_see_object(this.ai_current_squad, await this.player0());
            Engine.cs_force_combat_status(4);
        }

        [ScriptMethod(432, Lifecycle.CommandScript)]
        public async Task cs_e7_pro_inf0_sentry0()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep_until(async () => this.g_e7_pro_captain_done || Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) <= 5F, 10);
            Engine.cs_look(true, Engine.GetReference<ISpatialPoint>("e7_pro_inf0_sentry/look0"));
            await Engine.sleep(45);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e7_pro_inf0_sentry/look1"));
            await Engine.sleep(60);
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e7_pro_inf0_sentry0_alerted));
        }

        [ScriptMethod(433, Lifecycle.Dormant)]
        public async Task e7_mars_inf0_main()
        {
            Engine.ai_place(e7_mars_inf0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_on_ledge, Engine.players()), 3);
            this.g_e7_pro_sentry_alerted = true;
            this.g_e7_mars_johnson_go = true;
        }

        [ScriptMethod(434, Lifecycle.Dormant)]
        public async Task e7_pro_inf0_main()
        {
            Engine.ai_place(e7_pro_inf0.Squad);
            Engine.ai_prefer_target(Engine.ai_actors(e7_cov), true);
        }

        [ScriptMethod(435, Lifecycle.Dormant)]
        public async Task e7_cov_hunters0_main()
        {
            await Engine.sleep(1);
        }

        [ScriptMethod(436, Lifecycle.Dormant)]
        public async Task e7_cov_inf0_main()
        {
            Engine.ai_migrate(e6_cov_hunters0.Squad, e7_cov_hunters0.Squad);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_living_count(e6_cov) <= 0)
                {
                    return 1F == 1F;
                }
                else
                {
                    if ((short)Engine.ai_living_count(e7_cov_inf0.Squad) < 2)
                    {
                        Engine.print("migrated an actor");
                        Engine.ai_migrate(Engine.object_get_ai(Engine.list_get(Engine.ai_actors(e6_cov), 0)), e7_cov_inf0.Squad);
                    }

                    return 1F == 0F;
                }
            });
        }

        [ScriptMethod(437, Lifecycle.Startup)]
        public async Task e7_scarab_main()
        {
            Engine.pvs_set_object(scarab.Entity);
            Engine.device_set_position_track(scarab.Entity, "delta_ledge_idle", 0F);
            Engine.device_animate_position(scarab.Entity, 1F, 2F, 0F, 0F, true);
            Engine.pvs_clear();
            await Engine.sleep_until(async () => this.g_e7_mars_johnson_aboard, 2);
            Engine.pvs_set_object(scarab.Entity);
            Engine.device_set_position_track(scarab.Entity, "delta_ledge_rear_back", 0F);
            Engine.device_animate_position(scarab.Entity, 1F, 70F / 30F, 0F, 0F, true);
            await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
            await Engine.sleep_until(async () =>
            {
                Engine.device_set_position_track(scarab.Entity, "delta_ledge_rear_idle", 0F);
                Engine.device_animate_position(scarab.Entity, 1F, 120F / 30F, 0F, 0F, true);
                await Engine.sleep_until(async () => Engine.device_get_position(scarab.Entity) >= 1F, 1);
                return (short)Engine.structure_bsp_index() == 0 && !(Engine.volume_test_objects(tv_e7_brute_area, Engine.ai_actors(e7_pro_inf0.Squad))) && (bool)Engine.game_safe_to_save();
            }, 5);
            await this.cinematic_fade_to_white();
            Engine.ai_erase(e7_mars);
            Engine.object_destroy(scarab.Entity);
            Engine.object_teleport(await this.player0(), player0_e8_stash);
            Engine.object_teleport(await this.player1(), player1_e8_stash);
            Engine.object_cannot_take_damage(Engine.players());
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            await this.cinematic_johnson_ledge();
            Engine.sound_suppress_ambience_update_on_revert();
            Engine.sound_class_set_gain("amb", 0F, 0);
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 1F, 15);
            Engine.object_teleport(await this.player0(), player0_e8_start);
            Engine.object_teleport(await this.player1(), player1_e8_start);
            Engine.object_can_take_damage(Engine.players());
            Engine.object_hide(await this.player0(), false);
            Engine.object_hide(await this.player1(), false);
            Engine.object_create(scarab);
            Engine.pvs_set_object(scarab.Entity);
            Engine.device_set_position_track(scarab.Entity, "delta_ledge_idle", 0F);
            Engine.wake(new ScriptMethodReference(e8_main));
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_title1));
        }

        [ScriptMethod(438, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0 && Engine.volume_test_objects(tv_e7_main_begin, Engine.players()), 15);
            this.g_e7_started = true;
            Engine.game_save();
            Engine.print("e7_main");
            Engine.data_mine_set_mission_segment("e7_scarab_ledge");
            Engine.weather_stop(0F);
            Engine.device_operates_automatically_set(e7_door0.Entity, true);
            Engine.wake(new ScriptMethodReference(music_08b_05_stop));
            Engine.wake(new ScriptMethodReference(e7_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e7_cov_hunters0_main));
            Engine.wake(new ScriptMethodReference(e7_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e7_mars_inf0_main));
            await Engine.sleep_until(async () => this.g_e8_started);
            Engine.ai_disposable(e7_cov, true);
            Engine.ai_disposable(e7_pro, true);
            await Engine.sleep_until(async () => this.g_e9_started);
            Engine.sleep_forever(new ScriptMethodReference(e7_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_cov_hunters0_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e7_mars_inf0_main));
        }

        [ScriptMethod(439, Lifecycle.Static)]
        public async Task test_scarab_boarding()
        {
            Engine.object_teleport(await this.player0(), e7_test);
            Engine.ai_place(e7_cov_inf0.Squad);
            Engine.ai_place(e7_cov_hunters0.Squad);
            if (!(this.g_e7_started))
            {
                Engine.wake(new ScriptMethodReference(e7_main));
            }
        }

        [ScriptMethod(440, Lifecycle.Static)]
        public async Task<bool> e6_room_cleared()
        {
            return (short)Engine.ai_living_count(e6_pro) <= 0 && Engine.object_get_health(e6_jail_shield1.Entity) < 0F && Engine.object_get_health(e6_jail_shield2.Entity) < 0F && Engine.object_get_health(e6_jail_shield4.Entity) < 0F;
        }

        [ScriptMethod(441, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (Engine.object_get_health(e6_jail_shield0.Entity) >= 0F)
            {
                Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield0"));
                await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(e6_jail_shield0.Entity) < 0F, 15);
                if (Engine.object_get_health(e6_jail_shield0.Entity) >= 0F)
                {
                    Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield0"));
                }

                await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield0.Entity) < 0F, 15, 150);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield0"));
            }
        }

        [ScriptMethod(442, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door1()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (Engine.object_get_health(e6_jail_shield1.Entity) >= 0F)
            {
                Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield1"));
                await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 15);
                if (Engine.object_get_health(e6_jail_shield1.Entity) >= 0F)
                {
                    Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield1"));
                }

                await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 15, 150);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield1"));
            }
        }

        [ScriptMethod(443, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door2()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (Engine.object_get_health(e6_jail_shield2.Entity) >= 0F)
            {
                Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield2"));
                await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 15);
                if (Engine.object_get_health(e6_jail_shield2.Entity) >= 0F)
                {
                    Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield2"));
                }

                await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 15, 150);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield2"));
            }
        }

        [ScriptMethod(444, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door3()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (Engine.object_get_health(e6_jail_shield3.Entity) >= 0F)
            {
                Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield3"));
                await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(e6_jail_shield3.Entity) < 0F, 15);
                if (Engine.object_get_health(e6_jail_shield3.Entity) >= 0F)
                {
                    Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield3"));
                }

                await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield3.Entity) < 0F, 15, 150);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield3"));
            }
        }

        [ScriptMethod(445, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door4()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (Engine.object_get_health(e6_jail_shield4.Entity) >= 0F)
            {
                Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield4"));
                await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(e6_jail_shield4.Entity) < 0F, 15);
                if (Engine.object_get_health(e6_jail_shield4.Entity) >= 0F)
                {
                    Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield4"));
                }

                await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield4.Entity) < 0F, 15, 150);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield4"));
            }
        }

        [ScriptMethod(446, Lifecycle.CommandScript)]
        public async Task cs_e6_destroy_door5()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (Engine.object_get_health(e6_jail_shield5.Entity) >= 0F)
            {
                Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/near_shield5"));
                await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) || Engine.object_get_health(e6_jail_shield5.Entity) < 0F, 15);
                if (Engine.object_get_health(e6_jail_shield5.Entity) >= 0F)
                {
                    Engine.cs_shoot_point(true, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield5"));
                }

                await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield5.Entity) < 0F, 15, 150);
                Engine.cs_shoot_point(false, Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/shield5"));
            }
        }

        [ScriptMethod(447, Lifecycle.CommandScript)]
        public async Task cs_e6_release_captives()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_certain);
            if (Engine.object_get_health(e6_jail_shield4.Entity) >= 0F && !(Engine.cs_command_script_queued(this.ai_current_squad, new ScriptMethodReference(cs_e6_destroy_door4))))
            {
                Engine.cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_destroy_door4));
                await Engine.sleep(30);
            }

            if (Engine.object_get_health(e6_jail_shield1.Entity) >= 0F && !(Engine.cs_command_script_queued(this.ai_current_squad, new ScriptMethodReference(cs_e6_destroy_door1))))
            {
                Engine.cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_destroy_door1));
                await Engine.sleep(30);
            }

            if (Engine.object_get_health(e6_jail_shield2.Entity) >= 0F && !(Engine.cs_command_script_queued(this.ai_current_squad, new ScriptMethodReference(cs_e6_destroy_door2))))
            {
                Engine.cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_destroy_door2));
                await Engine.sleep(30);
            }
        }

        [ScriptMethod(448, Lifecycle.CommandScript)]
        public async Task cs_e6_jailbreak_behavior()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_enable_dialogue(true);
            await Engine.sleep_until(async () =>
            {
                if (!(Engine.unit_has_weapon(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3854369863U))) && (short)Engine.ai_combat_status(this.ai_current_actor) < this.ai_combat_status_certain)
                {
                    Engine.cs_stack_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_release_captives));
                }

                return await this.e6_room_cleared() || Engine.unit_has_weapon(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3854369863U));
            }, 60);
        }

        [ScriptMethod(449, Lifecycle.CommandScript)]
        public async Task cs_e6_cov_inf1_1_init()
        {
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e6_pro) >= this.ai_combat_status_active || Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 15);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/elite1_approach"));
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:cheer", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:shakefist", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:warn", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield1.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:wave", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                });
                return Engine.object_get_health(e6_jail_shield1.Entity) < 0F || (short)Engine.ai_living_count(e6_pro) <= 0;
            }, 15);
            await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield1.Entity) < 0F, 15);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_jailbreak_behavior));
        }

        [ScriptMethod(450, Lifecycle.CommandScript)]
        public async Task cs_e6_cov_inf1_2_init()
        {
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e6_pro) >= this.ai_combat_status_active || Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 15);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("cs_e6_hunter_room/elite2_approach"));
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:cheer", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:shakefist", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:warn", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                }, 
                    async () =>
                {
                    if (Engine.object_get_health(e6_jail_shield2.Entity) >= 0F)
                    {
                        Engine.custom_animation(Engine.ai_get_unit(this.ai_current_actor), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3859088527U), "combat:pistol:wave", true);
                        await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.ai_get_unit(this.ai_current_actor)));
                        await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 10, (int)Engine.random_range(90, 150));
                    }
                });
                return Engine.object_get_health(e6_jail_shield2.Entity) < 0F || (short)Engine.ai_living_count(e6_pro) <= 0;
            }, 15);
            await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield2.Entity) < 0F, 15);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_jailbreak_behavior));
        }

        [ScriptMethod(451, Lifecycle.CommandScript)]
        public async Task cs_e6_cov_hunters0_0_init()
        {
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("generic_player_sighted", this.ai_current_squad) || Engine.object_get_health(e6_jail_shield4.Entity) < 0F, 15);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => Engine.object_get_health(e6_jail_shield4.Entity) < 0F, 15);
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.cs_force_combat_status(4);
            Engine.cs_look_player(false);
            Engine.cs_queue_command_script(this.ai_current_actor, new ScriptMethodReference(cs_e6_jailbreak_behavior));
        }

        [ScriptMethod(452, Lifecycle.CommandScript)]
        public async Task cs_e6_jailbreak_scene()
        {
            Engine.ai_play_line(this.ai_current_actor, "0610") // Couldn't generate cast from 'Short' to 'Void'
            ;
        }

        [ScriptMethod(453, Lifecycle.Dormant)]
        public async Task e6_pro_inf0_main()
        {
            Engine.ai_place(e6_pro_inf0_0.Squad);
            Engine.ai_place(e6_pro_inf0_1.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(e6_pro_inf0) > this.ai_combat_status_clear_los || (short)Engine.ai_living_count(e6_pro_inf0_0.Squad) <= 2, 15);
            Engine.wake(new ScriptMethodReference(music_08b_05_start_alt));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e6_pro_inf0_0.Squad) <= 2);
            Engine.ai_place(e6_pro_inf0_2.Squad);
            await Engine.sleep(15);
            Engine.device_operates_automatically_set(e6_door0.Entity, true);
        }

        [ScriptMethod(454, Lifecycle.Dormant)]
        public async Task e6_cov_hunters0_main()
        {
            Engine.ai_migrate(e5_cov_hunters0.Squad, e6_cov_hunters0.Squad);
            if ((short)Engine.ai_living_count(e6_cov_hunters0.Squad) >= 2)
            {
                Engine.sleep_forever();
            }

            Engine.ai_place(e6_cov_hunters0.Squad);
            Engine.ai_set_orders(e6_cov_hunters0.Squad, e6_cov_hunters0_engage1);
        }

        [ScriptMethod(455, Lifecycle.Dormant)]
        public async Task e6_cov_inf1_main()
        {
            Engine.ai_place(e6_cov_inf1_1.Squad);
            Engine.ai_place(e6_cov_inf1_2.Squad);
        }

        [ScriptMethod(456, Lifecycle.Dormant)]
        public async Task e6_cov_inf0_main()
        {
            Engine.ai_migrate(e5_cov_inf0.Squad, e6_cov_inf0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_main_room, Engine.ai_actors(e6_cov_inf0.Squad)));
            await Engine.sleep_until(async () => Engine.ai_scene("e6_jailbreak_scene", new ScriptMethodReference(cs_e6_jailbreak_scene), e6_cov_inf0.Squad), 30, 300);
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e6_pro_inf0_2.Squad) > 0 && (short)Engine.ai_living_count(e6_pro_inf0_2.Squad) <= 0);
            Engine.cs_run_command_script(e6_cov_inf0.Squad, new ScriptMethodReference(cs_e6_jailbreak_behavior));
            await Engine.sleep_until(async () => await this.e6_room_cleared());
            Engine.game_save();
            Engine.ai_migrate(e6_cov_inf1, e6_cov_inf0.Squad);
            Engine.ai_set_orders(e6_cov_inf0.Squad, e6_cov_inf0_continue);
        }

        [ScriptMethod(457, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_main_begin, Engine.players()), 15);
            this.g_e6_started = true;
            Engine.game_save();
            Engine.print("e6_main");
            Engine.data_mine_set_mission_segment("e6_jail");
            Engine.wake(new ScriptMethodReference(music_08b_05_start));
            Engine.wake(new ScriptMethodReference(e7_main));
            Engine.wake(new ScriptMethodReference(e6_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e6_cov_inf1_main));
            Engine.wake(new ScriptMethodReference(e6_cov_hunters0_main));
            Engine.wake(new ScriptMethodReference(e6_pro_inf0_main));
            await Engine.sleep_until(async () => this.g_e7_started);
            Engine.sleep_forever(new ScriptMethodReference(e6_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e6_cov_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e6_cov_hunters0_main));
            Engine.sleep_forever(new ScriptMethodReference(e6_pro_inf0_main));
            Engine.ai_disposable(e6_pro, true);
        }

        [ScriptMethod(458, Lifecycle.Static)]
        public async Task test_hunter_room()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e6_test);
            Engine.ai_place(e6_cov_inf0.Squad);
            if (!(this.g_e6_started))
            {
                Engine.wake(new ScriptMethodReference(e6_main));
            }
        }

        [ScriptMethod(459, Lifecycle.CommandScript)]
        public async Task cs_e5_pro_phantom0_entry()
        {
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e5_pro_phantom0/p0"), Engine.GetReference<ISpatialPoint>("e5_pro_phantom0/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e5_pro_phantom0/p1"));
        }

        [ScriptMethod(460, Lifecycle.CommandScript)]
        public async Task cs_e5_pro_phantom0_exit()
        {
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e5_pro_phantom0/p2"), Engine.GetReference<ISpatialPoint>("e5_pro_phantom0/p2_facing"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e5_pro_phantom0/p3"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e5_pro_phantom0/p4"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(461, Lifecycle.Dormant)]
        public async Task e5_pro_phantom0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_pro_phantom0_begin, Engine.players()), 15);
            Engine.ai_place(e5_pro_phantom0.Squad);
            await Engine.sleep_until(async () => Engine.object_get_health(Engine.ai_vehicle_get(e5_pro_phantom0.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e5_pro_phantom0.phantom0), "target_front") >= 3 || Engine.volume_test_objects(tv_e7_main_begin, Engine.players()), 30, this.one_minute);
            Engine.cs_run_command_script(e5_pro_phantom0.phantom0, new ScriptMethodReference(cs_e5_pro_phantom0_exit));
        }

        [ScriptMethod(462, Lifecycle.Dormant)]
        public async Task e5_pro_inf3_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_pro_inf3_init, Engine.players()), 15);
            Engine.ai_place(e5_pro_inf3.Squad);
        }

        [ScriptMethod(463, Lifecycle.Dormant)]
        public async Task e5_pro_inf2_main()
        {
            await Engine.sleep_until(async () =>
            {
                if ((float)Engine.ai_living_count(e5_pro_inf0.Squad) + (float)Engine.ai_living_count(e5_pro_inf1.Squad) + (float)Engine.ai_living_count(e5_pro_inf2.Squad) < this.g_e5_pro_inf2_limit)
                {
                    Engine.ai_place(e5_pro_inf2.Squad, 1);
                }

                return Engine.volume_test_objects(tv_e5_bridge_exit, Engine.players()) || (short)Engine.ai_spawn_count(e5_pro_inf2.Squad) >= this.g_e5_pro_inf2_limit;
            }, 30);
        }

        [ScriptMethod(464, Lifecycle.Dormant)]
        public async Task e5_pro_inf1_main()
        {
            Engine.ai_place(e5_pro_inf1.Squad);
        }

        [ScriptMethod(465, Lifecycle.Dormant)]
        public async Task e5_pro_inf0_main()
        {
            Engine.ai_place(e5_pro_inf0.Squad);
        }

        [ScriptMethod(466, Lifecycle.Dormant)]
        public async Task e5_cov_hunters0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_pro_inf0.Squad) <= 0 && (short)Engine.ai_living_count(e4_pro_inf1.Squad) <= 0 && (short)Engine.ai_living_count(e4_pro_inf3.Squad) <= 0);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1, 15);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0, 15);
            Engine.ai_migrate(e4_cov_hunters0.Squad, e5_cov_hunters0.Squad);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e5_cov_hunters0.Squad);
        }

        [ScriptMethod(467, Lifecycle.Dormant)]
        public async Task e5_cov_inf0_main()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e4_pro_inf0.Squad) <= 0 && (short)Engine.ai_living_count(e4_pro_inf1.Squad) <= 0 && (short)Engine.ai_living_count(e4_pro_inf3.Squad) <= 0);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1, 15);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0, 15);
            Engine.ai_migrate(e4_cov_inf0.Squad, e5_cov_inf0.Squad);
            Engine.ai_teleport_to_starting_location_if_outside_bsp(e5_cov_inf0.Squad);
        }

        [ScriptMethod(468, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_main_begin, Engine.players()) && (short)Engine.structure_bsp_index() == 0, 15);
            this.g_e5_started = true;
            Engine.game_save();
            Engine.print("e5_main");
            Engine.data_mine_set_mission_segment("e5_bridge");
            Engine.weather_change_intensity(0F, 0.5F);
            Engine.wake(new ScriptMethodReference(e6_main));
            Engine.wake(new ScriptMethodReference(e5_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e5_cov_hunters0_main));
            Engine.wake(new ScriptMethodReference(e5_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e5_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e5_pro_inf2_main));
            Engine.wake(new ScriptMethodReference(e5_pro_phantom0_main));
            await Engine.sleep_until(async () => this.g_e6_started);
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_cov_hunters0_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_pro_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e5_pro_phantom0_main));
            Engine.ai_disposable(e5_pro, true);
            Engine.ai_disposable(e5_pro_phantom0.Squad, false);
        }

        [ScriptMethod(469, Lifecycle.Static)]
        public async Task test_bridge()
        {
            Engine.object_teleport(await this.player0(), e5_test);
            Engine.ai_place(e5_cov_inf0.Squad);
            Engine.ai_place(e5_cov_hunters0.Squad);
            if (!(this.g_e5_started))
            {
                Engine.wake(new ScriptMethodReference(e5_main));
            }
        }

        [ScriptMethod(470, Lifecycle.Dormant)]
        public async Task e4_music()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_halfway, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_08b_04_start));
            await Engine.sleep(2);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_main_shutdown, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_08b_03_stop));
            Engine.wake(new ScriptMethodReference(music_08b_04_stop));
        }

        [ScriptMethod(471, Lifecycle.Dormant)]
        public async Task e4_pro_inf3_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_corner, Engine.players()) || (short)Engine.ai_living_count(e4_pro_inf0.Squad) <= 0 || (short)Engine.ai_living_count(e4_pro_inf1.Squad) <= 0, 15);
            Engine.ai_place(e4_pro_inf3.Squad, (short)(6 - (float)Engine.ai_living_count(e4_pro_inf0.Squad)));
        }

        [ScriptMethod(472, Lifecycle.Dormant)]
        public async Task e4_pro_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_corner, Engine.players()) || (short)Engine.ai_living_count(e4_pro_inf0.Squad) <= 0 || (short)Engine.ai_living_count(e4_pro_inf1.Squad) <= 0, 15);
            Engine.ai_place(e4_pro_inf2.Squad);
        }

        [ScriptMethod(473, Lifecycle.Dormant)]
        public async Task e4_pro_inf1_main()
        {
            Engine.ai_place(e4_pro_inf1.Squad);
        }

        [ScriptMethod(474, Lifecycle.Dormant)]
        public async Task e4_pro_inf0_main()
        {
            Engine.ai_place(e4_pro_inf0.Squad);
        }

        [ScriptMethod(475, Lifecycle.Dormant)]
        public async Task e4_cov_hunters0_main()
        {
            Engine.ai_migrate(e3_cov_hunters0.Squad, e4_cov_hunters0.Squad);
        }

        [ScriptMethod(476, Lifecycle.Dormant)]
        public async Task e4_cov_inf0_main()
        {
            Engine.ai_migrate(e3_cov_inf0.Squad, e4_cov_inf0.Squad);
        }

        [ScriptMethod(477, Lifecycle.Dormant)]
        public async Task e4_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_main_begin, Engine.players()), 15);
            this.g_e4_started = true;
            Engine.game_save();
            Engine.print("e4_main");
            Engine.data_mine_set_mission_segment("e4_generator_room");
            Engine.wake(new ScriptMethodReference(music_08b_03_start));
            Engine.wake(new ScriptMethodReference(e5_main));
            Engine.wake(new ScriptMethodReference(e4_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e4_cov_hunters0_main));
            Engine.wake(new ScriptMethodReference(e4_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e4_pro_inf1_main));
            Engine.wake(new ScriptMethodReference(e4_pro_inf3_main));
            Engine.wake(new ScriptMethodReference(e4_music));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e4_main_shutdown, Engine.players()), 15);
            Engine.sleep_forever(new ScriptMethodReference(e4_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_cov_hunters0_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_pro_inf2_main));
            Engine.sleep_forever(new ScriptMethodReference(e4_pro_inf3_main));
            await Engine.sleep_until(async () => this.g_e5_started);
            Engine.ai_disposable(e4_pro, true);
        }

        [ScriptMethod(478, Lifecycle.Static)]
        public async Task test_generator_cave()
        {
            Engine.switch_bsp(1);
            await Engine.sleep(1);
            Engine.object_teleport(await this.player0(), e4_test);
            Engine.ai_place(e4_cov_inf0.Squad);
            Engine.ai_place(e4_cov_hunters0.Squad);
            if (!(this.g_e4_started))
            {
                Engine.wake(new ScriptMethodReference(e4_main));
            }
        }

        [ScriptMethod(479, Lifecycle.Static)]
        public async Task<bool> e3_cov_hunters0_break()
        {
            return (short)Engine.ai_spawn_count(e3_pro_inf0) > 0 && (short)Engine.ai_living_count(e3_pro_inf0_0.Squad) <= 1 || Engine.volume_test_objects(tv_e3_player_advance2, Engine.players());
        }

        [ScriptMethod(480, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_hunters0_0()
        {
            Engine.cs_crouch(true);
            Engine.cs_look_player(true);
            Engine.unit_impervious(Engine.ai_get_unit(this.ai_current_actor), true);
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep_until(async () => this.g_e3_hunters_rise || Engine.volume_test_objects(tv_e3_player_advance0, Engine.players()), 5);
            await Engine.sleep(20);
            Engine.cs_crouch(false);
            await Engine.sleep_until(async () => this.g_e3_hunter0_go || Engine.volume_test_objects(tv_e3_player_advance0, Engine.players()), 5);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_look_player(false);
            Engine.cs_enable_looking(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp0/p0"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) && (short)Engine.structure_bsp_index() == 1, 5);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp1/p0"));
            Engine.cs_crouch(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp1/p1_0"));
            await Engine.sleep_until(async () => await this.e3_cov_hunters0_break(), 15, this._30_seconds);
            this.g_e3_hunter0_arrived = true;
            Engine.ai_renew(this.ai_current_actor);
            Engine.unit_impervious(Engine.ai_get_unit(this.ai_current_actor), false);
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(481, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_hunters0_1()
        {
            Engine.cs_crouch(true);
            Engine.cs_look_player(true);
            Engine.unit_impervious(Engine.ai_get_unit(this.ai_current_actor), true);
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep_until(async () => this.g_e3_hunters_rise || Engine.volume_test_objects(tv_e3_player_advance0, Engine.players()), 5);
            await Engine.sleep(30);
            Engine.cs_crouch(false);
            await Engine.sleep_until(async () => this.g_e3_hunter1_go || Engine.volume_test_objects(tv_e3_player_advance0, Engine.players()), 5);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_look_player(false);
            Engine.cs_enable_looking(true);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp0/p1"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) && (short)Engine.structure_bsp_index() == 1, 5);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp1/p0"));
            Engine.cs_crouch(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp1/p1_1"));
            await Engine.sleep_until(async () => await this.e3_cov_hunters0_break(), 15, this._30_seconds);
            this.g_e3_hunter1_arrived = true;
            Engine.ai_renew(this.ai_current_actor);
            Engine.unit_impervious(Engine.ai_get_unit(this.ai_current_actor), false);
            Engine.object_cannot_die(Engine.ai_get_object(this.ai_current_actor), false);
        }

        [ScriptMethod(482, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_0()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_crouch(true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => Engine.device_get_position(e2_exit_door.Entity) > 0.1F, 5);
            Engine.cs_crouch(false);
            this.g_e3_hunters_rise = true;
            Engine.print("elite: hold your fire!");
            await Engine.sleep(Engine.ai_play_line_at_player(this.ai_current_actor, "0560"));
            Engine.cs_jump_to_point(1F, 2.25F);
            await Engine.sleep(25);
            Engine.print("elite: the hunters rawk");
            Engine.ai_play_line_at_player(this.ai_current_actor, "0570") // Couldn't generate cast from 'Short' to 'Void'
            ;
            await Engine.sleep(20);
            Engine.cs_look_object(true, Engine.ai_get_object(e3_cov_hunters0.hunter0));
            await Engine.sleep(40);
            this.g_e3_hunter0_go = true;
            Engine.cs_look_object(true, Engine.ai_get_object(e3_cov_hunters0.hunter1));
            await Engine.sleep(30);
            this.g_e3_hunter1_go = true;
            Engine.cs_look_object(false, Engine.ai_get_object(e3_cov_hunters0.hunter1));
            Engine.cs_enable_looking(true);
            Engine.cs_move_in_direction(-20F, 0.5F, 0F);
            Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp0/p2"));
            await Engine.sleep_until(async () => !((bool)Engine.cs_moving()) && (short)Engine.structure_bsp_index() == 1, 5);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp1/p0"));
            await Engine.sleep_until(async () => this.g_e3_hunter0_arrived && this.g_e3_hunter1_arrived);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp1/p2"));
        }

        [ScriptMethod(483, Lifecycle.CommandScript)]
        public async Task cs_e3_cov_inf0_init()
        {
            Engine.cs_crouch(true);
            Engine.cs_look_player(true);
            await Engine.sleep_until(async () => Engine.device_get_position(e2_exit_door.Entity) > 0F, 5);
            await Engine.sleep(30);
            Engine.cs_crouch(false);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_player_advance0, Engine.players()), 15, 200);
        }

        [ScriptMethod(484, Lifecycle.CommandScript)]
        public async Task cs_e3_pro_inf2_idle()
        {
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(this.ai_current_actor) >= this.ai_combat_status_active, 3);
            Engine.cs_crouch(false);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e3_intro_bsp1/p3"));
        }

        [ScriptMethod(485, Lifecycle.CommandScript)]
        public async Task cs_e3_weapon_scene()
        {
            Engine.cs_play_line("0580");
        }

        [ScriptMethod(486, Lifecycle.Dormant)]
        public async Task e3_weapon_scene()
        {
            await Engine.sleep_until(async () => Engine.ai_scene("e3_weapons_scene", new ScriptMethodReference(cs_e3_weapon_scene), e3_cov));
        }

        [ScriptMethod(487, Lifecycle.Dormant)]
        public async Task e3_objective_failsafe()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(e2_exit_door.Entity) > 0F, 5, 30);
            Engine.wake(new ScriptMethodReference(objective1_set));
        }

        [ScriptMethod(488, Lifecycle.Dormant)]
        public async Task e3_pro_inf2_main()
        {
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1, 5);
            Engine.ai_place(e3_pro_inf2.Squad);
        }

        [ScriptMethod(489, Lifecycle.Dormant)]
        public async Task e3_pro_inf1_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_pro_inf1_begin, Engine.players()), 15);
            Engine.ai_place(e3_pro_inf1.Squad);
        }

        [ScriptMethod(490, Lifecycle.Dormant)]
        public async Task e3_pro_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_pro_inf0_begin, Engine.players()), 15);
            Engine.ai_place(e3_pro_inf0_0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_player_advance2, Engine.players()) || (short)Engine.ai_living_count(e3_pro_inf0) <= 2, 15);
            Engine.ai_place(e3_pro_inf0_1.Squad, (short)Engine.pin(7F - (float)Engine.ai_living_count(e3_pro_inf0), 2F, 4F));
        }

        [ScriptMethod(491, Lifecycle.Dormant)]
        public async Task e3_cov_hunters0_main()
        {
            Engine.ai_place(e3_cov_hunters0.Squad);
            Engine.cs_run_command_script(e3_cov_hunters0.hunter0, new ScriptMethodReference(cs_e3_cov_hunters0_0));
            Engine.cs_run_command_script(e3_cov_hunters0.hunter1, new ScriptMethodReference(cs_e3_cov_hunters0_1));
        }

        [ScriptMethod(492, Lifecycle.Dormant)]
        public async Task e3_cov_inf0_main()
        {
            Engine.ai_place(e3_cov_inf0.Squad);
            await Engine.sleep_until(async () => Engine.device_get_position(e2_exit_door.Entity) > 0F, 5, 30);
            Engine.wake(new ScriptMethodReference(music_08b_02_stop));
        }

        [ScriptMethod(493, Lifecycle.Dormant)]
        public async Task e3_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_main_begin, Engine.players()), 15);
            this.g_e3_started = true;
            Engine.game_save();
            Engine.print("e3_main");
            Engine.data_mine_set_mission_segment("e3_ramp_room");
            Engine.wake(new ScriptMethodReference(e4_main));
            Engine.wake(new ScriptMethodReference(e3_cov_inf0_main));
            Engine.wake(new ScriptMethodReference(e3_cov_hunters0_main));
            Engine.wake(new ScriptMethodReference(e3_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e3_objective_failsafe));
            await Engine.sleep_until(async () => this.g_e4_started);
            Engine.sleep_forever(new ScriptMethodReference(e3_cov_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_cov_hunters0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_pro_inf1_main));
            Engine.sleep_forever(new ScriptMethodReference(e3_pro_inf2_main));
            Engine.ai_disposable(e3_pro, true);
            await Engine.sleep_until(async () => this.g_e5_started);
            Engine.ai_erase(e3_cov);
            Engine.ai_erase(e3_pro);
        }

        [ScriptMethod(494, Lifecycle.Static)]
        public async Task test_ramp_room()
        {
            Engine.object_teleport(await this.player0(), e3_test);
            if (!(this.g_e3_started))
            {
                Engine.wake(new ScriptMethodReference(e3_main));
            }

            Engine.device_operates_automatically_set(e2_exit_door.Entity, true);
        }

        [ScriptMethod(495, Lifecycle.Dormant)]
        public async Task e2_dialogue()
        {
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), scarab.Entity, 15F) && (bool)Engine.game_safe_to_save(), 15, 300);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), scarab.Entity, 15F), 15, this._30_seconds);
            await Engine.sleep(Engine.ai_play_line_at_player(Engine.object_get_ai(this.g_cov_commander), "0520"));
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), e2_exit_door.Entity, 15F) && (bool)Engine.game_safe_to_save(), 15, 300);
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), e2_exit_door.Entity, 15F), 15, this._30_seconds);
            await Engine.sleep(Engine.ai_play_line_at_player(Engine.object_get_ai(this.g_cov_commander), "0530"));
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(objective0_clear));
            Engine.wake(new ScriptMethodReference(objective1_set));
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e2_pro_wraith0) > 0 && (short)Engine.ai_living_count(e2_pro_wraith0) <= 0 && Engine.volume_test_objects(tv_e2_near_perimeter, Engine.players()) && (bool)Engine.game_safe_to_save());
            await Engine.sleep(Engine.ai_play_line_at_player(Engine.object_get_ai(this.g_cov_commander), "0540"));
        }

        [ScriptMethod(496, Lifecycle.Dormant)]
        public async Task e2_door_unlocker()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_spawn_count(e2_pro_wraith0) > 0 && (short)Engine.ai_living_count(e2_pro_wraith0) <= 0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e3_main_begin, Engine.players()), 15);
            Engine.device_operates_automatically_set(e2_exit_door.Entity, true);
        }

        [ScriptMethod(497, Lifecycle.CommandScript)]
        public async Task cs_e2_pro_phantom0_0_entry()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p0"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1"), Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1_facing"));
        }

        [ScriptMethod(498, Lifecycle.CommandScript)]
        public async Task cs_e2_pro_phantom0_0_exit()
        {
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1"), Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1_facing"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p1"), Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p2"), 0.5F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p2"), Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p3"), 1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e2_pro_phantom0_0/p3"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(499, Lifecycle.Static)]
        public async Task e2_pro_ghosts0_enter()
        {
            Engine.ai_enter_squad_vehicles(this.ai_current_squad);
        }

        [ScriptMethod(500, Lifecycle.Dormant)]
        public async Task e2_pro_phantoms0_main()
        {
            Engine.ai_place(e2_pro_phantom0_0.Squad);
            await Engine.sleep_until(async () => Engine.object_get_health(Engine.ai_vehicle_get(e2_pro_phantom0_0.phantom0)) <= 0.05F || Engine.object_model_targets_destroyed(Engine.ai_vehicle_get(e2_pro_phantom0_0.phantom0), "target_front") >= 3, 30, this.one_minute);
            Engine.cs_run_command_script(e2_pro_phantom0_0.phantom0, new ScriptMethodReference(cs_e2_pro_phantom0_0_exit));
            Engine.wake(new ScriptMethodReference(music_08b_01_stop));
            Engine.wake(new ScriptMethodReference(music_08b_02_start));
        }

        [ScriptMethod(501, Lifecycle.Dormant)]
        public async Task e2_pro_wraiths0_main()
        {
            await Engine.sleep(150);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_pro_wraiths0_begin, Engine.players()) || (short)Engine.ai_living_count(e2_pro_phantom0) <= 0, 15);
            Engine.ai_place(e2_pro_wraith0);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_pro_wraith0) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(502, Lifecycle.Dormant)]
        public async Task e2_pro_ghosts0_main()
        {
            Engine.ai_place(e2_pro_ghosts0);
        }

        [ScriptMethod(503, Lifecycle.Dormant)]
        public async Task e2_pro_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_near_perimeter, Engine.players()), 15);
            Engine.ai_place(e2_pro_inf0.Squad);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e2_pro_inf0.Squad) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(504, Lifecycle.Dormant)]
        public async Task e2_cov_wraith0_main()
        {
            Engine.ai_migrate(e1_cov_wraiths0, e2_cov_wraith0.Squad);
        }

        [ScriptMethod(505, Lifecycle.Dormant)]
        public async Task e2_cov_spectre0_main()
        {
            Engine.ai_migrate(e1_cov_spectre0.Squad, e2_cov_spectre0.Squad);
        }

        [ScriptMethod(506, Lifecycle.Dormant)]
        public async Task e2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_main_begin, Engine.players()), 15);
            this.g_e2_started = true;
            Engine.game_save();
            Engine.print("e2_main");
            Engine.data_mine_set_mission_segment("e2_scarab_cove");
            Engine.wake(new ScriptMethodReference(e3_main));
            Engine.wake(new ScriptMethodReference(e2_cov_spectre0_main));
            Engine.wake(new ScriptMethodReference(e2_cov_wraith0_main));
            Engine.wake(new ScriptMethodReference(e2_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e2_pro_wraiths0_main));
            Engine.wake(new ScriptMethodReference(e2_pro_phantoms0_main));
            Engine.wake(new ScriptMethodReference(e2_dialogue));
            Engine.wake(new ScriptMethodReference(e2_door_unlocker));
            await Engine.sleep_until(async () => this.g_e3_started);
            Engine.ai_disposable(e2_pro, true);
            Engine.ai_disposable(e2_pro_phantom0, false);
            await Engine.sleep_until(async () => this.g_e4_started);
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_spectre0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_cov_wraith0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_inf0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_wraiths0_main));
            Engine.sleep_forever(new ScriptMethodReference(e2_pro_phantoms0_main));
            Engine.ai_disposable(e2_cov, true);
        }

        [ScriptMethod(507, Lifecycle.Static)]
        public async Task test_scarab_cove()
        {
            Engine.object_teleport(await this.player0(), e2_test);
            if (!(this.g_e2_started))
            {
                Engine.wake(new ScriptMethodReference(e2_main));
            }

            Engine.ai_place(e2_cov_wraith0.Squad);
            Engine.ai_place(e2_cov_spectre0.Squad);
        }

        [ScriptMethod(508, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_phantom0_exit()
        {
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p0"), Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"), 1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p2"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p3"), Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(509, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_phantom0_entry()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p0"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p1"), Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p1_facing"), 0.5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p2"), 0.5F);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get(this.ai_current_actor), "phantom_lc");
            Engine.ai_braindead(e1_pro_wraith0.Squad, false);
            await Engine.sleep(30);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_entry/p1"), 0.5F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p0"), Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"), 1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p2"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p3"), Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("e1_pro_phantom0_exit/p4"));
            Engine.ai_erase(this.ai_current_squad);
        }

        [ScriptMethod(510, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_spectre0_init()
        {
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_cov_spectre0_entry/p0"));
            Engine.ai_overcomes_oversteer(this.ai_current_actor, true);
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("e1_cov_spectre0_entry/p1"));
            await Engine.sleep_until(async () => await this.players_in_vehicle() && Engine.unit_in_vehicle(this.g_cov_commander) || Engine.volume_test_objects(tv_e1_canyon_entry, Engine.players()), 10);
            Engine.ai_overcomes_oversteer(this.ai_current_actor, false);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("e1_cov_spectre0_entry/p1"));
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(e1_cov_spectre0.spectre0));
        }

        [ScriptMethod(511, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_spectre0_passenger()
        {
            Engine.cs_look_player(true);
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => await this.players_in_vehicle() && Engine.unit_in_vehicle(this.g_cov_commander), 10);
            Engine.cs_look_player(false);
            Engine.cs_face_player(false);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(e1_cov_spectre0.spectre0));
        }

        [ScriptMethod(512, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_commander0_legendary()
        {
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => await this.players_in_vehicle() || Engine.volume_test_objects(tv_e1_canyon_entry, Engine.players()), 15);
            Engine.cs_look_player(false);
            Engine.cs_face_player(false);
        }

        [ScriptMethod(513, Lifecycle.CommandScript)]
        public async Task cs_e1_cov_commander0_init()
        {
            Engine.ai_vehicle_exit(this.ai_current_actor);
            await Engine.sleep_until(async () => !(Engine.unit_in_vehicle(Engine.ai_get_unit(this.ai_current_actor))), 5);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_cov_spectre0_entry/soc_p0"));
            Engine.cs_face_player(true);
            await Engine.sleep_until(async () => Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(e1_cov_wraiths0_0.wraith0), "wraith_d", Engine.players()) || await this.players_in_vehicle() || Engine.volume_test_objects(tv_e1_canyon_entry, Engine.players()), 15);
            Engine.cs_look_player(false);
            Engine.cs_face_player(false);
            if (Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(e1_cov_wraiths0_0.wraith0), "wraith_d", Engine.players()))
            {
                Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(e1_cov_spectre0.spectre0));
            }
            else
            {
                Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(e1_cov_wraiths0_0.wraith0));
            }
        }

        [ScriptMethod(514, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_2_entry0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p8"));
        }

        [ScriptMethod(515, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_2_entry1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p9"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p10"));
        }

        [ScriptMethod(516, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_1_entry0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p5"));
        }

        [ScriptMethod(517, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_1_entry1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p6"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p7"));
        }

        [ScriptMethod(518, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_0_entry0()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p0"));
        }

        [ScriptMethod(519, Lifecycle.CommandScript)]
        public async Task cs_e1_pro_ghosts0_0_entry1()
        {
            Engine.cs_abort_on_combat_status(this.ai_combat_status_clear_los);
            Engine.cs_vehicle_boost(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p2"));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_pro_ghosts0_entry/p3"));
        }

        [ScriptMethod(520, Lifecycle.Static)]
        public async Task<bool> e1_pro_ghosts0_weak()
        {
            return (float)Engine.ai_living_count(e1_pro_ghosts0) + (float)Engine.ai_living_count(e1_pro_wraith0.Squad) <= this.g_e1_ghosts_weak;
        }

        [ScriptMethod(521, Lifecycle.Static)]
        public async Task<bool> e1_pro_ghosts0_strong()
        {
            return (float)Engine.ai_living_count(e1_pro_ghosts0) + (float)Engine.ai_living_count(e1_pro_wraith0.Squad) >= this.g_e1_ghosts_strong;
        }

        [ScriptMethod(522, Lifecycle.Dormant)]
        public async Task e1_weather()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_advance0, Engine.players()), 16);
            Engine.weather_change_intensity(60F, 0.4F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_advance1, Engine.players()), 16);
            Engine.weather_change_intensity(60F, 0.7F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_advance2, Engine.players()), 16);
            Engine.weather_change_intensity(60F, 1F);
        }

        [ScriptMethod(523, Lifecycle.Dormant)]
        public async Task e1_pro_phantom0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_advance1, Engine.players()), 15);
            Engine.ai_place(e1_pro_wraith0.Squad);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_advance3, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_08b_01_start_alt));
        }

        [ScriptMethod(524, Lifecycle.Dormant)]
        public async Task e1_pro_ghosts0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_canyon_entry, Engine.players()), 15);
            Engine.ai_place(e1_pro_ghosts0_0.Squad);
            await Engine.sleep_until(async () =>
            {
                if (await this.e1_pro_ghosts0_weak())
                {
                    await Engine.sleep_until(async () =>
                    {
                        Engine.ai_place(e1_pro_ghosts0_0.Squad, 1);
                        return await this.e1_pro_ghosts0_strong() || (short)Engine.ai_spawn_count(e1_pro_ghosts0_0.Squad) >= this.g_e1_ghosts_per_leg || Engine.volume_test_objects(tv_e1_advance0, Engine.players());
                    });
                }

                return Engine.volume_test_objects(tv_e1_advance0, Engine.players());
            });
            Engine.game_save_no_timeout();
            await Engine.sleep_until(async () =>
            {
                if (await this.e1_pro_ghosts0_weak())
                {
                    await Engine.sleep_until(async () =>
                    {
                        Engine.ai_place(e1_pro_ghosts0_1.Squad, 1);
                        return await this.e1_pro_ghosts0_strong() || (short)Engine.ai_spawn_count(e1_pro_ghosts0_1.Squad) >= this.g_e1_ghosts_per_leg || Engine.volume_test_objects(tv_e1_advance2, Engine.players());
                    });
                }

                return Engine.volume_test_objects(tv_e1_advance2, Engine.players());
            });
            Engine.game_save_no_timeout();
            await Engine.sleep_until(async () =>
            {
                if (await this.e1_pro_ghosts0_weak())
                {
                    await Engine.sleep_until(async () =>
                    {
                        Engine.ai_place(e1_pro_ghosts0_2.Squad, 1);
                        return await this.e1_pro_ghosts0_strong() || (short)Engine.ai_spawn_count(e1_pro_ghosts0_2.Squad) >= this.g_e1_ghosts_per_leg || Engine.volume_test_objects(tv_e1_advance4, Engine.players());
                    });
                }

                return Engine.volume_test_objects(tv_e1_advance4, Engine.players());
            });
            Engine.game_save();
        }

        [ScriptMethod(525, Lifecycle.Dormant)]
        public async Task e1_pro_inf0_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_advance1, Engine.players()));
            Engine.ai_place(e1_pro_inf0_0.Squad);
        }

        [ScriptMethod(526, Lifecycle.Dormant)]
        public async Task e1_cov_spectre0_main()
        {
            Engine.ai_place(e1_cov_spectre0.Squad);
            await Engine.sleep(10);
            Engine.object_type_predict(Engine.GetTag<BaseTag>("objects\\vehicles\\spectre\\spectre", 3869771058U));
        }

        [ScriptMethod(527, Lifecycle.Dormant)]
        public async Task e1_cov_wraiths0_main()
        {
            Engine.ai_place(e1_cov_wraiths0_0.Squad);
            Engine.object_cannot_die(Engine.ai_get_object(e1_cov_wraiths0_0.wraith0), true);
            this.g_cov_commander = Engine.ai_get_unit(e1_cov_wraiths0_0.wraith0);
            if (await this.difficulty_legendary())
            {
                Engine.unit_set_enterable_by_player(Engine.ai_vehicle_get(e1_cov_wraiths0_0.wraith0), false);
                Engine.cs_run_command_script(e1_cov_wraiths0_0.wraith0, new ScriptMethodReference(cs_e1_cov_commander0_legendary));
            }
            else
            {
                Engine.cs_run_command_script(e1_cov_wraiths0_0.wraith0, new ScriptMethodReference(cs_e1_cov_commander0_init));
            }

            await Engine.sleep_until(async () => await this.players_in_vehicle() || Engine.volume_test_objects(tv_e1_canyon_entry, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_08b_01_start));
        }

        [ScriptMethod(528, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            this.g_e1_started = true;
            Engine.print("e1_main");
            Engine.data_mine_set_mission_segment("e1_wraith_canyon");
            Engine.wake(new ScriptMethodReference(objective0_set));
            Engine.wake(new ScriptMethodReference(e2_main));
            Engine.wake(new ScriptMethodReference(e1_cov_wraiths0_main));
            Engine.wake(new ScriptMethodReference(e1_cov_spectre0_main));
            Engine.wake(new ScriptMethodReference(e1_pro_ghosts0_main));
            Engine.wake(new ScriptMethodReference(e1_pro_phantom0_main));
            Engine.wake(new ScriptMethodReference(e1_pro_inf0_main));
            Engine.wake(new ScriptMethodReference(e1_weather));
            await Engine.sleep_until(async () => this.g_e2_started);
            Engine.ai_disposable(e1_pro, true);
            Engine.ai_disposable(e1_pro_phantom0.Squad, false);
            await Engine.sleep_until(async () => this.g_e3_started);
            Engine.sleep_forever(new ScriptMethodReference(e1_cov_wraiths0_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_pro_ghosts0_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_pro_phantom0_main));
            Engine.sleep_forever(new ScriptMethodReference(e1_pro_inf0_main));
        }

        [ScriptMethod(529, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            Engine.object_cannot_take_damage(Engine.players());
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            await this.cinematic_snap_to_white();
            await this.cinematic_intro();
            Engine.object_teleport(await this.player0(), player0_start);
            Engine.object_teleport(await this.player1(), player1_start);
            Engine.object_hide(await this.player0(), false);
            Engine.object_hide(await this.player1(), false);
            Engine.object_can_take_damage(Engine.players());
            Engine.wake(new ScriptMethodReference(e1_main));
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(15);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_title0));
            await Engine.sleep_until(async () => this.g_mission_over, 5);
            await this.playtest_mission();
            await Engine.sleep(15);
            Engine.object_cannot_take_damage(Engine.players());
            Engine.object_teleport(await this.player0(), player0_stash);
            Engine.object_teleport(await this.player1(), player1_stash);
            await this.cinematic_epilogue();
            Engine.game_won();
        }

        [ScriptMethod(530, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(531, Lifecycle.Startup)]
        public async Task mission_main()
        {
            Engine.ai_allegiance(player, covenant);
            Engine.ai_allegiance(player, human);
            Engine.ai_allegiance(covenant, human);
            Engine.weather_start(0F);
            Engine.weather_change_intensity(0F, 0.1F);
            Engine.kill_volume_disable(kill_e13_0);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(532, Lifecycle.Dormant)]
        public async Task _08_intra1_04_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3880125904U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3881633255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_saplingm\\redalder_saplingm", 3883664902U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 68);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 9);
            await Engine.sleep(6);
            await Engine.sleep(24);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            await Engine.sleep(129);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 17);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 70, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 79, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 69, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 67, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 35, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            await Engine.sleep(66);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple\\maple", 3880125904U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 3);
            await Engine.sleep(155);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3884058124U), 32);
            await Engine.sleep(72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 2);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 80, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 70, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 79, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 69, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 67, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 35, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
        }

        [ScriptMethod(533, Lifecycle.Dormant)]
        public async Task _08_intra2_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 44, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 38, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 89, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3881633255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 83, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 46, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3891398268U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 66);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 67);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 68);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 70);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 71);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\wraith", 3890021991U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 24, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_cam\\scarab_cam", 3893167767U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3893495452U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3894216359U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3894544044U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3895002803U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 40, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 16, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3900114689U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_small\\door_small", 3901359892U), 1);
            await Engine.sleep(115);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3901622040U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            await Engine.sleep(71);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 13, false);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_small\\door_small", 3901359892U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 26, true);
            await Engine.sleep(86);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 40, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 2);
        }

        [ScriptMethod(534, Lifecycle.Dormant)]
        public async Task _08_intra2_02_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            await Engine.sleep(69);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 7, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 42, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_maple\\maple_l\\maple_l", 3881633255U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            await Engine.sleep(151);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 68, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            await Engine.sleep(244);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
        }

        [ScriptMethod(535, Lifecycle.Dormant)]
        public async Task _08_intra3_01_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_walkway\\control_walkway", 3906340704U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3908437888U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_boss_platform\\control_boss_platform", 3909355406U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
            await Engine.sleep(355);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(83);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
        }

        [ScriptMethod(536, Lifecycle.Dormant)]
        public async Task _08_intra3_02_predict()
        {
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            await Engine.sleep(36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 2);
            await Engine.sleep(33);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            await Engine.sleep(72);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            await Engine.sleep(200);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(21);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            await Engine.sleep(72);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await Engine.sleep(174);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
        }

        [ScriptMethod(537, Lifecycle.Dormant)]
        public async Task _08_intra3_03_predict()
        {
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await Engine.sleep(157);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 2);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            await Engine.sleep(47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await Engine.sleep(54);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            await Engine.sleep(90);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            await Engine.sleep(60);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
        }

        [ScriptMethod(538, Lifecycle.Dormant)]
        public async Task _08_intra3_04_predict()
        {
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await Engine.sleep(186);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(185);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await Engine.sleep(250);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
        }

        [ScriptMethod(539, Lifecycle.Dormant)]
        public async Task _08_intra3_05_predict()
        {
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 28);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3902539558U), 43);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3913549774U), 0);
            await Engine.sleep(51);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3900245763U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3913549774U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\control_room_index_board\\control_room_index_board", 3908765573U), 0);
            await Engine.sleep(18);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 8, false);
            await Engine.sleep(107);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp3"), 5, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3788701789U), 3);
        }

        [ScriptMethod(540, Lifecycle.Dormant)]
        public async Task _08_intra3_06_predict()
        {
            Engine.print("next scene has no prediction...yet");
        }

        [ScriptMethod(541, Lifecycle.Dormant)]
        public async Task x09_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3891070583U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\fp_plasma_rifle\\fp_plasma_rifle", 3810787758U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3891398268U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\minigun\\minigun", 3890677361U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\wraith\\turrets\\mortar\\mortar", 3890742898U), 17);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_rotors\\control_rotors", 3913942996U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_room\\grav_lift\\grav_lift", 3914401755U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await Engine.sleep(64);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            await Engine.sleep(57);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            await Engine.sleep(75);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_room\\grav_lift\\grav_lift", 3914401755U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await Engine.sleep(35);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await Engine.sleep(33);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\control_room\\grav_lift\\grav_lift", 3914401755U), 0);
            await Engine.sleep(53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3908437888U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 6, true);
            await Engine.sleep(29);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
        }

        [ScriptMethod(542, Lifecycle.Dormant)]
        public async Task x09_02_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 8, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(58);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            await Engine.sleep(15);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 6, true);
            await Engine.sleep(129);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 62, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 77, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 22, false);
        }

        [ScriptMethod(543, Lifecycle.Dormant)]
        public async Task x09_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 88, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 44, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 43, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 89, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 52, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\door_large\\door_large", 3883140606U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\control_room_beam\\control_room_beam", 3915122662U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltacontrolroom\\deltacontrolroom_08b\\deltacontrolroom_08b", 3783000070U), 5);
            await Engine.sleep(166);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 41, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_l\\redcedar_l", 3881174496U), 1);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redcedar\\redcedar_m\\redcedar_m", 3880650200U), 1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 46, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_redalder\\redalder_s\\redalder_s", 3891398268U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 48, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 46, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 60, false);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 9, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 49, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 63, false);
        }

        [ScriptMethod(544, Lifecycle.Dormant)]
        public async Task x09_04_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 75, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3915188199U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3915515884U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_halo_quarter\\delta_halo_quarter", 3915712495U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\halo\\halo", 3915909106U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785097254U), 0);
            await Engine.sleep(131);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\halo_disarm\\halo_disarm", 3916564476U), 0);
        }

        [ScriptMethod(545, Lifecycle.Dormant)]
        public async Task x09_05_predict()
        {
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\index\\index_full\\index_full", 3908437888U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\beacon_halo_holo\\beacon_halo_holo", 3916630013U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            await Engine.sleep(113);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 69);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3895068340U), 60);
            await Engine.sleep(15);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            await Engine.sleep(31);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            await Engine.sleep(210);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
        }

        [ScriptMethod(546, Lifecycle.Dormant)]
        public async Task x09_06_predict()
        {
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(303);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            await Engine.sleep(77);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 6, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\beacon_halo_holo\\beacon_halo_holo", 3916630013U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 8, true);
            await Engine.sleep(126);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 14, true);
            await Engine.sleep(39);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltacontrolroom\\lightfixture_indirect_blurple\\lightfixture_indirect_blurple", 3913418700U), 0);
            await Engine.sleep(46);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3901687577U), 2);
            await Engine.sleep(140);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3904833353U), 1);
            await Engine.sleep(114);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp4"), 11, false);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 62, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 77, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 64, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 22, false);
        }

        [ScriptMethod(547, Lifecycle.Dormant)]
        public async Task x09_07_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\08b_deltacontrol\\deltacontrolroom_bsp0"), 75, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\moon\\moon", 3917809679U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\earth_space\\earth_space", 3918006290U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship\\forerunner_ship", 3918202901U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3919317030U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3785097254U), 0);
            await Engine.sleep(123);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3919317030U), 0);
            await Engine.sleep(36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\forerunner_ship_alcove", 3919448104U), 0);
        }

        [ScriptMethod(548, Lifecycle.Dormant)]
        public async Task x09_08_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3920758844U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 19);
            await Engine.sleep(5);
            await Engine.sleep(119);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3921610825U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\lord_hood\\lord_hood", 3921610825U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\cairo_bridge\\cairo_bridge", 3922397269U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3919317030U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\emergency\\emergency", 3926198415U), 0);
            await Engine.sleep(153);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3920955455U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3920758844U), 0);
            await Engine.sleep(678);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3881240033U), 0);
        }

        [ScriptMethod(549, Lifecycle.Dormant)]
        public async Task x10_01_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 25, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\flood\\flood_spore\\flood_spore", 3926329489U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3786145846U), 7);
            await Engine.sleep(19);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, true);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 16, true);
            await Engine.sleep(17);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 20, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab", 3891463805U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_scarab_full\\holo_scarab_full", 3893495452U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_main_gun\\scarab_main_gun", 3894216359U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_rear_gun\\scarab_rear_gun", 3894544044U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\scarab\\scarab_upper_gun\\scarab_upper_gun", 3895002803U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 19, true);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space_a\\crate_space_a", 3900114689U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3854500937U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3926526100U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_recharge_station\\recharge_station_cell\\recharge_station_cell", 3899787004U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3881698792U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3927050396U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3927115933U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, true);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\multi\\lockout\\power_module\\power_module", 3927443618U), 0);
            await Engine.sleep(18);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 26, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3888383566U), 1);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 27, true);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 28, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, false);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3927902377U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3927902377U), 1);
            await Engine.sleep(28);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 0, true);
            await Engine.sleep(15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\garbage\\cov_gravcolumn_top\\cov_gravcolumn_top", 3928688821U), 0);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\cov_gravcolumn", 3929606339U), 1);
            await Engine.sleep(18);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 32, true);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3930720468U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_clump\\flood_clump", 3931506912U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_sack\\flood_sack", 3931769060U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_pod\\flood_pod", 3931965671U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_floor_clump_small\\flood_floor_clump_small", 3932031208U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3932096745U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 15, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3933145337U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3933210874U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 31, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_generator\\flood_generator", 3933276411U), 0);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_gravcolumn\\garbage\\cov_gravcolumn_bottom_garbage_1\\cov_gravcolumn_bottom_garbage_1", 3933341948U), 0);
        }

        [ScriptMethod(550, Lifecycle.Dormant)]
        public async Task x10_02_predict()
        {
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 45, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\interior_objects\\cov_chubby\\cov_chubby", 3930720468U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_small_door\\high_small_door", 3933473022U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3933800707U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3933800707U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3933800707U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3901622040U), 0);
            await Engine.sleep(236);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 41, false);
            await Engine.sleep(130);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 22, false);
            await Engine.sleep(61);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 10, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 37, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_0"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door\\high_door", 3933210874U), 0);
        }
    }
}