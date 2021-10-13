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
            this.splashy = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\deltatemple\\elevator_splash", 2244748154U);
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
            this.regret_teleport = Engine.GetTag<EffectTag>("effects\\gameplay\\regret_teleport", 2245141376U);
            this.regret_blood = Engine.GetTag<EffectTag>("effects\\contact\\collision\\blood_aoe\\blood_aoe_human", 4160820873U);
            this.regret_lives = 0;
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
        public async Task _05_intra1_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_intra1_01_predict));
        }

        [ScriptMethod(25, Lifecycle.Static)]
        public async Task _05_intra1_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_intra1_02_predict));
            Engine.print("just started 02 predict");
        }

        [ScriptMethod(26, Lifecycle.Static)]
        public async Task _05_intra1_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_intra1_03_predict));
        }

        [ScriptMethod(27, Lifecycle.Static)]
        public async Task _05_intra2_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_intra2_01_predict));
        }

        [ScriptMethod(28, Lifecycle.Static)]
        public async Task _05_outro_01_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_outro_01_predict));
        }

        [ScriptMethod(29, Lifecycle.Static)]
        public async Task _05_outro_02_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_outro_02_predict));
        }

        [ScriptMethod(30, Lifecycle.Static)]
        public async Task _05_outro_03_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_outro_03_predict));
        }

        [ScriptMethod(31, Lifecycle.Static)]
        public async Task _05_outro_04_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_outro_04_predict));
        }

        [ScriptMethod(32, Lifecycle.Static)]
        public async Task _05_outro_05_predict_stub()
        {
            Engine.wake(new ScriptMethodReference(_05_outro_05_predict));
        }

        [ScriptMethod(33, Lifecycle.Dormant)]
        public async Task c05_intra1_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\music\\c05_intra1_02_mus", 3839165279U), default(IGameObject), 1F);
            Engine.print("c05_intra1 score 01 start");
        }

        [ScriptMethod(34, Lifecycle.Dormant)]
        public async Task c05_intra1_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_01_fol", 3839230816U), default(IGameObject), 1F);
            Engine.print("c05_intra1 foley 01 start");
        }

        [ScriptMethod(35, Lifecycle.Dormant)]
        public async Task c05_2010_cor()
        {
            await Engine.sleep(17);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2010_cor", 3839296353U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c05_2010_cor", 1F);
        }

        [ScriptMethod(36, Lifecycle.Dormant)]
        public async Task c05_2020_cor()
        {
            await Engine.sleep(135);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2020_cor", 3839361890U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c05_2020_cor", 1F);
            Engine.unit_set_emotional_state(cortana.Entity, "angry", 0.5F, 60);
            Engine.print("cortana - angry .5 60");
        }

        [ScriptMethod(37, Lifecycle.Dormant)]
        public async Task c05_2030_cor()
        {
            await Engine.sleep(200);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2030_cor", 3839427427U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c05_2030_cor", 3F);
        }

        [ScriptMethod(38, Lifecycle.Dormant)]
        public async Task c05_2040_mas()
        {
            await Engine.sleep(299);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2040_mas", 3839492964U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c05_2040_mas", 1F);
        }

        [ScriptMethod(39, Lifecycle.Dormant)]
        public async Task c05_2050_por()
        {
            await Engine.sleep(357);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2050_por", 3839558501U), regret.Entity, 1F);
            Engine.cinematic_subtitle("c05_2050_por", 8F);
        }

        [ScriptMethod(40, Lifecycle.Dormant)]
        public async Task c05_2060_cor()
        {
            await Engine.sleep(553);
            Engine.unit_set_emotional_state(cortana.Entity, "annoyed", 0.25F, 60);
            Engine.print("cortana - annoyed .25 60");
            await Engine.sleep(30);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2060_cor", 3839624038U), cortana.Entity, 1F);
            Engine.cinematic_subtitle("c05_2060_cor", 1F);
        }

        [ScriptMethod(41, Lifecycle.Dormant)]
        public async Task c05_2070_mas()
        {
            await Engine.sleep(622);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2070_mas", 3839689575U), chief.Entity, 1F);
            Engine.cinematic_subtitle("c05_2070_mas", 2F);
        }

        [ScriptMethod(42, Lifecycle.Dormant)]
        public async Task c05_2080_mir()
        {
            await Engine.sleep(678);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2080_mir", 3839755112U), default(IGameObject), 1F, "radio_default_in");
            Engine.cinematic_subtitle("c05_2080_mir", 1F);
        }

        [ScriptMethod(43, Lifecycle.Dormant)]
        public async Task cortana_appear()
        {
            await Engine.sleep(98);
            Engine.print("cortana appears");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 3839820649U), cortana_base.Entity, "marker");
        }

        [ScriptMethod(44, Lifecycle.Dormant)]
        public async Task c05_intra1_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(-38F, 310F, 0.180392F, 0.160784F, 0.113725F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 162F, 0.458824F, 0.466667F, 0.74902F);
            Engine.cinematic_lighting_set_ambient_light(0.0823529F, 0.0470588F, 0.00784314F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(cortana.Entity, true);
            Engine.object_uses_cinematic_lighting(regret.Entity, true);
        }

        [ScriptMethod(45, Lifecycle.Static)]
        public async Task c05_intra1_02_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(miranda);
            Engine.object_create_anew(johnson);
            Engine.object_create_anew(pilot);
            Engine.object_create_anew(pelican_01);
            Engine.object_create_anew(holo_index);
            Engine.object_create_anew(iac_bridge);
            Engine.object_create_anew(matte_horizon);
            Engine.object_cinematic_lod(miranda.Entity, true);
            Engine.object_cinematic_lod(johnson.Entity, true);
            Engine.object_cinematic_lod(pilot.Entity, true);
            Engine.object_cinematic_lod(pelican_01.Entity, true);
            Engine.object_cinematic_lod(holo_index.Entity, true);
            Engine.object_cinematic_lod(iac_bridge.Entity, true);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_bridge.Entity, true);
            Engine.object_hide(johnson.Entity, true);
            Engine.object_hide(pilot.Entity, true);
            Engine.object_hide(pelican_01.Entity, true);
            Engine.object_hide(matte_horizon.Entity, true);
        }

        [ScriptMethod(46, Lifecycle.Static)]
        public async Task c05_intra1_01_setup()
        {
            Engine.object_create_anew(chief);
            Engine.object_create_anew(cortana);
            Engine.object_create_anew(regret);
            Engine.object_create_anew(throne_regret);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.object_cinematic_lod(cortana.Entity, true);
            Engine.object_cinematic_lod(regret.Entity, true);
            Engine.object_cinematic_lod(throne_regret.Entity, true);
            Engine.cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            Engine.objects_attach(regret.Entity, "driver", throne_regret.Entity, "driver_cinematic");
            Engine.wake(new ScriptMethodReference(c05_2010_cor));
            Engine.wake(new ScriptMethodReference(c05_2020_cor));
            Engine.wake(new ScriptMethodReference(c05_2030_cor));
            Engine.wake(new ScriptMethodReference(c05_2040_mas));
            Engine.wake(new ScriptMethodReference(c05_2050_por));
            Engine.wake(new ScriptMethodReference(c05_2060_cor));
            Engine.wake(new ScriptMethodReference(c05_2070_mas));
            Engine.wake(new ScriptMethodReference(c05_2080_mir));
            Engine.wake(new ScriptMethodReference(c05_intra1_score_01));
            Engine.wake(new ScriptMethodReference(c05_intra1_foley_01));
            Engine.wake(new ScriptMethodReference(cortana_appear));
            Engine.wake(new ScriptMethodReference(c05_intra1_cinematic_light_01));
            Engine.cinematic_set_near_clip_distance(0.05F);
        }

        [ScriptMethod(47, Lifecycle.Static)]
        public async Task c05_intra1_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltatowers_intra1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            await this._05_intra1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\music\\c05_intra1_02_mus", 3839165279U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_01_fol", 3839230816U));
            await Engine.sleep(this.prediction_offset);
            await this.c05_intra1_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra1\\05_intra1", 3840738167U), "05_intra1_01", default(IUnit), anchor_flag_intra1a);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intra1\\05_intra1", 3840803704U), "chief_01", false, anchor_intra1a.Entity);
            Engine.custom_animation_relative(regret.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\05_intra1\\05_intra1", 3840869241U), "regret_01", false, anchor_intra1a.Entity);
            await Engine.sleep(5);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep(94);
            Engine.custom_animation_relative(cortana.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\05_intra1\\05_intra1", 3841000315U), "cortana_01", false, anchor_intra1a.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._05_intra1_02_predict_stub();
            await this.c05_intra1_02_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_02_fol", 3841131389U));
            await Engine.sleep((short)((float)Engine.camera_time() - 5));
            Engine.fade_out(1F, 1F, 1F, 5);
            await Engine.sleep(5);
        }

        [ScriptMethod(48, Lifecycle.Dormant)]
        public async Task c05_intra1_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_02_fol", 3841131389U), default(IGameObject), 1F);
            Engine.print("c05_intra1 foley 02 start");
        }

        [ScriptMethod(49, Lifecycle.Dormant)]
        public async Task c05_2090_mir()
        {
            Engine.unit_set_emotional_state(miranda.Entity, "pensive", 0.5F, 0);
            Engine.print("miranda - pensive .5 0");
            await Engine.sleep(7);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2090_mir", 3841196926U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c05_2090_mir", 5F);
        }

        [ScriptMethod(50, Lifecycle.Dormant)]
        public async Task c05_2100_mir()
        {
            await Engine.sleep(162);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2100_mir", 3841262463U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c05_2100_mir", 7F);
        }

        [ScriptMethod(51, Lifecycle.Dormant)]
        public async Task c05_2110_jon()
        {
            await Engine.sleep(373);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2110_jon", 3841328000U), johnson.Entity, 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c05_2110_jon", 3F);
        }

        [ScriptMethod(52, Lifecycle.Dormant)]
        public async Task c05_2120_mir()
        {
            await Engine.sleep(455);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2120_mir", 3841393537U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c05_2120_mir", 2F);
        }

        [ScriptMethod(53, Lifecycle.Dormant)]
        public async Task c05_2130_mir()
        {
            await Engine.sleep(509);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2130_mir", 3841459074U), miranda.Entity, 1F);
            Engine.cinematic_subtitle("c05_2130_mir", 2F);
            Engine.texture_camera_off();
            await Engine.sleep(45);
            Engine.unit_set_emotional_state(miranda.Entity, "angry", 0.25F, 60);
            Engine.print("miranda - angry .25 60");
        }

        [ScriptMethod(54, Lifecycle.Dormant)]
        public async Task c05_2140_jon()
        {
            await Engine.sleep(574);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2140_jon", 3841524611U), johnson.Entity, 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c05_2140_jon", 1F);
        }

        [ScriptMethod(55, Lifecycle.Dormant)]
        public async Task intra1_texture_camera_on()
        {
            Engine.object_create_anew(texture_camera);
            Engine.scenery_animation_start_relative(texture_camera.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\texture_camera\\05_intra1\\05_intra1", 3841590148U), "texture_camera_02", anchor_intra1b.Entity);
            await Engine.sleep(150);
            Engine.print("texture camera on");
            Engine.texture_camera_set_object_marker(texture_camera.Entity, "marker", 50F);
            Engine.object_hide(johnson.Entity, false);
            Engine.object_hide(pilot.Entity, false);
            Engine.object_hide(pelican_01.Entity, false);
            Engine.object_hide(matte_horizon.Entity, false);
        }

        [ScriptMethod(56, Lifecycle.Dormant)]
        public async Task c05_intra1_cinematic_light_02()
        {
            Engine.cinematic_lighting_set_primary_light(-52F, 292F, 0.08F, 0.15F, 0.22F);
            Engine.cinematic_lighting_set_secondary_light(-14F, 150F, 0.09F, 0.09F, 0.22F);
            Engine.cinematic_lighting_set_ambient_light(0.06F, 0.05F, 0.04F);
            Engine.object_uses_cinematic_lighting(miranda.Entity, true);
            Engine.object_uses_cinematic_lighting(iac_bridge.Entity, true);
            Engine.object_uses_cinematic_lighting(johnson.Entity, true);
            Engine.object_uses_cinematic_lighting(pilot.Entity, true);
            Engine.object_uses_cinematic_lighting(index.Entity, true);
            Engine.object_uses_cinematic_lighting(pelican_01.Entity, true);
        }

        [ScriptMethod(57, Lifecycle.Static)]
        public async Task c05_intra1_02_setup()
        {
            Engine.object_create_anew(holo_library);
            Engine.object_create_anew(matte_horizon);
            Engine.object_cinematic_lod(holo_library.Entity, true);
            Engine.wake(new ScriptMethodReference(c05_2090_mir));
            Engine.wake(new ScriptMethodReference(c05_2100_mir));
            Engine.wake(new ScriptMethodReference(c05_2110_jon));
            Engine.wake(new ScriptMethodReference(c05_2120_mir));
            Engine.wake(new ScriptMethodReference(c05_2130_mir));
            Engine.wake(new ScriptMethodReference(c05_2140_jon));
            Engine.wake(new ScriptMethodReference(c05_intra1_foley_02));
            Engine.wake(new ScriptMethodReference(intra1_texture_camera_on));
            Engine.wake(new ScriptMethodReference(c05_intra1_cinematic_light_02));
        }

        [ScriptMethod(58, Lifecycle.Static)]
        public async Task c05_intra1_02_cleanup()
        {
            Engine.object_destroy(miranda.Entity);
            Engine.object_destroy(johnson.Entity);
            Engine.object_destroy(pilot.Entity);
            Engine.object_destroy(holo_index.Entity);
            Engine.object_destroy(holo_library.Entity);
            Engine.object_destroy(pelican_01.Entity);
            Engine.object_destroy(iac_bridge.Entity);
            Engine.object_destroy(texture_camera.Entity);
            Engine.object_destroy(matte_horizon.Entity);
        }

        [ScriptMethod(59, Lifecycle.Static)]
        public async Task c05_intra1_scene_02()
        {
            await this.c05_intra1_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra1\\05_intra1", 3840738167U), "05_intra1_02", default(IUnit), anchor_flag_intra1b);
            Engine.custom_animation_relative(miranda.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\miranda\\05_intra1\\05_intra1", 3841655685U), "miranda_02", false, anchor_intra1b.Entity);
            Engine.custom_animation_relative(johnson.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\05_intra1\\05_intra1", 3846439886U), "johnson_02", false, anchor_intra1b.Entity);
            Engine.custom_animation_relative(pilot.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\marine\\05_intra1\\05_intra1", 3846439886U), "marine01_02", false, anchor_intra1b.Entity);
            Engine.scenery_animation_start_relative(iac_bridge.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\human\\inamberclad_bridge\\05_intra1\\05_intra1", 3846570960U), "bridge_02", anchor_intra1b.Entity);
            Engine.scenery_animation_start_relative(holo_index.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\index_holo_human\\05_intra1\\05_intra1", 3846636497U), "index_holo_human_02", anchor_intra1b.Entity);
            Engine.scenery_animation_start_relative(holo_library.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\forerunner\\mount_doom_holo\\05_intra1\\05_intra1", 3846702034U), "mount_doom_holo_02", anchor_intra1b.Entity);
            Engine.scenery_animation_start_relative(matte_horizon.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\05_intra1\\05_intra1", 3846767571U), "delta_horizon_02", anchor_intra1b.Entity);
            Engine.custom_animation_relative(pelican_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\pelican\\05_intra1\\05_intra1", 3846833108U), "pelican_02", false, anchor_intra1b.Entity);
            await Engine.sleep(30);
            Engine.fade_in(1F, 1F, 1F, 5);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._05_intra1_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_03_fol", 3846898645U));
            await Engine.sleep((short)Engine.camera_time());
            await this.c05_intra1_02_cleanup();
        }

        [ScriptMethod(60, Lifecycle.Dormant)]
        public async Task c05_intra1_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra1\\foley\\c05_intra1_03_fol", 3846898645U), default(IGameObject), 1F);
            Engine.print("c05_intra1 foley 03 start");
        }

        [ScriptMethod(61, Lifecycle.Dormant)]
        public async Task c05_2150_mir()
        {
            Engine.unit_set_emotional_state(cortana.Entity, "angry", 0.5F, 0);
            Engine.print("cortana - angry .5 0");
            await Engine.sleep(0);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2150_mir", 3846964182U), default(IGameObject), 1F, "radio_default_loop");
            Engine.cinematic_subtitle("c05_2150_mir", 3F);
        }

        [ScriptMethod(62, Lifecycle.Dormant)]
        public async Task c05_2160_mir()
        {
            await Engine.sleep(99);
            Engine.sound_impulse_start_effect(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_2160_mir", 3847029719U), default(IGameObject), 1F, "radio_default_out");
            Engine.cinematic_subtitle("c05_2160_mir", 2F);
        }

        [ScriptMethod(63, Lifecycle.Dormant)]
        public async Task cortana_disappear()
        {
            await Engine.sleep(35);
            Engine.print("cortana disappears");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\cortana\\cortana_on_off", 3839820649U), cortana_base.Entity, "marker");
        }

        [ScriptMethod(64, Lifecycle.Dormant)]
        public async Task c05_intra1_cinematic_light_03()
        {
            Engine.cinematic_lighting_set_primary_light(-38F, 310F, 0.180392F, 0.160784F, 0.113725F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 162F, 0.458824F, 0.466667F, 0.74902F);
            Engine.cinematic_lighting_set_ambient_light(0.0823529F, 0.0470588F, 0.00784314F);
        }

        [ScriptMethod(65, Lifecycle.Static)]
        public async Task c05_intra1_03_setup()
        {
            Engine.wake(new ScriptMethodReference(c05_2150_mir));
            Engine.wake(new ScriptMethodReference(c05_2160_mir));
            Engine.wake(new ScriptMethodReference(c05_intra1_foley_03));
            Engine.wake(new ScriptMethodReference(c05_intra1_cinematic_light_03));
            Engine.wake(new ScriptMethodReference(cortana_disappear));
        }

        [ScriptMethod(66, Lifecycle.Static)]
        public async Task c05_intra1_03_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(regret.Entity);
            Engine.object_destroy(throne_regret.Entity);
            Engine.object_destroy(cortana_base.Entity);
        }

        [ScriptMethod(67, Lifecycle.Static)]
        public async Task c05_intra1_scene_03()
        {
            await this.c05_intra1_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra1\\05_intra1", 3840738167U), "05_intra1_03", default(IUnit), anchor_flag_intra1a);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intra1\\05_intra1", 3840803704U), "chief_03", false, anchor_intra1a.Entity);
            Engine.custom_animation_relative(cortana.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\cortana\\05_intra1\\05_intra1", 3841000315U), "cortana_03", false, anchor_intra1a.Entity);
            await Engine.sleep(50);
            Engine.object_destroy(cortana.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c05_intra1_03_cleanup();
        }

        [ScriptMethod(68, Lifecycle.Static)]
        public async Task c05_intra1()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("bsp_01"));
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 0F, 0);
            Engine.sound_class_set_gain("vehicle", 0F, 0);
            await this.c05_intra1_scene_01();
            await this.c05_intra1_scene_02();
            await this.c05_intra1_scene_03();
            Engine.sound_class_set_gain("amb", 0F, 15);
        }

        [ScriptMethod(69, Lifecycle.Dormant)]
        public async Task c05_intra2_foley()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra2\\foley\\c05_intra2_01_fol", 3847095256U), default(IGameObject), 1F);
            Engine.print("c05_intra2 foley start");
        }

        [ScriptMethod(70, Lifecycle.Dormant)]
        public async Task c05_3010_cor()
        {
            await Engine.sleep(275);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_3010_cor", 3847160793U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c05_3010_cor", 2F);
        }

        [ScriptMethod(71, Lifecycle.Dormant)]
        public async Task c05_3020_cor()
        {
            await Engine.sleep(359);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_3020_cor", 3847226330U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c05_3020_cor", 2F);
        }

        [ScriptMethod(72, Lifecycle.Dormant)]
        public async Task c05_3030_cor()
        {
            await Engine.sleep(513);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\05_deltatemple\\cinematics\\c05_3030_cor", 3847291867U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c05_3030_cor", 3F);
        }

        [ScriptMethod(73, Lifecycle.Dormant)]
        public async Task c05_intra2_dof()
        {
            await Engine.sleep(250);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(250);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(74, Lifecycle.Dormant)]
        public async Task c05_intra2_cinematic_light()
        {
            Engine.cinematic_lighting_set_primary_light(24F, 272F, 0.639216F, 0.54902F, 0.388235F);
            Engine.cinematic_lighting_set_secondary_light(-27F, 140F, 0.329412F, 0.180392F, 0.0509804F);
            Engine.cinematic_lighting_set_ambient_light(0.0784314F, 0.0784314F, 0.101961F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
        }

        [ScriptMethod(75, Lifecycle.Dormant)]
        public async Task fleet_arrival()
        {
            await Engine.sleep(251);
            Engine.print("fleet arrival");
            Engine.object_create_anew(intra2_fleet);
        }

        [ScriptMethod(76, Lifecycle.Static)]
        public async Task c05_intra2_setup()
        {
            Engine.object_create(chief);
            Engine.object_cinematic_lod(chief.Entity, true);
            Engine.cinematic_clone_players_weapon(chief.Entity, "right_hand", "");
            Engine.wake(new ScriptMethodReference(c05_3010_cor));
            Engine.wake(new ScriptMethodReference(c05_3020_cor));
            Engine.wake(new ScriptMethodReference(c05_3030_cor));
            Engine.wake(new ScriptMethodReference(c05_intra2_foley));
            Engine.wake(new ScriptMethodReference(fleet_arrival));
            Engine.wake(new ScriptMethodReference(c05_intra2_dof));
            Engine.wake(new ScriptMethodReference(c05_intra2_cinematic_light));
        }

        [ScriptMethod(77, Lifecycle.Static)]
        public async Task c05_intra2()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("bsp_03"));
            await Engine.sleep(1);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltatowers_intra2");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._05_intra1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_intra2\\foley\\c05_intra2_01_fol", 3847095256U));
            await Engine.sleep(this.prediction_offset);
            await this.c05_intra2_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_intra2\\05_intra2", 3847357404U), "05_intra2_01", default(IUnit), anchor_flag_outro);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_intra2\\05_intra2", 3847422941U), "chief_01", false, anchor_outro.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(intra2_fleet.Entity);
        }

        [ScriptMethod(78, Lifecycle.Dormant)]
        public async Task c05_outro_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\music\\c05_outro_01_mus", 3847488478U), default(IGameObject), 1F);
            Engine.print("c05_outro score 01 start");
        }

        [ScriptMethod(79, Lifecycle.Dormant)]
        public async Task c05_outro_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_01_fol", 3847554015U), default(IGameObject), 1F);
            Engine.print("c05_outro foley 01 start");
        }

        [ScriptMethod(80, Lifecycle.Dormant)]
        public async Task effect_dust_scrape()
        {
            Engine.time_code_reset();
            await Engine.sleep(240);
            Engine.print("effect - dust scrape");
            Engine.object_create_anew(outro_dust_scrape);
        }

        [ScriptMethod(81, Lifecycle.Dormant)]
        public async Task c05_outro_01_dof()
        {
            await Engine.sleep(55);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 0.5F, 0.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
            await Engine.sleep(130);
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(82, Lifecycle.Dormant)]
        public async Task c05_outro_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(24F, 272F, 0.639216F, 0.54902F, 0.388235F);
            Engine.cinematic_lighting_set_secondary_light(-27F, 140F, 0.329412F, 0.180392F, 0.0509804F);
            Engine.cinematic_lighting_set_ambient_light(0.0784314F, 0.0784314F, 0.101961F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(carrier.Entity, true);
        }

        [ScriptMethod(83, Lifecycle.Dormant)]
        public async Task c05_outro_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(chief);
            Engine.object_cinematic_lod(chief.Entity, true);
        }

        [ScriptMethod(84, Lifecycle.Static)]
        public async Task c05_outro_01_setup()
        {
            Engine.object_create_anew(carrier);
            Engine.object_cinematic_lod(carrier.Entity, true);
            Engine.wake(new ScriptMethodReference(c05_outro_score_01));
            Engine.wake(new ScriptMethodReference(c05_outro_foley_01));
            Engine.wake(new ScriptMethodReference(effect_dust_scrape));
            Engine.wake(new ScriptMethodReference(c05_outro_01_dof));
            Engine.wake(new ScriptMethodReference(c05_outro_cinematic_light_01));
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\covenant_beam", 3847619552U), carrier.Entity, "beam");
        }

        [ScriptMethod(85, Lifecycle.Static)]
        public async Task c05_outro_scene_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("deltatowers_outro");
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._05_outro_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\music\\c05_outro_01_mus", 3847488478U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_01_fol", 3847554015U));
            Engine.wake(new ScriptMethodReference(c05_outro_problem_actors));
            await Engine.sleep(this.prediction_offset);
            await this.c05_outro_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_01", default(IUnit), anchor_flag_outro);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_01", false, anchor_outro.Entity);
            Engine.scenery_animation_start_relative(carrier.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\05_outro\\05_outro", 3848930292U), "cruiser_01", anchor_outro.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._05_outro_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_02_fol", 3848995829U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(86, Lifecycle.Dormant)]
        public async Task c05_outro_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_02_fol", 3848995829U), default(IGameObject), 1F);
            Engine.print("c05_outro foley 02 start");
        }

        [ScriptMethod(87, Lifecycle.Dormant)]
        public async Task effect_dust_land()
        {
            await Engine.sleep(59);
            Engine.print("effect - dust land");
            Engine.object_create_anew(outro_dust_land);
        }

        [ScriptMethod(88, Lifecycle.Static)]
        public async Task c05_outro_scene_02()
        {
            Engine.wake(new ScriptMethodReference(c05_outro_foley_02));
            Engine.wake(new ScriptMethodReference(effect_dust_land));
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_02", default(IUnit), anchor_flag_outro);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_02", false, anchor_outro.Entity);
            Engine.scenery_animation_start_relative(carrier.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\05_outro\\05_outro", 3848930292U), "cruiser_02", anchor_outro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._05_outro_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_03_fol", 3849061366U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(89, Lifecycle.Dormant)]
        public async Task c05_outro_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_03_fol", 3849061366U), default(IGameObject), 1F);
            Engine.print("c05_outro foley 03 start");
        }

        [ScriptMethod(90, Lifecycle.Dormant)]
        public async Task c05_outro_fov_01()
        {
            await Engine.sleep(122);
            Engine.camera_set_field_of_view(7F, 0);
        }

        [ScriptMethod(91, Lifecycle.Static)]
        public async Task c05_outro_03_setup()
        {
            Engine.wake(new ScriptMethodReference(c05_outro_foley_03));
            Engine.wake(new ScriptMethodReference(c05_outro_fov_01));
        }

        [ScriptMethod(92, Lifecycle.Static)]
        public async Task c05_outro_scene_03()
        {
            await this.c05_outro_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_03", default(IUnit), anchor_flag_outro);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_03", false, anchor_outro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._05_outro_04_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_04_fol", 3849126903U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(93, Lifecycle.Dormant)]
        public async Task c05_outro_foley_04()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\05_deltahalo\\c05_outro\\foley\\c05_outro_04_fol", 3849126903U), default(IGameObject), 1F);
            Engine.print("c05_outro foley 04 start");
        }

        [ScriptMethod(94, Lifecycle.Static)]
        public async Task c05_outro_scene_04()
        {
            Engine.wake(new ScriptMethodReference(c05_outro_foley_04));
            Engine.object_create_anew(outro_beam);
            Engine.print("start beam");
            Engine.camera_set_field_of_view(60F, 0);
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_04", default(IUnit), anchor_flag_outro);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_04", false, anchor_outro.Entity);
            Engine.scenery_animation_start_relative(carrier.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\covenant\\military\\capital_ship\\05_outro\\05_outro", 3848930292U), "cruiser_04", anchor_outro.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._05_outro_05_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - 1));
            Engine.fade_out(0F, 0F, 0F, 0);
            await Engine.sleep(60);
            Engine.object_destroy(outro_beam.Entity);
        }

        [ScriptMethod(95, Lifecycle.Dormant)]
        public async Task x07_0220_grv()
        {
            await Engine.sleep(207);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0220_grv", 3849192440U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x07_0220_grv", 7F);
        }

        [ScriptMethod(96, Lifecycle.Dormant)]
        public async Task x07_0230_grv()
        {
            await Engine.sleep(426);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\06_sentinelwall\\cinematic\\x07_0230_grv", 3849257977U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("x07_0230_grv", 6F);
        }

        [ScriptMethod(97, Lifecycle.Dormant)]
        public async Task c05_outro_bubbles()
        {
            Engine.object_create_anew(bubbles_01);
            Engine.objects_attach(chief.Entity, "", bubbles_01.Entity, "");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles01");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles04");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles06");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles08");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles09");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles11");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles12");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\cinematics\\05\\bubbles_debris", 3849323514U), rubble.Entity, "bubbles14");
        }

        [ScriptMethod(98, Lifecycle.Dormant)]
        public async Task c05_outro_caustic()
        {
            Engine.time_code_reset();
            await Engine.sleep(127);
            Engine.print("create caustic light");
            Engine.object_create_anew_containing("caustic_light");
        }

        [ScriptMethod(99, Lifecycle.Dormant)]
        public async Task c05_outro_cinematic_light_05()
        {
            Engine.cinematic_lighting_set_primary_light(54F, 138F, 0.129412F, 0.121569F, 0.0705882F);
            Engine.cinematic_lighting_set_secondary_light(-46F, 238F, 0.0705882F, 0.160784F, 0.329412F);
            Engine.cinematic_lighting_set_ambient_light(0.0901961F, 0.129412F, 0.219608F);
            Engine.object_uses_cinematic_lighting(chief.Entity, true);
            Engine.object_uses_cinematic_lighting(rubble.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_capture_01.Entity, true);
            Engine.object_uses_cinematic_lighting(tentacle_capture_02.Entity, true);
        }

        [ScriptMethod(100, Lifecycle.Static)]
        public async Task c05_outro_05_setup()
        {
            Engine.object_create_anew(rubble);
            Engine.object_create_anew(tentacle_capture_01);
            Engine.object_create_anew(tentacle_capture_02);
            Engine.wake(new ScriptMethodReference(x07_0220_grv));
            Engine.wake(new ScriptMethodReference(x07_0230_grv));
            Engine.wake(new ScriptMethodReference(c05_outro_cinematic_light_05));
            Engine.wake(new ScriptMethodReference(c05_outro_bubbles));
            Engine.wake(new ScriptMethodReference(c05_outro_caustic));
        }

        [ScriptMethod(101, Lifecycle.Static)]
        public async Task c05_outro_05_cleanup()
        {
            Engine.object_destroy(chief.Entity);
            Engine.object_destroy(rubble.Entity);
            Engine.object_destroy(carrier.Entity);
            Engine.object_destroy_containing("caustic_light");
            Engine.object_destroy_containing("tentacle");
            Engine.object_destroy_containing("bubbles");
        }

        [ScriptMethod(102, Lifecycle.Static)]
        public async Task c05_outro_scene_05()
        {
            await this.c05_outro_05_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\05_outro\\05_outro", 3848799218U), "05_outro_05", default(IUnit), anchor_flag_outro);
            Engine.custom_animation_relative(chief.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\masterchief\\05_outro\\05_outro", 3848864755U), "chief_05", false, anchor_outro.Entity);
            Engine.scenery_animation_start_relative(rubble.Entity, Engine.GetTag<AnimationGraphTag>("objects\\cinematics\\effects\\05_outro_rubble\\05_outro_rubble", 3849716736U), "05_outro_05", anchor_outro.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\05_outro\\05_outro", 3849782273U), "tentacle1_05", anchor_outro.Entity);
            Engine.scenery_animation_start_relative(tentacle_capture_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\gravemind\\tentacle_capture\\05_outro\\05_outro", 3849782273U), "tentacle2_05", anchor_outro.Entity);
            Engine.fade_in(0F, 0F, 0F, 60);
            await Engine.sleep((short)((float)Engine.camera_time() - 30));
            Engine.fade_out(0F, 0F, 0F, 60);
            await Engine.sleep(60);
            await this.c05_outro_05_cleanup();
            Engine.cinematic_lightmap_shadow_disable();
        }

        [ScriptMethod(103, Lifecycle.Static)]
        public async Task c05_outro()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("bsp_03"));
            await Engine.sleep(1);
            await this.c05_outro_scene_01();
            await this.c05_outro_scene_02();
            await this.c05_outro_scene_03();
            await this.c05_outro_scene_04();
            await this.c05_outro_scene_05();
        }

        [ScriptMethod(104, Lifecycle.CommandScript)]
        public async Task long_pause()
        {
            Engine.cs_abort_on_alert(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(105, Lifecycle.CommandScript)]
        public async Task forever_pause()
        {
            Engine.cs_pause(-1F);
        }

        [ScriptMethod(106, Lifecycle.CommandScript)]
        public async Task abort()
        {
            Engine.cs_pause(0.1F);
        }

        [ScriptMethod(107, Lifecycle.Dormant)]
        public async Task _05b_title0()
        {
            await this.cinematic_fade_from_white_bars();
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_1);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(108, Lifecycle.Dormant)]
        public async Task _05b_title1()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_2);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(109, Lifecycle.Dormant)]
        public async Task _05b_title1_alt()
        {
            Engine.hud_cinematic_fade(0F, 0.5F);
            Engine.cinematic_show_letterbox(true);
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_2alt);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(110, Lifecycle.Dormant)]
        public async Task _05b_title2()
        {
            await this.cinematic_fade_from_white_bars();
            await Engine.sleep(30);
            Engine.cinematic_set_title(title_3);
            await Engine.sleep(150);
            Engine.hud_cinematic_fade(1F, 0.5F);
            Engine.cinematic_show_letterbox(false);
        }

        [ScriptMethod(111, Lifecycle.Dormant)]
        public async Task objective_towers_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("make your way through the first set of towers.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(112, Lifecycle.Dormant)]
        public async Task objective_towers_clear()
        {
            Engine.print("objective complete:");
            Engine.print("make your way through the first set of towers.");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(113, Lifecycle.Dormant)]
        public async Task objective_gondola1_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("ride the gondola to the far towers.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(114, Lifecycle.Dormant)]
        public async Task objective_gondola1_clear()
        {
            Engine.print("objective complete:");
            Engine.print("ride the gondola to the far towers.");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(115, Lifecycle.Dormant)]
        public async Task objective_sunken_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("pass through the submerged structures.");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(116, Lifecycle.Dormant)]
        public async Task objective_sunken_clear()
        {
            Engine.print("objective complete:");
            Engine.print("pass through the submerged structures.");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(117, Lifecycle.Dormant)]
        public async Task objective_temple_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("reach the main temple.");
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(118, Lifecycle.Dormant)]
        public async Task objective_temple_clear()
        {
            Engine.print("objective complete:");
            Engine.print("reach the main temple.");
            Engine.objectives_finish_up_to(3);
        }

        [ScriptMethod(119, Lifecycle.Dormant)]
        public async Task objective_regret_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("kill the prophet of regret, and escape.");
            Engine.objectives_show_up_to(4);
        }

        [ScriptMethod(120, Lifecycle.Dormant)]
        public async Task objective_regret_clear()
        {
            Engine.print("objective complete:");
            Engine.print("kill the prophet of regret, and escape.");
            Engine.objectives_finish_up_to(4);
        }

        [ScriptMethod(121, Lifecycle.Dormant)]
        public async Task music_05b_01_start()
        {
            Engine.print("music 05b_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_01", 2240684860U), default(IGameObject), 1F);
        }

        [ScriptMethod(122, Lifecycle.Dormant)]
        public async Task music_05b_01_stop()
        {
            Engine.print("music 05b_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_01", 2240684860U));
        }

        [ScriptMethod(123, Lifecycle.Dormant)]
        public async Task music_05b_02_start()
        {
            Engine.print("music 05b_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_02", 2241209156U), default(IGameObject), 1F);
        }

        [ScriptMethod(124, Lifecycle.Dormant)]
        public async Task music_05b_02_stop()
        {
            Engine.print("music 05b_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_02", 2241209156U));
        }

        [ScriptMethod(125, Lifecycle.Dormant)]
        public async Task music_05b_03_start()
        {
            Engine.print("music 05b_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_03", 2241602378U), default(IGameObject), 1F);
        }

        [ScriptMethod(126, Lifecycle.Dormant)]
        public async Task music_05b_03_stop()
        {
            Engine.print("music 05b_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_03", 2241602378U));
        }

        [ScriptMethod(127, Lifecycle.Dormant)]
        public async Task music_05b_04_start()
        {
            Engine.print("music 05b_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_04", 2242126674U), default(IGameObject), 1F);
        }

        [ScriptMethod(128, Lifecycle.Dormant)]
        public async Task music_05b_04_stop()
        {
            Engine.print("music 05b_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_04", 2242126674U));
        }

        [ScriptMethod(129, Lifecycle.Dormant)]
        public async Task music_05b_05_start()
        {
            Engine.print("music 05b_05 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_05", 2242519896U), default(IGameObject), 1F);
        }

        [ScriptMethod(130, Lifecycle.Dormant)]
        public async Task music_05b_06_start()
        {
            Engine.print("music 05b_06 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_06", 2242782044U), default(IGameObject), 1F);
        }

        [ScriptMethod(131, Lifecycle.Dormant)]
        public async Task music_05b_06_stop()
        {
            Engine.print("music 05b_06 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_06", 2242782044U));
        }

        [ScriptMethod(132, Lifecycle.Dormant)]
        public async Task music_05b_07_start()
        {
            Engine.print("music 05b_07 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_07", 2243175266U), default(IGameObject), 1F);
        }

        [ScriptMethod(133, Lifecycle.Dormant)]
        public async Task music_05b_08_start()
        {
            Engine.print("music 05b_08 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_08", 2243568488U), default(IGameObject), 1F);
        }

        [ScriptMethod(134, Lifecycle.Dormant)]
        public async Task music_05b_09_start()
        {
            Engine.print("music 05b_09 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_09", 2243830636U), default(IGameObject), 1F);
        }

        [ScriptMethod(135, Lifecycle.Dormant)]
        public async Task music_05b_09_start_alt()
        {
            Engine.print("music 05b_09 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_09", 2243830636U), true);
        }

        [ScriptMethod(136, Lifecycle.Dormant)]
        public async Task music_05b_09_stop()
        {
            Engine.print("music 05b_09 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_09", 2243830636U));
        }

        [ScriptMethod(137, Lifecycle.Dormant)]
        public async Task music_05b_10_start()
        {
            Engine.print("music 05b_10 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_10", 2244354932U), default(IGameObject), 1F);
        }

        [ScriptMethod(138, Lifecycle.Dormant)]
        public async Task music_05b_10_stop()
        {
            Engine.print("music 05b_10 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\05b_deltatowers\\05b_music\\05b_10", 2244354932U));
        }

        [ScriptMethod(139, Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            Engine.kill_volume_disable(kill_no_riders_up);
            Engine.kill_volume_disable(kill_bsp03);
            Engine.kill_volume_disable(kill_temple_wings);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.kill_volume_enable(kill_bsp03);
            Engine.kill_volume_enable(kill_temple_wings);
            Engine.kill_volume_disable(kill_bsp01_01);
            Engine.kill_volume_disable(kill_bsp01_02);
        }

        [ScriptMethod(140, Lifecycle.Dormant)]
        public async Task tower1_holo_looper()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant1a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3000"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant2b", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3001"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant2c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3002"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant3a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3003"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant3c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3004"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant5a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3005"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.tower1_holo_trans == false)
                    {
                        this.tower1_holo_chant = true;
                        Engine.custom_animation(regret01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant6a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret01.Entity, "3006"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.tower1_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(141, Lifecycle.Static)]
        public async Task prep_return_from_intro()
        {
            Engine.object_create_anew(in_game_throne);
            Engine.object_create_anew(regret01);
            Engine.objects_attach(in_game_throne.Entity, "driver", regret01.Entity, "");
            Engine.ai_disregard(regret01.Entity, true);
            Engine.ai_place(initial_allies.Squad, 2);
            Engine.object_teleport(await this.player0(), tower1_player0);
            Engine.object_teleport(await this.player1(), tower1_player1);
        }

        [ScriptMethod(142, Lifecycle.Dormant)]
        public async Task tower1_cortana_comment()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1_exit, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_exit_01, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_exit_02, Engine.players()) == true, 30, 300);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            if (Engine.volume_test_objects(vol_tower1_exit, Engine.players()) == false && Engine.volume_test_objects(vol_tower1_exit_01, Engine.players()) == false && Engine.volume_test_objects(vol_tower1_exit_02, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.print("cortana: 'you know, i think the forerunners built these new structures...'");
                Engine.print("'...around the old - to protect them, honor them...'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0810"));
                await Engine.sleep(30);
                Engine.print("'pure speculation, mind you. i'd need to make a thorough survey to be sure.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0820"));
            }

            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(143, Lifecycle.Dormant)]
        public async Task tower1_start()
        {
            Engine.data_mine_set_mission_segment("05b_1_tower1");
            Engine.game_save_immediate();
            await Engine.sleep(90);
            Engine.ai_place(tower1_buggers_01.Squad, 4);
            await Engine.sleep(90);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(tower1_elites_01.Squad, 2);
            }
            else
            {
                Engine.ai_place(tower1_elites_01.Squad, 1);
            }

            Engine.wake(new ScriptMethodReference(tower1_holo_looper));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower1_enemies) < 3 || Engine.volume_test_objects(vol_tower1_upper, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_upper_right, Engine.players()) == true);
            Engine.ai_place(tower1_buggers_02.Squad, (short)(4 - (float)Engine.ai_living_count(tower1_buggers_01.Squad)));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower1_enemies) < 2 || Engine.volume_test_objects(vol_tower1_upper_right, Engine.players()) == true);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(tower1_elites_02.Squad, (short)(2 - (float)Engine.ai_living_count(tower1_elites_01.Squad)));
            }
            else
            {
                Engine.ai_place(tower1_elites_02.Squad, (short)(1 - (float)Engine.ai_living_count(tower1_elites_01.Squad)));
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower1_enemies) < 1 || Engine.volume_test_objects(vol_tower1_exit, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_exit_01, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_exit_02, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_roof, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(tower1_cortana_comment));
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(music_05b_01_start));
        }

        [ScriptMethod(144, Lifecycle.CommandScript)]
        public async Task tower1_escape()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("bridges"));
        }

        [ScriptMethod(145, Lifecycle.Dormant)]
        public async Task cortana_bridge_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower2_ext_entry, Engine.players()) == true || Engine.volume_test_objects(vol_central_platform, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_tower2_ext_entry, Engine.players()) == false && Engine.volume_test_objects(vol_central_platform, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'there's some sort of transport-system on the far side...'");
                Engine.print("'...of that center platform. let's check it out.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0860"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(146, Lifecycle.Dormant)]
        public async Task bridges_start()
        {
            Engine.ai_disposable(tower1_enemies, true);
            Engine.data_mine_set_mission_segment("05b_2_bridges");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            if (await this.difficulty_heroic())
            {
                this.bridges_sniper_count = 4;
            }

            if (await this.difficulty_legendary())
            {
                this.bridges_sniper_count = 5;
            }

            Engine.begin_random(async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    Engine.ai_place(bridge_jackals_01.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    Engine.ai_place(bridge_jackals_02.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    Engine.ai_place(bridge_jackals_03.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    Engine.ai_place(bridge_jackals_04.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    Engine.ai_place(bridge_jackals_05.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            }, 
                async () =>
            {
                if (this.bridges_sniper_count > 0)
                {
                    Engine.ai_place(bridge_jackals_06.Squad, 1);
                    this.bridges_sniper_count = (short)(this.bridges_sniper_count - 1);
                }
            });
            Engine.ai_place(bridge_elites_01.Squad, 1);
            Engine.ai_place(bridge_elites_02.Squad, 1);
            Engine.ai_place(bridge_grunts_01.Squad, 2);
            Engine.ai_set_orders(all_allies, tower1_ext_allies);
            Engine.cs_run_command_script(all_allies, new ScriptMethodReference(tower1_escape));
            Engine.wake(new ScriptMethodReference(cortana_bridge_reminder));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_enemies) < 5 || Engine.volume_test_objects(vol_bridge, Engine.players()) == true || Engine.volume_test_objects(vol_tower2_ext_entry, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_grunts_02.Squad, (short)(3 - (float)Engine.ai_living_count(bridge_grunts_01.Squad)));
            }

            if ((short)Engine.ai_living_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_elites_03.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_enemies) < 5 || Engine.volume_test_objects(vol_tower2_ext_entry, Engine.players()) == true || Engine.volume_test_objects(vol_bridge_far_half, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_grunts_03.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_grunts_02.Squad)));
            }

            if ((short)Engine.ai_living_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_jackals_07.Squad, 1);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bridge, Engine.players()) == true || Engine.volume_test_objects(vol_tower2_ext_entry, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, bridge_allies);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bridge_enemies) < 5 || Engine.volume_test_objects(vol_tower2_ext_entry, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_grunts_04.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_grunts_03.Squad)));
            }

            if ((short)Engine.ai_living_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_elites_04.Squad, 1);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower2_ext_entry, Engine.players()) == true);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, tower2_ext_allies_01);
        }

        [ScriptMethod(147, Lifecycle.Dormant)]
        public async Task tower2_cortana_comment()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == true || Engine.volume_test_objects(vol_tower2_ext_exit, Engine.players()) == true || Engine.volume_test_objects(vol_tower2_exit_mid, Engine.players()) == true, 30, 300);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            if (Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == false && Engine.volume_test_objects(vol_tower2_ext_exit, Engine.players()) == false && Engine.volume_test_objects(vol_tower2_exit_mid, Engine.players()) == true && await this.player_count() > 0)
            {
                Engine.print("cortana: 'i wish i had time to decipher these inscriptions.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0870"));
                await Engine.sleep(60);
                Engine.print("'the forerunners revered this place - that much is clear.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0880"));
                await Engine.sleep(60);
                Engine.print("'but was it a temple? a university? i can't say...'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0890"));
            }

            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(148, Lifecycle.Dormant)]
        public async Task tower2_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower2_entry, Engine.players()) == true || Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == true);
            Engine.ai_disposable(bridge_enemies, true);
            Engine.data_mine_set_mission_segment("05b_3_tower2");
            Engine.ai_renew(all_allies);
            Engine.wake(new ScriptMethodReference(music_05b_01_stop));
            Engine.game_save();
            Engine.ai_place(tower2_jackals_01.Squad, 2);
            Engine.ai_place(tower2_grunts_01.Squad, 2);
            Engine.ai_place(tower2_grunts_02.Squad, 2);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_in_tower2, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, tower2_allies);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower2_enemies) < 3 || Engine.volume_test_objects(vol_tower2_by_exit, Engine.players()) == true || Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == true);
            Engine.game_save();
            Engine.ai_place(tower2_jackals_02.Squad, (short)(2 - (float)Engine.ai_living_count(tower2_jackals_01.Squad)));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower2_enemies) <= 0 || Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(tower2_cortana_comment));
        }

        [ScriptMethod(149, Lifecycle.Dormant)]
        public async Task miranda_pelican_comment()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("miranda: 'cortana? the covenant's getting nosy.'");
            Engine.print("'i don't want to give away my position,'");
            Engine.print("'so i'm re-routing a few stragglers back to you.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0830"));
            await Engine.sleep(30);
            Engine.print("'i apologize. these pelicans are all the support you're going to get.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0840"));
            await Engine.sleep(60);
            Engine.print("'understood, ma'am.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0850"));
            this.miranda_pel_comment_done = true;
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(150, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_warn()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'a gondola's launching from the far towers!'");
            Engine.print("'big surprise: it's full of covenant reinforcements!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0900"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(151, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_comment()
        {
            if (Engine.volume_test_objects(vol_gondola_01, Engine.players()) == false && await this.player_count() > 0 && (bool)Engine.ai_trigger_test("done_fighting", central_platform_enemies) == true && (bool)Engine.ai_trigger_test("done_fighting", gondola_01_enemies) == true)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'well, they were nice enough to bring us a ride.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0910"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(152, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_reminder()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'this gondola won't bring us all the way to the main-temple,'");
            Engine.print("'but it'll get us close. let's get on-board.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0950"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(153, Lifecycle.CommandScript)]
        public async Task gondola_01_ally_comment()
        {
            Engine.cs_switch("ally01");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            Engine.print("ally_01: 'all aboard!'");
            Engine.cs_play_line("0920");
            Engine.cs_switch("ally02");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_abort_on_damage(true);
            await Engine.sleep(5);
            Engine.print("ally_02: 'i'll drive!'");
            Engine.cs_play_line("0930");
            Engine.cs_switch("ally01");
            await Engine.sleep(15);
            Engine.print("ally_01: 'what's to drive? it comes here. it goes there.'");
            Engine.cs_play_line("0940");
        }

        [ScriptMethod(154, Lifecycle.Dormant)]
        public async Task hunter_drop()
        {
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), true);
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a01");
            await Engine.sleep(60);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a02");
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), false);
            Engine.ai_set_blind(central_platform_hunters.Squad, false);
        }

        [ScriptMethod(155, Lifecycle.CommandScript)]
        public async Task central_platform_dropship()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_0"), 10F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_1"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_2"), 5F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.wake(new ScriptMethodReference(hunter_drop));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_2"), 1F);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(central_platform_phantom.Squad) < 2);
            await Engine.sleep(60);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_3"), Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_1"), 1F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_1"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_0"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_01_x"), 40F);
            Engine.ai_erase(central_platform_phantom.Squad);
        }

        [ScriptMethod(156, Lifecycle.CommandScript)]
        public async Task central_platform_pelican_path()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/p0"), 2F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel0"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel1"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel3"), 10F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel4"), 5F);
            this.central_plat_pel_arrives = true;
            Engine.cs_vehicle_speed(0.3F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel4"), 1F);
            Engine.ai_place(central_plat_pelican_allies.Squad, (short)(2 - (float)Engine.ai_living_count(allies_infantry)));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_p", Engine.ai_actors(central_plat_pelican_allies.Squad));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel5"), 1F);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_p");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(central_plat_pelican.Squad) < 4);
            await Engine.sleep(60);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel4"), Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel3"), 1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel3"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel2"), 2F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel2"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel1"), 20F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pel0"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/pelx"), 5F);
            Engine.ai_erase(central_plat_pelican.Squad);
        }

        [ScriptMethod(157, Lifecycle.Dormant)]
        public async Task central_platform_pelican()
        {
            Engine.ai_place(central_plat_pelican.Squad, 1);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), true);
            Engine.cs_run_command_script(central_plat_pelican.pilot, new ScriptMethodReference(central_platform_pelican_path));
            Engine.object_create_anew(rack);
            Engine.objects_attach(Engine.ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_sc_01", rack.Entity, "pin");
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
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0));
                }

                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0));
                }

                return this.central_plat_pel_arrives == true;
            });
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

        [ScriptMethod(158, Lifecycle.Static)]
        public async Task short_central_plat_pel()
        {
            Engine.ai_place(central_plat_pelican.Squad, 1);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), true);
            Engine.cs_run_command_script(central_plat_pelican.pilot, new ScriptMethodReference(central_platform_pelican_path));
            Engine.object_create_anew(rack);
            Engine.objects_attach(Engine.ai_vehicle_get_from_starting_location(central_plat_pelican.pilot), "pelican_sc_01", rack.Entity, "pin");
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
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0));
                }

                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0));
                }

                return this.central_plat_pel_arrives == true;
            });
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

        [ScriptMethod(159, Lifecycle.Dormant)]
        public async Task central_plat_ph_go()
        {
            Engine.ai_place(central_platform_hunters.Squad, 2);
            Engine.ai_place(central_platform_phantom.Squad, 1);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a", Engine.ai_actors(central_platform_hunters.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), true);
            Engine.cs_run_command_script(central_platform_phantom.pilot, new ScriptMethodReference(central_platform_dropship));
            await Engine.sleep(4000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot));
        }

        [ScriptMethod(160, Lifecycle.Dormant)]
        public async Task gondola_01_wake()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.device_get_position(gondola_01_a.Entity) > 0.37F && Engine.device_get_position(gondola_01_a.Entity) < 0.59F && Engine.device_get_position(gondola_01_a.Entity) > this.gondola_01_wake_state)
                {
                    Engine.object_clear_function_variable(gondola_01_a.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_01_a.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_01_a.Entity, "wake_backward", 1F, 1F);
                    Engine.object_clear_function_variable(gondola_01_b.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_01_b.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_01_b.Entity, "wake_backward", 1F, 1F);
                }

                if (Engine.device_get_position(gondola_01_a.Entity) > 0.37F && Engine.device_get_position(gondola_01_a.Entity) < 0.59F && Engine.device_get_position(gondola_01_a.Entity) < this.gondola_01_wake_state)
                {
                    Engine.object_clear_function_variable(gondola_01_a.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_01_a.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_01_a.Entity, "wake_forward", 1F, 1F);
                    Engine.object_clear_function_variable(gondola_01_b.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_01_b.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_01_b.Entity, "wake_forward", 1F, 1F);
                }

                if (Engine.device_get_position(gondola_01_a.Entity) == this.gondola_01_wake_state || Engine.device_get_position(gondola_01_a.Entity) < 0.37F || Engine.device_get_position(gondola_01_a.Entity) > 0.59F)
                {
                    Engine.object_clear_function_variable(gondola_01_a.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_01_a.Entity, "wake_backward");
                    Engine.object_clear_function_variable(gondola_01_b.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_01_b.Entity, "wake_backward");
                }

                this.gondola_01_wake_state = Engine.device_get_position(gondola_01_a.Entity);
                return Engine.device_get_position(gondola_01_a.Entity) == 0F;
            });
        }

        [ScriptMethod(161, Lifecycle.Dormant)]
        public async Task central_platform_start()
        {
            Engine.ai_disposable(tower2_enemies, true);
            Engine.data_mine_set_mission_segment("05b_4_central_platform");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            Engine.ai_place(tower3_turrets.Squad, 2);
            Engine.objects_attach(gondola_01_b.Entity, "control_back", gondola_01_switch_front.Entity, "");
            Engine.objects_attach(gondola_01_a.Entity, "control_back", gondola_01_switch_back.Entity, "");
            Engine.device_set_position(gondola_01_launch_a.Entity, 1F);
            Engine.device_set_position(gondola_01_launch_b.Entity, 1F);
            Engine.device_set_position(gondola_01_a.Entity, 0.5F);
            Engine.device_set_position(gondola_01_b.Entity, 0.5F);
            Engine.ai_place(central_platform_elites_01.Squad, 1);
            Engine.ai_place(central_platform_elites_02.Squad, 1);
            Engine.ai_place(central_platform_jackals_01.Squad, 2);
            Engine.ai_place(central_platform_jackals_02.Squad, 2);
            Engine.ai_set_orders(all_allies, tower2_ext_allies_02);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_near_gondola_01, Engine.players()) == true || Engine.volume_test_objects(vol_central_platform, Engine.players()) == true, 30, 150);
            Engine.wake(new ScriptMethodReference(gondola_01_wake));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_near_gondola_01, Engine.players()) == true || Engine.volume_test_objects(vol_central_platform, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, central_platform_allies);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(central_platform_enemies) < 2, 30, 4000);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", central_platform_enemies) == true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(central_plat_ph_go));
            await Engine.sleep(450);
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(central_platform_hunters.Squad) > 0 || (short)Engine.ai_living_count(central_platform_phantom.Squad) < 1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(central_platform_hunters.Squad) < 1);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(music_05b_02_start));
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(miranda_pelican_comment));
            await Engine.sleep_until(async () => this.miranda_pel_comment_done == true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(central_platform_pelican));
            Engine.ai_place(gondola_01_elite_riders.Squad, 2);
            Engine.ai_place(gondola_01_grunt_riders.Squad, 3);
            Engine.device_set_position(gondola_01_a.Entity, 1F);
            Engine.device_set_position(gondola_01_b.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) > 0.75F);
            Engine.wake(new ScriptMethodReference(gondola_01_cortana_warn));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) == 1F);
            Engine.object_dynamic_simulation_disable(gondola_01_a.Entity, true);
            Engine.object_dynamic_simulation_disable(gondola_01_b.Entity, true);
            Engine.device_set_position(gondola_01_launch_a.Entity, 0F);
            Engine.device_set_position(gondola_01_launch_b.Entity, 0F);
            Engine.device_group_change_only_once_more_set(gondola_01_switch, true);
            Engine.ai_set_orders(gondola_01_grunt_riders.Squad, gondola_01_landing_01);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_05b_03_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_near_gondola_01, Engine.players()) == true || (short)Engine.ai_living_count(gondola_01_enemies) < 3);
            Engine.ai_place(gondola_01_jackal_riders.Squad, 2);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(gondola_01_jackal_riders.Squad) <= 0 || Engine.volume_test_objects(vol_gondola_01, Engine.players()) == true, 30, 4000);
            Engine.ai_set_orders(gondola_01_elite_riders.Squad, gondola_01_landing_03);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_gondola_01, Engine.players()) == true || (short)Engine.ai_living_count(gondola_01_enemies) <= 0 && (short)Engine.ai_living_count(central_platform_enemies) <= 0 && (short)Engine.ai_living_count(bridge_enemies) <= 0, 30, 4000);
            await Engine.sleep(30);
            Engine.wake(new ScriptMethodReference(gondola_01_cortana_comment));
            await Engine.sleep(150);
            Engine.ai_scene("gondola_01_allies_scene", new ScriptMethodReference(gondola_01_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            Engine.ai_set_orders(all_allies, gondola_01_allies);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_gondola_01, Engine.players()) == true, 30, 1800);
            if (Engine.volume_test_objects(vol_gondola_01, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.wake(new ScriptMethodReference(gondola_01_cortana_reminder));
            }
        }

        [ScriptMethod(162, Lifecycle.Static)]
        public async Task short_central_plat_ph()
        {
            Engine.device_set_position_immediate(gondola_01_a.Entity, 0.5F);
            Engine.device_set_position_immediate(gondola_01_b.Entity, 0.5F);
            Engine.ai_place(central_platform_hunters.Squad, 2);
            Engine.ai_place(central_platform_phantom.Squad, 1);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), "phantom_p_a", Engine.ai_actors(central_platform_hunters.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot), true);
            Engine.cs_run_command_script(central_platform_phantom.pilot, new ScriptMethodReference(central_platform_dropship));
            await Engine.sleep(4000);
            Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(central_platform_phantom.pilot));
        }

        [ScriptMethod(163, Lifecycle.Dormant)]
        public async Task assassin_ice_cream()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_assassins, Engine.players()) == false);
            Engine.object_create(assassins);
            Engine.ai_place(assassin_elites.Squad);
            Engine.ai_set_active_camo(assassin_elites.Squad, true);
            Engine.cs_run_command_script(assassin_elites.Squad, new ScriptMethodReference(forever_pause));
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(assassin_elites.Squad), 0)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3974105962U), "combat:sword:berserk", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(assassin_elites.Squad), 1)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3974105962U), "combat:sword:berserk", true);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4209383790U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4209383790U)));
            Engine.ice_cream_flavor_stock(2);
        }

        [ScriptMethod(164, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_01()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_move_in_direction(90F, 2F, 0F);
            Engine.cs_move_in_direction(45F, 5.5F, 0F);
            Engine.cs_move_in_direction(95F, 1F, 0F);
            Engine.cs_jump(45F, 7F);
        }

        [ScriptMethod(165, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_02()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_move_in_direction(90F, 2.75F, 0F);
            Engine.cs_move_in_direction(45F, 5.5F, 0F);
            Engine.cs_move_in_direction(90F, 1F, 0F);
            Engine.cs_jump(45F, 7.5F);
        }

        [ScriptMethod(166, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_03()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_move_in_direction(90F, 3.5F, 0F);
            Engine.cs_move_in_direction(45F, 5.5F, 0F);
            Engine.cs_move_in_direction(85F, 1F, 0F);
            Engine.cs_jump(45F, 8F);
        }

        [ScriptMethod(167, Lifecycle.CommandScript)]
        public async Task gondola_01_jumper_04()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_move_in_direction(90F, 4.25F, 0F);
            Engine.cs_move_in_direction(45F, 5.5F, 0F);
            Engine.cs_move_in_direction(75F, 1F, 0F);
            Engine.cs_jump(45F, 8.5F);
        }

        [ScriptMethod(168, Lifecycle.Dormant)]
        public async Task gondola_01_buggers_board()
        {
            await Engine.sleep(150);
            Engine.ai_place(gondola_01_bugs_new.Squad, 4);
        }

        [ScriptMethod(169, Lifecycle.Dormant)]
        public async Task gondola_01_go_reminder()
        {
            await Engine.sleep_until(async () => Engine.device_group_get(gondola_01_switch) > 0F, 30, 1800);
            if (Engine.device_group_get(gondola_01_switch) == 0F)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'if you hit the activation-switch, it should drive itself.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0960"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => Engine.device_group_get(gondola_01_switch) > 0F, 30, 900);
            if (Engine.device_group_get(gondola_01_switch) == 0F)
            {
                Engine.activate_team_nav_point_object(_default, player, gondola_01_switch_back.Entity, 0F);
                await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) < 1F);
                Engine.deactivate_team_nav_point_object(player, gondola_01_switch_back.Entity);
            }
        }

        [ScriptMethod(170, Lifecycle.CommandScript)]
        public async Task gondola_01_boarders_warn()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'whoa!  we got boarders!'");
            Engine.cs_play_line("0970");
        }

        [ScriptMethod(171, Lifecycle.Dormant)]
        public async Task gondola_01_cortana_arch()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'this lake couldn't have been formed by volcanic action -'");
            Engine.print("'which means it was either built this way on purpose,'");
            Engine.print("'or was created by some other cataclysmic event.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0980"));
            await Engine.sleep(30);
            Engine.print("cortana: 'sorry. were you trying to kill something?'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0990"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.game_save();
        }

        [ScriptMethod(172, Lifecycle.CommandScript)]
        public async Task gondola_01_retreat()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_02_4"), 2F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_02_x"), 2F);
            Engine.ai_erase(gondola_01_phantom.Squad);
        }

        [ScriptMethod(173, Lifecycle.Dormant)]
        public async Task gondola_01_unload()
        {
            await Engine.sleep(90);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_a01");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_a02");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_a03");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_b01");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_b02");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_b03");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_c01");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_c02");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p_c03");
            await Engine.sleep(90);
            Engine.cs_run_command_script(gondola_01_phantom.pilot, new ScriptMethodReference(gondola_01_retreat));
        }

        [ScriptMethod(174, Lifecycle.CommandScript)]
        public async Task gondola_01_flight()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_02_0"), 2F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_02_1"), 2F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_02_2"), Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_02_3"));
            Engine.cs_vehicle_speed(0.3F);
            Engine.wake(new ScriptMethodReference(gondola_01_unload));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("bsp1_airspace/ph_02_3"));
        }

        [ScriptMethod(175, Lifecycle.Dormant)]
        public async Task gondola_01_phantom_arrives()
        {
            Engine.ai_place(gondola_01_elite_boarders.Squad, 2);
            Engine.ai_place(gondola_01_grunt_boarders_01.Squad, 2);
            Engine.ai_place(gondola_01_grunt_boarders_02.Squad, 2);
            Engine.ai_place(gondola_01_phantom.Squad, 1);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p", Engine.ai_actors(gondola_01_grunt_boarders_01.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p", Engine.ai_actors(gondola_01_elite_boarders.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), "phantom_p", Engine.ai_actors(gondola_01_grunt_boarders_02.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(gondola_01_phantom.pilot), true);
            Engine.cs_run_command_script(gondola_01_phantom.pilot, new ScriptMethodReference(gondola_01_flight));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(gondola_01_phantom.Squad) < 2);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(gondola_01_grunt_boarders_01.Squad) <= 0 && (short)Engine.ai_living_count(gondola_01_grunt_boarders_02.Squad) <= 0);
            Engine.ai_set_orders(gondola_01_elite_boarders.Squad, gondola_01_all);
        }

        [ScriptMethod(176, Lifecycle.CommandScript)]
        public async Task tower3_turret_mount_01()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("tower3/left"));
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.left));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            await Engine.sleep(120);
            if (Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.left), "c_turret_ap_d", Engine.unit(Engine.ai_get_object(this.ai_current_actor))) == true)
            {
                Engine.cs_set_behavior(guard);
            }
        }

        [ScriptMethod(177, Lifecycle.CommandScript)]
        public async Task tower3_turret_mount_02()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("tower3/right"));
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.right));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            await Engine.sleep(120);
            if (Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.right), "c_turret_ap_d", Engine.unit(Engine.ai_get_object(this.ai_current_actor))) == true)
            {
                Engine.cs_set_behavior(guard);
            }
        }

        [ScriptMethod(178, Lifecycle.Dormant)]
        public async Task tower3_turret_reman()
        {
            await Engine.sleep(300);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep((short)Engine.random_range(30, 90));
                if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.right)) > 0F && Engine.volume_test_objects(vol_tower3_entry, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_spawn_count(tower3_dock_grunts.Squad) < 5 && (short)Engine.ai_living_count(tower3_dock_grunts.Squad) < 1 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.right), "c_turret_ap_d", Engine.ai_actors(all_enemies)) == false)
                {
                    Engine.ai_place(tower3_dock_grunts.Squad, 1);
                    Engine.cs_run_command_script(tower3_dock_grunts.Squad, new ScriptMethodReference(tower3_turret_mount_02));
                }

                await Engine.sleep((short)Engine.random_range(30, 90));
                if (Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.left)) > 0F && Engine.volume_test_objects(vol_tower3_entry, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_spawn_count(tower3_dock_grunts.Squad) < 5 && (short)Engine.ai_living_count(tower3_dock_grunts.Squad) < 1 && Engine.vehicle_test_seat_list(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.left), "c_turret_ap_d", Engine.ai_actors(all_enemies)) == false)
                {
                    Engine.ai_place(tower3_dock_grunts.Squad, 1);
                    Engine.cs_run_command_script(tower3_dock_grunts.Squad, new ScriptMethodReference(tower3_turret_mount_01));
                }

                return Engine.volume_test_objects(vol_tower3_entry, await this.player0()) == true || Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.right)) <= 0F && Engine.object_get_health(Engine.ai_vehicle_get_from_starting_location(tower3_turrets.left)) <= 0F;
            });
        }

        [ScriptMethod(179, Lifecycle.Dormant)]
        public async Task tower3_dock_above()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower3_dock_snipers.Squad) <= 0 || Engine.device_get_position(gondola_01_a.Entity) == 0F);
            if (Engine.device_get_position(gondola_01_a.Entity) > 0F)
            {
                Engine.ai_place(tower3_dock_snipers.Squad, 2);
            }
        }

        [ScriptMethod(180, Lifecycle.Dormant)]
        public async Task gondola_01_nuke()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 0)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 1), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 1)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 2), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 2)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(tower_cluster_enemies), 2));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                await Engine.sleep(5);
                return Engine.device_get_position(gondola_01_a.Entity) < 0.25F;
            });
        }

        [ScriptMethod(181, Lifecycle.Dormant)]
        public async Task gondola_01_restarter()
        {
            await Engine.sleep_until(async () =>
            {
                this.gondola_01_state = Engine.device_get_position(gondola_01_a.Entity);
                if (Engine.volume_test_objects_all(vol_gondola_01_mid, Engine.players()) == true && await this.player_count() > 0)
                {
                    Engine.device_set_position(gondola_01_a.Entity, 0F);
                    Engine.device_set_position(gondola_01_b.Entity, 0F);
                }
                else
                {
                    Engine.device_set_position(gondola_01_a.Entity, this.gondola_01_state);
                    Engine.device_set_position(gondola_01_b.Entity, this.gondola_01_state);
                }

                return Engine.device_get_position(gondola_01_a.Entity) < 0.4F;
            });
        }

        [ScriptMethod(182, Lifecycle.Dormant)]
        public async Task gondola_01_reverser()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects_all(vol_gondola_01_mid, Engine.players()) == true && await this.player_count() > 0)
                {
                    Engine.device_set_position(gondola_01_a.Entity, 0F);
                    Engine.device_set_position(gondola_01_b.Entity, 0F);
                }
                else
                {
                    Engine.device_set_position(gondola_01_a.Entity, 0.54F);
                    Engine.device_set_position(gondola_01_b.Entity, 0.54F);
                }

                return Engine.device_get_position(gondola_01_a.Entity) < 0.4F;
            });
        }

        [ScriptMethod(183, Lifecycle.Dormant)]
        public async Task tower_cluster_delete()
        {
            await Engine.sleep_until(async () => Engine.objects_can_see_flag(Engine.players(), tower_cluster, 45F) == false, 30, 300);
            Engine.garbage_collect_unsafe();
            Engine.object_destroy_containing("tower_cluster_");
        }

        [ScriptMethod(184, Lifecycle.Dormant)]
        public async Task gondola_01_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_gondola_01, Engine.players()) == true);
            Engine.ai_disposable(central_platform_enemies, true);
            Engine.data_mine_set_mission_segment("05b_5_gondola_01");
            Engine.ai_renew(all_allies);
            Engine.wake(new ScriptMethodReference(objective_towers_clear));
            Engine.wake(new ScriptMethodReference(objective_gondola1_set));
            Engine.wake(new ScriptMethodReference(gondola_01_go_reminder));
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.device_group_get(gondola_01_switch) > 0F);
            Engine.device_set_power(gondola_01_switch_back.Entity, 0F);
            Engine.wake(new ScriptMethodReference(music_05b_02_stop));
            Engine.wake(new ScriptMethodReference(music_05b_03_stop));
            Engine.wake(new ScriptMethodReference(tower_cluster_delete));
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_gondola_01, Engine.players()) == true && await this.player_count() > 0);
            Engine.object_dynamic_simulation_disable(gondola_01_a.Entity, false);
            Engine.object_dynamic_simulation_disable(gondola_01_b.Entity, false);
            Engine.wake(new ScriptMethodReference(_05b_title1));
            Engine.device_set_position(gondola_01_launch_a.Entity, 1F);
            Engine.device_set_position(gondola_01_launch_b.Entity, 1F);
            Engine.device_set_position(gondola_01_a.Entity, 0.54F);
            Engine.device_set_position(gondola_01_b.Entity, 0.54F);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(gondola_01_buggers_board));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) < 0.85F);
            Engine.game_save();
            Engine.ai_place(gondola_01_b_elites.Squad, 2);
            Engine.ai_place(gondola_01_b_buggers.Squad, (short)(4 - (float)Engine.ai_living_count(gondola_01_bugs_new.Squad)));
            Engine.ai_place(tower3_dock_grunts.Squad, 2);
            Engine.cs_run_command_script(tower3_dock_grunts._1, new ScriptMethodReference(tower3_turret_mount_01));
            Engine.cs_run_command_script(tower3_dock_grunts._2, new ScriptMethodReference(tower3_turret_mount_02));
            Engine.wake(new ScriptMethodReference(gondola_01_nuke));
            Engine.wake(new ScriptMethodReference(tower3_turret_reman));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) < 0.7F);
            Engine.wake(new ScriptMethodReference(gondola_01_cortana_arch));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) == 0.54F);
            Engine.game_save();
            Engine.ai_place(tower3_dock_snipers.Squad, 2);
            Engine.wake(new ScriptMethodReference(tower3_dock_above));
            Engine.ai_set_orders(gondola_01_b_buggers.Squad, gondola_01_all);
            Engine.object_dynamic_simulation_disable(gondola_01_a.Entity, true);
            Engine.object_dynamic_simulation_disable(gondola_01_b.Entity, true);
            await Engine.sleep_until(async () => (float)Engine.ai_living_count(gondola_01_b_elites.Squad) + (float)Engine.ai_living_count(gondola_01_b_buggers.Squad) < 1F, 30, 1800);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", gondola_01_enemies) == true, 30, 1800);
            await Engine.sleep(60);
            Engine.game_save();
            Engine.object_dynamic_simulation_disable(gondola_01_a.Entity, false);
            Engine.object_dynamic_simulation_disable(gondola_01_b.Entity, false);
            Engine.wake(new ScriptMethodReference(music_05b_04_start));
            Engine.wake(new ScriptMethodReference(gondola_01_reverser));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) < 0.25F);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) == 0F);
            Engine.game_save();
            Engine.device_set_position(gondola_01_launch_a.Entity, 0F);
            Engine.device_set_position(gondola_01_launch_b.Entity, 0F);
            Engine.ai_place(tower3_dock_jackals.Squad, 2);
            Engine.wake(new ScriptMethodReference(music_05b_04_stop));
            if (await this.difficulty_legendary())
            {
                Engine.wake(new ScriptMethodReference(assassin_ice_cream));
            }

            await Engine.sleep_until(async () => Engine.device_get_position(gondola_01_a.Entity) == 0F && Engine.volume_test_objects_all(vol_gondola_01, Engine.players()) == false && await this.player_count() > 0);
            Engine.object_dynamic_simulation_disable(gondola_01_a.Entity, true);
            Engine.object_dynamic_simulation_disable(gondola_01_b.Entity, true);
            Engine.ai_set_orders(all_allies, tower3_allies);
            Engine.game_save();
        }

        [ScriptMethod(185, Lifecycle.Static)]
        public async Task cam_shake()
        {
            Engine.player_effect_set_max_rotation(0F, 2F, 2F);
            Engine.player_effect_set_max_vibration(1F, 1F);
            Engine.player_effect_start(0.5F, 0F);
            Engine.player_effect_stop(1F);
        }

        [ScriptMethod(186, Lifecycle.Static)]
        public async Task godownfast()
        {
            Engine.device_set_position_track(elev_under.Entity, "transition_1to2", 0F);
            Engine.device_animate_position(elev_under.Entity, 0.135F, 1F, 1F, 1F, false);
        }

        [ScriptMethod(187, Lifecycle.Static)]
        public async Task nowcomeup()
        {
            Engine.device_animate_position(elev_under.Entity, 0F, 15F, 1F, 1F, false);
        }

        [ScriptMethod(188, Lifecycle.Static)]
        public async Task go1to2()
        {
            Engine.device_set_position_track(elev_under.Entity, "transition_1to2", 0F);
            Engine.device_animate_position(elev_under.Entity, 0.103F, 10F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) == 0.103F);
            if (Engine.volume_test_object(vol_elev_shaft_under, await this.player0()) == false && await this.player_count() > 0)
            {
                Engine.object_teleport(await this.player0(), _1to2_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player0(), "");
            }

            if (Engine.volume_test_object(vol_elev_shaft_under, await this.player1()) == false && await this.player_count() > 0)
            {
                Engine.object_teleport(await this.player1(), _1to2_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player0(), "");
            }

            Engine.switch_bsp(3);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.device_animate_position(elev_under.Entity, 1F, 60F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.122F, 1);
            Engine.effect_new(this.splashy, splash_01);
            Engine.effect_new(this.splashy, splash_02);
            Engine.effect_new(this.splashy, splash_03);
            Engine.effect_new(this.splashy, splash_04);
            Engine.effect_new(this.splashy, splash_05);
            Engine.effect_new(this.splashy, splash_06);
            Engine.effect_new(this.splashy, splash_07);
            Engine.effect_new(this.splashy, splash_08);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244879228U), default(IGameObject), 1F);
            Engine.object_destroy(water_1to2a.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.128F, 1);
            Engine.object_create_anew(water_1to2a);
            Engine.wake(new ScriptMethodReference(music_05b_05_start));
            await Engine.sleep(60);
            Engine.ai_erase(all_enemies);
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 4));
                }

                await Engine.sleep(5);
                return Engine.device_get_position(elev_under.Entity) > 0.5F;
            });
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.6F);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.866F, 1);
            Engine.effect_new(this.splashy, splash_09);
            Engine.effect_new(this.splashy, splash_10);
            Engine.effect_new(this.splashy, splash_11);
            Engine.effect_new(this.splashy, splash_12);
            Engine.effect_new(this.splashy, splash_13);
            Engine.effect_new(this.splashy, splash_14);
            Engine.effect_new(this.splashy, splash_15);
            Engine.effect_new(this.splashy, splash_16);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245010302U), default(IGameObject), 1F);
            Engine.object_destroy(water_1to2b.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.874F, 1);
            Engine.object_create_anew(water_1to2b);
        }

        [ScriptMethod(189, Lifecycle.Static)]
        public async Task sub2doors()
        {
            Engine.device_set_position_track(elev_up.Entity, "transition_2to3", 0F);
            Engine.device_animate_position(elev_up.Entity, 0F, 1F, 1F, 1F, false);
        }

        [ScriptMethod(190, Lifecycle.Static)]
        public async Task go2to3()
        {
            Engine.device_set_position_track(elev_up.Entity, "transition_2to3", 0F);
            Engine.device_animate_position(elev_up.Entity, 0.103F, 10F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) == 0.103F);
            if (Engine.volume_test_object(vol_elev_shaft_up, await this.player0()) == false && await this.player_count() > 0)
            {
                Engine.object_teleport(await this.player0(), _2to3_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player0(), "");
            }

            if (Engine.volume_test_object(vol_elev_shaft_up, await this.player1()) == false && await this.player_count() > 0)
            {
                Engine.object_teleport(await this.player1(), _2to3_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player0(), "");
            }

            Engine.switch_bsp(4);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 4);
            Engine.device_animate_position(elev_up.Entity, 1F, 60F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.134F, 1);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244879228U), default(IGameObject), 1F);
            Engine.object_destroy(water_2to3a.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.143F, 1);
            Engine.object_create_anew(water_2to3a);
            Engine.wake(new ScriptMethodReference(music_05b_08_start));
            await Engine.sleep(60);
            Engine.ai_erase(all_enemies);
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 4));
                }

                await Engine.sleep(5);
                return Engine.device_get_position(elev_up.Entity) > 0.7F;
            });
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.889F, 1);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245010302U), default(IGameObject), 1F);
            Engine.object_destroy(water_2to3b.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.896F, 1);
            Engine.object_create_anew(water_2to3b);
        }

        [ScriptMethod(191, Lifecycle.CommandScript)]
        public async Task tower3_pelican_path()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("tower3_airspace/pel0"), 2F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("tower3_airspace/peln"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("tower3_airspace/pel1"), 5F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("tower3_airspace/pel1"), 1F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("tower3_airspace/pel2"), Engine.GetReference<ISpatialPoint>("tower3_airspace/p0"), 1F);
            Engine.ai_place(tower3_pelican_allies.Squad, (short)(2 - (float)Engine.ai_living_count(allies_infantry)));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(tower3_pelican.pilot), "pelican_p", Engine.ai_actors(tower3_pelican_allies.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(tower3_pelican.pilot), true);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(tower3_pelican.pilot), "pelican_p");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower3_pelican.Squad) < 4);
            await Engine.sleep(60);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("tower3_airspace/pel1"), Engine.GetReference<ISpatialPoint>("tower3_airspace/peln"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("tower3_airspace/peln"), 5F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("tower3_airspace/pel0"), 20F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("tower3_airspace/pelx"), 10F);
            Engine.ai_erase(tower3_pelican.Squad);
        }

        [ScriptMethod(192, Lifecycle.Dormant)]
        public async Task tower3_pelican_arrives()
        {
            Engine.ai_place(tower3_pelican.Squad);
            Engine.cs_run_command_script(tower3_pelican.pilot, new ScriptMethodReference(tower3_pelican_path));
        }

        [ScriptMethod(193, Lifecycle.Static)]
        public async Task short_tower3_pel()
        {
            Engine.ai_place(tower3_pelican.Squad);
            Engine.cs_run_command_script(tower3_pelican.pilot, new ScriptMethodReference(tower3_pelican_path));
        }

        [ScriptMethod(194, Lifecycle.Dormant)]
        public async Task tower3_cortana_comment()
        {
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", tower3_enemies) == true);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'ah, now i see. there's a submerged section that...'");
            Engine.print("'...connects these towers to the outlying structures.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1000"));
            await Engine.sleep(60);
            Engine.print("'looks like we're going down.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1010"));
            await Engine.sleep(30);
            Engine.print("'unless you'd prefer to swim...'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1020"));
            this.tower3_done_blabbing = true;
        }

        [ScriptMethod(195, Lifecycle.CommandScript)]
        public async Task tower3_ally_warn()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'full car coming up!'");
            Engine.cs_play_line("1040");
        }

        [ScriptMethod(196, Lifecycle.Dormant)]
        public async Task tower3_cortana_reminder_02()
        {
            await Engine.sleep_until(async () => Engine.device_group_get(elev_under_switch) > 0F, 30, 3600);
            if (Engine.device_group_get(elev_under_switch) == 0F)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'all right. let's see where this elevator goes...'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1050"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => Engine.device_group_get(elev_under_switch) > 0F, 30, 1800);
            if (Engine.device_group_get(elev_under_switch) == 0F)
            {
                Engine.activate_team_nav_point_object(_default, player, elev_under_switch_01.Entity, 0F);
                await Engine.sleep_until(async () => Engine.device_group_get(elev_under_switch) > 0F);
                Engine.deactivate_team_nav_point_object(player, elev_under_switch_01.Entity);
            }
        }

        [ScriptMethod(197, Lifecycle.Dormant)]
        public async Task elev_under_cortana_comment()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(180);
            Engine.print("cortana: 'i've intercepted a secure transmission from regret's carrier...'");
            Engine.print("'...to something called high charity. it's seems to be a formal apology - '");
            Engine.print("'to the prophets of truth and mercy.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2120"));
            await Engine.sleep(15);
            Engine.print("cortana: 'apparently, regret jumped the gun when he attacked earth.'");
            Engine.print("'he's asking the other prophets to forgive his premature arrival...'");
            Engine.print("'...arguing that no human presence was foretold.");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2130"));
            Engine.print("cortana: 'that explains why there were so few ships in his fleet.'");
            Engine.print("'but it's odd a prophet would have such bad intel about his enemy's home-world.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2140"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(198, Lifecycle.CommandScript)]
        public async Task elev_under_ally_01()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'hey, my ears just popped!'");
            Engine.cs_play_line("1060");
        }

        [ScriptMethod(199, Lifecycle.CommandScript)]
        public async Task elev_under_ally_02()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'uh, just exactly how deep are we?'");
            Engine.cs_play_line("1070");
        }

        [ScriptMethod(200, Lifecycle.CommandScript)]
        public async Task elev_under_ally_03()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'you think that glass is bulletproof?'");
            Engine.cs_play_line("1080");
        }

        [ScriptMethod(201, Lifecycle.Dormant)]
        public async Task tower3_sleeper_spawn()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower3_upstairs, Engine.players()) == true);
            Engine.ai_place(tower3_sleeper.Squad, 1);
        }

        [ScriptMethod(202, Lifecycle.Dormant)]
        public async Task elev_under_monitor()
        {
            await Engine.sleep_until(async () => Engine.device_group_get(elev_under_switch) > 0F);
            Engine.device_set_power(elev_under_switch_01.Entity, 0F);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_inside_elev_under, Engine.players()) == true && await this.player_count() > 0);
            Engine.device_set_position_track(elev_under.Entity, "transition_1to2", 0F);
            Engine.device_animate_position(elev_under.Entity, 0.103F, 10F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) == 0.103F);
            if (Engine.volume_test_object(vol_elev_shaft_under, await this.player0()) == false && await this.player_count() > 0)
            {
                Engine.object_teleport(await this.player0(), _1to2_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player0(), "");
            }

            if (Engine.volume_test_object(vol_elev_shaft_under, await this.player1()) == false && await this.player_count() > 0 && (bool)Engine.game_is_cooperative() == true)
            {
                Engine.object_teleport(await this.player1(), _1to2_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player1(), "");
            }

            Engine.switch_bsp(3);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 3);
            Engine.game_can_use_flashlights(true);
            Engine.device_animate_position(elev_under.Entity, 1F, 60F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.122F, 1);
            Engine.effect_new(this.splashy, splash_01);
            Engine.effect_new(this.splashy, splash_02);
            Engine.effect_new(this.splashy, splash_03);
            Engine.effect_new(this.splashy, splash_04);
            Engine.effect_new(this.splashy, splash_05);
            Engine.effect_new(this.splashy, splash_06);
            Engine.effect_new(this.splashy, splash_07);
            Engine.effect_new(this.splashy, splash_08);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244879228U), default(IGameObject), 1F);
            Engine.object_destroy(water_1to2a.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.128F, 1);
            Engine.object_create_anew(water_1to2a);
            Engine.kill_volume_enable(kill_no_riders_under);
            Engine.wake(new ScriptMethodReference(music_05b_05_start));
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(elev_under_cortana_comment));
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 4));
                }

                await Engine.sleep(5);
                return Engine.device_get_position(elev_under.Entity) > 0.5F;
            });
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.6F);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.866F, 1);
            Engine.effect_new(this.splashy, splash_09);
            Engine.effect_new(this.splashy, splash_10);
            Engine.effect_new(this.splashy, splash_11);
            Engine.effect_new(this.splashy, splash_12);
            Engine.effect_new(this.splashy, splash_13);
            Engine.effect_new(this.splashy, splash_14);
            Engine.effect_new(this.splashy, splash_15);
            Engine.effect_new(this.splashy, splash_16);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245010302U), default(IGameObject), 1F);
            Engine.object_destroy(water_1to2b.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) > 0.874F, 1);
            Engine.object_create_anew(water_1to2b);
            Engine.kill_volume_disable(kill_no_riders_under);
        }

        [ScriptMethod(203, Lifecycle.Dormant)]
        public async Task tower3_start()
        {
            Engine.ai_disposable(gondola_01_enemies, true);
            Engine.data_mine_set_mission_segment("05b_6_tower3");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            Engine.objects_attach(elev_under.Entity, "switch", elev_under_switch_01.Entity, "");
            Engine.device_group_change_only_once_more_set(elev_under_switch, true);
            await this.godownfast();
            Engine.wake(new ScriptMethodReference(tower3_sleeper_spawn));
            Engine.wake(new ScriptMethodReference(objective_gondola1_clear));
            Engine.wake(new ScriptMethodReference(objective_sunken_set));
            Engine.ai_place(tower3_jackals_01.Squad, 4);
            Engine.sleep_forever(new ScriptMethodReference(tower3_turret_reman));
            Engine.cs_run_command_script(tower3_turrets.Squad, new ScriptMethodReference(abort));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower3_mid, Engine.players()) == true || (short)Engine.ai_living_count(tower3_main) < 2);
            Engine.game_save();
            Engine.ai_place(tower3_jackals_02.Squad, (short)(4 - (float)Engine.ai_living_count(tower3_jackals_01.Squad)));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower3_main) < 2, 30, 3600);
            Engine.game_save();
            if (Engine.volume_test_objects(vol_tower3_upstairs, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_place(tower3_buggers_01.Squad, 3);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower3_main) < 2, 30, 3600);
            Engine.game_save();
            if (Engine.volume_test_objects(vol_tower3_upstairs, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_place(tower3_buggers_02.Squad, (short)(3 - (float)Engine.ai_living_count(tower3_buggers_01.Squad)));
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower3_main) <= 0, 30, 3600);
            Engine.wake(new ScriptMethodReference(tower3_cortana_comment));
            if ((short)Engine.ai_living_count(all_allies) < 2)
            {
                Engine.wake(new ScriptMethodReference(tower3_pelican_arrives));
            }

            await Engine.sleep_until(async () => this.tower3_done_blabbing == true);
            Engine.ai_place(tower3_jackals_elev.Squad, 3);
            await Engine.sleep(30);
            Engine.game_save();
            await this.nowcomeup();
            Engine.kill_volume_disable(kill_no_riders_under);
            await Engine.sleep(150);
            Engine.ai_scene("tower3_ally_scene", new ScriptMethodReference(tower3_ally_warn), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) == 0F);
            Engine.ai_set_orders(tower3_jackals_elev.Squad, tower3_int_elev_ridge);
            Engine.wake(new ScriptMethodReference(tower3_cortana_reminder_02));
            Engine.wake(new ScriptMethodReference(elev_under_monitor));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tower3_main) <= 0 || Engine.volume_test_objects_all(vol_inside_elev_under, Engine.players()) == true && await this.player_count() > 0);
            Engine.ai_set_orders(all_allies, tower3_on_elev);
        }

        [ScriptMethod(204, Lifecycle.Dormant)]
        public async Task tunnel_01_cortana_comment()
        {
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", tunnel_01_enemies) == true || Engine.volume_test_objects(vol_sunken_chamber_entry, Engine.players()) == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_sunken_chamber_entry, Engine.players()) == true, 30, 300);
            if (Engine.volume_test_objects(vol_sunken_chamber_entry, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'out there...look! more ruins!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1090"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(205, Lifecycle.Dormant)]
        public async Task sunken_tunnel1_start()
        {
            Engine.ai_disposable(tower3_enemies, true);
            Engine.data_mine_set_mission_segment("05b_7_tunnel1");
            Engine.ai_renew(all_allies);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_under.Entity) == 1F);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, tunnel_01_suppress);
            Engine.ai_place(tunnel_01_grunts_patrol.Squad, 2);
            Engine.ai_place(tunnel_01_grunts_01.Squad, 3);
            Engine.ai_place(tunnel_01_grunts_02.Squad, 2);
            Engine.wake(new ScriptMethodReference(music_05b_06_start));
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(tunnel_01_enemies) > this.ai_combat_status_idle || Engine.volume_test_objects(vol_tunnel_01_mid, Engine.players()) == true);
            await Engine.sleep(60);
            Engine.ai_set_orders(all_allies, tunnel_01_allies);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01_mid, Engine.players()) == true || (short)Engine.ai_living_count(tunnel_01_enemies) < 5);
            Engine.game_save();
            Engine.ai_place(tunnel_01_grunts_03.Squad, (short)(3 - (float)Engine.ai_living_count(tunnel_01_grunts_01.Squad)));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(tunnel_01_enemies) <= 0 || Engine.volume_test_objects(vol_sunken_chamber_entry, Engine.players()) == true, 30, 1800);
            Engine.game_save();
        }

        [ScriptMethod(206, Lifecycle.Dormant)]
        public async Task sunken_holo_cortana_comment()
        {
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), regret02.Entity) < 10F && Engine.objects_can_see_object(Engine.players(), regret02.Entity, 30F) && Engine.volume_test_objects(vol_sunk_chamber_right, Engine.players()) == true);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'and people say i've got a big head...'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1100"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(207, Lifecycle.CommandScript)]
        public async Task sunken_holo_ally_react()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'oh, man. he is so dead!'");
            Engine.cs_play_line("1110");
        }

        [ScriptMethod(208, Lifecycle.Dormant)]
        public async Task sunken_holo_looper()
        {
            Engine.object_create_anew(sunken_throne);
            Engine.object_create_anew(regret02);
            Engine.objects_attach(sunken_throne.Entity, "driver", regret02.Entity, "");
            Engine.ai_disregard(regret02.Entity, true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant1a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3000"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant2b", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3001"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant2c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3002"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant3a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3003"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant3c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3004"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant5a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3005"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.sunken_holo_trans == false)
                    {
                        this.sunken_holo_chant = true;
                        Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant6a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "3006"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.sunken_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(209, Lifecycle.Dormant)]
        public async Task sunken_holo_translate()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(sunken_chamber_enemies) <= 0);
            await Engine.sleep(150);
            this.sunken_holo_trans = true;
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), regret02.Entity) < 10F && this.sunken_holo_chant == false);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("regret: 'most of those we encountered on our search were compelled...'");
            Engine.print("regret: '...to join our union - to take part in a movement that promised...'");
            Engine.print("regret: '...freedom for allegiance! salvation for service!'");
            Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_l05_0140_por", true);
            await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "0140"));
            await Engine.sleep(30);
            Engine.print("'but some, like the humans, chose to impede our progress -'");
            Engine.print("'block our access to sacred sites, damage holy relics! for their...'");
            Engine.print("'...transgressions the humans shall be hunted until none remain alive!'");
            Engine.custom_animation(regret02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_l05_0150_por", true);
            await Engine.sleep(Engine.ai_play_line_on_object(regret02.Entity, "0150"));
            await Engine.sleep(60);
            Engine.ai_scene("sunken_holo_ally_scene", new ScriptMethodReference(sunken_holo_ally_react), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep((short)Engine.random_range(240, 480));
            this.sunken_holo_trans = false;
        }

        [ScriptMethod(210, Lifecycle.Dormant)]
        public async Task sunken_chamber_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'keep moving. let's find our way back to the surface.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1120"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(211, Lifecycle.Dormant)]
        public async Task hide_rightside_guys()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(sunk_chamber_right_enemies) > this.ai_combat_status_idle);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_sunk_chamber_left, Engine.players()) == true && await this.player_count() > 0 && (short)Engine.ai_living_count(sunken_rightside_nonsnipers) > 0);
                Engine.ai_set_orders(sunken_rightside_nonsnipers, sunken_rightside_hide);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 0));
                }

                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 1), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 1)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 1));
                }

                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 2), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 2)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(sunken_rightside_nonsnipers), 2));
                }

                return Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == true;
            });
        }

        [ScriptMethod(212, Lifecycle.Dormant)]
        public async Task hide_leftside_guys()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(sunk_chamber_left_enemies) > this.ai_combat_status_idle);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_sunk_chamber_right, Engine.players()) == true && await this.player_count() > 0 && (short)Engine.ai_living_count(sunken_leftside_nonsnipers) > 0);
                Engine.ai_set_orders(sunken_leftside_nonsnipers, sunken_leftside_hide);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 0)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 0));
                }

                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 1), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 1)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 1));
                }

                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 2), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 2)) > 10F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(sunken_leftside_nonsnipers), 2));
                }

                return Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == true;
            });
        }

        [ScriptMethod(213, Lifecycle.CommandScript)]
        public async Task sunken_hologram_focus()
        {
            Engine.cs_abort_on_alert(true);
            Engine.cs_face_object(true, regret02.Entity);
            Engine.cs_pause(-1F);
        }

        [ScriptMethod(214, Lifecycle.Static)]
        public async Task sunken_try_reinforce_r()
        {
            if (Engine.device_get_position(sunk_chmbr_spwn_r1a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_r1b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r1a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r1b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_jack_R_01.Squad, (short)(this.sunken_jacks_total - (float)Engine.ai_living_count(sunken_jacks_right)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_hg_R_01.Squad, (short)(this.sunken_hg_total - (float)Engine.ai_living_count(sunken_hg_right)));
                }
            }

            if (Engine.device_get_position(sunk_chmbr_spwn_r2a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_r2b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r2a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r2b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_jack_R_02.Squad, (short)(this.sunken_jacks_total - (float)Engine.ai_living_count(sunken_jacks_right)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_hg_R_02.Squad, (short)(this.sunken_hg_total - (float)Engine.ai_living_count(sunken_hg_right)));
                }
            }
        }

        [ScriptMethod(215, Lifecycle.Static)]
        public async Task sunken_try_reinforce_l()
        {
            if (Engine.device_get_position(sunk_chmbr_spwn_l1a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_l1b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l1a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l1b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_jack_L_01.Squad, (short)(this.sunken_jacks_total - (float)Engine.ai_living_count(sunken_jacks_left)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_hg_L_01.Squad, (short)(this.sunken_hg_total - (float)Engine.ai_living_count(sunken_hg_left)));
                }
            }

            if (Engine.device_get_position(sunk_chmbr_spwn_l2a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_l2b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l2a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l2b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_jack_L_02.Squad, (short)(this.sunken_jacks_total - (float)Engine.ai_living_count(sunken_jacks_left)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_hg_L_02.Squad, (short)(this.sunken_hg_total - (float)Engine.ai_living_count(sunken_hg_left)));
                }
            }
        }

        [ScriptMethod(216, Lifecycle.Static)]
        public async Task sunken_try_js_r1()
        {
            if (Engine.device_get_position(sunk_chmbr_spwn_r1a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_r1b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r1a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r1b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_js_R_01.Squad, (short)(this.sunken_sniper_total - (float)Engine.ai_living_count(sunken_rightside_snipers)));
                }
            }
        }

        [ScriptMethod(217, Lifecycle.Static)]
        public async Task sunken_try_js_r2()
        {
            if (Engine.device_get_position(sunk_chmbr_spwn_r2a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_r2b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r2a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_r2b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_js_R_02.Squad, (short)(this.sunken_sniper_total - (float)Engine.ai_living_count(sunken_rightside_snipers)));
                }
            }
        }

        [ScriptMethod(218, Lifecycle.Static)]
        public async Task sunken_try_js_l1()
        {
            if (Engine.device_get_position(sunk_chmbr_spwn_l1a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_l1b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l1a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l1b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_js_L_01.Squad, (short)(this.sunken_sniper_total - (float)Engine.ai_living_count(sunken_leftside_snipers)));
                }
            }
        }

        [ScriptMethod(219, Lifecycle.Static)]
        public async Task sunken_try_js_l2()
        {
            if (Engine.device_get_position(sunk_chmbr_spwn_l2a.Entity) == 0F && Engine.device_get_position(sunk_chmbr_spwn_l2b.Entity) == 0F && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l2a, Engine.players()) == false && Engine.volume_test_objects(vol_sunk_chmbr_spwn_l2b, Engine.players()) == false && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_js_L_02.Squad, (short)(this.sunken_sniper_total - (float)Engine.ai_living_count(sunken_leftside_snipers)));
                }
            }
        }

        [ScriptMethod(220, Lifecycle.Dormant)]
        public async Task sunk_chamber_hunters_enter()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(sunken_chamber_enemies) > this.ai_combat_status_idle || Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.device_operates_automatically_set(sunk_chamber_hunter_door.Entity, true);
                Engine.ai_place(sunk_chamber_hunters.Squad, 2);
            }
        }

        [ScriptMethod(221, Lifecycle.Dormant)]
        public async Task sunken_chamber_saves()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save() && this.sunken_save_again == true);
                Engine.game_save_immediate();
                this.sunken_save_again = false;
                return Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == true;
            });
        }

        [ScriptMethod(222, Lifecycle.Dormant)]
        public async Task sunken_chamber_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_sunken_chamber_entry, Engine.players()) == true);
            Engine.ai_disposable(tunnel_01_enemies, true);
            Engine.data_mine_set_mission_segment("05b_8_sunken_chamber");
            Engine.ai_renew(all_allies);
            Engine.game_save();
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

            Engine.ai_place(sunk_chamber_init_js_L01.Squad, 1);
            Engine.ai_place(sunk_chamber_init_js_L02.Squad, 1);
            Engine.ai_place(sunk_chamber_init_js_R01.Squad, 1);
            Engine.cs_run_command_script(sunk_chamber_init_js_R01.Squad, new ScriptMethodReference(sunken_hologram_focus));
            Engine.ai_place(sunk_chamber_init_js_R02.Squad, 1);
            Engine.cs_run_command_script(sunk_chamber_init_js_R02.Squad, new ScriptMethodReference(sunken_hologram_focus));
            Engine.ai_place(sunk_chamber_init_hg_Ra.Squad, 1);
            Engine.ai_place(sunk_chamber_init_hg_La.Squad, 1);
            Engine.wake(new ScriptMethodReference(sunken_holo_looper));
            Engine.wake(new ScriptMethodReference(sunken_holo_cortana_comment));
            Engine.wake(new ScriptMethodReference(hide_rightside_guys));
            Engine.wake(new ScriptMethodReference(hide_leftside_guys));
            Engine.wake(new ScriptMethodReference(sunken_chamber_saves));
            Engine.ai_set_orders(all_allies, sunken_chamber_allies);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_sunk_chamber_near_01, Engine.players()) == true || (short)Engine.ai_combat_status(sunken_chamber_enemies) > this.ai_combat_status_uninspected);
            this.sunken_save_again = true;
            Engine.wake(new ScriptMethodReference(music_05b_06_stop));
            if (Engine.volume_test_objects_all(vol_sunk_chamber_left, Engine.players()) == true && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_L_01.Squad, 4);
                }

                await this.sunken_try_js_r1();
            }

            if (Engine.volume_test_objects_all(vol_sunk_chamber_right, Engine.players()) == true && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_R_01.Squad, 4);
                }

                await this.sunken_try_js_l1();
            }

            if (Engine.volume_test_objects(vol_sunk_chamber_right, Engine.players()) == true && Engine.volume_test_objects(vol_sunk_chamber_left, Engine.players()) == true)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_R_01.Squad, 2);
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_L_01.Squad, 2);
                }

                await this.sunken_try_js_r1();
                await this.sunken_try_js_l1();
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_sunk_chamber_near_02, Engine.players()) == true);
            this.sunken_save_again = true;
            if (Engine.volume_test_objects_all(vol_sunk_chamber_left, Engine.players()) == true && await this.player_count() > 0)
            {
                await this.sunken_try_reinforce_l();
                await this.sunken_try_js_r1();
            }

            if (Engine.volume_test_objects_all(vol_sunk_chamber_right, Engine.players()) == true && await this.player_count() > 0)
            {
                await this.sunken_try_reinforce_r();
                await this.sunken_try_js_l1();
            }

            if (Engine.volume_test_objects(vol_sunk_chamber_right, Engine.players()) == true && Engine.volume_test_objects(vol_sunk_chamber_left, Engine.players()) == true)
            {
                await this.sunken_try_reinforce_r();
                await this.sunken_try_reinforce_l();
                await this.sunken_try_js_r1();
                await this.sunken_try_js_l1();
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_sunk_chamber_far_01, Engine.players()) == true);
            this.sunken_save_again = true;
            Engine.wake(new ScriptMethodReference(sunk_chamber_hunters_enter));
            if (Engine.volume_test_objects_all(vol_sunk_chamber_left, Engine.players()) == true && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_L_02.Squad, (short)(4 - (float)Engine.ai_living_count(sunken_bugs)));
                }

                await this.sunken_try_js_r2();
            }

            if (Engine.volume_test_objects_all(vol_sunk_chamber_right, Engine.players()) == true && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_R_02.Squad, (short)(4 - (float)Engine.ai_living_count(sunken_bugs)));
                }

                await this.sunken_try_js_l2();
            }

            if (Engine.volume_test_objects(vol_sunk_chamber_right, Engine.players()) == true && Engine.volume_test_objects(vol_sunk_chamber_left, Engine.players()) == true)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_R_02.Squad, (short)(2 - (float)Engine.ai_living_count(sunk_chamber_bugs_R_01.Squad)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_bugs_L_02.Squad, (short)(2 - (float)Engine.ai_living_count(sunk_chamber_bugs_L_01.Squad)));
                }

                await this.sunken_try_js_l2();
                await this.sunken_try_js_r2();
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_sunk_chamber_far_02, Engine.players()) == true);
            this.sunken_save_again = true;
            Engine.wake(new ScriptMethodReference(sunken_chamber_reminder));
            Engine.device_operates_automatically_set(sunk_chamber_exit_r.Entity, true);
            Engine.device_operates_automatically_set(sunk_chamber_exit_l.Entity, true);
            if (Engine.volume_test_objects_all(vol_sunk_chamber_left, Engine.players()) == true && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_j01_L.Squad, (short)(2 - (float)Engine.ai_living_count(sunken_jacks_left)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_e_L.Squad, (short)Engine.max(1F, 2F - (float)Engine.ai_living_count(sunken_hg_left)));
                }
            }

            if (Engine.volume_test_objects_all(vol_sunk_chamber_right, Engine.players()) == true && await this.player_count() > 0)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_j01_R.Squad, (short)(2 - (float)Engine.ai_living_count(sunken_jacks_right)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_e_R.Squad, (short)Engine.max(1F, 2F - (float)Engine.ai_living_count(sunken_hg_right)));
                }
            }

            if (Engine.volume_test_objects(vol_sunk_chamber_right, Engine.players()) == true && Engine.volume_test_objects(vol_sunk_chamber_left, Engine.players()) == true)
            {
                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_j01_L.Squad, (short)(2 - (float)Engine.ai_living_count(sunken_jacks_left)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_j01_R.Squad, (short)(2 - (float)Engine.ai_living_count(sunken_jacks_right)));
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_e_L.Squad, 1);
                }

                if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
                {
                    Engine.ai_place(sunk_chamber_exit_e_R.Squad, 1);
                }
            }

            if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
            {
                Engine.ai_place(sunk_chamber_exit_j02_R.Squad, 2);
            }

            if ((short)Engine.ai_living_count(sunken_chamber_enemies) < 8)
            {
                Engine.ai_place(sunk_chamber_exit_j02_L.Squad, 2);
            }

            Engine.wake(new ScriptMethodReference(sunken_holo_translate));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_sunken_chamber, Engine.players()) == true);
            this.sunken_save_again = true;
            Engine.ai_set_orders(all_allies, tunnel_02_allies);
        }

        [ScriptMethod(223, Lifecycle.Dormant)]
        public async Task elev_up_cortana_comment()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(180);
            Engine.print("cortana: 'regret's carrier just received a response from high charity.'");
            Engine.print("'a very well-encrypted message from the prophet of truth.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2150"));
            await Engine.sleep(15);
            Engine.print("cortana: 'listen to this: your haste has jeopardized the fulfillment of our covenant -'");
            Engine.print("'threatened our grand design. that you shall be spared a public display of our contempt...'");
            Engine.print("'...is thanks only to mercy and his wise counsel.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2160"));
            Engine.print("cortana: 'truth, mercy, regret. three prophet hierarchs.'");
            Engine.print("'killing regret should shake-up the covenant leadership, but, frankly'");
            Engine.print("'it sounds like you might be doing truth a favor.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "2170"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(224, Lifecycle.Dormant)]
        public async Task elev_up_monitor()
        {
            await Engine.sleep_until(async () => Engine.device_group_get(elev_up_switch) > 0F);
            Engine.device_set_power(elev_up_switch_01.Entity, 0F);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_inside_elev_up, Engine.players()) == true && await this.player_count() > 0);
            Engine.device_animate_position(elev_up.Entity, 0.103F, 10F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) == 0.103F);
            if (Engine.volume_test_object(vol_elev_shaft_up, await this.player0()) == false && await this.player_count() > 0)
            {
                Engine.object_teleport(await this.player0(), _2to3_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player0(), "");
            }

            if (Engine.volume_test_object(vol_elev_shaft_up, await this.player1()) == false && await this.player_count() > 0 && (bool)Engine.game_is_cooperative() == true)
            {
                Engine.object_teleport(await this.player1(), _2to3_teleport);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 2228560515U), await this.player1(), "");
            }

            Engine.switch_bsp(4);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 4);
            Engine.device_animate_position(elev_up.Entity, 1F, 60F, 1F, 1F, false);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.134F, 1);
            Engine.effect_new(this.splashy, splash_17);
            Engine.effect_new(this.splashy, splash_18);
            Engine.effect_new(this.splashy, splash_19);
            Engine.effect_new(this.splashy, splash_20);
            Engine.effect_new(this.splashy, splash_21);
            Engine.effect_new(this.splashy, splash_22);
            Engine.effect_new(this.splashy, splash_23);
            Engine.effect_new(this.splashy, splash_24);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_impact_water", 2244879228U), default(IGameObject), 1F);
            Engine.object_destroy(water_2to3a.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.143F, 1);
            Engine.object_create_anew(water_2to3a);
            Engine.kill_volume_enable(kill_no_riders_up);
            Engine.wake(new ScriptMethodReference(music_05b_08_start));
            await Engine.sleep(60);
            Engine.wake(new ScriptMethodReference(elev_up_cortana_comment));
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 3)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
                }

                await Engine.sleep(5);
                if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 4)) > 5F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 4));
                }

                await Engine.sleep(5);
                return Engine.device_get_position(elev_up.Entity) > 0.7F;
            });
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.889F, 1);
            Engine.effect_new(this.splashy, splash_25);
            Engine.effect_new(this.splashy, splash_26);
            Engine.effect_new(this.splashy, splash_27);
            Engine.effect_new(this.splashy, splash_28);
            Engine.effect_new(this.splashy, splash_29);
            Engine.effect_new(this.splashy, splash_30);
            Engine.effect_new(this.splashy, splash_31);
            Engine.effect_new(this.splashy, splash_32);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\device_machines\\delta_sub\\sub_water_in_out\\sub_out_of_water", 2245010302U), default(IGameObject), 1F);
            Engine.object_destroy(water_2to3b.Entity);
            await this.cam_shake();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_up.Entity) > 0.896F, 1);
            Engine.object_create_anew(water_2to3b);
            Engine.kill_volume_disable(kill_no_riders_up);
        }

        [ScriptMethod(225, Lifecycle.Dormant)]
        public async Task sunken_tunnel2_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_02_entry, Engine.players()) == true);
            Engine.ai_disposable(sunken_chamber_enemies, true);
            Engine.data_mine_set_mission_segment("05b_9_tunnel2");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            Engine.objects_attach(elev_up.Entity, "switch", elev_up_switch_01.Entity, "");
            Engine.device_group_change_only_once_more_set(elev_up_switch, true);
            await this.sub2doors();
            Engine.wake(new ScriptMethodReference(elev_up_monitor));
            Engine.ai_place(tunnel_02_elites_01.Squad, 1);
            Engine.ai_place(tunnel_02_elites_02.Squad, 1);
            Engine.ai_set_active_camo(tunnel_02_elites_01.Squad, true);
            Engine.ai_set_active_camo(tunnel_02_elites_02.Squad, true);
            Engine.ai_set_orders(all_allies, tunnel_02_suppress);
            Engine.wake(new ScriptMethodReference(music_05b_07_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_02_mid_01, Engine.players()) == true || (short)Engine.ai_combat_status(tunnel_02_enemies) > this.ai_combat_status_idle || (short)Engine.ai_living_count(tunnel_02_enemies) < 1);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, tunnel_02_allies);
            Engine.ai_place(tunnel_02_elites_04.Squad, (short)(1 - (float)Engine.ai_living_count(tunnel_02_elites_01.Squad) + (float)Engine.ai_living_count(tunnel_02_elites_02.Squad)));
            Engine.ai_set_active_camo(tunnel_02_elites_04.Squad, true);
            Engine.ai_place(tunnel_02_grunts.Squad, 3);
            Engine.ai_set_active_camo(tunnel_02_grunts.Squad, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_02_mid_02, Engine.players()) == true || (short)Engine.ai_living_count(tunnel_02_enemies) < 1);
            Engine.game_save();
            Engine.ai_place(tunnel_02_elites_03.Squad, 1);
            Engine.ai_set_active_camo(tunnel_02_elites_03.Squad, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_elev_up_dock, Engine.players()) == true);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, tunnel_02_on_elev);
        }

        [ScriptMethod(226, Lifecycle.Dormant)]
        public async Task island_holo_looper()
        {
            Engine.object_create_anew(island_throne);
            Engine.object_create_anew(regret03);
            Engine.objects_attach(island_throne.Entity, "driver", regret03.Entity, "");
            Engine.ai_disregard(regret03.Entity, true);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant1a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3000"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant2b", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3001"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant2c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3002"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant3a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3003"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant3c", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3004"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant5a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3005"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                }, 
                    async () =>
                {
                    if (this.island_holo_trans == false)
                    {
                        this.island_holo_chant = true;
                        Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_chant6a", true);
                        await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "3006"));
                        await Engine.sleep((short)Engine.random_range(240, 480));
                        this.island_holo_chant = false;
                    }
                });
                return false;
            });
        }

        [ScriptMethod(227, Lifecycle.Dormant)]
        public async Task island_int_translate()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_02, Engine.players()) == true && (short)Engine.ai_living_count(island_int_enemies) <= 0);
            await Engine.sleep(150);
            this.island_holo_trans = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_02, Engine.players()) == true && this.island_holo_chant == false);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("regret: 'every member of the covenant shall walk the path!'");
            Engine.print("'none will be left behind when our great journey begins!'");
            Engine.print("'that is the prophets' age-old promise! and it shall be fulfilled!'");
            Engine.custom_animation(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "regret_l05_0160_por", true);
            await Engine.sleep(Engine.ai_play_line_on_object(regret03.Entity, "0160"));
            await Engine.sleep(30);
            Engine.print("cortana: 'great journey? doesn't he know what these rings do?'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1130"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep((short)Engine.random_range(240, 480));
            this.island_holo_trans = false;
        }

        [ScriptMethod(228, Lifecycle.Dormant)]
        public async Task island_interior_start()
        {
            Engine.ai_disposable(tunnel_02_enemies, true);
            Engine.game_can_use_flashlights(false);
            Engine.wake(new ScriptMethodReference(objective_sunken_clear));
            Engine.wake(new ScriptMethodReference(objective_temple_set));
            Engine.objects_attach(gondola_02_a.Entity, "control_front", gondola_02_switch_front.Entity, "");
            Engine.objects_attach(gondola_02_b.Entity, "control_front", gondola_02_b_fake.Entity, "");
            Engine.device_group_change_only_once_more_set(gondola_02_switch, true);
            Engine.wake(new ScriptMethodReference(island_holo_looper));
            Engine.data_mine_set_mission_segment("05b_10_island_interior");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, island_int_allies);
            Engine.ai_place(island_int_grunts.Squad, 4);
            await Engine.sleep(1);
            Engine.ai_place(island_int_hg.Squad, 2);
            Engine.wake(new ScriptMethodReference(island_int_translate));
        }

        [ScriptMethod(229, Lifecycle.Dormant)]
        public async Task island_pelican_comment()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("pelican pilot: 'this is my last run, chief. i'm nearly out of fuel.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1140"));
            await Engine.sleep(30);
            Engine.print("'we've secured the first tower cluster, so i'll set down there.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1150"));
            await Engine.sleep(30);
            Engine.print("'call when you're ready for evac.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1160"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.game_save();
        }

        [ScriptMethod(230, Lifecycle.CommandScript)]
        public async Task island_pelican_path()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/pel0"), 2F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/pel1"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/p2"), 5F);
            Engine.cs_vehicle_speed(0.5F);
            this.island_pelican_arrived = true;
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("island_airspace/p5"), 2F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("island_airspace/p6"), Engine.GetReference<ISpatialPoint>("island_airspace/p4"), 2F);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_p");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(island_pelican.Squad) < 4);
            await Engine.sleep(60);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("island_airspace/p5"), Engine.GetReference<ISpatialPoint>("island_airspace/p3"), 10F);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("island_airspace/p5"), Engine.GetReference<ISpatialPoint>("island_airspace/pel2"), 1F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/pel2"), 2F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/pel6"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("island_airspace/pelx"), 20F);
            Engine.ai_erase(island_pelican.Squad);
        }

        [ScriptMethod(231, Lifecycle.Dormant)]
        public async Task island_pelican_arrives()
        {
            Engine.ai_place(island_pelican_allies.Squad, (short)(2 - (float)Engine.ai_living_count(allies_infantry)));
            Engine.ai_place(island_pelican.Squad);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_p", Engine.ai_actors(island_pelican_allies.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(island_pelican.pilot), true);
            Engine.object_create_anew(rack2);
            Engine.objects_attach(Engine.ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_sc_01", rack2.Entity, "pin");
            Engine.object_create_anew(bomb07);
            Engine.objects_attach(rack2.Entity, "rack01", bomb07.Entity, "pin");
            Engine.object_create_anew(bomb08);
            Engine.objects_attach(rack2.Entity, "rack02", bomb08.Entity, "pin");
            Engine.object_create_anew(bomb09);
            Engine.objects_attach(rack2.Entity, "rack03", bomb09.Entity, "pin");
            Engine.object_create_anew(bomb10);
            Engine.objects_attach(rack2.Entity, "rack04", bomb10.Entity, "pin");
            Engine.object_create_anew(bomb11);
            Engine.objects_attach(rack2.Entity, "rack05", bomb11.Entity, "pin");
            Engine.object_create_anew(bomb12);
            Engine.objects_attach(rack2.Entity, "rack06", bomb12.Entity, "pin");
            Engine.cs_run_command_script(island_pelican.pilot, new ScriptMethodReference(island_pelican_path));
            await Engine.sleep(150);
            Engine.wake(new ScriptMethodReference(island_pelican_comment));
            await Engine.sleep_until(async () => this.island_pelican_arrived == true);
            await Engine.sleep(120);
            Engine.begin_random(async () => Engine.objects_detach(rack2.Entity, bomb07.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb08.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb09.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb10.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb11.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb12.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)));
        }

        [ScriptMethod(232, Lifecycle.Static)]
        public async Task short_island_pel()
        {
            Engine.ai_place(island_pelican_allies.Squad, (short)(2 - (float)Engine.ai_living_count(allies_infantry)));
            Engine.ai_place(island_pelican.Squad);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_p", Engine.ai_actors(island_pelican_allies.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(island_pelican.pilot), true);
            Engine.object_create_anew(rack2);
            Engine.objects_attach(Engine.ai_vehicle_get_from_starting_location(island_pelican.pilot), "pelican_sc_01", rack2.Entity, "pin");
            Engine.object_create_anew(bomb07);
            Engine.objects_attach(rack2.Entity, "rack01", bomb07.Entity, "pin");
            Engine.object_create_anew(bomb08);
            Engine.objects_attach(rack2.Entity, "rack02", bomb08.Entity, "pin");
            Engine.object_create_anew(bomb09);
            Engine.objects_attach(rack2.Entity, "rack03", bomb09.Entity, "pin");
            Engine.object_create_anew(bomb10);
            Engine.objects_attach(rack2.Entity, "rack04", bomb10.Entity, "pin");
            Engine.object_create_anew(bomb11);
            Engine.objects_attach(rack2.Entity, "rack05", bomb11.Entity, "pin");
            Engine.object_create_anew(bomb12);
            Engine.objects_attach(rack2.Entity, "rack06", bomb12.Entity, "pin");
            Engine.cs_run_command_script(island_pelican.pilot, new ScriptMethodReference(island_pelican_path));
            await Engine.sleep(150);
            Engine.wake(new ScriptMethodReference(island_pelican_comment));
            await Engine.sleep_until(async () => this.island_pelican_arrived == true);
            await Engine.sleep(90);
            Engine.begin_random(async () => Engine.objects_detach(rack2.Entity, bomb07.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb08.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb09.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb10.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb11.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)), 
                async () => Engine.objects_detach(rack2.Entity, bomb12.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(2, 10)));
        }

        [ScriptMethod(233, Lifecycle.Dormant)]
        public async Task island_gully_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_exit, Engine.players()) == true);
            Engine.ai_disposable(island_int_enemies, true);
            Engine.data_mine_set_mission_segment("05b_11_island_gully");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, island_low_allies);
            Engine.ai_place(island_gully_buggers_01.Squad, 4);
            await Engine.sleep(1);
            Engine.ai_place(island_gully_elites_01.Squad, 2);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_gully_ridge, Engine.players()) == true || (short)Engine.ai_living_count(island_gully_enemies) < 3);
            Engine.game_save();
            Engine.ai_place(island_gully_jackals_01.Squad, (short)(3 - (float)Engine.ai_living_count(island_gully_buggers_01.Squad)));
            await Engine.sleep(1);
            Engine.ai_place(island_gully_elites_02.Squad, (short)(2 - (float)Engine.ai_living_count(island_gully_elites_01.Squad)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_ext_start, Engine.players()) == true || (short)Engine.ai_living_count(island_gully_enemies) <= 3);
            if (Engine.volume_test_objects(vol_island_ext_start, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.wake(new ScriptMethodReference(island_pelican_arrives));
            }
        }

        [ScriptMethod(234, Lifecycle.Dormant)]
        public async Task gondola_02_cortana_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_gondola_02, Engine.players()) == true, 30, 3600);
            if (Engine.volume_test_objects(vol_gondola_02, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }

            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), gondola_02_a.Entity, 30F) == true || Engine.volume_test_objects(vol_gondola_02, Engine.players()) == true);
            if (Engine.volume_test_objects(vol_gondola_02, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }
            else
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'there. another gondola. looks like it leads straight to the main-temple.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1170"));
                await Engine.sleep(30);
                Engine.print("'not much further now...'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1180"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }

            await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) > 0F, 30, 1800);
            if (Engine.device_get_position(gondola_02_a.Entity) > 0F)
            {
                Engine.activate_team_nav_point_object(_default, player, gondola_02_switch_front.Entity, 0F);
                await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) > 0F);
                Engine.deactivate_team_nav_point_object(player, gondola_02_switch_front.Entity);
            }
        }

        [ScriptMethod(235, Lifecycle.Dormant)]
        public async Task island_drop()
        {
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), true);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a01");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a02");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a03");
            await Engine.sleep(45);
            Engine.ai_set_orders(island_phantom_jackals.Squad, island_ext_07);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_b01");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_b02");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_b03");
            await Engine.sleep(45);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c01");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c02");
            await Engine.sleep(5);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c03");
            await Engine.sleep(60);
            Engine.ai_set_orders(island_phantom_elites.Squad, island_ext_06);
            Engine.ai_set_orders(island_phantom_grunts.Squad, island_ext_06);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), false);
        }

        [ScriptMethod(236, Lifecycle.CommandScript)]
        public async Task island_phantom_path()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/ph0"), 10F);
            Engine.cs_vehicle_boost(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/ph1"), 10F);
            Engine.cs_vehicle_speed(0.5F);
            if ((short)Engine.ai_living_count(island_all_enemies) < 8)
            {
                Engine.ai_place(island_phantom_elites.Squad, (short)(2 - (float)Engine.ai_living_count(island_ext_elites_01.Squad) + (float)Engine.ai_living_count(island_ext_elites_02.Squad)));
            }

            if ((short)Engine.ai_living_count(island_all_enemies) < 8)
            {
                Engine.ai_place(island_phantom_jackals.Squad, (short)(3 - (float)Engine.ai_living_count(island_ext_js_01.Squad) + (float)Engine.ai_living_count(island_ext_js_02.Squad) + (float)Engine.ai_living_count(island_ext_js_03.Squad) + (float)Engine.ai_living_count(island_ext_js_04.Squad)));
            }

            if ((short)Engine.ai_living_count(island_all_enemies) < 8)
            {
                Engine.ai_place(island_phantom_grunts.Squad, (short)(3 - (float)Engine.ai_living_count(island_ext_grunts_01.Squad) + (float)Engine.ai_living_count(island_ext_grunts_02.Squad)));
            }

            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_c", Engine.ai_actors(island_phantom_elites.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p_a", Engine.ai_actors(island_phantom_jackals.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), "phantom_p", Engine.ai_actors(island_phantom_grunts.Squad));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("island_airspace/ph2"), 5F);
            Engine.cs_vehicle_speed(0.25F);
            Engine.wake(new ScriptMethodReference(island_drop));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("island_airspace/ph2"), 2F);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(island_phantom.Squad) < 2);
            await Engine.sleep(60);
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("island_airspace/ph1"), Engine.GetReference<ISpatialPoint>("island_airspace/ph0"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/ph0"), 10F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("island_airspace/phx"), 20F);
            Engine.ai_erase(island_phantom.Squad);
        }

        [ScriptMethod(237, Lifecycle.Dormant)]
        public async Task island_phantom_arrives()
        {
            Engine.ai_place(island_phantom.Squad);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), true);
            Engine.cs_run_command_script(island_phantom.pilot, new ScriptMethodReference(island_phantom_path));
        }

        [ScriptMethod(238, Lifecycle.Static)]
        public async Task short_island_ph()
        {
            Engine.ai_allegiance(covenant, prophet);
            Engine.ai_place(island_phantom.Squad);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(island_phantom.pilot), true);
            Engine.cs_run_command_script(island_phantom.pilot, new ScriptMethodReference(island_phantom_path));
        }

        [ScriptMethod(239, Lifecycle.Dormant)]
        public async Task island_exterior_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_ext_start, Engine.players()) == true);
            Engine.ai_disposable(island_gully_enemies, true);
            Engine.data_mine_set_mission_segment("05b_12_island_exterior");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, island_ext_allies);
            Engine.ai_place(temple_ent_turrets.Squad, 2);
            if (await this.difficulty_legendary())
            {
                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_elites_01.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_elites_02.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_01.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_02.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_03.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_04.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_grunts_01.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_grunts_02.Squad, 1);
                }
            }

            if (await this.difficulty_heroic())
            {
                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_elites_01.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_elites_02.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_01.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_02.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_03.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_grunts_01.Squad, 2);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_grunts_02.Squad, 1);
                }
            }

            if (await this.difficulty_normal())
            {
                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_elites_01.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_01.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_js_03.Squad, 1);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_grunts_01.Squad, 2);
                }

                if ((short)Engine.ai_living_count(island_all_enemies) < 8)
                {
                    Engine.ai_place(island_ext_grunts_02.Squad, 2);
                }
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_ext_01, Engine.players()) == true || (short)Engine.ai_living_count(island_main_enemies) < 3);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(island_phantom_arrives));
            Engine.wake(new ScriptMethodReference(gondola_02_cortana_reminder));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_near_gondola_02, Engine.players()) == true);
            Engine.game_save();
            Engine.object_dynamic_simulation_disable(gondola_02_a.Entity, true);
            Engine.object_dynamic_simulation_disable(gondola_02_b.Entity, true);
            if ((short)Engine.ai_living_count(island_all_enemies) < 8)
            {
                Engine.ai_place(near_gondola_02_jackals.Squad, (short)(2 - (float)Engine.ai_living_count(island_phantom_jackals.Squad)));
            }

            if ((short)Engine.ai_living_count(island_all_enemies) < 8)
            {
                Engine.ai_place(near_gondola_02_grunts.Squad, (short)(3 - (float)Engine.ai_living_count(island_phantom_grunts.Squad)));
            }

            await Engine.sleep_until(async () => (short)Engine.ai_living_count(island_main_enemies) <= 0 || Engine.device_get_position(gondola_02_a.Entity) > 0F);
            Engine.game_save();
        }

        [ScriptMethod(240, Lifecycle.Dormant)]
        public async Task island_miranda_conversation()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("miranda: 'how's it going, you two?'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0170"));
            await Engine.sleep(30);
            Engine.print("cortana: 'so far, so good. we're nearing the main-temple now.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0180"));
            await Engine.sleep(30);
            Engine.print("miranda: 'roger that. i'm as close to the library as i can get.'");
            Engine.print("'there's some sort of barrier...we're trying to find a way around it.'");
            Engine.print("'i'll keep you posted.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0190"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(music_05b_09_start));
            await Engine.sleep(90);
            Engine.ai_set_blind(gondola_02_banshees.Squad, false);
        }

        [ScriptMethod(241, Lifecycle.CommandScript)]
        public async Task gondola_02_ally_comment()
        {
            Engine.cs_switch("ally01");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'great. we gotta ride another one of these death-traps?'");
            Engine.cs_play_line("1190");
            Engine.cs_switch("ally02");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'if you forget about the covenant and the fact that we're stuck...'");
            Engine.print("'...on a freaky alien world�it's actually kinda fun.'");
            Engine.cs_play_line("1200");
        }

        [ScriptMethod(242, Lifecycle.CommandScript)]
        public async Task temple_ent_turret_01()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets._1));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(243, Lifecycle.CommandScript)]
        public async Task temple_ent_turret_02()
        {
            Engine.cs_force_combat_status(4);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(temple_ent_turrets._2));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(244, Lifecycle.CommandScript)]
        public async Task banshee_retreat()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_banshee_retreat, Engine.ai_actors(gondola_02_banshees.Squad)) == true, 30, 4000);
            Engine.ai_erase(gondola_02_banshees.Squad);
        }

        [ScriptMethod(245, Lifecycle.Dormant)]
        public async Task gondola_02_nuke()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(island_all_enemies), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(island_all_enemies), 0)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(island_all_enemies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(island_all_enemies), 1), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(island_all_enemies), 1)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(island_all_enemies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(island_all_enemies), 2), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(island_all_enemies), 2)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(island_all_enemies), 2));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 0)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 1)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                await Engine.sleep(5);
                if (Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2), 45F) == false && Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(all_allies), 2)) > 30F)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                await Engine.sleep(5);
                return Engine.device_get_position(gondola_02_a.Entity) > 0.75F;
            });
        }

        [ScriptMethod(246, Lifecycle.Dormant)]
        public async Task gondola_02_wake()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.device_get_position(gondola_02_a.Entity) > 0.37F && Engine.device_get_position(gondola_02_a.Entity) < 0.59F && Engine.device_get_position(gondola_02_a.Entity) > this.gondola_02_wake_state)
                {
                    Engine.object_clear_function_variable(gondola_02_a.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_02_a.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_02_a.Entity, "wake_backward", 1F, 1F);
                    Engine.object_clear_function_variable(gondola_02_b.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_02_b.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_02_b.Entity, "wake_backward", 1F, 1F);
                }

                if (Engine.device_get_position(gondola_02_a.Entity) > 0.37F && Engine.device_get_position(gondola_02_a.Entity) < 0.59F && Engine.device_get_position(gondola_02_a.Entity) < this.gondola_02_wake_state)
                {
                    Engine.object_clear_function_variable(gondola_02_a.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_02_a.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_02_a.Entity, "wake_forward", 1F, 1F);
                    Engine.object_clear_function_variable(gondola_02_b.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_02_b.Entity, "wake_backward");
                    Engine.object_set_function_variable(gondola_02_b.Entity, "wake_forward", 1F, 1F);
                }

                if (Engine.device_get_position(gondola_02_a.Entity) == this.gondola_02_wake_state || Engine.device_get_position(gondola_02_a.Entity) < 0.37F || Engine.device_get_position(gondola_02_a.Entity) > 0.59F)
                {
                    Engine.object_clear_function_variable(gondola_02_a.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_02_a.Entity, "wake_backward");
                    Engine.object_clear_function_variable(gondola_02_b.Entity, "wake_forward");
                    Engine.object_clear_function_variable(gondola_02_b.Entity, "wake_backward");
                }

                this.gondola_02_wake_state = Engine.device_get_position(gondola_02_a.Entity);
                return Engine.device_get_position(gondola_02_a.Entity) == 1F;
            });
        }

        [ScriptMethod(247, Lifecycle.Dormant)]
        public async Task gondola_02_restarter()
        {
            await Engine.sleep_until(async () =>
            {
                this.gondola_02_state = Engine.device_get_position(gondola_02_a.Entity);
                if (Engine.volume_test_objects_all(vol_gondola_02_mid, Engine.players()) == true && await this.player_count() > 0)
                {
                    Engine.device_set_position(gondola_02_a.Entity, 0F);
                    Engine.device_set_position(gondola_02_b.Entity, 0F);
                }
                else
                {
                    Engine.device_set_position(gondola_02_a.Entity, this.gondola_02_state);
                    Engine.device_set_position(gondola_02_b.Entity, this.gondola_02_state);
                }

                return Engine.device_get_position(gondola_02_a.Entity) > 0.6F;
            });
        }

        [ScriptMethod(248, Lifecycle.Dormant)]
        public async Task gondola_02_reverser()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects_all(vol_gondola_02_mid, Engine.players()) == true && await this.player_count() > 0)
                {
                    Engine.device_set_position(gondola_02_a.Entity, 1F);
                    Engine.device_set_position(gondola_02_b.Entity, 1F);
                }
                else
                {
                    Engine.device_set_position(gondola_02_a.Entity, 0.54F);
                    Engine.device_set_position(gondola_02_b.Entity, 0.54F);
                }

                return Engine.device_get_position(gondola_02_a.Entity) > 0.6F;
            });
        }

        [ScriptMethod(249, Lifecycle.CommandScript)]
        public async Task boost_test()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 30F);
        }

        [ScriptMethod(250, Lifecycle.CommandScript)]
        public async Task boost_to_temple_01()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(251, Lifecycle.CommandScript)]
        public async Task boost_to_temple_02()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(252, Lifecycle.CommandScript)]
        public async Task panic()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_movement_mode(3);
            Engine.sleep_forever();
        }

        [ScriptMethod(253, Lifecycle.Dormant)]
        public async Task gondola_02_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_near_gondola_02, Engine.players()) == true);
            Engine.ai_disposable(island_all_enemies, true);
            await Engine.sleep_until(async () => Engine.device_group_get(gondola_02_switch) > 0F || (short)Engine.ai_living_count(island_main_enemies) < 1);
            if (Engine.device_group_get(gondola_02_switch) > 0F)
            {
                Engine.ai_set_orders(all_allies, gondola_02_allies);
            }
            else
            {
                await Engine.sleep(60);
                Engine.ai_set_orders(all_allies, gondola_02_allies);
                Engine.ai_scene("gondola_02_ally_scene", new ScriptMethodReference(gondola_02_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                ;
            }

            Engine.data_mine_set_mission_segment("05b_13_gondola_02");
            Engine.ai_renew(all_allies);
            await Engine.sleep_until(async () => Engine.device_group_get(gondola_02_switch) > 0F);
            Engine.device_set_power(gondola_02_switch_front.Entity, 0F);
            Engine.wake(new ScriptMethodReference(gondola_02_wake));
            Engine.object_dynamic_simulation_disable(gondola_02_a.Entity, false);
            Engine.object_dynamic_simulation_disable(gondola_02_b.Entity, false);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_gondola_02, Engine.players()) == true && await this.player_count() > 0);
            Engine.device_set_position(gondola_02_launch_a.Entity, 1F);
            Engine.device_set_position(gondola_02_launch_b.Entity, 1F);
            Engine.device_set_position(gondola_02_a.Entity, 0.54F);
            Engine.device_set_position(gondola_02_b.Entity, 0.54F);
            Engine.wake(new ScriptMethodReference(island_miranda_conversation));
            await Engine.sleep(300);
            Engine.ai_place(gondola_02_banshees.Squad, 2);
            Engine.cs_run_command_script(gondola_02_banshees.Squad, new ScriptMethodReference(boost_test));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) >= 0.25F);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(gondola_02_grunts.Squad, 4);
            }

            Engine.ai_place(gondola_02_jetpacks.Squad, 2);
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) >= 0.43F);
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(gondola_02_nuke));
            Engine.ai_set_orders(gondola_02_jetpacks.Squad, gondola_02_jets);
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) == 0.54F);
            Engine.object_dynamic_simulation_disable(gondola_02_a.Entity, true);
            Engine.object_dynamic_simulation_disable(gondola_02_b.Entity, true);
            await Engine.sleep_until(async () => (float)Engine.ai_living_count(gondola_02_grunts.Squad) + (float)Engine.ai_living_count(gondola_02_jetpacks.Squad) < 1F, 30, 1800);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", gondola_02_enemies) == true, 30, 1800);
            Engine.game_save();
            Engine.object_dynamic_simulation_disable(gondola_02_a.Entity, false);
            Engine.object_dynamic_simulation_disable(gondola_02_b.Entity, false);
            Engine.wake(new ScriptMethodReference(music_05b_09_start_alt));
            Engine.wake(new ScriptMethodReference(gondola_02_reverser));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) > 0.75F);
            Engine.ai_set_orders(gondola_02_banshees.Squad, airspace_island);
            Engine.cs_run_command_script(gondola_02_banshees.Squad, new ScriptMethodReference(banshee_retreat));
            Engine.ai_place(temple_ent_grunts.Squad, 4);
            Engine.cs_run_command_script(temple_ent_grunts._1, new ScriptMethodReference(temple_ent_turret_01));
            Engine.cs_run_command_script(temple_ent_grunts._2, new ScriptMethodReference(temple_ent_turret_02));
            Engine.ai_place(temple_ent_jackals.Squad, 2);
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) > 0.9F);
            Engine.ai_set_orders(gondola_02_jetpacks.Squad, jetpacks_temple);
            Engine.cs_run_command_script(gondola_02_jetpacks._1, new ScriptMethodReference(boost_to_temple_01));
            Engine.cs_run_command_script(gondola_02_jetpacks._2, new ScriptMethodReference(boost_to_temple_01));
            await Engine.sleep_until(async () => Engine.device_get_position(gondola_02_a.Entity) == 1F);
            Engine.object_dynamic_simulation_disable(gondola_02_a.Entity, true);
            Engine.object_dynamic_simulation_disable(gondola_02_b.Entity, true);
            Engine.game_save();
            Engine.ai_vehicle_exit(temple_ent_turrets.Squad);
            Engine.ai_set_orders(temple_ent_grunts.Squad, temple_ent_retreat);
            Engine.ai_set_orders(temple_ent_jackals.Squad, temple_ent_retreat);
            Engine.device_set_position(gondola_02_launch_a.Entity, 0F);
            Engine.device_set_position(gondola_02_launch_b.Entity, 0F);
            Engine.cs_run_command_script(temple_ent_grunts.Squad, new ScriptMethodReference(panic));
            await Engine.sleep(60);
            Engine.cs_run_command_script(temple_ent_jackals.Squad, new ScriptMethodReference(panic));
        }

        [ScriptMethod(254, Lifecycle.CommandScript)]
        public async Task temple_hunker()
        {
            Engine.cs_crouch(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(255, Lifecycle.CommandScript)]
        public async Task high_charity_ally_comment()
        {
            Engine.cs_switch("ally");
            Engine.cs_abort_on_damage(true);
            Engine.print("ally: 'damn! look at the size of that thing!'");
            Engine.cs_play_line("1210");
        }

        [ScriptMethod(256, Lifecycle.Dormant)]
        public async Task temple_ent_cortana_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_entry, Engine.players()) == true, 30, 1800);
            if (Engine.volume_test_objects(vol_temple_entry, Engine.players()) == false)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_entry, Engine.players()) == true, 30, 60);
                if (Engine.volume_test_objects(vol_temple_entry, Engine.players()) == false)
                {
                    Engine.print("cortana: 'there's no time, chief! get inside and take care of the prophet!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1220"));
                }

                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(257, Lifecycle.CommandScript)]
        public async Task temple_deploy_l()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("temple_turrets/deploy_left"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("temple_turrets/left"));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(258, Lifecycle.CommandScript)]
        public async Task temple_deploy_r()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("temple_turrets/deploy_right"));
            Engine.cs_deploy_turret(Engine.GetReference<ISpatialPoint>("temple_turrets/right"));
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(259, Lifecycle.Dormant)]
        public async Task temple_entry_start()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_entry_enemies) < 1 || Engine.volume_test_objects(vol_temple_ent_cutscene, Engine.players()) == true, 5);
            Engine.ai_disposable(gondola_02_enemies, true);
            Engine.wake(new ScriptMethodReference(music_05b_09_stop));
            await this.cinematic_fade_to_white();
            Engine.object_teleport(await this.player0(), player0_hide_bsp3);
            Engine.object_teleport(await this.player1(), player1_hide_bsp3);
            Engine.cs_run_command_script(all_allies, new ScriptMethodReference(temple_hunker));
            if (await this.cinematic_skip_start())
            {
                await this.c05_intra2();
            }

            await this.cinematic_skip_stop();
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), temple_ext_player0);
            Engine.object_teleport(await this.player1(), temple_ext_player1);
            Engine.object_create_anew(fleet01);
            Engine.object_create_anew(fleet02);
            Engine.object_create_anew(fleet_high_char);
            Engine.cs_run_command_script(temple_ent_grunts.Squad, new ScriptMethodReference(abort));
            Engine.cs_run_command_script(temple_ent_jackals.Squad, new ScriptMethodReference(abort));
            Engine.cs_run_command_script(gondola_02_jetpacks.Squad, new ScriptMethodReference(abort));
            Engine.cs_run_command_script(all_allies, new ScriptMethodReference(abort));
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(_05b_title2));
            Engine.wake(new ScriptMethodReference(objective_temple_clear));
            Engine.wake(new ScriptMethodReference(objective_regret_set));
            Engine.data_mine_set_mission_segment("05b_14_temple_exterior");
            Engine.ai_renew(all_allies);
            Engine.game_save_immediate();
            await Engine.sleep(30);
            Engine.ai_set_orders(all_allies, temple_ent_allies);
            Engine.ai_scene("temple_ent_ally_scene", new ScriptMethodReference(high_charity_ally_comment), all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            Engine.wake(new ScriptMethodReference(temple_ent_cortana_reminder));
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(temple_heavies.Squad, 2);
                Engine.begin_random(async () => Engine.cs_run_command_script(temple_heavies.left, new ScriptMethodReference(temple_deploy_l)), 
                    async () => Engine.cs_run_command_script(temple_heavies.right, new ScriptMethodReference(temple_deploy_r)));
            }
            else
            {
                Engine.ai_place(temple_heavies.Squad, 1);
                Engine.begin_random(async () => Engine.cs_run_command_script(temple_heavies.Squad, new ScriptMethodReference(temple_deploy_l)), 
                    async () => Engine.cs_run_command_script(temple_heavies.Squad, new ScriptMethodReference(temple_deploy_r)));
            }

            await Engine.sleep(90);
            if (await this.difficulty_legendary())
            {
                Engine.ai_place(temple_halls_jackals_01.Squad, (short)(2 - (float)Engine.ai_living_count(temple_ent_jackals.Squad)));
            }
            else
            {
                Engine.ai_place(temple_halls_jackals_01.Squad, (short)(3 - (float)Engine.ai_living_count(temple_ent_jackals.Squad)));
            }

            if (await this.difficulty_legendary())
            {
                Engine.ai_place(temple_halls_elites_01.Squad, (short)(2 - (float)Engine.ai_living_count(gondola_02_jetpacks.Squad)));
            }
            else
            {
                Engine.ai_place(temple_halls_elites_01.Squad, (short)(1 - (float)Engine.ai_living_count(gondola_02_jetpacks.Squad)));
            }
        }

        [ScriptMethod(260, Lifecycle.Dormant)]
        public async Task temple_cortana_warn_02()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            Engine.game_save_cancel();
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'the covenant fleet has launched multiple waves of reinforcements!'");
            Engine.print("'too many for me to track! we don't have much time!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0210"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            this.bossfight_chatter = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(261, Lifecycle.Dormant)]
        public async Task temple_foyer_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_entry, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("05b_15_temple_halls");
            Engine.ai_renew(all_allies);
            Engine.game_save_no_timeout();
            Engine.ai_set_orders(all_allies, temple_halls_allies);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(temple_entry_enemies) < 3, 30, 60);
            Engine.game_save_no_timeout();
            if (Engine.volume_test_objects(vol_temple_left, Engine.players()) == true)
            {
                Engine.ai_place(temple_halls_jackals_02L.Squad, (short)(4 - (float)Engine.ai_living_count(temple_halls_jackals_01.Squad)));
            }

            if (Engine.volume_test_objects(vol_temple_right, Engine.players()) == true)
            {
                Engine.ai_place(temple_halls_jackals_02R.Squad, (short)(4 - (float)Engine.ai_living_count(temple_halls_jackals_02L.Squad) + (float)Engine.ai_living_count(temple_halls_jackals_01.Squad)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_foyer, Engine.players()) == true);
            Engine.game_save_no_timeout();
            Engine.ai_place(temple_halls_elites_02.Squad, 2);
            Engine.wake(new ScriptMethodReference(temple_cortana_warn_02));
        }

        [ScriptMethod(262, Lifecycle.Dormant)]
        public async Task temple_cortana_warn_01()
        {
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0)) < 15F && Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0), 30F) == true);
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                Engine.game_save_cancel();
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                if (this.regret_dead == false)
                {
                    Engine.print("cortana: 'there's the target! take him out!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0200"));
                }

                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                Engine.game_save_no_timeout();
            }
        }

        [ScriptMethod(263, Lifecycle.Dormant)]
        public async Task temple_cortana_warn_03()
        {
            await Engine.sleep_until(async () => this.regret_dead == true || this.regret_times_dead > 0, 30, 5100);
            if (this.regret_dead == false)
            {
                await Engine.sleep_until(async () => this.bossfight_chatter == true);
                this.bossfight_chatter = false;
                Engine.game_save_cancel();
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("cortana: 'bad news. the reinforcements are turning around -'");
                Engine.print("'the fleet is preparing to fire on our position! we need to get out of here!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0220"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                Engine.game_save_no_timeout();
            }
        }

        [ScriptMethod(264, Lifecycle.Dormant)]
        public async Task temple_cortana_reminder()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            Engine.game_save_cancel();
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'go! back out the way we came in!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1370"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            this.bossfight_chatter = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(265, Lifecycle.Dormant)]
        public async Task regret_hint_01()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                Engine.ai_dialogue_enable(false);
                await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save(), 30, 600);
                Engine.game_save_cancel();
                if (this.regret_dead == false)
                {
                    Engine.print("cortana: 'his throne is shielded!  it's deflecting everything you throw at it!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1230"));
                    await Engine.sleep(15);
                    Engine.print("cortana: 'get in close, and do whatever you can!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1240"));
                }

                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                Engine.game_save_no_timeout();
            }
        }

        [ScriptMethod(266, Lifecycle.Dormant)]
        public async Task regret_hint_02()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                Engine.ai_dialogue_enable(false);
                await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save(), 30, 600);
                Engine.game_save_cancel();
                if (this.regret_dead == false)
                {
                    Engine.print("cortana: 'you've got to get him out of that throne!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1250"));
                }

                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                Engine.game_save_no_timeout();
            }
        }

        [ScriptMethod(267, Lifecycle.Dormant)]
        public async Task regret_hint_03()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            if (this.regret_dead == false)
            {
                this.bossfight_chatter = false;
                Engine.ai_dialogue_enable(false);
                await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save(), 30, 600);
                Engine.game_save_cancel();
                if (this.regret_dead == false)
                {
                    Engine.print("cortana: 'quick! board his throne!'");
                    await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1290"));
                }

                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
                this.bossfight_chatter = true;
                Engine.game_save_no_timeout();
            }
        }

        [ScriptMethod(268, Lifecycle.Dormant)]
        public async Task regret_teleport_comment()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'phased spatial relocation! the same technology the monitor used on the first halo.'");
            Engine.print("'seems the prophets save the best toys for themselves�'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1260"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            this.bossfight_chatter = true;
        }

        [ScriptMethod(269, Lifecycle.Dormant)]
        public async Task regret_beam_comment()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(regret1.Squad) >= this.ai_combat_status_clear_los);
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'keep clear of that beam! i don't think you'll survive a direct hit!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1270"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            this.bossfight_chatter = true;
        }

        [ScriptMethod(270, Lifecycle.Dormant)]
        public async Task regret_hg_comment()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(temple_hg_init.Squad) >= this.ai_combat_status_clear_los);
            await Engine.sleep_until(async () => this.bossfight_chatter == true);
            this.bossfight_chatter = false;
            Engine.game_save_cancel();
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            if (this.regret_dead == false)
            {
                Engine.print("cortana: 'there are honor-guards all over this place!  watch your back!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1280"));
            }

            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            this.bossfight_chatter = true;
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(271, Lifecycle.Static)]
        public async Task regret_taunt_01()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true && Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            Engine.print("regret: 'warriors! attack! the demon must die!'");
            Engine.custom_animation(Engine.unit(Engine.ai_get_object(regret1.Squad)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:point", true);
            await Engine.sleep(Engine.ai_play_line(regret1.Squad, "1300"));
            this.bossfight_chatter = true;
            await Engine.sleep((short)Engine.random_range(300, 600));
        }

        [ScriptMethod(272, Lifecycle.Static)]
        public async Task regret_taunt_02()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true && Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            Engine.print("regret: 'you dare to interrupt my sermon?!'");
            Engine.custom_animation(Engine.unit(Engine.ai_get_object(regret1.Squad)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:cheer", true);
            await Engine.sleep(Engine.ai_play_line(regret1.Squad, "1310"));
            this.bossfight_chatter = true;
            await Engine.sleep((short)Engine.random_range(300, 600));
        }

        [ScriptMethod(273, Lifecycle.Static)]
        public async Task regret_taunt_03()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true && Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            Engine.print("regret: 'the great journey will not be postponed!'");
            Engine.custom_animation(Engine.unit(Engine.ai_get_object(regret1.Squad)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:cheer", true);
            await Engine.sleep(Engine.ai_play_line(regret1.Squad, "1320"));
            this.bossfight_chatter = true;
            await Engine.sleep((short)Engine.random_range(300, 600));
        }

        [ScriptMethod(274, Lifecycle.Static)]
        public async Task regret_taunt_04()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true && Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            Engine.print("regret: 'guards! remove this vermin from my sight!'");
            Engine.custom_animation(Engine.unit(Engine.ai_get_object(regret1.Squad)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:point", true);
            await Engine.sleep(Engine.ai_play_line(regret1.Squad, "1330"));
            this.bossfight_chatter = true;
            await Engine.sleep((short)Engine.random_range(300, 600));
        }

        [ScriptMethod(275, Lifecycle.Static)]
        public async Task regret_taunt_05()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true && Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            Engine.print("regret: 'human filth! you befoul this holy place!'");
            Engine.custom_animation(Engine.unit(Engine.ai_get_object(regret1.Squad)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:taunt", true);
            await Engine.sleep(Engine.ai_play_line(regret1.Squad, "1340"));
            this.bossfight_chatter = true;
            await Engine.sleep((short)Engine.random_range(300, 600));
        }

        [ScriptMethod(276, Lifecycle.Static)]
        public async Task regret_taunt_06()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true && Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            Engine.print("regret: 'incompetents! i'll kill it myself!'");
            Engine.custom_animation(Engine.unit(Engine.ai_get_object(regret1.Squad)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:taunt", true);
            await Engine.sleep(Engine.ai_play_line(regret1.Squad, "1350"));
            this.bossfight_chatter = true;
            await Engine.sleep((short)Engine.random_range(300, 600));
        }

        [ScriptMethod(277, Lifecycle.Static)]
        public async Task regret_taunt_07()
        {
            await Engine.sleep_until(async () => this.bossfight_chatter == true && Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
            this.bossfight_chatter = false;
            Engine.print("regret: 'your very existence offends me, demon!'");
            Engine.custom_animation(Engine.unit(Engine.ai_get_object(regret1.Squad)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:cheer", true);
            await Engine.sleep(Engine.ai_play_line(regret1.Squad, "1360"));
            this.bossfight_chatter = true;
            await Engine.sleep((short)Engine.random_range(300, 600));
        }

        [ScriptMethod(278, Lifecycle.Dormant)]
        public async Task regret_taunts()
        {
            Engine.begin_random(async () => await this.regret_taunt_01(), 
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
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_L_01) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_L_01, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_L._01);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_L_02) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_L_02, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_L._02);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_L_03) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_L_03, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_L._03);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_L_04) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_L_04, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_L._04);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_L_05) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_L_05, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_L._05);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_R_01) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_R_01, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_R._01);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_R_02) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_R_02, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_R._02);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_R_03) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_R_03, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_R._03);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_R_04) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_R_04, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_R._04);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_honor_grunts) < 2 && Engine.objects_distance_to_flag(Engine.players(), temple_R_05) > 5F && Engine.objects_can_see_flag(Engine.players(), temple_R_05, 45F) == false)
                    {
                        Engine.ai_place(honor_grunts_new_R._05);
                        await Engine.sleep((short)Engine.random_range(120, 240));
                    }
                });
                await Engine.sleep_until(async () => (bool)Engine.ai_vitality_pinned(regret1.Squad) == true || this.regret_dead == true || (short)Engine.ai_living_count(temple_honor_grunts) < 2);
                return this.regret_dead == true;
            });
        }

        [ScriptMethod(280, Lifecycle.Dormant)]
        public async Task temple_hg_respawner()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(temple_hg) < this.hg_count && Engine.device_get_position(temple_spawndoor_01r.Entity) == 0F && Engine.volume_test_objects(vol_temple_spawnroom_01r, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(temple_hg_01R.Squad, 1);
                        await Engine.sleep((short)Engine.random_range(60, 120));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_hg) < this.hg_count && Engine.device_get_position(temple_spawndoor_01l.Entity) == 0F && Engine.volume_test_objects(vol_temple_spawnroom_01l, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(temple_hg_01L.Squad, 1);
                        await Engine.sleep((short)Engine.random_range(60, 120));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_hg) < this.hg_count && Engine.device_get_position(temple_spawndoor_02r.Entity) == 0F && Engine.volume_test_objects(vol_temple_spawnroom_02r, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(temple_hg_02R.Squad, 1);
                        await Engine.sleep((short)Engine.random_range(60, 120));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(temple_hg) < this.hg_count && Engine.device_get_position(temple_spawndoor_02l.Entity) == 0F && Engine.volume_test_objects(vol_temple_spawnroom_02l, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(temple_hg_02L.Squad, 1);
                        await Engine.sleep((short)Engine.random_range(60, 120));
                    }
                });
                await Engine.sleep_until(async () => (bool)Engine.ai_vitality_pinned(regret1.Squad) == true || this.regret_dead == true || (short)Engine.ai_living_count(temple_hg) < 1);
                await Engine.sleep_until(async () => (bool)Engine.ai_vitality_pinned(regret1.Squad) == true || this.regret_dead == true, 30, (int)(this.hg_delay / this.regret_times_dead + 1F));
                return this.regret_dead == true;
            });
        }

        [ScriptMethod(281, Lifecycle.Dormant)]
        public async Task regret_respawner()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (bool)Engine.ai_vitality_pinned(regret1.Squad) == true);
                Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                Engine.unit_exit_vehicle(await this.player0(), 1);
                Engine.unit_exit_vehicle(await this.player1(), 1);
                await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
                Engine.object_destroy(this.regret_corpse);
                Engine.object_destroy(this.regret_throne);
                await Engine.sleep(60);
                Engine.ai_place(regret1.Squad, 1);
                Engine.ai_cannot_die(regret1.Squad, true);
                this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
                this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
                Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                Engine.object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                this.regret_times_dead = (short)(this.regret_times_dead + 1);
                return this.regret_times_dead == 4;
            });
        }

        [ScriptMethod(282, Lifecycle.CommandScript)]
        public async Task reserve_throne()
        {
            await Engine.sleep(2);
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get(this.ai_current_actor), true);
            await Engine.sleep(2);
        }

        [ScriptMethod(283, Lifecycle.CommandScript)]
        public async Task regret_pause()
        {
            Engine.cs_abort_on_damage(true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_02, Engine.players()) == true && Engine.objects_can_see_object(Engine.ai_actors(regret1.Squad), await this.player0(), 45F) == true || Engine.objects_can_see_object(Engine.ai_actors(regret1.Squad), await this.player1(), 45F) == true);
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

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0)) < 5F);
                await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == true || Engine.unit_in_vehicle(await this.player1()) == true || Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0)) > 5F, 30, 150);
                if (Engine.unit_in_vehicle(await this.player0()) == true || Engine.unit_in_vehicle(await this.player1()) == true)
                {
                    await Engine.sleep_until(async () => (bool)Engine.ai_vitality_pinned(regret1.Squad) == true, 30, 150);
                    if ((bool)Engine.ai_vitality_pinned(regret1.Squad) == false)
                    {
                        Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), false);
                        Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        await Engine.sleep(30);
                        Engine.unit_exit_vehicle(await this.player0(), 1);
                        Engine.unit_exit_vehicle(await this.player1(), 1);
                        await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
                        Engine.object_destroy(this.regret_corpse);
                        Engine.object_destroy(this.regret_throne);
                        await Engine.sleep(60);
                        Engine.ai_place(regret1.Squad, 1);
                        Engine.ai_cannot_die(regret1.Squad, true);
                        if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                        {
                            Engine.ai_set_orders(regret1.Squad, regret_02);
                        }

                        if (this.regret_times_dead > 2)
                        {
                            Engine.ai_set_orders(regret1.Squad, regret_03);
                        }

                        this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
                        this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
                        Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        Engine.object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                        Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), true);
                    }
                    else
                    {
                        Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), false);
                        Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        await Engine.sleep(30);
                        Engine.unit_exit_vehicle(await this.player0(), 1);
                        Engine.unit_exit_vehicle(await this.player1(), 1);
                        await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
                        Engine.object_destroy(this.regret_corpse);
                        Engine.object_destroy(this.regret_throne);
                        await Engine.sleep(60);
                        Engine.game_save();
                        Engine.ai_place(regret1.Squad, 1);
                        Engine.ai_cannot_die(regret1.Squad, true);
                        if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                        {
                            Engine.ai_set_orders(regret1.Squad, regret_02);
                        }

                        if (this.regret_times_dead > 2)
                        {
                            Engine.ai_set_orders(regret1.Squad, regret_03);
                        }

                        this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
                        this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
                        Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        Engine.object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                        this.regret_times_dead = (short)(this.regret_times_dead + 1);
                        Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), true);
                    }
                }
                else if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0)) < 5F)
                {
                    Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), false);
                    Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    await Engine.sleep(30);
                    Engine.unit_exit_vehicle(await this.player0(), 1);
                    Engine.unit_exit_vehicle(await this.player1(), 1);
                    await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
                    Engine.object_destroy(this.regret_corpse);
                    Engine.object_destroy(this.regret_throne);
                    await Engine.sleep(60);
                    Engine.ai_place(regret1.Squad, 1);
                    Engine.ai_cannot_die(regret1.Squad, true);
                    if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                    {
                        Engine.ai_set_orders(regret1.Squad, regret_02);
                    }

                    if (this.regret_times_dead > 2)
                    {
                        Engine.ai_set_orders(regret1.Squad, regret_03);
                    }

                    this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
                    this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
                    Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    Engine.object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                    Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), true);
                }
                else
                {
                    Engine.print("do nothing");
                }

                return this.regret_times_dead == this.regret_lives;
            });
        }

        [ScriptMethod(285, Lifecycle.Dormant)]
        public async Task regret_death()
        {
            Engine.object_create_anew(fake_corpse);
            await Engine.sleep(2);
            Engine.object_cannot_take_damage(fake_corpse.Entity);
            Engine.object_hide(fake_corpse.Entity, true);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0)) < 5F);
                await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == true || Engine.unit_in_vehicle(await this.player1()) == true || Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0)) > 5F, 30, 150);
                if (Engine.unit_in_vehicle(await this.player0()) == true || Engine.unit_in_vehicle(await this.player1()) == true)
                {
                    await Engine.sleep_until(async () => (bool)Engine.ai_vitality_pinned(regret1.Squad) == true, 30, 150);
                    if ((bool)Engine.ai_vitality_pinned(regret1.Squad) == false)
                    {
                        Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), false);
                        Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        await Engine.sleep(30);
                        Engine.unit_exit_vehicle(await this.player0(), 1);
                        Engine.unit_exit_vehicle(await this.player1(), 1);
                        await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
                        Engine.object_destroy(this.regret_corpse);
                        Engine.object_destroy(this.regret_throne);
                        await Engine.sleep(60);
                        Engine.ai_place(regret1.Squad, 1);
                        Engine.ai_cannot_die(regret1.Squad, true);
                        Engine.cs_run_command_script(regret1.Squad, new ScriptMethodReference(reserve_throne));
                        if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                        {
                            Engine.ai_set_orders(regret1.Squad, regret_02);
                        }

                        if (this.regret_times_dead > 2)
                        {
                            Engine.ai_set_orders(regret1.Squad, regret_03);
                        }

                        this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
                        this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
                        Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                        Engine.object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                        Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), true);
                    }
                    else
                    {
                        this.regret_dead = true;
                        Engine.objects_attach(this.regret_throne, "driver", fake_corpse.Entity, "");
                        await Engine.sleep(2);
                        Engine.object_hide(fake_corpse.Entity, false);
                        Engine.object_hide(this.regret_corpse, true);
                        Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), false);
                        Engine.custom_animation_loop(fake_corpse.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "throne_d:dead", true);
                        Engine.ai_play_line_on_object(fake_corpse.Entity, "1380") // Couldn't generate cast from 'Short' to 'Void'
                        ;
                        await Engine.sleep(60);
                        Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\prophet\\regret_death", 2245403524U), fake_corpse.Entity, "body");
                        Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\prophet\\regret_death", 2245403524U), this.regret_throne, "");
                        Engine.unit_exit_vehicle(await this.player0(), 1);
                        Engine.unit_exit_vehicle(await this.player1(), 1);
                        Engine.ai_cannot_die(regret1.Squad, false);
                        Engine.object_hide(this.regret_corpse, true);
                        Engine.ai_kill(regret1.Squad);
                        await Engine.sleep(1);
                        Engine.object_hide(this.regret_corpse, true);
                        Engine.object_clear_all_function_variables(this.regret_throne);
                        await Engine.sleep(150);
                        Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\vehicles\\damage_effects\\cov_damage_large", 3912042423U), this.regret_throne, 1F);
                    }
                }
                else if (Engine.objects_distance_to_object(Engine.players(), Engine.list_get(Engine.ai_actors(regret1.Squad), 0)) < 5F)
                {
                    Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), false);
                    Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    await Engine.sleep(30);
                    Engine.unit_exit_vehicle(await this.player0(), 1);
                    Engine.unit_exit_vehicle(await this.player1(), 1);
                    await Engine.sleep_until(async () => Engine.unit_in_vehicle(await this.player0()) == false && Engine.unit_in_vehicle(await this.player1()) == false);
                    Engine.object_destroy(this.regret_corpse);
                    Engine.object_destroy(this.regret_throne);
                    await Engine.sleep(60);
                    Engine.ai_place(regret1.Squad, 1);
                    Engine.ai_cannot_die(regret1.Squad, true);
                    Engine.cs_run_command_script(regret1.Squad, new ScriptMethodReference(reserve_throne));
                    if (this.regret_times_dead == 1 || this.regret_times_dead == 2)
                    {
                        Engine.ai_set_orders(regret1.Squad, regret_02);
                    }

                    if (this.regret_times_dead > 2)
                    {
                        Engine.ai_set_orders(regret1.Squad, regret_03);
                    }

                    this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
                    this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
                    Engine.effect_new_on_object_marker(this.regret_teleport, this.regret_corpse, "body");
                    Engine.object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
                    Engine.unit_set_enterable_by_player(Engine.unit(this.regret_throne), true);
                }
                else
                {
                    Engine.print("do nothing");
                }

                return this.regret_dead == true;
            });
        }

        [ScriptMethod(286, Lifecycle.Static)]
        public async Task regret_test()
        {
            Engine.ai_place(regret1._1);
            await Engine.sleep(60);
            this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
            this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
            Engine.object_create_anew(regret03);
            Engine.print("destroy him");
            Engine.object_destroy(this.regret_corpse);
            Engine.print("attach him");
            Engine.objects_attach(this.regret_throne, "driver", regret03.Entity, "");
            Engine.print("animate him");
            Engine.custom_animation_loop(regret03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\prophet\\prophet", 3896051395U), "combat:any:any:cheer", true);
        }

        [ScriptMethod(287, Lifecycle.CommandScript)]
        public async Task regret_dead_retreat()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            Engine.sleep_forever();
        }

        [ScriptMethod(288, Lifecycle.Dormant)]
        public async Task temple_center_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_foyer, Engine.players()) == true);
            Engine.ai_disposable(temple_entry_enemies, true);
            Engine.data_mine_set_mission_segment("05b_16_temple_center");
            Engine.ai_renew(all_allies);
            Engine.game_save_no_timeout();
            Engine.ai_place(regret1._1);
            Engine.ai_cannot_die(regret1.Squad, true);
            Engine.cs_run_command_script(regret1.Squad, new ScriptMethodReference(regret_pause));
            this.regret_corpse = this.regret_corpse = Engine.list_get(Engine.ai_actors(regret1.Squad), 0);
            this.regret_throne = Engine.object_get_parent(Engine.list_get(Engine.ai_actors(regret1.Squad), 0));
            Engine.object_set_function_variable(this.regret_throne, "effects", 1F, 1F);
            Engine.ai_place(temple_hg_init.Squad, 2);
            Engine.wake(new ScriptMethodReference(regret_hg_comment));
            Engine.wake(new ScriptMethodReference(temple_hg_respawner));
            Engine.ai_place(honor_grunts_init_R.Squad, 2);
            Engine.ai_place(honor_grunts_init_L.Squad, 2);
            Engine.wake(new ScriptMethodReference(temple_grunt_spawner));
            if (await this.difficulty_legendary() || await this.difficulty_heroic())
            {
                Engine.wake(new ScriptMethodReference(regret_retreat));
            }
            else
            {
                Engine.wake(new ScriptMethodReference(regret_death));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_02, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, temple_left_allies);
            Engine.wake(new ScriptMethodReference(temple_cortana_warn_01));
            Engine.wake(new ScriptMethodReference(regret_taunts));
            await Engine.sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true, 30, 3600);
            if (this.regret_times_dead == 0 && this.regret_dead == false)
            {
                Engine.wake(new ScriptMethodReference(regret_hint_01));
            }

            await Engine.sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true, 30, 3600);
            if (this.regret_times_dead == 0 && this.regret_dead == false)
            {
                Engine.wake(new ScriptMethodReference(regret_hint_02));
            }

            await Engine.sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true, 30, 1800);
            if (this.regret_times_dead == 0 && this.regret_dead == false)
            {
                Engine.wake(new ScriptMethodReference(regret_hint_03));
            }

            await Engine.sleep_until(async () => this.regret_times_dead == 1 || this.regret_dead == true);
            if (await this.difficulty_heroic())
            {
                this.hg_count = 3;
                await Engine.sleep_until(async () => this.regret_times_dead == 2);
                Engine.wake(new ScriptMethodReference(regret_death));
            }

            if (await this.difficulty_legendary())
            {
                this.hg_count = 3;
                await Engine.sleep_until(async () => this.regret_times_dead == 3);
                this.hg_count = 4;
                await Engine.sleep_until(async () => this.regret_times_dead == 4);
                Engine.wake(new ScriptMethodReference(regret_death));
            }

            await Engine.sleep_until(async () => this.regret_dead == true);
            Engine.sleep_forever(new ScriptMethodReference(regret_taunts));
            Engine.ai_set_orders(all_enemies, everyone_retreat);
            Engine.ai_set_blind(all_enemies, true);
            Engine.ai_set_deaf(all_enemies, true);
            Engine.cs_run_command_script(all_enemies, new ScriptMethodReference(regret_dead_retreat));
            await Engine.sleep(60);
            this.bossfight_chatter = false;
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("cortana: 'bad news. the reinforcements are turning around -'");
            Engine.print("'the fleet is preparing to fire on our position! we need to get out of here!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0220"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await this.cinematic_fade_to_white();
            Engine.kill_volume_disable(kill_temple_wings);
            Engine.wake(new ScriptMethodReference(music_05b_10_stop));
            Engine.object_teleport(await this.player0(), player0_hide_bsp3);
            Engine.object_teleport(await this.player1(), player1_hide_bsp3);
            Engine.ai_kill_silent(all_enemies);
            if (await this.cinematic_skip_start())
            {
                await this.c05_outro();
            }

            await this.cinematic_skip_stop();
            await Engine.sleep(2);
            await this.playtest_mission();
            await Engine.sleep(2);
            Engine.game_won();
        }

        [ScriptMethod(289, Lifecycle.Dormant)]
        public async Task temple_foyer_retreat()
        {
            await Engine.sleep_until(async () => this.regret_dead == true);
            Engine.data_mine_set_mission_segment("05b_17_temple_retreat");
            Engine.ai_renew(all_allies);
            Engine.game_save();
            Engine.device_operates_automatically_set(temple_retreat_exit.Entity, true);
            Engine.ai_place(temple_exit_elites_01.Squad, (short)(2 - (float)Engine.ai_living_count(temple_hg)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_retreat_01, Engine.players()) == true || Engine.volume_test_objects(vol_temple_retreat_02, Engine.players()) == true || (float)Engine.ai_living_count(temple_hg) + (float)Engine.ai_living_count(temple_exit_elites_01.Squad) < 2F);
            Engine.game_save();
            Engine.ai_set_orders(all_allies, temple_retreat_allies);
            Engine.ai_place(temple_exit_grunts_01.Squad, 4);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_foyer, Engine.players()) == true || (short)Engine.ai_living_count(temple_escape_enemies) < 3);
            Engine.game_save();
            Engine.ai_place(temple_exit_jackals_02.Squad, 2);
            Engine.ai_place(temple_exit_elites_02.Squad, (short)(2 - (float)Engine.ai_living_count(temple_exit_elites_01.Squad)));
        }

        [ScriptMethod(290, Lifecycle.Dormant)]
        public async Task temple_entry_retreat()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_entry, Engine.players()) == true && this.regret_dead == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            await this.cinematic_fade_to_white();
            Engine.kill_volume_disable(kill_temple_wings);
            Engine.wake(new ScriptMethodReference(music_05b_10_stop));
            Engine.object_teleport(await this.player0(), player0_hide_bsp3);
            Engine.object_teleport(await this.player1(), player1_hide_bsp3);
            Engine.ai_kill_silent(all_enemies);
            if (await this.cinematic_skip_start())
            {
                await this.c05_outro();
            }

            await this.cinematic_skip_stop();
            await Engine.sleep(2);
            await this.cinematic_fade_from_white();
            await Engine.sleep(2);
            await this.playtest_mission();
            await Engine.sleep(2);
            Engine.game_won();
        }

        [ScriptMethod(291, Lifecycle.Static)]
        public async Task sleep_tower1()
        {
            Engine.sleep_forever(new ScriptMethodReference(tower1_start));
            Engine.sleep_forever(new ScriptMethodReference(tower1_holo_looper));
            Engine.sleep_forever(new ScriptMethodReference(tower1_cortana_comment));
        }

        [ScriptMethod(292, Lifecycle.Static)]
        public async Task sleep_bridges()
        {
            Engine.sleep_forever(new ScriptMethodReference(bridges_start));
            Engine.sleep_forever(new ScriptMethodReference(cortana_bridge_reminder));
        }

        [ScriptMethod(293, Lifecycle.Static)]
        public async Task sleep_tower2()
        {
            Engine.sleep_forever(new ScriptMethodReference(tower2_start));
            Engine.sleep_forever(new ScriptMethodReference(tower2_cortana_comment));
        }

        [ScriptMethod(294, Lifecycle.Static)]
        public async Task sleep_central_platform()
        {
            Engine.sleep_forever(new ScriptMethodReference(central_platform_start));
            Engine.sleep_forever(new ScriptMethodReference(central_platform_pelican));
        }

        [ScriptMethod(295, Lifecycle.Static)]
        public async Task sleep_gondola_01()
        {
            Engine.sleep_forever(new ScriptMethodReference(gondola_01_start));
            Engine.sleep_forever(new ScriptMethodReference(tower3_dock_above));
            Engine.sleep_forever(new ScriptMethodReference(gondola_01_nuke));
            Engine.sleep_forever(new ScriptMethodReference(gondola_01_restarter));
            Engine.sleep_forever(new ScriptMethodReference(gondola_01_reverser));
            Engine.sleep_forever(new ScriptMethodReference(gondola_01_go_reminder));
            Engine.sleep_forever(new ScriptMethodReference(gondola_01_phantom_arrives));
            Engine.sleep_forever(new ScriptMethodReference(tower3_turret_reman));
            Engine.sleep_forever(new ScriptMethodReference(tower3_cortana_comment));
            Engine.sleep_forever(new ScriptMethodReference(gondola_01_wake));
            Engine.sleep_forever(new ScriptMethodReference(tower_cluster_delete));
        }

        [ScriptMethod(296, Lifecycle.Static)]
        public async Task sleep_tower3()
        {
            Engine.sleep_forever(new ScriptMethodReference(tower3_start));
            Engine.sleep_forever(new ScriptMethodReference(tower3_sleeper_spawn));
            Engine.sleep_forever(new ScriptMethodReference(tower3_cortana_reminder_02));
            Engine.sleep_forever(new ScriptMethodReference(elev_under_monitor));
            Engine.sleep_forever(new ScriptMethodReference(assassin_ice_cream));
        }

        [ScriptMethod(297, Lifecycle.Static)]
        public async Task sleep_sunken_tunnel_01()
        {
            Engine.sleep_forever(new ScriptMethodReference(sunken_tunnel1_start));
        }

        [ScriptMethod(298, Lifecycle.Static)]
        public async Task sleep_sunken_chamber()
        {
            Engine.sleep_forever(new ScriptMethodReference(sunken_chamber_start));
            Engine.sleep_forever(new ScriptMethodReference(sunken_holo_cortana_comment));
            Engine.sleep_forever(new ScriptMethodReference(sunken_holo_looper));
            Engine.sleep_forever(new ScriptMethodReference(sunken_holo_translate));
            Engine.sleep_forever(new ScriptMethodReference(sunken_chamber_reminder));
            Engine.sleep_forever(new ScriptMethodReference(hide_rightside_guys));
            Engine.sleep_forever(new ScriptMethodReference(hide_leftside_guys));
            Engine.sleep_forever(new ScriptMethodReference(sunk_chamber_hunters_enter));
            Engine.sleep_forever(new ScriptMethodReference(sunken_chamber_saves));
        }

        [ScriptMethod(299, Lifecycle.Static)]
        public async Task sleep_sunken_tunnel_02()
        {
            Engine.sleep_forever(new ScriptMethodReference(sunken_tunnel2_start));
        }

        [ScriptMethod(300, Lifecycle.Static)]
        public async Task sleep_island_exterior()
        {
            Engine.sleep_forever(new ScriptMethodReference(island_interior_start));
            Engine.sleep_forever(new ScriptMethodReference(island_gully_start));
            Engine.sleep_forever(new ScriptMethodReference(island_exterior_start));
            Engine.sleep_forever(new ScriptMethodReference(elev_up_monitor));
            Engine.sleep_forever(new ScriptMethodReference(island_holo_looper));
            Engine.sleep_forever(new ScriptMethodReference(island_int_translate));
            Engine.sleep_forever(new ScriptMethodReference(island_pelican_arrives));
        }

        [ScriptMethod(301, Lifecycle.Static)]
        public async Task sleep_gondola_02()
        {
            Engine.sleep_forever(new ScriptMethodReference(gondola_02_start));
            Engine.sleep_forever(new ScriptMethodReference(gondola_02_cortana_reminder));
            Engine.sleep_forever(new ScriptMethodReference(gondola_02_nuke));
            Engine.sleep_forever(new ScriptMethodReference(gondola_02_restarter));
            Engine.sleep_forever(new ScriptMethodReference(gondola_02_reverser));
            Engine.sleep_forever(new ScriptMethodReference(gondola_02_wake));
        }

        [ScriptMethod(302, Lifecycle.Static)]
        public async Task sleep_temple_entry()
        {
            Engine.sleep_forever(new ScriptMethodReference(temple_entry_start));
            Engine.sleep_forever(new ScriptMethodReference(temple_foyer_start));
            Engine.sleep_forever(new ScriptMethodReference(temple_ent_cortana_reminder));
        }

        [ScriptMethod(303, Lifecycle.Static)]
        public async Task sleep_boss_fight()
        {
            Engine.sleep_forever(new ScriptMethodReference(temple_center_start));
            Engine.sleep_forever(new ScriptMethodReference(temple_hg_respawner));
            Engine.sleep_forever(new ScriptMethodReference(regret_respawner));
            Engine.sleep_forever(new ScriptMethodReference(regret_retreat));
            Engine.sleep_forever(new ScriptMethodReference(regret_beam_comment));
            Engine.sleep_forever(new ScriptMethodReference(regret_hg_comment));
            Engine.sleep_forever(new ScriptMethodReference(temple_cortana_warn_01));
            Engine.sleep_forever(new ScriptMethodReference(regret_taunts));
        }

        [ScriptMethod(304, Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_white();
            if (Engine.volume_test_objects(vol_starting_locations, Engine.players()) == true)
            {
                if (await this.cinematic_skip_start())
                {
                    await this.c05_intra1();
                }

                await this.cinematic_skip_stop();
            }

            Engine.sound_suppress_ambience_update_on_revert();
            Engine.sound_class_set_gain("amb", 0F, 0);
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 1F, 15);
            await Engine.sleep(2);
            Engine.switch_bsp(0);
            await Engine.sleep(2);
            Engine.ai_allegiance(covenant, prophet);
            Engine.ai_allegiance(player, human);
            Engine.objectives_clear();
            await Engine.sleep(2);
            await this.prep_return_from_intro();
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            Engine.wake(new ScriptMethodReference(_05b_title0));
            Engine.wake(new ScriptMethodReference(objective_towers_set));
            Engine.wake(new ScriptMethodReference(kill_volumes));
            Engine.wake(new ScriptMethodReference(tower1_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower1_exit, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_exit_01, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_exit_02, Engine.players()) == true || Engine.volume_test_objects(vol_tower1_roof, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(bridges_start));
            Engine.wake(new ScriptMethodReference(tower2_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == true || Engine.volume_test_objects(vol_central_platform, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(central_platform_start));
            Engine.wake(new ScriptMethodReference(gondola_01_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower3_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(tower3_start));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.wake(new ScriptMethodReference(sunken_tunnel1_start));
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(305, Lifecycle.Dormant)]
        public async Task _05_intra1_01_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3851748383U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 65, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 69, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 70, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 71, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 74, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\door_tower\\door_tower", 3860661415U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 10, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3861906618U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862234303U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\deltatemple\\sky_bsp_00\\sky_bsp_00", 3783000070U), 4);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 8);
            await Engine.sleep(98);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 8);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 65, true);
            await Engine.sleep(14);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 14, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 69, true);
            await Engine.sleep(205);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 67, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            await Engine.sleep(232);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 66, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            await Engine.sleep(36);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 17, false);
            await Engine.sleep(22);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 65, true);
        }

        [ScriptMethod(306, Lifecycle.Dormant)]
        public async Task _05_intra1_02_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3863610580U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\miranda\\miranda", 3863610580U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\human\\inamberclad_bridge\\inamberclad_bridge", 3865445616U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 4, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\matte_paintings\\delta_horizon\\delta_horizon", 3869377836U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\index_holo_human\\index_holo_human", 3869705521U), 0);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\forerunner\\mount_doom_holo\\mount_doom_holo", 3870360891U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\water_elevator\\water_elevator", 3871737168U), 0);
            await Engine.sleep(16);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 13, false);
            await Engine.sleep(128);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3872458075U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3873834352U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican_rear_gun\\pelican_rear_gun", 3873834352U), 1);
            await Engine.sleep(215);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\pelican\\pelican", 3872458075U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 61);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 72);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 74);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 69);
            await Engine.sleep(135);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 72, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 73, true);
        }

        [ScriptMethod(307, Lifecycle.Dormant)]
        public async Task _05_intra1_03_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3851748383U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\cortana\\cortana", 3862430914U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 11, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 68, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 69, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862234303U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05a_deltaapproach\\bsp_01"), 70, true);
        }

        [ScriptMethod(308, Lifecycle.Dormant)]
        public async Task _05_intra2_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\door_tower\\door_tower", 3860661415U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\fp_beam_rifle\\fp_beam_rifle", 3809477018U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885172253U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885172253U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886089771U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886089771U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 11);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885172253U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\projectiles\\needler_shard\\needler_shard", 3886876215U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3881829866U), 10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 39, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 17, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 18, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 27, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 29, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 35, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3887662659U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888252492U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888580177U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3889694306U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3810525610U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\frag_grenade\\frag_grenade", 3889694306U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\smg\\smg", 3810525610U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 2);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888252492U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium_tall\\stone_block_medium_tall", 3859612823U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\fp\\fp", 3878421942U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\fp_beam_rifle\\fp_beam_rifle", 3809477018U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_medium\\stone_block_medium", 3860530341U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\gravity_throne\\gravity_throne", 3859022990U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\prophet\\prophet", 3852403753U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\cov_floodlight\\cov_floodlight", 3861316785U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3862234303U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine_female\\marine_female", 3878880701U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 53);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 62);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 57);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 58);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\marine\\marine", 3874555259U), 60);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\shotgun\\shotgun", 3879863756U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3821535826U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\bugger\\bugger", 3880977885U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\ambient_life\\bird_quadwing\\bird_quadwing", 3890021991U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_large\\stone_block_large", 3890349676U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888580177U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_short\\bowl_short", 3851748383U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\door_tower\\door_tower", 3860661415U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            await Engine.sleep(150);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 0, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 12, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 19, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 16, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\human\\military\\resupply_capsule\\resupply_capsule_crate\\resupply_capsule_crate", 3890415213U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888252492U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_branch\\tree_branch", 3890742898U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_bush\\tree_bush", 3891267194U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_medium\\tree_ancient_medium", 3891332731U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\nature\\trees\\tree_ancient\\tree_ancient_large\\tree_ancient_large", 3891398268U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\stone_block_large\\stone_block_large", 3890349676U), 0);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 36, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, false);
            await Engine.sleep(41);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 47, true);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 36, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 44, true);
            await Engine.sleep(42);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 36, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 26, false);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891463805U), 0);
            await Engine.sleep(248);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3887662659U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 2);
        }

        [ScriptMethod(309, Lifecycle.Dormant)]
        public async Task _05_outro_01_predict()
        {
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 65, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\covenant\\military\\capital_ship\\capital_ship", 3891594879U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886089771U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3886089771U), 1);
            await Engine.sleep(185);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 65, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 6, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888580177U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 2);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3887662659U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888252492U), 1);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888252492U), 2);
            await Engine.sleep(34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891463805U), 0);
            await Engine.sleep(20);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
        }

        [ScriptMethod(310, Lifecycle.Dormant)]
        public async Task _05_outro_02_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891463805U), 0);
            await Engine.sleep(42);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 19);
            await Engine.sleep(23);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 18, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 16, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 17, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 23, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 24, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 25, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 28, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 31, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 32, true);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891463805U), 0);
        }

        [ScriptMethod(311, Lifecycle.Dormant)]
        public async Task _05_outro_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3887662659U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888580177U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888252492U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await Engine.sleep(122);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
        }

        [ScriptMethod(312, Lifecycle.Dormant)]
        public async Task _05_outro_04_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3887662659U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3861906618U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3885172253U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle", 3786801216U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888580177U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\masterchief\\masterchief", 3849847810U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\gear\\covenant\\military\\crate_space\\crate_space", 3888252492U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3870491965U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\carrier_plasma_beam_closeup\\carrier_plasma_beam_closeup", 3892577934U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891463805U), 0);
        }

        [ScriptMethod(313, Lifecycle.Dormant)]
        public async Task _05_outro_05_predict()
        {
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\special\\null_up\\null_up", 3891463805U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3892840082U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\gravemind\\tentacle_capture\\tentacle_capture", 3892840082U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\effects\\05_outro_rubble\\05_outro_rubble", 3893692063U), 0);
            await Engine.sleep(123);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 41, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 40, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 2, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\05b_deltatowers\\bsp_03"), 70, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3861906618U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\nature\\underwater_caustic_light\\underwater_caustic_light", 3894216359U), 0);
            await Engine.sleep(140);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\temple_dynamic\\bowl_tall\\bowl_tall", 3860595878U), 0);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola\\gondola", 3887662659U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3868853540U), 0);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\deltatemple\\gondola\\gondola_launch\\gondola_launch", 3887007289U), 2);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3888580177U), 0);
        }

        [ScriptMethod(314, Lifecycle.Static)]
        public async Task teleport_bridges()
        {
            Engine.ai_erase_all();
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), bridges_player0);
            Engine.object_teleport(await this.player1(), bridges_player1);
            Engine.ai_place(initial_allies.Squad);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), bridges_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 1), bridges_ally2);
            Engine.ai_set_orders(initial_allies.Squad, tower1_ext_allies);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(bridges_start));
            Engine.wake(new ScriptMethodReference(tower2_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == true || Engine.volume_test_objects(vol_central_platform, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(central_platform_start));
            Engine.wake(new ScriptMethodReference(gondola_01_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower3_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(tower3_start));
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(sunken_tunnel1_start));
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(315, Lifecycle.Static)]
        public async Task teleport_tower2()
        {
            Engine.ai_erase_all();
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), tower2_player0);
            Engine.object_teleport(await this.player1(), tower2_player1);
            Engine.ai_place(initial_allies.Squad);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), tower2_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 1), tower2_ally2);
            Engine.ai_set_orders(initial_allies.Squad, tower2_ext_allies_01);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(tower2_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower2_exit, Engine.players()) == true || Engine.volume_test_objects(vol_central_platform, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(central_platform_start));
            Engine.wake(new ScriptMethodReference(gondola_01_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower3_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(tower3_start));
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(sunken_tunnel1_start));
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(316, Lifecycle.Static)]
        public async Task teleport_central_platform()
        {
            Engine.ai_erase_all();
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), center_plat_player0);
            Engine.object_teleport(await this.player1(), center_plat_player1);
            Engine.ai_place(initial_allies.Squad);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), center_plat_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 1), center_plat_ally2);
            Engine.ai_set_orders(initial_allies.Squad, tower2_ext_allies_02);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(central_platform_start));
            Engine.wake(new ScriptMethodReference(gondola_01_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower3_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(tower3_start));
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(sunken_tunnel1_start));
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(317, Lifecycle.Static)]
        public async Task teleport_gondola_01()
        {
            Engine.ai_erase_all();
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), gondola_01_player0);
            Engine.object_teleport(await this.player1(), gondola_01_player1);
            Engine.ai_place(initial_allies.Squad);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), gondola_01_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 1), gondola_01_ally2);
            Engine.ai_set_orders(initial_allies.Squad, gondola_01_allies);
            Engine.device_set_position_immediate(gondola_01_a.Entity, 1F);
            Engine.device_set_position_immediate(gondola_01_b.Entity, 1F);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(gondola_01_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tower3_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(tower3_start));
            await this.sleep_gondola_01();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(sunken_tunnel1_start));
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(318, Lifecycle.Static)]
        public async Task teleport_tower3()
        {
            Engine.ai_erase_all();
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            Engine.object_teleport(await this.player0(), tower3_player0);
            Engine.object_teleport(await this.player1(), tower3_player1);
            Engine.ai_place(initial_allies.Squad);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 0), tower3_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(initial_allies.Squad), 1), tower3_ally2);
            Engine.ai_set_orders(initial_allies.Squad, tower3_allies);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(tower3_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_tunnel_01_entry, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(sunken_tunnel1_start));
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await this.sleep_tower3();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(319, Lifecycle.Static)]
        public async Task teleport_tunnel_01()
        {
            Engine.ai_erase_all();
            Engine.ai_place(temp_bsp2_allies.Squad);
            Engine.switch_bsp(1);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), tunnel_01_player0);
            Engine.object_teleport(await this.player1(), tunnel_01_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp2_allies.Squad), 0), tunnel_01_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp2_allies.Squad), 1), tunnel_01_ally2);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(sunken_tunnel1_start));
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(320, Lifecycle.Static)]
        public async Task teleport_sunken_chamber()
        {
            Engine.ai_erase_all();
            Engine.ai_place(temp_bsp2_allies.Squad);
            Engine.switch_bsp(1);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), sunken_chamber_player0);
            Engine.object_teleport(await this.player1(), sunken_chamber_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp2_allies.Squad), 0), sunken_chamber_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp2_allies.Squad), 1), sunken_chamber_ally2);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(sunken_chamber_start));
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(321, Lifecycle.Static)]
        public async Task teleport_tunnel_02()
        {
            Engine.ai_erase_all();
            Engine.ai_place(temp_bsp2_allies.Squad);
            Engine.switch_bsp(1);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), tunnel_02_player0);
            Engine.object_teleport(await this.player1(), tunnel_02_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp2_allies.Squad), 0), tunnel_02_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp2_allies.Squad), 1), tunnel_02_ally2);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(sunken_tunnel2_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_island_int_entry, Engine.players()) == true && (short)Engine.structure_bsp_index() == 2);
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await this.sleep_sunken_tunnel_02();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(322, Lifecycle.Static)]
        public async Task teleport_island()
        {
            Engine.ai_erase_all();
            Engine.ai_place(temp_bsp3_allies.Squad);
            Engine.switch_bsp(2);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), island_player0);
            Engine.object_teleport(await this.player1(), island_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp3_allies.Squad), 0), island_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp3_allies.Squad), 1), island_ally2);
            Engine.sleep_forever(new ScriptMethodReference(mission));
            await this.sleep_tower1();
            await this.sleep_bridges();
            await this.sleep_tower2();
            await this.sleep_central_platform();
            await this.sleep_gondola_01();
            await this.sleep_tower3();
            await this.sleep_sunken_tunnel_01();
            await this.sleep_sunken_chamber();
            await this.sleep_sunken_tunnel_02();
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(island_interior_start));
            Engine.wake(new ScriptMethodReference(island_gully_start));
            Engine.wake(new ScriptMethodReference(island_exterior_start));
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_island_exterior();
            await this.sleep_gondola_02();
        }

        [ScriptMethod(323, Lifecycle.Static)]
        public async Task teleport_gondola_02()
        {
            Engine.ai_erase_all();
            Engine.ai_place(temp_bsp3_allies.Squad);
            Engine.switch_bsp(2);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), gondola_02_player0);
            Engine.object_teleport(await this.player1(), gondola_02_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp3_allies.Squad), 0), gondola_02_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp3_allies.Squad), 1), gondola_02_ally2);
            Engine.sleep_forever(new ScriptMethodReference(mission));
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
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(gondola_02_start));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_temple_ext, Engine.players()) == true);
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
            await this.sleep_gondola_02();
        }

        [ScriptMethod(324, Lifecycle.Static)]
        public async Task teleport_temple_ext()
        {
            Engine.ai_erase_all();
            Engine.ai_place(temp_bsp3_allies.Squad);
            Engine.switch_bsp(2);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), temple_ext_player0);
            Engine.object_teleport(await this.player1(), temple_ext_player1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp3_allies.Squad), 0), temple_ext_ally1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(temp_bsp3_allies.Squad), 1), temple_ext_ally2);
            Engine.sleep_forever(new ScriptMethodReference(mission));
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
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(temple_entry_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_start));
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
        }

        [ScriptMethod(325, Lifecycle.Static)]
        public async Task teleport_temple_int()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(2);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), temple_int_player0);
            Engine.object_teleport(await this.player1(), temple_int_player1);
            Engine.sleep_forever(new ScriptMethodReference(mission));
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
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.wake(new ScriptMethodReference(temple_center_start));
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
        }

        [ScriptMethod(326, Lifecycle.Static)]
        public async Task teleport_temple_retreat()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(2);
            Engine.unit_add_equipment(await this.player0(), profile_1, true, true);
            Engine.unit_add_equipment(await this.player1(), profile_1, true, true);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), temple_return_player0);
            Engine.object_teleport(await this.player1(), temple_return_player1);
            Engine.sleep_forever(new ScriptMethodReference(mission));
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
            Engine.garbage_collect_now();
            Engine.game_save();
            Engine.device_one_sided_set(door_main.Entity, false);
            Engine.device_one_sided_set(temple_retreat_exit.Entity, false);
            Engine.wake(new ScriptMethodReference(temple_foyer_retreat));
            Engine.wake(new ScriptMethodReference(temple_entry_retreat));
        }
    }
}