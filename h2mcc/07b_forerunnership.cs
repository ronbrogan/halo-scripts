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
        public async Task _07_intra1_05_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_05_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _07_intra1_06_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_06_predict));
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _07_intra1_07_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_07_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _07_intra1_08_predict_stub()
        {
            wake(new ScriptMethodReference(_07_intra1_08_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task _07_outro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_07_outro_01_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task _07_outro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_07_outro_02_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task _07_outro_03_predict_stub()
        {
            wake(new ScriptMethodReference(_07_outro_03_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task cinematic_pelican_unload()
        {
            ai_place(cinematic_fld_inf0.form0);
            await sleep(8);
            ai_place(cinematic_fld_inf0.form1);
            await sleep(4);
            ai_place(cinematic_fld_inf0.form0);
            await sleep(10);
            ai_place(cinematic_fld_inf0.form1);
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task cinematic_pelican_runby()
        {
            ai_place(cinematic_fld_inf1.form0);
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task c07_intra1_score_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_05_mus", 3836281651U), default(IGameObject), 1F);
            print("c07_intra1 score 05");
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_05()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_05_fol", 3836347188U), default(IGameObject), 1F);
            print("c07_intra1 foley 05 start");
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c07_intra1_05_dof_01()
        {
            time_code_reset();
            await sleep(127);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0F, 0F, 0F, 0.75F, 0.75F, 0F);
            print("rack focus");
            time_code_reset();
            await sleep(60);
            cinematic_screen_effect_set_depth_of_field(1F, 0F, 0.75F, 0.5F, 0.75F, 0F, 0.5F);
            print("rack focus");
            time_code_reset();
            await sleep(68);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c07_intra1_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(23F, 74F, 0.258824F, 0.270588F, 0.368627F);
            cinematic_lighting_set_secondary_light(-40F, 276F, 0.407843F, 0.345098F, 0.317647F);
            cinematic_lighting_set_ambient_light(0.0431373F, 0.0470588F, 0.0666667F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(mercy.Entity, true);
            object_uses_cinematic_lighting(infection_01.Entity, true);
            object_uses_cinematic_lighting(throne_mercy.Entity, true);
            object_uses_cinematic_lighting(phantom_01.Entity, true);
            object_uses_cinematic_lighting(phantom_02.Entity, true);
            object_uses_cinematic_lighting(phantom_03.Entity, true);
        }

        [ScriptMethod(37, Lifecycle.Static)]
        public async Task c07_intra1_05_setup()
        {
            wake(new ScriptMethodReference(c07_intra1_score_05));
            wake(new ScriptMethodReference(c07_intra1_foley_05));
            object_create_anew(chief);
            object_create_anew(mercy);
            object_create_anew(infection_01);
            object_create_anew(throne_mercy);
            object_create_anew(phantom_01);
            object_create_anew(phantom_02);
            object_create_anew(phantom_03);
            cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(mercy.Entity, true);
            object_cinematic_lod(infection_01.Entity, true);
            object_cinematic_lod(throne_mercy.Entity, true);
            object_cinematic_lod(phantom_01.Entity, true);
            object_cinematic_lod(phantom_02.Entity, true);
            object_cinematic_lod(phantom_03.Entity, true);
            wake(new ScriptMethodReference(c07_intra1_05_dof_01));
            wake(new ScriptMethodReference(c07_intra1_cinematic_light_01));
            object_destroy(ledge_1.Entity);
        }

        [ScriptMethod(38, Lifecycle.Static)]
        public async Task c07_intra1_05_cleanup()
        {
            object_destroy_containing("phantom");
        }

        [ScriptMethod(39, Lifecycle.Static)]
        public async Task c07_intra1_scene_05()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("forerunnership_intra1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._07_intra1_05_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\music\\c07_intra1_05_mus", 3836281651U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_05_fol", 3836347188U));
            await sleep(this.prediction_offset);
            await this.c07_intra1_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3836412725U), "07_intra1_05", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3836478262U), "chief_05", false, anchor_intra1.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3836543799U), "mercy_05", false, anchor_intra1.Entity);
            custom_animation_relative(infection_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3836674873U), "infection01_05", false, anchor_intra1.Entity);
            custom_animation_relative(throne_mercy.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\gravity_throne\\animations\\07_intra1\\07_intra1", 3836740410U), "throne_mercy_05", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3836805947U), "phantom1_05", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_02.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3836805947U), "phantom2_05", false, anchor_intra1.Entity);
            custom_animation_relative(phantom_03.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\07_intra1\\07_intra1", 3836805947U), "phantom3_05", false, anchor_intra1.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intra1_06_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_06_fol", 3836871484U));
            await sleep((short)camera_time());
            await this.c07_intra1_05_cleanup();
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_06()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_06_fol", 3836871484U), default(IGameObject), 1F);
            print("c07_intra1 foley 06 start");
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c07_2080_mas()
        {
            await sleep(45);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2080_mas", 3836937021U), chief.Entity, 1F);
            cinematic_subtitle("c07_2080_mas", 2.5F);
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c07_2090_pom()
        {
            await sleep(180);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2090_pom", 3837002558U), mercy.Entity, 1F);
            cinematic_subtitle("c07_2090_pom", 3F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task c07_2100_pom()
        {
            await sleep(283);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2100_pom", 3837068095U), mercy.Entity, 1F);
            cinematic_subtitle("c07_2100_pom", 4F);
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c07_2101_pom()
        {
            await sleep(451);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2101_pom", 3837133632U), mercy.Entity, 1F);
        }

        [ScriptMethod(45, Lifecycle.Dormant)]
        public async Task c07_2110_cor()
        {
            await sleep(566);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2110_cor", 3837199169U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2110_cor", 2F);
            unit_set_emotional_state(cortana.Entity, "shocked", 0.25F, 0);
            print("cortana - shocked .25 0");
        }

        [ScriptMethod(46, Lifecycle.Dormant)]
        public async Task c07_2120_cor()
        {
            await sleep(621);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2120_cor", 3837264706U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2120_cor", 4F);
        }

        [ScriptMethod(47, Lifecycle.Dormant)]
        public async Task c07_intra1_06_dof_01()
        {
            time_code_reset();
            await sleep(121);
            print("rack focus");
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(0.4F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            time_code_reset();
            await sleep(153);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task c07_intra1_06_fov_01()
        {
            await sleep(396);
            print("fov change: 60 -> 70 over 0 ticks");
            camera_set_field_of_view(70F, 0);
            await sleep(53);
            print("fov change: 70 -> 60 over 0 ticks");
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task infection_pop()
        {
            await sleep(510);
            print("infection pop");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\flood_infection\\body_depleted", 3837330243U), infection_02.Entity, "");
            await sleep(1);
            object_destroy(infection_02.Entity);
        }

        [ScriptMethod(50, Lifecycle.Static)]
        public async Task c07_intra1_06_setup()
        {
            object_create_anew(cortana);
            object_cinematic_lod(cortana.Entity, true);
            object_create_anew(infection_02);
            object_cinematic_lod(infection_02.Entity, true);
            object_uses_cinematic_lighting(infection_02.Entity, true);
            object_create_anew(cortana_base);
            wake(new ScriptMethodReference(c07_intra1_foley_06));
            wake(new ScriptMethodReference(c07_2080_mas));
            wake(new ScriptMethodReference(c07_2090_pom));
            wake(new ScriptMethodReference(c07_2100_pom));
            wake(new ScriptMethodReference(c07_2101_pom));
            wake(new ScriptMethodReference(c07_2110_cor));
            wake(new ScriptMethodReference(c07_2120_cor));
            wake(new ScriptMethodReference(infection_pop));
            wake(new ScriptMethodReference(c07_intra1_06_dof_01));
            wake(new ScriptMethodReference(c07_intra1_06_fov_01));
        }

        [ScriptMethod(51, Lifecycle.Static)]
        public async Task c07_intra1_06_cleanup()
        {
            object_destroy_containing("infection");
            object_destroy(cortana_base.Entity);
        }

        [ScriptMethod(52, Lifecycle.Static)]
        public async Task c07_intra1_scene_06()
        {
            await this.c07_intra1_06_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3836412725U), "07_intra1_06", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3836478262U), "chief_06", false, anchor_intra1.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3836543799U), "mercy_06", false, anchor_intra1.Entity);
            custom_animation_relative(infection_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3836674873U), "infection01_06", false, anchor_intra1.Entity);
            custom_animation_relative(infection_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\flood_infection\\07_intra1\\07_intra1", 3836674873U), "infection02_06", false, anchor_intra1.Entity);
            custom_animation_relative(throne_mercy.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\gravity_throne\\animations\\07_intra1\\07_intra1", 3836740410U), "throne_mercy_06", false, anchor_intra1.Entity);
            await sleep(556);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_25", 3838116687U), cortana_base.Entity, "marker");
            custom_animation_relative(cortana.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_intra1\\07_intra1", 3839165279U), "cortana_06", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intra1_07_predict_stub();
            await sleep((short)camera_time());
            await this.c07_intra1_06_cleanup();
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c07_2130_cor()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2130_cor", 3839296353U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2130_cor", 3F);
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c07_2140_cor()
        {
            await sleep(110);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2140_cor", 3839361890U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2140_cor", 1F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task c07_2150_mas()
        {
            await sleep(150);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2150_mas", 3839427427U), chief.Entity, 1F);
            cinematic_subtitle("c07_2150_mas", 5F);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task c07_2160_cor()
        {
            await sleep(297);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2160_cor", 3839492964U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2160_cor", 6F);
            unit_set_emotional_state(cortana.Entity, "annoyed", 0.5F, 0);
            print("cortana - annoyed .5 0");
        }

        [ScriptMethod(57, Lifecycle.Dormant)]
        public async Task c07_2170_cor()
        {
            await sleep(490);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2170_cor", 3839558501U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2170_cor", 3F);
        }

        [ScriptMethod(58, Lifecycle.Dormant)]
        public async Task c07_2180_cor()
        {
            await sleep(622);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2180_cor", 3839624038U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2180_cor", 3F);
        }

        [ScriptMethod(59, Lifecycle.Dormant)]
        public async Task c07_2190_cor()
        {
            await sleep(710);
            unit_set_emotional_state(cortana.Entity, "disappointed", 0.5F, 60);
            print("cortana - disappointed .5 60");
            await sleep(13);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_2190_cor", 3839689575U), cortana.Entity, 1F);
            cinematic_subtitle("c07_2190_cor", 1F);
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c07_intra1_07_fov_01()
        {
            await sleep(414);
            print("fov change: 60 -> 26 over 0 ticks");
            camera_set_field_of_view(26F, 0);
            await sleep(70);
            print("fov change: 26 -> 60 over 0 ticks");
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(61, Lifecycle.Static)]
        public async Task c07_intra1_07_setup()
        {
            wake(new ScriptMethodReference(c07_2130_cor));
            wake(new ScriptMethodReference(c07_2140_cor));
            wake(new ScriptMethodReference(c07_2150_mas));
            wake(new ScriptMethodReference(c07_2160_cor));
            wake(new ScriptMethodReference(c07_2170_cor));
            wake(new ScriptMethodReference(c07_2180_cor));
            wake(new ScriptMethodReference(c07_2190_cor));
            wake(new ScriptMethodReference(c07_intra1_07_fov_01));
        }

        [ScriptMethod(62, Lifecycle.Static)]
        public async Task c07_intra1_07_cleanup()
        {
            object_destroy_containing("mercy");
        }

        [ScriptMethod(63, Lifecycle.Static)]
        public async Task c07_intra1_scene_07()
        {
            await this.c07_intra1_07_setup();
            cinematic_set_near_clip_distance(0.05F);
            print("setting near clip distance to .05");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3836412725U), "07_intra1_07", default(IUnit), anchor_flag_intra1);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3836478262U), "chief_07", false, anchor_intra1.Entity);
            custom_animation_relative(cortana.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_intra1\\07_intra1", 3839165279U), "cortana_07", false, anchor_intra1.Entity);
            custom_animation_relative(mercy.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\07_intra1\\07_intra1", 3836543799U), "mercy_07", false, anchor_intra1.Entity);
            custom_animation_relative(throne_mercy.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\gravity_throne\\animations\\07_intra1\\07_intra1", 3836740410U), "throne_mercy_07", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_intra1_08_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_08_fol", 3839755112U));
            await sleep((short)camera_time());
            await this.c07_intra1_07_cleanup();
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task c07_intra1_foley_08()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_intra1\\foley\\c07_intra1_08_fol", 3839755112U), default(IGameObject), 1F);
            print("c07_intra1 foley 08 start");
        }

        [ScriptMethod(65, Lifecycle.Dormant)]
        public async Task pelican_crash_01()
        {
            await sleep(38);
            print("crash 1");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit_small", 3839820649U), pelican_01.Entity, "hardpoint_right");
        }

        [ScriptMethod(66, Lifecycle.Dormant)]
        public async Task pelican_crash_02()
        {
            await sleep(49);
            print("crash 2");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3840410482U), pelican_01.Entity, "johnson");
        }

        [ScriptMethod(67, Lifecycle.Dormant)]
        public async Task pelican_crash_03()
        {
            await sleep(101);
            print("crash 3");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\generic\\explosions_air\\human_vehicle_air_hit", 3840410482U), pelican_01.Entity, "pelican_p_l05");
        }

        [ScriptMethod(68, Lifecycle.Dormant)]
        public async Task c07_intra1_08_fov_01()
        {
            await sleep(99);
            print("fov change: 36 -> 60 over 0 ticks");
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task flood_pelican_unload()
        {
            await sleep(145);
            print("ai flood unload");
            await this.cinematic_pelican_unload();
            await this.cinematic_pelican_runby();
        }

        [ScriptMethod(70, Lifecycle.Static)]
        public async Task c07_intra1_08_setup()
        {
            wake(new ScriptMethodReference(c07_intra1_foley_08));
            object_destroy_containing("offending_crate");
            object_create_anew(pelican_01);
            object_cinematic_lod(pelican_01.Entity, true);
            object_uses_cinematic_lighting(pelican_01.Entity, true);
            wake(new ScriptMethodReference(c07_intra1_08_fov_01));
            wake(new ScriptMethodReference(pelican_crash_01));
            wake(new ScriptMethodReference(pelican_crash_02));
            wake(new ScriptMethodReference(pelican_crash_03));
            wake(new ScriptMethodReference(flood_pelican_unload));
        }

        [ScriptMethod(71, Lifecycle.Static)]
        public async Task c07_intra1_08_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(cortana.Entity);
            object_destroy(pelican_01.Entity);
        }

        [ScriptMethod(72, Lifecycle.Static)]
        public async Task c07_intra1_scene_08()
        {
            await this.c07_intra1_08_setup();
            cinematic_set_near_clip_distance(0.06F);
            print("resetting near clip distance to .06");
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_intra1\\07_intra1", 3836412725U), "07_intra1_08", default(IUnit), anchor_flag_intra1);
            camera_set_field_of_view(26F, 0);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_intra1\\07_intra1", 3836478262U), "chief_08", false, anchor_intra1.Entity);
            custom_animation_relative(cortana.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_intra1\\07_intra1", 3839165279U), "cortana_08", false, anchor_intra1.Entity);
            custom_animation_relative(pelican_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\07_intra1\\07_intra1", 3840607093U), "pelican_08", false, anchor_intra1.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            sound_class_set_gain("amb", 0F, 15);
            await sleep(15);
            await this.c07_intra1_08_cleanup();
        }

        [ScriptMethod(73, Lifecycle.Static)]
        public async Task c07_intra1()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("vehicle", 0F, 0);
            sound_class_set_gain("amb", 0F, 0);
            switch_bsp_by_name(GetReference<IBsp>("high_5"));
            await sleep(1);
            await this.c07_intra1_scene_05();
            await this.c07_intra1_scene_06();
            await this.c07_intra1_scene_07();
            await this.c07_intra1_scene_08();
            sound_class_set_gain("vehicle", 1F, 15);
            sound_class_set_gain("amb", 1F, 15);
            await sleep(15);
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c07_outro_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\music\\c07_outro_01_mus", 3840672630U), default(IGameObject), 1F);
            print("c07_outro score 01 start");
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task c07_outro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_01_fol", 3840738167U), default(IGameObject), 1F);
            print("c07_outro foley 01 start");
        }

        [ScriptMethod(76, Lifecycle.Dormant)]
        public async Task c07_outro_shake()
        {
            await sleep(89);
            print("shake start");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            await sleep(70);
            player_effect_stop(0F);
            print("shake stop");
        }

        [ScriptMethod(77, Lifecycle.Dormant)]
        public async Task c07_outro_shake2()
        {
            time_code_reset();
            await sleep(290);
            print("shake start");
            player_effect_set_max_rotation(0F, 1F, 1F);
            player_effect_start(0.25F, 0F);
            await sleep(60);
            player_effect_stop(1F);
            print("shake stop");
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c07_outro_dof_01()
        {
            time_code_reset();
            print("rack focus");
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(20F, 0F, 0F, 0F, 1F, 1F, 0F);
            await sleep(89);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c07_outro_dof_02()
        {
            time_code_reset();
            await sleep(289);
            print("rack focus");
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(20F, 2F, 2F, 0F, 0F, 0F, 0F);
            await sleep(106);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task c07_outro_fov_01()
        {
            await sleep(357);
            print("fov change: 60 -> 12 over 15 ticks");
            camera_set_field_of_view(12F, 15);
            await sleep(46);
            print("fov change: 12 -> 60 over 0 ticks");
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c07_outro_cinematic_lighting_01()
        {
            cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            rasterizer_bloom_override(true);
            rasterizer_bloom_override_threshold(0.3F);
            rasterizer_bloom_override_brightness(0.5F);
            object_uses_cinematic_lighting(chief_outro.Entity, true);
            object_uses_cinematic_lighting(alcove.Entity, true);
            object_uses_cinematic_lighting(cap.Entity, true);
            object_uses_cinematic_lighting(ring_01.Entity, true);
            object_uses_cinematic_lighting(ring_02.Entity, true);
            object_uses_cinematic_lighting(ring_03.Entity, true);
            object_uses_cinematic_lighting(ring_04.Entity, true);
            object_uses_cinematic_lighting(ring_05.Entity, true);
            object_uses_cinematic_lighting(ring_06.Entity, true);
            object_uses_cinematic_lighting(ring_06.Entity, true);
            object_uses_cinematic_lighting(ring_08.Entity, true);
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task ship_initial_blast()
        {
            await sleep(188);
            print("effect - initial blast");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale5", 3840803704U), forerunner_ship.Entity, "thruster");
        }

        [ScriptMethod(83, Lifecycle.Static)]
        public async Task c07_outro_problem_actors()
        {
            print("problem actors");
            object_create_anew(chief_outro);
            object_cinematic_lod(chief_outro.Entity, true);
            object_create_anew(conduit);
            object_create_anew(ring_01);
            object_create_anew(ring_02);
            object_create_anew(ring_03);
            object_create_anew(ring_04);
            object_create_anew(ring_05);
            object_create_anew(ring_06);
            object_create_anew(ring_07);
            object_create_anew(ring_08);
            object_cinematic_lod(conduit.Entity, true);
            object_cinematic_lod(ring_01.Entity, true);
            object_cinematic_lod(ring_02.Entity, true);
            object_cinematic_lod(ring_03.Entity, true);
            object_cinematic_lod(ring_04.Entity, true);
            object_cinematic_lod(ring_05.Entity, true);
            object_cinematic_lod(ring_06.Entity, true);
            object_cinematic_lod(ring_07.Entity, true);
            object_cinematic_lod(ring_08.Entity, true);
            object_cinematic_visibility(conduit.Entity, true);
        }

        [ScriptMethod(84, Lifecycle.Static)]
        public async Task c07_outro_01_setup()
        {
            object_create_anew(forerunner_ship);
            object_create_anew(cap);
            object_create_anew(alcove);
            object_cinematic_visibility(cap.Entity, true);
            object_cinematic_lod(forerunner_ship.Entity, true);
            object_cinematic_lod(alcove.Entity, true);
            wake(new ScriptMethodReference(c07_outro_score_01));
            wake(new ScriptMethodReference(c07_outro_foley_01));
            wake(new ScriptMethodReference(ship_initial_blast));
            wake(new ScriptMethodReference(c07_outro_dof_01));
            wake(new ScriptMethodReference(c07_outro_dof_02));
            wake(new ScriptMethodReference(c07_outro_shake));
            wake(new ScriptMethodReference(c07_outro_shake2));
            wake(new ScriptMethodReference(c07_outro_fov_01));
            wake(new ScriptMethodReference(c07_outro_cinematic_lighting_01));
        }

        [ScriptMethod(85, Lifecycle.Static)]
        public async Task c07_outro_01_cleanup()
        {
            object_destroy(conduit.Entity);
            object_destroy(cap.Entity);
            object_destroy(ring_05.Entity);
            object_destroy(ring_06.Entity);
            object_destroy(ring_07.Entity);
            object_destroy(ring_08.Entity);
        }

        [ScriptMethod(86, Lifecycle.Static)]
        public async Task c07_outro_scene_01()
        {
            sound_class_set_gain("amb", 0F, 30);
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("forerunnership_outro");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this.c07_outro_problem_actors();
            await this._07_outro_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\music\\c07_outro_01_mus", 3840672630U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_01_fol", 3840738167U));
            await sleep(this.prediction_offset);
            await this.c07_outro_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_outro\\07_outro", 3841524611U), "07_outro_01", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief_outro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_outro\\07_outro", 3841590148U), "chief_01", false, anchor_outro1.Entity);
            scenery_animation_start_relative(forerunner_ship.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\07_outro\\07_outro", 3841655685U), "forerunner_ship_01", anchor_outro1.Entity);
            scenery_animation_start_relative(alcove.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\07_outro\\07_outro", 3841721222U), "alcove_01", anchor_outro1.Entity);
            scenery_animation_start_relative(cap.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_cap\\07_outro\\07_outro", 3841786759U), "conduit_cap_01", anchor_outro1.Entity);
            scenery_animation_start_relative(conduit.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit\\07_outro\\07_outro", 3841852296U), "conduit_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring01_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring02_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring03_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring04_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_05.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring05_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_06.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring06_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_07.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring07_01", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_08.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring08_01", anchor_outro1.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_outro_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_02_fol", 3841983370U));
            await sleep((short)camera_time());
            await this.c07_outro_01_cleanup();
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task c07_outro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_02_fol", 3841983370U), default(IGameObject), 1F);
            print("c07_outro foley 02 start");
        }

        [ScriptMethod(88, Lifecycle.Dormant)]
        public async Task c07_9010_cor()
        {
            await sleep(38);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9010_cor", 3842048907U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c07_9010_cor", 2F);
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task c07_9020_mas()
        {
            await sleep(104);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9020_mas", 3842114444U), chief_outro.Entity, 1F);
            cinematic_subtitle("c07_9020_mas", 2F);
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task c07_9030_cor()
        {
            await sleep(147);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9030_cor", 3842179981U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c07_9030_cor", 2F);
            unit_set_emotional_state(cortana_outro.Entity, "pensive", 0.25F, 0);
            print("cortana - pensive .25 0");
        }

        [ScriptMethod(91, Lifecycle.Dormant)]
        public async Task c07_9040_cor()
        {
            await sleep(211);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\cinematic\\c07_9040_cor", 3842245518U), cortana_outro.Entity, 1F);
            cinematic_subtitle("c07_9040_cor", 2F);
            unit_set_emotional_state(cortana_outro.Entity, "disappointed", 0.75F, 60);
            print("cortana - disappointed .75 60");
        }

        [ScriptMethod(92, Lifecycle.Dormant)]
        public async Task chief_sparks()
        {
            await sleep(17);
            print("chief sparks");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\07\\chief_sparks", 3842311055U), chief_outro.Entity, "body");
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task c07_outro_fov_02()
        {
            await sleep(99);
            print("fov change: 36 -> 60 over 0 ticks");
            camera_set_field_of_view(60F, 0);
        }

        [ScriptMethod(94, Lifecycle.Dormant)]
        public async Task c07_outro_cinematic_lighting_02()
        {
            cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task ship_take_off_01()
        {
            await sleep(271);
            print("effect - take off 01");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale12", 3842376592U), forerunner_ship.Entity, "thruster");
            object_create_anew(takeoff_dust);
        }

        [ScriptMethod(96, Lifecycle.Static)]
        public async Task c07_outro_03_problem_actors()
        {
            print("problem actors");
            object_create_anew(matte_high_charity);
            object_create_anew(matte_substance);
            object_create_anew_containing("outro_fleet");
        }

        [ScriptMethod(97, Lifecycle.Static)]
        public async Task c07_outro_02_setup()
        {
            object_create_anew(cortana_outro);
            object_cinematic_lod(cortana_outro.Entity, true);
            object_create_anew(bloom_quad);
            wake(new ScriptMethodReference(c07_outro_foley_02));
            wake(new ScriptMethodReference(c07_9010_cor));
            wake(new ScriptMethodReference(c07_9020_mas));
            wake(new ScriptMethodReference(c07_9030_cor));
            wake(new ScriptMethodReference(c07_9040_cor));
            wake(new ScriptMethodReference(chief_sparks));
            wake(new ScriptMethodReference(ship_take_off_01));
            wake(new ScriptMethodReference(c07_outro_cinematic_lighting_02));
        }

        [ScriptMethod(98, Lifecycle.Static)]
        public async Task c07_outro_02_cleanup()
        {
            object_destroy(takeoff_dust.Entity);
            object_destroy(ring_01.Entity);
            object_destroy(ring_02.Entity);
            object_destroy(ring_03.Entity);
            object_destroy(ring_04.Entity);
            object_destroy(bloom_quad.Entity);
        }

        [ScriptMethod(99, Lifecycle.Static)]
        public async Task c07_outro_scene_02()
        {
            await this.c07_outro_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_outro\\07_outro", 3841524611U), "07_outro_02", default(IUnit), anchor_flag_outro1);
            custom_animation_relative(chief_outro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\07_outro\\07_outro", 3841590148U), "chief_02", false, anchor_outro1.Entity);
            custom_animation_relative(cortana_outro.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\07_outro\\07_outro", 3842573203U), "cortana_02", false, anchor_outro1.Entity);
            scenery_animation_start_relative(forerunner_ship.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\07_outro\\07_outro", 3841655685U), "forerunner_ship_02", anchor_outro1.Entity);
            scenery_animation_start_relative(alcove.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship_alcove\\07_outro\\07_outro", 3841721222U), "alcove_02", anchor_outro1.Entity);
            scenery_animation_start_relative(cap.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_cap\\07_outro\\07_outro", 3841786759U), "conduit_cap_02", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_01.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring01_02", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_02.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring02_02", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_03.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring03_02", anchor_outro1.Entity);
            scenery_animation_start_relative(ring_04.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\covenant\\conduit_ring\\07_outro\\07_outro", 3841917833U), "ring04_02", anchor_outro1.Entity);
            scenery_animation_start_relative(bloom_quad.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\special\\bloom_quad\\07_outro\\07_outro", 3842638740U), "bloom_quad_02", anchor_outro1.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._07_outro_03_predict_stub();
            await this.c07_outro_03_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_03_fol", 3842704277U));
            cinematic_screen_effect_start(true);
            await sleep((short)((float)camera_time() - 5));
            cinematic_screen_effect_set_crossfade(1.5F);
            print("crossfade");
            await sleep(5);
            await this.c07_outro_02_cleanup();
        }

        [ScriptMethod(100, Lifecycle.Dormant)]
        public async Task c07_outro_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\07_highcharity\\c07_outro\\foley\\c07_outro_03_fol", 3842704277U), default(IGameObject), 1F);
            print("c07_outro foley 03 start");
        }

        [ScriptMethod(101, Lifecycle.Dormant)]
        public async Task c07_outro_cinematic_lighting_03()
        {
            cinematic_lighting_set_primary_light(-41F, 270F, 0.25F, 0.32F, 0.52F);
            cinematic_lighting_set_secondary_light(58F, 78F, 0.21F, 0.11F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            object_uses_cinematic_lighting(forerunner_ship.Entity, true);
        }

        [ScriptMethod(102, Lifecycle.Dormant)]
        public async Task ship_take_off_02()
        {
            await sleep(0);
            print("effect - take off 02");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale01", 3842769814U), forerunner_ship.Entity, "thruster");
        }

        [ScriptMethod(103, Lifecycle.Dormant)]
        public async Task ship_take_off_03()
        {
            time_code_reset();
            await sleep(111);
            print("effect - take off 02");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\cinematics\\forerunner_ship\\initial_take_off_scale04", 3843031962U), forerunner_ship.Entity, "thruster");
        }

        [ScriptMethod(104, Lifecycle.Dormant)]
        public async Task effect_slipspace()
        {
            await sleep(159);
            print("effect - slipspace");
            object_create_anew(slipspace);
        }

        [ScriptMethod(105, Lifecycle.Static)]
        public async Task c07_outro_03_setup()
        {
            wake(new ScriptMethodReference(c07_outro_foley_03));
            wake(new ScriptMethodReference(ship_take_off_02));
            wake(new ScriptMethodReference(ship_take_off_03));
            wake(new ScriptMethodReference(effect_slipspace));
            wake(new ScriptMethodReference(c07_outro_cinematic_lighting_02));
        }

        [ScriptMethod(106, Lifecycle.Static)]
        public async Task c07_outro_03_cleanup()
        {
            cinematic_screen_effect_stop();
            object_destroy(forerunner_ship.Entity);
            object_destroy(matte_high_charity.Entity);
            object_destroy(matte_substance.Entity);
            object_destroy_containing("outro_fleet");
        }

        [ScriptMethod(107, Lifecycle.Static)]
        public async Task c07_outro_scene_03()
        {
            await this.c07_outro_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\07_outro\\07_outro", 3841524611U), "07_outro_03", default(IUnit), anchor_flag_outro2);
            scenery_animation_start_relative(forerunner_ship.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\forerunner_ship\\07_outro\\07_outro", 3841655685U), "forerunner_ship_03", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_high_charity.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\07_outro\\07_outro", 3843294110U), "high_charity_03", anchor_outro2.Entity);
            scenery_animation_start_relative(matte_substance.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\substance_space\\07_outro\\07_outro", 3843359647U), "substance_03", anchor_outro2.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - 30));
            fade_out(0F, 0F, 0F, 30);
            await sleep(30);
            await sleep(90);
            await this.c07_outro_03_cleanup();
        }

        [ScriptMethod(108, Lifecycle.Static)]
        public async Task c07_outro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            sound_class_set_gain("vehicle", 0F, 0);
            sound_class_set_gain("amb", 0F, 0);
            switch_bsp_by_name(GetReference<IBsp>("high_9_cinematic"));
            await sleep(1);
            await this.c07_outro_scene_01();
            await this.c07_outro_scene_02();
            await this.c07_outro_scene_03();
            sound_class_set_gain("vehicle", 1F, 1);
            sound_class_set_gain("amb", 1F, 1);
            rasterizer_bloom_override(false);
        }

        [ScriptMethod(109, Lifecycle.Stub)]
        public async Task c07_intra2()
        {
            print("c07_intra2");
        }

        [ScriptMethod(110, Lifecycle.CommandScript)]
        public async Task cs_expand_cortana()
        {
            object_set_scale(ai_get_object(this.ai_current_actor), 0.01F, 0);
            object_cannot_take_damage(ai_get_object(this.ai_current_actor));
            ai_disregard(ai_get_object(this.ai_current_actor), true);
            await sleep(5);
            unit_set_emotional_state(ai_get_unit(this.ai_current_actor), "disappointed", 0.5F, 0);
            object_dynamic_simulation_disable(ai_get_object(this.ai_current_actor), true);
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off_65", 4256111459U), ai_get_object(this.ai_current_actor), "effect");
            await sleep(1);
            object_hide(ai_get_object(this.ai_current_actor), false);
            object_set_scale(ai_get_object(this.ai_current_actor), 0.65F, 20);
            cs_face_player(true);
            sleep_forever();
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task music_07b_01_start()
        {
            print("music 07b_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_01", 4256176996U), default(IGameObject), 1F);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task music_07b_01_stop()
        {
            print("music 07b_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_01", 4256176996U));
        }

        [ScriptMethod(113, Lifecycle.Static)]
        public async Task test()
        {
            objects_attach(sanctum_lift.Entity, "switch", sanctum_lift_control.Entity, "");
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task music_07b_02_start()
        {
            print("music 07b_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_02", 4256570218U), default(IGameObject), 1F);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task music_07b_03_start()
        {
            print("music 07b_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_03", 4256832366U), default(IGameObject), 1F);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task music_07b_03_stop()
        {
            print("music 07b_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_03", 4256832366U));
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task music_07b_04_start()
        {
            print("music 07b_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_04", 4257487736U), default(IGameObject), 1F);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task music_07b_04_stop()
        {
            print("music 07b_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_04", 4257487736U));
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task music_07b_05_start()
        {
            print("music 07b_05 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_05", 4257880958U), default(IGameObject), 1F);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task music_07b_05_stop()
        {
            print("music 07b_05 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_05", 4257880958U));
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task music_07b_06_start()
        {
            print("music 07b_06 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_06", 4258274180U), default(IGameObject), 1F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task music_07b_06_stop()
        {
            print("music 07b_06 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\07b_forerunnership\\07b_music\\07b_06", 4258274180U));
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task chapter_purposes()
        {
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task chapter_please()
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

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task chapter_sanctified()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_3);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task chapter_feeling()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_4);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task objective_enter_set()
        {
            await sleep(30);
            print("new objective set:");
            print("fight your way back inside the mausoleum-tower.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task objective_enter_clear()
        {
            print("objective complete:");
            print("you got inside the tower");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task objective_riptide_set()
        {
            await sleep(30);
            print("new objective set:");
            print("survive the rising tide of the flood.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task objective_riptide_clear()
        {
            print("objective complete:");
            print("you have reached the inner sanctum of the covenant homeworld");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task objective_exit_set()
        {
            await sleep(30);
            print("new objective set:");
            print("find a way onto the forerunner ship.");
            objectives_show_up_to(2);
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task objective_exit_clear()
        {
            print("objective complete:");
            print("ride that pipe.");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task gen_dia_civil_war_a()
        {
            if (this.dialogue)
            {
                print("cortana: brute and elite ships are engaging one-another all around high charity!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2880"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task gen_dia_civil_war_b()
        {
            if (this.dialogue)
            {
                print("cortana: the jackals and the drones have declared themselves the servants of the brutes. the hunters have have sworn allegiance to the elites.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2890"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task gen_dia_civil_war_c()
        {
            if (this.dialogue)
            {
                print("cortana: the grunts seem to be neutral, or, at least afraid to announce which side they support. except for truth, the prophets aren't saying a word.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2900"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task gen_dia_locking_doors_behind()
        {
            if (this.dialogue)
            {
                print("cortana: if it makes you feel any better, i'm locking the doors behind you. should keep some of the flood off your back.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2840"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task e1_dia_truth_holycity()
        {
            if (this.dialogue)
            {
                print("truth: shall we let the flood consume our holy-city? turn high charity into another of their wretched hives?");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4191885223U), e5_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4191885223U), e5_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4191885223U), e5_speaker5.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4191885223U), e5_speaker0.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0280_pot", 4191885223U), e5_speaker1.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e5_speaker3.Entity, "0280"));
            await sleep(30);
            if (this.dialogue)
            {
                print("truth: no enemy has ever withstood our might - the flood too shall fall!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4191360927U), e5_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4191360927U), e5_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4191360927U), e5_speaker5.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4191360927U), e5_speaker0.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0200_pot", 4191360927U), e5_speaker1.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e5_speaker3.Entity, "0200"));
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task e5_dia_get_to_conduit()
        {
            if (this.dialogue)
            {
                print("cortana: no time to admire the view. truth's phantom has reached the forerunner ship!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2730"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task e8_dia_security_lock()
        {
            if (this.dialogue)
            {
                print("cortana: the security systems in this part of the tower are particularly robust. hang on while i override the lock.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2760"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_a()
        {
            if (this.dialogue)
            {
                print("cortana: hang on. this will just take a minute.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2780"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(141, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_b()
        {
            if (this.dialogue)
            {
                print("cortana: standby while i break the lock.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2790"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_c()
        {
            if (this.dialogue)
            {
                print("cortana: i'm working as quickly as possible.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2800"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_d()
        {
            if (this.dialogue)
            {
                print("cortana: almost have it.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2810"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(144, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_e()
        {
            if (this.dialogue)
            {
                print("cortana: just a little more time...");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2820"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task e8_dia_unlock_f()
        {
            if (this.dialogue)
            {
                print("cortana: a few more seconds...");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2830"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task e7_dia_filtration_systems()
        {
            if (this.dialogue)
            {
                print("cortana: flood spores have contaminated the city's life-support infrastructure - the filtration systems are overloading!");
            }

            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2850_cor", 4198438923U)));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task e10_dia_truth_theparasite()
        {
            if (this.dialogue)
            {
                print("truth: the parasite did not defeat the forerunners, and it shall not defeat us!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2910"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task e10_dia_truth_grippedbyfear()
        {
            if (this.dialogue)
            {
                print("truth: whosoever is gripped by fear, take heed: i am the prophet of truth, and i am not afraid!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0210"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task e10_dia_truth_noblemercy()
        {
            if (this.dialogue)
            {
                print("truth: noble mercy is here, at my side - his wise counsel ever in my ears!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0270"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task e10_dia_civilwar_a()
        {
            if (this.dialogue)
            {
                print("cortana: brute and elite ships are engaging one-another all around high charity!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2880"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task e10_dia_civilwar_b()
        {
            if (this.dialogue)
            {
                print("cortana: the jackals and drones have declared themselves the servants of the brutes. the hunters have sworn allegiance to the elites.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2890"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task e10_dia_civilwar_c()
        {
            if (this.dialogue)
            {
                print("cortana: the grunts seem to be neutral, or at least afraid to announce which side they support. except for truth the prophets aren't saying a word.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2900"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(153, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_a()
        {
            if (this.dialogue)
            {
                print("cortana: stopping truth - that's all that matters!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2980"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task e12_dia_truth_becomegods()
        {
            if (this.dialogue)
            {
                print("truth: now is the time of our unworlding - the moment we shall all become as gods!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0330"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(155, Lifecycle.Dormant)]
        public async Task e12_dia_truth_final()
        {
            if (this.dialogue)
            {
                print("truth: if you would falter, know this: one final effort is all that remains!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "0260"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(156, Lifecycle.Dormant)]
        public async Task e12_dia_go_conduit_a()
        {
            if (this.dialogue)
            {
                print("cortana: get to the conduit. i'll keep it attached to the ship as long as i can.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2940"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task e12_dia_go_conduit_b()
        {
            if (this.dialogue)
            {
                print("cortana: i've lost control of the conduit! it's breaking away from the ship!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2950"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(158, Lifecycle.Dormant)]
        public async Task e12_dia_end_b()
        {
            if (this.dialogue)
            {
                print("cortana: you know the plan. you've got to stop truth. i've got to handle the index. go!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "3030"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_flood()
        {
            if (this.dialogue)
            {
                print("cortana: forget about the flood! you've got to get aboard!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2960"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_brutes()
        {
            if (this.dialogue)
            {
                print("cortana: ignore the brutes! get into the conduit!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2970"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_d()
        {
            if (this.dialogue)
            {
                print("cortana: i can't go with you!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "3010"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(162, Lifecycle.Dormant)]
        public async Task e12_dia_end_a()
        {
            if (this.dialogue)
            {
                print("cortana: i have to stay here, chief!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "3020"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task e12_dia_end_c()
        {
            if (this.dialogue)
            {
                print("cortana: we're out of time, chief! into the conduit!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "3040"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(164, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_c()
        {
            if (this.dialogue)
            {
                print("cortana: chief! leave me!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "3000"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(165, Lifecycle.Dormant)]
        public async Task e12_dia_tickle_b()
        {
            if (this.dialogue)
            {
                print("cortana: jump in chief, now!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2990"));
            await sleep(this.dialogue_pause);
        }

        [ScriptMethod(166, Lifecycle.Dormant)]
        public async Task e12_pelican_flyby()
        {
            ai_place(e12_CS_pelican1.Squad);
            ai_place(e12_CS_banshee1.Squad);
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task e12_cs_pelican1()
        {
            cs_vehicle_speed(0.8F);
            cs_fly_by(GetReference<ISpatialPoint>("pelican3/p0"));
            cs_fly_by(GetReference<ISpatialPoint>("pelican3/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("pelican3/p2"));
            cs_fly_to(GetReference<ISpatialPoint>("pelican3/p3"));
            cs_fly_by(GetReference<ISpatialPoint>("pelican3/p4"));
            cs_fly_by(GetReference<ISpatialPoint>("pelican3/p5"));
            ai_erase(e12_CS_pelican1.Squad);
            ai_erase(e12_CS_banshee1.Squad);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task e12_tickle()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_tickle, players()), 15);
            print("placing cortana...");
            ai_place(cortana1.Squad);
            wake(new ScriptMethodReference(music_07b_03_stop));
            await sleep_until(async () => this.g_dialogue_counter == 8);
            await sleep(90);
            if (this.dialogue)
            {
                print("cortana: i knew the covenant was good at re-purposing forerunner technology, but this is amazing. they've been using the forerunner ship's engines as an energy-source for the city!");
            }

            if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
            {
                await sleep(ai_play_line_on_object(default(IGameObject), "2920"));
            }
            else
            {
                await sleep(ai_play_line_at_player(cortana1.Squad, "2920"));
            }

            await sleep((short)(this.dialogue_pause * 2));
            if (this.dialogue)
            {
                print("cortana: the ship isn't so much launching as it is disengaging - uncoupling itself from high charity's power grid!");
            }

            if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
            {
                await sleep(ai_play_line_on_object(default(IGameObject), "2930"));
            }
            else
            {
                await sleep(ai_play_line_at_player(cortana1.Squad, "2930"));
            }

            await sleep_until(async () => this.g_e12_started);
            if (this.dialogue)
            {
                print("cortana: stopping truth - that's all that matters!");
            }

            if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
            {
                await sleep(ai_play_line_on_object(default(IGameObject), "2980"));
            }
            else
            {
                await sleep(ai_play_line_at_player(cortana1.Squad, "2980"));
            }

            await sleep((short)(this.dialogue_pause * 6));
            if (this.dialogue)
            {
                print("truth: now is the time of our unworlding - the moment we shall all become as gods!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker5.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker6.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker7.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker8.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e12_speaker0.Entity, "0330"));
            await sleep(this.dialogue_pause);
            await sleep_until(async () => this.g_e12_final_battle_started);
            if (this.dialogue)
            {
                print("cortana: you know the plan. you've got to stop truth. i've got to handle the index. go!");
            }

            if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
            {
                await sleep(ai_play_line_on_object(default(IGameObject), "3030"));
            }
            else
            {
                await sleep(ai_play_line_at_player(cortana1.Squad, "3030"));
            }

            await sleep(this.dialogue_pause);
            await sleep_until(async () => this.g_e12_final_battle_mid);
            if (this.dialogue)
            {
                print("truth: if you would falter, know this: one final effort is all that remains!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4191754149U), e12_speaker1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4191754149U), e12_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4191754149U), e12_speaker3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0260_pot", 4191754149U), e12_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker5.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker6.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker7.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0330_pot", 4192212908U), e12_speaker8.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e12_speaker0.Entity, "0260"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: forget about the flood! you've got to get aboard!");
            }

            if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
            {
                await sleep(ai_play_line_on_object(default(IGameObject), "2960"));
            }
            else
            {
                await sleep(ai_play_line_at_player(cortana1.Squad, "2960"));
            }

            await sleep(this.dialogue_pause);
            await sleep_until(async () => volume_test_objects(tv_e12_final_dialogue, players()));
            if (random_range(0, 2) == 1 ? true : false)
            {
                if (this.dialogue)
                {
                    print("cortana: i can't go with you!");
                }

                if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
                {
                    await sleep(ai_play_line_on_object(default(IGameObject), "3010"));
                }
                else
                {
                    await sleep(ai_play_line_at_player(cortana1.Squad, "3010"));
                }

                await sleep(this.dialogue_pause_long);
            }
            else
            {
                if (this.dialogue)
                {
                    print("cortana: i have to stay here, chief!");
                }

                if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
                {
                    await sleep(ai_play_line_on_object(default(IGameObject), "3020"));
                }
                else
                {
                    await sleep(ai_play_line_at_player(cortana1.Squad, "3020"));
                }

                await sleep(this.dialogue_pause_long);
            }

            await sleep(90);
            await sleep_until(async () => volume_test_objects(tv_e12_final_dialogue, players()));
            if (random_range(0, 2) == 1 ? true : false)
            {
                if (this.dialogue)
                {
                    print("cortana: we're out of time, chief! into the conduit!");
                }

                if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
                {
                    await sleep(ai_play_line_on_object(default(IGameObject), "3040"));
                }
                else
                {
                    await sleep(ai_play_line_at_player(cortana1.Squad, "3040"));
                }

                await sleep(this.dialogue_pause_long);
            }
            else
            {
                if (this.dialogue)
                {
                    print("cortana: chief! leave me!");
                }

                if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
                {
                    await sleep(ai_play_line_on_object(default(IGameObject), "3000"));
                }
                else
                {
                    await sleep(ai_play_line_at_player(cortana1.Squad, "3000"));
                }

                await sleep(this.dialogue_pause_long);
            }

            await sleep(20);
            await sleep_until(async () => volume_test_objects(tv_e12_final_dialogue, players()));
            if (this.dialogue)
            {
                print("cortana: jump in chief, now!");
            }

            if (objects_distance_to_object(players(), ai_get_object(cortana1.Squad)) > 7F)
            {
                await sleep(ai_play_line_on_object(default(IGameObject), "2990"));
            }
            else
            {
                await sleep(ai_play_line_at_player(cortana1.Squad, "2990"));
            }
        }

        [ScriptMethod(169, Lifecycle.Static)]
        public async Task e12_safe_to_spawn_flood()
        {
            await sleep_until(async () => (short)ai_nonswarm_count(e12_flood_rush) <= 4, 15);
        }

        [ScriptMethod(170, Lifecycle.Dormant)]
        public async Task e12_final_battle()
        {
            print("final battle started!!!!!!");
            this.g_e12_final_battle_started = true;
            if (this.g_e12_side)
            {
                begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_right.Squad), 
                    async () => await sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf3_right.Squad), 
                    async () => await sleep(1));
                this.g_e12_talk = 2;
                begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf1_right.Squad), 
                    async () => await sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_right.Squad), 
                    async () => await sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf3_right.Squad), 
                    async () => await sleep(1));
                wake(new ScriptMethodReference(e12_pelican_flyby));
                print("final battle midpoint...");
                this.g_e12_final_battle_mid = true;
                await this.e12_safe_to_spawn_flood();
                begin_random(async () => sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e12_howler1.Entity, 1F), 
                    async () => ai_place(e12_fld_inf4.guy1), 
                    async () => ai_place(e12_fld_inf4.guy2), 
                    async () => ai_place(e12_fld_inf4.guya), 
                    async () => sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e12_howler2.Entity, 1F), 
                    async () => ai_place(e12_fld_inf4.guy3), 
                    async () => ai_place(e12_fld_inf4.guy4), 
                    async () => ai_place(e12_fld_inf4.guyz));
                begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf1_right.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_right.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf3_right.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_left.Squad));
                ai_set_orders(e12_flood_rush, e12_get_the_player);
                await sleep_until(async () => !(volume_test_objects_all(tv_e12_conduit_check, ai_actors(all_enemies))));
                this.g_e12_talk = 3;
                this.g_e12_go = true;
            }
            else
            {
                begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_left.Squad), 
                    async () => await sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf3_left.Squad), 
                    async () => await sleep(1));
                this.g_e12_talk = 2;
                begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf1_left.Squad), 
                    async () => await sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_left.Squad), 
                    async () => await sleep(1), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf3_left.Squad), 
                    async () => await sleep(1));
                wake(new ScriptMethodReference(e12_pelican_flyby));
                print("final battle midpoint...");
                this.g_e12_final_battle_mid = true;
                await this.e12_safe_to_spawn_flood();
                begin_random(async () => sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e12_howler1.Entity, 1F), 
                    async () => ai_place(e12_fld_inf4.guy1), 
                    async () => ai_place(e12_fld_inf4.guy2), 
                    async () => sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e12_howler2.Entity, 1F), 
                    async () => ai_place(e12_fld_inf4.guy3), 
                    async () => ai_place(e12_fld_inf4.guy4));
                begin_random(async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf1_left.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_left.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf3_left.Squad), 
                    async () => await this.e12_safe_to_spawn_flood(), 
                    async () => ai_place(e12_fld_inf2_right.Squad));
                ai_set_orders(e12_flood_rush, e12_get_the_player);
                await sleep_until(async () => !(volume_test_objects_all(tv_e12_conduit_check, ai_actors(all_enemies))));
                this.g_e12_talk = 3;
                this.g_e12_go = true;
            }

            print("final battle ended...");
            this.g_e12_final_battle_ended = true;
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task e12_start()
        {
            await sleep_until(async () => volume_test_objects(tv_e12_trigger1, players()), 5);
            wake(new ScriptMethodReference(chapter_feeling));
            data_mine_set_mission_segment("last_room");
            game_save_cancel();
            await sleep(1);
            game_save_no_timeout();
            this.g_e12_talk = 1;
            this.g_e12_started = true;
            ai_disposable(e10_pro_inf1.Squad, true);
            ai_disposable(e10_pro_inf1_a.Squad, true);
            ai_disposable(e10_cov_inf11.Squad, true);
            ai_disposable(e10_fld_inf1.Squad, true);
            if (random_range(0, 2) == 1 ? true : false)
            {
                object_create_containing("e12_left");
                ai_place(e12_pro_inf2_left1.Squad);
                ai_place(e12_pro_inf3_end.Squad);
                ai_place(e12_pro_inf4_left1.Squad, 1);
                wake(new ScriptMethodReference(e12_final_battle));
            }
            else
            {
                object_create_containing("e12_right");
                ai_place(e12_pro_inf2_right1.Squad);
                ai_place(e12_pro_inf3_end.Squad);
                ai_place(e12_pro_inf4_right1.Squad, 1);
                this.g_e12_side = true;
                wake(new ScriptMethodReference(e12_final_battle));
            }

            await sleep(120);
        }

        [ScriptMethod(172, Lifecycle.Dormant)]
        public async Task e12_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_trigger5, players()), 15);
            await sleep_until(async () => volume_test_objects(tv_e10_trigger6, players()), 15);
            wake(new ScriptMethodReference(e12_start));
            ai_disposable(e10_fld_swarm1.Squad, true);
            ai_disposable(e10_cov_inf11.Squad, true);
            ai_disposable(e10_pro_inf1_a.Squad, true);
            ai_disposable(e10_pro_inf1.Squad, true);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task e10_sanctum2()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_trigger6, players()), 15);
            wake(new ScriptMethodReference(music_07b_06_stop));
            wake(new ScriptMethodReference(e12_tickle));
            game_save_no_timeout();
            data_mine_set_mission_segment("council_chamber");
            await sleep_until(async () => this.g_dialogue_counter == 7);
            await sleep_until(async () => volume_test_objects(tv_e10_screen, players()), 10);
            if (this.dialogue)
            {
                print("cortana: brute and elite ships are engaging one-another all around high charity!");
            }

            if (volume_test_objects(tv_e10_screen, players()))
            {
                await sleep(ai_play_line_on_object(default(IGameObject), "2880"));
                await sleep(this.dialogue_pause);
            }

            await sleep_until(async () => volume_test_objects(tv_e10_screen, players()), 10);
            if (this.dialogue)
            {
                print("cortana: the jackals and drones have declared themselves the servants of the brutes. the hunters have sworn allegiance to the elites.");
            }

            if (volume_test_objects(tv_e10_screen, players()))
            {
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2890_cor", 4198701071U)));
                await sleep((short)(this.dialogue_pause * 2));
            }

            await sleep_until(async () => volume_test_objects(tv_e10_screen, players()), 10);
            if (this.dialogue)
            {
                print("cortana: the grunts seem to be neutral, or at least afraid to announce which side they support. except for truth the prophets aren't saying a word.");
            }

            if (volume_test_objects(tv_e10_screen, players()))
            {
                await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2900_cor", 4198766608U)));
                this.g_e10_talk = 9;
            }

            this.g_dialogue_counter = 8;
        }

        [ScriptMethod(174, Lifecycle.Dormant)]
        public async Task e10_tickle()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_trigger9, players()) || this.g_e10_talk == 9);
            sleep_forever(new ScriptMethodReference(e10_sanctum2));
            wake(new ScriptMethodReference(music_07b_06_stop));
            if (!(this.g_e10_talk == 9))
            {
                await sleep(150);
            }

            if (this.dialogue)
            {
                print("cortana: i'm running out of options, chief. i can't stall the launch sequence much longer. the next lift will take you up to the conduit. hurry!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2910"));
            await sleep(this.dialogue_pause);
            wake(new ScriptMethodReference(objective_exit_set));
            this.g_dialogue_counter = 8;
            if (this.g_e10_talk == 9)
            {
                device_set_position(e10_tube_door.Entity, 1F);
                device_closes_automatically_set(e10_tube_door.Entity, false);
            }
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task e10_end_open()
        {
            await sleep_until(async () => this.g_e10_move_on == true && volume_test_objects(tv_e10_trigger5, players()));
            game_save();
            wake(new ScriptMethodReference(e10_sanctum2));
            wake(new ScriptMethodReference(e10_tickle));
            device_operates_automatically_set(e10_sanctum_door.Entity, true);
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task e10_superflood()
        {
            if (await this.difficulty_legendary())
            {
                ai_set_active_camo(this.ai_current_actor, false);
            }
        }

        [ScriptMethod(177, Lifecycle.Dormant)]
        public async Task e10_storm()
        {
            ai_place(e10_pro_inf1.Squad);
            ai_place(e10_pro_inf1_a.Squad);
            if (random_range(0, 2) == 1 ? true : false)
            {
                ai_place(e10_cov_inf11.Squad, 2);
            }
            else
            {
                ai_place(e10_cov_inf11.Squad, 3);
            }

            await sleep_until(async () => (float)ai_strength(e10_pro_inner_sanctum) <= 0.8F, 15, 600);
            begin_random(async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 1)
                {
                    ai_place(e10_fld_inf1.guy1);
                    ai_place(e10_fld_inf1.guy2);
                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 1)
                {
                    ai_place(e10_fld_inf1.guy4);
                    ai_place(e10_fld_inf1.guy5);
                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 1)
                {
                    ai_place(e10_fld_inf1.guy3);
                    ai_place(e10_fld_inf1.guy6);
                    await sleep(1);
                }
            });
            await sleep_until(async () => (float)ai_strength(e10_pro_inner_sanctum) <= 0.5F, 15, 600);
            this.g_e10_talk = 1;
            begin_random(async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 2)
                {
                    ai_place(e10_fld_inf1.guy1);
                    ai_place(e10_fld_inf1.guy2);
                    ai_place(e10_fld_inf1.guy3);
                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 2)
                {
                    ai_place(e10_fld_inf1.guy4);
                    ai_place(e10_fld_inf1.guy5);
                    ai_place(e10_fld_inf1.guy6);
                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 2)
                {
                    ai_place(e10_fld_inf1.guy1);
                    ai_place(e10_fld_inf1.guy5);
                    ai_place(e10_fld_inf1.guy6);
                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 2)
                {
                    ai_place(e10_fld_inf1.guy2);
                    ai_place(e10_fld_inf1.guy3);
                    ai_place(e10_fld_inf1.guy4);
                    await sleep(1);
                }
            });
            await sleep_until(async () => (float)ai_strength(e10_pro_inner_sanctum) <= 0.3F, 15, 600);
            begin_random(async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 3)
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler1.Entity, 1F);
                    ai_place(e10_fld_inf1.guy1);
                    ai_place(e10_fld_inf1.guy2);
                    ai_place(e10_fld_inf1.guy3);
                    await sleep((short)random_range(90, 150));
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler3.Entity, 1F);
                    ai_place(e10_fld_inf1.guy7);
                    ai_place(e10_fld_inf1.guy8);
                    ai_place(e10_fld_inf1.guy9);
                    if (await this.difficulty_legendary())
                    {
                        ai_set_orders(e10_fld_inf1.Squad, e10_fld_storm_z);
                    }

                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 3)
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler2.Entity, 1F);
                    ai_place(e10_fld_inf1.guy4);
                    ai_place(e10_fld_inf1.guy5);
                    ai_place(e10_fld_inf1.guy6);
                    await sleep((short)random_range(90, 150));
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler4.Entity, 1F);
                    ai_place(e10_fld_inf1.guy10);
                    ai_place(e10_fld_inf1.guy11);
                    ai_place(e10_fld_inf1.guy12);
                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 3)
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler1.Entity, 1F);
                    ai_place(e10_fld_inf1.guy1);
                    ai_place(e10_fld_inf1.guy2);
                    ai_place(e10_fld_inf1.guy3);
                    await sleep((short)random_range(90, 150));
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler4.Entity, 1F);
                    ai_place(e10_fld_inf1.guy10);
                    ai_place(e10_fld_inf1.guy11);
                    ai_place(e10_fld_inf1.guy12);
                    await sleep(1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e10_flood_storm) <= 3)
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler2.Entity, 1F);
                    ai_place(e10_fld_inf1.guy4);
                    ai_place(e10_fld_inf1.guy5);
                    ai_place(e10_fld_inf1.guy6);
                    await sleep((short)random_range(90, 150));
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e10_howler3.Entity, 1F);
                    ai_place(e10_fld_inf1.guy7);
                    ai_place(e10_fld_inf1.guy8);
                    ai_place(e10_fld_inf1.guy9);
                    await sleep(1);
                }
            });
            this.g_e10_move_on = true;
            game_save();
            await sleep(150);
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task e10_infinite_save()
        {
            game_save_no_timeout();
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task e10_sanctum_lift_recall()
        {
            await sleep_until(async () => device_get_position(sanctum_lift.Entity) <= 1F, 10);
            await sleep_until(async () =>
            {
                if (volume_test_objects(tv_sanctum_lift, players()))
                {
                    device_set_position(sanctum_lift.Entity, 1F);
                }

                return false;
            }, 31);
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task e10_sanctum_lift_crusher()
        {
            await sleep_until(async () =>
            {
                if (device_get_position(sanctum_lift.Entity) >= 0.955F)
                {
                    kill_volume_enable(kill_sanctum_crusher);
                }
                else
                {
                    kill_volume_disable(kill_sanctum_crusher);
                }

                return false;
            }, 3);
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task e10_battle()
        {
            await sleep_until(async () => volume_test_objects(tv_e10_trigger2, players()), 15);
            wake(new ScriptMethodReference(e10_infinite_save));
            data_mine_set_mission_segment("inner_sanctum");
            wake(new ScriptMethodReference(e10_storm));
            await sleep(90);
            wake(new ScriptMethodReference(chapter_sanctified));
            wake(new ScriptMethodReference(objective_riptide_clear));
            ai_disposable(e8_pro_inf1.Squad, true);
            ai_disposable(e8_fld_inf1.Squad, true);
            await sleep_until(async () => device_get_position(sanctum_lift.Entity) <= 1F, 10);
            await sleep_until(async () => volume_test_objects(tv_e10_trigger1, players()), 15);
            device_set_position(sanctum_lift.Entity, 0F);
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task e10_talking_points()
        {
            await sleep_until(async () => this.g_e10_talk == 1 && this.g_dialogue_counter == 6);
            if (this.dialogue)
            {
                print("truth: this crisis will not be the end of us! it is but one, last hurdle before the journey and salvation!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4191164316U), e10_speaker1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4191164316U), e10_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4191164316U), e10_speaker3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4191164316U), e10_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0170_pot", 4191164316U), e10_speaker5.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e10_speaker0.Entity, "0170"));
            await sleep(this.dialogue_pause);
            this.g_dialogue_counter = 7;
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task e10_start()
        {
            wake(new ScriptMethodReference(e10_battle));
            wake(new ScriptMethodReference(e10_end_open));
            wake(new ScriptMethodReference(e10_talking_points));
            await sleep_until(async () => volume_test_objects_all(tv_e10_trigger1, players()), 15);
            await sleep((short)random_range(150, 240));
            await sleep((short)random_range(90, 150));
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task e10_music_aux()
        {
            await sleep_until(async () => device_get_position(sanctum_lift.Entity) >= 1F, 10);
            await sleep_until(async () => device_get_position(sanctum_lift.Entity) < 1F, 10);
            wake(new ScriptMethodReference(music_07b_06_start));
            await sleep(2);
            game_save();
        }

        [ScriptMethod(185, Lifecycle.Dormant)]
        public async Task e10_load()
        {
            device_set_position_immediate(sanctum_lift.Entity, 1F);
            wake(new ScriptMethodReference(e10_sanctum_lift_recall));
            wake(new ScriptMethodReference(e10_sanctum_lift_crusher));
            wake(new ScriptMethodReference(e10_music_aux));
            objects_attach(sanctum_lift.Entity, "switch", sanctum_lift_control.Entity, "");
            await sleep_until(async () => volume_test_objects(tv_e9_end, players()), 15);
            game_save_cancel();
            await sleep(6);
            game_save();
            wake(new ScriptMethodReference(e10_start));
        }

        [ScriptMethod(186, Lifecycle.Dormant)]
        public async Task e10_key()
        {
            if (!(await this.difficulty_legendary()))
            {
                sleep_forever();
            }

            object_create(key);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4164425220U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4164425220U)));
            ice_cream_flavor_stock(11);
        }

        [ScriptMethod(187, Lifecycle.Dormant)]
        public async Task e10_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_trigger1, players()), 15);
            wake(new ScriptMethodReference(e10_load));
            wake(new ScriptMethodReference(e10_key));
            wake(new ScriptMethodReference(e12_main));
            ai_disposable(e9_fld_inf11.Squad, true);
        }

        [ScriptMethod(188, Lifecycle.Dormant)]
        public async Task e9_start()
        {
            await sleep_until(async () => volume_test_objects(tv_e9_trigger1, players()), 15);
            data_mine_set_mission_segment("hallway_attack");
            if ((bool)game_safe_to_save())
            {
                game_save();
            }

            await sleep(5);
            if ((bool)game_safe_to_save())
            {
                if (volume_test_objects_all(tv_e9_trigger1, players()))
                {
                    begin_random(async () =>
                    {
                        if ((short)ai_living_count(e9_fld_inf11.Squad) <= 0)
                        {
                            await sleep_until(async () => volume_test_objects(tv_e9_surprise, players()));
                            ai_place(e9_fld_inf11.guy1);
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e9_howler1.Entity, 1F);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)ai_living_count(e9_fld_inf11.Squad) <= 0)
                        {
                            ai_place(e9_fld_inf11.guy2);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)ai_living_count(e9_fld_inf11.Squad) <= 0)
                        {
                            ai_place(e9_fld_inf11.guy3);
                        }
                    });
                }
            }
        }

        [ScriptMethod(189, Lifecycle.Dormant)]
        public async Task e9_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e7_trigger2, players()), 15);
            game_save();
            await sleep_until(async () => volume_test_objects(tv_e8_end, players()), 15);
            wake(new ScriptMethodReference(e9_start));
            wake(new ScriptMethodReference(e10_main));
            ai_disposable(e8_fld_inf1.Squad, true);
            ai_disposable(e8_fld_swarm1.Squad, true);
            ai_disposable(e8_pro_inf1.Squad, true);
        }

        [ScriptMethod(190, Lifecycle.Dormant)]
        public async Task e8_end_open()
        {
            await sleep_until(async () => volume_test_objects(tv_e8_end, players()), 15);
            await sleep_until(async () => this.g_dialogue_counter == 5, 15);
            wake(new ScriptMethodReference(music_07b_05_stop));
            await sleep(120);
            if (this.dialogue)
            {
                print("cortana: apparently these are the prophet hierarch's private quarters - their inner sanctum.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2770"));
            this.g_dialogue_counter = 6;
            game_save();
        }

        [ScriptMethod(191, Lifecycle.Dormant)]
        public async Task e8_infinite_save()
        {
            game_save_no_timeout();
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task e8_sneaky_spawner_dialogue()
        {
            await sleep_until(async () => this.g_dialogue_counter == 4);
            if (this.dialogue)
            {
                print("truth: whosoever is gripped by fear, take heed: i am the prophet of truth, and i am not afraid!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4191426464U), e8_speaker1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4191426464U), e8_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4191426464U), e8_speaker3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4191426464U), e8_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0210_pot", 4191426464U), e8_speaker5.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e8_speaker0.Entity, "0210"));
            await sleep(20);
            if (this.dialogue)
            {
                print("truth: noble mercy is here, at my side - his wise counsel ever in my ears!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4191819686U), e8_speaker1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4191819686U), e8_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4191819686U), e8_speaker3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4191819686U), e8_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0270_pot", 4191819686U), e8_speaker5.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e8_speaker0.Entity, "0270"));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("gravemind: we exist together now. two corpses in one grave.");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4200011811U), e8_speaker_gm1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4200011811U), e8_speaker_gm2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4200011811U), e8_speaker_gm3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4200011811U), e8_speaker_gm4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5000_grv", 4200011811U), e8_speaker_gm5.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e8_speaker_gm0.Entity, "5000"));
            game_save_no_timeout();
            this.g_dialogue_counter = 5;
        }

        [ScriptMethod(193, Lifecycle.Dormant)]
        public async Task e8_sneaky_spawner()
        {
            await sleep_until(async () => volume_test_objects(tv_e8_trigger2_a, players()));
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                ai_place(e8_pro_inf1.Squad, 2);
            }
            else
            {
                ai_place(e8_pro_inf1.Squad, 3);
            }

            game_save_no_timeout();
            wake(new ScriptMethodReference(e8_sneaky_spawner_dialogue));
            if (volume_test_objects(tv_e8_cave_check, players()))
            {
                if (await this.difficulty_normal() || await this.difficulty_heroic())
                {
                    ai_place(e8_pro_inf1.Squad, 2);
                }
                else
                {
                    ai_place(e8_pro_inf1.Squad, 3);
                }
            }

            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3 && volume_test_objects(tv_e8_cave_check, players()))
                    {
                        if (random_range(0, 2) == 1 ? true : false)
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler3.Entity, 1F);
                        }

                        ai_place(e8_fld_inf1.guy10);
                        await sleep((short)random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3 && volume_test_objects(tv_e8_cave_check, players()))
                    {
                        if (random_range(0, 2) == 1 ? true : false)
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler3.Entity, 1F);
                        }

                        ai_place(e8_fld_inf1.guy9);
                        await sleep((short)random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3 && volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy8);
                        await sleep((short)random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3 && volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy7);
                        await sleep((short)random_range(30, 180));
                    }
                });
                await sleep_until(async () => (float)ai_strength(e8_fld_inf1.Squad) <= 0.3F, 15, 1800);
                begin_random(async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        if (random_range(0, 2) == 1 ? true : false)
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler3.Entity, 1F);
                        }

                        ai_place(e8_fld_inf1.guy10);
                        await sleep((short)random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        if (random_range(0, 2) == 1 ? true : false)
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler3.Entity, 1F);
                        }

                        ai_place(e8_fld_inf1.guy9);
                        await sleep((short)random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        ai_place(e8_fld_inf1.guy8);
                        await sleep((short)random_range(30, 180));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e8_fld_inf1.Squad) <= 3)
                    {
                        ai_place(e8_fld_inf1.guy7);
                        await sleep((short)random_range(30, 180));
                    }
                });
            }
            else
            {
                begin_random(async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy10);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy9);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy8);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy7);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy12);
                        await sleep((short)random_range(30, 90));
                    }
                });
                await sleep_until(async () => (float)ai_strength(e8_fld_inf1.Squad) <= 0.3F, 15, 450);
                begin_random(async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy11);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy9);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy8);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy7);
                        await sleep((short)random_range(30, 90));
                    }
                });
                await sleep_until(async () => (float)ai_strength(e8_fld_inf1.Squad) <= 0.5F, 15, 450);
                begin_random(async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        if (random_range(0, 2) == 1 ? true : false)
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler3.Entity, 1F);
                        }

                        ai_place(e8_fld_inf1.guy9);
                        ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        if (random_range(0, 2) == 1 ? true : false)
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler1.Entity, 1F);
                        }
                        else
                        {
                            sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e8_howler3.Entity, 1F);
                        }

                        ai_place(e8_fld_inf1.guy10);
                        ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy11);
                        ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await sleep((short)random_range(30, 90));
                    }
                }, 
                    async () =>
                {
                    if (volume_test_objects(tv_e8_cave_check, players()))
                    {
                        ai_place(e8_fld_inf1.guy12);
                        ai_set_orders(e8_fld_inf1.Squad, e8_fld_inf1_z);
                        await sleep((short)random_range(30, 90));
                    }
                });
            }
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task e8_load()
        {
            await sleep_until(async () => volume_test_objects(tv_e7_trigger2, players()), 15);
            data_mine_set_mission_segment("space_cave2");
            ai_place(e8_fld_swarm1.Squad);
            ai_place(e8_fld_inf1.guy5);
            begin_random(async () =>
            {
                if ((short)ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    ai_place(e8_fld_inf1.guy1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    ai_place(e8_fld_inf1.guy2);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    ai_place(e8_fld_inf1.guy3);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    ai_place(e8_fld_inf1.guy4);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e8_fld_inf1.Squad) <= 2)
                {
                    ai_place(e8_fld_inf1.guy6);
                }
            });
            ai_disposable(e6_fld_inf1.Squad, true);
            ai_disposable(e6_fld_inf1_a.Squad, true);
            ai_disposable(e6_fld_inf2_a.Squad, true);
            ai_disposable(e6_fld_inf2_b.Squad, true);
            ai_disposable(e6_fld_inf2_c.Squad, true);
            ai_disposable(e6_fld_inf2_d.Squad, true);
            ai_disposable(e6_fld_inf2_z.Squad, true);
            ai_disposable(e6_fld_inf3.Squad, true);
            ai_disposable(e6_fld_inf4.Squad, true);
            ai_disposable(e6_pro_inf2_a.Squad, true);
            ai_disposable(e6_pro_inf2.Squad, true);
            ai_disposable(e6_pro_inf3.Squad, true);
            ai_disposable(e6_pro_inf3_a.Squad, true);
            wake(new ScriptMethodReference(e8_sneaky_spawner));
            wake(new ScriptMethodReference(e8_end_open));
            await sleep_until(async () => this.g_dialogue_counter == 3);
            if (this.dialogue)
            {
                print("cortana: the security systems in this part of the tower are particularly robust.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2760"));
            this.g_dialogue_counter = 4;
            wake(new ScriptMethodReference(music_07b_05_start));
        }

        [ScriptMethod(195, Lifecycle.Dormant)]
        public async Task e8_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e7_trigger1, players()), 15);
            wake(new ScriptMethodReference(e8_load));
            wake(new ScriptMethodReference(e9_main));
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task e7_start()
        {
            await sleep_until(async () => volume_test_objects(tv_e7_trigger1, players()), 15);
            data_mine_set_mission_segment("boobag_garden");
            game_save_cancel();
            await sleep(6);
            game_save();
            wake(new ScriptMethodReference(music_07b_04_stop));
            await sleep_until(async () => this.g_dialogue_counter == 9);
            await sleep(150);
            if (this.dialogue)
            {
                print("cortana: the amount of flood bio-mass is increasing exponentially. there are reports of infestations in every district!");
            }

            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2860_cor", 4198504460U)));
            await sleep(this.dialogue_pause);
            if (this.dialogue)
            {
                print("cortana: if the speed of the flood's spread in this tower is any indication, it won't take long for it to overrun the entire city!");
            }

            await sleep((short)sound_impulse_language_time(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_2870_cor", 4198569997U)));
            await sleep(this.dialogue_pause);
            this.g_dialogue_counter = 3;
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task e7_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_trigger1, players()), 15);
            wake(new ScriptMethodReference(e7_start));
            game_save_no_timeout();
            wake(new ScriptMethodReference(e8_main));
            ai_disposable(e6_fld_inf1.Squad, true);
            ai_disposable(e6_fld_inf1_a.Squad, true);
            ai_disposable(e6_fld_inf2_z.Squad, true);
            ai_disposable(e6_fld_inf2_d.Squad, true);
            ai_disposable(e6_fld_inf2_c.Squad, true);
            ai_disposable(e6_fld_inf2_b.Squad, true);
            ai_disposable(e6_fld_inf2_a.Squad, true);
            ai_disposable(e6_pro_inf2_a.Squad, true);
            ai_disposable(e6_pro_inf2.Squad, true);
            ai_disposable(e6_fld_inf4.Squad, true);
            ai_disposable(e6_fld_inf3.Squad, true);
            ai_disposable(e6_fld_inf5.Squad, true);
            ai_disposable(e6_pro_inf3_a.Squad, true);
            ai_disposable(e6_pro_inf3.Squad, true);
        }

        [ScriptMethod(198, Lifecycle.Dormant)]
        public async Task e6_talking()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_talkbox, players()), 15);
            this.g_dialogue_counter = 9;
            if (this.dialogue)
            {
                print("truth: the parasite did not defeat the forerunners, and it shall not defeat us!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4191295390U), e6_speaker1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4191295390U), e6_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4191295390U), e6_speaker3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4191295390U), e6_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_0190_pot", 4191295390U), e6_speaker5.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e6_speaker0.Entity, "0190"));
            await sleep(20);
            if (this.dialogue)
            {
                print("gravemind: arrogant creature! your deaths will be instantaneous, while we shall suffer the progress of infinitude!");
            }

            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4200077348U), e6_speaker1.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4200077348U), e6_speaker2.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4200077348U), e6_speaker3.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4200077348U), e6_speaker4.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4200077348U), e6_speaker5.Entity, 1F, 1);
            sound_impulse_trigger(GetTag<SoundTag>("sound\\dialog\\levels\\07_highcharity\\mission\\l07_5010_grv", 4200077348U), e6_speaker_gm1.Entity, 1F, 1);
            await sleep(ai_play_line_on_object(e6_speaker_gm0.Entity, "5010"));
            wake(new ScriptMethodReference(music_07b_04_start));
        }

        [ScriptMethod(199, Lifecycle.Dormant)]
        public async Task e6_go_go_go()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_cave_check, players()));
            ai_migrate(e6_flood_group_1, e6_flood_group_3);
            await sleep(10);
            ai_migrate(e6_flood_group_2, e6_flood_group_3);
            await sleep(10);
            ai_migrate(e6_flood_storm, e6_flood_group_3);
            await sleep(10);
            ai_set_orders(e6_flood_group_3, e6_fld_go_go_go);
            this.g_e6_move_on = true;
        }

        [ScriptMethod(200, Lifecycle.Dormant)]
        public async Task e6_final()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_final_start, players()));
            data_mine_set_mission_segment("space_cave1");
            wake(new ScriptMethodReference(e6_talking));
            wake(new ScriptMethodReference(e6_go_go_go));
            ai_place(e6_pro_inf3.Squad, 2);
            ai_place(e6_pro_inf3_a.Squad, 3);
            await sleep_until(async () => (float)ai_strength(e6_pro_cave1) <= 0.2F, 15, 600);
            if (volume_test_objects(tv_e6_cave_check, players()))
            {
                ai_place(e6_fld_inf5.Squad);
            }
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task e6_ambush()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_ambusher, players()));
            game_save();
            await sleep(15);
            ai_place(e6_fld_inf3.Squad);
            begin_random(async () =>
            {
                if ((short)ai_living_count(e6_flood_storm) <= 5 && volume_test_objects(tv_e6_ambusher, players()))
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler_spec1.Entity, 1F);
                    ai_place(e6_fld_inf4.guy1);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await sleep((short)random_range(90, 150));
                    ai_place(e6_fld_inf4.guy2);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_storm) <= 5 && volume_test_objects(tv_e6_ambusher, players()))
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler_spec2.Entity, 1F);
                    ai_place(e6_fld_inf4.guy4);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await sleep((short)random_range(90, 150));
                    ai_place(e6_fld_inf4.guy5);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_storm) <= 5 && volume_test_objects(tv_e6_ambusher, players()))
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler_spec3.Entity, 1F);
                    ai_place(e6_fld_inf4.guy6);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await sleep((short)random_range(90, 150));
                    ai_place(e6_fld_inf4.guy7);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_storm) <= 5 && volume_test_objects(tv_e6_ambusher, players()))
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler_spec4.Entity, 1F);
                    ai_place(e6_fld_inf4.guy8);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await sleep((short)random_range(90, 150));
                    ai_place(e6_fld_inf4.guy9);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_storm) <= 5 && volume_test_objects(tv_e6_ambusher, players()))
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler_spec4.Entity, 1F);
                    ai_place(e6_fld_inf2_z.guy1);
                    await sleep(6);
                    ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await sleep(6);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await sleep((short)random_range(90, 150));
                    ai_place(e6_fld_inf2_z.guy2);
                    await sleep(6);
                    ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await sleep(6);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_storm) <= 5 && volume_test_objects(tv_e6_ambusher, players()))
                {
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler_spec4.Entity, 1F);
                    ai_place(e6_fld_inf2_z.guy3);
                    await sleep(6);
                    ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await sleep(6);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }

                    await sleep((short)random_range(90, 150));
                    ai_place(e6_fld_inf2_z.guy4);
                    await sleep(6);
                    ai_migrate(e6_fld_inf2_z.Squad, e6_fld_inf4.Squad);
                    await sleep(6);
                    if (this.g_e6_move_on)
                    {
                        ai_set_orders(e6_fld_inf4.Squad, e6_fld_go_go_go);
                    }
                }
            });
        }

        [ScriptMethod(202, Lifecycle.CommandScript)]
        public async Task e6_cs_attack_the_prophetscd()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_force_combat_status(3);
            cs_go_by(GetReference<ISpatialPoint>("e6_attack/p0"), GetReference<ISpatialPoint>("e6_attack/p1"));
            cs_go_by(GetReference<ISpatialPoint>("e6_attack/p2"), GetReference<ISpatialPoint>("e6_attack/p3"));
        }

        [ScriptMethod(203, Lifecycle.CommandScript)]
        public async Task e6_cs_attack_the_prophetsab()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_force_combat_status(3);
            cs_go_by(GetReference<ISpatialPoint>("e6_attack/p4"), GetReference<ISpatialPoint>("e6_attack/p5"));
            cs_go_by(GetReference<ISpatialPoint>("e6_attack/p2"), GetReference<ISpatialPoint>("e6_attack/p3"));
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task e6_flood_attack_2()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_trigger3, players()));
            game_save_no_timeout();
            data_mine_set_mission_segment("riptide_ambush");
            wake(new ScriptMethodReference(e6_ambush));
            wake(new ScriptMethodReference(e6_final));
            ai_place(e6_pro_inf2.Squad, 2);
            ai_place(e6_pro_inf2_a.Squad, 2);
            ai_disposable(e5_pro_inf11.Squad, true);
            ai_disposable(e5_pro_bug2_c.Squad, true);
            ai_disposable(e5_fld_inf1.Squad, true);
            ai_disposable(e5_fld_inf2.Squad, true);
            ai_disposable(e5_fld_inf2_z.Squad, true);
            begin_random(async () =>
            {
                if ((short)ai_living_count(e6_flood_group_2) <= 0)
                {
                    await sleep(10);
                    ai_place(e6_fld_inf2_a.Squad);
                    ai_place(e6_fld_inf2_b.Squad);
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler1.Entity, 1F);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_group_2) <= 0)
                {
                    await sleep(10);
                    ai_place(e6_fld_inf2_c.Squad);
                    ai_place(e6_fld_inf2_d.Squad);
                    sound_impulse_start(GetTag<SoundTag>("sound\\characters\\flood\\flood_howls", 4259060624U), e6_howler2.Entity, 1F);
                }
            });
            await sleep_until(async () => (short)ai_nonswarm_count(e6_flood_group_2) <= 1, 10, 300);
            ai_place(e6_fld_inf2_z.Squad, 1);
            await sleep_until(async () => (short)ai_nonswarm_count(e6_flood_group_2) <= 0, 10, 450);
            if (volume_test_objects(tv_e6_infinite2, players()))
            {
                ai_place(e6_fld_inf2_z.Squad, 1);
            }

            await sleep_until(async () => (short)ai_nonswarm_count(e6_flood_group_2) <= 0, 10, 450);
            if (volume_test_objects(tv_e6_infinite2, players()))
            {
                ai_place(e6_fld_inf2_z.Squad, 1);
            }
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task e6_infinite_save()
        {
            game_save_no_timeout();
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task e6_flood_attack_1()
        {
            await sleep_until(async () => (short)ai_living_count(e6_fld_inf1.Squad) <= 0, 15, 300);
            game_save();
            wake(new ScriptMethodReference(e7_dia_filtration_systems));
            begin_random(async () =>
            {
                if ((short)ai_living_count(e6_flood_group_1) <= 0 && volume_test_objects(tv_e6_infinite1, players()))
                {
                    ai_place(e6_fld_inf1_a.guy1);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_group_1) <= 0 && volume_test_objects(tv_e6_infinite1, players()))
                {
                    await sleep(10);
                    ai_place(e6_fld_inf1_a.guy2);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_group_1) <= 0 && volume_test_objects(tv_e6_infinite1, players()))
                {
                    await sleep(10);
                    ai_place(e6_fld_inf1_a.guy3);
                }
            }, 
                async () =>
            {
                if ((short)ai_living_count(e6_flood_group_1) <= 0 && volume_test_objects(tv_e6_infinite1, players()))
                {
                    await sleep(10);
                    ai_place(e6_fld_inf1_a.guy4);
                }
            });
            game_save();
        }

        [ScriptMethod(207, Lifecycle.Dormant)]
        public async Task e6_start()
        {
            await sleep_until(async () => volume_test_objects(tv_e6_trigger1, players()), 15);
            wake(new ScriptMethodReference(chapter_please));
            wake(new ScriptMethodReference(objective_riptide_set));
            game_save_cancel();
            data_mine_set_mission_segment("riptide_start");
            game_save();
            ai_place(e6_fld_inf1.Squad, 2);
            await sleep(30);
            wake(new ScriptMethodReference(music_07b_03_start));
            wake(new ScriptMethodReference(e6_flood_attack_1));
            wake(new ScriptMethodReference(e6_flood_attack_2));
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task e6_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_trigger1, players()), 15);
            wake(new ScriptMethodReference(e6_start));
            game_save();
            wake(new ScriptMethodReference(e7_main));
            ai_disposable(e5_pro_inf11.Squad, true);
            ai_disposable(e5_fld_inf1.Squad, true);
            ai_disposable(e5_pro_bug1.Squad, true);
            ai_disposable(e5_pro_bug2_c.Squad, true);
            ai_disposable(e5_fld_inf2.Squad, true);
            ai_disposable(e5_fld_inf2_z.Squad, true);
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task e5_platform_c()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_platform_c1, players()), 15);
            device_set_position(maus_platform_d.Entity, 0F);
            await sleep_until(async () => device_get_position(maus_platform_d.Entity) <= 0F, 10);
            device_set_position_immediate(gravity_bridge_c1.Entity, 1F);
            device_set_power(gravity_bridge_c1.Entity, 1F);
            await sleep(1);
            await sleep_until(async () => volume_test_objects(tv_e5_platform_c1, players()), 15);
            device_set_position(gravity_bridge_c1.Entity, 0F);
            await sleep_until(async () => device_get_position(gravity_bridge_c1.Entity) <= 0F, 10);
            device_set_power(gravity_bridge_c1.Entity, 0F);
            device_set_position_immediate(gravity_bridge_c1.Entity, 1F);
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task e5_platform_b()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(tv_e5_platform_b1, players()), 15);
                device_set_position(maus_platform_d.Entity, 0F);
                await sleep_until(async () => device_get_position(maus_platform_d.Entity) <= 0F, 10);
                device_set_power(gravity_bridge_b1.Entity, 1F);
                await sleep(30);
                await sleep_until(async () => volume_test_objects(tv_e5_platform_b1, players()), 15);
                device_set_position(gravity_bridge_b1.Entity, 1F);
                await sleep_until(async () => device_get_position(gravity_bridge_b1.Entity) >= 1F, 15);
                device_set_power(gravity_bridge_b1.Entity, 0F);
                device_set_position_immediate(gravity_bridge_b1.Entity, 0F);
                return (short)structure_bsp_index() == 2;
            });
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task e5_platform_a2()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_platform_a2, players()), 15);
            device_set_position(maus_platform_c.Entity, 0F);
            device_set_position_immediate(gravity_bridge_a2.Entity, 1F);
            await sleep_until(async () => device_get_position(maus_platform_c.Entity) <= 0F, 15);
            device_set_power(gravity_bridge_a2.Entity, 1F);
            await sleep(1);
            await sleep_until(async () => volume_test_objects(tv_e5_platform_a2, players()), 15);
            device_set_position(gravity_bridge_a2.Entity, 0F);
            await sleep_until(async () => device_get_position(gravity_bridge_a2.Entity) <= 0F, 15);
            device_set_power(gravity_bridge_a2.Entity, 0F);
            device_set_position_immediate(gravity_bridge_a2.Entity, 1F);
            wake(new ScriptMethodReference(e5_platform_c));
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task e5_platform_a1()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects(tv_e5_platform_a1, players()), 15);
                device_set_power(gravity_bridge_a1.Entity, 1F);
                await sleep(30);
                await sleep_until(async () => volume_test_objects(tv_e5_platform_a1, players()), 15);
                device_set_position(gravity_bridge_a1.Entity, 1F);
                await sleep_until(async () => device_get_position(gravity_bridge_a1.Entity) >= 1F, 15);
                device_set_power(gravity_bridge_a1.Entity, 0F);
                device_set_position_immediate(gravity_bridge_a1.Entity, 0F);
                return (short)structure_bsp_index() == 2;
            });
        }

        [ScriptMethod(213, Lifecycle.Dormant)]
        public async Task e5_platform_begin()
        {
            game_save();
            device_set_power(gravity_bridge_a1.Entity, 0F);
            device_set_power(gravity_bridge_a2.Entity, 0F);
            device_set_power(gravity_bridge_b1.Entity, 0F);
            device_set_power(gravity_bridge_c1.Entity, 0F);
            device_set_position_immediate(gravity_bridge_a1.Entity, 0F);
            device_set_position_immediate(gravity_bridge_a2.Entity, 1F);
            device_set_position_immediate(gravity_bridge_b1.Entity, 0F);
            device_set_position_immediate(gravity_bridge_c1.Entity, 1F);
            object_create(lift_effect_b);
            await sleep(1);
            device_set_position(lift_effect_b.Entity, 1F);
            objects_attach(maus_platform_b.Entity, "lift_effect", lift_effect_b.Entity, "lift_effect");
            await sleep_until(async () => volume_test_objects(tv_e5_platform_start, players()), 15);
            device_set_position(maus_platform_a.Entity, 0F);
            object_create(lift_effect_a);
            await sleep(1);
            objects_attach(maus_platform_a.Entity, "lift_effect", lift_effect_a.Entity, "lift_effect");
            await sleep_until(async () => device_get_position(maus_platform_a.Entity) <= 0F, 10);
            device_set_position(lift_effect_a.Entity, 1F);
            wake(new ScriptMethodReference(e5_platform_a1));
            wake(new ScriptMethodReference(e5_platform_b));
        }

        [ScriptMethod(214, Lifecycle.CommandScript)]
        public async Task e5_cs_leave()
        {
            cs_abort_on_damage(true);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_force_combat_status(3);
            cs_go_to(GetReference<ISpatialPoint>("e5_leave/p0"));
        }

        [ScriptMethod(215, Lifecycle.Dormant)]
        public async Task e5_infinite_save()
        {
            game_save_no_timeout();
        }

        [ScriptMethod(216, Lifecycle.Dormant)]
        public async Task e5_fld_inf2_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_trigger3, players()), 15);
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                ai_place(e5_fld_inf2.Squad, 2);
            }
            else
            {
                ai_place(e5_fld_inf2_z.Squad);
            }

            await sleep_until(async () => (short)ai_living_count(e5_fld_inf2.Squad) <= 0 && (short)ai_living_count(e5_fld_inf2_z.Squad) <= 0);
            game_save();
        }

        [ScriptMethod(217, Lifecycle.Dormant)]
        public async Task e5_start_the_other_fight()
        {
            await sleep_until(async () => device_get_position(maus_platform_d.Entity) <= 0F);
            wake(new ScriptMethodReference(e5_infinite_save));
            wake(new ScriptMethodReference(e5_fld_inf2_main));
            await sleep_until(async () => volume_test_objects(tv_e5_trigger_chase, players()));
            ai_place(e5_pro_bug2_c.Squad, (short)pin(5F - (float)ai_living_count(e5_buggers), 0F, 3F));
            ai_migrate(e5_pro_bug1.Squad, e5_pro_bug2_c.Squad);
            ai_set_orders(e5_buggers, e5_pro_bug2_c_attk);
        }

        [ScriptMethod(218, Lifecycle.Dormant)]
        public async Task e5_bugger_spawner()
        {
            await sleep_until(async () => (short)ai_living_count(e5_pro_bug1.Squad) <= 2);
            ai_place(e5_pro_bug2_c.Squad);
        }

        [ScriptMethod(219, Lifecycle.Dormant)]
        public async Task e5_start_the_fight()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_trigger2, players()), 15);
            ai_place(e5_pro_bug1.Squad, 6);
            wake(new ScriptMethodReference(e5_bugger_spawner));
            ai_place(e5_fld_inf1.Squad, 2);
            await sleep_until(async () => (short)ai_living_count(e5_fld_inf1.Squad) <= 0, 15, 450);
            await sleep((short)random_range(30, 300));
            if (!(volume_test_objects(tv_e5_plat_b, players())) && !(volume_test_objects(tv_e5_plat_c, players())))
            {
                ai_place(e5_fld_inf1.Squad, 3);
                await sleep_until(async () => (short)ai_living_count(e5_fld_inf1.Squad) <= 0);
                await sleep((short)random_range(30, 150));
            }

            if (!(volume_test_objects(tv_e5_plat_b, players())) && !(volume_test_objects(tv_e5_plat_c, players())))
            {
                ai_place(e5_fld_inf1.Squad, 3);
            }

            await sleep_until(async () => (short)ai_living_count(e5_fld_inf1.Squad) <= 0, 15, 450);
            ai_set_orders(e5_pro_inf11.Squad, e5_pro_inf1_leave);
            ai_set_orders(e5_fld_inf1.Squad, e5_pro_inf1_leave);
            await sleep(150);
            ai_set_orders(e5_buggers, e5_pro_bug1_attk_player);
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task e5_talking_points()
        {
            wake(new ScriptMethodReference(e1_dia_truth_holycity));
            await sleep(600);
            if (this.dialogue)
            {
                print("cortana: i'll do what i can to slow the launch sequence, but there's something inside the ship... a presence... that's fighting back.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2740"));
            await sleep((short)(this.dialogue_pause * 3));
            if (this.dialogue)
            {
                print("cortana: for a covenant construct it's unusually formidable.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2750"));
            await sleep((short)(this.dialogue_pause * 5));
            if (volume_test_objects(tv_e5_trigger1, players()))
            {
                wake(new ScriptMethodReference(e5_dia_get_to_conduit));
            }
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task e5_start()
        {
            await sleep_until(async () => volume_test_objects(tv_e5_trigger1, players()), 15);
            device_set_position_immediate(maus_platform_a.Entity, 1F);
            device_set_position_immediate(maus_platform_d.Entity, 1F);
            data_mine_set_mission_segment("plasma_chandelier");
            game_save();
            wake(new ScriptMethodReference(e5_platform_begin));
            wake(new ScriptMethodReference(e5_start_the_fight));
            wake(new ScriptMethodReference(e5_start_the_other_fight));
            wake(new ScriptMethodReference(e5_talking_points));
            ai_place(e5_pro_inf11.Squad);
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task e5_main()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_trigger2, players()), 15);
            await sleep_until(async () => volume_test_objects(tv_e2_trigger1, players()), 15);
            wake(new ScriptMethodReference(e5_start));
            wake(new ScriptMethodReference(e6_main));
            ai_disposable(e1_fld_inf1.Squad, true);
            ai_disposable(e1_pro_inf1.Squad, true);
            ai_disposable(e1_fld_gitem1.Squad, true);
            ai_disposable(e1_fld_gitem2.Squad, true);
            ai_disposable(e1_pro_inf2.Squad, true);
            ai_disposable(e1_fld_inf2.Squad, true);
            ai_disposable(e1_fld_inf5.Squad, true);
            ai_disposable(e1_pro_inf3.Squad, true);
            ai_disposable(e1_fld_inf3.Squad, true);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task e2_cortana_intro()
        {
            await sleep_until(async () => volume_test_objects(tv_e2_trigger1, players()), 15);
            game_save_cancel();
            await sleep(6);
            game_save_no_timeout();
            await sleep(150);
            if (this.dialogue)
            {
                print("cortana: i'll disable this lift once you reach the top. that'll slow them down... i hope!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2720"));
            wake(new ScriptMethodReference(objective_enter_clear));
            ai_disposable(e1_fld_inf1.Squad, true);
            ai_disposable(e1_fld_inf2.Squad, true);
            ai_disposable(e1_fld_inf3.Squad, true);
            ai_disposable(e1_fld_inf4.Squad, true);
            ai_disposable(e1_fld_inf5.Squad, true);
            ai_disposable(e1_pro_inf1.Squad, true);
            ai_disposable(e1_pro_inf2.Squad, true);
            ai_disposable(e1_pro_inf3.Squad, true);
        }

        [ScriptMethod(224, Lifecycle.CommandScript)]
        public async Task e1_cs_gitem1()
        {
            ai_set_blind(this.ai_current_actor, true);
            ai_set_deaf(this.ai_current_actor, true);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_by(GetReference<ISpatialPoint>("gitem1/p1"), GetReference<ISpatialPoint>("gitem1/p2"));
            ai_set_blind(this.ai_current_actor, false);
            ai_set_deaf(this.ai_current_actor, false);
        }

        [ScriptMethod(225, Lifecycle.CommandScript)]
        public async Task e1_cs_gitem2()
        {
            ai_set_blind(this.ai_current_actor, true);
            ai_set_deaf(this.ai_current_actor, true);
            cs_enable_pathfinding_failsafe(true);
            cs_ignore_obstacles(true);
            cs_go_by(GetReference<ISpatialPoint>("gitem2/p1"), GetReference<ISpatialPoint>("gitem2/p2"));
            ai_set_blind(this.ai_current_actor, false);
            ai_set_deaf(this.ai_current_actor, false);
        }

        [ScriptMethod(226, Lifecycle.CommandScript)]
        public async Task e1_cs_freakout()
        {
            cs_movement_mode(this.ai_movement_flee);
            await sleep_until(async () =>
            {
                begin_random(async () => cs_go_to(GetReference<ISpatialPoint>("e1_panic/p0")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_panic/p1")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_panic/p2")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_panic/p3")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_panic/p4")), 
                    async () => cs_go_to(GetReference<ISpatialPoint>("e1_panic/p5")));
                return true;
            });
        }

        [ScriptMethod(227, Lifecycle.CommandScript)]
        public async Task e1_cs_teleport1()
        {
            cs_teleport(GetReference<ISpatialPoint>("e1_drops/p1a"), GetReference<ISpatialPoint>("e1_drops/p1b"));
        }

        [ScriptMethod(228, Lifecycle.CommandScript)]
        public async Task e1_cs_teleport2()
        {
            cs_teleport(GetReference<ISpatialPoint>("e1_drops/p2a"), GetReference<ISpatialPoint>("e1_drops/p2b"));
        }

        [ScriptMethod(229, Lifecycle.CommandScript)]
        public async Task e1_cs_pelican2()
        {
            cs_fly_by(GetReference<ISpatialPoint>("pelican2/p0"));
            this.g_e1_talk = 3;
            this.g_e1_pelican2_entering = true;
            cs_fly_by(GetReference<ISpatialPoint>("pelican2/p1"));
            cs_fly_by(GetReference<ISpatialPoint>("pelican2/p2"));
            cs_fly_by(GetReference<ISpatialPoint>("pelican2/p3"));
            ai_erase(e1_CS_pelican2.Squad);
        }

        [ScriptMethod(230, Lifecycle.Dormant)]
        public async Task e1_carrier_drop()
        {
            object_set_velocity(ai_get_object(e1_fld_inf3.carrier0), -5F, 0F, 0F);
            object_set_velocity(ai_get_object(e1_fld_inf3.carrier1), -4F, 0F, 0F);
            await sleep(30);
            unit_set_current_vitality(ai_get_unit(e1_fld_inf3.carrier0), 0.1F, 0F);
            unit_set_current_vitality(ai_get_unit(e1_fld_inf3.carrier1), 0.1F, 0F);
        }

        [ScriptMethod(231, Lifecycle.CommandScript)]
        public async Task e1_cs_pelican1()
        {
            ai_place(e1_fld_inf3.carrier0);
            ai_place(e1_fld_inf3.carrier1);
            await sleep(1);
            objects_attach(ai_vehicle_get(this.ai_current_actor), "chief_rear", ai_get_object(e1_fld_inf3.carrier0), "");
            objects_attach(ai_vehicle_get(this.ai_current_actor), "pelican_e", ai_get_object(e1_fld_inf3.carrier1), "");
            cs_fly_by(GetReference<ISpatialPoint>("pelican1/p0"));
            this.g_e1_talk = 1;
            this.g_e1_pelican1_entering = true;
            cs_fly_by(GetReference<ISpatialPoint>("pelican1/p3"));
            objects_detach(ai_vehicle_get(this.ai_current_actor), ai_get_object(e1_fld_inf3.carrier0));
            objects_detach(ai_vehicle_get(this.ai_current_actor), ai_get_object(e1_fld_inf3.carrier1));
            await sleep(1);
            wake(new ScriptMethodReference(e1_carrier_drop));
            this.g_e1_talk = 2;
            this.g_e1_pelican1_unloaded = true;
            cs_fly_by(GetReference<ISpatialPoint>("pelican1/p4"));
            cs_fly_by(GetReference<ISpatialPoint>("pelican1/p5"));
            ai_erase(e1_CS_pelican1.Squad);
        }

        [ScriptMethod(232, Lifecycle.Dormant)]
        public async Task e1_infinite_save()
        {
            game_save_no_timeout();
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task e1_pro_inf3_place()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_trigger4, players()), 15);
            data_mine_set_mission_segment("turbolift_base");
            wake(new ScriptMethodReference(e1_infinite_save));
            ai_place(e1_pro_inf3.Squad);
            await sleep_until(async () => this.g_dialogue_counter == 1);
            this.g_e1_talk = 4;
            this.g_e1_pro_inf3_spawned = true;
            await sleep(150);
            this.g_e1_talk = 5;
            await sleep(150);
            this.g_e1_talk = 6;
            this.g_dialogue_counter = 2;
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                await sleep(450);
                if (volume_test_objects_all(tv_e1_trigger2, players()) || volume_test_objects_all(tv_e1_trigger4, players()))
                {
                    ai_place(e1_fld_inf5.Squad, (short)pin(8F - (float)ai_living_count(e1_flood_master), 0F, 5F));
                }
            }
            else
            {
                await sleep(150);
                if (volume_test_objects_all(tv_e1_trigger2, players()) || volume_test_objects_all(tv_e1_trigger4, players()))
                {
                    ai_place(e1_fld_inf5.Squad, (short)pin(8F - (float)ai_living_count(e1_flood_master), 0F, 5F));
                }

                await sleep(150);
                if (volume_test_objects_all(tv_e1_trigger2, players()) || volume_test_objects_all(tv_e1_trigger4, players()))
                {
                    ai_place(e1_fld_inf5.Squad, (short)pin(8F - (float)ai_living_count(e1_flood_master), 0F, 5F));
                }
            }
        }

        [ScriptMethod(234, Lifecycle.CommandScript)]
        public async Task run_grunt_run()
        {
            cs_movement_mode(this.ai_movement_flee);
            cs_go_to_nearest(GetReference<ISpatialPoint>("gitem1"));
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task e1_exterior_checkpoint()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_trigger4, players()) || (short)ai_nonswarm_count(e1_fld_inf1.Squad) <= 0 && (short)ai_nonswarm_count(e1_fld_inf2.Squad) <= 0 && (short)ai_nonswarm_count(e1_pro_inf1.Squad) <= 0 && (short)ai_nonswarm_count(e1_pro_inf2.Squad) <= 0, 15);
            game_save_no_timeout();
        }

        [ScriptMethod(236, Lifecycle.Dormant)]
        public async Task e1_pro_inf2_place()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_trigger2, players()), 15);
            ai_place(e1_pro_inf2.Squad, 2);
            ai_place(e1_fld_inf2.Squad, 1);
            if (await this.difficulty_legendary())
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(e1_flood_master) <= 5)
                    {
                        ai_place(e1_fld_inf1.guy2);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e1_flood_master) <= 5)
                    {
                        ai_place(e1_fld_inf1.guy3);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e1_flood_master) <= 5)
                    {
                        ai_place(e1_fld_inf1.guy4);
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(e1_flood_master) <= 5)
                    {
                        ai_place(e1_fld_inf1.guy5);
                    }
                });
            }

            wake(new ScriptMethodReference(e1_exterior_checkpoint));
            wake(new ScriptMethodReference(e1_pro_inf3_place));
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task e1_gitem_2()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_gitem2, players()), 15);
            this.g_e1_git_check = true;
            begin_random(async () => ai_place(e1_fld_gitem2.guy1), 
                async () => await sleep(90), 
                async () => ai_place(e1_fld_gitem2.guy2), 
                async () => await sleep(90));
        }

        [ScriptMethod(238, Lifecycle.Dormant)]
        public async Task e1_gitem_1()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_gitem1, players()), 15);
            if (!(this.g_e1_git_check))
            {
                begin_random(async () => ai_place(e1_fld_gitem1.guy1), 
                    async () => await sleep(90), 
                    async () => ai_place(e1_fld_gitem1.guy2), 
                    async () => await sleep(90));
            }

            sleep_forever(new ScriptMethodReference(e1_gitem_2));
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task e1_talking_points()
        {
            await sleep_until(async () => this.g_e1_pelican1_entering, 15, 450);
            if (this.dialogue)
            {
                print("cortana: flood-controlled dropships are touching down all over the city!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2680"));
            wake(new ScriptMethodReference(music_07b_01_start));
            await sleep(25);
            if (this.dialogue)
            {
                print("cortana: that creature beneath the library; that gravemind, used us! we were just a diversion. in amber clad was always it's intended vector!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2690"));
            game_save();
            await sleep_until(async () => this.g_e1_pelican2_entering || volume_test_objects(tv_e1_trigger4, players()), 15, 450);
            await sleep(25);
            if (this.dialogue)
            {
                print("cortana: there's a conduit connecting this tower to the ship. head back inside. i'll lead you to it.");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2710"));
            game_save();
            wake(new ScriptMethodReference(objective_enter_set));
            wake(new ScriptMethodReference(music_07b_01_stop));
            wake(new ScriptMethodReference(music_07b_02_start));
            this.g_dialogue_counter = 1;
            await sleep_until(async () => this.g_e1_pro_inf3_spawned, 15);
            await sleep(150);
            await sleep_until(async () => volume_test_objects(tv_e1_trigger2, players()), 15);
            if (this.dialogue)
            {
                print("cortana: we don't have time for this chief. truth's phantom is nearning the forerunner ship!");
            }

            await sleep(ai_play_line_on_object(default(IGameObject), "2700"));
            if (volume_test_objects_all(tv_e1_ledge_check, players()))
            {
                wake(new ScriptMethodReference(music_07b_02_start));
            }
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task e1_flashlight_training()
        {
            await sleep_until(async () => volume_test_objects(tv_e1_trigger5, players()), 15);
            await sleep_until(async () => (bool)game_safe_to_save());
            player_training_activate_flashlight();
        }

        [ScriptMethod(241, Lifecycle.Dormant)]
        public async Task e1_mercy()
        {
            object_create_anew(ledge_99);
            await sleep(10);
            scenery_animation_start_loop(ledge_99.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3901359891U), "mercy_dead");
        }

        [ScriptMethod(242, Lifecycle.Dormant)]
        public async Task e1_main()
        {
            game_save();
            data_mine_set_mission_segment("phantom_ledge");
            object_create_containing("ledge");
            wake(new ScriptMethodReference(e1_pro_inf2_place));
            wake(new ScriptMethodReference(e1_talking_points));
            wake(new ScriptMethodReference(e1_gitem_1));
            wake(new ScriptMethodReference(e1_gitem_2));
            wake(new ScriptMethodReference(e1_flashlight_training));
            wake(new ScriptMethodReference(e1_mercy));
            wake(new ScriptMethodReference(e5_main));
            wake(new ScriptMethodReference(e2_cortana_intro));
            ai_place(e1_pro_inf1.Squad);
            await sleep(6);
            units_set_current_vitality(ai_actors(e1_pro_inf1.Squad), 100F, 0F);
            ai_place(e1_fld_inf1.Squad, 4);
            ai_place(e1_CS_pelican1.pilot);
            await sleep(6);
            cs_run_command_script(e1_CS_pelican1.pilot, new ScriptMethodReference(e1_cs_pelican1));
            await sleep(180);
            ai_place(e1_CS_pelican2.pilot);
            await sleep(6);
            cs_run_command_script(e1_CS_pelican2.pilot, new ScriptMethodReference(e1_cs_pelican2));
        }

        [ScriptMethod(243, Lifecycle.Dormant)]
        public async Task mission_start()
        {
            switch_bsp(0);
            await this.cinematic_snap_to_white();
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    object_destroy(ledge_1.Entity);
                    object_destroy(ledge_97.Entity);
                    object_destroy(ledge_98.Entity);
                    object_destroy(ledge_99.Entity);
                    print("c07_intra1");
                    await this.c07_intra1();
                }

                await this.cinematic_skip_stop();
            }

            sound_suppress_ambience_update_on_revert();
            sound_class_set_gain("amb", 0F, 0);
            await sleep(1);
            sound_class_set_gain("amb", 1F, 15);
            await sleep(2);
            object_teleport(await this.player0(), player0_start);
            object_teleport(await this.player1(), player1_start);
            wake(new ScriptMethodReference(e1_main));
            await sleep(10);
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            await this.cinematic_fade_from_white_bars();
            wake(new ScriptMethodReference(chapter_purposes));
            await sleep_until(async () => volume_test_objects(tv_e12_end, players()), 16);
            object_cannot_take_damage(players());
            await this.cinematic_fade_to_white();
            ai_erase_all();
            object_teleport(await this.player0(), player0_end);
            object_teleport(await this.player1(), player1_end);
            object_hide(await this.player0(), true);
            object_hide(await this.player1(), true);
            await sleep(15);
            wake(new ScriptMethodReference(objective_exit_clear));
            if (this.g_play_cinematics == true)
            {
                if (await this.cinematic_skip_start())
                {
                    print("c07_outro");
                    await this.c07_outro();
                }

                await this.cinematic_skip_stop();
            }

            game_won();
        }

        [ScriptMethod(244, Lifecycle.Static)]
        public async Task start()
        {
            wake(new ScriptMethodReference(mission_start));
        }

        [ScriptMethod(245, Lifecycle.Startup)]
        public async Task mission_main()
        {
            ai_allegiance(player, human);
            ai_allegiance(covenant, prophet);
            game_can_use_flashlights(true);
            if (await this.player_count() > 0)
            {
                await this.start();
            }
        }

        [ScriptMethod(246, Lifecycle.CommandScript)]
        public async Task cinematic_fld_inf0_0()
        {
            cs_movement_mode(this.ai_movement_combat);
            cs_enable_pathfinding_failsafe(true);
            await sleep(1);
            object_set_velocity(ai_get_object(this.ai_current_actor), 4F, 0F, 1.5F);
            cs_go_to(GetReference<ISpatialPoint>("cinematic_fld_inf0/p0"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(247, Lifecycle.CommandScript)]
        public async Task cinematic_fld_inf0_1()
        {
            cs_movement_mode(this.ai_movement_combat);
            cs_enable_pathfinding_failsafe(true);
            await sleep(1);
            object_set_velocity(ai_get_object(this.ai_current_actor), 4F, 0F, 1F);
            cs_go_to(GetReference<ISpatialPoint>("cinematic_fld_inf0/p1"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(248, Lifecycle.CommandScript)]
        public async Task cinematic_fld_inf1_0()
        {
            cs_movement_mode(this.ai_movement_combat);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("cinematic_fld_inf0/p2"));
            ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(249, Lifecycle.Dormant)]
        public async Task _07_intra1_05_predict()
        {
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3843425184U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3843425184U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\fp_covenant_carbine\\fp_covenant_carbine", 3808625037U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\holo_panels\\holo_hallway_signs\\holo_hallway_signs", 3844998072U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 5);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\highcharity", 3783000070U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 19, false);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3847160793U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 7);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 0);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3849716736U), 0);
            await sleep(25);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 1);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 4, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 13, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3851093013U), 0);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 2);
            await sleep(51);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3852665901U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3849716736U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3859940508U), 0);
            await sleep(26);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 1);
            await sleep(103);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3860726952U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3851093013U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3861054637U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3847160793U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await sleep(46);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
        }

        [ScriptMethod(250, Lifecycle.Dormant)]
        public async Task _07_intra1_06_predict()
        {
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3859940508U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862168766U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 8);
            await sleep(119);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\flood_infection\\flood_infection", 3852665901U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3859940508U), 2);
            await sleep(154);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            await sleep(121);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3860726952U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3851093013U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3861054637U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3847160793U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862168766U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            await sleep(160);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 8);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 3);
            await sleep(53);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
        }

        [ScriptMethod(251, Lifecycle.Dormant)]
        public async Task _07_intra1_07_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3859940508U), 1);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 8);
            await sleep(239);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            await sleep(26);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            await sleep(215);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 3, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3853190197U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3860726952U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3851093013U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3861054637U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3849716736U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3847160793U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            await sleep(104);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3859940508U), 1);
            await sleep(118);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3860726952U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3851093013U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3861054637U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3847160793U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            await sleep(45);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 14, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3854042178U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3859940508U), 1);
        }

        [ScriptMethod(252, Lifecycle.Dormant)]
        public async Task _07_intra1_08_predict()
        {
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3863545043U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3864986857U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3864986857U), 1);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 5, true);
            await sleep(50);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 13, true);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 11, true);
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 8, true);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await sleep(15);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\support_high\\rocket_launcher\\rocket_launcher", 3861054637U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 18, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3860726952U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3851093013U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 1);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3848733681U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3849651199U), 1);
            await sleep(8);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 0, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 1);
            await sleep(24);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07a_highcharity\\high_5"), 12, true);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3829138118U), 0);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 22);
            await sleep(31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 31);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 33);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 34);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 38);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 41);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 42);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 12);
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task _07_outro_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3849716736U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 20);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_shipping_crate\\high_shipping_crate", 3853780030U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3863545043U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3866625282U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3866625282U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3866625282U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3866625282U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3866625282U), 4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3866625282U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_human\\floodcombat_human", 3866625282U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3867215115U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3867215115U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 3865576690U), 10);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\magnum\\magnum", 3868001559U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 36);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 37);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3868460318U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3871278409U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\brute_plasma_rifle\\brute_plasma_rifle", 3871278409U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_sack\\flood_sack", 3871868242U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_clump\\flood_clump", 3872458075U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_floor_clump_large\\flood_floor_clump_large", 3872523612U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_pod\\flood_pod", 3872589149U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3843425184U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3843425184U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\fp_covenant_carbine\\fp_covenant_carbine", 3808625037U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\highcharity\\high_door_grand\\high_door_grand", 3847160793U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 5);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\crashed\\crashed", 3866559745U), 6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_tentacle_c\\flood_tentacle_c", 3872654686U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_tentacle_b\\flood_tentacle_b", 3872720223U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\flood\\flood_tentacle_a\\flood_tentacle_a", 3872785760U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3788243030U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcarrier\\floodcarrier", 3872851297U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcarrier\\floodcarrier", 3872851297U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\floodcarrier\\floodcarrier", 3872851297U), 2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 1, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3788046419U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3788046419U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3788046419U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3788046419U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3788046419U), 4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\highcharity\\sky_high_cinematic\\sky_high_cinematic", 3788046419U), 5);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3873113445U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit\\conduit", 3874358648U), 0);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit_ring\\conduit_ring", 3874620796U), 0);
        }

        [ScriptMethod(254, Lifecycle.Dormant)]
        public async Task _07_outro_02_predict()
        {
            await sleep(3);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 9, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 13, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 17, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 3, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 20, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 5, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 6, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 18, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3850109958U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3849716736U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\battery\\battery", 3850437643U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3876652443U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit_ring\\conduit_ring", 3874620796U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            await sleep(59);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3863545043U), 0);
            await sleep(20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3876652443U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship\\forerunner_ship", 3876914591U), 0);
            await sleep(142);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 4, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862365377U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\covenant\\conduit_ring\\conduit_ring", 3874620796U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3845587905U), 0);
            await sleep(49);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 0, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 6, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\07b_forerunnership\\high_9_cinematic"), 8, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3846177738U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\residential\\civilian_cov_crate\\civilian_cov_crate", 3849716736U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\forerunner_ship\\forerunner_ship", 3876914591U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\bloom_quad\\bloom_quad", 3876652443U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
        }

        [ScriptMethod(255, Lifecycle.Dormant)]
        public async Task _07_outro_03_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\substance_space\\substance_space", 3877963183U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\high_charity_exterior\\high_charity_exterior", 3878290868U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\generic\\space\\space", 3786276920U), 0);
            await sleep(160);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3849978884U), 0);
        }
    }
}