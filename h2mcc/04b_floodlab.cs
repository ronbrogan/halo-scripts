namespace OpenH2.Scripts.Generatedscenarios.solo
{
    using System;
    using System.Threading.Tasks;
    using OpenH2.Core.Architecture;
    using OpenH2.Core.Tags;
    using OpenH2.Core.Tags.Scenario;
    using OpenH2.Core.Scripting;
    using OpenH2.Core.GameObjects;

    [OriginScenario("scenarios\\solo\\04b_floodlab\\04b_floodlab")]
    public partial class scnr_04b_floodlab : ScenarioScriptBase
    {
#region Fields
        string data_mine_mission_segment;
        int sound_offset;
        int prediction_offset;
        bool plummeting;
        bool holo_drone_arrived;
        bool hl_done_talking;
        bool done_shooting_holo;
        bool mess_react_01_go;
        bool mess_react_02_go;
        bool mess_react_01_done;
        bool mess_react_02_done;
        bool holo_ally_01_go;
        bool holo_ally_02_go;
        bool holo_ally_03_go;
        bool holo_ally_01_done;
        bool holo_ally_02_done;
        bool holo_ally_03_done;
        bool silo_killer_power;
        bool silo_almost_there;
        int silo_sentinels_total;
        int silo_flood_total;
        bool silo_try_save;
        int lab_flood_count;
        bool bridge_final_gone;
        bool comm_farewell_done;
        bool soe_farewell_done;
        bool bug_out_phantom_here;
        EffectTag stress;
        EffectTag boom;
        float gravity;
        bool cables_cuttable;
        bool in_cable_room;
        int croom_sen_total;
        int croom_flood_total;
        int croom_flood_desired;
        int croom_sen_desired;
        int cable_var;
        EffectTag gasleak;
        EffectTag big_boom;
        int plummet_junk_total;
        bool cinematic_shooting_done;
        bool banshee_sin_01_ready;
        bool banshee_sin_02_ready;
        bool monitor_done_talking;
        bool monitor_available;
        bool boss_done_talking;
        bool final_hl_boss_dead;
        IGameObject heretic_leader;
        bool more_hl_orders;
        bool more_holo1_orders;
        bool more_holo2_orders;
        IGameObject holo1;
        IGameObject holo2;
        IGameObject holo3;
        IGameObject holo4;
        EffectTag holo_death;
        bool holo_drones_nuke;
        int hl_times_dead;
        int hl_lives_total;
        int hl_drone_total;
        public scnr_04b_floodlab(IScriptEngine scriptEngine)
        {
            this.Engine = scriptEngine;
            this.data_mine_mission_segment = "";
            this.sound_offset = 15;
            this.prediction_offset = 45;
            this.plummeting = false;
            this.holo_drone_arrived = false;
            this.hl_done_talking = false;
            this.done_shooting_holo = false;
            this.mess_react_01_go = false;
            this.mess_react_02_go = false;
            this.mess_react_01_done = false;
            this.mess_react_02_done = false;
            this.holo_ally_01_go = false;
            this.holo_ally_02_go = false;
            this.holo_ally_03_go = false;
            this.holo_ally_01_done = false;
            this.holo_ally_02_done = false;
            this.holo_ally_03_done = false;
            this.silo_killer_power = true;
            this.silo_almost_there = false;
            this.silo_sentinels_total = 0;
            this.silo_flood_total = 0;
            this.silo_try_save = false;
            this.lab_flood_count = 0;
            this.bridge_final_gone = false;
            this.comm_farewell_done = false;
            this.soe_farewell_done = false;
            this.bug_out_phantom_here = false;
            this.stress = Engine.GetTag<EffectTag>("effects\\scenery\\sparks\\sparking_light", 4221245794U);
            this.boom = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\alphagasgiant\\wall_explosion", 4221442405U);
            this.gravity = 0F;
            this.cables_cuttable = true;
            this.in_cable_room = false;
            this.croom_sen_total = 0;
            this.croom_flood_total = 0;
            this.croom_flood_desired = 6;
            this.croom_sen_desired = 4;
            this.cable_var = 0;
            this.gasleak = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\alphagasgiant\\gas_leak", 3906406241U);
            this.big_boom = Engine.GetTag<EffectTag>("effects\\scenarios\\solo\\alphagasgiant\\wall_explosion", 4221442405U);
            this.plummet_junk_total = 0;
            this.cinematic_shooting_done = false;
            this.banshee_sin_01_ready = false;
            this.banshee_sin_02_ready = false;
            this.monitor_done_talking = true;
            this.monitor_available = true;
            this.boss_done_talking = true;
            this.final_hl_boss_dead = false;
            this.heretic_leader = default(IGameObject);
            this.more_hl_orders = false;
            this.more_holo1_orders = false;
            this.more_holo2_orders = false;
            this.holo1 = default(IGameObject);
            this.holo2 = default(IGameObject);
            this.holo3 = default(IGameObject);
            this.holo4 = default(IGameObject);
            this.holo_death = Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_death", 3919382567U);
            this.holo_drones_nuke = false;
            this.hl_times_dead = 0;
            this.hl_lives_total = 0;
            this.hl_drone_total = 2;
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
        public async Task _04_intra0_predict_stub()
        {
            Engine.wake(_04_intra0_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _04_intra1_01_predict_stub()
        {
            Engine.wake(_04_intra1_01_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _04_intra1_02_predict_stub()
        {
            Engine.wake(_04_intra1_02_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _04_outro1_01_predict_stub()
        {
            Engine.wake(_04_outro1_01_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _04_outro1_02_predict_stub()
        {
            Engine.wake(_04_outro1_02_predict);
        }

        [ScriptMethod(Lifecycle.Stub)]
        public async Task _04_outro1_03_predict_stub()
        {
            Engine.print("predict 03");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _04_outro2_01_predict_stub()
        {
            Engine.wake(_04_outro2_01_predict);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task _04_outro2_02_predict_stub()
        {
            Engine.wake(_04_outro2_02_predict);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_intra0_score_01()
        {
            await Engine.sleep(369);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\music\\c04_intra0_01_mus", 3868329244U), default(IGameObject), 1F);
            Engine.print("c04_intra0 score 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_intra0_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\foley\\c04_intra0_01_fol", 3868394781U), default(IGameObject), 1F);
            Engine.print("c04_intra1 foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_1230_der()
        {
            await Engine.sleep(467);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1230_der", 3868460318U), dervish_intra0.Entity, 1F);
            Engine.cinematic_subtitle("c04_1230_der", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_1240_soc()
        {
            await Engine.sleep(493);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_1240_soc", 3868525855U), commander_intra0.Entity, 1F);
            Engine.cinematic_subtitle("c04_1240_soc", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_intra0_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            Engine.object_uses_cinematic_lighting(dervish_intra0.Entity, true);
            Engine.object_uses_cinematic_lighting(commander_intra0.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_intra0_01.Entity, true);
            Engine.object_uses_cinematic_lighting(elite_intra0_02.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_intra0_01.Entity, true);
            Engine.object_uses_cinematic_lighting(grunt_intra0_02.Entity, true);
            Engine.object_uses_cinematic_lighting(pr_intra0_der.Entity, true);
            Engine.object_uses_cinematic_lighting(eb_intra0_soc.Entity, true);
            Engine.object_uses_cinematic_lighting(pr_intra0_soe_01.Entity, true);
            Engine.object_uses_cinematic_lighting(pr_intra0_soe_02.Entity, true);
            Engine.object_uses_cinematic_lighting(pr_intra0_soe_03.Entity, true);
            Engine.object_uses_cinematic_lighting(pp_intra0_sog_01.Entity, true);
            Engine.object_uses_cinematic_lighting(pp_intra0_sog_02.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task soc_blade_activate()
        {
            await Engine.sleep(5);
            Engine.object_set_permutation(eb_intra0_soc.Entity, "blade", "default");
            Engine.print("blade activate");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra0_setup()
        {
            Engine.object_create_anew(dervish_intra0);
            Engine.object_create_anew(commander_intra0);
            Engine.object_create_anew_containing("elite_intra0");
            Engine.object_create_anew_containing("grunt_intra0");
            Engine.object_create_anew(eb_intra0_soc);
            Engine.object_create_anew(pr_intra0_soe_01);
            Engine.object_create_anew(pr_intra0_soe_02);
            Engine.object_create_anew(pr_intra0_soe_03);
            Engine.object_create_anew(pp_intra0_sog_01);
            Engine.object_create_anew(pp_intra0_sog_02);
            Engine.object_cinematic_lod(dervish_intra0.Entity, true);
            Engine.object_cinematic_lod(commander_intra0.Entity, true);
            Engine.object_cinematic_lod(elite_intra0_01.Entity, true);
            Engine.object_cinematic_lod(elite_intra0_02.Entity, true);
            Engine.object_cinematic_lod(grunt_intra0_01.Entity, true);
            Engine.object_cinematic_lod(grunt_intra0_02.Entity, true);
            Engine.object_cinematic_lod(eb_intra0_soc.Entity, true);
            Engine.object_cinematic_lod(pr_intra0_soe_01.Entity, true);
            Engine.object_cinematic_lod(pr_intra0_soe_02.Entity, true);
            Engine.object_cinematic_lod(pr_intra0_soe_03.Entity, true);
            Engine.object_cinematic_lod(pp_intra0_sog_01.Entity, true);
            Engine.object_cinematic_lod(pp_intra0_sog_02.Entity, true);
            Engine.cinematic_clone_players_weapon(dervish_intra0.Entity, "right_hand_elite", "");
            Engine.objects_attach(commander_intra0.Entity, "right_hand_elite", eb_intra0_soc.Entity, "");
            Engine.objects_attach(elite_intra0_01.Entity, "right_hand_elite", pr_intra0_soe_01.Entity, "");
            Engine.objects_attach(elite_intra0_01.Entity, "left_hand_elite", pr_intra0_soe_02.Entity, "");
            Engine.objects_attach(elite_intra0_02.Entity, "right_hand_elite", pr_intra0_soe_03.Entity, "");
            Engine.objects_attach(grunt_intra0_01.Entity, "right_hand", pp_intra0_sog_01.Entity, "");
            Engine.objects_attach(grunt_intra0_02.Entity, "right_hand", pp_intra0_sog_02.Entity, "");
            Engine.wake(c04_intra0_score_01);
            Engine.wake(c04_intra0_foley_01);
            Engine.wake(c04_1230_der);
            Engine.wake(c04_1240_soc);
            Engine.wake(soc_blade_activate);
            Engine.wake(c04_intra0_cinematic_light_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra0()
        {
            Engine.texture_cache_flush();
            Engine.geometry_cache_flush();
            Engine.cinematic_enable_ambience_details(false);
            Engine.sound_class_set_gain("device", 0.2F, 0);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("alphagasgiant"));
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("floodlab_intra0");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._04_intra0_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\music\\c04_intra0_01_mus", 3868329244U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra0\\foley\\c04_intra0_01_fol", 3868394781U));
            await Engine.sleep(this.prediction_offset);
            await this.c04_intra0_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intra0\\04_intra0", 3868591392U), "04_intra0", default(IUnit), anchor_flag_intra0);
            Engine.custom_animation_relative(dervish_intra0.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intra0\\04_intra0", 3868656929U), "dervish", false, anchor_intra0.Entity);
            Engine.custom_animation_relative(commander_intra0.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra0\\04_intra0", 3868788003U), "commander", false, anchor_intra0.Entity);
            Engine.custom_animation_relative(elite_intra0_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra0\\04_intra0", 3868788003U), "elite01", false, anchor_intra0.Entity);
            Engine.custom_animation_relative(elite_intra0_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra0\\04_intra0", 3868788003U), "elite02", false, anchor_intra0.Entity);
            Engine.custom_animation_relative(grunt_intra0_01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intra0\\04_intra0", 3868919077U), "grunt01", false, anchor_intra0.Entity);
            Engine.custom_animation_relative(grunt_intra0_02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\grunt\\04_intra0\\04_intra0", 3868919077U), "grunt02", false, anchor_intra0.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            Engine.device_set_power(arm_02_entry_ext.Entity, 0F);
            await Engine.sleep(30);
            Engine.device_set_power(arm_02_entry_ext.Entity, 1F);
            Engine.device_set_position(arm_02_entry_ext.Entity, 1F);
            await Engine.sleep(563);
            Engine.device_group_change_only_once_more_set(_04_intra0, false);
            Engine.device_set_position(arm_02_entry_ext.Entity, 0F);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            Engine.object_destroy_containing("intra0");
            Engine.sound_class_set_gain("device", 0F, 30);
            Engine.sound_class_set_gain("amb", 0F, 30);
            await Engine.sleep(30);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_intra1_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_01_fol", 3868984614U), default(IGameObject), 1F);
            Engine.print("c04_intra1 foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2010_her()
        {
            await Engine.sleep(45);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2010_her", 3869050151U), heretic_leader1.Entity, 1F);
            Engine.cinematic_subtitle("c04_2010_her", 2.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2020_her()
        {
            await Engine.sleep(121);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2020_her", 3869115688U), heretic_leader1.Entity, 1F);
            Engine.cinematic_subtitle("c04_2020_her", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2030_soc()
        {
            await Engine.sleep(249);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2030_soc", 3869181225U), default(IGameObject), 1F);
            Engine.cinematic_subtitle("c04_2030_soc", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task scale_hologram()
        {
            await Engine.sleep(615);
            Engine.object_set_scale(gasmine_hologram.Entity, 0.525F, 0);
            Engine.print("scale hologram");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_shield_impact()
        {
            await Engine.sleep(185);
            Engine.print("effect - shield impact");
            Engine.effect_new(Engine.GetTag<EffectTag>("effects\\impact\\impact_bullet_medium\\energy_shield_thin_cov", 3831759598U), flag_shield_impact);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_intra1_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            Engine.object_uses_cinematic_lighting(dervish02.Entity, true);
            Engine.object_uses_cinematic_lighting(heretic_leader1.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra1_02_problem_actors()
        {
            Engine.print("problem actors");
            Engine.object_create_anew(dervish02b);
            Engine.object_create_anew(commander);
            Engine.object_create_anew(elite01);
            Engine.object_create_anew(elite02);
            Engine.object_create_anew(intra1_blade);
            Engine.object_create_anew(intra1_rifle_01);
            Engine.object_create_anew(intra1_rifle_02);
            Engine.object_cinematic_lod(dervish02b.Entity, true);
            Engine.object_cinematic_lod(commander.Entity, true);
            Engine.object_cinematic_lod(elite01.Entity, true);
            Engine.object_cinematic_lod(elite02.Entity, true);
            Engine.object_cinematic_lod(intra1_blade.Entity, true);
            Engine.object_cinematic_lod(intra1_rifle_01.Entity, true);
            Engine.object_cinematic_lod(intra1_rifle_02.Entity, true);
            Engine.cinematic_clone_players_weapon(dervish02b.Entity, "right_hand_elite", "");
            Engine.objects_attach(commander.Entity, "right_hand_elite", intra1_blade.Entity, "");
            Engine.objects_attach(elite01.Entity, "right_hand_elite", intra1_rifle_01.Entity, "");
            Engine.objects_attach(elite02.Entity, "right_hand_elite", intra1_rifle_02.Entity, "");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra1_01_setup()
        {
            Engine.object_create_anew(dervish02);
            Engine.object_create_anew(heretic_leader1);
            Engine.object_cinematic_lod(dervish02.Entity, true);
            Engine.object_cinematic_lod(heretic_leader1.Entity, true);
            Engine.cinematic_clone_players_weapon(dervish02.Entity, "left_hand_elite", "");
            Engine.wake(c04_intra1_foley_01);
            Engine.wake(c04_2010_her);
            Engine.wake(c04_2020_her);
            Engine.wake(c04_2030_soc);
            Engine.wake(scale_hologram);
            Engine.wake(effect_shield_impact);
            Engine.wake(c04_intra1_cinematic_light_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra1_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("floodlab_intra1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(70F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._04_intra1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_01_fol", 3868984614U));
            await Engine.sleep(this.prediction_offset);
            await this.c04_intra1_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intra1\\04_intra1", 3869246762U), "04_intra1_01", default(IUnit), cinematic_anchor02);
            Engine.custom_animation_relative(dervish02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intra1\\04_intra1", 3869312299U), "dervish_01", false, anchor02.Entity);
            Engine.custom_animation_relative(heretic_leader1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_intra1\\04_intra1", 3869377836U), "heretic_01", false, anchor02.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep(165);
            Engine.device_set_position(control_shield_door.Entity, 0F);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_intra1_02_predict_stub();
            await this.c04_intra1_02_problem_actors();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_02_fol", 3869443373U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.object_destroy(dervish02.Entity);
            Engine.object_set_scale(gasmine_hologram.Entity, 1F, 0);
            Engine.print("scale hologram");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_intra1_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_intra1\\foley\\c04_intra1_02_fol", 3869443373U), default(IGameObject), 1F);
            Engine.print("c04_intra1 foley 02 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2031_soc()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2031_soc", 3869508910U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_2031_soc", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2040_soc()
        {
            await Engine.sleep(96);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2040_soc", 3869574447U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_2040_soc", 3F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2050_soc()
        {
            await Engine.sleep(178);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2050_soc", 3869639984U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_2050_soc", 1.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2060_der()
        {
            await Engine.sleep(229);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2060_der", 3869705521U), dervish02b.Entity, 1F);
            Engine.cinematic_subtitle("c04_2060_der", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2070_soc()
        {
            await Engine.sleep(292);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2070_soc", 3869771058U), commander.Entity, 1F);
            Engine.cinematic_subtitle("c04_2070_soc", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2080_der()
        {
            await Engine.sleep(335);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2080_der", 3869836595U), dervish02b.Entity, 1F);
            Engine.cinematic_subtitle("c04_2080_der", 3.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_2090_der()
        {
            await Engine.sleep(482);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_2090_der", 3869902132U), dervish02b.Entity, 1F);
            Engine.cinematic_subtitle("c04_2090_der", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_intra1_cinematic_light_02()
        {
            Engine.cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            Engine.object_uses_cinematic_lighting(dervish02b.Entity, true);
            Engine.object_uses_cinematic_lighting(commander.Entity, true);
            Engine.object_uses_cinematic_lighting(elite01.Entity, true);
            Engine.object_uses_cinematic_lighting(elite02.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra1_02_setup()
        {
            Engine.wake(c04_intra1_foley_02);
            Engine.wake(c04_2031_soc);
            Engine.wake(c04_2040_soc);
            Engine.wake(c04_2050_soc);
            Engine.wake(c04_2060_der);
            Engine.wake(c04_2070_soc);
            Engine.wake(c04_2080_der);
            Engine.wake(c04_2090_der);
            Engine.wake(c04_intra1_cinematic_light_02);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra1_02_cleanup()
        {
            Engine.object_destroy(dervish02b.Entity);
            Engine.object_destroy(commander.Entity);
            Engine.object_destroy(elite01.Entity);
            Engine.object_destroy(elite02.Entity);
            Engine.object_destroy_containing("intra1");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra1_02()
        {
            await this.c04_intra1_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_intra1\\04_intra1", 3869246762U), "04_intra1_02", default(IUnit), cinematic_anchor02);
            Engine.custom_animation_relative(dervish02b.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_intra1\\04_intra1", 3869312299U), "dervish_02", false, anchor02.Entity);
            Engine.custom_animation_relative(commander.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra1\\04_intra1", 3869967669U), "soc_02", false, anchor02.Entity);
            Engine.custom_animation_relative(elite01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra1\\04_intra1", 3869967669U), "elite01_02", false, anchor02.Entity);
            Engine.custom_animation_relative(elite02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\04_intra1\\04_intra1", 3869967669U), "elite02_02", false, anchor02.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            Engine.sound_class_set_gain("amb", 0F, 15);
            await Engine.sleep(15);
            await this.c04_intra1_02_cleanup();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_intra1()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.geometry_cache_flush();
            Engine.texture_cache_flush();
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("alphagasgiant"));
            await Engine.sleep(1);
            await this.c04_intra1_01();
            await this.c04_intra1_02();
            await Engine.sleep(30);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\music\\c04_outro1_01_mus", 3870033206U), default(IGameObject), 1F);
            Engine.print("c04_outro1 score 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_01_fol", 3870098743U), default(IGameObject), 1F);
            Engine.print("c04_outro1 foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3010_der()
        {
            await Engine.sleep(118);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3010_der", 3870164280U), dervish_03.Entity, 1F);
            Engine.cinematic_subtitle("c04_3010_der", 1.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3020_her()
        {
            await Engine.sleep(197);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3020_her", 3870229817U), heretic_leader1.Entity, 1F);
            Engine.cinematic_subtitle("c04_3020_her", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3030_her()
        {
            await Engine.sleep(243);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3030_her", 3870295354U), heretic_leader1.Entity, 1F);
            Engine.cinematic_subtitle("c04_3030_her", 4.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3040_der()
        {
            await Engine.sleep(385);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3040_der", 3870360891U), dervish_03.Entity, 1F);
            Engine.cinematic_subtitle("c04_3040_der", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_01_dof()
        {
            Engine.time_code_reset();
            await Engine.sleep(382);
            Engine.cinematic_screen_effect_start(true);
            Engine.cinematic_screen_effect_set_depth_of_field(1F, 1.5F, 1.5F, 0F, 0F, 0F, 0F);
            Engine.print("rack focus");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            Engine.object_uses_cinematic_lighting(dervish_03.Entity, true);
            Engine.object_uses_cinematic_lighting(heretic_leader1.Entity, true);
            Engine.object_uses_cinematic_lighting(outro_seraph.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1_01_setup()
        {
            Engine.object_destroy(seraph.Entity);
            Engine.object_create(outro_seraph);
            Engine.object_create_anew(dervish_03);
            Engine.object_create_anew(heretic_leader1);
            Engine.object_cinematic_lod(dervish_03.Entity, true);
            Engine.object_cinematic_lod(heretic_leader1.Entity, true);
            Engine.cinematic_clone_players_weapon(dervish_03.Entity, "right_hand_elite", "");
            Engine.wake(c04_outro1_score_01);
            Engine.wake(c04_outro1_foley_01);
            Engine.wake(c04_3010_der);
            Engine.wake(c04_3020_her);
            Engine.wake(c04_3030_her);
            Engine.wake(c04_3040_der);
            Engine.wake(c04_outro1_01_dof);
            Engine.wake(c04_outro1_cinematic_light_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("floodlab_outro1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._04_outro1_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\music\\c04_outro1_01_mus", 3870033206U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_01_fol", 3870098743U));
            await Engine.sleep(this.prediction_offset);
            await this.c04_outro1_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro1\\04_outro1", 3870426428U), "04_outro1_01", default(IUnit), anchor_flag_seraph);
            Engine.custom_animation_relative(dervish_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro1\\04_outro1", 3870491965U), "dervish_01", false, anchor02.Entity);
            Engine.custom_animation_relative(heretic_leader1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3870557502U), "heretic_01", false, anchor02.Entity);
            Engine.scenery_animation_start_relative(outro_seraph.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3870623039U), "04_outro1_01", anchor_seraph.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_outro1_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_02_fol", 3870688576U));
            await Engine.sleep((short)Engine.camera_time());
            Engine.cinematic_screen_effect_stop();
            Engine.print("rack focus stop");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_02_fol", 3870688576U), default(IGameObject), 1F);
            Engine.print("c04_outro1 foley 02 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3050_der()
        {
            await Engine.sleep(132);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3050_der", 3870754113U), dervish_03.Entity, 1F);
            Engine.cinematic_subtitle("c04_3050_der", 1.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3060_gsp()
        {
            await Engine.sleep(190);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3060_gsp", 3870819650U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c04_3060_gsp", 6F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3070_her()
        {
            await Engine.sleep(363);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3070_her", 3870885187U), heretic_leader1.Entity, 1F);
            Engine.cinematic_subtitle("c04_3070_her", 5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3080_gsp()
        {
            await Engine.sleep(516);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3080_gsp", 3870950724U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c04_3080_gsp", 3.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_cinematic_light_02()
        {
            Engine.cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            Engine.object_uses_cinematic_lighting(monitor.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task heretic_leader_fire_rifles()
        {
            Engine.object_create_anew(hl_rifle_01);
            Engine.object_create_anew(hl_rifle_02);
            await Engine.sleep(623);
            Engine.objects_attach(heretic_leader1.Entity, "right_hand_elite", hl_rifle_01.Entity, "");
            Engine.objects_attach(heretic_leader1.Entity, "left_hand_elite", hl_rifle_02.Entity, "");
            await Engine.sleep(1);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("hl_rifle_01"), 0, true);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("hl_rifle_02"), 0, true);
            Engine.print("heretic rifles fire");
            await Engine.sleep(85);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("hl_rifle_01"), 0, false);
            Engine.weapon_hold_trigger(Engine.GetReference<IWeaponReference>("hl_rifle_02"), 0, false);
            Engine.print("heretic rifles stop");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_jetpack()
        {
            await Engine.sleep(735);
            Engine.print("jetpack on");
            Engine.object_set_function_variable(heretic_leader1.Entity, "vertical_thrust", 1F, 0F);
            await Engine.sleep(154);
            Engine.object_set_function_variable(heretic_leader1.Entity, "vertical_thrust", 0F, 0F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1_02_setup()
        {
            Engine.object_create_anew(monitor);
            Engine.object_cinematic_lod(monitor.Entity, true);
            Engine.wake(c04_outro1_foley_02);
            Engine.wake(c04_3050_der);
            Engine.wake(c04_3060_gsp);
            Engine.wake(c04_3070_her);
            Engine.wake(c04_3080_gsp);
            Engine.wake(heretic_leader_fire_rifles);
            Engine.wake(effect_jetpack);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1_02()
        {
            await this.c04_outro1_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro1\\04_outro1", 3870426428U), "04_outro1_02", default(IUnit), anchor_flag_seraph);
            Engine.custom_animation_relative(dervish_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro1\\04_outro1", 3870491965U), "dervish_02", false, anchor02.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro1\\04_outro1", 3871016261U), "monitor_02", false, anchor02.Entity);
            Engine.custom_animation_relative(heretic_leader1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3870557502U), "heretic_02", false, anchor02.Entity);
            Engine.scenery_animation_start_relative(outro_seraph.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3870623039U), "04_outro1_02", anchor_seraph.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_outro1_03_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_03_fol", 3871081798U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_foley_03()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro1\\foley\\c04_outro1_03_fol", 3871081798U), default(IGameObject), 1F);
            Engine.print("c04_outro1 foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3090_her()
        {
            await Engine.sleep(29);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3090_her", 3871147335U), heretic_leader1.Entity, 1F);
            Engine.cinematic_subtitle("c04_3090_her", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_3100_her()
        {
            await Engine.sleep(108);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_3100_her", 3871212872U), heretic_leader1.Entity, 1F);
            Engine.cinematic_subtitle("c04_3100_her", 2.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_drone_activate()
        {
            await Engine.sleep(162);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_activate", 3871278409U), holo_drone_1.Entity, "light");
            Engine.print("effect - drone 1");
            await Engine.sleep(13);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_activate", 3871278409U), holo_drone_2.Entity, "light");
            Engine.print("effect - drone 2");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_holograms_appear()
        {
            await Engine.sleep(477);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_holo_on_cinematic", 3871606094U), holo_base_1.Entity, "marker");
            Engine.print("effect - hologram 1");
            await Engine.sleep(18);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_holo_on_cinematic", 3871606094U), holo_base_2.Entity, "marker");
            Engine.print("effect - hologram 2");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task arm_holograms()
        {
            Engine.time_code_reset();
            await Engine.sleep(546);
            Engine.object_create_anew_containing("holo_rifle");
            Engine.objects_attach(hologram01.Entity, "right_hand_elite", holo_rifle_01.Entity, "");
            Engine.objects_attach(hologram01.Entity, "left_hand_elite", holo_rifle_02.Entity, "");
            Engine.objects_attach(hologram02.Entity, "right_hand_elite", holo_rifle_03.Entity, "");
            Engine.objects_attach(hologram02.Entity, "left_hand_elite", holo_rifle_04.Entity, "");
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1_03_setup()
        {
            Engine.object_create_anew(holo_base_1);
            Engine.object_create_anew(holo_base_2);
            Engine.object_create_anew(holo_drone_1);
            Engine.object_create_anew(holo_drone_2);
            Engine.object_cinematic_lod(holo_drone_1.Entity, true);
            Engine.object_cinematic_lod(holo_drone_2.Entity, true);
            Engine.object_destroy(hl_rifle_01.Entity);
            Engine.object_destroy(hl_rifle_02.Entity);
            Engine.wake(c04_outro1_foley_03);
            Engine.wake(c04_3090_her);
            Engine.wake(c04_3100_her);
            Engine.wake(arm_holograms);
            Engine.wake(effect_drone_activate);
            Engine.wake(effect_holograms_appear);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1_03_cleanup()
        {
            Engine.object_destroy(dervish_03.Entity);
            Engine.object_destroy(heretic_leader1.Entity);
            Engine.object_destroy(monitor.Entity);
            Engine.object_destroy(hologram01.Entity);
            Engine.object_destroy(hologram02.Entity);
            Engine.object_destroy(holo_drone_1.Entity);
            Engine.object_destroy(holo_drone_2.Entity);
            Engine.object_destroy_containing("holo_rifle");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_03_holo1()
        {
            await Engine.sleep(478);
            Engine.object_create_anew(hologram01);
            Engine.object_cinematic_lod(hologram01.Entity, true);
            Engine.custom_animation_relative(hologram01.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3870557502U), "holo1_03", false, anchor02.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro1_03_holo2()
        {
            await Engine.sleep(490);
            Engine.object_create_anew(hologram02);
            Engine.object_cinematic_lod(hologram02.Entity, true);
            Engine.custom_animation_relative(hologram02.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3870557502U), "holo2_03", false, anchor02.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1_03()
        {
            await this.c04_outro1_03_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro1\\04_outro1", 3870426428U), "04_outro1_03", default(IUnit), anchor_flag_seraph);
            Engine.custom_animation_relative(dervish_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro1\\04_outro1", 3870491965U), "dervish_03", false, anchor02.Entity);
            Engine.custom_animation_relative(heretic_leader1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro1\\04_outro1", 3870557502U), "heretic_03", false, anchor02.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro1\\04_outro1", 3871016261U), "monitor_03", false, anchor02.Entity);
            Engine.scenery_animation_start_relative(outro_seraph.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3870623039U), "04_outro1_03", anchor_seraph.Entity);
            Engine.scenery_animation_start_relative(holo_drone_1.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3871999316U), "outro1_01", anchor02.Entity);
            Engine.scenery_animation_start_relative(holo_drone_2.Entity, Engine.GetTag<AnimationGraphTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3871999316U), "outro1_02", anchor02.Entity);
            Engine.wake(c04_outro1_03_holo1);
            Engine.wake(c04_outro1_03_holo2);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(15);
            await this.c04_outro1_03_cleanup();
            Engine.sound_class_set_gain("amb", 0F, 30);
            await Engine.sleep(30);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro1()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.geometry_cache_flush();
            Engine.texture_cache_flush();
            Engine.cinematic_enable_ambience_details(false);
            Engine.sound_class_set_gain("amb", 0.5F, 0);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("production_arm2"));
            await Engine.sleep(1);
            await this.c04_outro1_01();
            await this.c04_outro1_02();
            await this.c04_outro1_03();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro2_score_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\music\\c04_outro2_01_mus", 3872064853U), default(IGameObject), 1F);
            Engine.print("c04_outro2 score 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro2_foley_01()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_01_fol", 3872130390U), default(IGameObject), 1F);
            Engine.print("c04_outro2 foley 01 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_9110_gsp()
        {
            await Engine.sleep(32);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9110_gsp", 3872195927U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c04_9110_gsp", 3.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_9120_der()
        {
            await Engine.sleep(133);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9120_der", 3872261464U), dervish_03.Entity, 1F);
            Engine.cinematic_subtitle("c04_9120_der", 5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_9130_gsp()
        {
            await Engine.sleep(274);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9130_gsp", 3872327001U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c04_9130_gsp", 5.5F);
            await Engine.sleep(150);
            Engine.unit_set_emotional_state(dervish_03.Entity, "shocked", 0.75F, 30);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_monitor_scramble()
        {
            await Engine.sleep(423);
            Engine.print("effect - monitor scramble");
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\brute\\hammer_grappling", 3872392538U), monitor.Entity, "body");
            Engine.player_effect_set_max_rotation(0F, 1F, 1F);
            Engine.player_effect_start(0.25F, 0F);
            Engine.player_effect_stop(1.5F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro2_cinematic_light_01()
        {
            Engine.cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            Engine.object_uses_cinematic_lighting(dervish_03.Entity, true);
            Engine.object_uses_cinematic_lighting(heretic_leader1.Entity, true);
            Engine.object_uses_cinematic_lighting(monitor.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro2_01_setup()
        {
            Engine.object_destroy(hangar_door_ingame.Entity);
            Engine.object_create_anew(hangar_door_cinematic);
            Engine.device_set_position(hangar_door_cinematic.Entity, 1F);
            Engine.object_create_anew(dervish_03);
            Engine.object_create_anew(heretic_leader1);
            Engine.object_create_anew(monitor);
            Engine.object_cinematic_lod(dervish_03.Entity, true);
            Engine.object_cinematic_lod(heretic_leader1.Entity, true);
            Engine.object_cinematic_lod(monitor.Entity, true);
            Engine.object_set_function_variable(heretic_leader1.Entity, "alive", 0F, 0F);
            Engine.wake(c04_outro2_score_01);
            Engine.wake(c04_outro2_foley_01);
            Engine.wake(c04_9110_gsp);
            Engine.wake(c04_9120_der);
            Engine.wake(c04_9130_gsp);
            Engine.wake(effect_monitor_scramble);
            Engine.wake(c04_outro2_cinematic_light_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro2_01()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.camera_control(true);
            Engine.cinematic_start_movie("floodlab_outro2");
            Engine.cinematic_start();
            Engine.cinematic_outro_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(70F, 0);
            Engine.cinematic_lightmap_shadow_enable();
            await this._04_outro2_01_predict_stub();
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\music\\c04_outro2_01_mus", 3872064853U));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_01_fol", 3872130390U));
            await Engine.sleep(this.prediction_offset);
            await this.c04_outro2_01_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro2\\04_outro2", 3872720223U), "04_outro2_01", default(IUnit), cinematic_anchor02);
            Engine.custom_animation_relative(dervish_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro2\\04_outro2", 3872785760U), "dervish_01", false, anchor02.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro2\\04_outro2", 3872851297U), "monitor_01", false, anchor02.Entity);
            Engine.custom_animation_relative(heretic_leader1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro2\\04_outro2", 3872916834U), "heretic_01", false, anchor02.Entity);
            Engine.fade_in(1F, 1F, 1F, 15);
            await Engine.sleep((short)((float)Engine.camera_time() - this.prediction_offset));
            await this._04_outro2_02_predict_stub();
            await Engine.sleep((short)((float)Engine.camera_time() - this.sound_offset));
            Engine.sound_impulse_predict(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_02_fol", 3872982371U));
            await Engine.sleep((short)Engine.camera_time());
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro2_foley_02()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\cinematics\\04_alphagas\\c04_outro2\\foley\\c04_outro2_02_fol", 3872982371U), default(IGameObject), 1F);
            Engine.print("c04_outro2 foley 02 start");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_9140_gsp()
        {
            await Engine.sleep(0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9140_gsp", 3873047908U), monitor.Entity, 1F);
            Engine.cinematic_subtitle("c04_9140_gsp", 2F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_9150_der()
        {
            await Engine.sleep(146);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9150_der", 3873113445U), dervish_03.Entity, 1F);
            Engine.cinematic_subtitle("c04_9150_der", 2F);
            await Engine.sleep(127);
            Engine.unit_set_emotional_state(tartarus.Entity, "repulsed", 1F, 60);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_9160_tar()
        {
            await Engine.sleep(236);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9160_tar", 3873178982U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c04_9160_tar", 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_9170_tar()
        {
            await Engine.sleep(300);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\levels\\04_gasgiant\\cinematic\\c04_9170_tar", 3873244519U), tartarus.Entity, 1F);
            Engine.cinematic_subtitle("c04_9170_tar", 2F);
            Engine.unit_set_emotional_state(tartarus.Entity, "annoyed", 1F, 60);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task effect_monitor_yank()
        {
            Engine.time_code_reset();
            await Engine.sleep(190);
            Engine.print("effect - monitor yank");
            Engine.object_set_function_variable(monitor.Entity, "talking", 0F, 0F);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\objects\\characters\\monitor\\monitor_scrambled", 3873310056U), monitor.Entity, "body");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task c04_outro2_cinematic_light_02()
        {
            Engine.cinematic_lighting_set_primary_light(55F, 138F, 0.26F, 0.24F, 0.15F);
            Engine.cinematic_lighting_set_secondary_light(-28F, 358F, 0.08F, 0.08F, 0.11F);
            Engine.cinematic_lighting_set_ambient_light(0.03F, 0.03F, 0.03F);
            Engine.object_uses_cinematic_lighting(tartarus.Entity, true);
            Engine.object_uses_cinematic_lighting(hammer.Entity, true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro2_02_setup()
        {
            Engine.object_create_anew(tartarus);
            Engine.object_create_anew(hammer);
            Engine.object_create_anew(phantom_outro2);
            Engine.object_cinematic_lod(tartarus.Entity, true);
            Engine.object_cinematic_lod(hammer.Entity, true);
            Engine.object_cinematic_lod(phantom_outro2.Entity, true);
            Engine.unit_set_emotional_state(tartarus.Entity, "pensive", 1F, 0);
            Engine.wake(c04_outro2_foley_02);
            Engine.wake(c04_9140_gsp);
            Engine.wake(c04_9150_der);
            Engine.wake(c04_9160_tar);
            Engine.wake(c04_9170_tar);
            Engine.wake(effect_monitor_yank);
            Engine.wake(c04_outro2_cinematic_light_02);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro2_02_cleanup()
        {
            Engine.object_destroy(dervish_03.Entity);
            Engine.object_destroy(heretic_leader1.Entity);
            Engine.object_destroy(monitor.Entity);
            Engine.object_destroy(tartarus.Entity);
            Engine.object_destroy(hammer.Entity);
            Engine.object_destroy(phantom_outro2.Entity);
            Engine.sound_class_set_gain("amb", 1F, 2);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro2_02()
        {
            await this.c04_outro2_02_setup();
            Engine.camera_set_animation_relative(Engine.GetTag<AnimationGraphTag>("objects\\characters\\cinematic_camera\\04_outro2\\04_outro2", 3872720223U), "04_outro2_02", default(IUnit), cinematic_anchor02);
            Engine.custom_animation_relative(dervish_03.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\dervish\\04_outro2\\04_outro2", 3872785760U), "dervish_02", false, anchor02.Entity);
            Engine.custom_animation_relative(monitor.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\monitor\\04_outro2\\04_outro2", 3872851297U), "monitor_02", false, anchor02.Entity);
            Engine.custom_animation_relative(heretic_leader1.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\heretic\\04_outro2\\04_outro2", 3872916834U), "heretic_02", false, anchor02.Entity);
            Engine.custom_animation_relative(tartarus.Entity, Engine.GetTag<AnimationGraphTag>("objects\\characters\\brute\\04_outro2\\04_outro2", 3873375593U), "tartarus_02", false, anchor02.Entity);
            Engine.scenery_animation_start_relative(hammer.Entity, Engine.GetTag<AnimationGraphTag>("objects\\weapons\\melee\\gravity_hammer\\04_outro2\\04_outro2", 3873506667U), "hammer_02", anchor02.Entity);
            Engine.custom_animation_relative(phantom_outro2.Entity, Engine.GetTag<AnimationGraphTag>("objects\\vehicles\\phantom\\animations\\04_outro2\\04_outro2", 3873572204U), "phantom_02", false, anchor02.Entity);
            await Engine.sleep((short)((float)Engine.camera_time() - 15));
            Engine.fade_out(0F, 0F, 0F, 15);
            await Engine.sleep(15);
            await this.c04_outro2_02_cleanup();
            Engine.sound_class_set_gain("amb", 0F, 30);
            await Engine.sleep(30);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task c04_outro2()
        {
            Engine.fade_out(1F, 1F, 1F, 0);
            Engine.geometry_cache_flush();
            Engine.texture_cache_flush();
            Engine.cinematic_enable_ambience_details(false);
            Engine.sound_class_set_gain("amb", 0.5F, 0);
            Engine.switch_bsp_by_name(Engine.GetReference<IBsp>("production_arm2"));
            await Engine.sleep(1);
            await this.c04_outro2_01();
            await this.c04_outro2_02();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task abort()
        {
            Engine.cs_pause(0.1F);
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

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04b_title0()
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
        public async Task _04b_title1()
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
        public async Task _04b_title2()
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
        public async Task objective_labs_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("escape the infested labs.");
            Engine.objectives_show_up_to(0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_labs_clear()
        {
            Engine.print("objective complete:");
            Engine.print("escape the infested labs.");
            Engine.objectives_finish_up_to(0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_control_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("ascertain the heretic leader's whereabouts.");
            Engine.objectives_show_up_to(1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_control_clear()
        {
            Engine.print("objective complete:");
            Engine.print("ascertain the heretic leader's whereabouts.");
            Engine.objectives_finish_up_to(1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_cables_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("sever the tether holding the station aloft.");
            Engine.objectives_show_up_to(2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_cables_clear()
        {
            Engine.print("objective complete:");
            Engine.print("sever the tether holding the station aloft.");
            Engine.objectives_finish_up_to(2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_dogfight_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("pursue the heretic leader back to the hangar.");
            Engine.objectives_show_up_to(3);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_dogfight_clear()
        {
            Engine.print("objective complete:");
            Engine.print("pursue the heretic leader back to the hangar.");
            Engine.objectives_finish_up_to(3);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_hl_set()
        {
            await Engine.sleep(30);
            Engine.print("new objective set:");
            Engine.print("kill the heretic leader.");
            Engine.objectives_show_up_to(4);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task objective_hl_clear()
        {
            Engine.print("objective complete:");
            Engine.print("kill the heretic leader.");
            Engine.objectives_finish_up_to(4);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_01_start()
        {
            Engine.print("music 04b_01 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_01", 4217706796U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_01_stop()
        {
            Engine.print("music 04b_01 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_01", 4217706796U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_02_start()
        {
            Engine.print("music 04b_02 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_02", 4218100018U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_02_stop()
        {
            Engine.print("music 04b_02 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_02", 4218100018U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_03_start()
        {
            Engine.print("music 04b_03 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4218493240U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task music_04b_03_start_alt()
        {
            Engine.print("music 04b_03 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4218493240U), true);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task music_04b_03_stop_alt()
        {
            Engine.print("music 04b_03 stop alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4218493240U), false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_03_stop()
        {
            Engine.print("music 04b_03 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_03", 4218493240U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_04_start()
        {
            Engine.print("music 04b_04 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4219083073U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_04_start_alt()
        {
            Engine.print("music 04b_04 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4219083073U), true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_04_stop_alt()
        {
            Engine.print("music 04b_04 stop alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4219083073U), false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_04_stop()
        {
            Engine.print("music 04b_04 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_04", 4219083073U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_05_start()
        {
            Engine.print("music 04b_05 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_05", 4219279684U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_06_start()
        {
            Engine.print("music 04b_06 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_06", 4219541832U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_07_start()
        {
            Engine.print("music 04b_07 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_07", 4219935054U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_08_start()
        {
            Engine.print("music 04b_08 start");
            Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_08", 4220197202U), default(IGameObject), 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_08_start_alt()
        {
            Engine.print("music 04b_08 start alt");
            Engine.sound_looping_set_alternate(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_08", 4220197202U), true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task music_04b_08_stop()
        {
            Engine.print("music 04b_08 stop");
            Engine.sound_looping_stop(Engine.GetTag<LoopingSoundTag>("scenarios\\solo\\04b_floodlab\\04b_music\\04b_08", 4220197202U));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task kill_volumes()
        {
            Engine.kill_volume_disable(kill_hangar_pit_01);
            Engine.kill_volume_disable(kill_hangar_pit_02);
            Engine.kill_volume_disable(kill_hangar_pit_03);
            Engine.kill_volume_disable(kill_hangar_pit_04);
            Engine.kill_volume_disable(kill_underhangar_pit_01);
            Engine.kill_volume_disable(kill_underhangar_pit_02);
            Engine.kill_volume_disable(kill_bottling_pit_01);
            Engine.kill_volume_disable(kill_bottling_pit_02);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.kill_volume_disable(kill_silo_pit);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.kill_volume_disable(kill_wraparound);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.kill_volume_enable(kill_bottling_pit_01);
            Engine.kill_volume_enable(kill_bottling_pit_02);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 5);
                Engine.kill_volume_disable(kill_bottling_pit_01);
                Engine.kill_volume_disable(kill_bottling_pit_02);
                Engine.kill_volume_enable(kill_hangar_pit_01);
                Engine.kill_volume_enable(kill_hangar_pit_02);
                Engine.kill_volume_enable(kill_hangar_pit_03);
                Engine.kill_volume_enable(kill_hangar_pit_04);
                Engine.kill_volume_enable(kill_underhangar_pit_01);
                Engine.kill_volume_enable(kill_underhangar_pit_02);
                await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
                Engine.kill_volume_enable(kill_bottling_pit_01);
                Engine.kill_volume_enable(kill_bottling_pit_02);
                Engine.kill_volume_disable(kill_hangar_pit_01);
                Engine.kill_volume_disable(kill_hangar_pit_02);
                Engine.kill_volume_disable(kill_hangar_pit_03);
                Engine.kill_volume_disable(kill_hangar_pit_04);
                Engine.kill_volume_disable(kill_underhangar_pit_01);
                Engine.kill_volume_disable(kill_underhangar_pit_02);
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cableroom_killer()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_object(vol_croom_kill_new, await this.player0()) == true || Engine.volume_test_object(vol_croom_kill_new_too, await this.player0()) == true)
                {
                    Engine.unit_kill(Engine.unit(await this.player0()));
                }

                if (Engine.volume_test_object(vol_croom_kill_new, await this.player1()) == true || Engine.volume_test_object(vol_croom_kill_new_too, await this.player1()) == true)
                {
                    Engine.unit_kill(Engine.unit(await this.player1()));
                }

                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cableroom_junk_killer()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep(90);
                Engine.garbage_collect_now();
                return (short)Engine.structure_bsp_index() == 1;
            });
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task prep_return_from_intro()
        {
            Engine.data_mine_set_mission_segment("04b_1_entry");
            Engine.ai_place(disposal_commander.Squad, 1);
            Engine.ai_cannot_die(disposal_commander.Squad, true);
            Engine.ai_place(allies_elites_03a.Squad, 1);
            Engine.ai_place(allies_elites_03b.Squad, 1);
            Engine.ai_place(allies_grunts_03.Squad, 2);
            await Engine.sleep(30);
            Engine.object_teleport(await this.player0(), research_player0);
            Engine.object_teleport(await this.player1(), research_player1);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task juggernaut_gosh()
        {
            Engine.cs_switch("elite");
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_moving(true);
            Engine.print("spec-ops elite: 'by the rings! what is that?!'");
            Engine.cs_play_line("0550");
            await Engine.sleep(30);
            Engine.cs_switch("grunt");
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_moving(true);
            Engine.print("spec-ops grunt: (nervous grunts and whines)");
            Engine.cs_play_line("0560");
            await Engine.sleep(30);
            Engine.cs_switch("elite");
            Engine.print("spec-ops elite: 'quiet!'");
            Engine.cs_play_line("0570");
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(disposal_entry_flood.Squad) == 0, 30, 300);
            await Engine.sleep(60);
            Engine.print("spec-ops elite: 'it's moved on.'");
            Engine.cs_play_line("0580");
            await Engine.sleep(30);
            Engine.print("spec-ops elite: 'quickly, before it returns! let's find the heretic leader, and finish him off!'");
            Engine.cs_play_line("0590");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task disposal_juggernaut_exit()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("disposal_chamber/juggs"));
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task arm_02_entry_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_juggernaut_preview, Engine.players()) == true);
            Engine.ai_set_orders(all_allies, allies_disposal);
            Engine.sound_class_set_gain("unit_animation", 0.5F, 1);
            Engine.ai_place(disposal_entry_flood.Squad, 4);
            Engine.ai_cannot_die(disposal_entry_flood.Squad, true);
            Engine.ai_place(disposal_entry_heretics.Squad, 4);
            Engine.units_set_maximum_vitality(Engine.ai_actors(disposal_entry_heretics.Squad), 20F, 20F);
            Engine.units_set_current_vitality(Engine.ai_actors(disposal_entry_heretics.Squad), 20F, 20F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_juggernaut_preview, Engine.ai_actors(allies_elites)) == true && Engine.volume_test_objects(vol_juggernaut_preview, Engine.ai_actors(allies_grunts_03.Squad)) == true, 30, 450);
            await Engine.sleep_until(async () => Engine.ai_scene("juggernaut_gosh_scene", juggernaut_gosh, all_allies), 30, 450);
            await Engine.sleep(90);
            Engine.wake(music_04b_01_start);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(disposal_entry_heretics.Squad) == 0, 30, 300);
            Engine.ai_kill_silent(disposal_entry_heretics.Squad);
            Engine.cs_run_command_script(disposal_entry_flood.Squad, disposal_juggernaut_exit);
            Engine.sound_class_set_gain("unit_animation", 1F, 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task juggernaut_abort()
        {
            if (Engine.cs_command_script_running(all_allies, juggernaut_gosh))
            {
                Engine.cs_run_command_script(all_allies, abort);
            }
            else
            {
                Engine.sound_class_set_gain("unit_animation", 1F, 1);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task holo_drone_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_shoot(false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("disposal_chamber/p0"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("disposal_chamber/p1"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("disposal_chamber/p2"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("disposal_chamber/p3"));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("disposal_chamber/p4"));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("disposal_chamber/p5"), 0.5F);
            this.holo_drone_arrived = true;
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task disposal_ally_comment_01()
        {
            Engine.cs_switch("so_elite");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.print("spec-ops elite: 'what happened here?'");
            Engine.cs_play_line("0010");
            this.mess_react_01_done = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task disposal_ally_comment_02()
        {
            Engine.cs_switch("grunt_01");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.print("spec-ops grunt: 'me have bad feeling 'bout this.'");
            Engine.cs_play_line("0600");
            Engine.cs_switch("grunt_02");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.print("spec-ops grunt: 'you always have bad feeling!'");
            Engine.cs_play_line("0610");
            await Engine.sleep(10);
            Engine.print("spec-ops grunt: 'you had bad feeling about morning food-nipple!'");
            Engine.cs_play_line("0620");
            Engine.cs_switch("elite_01");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.print("spec-ops elite: 'close your jaws, or i shall bind them shut!'");
            Engine.cs_play_line("0630");
            this.mess_react_02_done = true;
            Engine.cs_switch("grunt_02");
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("disposal_grunts"));
            Engine.cs_switch("grunt_01");
            Engine.cs_go_to_nearest(Engine.GetReference<ISpatialPoint>("disposal_grunts"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hologram_face()
        {
            Engine.cs_start_approach(drone_spawn.Entity, 3F, 20F, 20F);
            Engine.cs_aim_object(true, Engine.list_get(Engine.ai_actors(hl_hologram.Squad), 0));
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hl_hologram.Squad) == 0, 30, 900);
            Engine.cs_aim_object(false, Engine.list_get(Engine.ai_actors(hl_hologram.Squad), 0));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hologram_ally_01()
        {
            this.holo_ally_01_go = true;
            Engine.cs_switch("so_grunt");
            Engine.cs_aim_object(true, Engine.list_get(Engine.ai_actors(hl_hologram.Squad), 0));
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true, Engine.list_get(Engine.ai_actors(hl_hologram.Squad), 0));
            Engine.print("spec-ops grunt: 'see! heretic!'");
            Engine.cs_play_line("0020");
            await Engine.sleep(60);
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'hold your fire! hold your fire!'");
            Engine.cs_play_line("0030");
            Engine.cs_switch("so_grunt");
            Engine.cs_shoot(false);
            this.holo_ally_01_done = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hologram_ally_02()
        {
            this.holo_ally_02_go = true;
            Engine.cs_switch("heretic_leader");
            Engine.cs_face_player(true);
            Engine.print("heretic leader: 'i wondered who the prophets would send to silence me. an arbiter. i'm flattered.'");
            Engine.cs_play_line("0040");
            this.holo_ally_02_done = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hologram_ally_03()
        {
            this.holo_ally_03_go = true;
            Engine.cs_switch("commander");
            Engine.cs_start_approach(drone_spawn.Entity, 2F, 20F, 20F);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            Engine.print("spec-ops commander: 'he's using a holo-drone. he must be close!'");
            Engine.cs_play_line("0050");
            await Engine.sleep(30);
            Engine.print("spec-ops commander: 'come out. so we may kill you.'");
            Engine.cs_play_line("0060");
            Engine.cs_approach_stop();
            Engine.cs_switch("heretic_leader");
            Engine.cs_face_object(true, Engine.list_get(Engine.ai_actors(disposal_commander.Squad), 0));
            Engine.print("heretic leader: 'get in line.'");
            Engine.cs_play_line("0070");
            Engine.cs_switch("commander");
            this.holo_ally_03_done = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hologram_ally_04()
        {
            Engine.cs_switch("so_elite");
            Engine.print("spec-ops elite: 'leader...'");
            Engine.cs_play_line("0080");
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'stand firm...the flood is upon us.'");
            Engine.cs_play_line("0090");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task revive_aware()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(disposal_infection) > 0);
            Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\dialog\\combat\\elite_loose\\02_danger\\warn_fldreanimate", 4221114720U), Engine.list_get(Engine.ai_actors(allies_elites_03a.Squad), 0), 1F);
            Engine.print("ally warns about reanimation");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task disposal_after_react()
        {
            Engine.cs_switch("ally");
            Engine.print("spec-ops elite: 'heretic fools! what have they done?!'");
            Engine.cs_play_line("0640");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task disposal_after_commander()
        {
            Engine.cs_switch("commander");
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("disposal_chamber/doorman"));
            Engine.cs_aim_player(true);
            Engine.print("spec-ops commander: 'go, arbiter! i'll follow when our reinforcements arrive!'");
            Engine.cs_play_line("1500");
            Engine.cs_aim_player(false);
            Engine.cs_enable_dialogue(true);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_soc_post, Engine.ai_actors(disposal_commander.Squad)) == false);
                Engine.cs_start_to(Engine.GetReference<ISpatialPoint>("disposal_chamber/doorman"));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task spec_ops_reborn()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_soc_reborn, Engine.ai_actors(disposal_commander.Squad)) == true);
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\gameplay\\coop_teleport", 4205975673U), Engine.list_get(Engine.ai_actors(disposal_commander.Squad), 0), "");
                await Engine.sleep(30);
                Engine.object_teleport(Engine.list_get(Engine.ai_actors(disposal_commander.Squad), 0), soc_reborn);
                return (short)Engine.structure_bsp_index() == 0;
            });
            Engine.ai_erase(disposal_commander.Squad);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task disposal_infection_spawn()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 20, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_02.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 20, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_02.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 15, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_01.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 15, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_01.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 10, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_02.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 10, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_02.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 5, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_01.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 5, 30, 300);
            if ((short)Engine.ai_swarm_count(disposal_infection) < 20)
            {
                Engine.ai_place(disposal_infection_01.Squad, 1);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task holo_cannot_die()
        {
            await Engine.sleep_until(async () => Engine.object_get_shield(holo_boy.Entity) < 1F, 1);
            Engine.object_set_shield_stun_infinite(holo_boy.Entity);
            Engine.object_set_shield(holo_boy.Entity, 0F);
            Engine.object_cannot_take_damage(holo_boy.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task disposal_chamber_start()
        {
            Engine.data_mine_set_mission_segment("04b_2_disposal_chamber");
            Engine.game_save();
            Engine.ai_renew(all_allies);
            Engine.wake(juggernaut_abort);
            Engine.wake(music_04b_01_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_disposal_bottom, Engine.players()) == true && await this.player_count() > 0);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_disposal_all, Engine.ai_actors(all_allies)) == true && await this.player_count() > 0, 30, 300);
            Engine.device_set_position(disposal_entry_int.Entity, 0F);
            Engine.ai_set_active_camo(all_allies, false);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.ai_scene("mess_react_01_scene", disposal_ally_comment_01, allies_elites) || (short)Engine.ai_living_count(allies_elites) == 0, 30, 150);
            await Engine.sleep(5);
            if (this.mess_react_01_go == true)
            {
                await Engine.sleep_until(async () => this.mess_react_01_done == true || (short)Engine.ai_living_count(allies_elites) == 0, 30, 150);
            }

            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.ai_scene("mess_react_02_scene", disposal_ally_comment_02, all_allies) || (short)Engine.ai_living_count(allies_grunts_03.Squad) < 2, 30, 150);
            await Engine.sleep(90);
            Engine.ai_disregard(Engine.ai_actors(all_allies), true);
            Engine.device_set_position(tennis_ball.Entity, 1F);
            await Engine.sleep(60);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_activate", 3871278409U), tennis_ball.Entity, "");
            await Engine.sleep_until(async () => Engine.device_get_position(tennis_ball.Entity) == 1F, 30, 450);
            Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_holo_on_cinematic", 3871606094U), tennis_ball.Entity, "light");
            Engine.ai_place(hl_hologram.Squad);
            Engine.unit_impervious(Engine.ai_actors(hl_hologram.Squad), true);
            Engine.ai_cannot_die(hl_hologram.Squad, true);
            Engine.cs_run_command_script(hl_hologram.Squad, forever_pause);
            Engine.ai_disregard(Engine.ai_actors(all_allies), true);
            Engine.ai_disregard(Engine.ai_actors(hl_hologram.Squad), true);
            Engine.object_destroy(tennis_ball.Entity);
            Engine.object_dynamic_simulation_disable(Engine.list_get(Engine.ai_actors(hl_hologram.Squad), 0), true);
            Engine.cs_run_command_script(all_allies, hologram_face);
            await Engine.sleep_until(async () => Engine.ai_scene("holo_grunt_react_scene", hologram_ally_01, all_allies) || (short)Engine.ai_living_count(allies_grunts_03.Squad) == 0 || (short)Engine.ai_living_count(disposal_commander.Squad) == 0, 30, 150);
            await Engine.sleep(5);
            if (this.holo_ally_01_go == true)
            {
                await Engine.sleep_until(async () => this.holo_ally_01_done == true || (short)Engine.ai_living_count(allies_grunts_03.Squad) == 0 || (short)Engine.ai_living_count(disposal_commander.Squad) == 0, 30, 300);
            }

            await Engine.sleep_until(async () => Engine.ai_scene("holo_main_hl_scene", hologram_ally_02, hl_hologram.Squad) || (short)Engine.ai_living_count(hl_hologram.Squad) == 0, 30, 150);
            await Engine.sleep(5);
            if (this.holo_ally_02_go == true)
            {
                await Engine.sleep_until(async () => this.holo_ally_02_done == true || (short)Engine.ai_living_count(hl_hologram.Squad) == 0, 30, 300);
            }

            await Engine.sleep_until(async () => Engine.ai_scene("holo_main_react_scene", hologram_ally_03, disposal_commander.Squad, hl_hologram.Squad) || (short)Engine.ai_living_count(disposal_commander.Squad) == 0 || (short)Engine.ai_living_count(hl_hologram.Squad) == 0, 30, 150);
            await Engine.sleep(5);
            if (this.holo_ally_03_go == true)
            {
                await Engine.sleep_until(async () => this.holo_ally_03_done == true || (short)Engine.ai_living_count(disposal_commander.Squad) == 0, 30, 450);
            }

            Engine.unit_doesnt_drop_items(Engine.ai_actors(hl_hologram.Squad));
            Engine.ai_cannot_die(hl_hologram.Squad, false);
            Engine.ai_kill_silent(hl_hologram.Squad);
            Engine.ai_disregard(Engine.ai_actors(all_allies), false);
            Engine.game_save();
            await Engine.sleep(120);
            Engine.ai_place(disposal_infection_01.Squad, 1);
            await Engine.sleep(30);
            Engine.ai_place(disposal_infection_01.Squad, 1);
            await Engine.sleep(30);
            Engine.ai_place(disposal_infection_01.Squad, 1);
            await Engine.sleep(30);
            Engine.ai_place(disposal_infection_01.Squad, 1);
            await Engine.sleep_until(async () => Engine.ai_scene("holo_after_scene", hologram_ally_04, all_allies) || (short)Engine.ai_living_count(disposal_commander.Squad) == 0 || (short)Engine.ai_living_count(allies_elites) == 0, 30, 150);
            Engine.wake(revive_aware);
            await this.disposal_infection_spawn();
            await Engine.sleep_until(async () => (short)Engine.ai_swarm_count(disposal_infection) < 30 && (short)Engine.ai_nonswarm_count(disposal_infection) == 0, 30, 8000);
            Engine.device_operates_automatically_set(disposal_exit.Entity, true);
            await Engine.sleep_until(async () => Engine.ai_scene("disposal_post_scene", disposal_after_react, all_allies) || (short)Engine.ai_living_count(allies_elites) == 0, 30, 150);
            await Engine.sleep(150);
            await Engine.sleep_until(async () => Engine.ai_scene("disposal_comm_pussy_scene", disposal_after_commander, disposal_commander.Squad), 30, 300);
            Engine.wake(spec_ops_reborn);
            await Engine.sleep(30);
            Engine.game_save();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task silo_ally_comment()
        {
            Engine.cs_switch("ally");
            Engine.print("spec-ops elite: 'this place...it is filled with the parasite!'");
            Engine.cs_play_line("0650");
            await Engine.sleep(30);
            Engine.print("spec-ops elite: 'not even heretics would have come here had they known this!'");
            Engine.cs_play_line("0660");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task silo_commander_whine()
        {
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'i do not wish to stay here any longer than we have to, arbiter!'");
            Engine.cs_play_line("1230");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_commander_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (short)Engine.ai_nonswarm_count(silo_flood) == 0);
            if (Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == false && await this.player_count() > 0)
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true, 30, 100);
                if (Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_scene("silo_commander_scene", silo_commander_whine, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
                    ;
                }
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_killer()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(kill_silo_pit), 0));
                await Engine.sleep(15);
                return this.silo_killer_power == false;
            });
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_crane_01()
        {
            Engine.device_set_overlay_track(elev_silo.Entity, "crane_left");
            Engine.device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await Engine.sleep(360);
            Engine.object_destroy(stop_01.Entity);
            Engine.object_create_anew(dummy_can);
            Engine.objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await Engine.sleep(285);
            Engine.object_destroy(dummy_can.Entity);
            await Engine.sleep(270);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_crane_02()
        {
            Engine.device_set_overlay_track(elev_silo.Entity, "crane_right");
            Engine.device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await Engine.sleep(360);
            Engine.object_destroy(stop_02.Entity);
            Engine.object_create_anew(dummy_can);
            Engine.objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await Engine.sleep(285);
            Engine.object_destroy(dummy_can.Entity);
            await Engine.sleep(270);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_crane_03()
        {
            Engine.device_set_overlay_track(elev_silo.Entity, "crane_right");
            Engine.device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await Engine.sleep(360);
            Engine.object_destroy(stop_03.Entity);
            Engine.object_create_anew(dummy_can);
            Engine.objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await Engine.sleep(285);
            Engine.object_destroy(dummy_can.Entity);
            await Engine.sleep(270);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_crane_04()
        {
            Engine.device_set_overlay_track(elev_silo.Entity, "crane_center");
            Engine.device_animate_overlay(elev_silo.Entity, 1F, 18F, 1F, 1F);
            await Engine.sleep(195);
            Engine.object_destroy(stop_04.Entity);
            Engine.object_create_anew(dummy_can);
            Engine.objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await Engine.sleep(255);
            Engine.object_destroy(dummy_can.Entity);
            await Engine.sleep(60);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_crane_05()
        {
            Engine.device_set_overlay_track(elev_silo.Entity, "crane_left");
            Engine.device_animate_overlay(elev_silo.Entity, 1F, 30F, 1F, 1F);
            await Engine.sleep(360);
            Engine.object_destroy(stop_05.Entity);
            Engine.object_create_anew(dummy_can);
            Engine.objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await Engine.sleep(285);
            Engine.object_destroy(dummy_can.Entity);
            await Engine.sleep(270);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_crane_06()
        {
            Engine.device_set_overlay_track(elev_silo.Entity, "crane_center");
            Engine.device_animate_overlay(elev_silo.Entity, 1F, 18F, 1F, 1F);
            await Engine.sleep(195);
            Engine.object_destroy(stop_06.Entity);
            Engine.object_create_anew(dummy_can);
            Engine.objects_attach(elev_silo.Entity, "can_entry", dummy_can.Entity, "can_top");
            await Engine.sleep(255);
            Engine.object_destroy(dummy_can.Entity);
            await Engine.sleep(60);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_down_200()
        {
            Engine.device_set_position_track(elev_silo.Entity, "down_200", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 5F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_down_400()
        {
            Engine.device_set_position_track(elev_silo.Entity, "down_400", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 10F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_down_600()
        {
            Engine.device_set_position_track(elev_silo.Entity, "down_600", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 15F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_down_800()
        {
            Engine.device_set_position_track(elev_silo.Entity, "down_800", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 20F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_rot_90_plus()
        {
            Engine.device_set_position_track(elev_silo.Entity, "rot_90_clockwise", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 5F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_rot_90_minus()
        {
            Engine.device_set_position_track(elev_silo.Entity, "rot_90_counterclockwise", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 5F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_rot_180_plus()
        {
            Engine.device_set_position_track(elev_silo.Entity, "rot_180_clockwise", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 10F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_rot_180_minus()
        {
            Engine.device_set_position_track(elev_silo.Entity, "rot_180_counterclockwise", 0F);
            Engine.device_animate_position(elev_silo.Entity, 1F, 10F, 1F, 1F, false);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_tray01()
        {
            Engine.objects_attach(elev_silo.Entity, "tray01", tray01.Entity, "can_exit");
            Engine.object_create(can01);
            Engine.objects_attach(tray01.Entity, "can_exit", can01.Entity, "can_base");
            Engine.device_set_position(tray01.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tray01.Entity) == 1F, 30, 900);
            Engine.objects_detach(tray01.Entity, can01.Entity);
            Engine.device_set_position_immediate(tray01.Entity, 0F);
            Engine.object_destroy(tray01.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_tray02()
        {
            Engine.objects_attach(elev_silo.Entity, "tray02", tray02.Entity, "can_exit");
            Engine.object_create(can02);
            Engine.objects_attach(tray02.Entity, "can_exit", can02.Entity, "can_base");
            Engine.device_set_position(tray02.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tray02.Entity) == 1F, 30, 300);
            Engine.objects_detach(tray02.Entity, can02.Entity);
            Engine.device_set_position_immediate(tray02.Entity, 0F);
            Engine.object_destroy(tray02.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_tray03()
        {
            Engine.objects_attach(elev_silo.Entity, "tray03", tray03.Entity, "can_exit");
            Engine.object_create(can03);
            Engine.objects_attach(tray03.Entity, "can_exit", can03.Entity, "can_base");
            Engine.device_set_position(tray03.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tray03.Entity) == 1F, 30, 300);
            Engine.objects_detach(tray03.Entity, can03.Entity);
            Engine.device_set_position_immediate(tray03.Entity, 0F);
            Engine.object_destroy(tray03.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_tray04()
        {
            Engine.objects_attach(elev_silo.Entity, "tray04", tray04.Entity, "can_exit");
            Engine.object_create(can04);
            Engine.objects_attach(tray04.Entity, "can_exit", can04.Entity, "can_base");
            Engine.device_set_position(tray04.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tray04.Entity) == 1F, 30, 300);
            Engine.objects_detach(tray04.Entity, can04.Entity);
            Engine.device_set_position_immediate(tray04.Entity, 0F);
            Engine.object_destroy(tray04.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_tray05()
        {
            Engine.objects_attach(elev_silo.Entity, "tray05", tray05.Entity, "can_exit");
            Engine.object_create(can05);
            Engine.objects_attach(tray05.Entity, "can_exit", can05.Entity, "can_base");
            Engine.device_set_position(tray05.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tray05.Entity) == 1F, 30, 300);
            Engine.objects_detach(tray05.Entity, can05.Entity);
            Engine.device_set_position_immediate(tray05.Entity, 0F);
            Engine.object_destroy(tray05.Entity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task silo_tray06()
        {
            Engine.objects_attach(elev_silo.Entity, "tray06", tray06.Entity, "can_exit");
            Engine.object_create(can06);
            Engine.objects_attach(tray06.Entity, "can_exit", can06.Entity, "can_base");
            Engine.device_set_position(tray06.Entity, 1F);
            await Engine.sleep_until(async () => Engine.device_get_position(tray06.Entity) == 1F, 30, 300);
            Engine.objects_detach(tray06.Entity, can06.Entity);
            Engine.device_set_position_immediate(tray06.Entity, 0F);
            Engine.object_destroy(tray06.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_covers_invincible()
        {
            Engine.object_cannot_take_damage(cap_01_1.Entity);
            Engine.object_cannot_take_damage(cap_01_2.Entity);
            Engine.object_cannot_take_damage(cap_01_3.Entity);
            Engine.object_cannot_take_damage(cap_01_4.Entity);
            Engine.object_cannot_take_damage(cap_01_5.Entity);
            Engine.object_cannot_take_damage(cap_01_6.Entity);
            Engine.object_cannot_take_damage(cap_01_7.Entity);
            Engine.object_cannot_take_damage(cap_01_8.Entity);
            Engine.object_cannot_take_damage(cap_01_9.Entity);
            Engine.object_cannot_take_damage(cap_01_10.Entity);
            Engine.object_cannot_take_damage(cap_01_11.Entity);
            Engine.object_cannot_take_damage(cap_01_12.Entity);
            Engine.object_cannot_take_damage(cap_02_1.Entity);
            Engine.object_cannot_take_damage(cap_02_2.Entity);
            Engine.object_cannot_take_damage(cap_02_3.Entity);
            Engine.object_cannot_take_damage(cap_02_4.Entity);
            Engine.object_cannot_take_damage(cap_02_5.Entity);
            Engine.object_cannot_take_damage(cap_02_6.Entity);
            Engine.object_cannot_take_damage(cap_02_7.Entity);
            Engine.object_cannot_take_damage(cap_02_8.Entity);
            Engine.object_cannot_take_damage(cap_02_9.Entity);
            Engine.object_cannot_take_damage(cap_02_10.Entity);
            Engine.object_cannot_take_damage(cap_02_11.Entity);
            Engine.object_cannot_take_damage(cap_03_1.Entity);
            Engine.object_cannot_take_damage(cap_03_2.Entity);
            Engine.object_cannot_take_damage(cap_03_3.Entity);
            Engine.object_cannot_take_damage(cap_03_4.Entity);
            Engine.object_cannot_take_damage(cap_03_5.Entity);
            Engine.object_cannot_take_damage(cap_03_6.Entity);
            Engine.object_cannot_take_damage(cap_03_7.Entity);
            Engine.object_cannot_take_damage(cap_03_8.Entity);
            Engine.object_cannot_take_damage(cap_04_1.Entity);
            Engine.object_cannot_take_damage(cap_04_2.Entity);
            Engine.object_cannot_take_damage(cap_04_3.Entity);
            Engine.object_cannot_take_damage(cap_04_4.Entity);
            Engine.object_cannot_take_damage(cap_04_5.Entity);
            Engine.object_cannot_take_damage(cap_04_6.Entity);
            Engine.object_cannot_take_damage(cap_04_7.Entity);
            Engine.object_cannot_take_damage(cap_04_8.Entity);
            Engine.object_cannot_take_damage(cap_04_9.Entity);
            Engine.object_cannot_take_damage(cap_04_10.Entity);
            Engine.object_cannot_take_damage(cap_04_11.Entity);
            Engine.object_cannot_take_damage(cap_04_12.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_sentinel_spawner()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        Engine.ai_place(silo_sentinels_resupply._1);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        Engine.ai_place(silo_sentinels_resupply._2);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                });
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (short)Engine.ai_living_count(silo_sentinels_all) < 2 || this.silo_sentinels_total > 3);
                return this.silo_sentinels_total > 3;
            }, 30, 4000);
            await Engine.sleep_until(async () => this.silo_sentinels_total == 0);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        Engine.ai_place(silo_sentinels_resupply._5);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(silo_sentinels_all) < 2 && this.silo_sentinels_total < 4)
                    {
                        Engine.ai_place(silo_sentinels_resupply._6);
                        this.silo_sentinels_total = (short)(this.silo_sentinels_total + 1);
                    }
                });
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (short)Engine.ai_living_count(silo_sentinels_all) < 2 || this.silo_sentinels_total > 3);
                return Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || this.silo_sentinels_total > 3;
            }, 30, 4000);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_saving()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => this.silo_try_save == true);
                await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save() && Engine.volume_test_objects_all(vol_silo_save, Engine.players()) == true && await this.player_count() > 0);
                Engine.game_save_immediate();
                this.silo_try_save = false;
                return Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_flood_spawner()
        {
            if (await this.difficulty_legendary())
            {
                this.silo_flood_total = 2;
            }

            if (await this.difficulty_heroic())
            {
                this.silo_flood_total = 1;
            }

            await Engine.sleep_until(async () =>
            {
                Engine.ai_place(silo_climbers_01.Squad, 1);
                Engine.ai_place(silo_climbers_02.Squad, 1);
                await Engine.sleep((short)Engine.random_range(30, 60));
                Engine.ai_place(silo_climbers_01.Squad, 1);
                Engine.ai_place(silo_climbers_02.Squad, 1);
                if (await this.difficulty_heroic())
                {
                    await Engine.sleep((short)Engine.random_range(30, 60));
                    Engine.begin_random(async () => Engine.ai_place(silo_climbers_01.Squad, (short)(1 - (float)Engine.ai_living_count(silo_climbers_02.Squad))), 
                        async () => Engine.ai_place(silo_climbers_02.Squad, (short)(1 - (float)Engine.ai_living_count(silo_climbers_01.Squad))));
                }

                if (await this.difficulty_legendary())
                {
                    await Engine.sleep((short)Engine.random_range(30, 60));
                    Engine.begin_random(async () => Engine.ai_place(silo_climbers_01.Squad, 1), 
                        async () => Engine.ai_place(silo_climbers_02.Squad, 1));
                }

                Engine.garbage_collect_now();
                this.silo_try_save = true;
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (float)Engine.ai_nonswarm_count(silo_flood) + (float)Engine.ai_nonswarm_count(silo_infection) <= this.silo_flood_total);
                return Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || this.silo_almost_there == true;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task elev_go()
        {
            await this.silo_crane_01();
            await this.silo_tray01();
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_specimen_storage, Engine.players()) == true && await this.player_count() > 0);
            Engine.print("down 400");
            Engine.wake(silo_saving);
            Engine.wake(music_04b_02_stop);
            await this.silo_down_400();
            await Engine.sleep(300);
            await this.silo_rot_90_plus();
            await Engine.sleep(150);
            await this.silo_crane_02();
            await this.silo_tray02();
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_specimen_storage, Engine.players()) == true && await this.player_count() > 0, 30, 300);
            Engine.print("down 600");
            await this.silo_down_600();
            await Engine.sleep(450);
            await this.silo_rot_90_minus();
            await Engine.sleep(150);
            await this.silo_crane_03();
            await this.silo_tray03();
            await Engine.sleep(30);
            Engine.data_mine_set_mission_segment("04b_4_silo_mid");
            this.silo_try_save = true;
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_specimen_storage, Engine.players()) == true && await this.player_count() > 0, 30, 300);
            Engine.print("down 200");
            Engine.wake(music_04b_01_stop);
            await this.silo_down_200();
            await Engine.sleep(150);
            Engine.ai_place(silo_sentinels_below.Squad, 4);
            await this.silo_rot_90_plus();
            await Engine.sleep(150);
            await this.silo_crane_04();
            await this.silo_tray04();
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_specimen_storage, Engine.players()) == true && await this.player_count() > 0, 30, 300);
            Engine.print("down 800 - kill disabled");
            Engine.kill_volume_disable(kill_silo_toggle);
            await this.silo_down_800();
            await Engine.sleep(600);
            await this.silo_rot_180_minus();
            await Engine.sleep(300);
            await this.silo_crane_05();
            await this.silo_tray05();
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_specimen_storage, Engine.players()) == true && await this.player_count() > 0, 30, 300);
            Engine.print("down 400");
            await this.silo_down_400();
            await Engine.sleep(300);
            await this.silo_rot_90_plus();
            await Engine.sleep(150);
            await this.silo_crane_06();
            await this.silo_tray06();
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_specimen_storage, Engine.players()) == true && await this.player_count() > 0, 30, 300);
            this.silo_almost_there = true;
            Engine.print("down 600");
            await this.silo_down_600();
            await Engine.sleep(300);
            await Engine.sleep(150);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_hall_flood_spawner()
        {
            Engine.ai_place(silo_flood_halls.Squad, 2);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (short)Engine.ai_nonswarm_count(silo_flood_halls.Squad) == 0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true, 30, 210);
            if (Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }

            if (Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_place(silo_flood_halls.Squad, 2);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (short)Engine.ai_nonswarm_count(silo_flood_halls.Squad) == 0);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true, 30, 210);
            if (Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true)
            {
                Engine.sleep_forever();
            }

            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == false && await this.player_count() > 0 && (short)Engine.ai_living_count(silo_flood_halls.Squad) < 1)
                {
                    Engine.ai_place(silo_flood_halls.Squad, 1);
                }

                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true, 30, 210);
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (short)Engine.ai_living_count(silo_flood_halls.Squad) < 1 || (short)Engine.ai_spawn_count(silo_flood_halls.Squad) > 7);
                return Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true || (short)Engine.ai_spawn_count(silo_flood_halls.Squad) > 7;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task silo_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_silo_enter, Engine.players()) == true);
            Engine.ai_disposable(disposal_flood, true);
            Engine.ai_disposable(disposal_infection, true);
            Engine.data_mine_set_mission_segment("04b_3_silo_start");
            Engine.game_save();
            Engine.kill_volume_enable(kill_silo_toggle);
            Engine.ai_renew(all_allies);
            Engine.ai_set_orders(arm02_allies, allies_silo);
            Engine.ai_place(silo_sentinels_initial.Squad, 2);
            Engine.ai_place(silo_flood_initial.Squad, 4);
            Engine.wake(silo_killer);
            Engine.wake(music_04b_02_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_specimen_storage, Engine.players()) == true && await this.player_count() > 0);
            Engine.wake(elev_go);
            Engine.wake(silo_covers_invincible);
            Engine.wake(silo_flood_spawner);
            Engine.wake(silo_sentinel_spawner);
            Engine.ai_set_orders(arm02_allies, allies_silo_lift);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(silo_flood_initial.Squad) == 0 && (short)Engine.ai_nonswarm_count(silo_sentinels_initial.Squad) == 0, 30, 4000);
            Engine.ai_scene("silo_ally_scene", silo_ally_comment, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            await Engine.sleep_until(async () => this.silo_almost_there == true || Engine.volume_test_objects(vol_leaving_silo, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("04b_5_silo_end");
            this.silo_try_save = true;
            Engine.wake(silo_hall_flood_spawner);
            Engine.ai_set_orders(silo_flood, silo_all);
            Engine.ai_place(silo_sentinels_below.Squad, 3);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task halls2lab_ally_comment()
        {
            Engine.cs_switch("ally");
            Engine.print("spec-ops elite: 'we should have brought weapons to burn these bodies.'");
            Engine.cs_play_line("1240");
            await Engine.sleep(30);
            Engine.print("spec-ops elite: 'every one is a potential vessel for the flood!'");
            Engine.cs_play_line("1250");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task to_flood_lab()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hall_to_lab, Engine.players()) == true);
            Engine.ai_disposable(silo_flood, true);
            Engine.ai_disposable(silo_infection, true);
            Engine.ai_disposable(silo_sentinels_all, true);
            Engine.data_mine_set_mission_segment("04b_6_hall_to_lab");
            Engine.game_save_no_timeout();
            Engine.ai_renew(all_allies);
            Engine.ai_set_orders(arm02_allies, allies_lab_upper);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_hall_to_lab, Engine.ai_actors(allies_elites)) == true || (short)Engine.ai_living_count(allies_elites) == 0);
            Engine.ai_scene("halls2lab_scene", halls2lab_ally_comment, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task famine_flavor()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_famine_01, Engine.players()) == true || Engine.volume_test_objects(vol_famine_02, Engine.players()) == true);
            Engine.object_create(famine);
            Engine.ai_place(famine_cf.Squad);
            Engine.cs_run_command_script(famine_cf.Squad, forever_pause);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(famine_cf.Squad), 0)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4007595368U), "combat:thrash_back:var0", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(famine_cf.Squad), 1)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4007595368U), "combat:thrash_back:var1", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(famine_cf.Squad), 2)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4007595368U), "combat:thrash_front:var0", true);
            Engine.custom_animation_loop(Engine.unit(Engine.list_get(Engine.ai_actors(famine_cf.Squad), 3)), Engine.GetTag<AnimationGraphTag>("objects\\characters\\floodcombat_elite\\floodcombat_elite", 4007595368U), "combat:thrash_front:var1", true);
            await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4094235112U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\multiplayer\\ball\\head_sp.weapon", 4094235112U)));
            Engine.ice_cream_flavor_stock(4);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task airlock_commander()
        {
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'bring the phantoms close to the mine! we are not leaving until the leader of these heretics is dead!'");
            Engine.cs_play_line("0110");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task airlock_commander_talk()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("phantom pilot: 'leader! the storm is about to hit! we cannot maintain our position!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0100"));
            Engine.print("spec-ops commander: 'bring the phantoms close to the mine! we are not leaving until the leader of these heretics is dead!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0110"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task research_arm_bsp_swap()
        {
            Engine.device_one_sided_set(lab_exit_int.Entity, true);
            Engine.device_set_never_appears_locked(lab_exit_int.Entity, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_research_arm_swap, Engine.ai_actors(allies_elites)) == true && await this.player_count() > 0, 30, 300);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_research_arm_swap, Engine.players()) == true && await this.player_count() > 0 && Engine.device_get_position(lab_exit_int.Entity) <= 0F);
            Engine.device_operates_automatically_set(lab_exit_int.Entity, false);
            Engine.device_set_never_appears_locked(lab_exit_int.Entity, false);
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_object(trans_3_0, Engine.list_get(Engine.ai_actors(all_allies), 4)) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 4));
                }

                await Engine.sleep(2);
                if (Engine.volume_test_object(trans_3_0, Engine.list_get(Engine.ai_actors(all_allies), 3)) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 3));
                }

                await Engine.sleep(2);
                if (Engine.volume_test_object(trans_3_0, Engine.list_get(Engine.ai_actors(all_allies), 2)) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 2));
                }

                await Engine.sleep(2);
                if (Engine.volume_test_object(trans_3_0, Engine.list_get(Engine.ai_actors(all_allies), 1)) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 1));
                }

                await Engine.sleep(2);
                if (Engine.volume_test_object(trans_3_0, Engine.list_get(Engine.ai_actors(all_allies), 0)) == false)
                {
                    Engine.object_destroy(Engine.list_get(Engine.ai_actors(all_allies), 0));
                }

                await Engine.sleep(2);
                return false;
            }, 30, 60);
            Engine.begin_random(async () => Engine.object_create(gas01), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas02), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas03), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas04), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas05), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas06), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas07), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas08), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas09), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_create(gas10), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)));
            Engine.switch_bsp(0);
            Engine.ai_set_orders(all_allies, allies_wraparound);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(airlock_commander_talk);
            await Engine.sleep(30);
            Engine.begin_random(async () => Engine.object_destroy(gas01.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas02.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas03.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas04.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas05.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas06.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas07.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas08.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas09.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)), 
                async () => Engine.object_destroy(gas10.Entity), 
                async () => await Engine.sleep((short)Engine.random_range(5, 15)));
            await Engine.sleep(30);
            Engine.device_operates_automatically_set(lab_exit_ext.Entity, true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lab_barricades()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_01._1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_01._2);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_01._3);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_01._4);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_01._5);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_01._6);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_01.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_01.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_01.Squad, 1);
                    }
                });
                return (float)Engine.ai_strength(lab_heretics_01.Squad) < 0.5F || Engine.volume_test_objects(vol_lab_floor, Engine.players()) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_02.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_02.Squad, 1);
                    }
                });
                return (short)Engine.ai_living_count(lab_heretics_01.Squad) == 0 || Engine.volume_test_objects(vol_lab_floor, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_heretics_ally()
        {
            Engine.cs_switch("ally");
            Engine.print("spec-ops elite: 'heretics!  above!'");
            Engine.cs_play_line("1270");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_heretics_commander()
        {
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'heretics!  above!'");
            Engine.cs_play_line("1260");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_juggernaut_ally()
        {
            Engine.cs_switch("ally");
            Engine.print("spec-ops elite: 'it comes!  prepare yourself, arbiter!'");
            Engine.cs_play_line("1290");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_juggernaut_commander()
        {
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'it comes!  prepare yourself, arbiter!'");
            Engine.cs_play_line("1280");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_jugg_hint1_ally()
        {
            Engine.cs_switch("ally");
            Engine.print("spec-ops elite: 'it shrugs off our every assault!  it must have a weak spot!'");
            Engine.cs_play_line("1290");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_jugg_hint1_commander()
        {
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'it shrugs off our every assault!  it must have a weak spot!'");
            Engine.cs_play_line("1280");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_jugg_hint2_ally()
        {
            Engine.cs_switch("ally");
            Engine.print("spec-ops elite: 'the eye, arbiter!  aim for its eye!'");
            Engine.cs_play_line("1290");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_jugg_hint2_commander()
        {
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'the eye, arbiter!  aim for its eye!'");
            Engine.cs_play_line("1280");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task stay_shootin()
        {
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_turret_man_r()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(lab_exit_turrets.r));
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(Engine.unit(Engine.ai_get_object(this.ai_current_actor))) == true, 30, 450);
            if (Engine.unit_in_vehicle(Engine.unit(Engine.ai_get_object(this.ai_current_actor))) == true)
            {
                Engine.cs_set_behavior(guard);
                Engine.sleep_forever();
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task lab_turret_man_l()
        {
            Engine.cs_abort_on_damage(true);
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to_vehicle(Engine.ai_vehicle_get_from_starting_location(lab_exit_turrets.l));
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(Engine.unit(Engine.ai_get_object(this.ai_current_actor))) == true, 30, 450);
            if (Engine.unit_in_vehicle(Engine.unit(Engine.ai_get_object(this.ai_current_actor))) == true)
            {
                Engine.cs_set_behavior(guard);
                Engine.sleep_forever();
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task fuck_this_turret_shit()
        {
            await Engine.sleep(120);
            Engine.ai_vehicle_enter(lab_grunts_02.Squad, Engine.ai_vehicle_get_from_starting_location(lab_exit_turrets.r));
            Engine.ai_vehicle_enter(lab_grunts_02.Squad, Engine.ai_vehicle_get_from_starting_location(lab_exit_turrets.l));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lab_wave_new_01()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                {
                    Engine.ai_place(lab_carriers_02.Squad, 1);
                    this.lab_flood_count = (short)(this.lab_flood_count + 1);
                }

                return this.lab_flood_count > 5;
            }, 30, 8000);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task lab_wave_new_02()
        {
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                {
                    Engine.ai_place(lab_combatforms_02.Squad, 1);
                    this.lab_flood_count = (short)(this.lab_flood_count + 1);
                }

                return false;
            }, 30, 1800);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task flood_lab_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_lab_enter, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("04b_7_flood_lab_start");
            Engine.game_save_no_timeout();
            this.silo_killer_power = false;
            Engine.ai_place(lab_heretics_01.Squad, 1);
            Engine.ai_place(lab_turret_grunts_01.Squad, 2);
            Engine.ai_place(lab_exit_turrets.Squad, 2);
            Engine.ai_place(lab_carriers_01.init1);
            Engine.ai_place(lab_carriers_01.init2);
            Engine.ai_place(lab_carriers_01.init3);
            Engine.wake(lab_barricades);
            if (await this.difficulty_legendary())
            {
                Engine.wake(famine_flavor);
            }

            Engine.wake(music_04b_03_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_lab_floor, Engine.players()) == true && await this.player_count() > 0, 30, 900);
            if (Engine.volume_test_objects_all(vol_lab_floor, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.begin_random(async () => Engine.ai_place(lab_combatforms_02.r1), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 45)), 
                    async () => Engine.ai_place(lab_combatforms_02.r2), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 45)), 
                    async () => Engine.ai_place(lab_combatforms_02.r3), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 45)), 
                    async () => Engine.ai_place(lab_combatforms_02.r4), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 45)));
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects_all(vol_lab_floor, Engine.players()) == true && await this.player_count() > 0);
            Engine.game_save_no_timeout();
            Engine.ai_set_orders(arm02_allies, allies_lab_lower);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(lab_flood) == 0 && (short)Engine.ai_living_count(lab_heretics) == 0 && Engine.volume_test_objects_all(vol_lab_floor, Engine.players()) == true && await this.player_count() > 0, 30, 8000);
            Engine.data_mine_set_mission_segment("04b_8_flood_lab_mid_01");
            Engine.game_save_no_timeout();
            Engine.ai_place(lab_heretics_above.Squad, 3);
            await Engine.sleep(15);
            Engine.ai_magically_see_object(lab_heretics_above.Squad, await this.player0());
            Engine.ai_magically_see_object(lab_heretics_above.Squad, await this.player1());
            await Engine.sleep_until(async () => Engine.objects_can_see_object(Engine.players(), Engine.list_get(Engine.ai_actors(lab_heretics_above.Squad), 0), 60F) == true, 30, 450);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(allies_elites) == 0 || Engine.ai_scene("lab_heretic_ally_scene", lab_heretics_ally, all_allies), 30, 300);
            Engine.ai_place(lab_combatforms_02.r2);
            Engine.ai_place(lab_carriers_02.r4);
            Engine.ai_set_orders(lab_flood, lab_above);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_02.r1);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_02.r2);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_02.r3);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_02.r4);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_combatforms_02.r5);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_02.r1);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_02.r2);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_02.r3);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_02.r4);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(lab_flood) < 4)
                    {
                        Engine.ai_place(lab_carriers_02.r5);
                        await Engine.sleep((short)Engine.random_range(10, 40));
                    }
                });
                return (short)Engine.ai_living_count(lab_heretics_above.Squad) < 1 || Engine.volume_test_objects_all(vol_lab_floor, Engine.ai_actors(lab_heretics_above.Squad)) == true && await this.player_count() > 0;
            }, 30, 4000);
            Engine.game_save_no_timeout();
            Engine.ai_set_orders(lab_heretics_above.Squad, lab_flood_all);
            Engine.ai_set_orders(lab_flood, lab_flood_all);
            Engine.ai_set_orders(arm02_allies, allies_lab_wagons);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(lab_flood) < 1 && (short)Engine.ai_living_count(lab_heretics_above.Squad) < 1, 30, 2000);
            Engine.game_save_no_timeout();
            await this.music_04b_03_start_alt();
            this.lab_flood_count = 0;
            Engine.wake(lab_wave_new_02);
            await Engine.sleep(1800);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(lab_flood) < 1, 30, 3600);
            await Engine.sleep_until(async () => (bool)Engine.ai_trigger_test("done_fighting", lab_flood) == true, 30, 1800);
            Engine.data_mine_set_mission_segment("04b_9_flood_lab_mid_02");
            Engine.game_save_no_timeout();
            await this.music_04b_03_stop_alt();
            this.lab_flood_count = 0;
            Engine.wake(lab_wave_new_01);
            Engine.data_mine_set_mission_segment("04b_10_flood_lab_end");
            await Engine.sleep(90);
            Engine.device_operates_automatically_set(lab_exit_int.Entity, true);
            Engine.ai_place(lab_heretics_02.Squad, 2);
            Engine.ai_place(lab_grunts_02.Squad, 3);
            Engine.ai_set_orders(arm02_allies, allies_lab_end);
            Engine.wake(fuck_this_turret_shit);
            Engine.wake(music_04b_03_stop);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(lab_heretics) == 0 || Engine.volume_test_objects_all(vol_research_arm_swap, Engine.players()) == true && await this.player_count() > 0);
            Engine.game_save_no_timeout();
            Engine.ai_set_orders(all_allies, allies_airlock);
            Engine.wake(research_arm_bsp_swap);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task wind()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () =>
                {
                    Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\sound_scenery\\gusty_wind\\details\\gusty_wind", 4221180257U), default(IGameObject), 1F);
                    await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_enter, Engine.players()) == true || (short)Engine.structure_bsp_index() == 2, 5, 30);
                    Engine.player_effect_set_max_rotation((float)Engine.real_random_range(0.1F, 1F), (float)Engine.real_random_range(0.1F, 1F), 0F);
                    Engine.player_effect_start((float)Engine.real_random_range(0.05F, 0.2F), (float)Engine.real_random_range(0.5F, 2F));
                    Engine.player_effect_stop((float)Engine.real_random_range(3F, 5F));
                    await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_enter, Engine.players()) == true || (short)Engine.structure_bsp_index() == 2, 5, (int)Engine.random_range(150, 300));
                    return Engine.volume_test_objects(vol_control_enter, Engine.players()) == true || (short)Engine.structure_bsp_index() == 2;
                });
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_gusty, Engine.players()) == true || (short)Engine.structure_bsp_index() == 2, 5);
                return (short)Engine.structure_bsp_index() == 2;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_phantom_arrives()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph0"), 5F);
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph1"), 2F);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), true);
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_a03");
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_a02");
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_a01");
            await Engine.sleep(30);
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p_b01");
            Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p");
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(allied_phantom_02.Squad) < 2);
            await Engine.sleep(60);
            Engine.object_set_phantom_power(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), false);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph2"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph3"), 5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph4"), 5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_bridge/phx"), 2F);
            Engine.ai_erase(allied_phantom_02.Squad);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_phantom_go()
        {
            Engine.ai_place(allies_elites_04.Squad, (short)(2 - (float)Engine.ai_living_count(allies_elites)));
            Engine.ai_place(allies_grunts_04.Squad, (short)(2 - (float)Engine.ai_living_count(allies_grunts_03.Squad)));
            Engine.ai_place(allied_phantom_02.Squad);
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p", Engine.ai_actors(allies_grunts_04.Squad));
            Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), "phantom_p", Engine.ai_actors(allies_elites_04.Squad));
            Engine.ai_vehicle_reserve(Engine.ai_vehicle_get_from_starting_location(allied_phantom_02.pilot), true);
            Engine.cs_run_command_script(allied_phantom_02.pilot, bridge_phantom_arrives);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_commander_comment()
        {
            Engine.cs_switch("commander");
            Engine.cs_start_approach_player(1F, 20F, 20F);
            Engine.print("spec-ops commander: 'arbiter, the flood has spread throughout the station!'");
            Engine.cs_play_line("0670");
            Engine.print("spec-ops commander: 'we don't have enough troops to manage such a large infestation!'");
            Engine.cs_play_line("0680");
            Engine.print("spec-ops commander: 'find the leader of these heretics! kill him now!'");
            Engine.cs_play_line("0672");
            Engine.cs_approach_stop();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bridge_commander_reminder()
        {
            Engine.cs_switch("commander");
            Engine.cs_start_approach_player(1F, 20F, 20F);
            Engine.print("spec-ops commander: 'onward! to the core of the station!'");
            Engine.cs_play_line("1340");
            Engine.cs_approach_stop();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_reminder()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_enter, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_control_enter, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'onward! to the core of the station!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1340"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task wraparound_right()
        {
            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_right_01, Engine.players()) == true);
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_heretics_R_02.Squad, 2);
            }

            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_h_grunts_R_03.Squad, (short)(4 - (float)Engine.ai_living_count(bridge_h_grunts_init.Squad) + (float)Engine.ai_living_count(bridge_runners.Squad)));
            }

            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_right_02, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_heretics_R_04.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_heretics_R_02.Squad)));
            }

            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_right_03, Engine.players()) == true);
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_sentinels_R_05.Squad, 3);
            }

            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_final, Engine.players()) == true);
            this.bridge_final_gone = true;
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_heretics_final.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_heretics_R_04.Squad) + (float)Engine.ai_living_count(bridge_heretics_L_04.Squad)));
            }

            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_h_grunts_final.Squad, 2);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task wraparound_left()
        {
            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_left_01, Engine.players()) == true);
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_heretics_L_02.Squad, 2);
            }

            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_h_grunts_L_03.Squad, (short)(4 - (float)Engine.ai_living_count(bridge_h_grunts_init.Squad) + (float)Engine.ai_living_count(bridge_runners.Squad)));
            }

            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_left_02, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_heretics_L_04.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_heretics_L_02.Squad)));
            }

            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_left_03, Engine.players()) == true);
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_sentinels_L_05.Squad, 3);
            }

            await Engine.sleep_until(async () => this.bridge_final_gone == false && Engine.volume_test_objects(vol_wrap_final, Engine.players()) == true);
            this.bridge_final_gone = true;
            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_heretics_final.Squad, (short)(2 - (float)Engine.ai_living_count(bridge_heretics_R_04.Squad) + (float)Engine.ai_living_count(bridge_heretics_L_04.Squad)));
            }

            if ((short)Engine.ai_nonswarm_count(bridge_enemies) < 8)
            {
                Engine.ai_place(bridge_h_grunts_final.Squad, 2);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bridge_start()
        {
            Engine.data_mine_set_mission_segment("04b_11_wraparound");
            Engine.ai_disposable(lab_flood, true);
            Engine.ai_disposable(lab_heretics, true);
            Engine.game_save();
            await Engine.sleep(60);
            Engine.ai_place(bridge_runners.Squad, 2);
            Engine.ai_place(bridge_h_grunts_init.Squad, 3);
            Engine.ai_place(bridge_infection.Squad, 3);
            Engine.ai_place(bridge_combatforms.Squad, 1);
            Engine.ai_place(bridge_carriers.Squad, 2);
            Engine.device_operates_automatically_set(control_room_ext.Entity, true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_on_bridge, Engine.players()) == true, 30, 150);
            Engine.game_save();
            Engine.wake(wraparound_right);
            Engine.wake(wraparound_left);
            Engine.ai_renew(all_allies);
            Engine.wake(bridge_phantom_go);
            Engine.wake(bridge_reminder);
            Engine.wake(wind);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(allied_phantom_02.Squad) > 1);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(allied_phantom_02.Squad) < 2);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'arbiter, the flood has spread throughout the station!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0670"));
            Engine.print("spec-ops commander: 'we don't have enough troops to manage such a large infestation!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0671"));
            Engine.print("spec-ops commander: 'find the leader of these heretics! kill him now!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0672"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.game_save_no_timeout();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task hl_killer()
        {
            await Engine.sleep_until(async () =>
            {
                if (Engine.volume_test_object(vol_hl_killer, await this.player0()) == true)
                {
                    Engine.unit_kill(Engine.unit(await this.player0()));
                }

                if (Engine.volume_test_object(vol_hl_killer, await this.player1()) == true)
                {
                    Engine.unit_kill(Engine.unit(await this.player1()));
                }

                return (short)Engine.structure_bsp_index() == 2;
            }, 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task hologram_toggle()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), mine_holo) <= 5F);
                Engine.object_create_anew(gasmine_hologram);
                Engine.object_set_function_variable(gasmine_hologram.Entity, "holo_power", 0F, 0F);
                Engine.object_set_function_variable(gasmine_hologram.Entity, "holo_power", 1F, 30F);
                await Engine.sleep(30);
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), mine_holo) > 5F);
                Engine.object_set_function_variable(gasmine_hologram.Entity, "holo_power", 1F, 0F);
                Engine.object_set_function_variable(gasmine_hologram.Entity, "holo_power", 0F, 30F);
                await Engine.sleep(30);
                Engine.object_destroy(gasmine_hologram.Entity);
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task control_commander_reminder()
        {
            await Engine.sleep_until(async () => Engine.device_get_position(elev_control_up.Entity) > 0F, 30, 3600);
            if (Engine.device_get_position(elev_control_up.Entity) <= 0F)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'make your way up to the cable, arbiter.'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1350"));
                Engine.print("spec-ops commander: 'there should be an elevator above you!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1360"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task control_grunt_comment()
        {
            Engine.cs_switch("grunt");
            Engine.print("spec-ops grunt: 'heretic boss! you see? you see?'");
            Engine.cs_play_line("0700");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task control_elite_comment()
        {
            Engine.cs_switch("elite");
            Engine.print("spec-ops elite: 'there! the heretic leader!'");
            Engine.cs_play_line("0680");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task heretic_leader_holes_up()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_force_combat_status(4);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("control_room/p0"));
            Engine.cs_face_player(true);
            Engine.device_set_position_immediate(shield.Entity, 0F);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task sog_bug_out_01()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/p3"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task sog_bug_out_02()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/p4"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task sog_bug_out_03()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/p5"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task sog_bug_out_04()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/p6"));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task commander_farewell()
        {
            Engine.cs_switch("commander");
            Engine.print("spec-ops commander: 'warriors, return to the landing-zone! the arbiter will continue upward, cut this station loose, and scare the heretic from his hole!'");
            Engine.cs_play_line("0120");
            this.comm_farewell_done = true;
            await Engine.sleep_until(async () => this.soe_farewell_done == true || (short)Engine.ai_living_count(control_elites_cinematic.Squad) < 2);
            await Engine.sleep(30);
            Engine.cs_start_approach_player(2F, 20F, 20F);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)))
            {
                Engine.print("spec-ops commander: 'keep your blade handy - i doubt the cable can withstand its bite.'");
                Engine.cs_play_line("0140");
            }
            else
            {
                Engine.print("spec-ops commander: 'take my blade - i doubt the cable can withstand its bite.'");
                Engine.cs_play_line("0130");
                await Engine.sleep_until(async () => Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)) || Engine.unit_has_weapon(Engine.unit(await this.player1()), Engine.GetTag<BaseTag>("objects\\weapons\\melee\\energy_blade\\energy_blade.weapon", 3786211383U)) || Engine.volume_test_objects(vol_control_middle, Engine.players()) == true, 30, 900);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task spec_op_farewell()
        {
            Engine.cs_switch("ally01");
            await Engine.sleep_until(async () => this.comm_farewell_done == true);
            await Engine.sleep(30);
            Engine.print("spec-ops elite: 'may our lords guide your hand!'");
            Engine.cs_play_line("0150");
            Engine.cs_enable_moving(true);
            Engine.cs_switch("ally02");
            await Engine.sleep(30);
            Engine.print("spec-ops elite: 'we shall not forget your sacrifice!'");
            Engine.cs_play_line("0160");
            this.soe_farewell_done = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task soe_bug_out_01()
        {
            await Engine.sleep_until(async () => this.comm_farewell_done == true);
            await Engine.sleep(30);
            Engine.print("spec-ops elite: 'may our lords guide your hand!'");
            Engine.cs_play_line("0150");
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task soe_bug_out_02()
        {
            await Engine.sleep_until(async () => this.comm_farewell_done == true);
            await Engine.sleep(120);
            Engine.print("spec-ops elite: 'we shall not forget your sacrifice!'");
            Engine.cs_play_line("0160");
            await Engine.sleep(15);
            this.soe_farewell_done = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task control_bug_out_flight()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph1too"));
            Engine.cs_vehicle_speed(0.5F);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph2too"));
            Engine.cs_fly_to_and_face(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph3too"), Engine.GetReference<ISpatialPoint>("airspace_bridge/ph4too"));
            this.bug_out_phantom_here = true;
            Engine.object_create(phantom_vol);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(all_allies) < 1);
            Engine.cs_pause(1F);
            Engine.object_destroy(phantom_vol.Entity);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace_bridge/ph4too"));
            Engine.cs_vehicle_speed(1F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace_bridge/phxtoo"));
            Engine.ai_erase(allied_phantom_03.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task bug_out_pussy()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("bridge/grav"));
            Engine.cs_jump(0F, 1F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_gusty, Engine.ai_get_object(this.ai_current_actor)) == false, 1);
            Engine.object_set_scale(Engine.ai_get_object(this.ai_current_actor), 0.1F, 15);
            await Engine.sleep(15);
            Engine.ai_erase(this.ai_current_actor);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task control_bug_out()
        {
            Engine.ai_place(allied_phantom_03.Squad);
            Engine.cs_run_command_script(allied_phantom_03.Squad, control_bug_out_flight);
            await Engine.sleep_until(async () => this.bug_out_phantom_here == true);
            Engine.cs_queue_command_script(control_commander_cinematic.Squad, bug_out_pussy);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(control_commander_cinematic.Squad) < 1);
            Engine.cs_run_command_script(control_elites_cinematic.elite01, bug_out_pussy);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(control_elites_cinematic.Squad) < 2);
            Engine.cs_run_command_script(control_elites_cinematic.elite02, bug_out_pussy);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(control_elites_cinematic.Squad) < 1);
            Engine.cs_run_command_script(allies_grunts_03.Squad, bug_out_pussy);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(allies_grunts_03.Squad) < 1);
            Engine.cs_run_command_script(allies_grunts_04.Squad, bug_out_pussy);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(allies_grunts_04.Squad) < 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task control_flood_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_flood) < 6 && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_flood_wave_02_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_flood) < 6 && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_flood_wave_02_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_flood) < 6 && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_flood_wave_02_carriers.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_flood) < 6 && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_flood_wave_03_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_flood) < 6 && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_flood_wave_03_combat.Squad, 1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_flood) < 6 && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_flood_wave_03_carriers.Squad, 1);
                    }
                });
                return Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == true || (short)Engine.ai_spawn_count(control_flood) > 10;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task control_room_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_enter, Engine.players()) == true);
            Engine.wake(hl_killer);
            Engine.ai_disposable(bridge_flood, true);
            Engine.ai_disposable(bridge_heretics, true);
            Engine.ai_disposable(bridge_sentinels, true);
            Engine.data_mine_set_mission_segment("04b_12_control_room_01");
            Engine.game_save();
            Engine.ai_migrate(allies_elites, allies_elites_04.Squad);
            Engine.device_set_power(control_up_switch_01.Entity, 0F);
            Engine.device_set_position_immediate(elev_control_up.Entity, 0.041F);
            Engine.device_set_position_immediate(shield.Entity, 1F);
            Engine.device_set_position_immediate(control_shield_door.Entity, 1F);
            Engine.ai_renew(all_allies);
            Engine.ai_set_orders(core_allies, allies_control);
            Engine.ai_place(heretic_leader_control.Squad);
            Engine.ai_cannot_die(heretic_leader_control.Squad, true);
            Engine.unit_impervious(Engine.ai_actors(heretic_leader_control.Squad), true);
            Engine.ai_set_blind(heretic_leader_control.Squad, true);
            Engine.ai_set_deaf(heretic_leader_control.Squad, true);
            Engine.cs_run_command_script(heretic_leader_control.Squad, heretic_leader_holes_up);
            Engine.ai_disregard(Engine.ai_actors(heretic_leader_control.Squad), true);
            Engine.ai_place(control_flood_wave_01_combat.Squad, 4);
            Engine.ai_place(control_sentinels_wave_01.Squad, 3);
            Engine.wake(music_04b_04_start);
            Engine.wake(hologram_toggle);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_enter, Engine.ai_actors(allies_grunts_03.Squad)) == true || Engine.volume_test_objects(vol_control_enter, Engine.ai_actors(allies_grunts_04.Squad)) == true || Engine.volume_test_objects(vol_control_enter, Engine.ai_actors(allies_elites_04.Squad)) == true, 30, 300);
            await Engine.sleep_until(async () => Engine.ai_scene("control_grunt_scene", control_grunt_comment, all_allies) || Engine.ai_scene("control_elite_scene", control_elite_comment, all_allies), 30, 300);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(control_flood_wave_01_combat.Squad) == 0 && (short)Engine.ai_living_count(control_sentinels_wave_01.Squad) == 0);
            await Engine.sleep(60);
            Engine.wake(music_04b_04_start_alt);
            await this.cinematic_fade_to_white();
            Engine.ai_erase(heretic_leader_control.Squad);
            Engine.ai_erase(all_enemies);
            Engine.ai_erase(disposal_commander.Squad);
            Engine.ai_erase(allies_elites);
            Engine.ai_erase(allies_elites_04.Squad);
            Engine.object_teleport(await this.player0(), player0_hide);
            Engine.object_teleport(await this.player1(), player1_hide);
            Engine.sleep_forever(hologram_toggle);
            Engine.object_create_anew(gasmine_hologram);
            Engine.object_set_function_variable(gasmine_hologram.Entity, "holo_power", 1F, 0F);
            if (await this.cinematic_skip_start())
            {
                await this.c04_intra1();
            }

            await this.cinematic_skip_stop();
            Engine.sound_suppress_ambience_update_on_revert();
            Engine.sound_class_set_gain("amb", 0F, 0);
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 1F, 15);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), player0_control);
            Engine.object_teleport(await this.player1(), player1_control);
            Engine.device_set_position_immediate(control_shield_door.Entity, 0F);
            Engine.device_set_position_immediate(shield.Entity, 0F);
            Engine.ai_place(control_elites_cinematic.Squad);
            Engine.ai_place(control_commander_cinematic.Squad);
            Engine.ai_cannot_die(control_commander_cinematic.Squad, true);
            Engine.ai_set_orders(all_allies, allies_pickup);
            Engine.device_set_power(control_up_switch_01.Entity, 1F);
            Engine.wake(hologram_toggle);
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white();
            Engine.wake(music_04b_04_stop_alt);
            Engine.wake(objective_control_clear);
            Engine.wake(objective_cables_set);
            Engine.ai_scene("control_comm_scene", commander_farewell, all_allies) // Couldn't generate cast from 'Boolean' to 'Void'
            ;
            Engine.cs_run_command_script(control_elites_cinematic.elite01, soe_bug_out_01);
            Engine.cs_run_command_script(control_elites_cinematic.elite02, soe_bug_out_02);
            Engine.data_mine_set_mission_segment("04b_13_control_room_02");
            Engine.game_save();
            Engine.wake(control_commander_reminder);
            Engine.wake(control_bug_out);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_middle, Engine.players()) == true, 30, 1800);
            Engine.wake(control_flood_spawn);
            await Engine.sleep_until(async () => (short)Engine.ai_combat_status(control_flood) >= this.ai_combat_status_visible || Engine.volume_test_objects(vol_control_middle, Engine.players()) == true || Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == true || Engine.volume_test_objects(vol_control_top, Engine.ai_actors(control_flood)) == true);
            Engine.wake(music_04b_05_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_perimeter, Engine.players()) == true || Engine.volume_test_objects(vol_control_top, Engine.ai_actors(control_flood)) == true);
            Engine.device_set_position(elev_control_up.Entity, 0F);
            Engine.ai_place(control_sentinels_wave_03.Squad, 3);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_return, Engine.players()) == true);
            Engine.wake(music_04b_04_stop);
            Engine.objects_predict(cableroom.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task strain()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.effect_new(this.stress, croom01), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom02), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom03), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom04), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom05), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom06), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom07), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom08), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom09), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom10), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom11), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.stress, croom12), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return (short)Engine.structure_bsp_index() == 4;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task rip()
        {
            Engine.begin_random(async () => Engine.effect_new(this.boom, tear01), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear02), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear03), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear04), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear05), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear06), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear07), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear08), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear09), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear10), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear11), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear12), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear13), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear14), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear15), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear16), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear17), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear18), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)), 
                async () => Engine.effect_new(this.boom, tear19), 
                async () => await Engine.sleep((short)Engine.random_range(1, 5)));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task try_to_fix()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_approach(croom_center.Entity, 4F, 20F, 20F);
            Engine.unit_add_equipment(Engine.unit(Engine.ai_get_object(this.ai_current_actor)), swap, true, true);
            Engine.cs_shoot(true, croom_center.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task grav_test()
        {
            this.gravity = 0F;
            Engine.physics_set_gravity(this.gravity);
            await Engine.sleep_until(async () =>
            {
                Engine.physics_set_gravity(this.gravity);
                this.gravity = this.gravity + 0.1F;
                return this.gravity > 0.9F;
            });
            this.gravity = 1F;
            Engine.physics_set_gravity(this.gravity);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cam_shake()
        {
            Engine.player_effect_set_max_rotation(0F, 2F, 2F);
            Engine.player_effect_start(0.5F, 0F);
            Engine.player_effect_stop(1.5F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task cam_roll()
        {
            Engine.player_effect_set_max_rotation(0.2F, 0.2F, 0.2F);
            Engine.player_effect_start(0.1F, 1F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cam_shake_cont()
        {
            Engine.player_effect_set_max_rotation(0F, 2F, 2F);
            Engine.player_effect_start(0.5F, 0F);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_going_down, Engine.players()) == true);
            Engine.player_effect_start(0.45F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.4F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.35F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.3F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.25F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.2F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.15F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.1F, 0F);
            await Engine.sleep(60);
            Engine.player_effect_start(0.05F, 0F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_invulnerable()
        {
            await Engine.sleep_until(async () => this.cables_cuttable == false, 1);
            Engine.object_cannot_take_damage(real_cable_a.Entity);
            Engine.object_cannot_take_damage(real_cable_b.Entity);
            Engine.object_cannot_take_damage(real_cable_c.Entity);
            await Engine.sleep_until(async () => Engine.device_get_position(cableroom.Entity) == 1F);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'that's one! by the prophets! look at the station list!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1380"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep_until(async () => this.cables_cuttable == true && Engine.device_get_position(cableroom.Entity) == 1F, 1);
            Engine.object_can_take_damage(real_cable_a.Entity);
            Engine.object_can_take_damage(real_cable_b.Entity);
            Engine.object_can_take_damage(real_cable_c.Entity);
            await Engine.sleep(5);
            await Engine.sleep_until(async () => this.cables_cuttable == false, 1);
            Engine.object_cannot_take_damage(real_cable_a.Entity);
            Engine.object_cannot_take_damage(real_cable_b.Entity);
            Engine.object_cannot_take_damage(real_cable_c.Entity);
            await Engine.sleep_until(async () => Engine.device_get_position(cableroom.Entity) == 1F);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'one final cable arbiter�'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1400"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            await Engine.sleep(30);
            Engine.wake(music_04b_06_start);
            await Engine.sleep_until(async () => this.cables_cuttable == true && Engine.device_get_position(cableroom.Entity) == 1F, 1);
            Engine.object_can_take_damage(real_cable_a.Entity);
            Engine.object_can_take_damage(real_cable_b.Entity);
            Engine.object_can_take_damage(real_cable_c.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cableroom_suck_killer()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(vol_cableroom_suck_kill), 0));
                await Engine.sleep(5);
                Engine.unit_kill(Engine.unit(Engine.list_get(Engine.volume_return_objects_by_type(vol_cableroom_suck_kill, 1), 0)));
                await Engine.sleep(5);
                return this.in_cable_room == false;
            }, 5);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cableroom_junk_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.object_create_anew(croom_junk_01), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_02), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_03), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_04), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_05), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_06), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_07), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_08), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_09), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_10), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_11), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_12), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_13), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_14), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_15), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_16), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)), 
                    async () => Engine.object_create_anew(croom_junk_17), 
                    async () => await Engine.sleep((short)Engine.random_range(20, 60)));
                return this.in_cable_room == false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_nav_a()
        {
            Engine.activate_team_nav_point_object(_default, player, cable_target_a.Entity, 0F);
            await Engine.sleep_until(async () => Engine.object_get_health(real_cable_a.Entity) <= 0F);
            Engine.deactivate_team_nav_point_object(player, cable_target_a.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_nav_b()
        {
            Engine.activate_team_nav_point_object(_default, player, cable_target_b.Entity, 0F);
            await Engine.sleep_until(async () => Engine.object_get_health(real_cable_b.Entity) <= 0F);
            Engine.deactivate_team_nav_point_object(player, cable_target_b.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_nav_c()
        {
            Engine.activate_team_nav_point_object(_default, player, cable_target_c.Entity, 0F);
            await Engine.sleep_until(async () => Engine.object_get_health(real_cable_c.Entity) <= 0F);
            Engine.deactivate_team_nav_point_object(player, cable_target_c.Entity);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cableroom_commander_reminder()
        {
            await Engine.sleep_until(async () => Engine.object_get_health(real_cable_a.Entity) <= 0F || Engine.object_get_health(real_cable_b.Entity) <= 0F || Engine.object_get_health(real_cable_c.Entity) <= 0F, 30, 3600);
            if (Engine.object_get_health(real_cable_a.Entity) > 0F && Engine.object_get_health(real_cable_b.Entity) > 0F && Engine.object_get_health(real_cable_c.Entity) > 0F)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'sever the cable at the points where it connect to the structure!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1370"));
                await Engine.sleep(30);
                Engine.wake(cable_nav_a);
                Engine.wake(cable_nav_b);
                Engine.wake(cable_nav_c);
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task cable_look()
        {
            Engine.cs_face_object(true, cableroom.Entity);
            await Engine.sleep_until(async () => this.plummeting == true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_a_health()
        {
            await Engine.sleep_until(async () => Engine.object_get_health(real_cable_a.Entity) <= 0F, 1);
            this.cables_cuttable = false;
            this.cable_var = (short)(this.cable_var + 1);
            Engine.object_create_anew(cable_nub_a);
            Engine.objects_attach(cableroom.Entity, "rot_a", cable_nub_a.Entity, "cable_destroyed");
            if (this.cable_var == 1)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_a.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4221704553U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_01_quad", 4221835627U), default(IGameObject), 1F);
                Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_5_bc", 0F);
                Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                Engine.game_save();
            }

            if (this.cable_var == 2)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_a.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4221704553U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_02_quad", 4222032238U), default(IGameObject), 1F);
                if (Engine.object_get_health(real_cable_b.Entity) <= 0F)
                {
                    Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_ac2c", 0F);
                    Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                }

                if (Engine.object_get_health(real_cable_c.Entity) <= 0F)
                {
                    Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_ab2b", 0F);
                    Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                }

                Engine.game_save();
            }

            if (this.cable_var == 3)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_a.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_two", 4222228849U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_03_quad", 4222359923U), default(IGameObject), 1F);
                Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_a_back", 0F);
                Engine.device_animate_position(cableroom.Entity, 1F, 2F, 0F, 0.5F, false);
                Engine.ai_set_orders(cable_sentinels, cable_room_sentinels_end);
                Engine.ai_set_blind(cable_sentinels, true);
                Engine.ai_set_blind(cable_flood, true);
                Engine.cs_run_command_script(cable_flood, cable_look);
                Engine.wake(music_04b_07_start);
                Engine.wake(strain);
                await Engine.sleep(400);
                Engine.object_type_predict_high(Engine.GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room\\cable_room", 4103803514U));
                Engine.object_type_predict_high(Engine.GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room_top\\cable_room_top", 4109112011U));
                await Engine.sleep(20);
                Engine.objects_detach(cableroom.Entity, real_cable_a.Entity);
                Engine.objects_detach(cableroom.Entity, real_cable_b.Entity);
                Engine.objects_detach(cableroom.Entity, real_cable_c.Entity);
                Engine.objects_detach(cableroom.Entity, elev_control_up.Entity);
                Engine.objects_detach(cableroom.Entity, control_up_switch_02.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_a.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_b.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_c.Entity);
                Engine.object_destroy(cableroom.Entity);
                Engine.switch_bsp(4);
                Engine.wake(cam_shake_cont);
                Engine.physics_disable_character_ground_adhesion_forces(1F);
                Engine.objects_attach(cableroom_top.Entity, "rot_a", real_cable_a.Entity, "");
                Engine.objects_attach(cableroom_top.Entity, "rot_b", real_cable_b.Entity, "");
                Engine.objects_attach(cableroom_top.Entity, "rot_c", real_cable_c.Entity, "");
                Engine.objects_attach(cableroom2.Entity, "elevator", elev_control_up.Entity, "elev_top");
                Engine.objects_attach(cableroom2.Entity, "switch", control_up_switch_02.Entity, "");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_a.Entity, "torn02");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_b.Entity, "torn03");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_c.Entity, "");
                Engine.device_set_position_track(cableroom2.Entity, "cable_room_drop", 0F);
                Engine.device_animate_position(cableroom2.Entity, 1F, 1F, 0F, 0.5F, false);
                Engine.device_set_position(cableroom_top.Entity, 1F);
                Engine.wake(cableroom_suck_killer);
                Engine.wake(cableroom_junk_spawn);
                Engine.object_create(suction);
                Engine.wake(grav_test);
                this.plummeting = true;
                await Engine.cache_block_for_one_frame();
                await Engine.sleep(150);
                Engine.object_destroy(cableroom_top.Entity);
            }

            await Engine.sleep(30);
            this.cables_cuttable = true;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_b_health()
        {
            await Engine.sleep_until(async () => Engine.object_get_health(real_cable_b.Entity) <= 0F, 1);
            this.cables_cuttable = false;
            this.cable_var = (short)(this.cable_var + 1);
            Engine.object_create_anew(cable_nub_b);
            Engine.objects_attach(cableroom.Entity, "rot_b", cable_nub_b.Entity, "cable_destroyed");
            if (this.cable_var == 1)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_b.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4221704553U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_01_quad", 4221835627U), default(IGameObject), 1F);
                Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_5_ac", 0F);
                Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                Engine.game_save();
            }

            if (this.cable_var == 2)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_b.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4221704553U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_02_quad", 4222032238U), default(IGameObject), 1F);
                if (Engine.object_get_health(real_cable_a.Entity) <= 0F)
                {
                    Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_bc2c", 0F);
                    Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                }

                if (Engine.object_get_health(real_cable_c.Entity) <= 0F)
                {
                    Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_ab2a", 0F);
                    Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                }

                Engine.game_save();
            }

            if (this.cable_var == 3)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_b.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_two", 4222228849U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_03_quad", 4222359923U), default(IGameObject), 1F);
                Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_b_back", 0F);
                Engine.device_animate_position(cableroom.Entity, 1F, 2F, 0F, 0.5F, false);
                Engine.cs_run_command_script(cable_room_sentinels.Squad, try_to_fix);
                Engine.ai_set_orders(cable_sentinels, cable_room_sentinels_end);
                Engine.ai_set_blind(cable_sentinels, true);
                Engine.ai_set_blind(cable_flood, true);
                Engine.cs_run_command_script(cable_flood, cable_look);
                Engine.wake(music_04b_07_start);
                Engine.wake(strain);
                await Engine.sleep(400);
                Engine.object_type_predict_high(Engine.GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room\\cable_room", 4103803514U));
                Engine.object_type_predict_high(Engine.GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room_top\\cable_room_top", 4109112011U));
                await Engine.sleep(20);
                Engine.objects_detach(cableroom.Entity, real_cable_a.Entity);
                Engine.objects_detach(cableroom.Entity, real_cable_b.Entity);
                Engine.objects_detach(cableroom.Entity, real_cable_c.Entity);
                Engine.objects_detach(cableroom.Entity, elev_control_up.Entity);
                Engine.objects_detach(cableroom.Entity, control_up_switch_02.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_a.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_b.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_c.Entity);
                Engine.object_destroy(cableroom.Entity);
                Engine.switch_bsp(4);
                Engine.wake(cam_shake_cont);
                Engine.physics_disable_character_ground_adhesion_forces(1F);
                Engine.objects_attach(cableroom_top.Entity, "rot_a", real_cable_a.Entity, "");
                Engine.objects_attach(cableroom_top.Entity, "rot_b", real_cable_b.Entity, "");
                Engine.objects_attach(cableroom_top.Entity, "rot_c", real_cable_c.Entity, "");
                Engine.objects_attach(cableroom2.Entity, "elevator", elev_control_up.Entity, "elev_top");
                Engine.objects_attach(cableroom2.Entity, "switch", control_up_switch_02.Entity, "");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_a.Entity, "torn02");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_b.Entity, "torn03");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_c.Entity, "");
                Engine.device_set_position_track(cableroom2.Entity, "cable_room_drop", 0F);
                Engine.device_animate_position(cableroom2.Entity, 1F, 1F, 0F, 0.5F, false);
                Engine.device_set_position(cableroom_top.Entity, 1F);
                Engine.wake(cableroom_suck_killer);
                Engine.wake(cableroom_junk_spawn);
                Engine.object_create(suction);
                Engine.wake(grav_test);
                this.plummeting = true;
                await Engine.cache_block_for_one_frame();
                await Engine.sleep(150);
                Engine.object_destroy(cableroom_top.Entity);
            }

            await Engine.sleep(30);
            this.cables_cuttable = true;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_c_health()
        {
            await Engine.sleep_until(async () => Engine.object_get_health(real_cable_c.Entity) <= 0F, 1);
            this.cables_cuttable = false;
            this.cable_var = (short)(this.cable_var + 1);
            Engine.object_create_anew(cable_nub_c);
            Engine.objects_attach(cableroom.Entity, "rot_c", cable_nub_c.Entity, "cable_destroyed");
            if (this.cable_var == 1)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_c.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4221704553U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_01_quad", 4221835627U), default(IGameObject), 1F);
                Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_5_ab", 0F);
                Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                Engine.game_save();
            }

            if (this.cable_var == 2)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_c.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_one", 4221704553U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_02_quad", 4222032238U), default(IGameObject), 1F);
                if (Engine.object_get_health(real_cable_a.Entity) <= 0F)
                {
                    Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_bc2b", 0F);
                    Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                }

                if (Engine.object_get_health(real_cable_b.Entity) <= 0F)
                {
                    Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_ac2a", 0F);
                    Engine.device_animate_position(cableroom.Entity, 1F, 10F, 1F, 4F, false);
                    this.croom_flood_total = (short)Engine.ai_nonswarm_count(cable_flood);
                    this.croom_sen_total = (short)Engine.ai_living_count(cable_sentinels);
                }

                Engine.game_save();
            }

            if (this.cable_var == 3)
            {
                await this.cam_shake();
                Engine.device_set_position(real_cable_c.Entity, 1F);
                Engine.sound_impulse_start(Engine.GetTag<SoundTag>("sound\\ambience\\alphagasgiant\\cable_snaps\\cable_snap_two", 4222228849U), default(IGameObject), 1F);
                Engine.sound_looping_start(Engine.GetTag<LoopingSoundTag>("sound_remastered\\visual_effects\\alphagas_cablelist\\alphacable_swtnr_03_quad", 4222359923U), default(IGameObject), 1F);
                Engine.device_set_position_track(cableroom.Entity, "cable_room_rot_c_back", 0F);
                Engine.device_animate_position(cableroom.Entity, 1F, 2F, 0F, 0.5F, false);
                Engine.cs_run_command_script(cable_room_sentinels.Squad, try_to_fix);
                Engine.ai_set_orders(cable_sentinels, cable_room_sentinels_end);
                Engine.ai_set_blind(cable_sentinels, true);
                Engine.ai_set_blind(cable_flood, true);
                Engine.cs_run_command_script(cable_flood, cable_look);
                Engine.wake(music_04b_07_start);
                Engine.wake(strain);
                await Engine.sleep(400);
                Engine.object_type_predict_high(Engine.GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room\\cable_room", 4103803514U));
                Engine.object_type_predict_high(Engine.GetTag<BaseTag>("scenarios\\objects\\solo\\alphagasgiant\\cable_room_top\\cable_room_top", 4109112011U));
                await Engine.sleep(20);
                Engine.objects_detach(cableroom.Entity, real_cable_a.Entity);
                Engine.objects_detach(cableroom.Entity, real_cable_b.Entity);
                Engine.objects_detach(cableroom.Entity, real_cable_c.Entity);
                Engine.objects_detach(cableroom.Entity, elev_control_up.Entity);
                Engine.objects_detach(cableroom.Entity, control_up_switch_02.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_a.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_b.Entity);
                Engine.objects_detach(cableroom.Entity, cable_nub_c.Entity);
                Engine.object_destroy(cableroom.Entity);
                Engine.switch_bsp(4);
                Engine.wake(cam_shake_cont);
                Engine.physics_disable_character_ground_adhesion_forces(1F);
                Engine.objects_attach(cableroom_top.Entity, "rot_a", real_cable_a.Entity, "");
                Engine.objects_attach(cableroom_top.Entity, "rot_b", real_cable_b.Entity, "");
                Engine.objects_attach(cableroom_top.Entity, "rot_c", real_cable_c.Entity, "");
                Engine.objects_attach(cableroom2.Entity, "elevator", elev_control_up.Entity, "elev_top");
                Engine.objects_attach(cableroom2.Entity, "switch", control_up_switch_02.Entity, "");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_a.Entity, "torn02");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_b.Entity, "torn03");
                Engine.objects_attach(cableroom2.Entity, "anim", cable_nub_c.Entity, "");
                Engine.device_set_position_track(cableroom2.Entity, "cable_room_drop", 0F);
                Engine.device_animate_position(cableroom2.Entity, 1F, 1F, 0F, 0.5F, false);
                Engine.device_set_position(cableroom_top.Entity, 1F);
                Engine.wake(cableroom_suck_killer);
                Engine.wake(cableroom_junk_spawn);
                Engine.object_create(suction);
                Engine.wake(grav_test);
                this.plummeting = true;
                await Engine.cache_block_for_one_frame();
                await Engine.sleep(150);
                Engine.object_destroy(cableroom_top.Entity);
            }

            await Engine.sleep(30);
            this.cables_cuttable = true;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_flood_spawner()
        {
            if (await this.difficulty_legendary())
            {
                this.croom_flood_desired = 10;
            }

            if (await this.difficulty_heroic())
            {
                this.croom_flood_desired = 8;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => this.croom_flood_total < this.croom_flood_desired && (short)Engine.ai_nonswarm_count(cable_flood) < (short)(this.croom_flood_desired / 2) || this.plummeting == true || this.cable_var > 0);
                if (this.plummeting == false && this.cable_var < 1)
                {
                    Engine.ai_place(cable_room_combatforms.Squad, 1);
                    this.croom_flood_total = (short)(this.croom_flood_total + 1);
                }

                return this.plummeting == true || this.cable_var > 0 || this.croom_flood_total >= this.croom_flood_desired;
            });
            await Engine.sleep_until(async () => this.cable_var > 0 || this.plummeting == true);
            if (this.plummeting == true)
            {
                Engine.sleep_forever();
            }

            this.croom_flood_total = 0;
            if (await this.difficulty_legendary())
            {
                this.croom_flood_desired = 12;
            }

            if (await this.difficulty_heroic())
            {
                this.croom_flood_desired = 10;
            }

            if (await this.difficulty_normal())
            {
                this.croom_flood_desired = 8;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => this.croom_flood_total < this.croom_flood_desired && (short)Engine.ai_nonswarm_count(cable_flood) < (short)(this.croom_flood_desired / 2) || this.plummeting == true || this.cable_var > 1);
                if (this.plummeting == false && this.cable_var < 2)
                {
                    Engine.ai_place(cable_room_combatforms.Squad, 1);
                    this.croom_flood_total = (short)(this.croom_flood_total + 1);
                }

                return this.plummeting == true || this.cable_var > 1 || this.croom_flood_total >= this.croom_flood_desired;
            });
            await Engine.sleep_until(async () => this.cable_var > 1 || this.plummeting == true);
            if (this.plummeting == true)
            {
                Engine.sleep_forever();
            }

            this.croom_flood_total = 0;
            if (await this.difficulty_legendary())
            {
                this.croom_flood_desired = 14;
            }

            if (await this.difficulty_heroic())
            {
                this.croom_flood_desired = 12;
            }

            if (await this.difficulty_normal())
            {
                this.croom_flood_desired = 10;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => this.croom_flood_total < this.croom_flood_desired && (short)Engine.ai_nonswarm_count(cable_flood) < (short)(this.croom_flood_desired / 2) || this.plummeting == true || this.cable_var > 2);
                if (this.plummeting == false && this.cable_var < 3)
                {
                    Engine.ai_place(cable_room_combatforms.Squad, 1);
                    this.croom_flood_total = (short)(this.croom_flood_total + 1);
                }

                return this.plummeting == true || this.cable_var > 2 || this.croom_flood_total >= this.croom_flood_desired;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_sentinel_spawner()
        {
            if (await this.difficulty_legendary())
            {
                this.croom_sen_desired = 8;
            }

            if (await this.difficulty_heroic())
            {
                this.croom_sen_desired = 6;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cable_sentinels) < (short)(this.croom_sen_desired / 2) && this.croom_sen_total < this.croom_sen_desired || this.plummeting == true || this.cable_var > 0);
                if (this.plummeting == false && this.cable_var < 1)
                {
                    Engine.ai_place(cable_room_sentinels.Squad, 1);
                    this.croom_sen_total = (short)(this.croom_sen_total + 1);
                }

                return this.plummeting == true || this.cable_var > 0 || this.croom_sen_total >= this.croom_sen_desired;
            });
            await Engine.sleep_until(async () => this.cable_var > 0 || this.plummeting == true);
            if (this.plummeting == true)
            {
                Engine.sleep_forever();
            }

            this.croom_sen_total = 0;
            if (await this.difficulty_legendary())
            {
                this.croom_sen_desired = 6;
            }

            if (await this.difficulty_heroic())
            {
                this.croom_sen_desired = 4;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cable_sentinels) < (short)(this.croom_sen_desired / 2) && this.croom_sen_total < this.croom_sen_desired || this.plummeting == true || this.cable_var > 1);
                if (this.plummeting == false && this.cable_var < 2)
                {
                    Engine.ai_place(cable_room_sentinels.Squad, 1);
                    this.croom_sen_total = (short)(this.croom_sen_total + 1);
                }

                return this.plummeting == true || this.cable_var > 1 || this.croom_sen_total >= this.croom_sen_desired;
            });
            await Engine.sleep_until(async () => this.cable_var > 1 || this.plummeting == true);
            if (this.plummeting == true)
            {
                Engine.sleep_forever();
            }

            this.croom_sen_total = 0;
            if (await this.difficulty_legendary())
            {
                this.croom_sen_desired = 4;
            }

            if (await this.difficulty_heroic())
            {
                this.croom_sen_desired = 4;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(cable_sentinels) < (short)(this.croom_sen_desired / 2) && this.croom_sen_total < this.croom_sen_desired || this.plummeting == true || this.cable_var > 2);
                if (this.plummeting == false && this.cable_var < 3)
                {
                    Engine.ai_place(cable_room_sentinels.Squad, 1);
                    this.croom_sen_total = (short)(this.croom_sen_total + 1);
                }

                return this.plummeting == true || this.cable_var > 2 || this.croom_sen_total >= this.croom_sen_desired;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task croom_exit()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_going_down, Engine.players()) == true, 1);
            Engine.sleep_forever(cableroom_killer);
            Engine.device_set_power(control_up_switch_01.Entity, 0F);
            Engine.device_set_power(control_up_switch_02.Entity, 0F);
            Engine.device_set_position(elev_control_up.Entity, 0.04195F);
            this.in_cable_room = false;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task cable_room_start()
        {
            Engine.ai_disposable(control_flood, true);
            Engine.ai_disposable(control_sentinels, true);
            Engine.ai_erase_all();
            Engine.sleep_forever(wind);
            Engine.data_mine_set_mission_segment("04b_14_cable_room");
            Engine.object_cannot_take_damage(await this.player0());
            Engine.object_cannot_take_damage(await this.player1());
            Engine.objects_attach(cableroom.Entity, "rot_a", real_cable_a.Entity, "");
            Engine.objects_attach(cableroom.Entity, "rot_b", real_cable_b.Entity, "");
            Engine.objects_attach(cableroom.Entity, "rot_c", real_cable_c.Entity, "");
            Engine.objects_attach(real_cable_a.Entity, "cut_here", cable_target_a.Entity, "");
            Engine.objects_attach(real_cable_b.Entity, "cut_here", cable_target_b.Entity, "");
            Engine.objects_attach(real_cable_c.Entity, "cut_here", cable_target_c.Entity, "");
            Engine.objects_attach(cableroom.Entity, "switch", control_up_switch_02.Entity, "");
            Engine.cinematic_lighting_set_primary_light(28F, 118F, 0.419608F, 0.313726F, 0.247059F);
            Engine.cinematic_lighting_set_secondary_light(-26F, 312F, 0.113725F, 0.0941177F, 0.0862745F);
            Engine.cinematic_lighting_set_ambient_light(0.0470588F, 0.0509804F, 0.054902F);
            Engine.object_uses_cinematic_lighting(real_cable_a.Entity, true);
            Engine.object_uses_cinematic_lighting(real_cable_b.Entity, true);
            Engine.object_uses_cinematic_lighting(real_cable_c.Entity, true);
            Engine.wake(cable_a_health);
            Engine.wake(cable_b_health);
            Engine.wake(cable_c_health);
            Engine.wake(cable_invulnerable);
            Engine.wake(cable_flood_spawner);
            Engine.wake(cable_sentinel_spawner);
            Engine.device_set_power(control_up_switch_02.Entity, 0F);
            this.in_cable_room = true;
            Engine.wake(_04b_title1);
            Engine.ai_place(cableroom_sentinels_init.Squad, 3);
            Engine.ai_place(cableroom_flood_init.Squad, 6);
            await Engine.sleep_until(async () => Engine.device_get_position(elev_control_up.Entity) > 0.95F);
            Engine.object_can_take_damage(await this.player0());
            Engine.object_can_take_damage(await this.player1());
            Engine.wake(cableroom_killer);
            Engine.wake(cableroom_junk_killer);
            Engine.game_save_immediate();
            await Engine.sleep_until(async () => Engine.device_get_position(elev_control_up.Entity) == 1F);
            Engine.objects_attach(cableroom.Entity, "elevator", elev_control_up.Entity, "elev_top");
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'all my phantoms are in the air, arbiter. go ahead - cut the cable!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0170"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.wake(cableroom_commander_reminder);
            await Engine.sleep_until(async () => this.plummeting == true);
            Engine.wake(croom_exit);
            Engine.wake(objective_cables_clear);
            await Engine.sleep(30);
            await Engine.sleep_until(async () => Engine.device_get_position(cableroom2.Entity) == 1F);
            Engine.objects_detach(cableroom2.Entity, elev_control_up.Entity);
            await Engine.sleep(2);
            Engine.device_set_position(elev_control_up.Entity, 0.99999F);
            await Engine.sleep(2);
            Engine.device_set_power(control_up_switch_02.Entity, 1F);
            await Engine.sleep(90);
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'that did it! the station is in free-fall!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0180"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
            Engine.wake(objective_dogfight_set);
            Engine.game_save();
            Engine.ai_set_blind(cable_flood, false);
            Engine.ai_set_orders(cable_flood, cable_room_after);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task plummeting_control_commander()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'the heretic leader is on the move! do not let him escape! we'll stay with you as long as we can! '");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0190"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task control_return_flood_spawn()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_middle_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.mid01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_middle_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.mid02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_middle_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.mid03);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_middle_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.mid04);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_middle_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_02.mid01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_middle_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_middle_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_02.mid02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.peri02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.peri03);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_02.peri04);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_02.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_02.peri02);
                    }
                });
                return (short)Engine.ai_living_count(control_return_heretics) == 0 || (short)Engine.ai_spawn_count(control_return_flood) > 10 || Engine.volume_test_objects(vol_control_return_perimeter, Engine.players()) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.peri02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.peri03);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.peri04);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_03.peri01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_peri_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_peri_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_03.peri02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.bott02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.bott03);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_03.bott04);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_03.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_03.bott02);
                    }
                });
                return (short)Engine.ai_living_count(control_return_heretics) == 0 || (short)Engine.ai_spawn_count(control_return_flood) > 10 || Engine.volume_test_objects(vol_control_return_middle, Engine.players()) == true;
            });
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.bott02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.bott03);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.bott04);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_04.bott01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_bottom_spawnroom.Entity) == 0F && Engine.volume_test_objects(vol_control_bottom_spawnroom, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_04.bott02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_entry_int.Entity) == 0F && Engine.volume_test_objects(vol_control_entry_int, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.entry01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_entry_int.Entity) == 0F && Engine.volume_test_objects(vol_control_entry_int, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.entry02);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_entry_int.Entity) == 0F && Engine.volume_test_objects(vol_control_entry_int, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.entry03);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_entry_int.Entity) == 0F && Engine.volume_test_objects(vol_control_entry_int, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_flood_04.entry04);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_entry_int.Entity) == 0F && Engine.volume_test_objects(vol_control_entry_int, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_04.entry01);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_nonswarm_count(control_return_flood) < 3 && Engine.device_get_position(control_entry_int.Entity) == 0F && Engine.volume_test_objects(vol_control_entry_int, Engine.players()) == false && await this.player_count() > 0)
                    {
                        Engine.ai_place(control_return_carriers_04.entry02);
                    }
                });
                return (short)Engine.ai_living_count(control_return_heretics) == 0 || (short)Engine.ai_spawn_count(control_return_flood) > 10 || Engine.volume_test_objects(vol_power_core_enter, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task control_return_heretic()
        {
            Engine.cs_switch("heretic_01");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.print("heretic elite 1: 'our lives for the truth!'");
            Engine.cs_play_line("0750");
            Engine.cs_switch("heretic_02");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.print("heretic elite 2: 'the truth and the covenant!'");
            Engine.cs_play_line("0760");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task control_room_return()
        {
            Engine.ai_disposable(cable_flood, true);
            Engine.ai_disposable(cable_sentinels, true);
            Engine.ai_disposable(all_allies, true);
            Engine.ai_erase_all();
            Engine.device_set_position_immediate(control_shield_door.Entity, 1F);
            Engine.device_set_position_immediate(shield.Entity, 1F);
            Engine.device_operates_automatically_set(control_room_ext.Entity, false);
            Engine.device_operates_automatically_set(control_entry_int.Entity, false);
            Engine.data_mine_set_mission_segment("04b_15_control_return");
            await Engine.sleep_until(async () => Engine.device_get_position(elev_control_up.Entity) < 0.05F || Engine.volume_test_objects(vol_control_top, Engine.players()) == true);
            Engine.game_save_immediate();
            Engine.wake(plummeting_control_commander);
            Engine.ai_place(control_return_sentinels_01.Squad, 2);
            Engine.ai_place(control_return_heretics_01.Squad, 1);
            Engine.ai_place(control_return_heretics_02.Squad, 2);
            Engine.ai_place(control_return_h_grunts_02.Squad, 2);
            await Engine.sleep(90);
            Engine.ai_place(control_return_flood_01.Squad, 2);
            Engine.ai_place(control_return_carriers_01.Squad, 2);
            Engine.wake(control_return_flood_spawn);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_control_return_middle, Engine.players()) == true || (short)Engine.ai_living_count(control_return_heretics) < 3);
            Engine.game_save();
            Engine.ai_place(control_return_heretics_03.Squad, (short)(2 - (float)Engine.ai_living_count(control_return_heretics_02.Squad)));
            Engine.ai_place(control_return_h_grunts_03.Squad, (short)(2 - (float)Engine.ai_living_count(control_return_h_grunts_02.Squad)));
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_near_shield, Engine.players()) == true);
            await Engine.sleep_until(async () => Engine.ai_scene("control_return_scene", control_return_heretic, control_return_heretics) || (short)Engine.ai_living_count(control_return_heretics) == 0, 30, 150);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(control_return_heretics) == 0);
            Engine.game_save();
            Engine.ai_set_orders(control_return_flood, control_return_flood_win);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task power_core_heretic()
        {
            Engine.cs_switch("heretic_01");
            Engine.cs_enable_moving(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.print("heretic elite: 'the oracle must be saved!'");
            Engine.cs_play_line("0740");
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task power_core_commander()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            await Engine.sleep_until(async () => (bool)Engine.game_safe_to_save());
            Engine.print("spec-ops commander: 'are you still alive, arbiter?'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0770"));
            Engine.print("spec-ops commander: 'we're keeping pace as best we can.'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0780"));
            Engine.game_save();
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hl_retreat_x()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("fake_cinematics/p4"));
            Engine.ai_erase(heretic_leader_04.Squad);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task power_core_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_power_core_enter, Engine.players()) == true);
            Engine.ai_disposable(control_return_flood, true);
            Engine.ai_disposable(control_return_sentinels, true);
            Engine.ai_disposable(control_return_heretics, true);
            Engine.device_operates_automatically_set(hl_ledge_ext.Entity, true);
            Engine.data_mine_set_mission_segment("04b_16_power_core");
            Engine.ai_set_orders(control_return_flood, power_core_flood_all);
            Engine.ai_place(power_core_combatforms.Squad, 2);
            Engine.ai_place(power_core_carriers.Squad, 1);
            Engine.ai_place(power_core_sentinels_01.Squad, 2);
            Engine.ai_place(power_core_heretics_01.Squad, 1);
            Engine.ai_place(power_core_h_grunts_01.Squad, 2);
            Engine.wake(power_core_commander);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_power_core_midway, Engine.players()) == true || (short)Engine.ai_living_count(power_core_heretics) < 2);
            Engine.object_create(player0_fake_banshee);
            Engine.object_create(player1_fake_banshee);
            Engine.object_create(hl_fake_banshee);
            Engine.object_cannot_take_damage(player0_fake_banshee.Entity);
            Engine.object_cannot_take_damage(player1_fake_banshee.Entity);
            Engine.object_cannot_take_damage(hl_fake_banshee.Entity);
            Engine.game_save();
            await Engine.sleep_until(async () => Engine.ai_scene("power_core_scene", power_core_heretic, power_core_heretics) || Engine.volume_test_objects(vol_power_core_bottom, Engine.players()) == true);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_power_core_bottom, Engine.players()) == true);
            if (await this.difficulty_normal() || await this.difficulty_heroic())
            {
                Engine.ai_place(power_core_swords.Squad, 1);
            }

            if (await this.difficulty_legendary())
            {
                Engine.ai_place(power_core_swords.Squad, 2);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task plummet_killer()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.object_destroy(Engine.list_get(Engine.volume_return_objects(vol_cableroom_suck_kill), 0));
                this.plummet_junk_total = (short)(this.plummet_junk_total - 1);
                await Engine.sleep(5);
                return (short)Engine.structure_bsp_index() == 5;
            }, 5);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task plummet_fl()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_plummet_fl, Engine.players()) == true);
                Engine.begin_random(async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fl32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }));
                return Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task plummet_fr()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_plummet_fr, Engine.players()) == true);
                Engine.begin_random(async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(fr32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }));
                return Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task plummet_nr()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_plummet_nr, Engine.players()) == true);
                Engine.begin_random(async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nr32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }));
                return Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task plummet_nl()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_plummet_nl, Engine.players()) == true);
                Engine.begin_random(async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl01);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl02);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl03);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl04);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl05);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl06);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl08);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl09);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl10);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl11);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl12);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl14);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl15);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl16);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl17);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl18);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl19);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl20);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl21);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl22);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl23);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl24);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl25);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl26);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }), 
                    async () => Engine.begin_random(async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl27);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl28);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl29);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl30);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl31);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }, 
    async () =>
                {
                    if (this.plummet_junk_total < 50)
                    {
                        Engine.object_create_anew(nl32);
                        this.plummet_junk_total = (short)(this.plummet_junk_total + 1);
                        await Engine.sleep((short)Engine.random_range(5, 15));
                    }
                }));
                return Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task banshee_killer_00()
        {
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d", Engine.unit(await this.player0())) == false);
            Engine.unit_kill(Engine.unit(await this.player0()));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task banshee_killer_01()
        {
            await Engine.sleep_until(async () => Engine.vehicle_test_seat(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.left), "banshee_d", Engine.unit(await this.player1())) == false);
            Engine.unit_kill(Engine.unit(await this.player1()));
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task dervish_chase_01()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("fake_cinematics/p1"));
            Engine.cs_shoot(true, Engine.list_get(Engine.ai_actors(heretic_leader_04.Squad), 0));
            await Engine.sleep(60);
            Engine.cs_shoot(false, Engine.list_get(Engine.ai_actors(heretic_leader_04.Squad), 0));
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("fake_cinematics/p0"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("fake_cinematics/p4"));
            Engine.cs_crouch(true);
            await Engine.sleep_until(async () => this.cinematic_shooting_done == true);
            Engine.cs_crouch(false);
            Engine.cs_face(false, Engine.GetReference<ISpatialPoint>("fake_cinematics/p1"));
            Engine.cs_go_to_vehicle(player0_fake_banshee.Entity);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace3/p1"), 1F);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hl_retreat_04()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_go_to_vehicle(hl_fake_banshee.Entity);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace3/p3"), 2F);
            Engine.cs_shoot(true, Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0));
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace3/p5"), 2F);
            Engine.cs_shoot(false, Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0));
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace3/p6"), 2F);
            Engine.cs_vehicle_speed(1F);
            Engine.cs_vehicle_boost(true);
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace3/p8"), 5F);
            this.cinematic_shooting_done = true;
            Engine.cs_fly_by(Engine.GetReference<ISpatialPoint>("airspace3/p2"), 5F);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace3/p0"), 5F);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task banshee_sin_01_weapon()
        {
            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle.weapon", 3794927804U)) && this.banshee_sin_01_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0)), rifle, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine.weapon", 3828155063U)) && this.banshee_sin_01_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0)), carbine, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle.weapon", 3838247761U)) && this.banshee_sin_01_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0)), sniper, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\pistol\\needler\\needler.weapon", 3847357404U)) && this.banshee_sin_01_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0)), needler, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol.weapon", 3815440885U)) && this.banshee_sin_01_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0)), pistol, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\support_high\\flak_cannon\\flak_cannon.weapon", 3856663658U)) && this.banshee_sin_01_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0)), flak, true, true);
                this.banshee_sin_01_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\characters\\sentinel_aggressor\\weapons\\beam\\sentinel_aggressor_beam.weapon", 3862693062U)) && this.banshee_sin_01_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0)), beam, true, true);
                this.banshee_sin_01_ready = true;
            }
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task banshee_sin_01()
        {
            Engine.camera_control(true);
            Engine.cinematic_start_movie("floodlab_banshee_1");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.camera_set(cam00, 0);
            this.cinematic_shooting_done = false;
            Engine.ai_erase(heretic_leader_04.Squad);
            Engine.device_operates_automatically_set(hl_ledge_ext.Entity, true);
            Engine.device_set_position(hl_ledge_ext.Entity, 1F);
            Engine.object_create_anew(player0_fake_banshee);
            Engine.object_create_anew(player1_fake_banshee);
            Engine.object_create_anew(hl_fake_banshee);
            Engine.fade_in(1F, 1F, 1F, 15);
            Engine.ai_place(heretic_leader_04.Squad);
            Engine.cs_run_command_script(heretic_leader_04.Squad, hl_retreat_04);
            Engine.camera_set(cam01, 150);
            await Engine.sleep(150);
            Engine.ai_place(dervish_01.Squad);
            await this.banshee_sin_01_weapon();
            Engine.cs_run_command_script(dervish_01.Squad, dervish_chase_01);
            Engine.camera_set(cam05, 120);
            await Engine.sleep(120);
            Engine.camera_set(cam06, 60);
            await Engine.sleep(60);
            await Engine.sleep_until(async () => this.cinematic_shooting_done == true);
            Engine.camera_set(cam02, 0);
            Engine.camera_set(cam03, 90);
            await Engine.sleep_until(async () => Engine.unit_in_vehicle(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_01.Squad), 0))) == true);
            Engine.camera_set(cam04, 120);
            await Engine.sleep(90);
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(20);
            Engine.ai_erase(dervish_01.Squad);
            Engine.ai_erase(heretic_leader_04.Squad);
            Engine.device_operates_automatically_set(hl_ledge_ext.Entity, false);
            Engine.device_set_position_immediate(hl_ledge_ext.Entity, 0F);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(heretic_leader_04.Squad) == 0 && (short)Engine.ai_living_count(dervish_01.Squad) == 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task dogfight2_commander()
        {
            Engine.ai_dialogue_enable(false);
            await Engine.sleep(60);
            Engine.print("spec-ops commander: 'what lunacy! he'll never escape this maelstrom in a banshee!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "0790"));
            await Engine.sleep(30);
            Engine.print("spec-ops commander: 'wait! the hangar! there was a seraph fighter inside! arbiter, you know what to do!'");
            await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1410"));
            await Engine.sleep(30);
            Engine.ai_dialogue_enable(true);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task boost_test()
        {
            Engine.cs_vehicle_boost(true);
            Engine.cs_enable_targeting(true);
            Engine.cs_shoot(true);
            Engine.cs_enable_moving(true);
            await Engine.sleep_until(async () => Engine.objects_distance_to_object(Engine.players(), Engine.ai_get_object(this.ai_current_actor)) < 20F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task dogfight_secondtime_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_power_core_ledge, Engine.players()) == true);
            Engine.ai_disposable(power_core_flood, true);
            Engine.ai_disposable(power_core_sentinels, true);
            Engine.ai_disposable(power_core_heretics, true);
            await this.cinematic_fade_to_white();
            Engine.ai_erase_all();
            Engine.object_teleport(await this.player0(), player0_hide);
            Engine.object_teleport(await this.player1(), player1_hide);
            if (await this.cinematic_skip_start())
            {
                await this.banshee_sin_01();
            }

            await this.cinematic_skip_stop();
            await Engine.sleep(2);
            Engine.wake(plummet_killer);
            Engine.wake(plummet_fl);
            Engine.wake(plummet_nl);
            Engine.wake(plummet_fr);
            Engine.wake(plummet_nr);
            await Engine.sleep(5);
            if ((bool)Engine.game_is_cooperative())
            {
                Engine.object_destroy(player0_fake_banshee.Entity);
                Engine.object_destroy(player1_fake_banshee.Entity);
                Engine.object_destroy(hl_fake_banshee.Entity);
                Engine.object_teleport(await this.player0(), banshee_player0);
                Engine.object_teleport(await this.player1(), banshee_player1);
                Engine.ai_place(ledge_banshees_02.left);
                Engine.ai_place(ledge_banshees_02.right);
                Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.left), "banshee_d", await this.player1());
                Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d", await this.player0());
                Engine.physics_set_gravity(-4F);
                Engine.physics_set_velocity_frame(0F, 0F, 3F);
                Engine.wake(banshee_killer_00);
                Engine.wake(banshee_killer_01);
            }
            else
            {
                Engine.object_destroy(player0_fake_banshee.Entity);
                Engine.object_destroy(player1_fake_banshee.Entity);
                Engine.object_destroy(hl_fake_banshee.Entity);
                await Engine.sleep(2);
                Engine.object_teleport(await this.player0(), banshee_player0);
                await Engine.sleep(2);
                Engine.ai_place(ledge_banshees_02.right);
                await Engine.sleep(2);
                Engine.vehicle_load_magic(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d", await this.player0());
                await Engine.sleep(2);
                Engine.physics_set_gravity(-4F);
                Engine.physics_set_velocity_frame(0F, 0F, 3F);
                Engine.wake(banshee_killer_00);
            }

            Engine.device_operates_automatically_set(control_room_ext.Entity, false);
            Engine.device_operates_automatically_set(lab_exit_ext.Entity, false);
            Engine.device_operates_automatically_set(arm_02_entry_ext.Entity, false);
            Engine.ai_place(dogfighters_init.Squad, 2);
            Engine.activate_team_nav_point_flag(default_red, player, he_went_here, 0F);
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white();
            Engine.data_mine_set_mission_segment("04b_17_dogfight");
            Engine.game_save_immediate();
            Engine.wake(dogfight2_commander);
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if ((short)Engine.ai_living_count(dogfighters) < 2 && Engine.objects_can_see_flag(Engine.players(), dogfight_1, 45F) == false)
                    {
                        Engine.ai_place(dogfighters_finale._1);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(dogfighters) < 2 && Engine.objects_can_see_flag(Engine.players(), dogfight_2, 45F) == false)
                    {
                        Engine.ai_place(dogfighters_finale._2);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(dogfighters) < 2 && Engine.objects_can_see_flag(Engine.players(), dogfight_3, 45F) == false)
                    {
                        Engine.ai_place(dogfighters_finale._3);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(dogfighters) < 2 && Engine.objects_can_see_flag(Engine.players(), dogfight_4, 45F) == false)
                    {
                        Engine.ai_place(dogfighters_finale._4);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(dogfighters) < 2 && Engine.objects_can_see_flag(Engine.players(), dogfight_5, 45F) == false)
                    {
                        Engine.ai_place(dogfighters_finale._5);
                    }
                }, 
                    async () =>
                {
                    if ((short)Engine.ai_living_count(dogfighters) < 2 && Engine.objects_can_see_flag(Engine.players(), dogfight_6, 45F) == false)
                    {
                        Engine.ai_place(dogfighters_finale._6);
                    }
                });
                return Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true || (short)Engine.ai_spawn_count(dogfighters_finale.Squad) > 3;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task dervish_chase_02()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("airspace3/p7"));
            await Engine.sleep(15);
            Engine.object_create_anew(player_fake_banshee);
            Engine.object_damage_damage_section(player_fake_banshee.Entity, "main", 2F);
            Engine.ai_erase(dervish_02.Squad);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task dervish_recovery()
        {
            Engine.cs_enable_pathfinding_failsafe(true);
            Engine.cs_custom_animation(Engine.GetTag<AnimationGraphTag>("objects\\characters\\elite\\elite", 3908700036U), "climb:unarmed:detach", 0F, true);
            await Engine.sleep(Engine.unit_get_custom_animation_time(Engine.unit(Engine.ai_get_object(this.ai_current_actor))));
            Engine.unit_stop_custom_animation(Engine.unit(Engine.ai_get_object(this.ai_current_actor)));
            Engine.cs_crouch(true);
            Engine.cs_move_in_direction(0F, 0.5F, 0F);
            Engine.cs_go_to(Engine.GetReference<ISpatialPoint>("fake_cinematics/p2"));
            Engine.cs_face(true, Engine.GetReference<ISpatialPoint>("fake_cinematics/p3"));
            Engine.cs_crouch(false);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task banshee_sin_02_weapon()
        {
            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle.weapon", 3794927804U)) && this.banshee_sin_02_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0)), rifle, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine.weapon", 3828155063U)) && this.banshee_sin_02_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0)), carbine, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\rifle\\beam_rifle\\beam_rifle.weapon", 3838247761U)) && this.banshee_sin_02_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0)), sniper, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\pistol\\needler\\needler.weapon", 3847357404U)) && this.banshee_sin_02_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0)), needler, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol.weapon", 3815440885U)) && this.banshee_sin_02_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0)), pistol, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\weapons\\support_high\\flak_cannon\\flak_cannon.weapon", 3856663658U)) && this.banshee_sin_02_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0)), flak, true, true);
                this.banshee_sin_02_ready = true;
            }

            if (Engine.unit_has_weapon(Engine.unit(await this.player0()), Engine.GetTag<BaseTag>("objects\\characters\\sentinel_aggressor\\weapons\\beam\\sentinel_aggressor_beam.weapon", 3862693062U)) && this.banshee_sin_02_ready == false)
            {
                Engine.unit_add_equipment(Engine.unit(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0)), beam, true, true);
                this.banshee_sin_02_ready = true;
            }
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task banshee_sin_02()
        {
            Engine.camera_control(true);
            Engine.cinematic_start_movie("floodlab_banshee_2");
            Engine.cinematic_start();
            this.cinematic_letterbox_style = 1;
            Engine.camera_set_field_of_view(60F, 0);
            Engine.camera_set(end00, 0);
            Engine.device_set_position_immediate(banshee_ledge_access_01.Entity, 1F);
            Engine.object_create_containing("banshee_gas_0");
            Engine.ai_place(dervish_02.Squad);
            Engine.cs_run_command_script(dervish_02.Squad, dervish_chase_02);
            Engine.fade_in(1F, 1F, 1F, 15);
            Engine.camera_set(end01, 120);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(dervish_02.Squad) == 0);
            await Engine.sleep(60);
            Engine.ai_place(dervish_031.Squad);
            await this.banshee_sin_02_weapon();
            Engine.object_hide(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0), true);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0), dervish_sticks_landing);
            Engine.cs_run_command_script(dervish_031.Squad, dervish_recovery);
            await Engine.sleep(5);
            Engine.object_hide(Engine.list_get(Engine.ai_actors(dervish_031.Squad), 0), false);
            Engine.camera_set(end02, 60);
            await Engine.sleep(60);
            Engine.camera_set(end03, 60);
            await Engine.sleep(60);
            Engine.camera_set(end04, 60);
            await Engine.sleep(60);
            Engine.fade_out(1F, 1F, 1F, 15);
            await Engine.sleep(20);
            Engine.ai_erase(dervish_031.Squad);
            Engine.device_set_position_immediate(banshee_ledge_access_01.Entity, 0F);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_return_s_respawner()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_return_sentinels_03.Squad) < 2);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_sentinels_03.Squad, 1);
            }

            await Engine.sleep((short)Engine.random_range(5, 45));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_return_sentinels_03.Squad) < 2);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_sentinels_03.Squad, 1);
            }

            await Engine.sleep((short)Engine.random_range(5, 45));
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(bottling_return_sentinels_03.Squad) < 2);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_sentinels_03.Squad, 1);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_return_cf_respawner()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(bottling_return_combatforms_03.Squad) < 2);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_combatforms_04.Squad, 1);
            }

            await Engine.sleep((short)Engine.random_range(5, 45));
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(bottling_return_combatforms_03.Squad) < 2);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_combatforms_04.Squad, 1);
            }

            await Engine.sleep((short)Engine.random_range(5, 45));
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(bottling_return_combatforms_03.Squad) < 2);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_combatforms_04.Squad, 1);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_return_ca_respawner()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(bottling_return_carriers_03.Squad) < 1);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_carriers_04.Squad, 1);
            }

            await Engine.sleep((short)Engine.random_range(5, 45));
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(bottling_return_carriers_03.Squad) < 1);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_carriers_04.Squad, 1);
            }

            await Engine.sleep((short)Engine.random_range(5, 45));
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(bottling_return_carriers_03.Squad) < 1);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_carriers_04.Squad, 1);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_return_commander()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_enter, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_bottling_enter, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'the heretic-leader has already landed! up to the hangar, arbiter! quickly now!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1420"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_fx_01()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _175) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _174), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _175), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _176), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _177), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _178), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _179), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _180), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _181), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _182), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _183), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _184), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _174), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _175), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _176), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _177), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _178), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _179), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _180), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _181), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _182), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _183), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _184), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_fx_02()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _197) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _185), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _186), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _187), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _188), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _189), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _190), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _191), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _192), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _193), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _194), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _195), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _196), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _197), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _198), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _185), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _186), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _187), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _188), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _189), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _190), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _191), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _192), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _193), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _194), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _195), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _196), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _197), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _198), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_fx_03()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _201) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _199), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _200), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _201), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _202), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _203), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _204), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _205), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _206), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _207), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _208), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _209), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _210), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _211), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _212), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _199), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _200), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _201), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _202), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _203), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _204), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _205), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _206), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _207), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _208), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _209), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _210), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _211), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _212), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_fx_04()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _227) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _213), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _214), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _215), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _216), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _217), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _218), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _219), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _220), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _221), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _222), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _223), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _224), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _225), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _226), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _227), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _213), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _214), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _215), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _216), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _217), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _218), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _219), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _220), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _221), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _222), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _223), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _224), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _225), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _226), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _227), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_fx_05()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _242) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _228), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _229), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _230), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _231), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _232), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _233), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _234), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _235), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _236), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _237), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _238), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _239), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _240), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _241), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _242), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _228), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _229), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _230), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _231), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _232), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _233), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _234), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _235), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _236), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _237), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _238), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _239), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _240), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _241), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _242), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task panic_bottling()
        {
            Engine.cs_ignore_obstacles(true);
            Engine.cs_enable_moving(true);
            Engine.cs_movement_mode(3);
            await Engine.sleep_until(async () => Engine.volume_test_object(vol_bottling_enter, Engine.ai_get_object(this.ai_current_actor)) == true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task bottling_secondtime_start()
        {
            Engine.ai_disposable(dogfighters, true);
            await this.cinematic_fade_to_white();
            Engine.ai_erase_all();
            if ((bool)Engine.game_is_cooperative())
            {
                Engine.sleep_forever(banshee_killer_00);
                Engine.sleep_forever(banshee_killer_01);
                Engine.physics_set_gravity(1F);
                Engine.physics_set_velocity_frame(0F, 0F, 0F);
                Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d");
                Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.left), "banshee_d");
                Engine.object_teleport(await this.player0(), player0_hide);
                Engine.object_teleport(await this.player1(), player1_hide);
                Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.right));
                Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.left));
            }
            else
            {
                Engine.sleep_forever(banshee_killer_00);
                Engine.physics_set_gravity(1F);
                Engine.physics_set_velocity_frame(0F, 0F, 0F);
                Engine.vehicle_unload(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.right), "banshee_d");
                Engine.object_teleport(await this.player0(), player0_hide);
                Engine.object_destroy(Engine.ai_vehicle_get_from_starting_location(ledge_banshees_02.right));
            }

            if (await this.cinematic_skip_start())
            {
                await this.banshee_sin_02();
            }

            await this.cinematic_skip_stop();
            await Engine.sleep(2);
            Engine.device_operates_automatically_set(banshee_ledge_access_01.Entity, false);
            Engine.device_set_position_immediate(banshee_ledge_access_01.Entity, 0F);
            Engine.deactivate_team_nav_point_flag(player, he_went_here);
            Engine.object_destroy_containing("banshee_gas_0");
            Engine.object_teleport(await this.player0(), bottling_return_player0);
            Engine.object_teleport(await this.player1(), bottling_return_player1);
            Engine.wake(bottling_fx_01);
            Engine.wake(bottling_fx_02);
            Engine.wake(bottling_fx_03);
            Engine.wake(bottling_fx_04);
            Engine.wake(bottling_fx_05);
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white();
            Engine.data_mine_set_mission_segment("04b_18_bottling_return_01");
            Engine.game_save_immediate();
            Engine.wake(_04b_title2);
            Engine.ai_place(bottling_return_sentinels_01.Squad, 2);
            Engine.ai_place(bottling_return_flood_01.Squad, 4);
            Engine.wake(bottling_return_commander);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_return_01r, Engine.players()) == false && await this.player_count() > 0);
            Engine.ai_place(bait_bottling_01.Squad, 1);
            await Engine.sleep_until(async () => (short)Engine.ai_nonswarm_count(bottling_return_flood_01.Squad) < 2 || Engine.volume_test_objects(vol_bottling_return_02, Engine.players()) == true);
            Engine.game_save();
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_combatforms_02.Squad, (short)(3 - (float)Engine.ai_nonswarm_count(bottling_return_flood_01.Squad)));
            }

            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_carriers_02.Squad, 3);
            }

            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_mid03, Engine.players()) == true);
            Engine.data_mine_set_mission_segment("04b_19_bottling_return_02");
            Engine.game_save();
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_sentinels_02.Squad, 3);
            }

            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_combatforms_03.Squad, 3);
            }

            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bottling_return_carriers_03.Squad, 2);
            }

            Engine.wake(bottling_return_s_respawner);
            Engine.wake(bottling_return_cf_respawner);
            Engine.wake(bottling_return_ca_respawner);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_mid02, Engine.players()) == true);
            if ((short)Engine.ai_living_count(bottling_plant_enemies) < 8)
            {
                Engine.ai_place(bait_bottling_02.Squad, 1);
            }

            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 5 || (short)Engine.ai_nonswarm_count(bottling_return_flood) == 0 && (short)Engine.ai_nonswarm_count(bottling_return_flood) == 0);
            Engine.game_save();
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 5);
            Engine.sleep_forever(bottling_return_s_respawner);
            Engine.sleep_forever(bottling_return_cf_respawner);
            Engine.sleep_forever(bottling_return_ca_respawner);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halls_up_01()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _7) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _1), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _2), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _3), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _4), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _5), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _6), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _7), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _8), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _9), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _1), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _2), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _3), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _4), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _5), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _6), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _7), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _8), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _9), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halls_up_02()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _19) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _10), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _11), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _12), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _13), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _14), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _15), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _16), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _17), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _18), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _19), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _20), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _21), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _22), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _23), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _10), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _11), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _12), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _13), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _14), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _15), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _16), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _17), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _18), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _19), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _20), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _21), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _22), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _23), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halls_up_03()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _24) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _24), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _25), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _26), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _27), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _28), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _29), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _30), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _31), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _32), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _33), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _34), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _35), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _36), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _37), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _38), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _24), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _25), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _26), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _27), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _28), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _29), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _30), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _31), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _32), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _33), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _34), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _35), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _36), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _37), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _38), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halls_up_04()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _47) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _39), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _40), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _41), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _42), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _43), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _44), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _45), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _46), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _47), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _48), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _49), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _50), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _51), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _52), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _53), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _39), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _40), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _41), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _42), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _43), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _44), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _45), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _46), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _47), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _48), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _49), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _50), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _51), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _52), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _53), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halls_up_05()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _58) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _54), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _55), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _56), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _57), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _58), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _59), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _60), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _61), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _62), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _63), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _64), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _65), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _66), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _67), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _68), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _54), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _55), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _56), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _57), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _58), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _59), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _60), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _61), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _62), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _63), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _64), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _65), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _66), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _67), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _68), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halls_up_06()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _69) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _69), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _70), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _72), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _73), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _74), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _75), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _76), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _77), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _78), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _79), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _80), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _81), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _82), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _83), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _69), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _70), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _71), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _72), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _73), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _74), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _75), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _76), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _77), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _78), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _79), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _80), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _81), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _82), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _83), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _84), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task halls_up_07()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _85) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _85), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _86), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _87), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _88), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _89), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _90), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _92), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _93), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _94), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _95), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _96), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _98), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _99), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _100), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _85), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _86), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _87), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _88), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _89), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _90), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _91), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _92), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _93), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _94), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _95), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _96), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _97), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _98), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _99), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _100), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task panic_halls()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_movement_mode(3);
            await Engine.sleep_until(async () => Engine.volume_test_object(vol_bottling_enter, Engine.ai_get_object(this.ai_current_actor)) == true);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task to_underhangar_secondtime()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_bottling_enter, Engine.players()) == true);
            Engine.ai_disposable(bottling_return_flood, true);
            Engine.ai_disposable(bottling_return_sentinels, true);
            Engine.wake(music_04b_08_start);
            Engine.wake(halls_up_01);
            Engine.wake(halls_up_02);
            Engine.wake(halls_up_03);
            Engine.wake(halls_up_04);
            Engine.wake(halls_up_05);
            Engine.wake(halls_up_06);
            Engine.wake(halls_up_07);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 5);
            Engine.data_mine_set_mission_segment("04b_20_halls_to_under_01");
            Engine.game_save();
            Engine.ai_place(second_hall_infection_01.Squad, 4);
            Engine.ai_place(bait_hall_01.Squad, 1);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_2nd_hall_02, Engine.players()) == true, 30, 150);
                if ((short)Engine.ai_nonswarm_count(second_hall_flood) < 2 && Engine.device_get_position(hall2_spawn_01.Entity) == 0F && Engine.volume_test_objects(vol_hall2_spawn_01, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(second_hall_flood_01.Squad, 1);
                }

                return Engine.volume_test_objects(vol_2nd_hall_02, Engine.players()) == true || (short)Engine.ai_spawn_count(second_hall_flood_01.Squad) == 4;
            });
            Engine.data_mine_set_mission_segment("04b_21_halls_to_under_02");
            Engine.game_save();
            Engine.ai_place(second_hall_carriers.Squad, 2);
            Engine.ai_place(bait_hall_02.Squad, 1);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_2nd_hall_01, Engine.players()) == true, 30, 150);
                if ((short)Engine.ai_nonswarm_count(second_hall_flood) < 2 && Engine.device_get_position(hall2_spawn_02.Entity) == 0F && Engine.volume_test_objects(vol_hall2_spawn_02, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(second_hall_flood_02.Squad, 1);
                }

                return Engine.volume_test_objects(vol_2nd_hall_01, Engine.players()) == true || (short)Engine.ai_spawn_count(second_hall_flood_02.Squad) == 4;
            });
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_2nd_hall_01, Engine.players()) == true);
            Engine.wake(music_04b_08_start_alt);
            Engine.data_mine_set_mission_segment("04b_22_halls_to_under_03");
            Engine.game_save();
            Engine.ai_place(bait_hall_03.Squad, 1);
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_bottom, Engine.players()) == true, 30, 150);
                if ((short)Engine.ai_nonswarm_count(second_hall_flood) < 2 && Engine.device_get_position(hall2_spawn_03.Entity) == 0F && Engine.volume_test_objects(vol_hall2_spawn_03, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(second_hall_flood_03.Squad, 1);
                }

                return Engine.volume_test_objects(vol_underhangar_from_bottom, Engine.players()) == true || (short)Engine.ai_spawn_count(second_hall_flood_03.Squad) == 4;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task underhangar_fx_01()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _251) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _243), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _244), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _245), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _246), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _247), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _248), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _249), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _250), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _251), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _252), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _253), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _254), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _243), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _244), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _245), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _246), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _247), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _248), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _249), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _250), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _251), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _252), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _253), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _254), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task underhangar_fx_02()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _255) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _255), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _256), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _257), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _258), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _259), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _260), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _261), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _262), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _263), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _264), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _265), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _266), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _267), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _268), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _269), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _255), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _256), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _257), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _258), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _259), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _260), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _261), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _262), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _263), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _264), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _265), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _266), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _267), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _268), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _269), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task underhangar_return_commander()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_top, Engine.players()) == true, 30, 8000);
            if (Engine.volume_test_objects(vol_underhangar_from_top, Engine.players()) == false && await this.player_count() > 0)
            {
                Engine.ai_dialogue_enable(false);
                await Engine.sleep(60);
                Engine.print("spec-ops commander: 'you're almost there!  keep going!'");
                await Engine.sleep(Engine.ai_play_line_on_object(default(IGameObject), "1430"));
                await Engine.sleep(30);
                Engine.ai_dialogue_enable(true);
            }
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task underhangar_secondtime_start()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_bottom, Engine.players()) == true);
            Engine.ai_disposable(second_hall_flood, true);
            Engine.data_mine_set_mission_segment("04b_23_underhangar_return");
            Engine.game_save();
            Engine.wake(underhangar_return_commander);
            Engine.wake(underhangar_fx_01);
            Engine.wake(underhangar_fx_02);
            Engine.ai_place(underhangar_heretics_01.Squad, 1);
            Engine.ai_place(underhangar_h_grunts_01.Squad, 2);
            Engine.ai_place(underhangar_heretics_02.Squad, 1);
            Engine.ai_place(underhangar_heretics_03.Squad, 1);
            Engine.ai_place(underhangar_carriers_02.Squad, 1);
            Engine.ai_place(underhangar_carriers_init.Squad, 1);
            Engine.ai_place(underhangar_combatforms_init.Squad, 2);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_music, Engine.players()) == true);
            Engine.wake(music_04b_08_stop);
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_nonswarm_count(underhangar_carriers_02.Squad) < 1 && Engine.device_get_position(underhangar_spawn_02.Entity) == 0F && Engine.volume_test_objects(vol_underhangar_spawn_02, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(underhangar_carriers_02.Squad, 1);
                }

                if ((short)Engine.ai_nonswarm_count(underhangar_return_flood) < 2 && Engine.device_get_position(underhangar_spawn_01.Entity) == 0F && Engine.volume_test_objects(vol_underhangar_spawn_01, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(underhangar_return_flood_01.Squad, 1);
                }

                if ((short)Engine.ai_nonswarm_count(underhangar_return_flood) < 2 && Engine.volume_test_objects(vol_underhangar_shaft_01, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(underhangar_return_flood_02.Squad, 1);
                }

                if ((short)Engine.ai_nonswarm_count(underhangar_return_flood) < 2 && Engine.volume_test_objects(vol_underhangar_shaft_02, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(underhangar_return_flood_03.Squad, 1);
                }

                return Engine.volume_test_objects(vol_underhangar_return_01, Engine.players()) == true || (float)Engine.ai_strength(underhangar_heretics_01.Squad) <= 0.25F || (short)Engine.ai_spawn_count(underhangar_return_flood) == 20;
            });
            Engine.game_save();
            Engine.ai_place(underhangar_h_grunts_02.Squad, (short)(2 - (float)Engine.ai_living_count(underhangar_h_grunts_01.Squad)));
            await Engine.sleep_until(async () =>
            {
                if ((short)Engine.ai_nonswarm_count(underhangar_return_flood) < 2 && Engine.device_get_position(underhangar_spawn_02.Entity) == 0F && Engine.volume_test_objects(vol_underhangar_spawn_02, Engine.players()) == false && await this.player_count() > 0)
                {
                    Engine.ai_place(underhangar_return_flood_04.Squad, 1);
                }

                return Engine.volume_test_objects(vol_underhangar_return_02, Engine.players()) == true || (short)Engine.ai_living_count(underhangar_heretics_02.Squad) == 0 || (short)Engine.ai_spawn_count(underhangar_return_flood_04.Squad) == 20;
            });
            Engine.game_save();
            Engine.ai_place(underhangar_heretics_03.Squad, (short)(2 - (float)Engine.ai_living_count(underhangar_return_heretics)));
            Engine.ai_place(underhangar_h_grunts_03.Squad, (short)(2 - (float)Engine.ai_living_count(underhangar_h_grunts_02.Squad)));
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task other_hall_fx()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.objects_distance_to_flag(Engine.players(), _270) < 20F);
                Engine.begin_random(async () => Engine.effect_new(this.gasleak, _270), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _271), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _272), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _273), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _274), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _275), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _276), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _277), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _278), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _279), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _280), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _281), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _282), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _283), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.gasleak, _284), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _270), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _271), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _272), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _273), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _274), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _275), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _276), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _277), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _278), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _279), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _280), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _281), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _282), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _283), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
                    async () => Engine.effect_new(this.boom, _284), 
                    async () => await Engine.sleep((short)Engine.random_range(5, 30)));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task to_hangar_secondtime()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_underhangar_from_top, Engine.players()) == true);
            Engine.ai_disposable(underhangar_return_flood, true);
            Engine.ai_disposable(underhangar_return_heretics, true);
            Engine.wake(other_hall_fx);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task hangar_fx()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => Engine.begin_random(async () => Engine.effect_new(this.big_boom, _294), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _295), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _285), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _286), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _306), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _307), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _289), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _290), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _285), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _288), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _307), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _308), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30))), 
                    async () => Engine.begin_random(async () => Engine.effect_new(this.big_boom, _291), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _292), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _293), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _303), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _304), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _294), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _295), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _296), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _291), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _292), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _293), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _294), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30))), 
                    async () => Engine.begin_random(async () => Engine.effect_new(this.big_boom, _297), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _298), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _299), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _300), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _301), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _302), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _289), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _290), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _299), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _286), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _287), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _300), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30))), 
                    async () => Engine.begin_random(async () => Engine.effect_new(this.big_boom, _303), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _304), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _305), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _297), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _298), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _308), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _287), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.big_boom, _288), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _303), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _304), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _305), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30)), 
    async () => Engine.effect_new(this.boom, _306), 
    async () => await Engine.sleep((short)Engine.random_range(5, 30))));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hack()
        {
            Engine.cs_enable_moving(true);
            Engine.cs_set_behavior(guard);
            Engine.sleep_forever();
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hl_boss_chat_01()
        {
            this.boss_done_talking = false;
            await Engine.sleep_until(async () => this.monitor_done_talking == true);
            Engine.cs_suppress_dialogue_global(true);
            await Engine.sleep(60);
            Engine.print("heretic leader: 'how did the prophets buy your loyalty, arbiter?'");
            Engine.cs_play_line("0800");
            await Engine.sleep(15);
            Engine.print("heretic leader: 'with a new command? a new fleet?'");
            Engine.cs_play_line("0810");
            await Engine.sleep(30);
            Engine.print("heretic leader: 'or was it the promise? their great journey!'");
            Engine.cs_play_line("0820");
            Engine.cs_suppress_dialogue_global(false);
            this.boss_done_talking = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hl_boss_chat_02()
        {
            this.boss_done_talking = false;
            await Engine.sleep_until(async () => this.monitor_done_talking == true);
            Engine.cs_suppress_dialogue_global(true);
            await Engine.sleep(60);
            Engine.print("heretic leader: 'look around you, arbiter�'");
            Engine.cs_play_line("0830");
            await Engine.sleep(15);
            Engine.print("heretic leader: 'this facility, and dozens like it, devoted to the study of the parasite!'");
            Engine.cs_play_line("0840");
            await Engine.sleep(15);
            Engine.print("heretic leader: 'but where are the weapons, arbiter?  what was the result?'");
            Engine.cs_play_line("0850");
            await Engine.sleep(30);
            Engine.print("heretic leader: 'all that time and effort, and the best the forerunners could do was put these foul creatures on ice!'");
            Engine.cs_play_line("0860");
            Engine.cs_suppress_dialogue_global(false);
            this.boss_done_talking = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task hl_boss_chat_03()
        {
            this.boss_done_talking = false;
            await Engine.sleep_until(async () => this.monitor_done_talking == true);
            Engine.cs_suppress_dialogue_global(true);
            await Engine.sleep(60);
            Engine.print("heretic leader: 'and now, where are these gods the prophets would have us worship?'");
            Engine.cs_play_line("0870");
            await Engine.sleep(30);
            Engine.print("heretic leader: 'transcended? (laughs) hardly.'");
            Engine.cs_play_line("0880");
            await Engine.sleep(60);
            Engine.print("heretic leader: 'come, arbiter. let me show you where they went!'");
            Engine.cs_play_line("0890");
            Engine.cs_suppress_dialogue_global(false);
            this.boss_done_talking = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_chat_01()
        {
            this.monitor_available = false;
            this.monitor_done_talking = false;
            Engine.cs_suppress_dialogue_global(true);
            Engine.cs_switch("monitor");
            await Engine.sleep(60);
            Engine.cs_start_approach_player(3F, 50F, 50F);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            Engine.print("343 guilty spark: 'this mining-facility predates instalation alpha by several hundred years.'");
            Engine.cs_play_line("0900");
            Engine.print("343 guilty spark: 'it was retrofitted to research possible offensive and defensive measures against the flood.'");
            Engine.cs_play_line("0910");
            Engine.print("343 guilty spark: 'indeed, i designed and oversaw the construction of this facilitiy's various outbreak management systems.'");
            Engine.cs_play_line("0920");
            Engine.cs_approach_stop();
            Engine.cs_suppress_dialogue_global(false);
            this.monitor_done_talking = true;
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_chat_02()
        {
            this.monitor_available = false;
            this.monitor_done_talking = false;
            Engine.cs_suppress_dialogue_global(true);
            Engine.cs_switch("monitor");
            await Engine.sleep(60);
            Engine.cs_start_approach_player(3F, 50F, 50F);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            Engine.print("343 guilty spark: 'the tether connecting the mine to the high-altitude suspension-grid was the primary failsafe.'");
            Engine.cs_play_line("0930");
            Engine.print("343 guilty spark: 'i'm glad that someone was aware of the necessary protocols and severed the tether locally.'");
            Engine.cs_play_line("0940");
            Engine.cs_approach_stop();
            Engine.cs_suppress_dialogue_global(false);
            this.monitor_done_talking = true;
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_chat_03()
        {
            this.monitor_available = false;
            this.monitor_done_talking = false;
            Engine.cs_suppress_dialogue_global(true);
            Engine.cs_switch("monitor");
            await Engine.sleep(60);
            Engine.cs_start_approach_player(3F, 50F, 50F);
            Engine.cs_enable_moving(true);
            Engine.cs_enable_looking(true);
            Engine.print("343 guilty spark: 'the flood will not survive once this mine descends into the liquid hydrogen core of the planet.'");
            Engine.cs_play_line("0950");
            await Engine.sleep(15);
            Engine.print("343 guilty spark: 'then again, neither will we. what a pity.'");
            Engine.cs_play_line("0960");
            Engine.cs_approach_stop();
            Engine.cs_suppress_dialogue_global(false);
            this.monitor_done_talking = true;
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task monitor_chatting()
        {
            await Engine.sleep(1800);
            await Engine.sleep_until(async () => this.boss_done_talking == true);
            Engine.cs_run_command_script(monitor1.Squad, monitor_chat_01);
            await Engine.sleep_until(async () => this.monitor_done_talking == true);
            await Engine.sleep(3600);
            await Engine.sleep_until(async () => this.boss_done_talking == true);
            Engine.cs_run_command_script(monitor1.Squad, monitor_chat_02);
            await Engine.sleep_until(async () => this.monitor_done_talking == true);
            await Engine.sleep(3600);
            await Engine.sleep_until(async () => this.boss_done_talking == true);
            Engine.cs_run_command_script(monitor1.Squad, monitor_chat_03);
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_01()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p0"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_02()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p1"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_03()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p2"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_04()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p3"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_05()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p4"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_06()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p5"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_07()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p6"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_08()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p7"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_09()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p8"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_10()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p9"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_11()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p10"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_12()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p11"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_13()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p12"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_14()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p13"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_15()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p14"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_16()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p15"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_17()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p16"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_18()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p17"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_19()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p18"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.CommandScript)]
        public async Task monitor_flit_20()
        {
            Engine.cs_fly_to(Engine.GetReference<ISpatialPoint>("monitor_wander/p19"));
            this.monitor_available = true;
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task monitor_flitting()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_01);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_02);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_03);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_04);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_05);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_06);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_07);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_08);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_09);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_10);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_11);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_12);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_13);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_14);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_15);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_16);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_17);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_18);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_19);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                }, 
                    async () =>
                {
                    if (this.monitor_available == true)
                    {
                        Engine.cs_run_command_script(monitor1.Squad, monitor_flit_20);
                        await Engine.sleep(5);
                        await Engine.sleep_until(async () => this.monitor_available == true);
                    }
                });
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task boss_fight_deletion()
        {
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_boss_delete_r, Engine.ai_actors(hl_boss_random.Squad)) == true || Engine.volume_test_objects(vol_boss_delete_l, Engine.ai_actors(hl_boss_random.Squad)) == true || Engine.volume_test_objects(vol_boss_delete_c1, Engine.ai_actors(hl_boss_random.Squad)) == true || Engine.volume_test_objects(vol_boss_delete_c2, Engine.ai_actors(hl_boss_random.Squad)) == true, 30, 900);
            if (Engine.volume_test_objects(vol_boss_delete_r, Engine.ai_actors(hl_boss_random.Squad)) == false && Engine.volume_test_objects(vol_boss_delete_l, Engine.ai_actors(hl_boss_random.Squad)) == false && Engine.volume_test_objects(vol_boss_delete_c1, Engine.ai_actors(hl_boss_random.Squad)) == false && Engine.volume_test_objects(vol_boss_delete_c2, Engine.ai_actors(hl_boss_random.Squad)) == false)
            {
                Engine.effect_new_on_object_marker(Engine.GetTag<EffectTag>("effects\\scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\drone_death", 3919382567U), Engine.list_get(Engine.ai_actors(hl_boss_random.Squad), 0), "");
                Engine.object_set_scale(Engine.list_get(Engine.ai_actors(hl_boss_random.Squad), 0), 0.1F, 30);
                await Engine.sleep(30);
            }

            Engine.ai_erase(hl_boss_random.Squad);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task holo1_deleteme()
        {
            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => (short)Engine.ai_living_count(hl_boss_holo_random_01.Squad) == 0 || this.holo_drones_nuke == true);
                Engine.object_set_scale(this.holo1, 0.1F, 30);
                Engine.effect_new_on_object_marker(this.holo_death, this.holo1, "body");
                await Engine.sleep(15);
                Engine.object_destroy(this.holo1);
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task holo2_deleteme()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hl_boss_holo_random_01.Squad) == 1);
            Engine.object_set_scale(this.holo2, 0.1F, 30);
            Engine.effect_new_on_object_marker(this.holo_death, this.holo2, "body");
            await Engine.sleep(15);
            Engine.object_destroy(this.holo2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task holo3_deleteme()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hl_boss_holo_random_03.Squad) == 2);
            Engine.object_set_scale(this.holo3, 0.1F, 30);
            Engine.effect_new_on_object_marker(this.holo_death, this.holo3, "body");
            await Engine.sleep(15);
            Engine.object_destroy(this.holo3);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task holo4_deleteme()
        {
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hl_boss_holo_random_01.Squad) == 3);
            Engine.object_set_scale(this.holo4, 0.1F, 30);
            Engine.effect_new_on_object_marker(this.holo_death, this.holo4, "body");
            await Engine.sleep(15);
            Engine.object_destroy(this.holo4);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task hl_respawner()
        {
            if (await this.difficulty_legendary())
            {
                this.hl_lives_total = 3;
            }

            if (await this.difficulty_heroic())
            {
                this.hl_lives_total = 1;
            }

            await Engine.sleep_until(async () =>
            {
                await Engine.sleep_until(async () => Engine.object_get_shield(Engine.list_get(Engine.ai_actors(hl_boss_random.Squad), 0)) <= 0F);
                if (this.hl_times_dead < this.hl_lives_total)
                {
                    Engine.ai_set_orders(hl_boss_random.Squad, hole_up);
                    Engine.cs_run_command_script(hl_boss_random.Squad, hack);
                    Engine.ai_kill(holo_drones);
                    await this.boss_fight_deletion();
                    this.hl_times_dead = (short)(this.hl_times_dead + 1);
                    Engine.ai_place(hl_boss_random.Squad, 1);
                    Engine.ai_cannot_die(hl_boss_random.Squad, true);
                    this.heretic_leader = Engine.list_get(Engine.ai_actors(hl_boss_random.Squad), 0);
                    if (this.hl_times_dead == this.hl_lives_total)
                    {
                        Engine.ai_cannot_die(boss_fight_heretic_leader.Squad, false);
                    }
                    else
                    {
                        Engine.ai_cannot_die(boss_fight_heretic_leader.Squad, true);
                    }

                    if (this.hl_times_dead == 1)
                    {
                        Engine.cs_run_command_script(hl_boss_random.Squad, hl_boss_chat_01);
                    }

                    if (this.hl_times_dead == 2)
                    {
                        Engine.cs_run_command_script(hl_boss_random.Squad, hl_boss_chat_02);
                    }

                    if (this.hl_times_dead == 3)
                    {
                        Engine.cs_run_command_script(hl_boss_random.Squad, hl_boss_chat_03);
                    }

                    await Engine.sleep(60);
                    await Engine.sleep_until(async () => this.boss_done_talking == true);
                    Engine.game_save();
                    Engine.begin_random(async () =>
                    {
                        if ((short)Engine.ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            Engine.ai_place(hl_boss_holo_random_01.Squad, 1);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)Engine.ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            Engine.ai_place(hl_boss_holo_random_02.Squad, 1);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)Engine.ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            Engine.ai_place(hl_boss_holo_random_03.Squad, 1);
                        }
                    }, 
                        async () =>
                    {
                        if ((short)Engine.ai_living_count(holo_drones) < this.hl_drone_total)
                        {
                            Engine.ai_place(hl_boss_holo_random_04.Squad, 1);
                        }
                    });
                    this.hl_drone_total = (short)(this.hl_drone_total + 1);
                    Engine.ai_set_orders(hl_boss_random.Squad, boss_fight_hl_center);
                    Engine.ai_set_orders(hl_boss_holo_random_01.Squad, boss_fight_hl_center);
                    Engine.ai_set_orders(hl_boss_holo_random_02.Squad, boss_fight_hl_center);
                    Engine.ai_set_orders(hl_boss_holo_random_03.Squad, boss_fight_hl_center);
                    Engine.ai_set_orders(hl_boss_holo_random_04.Squad, boss_fight_hl_center);
                }

                return this.hl_times_dead == this.hl_lives_total;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task toys()
        {
            await Engine.sleep_until(async () =>
            {
                Engine.begin_random(async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy01), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy02), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy03), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy04), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy05), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy06), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy07), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy08), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy09), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy10), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy11), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy12), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy13), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy14), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy15), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy16), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy17), 
                    async () => await Engine.sleep(600), 
                    async () => Engine.object_create_anew(toy18));
                return false;
            });
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task hangar_secondtime_start()
        {
            await Engine.sleep_until(async () => this.plummeting == true && Engine.volume_test_objects(vol_hangar_reenter, Engine.players()) == true);
            Engine.device_operates_automatically_set(hangar_exit.Entity, true);
            Engine.ai_place(heretic_leader_hangar.Squad);
            Engine.cs_run_command_script(heretic_leader_hangar.Squad, long_pause);
            Engine.ai_cannot_die(heretic_leader_hangar.Squad, true);
            await Engine.sleep_until(async () => this.plummeting == true && Engine.volume_test_objects(vol_hangar_cutscene_start, Engine.players()) == true);
            await this.cinematic_fade_to_white();
            Engine.sleep_forever(other_hall_fx);
            Engine.sleep_forever(underhangar_fx_01);
            Engine.sleep_forever(underhangar_fx_02);
            Engine.sleep_forever(bottling_fx_01);
            Engine.sleep_forever(bottling_fx_02);
            Engine.sleep_forever(bottling_fx_03);
            Engine.sleep_forever(bottling_fx_04);
            Engine.sleep_forever(bottling_fx_05);
            Engine.sleep_forever(halls_up_01);
            Engine.sleep_forever(halls_up_02);
            Engine.sleep_forever(halls_up_03);
            Engine.sleep_forever(halls_up_04);
            Engine.sleep_forever(halls_up_05);
            Engine.sleep_forever(halls_up_06);
            Engine.sleep_forever(halls_up_07);
            Engine.ai_erase_all();
            Engine.object_teleport(await this.player0(), player0_hide2);
            Engine.object_teleport(await this.player1(), player1_hide2);
            if (await this.cinematic_skip_start())
            {
                await this.c04_outro1();
            }

            await this.cinematic_skip_stop();
            Engine.sound_suppress_ambience_update_on_revert();
            Engine.sound_class_set_gain("amb", 0F, 0);
            await Engine.sleep(1);
            Engine.sound_class_set_gain("amb", 1F, 15);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), player0_hangar);
            Engine.object_teleport(await this.player1(), player1_hangar);
            Engine.wake(hangar_fx);
            Engine.ai_place(monitor1.Squad);
            Engine.ai_place(boss_fight_heretic_leader.Squad);
            Engine.ai_migrate(boss_fight_heretic_leader.Squad, hl_boss_random.Squad);
            Engine.ai_cannot_die(hl_boss_random.Squad, true);
            Engine.ai_place(boss_fight_hl_hologram_01.Squad);
            Engine.ai_migrate(boss_fight_hl_hologram_01.Squad, hl_boss_holo_random_01.Squad);
            Engine.ai_place(boss_fight_hl_hologram_02.Squad);
            Engine.ai_migrate(boss_fight_hl_hologram_02.Squad, hl_boss_holo_random_02.Squad);
            Engine.device_operates_automatically_set(hangar_exit.Entity, false);
            Engine.wake(toys);
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            await this.cinematic_fade_from_white();
            Engine.wake(objective_dogfight_clear);
            Engine.wake(objective_hl_set);
            Engine.data_mine_set_mission_segment("04b_24_boss_fight_01");
            Engine.game_save_immediate();
            Engine.wake(monitor_chatting);
            Engine.wake(monitor_flitting);
            await this.hl_respawner();
            Engine.ai_cannot_die(hl_boss_random.Squad, false);
            await Engine.sleep_until(async () => (short)Engine.ai_living_count(hl_boss_random.Squad) == 0);
            this.final_hl_boss_dead = true;
            Engine.ai_kill_silent(holo_drones);
            this.holo_drones_nuke = true;
            await Engine.sleep(120);
            if (await this.player_count() <= 0)
            {
                Engine.sleep_forever();
            }

            await this.cinematic_fade_to_white();
            Engine.object_teleport(await this.player0(), player0_hide2);
            Engine.object_teleport(await this.player1(), player1_hide2);
            Engine.object_destroy(this.heretic_leader);
            Engine.ai_erase(monitor1.Squad);
            Engine.ai_kill_silent(all_enemies);
            if (await this.cinematic_skip_start())
            {
                await this.c04_outro2();
            }

            await this.cinematic_skip_stop();
            await Engine.sleep(2);
            await this.playtest_mission();
            await Engine.sleep(2);
            Engine.game_won();
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_intro()
        {
            Engine.sleep_forever(arm_02_entry_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_disposal()
        {
            Engine.sleep_forever(disposal_chamber_start);
            Engine.sleep_forever(disposal_infection_spawn);
            Engine.sleep_forever(spec_ops_reborn);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_silo()
        {
            Engine.sleep_forever(silo_start);
            Engine.sleep_forever(silo_hall_flood_spawner);
            Engine.sleep_forever(elev_go);
            Engine.sleep_forever(to_flood_lab);
            Engine.sleep_forever(silo_commander_reminder);
            Engine.sleep_forever(silo_killer);
            Engine.sleep_forever(silo_sentinel_spawner);
            Engine.sleep_forever(silo_flood_spawner);
            Engine.sleep_forever(silo_saving);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_lab()
        {
            Engine.sleep_forever(to_flood_lab);
            Engine.sleep_forever(flood_lab_start);
            Engine.sleep_forever(lab_barricades);
            Engine.sleep_forever(lab_wave_new_01);
            Engine.sleep_forever(lab_wave_new_02);
            Engine.sleep_forever(famine_flavor);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_wraparound()
        {
            Engine.sleep_forever(bridge_start);
            Engine.sleep_forever(bridge_phantom_arrives);
            Engine.sleep_forever(bridge_reminder);
            Engine.sleep_forever(wraparound_right);
            Engine.sleep_forever(wraparound_left);
            Engine.sleep_forever(research_arm_bsp_swap);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_control()
        {
            Engine.sleep_forever(control_room_start);
            Engine.sleep_forever(control_commander_reminder);
            Engine.sleep_forever(control_bug_out);
            Engine.sleep_forever(control_flood_spawn);
            Engine.sleep_forever(wind);
            Engine.sleep_forever(hologram_toggle);
            Engine.sleep_forever(hl_killer);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_cableroom()
        {
            Engine.sleep_forever(cable_room_start);
            Engine.sleep_forever(cable_a_health);
            Engine.sleep_forever(cable_b_health);
            Engine.sleep_forever(cable_c_health);
            Engine.sleep_forever(cable_nav_a);
            Engine.sleep_forever(cable_nav_b);
            Engine.sleep_forever(cable_nav_c);
            Engine.sleep_forever(cable_sentinel_spawner);
            Engine.sleep_forever(cable_flood_spawner);
            Engine.sleep_forever(grav_test);
            Engine.sleep_forever(cable_invulnerable);
            Engine.sleep_forever(cableroom_suck_killer);
            Engine.sleep_forever(cableroom_junk_spawn);
            Engine.sleep_forever(cableroom_commander_reminder);
            Engine.sleep_forever(cableroom_killer);
            Engine.sleep_forever(cableroom_junk_killer);
            Engine.sleep_forever(croom_exit);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_control_return()
        {
            Engine.sleep_forever(control_room_return);
            Engine.sleep_forever(control_return_flood_spawn);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_powercore()
        {
            Engine.sleep_forever(power_core_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_dogfight()
        {
            Engine.sleep_forever(dogfight_secondtime_start);
            Engine.sleep_forever(banshee_killer_00);
            Engine.sleep_forever(banshee_killer_01);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_bottling_return()
        {
            Engine.sleep_forever(bottling_secondtime_start);
            Engine.sleep_forever(bottling_return_s_respawner);
            Engine.sleep_forever(bottling_return_cf_respawner);
            Engine.sleep_forever(bottling_return_ca_respawner);
            Engine.sleep_forever(to_underhangar_secondtime);
            Engine.sleep_forever(bottling_return_commander);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task sleep_underhangar_return()
        {
            Engine.sleep_forever(underhangar_secondtime_start);
            Engine.sleep_forever(to_hangar_secondtime);
            Engine.sleep_forever(underhangar_return_commander);
        }

        [ScriptMethod(Lifecycle.Startup)]
        public async Task mission()
        {
            await this.cinematic_snap_to_white();
            if (Engine.volume_test_objects(vol_arm_02_lz, Engine.players()) == true)
            {
                Engine.sound_suppress_ambience_update_on_revert();
                if (await this.cinematic_skip_start())
                {
                    await this.c04_intra0();
                }

                await this.cinematic_skip_stop();
            }

            await Engine.sleep(2);
            Engine.switch_bsp(3);
            await Engine.sleep(2);
            Engine.ai_allegiance(player, covenant);
            Engine.ai_allegiance(heretic, sentinel);
            Engine.ai_allegiance(player, prophet);
            Engine.ai_allegiance(heretic, prophet);
            Engine.ai_allegiance(sentinel, prophet);
            Engine.objectives_clear();
            await this.prep_return_from_intro();
            Engine.camera_control(false);
            await Engine.sleep(1);
            await Engine.cache_block_for_one_frame();
            await Engine.sleep(1);
            Engine.wake(_04b_title0);
            Engine.wake(objective_labs_set);
            Engine.wake(kill_volumes);
            Engine.wake(arm_02_entry_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_disposal_enter, Engine.players()) == true);
            Engine.wake(disposal_chamber_start);
            Engine.wake(silo_start);
            Engine.wake(to_flood_lab);
            Engine.wake(flood_lab_start);
            await this.sleep_intro();
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(bridge_start);
            Engine.wake(control_room_start);
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            Engine.wake(objective_labs_clear);
            Engine.wake(objective_control_set);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.wake(cable_room_start);
            await this.sleep_wraparound();
            await this.sleep_control();
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.wake(control_room_return);
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await this.sleep_cableroom();
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true, 1);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
            await this.sleep_control_return();
            await this.sleep_powercore();
            await this.sleep_dogfight();
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_intra0_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 62, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 63, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3873637741U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3875014018U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\alphagasgiant", 3783000070U), 9);
            await Engine.sleep(9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 61, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 20);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 22);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 24);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("incompetent\\default_object", 3881436644U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 5);
            await Engine.sleep(145);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            await Engine.sleep(45);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, false);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 5);
            await Engine.sleep(21);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, false);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            await Engine.sleep(11);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 11, true);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 60, false);
            await Engine.sleep(99);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 63, false);
            await Engine.sleep(31);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            await Engine.sleep(120);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 60, false);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_intra1_01_predict()
        {
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 63, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 67, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 51, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 54, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3883402754U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\fp\\fp", 3883402754U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\fp_energy_blade\\fp_energy_blade", 3794272434U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\fp_energy_blade\\fp_energy_blade", 3794272434U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 15);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\grunt\\grunt", 3879667145U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\plasma_pistol\\plasma_pistol", 3815571959U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 45, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 86, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 84, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 39, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg_containment_shield\\door_tron_lg_containment_shield", 3883730439U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\central_chamber\\generator_a\\generator_a", 3884516883U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886220845U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886220845U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3886482993U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3873637741U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 42, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\edge_trim\\platform_plates_a\\platform_plates_a", 3887334974U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\control_lift_up\\control_lift_up", 3887400511U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3889759843U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_small02\\holo_small02", 3890021991U), 0);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 1);
            await Engine.sleep(71);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 81, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 37, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_intra1_02_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 30, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 36, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 39, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886220845U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3886482993U), 1);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 25);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 30);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 27);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite", 3875341703U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(36);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 13, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 32, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 41, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 29, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\central_chamber\\generator_a\\generator_a", 3884516883U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_lg\\door_tron_lg", 3873637741U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_small02\\holo_small02", 3890021991U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3889759843U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3886482993U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\control_lift_up\\control_lift_up", 3887400511U), 0);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 33, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 34, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 42, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\edge_trim\\platform_plates_a\\platform_plates_a", 3887334974U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            await Engine.sleep(42);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            await Engine.sleep(101);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 86, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 64, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 81, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 37, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(144);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 6, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 35, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 38, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 40, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04a_gasgiant\\alphagasgiant"), 56, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\gasgiant_hologram\\gasgiant_hologram", 3886482993U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\holo_panels\\holo_generic\\holo_generic", 3889759843U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\wall_insertions\\channel_curcuit_a\\channel_curcuit_a", 3886220845U), 2);
            await Engine.sleep(146);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_outro1_01_predict()
        {
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 57, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3890611824U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3890939509U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\cinematics\\cinematic_anchor\\cinematic_anchor", 3875014018U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\skies\\solo\\alphagasgiant\\gasgiant_rob", 3785621550U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            await Engine.sleep(18);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 1);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            await Engine.sleep(35);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await Engine.sleep(33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(16);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            await Engine.sleep(6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            await Engine.sleep(32);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 22, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 42, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3890611824U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            await Engine.sleep(40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            await Engine.sleep(38);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            await Engine.sleep(6);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(45);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            await Engine.sleep(40);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            await Engine.sleep(48);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_outro1_02_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            await Engine.sleep(113);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            await Engine.sleep(39);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            await Engine.sleep(33);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 22, false);
            await Engine.sleep(81);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3890611824U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            await Engine.sleep(280);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            await Engine.sleep(23);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 1);
            await Engine.sleep(42);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(25);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3890611824U), 0);
            await Engine.sleep(15);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            await Engine.sleep(8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            await Engine.sleep(44);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            await Engine.sleep(5);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            await Engine.sleep(7);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\hanger_lift\\hanger_lift", 3891988101U), 0);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 1);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3890611824U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            await Engine.sleep(1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 0);
            await Engine.sleep(9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(52);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_outro1_03_predict()
        {
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            await Engine.sleep(92);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 30, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3890611824U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3892053638U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3890939509U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            await Engine.sleep(90);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            await Engine.sleep(12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3892053638U), 0);
            await Engine.sleep(32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            await Engine.sleep(32);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            await Engine.sleep(12);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            await Engine.sleep(14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3892512397U), 0);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            await Engine.sleep(1);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            await Engine.sleep(3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            await Engine.sleep(21);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            await Engine.sleep(59);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 1);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 1);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            await Engine.sleep(17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 1);
            await Engine.sleep(10);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar_scenery\\door_cargo_hangar_scenery", 3890611824U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\solo\\alphagasgiant\\holo_drone\\holo_drone", 3892053638U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3890939509U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3892512397U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 0);
            await Engine.sleep(47);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            await Engine.sleep(7);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 3);
            await Engine.sleep(56);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await Engine.sleep(44);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            await Engine.sleep(174);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_outro2_01_predict()
        {
            await Engine.sleep(2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_cargo_hangar\\door_cargo_hangar", 3892709008U), 0);
            await Engine.sleep(5);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            await Engine.sleep(54);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            await Engine.sleep(70);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 32, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 33, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 3);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\controls\\temp_door_switch\\temp_door_switch", 3887466048U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await Engine.sleep(53);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            await Engine.sleep(156);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            await Engine.sleep(89);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
        }

        [ScriptMethod(Lifecycle.Dormant)]
        public async Task _04_outro2_02_predict()
        {
            await Engine.sleep(3);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 29, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 23, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 2, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 3, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3890939509U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3892512397U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await Engine.sleep(2);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            await Engine.sleep(9);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 33, false);
            await Engine.sleep(8);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 32, false);
            await Engine.sleep(4);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            await Engine.sleep(10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 0);
            await Engine.sleep(4);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3893495452U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3893495452U), 7);
            await Engine.sleep(17);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3895658173U), 0);
            await Engine.sleep(90);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 57, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 34, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 31, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 16, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 8, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 35, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 17, false);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 0, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 5, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 6, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 11, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 12, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 13, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 19, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 20, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 21, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 1, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 4, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 7, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 9, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 10, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 14, true);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 15, true);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 9);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\heretic\\heretic", 3888121418U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\elite\\elite_jetpack\\elite_jetpack", 3888776788U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 8);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\dervish\\dervish", 3881633255U), 10);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\grenade\\plasma_grenade\\plasma_grenade", 3890087528U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\pistol\\needler\\needler", 3847488478U), 1);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\plasma_rifle\\plasma_rifle", 3795058878U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\rifle\\covenant_carbine\\covenant_carbine", 3828286137U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\forerunner\\industrial\\doors\\door_tron_sm\\door_tron_sm", 3887007289U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("scenarios\\objects\\vehicles\\c_seraph\\c_seraph", 3890939509U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\cinematics\\texture_camera\\texture_camera", 3892512397U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\support_low\\sentinel_gun\\sentinel_gun", 3862824136U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\energy_blade\\energy_blade", 3786342457U), 1);
            await Engine.sleep(56);
            Engine.predict_structure_section(Engine.GetReference<IBsp>("scenarios\\solo\\04b_floodlab\\production_arm2"), 27, false);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 26);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 29);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 35);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 36);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 37);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 33);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\brute\\brute", 3893560989U), 34);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\characters\\monitor\\monitor", 3891332731U), 2);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\weapons\\melee\\gravity_hammer\\gravity_hammer", 3895658173U), 0);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 12);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 13);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 14);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 19);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\phantom", 3892905619U), 16);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3893495452U), 6);
            Engine.predict_model_section(Engine.GetTag<RenderModelTag>("objects\\vehicles\\phantom\\turrets\\chin_gun\\chin_gun", 3893495452U), 7);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_silo()
        {
            Engine.switch_bsp(3);
            Engine.object_teleport(await this.player0(), silo_player0);
            Engine.object_teleport(await this.player1(), silo_player1);
            Engine.ai_place(allies_elites_03a.Squad, 1);
            Engine.ai_place(allies_elites_03b.Squad, 1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_03a.Squad), 0), silo_ally01);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_03b.Squad), 0), silo_ally02);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            Engine.wake(silo_start);
            Engine.wake(to_flood_lab);
            Engine.wake(flood_lab_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(bridge_start);
            Engine.wake(control_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.wake(cable_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.wake(control_room_return);
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_lab()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(3);
            Engine.object_teleport(await this.player0(), lab_player0);
            Engine.object_teleport(await this.player1(), lab_player1);
            Engine.ai_place(allies_elites_03a.Squad, 1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_03a.Squad), 0), lab_ally01);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            Engine.wake(to_flood_lab);
            Engine.wake(flood_lab_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 0);
            Engine.wake(bridge_start);
            Engine.wake(control_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.wake(cable_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.wake(control_room_return);
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_wraparound()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(0);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), wraparound_player0);
            Engine.object_teleport(await this.player1(), wraparound_player1);
            Engine.ai_place(allies_elites_03a.Squad, 1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_03a.Squad), 0), wraparound_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            Engine.wake(bridge_start);
            Engine.wake(control_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.wake(cable_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.wake(control_room_return);
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_control()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(0);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), control_entry_player0);
            Engine.object_teleport(await this.player1(), control_entry_player1);
            Engine.ai_place(allies_elites_04.Squad, 1);
            Engine.ai_place(allies_grunts_04.Squad, 1);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_elites_04.Squad), 0), control_ally01);
            Engine.object_teleport(Engine.list_get(Engine.ai_actors(allies_grunts_04.Squad), 0), control_ally02);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            Engine.wake(control_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 2);
            Engine.wake(cable_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.wake(control_room_return);
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_cableroom()
        {
            Engine.ai_erase_all();
            Engine.switch_bsp(2);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), cableroom_player0);
            Engine.object_teleport(await this.player1(), cableroom_player1);
            Engine.device_set_position_immediate(elev_control_up.Entity, 1F);
            Engine.device_set_power(control_up_switch_02.Entity, 0F);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            Engine.wake(cable_room_start);
            await Engine.sleep_until(async () => (short)Engine.structure_bsp_index() == 1);
            Engine.wake(control_room_return);
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_plummet()
        {
            Engine.ai_erase_all();
            this.plummeting = true;
            Engine.switch_bsp(1);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), after_plummet_player0);
            Engine.object_teleport(await this.player1(), after_plummet_player1);
            Engine.device_set_position_immediate(control_shield_door.Entity, 1F);
            Engine.device_set_position_immediate(shield.Entity, 1F);
            Engine.device_set_position_immediate(elev_control_up.Entity, 0F);
            Engine.device_set_power(control_up_switch_01.Entity, 0F);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            Engine.wake(control_room_return);
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_powercore()
        {
            Engine.ai_erase_all();
            this.plummeting = true;
            Engine.switch_bsp(1);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), powercore_player0);
            Engine.object_teleport(await this.player1(), powercore_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            await this.sleep_control_return();
            Engine.wake(power_core_start);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_banshee()
        {
            Engine.ai_erase_all();
            this.plummeting = true;
            Engine.switch_bsp(1);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), banshee_player0);
            Engine.object_teleport(await this.player1(), banshee_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            await this.sleep_control_return();
            await this.sleep_powercore();
            Engine.device_operates_automatically_set(hl_ledge_ext.Entity, true);
            Engine.object_create(player0_fake_banshee);
            Engine.object_create(player1_fake_banshee);
            Engine.object_create(hl_fake_banshee);
            Engine.object_cannot_take_damage(player0_fake_banshee.Entity);
            Engine.object_cannot_take_damage(player1_fake_banshee.Entity);
            Engine.object_cannot_take_damage(hl_fake_banshee.Entity);
            Engine.wake(dogfight_secondtime_start);
            await Engine.sleep_until(async () => Engine.volume_test_objects(vol_arm_01_return, Engine.players()) == true);
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_bottling_return()
        {
            Engine.ai_erase_all();
            this.plummeting = true;
            Engine.switch_bsp(1);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), bottling_return_player0);
            Engine.object_teleport(await this.player1(), bottling_return_player1);
            Engine.device_operates_automatically_set(viewroom_exit01_bsp0.Entity, true);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            await this.sleep_control_return();
            await this.sleep_powercore();
            await this.sleep_dogfight();
            Engine.wake(bottling_secondtime_start);
            Engine.wake(to_underhangar_secondtime);
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_underhangar_return()
        {
            Engine.ai_erase_all();
            this.plummeting = true;
            Engine.switch_bsp(5);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), underhangar_return_player0);
            Engine.object_teleport(await this.player1(), underhangar_return_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            await this.sleep_control_return();
            await this.sleep_powercore();
            await this.sleep_dogfight();
            await this.sleep_bottling_return();
            Engine.wake(underhangar_secondtime_start);
            Engine.wake(to_hangar_secondtime);
            Engine.wake(hangar_secondtime_start);
        }

        [ScriptMethod(Lifecycle.Static)]
        public async Task teleport_boss()
        {
            Engine.ai_erase_all();
            this.plummeting = true;
            Engine.switch_bsp(5);
            await Engine.sleep(2);
            Engine.object_teleport(await this.player0(), boss_player0);
            Engine.object_teleport(await this.player1(), boss_player1);
            Engine.sleep_forever(mission);
            await this.sleep_intro();
            await this.sleep_disposal();
            await this.sleep_silo();
            await this.sleep_lab();
            await this.sleep_wraparound();
            await this.sleep_control();
            await this.sleep_cableroom();
            await this.sleep_control_return();
            await this.sleep_powercore();
            await this.sleep_dogfight();
            await this.sleep_bottling_return();
            await this.sleep_underhangar_return();
            Engine.wake(hangar_secondtime_start);
        }
    }
}