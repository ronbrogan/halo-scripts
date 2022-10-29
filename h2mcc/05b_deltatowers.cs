namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\05b_deltatowers\\05b_deltatowers")]
    public partial class scnr_05b_deltatowers : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool tower1_holo_trans;
        bool tower1_holo_chant;
        int bridges_sniper_count;
        bool miranda_pel_comment_done;
        bool central_plat_pel_arrives;
        float gondola_01_wake_state;
        float gondola_01_state;
        EffectTag splashy;
        bool tower3_cortana_cont;
        bool tower3_done_blabbing;
        bool elev_under_scene_gone;
        bool sunken_holo_trans;
        bool sunken_holo_chant;
        int sunken_sniper_total;
        int sunken_hg_total;
        int sunken_jacks_total;
        bool sunken_save_again;
        bool island_holo_trans;
        bool island_holo_chant;
        bool island_pelican_arrived;
        float gondola_02_wake_state;
        float gondola_02_state;
        bool bossfight_chatter;
        bool regret_dead;
        int regret_times_dead;
        int hg_count;
        int hg_delay;
        IGameObject regret_corpse;
        IGameObject regret_throne;
        EffectTag regret_teleport;
        EffectTag regret_blood;
        int regret_lives;
        public scnr_05b_deltatowers(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 60;
            this.tower1_holo_trans = false;
            this.tower1_holo_chant = true;
            this.bridges_sniper_count = 3;
            this.miranda_pel_comment_done = false;
            this.central_plat_pel_arrives = false;
            this.gondola_01_wake_state = 0F;
            this.gondola_01_state = 0F;
            this.splashy = GetTag<EffectTag>("effects\\scenarios\\solo\\deltatemple\\elevator_splash", 2244813691U);
            this.tower3_cortana_cont = false;
            this.tower3_done_blabbing = false;
            this.elev_under_scene_gone = false;
            this.sunken_holo_trans = false;
            this.sunken_holo_chant = true;
            this.sunken_sniper_total = 2;
            this.sunken_hg_total = 1;
            this.sunken_jacks_total = 2;
            this.sunken_save_again = false;
            this.island_holo_trans = false;
            this.island_holo_chant = true;
            this.island_pelican_arrived = false;
            this.gondola_02_wake_state = 0F;
            this.gondola_02_state = 0F;
            this.bossfight_chatter = true;
            this.regret_dead = false;
            this.regret_times_dead = 0;
            this.hg_count = 2;
            this.hg_delay = 600;
            this.regret_corpse = default(IGameObject);
            this.regret_throne = default(IGameObject);
            this.regret_teleport = GetTag<EffectTag>("effects\\gameplay\\regret_teleport", 2245206913U);
            this.regret_blood = GetTag<EffectTag>("effects\\contact\\collision\\blood_aoe\\blood_aoe_human", 4161214095U);
            this.regret_lives = 0;
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
        public async Task _05_intra1_01_predict_stub()
        {
            wake(new ScriptMethodReference(_05_intra1_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _05_intra1_02_predict_stub()
        {
            wake(new ScriptMethodReference(_05_intra1_02_predict));
            print("just started 02 predict");
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _05_intra1_03_predict_stub()
        {
            wake(new ScriptMethodReference(_05_intra1_03_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _05_intra2_01_predict_stub()
        {
            wake(new ScriptMethodReference(_05_intra2_01_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task _05_outro_01_predict_stub()
        {
            wake(new ScriptMethodReference(_05_outro_01_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task _05_outro_02_predict_stub()
        {
            wake(new ScriptMethodReference(_05_outro_02_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task _05_outro_03_predict_stub()
        {
            wake(new ScriptMethodReference(_05_outro_03_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task _05_outro_04_predict_stub()
        {
            wake(new ScriptMethodReference(_05_outro_04_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task _05_outro_05_predict_stub()
        {
            wake(new ScriptMethodReference(_05_outro_05_predict));
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task c05_intra1_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\music\\c05_intra1_02_mus", 3839165279U), default(IGameObject), 1F);
            print("c05_intra1 score 01 start");
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c05_intra1_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_01_fol", 3839230816U), default(IGameObject), 1F);
            print("c05_intra1 foley 01 start");
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c05_2010_cor()
        {
            await sleep(17);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2010_cor", 3839296353U), default(IGameObject), 1F);
            cinematic_subtitle("c05_2010_cor", 1F);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c05_2020_cor()
        {
            await sleep(135);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2020_cor", 3839361890U), cortana.Entity, 1F);
            cinematic_subtitle("c05_2020_cor", 1F);
            unit_set_emotional_state(cortana.Entity, "angry", 0.5F, 60);
            print("cortana - angry .5 60");
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c05_2030_cor()
        {
            await sleep(200);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2030_cor", 3839427427U), cortana.Entity, 1F);
            cinematic_subtitle("c05_2030_cor", 3F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c05_2040_mas()
        {
            await sleep(299);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2040_mas", 3839492964U), chief.Entity, 1F);
            cinematic_subtitle("c05_2040_mas", 1F);
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c05_2050_por()
        {
            await sleep(357);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2050_por", 3839558501U), regret.Entity, 1F);
            cinematic_subtitle("c05_2050_por", 8F);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c05_2060_cor()
        {
            await sleep(553);
            unit_set_emotional_state(cortana.Entity, "annoyed", 0.25F, 60);
            print("cortana - annoyed .25 60");
            await sleep(30);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2060_cor", 3839624038U), cortana.Entity, 1F);
            cinematic_subtitle("c05_2060_cor", 1F);
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c05_2070_mas()
        {
            await sleep(622);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2070_mas", 3839689575U), chief.Entity, 1F);
            cinematic_subtitle("c05_2070_mas", 2F);
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c05_2080_mir()
        {
            await sleep(678);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2080_mir", 3839755112U), default(IGameObject), 1F, "radio_default_in");
            cinematic_subtitle("c05_2080_mir", 1F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task cortana_appear()
        {
            await sleep(98);
            print("cortana appears");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 3839820649U), cortana_base.Entity, "marker");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c05_intra1_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(-38F, 310F, 0.180392F, 0.160784F, 0.113725F);
            cinematic_lighting_set_secondary_light(-46F, 162F, 0.458824F, 0.466667F, 0.74902F);
            cinematic_lighting_set_ambient_light(0.0823529F, 0.0470588F, 0.00784314F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(cortana.Entity, true);
            object_uses_cinematic_lighting(regret.Entity, true);
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task c05_intra1_02_problem_actors()
        {
            print("problem actors");
            object_create_anew(miranda);
            object_create_anew(johnson);
            object_create_anew(pilot);
            object_create_anew(pelican_01);
            object_create_anew(holo_index);
            object_create_anew(iac_bridge);
            object_create_anew(matte_horizon);
            object_cinematic_lod(miranda.Entity, true);
            object_cinematic_lod(johnson.Entity, true);
            object_cinematic_lod(pilot.Entity, true);
            object_cinematic_lod(pelican_01.Entity, true);
            object_cinematic_lod(holo_index.Entity, true);
            object_cinematic_lod(iac_bridge.Entity, true);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(iac_bridge.Entity, true);
            object_hide(johnson.Entity, true);
            object_hide(pilot.Entity, true);
            object_hide(pelican_01.Entity, true);
            object_hide(matte_horizon.Entity, true);
        }

        [ScriptMethod(46, Lifecycle.Static)]
        public async Task c05_intra1_01_setup()
        {
            object_create_anew(chief);
            object_create_anew(cortana);
            object_create_anew(regret);
            object_create_anew(throne_regret);
            object_cinematic_lod(chief.Entity, true);
            object_cinematic_lod(cortana.Entity, true);
            object_cinematic_lod(regret.Entity, true);
            object_cinematic_lod(throne_regret.Entity, true);
            cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            objects_attach(regret.Entity, "driver", throne_regret.Entity, "driver_cinematic");
            wake(new ScriptMethodReference(c05_2010_cor));
            wake(new ScriptMethodReference(c05_2020_cor));
            wake(new ScriptMethodReference(c05_2030_cor));
            wake(new ScriptMethodReference(c05_2040_mas));
            wake(new ScriptMethodReference(c05_2050_por));
            wake(new ScriptMethodReference(c05_2060_cor));
            wake(new ScriptMethodReference(c05_2070_mas));
            wake(new ScriptMethodReference(c05_2080_mir));
            wake(new ScriptMethodReference(c05_intra1_score_01));
            wake(new ScriptMethodReference(c05_intra1_foley_01));
            wake(new ScriptMethodReference(cortana_appear));
            wake(new ScriptMethodReference(c05_intra1_cinematic_light_01));
            cinematic_set_near_clip_distance(0.05F);
        }

        [ScriptMethod(47, Lifecycle.Static)]
        public async Task c05_intra1_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("deltatowers_intra1");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            await this._05_intra1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\music\\c05_intra1_02_mus", 3839165279U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_01_fol", 3839230816U));
            await sleep(this.prediction_offset);
            await this.c05_intra1_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra1\\05_intra1", 3840738167U), "05_intra1_01", default(IUnit), anchor_flag_intra1a);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intra1\\05_intra1", 3840803704U), "chief_01", false, anchor_intra1a.Entity);
            custom_animation_relative(regret.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\05_intra1\\05_intra1", 3840869241U), "regret_01", false, anchor_intra1a.Entity);
            await sleep(5);
            fade_in(1F, 1F, 1F, 15);
            await sleep(94);
            custom_animation_relative(cortana.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\05_intra1\\05_intra1", 3841000315U), "cortana_01", false, anchor_intra1a.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._05_intra1_02_predict_stub();
            await this.c05_intra1_02_problem_actors();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_02_fol", 3841131389U));
            await sleep((short)((float)camera_time() - 5));
            fade_out(1F, 1F, 1F, 5);
            await sleep(5);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task c05_intra1_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_02_fol", 3841131389U), default(IGameObject), 1F);
            print("c05_intra1 foley 02 start");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task c05_2090_mir()
        {
            unit_set_emotional_state(miranda.Entity, "pensive", 0.5F, 0);
            print("miranda - pensive .5 0");
            await sleep(7);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2090_mir", 3841196926U), miranda.Entity, 1F);
            cinematic_subtitle("c05_2090_mir", 5F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task c05_2100_mir()
        {
            await sleep(162);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2100_mir", 3841262463U), miranda.Entity, 1F);
            cinematic_subtitle("c05_2100_mir", 7F);
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task c05_2110_jon()
        {
            await sleep(373);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2110_jon", 3841328000U), johnson.Entity, 1F, "radio_default_loop");
            cinematic_subtitle("c05_2110_jon", 3F);
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task c05_2120_mir()
        {
            await sleep(455);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2120_mir", 3841393537U), miranda.Entity, 1F);
            cinematic_subtitle("c05_2120_mir", 2F);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c05_2130_mir()
        {
            await sleep(509);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2130_mir", 3841459074U), miranda.Entity, 1F);
            cinematic_subtitle("c05_2130_mir", 2F);
            texture_camera_off();
            await sleep(45);
            unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 60);
            print("miranda - angry .25 60");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c05_2140_jon()
        {
            await sleep(574);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2140_jon", 3841524611U), johnson.Entity, 1F, "radio_default_loop");
            cinematic_subtitle("c05_2140_jon", 1F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task intra1_texture_camera_on()
        {
            object_create_anew(texture_camera);
            scenery_animation_start_relative(texture_camera.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\05_intra1\\05_intra1", 3841590148U), "texture_camera_02", anchor_intra1b.Entity);
            await sleep(150);
            print("texture camera on");
            texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            object_hide(johnson.Entity, false);
            object_hide(pilot.Entity, false);
            object_hide(pelican_01.Entity, false);
            object_hide(matte_horizon.Entity, false);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task c05_intra1_cinematic_light_02()
        {
            cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            object_uses_cinematic_lighting(miranda.Entity, true);
            object_uses_cinematic_lighting(iac_bridge.Entity, true);
            object_uses_cinematic_lighting(johnson.Entity, true);
            object_uses_cinematic_lighting(pilot.Entity, true);
            object_uses_cinematic_lighting(index.Entity, true);
            object_uses_cinematic_lighting(pelican_01.Entity, true);
        }

        [ScriptMethod(57, Lifecycle.Static)]
        public async Task c05_intra1_02_setup()
        {
            object_create_anew(holo_library);
            object_create_anew(matte_horizon);
            object_cinematic_lod(holo_library.Entity, true);
            wake(new ScriptMethodReference(c05_2090_mir));
            wake(new ScriptMethodReference(c05_2100_mir));
            wake(new ScriptMethodReference(c05_2110_jon));
            wake(new ScriptMethodReference(c05_2120_mir));
            wake(new ScriptMethodReference(c05_2130_mir));
            wake(new ScriptMethodReference(c05_2140_jon));
            wake(new ScriptMethodReference(c05_intra1_foley_02));
            wake(new ScriptMethodReference(intra1_texture_camera_on));
            wake(new ScriptMethodReference(c05_intra1_cinematic_light_02));
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c05_intra1_02_cleanup()
        {
            object_destroy(miranda.Entity);
            object_destroy(johnson.Entity);
            object_destroy(pilot.Entity);
            object_destroy(holo_index.Entity);
            object_destroy(holo_library.Entity);
            object_destroy(pelican_01.Entity);
            object_destroy(iac_bridge.Entity);
            object_destroy(texture_camera.Entity);
            object_destroy(matte_horizon.Entity);
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c05_intra1_scene_02()
        {
            await this.c05_intra1_02_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra1\\05_intra1", 3840738167U), "05_intra1_02", default(IUnit), anchor_flag_intra1b);
            custom_animation_relative(miranda.Entity, GetTag<AnimationGraphTag>("objects\\characters\\miranda\\05_intra1\\05_intra1", 3841655685U), "miranda_02", false, anchor_intra1b.Entity);
            custom_animation_relative(johnson.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\05_intra1\\05_intra1", 3846439886U), "johnson_02", false, anchor_intra1b.Entity);
            custom_animation_relative(pilot.Entity, GetTag<AnimationGraphTag>("objects\\characters\\marine\\05_intra1\\05_intra1", 3846439886U), "marine01_02", false, anchor_intra1b.Entity);
            scenery_animation_start_relative(iac_bridge.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\05_intra1\\05_intra1", 3846570960U), "bridge_02", anchor_intra1b.Entity);
            scenery_animation_start_relative(holo_index.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\index_holo_human\\05_intra1\\05_intra1", 3846636497U), "index_holo_human_02", anchor_intra1b.Entity);
            scenery_animation_start_relative(holo_library.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\mount_doom_holo\\05_intra1\\05_intra1", 3846702034U), "mount_doom_holo_02", anchor_intra1b.Entity);
            scenery_animation_start_relative(matte_horizon.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\05_intra1\\05_intra1", 3846767571U), "delta_horizon_02", anchor_intra1b.Entity);
            custom_animation_relative(pelican_01.Entity, GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\05_intra1\\05_intra1", 3846833108U), "pelican_02", false, anchor_intra1b.Entity);
            await sleep(30);
            fade_in(1F, 1F, 1F, 5);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._05_intra1_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_03_fol", 3846898645U));
            await sleep((short)camera_time());
            await this.c05_intra1_02_cleanup();
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c05_intra1_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_03_fol", 3846898645U), default(IGameObject), 1F);
            print("c05_intra1 foley 03 start");
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task c05_2150_mir()
        {
            unit_set_emotional_state(cortana.Entity, "angry", 0.5F, 0);
            print("cortana - angry .5 0");
            await sleep(0);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2150_mir", 3846964182U), default(IGameObject), 1F, "radio_default_loop");
            cinematic_subtitle("c05_2150_mir", 3F);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task c05_2160_mir()
        {
            await sleep(99);
            sound_impulse_start_effect(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2160_mir", 3847029719U), default(IGameObject), 1F, "radio_default_out");
            cinematic_subtitle("c05_2160_mir", 2F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task cortana_disappear()
        {
            await sleep(35);
            print("cortana disappears");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 3839820649U), cortana_base.Entity, "marker");
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task c05_intra1_cinematic_light_03()
        {
            cinematic_lighting_set_primary_light(-38F, 310F, 0.180392F, 0.160784F, 0.113725F);
            cinematic_lighting_set_secondary_light(-46F, 162F, 0.458824F, 0.466667F, 0.74902F);
            cinematic_lighting_set_ambient_light(0.0823529F, 0.0470588F, 0.00784314F);
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task c05_intra1_03_setup()
        {
            wake(new ScriptMethodReference(c05_2150_mir));
            wake(new ScriptMethodReference(c05_2160_mir));
            wake(new ScriptMethodReference(c05_intra1_foley_03));
            wake(new ScriptMethodReference(c05_intra1_cinematic_light_03));
            wake(new ScriptMethodReference(cortana_disappear));
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task c05_intra1_03_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(regret.Entity);
            object_destroy(throne_regret.Entity);
            object_destroy(cortana_base.Entity);
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task c05_intra1_scene_03()
        {
            await this.c05_intra1_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra1\\05_intra1", 3840738167U), "05_intra1_03", default(IUnit), anchor_flag_intra1a);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intra1\\05_intra1", 3840803704U), "chief_03", false, anchor_intra1a.Entity);
            custom_animation_relative(cortana.Entity, GetTag<AnimationGraphTag>("objects\\characters\\cortana\\05_intra1\\05_intra1", 3841000315U), "cortana_03", false, anchor_intra1a.Entity);
            await sleep(50);
            object_destroy(cortana.Entity);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            await this.c05_intra1_03_cleanup();
        }

        [ScriptMethod(68, Lifecycle.Static)]
        public async Task c05_intra1()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("bsp_01"));
            await sleep(1);
            sound_class_set_gain("amb", 0F, 0);
            sound_class_set_gain("vehicle", 0F, 0);
            await this.c05_intra1_scene_01();
            await this.c05_intra1_scene_02();
            await this.c05_intra1_scene_03();
            sound_class_set_gain("amb", 0F, 15);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c05_intra2_foley()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra2\\foley\\c05_intra2_01_fol", 3847095256U), default(IGameObject), 1F);
            print("c05_intra2 foley start");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c05_3010_cor()
        {
            await sleep(275);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_3010_cor", 3847160793U), default(IGameObject), 1F);
            cinematic_subtitle("c05_3010_cor", 2F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task c05_3020_cor()
        {
            await sleep(359);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_3020_cor", 3847226330U), default(IGameObject), 1F);
            cinematic_subtitle("c05_3020_cor", 2F);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task c05_3030_cor()
        {
            await sleep(513);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_3030_cor", 3847291867U), default(IGameObject), 1F);
            cinematic_subtitle("c05_3030_cor", 3F);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task c05_intra2_dof()
        {
            await sleep(250);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(250);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c05_intra2_cinematic_light()
        {
            cinematic_lighting_set_primary_light(24F, 272F, 0.639216F, 0.54902F, 0.388235F);
            cinematic_lighting_set_secondary_light(-27F, 140F, 0.329412F, 0.180392F, 0.0509804F);
            cinematic_lighting_set_ambient_light(0.0784314F, 0.0784314F, 0.101961F);
            object_uses_cinematic_lighting(chief.Entity, true);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task fleet_arrival()
        {
            await sleep(251);
            print("fleet arrival");
            object_create_anew(intra2_fleet);
        }

        [ScriptMethod(76, Lifecycle.Static)]
        public async Task c05_intra2_setup()
        {
            object_create(chief);
            object_cinematic_lod(chief.Entity, true);
            cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            wake(new ScriptMethodReference(c05_3010_cor));
            wake(new ScriptMethodReference(c05_3020_cor));
            wake(new ScriptMethodReference(c05_3030_cor));
            wake(new ScriptMethodReference(c05_intra2_foley));
            wake(new ScriptMethodReference(fleet_arrival));
            wake(new ScriptMethodReference(c05_intra2_dof));
            wake(new ScriptMethodReference(c05_intra2_cinematic_light));
        }

        [ScriptMethod(77, Lifecycle.Static)]
        public async Task c05_intra2()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("bsp_03"));
            await sleep(1);
            camera_control(true);
            cinematic_start_movie("deltatowers_intra2");
            cinematic_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this._05_intra1_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra2\\foley\\c05_intra2_01_fol", 3847095256U));
            await sleep(this.prediction_offset);
            await this.c05_intra2_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra2\\05_intra2", 3847357404U), "05_intra2_01", default(IUnit), anchor_flag_outro);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intra2\\05_intra2", 3847422941U), "chief_01", false, anchor_outro.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - 15));
            fade_out(1F, 1F, 1F, 15);
            await sleep(15);
            object_destroy(chief.Entity);
            object_destroy(intra2_fleet.Entity);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c05_outro_score_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\music\\c05_outro_01_mus", 3847488478U), default(IGameObject), 1F);
            print("c05_outro score 01 start");
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c05_outro_foley_01()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_01_fol", 3847554015U), default(IGameObject), 1F);
            print("c05_outro foley 01 start");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task effect_dust_scrape()
        {
            time_code_reset();
            await sleep(240);
            print("effect - dust scrape");
            object_create_anew(outro_dust_scrape);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c05_outro_01_dof()
        {
            await sleep(55);
            cinematic_screen_effect_start(true);
            cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            print("rack focus");
            await sleep(130);
            cinematic_screen_effect_stop();
            print("rack focus stop");
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c05_outro_cinematic_light_01()
        {
            cinematic_lighting_set_primary_light(24F, 272F, 0.639216F, 0.54902F, 0.388235F);
            cinematic_lighting_set_secondary_light(-27F, 140F, 0.329412F, 0.180392F, 0.0509804F);
            cinematic_lighting_set_ambient_light(0.0784314F, 0.0784314F, 0.101961F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(carrier.Entity, true);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c05_outro_problem_actors()
        {
            print("problem actors");
            object_create_anew(chief);
            object_cinematic_lod(chief.Entity, true);
        }

        [ScriptMethod(84, Lifecycle.Static)]
        public async Task c05_outro_01_setup()
        {
            object_create_anew(carrier);
            object_cinematic_lod(carrier.Entity, true);
            wake(new ScriptMethodReference(c05_outro_score_01));
            wake(new ScriptMethodReference(c05_outro_foley_01));
            wake(new ScriptMethodReference(effect_dust_scrape));
            wake(new ScriptMethodReference(c05_outro_01_dof));
            wake(new ScriptMethodReference(c05_outro_cinematic_light_01));
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\covenant_beam", 3847619552U), carrier.Entity, "beam");
        }

        [ScriptMethod(85, Lifecycle.Static)]
        public async Task c05_outro_scene_01()
        {
            fade_out(1F, 1F, 1F, 0);
            camera_control(true);
            cinematic_start_movie("deltatowers_outro");
            cinematic_start();
            cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            camera_set_field_of_view(60F, 0);
            cinematic_lightmap_shadow_enable();
            await this._05_outro_01_predict_stub();
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\music\\c05_outro_01_mus", 3847488478U));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_01_fol", 3847554015U));
            wake(new ScriptMethodReference(c05_outro_problem_actors));
            await sleep(this.prediction_offset);
            await this.c05_outro_01_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_01", default(IUnit), anchor_flag_outro);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_01", false, anchor_outro.Entity);
            scenery_animation_start_relative(carrier.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\05_outro\\05_outro", 3848930292U), "cruiser_01", anchor_outro.Entity);
            fade_in(1F, 1F, 1F, 15);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._05_outro_02_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_02_fol", 3848995829U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task c05_outro_foley_02()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_02_fol", 3848995829U), default(IGameObject), 1F);
            print("c05_outro foley 02 start");
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task effect_dust_land()
        {
            await sleep(59);
            print("effect - dust land");
            object_create_anew(outro_dust_land);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task c05_outro_scene_02()
        {
            wake(new ScriptMethodReference(c05_outro_foley_02));
            wake(new ScriptMethodReference(effect_dust_land));
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_02", default(IUnit), anchor_flag_outro);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_02", false, anchor_outro.Entity);
            scenery_animation_start_relative(carrier.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\05_outro\\05_outro", 3848930292U), "cruiser_02", anchor_outro.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._05_outro_03_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_03_fol", 3849061366U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task c05_outro_foley_03()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_03_fol", 3849061366U), default(IGameObject), 1F);
            print("c05_outro foley 03 start");
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task c05_outro_fov_01()
        {
            await sleep(122);
            camera_set_field_of_view(7F, 0);
        }

        [ScriptMethod(91, Lifecycle.Static)]
        public async Task c05_outro_03_setup()
        {
            wake(new ScriptMethodReference(c05_outro_foley_03));
            wake(new ScriptMethodReference(c05_outro_fov_01));
        }

        [ScriptMethod(92, Lifecycle.Static)]
        public async Task c05_outro_scene_03()
        {
            await this.c05_outro_03_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_03", default(IUnit), anchor_flag_outro);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_03", false, anchor_outro.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._05_outro_04_predict_stub();
            await sleep((short)((float)camera_time() - this.sound_offset));
            sound_impulse_predict(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_04_fol", 3849126903U));
            await sleep((short)camera_time());
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task c05_outro_foley_04()
        {
            await sleep(0);
            sound_impulse_start(GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_04_fol", 3849126903U), default(IGameObject), 1F);
            print("c05_outro foley 04 start");
        }

        [ScriptMethod(94, Lifecycle.Static)]
        public async Task c05_outro_scene_04()
        {
            wake(new ScriptMethodReference(c05_outro_foley_04));
            object_create_anew(outro_beam);
            print("start beam");
            camera_set_field_of_view(60F, 0);
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_04", default(IUnit), anchor_flag_outro);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_04", false, anchor_outro.Entity);
            scenery_animation_start_relative(carrier.Entity, GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\05_outro\\05_outro", 3848930292U), "cruiser_04", anchor_outro.Entity);
            await sleep((short)((float)camera_time() - this.prediction_offset));
            await this._05_outro_05_predict_stub();
            await sleep((short)((float)camera_time() - 1));
            fade_out(0F, 0F, 0F, 0);
            await sleep(60);
            object_destroy(outro_beam.Entity);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x07_0220_grv()
        {
            await sleep(207);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0220_grv", 3849192440U), default(IGameObject), 1F);
            cinematic_subtitle("x07_0220_grv", 7F);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x07_0230_grv()
        {
            await sleep(426);
            sound_impulse_start(GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0230_grv", 3849257977U), default(IGameObject), 1F);
            cinematic_subtitle("x07_0230_grv", 6F);
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task c05_outro_bubbles()
        {
            object_create_anew(bubbles_01);
            objects_attach(chief.Entity, "", bubbles_01.Entity, "");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles01");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles04");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles06");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles08");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles09");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles11");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles12");
            effect_new_on_object_marker(GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles14");
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task c05_outro_caustic()
        {
            time_code_reset();
            await sleep(127);
            print("create caustic light");
            object_create_anew_containing("caustic_light");
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task c05_outro_cinematic_light_05()
        {
            cinematic_lighting_set_primary_light(54F, 138F, 0.129412F, 0.121569F, 0.0705882F);
            cinematic_lighting_set_secondary_light(-46F, 238F, 0.0705882F, 0.160784F, 0.329412F);
            cinematic_lighting_set_ambient_light(0.0901961F, 0.129412F, 0.219608F);
            object_uses_cinematic_lighting(chief.Entity, true);
            object_uses_cinematic_lighting(rubble.Entity, true);
            object_uses_cinematic_lighting(tentacle_capture_01.Entity, true);
            object_uses_cinematic_lighting(tentacle_capture_02.Entity, true);
        }

        [ScriptMethod(100, Lifecycle.Static)]
        public async Task c05_outro_05_setup()
        {
            object_create_anew(rubble);
            object_create_anew(tentacle_capture_01);
            object_create_anew(tentacle_capture_02);
            wake(new ScriptMethodReference(x07_0220_grv));
            wake(new ScriptMethodReference(x07_0230_grv));
            wake(new ScriptMethodReference(c05_outro_cinematic_light_05));
            wake(new ScriptMethodReference(c05_outro_bubbles));
            wake(new ScriptMethodReference(c05_outro_caustic));
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task c05_outro_05_cleanup()
        {
            object_destroy(chief.Entity);
            object_destroy(rubble.Entity);
            object_destroy(carrier.Entity);
            object_destroy_containing("caustic_light");
            object_destroy_containing("tentacle");
            object_destroy_containing("bubbles");
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task c05_outro_scene_05()
        {
            await this.c05_outro_05_setup();
            camera_set_animation_relative(GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_05", default(IUnit), anchor_flag_outro);
            custom_animation_relative(chief.Entity, GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_05", false, anchor_outro.Entity);
            scenery_animation_start_relative(rubble.Entity, GetTag<AnimationGraphTag>("objects\\cinematics\\effects\\05_outro_rubble\\05_outro_rubble", 3849716736U), "05_outro_05", anchor_outro.Entity);
            scenery_animation_start_relative(tentacle_capture_01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\05_outro\\05_outro", 3849782273U), "tentacle1_05", anchor_outro.Entity);
            scenery_animation_start_relative(tentacle_capture_02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\05_outro\\05_outro", 3849782273U), "tentacle2_05", anchor_outro.Entity);
            fade_in(0F, 0F, 0F, 60);
            await sleep((short)((float)camera_time() - 30));
            fade_out(0F, 0F, 0F, 60);
            await sleep(60);
            await this.c05_outro_05_cleanup();
            cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task c05_outro()
        {
            texture_cache_flush();
            geometry_cache_flush();
            switch_bsp_by_name(GetReference<IBsp>("bsp_03"));
            await sleep(1);
            await this.c05_outro_scene_01();
            await this.c05_outro_scene_02();
            await this.c05_outro_scene_03();
            await this.c05_outro_scene_04();
            await this.c05_outro_scene_05();
        }

        [ScriptMethod(104, Lifecycle.CommandScript)]
        public async Task long_pause()
        {
            cs_abort_on_alert(true);
            sleep_forever();
        }

        [ScriptMethod(105, Lifecycle.CommandScript)]
        public async Task forever_pause()
        {
            cs_pause(-1F);
        }

        [ScriptMethod(106, Lifecycle.CommandScript)]
        public async Task abort()
        {
            cs_pause(0.1F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task _05b_title0()
        {
            await this.cinematic_fade_from_white_bars();
            await sleep(30);
            cinematic_set_title(title_1);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task _05b_title1()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task _05b_title1_alt()
        {
            hud_cinematic_fade(0F, 0.5F);
            cinematic_show_letterbox(true);
            await sleep(30);
            cinematic_set_title(title_2alt);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task _05b_title2()
        {
            await this.cinematic_fade_from_white_bars();
            await sleep(30);
            cinematic_set_title(title_3);
            await sleep(150);
            hud_cinematic_fade(1F, 0.5F);
            cinematic_show_letterbox(false);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task objective_towers_set()
        {
            await sleep(30);
            print("new objective set:");
            print("make your way through the first set of towers.");
            objectives_show_up_to(0);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task objective_towers_clear()
        {
            print("objective complete:");
            print("make your way through the first set of towers.");
            objectives_finish_up_to(0);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task objective_gondola1_set()
        {
            await sleep(30);
            print("new objective set:");
            print("ride the gondola to the far towers.");
            objectives_show_up_to(1);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task objective_gondola1_clear()
        {
            print("objective complete:");
            print("ride the gondola to the far towers.");
            objectives_finish_up_to(1);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task objective_sunken_set()
        {
            await sleep(30);
            print("new objective set:");
            print("pass through the submerged structures.");
            objectives_show_up_to(2);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task objective_sunken_clear()
        {
            print("objective complete:");
            print("pass through the submerged structures.");
            objectives_finish_up_to(2);
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task objective_temple_set()
        {
            await sleep(30);
            print("new objective set:");
            print("reach the main temple.");
            objectives_show_up_to(3);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task objective_temple_clear()
        {
            print("objective complete:");
            print("reach the main temple.");
            objectives_finish_up_to(3);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task objective_regret_set()
        {
            await sleep(30);
            print("new objective set:");
            print("kill the prophet of regret, and escape.");
            objectives_show_up_to(4);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task objective_regret_clear()
        {
            print("objective complete:");
            print("kill the prophet of regret, and escape.");
            objectives_finish_up_to(4);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task music_05b_01_start()
        {
            print("music 05b_01 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_01", 2240750397U), default(IGameObject), 1F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task music_05b_01_stop()
        {
            print("music 05b_01 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_01", 2240750397U));
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task music_05b_02_start()
        {
            print("music 05b_02 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_02", 2241274693U), default(IGameObject), 1F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task music_05b_02_stop()
        {
            print("music 05b_02 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_02", 2241274693U));
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task music_05b_03_start()
        {
            print("music 05b_03 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_03", 2241667915U), default(IGameObject), 1F);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task music_05b_03_stop()
        {
            print("music 05b_03 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_03", 2241667915U));
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task music_05b_04_start()
        {
            print("music 05b_04 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_04", 2242192211U), default(IGameObject), 1F);
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task music_05b_04_stop()
        {
            print("music 05b_04 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_04", 2242192211U));
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task music_05b_05_start()
        {
            print("music 05b_05 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_05", 2242585433U), default(IGameObject), 1F);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task music_05b_06_start()
        {
            print("music 05b_06 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_06", 2242847581U), default(IGameObject), 1F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task music_05b_06_stop()
        {
            print("music 05b_06 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_06", 2242847581U));
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task music_05b_07_start()
        {
            print("music 05b_07 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_07", 2243240803U), default(IGameObject), 1F);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task music_05b_08_start()
        {
            print("music 05b_08 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_08", 2243634025U), default(IGameObject), 1F);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task music_05b_09_start()
        {
            print("music 05b_09 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_09", 2243896173U), default(IGameObject), 1F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task music_05b_09_start_alt()
        {
            print("music 05b_09 start alt");
            sound_looping_set_alternate(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_09", 2243896173U), true);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task music_05b_09_stop()
        {
            print("music 05b_09 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_09", 2243896173U));
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task music_05b_10_start()
        {
            print("music 05b_10 start");
            sound_looping_start(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_10", 2244420469U), default(IGameObject), 1F);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task music_05b_10_stop()
        {
            print("music 05b_10 stop");
            sound_looping_stop(GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_10", 2244420469U));
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            kill_volume_disable(kill_no_riders_up);
            kill_volume_disable(kill_bsp03);
            kill_volume_disable(kill_temple_wings);
            await sleep_until(async () => (short)structure_bsp_index() == 2);
            kill_volume_enable(kill_bsp03);
            kill_volume_enable(kill_temple_wings);
            kill_volume_disable(kill_bsp01_01);
            kill_volume_disable(kill_bsp01_02);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task tower1_holo_looper()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant1a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3000"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant2b", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3001"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant2c", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3002"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant3a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3003"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant3c", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3004"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant5a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3005"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        custom_animation(regret01.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant6a", true);
                        await sleep(ai_play_line_on_object(regret01.Entity, "3006"));
                        await sleep((short)random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task prep_return_from_intro()
        {
            object_create_anew(in_game_throne);
            object_create_anew(regret01);
            objects_attach(in_game_throne.Entity, "driver", regret01.Entity, "");
            ai_disregard(regret01.Entity, true);
            ai_place(initial_allies.Squad, 2);
            object_teleport(await this.player0(), tower1_player0);
            object_teleport(await this.player1(), tower1_player1);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task tower1_cortana_comment()
        {
            await sleep_until(async () => volume_test_objects(vol_tower1_exit, players()) == true || volume_test_objects(vol_tower1_exit_01, players()) == true || volume_test_objects(vol_tower1_exit_02, players()) == true, 30, 300);
            ai_dialogue_enable(false);
            await sleep(60);
            if (volume_test_objects(vol_tower1_exit, players()) == false && volume_test_objects(vol_tower1_exit_01, players()) == false && volume_test_objects(vol_tower1_exit_02, players()) == false && await this.player_count() > 0)
            {
                print("cortana: 'you know, i think the forerunners built these new structures...'");
                print("'...around the old - to protect them, honor them...'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0810"));
                await sleep(30);
                print("'pure speculation, mind you. i'd need to make a thorough survey to be sure.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0820"));
            }

            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task tower1_start()
        {
            data_mine_set_mission_segment("05b_1_tower1");
            game_save_immediate();
            await sleep(90);
            ai_place(tower1_buggers_01.Squad, 4);
            await sleep(90);
            if (await this.difficulty_legendary())
            {
                ai_place(tower1_elites_01.Squad, 2);
            }
            else
            {
                ai_place(tower1_elites_01.Squad, 1);
            }

            wake(new ScriptMethodReference(tower1_holo_looper));
            await sleep_until(async () => (short)ai_living_count(tower1_enemies) < 3 || volume_test_objects(vol_tower1_upper, players()) == true || volume_test_objects(vol_tower1_upper_right, players()) == true);
            ai_place(tower1_buggers_02.Squad, (short)(4 - (float)ai_living_count(tower1_buggers_01.Squad)));
            await sleep_until(async () => (short)ai_living_count(tower1_enemies) < 2 || volume_test_objects(vol_tower1_upper_right, players()) == true);
            if (await this.difficulty_legendary())
            {
                ai_place(tower1_elites_02.Squad, (short)(2 - (float)ai_living_count(tower1_elites_01.Squad)));
            }
            else
            {
                ai_place(tower1_elites_02.Squad, (short)(1 - (float)ai_living_count(tower1_elites_01.Squad)));
            }

            await sleep_until(async () => (short)ai_living_count(tower1_enemies) < 1 || volume_test_objects(vol_tower1_exit, players()) == true || volume_test_objects(vol_tower1_exit_01, players()) == true || volume_test_objects(vol_tower1_exit_02, players()) == true || volume_test_objects(vol_tower1_roof, players()) == true);
            game_save();
            wake(new ScriptMethodReference(tower1_cortana_comment));
            await sleep(60);
            wake(new ScriptMethodReference(music_05b_01_start));
        }

        [ScriptMethod(144, Lifecycle.CommandScript)]
        public async Task tower1_escape()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_nearest(GetReference<ISpatialPoint>("bridges"));
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task cortana_bridge_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_tower2_ext_entry, players()) == true || volume_test_objects(vol_central_platform, players()) == true, 30, 8000);
            if (volume_test_objects(vol_tower2_ext_entry, players()) == false && volume_test_objects(vol_central_platform, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'there's some sort of transport-system on the far side...'");
                print("'...of that center platform. let's check it out.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0860"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task bridges_start()
        {
            ai_disposable(tower1_enemies, true);
            data_mine_set_mission_segment("05b_2_bridges");
            ai_renew(all_allies);
            game_save();
            if (await this.difficulty_heroic())
            {
                this.bridges_sniper_count = 4;
            }

            if (await this.difficulty_legendary())
            {
                this.bridges_sniper_count = 5;
            }

            begin_random(async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    ai_place(bridge_jackals_01.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    ai_place(bridge_jackals_02.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    ai_place(bridge_jackals_03.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    ai_place(bridge_jackals_04.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    ai_place(bridge_jackals_05.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    ai_place(bridge_jackals_06.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            });
            ai_place(bridge_elites_01.Squad, 1);
            ai_place(bridge_elites_02.Squad, 1);
            ai_place(bridge_grunts_01.Squad, 2);
            ai_set_orders(all_allies, tower1_ext_allies);
            cs_run_command_script(all_allies, new ScriptMethodReference(tower1_escape));
            wake(new ScriptMethodReference(cortana_bridge_reminder));
            await sleep_until(async () => (short)ai_living_count(bridge_enemies) < 5 || volume_test_objects(vol_bridge, players()) == true || volume_test_objects(vol_tower2_ext_entry, players()) == true);
            game_save();
            if ((short)ai_living_count(bridge_enemies) < 8)
            {
                ai_place(bridge_grunts_02.Squad, (short)(3 - (float)ai_living_count(bridge_grunts_01.Squad)));
            }

            if ((short)ai_living_count(bridge_enemies) < 8)
            {
                ai_place(bridge_elites_03.Squad, 1);
            }

            await sleep_until(async () => (short)ai_living_count(bridge_enemies) < 5 || volume_test_objects(vol_tower2_ext_entry, players()) == true || volume_test_objects(vol_bridge_far_half, players()) == true);
            game_save();
            if ((short)ai_living_count(bridge_enemies) < 8)
            {
                ai_place(bridge_grunts_03.Squad, (short)(2 - (float)ai_living_count(bridge_grunts_02.Squad)));
            }

            if ((short)ai_living_count(bridge_enemies) < 8)
            {
                ai_place(bridge_jackals_07.Squad, 1);
            }

            await sleep_until(async () => volume_test_objects(vol_bridge, players()) == true || volume_test_objects(vol_tower2_ext_entry, players()) == true);
            ai_set_orders(all_allies, bridge_allies);
            await sleep_until(async () => (short)ai_living_count(bridge_enemies) < 5 || volume_test_objects(vol_tower2_ext_entry, players()) == true);
            game_save();
            if ((short)ai_living_count(bridge_enemies) < 8)
            {
                ai_place(bridge_grunts_04.Squad, (short)(2 - (float)ai_living_count(bridge_grunts_03.Squad)));
            }

            if ((short)ai_living_count(bridge_enemies) < 8)
            {
                ai_place(bridge_elites_04.Squad, 1);
            }

            await sleep_until(async () => volume_test_objects(vol_tower2_ext_entry, players()) == true);
            game_save();
            ai_set_orders(all_allies, tower2_ext_allies_01);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task tower2_cortana_comment()
        {
            await sleep_until(async () => volume_test_objects(vol_tower2_exit, players()) == true || volume_test_objects(vol_tower2_ext_exit, players()) == true || volume_test_objects(vol_tower2_exit_mid, players()) == true, 30, 300);
            ai_dialogue_enable(false);
            await sleep(60);
            if (volume_test_objects(vol_tower2_exit, players()) == false && volume_test_objects(vol_tower2_ext_exit, players()) == false && volume_test_objects(vol_tower2_exit_mid, players()) == true && await this.player_count() > 0)
            {
                print("cortana: 'i wish i had time to decipher these inscriptions.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0870"));
                await sleep(60);
                print("'the forerunners revered this place - that much is clear.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0880"));
                await sleep(60);
                print("'but was it a temple? a university? i can't say...'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0890"));
            }

            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task tower2_start()
        {
            await sleep_until(async () => volume_test_objects(vol_tower2_entry, players()) == true || volume_test_objects(vol_tower2_exit, players()) == true);
            ai_disposable(bridge_enemies, true);
            data_mine_set_mission_segment("05b_3_tower2");
            ai_renew(all_allies);
            wake(new ScriptMethodReference(music_05b_01_stop));
            game_save();
            ai_place(tower2_jackals_01.Squad, 2);
            ai_place(tower2_grunts_01.Squad, 2);
            ai_place(tower2_grunts_02.Squad, 2);
            await sleep_until(async () => volume_test_objects(vol_in_tower2, players()) == true);
            ai_set_orders(all_allies, tower2_allies);
            await sleep_until(async () => (short)ai_living_count(tower2_enemies) < 3 || volume_test_objects(vol_tower2_by_exit, players()) == true || volume_test_objects(vol_tower2_exit, players()) == true);
            game_save();
            ai_place(tower2_jackals_02.Squad, (short)(2 - (float)ai_living_count(tower2_jackals_01.Squad)));
            await sleep_until(async () => (short)ai_living_count(tower2_enemies) <= 0 || volume_test_objects(vol_tower2_exit, players()) == true);
            game_save();
            wake(new ScriptMethodReference(tower2_cortana_comment));
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task miranda_pelican_comment()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("miranda: 'cortana? the covenant's getting nosy.'");
            print("'i don't want to give away my position,'");
            print("'so i'm re-routing a few stragglers back to you.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0830"));
            await sleep(30);
            print("'i apologize. these pelicans are all the support you're going to get.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0840"));
            await sleep(60);
            print("'understood, ma'am.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0850"));
            this.miranda_pel_comment_done = true;
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_warn()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'a gondola's launching from the far towers!'");
            print("'big surprise: it's full of covenant reinforcements!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0900"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_comment()
        {
            if (volume_test_objects(vol_gondola_01, players()) == false && await this.player_count() > 0 && (bool)ai_trigger_test("done_fighting", central_platform_enemies) == true && (bool)ai_trigger_test("done_fighting", gondola_01_enemies) == true)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'well, they were nice enough to bring us a ride.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0910"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_reminder()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'this gondola won't bring us all the way to the main-temple,'");
            print("'but it'll get us close. let's get on-board.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0950"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(153, Lifecycle.CommandScript)]
        public async Task gondola_01_ally_comment()
        {
            cs_switch("ally01");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            print("ally_01: 'all aboard!'");
            cs_play_line("0920");
            cs_switch("ally02");
            cs_enable_pathfinding_failsafe(true);
            cs_abort_on_damage(true);
            await sleep(5);
            print("ally_02: 'i'll drive!'");
            cs_play_line("0930");
            cs_switch("ally01");
            await sleep(15);
            print("ally_01: 'what's to drive? it comes here. it goes there.'");
            cs_play_line("0940");
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task hunter_drop()
        {
            object_set_phantom_power(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), true);
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a01");
            await sleep(60);
            vehicle_unload(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a02");
            await sleep(60);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), false);
            ai_set_blind(central_platform_hunters.Squad, false);
        }

        [ScriptMethod(155, Lifecycle.CommandScript)]
        public async Task central_platform_dropship()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_0"), 10F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_1"), 10F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_2"), 5F);
            cs_vehicle_speed(0.5F);
            wake(new ScriptMethodReference(hunter_drop));
            cs_fly_to(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_2"), 1F);
            await sleep_until(async () => (short)ai_living_count(central_platform_phantom.Squad) < 2);
            await sleep(60);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_3"), GetReference<ISpatialPoint>("bsp1_airspace/ph_01_1"), 1F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_1"), 5F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_0"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_01_x"), 40F);
            ai_erase(central_platform_phantom.Squad);
        }

        [ScriptMethod(156, Lifecycle.CommandScript)]
        public async Task central_platform_pelican_path()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/p0"), 2F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel0"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel1"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel3"), 10F);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel4"), 5F);
            this.central_plat_pel_arrives = true;
            cs_vehicle_speed(0.3F);
            cs_fly_to(GetReference<ISpatialPoint>("bsp1_airspace/pel4"), 1F);
            ai_place(central_plat_pelican_allies.Squad, (short)(2 - (float)ai_living_count(allies_infantry)));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_p", ai_actors(central_plat_pelican_allies.Squad));
            cs_fly_to(GetReference<ISpatialPoint>("bsp1_airspace/pel5"), 1F);
            vehicle_unload(ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_p");
            await sleep_until(async () => (short)ai_living_count(central_plat_pelican.Squad) < 4);
            await sleep(60);
            cs_vehicle_speed(0.5F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bsp1_airspace/pel4"), GetReference<ISpatialPoint>("bsp1_airspace/pel3"), 1F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel3"), 2F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel2"), 2F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel2"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel1"), 20F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pel0"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/pelx"), 5F);
            ai_erase(central_plat_pelican.Squad);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task central_platform_pelican()
        {
            ai_place(central_plat_pelican.Squad, 1);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), true);
            cs_run_command_script(central_plat_pelican.pilot, new ScriptMethodReference(central_platform_pelican_path));
            object_create_anew(rack);
            objects_attach(ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_sc_01", rack.Entity, "pin");
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
            await sleep_until(async () =>
            {
                if (objects_can_see_object(players(), list_get(ai_actors(initial_allies.Squad), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(initial_allies.Squad), 0));
                }

                if (objects_can_see_object(players(), list_get(ai_actors(initial_allies.Squad), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(initial_allies.Squad), 0));
                }

                return this.central_plat_pel_arrives == true;
            });
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

        [ScriptMethod(158, Lifecycle.Static)]
        public async Task short_central_plat_pel()
        {
            ai_place(central_plat_pelican.Squad, 1);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), true);
            cs_run_command_script(central_plat_pelican.pilot, new ScriptMethodReference(central_platform_pelican_path));
            object_create_anew(rack);
            objects_attach(ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_sc_01", rack.Entity, "pin");
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
            await sleep_until(async () =>
            {
                if (objects_can_see_object(players(), list_get(ai_actors(initial_allies.Squad), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(initial_allies.Squad), 0));
                }

                if (objects_can_see_object(players(), list_get(ai_actors(initial_allies.Squad), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(initial_allies.Squad), 0));
                }

                return this.central_plat_pel_arrives == true;
            });
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

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task central_plat_ph_go()
        {
            ai_place(central_platform_hunters.Squad, 2);
            ai_place(central_platform_phantom.Squad, 1);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a", ai_actors(central_platform_hunters.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), true);
            cs_run_command_script(central_platform_phantom.pilot, new ScriptMethodReference(central_platform_dropship));
            await sleep(4000);
            object_destroy(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot));
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task gondola_01_wake()
        {
            await sleep_until(async () =>
            {
                if (device_get_position(gondola_01_a.Entity) > 0.37F && device_get_position(gondola_01_a.Entity) < 0.59F && device_get_position(gondola_01_a.Entity) > this.gondola_01_wake_state)
                {
                    object_clear_function_variable(gondola_01_a.Entity, "wake_forward");
                    object_clear_function_variable(gondola_01_a.Entity, "wake_backward");
                    object_set_function_variable(gondola_01_a.Entity, "wake_backward", 1F, 1F);
                    object_clear_function_variable(gondola_01_b.Entity, "wake_forward");
                    object_clear_function_variable(gondola_01_b.Entity, "wake_backward");
                    object_set_function_variable(gondola_01_b.Entity, "wake_backward", 1F, 1F);
                }

                if (device_get_position(gondola_01_a.Entity) > 0.37F && device_get_position(gondola_01_a.Entity) < 0.59F && device_get_position(gondola_01_a.Entity) < this.gondola_01_wake_state)
                {
                    object_clear_function_variable(gondola_01_a.Entity, "wake_forward");
                    object_clear_function_variable(gondola_01_a.Entity, "wake_backward");
                    object_set_function_variable(gondola_01_a.Entity, "wake_forward", 1F, 1F);
                    object_clear_function_variable(gondola_01_b.Entity, "wake_forward");
                    object_clear_function_variable(gondola_01_b.Entity, "wake_backward");
                    object_set_function_variable(gondola_01_b.Entity, "wake_forward", 1F, 1F);
                }

                if (device_get_position(gondola_01_a.Entity) == this.gondola_01_wake_state || device_get_position(gondola_01_a.Entity) < 0.37F || device_get_position(gondola_01_a.Entity) > 0.59F)
                {
                    object_clear_function_variable(gondola_01_a.Entity, "wake_forward");
                    object_clear_function_variable(gondola_01_a.Entity, "wake_backward");
                    object_clear_function_variable(gondola_01_b.Entity, "wake_forward");
                    object_clear_function_variable(gondola_01_b.Entity, "wake_backward");
                }

                this.gondola_01_wake_state = device_get_position(gondola_01_a.Entity);
                return device_get_position(gondola_01_a.Entity) == 0F;
            });
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task central_platform_start()
        {
            ai_disposable(tower2_enemies, true);
            data_mine_set_mission_segment("05b_4_central_platform");
            ai_renew(all_allies);
            game_save();
            ai_place(tower3_turrets.Squad, 2);
            objects_attach(gondola_01_b.Entity, "control_back", gondola_01_switch_front.Entity, "");
            objects_attach(gondola_01_a.Entity, "control_back", gondola_01_switch_back.Entity, "");
            device_set_position(gondola_01_launch_a.Entity, 1F);
            device_set_position(gondola_01_launch_b.Entity, 1F);
            device_set_position(gondola_01_a.Entity, 0.5F);
            device_set_position(gondola_01_b.Entity, 0.5F);
            ai_place(central_platform_elites_01.Squad, 1);
            ai_place(central_platform_elites_02.Squad, 1);
            ai_place(central_platform_jackals_01.Squad, 2);
            ai_place(central_platform_jackals_02.Squad, 2);
            ai_set_orders(all_allies, tower2_ext_allies_02);
            await sleep_until(async () => volume_test_objects(vol_near_gondola_01, players()) == true || volume_test_objects(vol_central_platform, players()) == true, 30, 150);
            wake(new ScriptMethodReference(gondola_01_wake));
            await sleep_until(async () => volume_test_objects(vol_near_gondola_01, players()) == true || volume_test_objects(vol_central_platform, players()) == true);
            ai_set_orders(all_allies, central_platform_allies);
            await sleep_until(async () => (short)ai_living_count(central_platform_enemies) < 2, 30, 4000);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", central_platform_enemies) == true);
            game_save();
            wake(new ScriptMethodReference(central_plat_ph_go));
            await sleep(450);
            game_save();
            await sleep_until(async () => (short)ai_living_count(central_platform_hunters.Squad) > 0 || (short)ai_living_count(central_platform_phantom.Squad) < 1);
            await sleep_until(async () => (short)ai_living_count(central_platform_hunters.Squad) < 1);
            await sleep(30);
            wake(new ScriptMethodReference(music_05b_02_start));
            await sleep(60);
            wake(new ScriptMethodReference(miranda_pelican_comment));
            await sleep_until(async () => this.miranda_pel_comment_done == true);
            game_save();
            wake(new ScriptMethodReference(central_platform_pelican));
            ai_place(gondola_01_elite_riders.Squad, 2);
            ai_place(gondola_01_grunt_riders.Squad, 3);
            device_set_position(gondola_01_a.Entity, 1F);
            device_set_position(gondola_01_b.Entity, 1F);
            await sleep_until(async () => device_get_position(gondola_01_a.Entity) > 0.75F);
            wake(new ScriptMethodReference(gondola_01_cortana_warn));
            await sleep_until(async () => device_get_position(gondola_01_a.Entity) == 1F);
            object_dynamic_simulation_disable(gondola_01_a.Entity, true);
            object_dynamic_simulation_disable(gondola_01_b.Entity, true);
            device_set_position(gondola_01_launch_a.Entity, 0F);
            device_set_position(gondola_01_launch_b.Entity, 0F);
            device_group_change_only_once_more_set(gondola_01_switch, true);
            ai_set_orders(gondola_01_grunt_riders.Squad, gondola_01_landing_01);
            game_save();
            wake(new ScriptMethodReference(music_05b_03_start));
            await sleep_until(async () => volume_test_objects(vol_near_gondola_01, players()) == true || (short)ai_living_count(gondola_01_enemies) < 3);
            ai_place(gondola_01_jackal_riders.Squad, 2);
            await sleep_until(async () => (short)ai_living_count(gondola_01_jackal_riders.Squad) <= 0 || volume_test_objects(vol_gondola_01, players()) == true, 30, 4000);
            ai_set_orders(gondola_01_elite_riders.Squad, gondola_01_landing_03);
            await sleep_until(async () => volume_test_objects(vol_gondola_01, players()) == true || (short)ai_living_count(gondola_01_enemies) <= 0 && (short)ai_living_count(central_platform_enemies) <= 0 && (short)ai_living_count(bridge_enemies) <= 0, 30, 4000);
            await sleep(30);
            wake(new ScriptMethodReference(gondola_01_cortana_comment));
            await sleep(150);
            ai_scene("gondola_01_allies_scene", new ScriptMethodReference(gondola_01_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            ai_set_orders(all_allies, gondola_01_allies);
            game_save();
            await sleep_until(async () => volume_test_objects(vol_gondola_01, players()) == true, 30, 1800);
            if (volume_test_objects(vol_gondola_01, players()) == false && await this.player_count() > 0)
            {
                wake(new ScriptMethodReference(gondola_01_cortana_reminder));
            }
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task short_central_plat_ph()
        {
            device_set_position_immediate(gondola_01_a.Entity, 0.5F);
            device_set_position_immediate(gondola_01_b.Entity, 0.5F);
            ai_place(central_platform_hunters.Squad, 2);
            ai_place(central_platform_phantom.Squad, 1);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a", ai_actors(central_platform_hunters.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), true);
            cs_run_command_script(central_platform_phantom.pilot, new ScriptMethodReference(central_platform_dropship));
            await sleep(4000);
            object_destroy(ai_vehicle_get_from_starting_location(central_platform_phantom.pilot));
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task assassin_ice_cream()
        {
            await sleep_until(async () => volume_test_objects_all(vol_assassins, players()) == false);
            object_create(assassins);
            ai_place(assassin_elites.Squad);
            ai_set_active_camo(assassin_elites.Squad, true);
            cs_run_command_script(assassin_elites.Squad, new ScriptMethodReference(forever_pause));
            custom_animation_loop(unit(list_get(ai_actors(assassin_elites.Squad), 0)), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3974499184U), "combat:sword:berserk", true);
            custom_animation_loop(unit(list_get(ai_actors(assassin_elites.Squad), 1)), GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3974499184U), "combat:sword:berserk", true);
            await sleep_until(async () => unit_has_weapon(unit(await this.player0()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4209777012U)) || unit_has_weapon(unit(await this.player1()), GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4209777012U)));
            ice_cream_flavor_stock(2);
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_01()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_move_in_direction(90F, 2F, 0F);
            cs_move_in_direction(45F, 5.5F, 0F);
            cs_move_in_direction(95F, 1F, 0F);
            cs_jump(45F, 7F);
        }

        [ScriptMethod(165, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_02()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_move_in_direction(90F, 2.75F, 0F);
            cs_move_in_direction(45F, 5.5F, 0F);
            cs_move_in_direction(90F, 1F, 0F);
            cs_jump(45F, 7.5F);
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_03()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_move_in_direction(90F, 3.5F, 0F);
            cs_move_in_direction(45F, 5.5F, 0F);
            cs_move_in_direction(85F, 1F, 0F);
            cs_jump(45F, 8F);
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_04()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_force_combat_status(4);
            cs_move_in_direction(90F, 4.25F, 0F);
            cs_move_in_direction(45F, 5.5F, 0F);
            cs_move_in_direction(75F, 1F, 0F);
            cs_jump(45F, 8.5F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task gondola_01_buggers_board()
        {
            await sleep(150);
            ai_place(gondola_01_bugs_new.Squad, 4);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task gondola_01_go_reminder()
        {
            await sleep_until(async () => device_group_get(gondola_01_switch) > 0F, 30, 1800);
            if (device_group_get(gondola_01_switch) == 0F)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'if you hit the activation-switch, it should drive itself.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0960"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => device_group_get(gondola_01_switch) > 0F, 30, 900);
            if (device_group_get(gondola_01_switch) == 0F)
            {
                activate_team_nav_point_object(_default, player, gondola_01_switch_back.Entity, 0F);
                await sleep_until(async () => device_get_position(gondola_01_a.Entity) < 1F);
                deactivate_team_nav_point_object(player, gondola_01_switch_back.Entity);
            }
        }

        [ScriptMethod(170, Lifecycle.CommandScript)]
        public async Task gondola_01_boarders_warn()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'whoa!  we got boarders!'");
            cs_play_line("0970");
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_arch()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'this lake couldn't have been formed by volcanic action -'");
            print("'which means it was either built this way on purpose,'");
            print("'or was created by some other cataclysmic event.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0980"));
            await sleep(30);
            print("cortana: 'sorry. were you trying to kill something?'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0990"));
            await sleep(30);
            ai_dialogue_enable(true);
            game_save();
        }

        [ScriptMethod(172, Lifecycle.CommandScript)]
        public async Task gondola_01_retreat()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_02_4"), 2F);
            cs_fly_to(GetReference<ISpatialPoint>("bsp1_airspace/ph_02_x"), 2F);
            ai_erase(gondola_01_phantom.Squad);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task gondola_01_unload()
        {
            await sleep(90);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_a01");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_a02");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_a03");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_b01");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_b02");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_b03");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_c01");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_c02");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_c03");
            await sleep(90);
            cs_run_command_script(gondola_01_phantom.pilot, new ScriptMethodReference(gondola_01_retreat));
        }

        [ScriptMethod(174, Lifecycle.CommandScript)]
        public async Task gondola_01_flight()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_02_0"), 2F);
            cs_fly_by(GetReference<ISpatialPoint>("bsp1_airspace/ph_02_1"), 2F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("bsp1_airspace/ph_02_2"), GetReference<ISpatialPoint>("bsp1_airspace/ph_02_3"));
            cs_vehicle_speed(0.3F);
            wake(new ScriptMethodReference(gondola_01_unload));
            cs_fly_to(GetReference<ISpatialPoint>("bsp1_airspace/ph_02_3"));
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task gondola_01_phantom_arrives()
        {
            ai_place(gondola_01_elite_boarders.Squad, 2);
            ai_place(gondola_01_grunt_boarders_01.Squad, 2);
            ai_place(gondola_01_grunt_boarders_02.Squad, 2);
            ai_place(gondola_01_phantom.Squad, 1);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p", ai_actors(gondola_01_grunt_boarders_01.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p", ai_actors(gondola_01_elite_boarders.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p", ai_actors(gondola_01_grunt_boarders_02.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), true);
            cs_run_command_script(gondola_01_phantom.pilot, new ScriptMethodReference(gondola_01_flight));
            await sleep_until(async () => (short)ai_living_count(gondola_01_phantom.Squad) < 2);
            await sleep_until(async () => (short)ai_living_count(gondola_01_grunt_boarders_01.Squad) <= 0 && (short)ai_living_count(gondola_01_grunt_boarders_02.Squad) <= 0);
            ai_set_orders(gondola_01_elite_boarders.Squad, gondola_01_all);
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task tower3_turret_mount_01()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("tower3/left"));
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(tower3_turrets.left));
            cs_enable_targeting(true);
            cs_shoot(true);
            await sleep(120);
            if (vehicle_test_seat(ai_vehicle_get_from_starting_location(tower3_turrets.left), "c_turret_ap_d", unit(ai_get_object(this.ai_current_actor))) == true)
            {
                cs_set_behavior(guard);
            }
        }

        [ScriptMethod(177, Lifecycle.CommandScript)]
        public async Task tower3_turret_mount_02()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("tower3/right"));
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(tower3_turrets.right));
            cs_enable_targeting(true);
            cs_shoot(true);
            await sleep(120);
            if (vehicle_test_seat(ai_vehicle_get_from_starting_location(tower3_turrets.right), "c_turret_ap_d", unit(ai_get_object(this.ai_current_actor))) == true)
            {
                cs_set_behavior(guard);
            }
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task tower3_turret_reman()
        {
            await sleep(300);
            await sleep_until(async () =>
            {
                await sleep((short)random_range(30, 90));
                if (object_get_health(ai_vehicle_get_from_starting_location(tower3_turrets.right)) > 0F && volume_test_objects(vol_tower3_entry, players()) == false && await this.player_count() > 0 && (short)ai_spawn_count(tower3_dock_grunts.Squad) < 5 && (short)ai_living_count(tower3_dock_grunts.Squad) < 1 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(tower3_turrets.right), "c_turret_ap_d", ai_actors(all_enemies)) == false)
                {
                    ai_place(tower3_dock_grunts.Squad, 1);
                    cs_run_command_script(tower3_dock_grunts.Squad, new ScriptMethodReference(tower3_turret_mount_02));
                }

                await sleep((short)random_range(30, 90));
                if (object_get_health(ai_vehicle_get_from_starting_location(tower3_turrets.left)) > 0F && volume_test_objects(vol_tower3_entry, players()) == false && await this.player_count() > 0 && (short)ai_spawn_count(tower3_dock_grunts.Squad) < 5 && (short)ai_living_count(tower3_dock_grunts.Squad) < 1 && vehicle_test_seat_list(ai_vehicle_get_from_starting_location(tower3_turrets.left), "c_turret_ap_d", ai_actors(all_enemies)) == false)
                {
                    ai_place(tower3_dock_grunts.Squad, 1);
                    cs_run_command_script(tower3_dock_grunts.Squad, new ScriptMethodReference(tower3_turret_mount_01));
                }

                return volume_test_objects(vol_tower3_entry, await this.player0()) == true || object_get_health(ai_vehicle_get_from_starting_location(tower3_turrets.right)) <= 0F && object_get_health(ai_vehicle_get_from_starting_location(tower3_turrets.left)) <= 0F;
            });
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task tower3_dock_above()
        {
            await sleep_until(async () => (short)ai_living_count(tower3_dock_snipers.Squad) <= 0 || device_get_position(gondola_01_a.Entity) == 0F);
            if (device_get_position(gondola_01_a.Entity) > 0F)
            {
                ai_place(tower3_dock_snipers.Squad, 2);
            }
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task gondola_01_nuke()
        {
            await sleep_until(async () =>
            {
                if (objects_can_see_object(players(), list_get(ai_actors(tower_cluster_enemies), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(tower_cluster_enemies), 0)) > 30F)
                {
                    object_destroy(list_get(ai_actors(tower_cluster_enemies), 0));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(tower_cluster_enemies), 1), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(tower_cluster_enemies), 1)) > 30F)
                {
                    object_destroy(list_get(ai_actors(tower_cluster_enemies), 1));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(tower_cluster_enemies), 2), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(tower_cluster_enemies), 2)) > 30F)
                {
                    object_destroy(list_get(ai_actors(tower_cluster_enemies), 2));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(all_allies), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 30F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(all_allies), 1), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 30F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(all_allies), 2), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 30F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                await sleep(5);
                return device_get_position(gondola_01_a.Entity) < 0.25F;
            });
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task gondola_01_restarter()
        {
            await sleep_until(async () =>
            {
                this.gondola_01_state = device_get_position(gondola_01_a.Entity);
                if (volume_test_objects_all(vol_gondola_01_mid, players()) == true && await this.player_count() > 0)
                {
                    device_set_position(gondola_01_a.Entity, 0F);
                    device_set_position(gondola_01_b.Entity, 0F);
                }
                else
                {
                    device_set_position(gondola_01_a.Entity, this.gondola_01_state);
                    device_set_position(gondola_01_b.Entity, this.gondola_01_state);
                }

                return device_get_position(gondola_01_a.Entity) < 0.4F;
            });
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task gondola_01_reverser()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects_all(vol_gondola_01_mid, players()) == true && await this.player_count() > 0)
                {
                    device_set_position(gondola_01_a.Entity, 0F);
                    device_set_position(gondola_01_b.Entity, 0F);
                }
                else
                {
                    device_set_position(gondola_01_a.Entity, 0.54F);
                    device_set_position(gondola_01_b.Entity, 0.54F);
                }

                return device_get_position(gondola_01_a.Entity) < 0.4F;
            });
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task tower_cluster_delete()
        {
            await sleep_until(async () => objects_can_see_flag(players(), tower_cluster, 45F) == false, 30, 300);
            garbage_collect_unsafe();
            object_destroy_containing("tower_cluster_");
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task gondola_01_start()
        {
            await sleep_until(async () => volume_test_objects(vol_gondola_01, players()) == true);
            ai_disposable(central_platform_enemies, true);
            data_mine_set_mission_segment("05b_5_gondola_01");
            ai_renew(all_allies);
            wake(new ScriptMethodReference(objective_towers_clear));
            wake(new ScriptMethodReference(objective_gondola1_set));
            wake(new ScriptMethodReference(gondola_01_go_reminder));
            game_save();
            await sleep_until(async () => device_group_get(gondola_01_switch) > 0F);
            device_set_power(gondola_01_switch_back.Entity, 0F);
            wake(new ScriptMethodReference(music_05b_02_stop));
            wake(new ScriptMethodReference(music_05b_03_stop));
            wake(new ScriptMethodReference(tower_cluster_delete));
            await sleep_until(async () => volume_test_objects_all(vol_gondola_01, players()) == true && await this.player_count() > 0);
            object_dynamic_simulation_disable(gondola_01_a.Entity, false);
            object_dynamic_simulation_disable(gondola_01_b.Entity, false);
            wake(new ScriptMethodReference(_05b_title1));
            device_set_position(gondola_01_launch_a.Entity, 1F);
            device_set_position(gondola_01_launch_b.Entity, 1F);
            device_set_position(gondola_01_a.Entity, 0.54F);
            device_set_position(gondola_01_b.Entity, 0.54F);
            game_save();
            wake(new ScriptMethodReference(gondola_01_buggers_board));
            await sleep_until(async () => device_get_position(gondola_01_a.Entity) < 0.85F);
            game_save();
            ai_place(gondola_01_b_elites.Squad, 2);
            ai_place(gondola_01_b_buggers.Squad, (short)(4 - (float)ai_living_count(gondola_01_bugs_new.Squad)));
            ai_place(tower3_dock_grunts.Squad, 2);
            cs_run_command_script(tower3_dock_grunts._1, new ScriptMethodReference(tower3_turret_mount_01));
            cs_run_command_script(tower3_dock_grunts._2, new ScriptMethodReference(tower3_turret_mount_02));
            wake(new ScriptMethodReference(gondola_01_nuke));
            wake(new ScriptMethodReference(tower3_turret_reman));
            await sleep_until(async () => device_get_position(gondola_01_a.Entity) < 0.7F);
            wake(new ScriptMethodReference(gondola_01_cortana_arch));
            await sleep_until(async () => device_get_position(gondola_01_a.Entity) == 0.54F);
            game_save();
            ai_place(tower3_dock_snipers.Squad, 2);
            wake(new ScriptMethodReference(tower3_dock_above));
            ai_set_orders(gondola_01_b_buggers.Squad, gondola_01_all);
            object_dynamic_simulation_disable(gondola_01_a.Entity, true);
            object_dynamic_simulation_disable(gondola_01_b.Entity, true);
            await sleep_until(async () => (float)ai_living_count(gondola_01_b_elites.Squad) + (float)ai_living_count(gondola_01_b_buggers.Squad) < 1F, 30, 1800);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", gondola_01_enemies) == true, 30, 1800);
            await sleep(60);
            game_save();
            object_dynamic_simulation_disable(gondola_01_a.Entity, false);
            object_dynamic_simulation_disable(gondola_01_b.Entity, false);
            wake(new ScriptMethodReference(music_05b_04_start));
            wake(new ScriptMethodReference(gondola_01_reverser));
            await sleep_until(async () => device_get_position(gondola_01_a.Entity) < 0.25F);
            game_save();
            await sleep_until(async () => device_get_position(gondola_01_a.Entity) == 0F);
            game_save();
            device_set_position(gondola_01_launch_a.Entity, 0F);
            device_set_position(gondola_01_launch_b.Entity, 0F);
            ai_place(tower3_dock_jackals.Squad, 2);
            wake(new ScriptMethodReference(music_05b_04_stop));
            if (await this.difficulty_legendary())
            {
                wake(new ScriptMethodReference(assassin_ice_cream));
            }

            await sleep_until(async () => device_get_position(gondola_01_a.Entity) == 0F && volume_test_objects_all(vol_gondola_01, players()) == false && await this.player_count() > 0);
            object_dynamic_simulation_disable(gondola_01_a.Entity, true);
            object_dynamic_simulation_disable(gondola_01_b.Entity, true);
            ai_set_orders(all_allies, tower3_allies);
            game_save();
        }

        [ScriptMethod(185, Lifecycle.Static)]
        public async Task cam_shake()
        {
            player_effect_set_max_rotation(0F, 2F, 2F);
            player_effect_set_max_vibration(1F, 1F);
            player_effect_start(0.5F, 0F);
            player_effect_stop(1F);
        }

        [ScriptMethod(186, Lifecycle.Static)]
        public async Task godownfast()
        {
            device_set_position_track(elev_under.Entity, "transition_1to2", 0F);
            device_animate_position(elev_under.Entity, 0.135F, 1F, 1F, 1F, false);
        }

        [ScriptMethod(187, Lifecycle.Static)]
        public async Task nowcomeup()
        {
            device_animate_position(elev_under.Entity, 0F, 15F, 1F, 1F, false);
        }

        [ScriptMethod(188, Lifecycle.Static)]
        public async Task go1to2()
        {
            device_set_position_track(elev_under.Entity, "transition_1to2", 0F);
            device_animate_position(elev_under.Entity, 0.103F, 10F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_under.Entity) == 0.103F);
            if (volume_test_object(vol_elev_shaft_under, await this.player0()) == false && await this.player_count() > 0)
            {
                object_teleport(await this.player0(), _1to2_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player0(), "");
            }

            if (volume_test_object(vol_elev_shaft_under, await this.player1()) == false && await this.player_count() > 0)
            {
                object_teleport(await this.player1(), _1to2_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player0(), "");
            }

            switch_bsp(3);
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            device_animate_position(elev_under.Entity, 1F, 60F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.122F, 1);
            effect_new(this.splashy, splash_01);
            effect_new(this.splashy, splash_02);
            effect_new(this.splashy, splash_03);
            effect_new(this.splashy, splash_04);
            effect_new(this.splashy, splash_05);
            effect_new(this.splashy, splash_06);
            effect_new(this.splashy, splash_07);
            effect_new(this.splashy, splash_08);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244944765U), default(IGameObject), 1F);
            object_destroy(water_1to2a.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.128F, 1);
            object_create_anew(water_1to2a);
            wake(new ScriptMethodReference(music_05b_05_start));
            await sleep(60);
            ai_erase(all_enemies);
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 3)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 3));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 4)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 4));
                }

                await sleep(5);
                return device_get_position(elev_under.Entity) > 0.5F;
            });
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.6F);
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.866F, 1);
            effect_new(this.splashy, splash_09);
            effect_new(this.splashy, splash_10);
            effect_new(this.splashy, splash_11);
            effect_new(this.splashy, splash_12);
            effect_new(this.splashy, splash_13);
            effect_new(this.splashy, splash_14);
            effect_new(this.splashy, splash_15);
            effect_new(this.splashy, splash_16);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245075839U), default(IGameObject), 1F);
            object_destroy(water_1to2b.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.874F, 1);
            object_create_anew(water_1to2b);
        }

        [ScriptMethod(189, Lifecycle.Static)]
        public async Task sub2doors()
        {
            device_set_position_track(elev_up.Entity, "transition_2to3", 0F);
            device_animate_position(elev_up.Entity, 0F, 1F, 1F, 1F, false);
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task go2to3()
        {
            device_set_position_track(elev_up.Entity, "transition_2to3", 0F);
            device_animate_position(elev_up.Entity, 0.103F, 10F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_up.Entity) == 0.103F);
            if (volume_test_object(vol_elev_shaft_up, await this.player0()) == false && await this.player_count() > 0)
            {
                object_teleport(await this.player0(), _2to3_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player0(), "");
            }

            if (volume_test_object(vol_elev_shaft_up, await this.player1()) == false && await this.player_count() > 0)
            {
                object_teleport(await this.player1(), _2to3_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player0(), "");
            }

            switch_bsp(4);
            await sleep_until(async () => (short)structure_bsp_index() == 4);
            device_animate_position(elev_up.Entity, 1F, 60F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.134F, 1);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244944765U), default(IGameObject), 1F);
            object_destroy(water_2to3a.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.143F, 1);
            object_create_anew(water_2to3a);
            wake(new ScriptMethodReference(music_05b_08_start));
            await sleep(60);
            ai_erase(all_enemies);
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 3)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 3));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 4)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 4));
                }

                await sleep(5);
                return device_get_position(elev_up.Entity) > 0.7F;
            });
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.889F, 1);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245075839U), default(IGameObject), 1F);
            object_destroy(water_2to3b.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.896F, 1);
            object_create_anew(water_2to3b);
        }

        [ScriptMethod(191, Lifecycle.CommandScript)]
        public async Task tower3_pelican_path()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("tower3_airspace/pel0"), 2F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("tower3_airspace/peln"), 20F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("tower3_airspace/pel1"), 5F);
            cs_vehicle_speed(0.5F);
            cs_fly_by(GetReference<ISpatialPoint>("tower3_airspace/pel1"), 1F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("tower3_airspace/pel2"), GetReference<ISpatialPoint>("tower3_airspace/p0"), 1F);
            ai_place(tower3_pelican_allies.Squad, (short)(2 - (float)ai_living_count(allies_infantry)));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(tower3_pelican.pilot), "pelican_p", ai_actors(tower3_pelican_allies.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(tower3_pelican.pilot), true);
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(tower3_pelican.pilot), "pelican_p");
            await sleep_until(async () => (short)ai_living_count(tower3_pelican.Squad) < 4);
            await sleep(60);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("tower3_airspace/pel1"), GetReference<ISpatialPoint>("tower3_airspace/peln"), 2F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("tower3_airspace/peln"), 5F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("tower3_airspace/pel0"), 20F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("tower3_airspace/pelx"), 10F);
            ai_erase(tower3_pelican.Squad);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task tower3_pelican_arrives()
        {
            ai_place(tower3_pelican.Squad);
            cs_run_command_script(tower3_pelican.pilot, new ScriptMethodReference(tower3_pelican_path));
        }

        [ScriptMethod(193, Lifecycle.Static)]
        public async Task short_tower3_pel()
        {
            ai_place(tower3_pelican.Squad);
            cs_run_command_script(tower3_pelican.pilot, new ScriptMethodReference(tower3_pelican_path));
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task tower3_cortana_comment()
        {
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", tower3_enemies) == true);
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'ah, now i see. there's a submerged section that...'");
            print("'...connects these towers to the outlying structures.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1000"));
            await sleep(60);
            print("'looks like we're going down.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1010"));
            await sleep(30);
            print("'unless you'd prefer to swim...'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1020"));
            this.tower3_done_blabbing = true;
        }

        [ScriptMethod(195, Lifecycle.CommandScript)]
        public async Task tower3_ally_warn()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'full car coming up!'");
            cs_play_line("1040");
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task tower3_cortana_reminder_02()
        {
            await sleep_until(async () => device_group_get(elev_under_switch) > 0F, 30, 3600);
            if (device_group_get(elev_under_switch) == 0F)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'all right. let's see where this elevator goes...'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1050"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => device_group_get(elev_under_switch) > 0F, 30, 1800);
            if (device_group_get(elev_under_switch) == 0F)
            {
                activate_team_nav_point_object(_default, player, elev_under_switch_01.Entity, 0F);
                await sleep_until(async () => device_group_get(elev_under_switch) > 0F);
                deactivate_team_nav_point_object(player, elev_under_switch_01.Entity);
            }
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task elev_under_cortana_comment()
        {
            ai_dialogue_enable(false);
            await sleep(180);
            print("cortana: 'i've intercepted a secure transmission from regret's carrier...'");
            print("'...to something called high charity. it's seems to be a formal apology - '");
            print("'to the prophets of truth and mercy.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2120"));
            await sleep(15);
            print("cortana: 'apparently, regret jumped the gun when he attacked earth.'");
            print("'he's asking the other prophets to forgive his premature arrival...'");
            print("'...arguing that no human presence was foretold.");
            await sleep(ai_play_line_on_object(default(IGameObject), "2130"));
            print("cortana: 'that explains why there were so few ships in his fleet.'");
            print("'but it's odd a prophet would have such bad intel about his enemy's home-world.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2140"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(198, Lifecycle.CommandScript)]
        public async Task elev_under_ally_01()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'hey, my ears just popped!'");
            cs_play_line("1060");
        }

        [ScriptMethod(199, Lifecycle.CommandScript)]
        public async Task elev_under_ally_02()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'uh, just exactly how deep are we?'");
            cs_play_line("1070");
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task elev_under_ally_03()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'you think that glass is bulletproof?'");
            cs_play_line("1080");
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task tower3_sleeper_spawn()
        {
            await sleep_until(async () => volume_test_objects(vol_tower3_upstairs, players()) == true);
            ai_place(tower3_sleeper.Squad, 1);
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task elev_under_monitor()
        {
            await sleep_until(async () => device_group_get(elev_under_switch) > 0F);
            device_set_power(elev_under_switch_01.Entity, 0F);
            await sleep_until(async () => volume_test_objects_all(vol_inside_elev_under, players()) == true && await this.player_count() > 0);
            device_set_position_track(elev_under.Entity, "transition_1to2", 0F);
            device_animate_position(elev_under.Entity, 0.103F, 10F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_under.Entity) == 0.103F);
            if (volume_test_object(vol_elev_shaft_under, await this.player0()) == false && await this.player_count() > 0)
            {
                object_teleport(await this.player0(), _1to2_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player0(), "");
            }

            if (volume_test_object(vol_elev_shaft_under, await this.player1()) == false && await this.player_count() > 0 && (bool)game_is_cooperative() == true)
            {
                object_teleport(await this.player1(), _1to2_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player1(), "");
            }

            switch_bsp(3);
            await sleep_until(async () => (short)structure_bsp_index() == 3);
            game_can_use_flashlights(true);
            device_animate_position(elev_under.Entity, 1F, 60F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.122F, 1);
            effect_new(this.splashy, splash_01);
            effect_new(this.splashy, splash_02);
            effect_new(this.splashy, splash_03);
            effect_new(this.splashy, splash_04);
            effect_new(this.splashy, splash_05);
            effect_new(this.splashy, splash_06);
            effect_new(this.splashy, splash_07);
            effect_new(this.splashy, splash_08);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244944765U), default(IGameObject), 1F);
            object_destroy(water_1to2a.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.128F, 1);
            object_create_anew(water_1to2a);
            kill_volume_enable(kill_no_riders_under);
            wake(new ScriptMethodReference(music_05b_05_start));
            await sleep(60);
            wake(new ScriptMethodReference(elev_under_cortana_comment));
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 3)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 3));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 4)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 4));
                }

                await sleep(5);
                return device_get_position(elev_under.Entity) > 0.5F;
            });
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.6F);
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.866F, 1);
            effect_new(this.splashy, splash_09);
            effect_new(this.splashy, splash_10);
            effect_new(this.splashy, splash_11);
            effect_new(this.splashy, splash_12);
            effect_new(this.splashy, splash_13);
            effect_new(this.splashy, splash_14);
            effect_new(this.splashy, splash_15);
            effect_new(this.splashy, splash_16);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245075839U), default(IGameObject), 1F);
            object_destroy(water_1to2b.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_under.Entity) > 0.874F, 1);
            object_create_anew(water_1to2b);
            kill_volume_disable(kill_no_riders_under);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task tower3_start()
        {
            ai_disposable(gondola_01_enemies, true);
            data_mine_set_mission_segment("05b_6_tower3");
            ai_renew(all_allies);
            game_save();
            objects_attach(elev_under.Entity, "switch", elev_under_switch_01.Entity, "");
            device_group_change_only_once_more_set(elev_under_switch, true);
            await this.godownfast();
            wake(new ScriptMethodReference(tower3_sleeper_spawn));
            wake(new ScriptMethodReference(objective_gondola1_clear));
            wake(new ScriptMethodReference(objective_sunken_set));
            ai_place(tower3_jackals_01.Squad, 4);
            sleep_forever(new ScriptMethodReference(tower3_turret_reman));
            cs_run_command_script(tower3_turrets.Squad, new ScriptMethodReference(abort));
            await sleep_until(async () => volume_test_objects(vol_tower3_mid, players()) == true || (short)ai_living_count(tower3_main) < 2);
            game_save();
            ai_place(tower3_jackals_02.Squad, (short)(4 - (float)ai_living_count(tower3_jackals_01.Squad)));
            await sleep_until(async () => (short)ai_living_count(tower3_main) < 2, 30, 3600);
            game_save();
            if (volume_test_objects(vol_tower3_upstairs, players()) == false && await this.player_count() > 0)
            {
                ai_place(tower3_buggers_01.Squad, 3);
            }

            await sleep_until(async () => (short)ai_living_count(tower3_main) < 2, 30, 3600);
            game_save();
            if (volume_test_objects(vol_tower3_upstairs, players()) == false && await this.player_count() > 0)
            {
                ai_place(tower3_buggers_02.Squad, (short)(3 - (float)ai_living_count(tower3_buggers_01.Squad)));
            }

            await sleep_until(async () => (short)ai_living_count(tower3_main) <= 0, 30, 3600);
            wake(new ScriptMethodReference(tower3_cortana_comment));
            if ((short)ai_living_count(all_allies) < 2)
            {
                wake(new ScriptMethodReference(tower3_pelican_arrives));
            }

            await sleep_until(async () => this.tower3_done_blabbing == true);
            ai_place(tower3_jackals_elev.Squad, 3);
            await sleep(30);
            game_save();
            await this.nowcomeup();
            kill_volume_disable(kill_no_riders_under);
            await sleep(150);
            ai_scene("tower3_ally_scene", new ScriptMethodReference(tower3_ally_warn), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await sleep_until(async () => device_get_position(elev_under.Entity) == 0F);
            ai_set_orders(tower3_jackals_elev.Squad, tower3_int_elev_ridge);
            wake(new ScriptMethodReference(tower3_cortana_reminder_02));
            wake(new ScriptMethodReference(elev_under_monitor));
            await sleep_until(async () => (short)ai_living_count(tower3_main) <= 0 || volume_test_objects_all(vol_inside_elev_under, players()) == true && await this.player_count() > 0);
            ai_set_orders(all_allies, tower3_on_elev);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task tunnel_01_cortana_comment()
        {
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", tunnel_01_enemies) == true || volume_test_objects(vol_sunken_chamber_entry, players()) == true);
            await sleep_until(async () => volume_test_objects(vol_sunken_chamber_entry, players()) == true, 30, 300);
            if (volume_test_objects(vol_sunken_chamber_entry, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'out there...look! more ruins!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1090"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task sunken_tunnel1_start()
        {
            ai_disposable(tower3_enemies, true);
            data_mine_set_mission_segment("05b_7_tunnel1");
            ai_renew(all_allies);
            await sleep_until(async () => device_get_position(elev_under.Entity) == 1F);
            game_save();
            ai_set_orders(all_allies, tunnel_01_suppress);
            ai_place(tunnel_01_grunts_patrol.Squad, 2);
            ai_place(tunnel_01_grunts_01.Squad, 3);
            ai_place(tunnel_01_grunts_02.Squad, 2);
            wake(new ScriptMethodReference(music_05b_06_start));
            await sleep_until(async () => (short)ai_combat_status(tunnel_01_enemies) > this.ai_combat_status_idle || volume_test_objects(vol_tunnel_01_mid, players()) == true);
            await sleep(60);
            ai_set_orders(all_allies, tunnel_01_allies);
            await sleep_until(async () => volume_test_objects(vol_tunnel_01_mid, players()) == true || (short)ai_living_count(tunnel_01_enemies) < 5);
            game_save();
            ai_place(tunnel_01_grunts_03.Squad, (short)(3 - (float)ai_living_count(tunnel_01_grunts_01.Squad)));
            await sleep_until(async () => (short)ai_living_count(tunnel_01_enemies) <= 0 || volume_test_objects(vol_sunken_chamber_entry, players()) == true, 30, 1800);
            game_save();
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task sunken_holo_cortana_comment()
        {
            await sleep_until(async () => objects_distance_to_object(players(), regret02.Entity) < 10F && objects_can_see_object(players(), regret02.Entity, 30F) && volume_test_objects(vol_sunk_chamber_right, players()) == true);
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'and people say i've got a big head...'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1100"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(207, Lifecycle.CommandScript)]
        public async Task sunken_holo_ally_react()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'oh, man. he is so dead!'");
            cs_play_line("1110");
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task sunken_holo_looper()
        {
            object_create_anew(sunken_throne);
            object_create_anew(regret02);
            objects_attach(sunken_throne.Entity, "driver", regret02.Entity, "");
            ai_disregard(regret02.Entity, true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant1a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3000"));
                        await sleep((short)random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant2b", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3001"));
                        await sleep((short)random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant2c", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3002"));
                        await sleep((short)random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant3a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3003"));
                        await sleep((short)random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant3c", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3004"));
                        await sleep((short)random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant5a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3005"));
                        await sleep((short)random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant6a", true);
                        await sleep(ai_play_line_on_object(regret02.Entity, "3006"));
                        await sleep((short)random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task sunken_holo_translate()
        {
            await sleep_until(async () => (short)ai_living_count(sunken_chamber_enemies) <= 0);
            await sleep(150);
            this.sunken_holo_trans = true;
            await sleep_until(async () => objects_distance_to_object(players(), regret02.Entity) < 10F && this.sunken_holo_chant == false);
            ai_dialogue_enable(false);
            await sleep(60);
            print("regret: 'most of those we encountered on our search were compelled...'");
            print("regret: '...to join our union - to take part in a movement that promised...'");
            print("regret: '...freedom for allegiance! salvation for service!'");
            custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_l05_0140_por", true);
            await sleep(ai_play_line_on_object(regret02.Entity, "0140"));
            await sleep(30);
            print("'but some, like the humans, chose to impede our progress -'");
            print("'block our access to sacred sites, damage holy relics! for their...'");
            print("'...transgressions the humans shall be hunted until none remain alive!'");
            custom_animation(regret02.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_l05_0150_por", true);
            await sleep(ai_play_line_on_object(regret02.Entity, "0150"));
            await sleep(60);
            ai_scene("sunken_holo_ally_scene", new ScriptMethodReference(sunken_holo_ally_react), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await sleep(30);
            ai_dialogue_enable(true);
            await sleep((short)random_range(240, 480));
            this.sunken_holo_trans = false;
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task sunken_chamber_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_leaving_sunken_chamber, players()) == true, 30, 8000);
            if (volume_test_objects(vol_leaving_sunken_chamber, players()) == false && await this.player_count() > 0)
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'keep moving. let's find our way back to the surface.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1120"));
                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task hide_rightside_guys()
        {
            await sleep_until(async () => (short)ai_combat_status(sunk_chamber_right_enemies) > this.ai_combat_status_idle);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects_all(vol_sunk_chamber_left, players()) == true && await this.player_count() > 0 && (short)ai_living_count(sunken_rightside_nonsnipers) > 0);
                ai_set_orders(sunken_rightside_nonsnipers, sunken_rightside_hide);
                if (objects_can_see_object(players(), list_get(ai_actors(sunken_rightside_nonsnipers), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(sunken_rightside_nonsnipers), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(sunken_rightside_nonsnipers), 0));
                }

                if (objects_can_see_object(players(), list_get(ai_actors(sunken_rightside_nonsnipers), 1), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(sunken_rightside_nonsnipers), 1)) > 10F)
                {
                    object_destroy(list_get(ai_actors(sunken_rightside_nonsnipers), 1));
                }

                if (objects_can_see_object(players(), list_get(ai_actors(sunken_rightside_nonsnipers), 2), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(sunken_rightside_nonsnipers), 2)) > 10F)
                {
                    object_destroy(list_get(ai_actors(sunken_rightside_nonsnipers), 2));
                }

                return volume_test_objects(vol_leaving_sunken_chamber, players()) == true;
            });
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task hide_leftside_guys()
        {
            await sleep_until(async () => (short)ai_combat_status(sunk_chamber_left_enemies) > this.ai_combat_status_idle);
            await sleep_until(async () =>
            {
                await sleep_until(async () => volume_test_objects_all(vol_sunk_chamber_right, players()) == true && await this.player_count() > 0 && (short)ai_living_count(sunken_leftside_nonsnipers) > 0);
                ai_set_orders(sunken_leftside_nonsnipers, sunken_leftside_hide);
                if (objects_can_see_object(players(), list_get(ai_actors(sunken_leftside_nonsnipers), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(sunken_leftside_nonsnipers), 0)) > 10F)
                {
                    object_destroy(list_get(ai_actors(sunken_leftside_nonsnipers), 0));
                }

                if (objects_can_see_object(players(), list_get(ai_actors(sunken_leftside_nonsnipers), 1), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(sunken_leftside_nonsnipers), 1)) > 10F)
                {
                    object_destroy(list_get(ai_actors(sunken_leftside_nonsnipers), 1));
                }

                if (objects_can_see_object(players(), list_get(ai_actors(sunken_leftside_nonsnipers), 2), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(sunken_leftside_nonsnipers), 2)) > 10F)
                {
                    object_destroy(list_get(ai_actors(sunken_leftside_nonsnipers), 2));
                }

                return volume_test_objects(vol_leaving_sunken_chamber, players()) == true;
            });
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task sunken_hologram_focus()
        {
            cs_abort_on_alert(true);
            cs_face_object(true, regret02.Entity);
            cs_pause(-1F);
        }

        [ScriptMethod(214, Lifecycle.Static)]
        public async Task sunken_try_reinforce_r()
        {
            if (device_get_position(sunk_chmbr_spwn_r1a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_r1b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_r1a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_r1b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_jack_R_01.Squad, (short)(this.sunken_jacks_total - (float)ai_living_count(sunken_jacks_right)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_hg_R_01.Squad, (short)(this.sunken_hg_total - (float)ai_living_count(sunken_hg_right)));
                }
            }

            if (device_get_position(sunk_chmbr_spwn_r2a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_r2b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_r2a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_r2b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_jack_R_02.Squad, (short)(this.sunken_jacks_total - (float)ai_living_count(sunken_jacks_right)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_hg_R_02.Squad, (short)(this.sunken_hg_total - (float)ai_living_count(sunken_hg_right)));
                }
            }
        }

        [ScriptMethod(215, Lifecycle.Static)]
        public async Task sunken_try_reinforce_l()
        {
            if (device_get_position(sunk_chmbr_spwn_l1a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_l1b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_l1a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_l1b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_jack_L_01.Squad, (short)(this.sunken_jacks_total - (float)ai_living_count(sunken_jacks_left)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_hg_L_01.Squad, (short)(this.sunken_hg_total - (float)ai_living_count(sunken_hg_left)));
                }
            }

            if (device_get_position(sunk_chmbr_spwn_l2a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_l2b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_l2a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_l2b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_jack_L_02.Squad, (short)(this.sunken_jacks_total - (float)ai_living_count(sunken_jacks_left)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_hg_L_02.Squad, (short)(this.sunken_hg_total - (float)ai_living_count(sunken_hg_left)));
                }
            }
        }

        [ScriptMethod(216, Lifecycle.Static)]
        public async Task sunken_try_js_r1()
        {
            if (device_get_position(sunk_chmbr_spwn_r1a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_r1b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_r1a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_r1b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_js_R_01.Squad, (short)(this.sunken_sniper_total - (float)ai_living_count(sunken_rightside_snipers)));
                }
            }
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task sunken_try_js_r2()
        {
            if (device_get_position(sunk_chmbr_spwn_r2a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_r2b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_r2a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_r2b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_js_R_02.Squad, (short)(this.sunken_sniper_total - (float)ai_living_count(sunken_rightside_snipers)));
                }
            }
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task sunken_try_js_l1()
        {
            if (device_get_position(sunk_chmbr_spwn_l1a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_l1b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_l1a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_l1b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_js_L_01.Squad, (short)(this.sunken_sniper_total - (float)ai_living_count(sunken_leftside_snipers)));
                }
            }
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task sunken_try_js_l2()
        {
            if (device_get_position(sunk_chmbr_spwn_l2a.Entity) == 0F && device_get_position(sunk_chmbr_spwn_l2b.Entity) == 0F && volume_test_objects(vol_sunk_chmbr_spwn_l2a, players()) == false && volume_test_objects(vol_sunk_chmbr_spwn_l2b, players()) == false && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_js_L_02.Squad, (short)(this.sunken_sniper_total - (float)ai_living_count(sunken_leftside_snipers)));
                }
            }
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task sunk_chamber_hunters_enter()
        {
            await sleep_until(async () => (short)ai_combat_status(sunken_chamber_enemies) > this.ai_combat_status_idle || volume_test_objects(vol_leaving_sunken_chamber, players()) == true);
            if (volume_test_objects(vol_leaving_sunken_chamber, players()) == false && await this.player_count() > 0)
            {
                device_operates_automatically_set(sunk_chamber_hunter_door.Entity, true);
                ai_place(sunk_chamber_hunters.Squad, 2);
            }
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task sunken_chamber_saves()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (bool)game_safe_to_save() && this.sunken_save_again == true);
                game_save_immediate();
                this.sunken_save_again = false;
                return volume_test_objects(vol_leaving_sunken_chamber, players()) == true;
            });
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task sunken_chamber_start()
        {
            await sleep_until(async () => volume_test_objects(vol_sunken_chamber_entry, players()) == true);
            ai_disposable(tunnel_01_enemies, true);
            data_mine_set_mission_segment("05b_8_sunken_chamber");
            ai_renew(all_allies);
            game_save();
            if (await this.difficulty_legendary())
            {
                this.sunken_sniper_total = 4;
                this.sunken_jacks_total = 0;
                this.sunken_hg_total = 3;
            }

            if (await this.difficulty_heroic())
            {
                this.sunken_sniper_total = 3;
                this.sunken_jacks_total = 1;
                this.sunken_hg_total = 2;
            }

            ai_place(sunk_chamber_init_js_L01.Squad, 1);
            ai_place(sunk_chamber_init_js_L02.Squad, 1);
            ai_place(sunk_chamber_init_js_R01.Squad, 1);
            cs_run_command_script(sunk_chamber_init_js_R01.Squad, new ScriptMethodReference(sunken_hologram_focus));
            ai_place(sunk_chamber_init_js_R02.Squad, 1);
            cs_run_command_script(sunk_chamber_init_js_R02.Squad, new ScriptMethodReference(sunken_hologram_focus));
            ai_place(sunk_chamber_init_hg_Ra.Squad, 1);
            ai_place(sunk_chamber_init_hg_La.Squad, 1);
            wake(new ScriptMethodReference(sunken_holo_looper));
            wake(new ScriptMethodReference(sunken_holo_cortana_comment));
            wake(new ScriptMethodReference(hide_rightside_guys));
            wake(new ScriptMethodReference(hide_leftside_guys));
            wake(new ScriptMethodReference(sunken_chamber_saves));
            ai_set_orders(all_allies, sunken_chamber_allies);
            await sleep_until(async () => volume_test_objects(vol_sunk_chamber_near_01, players()) == true || (short)ai_combat_status(sunken_chamber_enemies) > this.ai_combat_status_uninspected);
            this.sunken_save_again = true;
            wake(new ScriptMethodReference(music_05b_06_stop));
            if (volume_test_objects_all(vol_sunk_chamber_left, players()) == true && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_L_011.Squad, 4);
                }

                await this.sunken_try_js_r1();
            }

            if (volume_test_objects_all(vol_sunk_chamber_right, players()) == true && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_R_011.Squad, 4);
                }

                await this.sunken_try_js_l1();
            }

            if (volume_test_objects(vol_sunk_chamber_right, players()) == true && volume_test_objects(vol_sunk_chamber_left, players()) == true)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_R_011.Squad, 2);
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_L_011.Squad, 2);
                }

                await this.sunken_try_js_r1();
                await this.sunken_try_js_l1();
            }

            await sleep_until(async () => volume_test_objects(vol_sunk_chamber_near_02, players()) == true);
            this.sunken_save_again = true;
            if (volume_test_objects_all(vol_sunk_chamber_left, players()) == true && await this.player_count() > 0)
            {
                await this.sunken_try_reinforce_l();
                await this.sunken_try_js_r1();
            }

            if (volume_test_objects_all(vol_sunk_chamber_right, players()) == true && await this.player_count() > 0)
            {
                await this.sunken_try_reinforce_r();
                await this.sunken_try_js_l1();
            }

            if (volume_test_objects(vol_sunk_chamber_right, players()) == true && volume_test_objects(vol_sunk_chamber_left, players()) == true)
            {
                await this.sunken_try_reinforce_r();
                await this.sunken_try_reinforce_l();
                await this.sunken_try_js_r1();
                await this.sunken_try_js_l1();
            }

            await sleep_until(async () => volume_test_objects(vol_sunk_chamber_far_01, players()) == true);
            this.sunken_save_again = true;
            wake(new ScriptMethodReference(sunk_chamber_hunters_enter));
            if (volume_test_objects_all(vol_sunk_chamber_left, players()) == true && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_L_021.Squad, (short)(4 - (float)ai_living_count(sunken_bugs)));
                }

                await this.sunken_try_js_r2();
            }

            if (volume_test_objects_all(vol_sunk_chamber_right, players()) == true && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_R_021.Squad, (short)(4 - (float)ai_living_count(sunken_bugs)));
                }

                await this.sunken_try_js_l2();
            }

            if (volume_test_objects(vol_sunk_chamber_right, players()) == true && volume_test_objects(vol_sunk_chamber_left, players()) == true)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_R_021.Squad, (short)(2 - (float)ai_living_count(sunk_chamber_bugs_R_011.Squad)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_bugs_L_021.Squad, (short)(2 - (float)ai_living_count(sunk_chamber_bugs_L_011.Squad)));
                }

                await this.sunken_try_js_l2();
                await this.sunken_try_js_r2();
            }

            await sleep_until(async () => volume_test_objects(vol_sunk_chamber_far_02, players()) == true);
            this.sunken_save_again = true;
            wake(new ScriptMethodReference(sunken_chamber_reminder));
            device_operates_automatically_set(sunk_chamber_exit_r.Entity, true);
            device_operates_automatically_set(sunk_chamber_exit_l.Entity, true);
            if (volume_test_objects_all(vol_sunk_chamber_left, players()) == true && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_j01_L.Squad, (short)(2 - (float)ai_living_count(sunken_jacks_left)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_e_L.Squad, (short)max(1F, 2F - (float)ai_living_count(sunken_hg_left)));
                }
            }

            if (volume_test_objects_all(vol_sunk_chamber_right, players()) == true && await this.player_count() > 0)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_j01_R.Squad, (short)(2 - (float)ai_living_count(sunken_jacks_right)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_e_R.Squad, (short)max(1F, 2F - (float)ai_living_count(sunken_hg_right)));
                }
            }

            if (volume_test_objects(vol_sunk_chamber_right, players()) == true && volume_test_objects(vol_sunk_chamber_left, players()) == true)
            {
                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_j01_L.Squad, (short)(2 - (float)ai_living_count(sunken_jacks_left)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_j01_R.Squad, (short)(2 - (float)ai_living_count(sunken_jacks_right)));
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_e_L.Squad, 1);
                }

                if ((short)ai_living_count(sunken_chamber_enemies) < 8)
                {
                    ai_place(sunk_chamber_exit_e_R.Squad, 1);
                }
            }

            if ((short)ai_living_count(sunken_chamber_enemies) < 8)
            {
                ai_place(sunk_chamber_exit_j02_R.Squad, 2);
            }

            if ((short)ai_living_count(sunken_chamber_enemies) < 8)
            {
                ai_place(sunk_chamber_exit_j02_L.Squad, 2);
            }

            wake(new ScriptMethodReference(sunken_holo_translate));
            await sleep_until(async () => volume_test_objects(vol_leaving_sunken_chamber, players()) == true);
            this.sunken_save_again = true;
            ai_set_orders(all_allies, tunnel_02_allies);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task elev_up_cortana_comment()
        {
            ai_dialogue_enable(false);
            await sleep(180);
            print("cortana: 'regret's carrier just received a response from high charity.'");
            print("'a very well-encrypted message from the prophet of truth.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2150"));
            await sleep(15);
            print("cortana: 'listen to this: your haste has jeopardized the fulfillment of our covenant -'");
            print("'threatened our grand design. that you shall be spared a public display of our contempt...'");
            print("'...is thanks only to mercy and his wise counsel.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2160"));
            print("cortana: 'truth, mercy, regret. three prophet hierarchs.'");
            print("'killing regret should shake-up the covenant leadership, but, frankly'");
            print("'it sounds like you might be doing truth a favor.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "2170"));
            await sleep(30);
            ai_dialogue_enable(true);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task elev_up_monitor()
        {
            await sleep_until(async () => device_group_get(elev_up_switch) > 0F);
            device_set_power(elev_up_switch_01.Entity, 0F);
            await sleep_until(async () => volume_test_objects_all(vol_inside_elev_up, players()) == true && await this.player_count() > 0);
            device_animate_position(elev_up.Entity, 0.103F, 10F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_up.Entity) == 0.103F);
            if (volume_test_object(vol_elev_shaft_up, await this.player0()) == false && await this.player_count() > 0)
            {
                object_teleport(await this.player0(), _2to3_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player0(), "");
            }

            if (volume_test_object(vol_elev_shaft_up, await this.player1()) == false && await this.player_count() > 0 && (bool)game_is_cooperative() == true)
            {
                object_teleport(await this.player1(), _2to3_teleport);
                effect_new_on_object_marker(GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228626052U), await this.player1(), "");
            }

            switch_bsp(4);
            await sleep_until(async () => (short)structure_bsp_index() == 4);
            device_animate_position(elev_up.Entity, 1F, 60F, 1F, 1F, false);
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.134F, 1);
            effect_new(this.splashy, splash_17);
            effect_new(this.splashy, splash_18);
            effect_new(this.splashy, splash_19);
            effect_new(this.splashy, splash_20);
            effect_new(this.splashy, splash_21);
            effect_new(this.splashy, splash_22);
            effect_new(this.splashy, splash_23);
            effect_new(this.splashy, splash_24);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244944765U), default(IGameObject), 1F);
            object_destroy(water_2to3a.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.143F, 1);
            object_create_anew(water_2to3a);
            kill_volume_enable(kill_no_riders_up);
            wake(new ScriptMethodReference(music_05b_08_start));
            await sleep(60);
            wake(new ScriptMethodReference(elev_up_cortana_comment));
            await sleep_until(async () =>
            {
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 3)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 3));
                }

                await sleep(5);
                if (objects_distance_to_object(players(), list_get(ai_actors(all_allies), 4)) > 5F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 4));
                }

                await sleep(5);
                return device_get_position(elev_up.Entity) > 0.7F;
            });
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.889F, 1);
            effect_new(this.splashy, splash_25);
            effect_new(this.splashy, splash_26);
            effect_new(this.splashy, splash_27);
            effect_new(this.splashy, splash_28);
            effect_new(this.splashy, splash_29);
            effect_new(this.splashy, splash_30);
            effect_new(this.splashy, splash_31);
            effect_new(this.splashy, splash_32);
            sound_impulse_start(GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245075839U), default(IGameObject), 1F);
            object_destroy(water_2to3b.Entity);
            await this.cam_shake();
            await sleep_until(async () => device_get_position(elev_up.Entity) > 0.896F, 1);
            object_create_anew(water_2to3b);
            kill_volume_disable(kill_no_riders_up);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task sunken_tunnel2_start()
        {
            await sleep_until(async () => volume_test_objects(vol_tunnel_02_entry, players()) == true);
            ai_disposable(sunken_chamber_enemies, true);
            data_mine_set_mission_segment("05b_9_tunnel2");
            ai_renew(all_allies);
            game_save();
            objects_attach(elev_up.Entity, "switch", elev_up_switch_01.Entity, "");
            device_group_change_only_once_more_set(elev_up_switch, true);
            await this.sub2doors();
            wake(new ScriptMethodReference(elev_up_monitor));
            ai_place(tunnel_02_elites_01.Squad, 1);
            ai_place(tunnel_02_elites_02.Squad, 1);
            ai_set_active_camo(tunnel_02_elites_01.Squad, true);
            ai_set_active_camo(tunnel_02_elites_02.Squad, true);
            ai_set_orders(all_allies, tunnel_02_suppress);
            wake(new ScriptMethodReference(music_05b_07_start));
            await sleep_until(async () => volume_test_objects(vol_tunnel_02_mid_01, players()) == true || (short)ai_combat_status(tunnel_02_enemies) > this.ai_combat_status_idle || (short)ai_living_count(tunnel_02_enemies) < 1);
            game_save();
            ai_set_orders(all_allies, tunnel_02_allies);
            ai_place(tunnel_02_elites_04.Squad, (short)(1 - (float)ai_living_count(tunnel_02_elites_01.Squad) + (float)ai_living_count(tunnel_02_elites_02.Squad)));
            ai_set_active_camo(tunnel_02_elites_04.Squad, true);
            ai_place(tunnel_02_grunts.Squad, 3);
            ai_set_active_camo(tunnel_02_grunts.Squad, true);
            await sleep_until(async () => volume_test_objects(vol_tunnel_02_mid_02, players()) == true || (short)ai_living_count(tunnel_02_enemies) < 1);
            game_save();
            ai_place(tunnel_02_elites_03.Squad, 1);
            ai_set_active_camo(tunnel_02_elites_03.Squad, true);
            await sleep_until(async () => volume_test_objects(vol_elev_up_dock, players()) == true);
            game_save();
            ai_set_orders(all_allies, tunnel_02_on_elev);
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task island_holo_looper()
        {
            object_create_anew(island_throne);
            object_create_anew(regret03);
            objects_attach(island_throne.Entity, "driver", regret03.Entity, "");
            ai_disregard(regret03.Entity, true);
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant1a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3000"));
                        await sleep((short)random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant2b", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3001"));
                        await sleep((short)random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant2c", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3002"));
                        await sleep((short)random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant3a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3003"));
                        await sleep((short)random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant3c", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3004"));
                        await sleep((short)random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant5a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3005"));
                        await sleep((short)random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_chant6a", true);
                        await sleep(ai_play_line_on_object(regret03.Entity, "3006"));
                        await sleep((short)random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task island_int_translate()
        {
            await sleep_until(async () => volume_test_objects(vol_island_int_02, players()) == true && (short)ai_living_count(island_int_enemies) <= 0);
            await sleep(150);
            this.island_holo_trans = true;
            await sleep_until(async () => volume_test_objects(vol_island_int_02, players()) == true && this.island_holo_chant == false);
            ai_dialogue_enable(false);
            await sleep(60);
            print("regret: 'every member of the covenant shall walk the path!'");
            print("'none will be left behind when our great journey begins!'");
            print("'that is the prophets' age-old promise! and it shall be fulfilled!'");
            custom_animation(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "regret_l05_0160_por", true);
            await sleep(ai_play_line_on_object(regret03.Entity, "0160"));
            await sleep(30);
            print("cortana: 'great journey? doesn't he know what these rings do?'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1130"));
            await sleep(30);
            ai_dialogue_enable(true);
            await sleep((short)random_range(240, 480));
            this.island_holo_trans = false;
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task island_interior_start()
        {
            ai_disposable(tunnel_02_enemies, true);
            game_can_use_flashlights(false);
            wake(new ScriptMethodReference(objective_sunken_clear));
            wake(new ScriptMethodReference(objective_temple_set));
            objects_attach(gondola_02_a.Entity, "control_front", gondola_02_switch_front.Entity, "");
            objects_attach(gondola_02_b.Entity, "control_front", gondola_02_b_fake.Entity, "");
            device_group_change_only_once_more_set(gondola_02_switch, true);
            wake(new ScriptMethodReference(island_holo_looper));
            data_mine_set_mission_segment("05b_10_island_interior");
            ai_renew(all_allies);
            game_save();
            ai_set_orders(all_allies, island_int_allies);
            ai_place(island_int_grunts.Squad, 4);
            await sleep(1);
            ai_place(island_int_hg.Squad, 2);
            wake(new ScriptMethodReference(island_int_translate));
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task island_pelican_comment()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("pelican pilot: 'this is my last run, chief. i'm nearly out of fuel.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1140"));
            await sleep(30);
            print("'we've secured the first tower cluster, so i'll set down there.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1150"));
            await sleep(30);
            print("'call when you're ready for evac.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1160"));
            await sleep(30);
            ai_dialogue_enable(true);
            game_save();
        }

        [ScriptMethod(230, Lifecycle.CommandScript)]
        public async Task island_pelican_path()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/pel0"), 2F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/pel1"), 10F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/p2"), 5F);
            cs_vehicle_speed(0.5F);
            this.island_pelican_arrived = true;
            cs_fly_to(GetReference<ISpatialPoint>("island_airspace/p5"), 2F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("island_airspace/p6"), GetReference<ISpatialPoint>("island_airspace/p4"), 2F);
            await sleep(30);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_p");
            await sleep_until(async () => (short)ai_living_count(island_pelican.Squad) < 4);
            await sleep(60);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("island_airspace/p5"), GetReference<ISpatialPoint>("island_airspace/p3"), 10F);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("island_airspace/p5"), GetReference<ISpatialPoint>("island_airspace/pel2"), 1F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/pel2"), 2F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/pel6"), 10F);
            cs_vehicle_boost(false);
            cs_fly_to(GetReference<ISpatialPoint>("island_airspace/pelx"), 20F);
            ai_erase(island_pelican.Squad);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task island_pelican_arrives()
        {
            ai_place(island_pelican_allies.Squad, (short)(2 - (float)ai_living_count(allies_infantry)));
            ai_place(island_pelican.Squad);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_p", ai_actors(island_pelican_allies.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(island_pelican.pilot), true);
            object_create_anew(rack2);
            objects_attach(ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_sc_01", rack2.Entity, "pin");
            object_create_anew(bomb07);
            objects_attach(rack2.Entity, "rack01", bomb07.Entity, "pin");
            object_create_anew(bomb08);
            objects_attach(rack2.Entity, "rack02", bomb08.Entity, "pin");
            object_create_anew(bomb09);
            objects_attach(rack2.Entity, "rack03", bomb09.Entity, "pin");
            object_create_anew(bomb10);
            objects_attach(rack2.Entity, "rack04", bomb10.Entity, "pin");
            object_create_anew(bomb11);
            objects_attach(rack2.Entity, "rack05", bomb11.Entity, "pin");
            object_create_anew(bomb12);
            objects_attach(rack2.Entity, "rack06", bomb12.Entity, "pin");
            cs_run_command_script(island_pelican.pilot, new ScriptMethodReference(island_pelican_path));
            await sleep(150);
            wake(new ScriptMethodReference(island_pelican_comment));
            await sleep_until(async () => this.island_pelican_arrived == true);
            await sleep(120);
            begin_random(async () => objects_detach(rack2.Entity, bomb07.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb08.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb09.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb10.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb11.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb12.Entity), 
                async () => await sleep((short)random_range(2, 10)));
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task short_island_pel()
        {
            ai_place(island_pelican_allies.Squad, (short)(2 - (float)ai_living_count(allies_infantry)));
            ai_place(island_pelican.Squad);
            vehicle_load_magic(ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_p", ai_actors(island_pelican_allies.Squad));
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(island_pelican.pilot), true);
            object_create_anew(rack2);
            objects_attach(ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_sc_01", rack2.Entity, "pin");
            object_create_anew(bomb07);
            objects_attach(rack2.Entity, "rack01", bomb07.Entity, "pin");
            object_create_anew(bomb08);
            objects_attach(rack2.Entity, "rack02", bomb08.Entity, "pin");
            object_create_anew(bomb09);
            objects_attach(rack2.Entity, "rack03", bomb09.Entity, "pin");
            object_create_anew(bomb10);
            objects_attach(rack2.Entity, "rack04", bomb10.Entity, "pin");
            object_create_anew(bomb11);
            objects_attach(rack2.Entity, "rack05", bomb11.Entity, "pin");
            object_create_anew(bomb12);
            objects_attach(rack2.Entity, "rack06", bomb12.Entity, "pin");
            cs_run_command_script(island_pelican.pilot, new ScriptMethodReference(island_pelican_path));
            await sleep(150);
            wake(new ScriptMethodReference(island_pelican_comment));
            await sleep_until(async () => this.island_pelican_arrived == true);
            await sleep(90);
            begin_random(async () => objects_detach(rack2.Entity, bomb07.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb08.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb09.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb10.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb11.Entity), 
                async () => await sleep((short)random_range(2, 10)), 
                async () => objects_detach(rack2.Entity, bomb12.Entity), 
                async () => await sleep((short)random_range(2, 10)));
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task island_gully_start()
        {
            await sleep_until(async () => volume_test_objects(vol_island_int_exit, players()) == true);
            ai_disposable(island_int_enemies, true);
            data_mine_set_mission_segment("05b_11_island_gully");
            ai_renew(all_allies);
            game_save();
            ai_set_orders(all_allies, island_low_allies);
            ai_place(island_gully_buggers_01.Squad, 4);
            await sleep(1);
            ai_place(island_gully_elites_01.Squad, 2);
            await sleep_until(async () => volume_test_objects(vol_island_gully_ridge, players()) == true || (short)ai_living_count(island_gully_enemies) < 3);
            game_save();
            ai_place(island_gully_jackals_01.Squad, (short)(3 - (float)ai_living_count(island_gully_buggers_01.Squad)));
            await sleep(1);
            ai_place(island_gully_elites_02.Squad, (short)(2 - (float)ai_living_count(island_gully_elites_01.Squad)));
            await sleep_until(async () => volume_test_objects(vol_island_ext_start, players()) == true || (short)ai_living_count(island_gully_enemies) <= 3);
            if (volume_test_objects(vol_island_ext_start, players()) == false && await this.player_count() > 0)
            {
                wake(new ScriptMethodReference(island_pelican_arrives));
            }
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task gondola_02_cortana_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_gondola_02, players()) == true, 30, 3600);
            if (volume_test_objects(vol_gondola_02, players()) == true)
            {
                sleep_forever();
            }

            await sleep_until(async () => objects_can_see_object(players(), gondola_02_a.Entity, 30F) == true || volume_test_objects(vol_gondola_02, players()) == true);
            if (volume_test_objects(vol_gondola_02, players()) == true)
            {
                sleep_forever();
            }
            else
            {
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'there. another gondola. looks like it leads straight to the main-temple.'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1170"));
                await sleep(30);
                print("'not much further now...'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1180"));
                await sleep(30);
                ai_dialogue_enable(true);
            }

            await sleep_until(async () => device_get_position(gondola_02_a.Entity) > 0F, 30, 1800);
            if (device_get_position(gondola_02_a.Entity) > 0F)
            {
                activate_team_nav_point_object(_default, player, gondola_02_switch_front.Entity, 0F);
                await sleep_until(async () => device_get_position(gondola_02_a.Entity) > 0F);
                deactivate_team_nav_point_object(player, gondola_02_switch_front.Entity);
            }
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task island_drop()
        {
            object_set_phantom_power(ai_vehicle_get_from_starting_location(island_phantom.pilot), true);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a01");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a02");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a03");
            await sleep(45);
            ai_set_orders(island_phantom_jackals.Squad, island_ext_07);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_b01");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_b02");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_b03");
            await sleep(45);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c01");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c02");
            await sleep(5);
            vehicle_unload(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c03");
            await sleep(60);
            ai_set_orders(island_phantom_elites.Squad, island_ext_06);
            ai_set_orders(island_phantom_grunts.Squad, island_ext_06);
            object_set_phantom_power(ai_vehicle_get_from_starting_location(island_phantom.pilot), false);
        }

        [ScriptMethod(236, Lifecycle.CommandScript)]
        public async Task island_phantom_path()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_vehicle_speed(1F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/ph0"), 10F);
            cs_vehicle_boost(false);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/ph1"), 10F);
            cs_vehicle_speed(0.5F);
            if ((short)ai_living_count(island_all_enemies) < 8)
            {
                ai_place(island_phantom_elites.Squad, (short)(2 - (float)ai_living_count(island_ext_elites_01.Squad) + (float)ai_living_count(island_ext_elites_02.Squad)));
            }

            if ((short)ai_living_count(island_all_enemies) < 8)
            {
                ai_place(island_phantom_jackals.Squad, (short)(3 - (float)ai_living_count(island_ext_js_01.Squad) + (float)ai_living_count(island_ext_js_02.Squad) + (float)ai_living_count(island_ext_js_03.Squad) + (float)ai_living_count(island_ext_js_04.Squad)));
            }

            if ((short)ai_living_count(island_all_enemies) < 8)
            {
                ai_place(island_phantom_grunts.Squad, (short)(3 - (float)ai_living_count(island_ext_grunts_01.Squad) + (float)ai_living_count(island_ext_grunts_02.Squad)));
            }

            vehicle_load_magic(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c", ai_actors(island_phantom_elites.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a", ai_actors(island_phantom_jackals.Squad));
            vehicle_load_magic(ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p", ai_actors(island_phantom_grunts.Squad));
            cs_fly_to(GetReference<ISpatialPoint>("island_airspace/ph2"), 5F);
            cs_vehicle_speed(0.25F);
            wake(new ScriptMethodReference(island_drop));
            cs_fly_to(GetReference<ISpatialPoint>("island_airspace/ph2"), 2F);
            await sleep_until(async () => (short)ai_living_count(island_phantom.Squad) < 2);
            await sleep(60);
            cs_fly_to_and_face(GetReference<ISpatialPoint>("island_airspace/ph1"), GetReference<ISpatialPoint>("island_airspace/ph0"), 2F);
            cs_vehicle_speed(1F);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/ph0"), 10F);
            cs_vehicle_boost(true);
            cs_fly_by(GetReference<ISpatialPoint>("island_airspace/phx"), 20F);
            ai_erase(island_phantom.Squad);
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task island_phantom_arrives()
        {
            ai_place(island_phantom.Squad);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(island_phantom.pilot), true);
            cs_run_command_script(island_phantom.pilot, new ScriptMethodReference(island_phantom_path));
        }

        [ScriptMethod(238, Lifecycle.Static)]
        public async Task short_island_ph()
        {
            ai_allegiance(covenant, prophet);
            ai_place(island_phantom.Squad);
            ai_vehicle_reserve(ai_vehicle_get_from_starting_location(island_phantom.pilot), true);
            cs_run_command_script(island_phantom.pilot, new ScriptMethodReference(island_phantom_path));
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task island_exterior_start()
        {
            await sleep_until(async () => volume_test_objects(vol_island_ext_start, players()) == true);
            ai_disposable(island_gully_enemies, true);
            data_mine_set_mission_segment("05b_12_island_exterior");
            ai_renew(all_allies);
            game_save();
            ai_set_orders(all_allies, island_ext_allies);
            ai_place(temple_ent_turrets.Squad, 2);
            if (await this.difficulty_legendary())
            {
                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_elites_01.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_elites_02.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_01.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_02.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_03.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_04.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_grunts_01.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_grunts_02.Squad, 1);
                }
            }

            if (await this.difficulty_heroic())
            {
                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_elites_01.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_elites_02.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_01.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_02.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_03.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_grunts_01.Squad, 2);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_grunts_02.Squad, 1);
                }
            }

            if (await this.difficulty_normal())
            {
                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_elites_01.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_01.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_js_03.Squad, 1);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_grunts_01.Squad, 2);
                }

                if ((short)ai_living_count(island_all_enemies) < 8)
                {
                    ai_place(island_ext_grunts_02.Squad, 2);
                }
            }

            await sleep_until(async () => volume_test_objects(vol_island_ext_01, players()) == true || (short)ai_living_count(island_main_enemies) < 3);
            game_save();
            wake(new ScriptMethodReference(island_phantom_arrives));
            wake(new ScriptMethodReference(gondola_02_cortana_reminder));
            await sleep_until(async () => volume_test_objects(vol_near_gondola_02, players()) == true);
            game_save();
            object_dynamic_simulation_disable(gondola_02_a.Entity, true);
            object_dynamic_simulation_disable(gondola_02_b.Entity, true);
            if ((short)ai_living_count(island_all_enemies) < 8)
            {
                ai_place(near_gondola_02_jackals.Squad, (short)(2 - (float)ai_living_count(island_phantom_jackals.Squad)));
            }

            if ((short)ai_living_count(island_all_enemies) < 8)
            {
                ai_place(near_gondola_02_grunts.Squad, (short)(3 - (float)ai_living_count(island_phantom_grunts.Squad)));
            }

            await sleep_until(async () => (short)ai_living_count(island_main_enemies) <= 0 || device_get_position(gondola_02_a.Entity) > 0F);
            game_save();
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task island_miranda_conversation()
        {
            ai_dialogue_enable(false);
            await sleep(60);
            print("miranda: 'how's it going, you two?'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0170"));
            await sleep(30);
            print("cortana: 'so far, so good. we're nearing the main-temple now.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0180"));
            await sleep(30);
            print("miranda: 'roger that. i'm as close to the library as i can get.'");
            print("'there's some sort of barrier...we're trying to find a way around it.'");
            print("'i'll keep you posted.'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0190"));
            await sleep(30);
            ai_dialogue_enable(true);
            game_save();
            wake(new ScriptMethodReference(music_05b_09_start));
            await sleep(90);
            ai_set_blind(gondola_02_banshees1.Squad, false);
        }

        [ScriptMethod(241, Lifecycle.CommandScript)]
        public async Task gondola_02_ally_comment()
        {
            cs_switch("ally01");
            cs_abort_on_damage(true);
            print("ally: 'great. we gotta ride another one of these death-traps?'");
            cs_play_line("1190");
            cs_switch("ally02");
            cs_abort_on_damage(true);
            print("ally: 'if you forget about the covenant and the fact that we're stuck...'");
            print("'...on a freaky alien world�it's actually kinda fun.'");
            cs_play_line("1200");
        }

        [ScriptMethod(242, Lifecycle.CommandScript)]
        public async Task temple_ent_turret_01()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(temple_ent_turrets._1));
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(243, Lifecycle.CommandScript)]
        public async Task temple_ent_turret_02()
        {
            cs_force_combat_status(4);
            cs_enable_pathfinding_failsafe(true);
            cs_go_to_vehicle(ai_vehicle_get_from_starting_location(temple_ent_turrets._2));
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(244, Lifecycle.CommandScript)]
        public async Task banshee_retreat()
        {
            cs_vehicle_boost(true);
            cs_enable_moving(true);
            cs_enable_looking(true);
            await sleep_until(async () => volume_test_objects(vol_banshee_retreat, ai_actors(gondola_02_banshees1.Squad)) == true, 30, 4000);
            ai_erase(gondola_02_banshees1.Squad);
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task gondola_02_nuke()
        {
            await sleep_until(async () =>
            {
                if (objects_can_see_object(players(), list_get(ai_actors(island_all_enemies), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(island_all_enemies), 0)) > 30F)
                {
                    object_destroy(list_get(ai_actors(island_all_enemies), 0));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(island_all_enemies), 1), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(island_all_enemies), 1)) > 30F)
                {
                    object_destroy(list_get(ai_actors(island_all_enemies), 1));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(island_all_enemies), 2), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(island_all_enemies), 2)) > 30F)
                {
                    object_destroy(list_get(ai_actors(island_all_enemies), 2));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(all_allies), 0), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(all_allies), 0)) > 30F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 0));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(all_allies), 1), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(all_allies), 1)) > 30F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 1));
                }

                await sleep(5);
                if (objects_can_see_object(players(), list_get(ai_actors(all_allies), 2), 45F) == false && objects_distance_to_object(players(), list_get(ai_actors(all_allies), 2)) > 30F)
                {
                    object_destroy(list_get(ai_actors(all_allies), 2));
                }

                await sleep(5);
                return device_get_position(gondola_02_a.Entity) > 0.75F;
            });
        }

        [ScriptMethod(246, Lifecycle.Dormant)]
        public async Task gondola_02_wake()
        {
            await sleep_until(async () =>
            {
                if (device_get_position(gondola_02_a.Entity) > 0.37F && device_get_position(gondola_02_a.Entity) < 0.59F && device_get_position(gondola_02_a.Entity) > this.gondola_02_wake_state)
                {
                    object_clear_function_variable(gondola_02_a.Entity, "wake_forward");
                    object_clear_function_variable(gondola_02_a.Entity, "wake_backward");
                    object_set_function_variable(gondola_02_a.Entity, "wake_backward", 1F, 1F);
                    object_clear_function_variable(gondola_02_b.Entity, "wake_forward");
                    object_clear_function_variable(gondola_02_b.Entity, "wake_backward");
                    object_set_function_variable(gondola_02_b.Entity, "wake_backward", 1F, 1F);
                }

                if (device_get_position(gondola_02_a.Entity) > 0.37F && device_get_position(gondola_02_a.Entity) < 0.59F && device_get_position(gondola_02_a.Entity) < this.gondola_02_wake_state)
                {
                    object_clear_function_variable(gondola_02_a.Entity, "wake_forward");
                    object_clear_function_variable(gondola_02_a.Entity, "wake_backward");
                    object_set_function_variable(gondola_02_a.Entity, "wake_forward", 1F, 1F);
                    object_clear_function_variable(gondola_02_b.Entity, "wake_forward");
                    object_clear_function_variable(gondola_02_b.Entity, "wake_backward");
                    object_set_function_variable(gondola_02_b.Entity, "wake_forward", 1F, 1F);
                }

                if (device_get_position(gondola_02_a.Entity) == this.gondola_02_wake_state || device_get_position(gondola_02_a.Entity) < 0.37F || device_get_position(gondola_02_a.Entity) > 0.59F)
                {
                    object_clear_function_variable(gondola_02_a.Entity, "wake_forward");
                    object_clear_function_variable(gondola_02_a.Entity, "wake_backward");
                    object_clear_function_variable(gondola_02_b.Entity, "wake_forward");
                    object_clear_function_variable(gondola_02_b.Entity, "wake_backward");
                }

                this.gondola_02_wake_state = device_get_position(gondola_02_a.Entity);
                return device_get_position(gondola_02_a.Entity) == 1F;
            });
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task gondola_02_restarter()
        {
            await sleep_until(async () =>
            {
                this.gondola_02_state = device_get_position(gondola_02_a.Entity);
                if (volume_test_objects_all(vol_gondola_02_mid, players()) == true && await this.player_count() > 0)
                {
                    device_set_position(gondola_02_a.Entity, 0F);
                    device_set_position(gondola_02_b.Entity, 0F);
                }
                else
                {
                    device_set_position(gondola_02_a.Entity, this.gondola_02_state);
                    device_set_position(gondola_02_b.Entity, this.gondola_02_state);
                }

                return device_get_position(gondola_02_a.Entity) > 0.6F;
            });
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task gondola_02_reverser()
        {
            await sleep_until(async () =>
            {
                if (volume_test_objects_all(vol_gondola_02_mid, players()) == true && await this.player_count() > 0)
                {
                    device_set_position(gondola_02_a.Entity, 1F);
                    device_set_position(gondola_02_b.Entity, 1F);
                }
                else
                {
                    device_set_position(gondola_02_a.Entity, 0.54F);
                    device_set_position(gondola_02_b.Entity, 0.54F);
                }

                return device_get_position(gondola_02_a.Entity) > 0.6F;
            });
        }

        [ScriptMethod(249, Lifecycle.CommandScript)]
        public async Task boost_test()
        {
            cs_vehicle_boost(true);
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_enable_moving(true);
            await sleep_until(async () => objects_distance_to_object(players(), ai_get_object(this.ai_current_actor)) < 30F);
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task boost_to_temple_01()
        {
            cs_vehicle_boost(true);
            cs_enable_moving(true);
            cs_enable_looking(true);
            sleep_forever();
        }

        [ScriptMethod(251, Lifecycle.CommandScript)]
        public async Task boost_to_temple_02()
        {
            cs_vehicle_boost(true);
            cs_enable_moving(true);
            cs_enable_looking(true);
            sleep_forever();
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task panic()
        {
            cs_enable_moving(true);
            cs_movement_mode(3);
            sleep_forever();
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task gondola_02_start()
        {
            await sleep_until(async () => volume_test_objects(vol_near_gondola_02, players()) == true);
            ai_disposable(island_all_enemies, true);
            await sleep_until(async () => device_group_get(gondola_02_switch) > 0F || (short)ai_living_count(island_main_enemies) < 1);
            if (device_group_get(gondola_02_switch) > 0F)
            {
                ai_set_orders(all_allies, gondola_02_allies);
            }
            else
            {
                await sleep(60);
                ai_set_orders(all_allies, gondola_02_allies);
                ai_scene("gondola_02_ally_scene", new ScriptMethodReference(gondola_02_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                ;
            }

            data_mine_set_mission_segment("05b_13_gondola_02");
            ai_renew(all_allies);
            await sleep_until(async () => device_group_get(gondola_02_switch) > 0F);
            device_set_power(gondola_02_switch_front.Entity, 0F);
            wake(new ScriptMethodReference(gondola_02_wake));
            object_dynamic_simulation_disable(gondola_02_a.Entity, false);
            object_dynamic_simulation_disable(gondola_02_b.Entity, false);
            await sleep_until(async () => volume_test_objects_all(vol_gondola_02, players()) == true && await this.player_count() > 0);
            device_set_position(gondola_02_launch_a.Entity, 1F);
            device_set_position(gondola_02_launch_b.Entity, 1F);
            device_set_position(gondola_02_a.Entity, 0.54F);
            device_set_position(gondola_02_b.Entity, 0.54F);
            wake(new ScriptMethodReference(island_miranda_conversation));
            await sleep(300);
            ai_place(gondola_02_banshees1.Squad, 2);
            cs_run_command_script(gondola_02_banshees1.Squad, new ScriptMethodReference(boost_test));
            await sleep_until(async () => device_get_position(gondola_02_a.Entity) >= 0.25F);
            if (await this.difficulty_legendary())
            {
                ai_place(gondola_02_grunts.Squad, 4);
            }

            ai_place(gondola_02_jetpacks.Squad, 2);
            await sleep_until(async () => device_get_position(gondola_02_a.Entity) >= 0.43F);
            game_save();
            wake(new ScriptMethodReference(gondola_02_nuke));
            ai_set_orders(gondola_02_jetpacks.Squad, gondola_02_jets);
            await sleep_until(async () => device_get_position(gondola_02_a.Entity) == 0.54F);
            object_dynamic_simulation_disable(gondola_02_a.Entity, true);
            object_dynamic_simulation_disable(gondola_02_b.Entity, true);
            await sleep_until(async () => (float)ai_living_count(gondola_02_grunts.Squad) + (float)ai_living_count(gondola_02_jetpacks.Squad) < 1F, 30, 1800);
            await sleep_until(async () => (bool)ai_trigger_test("done_fighting", gondola_02_enemies) == true, 30, 1800);
            game_save();
            object_dynamic_simulation_disable(gondola_02_a.Entity, false);
            object_dynamic_simulation_disable(gondola_02_b.Entity, false);
            wake(new ScriptMethodReference(music_05b_09_start_alt));
            wake(new ScriptMethodReference(gondola_02_reverser));
            await sleep_until(async () => device_get_position(gondola_02_a.Entity) > 0.75F);
            ai_set_orders(gondola_02_banshees1.Squad, airspace_island);
            cs_run_command_script(gondola_02_banshees1.Squad, new ScriptMethodReference(banshee_retreat));
            ai_place(temple_ent_grunts.Squad, 4);
            cs_run_command_script(temple_ent_grunts._1, new ScriptMethodReference(temple_ent_turret_01));
            cs_run_command_script(temple_ent_grunts._2, new ScriptMethodReference(temple_ent_turret_02));
            ai_place(temple_ent_jackals.Squad, 2);
            await sleep_until(async () => device_get_position(gondola_02_a.Entity) > 0.9F);
            ai_set_orders(gondola_02_jetpacks.Squad, jetpacks_temple);
            cs_run_command_script(gondola_02_jetpacks._1, new ScriptMethodReference(boost_to_temple_01));
            cs_run_command_script(gondola_02_jetpacks._2, new ScriptMethodReference(boost_to_temple_01));
            await sleep_until(async () => device_get_position(gondola_02_a.Entity) == 1F);
            object_dynamic_simulation_disable(gondola_02_a.Entity, true);
            object_dynamic_simulation_disable(gondola_02_b.Entity, true);
            game_save();
            ai_vehicle_exit(temple_ent_turrets.Squad);
            ai_set_orders(temple_ent_grunts.Squad, temple_ent_retreat);
            ai_set_orders(temple_ent_jackals.Squad, temple_ent_retreat);
            device_set_position(gondola_02_launch_a.Entity, 0F);
            device_set_position(gondola_02_launch_b.Entity, 0F);
            cs_run_command_script(temple_ent_grunts.Squad, new ScriptMethodReference(panic));
            await sleep(60);
            cs_run_command_script(temple_ent_jackals.Squad, new ScriptMethodReference(panic));
        }

        [ScriptMethod(254, Lifecycle.CommandScript)]
        public async Task temple_hunker()
        {
            cs_crouch(true);
            sleep_forever();
        }

        [ScriptMethod(255, Lifecycle.CommandScript)]
        public async Task high_charity_ally_comment()
        {
            cs_switch("ally");
            cs_abort_on_damage(true);
            print("ally: 'damn! look at the size of that thing!'");
            cs_play_line("1210");
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task temple_ent_cortana_reminder()
        {
            await sleep_until(async () => volume_test_objects(vol_temple_entry, players()) == true, 30, 1800);
            if (volume_test_objects(vol_temple_entry, players()) == false)
            {
                ai_dialogue_enable(false);
                await sleep_until(async () => volume_test_objects(vol_temple_entry, players()) == true, 30, 60);
                if (volume_test_objects(vol_temple_entry, players()) == false)
                {
                    print("cortana: 'there's no time, chief! get inside and take care of the prophet!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "1220"));
                }

                await sleep(30);
                ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(257, Lifecycle.CommandScript)]
        public async Task temple_deploy_l()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("temple_turrets/deploy_left"));
            cs_deploy_turret(GetReference<ISpatialPoint>("temple_turrets/left"));
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(258, Lifecycle.CommandScript)]
        public async Task temple_deploy_r()
        {
            cs_enable_pathfinding_failsafe(true);
            cs_go_to(GetReference<ISpatialPoint>("temple_turrets/deploy_right"));
            cs_deploy_turret(GetReference<ISpatialPoint>("temple_turrets/right"));
            cs_enable_targeting(true);
            cs_shoot(true);
            cs_set_behavior(guard);
            sleep_forever();
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task temple_entry_start()
        {
            await sleep_until(async () => (short)ai_living_count(temple_entry_enemies) < 1 || volume_test_objects(vol_temple_ent_cutscene, players()) == true, 5);
            ai_disposable(gondola_02_enemies, true);
            wake(new ScriptMethodReference(music_05b_09_stop));
            await this.cinematic_fade_to_white();
            object_teleport(await this.player0(), player0_hide_bsp3);
            object_teleport(await this.player1(), player1_hide_bsp3);
            cs_run_command_script(all_allies, new ScriptMethodReference(temple_hunker));
            if (await this.cinematic_skip_start())
            {
                await this.c05_intra2();
            }

            await this.cinematic_skip_stop();
            await sleep(2);
            object_teleport(await this.player0(), temple_ext_player0);
            object_teleport(await this.player1(), temple_ext_player1);
            object_create_anew(fleet01);
            object_create_anew(fleet02);
            object_create_anew(fleet_high_char);
            cs_run_command_script(temple_ent_grunts.Squad, new ScriptMethodReference(abort));
            cs_run_command_script(temple_ent_jackals.Squad, new ScriptMethodReference(abort));
            cs_run_command_script(gondola_02_jetpacks.Squad, new ScriptMethodReference(abort));
            cs_run_command_script(all_allies, new ScriptMethodReference(abort));
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            wake(new ScriptMethodReference(_05b_title2));
            wake(new ScriptMethodReference(objective_temple_clear));
            wake(new ScriptMethodReference(objective_regret_set));
            data_mine_set_mission_segment("05b_14_temple_exterior");
            ai_renew(all_allies);
            game_save_immediate();
            await sleep(30);
            ai_set_orders(all_allies, temple_ent_allies);
            ai_scene("temple_ent_ally_scene", new ScriptMethodReference(high_charity_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            wake(new ScriptMethodReference(temple_ent_cortana_reminder));
            if (await this.difficulty_legendary())
            {
                ai_place(temple_heavies.Squad, 2);
                begin_random(async () => cs_run_command_script(temple_heavies.left, new ScriptMethodReference(temple_deploy_l)), 
                    async () => cs_run_command_script(temple_heavies.right, new ScriptMethodReference(temple_deploy_r)));
            }
            else
            {
                ai_place(temple_heavies.Squad, 1);
                begin_random(async () => cs_run_command_script(temple_heavies.Squad, new ScriptMethodReference(temple_deploy_l)), 
                    async () => cs_run_command_script(temple_heavies.Squad, new ScriptMethodReference(temple_deploy_r)));
            }

            await sleep(90);
            if (await this.difficulty_legendary())
            {
                ai_place(temple_halls_jackals_01.Squad, (short)(2 - (float)ai_living_count(temple_ent_jackals.Squad)));
            }
            else
            {
                ai_place(temple_halls_jackals_01.Squad, (short)(3 - (float)ai_living_count(temple_ent_jackals.Squad)));
            }

            if (await this.difficulty_legendary())
            {
                ai_place(temple_halls_elites_01.Squad, (short)(2 - (float)ai_living_count(gondola_02_jetpacks.Squad)));
            }
            else
            {
                ai_place(temple_halls_elites_01.Squad, (short)(1 - (float)ai_living_count(gondola_02_jetpacks.Squad)));
            }
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task temple_cortana_warn_02()
        {
            await sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            game_save_cancel();
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'the covenant fleet has launched multiple waves of reinforcements!'");
            print("'too many for me to track! we don't have much time!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0210"));
            await sleep(30);
            ai_dialogue_enable(true);
            this.bossfight_chatter = true;
            game_save_no_timeout();
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task temple_foyer_start()
        {
            await sleep_until(async () => volume_test_objects(vol_temple_entry, players()) == true);
            data_mine_set_mission_segment("05b_15_temple_halls");
            ai_renew(all_allies);
            game_save_no_timeout();
            ai_set_orders(all_allies, temple_halls_allies);
            await sleep_until(async () => (short)ai_living_count(temple_entry_enemies) < 3, 30, 60);
            game_save_no_timeout();
            if (volume_test_objects(vol_temple_left, players()) == true)
            {
                ai_place(temple_halls_jackals_02L.Squad, (short)(4 - (float)ai_living_count(temple_halls_jackals_01.Squad)));
            }

            if (volume_test_objects(vol_temple_right, players()) == true)
            {
                ai_place(temple_halls_jackals_02R.Squad, (short)(4 - (float)ai_living_count(temple_halls_jackals_02L.Squad) + (float)ai_living_count(temple_halls_jackals_01.Squad)));
            }

            await sleep_until(async () => volume_test_objects(vol_temple_foyer, players()) == true);
            game_save_no_timeout();
            ai_place(temple_halls_elites_02.Squad, 2);
            wake(new ScriptMethodReference(temple_cortana_warn_02));
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task temple_cortana_warn_01()
        {
            await sleep_until(async () => objects_distance_to_object(players(), list_get(ai_actors(regret1.Squad), 0)) < 15F && objects_can_see_object(players(), list_get(ai_actors(regret1.Squad), 0), 30F) == true);
            await sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                game_save_cancel();
                ai_dialogue_enable(false);
                await sleep(60);
                if (this.regret_dead == false)
                {
                    print("cortana: 'there's the target! take him out!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "0200"));
                }

                await sleep(30);
                ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                game_save_no_timeout();
            }
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task temple_cortana_warn_03()
        {
            await sleep_until(async () => this.regret_dead == true || this.regret_times_dead > 0, 30, 5100);
            if (this.regret_dead == false)
            {
                await sleep_until(async () => this.bossfight_chatter == true);
                this.bossfight_chatter = false;
                game_save_cancel();
                ai_dialogue_enable(false);
                await sleep(60);
                print("cortana: 'bad news. the reinforcements are turning around -'");
                print("'the fleet is preparing to fire on our position! we need to get out of here!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "0220"));
                await sleep(30);
                ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                game_save_no_timeout();
            }
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task temple_cortana_reminder()
        {
            await sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            game_save_cancel();
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'go! back out the way we came in!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1370"));
            await sleep(30);
            ai_dialogue_enable(true);
            this.bossfight_chatter = true;
            game_save_no_timeout();
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task regret_hint_01()
        {
            await sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                ai_dialogue_enable(false);
                await sleep_until(async () => (bool)game_safe_to_save(), 30, 600);
                game_save_cancel();
                if (this.regret_dead == false)
                {
                    print("cortana: 'his throne is shielded!  it's deflecting everything you throw at it!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "1230"));
                    await sleep(15);
                    print("cortana: 'get in close, and do whatever you can!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "1240"));
                }

                await sleep(30);
                ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                game_save_no_timeout();
            }
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task regret_hint_02()
        {
            await sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                ai_dialogue_enable(false);
                await sleep_until(async () => (bool)game_safe_to_save(), 30, 600);
                game_save_cancel();
                if (this.regret_dead == false)
                {
                    print("cortana: 'you've got to get him out of that throne!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "1250"));
                }

                await sleep(30);
                ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                game_save_no_timeout();
            }
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task regret_hint_03()
        {
            await sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                ai_dialogue_enable(false);
                await sleep_until(async () => (bool)game_safe_to_save(), 30, 600);
                game_save_cancel();
                if (this.regret_dead == false)
                {
                    print("cortana: 'quick! board his throne!'");
                    await sleep(ai_play_line_on_object(default(IGameObject), "1290"));
                }

                await sleep(30);
                ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                game_save_no_timeout();
            }
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task regret_teleport_comment()
        {
            await sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'phased spatial relocation! the same technology the monitor used on the first halo.'");
            print("'seems the prophets save the best toys for themselves�'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1260"));
            await sleep(30);
            ai_dialogue_enable(true);
            this.bossfight_chatter = true;
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task regret_beam_comment()
        {
            await sleep_until(async () => (short)ai_combat_status(regret1.Squad) >= this.ai_combat_status_clear_los);
            await sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'keep clear of that beam! i don't think you'll survive a direct hit!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "1270"));
            await sleep(30);
            ai_dialogue_enable(true);
            this.bossfight_chatter = true;
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task regret_hg_comment()
        {
            await sleep_until(async () => (short)ai_combat_status(temple_hg_init.Squad) >= this.ai_combat_status_clear_los);
            await sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            game_save_cancel();
            ai_dialogue_enable(false);
            await sleep(60);
            if (this.regret_dead == false)
            {
                print("cortana: 'there are honor-guards all over this place!  watch your back!'");
                await sleep(ai_play_line_on_object(default(IGameObject), "1280"));
            }

            await sleep(30);
            ai_dialogue_enable(true);
            this.bossfight_chatter = true;
            game_save_no_timeout();
        }

        [ScriptMethod(271, Lifecycle.Static)]
        public async Task regret_taunt_01()
        {
            await sleep_until(async () => this.bossfight_chatter == true && unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            print("regret: 'warriors! attack! the demon must die!'");
            custom_animation(unit(ai_get_object(regret1.Squad)), GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:point", true);
            await sleep(ai_play_line(regret1.Squad, "1300"));
            this.bossfight_chatter = true;
            await sleep((short)random_range(300, 600));
        }

        [ScriptMethod(272, Lifecycle.Static)]
        public async Task regret_taunt_02()
        {
            await sleep_until(async () => this.bossfight_chatter == true && unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            print("regret: 'you dare to interrupt my sermon?!'");
            custom_animation(unit(ai_get_object(regret1.Squad)), GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:cheer", true);
            await sleep(ai_play_line(regret1.Squad, "1310"));
            this.bossfight_chatter = true;
            await sleep((short)random_range(300, 600));
        }

        [ScriptMethod(273, Lifecycle.Static)]
        public async Task regret_taunt_03()
        {
            await sleep_until(async () => this.bossfight_chatter == true && unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            print("regret: 'the great journey will not be postponed!'");
            custom_animation(unit(ai_get_object(regret1.Squad)), GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:cheer", true);
            await sleep(ai_play_line(regret1.Squad, "1320"));
            this.bossfight_chatter = true;
            await sleep((short)random_range(300, 600));
        }

        [ScriptMethod(274, Lifecycle.Static)]
        public async Task regret_taunt_04()
        {
            await sleep_until(async () => this.bossfight_chatter == true && unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            print("regret: 'guards! remove this vermin from my sight!'");
            custom_animation(unit(ai_get_object(regret1.Squad)), GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:point", true);
            await sleep(ai_play_line(regret1.Squad, "1330"));
            this.bossfight_chatter = true;
            await sleep((short)random_range(300, 600));
        }

        [ScriptMethod(275, Lifecycle.Static)]
        public async Task regret_taunt_05()
        {
            await sleep_until(async () => this.bossfight_chatter == true && unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            print("regret: 'human filth! you befoul this holy place!'");
            custom_animation(unit(ai_get_object(regret1.Squad)), GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:taunt", true);
            await sleep(ai_play_line(regret1.Squad, "1340"));
            this.bossfight_chatter = true;
            await sleep((short)random_range(300, 600));
        }

        [ScriptMethod(276, Lifecycle.Static)]
        public async Task regret_taunt_06()
        {
            await sleep_until(async () => this.bossfight_chatter == true && unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            print("regret: 'incompetents! i'll kill it myself!'");
            custom_animation(unit(ai_get_object(regret1.Squad)), GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:taunt", true);
            await sleep(ai_play_line(regret1.Squad, "1350"));
            this.bossfight_chatter = true;
            await sleep((short)random_range(300, 600));
        }

        [ScriptMethod(277, Lifecycle.Static)]
        public async Task regret_taunt_07()
        {
            await sleep_until(async () => this.bossfight_chatter == true && unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            print("regret: 'your very existence offends me, demon!'");
            custom_animation(unit(ai_get_object(regret1.Squad)), GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:cheer", true);
            await sleep(ai_play_line(regret1.Squad, "1360"));
            this.bossfight_chatter = true;
            await sleep((short)random_range(300, 600));
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task regret_taunts()
        {
            begin_random(async () => await this.regret_taunt_01(), 
                async () => await this.regret_taunt_02(), 
                async () => await this.regret_taunt_03(), 
                async () => await this.regret_taunt_04(), 
                async () => await this.regret_taunt_05(), 
                async () => await this.regret_taunt_06(), 
                async () => await this.regret_taunt_07());
        }

        [ScriptMethod(279, Lifecycle.Dormant)]
        public async Task temple_grunt_spawner()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_L_01) > 5F && objects_can_see_flag(players(), temple_L_01, 45F) == false)
                    {
                        ai_place(honor_grunts_new_L._01);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_L_02) > 5F && objects_can_see_flag(players(), temple_L_02, 45F) == false)
                    {
                        ai_place(honor_grunts_new_L._02);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_L_03) > 5F && objects_can_see_flag(players(), temple_L_03, 45F) == false)
                    {
                        ai_place(honor_grunts_new_L._03);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_L_04) > 5F && objects_can_see_flag(players(), temple_L_04, 45F) == false)
                    {
                        ai_place(honor_grunts_new_L._04);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_L_05) > 5F && objects_can_see_flag(players(), temple_L_05, 45F) == false)
                    {
                        ai_place(honor_grunts_new_L._05);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_R_01) > 5F && objects_can_see_flag(players(), temple_R_01, 45F) == false)
                    {
                        ai_place(honor_grunts_new_R._01);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_R_02) > 5F && objects_can_see_flag(players(), temple_R_02, 45F) == false)
                    {
                        ai_place(honor_grunts_new_R._02);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_R_03) > 5F && objects_can_see_flag(players(), temple_R_03, 45F) == false)
                    {
                        ai_place(honor_grunts_new_R._03);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_R_04) > 5F && objects_can_see_flag(players(), temple_R_04, 45F) == false)
                    {
                        ai_place(honor_grunts_new_R._04);
                        await sleep((short)random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_honor_grunts) < 2 && objects_distance_to_flag(players(), temple_R_05) > 5F && objects_can_see_flag(players(), temple_R_05, 45F) == false)
                    {
                        ai_place(honor_grunts_new_R._05);
                        await sleep((short)random_range(120, 240));
                    }
                });
                await sleep_until(async () => (bool)ai_vitality_pinned(regret1.Squad) == true || this.regret_dead == true || (short)ai_living_count(temple_honor_grunts) < 2);
                return this.regret_dead == true;
            });
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task temple_hg_respawner()
        {
            await sleep_until(async () =>
            {
                begin_random(async () =>
                {
                    if ((short)ai_living_count(temple_hg) < this.hg_count && device_get_position(temple_spawndoor_01r.Entity) == 0F && volume_test_objects(vol_temple_spawnroom_01r, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(temple_hg_01R.Squad, 1);
                        await sleep((short)random_range(60, 120));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_hg) < this.hg_count && device_get_position(temple_spawndoor_01l.Entity) == 0F && volume_test_objects(vol_temple_spawnroom_01l, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(temple_hg_01L.Squad, 1);
                        await sleep((short)random_range(60, 120));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_hg) < this.hg_count && device_get_position(temple_spawndoor_02r.Entity) == 0F && volume_test_objects(vol_temple_spawnroom_02r, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(temple_hg_02R.Squad, 1);
                        await sleep((short)random_range(60, 120));
                    }
                }, 
                    async () =>
                {
                    if ((short)ai_living_count(temple_hg) < this.hg_count && device_get_position(temple_spawndoor_02l.Entity) == 0F && volume_test_objects(vol_temple_spawnroom_02l, players()) == false && await this.player_count() > 0)
                    {
                        ai_place(temple_hg_02L.Squad, 1);
                        await sleep((short)random_range(60, 120));
                    }
                });
                await sleep_until(async () => (bool)ai_vitality_pinned(regret1.Squad) == true || this.regret_dead == true || (short)ai_living_count(temple_hg) < 1);
                await sleep_until(async () => (bool)ai_vitality_pinned(regret1.Squad) == true || this.regret_dead == true, 30, (int)(this.hg_delay / this.regret_times_dead + 1F));
                return this.regret_dead == true;
            });
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task regret_respawner()
        {
            await sleep_until(async () =>
            {
                await sleep_until(async () => (bool)ai_vitality_pinned(regret1.Squad) == true);
                effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                unit_exit_vehicle(await this.player0(), 1);
                unit_exit_vehicle(await this.player1(), 1);
                await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
                object_destroy(this.regret_corpse);
                object_destroy(this.regret_throne);
                await sleep(60);
                ai_place(regret1.Squad, 1);
                ai_cannot_die(regret1.Squad, true);
                this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
                this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
                effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                this.regret_times_dead = (short)(this.regret_times_dead + 1);
                return this.regret_times_dead == 4;
            });
        }

        [ScriptMethod(282, Lifecycle.CommandScript)]
        public async Task reserve_throne()
        {
            await sleep(2);
            ai_vehicle_reserve(ai_vehicle_get(this.ai_current_actor), true);
            await sleep(2);
        }

        [ScriptMethod(283, Lifecycle.CommandScript)]
        public async Task regret_pause()
        {
            cs_abort_on_damage(true);
            await sleep_until(async () => volume_test_objects(vol_temple_02, players()) == true && objects_can_see_object(ai_actors(regret1.Squad), await this.player0(), 45F) == true || objects_can_see_object(ai_actors(regret1.Squad), await this.player1(), 45F) == true);
        }

        [ScriptMethod(284, Lifecycle.Dormant)]
        public async Task regret_retreat()
        {
            if (await this.difficulty_legendary())
            {
                this.regret_lives = 4;
            }

            if (await this.difficulty_heroic())
            {
                this.regret_lives = 2;
            }

            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_object(players(), list_get(ai_actors(regret1.Squad), 0)) < 5F);
                await sleep_until(async () => unit_in_vehicle(await this.player0()) == true || unit_in_vehicle(await this.player1()) == true || objects_distance_to_object(players(), list_get(ai_actors(regret1.Squad), 0)) > 5F, 30, 150);
                if (unit_in_vehicle(await this.player0()) == true || unit_in_vehicle(await this.player1()) == true)
                {
                    await sleep_until(async () => (bool)ai_vitality_pinned(regret1.Squad) == true, 30, 150);
                    if ((bool)ai_vitality_pinned(regret1.Squad) == false)
                    {
                        unit_set_enterable_by_player(unit(this.regret_throne), false);
                        effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        await sleep(30);
                        unit_exit_vehicle(await this.player0(), 1);
                        unit_exit_vehicle(await this.player1(), 1);
                        await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
                        object_destroy(this.regret_corpse);
                        object_destroy(this.regret_throne);
                        await sleep(60);
                        ai_place(regret1.Squad, 1);
                        ai_cannot_die(regret1.Squad, true);
                        if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                        {
                            ai_set_orders(regret1.Squad, regret_02);
                        }

                        if (this.regret_times_dead > 2)
                        {
                            ai_set_orders(regret1.Squad, regret_03);
                        }

                        this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
                        this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
                        effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                        unit_set_enterable_by_player(unit(this.regret_throne), true);
                    }
                    else
                    {
                        unit_set_enterable_by_player(unit(this.regret_throne), false);
                        effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        await sleep(30);
                        unit_exit_vehicle(await this.player0(), 1);
                        unit_exit_vehicle(await this.player1(), 1);
                        await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
                        object_destroy(this.regret_corpse);
                        object_destroy(this.regret_throne);
                        await sleep(60);
                        game_save();
                        ai_place(regret1.Squad, 1);
                        ai_cannot_die(regret1.Squad, true);
                        if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                        {
                            ai_set_orders(regret1.Squad, regret_02);
                        }

                        if (this.regret_times_dead > 2)
                        {
                            ai_set_orders(regret1.Squad, regret_03);
                        }

                        this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
                        this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
                        effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                        this.regret_times_dead = (short)(this.regret_times_dead + 1);
                        unit_set_enterable_by_player(unit(this.regret_throne), true);
                    }
                }
                else if (objects_distance_to_object(players(), list_get(ai_actors(regret1.Squad), 0)) < 5F)
                {
                    unit_set_enterable_by_player(unit(this.regret_throne), false);
                    effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    await sleep(30);
                    unit_exit_vehicle(await this.player0(), 1);
                    unit_exit_vehicle(await this.player1(), 1);
                    await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
                    object_destroy(this.regret_corpse);
                    object_destroy(this.regret_throne);
                    await sleep(60);
                    ai_place(regret1.Squad, 1);
                    ai_cannot_die(regret1.Squad, true);
                    if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                    {
                        ai_set_orders(regret1.Squad, regret_02);
                    }

                    if (this.regret_times_dead > 2)
                    {
                        ai_set_orders(regret1.Squad, regret_03);
                    }

                    this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
                    this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
                    effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                    unit_set_enterable_by_player(unit(this.regret_throne), true);
                }
                else
                {
                    print("do nothing");
                }

                return this.regret_times_dead == this.regret_lives;
            });
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task regret_death()
        {
            object_create_anew(fake_corpse);
            await sleep(2);
            object_cannot_take_damage(fake_corpse.Entity);
            object_hide(fake_corpse.Entity, true);
            await sleep_until(async () =>
            {
                await sleep_until(async () => objects_distance_to_object(players(), list_get(ai_actors(regret1.Squad), 0)) < 5F);
                await sleep_until(async () => unit_in_vehicle(await this.player0()) == true || unit_in_vehicle(await this.player1()) == true || objects_distance_to_object(players(), list_get(ai_actors(regret1.Squad), 0)) > 5F, 30, 150);
                if (unit_in_vehicle(await this.player0()) == true || unit_in_vehicle(await this.player1()) == true)
                {
                    await sleep_until(async () => (bool)ai_vitality_pinned(regret1.Squad) == true, 30, 150);
                    if ((bool)ai_vitality_pinned(regret1.Squad) == false)
                    {
                        unit_set_enterable_by_player(unit(this.regret_throne), false);
                        effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        await sleep(30);
                        unit_exit_vehicle(await this.player0(), 1);
                        unit_exit_vehicle(await this.player1(), 1);
                        await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
                        object_destroy(this.regret_corpse);
                        object_destroy(this.regret_throne);
                        await sleep(60);
                        ai_place(regret1.Squad, 1);
                        ai_cannot_die(regret1.Squad, true);
                        cs_run_command_script(regret1.Squad, new ScriptMethodReference(reserve_throne));
                        if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                        {
                            ai_set_orders(regret1.Squad, regret_02);
                        }

                        if (this.regret_times_dead > 2)
                        {
                            ai_set_orders(regret1.Squad, regret_03);
                        }

                        this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
                        this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
                        effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                        unit_set_enterable_by_player(unit(this.regret_throne), true);
                    }
                    else
                    {
                        this.regret_dead = true;
                        objects_attach(this.regret_throne, "driver", fake_corpse.Entity, "");
                        await sleep(2);
                        object_hide(fake_corpse.Entity, false);
                        object_hide(this.regret_corpse, true);
                        unit_set_enterable_by_player(unit(this.regret_throne), false);
                        custom_animation_loop(fake_corpse.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "throne_d:dead", true);
                        ai_play_line_on_object(fake_corpse.Entity, "1380") // Couldn't generate cast from 'Short' to 'Void'
                        ;
                        await sleep(60);
                        effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\prophet\\regret_death", 2245469061U), fake_corpse.Entity, "body");
                        effect_new_on_object_marker(GetTag<EffectTag>("effects\\objects\\characters\\prophet\\regret_death", 2245469061U), this.regret_throne, "");
                        unit_exit_vehicle(await this.player0(), 1);
                        unit_exit_vehicle(await this.player1(), 1);
                        ai_cannot_die(regret1.Squad, false);
                        object_hide(this.regret_corpse, true);
                        ai_kill(regret1.Squad);
                        await sleep(1);
                        object_hide(this.regret_corpse, true);
                        object_clear_all_function_variables(this.regret_throne);
                        await sleep(150);
                        sound_impulse_start(GetTag<SoundTag>("sound\\vehicles\\damage_effects\\cov_damage_large", 3912435645U), this.regret_throne, 1F);
                    }
                }
                else if (objects_distance_to_object(players(), list_get(ai_actors(regret1.Squad), 0)) < 5F)
                {
                    unit_set_enterable_by_player(unit(this.regret_throne), false);
                    effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    await sleep(30);
                    unit_exit_vehicle(await this.player0(), 1);
                    unit_exit_vehicle(await this.player1(), 1);
                    await sleep_until(async () => unit_in_vehicle(await this.player0()) == false && unit_in_vehicle(await this.player1()) == false);
                    object_destroy(this.regret_corpse);
                    object_destroy(this.regret_throne);
                    await sleep(60);
                    ai_place(regret1.Squad, 1);
                    ai_cannot_die(regret1.Squad, true);
                    cs_run_command_script(regret1.Squad, new ScriptMethodReference(reserve_throne));
                    if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                    {
                        ai_set_orders(regret1.Squad, regret_02);
                    }

                    if (this.regret_times_dead > 2)
                    {
                        ai_set_orders(regret1.Squad, regret_03);
                    }

                    this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
                    this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
                    effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                    unit_set_enterable_by_player(unit(this.regret_throne), true);
                }
                else
                {
                    print("do nothing");
                }

                return this.regret_dead == true;
            });
        }

        [ScriptMethod(286, Lifecycle.Static)]
        public async Task regret_test()
        {
            ai_place(regret1._1);
            await sleep(60);
            this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
            this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
            object_create_anew(regret03);
            print("destroy him");
            object_destroy(this.regret_corpse);
            print("attach him");
            objects_attach(this.regret_throne, "driver", regret03.Entity, "");
            print("animate him");
            custom_animation_loop(regret03.Entity, GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896444617U), "combat:any:any:cheer", true);
        }

        [ScriptMethod(287, Lifecycle.CommandScript)]
        public async Task regret_dead_retreat()
        {
            cs_enable_moving(true);
            cs_enable_looking(true);
            sleep_forever();
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task temple_center_start()
        {
            await sleep_until(async () => volume_test_objects(vol_temple_foyer, players()) == true);
            ai_disposable(temple_entry_enemies, true);
            data_mine_set_mission_segment("05b_16_temple_center");
            ai_renew(all_allies);
            game_save_no_timeout();
            ai_place(regret1._1);
            ai_cannot_die(regret1.Squad, true);
            cs_run_command_script(regret1.Squad, new ScriptMethodReference(regret_pause));
            this.regret_corpse = this.regret_corpse = list_get(ai_actors(regret1.Squad), 0);
            this.regret_throne = object_get_parent(list_get(ai_actors(regret1.Squad), 0));
            object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
            ai_place(temple_hg_init.Squad, 2);
            wake(new ScriptMethodReference(regret_hg_comment));
            wake(new ScriptMethodReference(temple_hg_respawner));
            ai_place(honor_grunts_init_R.Squad, 2);
            ai_place(honor_grunts_init_L.Squad, 2);
            wake(new ScriptMethodReference(temple_grunt_spawner));
            if (await this.difficulty_legendary() || await this.difficulty_heroic())
            {
                wake(new ScriptMethodReference(regret_retreat));
            }
            else
            {
                wake(new ScriptMethodReference(regret_death));
            }

            await sleep_until(async () => volume_test_objects(vol_temple_02, players()) == true);
            ai_set_orders(all_allies, temple_left_allies);
            wake(new ScriptMethodReference(temple_cortana_warn_01));
            wake(new ScriptMethodReference(regret_taunts));
            await sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true, 30, 3600);
            if (this.regret_times_dead == 0 && this.regret_dead == false)
            {
                wake(new ScriptMethodReference(regret_hint_01));
            }

            await sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true, 30, 3600);
            if (this.regret_times_dead == 0 && this.regret_dead == false)
            {
                wake(new ScriptMethodReference(regret_hint_02));
            }

            await sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true, 30, 1800);
            if (this.regret_times_dead == 0 && this.regret_dead == false)
            {
                wake(new ScriptMethodReference(regret_hint_03));
            }

            await sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true);
            if (await this.difficulty_heroic())
            {
                this.hg_count = 3;
                await sleep_until(async () => this.regret_times_dead == 2);
                wake(new ScriptMethodReference(regret_death));
            }

            if (await this.difficulty_legendary())
            {
                this.hg_count = 3;
                await sleep_until(async () => this.regret_times_dead == 3);
                this.hg_count = 4;
                await sleep_until(async () => this.regret_times_dead == 4);
                wake(new ScriptMethodReference(regret_death));
            }

            await sleep_until(async () => this.regret_dead == true);
            sleep_forever(new ScriptMethodReference(regret_taunts));
            ai_set_orders(all_enemies, everyone_retreat);
            ai_set_blind(all_enemies, true);
            ai_set_deaf(all_enemies, true);
            cs_run_command_script(all_enemies, new ScriptMethodReference(regret_dead_retreat));
            await sleep(60);
            this.bossfight_chatter = false;
            ai_dialogue_enable(false);
            await sleep(60);
            print("cortana: 'bad news. the reinforcements are turning around -'");
            print("'the fleet is preparing to fire on our position! we need to get out of here!'");
            await sleep(ai_play_line_on_object(default(IGameObject), "0220"));
            await sleep(30);
            ai_dialogue_enable(true);
            await this.cinematic_fade_to_white();
            kill_volume_disable(kill_temple_wings);
            wake(new ScriptMethodReference(music_05b_10_stop));
            object_teleport(await this.player0(), player0_hide_bsp3);
            object_teleport(await this.player1(), player1_hide_bsp3);
            ai_kill_silent(all_enemies);
            if (await this.cinematic_skip_start())
            {
                await this.c05_outro();
            }

            await this.cinematic_skip_stop();
            await sleep(2);
            await this.playtest_mission();
            await sleep(2);
            game_won();
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task temple_foyer_retreat()
        {
            await sleep_until(async () => this.regret_dead == true);
            data_mine_set_mission_segment("05b_17_temple_retreat");
            ai_renew(all_allies);
            game_save();
            device_operates_automatically_set(temple_retreat_exit.Entity, true);
            ai_place(temple_exit_elites_01.Squad, (short)(2 - (float)ai_living_count(temple_hg)));
            await sleep_until(async () => volume_test_objects(vol_temple_retreat_01, players()) == true || volume_test_objects(vol_temple_retreat_02, players()) == true || (float)ai_living_count(temple_hg) + (float)ai_living_count(temple_exit_elites_01.Squad) < 2F);
            game_save();
            ai_set_orders(all_allies, temple_retreat_allies);
            ai_place(temple_exit_grunts_01.Squad, 4);
            await sleep_until(async () => volume_test_objects(vol_temple_foyer, players()) == true || (short)ai_living_count(temple_escape_enemies) < 3);
            game_save();
            ai_place(temple_exit_jackals_02.Squad, 2);
            ai_place(temple_exit_elites_02.Squad, (short)(2 - (float)ai_living_count(temple_exit_elites_01.Squad)));
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task temple_entry_retreat()
        {
            await sleep_until(async () => volume_test_objects(vol_temple_entry, players()) == true && this.regret_dead == true);
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            await this.cinematic_fade_to_white();
            kill_volume_disable(kill_temple_wings);
            wake(new ScriptMethodReference(music_05b_10_stop));
            object_teleport(await this.player0(), player0_hide_bsp3);
            object_teleport(await this.player1(), player1_hide_bsp3);
            ai_kill_silent(all_enemies);
            if (await this.cinematic_skip_start())
            {
                await this.c05_outro();
            }

            await this.cinematic_skip_stop();
            await sleep(2);
            await this.cinematic_fade_from_white();
            await sleep(2);
            await this.playtest_mission();
            await sleep(2);
            game_won();
        }

        [ScriptMethod(291, Lifecycle.Static)]
        public async Task sleep_tower1()
        {
            sleep_forever(new ScriptMethodReference(tower1_start));
            sleep_forever(new ScriptMethodReference(tower1_holo_looper));
            sleep_forever(new ScriptMethodReference(tower1_cortana_comment));
        }

        [ScriptMethod(292, Lifecycle.Static)]
        public async Task sleep_bridges()
        {
            sleep_forever(new ScriptMethodReference(bridges_start));
            sleep_forever(new ScriptMethodReference(cortana_bridge_reminder));
        }

        [ScriptMethod(293, Lifecycle.Static)]
        public async Task sleep_tower2()
        {
            sleep_forever(new ScriptMethodReference(tower2_start));
            sleep_forever(new ScriptMethodReference(tower2_cortana_comment));
        }

        [ScriptMethod(294, Lifecycle.Static)]
        public async Task sleep_central_platform()
        {
            sleep_forever(new ScriptMethodReference(central_platform_start));
            sleep_forever(new ScriptMethodReference(central_platform_pelican));
        }

        [ScriptMethod(295, Lifecycle.Static)]
        public async Task sleep_gondola_01()
        {
            sleep_forever(new ScriptMethodReference(gondola_01_start));
            sleep_forever(new ScriptMethodReference(tower3_dock_above));
            sleep_forever(new ScriptMethodReference(gondola_01_nuke));
            sleep_forever(new ScriptMethodReference(gondola_01_restarter));
            sleep_forever(new ScriptMethodReference(gondola_01_reverser));
            sleep_forever(new ScriptMethodReference(gondola_01_go_reminder));
            sleep_forever(new ScriptMethodReference(gondola_01_phantom_arrives));
            sleep_forever(new ScriptMethodReference(tower3_turret_reman));
            sleep_forever(new ScriptMethodReference(tower3_cortana_comment));
            sleep_forever(new ScriptMethodReference(gondola_01_wake));
            sleep_forever(new ScriptMethodReference(tower_cluster_delete));
        }

        [ScriptMethod(296, Lifecycle.Static)]
        public async Task sleep_tower3()
        {
            sleep_forever(new ScriptMethodReference(tower3_start));
            sleep_forever(new ScriptMethodReference(tower3_sleeper_spawn));
            sleep_forever(new ScriptMethodReference(tower3_cortana_reminder_02));
            sleep_forever(new ScriptMethodReference(elev_under_monitor));
            sleep_forever(new ScriptMethodReference(assassin_ice_cream));
        }

        [ScriptMethod(297, Lifecycle.Static)]
        public async Task sleep_sunken_tunnel_01()
        {
            sleep_forever(new ScriptMethodReference(sunken_tunnel1_start));
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task sleep_sunken_chamber()
        {
            sleep_forever(new ScriptMethodReference(sunken_chamber_start));
            sleep_forever(new ScriptMethodReference(sunken_holo_cortana_comment));
            sleep_forever(new ScriptMethodReference(sunken_holo_looper));
            sleep_forever(new ScriptMethodReference(sunken_holo_translate));
            sleep_forever(new ScriptMethodReference(sunken_chamber_reminder));
            sleep_forever(new ScriptMethodReference(hide_rightside_guys));
            sleep_forever(new ScriptMethodReference(hide_leftside_guys));
            sleep_forever(new ScriptMethodReference(sunk_chamber_hunters_enter));
            sleep_forever(new ScriptMethodReference(sunken_chamber_saves));
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task sleep_sunken_tunnel_02()
        {
            sleep_forever(new ScriptMethodReference(sunken_tunnel2_start));
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task sleep_island_exterior()
        {
            sleep_forever(new ScriptMethodReference(island_interior_start));
            sleep_forever(new ScriptMethodReference(island_gully_start));
            sleep_forever(new ScriptMethodReference(island_exterior_start));
            sleep_forever(new ScriptMethodReference(elev_up_monitor));
            sleep_forever(new ScriptMethodReference(island_holo_looper));
            sleep_forever(new ScriptMethodReference(island_int_translate));
            sleep_forever(new ScriptMethodReference(island_pelican_arrives));
        }

        [ScriptMethod(301, Lifecycle.Static)]
        public async Task sleep_gondola_02()
        {
            sleep_forever(new ScriptMethodReference(gondola_02_start));
            sleep_forever(new ScriptMethodReference(gondola_02_cortana_reminder));
            sleep_forever(new ScriptMethodReference(gondola_02_nuke));
            sleep_forever(new ScriptMethodReference(gondola_02_restarter));
            sleep_forever(new ScriptMethodReference(gondola_02_reverser));
            sleep_forever(new ScriptMethodReference(gondola_02_wake));
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task sleep_temple_entry()
        {
            sleep_forever(new ScriptMethodReference(temple_entry_start));
            sleep_forever(new ScriptMethodReference(temple_foyer_start));
            sleep_forever(new ScriptMethodReference(temple_ent_cortana_reminder));
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task sleep_boss_fight()
        {
            sleep_forever(new ScriptMethodReference(temple_center_start));
            sleep_forever(new ScriptMethodReference(temple_hg_respawner));
            sleep_forever(new ScriptMethodReference(regret_respawner));
            sleep_forever(new ScriptMethodReference(regret_retreat));
            sleep_forever(new ScriptMethodReference(regret_beam_comment));
            sleep_forever(new ScriptMethodReference(regret_hg_comment));
            sleep_forever(new ScriptMethodReference(temple_cortana_warn_01));
            sleep_forever(new ScriptMethodReference(regret_taunts));
        }

        [ScriptMethod(304, Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_white();
            if (volume_test_objects(vol_starting_locations, players()) == true)
            {
                if (await this.cinematic_skip_start())
                {
                    await this.c05_intra1();
                }

                await this.cinematic_skip_stop();
            }

            sound_suppress_ambience_update_on_revert();
            sound_class_set_gain("amb", 0F, 0);
            await sleep(1);
            sound_class_set_gain("amb", 1F, 15);
            await sleep(2);
            switch_bsp(0);
            await sleep(2);
            ai_allegiance(covenant, prophet);
            ai_allegiance(player, human);
            objectives_clear();
            await sleep(2);
            await this.prep_return_from_intro();
            camera_control(false);
            await sleep(1);
            await cache_block_for_one_frame();
            await sleep(1);
            wake(new ScriptMethodReference(_05b_title0));
            wake(new ScriptMethodReference(objective_towers_set));
            wake(new ScriptMethodReference(kill_volumes));
            wake(new ScriptMethodReference(tower1_start));
            await sleep_until(async () => volume_test_objects(vol_tower1_exit, players()) == true || volume_test_objects(vol_tower1_exit_01, players()) == true || volume_test_objects(vol_tower1_exit_02, players()) == true || volume_test_objects(vol_tower1_roof, players()) == true);
            wake(new ScriptMethodReference(bridges_start));
            wake(new ScriptMethodReference(tower2_start));
            await sleep_until(async () => volume_test_objects(vol_tower2_exit, players()) == true || volume_test_objects(vol_central_platform, players()) == true);
            wake(new ScriptMethodReference(central_platform_start));
            wake(new ScriptMethodReference(gondola_01_start));
            await sleep_until(async () => volume_test_objects(vol_tower3_entry, players()) == true);
            wake(new ScriptMethodReference(tower3_start));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await sleep_until(async () => (short)structure_bsp_index() == 1);
            wake(new ScriptMethodReference(sunken_tunnel1_start));
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(305, Lifecycle.Dormant)]
        public async Task _05_intra1_01_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3851748383U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 65, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 69, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 70, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 71, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 74, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\door_tower\\door_tower", 3860661415U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 10, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3861906618U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862234303U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 4);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 8, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 8);
            await sleep(98);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 8);
            await sleep(9);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 65, true);
            await sleep(14);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 14, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 69, true);
            await sleep(205);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 4, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 67, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            await sleep(232);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            await sleep(36);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 17, false);
            await sleep(22);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 65, true);
        }

        [ScriptMethod(306, Lifecycle.Dormant)]
        public async Task _05_intra1_02_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3863610580U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3863610580U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3865445616U), 0);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 16, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 22, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 4, false);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\delta_horizon", 3869377836U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\index_holo_human\\index_holo_human", 3869705521U), 0);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\mount_doom_holo\\mount_doom_holo", 3870360891U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            await sleep(7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\water_elevator\\water_elevator", 3871737168U), 0);
            await sleep(16);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 13, false);
            await sleep(128);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3872458075U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3873834352U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3873834352U), 1);
            await sleep(215);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3872458075U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 61);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 54);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 72);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 74);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 69);
            await sleep(135);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 2, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 72, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 73, true);
        }

        [ScriptMethod(307, Lifecycle.Dormant)]
        public async Task _05_intra1_03_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3851748383U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 7);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 11, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 8, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 68, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 69, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862234303U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 70, true);
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task _05_intra2_01_predict()
        {
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\door_tower\\door_tower", 3860661415U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\fp_beam_rifle\\fp_beam_rifle", 3809477018U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 21);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885565475U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 30);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 32);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885565475U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886482993U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886482993U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 11);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885565475U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\projectiles\\needler_shard\\needler_shard", 3887269437U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3882223088U), 10);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 39, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 8, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 17, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 18, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 27, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 29, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 32, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 34, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 35, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3888055881U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888645714U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888973399U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3890087528U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3810525610U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3890087528U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3810525610U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 2);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888645714U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\fp_beam_rifle\\fp_beam_rifle", 3809477018U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 8);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 9);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 7);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862234303U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 19);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 20);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 29);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 22);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 23);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 24);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 25);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 27);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 53);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 62);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 56);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 6);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 57);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 58);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 59);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 60);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 12);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 13);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 14);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 15);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\ambient_life\\bird_quadwing\\bird_quadwing", 3890415213U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_large\\stone_block_large", 3890742898U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888973399U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3851748383U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\door_tower\\door_tower", 3860661415U), 0);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            await sleep(150);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 34, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 0, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 35, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 21, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 29, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 12, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 19, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 30, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 31, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 32, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 16, false);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\resupply_capsule\\resupply_capsule_crate\\resupply_capsule_crate", 3890808435U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888645714U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_branch\\tree_branch", 3891136120U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_bush\\tree_bush", 3891660416U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3891725953U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3891791490U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_large\\stone_block_large", 3890742898U), 0);
            await sleep(6);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 36, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, false);
            await sleep(41);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 47, true);
            await sleep(5);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 36, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, false);
            await sleep(4);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 44, true);
            await sleep(42);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 36, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, false);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891857027U), 0);
            await sleep(248);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3888055881U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 2);
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task _05_outro_01_predict()
        {
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 65, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3891988101U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886482993U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886482993U), 1);
            await sleep(185);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 42, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 1, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 65, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 5, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 6, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888973399U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await sleep(12);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 2);
            await sleep(6);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3888055881U), 0);
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888645714U), 1);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888645714U), 2);
            await sleep(34);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891857027U), 0);
            await sleep(20);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
        }

        [ScriptMethod(310, Lifecycle.Dormant)]
        public async Task _05_outro_02_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891857027U), 0);
            await sleep(42);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            await sleep(23);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 9, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 18, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 10, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 11, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 12, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 13, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 14, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 15, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 16, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 17, true);
            await sleep(1);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 7, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 19, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 20, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 21, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 23, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 24, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 25, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 30, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 31, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 32, true);
            await sleep(1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891857027U), 0);
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task _05_outro_03_predict()
        {
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3888055881U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888973399U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888645714U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await sleep(122);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
        }

        [ScriptMethod(312, Lifecycle.Dormant)]
        public async Task _05_outro_04_predict()
        {
            await sleep(2);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3888055881U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 2);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3861906618U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885565475U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888973399U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            predict_model_section(GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888645714U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\carrier_plasma_beam_closeup\\carrier_plasma_beam_closeup", 3892971156U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891857027U), 0);
        }

        [ScriptMethod(313, Lifecycle.Dormant)]
        public async Task _05_outro_05_predict()
        {
            await sleep(3);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891857027U), 0);
            await sleep(4);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3893233304U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3893233304U), 1);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\effects\\05_outro_rubble\\05_outro_rubble", 3894085285U), 0);
            await sleep(123);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 40, false);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            predict_structure_section(GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3861906618U), 0);
            predict_model_section(GetTag<RenderModelTag>("objects\\cinematics\\nature\\underwater_caustic_light\\underwater_caustic_light", 3894609581U), 0);
            await sleep(140);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3888055881U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            await sleep(2);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            await sleep(10);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            await sleep(8);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 0);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 1);
            predict_model_section(GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887400511U), 2);
            await sleep(14);
            predict_model_section(GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888973399U), 0);
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task teleport_bridges()
        {
            ai_erase_all();
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), bridges_player0);
            object_teleport(await this.player1(), bridges_player1);
            ai_place(initial_allies.Squad);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 0), bridges_ally1);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 1), bridges_ally2);
            ai_set_orders(initial_allies.Squad, tower1_ext_allies);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(bridges_start));
            wake(new ScriptMethodReference(tower2_start));
            await sleep_until(async () => volume_test_objects(vol_tower2_exit, players()) == true || volume_test_objects(vol_central_platform, players()) == true);
            wake(new ScriptMethodReference(central_platform_start));
            wake(new ScriptMethodReference(gondola_01_start));
            await sleep_until(async () => volume_test_objects(vol_tower3_entry, players()) == true);
            wake(new ScriptMethodReference(tower3_start));
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await sleep_until(async () => volume_test_objects(vol_tunnel_01_entry, players()) == true);
            wake(new ScriptMethodReference(sunken_tunnel1_start));
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(315, Lifecycle.Static)]
        public async Task teleport_tower2()
        {
            ai_erase_all();
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), tower2_player0);
            object_teleport(await this.player1(), tower2_player1);
            ai_place(initial_allies.Squad);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 0), tower2_ally1);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 1), tower2_ally2);
            ai_set_orders(initial_allies.Squad, tower2_ext_allies_01);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(tower2_start));
            await sleep_until(async () => volume_test_objects(vol_tower2_exit, players()) == true || volume_test_objects(vol_central_platform, players()) == true);
            wake(new ScriptMethodReference(central_platform_start));
            wake(new ScriptMethodReference(gondola_01_start));
            await sleep_until(async () => volume_test_objects(vol_tower3_entry, players()) == true);
            wake(new ScriptMethodReference(tower3_start));
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await sleep_until(async () => volume_test_objects(vol_tunnel_01_entry, players()) == true);
            wake(new ScriptMethodReference(sunken_tunnel1_start));
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task teleport_central_platform()
        {
            ai_erase_all();
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), center_plat_player0);
            object_teleport(await this.player1(), center_plat_player1);
            ai_place(initial_allies.Squad);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 0), center_plat_ally1);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 1), center_plat_ally2);
            ai_set_orders(initial_allies.Squad, tower2_ext_allies_02);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(central_platform_start));
            wake(new ScriptMethodReference(gondola_01_start));
            await sleep_until(async () => volume_test_objects(vol_tower3_entry, players()) == true);
            wake(new ScriptMethodReference(tower3_start));
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await sleep_until(async () => volume_test_objects(vol_tunnel_01_entry, players()) == true);
            wake(new ScriptMethodReference(sunken_tunnel1_start));
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task teleport_gondola_01()
        {
            ai_erase_all();
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), gondola_01_player0);
            object_teleport(await this.player1(), gondola_01_player1);
            ai_place(initial_allies.Squad);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 0), gondola_01_ally1);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 1), gondola_01_ally2);
            ai_set_orders(initial_allies.Squad, gondola_01_allies);
            device_set_position_immediate(gondola_01_a.Entity, 1F);
            device_set_position_immediate(gondola_01_b.Entity, 1F);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(gondola_01_start));
            await sleep_until(async () => volume_test_objects(vol_tower3_entry, players()) == true);
            wake(new ScriptMethodReference(tower3_start));
            await this.sleep_gondola_01();
            await sleep_until(async () => volume_test_objects(vol_tunnel_01_entry, players()) == true);
            wake(new ScriptMethodReference(sunken_tunnel1_start));
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task teleport_tower3()
        {
            ai_erase_all();
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            object_teleport(await this.player0(), tower3_player0);
            object_teleport(await this.player1(), tower3_player1);
            ai_place(initial_allies.Squad);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 0), tower3_ally1);
            object_teleport(list_get(ai_actors(initial_allies.Squad), 1), tower3_ally2);
            ai_set_orders(initial_allies.Squad, tower3_allies);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(tower3_start));
            await sleep_until(async () => volume_test_objects(vol_tunnel_01_entry, players()) == true);
            wake(new ScriptMethodReference(sunken_tunnel1_start));
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task teleport_tunnel_01()
        {
            ai_erase_all();
            ai_place(temp_bsp2_allies.Squad);
            switch_bsp(1);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), tunnel_01_player0);
            object_teleport(await this.player1(), tunnel_01_player1);
            object_teleport(list_get(ai_actors(temp_bsp2_allies.Squad), 0), tunnel_01_ally1);
            object_teleport(list_get(ai_actors(temp_bsp2_allies.Squad), 1), tunnel_01_ally2);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(sunken_tunnel1_start));
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task teleport_sunken_chamber()
        {
            ai_erase_all();
            ai_place(temp_bsp2_allies.Squad);
            switch_bsp(1);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), sunken_chamber_player0);
            object_teleport(await this.player1(), sunken_chamber_player1);
            object_teleport(list_get(ai_actors(temp_bsp2_allies.Squad), 0), sunken_chamber_ally1);
            object_teleport(list_get(ai_actors(temp_bsp2_allies.Squad), 1), sunken_chamber_ally2);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(sunken_chamber_start));
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(321, Lifecycle.Static)]
        public async Task teleport_tunnel_02()
        {
            ai_erase_all();
            ai_place(temp_bsp2_allies.Squad);
            switch_bsp(1);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), tunnel_02_player0);
            object_teleport(await this.player1(), tunnel_02_player1);
            object_teleport(list_get(ai_actors(temp_bsp2_allies.Squad), 0), tunnel_02_ally1);
            object_teleport(list_get(ai_actors(temp_bsp2_allies.Squad), 1), tunnel_02_ally2);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(sunken_tunnel2_start));
            await sleep_until(async () => volume_test_objects(vol_island_int_entry, players()) == true && (short)structure_bsp_index() == 2);
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_02();
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(322, Lifecycle.Static)]
        public async Task teleport_island()
        {
            ai_erase_all();
            ai_place(temp_bsp3_allies.Squad);
            switch_bsp(2);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), island_player0);
            object_teleport(await this.player1(), island_player1);
            object_teleport(list_get(ai_actors(temp_bsp3_allies.Squad), 0), island_ally1);
            object_teleport(list_get(ai_actors(temp_bsp3_allies.Squad), 1), island_ally2);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(island_interior_start));
            wake(new ScriptMethodReference(island_gully_start));
            wake(new ScriptMethodReference(island_exterior_start));
            wake(new ScriptMethodReference(gondola_02_start));
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(323, Lifecycle.Static)]
        public async Task teleport_gondola_02()
        {
            ai_erase_all();
            ai_place(temp_bsp3_allies.Squad);
            switch_bsp(2);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), gondola_02_player0);
            object_teleport(await this.player1(), gondola_02_player1);
            object_teleport(list_get(ai_actors(temp_bsp3_allies.Squad), 0), gondola_02_ally1);
            object_teleport(list_get(ai_actors(temp_bsp3_allies.Squad), 1), gondola_02_ally2);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await this.sleep_island_exterior();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(gondola_02_start));
            await sleep_until(async () => volume_test_objects(vol_temple_ext, players()) == true);
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_gondola_02();
        }

        [ScriptMethod(324, Lifecycle.Static)]
        public async Task teleport_temple_ext()
        {
            ai_erase_all();
            ai_place(temp_bsp3_allies.Squad);
            switch_bsp(2);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), temple_ext_player0);
            object_teleport(await this.player1(), temple_ext_player1);
            object_teleport(list_get(ai_actors(temp_bsp3_allies.Squad), 0), temple_ext_ally1);
            object_teleport(list_get(ai_actors(temp_bsp3_allies.Squad), 1), temple_ext_ally2);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(temple_entry_start));
            wake(new ScriptMethodReference(temple_foyer_start));
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task teleport_temple_int()
        {
            ai_erase_all();
            switch_bsp(2);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), temple_int_player0);
            object_teleport(await this.player1(), temple_int_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
            await this.sleep_temple_entry();
            garbage_collect_now();
            game_save();
            wake(new ScriptMethodReference(temple_center_start));
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task teleport_temple_retreat()
        {
            ai_erase_all();
            switch_bsp(2);
            unit_add_equipment(await this.player0(), profile_1, true, true);
            unit_add_equipment(await this.player1(), profile_1, true, true);
            await sleep(2);
            object_teleport(await this.player0(), temple_return_player0);
            object_teleport(await this.player1(), temple_return_player1);
            sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
            await this.sleep_temple_entry();
            await this.sleep_boss_fight();
            garbage_collect_now();
            game_save();
            device_one_sided_set(door_main.Entity, false);
            device_one_sided_set(temple_retreat_exit.Entity, false);
            wake(new ScriptMethodReference(temple_foyer_retreat));
            wake(new ScriptMethodReference(temple_entry_retreat));
        }
    }
}