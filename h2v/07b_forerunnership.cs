namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\07b_forerunnership\\07b_forerunnership")]
    public partial class scnr_07b_forerunnership : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool dialogue;
        int dialogue_pause;
        int g_dialogue_counter;
        int g_e12_talk;
        bool g_e12_go;
        bool g_e12_started;
        bool g_e12_final_battle_started;
        bool g_e12_final_battle_ended;
        bool g_e12_final_battle_mid;
        int dialogue_pause_long;
        bool g_e12_side;
        int g_e10_talk;
        bool g_e10_move_on;
        int g_e8_counter;
        bool g_e6_move_on;
        int g_e1_talk;
        bool g_e1_music;
        bool g_e1_pelican2_entering;
        bool g_e1_pelican1_entering;
        bool g_e1_pelican1_unloaded;
        bool g_e1_pro_inf3_spawned;
        bool g_e1_git_check;
        bool g_play_cinematics;
        public scnr_07b_forerunnership(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.dialogue = true;
            this.dialogue_pause = 7;
            this.g_dialogue_counter = 0;
            this.g_e12_talk = 0;
            this.g_e12_go = false;
            this.g_e12_started = false;
            this.g_e12_final_battle_started = false;
            this.g_e12_final_battle_ended = false;
            this.g_e12_final_battle_mid = false;
            this.dialogue_pause_long = 60;
            this.g_e12_side = false;
            this.g_e10_talk = 0;
            this.g_e10_move_on = false;
            this.g_e8_counter = 0;
            this.g_e6_move_on = false;
            this.g_e1_talk = 0;
            this.g_e1_music = false;
            this.g_e1_pelican2_entering = false;
            this.g_e1_pelican1_entering = false;
            this.g_e1_pelican1_unloaded = false;
            this.g_e1_pro_inf3_spawned = false;
            this.g_e1_git_check = false;
            this.g_play_cinematics = true;
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
        public async Task _07_intra1_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_05_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _07_intra1_06_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_06_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _07_intra1_07_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_07_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _07_intra1_08_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_intra1_08_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task _07_outro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_outro_01_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task _07_outro_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_outro_02_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task _07_outro_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_07_outro_03_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task cinematic_pelican_unload()
        {
            Engine.ai_place(cinematic_fld_inf0.form0);
            await Engine.sleep(8);
            Engine.ai_place(cinematic_fld_inf0.form1);
            await Engine.sleep(4);
            Engine.ai_place(cinematic_fld_inf0.form0);
            await Engine.sleep(10);
            Engine.ai_place(cinematic_fld_inf0.form1);
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task cinematic_pelican_runby()
        {
            Engine.ai_place(cinematic_fld_inf1.form0);
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task c07_intra1_score_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_05_mus", 3828679359U), default(IGameObject), 1F);
            Engine.print("c07_intra1 score 05");
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_05()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_05_fol", 3828744896U), default(IGameObject), 1F);
            Engine.print("c07_intra1 foley 05 start");
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c07_intra1_05_dof_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(127);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 0.75F, 0.75F, 0F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(60);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0F, 0.75F, 0.5F, 0.75F, 0F, 0.5F);
            Engine.print("rack focus");
            Engine.time_code_reset();
            await Engine.sleep(68);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c07_intra1_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(23F, 74F, 0.258824F, 0.270588F, 0.368627F);
            Engine.cinematic_lighting_set_secondary_light(-40F, 276F, 0.407843F, 0.345098F, 0.317647F);
            Engine.cinematic_lighting_set_ambient_light(0.0431373F, 0.0470588F, 0.0666667F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(infection_01.Entity, true);
            Engine.object_uses_cinematic_lighting(throne_mercy.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_01.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_02.Entity, true);
            Engine.object_uses_cinematic_lighting(phantom_03.Entity, true);
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task c07_intra1_05_setup()
        {
            Engine.wake(new ScriptMethodReference(c07_intra1_score_05));
            Engine.wake(new ScriptMethodReference(c07_intra1_foley_05));
            Engine.object_create_anew(chief);
            Engine.object_create_anew(mercy);
            Engine.object_create_anew(infection_01);
            Engine.object_create_anew(throne_mercy);
            Engine.object_create_anew(phantom_01);
            Engine.object_create_anew(phantom_02);
            Engine.object_create_anew(phantom_03);
            Engine.cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(mercy.Entity, true);
            Engine.object_cinematic_lod(infection_01.Entity, true);
            Engine.object_cinematic_lod(throne_mercy.Entity, true);
            Engine.object_cinematic_lod(phantom_01.Entity, true);
            Engine.object_cinematic_lod(phantom_02.Entity, true);
            Engine.object_cinematic_lod(phantom_03.Entity, true);
            Engine.wake(new ScriptMethodReference(c07_intra1_05_dof_01));
            Engine.wake(new ScriptMethodReference(c07_intra1_cinematic_light_01));
            Engine.object_destroy(ledge_1.Entity);
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task c07_intra1_05_cleanup()
        {
            Engine.object_destroy_containing("phantom");
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task c07_intra1_scene_05()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._07_intra1_05_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_05_mus", 3828679359U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_05_fol", 3828744896U));
            await Engine.sleep(this.prediction_offset);
            await this.c07_intra1_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3828810433U), "07_intra1_05", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3828875970U), "chief_05", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3828941507U), "mercy_05", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(infection_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3829072581U), "infection01_05", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(throne_mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\gravity_throne\\animations\\07_intra1\\07_intra1", 3829138118U), "throne_mercy_05", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3829203655U), "phantom1_05", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3829203655U), "phantom2_05", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(phantom_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3829203655U), "phantom3_05", false, anchor_intra1.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intra1_06_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_06_fol", 3829269192U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intra1_05_cleanup();
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_06()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_06_fol", 3829269192U), default(IGameObject), 1F);
            Engine.print("c07_intra1 foley 06 start");
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c07_2080_mas()
        {
            await Engine.sleep(45);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2080_mas", 3829334729U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c07_2080_mas", 2.5F);
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c07_2090_pom()
        {
            await Engine.sleep(180);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2090_pom", 3829400266U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("c07_2090_pom", 3F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c07_2100_pom()
        {
            await Engine.sleep(283);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2100_pom", 3829465803U), mercy.Entity, 1F);
            Engine.cinematic_subtitle("c07_2100_pom", 4F);
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c07_2101_pom()
        {
            await Engine.sleep(451);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2101_pom", 3829531340U), mercy.Entity, 1F);
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task c07_2110_cor()
        {
            await Engine.sleep(566);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2110_cor", 3829596877U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2110_cor", 2F);
            Engine.unit_set_emotional_state(cortana.Entity, "shocked", 0.25F, 0);
            Engine.print("cortana - shocked .25 0");
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task c07_2120_cor()
        {
            await Engine.sleep(621);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2120_cor", 3829662414U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2120_cor", 4F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c07_intra1_06_dof_01()
        {
            Engine.time_code_reset();
            await Engine.sleep(121);
            Engine.print("rack focus");
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(0.4F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.time_code_reset();
            await Engine.sleep(153);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task c07_intra1_06_fov_01()
        {
            await Engine.sleep(396);
            Engine.print("fov change: 60 -> 70 over 0 ticks");
            Engine.camera_set_field_of_view(70F, 0);
            await Engine.sleep(53);
            Engine.print("fov change: 70 -> 60 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task infection_pop()
        {
            await Engine.sleep(510);
            Engine.print("infection pop");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3829727951U), infection_02.Entity, "");
            await Engine.sleep(1);
            Engine.object_destroy(infection_02.Entity);
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task c07_intra1_06_setup()
        {
            Engine.object_create_anew(cortana);
            Engine.object_cinematic_lod(cortana.Entity, true);
            Engine.object_create_anew(infection_02);
            Engine.object_cinematic_lod(infection_02.Entity, true);
            Engine.object_uses_cinematic_lighting(infection_02.Entity, true);
            Engine.object_create_anew(cortana_base);
            Engine.wake(new ScriptMethodReference(c07_intra1_foley_06));
            Engine.wake(new ScriptMethodReference(c07_2080_mas));
            Engine.wake(new ScriptMethodReference(c07_2090_pom));
            Engine.wake(new ScriptMethodReference(c07_2100_pom));
            Engine.wake(new ScriptMethodReference(c07_2101_pom));
            Engine.wake(new ScriptMethodReference(c07_2110_cor));
            Engine.wake(new ScriptMethodReference(c07_2120_cor));
            Engine.wake(new ScriptMethodReference(infection_pop));
            Engine.wake(new ScriptMethodReference(c07_intra1_06_dof_01));
            Engine.wake(new ScriptMethodReference(c07_intra1_06_fov_01));
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c07_intra1_06_cleanup()
        {
            Engine.object_destroy_containing("infection");
            Engine.object_destroy(cortana_base.Entity);
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task c07_intra1_scene_06()
        {
            await this.c07_intra1_06_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3828810433U), "07_intra1_06", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3828875970U), "chief_06", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3828941507U), "mercy_06", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(infection_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3829072581U), "infection01_06", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(infection_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3829072581U), "infection02_06", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(throne_mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\gravity_throne\\animations\\07_intra1\\07_intra1", 3829138118U), "throne_mercy_06", false, anchor_intra1.Entity);
            await Engine.sleep(556);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_25", 3830448858U), cortana_base.Entity, "marker");
            Engine.custom_animation_relative(cortana.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_intra1\\07_intra1", 3831431913U), "cortana_06", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intra1_07_predict_stub();
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intra1_06_cleanup();
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c07_2130_cor()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2130_cor", 3831562987U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2130_cor", 3F);
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c07_2140_cor()
        {
            await Engine.sleep(110);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2140_cor", 3831628524U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2140_cor", 1F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task c07_2150_mas()
        {
            await Engine.sleep(150);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2150_mas", 3831694061U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c07_2150_mas", 5F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task c07_2160_cor()
        {
            await Engine.sleep(297);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2160_cor", 3831759598U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2160_cor", 6F);
            Engine.unit_set_emotional_state(cortana.Entity, "annoyed", 0.5F, 0);
            Engine.print("cortana - annoyed .5 0");
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task c07_2170_cor()
        {
            await Engine.sleep(490);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2170_cor", 3831825135U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2170_cor", 3F);
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task c07_2180_cor()
        {
            await Engine.sleep(622);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2180_cor", 3831890672U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2180_cor", 3F);
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task c07_2190_cor()
        {
            await Engine.sleep(710);
            Engine.unit_set_emotional_state(cortana.Entity, "disappointed", 0.5F, 60);
            Engine.print("cortana - disappointed .5 60");
            await Engine.sleep(13);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2190_cor", 3831956209U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c07_2190_cor", 1F);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c07_intra1_07_fov_01()
        {
            await Engine.sleep(414);
            Engine.print("fov change: 60 -> 26 over 0 ticks");
            Engine.camera_set_field_of_view(26F, 0);
            await Engine.sleep(70);
            Engine.print("fov change: 26 -> 60 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task c07_intra1_07_setup()
        {
            Engine.wake(new ScriptMethodReference(c07_2130_cor));
            Engine.wake(new ScriptMethodReference(c07_2140_cor));
            Engine.wake(new ScriptMethodReference(c07_2150_mas));
            Engine.wake(new ScriptMethodReference(c07_2160_cor));
            Engine.wake(new ScriptMethodReference(c07_2170_cor));
            Engine.wake(new ScriptMethodReference(c07_2180_cor));
            Engine.wake(new ScriptMethodReference(c07_2190_cor));
            Engine.wake(new ScriptMethodReference(c07_intra1_07_fov_01));
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task c07_intra1_07_cleanup()
        {
            Engine.object_destroy_containing("mercy");
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task c07_intra1_scene_07()
        {
            await this.c07_intra1_07_setup();
            Engine.cinematic_set_near_clip_distance(0.05F);
            Engine.print("setting near clip distance to .05");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3828810433U), "07_intra1_07", default(IUnit), anchor_flag_intra1);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3828875970U), "chief_07", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(cortana.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_intra1\\07_intra1", 3831431913U), "cortana_07", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3828941507U), "mercy_07", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(throne_mercy.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\gravity_throne\\animations\\07_intra1\\07_intra1", 3829138118U), "throne_mercy_07", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_intra1_08_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_08_fol", 3832021746U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_intra1_07_cleanup();
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_08()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_08_fol", 3832021746U), default(IGameObject), 1F);
            Engine.print("c07_intra1 foley 08 start");
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task pelican_crash_01()
        {
            await Engine.sleep(38);
            Engine.print("crash 1");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit_small", 3832087283U), pelican_01.Entity, "hardpoint_right");
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task pelican_crash_02()
        {
            await Engine.sleep(49);
            Engine.print("crash 2");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3832677116U), pelican_01.Entity, "johnson");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task pelican_crash_03()
        {
            await Engine.sleep(101);
            Engine.print("crash 3");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3832677116U), pelican_01.Entity, "pelican_p_l05");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c07_intra1_08_fov_01()
        {
            await Engine.sleep(99);
            Engine.print("fov change: 36 -> 60 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task flood_pelican_unload()
        {
            await Engine.sleep(145);
            Engine.print("ai flood unload");
            await this.cinematic_pelican_unload();
            await this.cinematic_pelican_runby();
        }

        [ScriptMethod(70, Lifecycle.Static)]
        public async Task c07_intra1_08_setup()
        {
            Engine.wake(new ScriptMethodReference(c07_intra1_foley_08));
            Engine.object_destroy_containing("offending_crate");
            Engine.object_create_anew(pelican_01);
            Engine.object_cinematic_lod(pelican_01.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_01.Entity, true);
            Engine.wake(new ScriptMethodReference(c07_intra1_08_fov_01));
            Engine.wake(new ScriptMethodReference(pelican_crash_01));
            Engine.wake(new ScriptMethodReference(pelican_crash_02));
            Engine.wake(new ScriptMethodReference(pelican_crash_03));
            Engine.wake(new ScriptMethodReference(flood_pelican_unload));
        }

        [ScriptMethod(71, Lifecycle.Static)]
        public async Task c07_intra1_08_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(cortana.Entity);
            Engine.object_destroy(pelican_01.Entity);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task c07_intra1_scene_08()
        {
            await this.c07_intra1_08_setup();
            Engine.cinematic_set_near_clip_distance(0.06F);
            Engine.print("resetting near clip distance to .06");
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3828810433U), "07_intra1_08", default(IUnit), anchor_flag_intra1);
            Engine.camera_set_field_of_view(26F, 0);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3828875970U), "chief_08", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(cortana.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_intra1\\07_intra1", 3831431913U), "cortana_08", false, anchor_intra1.Entity);
            Engine.custom_animation_relative(pelican_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\07_intra1\\07_intra1", 3832873727U), "pelican_08", false, anchor_intra1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.sound_class_set_gain("amb", 0F, 15);
            await Engine.sleep(15);
            await this.c07_intra1_08_cleanup();
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task c07_intra1()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.sound_class_set_gain("amb", 0F, 0);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_5"));
            await Engine.sleep(1);
            await this.c07_intra1_scene_05();
            await this.c07_intra1_scene_06();
            await this.c07_intra1_scene_07();
            await this.c07_intra1_scene_08();
            Engine.sound_class_set_gain("vehicle", 1F, 15);
            Engine.sound_class_set_gain("amb", 1F, 15);
            await Engine.sleep(15);
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c07_outro_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\music\\c07_outro_01_mus", 3832939264U), default(IGameObject), 1F);
            Engine.print("c07_outro score 01 start");
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task c07_outro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_01_fol", 3833004801U), default(IGameObject), 1F);
            Engine.print("c07_outro foley 01 start");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task c07_outro_shake()
        {
            await Engine.sleep(89);
            Engine.print("shake start");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            await Engine.sleep(70);
            Engine.player_effect_stop(0F);
            Engine.print("shake stop");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task c07_outro_shake2()
        {
            Engine.time_code_reset();
            await Engine.sleep(290);
            Engine.print("shake start");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_stop(1F);
            Engine.print("shake stop");
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c07_outro_dof_01()
        {
            Engine.time_code_reset();
            Engine.print("rack focus");
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(20F, 0F, 0F, 0F, 1F, 1F, 0F);
            await Engine.sleep(89);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c07_outro_dof_02()
        {
            Engine.time_code_reset();
            await Engine.sleep(289);
            Engine.print("rack focus");
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(20F, 2F, 2F, 0F, 0F, 0F, 0F);
            await Engine.sleep(106);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task c07_outro_fov_01()
        {
            await Engine.sleep(357);
            Engine.print("fov change: 60 -> 12 over 15 ticks");
            Engine.camera_set_field_of_view(12F, 15);
            await Engine.sleep(46);
            Engine.print("fov change: 12 -> 60 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c07_outro_cinematic_lighting_01()
        {
            Engine.cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            Engine.cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.rasterizer_bloom_override(true);
            Engine.rasterizer_bloom_override_threshold(0.3F);
            Engine.rasterizer_bloom_override_brightness(0.5F);
            Engine.object_uses_cinematic_lighting(chief_outro.Entity, true);
            Engine.object_uses_cinematic_lighting(alcove.Entity, true);
            Engine.object_uses_cinematic_lighting(cap.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_01.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_02.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_03.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_04.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_05.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_06.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_06.Entity, true);
            Engine.object_uses_cinematic_lighting(ring_08.Entity, true);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task ship_initial_blast()
        {
            await Engine.sleep(188);
            Engine.print("effect - initial blast");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale5", 3833070338U), forerunner_ship.Entity, "thruster");
        }

        [ScriptMethod(83, Lifecycle.Static)]
        public async Task c07_outro_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(chief_outro);
            Engine.object_cinematic_lod(chief_outro.Entity, true);
            Engine.object_create_anew(conduit);
            Engine.object_create_anew(ring_01);
            Engine.object_create_anew(ring_02);
            Engine.object_create_anew(ring_03);
            Engine.object_create_anew(ring_04);
            Engine.object_create_anew(ring_05);
            Engine.object_create_anew(ring_06);
            Engine.object_create_anew(ring_07);
            Engine.object_create_anew(ring_08);
            Engine.object_cinematic_lod(conduit.Entity, true);
            Engine.object_cinematic_lod(ring_01.Entity, true);
            Engine.object_cinematic_lod(ring_02.Entity, true);
            Engine.object_cinematic_lod(ring_03.Entity, true);
            Engine.object_cinematic_lod(ring_04.Entity, true);
            Engine.object_cinematic_lod(ring_05.Entity, true);
            Engine.object_cinematic_lod(ring_06.Entity, true);
            Engine.object_cinematic_lod(ring_07.Entity, true);
            Engine.object_cinematic_lod(ring_08.Entity, true);
            Engine.object_cinematic_visibility(conduit.Entity, true);
        }

        [ScriptMethod(84, Lifecycle.Static)]
        public async Task c07_outro_01_setup()
        {
            Engine.object_create_anew(forerunner_ship);
            Engine.object_create_anew(cap);
            Engine.object_create_anew(alcove);
            Engine.object_cinematic_visibility(cap.Entity, true);
            Engine.object_cinematic_lod(forerunner_ship.Entity, true);
            Engine.object_cinematic_lod(alcove.Entity, true);
            Engine.wake(new ScriptMethodReference(c07_outro_score_01));
            Engine.wake(new ScriptMethodReference(c07_outro_foley_01));
            Engine.wake(new ScriptMethodReference(ship_initial_blast));
            Engine.wake(new ScriptMethodReference(c07_outro_dof_01));
            Engine.wake(new ScriptMethodReference(c07_outro_dof_02));
            Engine.wake(new ScriptMethodReference(c07_outro_shake));
            Engine.wake(new ScriptMethodReference(c07_outro_shake2));
            Engine.wake(new ScriptMethodReference(c07_outro_fov_01));
            Engine.wake(new ScriptMethodReference(c07_outro_cinematic_lighting_01));
        }

        [ScriptMethod(85, Lifecycle.Static)]
        public async Task c07_outro_01_cleanup()
        {
            Engine.object_destroy(conduit.Entity);
            Engine.object_destroy(cap.Entity);
            Engine.object_destroy(ring_05.Entity);
            Engine.object_destroy(ring_06.Entity);
            Engine.object_destroy(ring_07.Entity);
            Engine.object_destroy(ring_08.Entity);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task c07_outro_scene_01()
        {
            Engine.sound_class_set_gain("amb", 0F, 30);
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this.c07_outro_problem_actors();
            await this._07_outro_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\music\\c07_outro_01_mus", 3832939264U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_01_fol", 3833004801U));
            await Engine.sleep(this.prediction_offset);
            await this.c07_outro_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_outro\\07_outro", 3833791245U), "07_outro_01", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief_outro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_outro\\07_outro", 3833856782U), "chief_01", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(forerunner_ship.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\07_outro\\07_outro", 3833922319U), "forerunner_ship_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(alcove.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\07_outro\\07_outro", 3833987856U), "alcove_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(cap.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_cap\\07_outro\\07_outro", 3834053393U), "conduit_cap_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(conduit.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit\\07_outro\\07_outro", 3834118930U), "conduit_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring01_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring02_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring03_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring04_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_05.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring05_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_06.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring06_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_07.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring07_01", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_08.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring08_01", anchor_outro1.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_outro_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_02_fol", 3834250004U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c07_outro_01_cleanup();
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task c07_outro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_02_fol", 3834250004U), default(IGameObject), 1F);
            Engine.print("c07_outro foley 02 start");
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task c07_9010_cor()
        {
            await Engine.sleep(38);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9010_cor", 3834315541U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c07_9010_cor", 2F);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task c07_9020_mas()
        {
            await Engine.sleep(104);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9020_mas", 3834381078U), chief_outro.Entity, 1F);
            Engine.cinematic_subtitle("c07_9020_mas", 2F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task c07_9030_cor()
        {
            await Engine.sleep(147);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9030_cor", 3834446615U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c07_9030_cor", 2F);
            Engine.unit_set_emotional_state(cortana_outro.Entity, "pensive", 0.25F, 0);
            Engine.print("cortana - pensive .25 0");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task c07_9040_cor()
        {
            await Engine.sleep(211);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9040_cor", 3834512152U), cortana_outro.Entity, 1F);
            Engine.cinematic_subtitle("c07_9040_cor", 2F);
            Engine.unit_set_emotional_state(cortana_outro.Entity, "disappointed", 0.75F, 60);
            Engine.print("cortana - disappointed .75 60");
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task chief_sparks()
        {
            await Engine.sleep(17);
            Engine.print("chief sparks");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\07\\chief_sparks", 3834577689U), chief_outro.Entity, "body");
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task c07_outro_fov_02()
        {
            await Engine.sleep(99);
            Engine.print("fov change: 36 -> 60 over 0 ticks");
            Engine.camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task c07_outro_cinematic_lighting_02()
        {
            Engine.cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            Engine.cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task ship_take_off_01()
        {
            await Engine.sleep(271);
            Engine.print("effect - take off 01");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale12", 3834643226U), forerunner_ship.Entity, "thruster");
            Engine.object_create_anew(takeoff_dust);
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task c07_outro_03_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(matte_high_charity);
            Engine.object_create_anew(matte_substance);
            Engine.object_create_anew_containing("outro_fleet");
        }

        [ScriptMethod(97, Lifecycle.Static)]
        public async Task c07_outro_02_setup()
        {
            Engine.object_create_anew(cortana_outro);
            Engine.object_cinematic_lod(cortana_outro.Entity, true);
            Engine.object_create_anew(bloom_quad);
            Engine.wake(new ScriptMethodReference(c07_outro_foley_02));
            Engine.wake(new ScriptMethodReference(c07_9010_cor));
            Engine.wake(new ScriptMethodReference(c07_9020_mas));
            Engine.wake(new ScriptMethodReference(c07_9030_cor));
            Engine.wake(new ScriptMethodReference(c07_9040_cor));
            Engine.wake(new ScriptMethodReference(chief_sparks));
            Engine.wake(new ScriptMethodReference(ship_take_off_01));
            Engine.wake(new ScriptMethodReference(c07_outro_cinematic_lighting_02));
        }

        [ScriptMethod(98, Lifecycle.Static)]
        public async Task c07_outro_02_cleanup()
        {
            Engine.object_destroy(takeoff_dust.Entity);
            Engine.object_destroy(ring_01.Entity);
            Engine.object_destroy(ring_02.Entity);
            Engine.object_destroy(ring_03.Entity);
            Engine.object_destroy(ring_04.Entity);
            Engine.object_destroy(bloom_quad.Entity);
        }

        [ScriptMethod(99, Lifecycle.Static)]
        public async Task c07_outro_scene_02()
        {
            await this.c07_outro_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_outro\\07_outro", 3833791245U), "07_outro_02", default(IUnit), anchor_flag_outro1);
            Engine.custom_animation_relative(chief_outro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_outro\\07_outro", 3833856782U), "chief_02", false, anchor_outro1.Entity);
            Engine.custom_animation_relative(cortana_outro.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_outro\\07_outro", 3834839837U), "cortana_02", false, anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(forerunner_ship.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\07_outro\\07_outro", 3833922319U), "forerunner_ship_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(alcove.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\07_outro\\07_outro", 3833987856U), "alcove_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(cap.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_cap\\07_outro\\07_outro", 3834053393U), "conduit_cap_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring01_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring02_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring03_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(ring_04.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3834184467U), "ring04_02", anchor_outro1.Entity);
            Engine.scenery_animation_start_relative(bloom_quad.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\special\\bloom_quad\\07_outro\\07_outro", 3834905374U), "bloom_quad_02", anchor_outro1.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._07_outro_03_predict_stub();
            await this.c07_outro_03_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_03_fol", 3834970911U));
            Engine.cinematic_screen_effect_start(true);
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.cinematic_screen_effect_set_crossfade(1.5F);
            Engine.print("crossfade");
            await Engine.sleep(5);
            await this.c07_outro_02_cleanup();
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task c07_outro_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_03_fol", 3834970911U), default(IGameObject), 1F);
            Engine.print("c07_outro foley 03 start");
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task c07_outro_cinematic_lighting_03()
        {
            Engine.cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            Engine.cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.object_uses_cinematic_lighting(forerunner_ship.Entity, true);
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task ship_take_off_02()
        {
            await Engine.sleep(0);
            Engine.print("effect - take off 02");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale01", 3835036448U), forerunner_ship.Entity, "thruster");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task ship_take_off_03()
        {
            Engine.time_code_reset();
            await Engine.sleep(111);
            Engine.print("effect - take off 02");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale04", 3835298596U), forerunner_ship.Entity, "thruster");
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task effect_slipspace()
        {
            await Engine.sleep(159);
            Engine.print("effect - slipspace");
            Engine.object_create_anew(slipspace);
        }

        [ScriptMethod(105, Lifecycle.Static)]
        public async Task c07_outro_03_setup()
        {
            Engine.wake(new ScriptMethodReference(c07_outro_foley_03));
            Engine.wake(new ScriptMethodReference(ship_take_off_02));
            Engine.wake(new ScriptMethodReference(ship_take_off_03));
            Engine.wake(new ScriptMethodReference(effect_slipspace));
            Engine.wake(new ScriptMethodReference(c07_outro_cinematic_lighting_02));
        }

        [ScriptMethod(106, Lifecycle.Static)]
        public async Task c07_outro_03_cleanup()
        {
            Engine.cinematic_screen_effect_stop();
            Engine.object_destroy(forerunner_ship.Entity);
            Engine.object_destroy(matte_high_charity.Entity);
            Engine.object_destroy(matte_substance.Entity);
            Engine.object_destroy_containing("outro_fleet");
        }

        [ScriptMethod(107, Lifecycle.Static)]
        public async Task c07_outro_scene_03()
        {
            await this.c07_outro_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_outro\\07_outro", 3833791245U), "07_outro_03", default(IUnit), anchor_flag_outro2);
            Engine.scenery_animation_start_relative(forerunner_ship.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\07_outro\\07_outro", 3833922319U), "forerunner_ship_03", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_high_charity.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\07_outro\\07_outro", 3835560744U), "high_charity_03", anchor_outro2.Entity);
            Engine.scenery_animation_start_relative(matte_substance.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\07_outro\\07_outro", 3835626281U), "substance_03", anchor_outro2.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - 30));
            Engine.fade_out(0F, 0F, 0F, 30);
            await Engine.sleep(30);
            await Engine.sleep(90);
            await this.c07_outro_03_cleanup();
        }

        [ScriptMethod(108, Lifecycle.Static)]
        public async Task c07_outro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            Engine.sound_class_set_gain("amb", 0F, 0);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("high_9_cinematic"));
            await Engine.sleep(1);
            await this.c07_outro_scene_01();
            await this.c07_outro_scene_02();
            await this.c07_outro_scene_03();
            Engine.sound_class_set_gain("vehicle", 1F, 1);
            Engine.sound_class_set_gain("amb", 1F, 1);
            Engine.rasterizer_bloom_override(false);
        }

        [ScriptMethod(109, Lifecycle.Stub)]
        public async Task c07_intra2()
        {
            Engine.print("c07_intra2");
        }

        [ScriptMethod(110, Lifecycle.CommandScript)]
        public async Task cs_expand_cortana()
        {
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.01F, 0);
            Engine.object_cannot_take_damage(Engine.ai_get_object(this.ai_current_actor));
            Engine.ai_disregard(Engine.ai_get_object(this.ai_current_actor), true);
            await Engine.sleep(5);
            Engine.unit_set_emotional_state(Engine.ai_get_unit(this.ai_current_actor), "disappointed", 0.5F, 0);
            Engine.object_dynamic_simulation_disable(Engine.ai_get_object(this.ai_current_actor), true);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4176942787U), Engine.ai_get_object(this.ai_current_actor), "effect");
            await Engine.sleep(1);
            Engine.object_hide(Engine.ai_get_object(this.ai_current_actor), false);
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.65F, 20);
            Engine.cs_face_player(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task music_07b_01_start()
        {
            Engine.print("music 07b_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_01", 4177008324U), default(IGameObject), 1F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task music_07b_01_stop()
        {
            Engine.print("music 07b_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_01", 4177008324U));
        }

        [ScriptMethod(113, Lifecycle.Static)]
        public async Task test()
        {
            Engine.objects_attach(sanctum_lift.Entity, "switch", sanctum_lift_control.Entity, "");
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task music_07b_02_start()
        {
            Engine.print("music 07b_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_02", 4177204935U), default(IGameObject), 1F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task music_07b_03_start()
        {
            Engine.print("music 07b_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_03", 4177336009U), default(IGameObject), 1F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task music_07b_03_stop()
        {
            Engine.print("music 07b_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_03", 4177336009U));
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task music_07b_04_start()
        {
            Engine.print("music 07b_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_04", 4177663694U), default(IGameObject), 1F);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task music_07b_04_stop()
        {
            Engine.print("music 07b_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_04", 4177663694U));
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task music_07b_05_start()
        {
            Engine.print("music 07b_05 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_05", 4177860305U), default(IGameObject), 1F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task music_07b_05_stop()
        {
            Engine.print("music 07b_05 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_05", 4177860305U));
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task music_07b_06_start()
        {
            Engine.print("music 07b_06 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_06", 4178056916U), default(IGameObject), 1F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task music_07b_06_stop()
        {
            Engine.print("music 07b_06 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_06", 4178056916U));
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task chapter_purposes()
        {
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task chapter_please()
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

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task chapter_sanctified()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_3);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task chapter_feeling()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_4);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task objective_enter_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("fight your way back inside the mausoleum-tower.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task objective_enter_clear()
        {
            Engine.print("objective complete:");
            Engine.print("you got inside the tower");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task objective_riptide_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("survive the rising tide of the flood.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task objective_riptide_clear()
        {
            Engine.print("objective complete:");
            Engine.print("you have reached the inner sanctum of the covenant homeworld");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task objective_exit_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("find a way onto the forerunner ship.");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task objective_exit_clear()
        {
            Engine.print("objective complete:");
            Engine.print("ride that pipe.");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task gen_dia_civil_war_a()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: brute and elite ships are engaging one-another all around high charity!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2880"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task gen_dia_civil_war_b()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: the jackals and the drones have declared themselves the servants of the brutes. the hunters have have sworn allegiance to the elites.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2890"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task gen_dia_civil_war_c()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: the grunts seem to be neutral, or, at least afraid to announce which side they support. except for truth, the prophets aren't saying a word.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2900"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task gen_dia_locking_doors_behind()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: if it makes you feel any better, i'm locking the doors behind you. should keep some of the flood off your back.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2840"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task e1_dia_truth_holycity()
        {
            if (this.dialogue)
            {
                Engine.print("truth: shall we let the flood consume our holy-city? turn high charity into another of their wretched hives?");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4118680413U), e5_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4118680413U), e5_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4118680413U), e5_speaker5.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4118680413U), e5_speaker0.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4118680413U), e5_speaker1.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e5_speaker3.Entity, "0280"));
            await Engine.sleep(30);
            if (this.dialogue)
            {
                Engine.print("truth: no enemy has ever withstood our might - the flood too shall fall!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4118156117U), e5_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4118156117U), e5_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4118156117U), e5_speaker5.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4118156117U), e5_speaker0.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4118156117U), e5_speaker1.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e5_speaker3.Entity, "0200"));
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task e5_dia_get_to_conduit()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: no time to admire the view. truth's phantom has reached the forerunner ship!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2730"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task e8_dia_security_lock()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: the security systems in this part of the tower are particularly robust. hang on while i override the lock.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2760"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_a()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: hang on. this will just take a minute.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2780"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_b()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: standby while i break the lock.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2790"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_c()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: i'm working as quickly as possible.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2800"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_d()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: almost have it.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2810"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_e()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: just a little more time...");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2820"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_f()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: a few more seconds...");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2830"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task e7_dia_filtration_systems()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: flood spores have contaminated the city's life-support infrastructure - the filtration systems are overloading!");
            }

            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2850_cor", 4125234113U)));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task e10_dia_truth_theparasite()
        {
            if (this.dialogue)
            {
                Engine.print("truth: the parasite did not defeat the forerunners, and it shall not defeat us!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2910"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task e10_dia_truth_grippedbyfear()
        {
            if (this.dialogue)
            {
                Engine.print("truth: whosoever is gripped by fear, take heed: i am the prophet of truth, and i am not afraid!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0210"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task e10_dia_truth_noblemercy()
        {
            if (this.dialogue)
            {
                Engine.print("truth: noble mercy is here, at my side - his wise counsel ever in my ears!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0270"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task e10_dia_civilwar_a()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: brute and elite ships are engaging one-another all around high charity!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2880"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task e10_dia_civilwar_b()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: the jackals and drones have declared themselves the servants of the brutes. the hunters have sworn allegiance to the elites.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2890"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task e10_dia_civilwar_c()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: the grunts seem to be neutral, or at least afraid to announce which side they support. except for truth the prophets aren't saying a word.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2900"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_a()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: stopping truth - that's all that matters!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2980"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task e12_dia_truth_becomegods()
        {
            if (this.dialogue)
            {
                Engine.print("truth: now is the time of our unworlding - the moment we shall all become as gods!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0330"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task e12_dia_truth_final()
        {
            if (this.dialogue)
            {
                Engine.print("truth: if you would falter, know this: one final effort is all that remains!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0260"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task e12_dia_go_conduit_a()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: get to the conduit. i'll keep it attached to the ship as long as i can.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2940"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task e12_dia_go_conduit_b()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: i've lost control of the conduit! it's breaking away from the ship!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2950"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task e12_dia_end_b()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: you know the plan. you've got to stop truth. i've got to handle the index. go!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3030"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_flood()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: forget about the flood! you've got to get aboard!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2960"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_brutes()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: ignore the brutes! get into the conduit!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2970"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_d()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: i can't go with you!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3010"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task e12_dia_end_a()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: i have to stay here, chief!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3020"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task e12_dia_end_c()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: we're out of time, chief! into the conduit!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3040"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_c()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: chief! leave me!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3000"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_b()
        {
            if (this.dialogue)
            {
                Engine.print("cortana: jump in chief, now!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2990"));
            await Engine.sleep(this.dialogue_pause);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task e12_pelican_flyby()
        {
            Engine.ai_place(e12_CS_pelican1.Squad);
            Engine.ai_place(e12_CS_banshee1.Squad);
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task e12_cs_pelican1()
        {
            Engine.cs_vehicle_speed(0.8F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican3/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican3/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican3/p2"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("pelican3/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican3/p4"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican3/p5"));
            Engine.ai_erase(e12_CS_pelican1.Squad);
            Engine.ai_erase(e12_CS_banshee1.Squad);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task e12_tickle()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_tickle, Engine.players()), 15);
            Engine.print("placing cortana...");
            Engine.ai_place(cortana1.Squad);
            Engine.wake(new ScriptMethodReference(music_07b_03_stop));
            await Engine.sleep_until(async () => this.g_dialogue_counter == 8);
            await Engine.sleep(90);
            if (this.dialogue)
            {
                Engine.print("cortana: i knew the covenant was good at re-purposing forerunner technology, but this is amazing. they've been using the forerunner ship's engines as an energy-source for the city!");
            }

            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
            {
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2920"));
            }
            else
            {
                await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "2920"));
            }

            await Engine.sleep((short)(this.dialogue_pause * 2));
            if (this.dialogue)
            {
                Engine.print("cortana: the ship isn't so much launching as it is disengaging - uncoupling itself from high charity's power grid!");
            }

            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
            {
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2930"));
            }
            else
            {
                await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "2930"));
            }

            await Engine.sleep_until(async () => this.g_e12_started);
            if (this.dialogue)
            {
                Engine.print("cortana: stopping truth - that's all that matters!");
            }

            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
            {
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2980"));
            }
            else
            {
                await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "2980"));
            }

            await Engine.sleep((short)(this.dialogue_pause * 6));
            if (this.dialogue)
            {
                Engine.print("truth: now is the time of our unworlding - the moment we shall all become as gods!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker5.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker6.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker7.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker8.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e12_speaker0.Entity, "0330"));
            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => this.g_e12_final_battle_started);
            if (this.dialogue)
            {
                Engine.print("cortana: you know the plan. you've got to stop truth. i've got to handle the index. go!");
            }

            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
            {
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3030"));
            }
            else
            {
                await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "3030"));
            }

            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => this.g_e12_final_battle_mid);
            if (this.dialogue)
            {
                Engine.print("truth: if you would falter, know this: one final effort is all that remains!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4118549339U), e12_speaker1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4118549339U), e12_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4118549339U), e12_speaker3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4118549339U), e12_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker5.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker6.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker7.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4119008098U), e12_speaker8.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e12_speaker0.Entity, "0260"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: forget about the flood! you've got to get aboard!");
            }

            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
            {
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2960"));
            }
            else
            {
                await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "2960"));
            }

            await Engine.sleep(this.dialogue_pause);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_final_dialogue, Engine.players()));
            if (Engine.random_range(0, 2) == 1 ? true : false)
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: i can't go with you!");
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
                {
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3010"));
                }
                else
                {
                    await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "3010"));
                }

                await Engine.sleep(this.dialogue_pause_long);
            }
            else
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: i have to stay here, chief!");
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
                {
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3020"));
                }
                else
                {
                    await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "3020"));
                }

                await Engine.sleep(this.dialogue_pause_long);
            }

            await Engine.sleep(90);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_final_dialogue, Engine.players()));
            if (Engine.random_range(0, 2) == 1 ? true : false)
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: we're out of time, chief! into the conduit!");
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
                {
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3040"));
                }
                else
                {
                    await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "3040"));
                }

                await Engine.sleep(this.dialogue_pause_long);
            }
            else
            {
                if (this.dialogue)
                {
                    Engine.print("cortana: chief! leave me!");
                }

                if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
                {
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "3000"));
                }
                else
                {
                    await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "3000"));
                }

                await Engine.sleep(this.dialogue_pause_long);
            }

            await Engine.sleep(20);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_final_dialogue, Engine.players()));
            if (this.dialogue)
            {
                Engine.print("cortana: jump in chief, now!");
            }

            if (Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(cortana1.Squad)) > 7F)
            {
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2990"));
            }
            else
            {
                await Engine.sleep(Engine.ai_play_line_at_player(cortana1.Squad, "2990"));
            }
        }

        [ScriptMethod(169, Lifecycle.Static)]
        public async Task e12_safe_to_spawn_flood()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(e12_flood_rush) <= 4, 15);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task e12_final_battle()
        {
            Engine.print("final battle started!!!!!!");
            this.g_e12_final_battle_started = true;
            if (this.g_e12_side)
            {
                Engine.begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_right.Squad), 
                    async () => await Engine.sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf3_right.Squad), 
                    async () => await Engine.sleep(1));
                this.g_e12_talk = 2;
                Engine.begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf1_right.Squad), 
                    async () => await Engine.sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_right.Squad), 
                    async () => await Engine.sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf3_right.Squad), 
                    async () => await Engine.sleep(1));
                Engine.wake(new ScriptMethodReference(e12_pelican_flyby));
                Engine.print("final battle midpoint...");
                this.g_e12_final_battle_mid = true;
                await this.e12_safe_to_spawn_flood();
                Engine.begin_random(async () => Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e12_howler1.Entity, 1F), 
                    async () => Engine.ai_place(e12_fld_inf4.guy1), 
                    async () => Engine.ai_place(e12_fld_inf4.guy2), 
                    async () => Engine.ai_place(e12_fld_inf4.guya), 
                    async () => Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e12_howler2.Entity, 1F), 
                    async () => Engine.ai_place(e12_fld_inf4.guy3), 
                    async () => Engine.ai_place(e12_fld_inf4.guy4), 
                    async () => Engine.ai_place(e12_fld_inf4.guyz));
                Engine.begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf1_right.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_right.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf3_right.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_left.Squad));
                Engine.ai_set_orders(e12_flood_rush, e12_get_the_player);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_e12_conduit_check, Engine.ai_actors(all_enemies))));
                this.g_e12_talk = 3;
                this.g_e12_go = true;
            }
            else
            {
                Engine.begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_left.Squad), 
                    async () => await Engine.sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf3_left.Squad), 
                    async () => await Engine.sleep(1));
                this.g_e12_talk = 2;
                Engine.begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf1_left.Squad), 
                    async () => await Engine.sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_left.Squad), 
                    async () => await Engine.sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf3_left.Squad), 
                    async () => await Engine.sleep(1));
                Engine.wake(new ScriptMethodReference(e12_pelican_flyby));
                Engine.print("final battle midpoint...");
                this.g_e12_final_battle_mid = true;
                await this.e12_safe_to_spawn_flood();
                Engine.begin_random(async () => Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e12_howler1.Entity, 1F), 
                    async () => Engine.ai_place(e12_fld_inf4.guy1), 
                    async () => Engine.ai_place(e12_fld_inf4.guy2), 
                    async () => Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e12_howler2.Entity, 1F), 
                    async () => Engine.ai_place(e12_fld_inf4.guy3), 
                    async () => Engine.ai_place(e12_fld_inf4.guy4));
                Engine.begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf1_left.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_left.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf3_left.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => Engine.ai_place(e12_fld_inf2_right.Squad));
                Engine.ai_set_orders(e12_flood_rush, e12_get_the_player);
                await Engine.sleep_until(async () => !(Engine.volume_test_objects_all(tv_e12_conduit_check, Engine.ai_actors(all_enemies))));
                this.g_e12_talk = 3;
                this.g_e12_go = true;
            }

            Engine.print("final battle ended...");
            this.g_e12_final_battle_ended = true;
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task e12_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_trigger1, Engine.players()), 5);
            Engine.wake(new ScriptMethodReference(chapter_feeling));
            Engine.data_mine_set_mission_segment("last_room");
            Engine.game_save_cancel();
            await Engine.sleep(1);
            Engine.game_save_no_timeout();
            this.g_e12_talk = 1;
            this.g_e12_started = true;
            Engine.ai_disposable(e10_pro_inf1.Squad, true);
            Engine.ai_disposable(e10_pro_inf1_a.Squad, true);
            Engine.ai_disposable(e10_cov_inf1.Squad, true);
            Engine.ai_disposable(e10_fld_inf1.Squad, true);
            if (Engine.random_range(0, 2) == 1 ? true : false)
            {
                Engine.object_create_containing("e12_left");
                Engine.ai_place(e12_pro_inf2_left.Squad);
                Engine.ai_place(e12_pro_inf3_end.Squad);
                Engine.ai_place(e12_pro_inf4_left.Squad, 1);
                Engine.wake(new ScriptMethodReference(e12_final_battle));
            }
            else
            {
                Engine.object_create_containing("e12_right");
                Engine.ai_place(e12_pro_inf2_right.Squad);
                Engine.ai_place(e12_pro_inf3_end.Squad);
                Engine.ai_place(e12_pro_inf4_right.Squad, 1);
                this.g_e12_side = true;
                Engine.wake(new ScriptMethodReference(e12_final_battle));
            }

            await Engine.sleep(120);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task e12_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_trigger5, Engine.players()), 15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_trigger6, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e12_start));
            Engine.ai_disposable(e10_fld_swarm1.Squad, true);
            Engine.ai_disposable(e10_cov_inf1.Squad, true);
            Engine.ai_disposable(e10_pro_inf1_a.Squad, true);
            Engine.ai_disposable(e10_pro_inf1.Squad, true);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task e10_sanctum2()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_trigger6, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(music_07b_06_stop));
            Engine.wake(new ScriptMethodReference(e12_tickle));
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("council_chamber");
            await Engine.sleep_until(async () => this.g_dialogue_counter == 7);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_screen, Engine.players()), 10);
            if (this.dialogue)
            {
                Engine.print("cortana: brute and elite ships are engaging one-another all around high charity!");
            }

            if (Engine.volume_test_objects(tv_e10_screen, Engine.players()))
            {
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2880"));
                await Engine.sleep(this.dialogue_pause);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_screen, Engine.players()), 10);
            if (this.dialogue)
            {
                Engine.print("cortana: the jackals and drones have declared themselves the servants of the brutes. the hunters have sworn allegiance to the elites.");
            }

            if (Engine.volume_test_objects(tv_e10_screen, Engine.players()))
            {
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2890_cor", 4125496261U)));
                await Engine.sleep((short)(this.dialogue_pause * 2));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_screen, Engine.players()), 10);
            if (this.dialogue)
            {
                Engine.print("cortana: the grunts seem to be neutral, or at least afraid to announce which side they support. except for truth the prophets aren't saying a word.");
            }

            if (Engine.volume_test_objects(tv_e10_screen, Engine.players()))
            {
                await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2900_cor", 4125561798U)));
                this.g_e10_talk = 9;
            }

            this.g_dialogue_counter = 8;
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task e10_tickle()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_trigger9, Engine.players()) || this.g_e10_talk == 9);
            Engine.sleep_forever(new ScriptMethodReference(e10_sanctum2));
            Engine.wake(new ScriptMethodReference(music_07b_06_stop));
            if (!(this.g_e10_talk == 9))
            {
                await Engine.sleep(150);
            }

            if (this.dialogue)
            {
                Engine.print("cortana: i'm running out of options, chief. i can't stall the launch sequence much longer. the next lift will take you up to the conduit. hurry!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2910"));
            await Engine.sleep(this.dialogue_pause);
            Engine.wake(new ScriptMethodReference(objective_exit_set));
            this.g_dialogue_counter = 8;
            if (this.g_e10_talk == 9)
            {
                Engine.device_set_position(e10_tube_door.Entity, 1F);
                Engine.device_closes_automatically_set(e10_tube_door.Entity, false);
            }
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task e10_end_open()
        {
            await Engine.sleep_until(async () => this.g_e10_move_on == true && Engine.volume_test_objects(tv_e10_trigger5, Engine.players()));
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e10_sanctum2));
            Engine.wake(new ScriptMethodReference(e10_tickle));
            Engine.device_operates_automatically_set(e10_sanctum_door.Entity, true);
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task e10_superflood()
        {
            if (await this.difficulty_legendary())
            {
                Engine.ai_set_active_camo(this.ai_current_actor, false);
            }
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task e10_storm()
        {
            Engine.ai_place(e10_pro_inf1.Squad);
            Engine.ai_place(e10_pro_inf1_a.Squad);
            if (Engine.random_range(0, 2) == 1 ? true : false)
            {
                Engine.ai_place(e10_cov_inf1.Squad, 2);
            }
            else
            {
                Engine.ai_place(e10_cov_inf1.Squad, 3);
            }

            await Engine.sleep_until(async () => (float)Engine.ai_strength(e10_pro_inner_sanctum) <= 0.8F, 15, 600);
            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 1)
                {
                    Engine.ai_place(e10_fld_inf1.guy1);
                    Engine.ai_place(e10_fld_inf1.guy2);
                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 1)
                {
                    Engine.ai_place(e10_fld_inf1.guy4);
                    Engine.ai_place(e10_fld_inf1.guy5);
                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 1)
                {
                    Engine.ai_place(e10_fld_inf1.guy3);
                    Engine.ai_place(e10_fld_inf1.guy6);
                    await Engine.sleep(1);
                }
            });
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e10_pro_inner_sanctum) <= 0.5F, 15, 600);
            this.g_e10_talk = 1;
            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 2)
                {
                    Engine.ai_place(e10_fld_inf1.guy1);
                    Engine.ai_place(e10_fld_inf1.guy2);
                    Engine.ai_place(e10_fld_inf1.guy3);
                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 2)
                {
                    Engine.ai_place(e10_fld_inf1.guy4);
                    Engine.ai_place(e10_fld_inf1.guy5);
                    Engine.ai_place(e10_fld_inf1.guy6);
                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 2)
                {
                    Engine.ai_place(e10_fld_inf1.guy1);
                    Engine.ai_place(e10_fld_inf1.guy5);
                    Engine.ai_place(e10_fld_inf1.guy6);
                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 2)
                {
                    Engine.ai_place(e10_fld_inf1.guy2);
                    Engine.ai_place(e10_fld_inf1.guy3);
                    Engine.ai_place(e10_fld_inf1.guy4);
                    await Engine.sleep(1);
                }
            });
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e10_pro_inner_sanctum) <= 0.3F, 15, 600);
            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 3)
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler1.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy1);
                    Engine.ai_place(e10_fld_inf1.guy2);
                    Engine.ai_place(e10_fld_inf1.guy3);
                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler3.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy7);
                    Engine.ai_place(e10_fld_inf1.guy8);
                    Engine.ai_place(e10_fld_inf1.guy9);
                    if (await this.difficulty_legendary())
                    {
                        Engine.ai_set_orders(e10_fld_inf1.Squad, e10_fld_storm_z);
                    }

                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 3)
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler2.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy4);
                    Engine.ai_place(e10_fld_inf1.guy5);
                    Engine.ai_place(e10_fld_inf1.guy6);
                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler4.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy10);
                    Engine.ai_place(e10_fld_inf1.guy11);
                    Engine.ai_place(e10_fld_inf1.guy12);
                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 3)
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler1.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy1);
                    Engine.ai_place(e10_fld_inf1.guy2);
                    Engine.ai_place(e10_fld_inf1.guy3);
                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler4.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy10);
                    Engine.ai_place(e10_fld_inf1.guy11);
                    Engine.ai_place(e10_fld_inf1.guy12);
                    await Engine.sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e10_flood_storm) <= 3)
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler2.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy4);
                    Engine.ai_place(e10_fld_inf1.guy5);
                    Engine.ai_place(e10_fld_inf1.guy6);
                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e10_howler3.Entity, 1F);
                    Engine.ai_place(e10_fld_inf1.guy7);
                    Engine.ai_place(e10_fld_inf1.guy8);
                    Engine.ai_place(e10_fld_inf1.guy9);
                    await Engine.sleep(1);
                }
            });
            this.g_e10_move_on = true;
            Engine.game_save();
            await Engine.sleep(150);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task e10_infinite_save()
        {
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task e10_sanctum_lift_recall()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(sanctum_lift.Entity) <= 1F, 10);
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(tv_sanctum_lift, Engine.players()))
                {
                    Engine.device_set_position(sanctum_lift.Entity, 1F);
                }

                return false;
            }, 31);
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task e10_sanctum_lift_crusher()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.device_get_position(sanctum_lift.Entity) >= 0.955F)
                {
                    Engine.kill_volume_enable(kill_sanctum_crusher);
                }
                else
                {
                    Engine.kill_volume_disable(kill_sanctum_crusher);
                }

                return false;
            }, 3);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task e10_battle()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_trigger2, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e10_infinite_save));
            Engine.data_mine_set_mission_segment("inner_sanctum");
            Engine.wake(new ScriptMethodReference(e10_storm));
            await Engine.sleep(90);
            Engine.wake(new ScriptMethodReference(chapter_sanctified));
            Engine.wake(new ScriptMethodReference(objective_riptide_clear));
            Engine.ai_disposable(e8_pro_inf1.Squad, true);
            Engine.ai_disposable(e8_fld_inf1.Squad, true);
            await Engine.sleep_until(async () => Engine.device_get_position(sanctum_lift.Entity) <= 1F, 10);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e10_trigger1, Engine.players()), 15);
            Engine.device_set_position(sanctum_lift.Entity, 0F);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task e10_talking_points()
        {
            await Engine.sleep_until(async () => this.g_e10_talk == 1 && this.g_dialogue_counter == 6);
            if (this.dialogue)
            {
                Engine.print("truth: this crisis will not be the end of us! it is but one, last hurdle before the journey and salvation!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4117959506U), e10_speaker1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4117959506U), e10_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4117959506U), e10_speaker3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4117959506U), e10_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4117959506U), e10_speaker5.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e10_speaker0.Entity, "0170"));
            await Engine.sleep(this.dialogue_pause);
            this.g_dialogue_counter = 7;
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task e10_start()
        {
            Engine.wake(new ScriptMethodReference(e10_battle));
            Engine.wake(new ScriptMethodReference(e10_end_open));
            Engine.wake(new ScriptMethodReference(e10_talking_points));
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(tv_e10_trigger1, Engine.players()), 15);
            await Engine.sleep((short)Engine.random_range(150, 240));
            await Engine.sleep((short)Engine.random_range(90, 150));
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task e10_music_aux()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(sanctum_lift.Entity) >= 1F, 10);
            await Engine.sleep_until(async () => Engine.device_get_position(sanctum_lift.Entity) < 1F, 10);
            Engine.wake(new ScriptMethodReference(music_07b_06_start));
            await Engine.sleep(2);
            Engine.game_save();
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task e10_load()
        {
            Engine.device_set_position_immediate(sanctum_lift.Entity, 1F);
            Engine.wake(new ScriptMethodReference(e10_sanctum_lift_recall));
            Engine.wake(new ScriptMethodReference(e10_sanctum_lift_crusher));
            Engine.wake(new ScriptMethodReference(e10_music_aux));
            Engine.objects_attach(sanctum_lift.Entity, "switch", sanctum_lift_control.Entity, "");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_end, Engine.players()), 15);
            Engine.game_save_cancel();
            await Engine.sleep(6);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e10_start));
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task e10_key()
        {
            if (!(await this.difficulty_legendary()))
            {
                Engine.sleep_forever();
            }

            Engine.object_create(key);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4095283704U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4095283704U)));
            Engine.ice_cream_flavor_stock(11);
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task e10_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trigger1, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e10_load));
            Engine.wake(new ScriptMethodReference(e10_key));
            Engine.wake(new ScriptMethodReference(e12_main));
            Engine.ai_disposable(e9_fld_inf1.Squad, true);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task e9_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_trigger1, Engine.players()), 15);
            Engine.data_mine_set_mission_segment("hallway_attack");
            if ((bool)Engine.game_safe_to_save())
            {
                Engine.game_save();
            }

            await Engine.sleep(5);
            if ((bool)Engine.game_safe_to_save())
            {
                if (Engine.volume_test_objects_all(tv_e9_trigger1, Engine.players()))
                {
                    Engine.begin_random(async () =>
                    {
                        if ((short)Engine.ai_living_count(e9_fld_inf1.Squad) <= 0)
                        {
                            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e9_surprise, Engine.players()));
                            Engine.ai_place(e9_fld_inf1.guy1);
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e9_howler1.Entity, 1F);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)Engine.ai_living_count(e9_fld_inf1.Squad) <= 0)
                        {
                            Engine.ai_place(e9_fld_inf1.guy2);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)Engine.ai_living_count(e9_fld_inf1.Squad) <= 0)
                        {
                            Engine.ai_place(e9_fld_inf1.guy3);
                        }
                    });
                }
            }
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_trigger2, Engine.players()), 15);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_end, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e9_start));
            Engine.wake(new ScriptMethodReference(e10_main));
            Engine.ai_disposable(e8_fld_inf1.Squad, true);
            Engine.ai_disposable(e8_fld_swarm1.Squad, true);
            Engine.ai_disposable(e8_pro_inf1.Squad, true);
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task e8_end_open()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_end, Engine.players()), 15);
            await Engine.sleep_until(async () => this.g_dialogue_counter == 5, 15);
            Engine.wake(new ScriptMethodReference(music_07b_05_stop));
            await Engine.sleep(120);
            if (this.dialogue)
            {
                Engine.print("cortana: apparently these are the prophet hierarch's private quarters - their inner sanctum.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2770"));
            this.g_dialogue_counter = 6;
            Engine.game_save();
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task e8_infinite_save()
        {
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task e8_sneaky_spawner_dialogue()
        {
            await Engine.sleep_until(async () => this.g_dialogue_counter == 4);
            if (this.dialogue)
            {
                Engine.print("truth: whosoever is gripped by fear, take heed: i am the prophet of truth, and i am not afraid!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4118221654U), e8_speaker1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4118221654U), e8_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4118221654U), e8_speaker3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4118221654U), e8_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4118221654U), e8_speaker5.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e8_speaker0.Entity, "0210"));
            await Engine.sleep(20);
            if (this.dialogue)
            {
                Engine.print("truth: noble mercy is here, at my side - his wise counsel ever in my ears!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4118614876U), e8_speaker1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4118614876U), e8_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4118614876U), e8_speaker3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4118614876U), e8_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4118614876U), e8_speaker5.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e8_speaker0.Entity, "0270"));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("gravemind: we exist together now. two corpses in one grave.");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4126807001U), e8_speaker_gm1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4126807001U), e8_speaker_gm2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4126807001U), e8_speaker_gm3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4126807001U), e8_speaker_gm4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4126807001U), e8_speaker_gm5.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e8_speaker_gm0.Entity, "5000"));
            Engine.game_save_no_timeout();
            this.g_dialogue_counter = 5;
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task e8_sneaky_spawner()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e8_trigger2_a, Engine.players()));
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                Engine.ai_place(e8_pro_inf1.Squad, 2);
            }
            else
            {
                Engine.ai_place(e8_pro_inf1.Squad, 3);
            }

            Engine.game_save_no_timeout();
            Engine.wake(new ScriptMethodReference(e8_sneaky_spawner_dialogue));
            if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
            {
                if (await this.difficulty_normal() || await this.difficulty_heroic())
                {
                    Engine.ai_place(e8_pro_inf1.Squad, 2);
                }
                else
                {
                    Engine.ai_place(e8_pro_inf1.Squad, 3);
                }
            }

            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3 && Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        if (Engine.random_range(0, 2) == 1 ? true : false)
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler3.Entity, 1F);
                        }

                        Engine.ai_place(e8_fld_inf1.guy10);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3 && Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        if (Engine.random_range(0, 2) == 1 ? true : false)
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler3.Entity, 1F);
                        }

                        Engine.ai_place(e8_fld_inf1.guy9);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3 && Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy8);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3 && Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy7);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                });
                await Engine.sleep_until(async () => (float)Engine.ai_strength(e8_fld_inf1.Squad) <= 0.3F, 15, 1800);
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        if (Engine.random_range(0, 2) == 1 ? true : false)
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler3.Entity, 1F);
                        }

                        Engine.ai_place(e8_fld_inf1.guy10);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        if (Engine.random_range(0, 2) == 1 ? true : false)
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler3.Entity, 1F);
                        }

                        Engine.ai_place(e8_fld_inf1.guy9);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        Engine.ai_place(e8_fld_inf1.guy8);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        Engine.ai_place(e8_fld_inf1.guy7);
                        await Engine.sleep((short)Engine.random_range(30, 180));
                    }
                });
            }
            else
            {
                Engine.begin_random(async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy10);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy9);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy8);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy7);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy12);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                });
                await Engine.sleep_until(async () => (float)Engine.ai_strength(e8_fld_inf1.Squad) <= 0.3F, 15, 450);
                Engine.begin_random(async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy11);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy9);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy8);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy7);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                });
                await Engine.sleep_until(async () => (float)Engine.ai_strength(e8_fld_inf1.Squad) <= 0.5F, 15, 450);
                Engine.begin_random(async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        if (Engine.random_range(0, 2) == 1 ? true : false)
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler3.Entity, 1F);
                        }

                        Engine.ai_place(e8_fld_inf1.guy9);
                        Engine.ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        if (Engine.random_range(0, 2) == 1 ? true : false)
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e8_howler3.Entity, 1F);
                        }

                        Engine.ai_place(e8_fld_inf1.guy10);
                        Engine.ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy11);
                        Engine.ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (Engine.volume_test_objects(tv_e8_cave_check, Engine.players()))
                    {
                        Engine.ai_place(e8_fld_inf1.guy12);
                        Engine.ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await Engine.sleep((short)Engine.random_range(30, 90));
                    }
                });
            }
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task e8_load()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_trigger2, Engine.players()), 15);
            Engine.data_mine_set_mission_segment("space_cave2");
            Engine.ai_place(e8_fld_swarm1.Squad);
            Engine.ai_place(e8_fld_inf1.guy5);
            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    Engine.ai_place(e8_fld_inf1.guy1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    Engine.ai_place(e8_fld_inf1.guy2);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    Engine.ai_place(e8_fld_inf1.guy3);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    Engine.ai_place(e8_fld_inf1.guy4);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    Engine.ai_place(e8_fld_inf1.guy6);
                }
            });
            Engine.ai_disposable(e6_fld_inf1.Squad, true);
            Engine.ai_disposable(e6_fld_inf1_a.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_a.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_b.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_c.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_d.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_z.Squad, true);
            Engine.ai_disposable(e6_fld_inf3.Squad, true);
            Engine.ai_disposable(e6_fld_inf4.Squad, true);
            Engine.ai_disposable(e6_pro_inf2_a.Squad, true);
            Engine.ai_disposable(e6_pro_inf2.Squad, true);
            Engine.ai_disposable(e6_pro_inf3.Squad, true);
            Engine.ai_disposable(e6_pro_inf3_a.Squad, true);
            Engine.wake(new ScriptMethodReference(e8_sneaky_spawner));
            Engine.wake(new ScriptMethodReference(e8_end_open));
            await Engine.sleep_until(async () => this.g_dialogue_counter == 3);
            if (this.dialogue)
            {
                Engine.print("cortana: the security systems in this part of the tower are particularly robust.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2760"));
            this.g_dialogue_counter = 4;
            Engine.wake(new ScriptMethodReference(music_07b_05_start));
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_trigger1, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e8_load));
            Engine.wake(new ScriptMethodReference(e9_main));
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task e7_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e7_trigger1, Engine.players()), 15);
            Engine.data_mine_set_mission_segment("boobag_garden");
            Engine.game_save_cancel();
            await Engine.sleep(6);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_07b_04_stop));
            await Engine.sleep_until(async () => this.g_dialogue_counter == 9);
            await Engine.sleep(150);
            if (this.dialogue)
            {
                Engine.print("cortana: the amount of flood bio-mass is increasing exponentially. there are reports of infestations in every district!");
            }

            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2860_cor", 4125299650U)));
            await Engine.sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                Engine.print("cortana: if the speed of the flood's spread in this tower is any indication, it won't take long for it to overrun the entire city!");
            }

            await Engine.sleep((short)Engine.sound_impulse_language_time(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2870_cor", 4125365187U)));
            await Engine.sleep(this.dialogue_pause);
            this.g_dialogue_counter = 3;
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_trigger1, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e7_start));
            Engine.game_save_no_timeout();
            Engine.wake(new ScriptMethodReference(e8_main));
            Engine.ai_disposable(e6_fld_inf1.Squad, true);
            Engine.ai_disposable(e6_fld_inf1_a.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_z.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_d.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_c.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_b.Squad, true);
            Engine.ai_disposable(e6_fld_inf2_a.Squad, true);
            Engine.ai_disposable(e6_pro_inf2_a.Squad, true);
            Engine.ai_disposable(e6_pro_inf2.Squad, true);
            Engine.ai_disposable(e6_fld_inf4.Squad, true);
            Engine.ai_disposable(e6_fld_inf3.Squad, true);
            Engine.ai_disposable(e6_fld_inf5.Squad, true);
            Engine.ai_disposable(e6_pro_inf3_a.Squad, true);
            Engine.ai_disposable(e6_pro_inf3.Squad, true);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task e6_talking()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_talkbox, Engine.players()), 15);
            this.g_dialogue_counter = 9;
            if (this.dialogue)
            {
                Engine.print("truth: the parasite did not defeat the forerunners, and it shall not defeat us!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4118090580U), e6_speaker1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4118090580U), e6_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4118090580U), e6_speaker3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4118090580U), e6_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4118090580U), e6_speaker5.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e6_speaker0.Entity, "0190"));
            await Engine.sleep(20);
            if (this.dialogue)
            {
                Engine.print("gravemind: arrogant creature! your deaths will be instantaneous, while we shall suffer the progress of infinitude!");
            }

            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4126872538U), e6_speaker1.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4126872538U), e6_speaker2.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4126872538U), e6_speaker3.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4126872538U), e6_speaker4.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4126872538U), e6_speaker5.Entity, 1F, 1);
            Engine.sound_impulse_trigger(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4126872538U), e6_speaker_gm1.Entity, 1F, 1);
            await Engine.sleep(Engine.ai_play_line_on_object(e6_speaker_gm0.Entity, "5010"));
            Engine.wake(new ScriptMethodReference(music_07b_04_start));
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task e6_go_go_go()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_cave_check, Engine.players()));
            Engine.ai_migrate(e6_flood_group_1, e6_flood_group_3);
            await Engine.sleep(10);
            Engine.ai_migrate(e6_flood_group_2, e6_flood_group_3);
            await Engine.sleep(10);
            Engine.ai_migrate(e6_flood_storm, e6_flood_group_3);
            await Engine.sleep(10);
            Engine.ai_set_orders(e6_flood_group_3, e6_fld_go_go_go);
            this.g_e6_move_on = true;
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task e6_final()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_final_start, Engine.players()));
            Engine.data_mine_set_mission_segment("space_cave1");
            Engine.wake(new ScriptMethodReference(e6_talking));
            Engine.wake(new ScriptMethodReference(e6_go_go_go));
            Engine.ai_place(e6_pro_inf3.Squad, 2);
            Engine.ai_place(e6_pro_inf3_a.Squad, 3);
            await Engine.sleep_until(async () => (float)Engine.ai_strength(e6_pro_cave1) <= 0.2F, 15, 600);
            if (Engine.volume_test_objects(tv_e6_cave_check, Engine.players()))
            {
                Engine.ai_place(e6_fld_inf5.Squad);
            }
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task e6_ambush()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_ambusher, Engine.players()));
            Engine.game_save();
            await Engine.sleep(15);
            Engine.ai_place(e6_fld_inf3.Squad);
            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_storm) <= 5 && Engine.volume_test_objects(tv_e6_ambusher, Engine.players()))
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler_spec1.Entity, 1F);
                    Engine.ai_place(e6_fld_inf4.guy1);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.ai_place(e6_fld_inf4.guy2);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_storm) <= 5 && Engine.volume_test_objects(tv_e6_ambusher, Engine.players()))
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler_spec2.Entity, 1F);
                    Engine.ai_place(e6_fld_inf4.guy4);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.ai_place(e6_fld_inf4.guy5);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_storm) <= 5 && Engine.volume_test_objects(tv_e6_ambusher, Engine.players()))
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler_spec3.Entity, 1F);
                    Engine.ai_place(e6_fld_inf4.guy6);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.ai_place(e6_fld_inf4.guy7);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_storm) <= 5 && Engine.volume_test_objects(tv_e6_ambusher, Engine.players()))
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler_spec4.Entity, 1F);
                    Engine.ai_place(e6_fld_inf4.guy8);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.ai_place(e6_fld_inf4.guy9);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_storm) <= 5 && Engine.volume_test_objects(tv_e6_ambusher, Engine.players()))
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler_spec4.Entity, 1F);
                    Engine.ai_place(e6_fld_inf2_z.guy1);
                    await Engine.sleep(6);
                    Engine.ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await Engine.sleep(6);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.ai_place(e6_fld_inf2_z.guy2);
                    await Engine.sleep(6);
                    Engine.ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await Engine.sleep(6);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_storm) <= 5 && Engine.volume_test_objects(tv_e6_ambusher, Engine.players()))
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler_spec4.Entity, 1F);
                    Engine.ai_place(e6_fld_inf2_z.guy3);
                    await Engine.sleep(6);
                    Engine.ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await Engine.sleep(6);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await Engine.sleep((short)Engine.random_range(90, 150));
                    Engine.ai_place(e6_fld_inf2_z.guy4);
                    await Engine.sleep(6);
                    Engine.ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await Engine.sleep(6);
                    if (this.g_e6_move_on)
                    {
                        Engine.ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            });
        }

        [ScriptMethod(202, Lifecycle.CommandScript)]
        public async Task e6_cs_attack_the_prophetscd()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_force_combat_status(3);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e6_attack/p0"), Engine.GetReference<ISpatialPoint>("e6_attack/p1"));
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e6_attack/p2"), Engine.GetReference<ISpatialPoint>("e6_attack/p3"));
        }

        [ScriptMethod(203, Lifecycle.CommandScript)]
        public async Task e6_cs_attack_the_prophetsab()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_force_combat_status(3);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e6_attack/p4"), Engine.GetReference<ISpatialPoint>("e6_attack/p5"));
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("e6_attack/p2"), Engine.GetReference<ISpatialPoint>("e6_attack/p3"));
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task e6_flood_attack_2()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_trigger3, Engine.players()));
            Engine.game_save_no_timeout();
            Engine.data_mine_set_mission_segment("riptide_ambush");
            Engine.wake(new ScriptMethodReference(e6_ambush));
            Engine.wake(new ScriptMethodReference(e6_final));
            Engine.ai_place(e6_pro_inf2.Squad, 2);
            Engine.ai_place(e6_pro_inf2_a.Squad, 2);
            Engine.ai_disposable(e5_pro_inf1.Squad, true);
            Engine.ai_disposable(e5_pro_bug2_c.Squad, true);
            Engine.ai_disposable(e5_fld_inf1.Squad, true);
            Engine.ai_disposable(e5_fld_inf2.Squad, true);
            Engine.ai_disposable(e5_fld_inf2_z.Squad, true);
            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_group_2) <= 0)
                {
                    await Engine.sleep(10);
                    Engine.ai_place(e6_fld_inf2_a.Squad);
                    Engine.ai_place(e6_fld_inf2_b.Squad);
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler1.Entity, 1F);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_group_2) <= 0)
                {
                    await Engine.sleep(10);
                    Engine.ai_place(e6_fld_inf2_c.Squad);
                    Engine.ai_place(e6_fld_inf2_d.Squad);
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4178450138U), e6_howler2.Entity, 1F);
                }
            });
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(e6_flood_group_2) <= 1, 10, 300);
            Engine.ai_place(e6_fld_inf2_z.Squad, 1);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(e6_flood_group_2) <= 0, 10, 450);
            if (Engine.volume_test_objects(tv_e6_infinite2, Engine.players()))
            {
                Engine.ai_place(e6_fld_inf2_z.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(e6_flood_group_2) <= 0, 10, 450);
            if (Engine.volume_test_objects(tv_e6_infinite2, Engine.players()))
            {
                Engine.ai_place(e6_fld_inf2_z.Squad, 1);
            }
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task e6_infinite_save()
        {
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task e6_flood_attack_1()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e6_fld_inf1.Squad) <= 0, 15, 300);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e7_dia_filtration_systems));
            Engine.begin_random(async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_group_1) <= 0 && Engine.volume_test_objects(tv_e6_infinite1, Engine.players()))
                {
                    Engine.ai_place(e6_fld_inf1_a.guy1);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_group_1) <= 0 && Engine.volume_test_objects(tv_e6_infinite1, Engine.players()))
                {
                    await Engine.sleep(10);
                    Engine.ai_place(e6_fld_inf1_a.guy2);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_group_1) <= 0 && Engine.volume_test_objects(tv_e6_infinite1, Engine.players()))
                {
                    await Engine.sleep(10);
                    Engine.ai_place(e6_fld_inf1_a.guy3);
                }
            }, 
                async () =>
            {
                if ((short)Engine.ai_living_count(e6_flood_group_1) <= 0 && Engine.volume_test_objects(tv_e6_infinite1, Engine.players()))
                {
                    await Engine.sleep(10);
                    Engine.ai_place(e6_fld_inf1_a.guy4);
                }
            });
            Engine.game_save();
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task e6_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e6_trigger1, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(chapter_please));
            Engine.wake(new ScriptMethodReference(objective_riptide_set));
            Engine.game_save_cancel();
            Engine.data_mine_set_mission_segment("riptide_start");
            Engine.game_save();
            Engine.ai_place(e6_fld_inf1.Squad, 2);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(music_07b_03_start));
            Engine.wake(new ScriptMethodReference(e6_flood_attack_1));
            Engine.wake(new ScriptMethodReference(e6_flood_attack_2));
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_trigger1, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e6_start));
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e7_main));
            Engine.ai_disposable(e5_pro_inf1.Squad, true);
            Engine.ai_disposable(e5_fld_inf1.Squad, true);
            Engine.ai_disposable(e5_pro_bug1.Squad, true);
            Engine.ai_disposable(e5_pro_bug2_c.Squad, true);
            Engine.ai_disposable(e5_fld_inf2.Squad, true);
            Engine.ai_disposable(e5_fld_inf2_z.Squad, true);
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task e5_platform_c()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_c1, Engine.players()), 15);
            Engine.device_set_position(maus_platform_d.Entity, 0F);
            await Engine.sleep_until(async () => Engine.device_get_position(maus_platform_d.Entity) <= 0F, 10);
            Engine.device_set_position_immediate(gravity_bridge_c1.Entity, 1F);
            Engine.device_set_power(gravity_bridge_c1.Entity, 1F);
            await Engine.sleep(1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_c1, Engine.players()), 15);
            Engine.device_set_position(gravity_bridge_c1.Entity, 0F);
            await Engine.sleep_until(async () => Engine.device_get_position(gravity_bridge_c1.Entity) <= 0F, 10);
            Engine.device_set_power(gravity_bridge_c1.Entity, 0F);
            Engine.device_set_position_immediate(gravity_bridge_c1.Entity, 1F);
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task e5_platform_b()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_b1, Engine.players()), 15);
                Engine.device_set_position(maus_platform_d.Entity, 0F);
                await Engine.sleep_until(async () => Engine.device_get_position(maus_platform_d.Entity) <= 0F, 10);
                Engine.device_set_power(gravity_bridge_b1.Entity, 1F);
                await Engine.sleep(30);
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_b1, Engine.players()), 15);
                Engine.device_set_position(gravity_bridge_b1.Entity, 1F);
                await Engine.sleep_until(async () => Engine.device_get_position(gravity_bridge_b1.Entity) >= 1F, 15);
                Engine.device_set_power(gravity_bridge_b1.Entity, 0F);
                Engine.device_set_position_immediate(gravity_bridge_b1.Entity, 0F);
                return (short)Engine.structure_bsp_index() == 2;
            });
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task e5_platform_a2()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_a2, Engine.players()), 15);
            Engine.device_set_position(maus_platform_c.Entity, 0F);
            Engine.device_set_position_immediate(gravity_bridge_a2.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(maus_platform_c.Entity) <= 0F, 15);
            Engine.device_set_power(gravity_bridge_a2.Entity, 1F);
            await Engine.sleep(1);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_a2, Engine.players()), 15);
            Engine.device_set_position(gravity_bridge_a2.Entity, 0F);
            await Engine.sleep_until(async () => Engine.device_get_position(gravity_bridge_a2.Entity) <= 0F, 15);
            Engine.device_set_power(gravity_bridge_a2.Entity, 0F);
            Engine.device_set_position_immediate(gravity_bridge_a2.Entity, 1F);
            Engine.wake(new ScriptMethodReference(e5_platform_c));
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task e5_platform_a1()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_a1, Engine.players()), 15);
                Engine.device_set_power(gravity_bridge_a1.Entity, 1F);
                await Engine.sleep(30);
                await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_a1, Engine.players()), 15);
                Engine.device_set_position(gravity_bridge_a1.Entity, 1F);
                await Engine.sleep_until(async () => Engine.device_get_position(gravity_bridge_a1.Entity) >= 1F, 15);
                Engine.device_set_power(gravity_bridge_a1.Entity, 0F);
                Engine.device_set_position_immediate(gravity_bridge_a1.Entity, 0F);
                return (short)Engine.structure_bsp_index() == 2;
            });
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task e5_platform_begin()
        {
            Engine.game_save();
            Engine.device_set_power(gravity_bridge_a1.Entity, 0F);
            Engine.device_set_power(gravity_bridge_a2.Entity, 0F);
            Engine.device_set_power(gravity_bridge_b1.Entity, 0F);
            Engine.device_set_power(gravity_bridge_c1.Entity, 0F);
            Engine.device_set_position_immediate(gravity_bridge_a1.Entity, 0F);
            Engine.device_set_position_immediate(gravity_bridge_a2.Entity, 1F);
            Engine.device_set_position_immediate(gravity_bridge_b1.Entity, 0F);
            Engine.device_set_position_immediate(gravity_bridge_c1.Entity, 1F);
            Engine.object_create(lift_effect_b);
            await Engine.sleep(1);
            Engine.device_set_position(lift_effect_b.Entity, 1F);
            Engine.objects_attach(maus_platform_b.Entity, "lift_effect", lift_effect_b.Entity, "lift_effect");
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_platform_start, Engine.players()), 15);
            Engine.device_set_position(maus_platform_a.Entity, 0F);
            Engine.object_create(lift_effect_a);
            await Engine.sleep(1);
            Engine.objects_attach(maus_platform_a.Entity, "lift_effect", lift_effect_a.Entity, "lift_effect");
            await Engine.sleep_until(async () => Engine.device_get_position(maus_platform_a.Entity) <= 0F, 10);
            Engine.device_set_position(lift_effect_a.Entity, 1F);
            Engine.wake(new ScriptMethodReference(e5_platform_a1));
            Engine.wake(new ScriptMethodReference(e5_platform_b));
        }

        [ScriptMethod(214, Lifecycle.CommandScript)]
        public async Task e5_cs_leave()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_force_combat_status(3);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e5_leave/p0"));
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task e5_infinite_save()
        {
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task e5_fld_inf2_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_trigger3, Engine.players()), 15);
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                Engine.ai_place(e5_fld_inf2.Squad, 2);
            }
            else
            {
                Engine.ai_place(e5_fld_inf2_z.Squad);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_fld_inf2.Squad) <= 0 && (short)Engine.ai_living_count(e5_fld_inf2_z.Squad) <= 0);
            Engine.game_save();
        }

        [ScriptMethod(217, Lifecycle.Dormant)]
        public async Task e5_start_the_other_fight()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(maus_platform_d.Entity) <= 0F);
            Engine.wake(new ScriptMethodReference(e5_infinite_save));
            Engine.wake(new ScriptMethodReference(e5_fld_inf2_main));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_trigger_chase, Engine.players()));
            Engine.ai_place(e5_pro_bug2_c.Squad, (short)Engine.pin(5F - (float)Engine.ai_living_count(e5_buggers), 0F, 3F));
            Engine.ai_migrate(e5_pro_bug1.Squad, e5_pro_bug2_c.Squad);
            Engine.ai_set_orders(e5_buggers, e5_pro_bug2_c_attk);
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task e5_bugger_spawner()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_pro_bug1.Squad) <= 2);
            Engine.ai_place(e5_pro_bug2_c.Squad);
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task e5_start_the_fight()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_trigger2, Engine.players()), 15);
            Engine.ai_place(e5_pro_bug1.Squad, 6);
            Engine.wake(new ScriptMethodReference(e5_bugger_spawner));
            Engine.ai_place(e5_fld_inf1.Squad, 2);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_fld_inf1.Squad) <= 0, 15, 450);
            await Engine.sleep((short)Engine.random_range(30, 300));
            if (!(Engine.volume_test_objects(tv_e5_plat_b, Engine.players())) && !(Engine.volume_test_objects(tv_e5_plat_c, Engine.players())))
            {
                Engine.ai_place(e5_fld_inf1.Squad, 3);
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_fld_inf1.Squad) <= 0);
                await Engine.sleep((short)Engine.random_range(30, 150));
            }

            if (!(Engine.volume_test_objects(tv_e5_plat_b, Engine.players())) && !(Engine.volume_test_objects(tv_e5_plat_c, Engine.players())))
            {
                Engine.ai_place(e5_fld_inf1.Squad, 3);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(e5_fld_inf1.Squad) <= 0, 15, 450);
            Engine.ai_set_orders(e5_pro_inf1.Squad, e5_pro_inf1_leave);
            Engine.ai_set_orders(e5_fld_inf1.Squad, e5_pro_inf1_leave);
            await Engine.sleep(150);
            Engine.ai_set_orders(e5_buggers, e5_pro_bug1_attk_player);
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task e5_talking_points()
        {
            Engine.wake(new ScriptMethodReference(e1_dia_truth_holycity));
            await Engine.sleep(600);
            if (this.dialogue)
            {
                Engine.print("cortana: i'll do what i can to slow the launch sequence, but there's something inside the ship... a presence... that's fighting back.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2740"));
            await Engine.sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                Engine.print("cortana: for a covenant construct it's unusually formidable.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2750"));
            await Engine.sleep((short)(this.dialogue_pause * 5));
            if (Engine.volume_test_objects(tv_e5_trigger1, Engine.players()))
            {
                Engine.wake(new ScriptMethodReference(e5_dia_get_to_conduit));
            }
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task e5_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e5_trigger1, Engine.players()), 15);
            Engine.device_set_position_immediate(maus_platform_a.Entity, 1F);
            Engine.device_set_position_immediate(maus_platform_d.Entity, 1F);
            Engine.data_mine_set_mission_segment("plasma_chandelier");
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(e5_platform_begin));
            Engine.wake(new ScriptMethodReference(e5_start_the_fight));
            Engine.wake(new ScriptMethodReference(e5_start_the_other_fight));
            Engine.wake(new ScriptMethodReference(e5_talking_points));
            Engine.ai_place(e5_pro_inf1.Squad);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_trigger2, Engine.players()), 15);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_trigger1, Engine.players()), 15);
            Engine.wake(new ScriptMethodReference(e5_start));
            Engine.wake(new ScriptMethodReference(e6_main));
            Engine.ai_disposable(e1_fld_inf1.Squad, true);
            Engine.ai_disposable(e1_pro_inf1.Squad, true);
            Engine.ai_disposable(e1_fld_gitem1.Squad, true);
            Engine.ai_disposable(e1_fld_gitem2.Squad, true);
            Engine.ai_disposable(e1_pro_inf2.Squad, true);
            Engine.ai_disposable(e1_fld_inf2.Squad, true);
            Engine.ai_disposable(e1_fld_inf5.Squad, true);
            Engine.ai_disposable(e1_pro_inf3.Squad, true);
            Engine.ai_disposable(e1_fld_inf3.Squad, true);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task e2_cortana_intro()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e2_trigger1, Engine.players()), 15);
            Engine.game_save_cancel();
            await Engine.sleep(6);
            Engine.game_save_no_timeout();
            await Engine.sleep(150);
            if (this.dialogue)
            {
                Engine.print("cortana: i'll disable this lift once you reach the top. that'll slow them down... i hope!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2720"));
            Engine.wake(new ScriptMethodReference(objective_enter_clear));
            Engine.ai_disposable(e1_fld_inf1.Squad, true);
            Engine.ai_disposable(e1_fld_inf2.Squad, true);
            Engine.ai_disposable(e1_fld_inf3.Squad, true);
            Engine.ai_disposable(e1_fld_inf4.Squad, true);
            Engine.ai_disposable(e1_fld_inf5.Squad, true);
            Engine.ai_disposable(e1_pro_inf1.Squad, true);
            Engine.ai_disposable(e1_pro_inf2.Squad, true);
            Engine.ai_disposable(e1_pro_inf3.Squad, true);
        }

        [ScriptMethod(224, Lifecycle.CommandScript)]
        public async Task e1_cs_gitem1()
        {
            Engine.ai_set_blind(this.ai_current_actor, true);
            Engine.ai_set_deaf(this.ai_current_actor, true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("gitem1/p1"), Engine.GetReference<ISpatialPoint>("gitem1/p2"));
            Engine.ai_set_blind(this.ai_current_actor, false);
            Engine.ai_set_deaf(this.ai_current_actor, false);
        }

        [ScriptMethod(225, Lifecycle.CommandScript)]
        public async Task e1_cs_gitem2()
        {
            Engine.ai_set_blind(this.ai_current_actor, true);
            Engine.ai_set_deaf(this.ai_current_actor, true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_ignore_obstacles(true);
            Engine.cs_go_by(Engine.GetReference<ISpatialPoint>("gitem2/p1"), Engine.GetReference<ISpatialPoint>("gitem2/p2"));
            Engine.ai_set_blind(this.ai_current_actor, false);
            Engine.ai_set_deaf(this.ai_current_actor, false);
        }

        [ScriptMethod(226, Lifecycle.CommandScript)]
        public async Task e1_cs_freakout()
        {
            Engine.cs_movement_mode(this.ai_movement_flee);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_panic/p0")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_panic/p1")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_panic/p2")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_panic/p3")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_panic/p4")), 
                    async () => Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("e1_panic/p5")));
                return true;
            });
        }

        [ScriptMethod(227, Lifecycle.CommandScript)]
        public async Task e1_cs_teleport1()
        {
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("e1_drops/p1a"), Engine.GetReference<ISpatialPoint>("e1_drops/p1b"));
        }

        [ScriptMethod(228, Lifecycle.CommandScript)]
        public async Task e1_cs_teleport2()
        {
            Engine.cs_teleport(Engine.GetReference<ISpatialPoint>("e1_drops/p2a"), Engine.GetReference<ISpatialPoint>("e1_drops/p2b"));
        }

        [ScriptMethod(229, Lifecycle.CommandScript)]
        public async Task e1_cs_pelican2()
        {
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican2/p0"));
            this.g_e1_talk = 3;
            this.g_e1_pelican2_entering = true;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican2/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican2/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican2/p3"));
            Engine.ai_erase(e1_CS_pelican2.Squad);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task e1_carrier_drop()
        {
            Engine.object_set_velocity(Engine.ai_get_object(e1_fld_inf3.carrier0), -5F, 0F, 0F);
            Engine.object_set_velocity(Engine.ai_get_object(e1_fld_inf3.carrier1), -4F, 0F, 0F);
            await Engine.sleep(30);
            Engine.unit_set_current_vitality(Engine.ai_get_unit(e1_fld_inf3.carrier0), 0.1F, 0F);
            Engine.unit_set_current_vitality(Engine.ai_get_unit(e1_fld_inf3.carrier1), 0.1F, 0F);
        }

        [ScriptMethod(231, Lifecycle.CommandScript)]
        public async Task e1_cs_pelican1()
        {
            Engine.ai_place(e1_fld_inf3.carrier0);
            Engine.ai_place(e1_fld_inf3.carrier1);
            await Engine.sleep(1);
            Engine.objects_attach(Engine.ai_vehicle_get(this.ai_current_actor), "chief_rear", Engine.ai_get_object(e1_fld_inf3.carrier0), "");
            Engine.objects_attach(Engine.ai_vehicle_get(this.ai_current_actor), "pelican_e", Engine.ai_get_object(e1_fld_inf3.carrier1), "");
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican1/p0"));
            this.g_e1_talk = 1;
            this.g_e1_pelican1_entering = true;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican1/p3"));
            Engine.objects_detach(Engine.ai_vehicle_get(this.ai_current_actor), Engine.ai_get_object(e1_fld_inf3.carrier0));
            Engine.objects_detach(Engine.ai_vehicle_get(this.ai_current_actor), Engine.ai_get_object(e1_fld_inf3.carrier1));
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(e1_carrier_drop));
            this.g_e1_talk = 2;
            this.g_e1_pelican1_unloaded = true;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican1/p4"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("pelican1/p5"));
            Engine.ai_erase(e1_CS_pelican1.Squad);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task e1_infinite_save()
        {
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task e1_pro_inf3_place()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_trigger4, Engine.players()), 15);
            Engine.data_mine_set_mission_segment("turbolift_base");
            Engine.wake(new ScriptMethodReference(e1_infinite_save));
            Engine.ai_place(e1_pro_inf3.Squad);
            await Engine.sleep_until(async () => this.g_dialogue_counter == 1);
            this.g_e1_talk = 4;
            this.g_e1_pro_inf3_spawned = true;
            await Engine.sleep(150);
            this.g_e1_talk = 5;
            await Engine.sleep(150);
            this.g_e1_talk = 6;
            this.g_dialogue_counter = 2;
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                await Engine.sleep(450);
                if (Engine.volume_test_objects_all(tv_e1_trigger2, Engine.players()) || Engine.volume_test_objects_all(tv_e1_trigger4, Engine.players()))
                {
                    Engine.ai_place(e1_fld_inf5.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(e1_flood_master), 0F, 5F));
                }
            }
            else
            {
                await Engine.sleep(150);
                if (Engine.volume_test_objects_all(tv_e1_trigger2, Engine.players()) || Engine.volume_test_objects_all(tv_e1_trigger4, Engine.players()))
                {
                    Engine.ai_place(e1_fld_inf5.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(e1_flood_master), 0F, 5F));
                }

                await Engine.sleep(150);
                if (Engine.volume_test_objects_all(tv_e1_trigger2, Engine.players()) || Engine.volume_test_objects_all(tv_e1_trigger4, Engine.players()))
                {
                    Engine.ai_place(e1_fld_inf5.Squad, (short)Engine.pin(8F - (float)Engine.ai_living_count(e1_flood_master), 0F, 5F));
                }
            }
        }

        [ScriptMethod(234, Lifecycle.CommandScript)]
        public async Task run_grunt_run()
        {
            Engine.cs_movement_mode(this.ai_movement_flee);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("gitem1"));
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task e1_exterior_checkpoint()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_trigger4, Engine.players()) || (short)Engine.ai_nonswarm_count(e1_fld_inf1.Squad) <= 0 && (short)Engine.ai_nonswarm_count(e1_fld_inf2.Squad) <= 0 && (short)Engine.ai_nonswarm_count(e1_pro_inf1.Squad) <= 0 && (short)Engine.ai_nonswarm_count(e1_pro_inf2.Squad) <= 0, 15);
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task e1_pro_inf2_place()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_trigger2, Engine.players()), 15);
            Engine.ai_place(e1_pro_inf2.Squad, 2);
            Engine.ai_place(e1_fld_inf2.Squad, 1);
            if (await this.difficulty_legendary())
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(e1_flood_master) <= 5)
                    {
                        Engine.ai_place(e1_fld_inf1.guy2);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e1_flood_master) <= 5)
                    {
                        Engine.ai_place(e1_fld_inf1.guy3);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e1_flood_master) <= 5)
                    {
                        Engine.ai_place(e1_fld_inf1.guy4);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(e1_flood_master) <= 5)
                    {
                        Engine.ai_place(e1_fld_inf1.guy5);
                    }
                });
            }

            Engine.wake(new ScriptMethodReference(e1_exterior_checkpoint));
            Engine.wake(new ScriptMethodReference(e1_pro_inf3_place));
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task e1_gitem_2()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_gitem2, Engine.players()), 15);
            this.g_e1_git_check = true;
            Engine.begin_random(async () => Engine.ai_place(e1_fld_gitem2.guy1), 
                async () => await Engine.sleep(90), 
                async () => Engine.ai_place(e1_fld_gitem2.guy2), 
                async () => await Engine.sleep(90));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task e1_gitem_1()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_gitem1, Engine.players()), 15);
            if (!(this.g_e1_git_check))
            {
                Engine.begin_random(async () => Engine.ai_place(e1_fld_gitem1.guy1), 
                    async () => await Engine.sleep(90), 
                    async () => Engine.ai_place(e1_fld_gitem1.guy2), 
                    async () => await Engine.sleep(90));
            }

            Engine.sleep_forever(new ScriptMethodReference(e1_gitem_2));
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task e1_talking_points()
        {
            await Engine.sleep_until(async () => this.g_e1_pelican1_entering, 15, 450);
            if (this.dialogue)
            {
                Engine.print("cortana: flood-controlled dropships are touching down all over the city!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2680"));
            Engine.wake(new ScriptMethodReference(music_07b_01_start));
            await Engine.sleep(25);
            if (this.dialogue)
            {
                Engine.print("cortana: that creature beneath the library; that gravemind, used us! we were just a diversion. in amber clad was always it's intended vector!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2690"));
            Engine.game_save();
            await Engine.sleep_until(async () => this.g_e1_pelican2_entering || Engine.volume_test_objects(tv_e1_trigger4, Engine.players()), 15, 450);
            await Engine.sleep(25);
            if (this.dialogue)
            {
                Engine.print("cortana: there's a conduit connecting this tower to the ship. head back inside. i'll lead you to it.");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2710"));
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(objective_enter_set));
            Engine.wake(new ScriptMethodReference(music_07b_01_stop));
            Engine.wake(new ScriptMethodReference(music_07b_02_start));
            this.g_dialogue_counter = 1;
            await Engine.sleep_until(async () => this.g_e1_pro_inf3_spawned, 15);
            await Engine.sleep(150);
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_trigger2, Engine.players()), 15);
            if (this.dialogue)
            {
                Engine.print("cortana: we don't have time for this chief. truth's phantom is nearning the forerunner ship!");
            }

            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2700"));
            if (Engine.volume_test_objects_all(tv_e1_ledge_check, Engine.players()))
            {
                Engine.wake(new ScriptMethodReference(music_07b_02_start));
            }
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task e1_flashlight_training()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e1_trigger5, Engine.players()), 15);
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save());
            Engine.player_training_activate_flashlight();
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task e1_mercy()
        {
            Engine.object_create_anew(ledge_99);
            await Engine.sleep(10);
            Engine.scenery_animation_start_loop(ledge_99.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3892315785U), "mercy_dead");
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            Engine.game_save();
            Engine.data_mine_set_mission_segment("phantom_ledge");
            Engine.object_create_containing("ledge");
            Engine.wake(new ScriptMethodReference(e1_pro_inf2_place));
            Engine.wake(new ScriptMethodReference(e1_talking_points));
            Engine.wake(new ScriptMethodReference(e1_gitem_1));
            Engine.wake(new ScriptMethodReference(e1_gitem_2));
            Engine.wake(new ScriptMethodReference(e1_flashlight_training));
            Engine.wake(new ScriptMethodReference(e1_mercy));
            Engine.wake(new ScriptMethodReference(e5_main));
            Engine.wake(new ScriptMethodReference(e2_cortana_intro));
            Engine.ai_place(e1_pro_inf1.Squad);
            await Engine.sleep(6);
            Engine.units_set_current_vitality(Engine.ai_actors(e1_pro_inf1.Squad), 100F, 0F);
            Engine.ai_place(e1_fld_inf1.Squad, 4);
            Engine.ai_place(e1_CS_pelican1.pilot);
            await Engine.sleep(6);
            Engine.cs_run_command_script(e1_CS_pelican1.pilot, e1_cs_pelican1);
            await Engine.sleep(180);
            Engine.ai_place(e1_CS_pelican2.pilot);
            await Engine.sleep(6);
            Engine.cs_run_command_script(e1_CS_pelican2.pilot, e1_cs_pelican2);
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            Engine.switch_bsp(0);
            await this.cinematic_snap_to_white();
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    Engine.object_destroy(ledge_1.Entity);
                    Engine.object_destroy(ledge_97.Entity);
                    Engine.object_destroy(ledge_98.Entity);
                    Engine.object_destroy(ledge_99.Entity);
                    Engine.print("c07_intra1");
                    await this.c07_intra1();
                }

                await this.cinematic_skip_stop();
            }

            Engine.sound_suppress_ambience_update_on_revert();
            Engine.sound_class_set_gain("amb", 0F, 0);
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 1F, 15);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), player0_start);
            Engine.object_teleport(await this.player1(), player1_start);
            Engine.wake(new ScriptMethodReference(e1_main));
            await Engine.sleep(10);
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white_bars();
            Engine.wake(new ScriptMethodReference(chapter_purposes));
            await Engine.sleep_until(async () => Engine.volume_test_objects(tv_e12_end, Engine.players()), 16);
            Engine.object_cannot_take_damage(Engine.players());
            await this.cinematic_fade_to_white();
            Engine.ai_erase_all();
            Engine.object_teleport(await this.player0(), player0_end);
            Engine.object_teleport(await this.player1(), player1_end);
            Engine.object_hide(await this.player0(), true);
            Engine.object_hide(await this.player1(), true);
            await Engine.sleep(15);
            Engine.wake(new ScriptMethodReference(objective_exit_clear));
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    Engine.print("c07_outro");
                    await this.c07_outro();
                }

                await this.cinematic_skip_stop();
            }

            Engine.game_won();
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task start()
        {
            Engine.wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(245, Lifecycle.Startup)]
        public async Task mission_main()
        {
            Engine.ai_allegiance(player, human);
            Engine.ai_allegiance(covenant, prophet);
            Engine.game_can_use_flashlights(true);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cinematic_fld_inf0_0()
        {
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep(1);
            Engine.object_set_velocity(Engine.ai_get_object(this.ai_current_actor), 4F, 0F, 1.5F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("cinematic_fld_inf0/p0"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cinematic_fld_inf0_1()
        {
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.cs_enable_pathfinding_failsafe(true);
            await Engine.sleep(1);
            Engine.object_set_velocity(Engine.ai_get_object(this.ai_current_actor), 4F, 0F, 1F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("cinematic_fld_inf0/p1"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(248, Lifecycle.CommandScript)]
        public async Task cinematic_fld_inf1_0()
        {
            Engine.cs_movement_mode(this.ai_movement_combat);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("cinematic_fld_inf0/p2"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task _07_intra1_05_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3835691818U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3835691818U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\fp_covenant_carbine\\fp_covenant_carbine", 3807183223U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3837264706U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3782934533U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 19, false);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3839296353U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 7);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 0);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3841852296U), 0);
            await Engine.sleep(25);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 4, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 13, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3843228573U), 0);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 2);
            await Engine.sleep(51);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3844866998U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3841852296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3851944994U), 0);
            await Engine.sleep(26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 1);
            await Engine.sleep(103);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3852665901U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3843228573U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3852993586U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3839296353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await Engine.sleep(46);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task _07_intra1_06_predict()
        {
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3851944994U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3854173252U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 8);
            await Engine.sleep(119);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3844866998U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3851944994U), 2);
            await Engine.sleep(154);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            await Engine.sleep(121);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3852665901U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3843228573U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3852993586U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3839296353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3854173252U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            await Engine.sleep(160);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 8);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 3);
            await Engine.sleep(53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task _07_intra1_07_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3851944994U), 1);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 8);
            await Engine.sleep(239);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            await Engine.sleep(26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            await Engine.sleep(215);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3845325757U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3852665901U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3843228573U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3852993586U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3841852296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3839296353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            await Engine.sleep(104);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3851944994U), 1);
            await Engine.sleep(118);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3852665901U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3843228573U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3852993586U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3839296353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            await Engine.sleep(45);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3846177738U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3851944994U), 1);
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task _07_intra1_08_predict()
        {
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3855549529U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3856991343U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3856991343U), 1);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            await Engine.sleep(50);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 13, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await Engine.sleep(15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3852993586U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3852665901U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3843228573U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 1);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3840869241U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3841786759U), 1);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 1);
            await Engine.sleep(24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3823764084U), 0);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 22);
            await Engine.sleep(31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 31);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 38);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 41);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 42);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 12);
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task _07_outro_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3841852296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3845915590U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3855549529U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3858629768U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3858629768U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3858629768U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3858629768U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3858629768U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3858629768U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3858629768U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3859219601U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3859219601U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3857581176U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\magnum\\magnum", 3860006045U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3860464804U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3863217358U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3863217358U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_sack\\flood_sack", 3863807191U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_clump\\flood_clump", 3864397024U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_floor_clump_large\\flood_floor_clump_large", 3864462561U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_pod\\flood_pod", 3864528098U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3835691818U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3835691818U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\fp_covenant_carbine\\fp_covenant_carbine", 3807183223U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3839296353U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3858564231U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_tentacle_c\\flood_tentacle_c", 3864593635U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_tentacle_b\\flood_tentacle_b", 3864659172U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_tentacle_a\\flood_tentacle_a", 3864724709U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788177493U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcarrier\\floodcarrier", 3864790246U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcarrier\\floodcarrier", 3864790246U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\floodcarrier\\floodcarrier", 3864790246U), 2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3787980882U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3787980882U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3787980882U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3787980882U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3787980882U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3787980882U), 5);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3865052394U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit\\conduit", 3866297597U), 0);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit_ring\\conduit_ring", 3866559745U), 0);
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task _07_outro_02_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 9, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 20, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 5, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 18, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3842245518U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3841852296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3842573203U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3868591392U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit_ring\\conduit_ring", 3866559745U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            await Engine.sleep(59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3855549529U), 0);
            await Engine.sleep(20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3868591392U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship\\forerunner_ship", 3868853540U), 0);
            await Engine.sleep(142);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3854369863U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit_ring\\conduit_ring", 3866559745U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3837854539U), 0);
            await Engine.sleep(49);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 8, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3838182224U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3841852296U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship\\forerunner_ship", 3868853540U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3868591392U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task _07_outro_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3869902132U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3870229817U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3786211383U), 0);
            await Engine.sleep(160);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3842114444U), 0);
        }
    }
}